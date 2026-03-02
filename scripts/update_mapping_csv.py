#!/usr/bin/env python3
"""
update_mapping_csv.py

Reads enriched D365 entity JSON from d365-entities/, loads SF entity data
from salesforce-entities/, and updates mapping CSVs with SF suggestions
and reference counts.

This is Step 4a of the pipeline. Run Steps 1-3 first.

Usage:
    python update_mapping_csv.py <entity> [--mapping-dir <path>]
    python update_mapping_csv.py --all
"""

import csv
import json
import re
import os
import sys
import argparse
from collections import defaultdict

PROJECT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
DEFAULT_MAPPING_DIR = os.path.join(PROJECT_DIR, "mapping")
SF_ENTITIES_DIR = os.path.join(PROJECT_DIR, "salesforce-entities")
DEFAULT_D365_DIR = os.path.join(PROJECT_DIR, "d365-entities")

SF_COLUMNS = [
    "sfObjectName",
    "sfFieldDisplayName",
    "sfFieldApiName",
    "sfSuggestedObjectName",
    "sfSuggestedFieldDisplayName",
    "sfSuggestedFieldApiName",
]

D365_COLUMNS = ["displayName", "dataType", "requiredLevel", "isCustom"]
REPORT_COLUMNS = ["picklistValues", "mappingSuggested"]

# Reference count columns: CSV header -> count_field_references key
REF_COUNT_COLUMNS = [
    ("refForms", "forms"),
    ("refViews", "views"),
    ("refChartVisualizations", "charts"),
    ("refReports", "reports"),
    ("refDashboards", "dashboards"),
    ("refWorkflows", "workflows"),
    ("refFormulas", "formulas"),
    ("refPlugins", "plugins"),
    ("refPcfControls", "pcf"),
    ("refRelationships", "rels"),
    ("refRibbon", "ribbon"),
]

CSV_COLUMNS = (D365_COLUMNS + REPORT_COLUMNS
               + [col for col, _ in REF_COUNT_COLUMNS] + SF_COLUMNS)


# ---------------------------------------------------------------------------
# camelCase -> snake_case conversion
# ---------------------------------------------------------------------------

def camel_to_snake(name):
    """Convert camelCase to snake_case: 'formType' -> 'form_type'."""
    return re.sub(r'([A-Z])', r'_\1', name).lower().lstrip('_')


# Keys whose values are dicts with data identifiers as keys (not schema keys).
_DATA_DICT_KEYS = frozenset({'field_refs', 'func_fields'})


def convert_keys_to_snake(obj, _parent_key=None):
    """Recursively convert all dict keys from camelCase to snake_case.

    Dicts under keys in _DATA_DICT_KEYS preserve their keys (data identifiers)
    while still converting their nested values.
    """
    if isinstance(obj, dict):
        if _parent_key in _DATA_DICT_KEYS:
            return {k: convert_keys_to_snake(v) for k, v in obj.items()}
        return {
            camel_to_snake(k): convert_keys_to_snake(v, _parent_key=camel_to_snake(k))
            for k, v in obj.items()
        }
    if isinstance(obj, list):
        return [convert_keys_to_snake(item, _parent_key=_parent_key) for item in obj]
    return obj


def adapt_json_fields(json_fields):
    """Convert enriched JSON field dicts to the parse-output key format."""
    return [{
        'schema_name': jf.get('fieldName', ''),
        'display_name': jf.get('displayName', ''),
        'description': jf.get('description', ''),
        'data_type': jf.get('dataType', ''),
        'required_level': jf.get('requiredLevel', 'none'),
        'is_custom': jf.get('isCustom', False),
        'introduced_version': jf.get('introducedVersion', ''),
        'max_length': jf.get('maxLength'),
        'is_audit_enabled': jf.get('auditEnabled', False),
        'is_secured': jf.get('fieldSecurity', False),
        'picklist_values': jf.get('picklistValues') or [],
    } for jf in json_fields]


# ---------------------------------------------------------------------------
# SECTION REFERENCE COUNTING
# ---------------------------------------------------------------------------

