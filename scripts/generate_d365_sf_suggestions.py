#!/usr/bin/env python3
"""
generate_d365_sf_suggestions.py

Step 7 of the pipeline. Run steps 1-6 first.

Generates SF field suggestions for D365 fields flagged with sfSuggestedMapping=true.
Uses a 5-tier matching algorithm against salesforce-entities/*.json schemas.
Writes suggestions to d365-entities JSON (source of truth).
CSV generation is handled by Step 8.

Matching tiers:
  1. Exact match (existing SF field by name)
  2. Fuzzy match (SequenceMatcher, data-type-aware, strips prefixes/underscores)
  3. Synonym match (known D365-to-SF field name equivalences)
  4. Rule-based name generation (D365 display name -> SF Pascal_Case__c)
  5. Anthropic API fallback (for cryptic field names)

Suggestions are persisted in d365-entities/*.json. Existing suggestions are
preserved unless the user manually clears them from the JSON.

Usage:
    python generate_d365_sf_suggestions.py <entity>
    python generate_d365_sf_suggestions.py --all
"""

import csv
import difflib
import json
import os
import re
import ssl
import sys
import argparse
import urllib.request
from collections import defaultdict, OrderedDict

from pipeline_shared import (
    convert_keys_to_snake,
    adapt_json_fields,
    count_field_references,
)

PROJECT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
DEFAULT_MAPPING_DIR = os.path.join(PROJECT_DIR, "mapping")
SF_ENTITIES_DIR = os.path.join(PROJECT_DIR, "salesforce-entities")
DEFAULT_D365_DIR = os.path.join(PROJECT_DIR, "d365-entities")
MATRIX_PATH = os.path.join(PROJECT_DIR, "DataTypeCompatibilityMatrix.md")
SETTINGS_PATH = os.path.join(PROJECT_DIR, ".claude", "settings.local.json")

# JSON keys for sfSuggested fields stored in d365-entities/*.json
SF_SUGGESTED_JSON_KEYS = [
    "sfSuggestedObjectName",
    "sfSuggestedFieldDisplayName",
    "sfSuggestedFieldApiName",
    "sfSuggestedDataType",
    "sfSuggestedMatchTier",
]

# Known D365 -> SF field name synonyms
SYNONYMS = {
    'createdon': 'CreatedDate',
    'modifiedon': 'LastModifiedDate',
    'createdby': 'CreatedById',
    'modifiedby': 'LastModifiedById',
    'ownerid': 'OwnerId',
    'owninguser': 'OwnerId',
    'owningteam': 'OwnerId',
    'statecode': 'Status',
    'statuscode': 'StatusCode',
    'name': 'Name',
    'description': 'Description',
    'emailaddress1': 'Email',
    'emailaddress2': 'Secondary_Email__c',
    'telephone1': 'Phone',
    'telephone2': 'OtherPhone',
    'telephone3': 'AssistantPhone',
    'fax': 'Fax',
    'websiteurl': 'Website',
    'address1_line1': 'BillingStreet',
    'address1_city': 'BillingCity',
    'address1_stateorprovince': 'BillingState',
    'address1_postalcode': 'BillingPostalCode',
    'address1_country': 'BillingCountry',
    'address2_line1': 'ShippingStreet',
    'address2_city': 'ShippingCity',
    'address2_stateorprovince': 'ShippingState',
    'address2_postalcode': 'ShippingPostalCode',
    'address2_country': 'ShippingCountry',
    'parentaccountid': 'ParentId',
    'parentcontactid': 'ReportsToId',
    'transactioncurrencyid': 'CurrencyIsoCode',
    'exchangerate': 'CurrencyIsoCode',
    'jobtitle': 'Title',
    'firstname': 'FirstName',
    'lastname': 'LastName',
    'fullname': 'Name',
    'middlename': 'MiddleName',
    'suffix': 'Suffix',
    'salutation': 'Salutation',
    'birthdate': 'Birthdate',
    'annualrevenue': 'AnnualRevenue',
    'numberofemployees': 'NumberOfEmployees',
    'revenue': 'Amount',
    'subject': 'Subject',
    'regardingobjectid': 'WhatId',
    'prioritycode': 'Priority',
    'scheduledstart': 'ActivityDate',
    'scheduledend': 'EndDateTime',
    'actualstart': 'ActivityDate',
    'actualend': 'EndDateTime',
}

# SF reserved words that cannot be used as field names
SF_RESERVED_WORDS = {
    'id', 'name', 'type', 'owner', 'status', 'createddate', 'lastmodifieddate',
    'systemmodstamp', 'isdeleted', 'createdbyid', 'lastmodifiedbyid',
}


# ---------------------------------------------------------------------------
# DATA TYPE COMPATIBILITY
# ---------------------------------------------------------------------------

def load_compatibility_matrix(matrix_path):
    """Parse DataTypeCompatibilityMatrix.md into a dict.

    Returns {d365_type_lower: [sf_type1, sf_type2, ...]}.
    First SF type is preferred.
    """
    compat = {}
    if not os.path.isfile(matrix_path):
        print(f"  WARNING: {matrix_path} not found, using empty compatibility matrix")
        return compat

    with open(matrix_path, 'r', encoding='utf-8') as f:
        in_table = False
        for line in f:
            line = line.strip()
            if line.startswith('|') and '---' in line:
                in_table = True
                continue
            if in_table and line.startswith('|'):
                parts = [p.strip() for p in line.split('|')]
                parts = [p for p in parts if p]
                if len(parts) >= 2:
                    d365_type = parts[0].lower().strip()
                    sf_types = [t.strip().lower() for t in parts[1].split(',')]
                    compat[d365_type] = sf_types
    return compat


def is_type_compatible(d365_type, sf_type, compat_matrix):
    """Check if a D365 data type is compatible with an SF data type."""
    if not d365_type or not sf_type:
        return True  # Unknown types are considered compatible
    compatible = compat_matrix.get(d365_type.lower(), [])
    return sf_type.lower() in compatible


def preferred_sf_type(d365_type, compat_matrix):
    """Return the preferred SF data type for a D365 type."""
    compatible = compat_matrix.get(d365_type.lower(), [])
    return compatible[0] if compatible else 'string'


# ---------------------------------------------------------------------------
# NAME NORMALIZATION
# ---------------------------------------------------------------------------

def normalize_name(name):
    """Strip prefixes, underscores, spaces, and lowercase for fuzzy comparison."""
    name = name.lower()
    # Strip common prefixes
    for prefix in ('azt_', 'ezt_', 'new_', 'mscrm_'):
        if name.startswith(prefix):
            name = name[len(prefix):]
    # Strip SF suffix
    if name.endswith('__c'):
        name = name[:-3]
    # Remove underscores and spaces
    name = name.replace('_', '').replace(' ', '')
    return name


def display_name_to_sf_api(display_name, entity_name=''):
    """Convert a D365 display name to SF custom field API name.

    Examples:
        'Annual Spend' -> 'Annual_Spend__c'
        'Account Alert' -> 'Account_Alert__c'
        'Comp Goal Type' -> 'Comp_Goal_Type__c'
    """
    if not display_name:
        return ''
    # Clean: remove special chars except spaces
    clean = re.sub(r'[^a-zA-Z0-9\s]', '', display_name).strip()
    if not clean:
        return ''
    # Title case each word, join with underscores
    words = clean.split()
    api_name = '_'.join(w.capitalize() for w in words if w)
    # Ensure doesn't start with a number
    if api_name and api_name[0].isdigit():
        api_name = 'X_' + api_name
    # Truncate to 40 chars (SF limit)
    if len(api_name) > 37:  # Leave room for __c
        api_name = api_name[:37]
    api_name += '__c'
    return api_name


# ---------------------------------------------------------------------------
# SF ENTITY HELPERS
# ---------------------------------------------------------------------------

def build_sf_entity_index(sf_entities_dir):
    """Scan salesforce-entities/*.json and build {objectName_lower: objectName}."""
    index = {}
    if not os.path.isdir(sf_entities_dir):
        return index
    for fname in os.listdir(sf_entities_dir):
        if not fname.endswith('.json'):
            continue
        fpath = os.path.join(sf_entities_dir, fname)
        try:
            with open(fpath, 'r', encoding='utf-8') as f:
                data = json.load(f)
            obj_name = data.get('objectName', '')
            if obj_name:
                index[obj_name.lower()] = obj_name
        except (json.JSONDecodeError, IOError):
            continue
    return index