def count_field_references(entity_name, forms, views, chart_visualizations,
                           reports, dashboards, workflows, formulas,
                           plugin_refs, controls, relationships, ribbon, conflicts):
    """Pre-compute per-field reference counts for each report section.

    Returns a defaultdict mapping field_name_lower -> {section_key: count}.
    """
    counts = defaultdict(lambda: defaultdict(int))

    for form in forms:
        for hf in form['header_fields']:
            counts[hf['name'].lower()]['forms'] += 1
        for tab in form['tabs']:
            for section in tab['sections']:
                for field in section['fields']:
                    if not field['is_subgrid'] and not field['is_webresource']:
                        counts[field['name'].lower()]['forms'] += 1
        for ff in form['footer_fields']:
            counts[ff['name'].lower()]['forms'] += 1

    for view in views:
        for col in view['columns']:
            counts[col['name'].lower()]['views'] += 1
        for ff in view['filter_fields']:
            counts[ff['field'].lower()]['views'] += 1
        for sf in view['sort_fields']:
            counts[sf['field'].lower()]['views'] += 1

    for chart in chart_visualizations:
        for mf in chart['measure_fields']:
            counts[mf['field'].lower()]['charts'] += 1
        for gf in chart['groupby_fields']:
            counts[gf['field'].lower()]['charts'] += 1
        for ff in chart['filter_fields']:
            counts[ff['field'].lower()]['charts'] += 1
        for sf in chart['sort_fields']:
            counts[sf['field'].lower()]['charts'] += 1

    def count_report_link_entities(link_list):
        for le in link_list:
            for attr in le['attributes']:
                counts[attr.lower()]['reports'] += 1
            for cond in le['conditions']:
                counts[cond['field'].lower()]['reports'] += 1
            for order in le['orders']:
                counts[order['field'].lower()]['reports'] += 1
            if le['nested_links']:
                count_report_link_entities(le['nested_links'])

    for rpt in reports:
        for ds in rpt['datasets']:
            for fd in ds['fetchxml_data']:
                for attr in fd['attributes']:
                    counts[attr.lower()]['reports'] += 1
                for cond in fd['conditions']:
                    counts[cond['field'].lower()]['reports'] += 1
                for order in fd['orders']:
                    counts[order['field'].lower()]['reports'] += 1
                count_report_link_entities(fd['link_entities'])

    for wf in workflows:
        for fn in wf['fields_read']:
            counts[fn.lower()]['workflows'] += 1
        for fn in wf['fields_written']:
            counts[fn.lower()]['workflows'] += 1

    for formula in formulas:
        counts[formula['field'].lower()]['formulas'] += 1
        for sf in formula['source_fields']:
            counts[sf['field'].lower()]['formulas'] += 1

    for plugin in plugin_refs:
        for fn in plugin['fields_read']:
            counts[fn.lower()]['plugins'] += 1
        for fn in plugin['fields_written']:
            counts[fn.lower()]['plugins'] += 1
        for fn in plugin['fields_filtered']:
            counts[fn.lower()]['plugins'] += 1
        for fn in plugin['fields_sorted']:
            counts[fn.lower()]['plugins'] += 1
        for fn in plugin['fields_joined']:
            counts[fn.lower()]['plugins'] += 1
        for fn in plugin['image_fields']:
            counts[fn.lower()]['plugins'] += 1

    for ctrl in controls:
        for prop in ctrl['bound_properties']:
            if prop['name']:
                counts[prop['name'].lower()]['pcf'] += 1

    for rel in relationships:
        if rel['referencing_attribute']:
            counts[rel['referencing_attribute'].lower()]['rels'] += 1

    return counts


# ---------------------------------------------------------------------------
# SF MAPPING
# ---------------------------------------------------------------------------