def load_sf_entity_fields(sf_entities_dir, sf_object_name):
    """Load SF entity JSON fields for a given object."""
    if not os.path.isdir(sf_entities_dir):
        return []
    fname = sf_object_name.lower() + '.json'
    fpath = os.path.join(sf_entities_dir, fname)
    if not os.path.isfile(fpath):
        return []
    try:
        with open(fpath, 'r', encoding='utf-8') as f:
            data = json.load(f)
        return data.get('fields', [])
    except (json.JSONDecodeError, IOError):
        return []


def build_sf_field_lookup(sf_fields):
    """Build lookup dicts from an SF entity's field list.

    Returns (by_name_lower, all_names_lower).
    """
    by_name_lower = {}
    for sf_field in sf_fields:
        fn = sf_field.get('fieldName', '')
        if fn:
            by_name_lower[fn.lower()] = sf_field
    all_names_lower = set(by_name_lower.keys())
    return by_name_lower, all_names_lower


def resolve_sf_object(entity_name, mapping_dir, sf_entity_index):
    """Determine the SF object name for a D365 entity."""
    csv_path = os.path.join(mapping_dir, f"{entity_name}.csv")
    if os.path.isfile(csv_path):
        obj_counts = defaultdict(int)
        with open(csv_path, "r", encoding="utf-8") as f:
            reader = csv.DictReader(f)
            for row in reader:
                for col in ("sfObjectName", "sfSuggestedObjectName"):
                    val = (row.get(col, "") or "").strip()
                    if val:
                        obj_counts[val] += 1
        if obj_counts:
            return max(obj_counts, key=obj_counts.get)

    if entity_name in sf_entity_index:
        return sf_entity_index[entity_name]

    return ''


# ---------------------------------------------------------------------------
# 5-TIER MATCHING ENGINE
# ---------------------------------------------------------------------------

def tier1_exact_match(d365_field_name, d365_type, sf_fields_lookup, compat_matrix):
    """Tier 1: Exact name match against existing SF fields.

    Checks SF fieldName for exact match.
    """
    by_name_lower, _ = sf_fields_lookup
    key = d365_field_name.lower()

    sf_field = by_name_lower.get(key)
    if sf_field:
        sf_type = sf_field.get('dataType', '')
        if is_type_compatible(d365_type, sf_type, compat_matrix):
            fn = sf_field.get('fieldName', '')
            display = sf_field.get('displayName', '') or fn
            return display, fn, sf_type, 'exact'
    return None


def tier2_fuzzy_match(d365_field_name, d365_type, sf_fields, compat_matrix):
    """Tier 2: Fuzzy name match with data-type awareness.

    Normalizes names (strips prefixes, underscores, spaces), uses SequenceMatcher.
    Score = name_similarity * type_weight. Accepts >= 0.65.
    """
    d365_norm = normalize_name(d365_field_name)
    if len(d365_norm) < 3:
        return None

    best_score = 0.0
    best_field = None

    for sf_field in sf_fields:
        sf_name = sf_field.get('fieldName', '')
        if not sf_name:
            continue
        sf_norm = normalize_name(sf_name)
        if len(sf_norm) < 3:
            continue

        name_sim = difflib.SequenceMatcher(None, d365_norm, sf_norm).ratio()
        sf_type = sf_field.get('dataType', '')
        type_weight = 1.0 if is_type_compatible(d365_type, sf_type, compat_matrix) else 0.3
        score = name_sim * type_weight

        if score > best_score:
            best_score = score
            best_field = sf_field

    if best_score >= 0.65 and best_field:
        fn = best_field.get('fieldName', '')
        display = best_field.get('displayName', '') or fn
        sf_type = best_field.get('dataType', '')
        return display, fn, sf_type, 'fuzzy'
    return None


def tier3_synonym_match(d365_field_name, d365_type, by_name_lower, compat_matrix):
    """Tier 3: Known D365-to-SF synonym lookup."""
    key = d365_field_name.lower()
    sf_name = SYNONYMS.get(key)
    if not sf_name:
        return None

    sf_field = by_name_lower.get(sf_name.lower())
    if sf_field:
        sf_type = sf_field.get('dataType', '')
        if is_type_compatible(d365_type, sf_type, compat_matrix):
            fn = sf_field.get('fieldName', '')
            display = sf_field.get('displayName', '') or fn
            return display, fn, sf_type, 'synonym'
    return None


def tier4_rule_based(d365_field_name, d365_display_name, d365_type,
                     existing_sf_names, compat_matrix):
    """Tier 4: Generate a new SF field name from the D365 display name."""
    api_name = display_name_to_sf_api(d365_display_name)
    if not api_name:
        # Fallback: use schema name
        clean = d365_field_name.lower()
        for prefix in ('azt_', 'ezt_', 'new_'):
            if clean.startswith(prefix):
                clean = clean[len(prefix):]
        words = re.split(r'[_\s]+', clean)
        api_name = '_'.join(w.capitalize() for w in words if w)
        if api_name and api_name[0].isdigit():
            api_name = 'X_' + api_name
        if len(api_name) > 37:
            api_name = api_name[:37]
        api_name += '__c'

    if not api_name or api_name == '__c':
        return None

    # Check uniqueness
    base = api_name
    if api_name.lower() in existing_sf_names or api_name[:-3].lower() in SF_RESERVED_WORDS:
        # Append a qualifier
        api_name = base[:-3] + '_CRM__c'
        if api_name.lower() in existing_sf_names:
            return None  # Give up, let Tier 5 handle

    display_name = api_name[:-3].replace('_', ' ')
    sf_type = preferred_sf_type(d365_type, compat_matrix)
    return display_name, api_name, sf_type, 'generated'


# ---------------------------------------------------------------------------
# TIER 5: ANTHROPIC API FALLBACK
# ---------------------------------------------------------------------------

def load_anthropic_api_key():
    """Load Anthropic API key from .claude/settings.local.json."""
    if not os.path.isfile(SETTINGS_PATH):
        return None
    try:
        with open(SETTINGS_PATH, 'r', encoding='utf-8') as f:
            settings = json.load(f)
        return settings.get('ANTHROPIC_API_KEY')
    except (json.JSONDecodeError, IOError):
        return None


def tier5_anthropic_batch(fields_needing_ai, entity_name, sf_object_name,
                          existing_sf_names, compat_matrix, api_key):
    """Tier 5: Call Anthropic API to generate SF field names for cryptic fields.

    Processes fields in batches of up to 20. Returns dict of
    {field_name_lower: (display, api_name, sf_type, 'ai')}.
    """
    if not api_key or not fields_needing_ai:
        return {}

    results = {}
    batch_size = 20

    for batch_start in range(0, len(fields_needing_ai), batch_size):
        batch = fields_needing_ai[batch_start:batch_start + batch_size]

        field_list = '\n'.join(
            f"- {f['schema_name']} (displayName: {f.get('display_name', '')}, "
            f"dataType: {f.get('data_type', '')})"
            for f in batch
        )

        prompt = f"""You are a Salesforce architect. Generate custom field API names for these D365 fields being migrated to Salesforce object "{sf_object_name}".

D365 Entity: {entity_name}
Fields needing SF names:
{field_list}

Rules:
- Use Salesforce custom field naming convention: Pascal_Case_Words__c
- Max 40 characters total (including __c suffix)
- Names must be descriptive and follow SF best practices
- Consider the D365 display name and data type for context
- Do NOT use these existing field names: {', '.join(sorted(existing_sf_names)[:50])}

Respond with ONLY a JSON array, one object per field:
[{{"d365FieldName": "...", "sfDisplayName": "...", "sfApiName": "...__c"}}]"""

        try:
            body = json.dumps({
                "model": "claude-sonnet-4-20250514",
                "max_tokens": 2000,
                "messages": [{"role": "user", "content": prompt}],
            }).encode('utf-8')

            req = urllib.request.Request(
                "https://api.anthropic.com/v1/messages",
                data=body,
                headers={
                    "Content-Type": "application/json",
                    "x-api-key": api_key,
                    "anthropic-version": "2023-06-01",
                },
                method="POST",
            )

            ctx = ssl.create_default_context()
            with urllib.request.urlopen(req, context=ctx, timeout=60) as resp:
                response = json.loads(resp.read().decode('utf-8'))

            content = response.get('content', [{}])[0].get('text', '')
            # Extract JSON array from response
            match = re.search(r'\[.*\]', content, re.DOTALL)
            if match:
                suggestions = json.loads(match.group())
                for sug in suggestions:
                    d365_name = sug.get('d365FieldName', '').lower()
                    sf_display = sug.get('sfDisplayName', '')
                    sf_api = sug.get('sfApiName', '')
                    if d365_name and sf_display and sf_api:
                        # Find the D365 type for preferred SF type
                        field = next((f for f in batch
                                      if f['schema_name'].lower() == d365_name), None)
                        d365_type = field.get('data_type', '') if field else ''
                        sf_type = preferred_sf_type(d365_type, compat_matrix)
                        results[d365_name] = (sf_display, sf_api, sf_type, 'ai')

        except Exception as e:
            print(f"    Anthropic API error: {e}")
            continue

    return results