def load_mapping_csv(mapping_dir, entity_name):
    """Load SF mapping data from a CSV file into a dict keyed by fieldName.

    Returns {field_name_lower: {sfObjectName: ..., ...}} or empty dict.
    """
    csv_path = os.path.join(mapping_dir, f"{entity_name}.csv")
    if not os.path.isfile(csv_path):
        return {}

    mapping = {}
    with open(csv_path, "r", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        for row in reader:
            field_name = row.get("fieldName", "").lower()
            if field_name:
                mapping[field_name] = {
                    col: row.get(col, "") or "" for col in CSV_COLUMNS
                }
    return mapping


def build_sf_entity_index(sf_entities_dir):
    """Scan salesforce-entities/*.json and build {objectName_lower: objectName}.

    Returns dict mapping lowercase object name to its canonical casing.
    """
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
    """Load the SF entity JSON for a given object and return its fields.

    Returns list of field dicts from the JSON, or empty list.
    """
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


def resolve_sf_object(entity_name, mapping_dir, sf_entity_index):
    """Determine the SF object name for a D365 entity (data-driven only).

    1. From existing CSV data -- most common sfObjectName or sfSuggestedObjectName
    2. From SF entity JSON index -- match D365 entity name to SF objectName
    3. No match -- returns ''
    """
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


def build_sf_field_lookup(sf_fields):
    """Build lookup dicts from an SF entity's field list.

    Returns (by_d365_internal, by_d365_suggested, by_name_lower).
    """
    by_d365_internal = {}
    by_d365_suggested = {}
    by_name_lower = {}
    for sf_field in sf_fields:
        fn = sf_field.get('fieldName', '')
        if fn:
            by_name_lower[fn.lower()] = sf_field
        d365_int = sf_field.get('d365InternalName') or ''
        if d365_int:
            by_d365_internal[d365_int.lower()] = sf_field
        d365_sug = sf_field.get('d365SuggestedInternalName') or ''
        if d365_sug:
            by_d365_suggested[d365_sug.lower()] = sf_field
    return by_d365_internal, by_d365_suggested, by_name_lower


def match_sf_field(d365_schema_name, by_d365_internal, by_d365_suggested, by_name_lower):
    """Find the best-matching SF field for a D365 field.

    Resolution order:
    1. Confirmed mapping: d365InternalName matches D365 schema_name
    2. Suggested mapping: d365SuggestedInternalName matches D365 schema_name
    3. Exact name match: SF fieldName matches D365 schema_name (case-insensitive)
    4. No match

    Returns (sf_field_display_name, sf_field_api_name) or ('', '').
    """
    key = d365_schema_name.lower()
    sf_field = by_d365_internal.get(key) or by_d365_suggested.get(key) or by_name_lower.get(key)
    if sf_field:
        fn = sf_field.get('fieldName', '')
        return fn, fn
    return '', ''


def write_mapping_csv(mapping_dir, entity_name, fields, sf_mapping,
                      field_mapping_suggested, field_ref_counts=None):
    """Write one row per D365 field to the mapping CSV.

    Includes D365 metadata, report columns, reference counts, and SF mapping.
    Every field is written regardless of whether SF columns are populated.
    Sorted by fieldName.
    """
    csv_path = os.path.join(mapping_dir, f"{entity_name}.csv")
    header = ["fieldName"] + CSV_COLUMNS
    if field_ref_counts is None:
        field_ref_counts = {}

    rows = []
    for field in sorted(fields, key=lambda f: f['schema_name'].lower()):
        sn_lower = field['schema_name'].lower()
        data = sf_mapping.get(sn_lower, {})
        pv = field.get('picklist_values', [])
        pv_str = ', '.join(
            f'{v["value"]}: {v["label"]}' for v in pv) if pv else ''
        suggested = field_mapping_suggested.get(sn_lower, False)
        row = {
            "fieldName": field['schema_name'],
            "displayName": field.get('display_name', ''),
            "dataType": field.get('data_type', ''),
            "requiredLevel": field.get('required_level', ''),
            "isCustom": str(field.get('is_custom', False)),
            "picklistValues": pv_str,
            "mappingSuggested": "true" if suggested else "false",
        }
        refs = field_ref_counts.get(sn_lower, {})
        for csv_col, count_key in REF_COUNT_COLUMNS:
            row[csv_col] = refs.get(count_key, 0)
        for col in SF_COLUMNS:
            row[col] = data.get(col, "") or ""
        rows.append(row)

    os.makedirs(mapping_dir, exist_ok=True)
    with open(csv_path, "w", encoding="utf-8", newline="") as f:
        writer = csv.DictWriter(f, fieldnames=header)
        writer.writeheader()
        writer.writerows(rows)


# ---------------------------------------------------------------------------
# MAIN
# ---------------------------------------------------------------------------

def process_entity(entity_name, mapping_dir, sf_entity_index, d365_entities_dir):
    """Load enriched JSON, compute SF suggestions, and write updated CSV."""
    entity_name = entity_name.lower()

    print(f"\nProcessing {entity_name.upper()}...")
    print("-" * 40)

    # 1. Load d365-entities/{entity}.json
    json_path = os.path.join(d365_entities_dir, f"{entity_name}.json")
    if not os.path.isfile(json_path):
        print(f"  ERROR: JSON not found: {json_path}")
        return False

    with open(json_path, 'r', encoding='utf-8') as f:
        entity_data = json.load(f)

    # 2. Convert entity-level sections from camelCase -> snake_case
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

    # 3. Convert field list from JSON keys to parse-output keys
    fields = adapt_json_fields(entity_data.get('fields', []))

    # 4. Compute field reference counts
    field_ref_counts = count_field_references(
        entity_name, forms, views, chart_visualizations,
        reports, dashboards, workflows, formulas,
        plugin_refs, controls, relationships, ribbon, conflicts
    )

    # 5. Load existing CSV, resolve SF object, compute SF suggestions
    sf_mapping = load_mapping_csv(mapping_dir, entity_name)
    sf_object = resolve_sf_object(entity_name, mapping_dir, sf_entity_index)

    sf_fields = load_sf_entity_fields(SF_ENTITIES_DIR, sf_object) if sf_object else []
    by_d365_internal, by_d365_suggested, by_name_lower = build_sf_field_lookup(sf_fields)

    suggestions_added = 0
    for field in fields:
        sn_lower = field['schema_name'].lower()
        if sn_lower not in sf_mapping:
            sf_mapping[sn_lower] = {col: '' for col in SF_COLUMNS}
        data = sf_mapping[sn_lower]

        refs = field_ref_counts.get(sn_lower, {})
        has_usage = any(refs.get(k, 0) > 0 for k in refs)

        if data.get('sfObjectName') and not (
                data.get('sfFieldDisplayName') and data.get('sfFieldApiName')):
            data['sfObjectName'] = ''

        if not has_usage:
            data['sfSuggestedObjectName'] = ''
            data['sfSuggestedFieldDisplayName'] = ''
            data['sfSuggestedFieldApiName'] = ''
        else:
            if data.get('sfSuggestedObjectName') and not (
                    data.get('sfSuggestedFieldDisplayName') and
                    data.get('sfSuggestedFieldApiName')):
                data['sfSuggestedObjectName'] = ''

            has_confirmed = all(data.get(c, '') for c in (
                'sfObjectName', 'sfFieldDisplayName', 'sfFieldApiName'))
            has_suggested = all(data.get(c, '') for c in (
                'sfSuggestedObjectName', 'sfSuggestedFieldDisplayName',
                'sfSuggestedFieldApiName'))
            if not has_confirmed and not has_suggested and sf_object:
                sf_display, sf_api = match_sf_field(
                    field['schema_name'],
                    by_d365_internal, by_d365_suggested, by_name_lower)
                if sf_display and sf_api:
                    data['sfSuggestedObjectName'] = sf_object
                    data['sfSuggestedFieldDisplayName'] = sf_display
                    data['sfSuggestedFieldApiName'] = sf_api
                    suggestions_added += 1

    # 6. Compute mappingSuggested flag
    field_mapping_suggested = {}
    for field in fields:
        sn_lower = field['schema_name'].lower()
        refs = field_ref_counts.get(sn_lower, {})
        has_usage = any(refs.get(k, 0) > 0 for k in refs)
        req = field.get('required_level', '') or ''
        is_required = req.lower() not in ('', 'none')
        field_mapping_suggested[sn_lower] = has_usage or is_required

    # 7. Write CSV
    write_mapping_csv(mapping_dir, entity_name, fields, sf_mapping,
                      field_mapping_suggested, field_ref_counts)

    matched = sum(1 for v in sf_mapping.values() if v.get('sfSuggestedFieldApiName', ''))
    print(f"  Fields: {len(fields)}")
    print(f"  SF object: {sf_object or '(none)'}")
    print(f"  Suggestions added: {suggestions_added}")
    print(f"  Total with SF match: {matched}")
    print(f"  CSV written: {os.path.join(mapping_dir, entity_name + '.csv')}")

    return True


def main():
    parser = argparse.ArgumentParser(
        description='Update D365-to-SF mapping CSVs with SF suggestions'
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
    print("D365CE Mapping CSV Updater")
    print("=" * 60)
    print()

    print("  Building SF entity index...")
    sf_entity_index = build_sf_entity_index(SF_ENTITIES_DIR)
    print(f"    SF objects: {len(sf_entity_index)}")

    if args.all:
        entities = sorted(f[:-5] for f in os.listdir(d365_dir) if f.endswith('.json'))
        print(f"\nDiscovered {len(entities)} entities in {d365_dir}.")
        success = 0
        for entity_name in entities:
            if process_entity(entity_name, mapping_dir,
                              sf_entity_index=sf_entity_index,
                              d365_entities_dir=d365_dir):
                success += 1
        print()
        print("=" * 60)
        print(f"Update complete! {success}/{len(entities)} CSVs updated.")
        print("=" * 60)
    else:
        entity_name = args.entity.lower()
        if not process_entity(entity_name, mapping_dir,
                              sf_entity_index=sf_entity_index,
                              d365_entities_dir=d365_dir):
            sys.exit(1)
        print()
        print("=" * 60)
        print("Update complete!")
        print("=" * 60)


if __name__ == '__main__':
    main()