# ---------------------------------------------------------------------------
# SUGGESTION ENGINE
# ---------------------------------------------------------------------------

def generate_suggestions(entity_name, fields, sf_object, sf_fields,
                         sf_fields_lookup, compat_matrix, api_key):
    """Run 5-tier matching for all fields needing suggestions.

    Returns dict of {field_name_lower: {sfSuggested* fields}}.
    """
    by_name_lower, all_names_lower = sf_fields_lookup
    suggestions = {}
    fields_for_ai = []
    tier_counts = defaultdict(int)

    for field in fields:
        sn = field['schema_name']
        sn_lower = sn.lower()
        d365_type = field.get('data_type', '')
        d365_display = field.get('display_name', '')

        # Tier 1: Exact match
        result = tier1_exact_match(sn, d365_type, sf_fields_lookup, compat_matrix)

        # Tier 2: Fuzzy match
        if not result:
            result = tier2_fuzzy_match(sn, d365_type, sf_fields, compat_matrix)

        # Tier 3: Synonym match
        if not result:
            result = tier3_synonym_match(sn, d365_type, by_name_lower, compat_matrix)

        # Tier 4: Rule-based generation
        if not result:
            result = tier4_rule_based(sn, d365_display, d365_type,
                                      all_names_lower, compat_matrix)

        if result:
            sf_display, sf_api, sf_type, tier = result
            suggestions[sn_lower] = {
                'sfSuggestedObjectName': sf_object,
                'sfSuggestedFieldDisplayName': sf_display,
                'sfSuggestedFieldApiName': sf_api,
                'sfSuggestedDataType': sf_type,
                'sfSuggestedMatchTier': tier,
            }
            tier_counts[tier] += 1
        else:
            fields_for_ai.append(field)

    # Tier 5: Anthropic API for remaining fields
    if fields_for_ai and api_key and sf_object:
        print(f"    Tier 5: calling Anthropic API for {len(fields_for_ai)} fields...")
        ai_results = tier5_anthropic_batch(
            fields_for_ai, entity_name, sf_object,
            all_names_lower, compat_matrix, api_key
        )
        for sn_lower, (sf_display, sf_api, sf_type, tier) in ai_results.items():
            suggestions[sn_lower] = {
                'sfSuggestedObjectName': sf_object,
                'sfSuggestedFieldDisplayName': sf_display,
                'sfSuggestedFieldApiName': sf_api,
                'sfSuggestedDataType': sf_type,
                'sfSuggestedMatchTier': tier,
            }
            tier_counts['ai'] += 1

    return suggestions, tier_counts


# ---------------------------------------------------------------------------
# MAIN PROCESSING
# ---------------------------------------------------------------------------

def process_entity(entity_name, mapping_dir, sf_entity_index, d365_entities_dir,
                   compat_matrix, api_key=None):
    """Load enriched JSON, compute SF suggestions, write to JSON and CSV."""
    entity_name = entity_name.lower()

    print(f"\nProcessing {entity_name.upper()}...")
    print("-" * 40)

    # 1. Load d365-entities/{entity}.json (preserving key order)
    json_path = os.path.join(d365_entities_dir, f"{entity_name}.json")
    if not os.path.isfile(json_path):
        print(f"  ERROR: JSON not found: {json_path}")
        return None

    with open(json_path, 'r', encoding='utf-8') as f:
        entity_data = json.load(f, object_pairs_hook=OrderedDict)

    raw_fields = entity_data.get('fields', [])

    # 2. Convert for reference counting
    sections = entity_data.get('sections', {})
    forms = convert_keys_to_snake(sections.get('forms', []))
    views = convert_keys_to_snake(sections.get('views', []))
    chart_visualizations = convert_keys_to_snake(sections.get('chartVisualizations', []))
    reports = convert_keys_to_snake(sections.get('reports', []))
    dashboards = convert_keys_to_snake(sections.get('dashboards', []))
    workflows = convert_keys_to_snake(sections.get('workflows', []))
    formulas = convert_keys_to_snake(sections.get('formulas', []))
    plugin_refs = convert_keys_to_snake(sections.get('plugins', []))
    controls = convert_keys_to_snake(sections.get('pcfControls', []))
    relationships = convert_keys_to_snake(sections.get('relationships', []))
    ribbon = convert_keys_to_snake(sections.get('ribbon', {'custom_actions': [], 'commands': []}))
    conflicts = convert_keys_to_snake(sections.get('conflicts', {}))

    fields = adapt_json_fields(raw_fields)

    field_ref_counts = count_field_references(
        entity_name, forms, views, chart_visualizations,
        reports, dashboards, workflows, formulas,
        plugin_refs, controls, relationships, ribbon, conflicts
    )

    # 3. Check which fields already have suggestions or need new ones
    existing_suggestions = {}
    fields_needing_suggestions = []
    preserved = 0

    for i, raw_field in enumerate(raw_fields):
        fn_lower = raw_field.get('fieldName', '').lower()

        # Skip fields not flagged for mapping (set by Step 6)
        if not raw_field.get('sfSuggestedMapping', False):
            continue

        has_existing = (
            raw_field.get('sfSuggestedObjectName') and
            raw_field.get('sfSuggestedFieldDisplayName') and
            raw_field.get('sfSuggestedFieldApiName')
        )
        if has_existing:
            existing_suggestions[fn_lower] = {
                'sfSuggestedObjectName': raw_field.get('sfSuggestedObjectName', ''),
                'sfSuggestedFieldDisplayName': raw_field.get('sfSuggestedFieldDisplayName', ''),
                'sfSuggestedFieldApiName': raw_field.get('sfSuggestedFieldApiName', ''),
                'sfSuggestedDataType': raw_field.get('sfSuggestedDataType', ''),
                'sfSuggestedMatchTier': raw_field.get('sfSuggestedMatchTier', ''),
            }
            preserved += 1
        else:
            if i < len(fields) and fields[i]:
                fields_needing_suggestions.append(fields[i])

    if preserved:
        print(f"  Preserved existing suggestions: {preserved}")

    # 4. Resolve SF object and generate new suggestions
    sf_object = resolve_sf_object(entity_name, mapping_dir, sf_entity_index)
    new_suggestions = {}
    tier_counts = {}

    if fields_needing_suggestions and sf_object:
        sf_fields = load_sf_entity_fields(SF_ENTITIES_DIR, sf_object)
        sf_fields_lookup = build_sf_field_lookup(sf_fields)

        new_suggestions, tier_counts = generate_suggestions(
            entity_name, fields_needing_suggestions, sf_object,
            sf_fields, sf_fields_lookup, compat_matrix, api_key
        )

    # 5. Merge: existing + new suggestions
    all_suggestions = {**existing_suggestions, **new_suggestions}

    # 6. Write suggestions back to d365-entities JSON
    json_modified = False
    for raw_field in raw_fields:
        # Never overwrite manual entries
        if raw_field.get('sfSuggestedMatchTier') == 'manual':
            continue

        fn_lower = raw_field.get('fieldName', '').lower()
        sug = all_suggestions.get(fn_lower)
        if sug:
            for key in SF_SUGGESTED_JSON_KEYS:
                raw_field[key] = sug.get(key) or None
                json_modified = True
        else:
            # Ensure keys exist as null
            for key in SF_SUGGESTED_JSON_KEYS:
                if key not in raw_field:
                    raw_field[key] = None
                    json_modified = True

    if json_modified:
        with open(json_path, 'w', encoding='utf-8') as f:
            json.dump(entity_data, f, indent=2, ensure_ascii=False)
            f.write('\n')

    # Summary
    print(f"  Fields: {len(fields)}")
    print(f"  SF object: {sf_object or '(none)'}")
    if tier_counts:
        for tier, count in sorted(tier_counts.items()):
            print(f"    Tier {tier}: {count} matches")
    print(f"  New suggestions: {len(new_suggestions)}")
    print(f"  Total with suggestions: {len(all_suggestions)}")

    return tier_counts


def main():
    parser = argparse.ArgumentParser(
        description='Step 7: Generate SF field suggestions via 5-tier matching'
    )
    parser.add_argument('entity', nargs='?', default=None,
                        help='Target entity schema name (e.g., account, contact)')
    parser.add_argument('--all', action='store_true',
                        help='Update mapping CSVs for all entities')
    parser.add_argument('--mapping-dir', default=DEFAULT_MAPPING_DIR,
                        help='Directory containing SF mapping CSVs (default: mapping/)')
    parser.add_argument('--d365-entities-dir', default=DEFAULT_D365_DIR,
                        help='Directory containing enriched D365 entity JSONs')
    args = parser.parse_args()

    if not args.all and not args.entity:
        parser.error('either provide an entity name or use --all')

    mapping_dir = args.mapping_dir
    d365_dir = args.d365_entities_dir

    print("=" * 60)
    print("D365CE SF Suggestion Engine (5-Tier Matching)")
    print("=" * 60)
    print()

    # Load compatibility matrix
    print("  Loading data type compatibility matrix...")
    compat_matrix = load_compatibility_matrix(MATRIX_PATH)
    print(f"    D365 types mapped: {len(compat_matrix)}")

    # Load Anthropic API key (optional)
    api_key = load_anthropic_api_key()
    if api_key:
        print("  Anthropic API key: loaded (Tier 5 enabled)")
    else:
        print("  Anthropic API key: not found (Tier 5 disabled)")

    # Build SF entity index
    print("  Building SF entity index...")
    sf_entity_index = build_sf_entity_index(SF_ENTITIES_DIR)
    print(f"    SF objects: {len(sf_entity_index)}")

    total_tier_counts = defaultdict(int)

    if args.all:
        entities = sorted(f[:-5] for f in os.listdir(d365_dir) if f.endswith('.json'))
        print(f"\nDiscovered {len(entities)} entities in {d365_dir}.")
        success = 0
        for entity_name in entities:
            result = process_entity(entity_name, mapping_dir,
                                    sf_entity_index=sf_entity_index,
                                    d365_entities_dir=d365_dir,
                                    compat_matrix=compat_matrix,
                                    api_key=api_key)
            if result is not None:
                for tier, count in result.items():
                    total_tier_counts[tier] += count
                success += 1
        print()
        print("=" * 60)
        print(f"Update complete! {success}/{len(entities)} entities processed.")
        if total_tier_counts:
            total = sum(total_tier_counts.values())
            print(f"  Total suggestions: {total}")
            for tier, count in sorted(total_tier_counts.items()):
                print(f"    {tier}: {count}")
        print("=" * 60)
    else:
        entity_name = args.entity.lower()
        result = process_entity(entity_name, mapping_dir,
                                sf_entity_index=sf_entity_index,
                                d365_entities_dir=d365_dir,
                                compat_matrix=compat_matrix,
                                api_key=api_key)
        if result is None:
            sys.exit(1)
        print()
        print("=" * 60)
        print("Update complete!")
        if result:
            total = sum(result.values())
            print(f"  Total suggestions: {total}")
            for tier, count in sorted(result.items()):
                print(f"    {tier}: {count}")
        print("=" * 60)


if __name__ == '__main__':
    main()
