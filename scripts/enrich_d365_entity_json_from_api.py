#!/usr/bin/env python3
"""
enrich_d365_entity_json_from_api.py

Step 2 of the pipeline. Runs after Step 1.

Queries the Dataverse Web API EntityDefinitions/Attributes endpoint to get
metadata for ALL real attributes, then updates stub fields (those with empty
dataType) in d365-entities/*.json in-place. Fields that already have metadata
from Step 1 (customizations.xml) are left untouched.

Requires: msal (pip install msal) and scripts/config.local.json with Dataverse
credentials.

Usage:
    python enrich_d365_entity_json_from_api.py account
    python enrich_d365_entity_json_from_api.py --all
    python enrich_d365_entity_json_from_api.py account --dry-run
"""

import argparse
import glob
import json
import os
import ssl
import sys
import time
import urllib.error
import urllib.request
from collections import OrderedDict

try:
    import msal
except ImportError:
    print("msal is required. Install with:  pip install msal", file=sys.stderr)
    sys.exit(1)

# ---------------------------------------------------------------------------
# Constants
# ---------------------------------------------------------------------------

SCRIPTS_DIR = os.path.dirname(os.path.abspath(__file__))
PROJECT_DIR = os.path.dirname(SCRIPTS_DIR)
DEFAULT_D365_DIR = os.path.join(PROJECT_DIR, "d365-entities")
DEFAULT_CONFIG = os.path.join(SCRIPTS_DIR, "config.local.json")

# Dataverse AttributeType → JSON dataType mapping
ATTRIBUTE_TYPE_MAP = {
    "String": "nvarchar",
    "Memo": "ntext",
    "Integer": "int",
    "BigInt": "bigint",
    "Decimal": "decimal",
    "Double": "float",
    "Money": "money",
    "Boolean": "bit",
    "DateTime": "datetime",
    "Uniqueidentifier": "uniqueidentifier",
    "Lookup": "lookup",
    "Customer": "lookup",
    "Owner": "lookup",
    "Picklist": "picklist",
    "State": "picklist",
    "Status": "picklist",
    "MultiSelectPicklist": "multiselect",
    "EntityName": "entityname",
    "ManagedProperty": "managedproperty",
    "Image": "image",
    "PartyList": "partylist",
}


# ---------------------------------------------------------------------------
# Config & Auth
# ---------------------------------------------------------------------------

def load_config(config_path):
    """Load and validate config.local.json."""
    if not os.path.isfile(config_path):
        template = os.path.join(SCRIPTS_DIR, "config.template.json")
        print(f"Config file not found: {config_path}", file=sys.stderr)
        print(f"Copy {template} to {config_path} and fill in credentials.", file=sys.stderr)
        sys.exit(1)

    with open(config_path, "r", encoding="utf-8") as f:
        config = json.load(f)

    dv = config.get("dataverse")
    if not dv:
        print("Config missing 'dataverse' section.", file=sys.stderr)
        sys.exit(1)

    required_keys = ["server", "tenant_id", "client_id", "client_secret"]
    missing = [k for k in required_keys if not dv.get(k)]
    if missing:
        print(f"Config missing dataverse keys: {', '.join(missing)}", file=sys.stderr)
        sys.exit(1)

    return config


def acquire_access_token(config):
    """Acquire Azure AD access token via MSAL service principal."""
    dv = config["dataverse"]
    authority = f"https://login.microsoftonline.com/{dv['tenant_id']}"
    scope = [f"https://{dv['server']}/.default"]

    app = msal.ConfidentialClientApplication(
        dv["client_id"],
        authority=authority,
        client_credential=dv["client_secret"],
    )

    result = app.acquire_token_for_client(scopes=scope)

    if "access_token" in result:
        return result["access_token"]

    error = result.get("error_description", result.get("error", "Unknown error"))
    print(f"Failed to acquire access token: {error}", file=sys.stderr)
    sys.exit(1)


# ---------------------------------------------------------------------------
# API Helpers
# ---------------------------------------------------------------------------

def api_request(url, headers, max_retries=3):
    """GET request with pagination and retry-on-429 handling.

    Returns the full list of 'value' items across all pages.
    """
    all_values = []
    current_url = url

    # Create SSL context that works on Windows
    ctx = ssl.create_default_context()

    while current_url:
        req = urllib.request.Request(current_url, headers=headers)
        retries = 0
        while True:
            try:
                with urllib.request.urlopen(req, context=ctx, timeout=120) as resp:
                    body = json.loads(resp.read().decode("utf-8"))
                    all_values.extend(body.get("value", []))
                    current_url = body.get("@odata.nextLink")
                    break
            except urllib.error.HTTPError as e:
                if e.code == 429 and retries < max_retries:
                    retry_after = int(e.headers.get("Retry-After", 5))
                    print(f"    Rate limited (429). Waiting {retry_after}s...")
                    time.sleep(retry_after)
                    retries += 1
                    continue
                raise
            except urllib.error.URLError as e:
                if retries < max_retries:
                    retries += 1
                    print(f"    Connection error: {e}. Retry {retries}/{max_retries}...")
                    time.sleep(2)
                    continue
                raise

    return all_values


# ---------------------------------------------------------------------------
# Attribute Mapping
# ---------------------------------------------------------------------------

def map_attribute_type(attr):
    """Convert Dataverse AttributeType to JSON dataType string.

    Returns None if the attribute should be skipped (e.g. Virtual companion).
    """
    attr_type = attr.get("AttributeType", "")
    attribute_of = attr.get("AttributeOf")

    # Virtual with AttributeOf = companion field (e.g. _name suffix), skip
    if attr_type == "Virtual" and attribute_of:
        return None

    # Virtual standalone
    if attr_type == "Virtual":
        return "virtual"

    return ATTRIBUTE_TYPE_MAP.get(attr_type, attr_type.lower() if attr_type else "")


def map_required_level(attr):
    """Convert RequiredLevel.Value to none/recommended/required."""
    req = attr.get("RequiredLevel", {})
    value = req.get("Value", "None") if isinstance(req, dict) else "None"

    mapping = {
        "None": "none",
        "Recommended": "recommended",
        "ApplicationRequired": "required",
        "SystemRequired": "required",
    }
    return mapping.get(value, "none")


def get_display_name(attr):
    """Extract the English display name from API attribute metadata."""
    dn = attr.get("DisplayName", {})
    label = dn.get("UserLocalizedLabel")
    if label and isinstance(label, dict):
        return label.get("Label", "")
    return ""


def get_description(attr):
    """Extract the English description from API attribute metadata."""
    desc = attr.get("Description", {})
    label = desc.get("UserLocalizedLabel")
    if label and isinstance(label, dict):
        return label.get("Label", "")
    return ""


# ---------------------------------------------------------------------------
# Entity Processing
# ---------------------------------------------------------------------------

def get_entity_attributes(api_base, headers, entity_name):
    """Query EntityDefinitions/Attributes for a given entity.

    Returns a dict keyed by lowercase LogicalName → attribute dict,
    or None if the entity is not found in Dataverse.
    """
    url = (
        f"{api_base}/EntityDefinitions(LogicalName='{entity_name}')"
        f"/Attributes"
    )
    headers_with_paging = dict(headers)
    headers_with_paging["Prefer"] = "odata.maxpagesize=5000"

    try:
        attrs = api_request(url, headers_with_paging)
    except urllib.error.HTTPError as e:
        if e.code == 404:
            return None
        raise

    lookup = {}
    for attr in attrs:
        logical = attr.get("LogicalName", "").lower()
        if logical:
            lookup[logical] = attr
    return lookup


MODE_MAP = {0: "Synchronous", 1: "Asynchronous"}
STAGE_MAP = {10: "Pre-Validation", 20: "Pre-Operation", 40: "Post-Operation"}
STATE_MAP = {0: "Enabled", 1: "Disabled"}


def get_all_plugin_steps(api_base, headers):
    """Query all SdkMessageProcessingStep records from Dataverse.

    Returns a dict keyed by lowercase plugin type name (class name) -> list of step dicts.
    Each step dict contains: message, mode, stage, state, filteringAttributes, rank.
    """
    url = (
        f"{api_base}/sdkmessageprocessingsteps"
        f"?$select=name,mode,stage,statecode,asyncautodelete,filteringattributes,rank"
        f"&$expand=sdkmessageid($select=name),plugintypeid($select=name)"
    )
    try:
        steps = api_request(url, headers)
    except Exception as e:
        print(f"  WARNING: Failed to query plugin steps: {e}")
        return {}

    lookup = {}
    for step in steps:
        plugin_type = step.get("plugintypeid")
        if not plugin_type:
            continue
        full_name = plugin_type.get("name", "")
        if not full_name:
            continue
        # Use short class name (last segment after dot) for matching
        class_name = full_name.rsplit('.', 1)[-1].lower()
        message = step.get("sdkmessageid", {}).get("name", "")
        entry = {
            "message": message,
            "mode": MODE_MAP.get(step.get("mode"), str(step.get("mode", ""))),
            "stage": STAGE_MAP.get(step.get("stage"), str(step.get("stage", ""))),
            "state": STATE_MAP.get(step.get("statecode"), str(step.get("statecode", ""))),
            "filteringAttributes": step.get("filteringattributes") or "",
            "rank": step.get("rank", 0),
        }
        lookup.setdefault(class_name, []).append(entry)

    return lookup


def enrich_plugin_sections(data, plugin_step_lookup):
    """Enrich entity sections.plugins with registration metadata from the API.

    Matches by class name. Adds registrations array to each plugin entry.
    Returns count of plugins enriched.
    """
    sections = data.get("sections", {})
    plugins = sections.get("plugins", [])
    enriched = 0

    for plugin in plugins:
        class_name = plugin.get("className", "").lower()
        steps = plugin_step_lookup.get(class_name, [])
        if steps:
            plugin["registrations"] = steps
            enriched += 1
        else:
            plugin["registrations"] = []

    return enriched


def process_entity(api_base, headers, entity_json_path, dry_run, plugin_step_lookup=None):
    """Load entity JSON, match stubs against API, enrich, and save.

    Returns (stub_count, enriched_count, removed_count) or None on error.
    """
    # Load JSON preserving key order
    with open(entity_json_path, "r", encoding="utf-8") as f:
        data = json.load(f, object_pairs_hook=OrderedDict)

    entity_name = data.get("entityName", os.path.splitext(os.path.basename(entity_json_path))[0])
    fields = data.get("fields", [])

    # Enrich plugin sections with registration metadata
    plugins_enriched = 0
    if plugin_step_lookup:
        plugins_enriched = enrich_plugin_sections(data, plugin_step_lookup)
        if plugins_enriched:
            print(f"  Plugin registrations matched: {plugins_enriched}")

    # Identify stub fields (empty dataType)
    stub_indices = [i for i, f in enumerate(fields) if f.get("dataType", "") == ""]
    stub_count = len(stub_indices)

    if stub_count == 0 and plugins_enriched == 0:
        print(f"  No stub fields, no plugin updates, skipping.")
        return (0, 0, 0)
    if stub_count == 0:
        # No stubs but plugins were enriched — save and return
        if not dry_run:
            with open(entity_json_path, "w", encoding="utf-8") as f:
                json.dump(data, f, indent=2, ensure_ascii=False)
                f.write("\n")
        print(f"  No stub fields.")
        return (0, 0, 0)

    print(f"  Stub fields: {stub_count}")

    # Query Dataverse API for entity attributes
    api_attrs = get_entity_attributes(api_base, headers, entity_name)

    if api_attrs is None:
        print(f"  Entity '{entity_name}' not found in Dataverse, skipping.")
        return None

    print(f"  API attributes returned: {len(api_attrs)}")

    enriched = 0
    artifacts = 0

    for idx in stub_indices:
        field = fields[idx]
        field_name = field.get("fieldName", "").lower()
        api_attr = api_attrs.get(field_name)

        if not api_attr:
            artifacts += 1
            continue

        # Map the attribute type
        data_type = map_attribute_type(api_attr)

        if data_type is None:
            # Virtual companion field — skip
            artifacts += 1
            continue

        # Update only stub properties
        field["dataType"] = data_type
        field["displayName"] = get_display_name(api_attr) or field.get("displayName", "")
        field["description"] = get_description(api_attr) or field.get("description", "")
        field["requiredLevel"] = map_required_level(api_attr)
        field["isCustom"] = api_attr.get("IsCustomAttribute", False)

        # MaxLength only for string/memo types
        max_len = api_attr.get("MaxLength")
        if data_type in ("nvarchar", "ntext") and max_len is not None:
            field["maxLength"] = max_len

        enriched += 1

    # Remove unresolved stubs (cross-entity artifacts)
    before_count = len(fields)
    data["fields"] = [f for f in fields if f.get("dataType", "") != ""]
    removed = before_count - len(data["fields"])

    print(f"  Matched in API: {enriched} (enriched)")
    print(f"  Removed: {removed} (cross-entity artifacts)")

    if not dry_run and (enriched > 0 or removed > 0):
        with open(entity_json_path, "w", encoding="utf-8") as f:
            json.dump(data, f, indent=2, ensure_ascii=False)
            f.write("\n")

    return (stub_count, enriched, removed)


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def main():
    parser = argparse.ArgumentParser(
        description="Enrich stub fields in d365-entities/*.json with Dataverse Web API metadata (Step 2)."
    )
    parser.add_argument("entity", nargs="?", help="Entity name (e.g. account)")
    parser.add_argument("--all", action="store_true", help="Process all entities")
    parser.add_argument("--config", default=DEFAULT_CONFIG, help="Path to config.local.json")
    parser.add_argument("--d365-dir", default=DEFAULT_D365_DIR, help="Path to d365-entities/ directory")
    parser.add_argument("--dry-run", action="store_true", help="Show what would be enriched without writing")

    args = parser.parse_args()

    if not args.entity and not args.all:
        parser.error("Provide an entity name or use --all")

    if args.dry_run:
        print("DRY RUN — no files will be modified.\n")

    # Load config and authenticate
    config = load_config(args.config)
    dv = config["dataverse"]
    api_base = f"https://{dv['server']}/api/data/v9.2"

    print("Acquiring access token...")
    access_token = acquire_access_token(config)
    print("  Token acquired.")

    headers = {
        "Authorization": f"Bearer {access_token}",
        "OData-Version": "4.0",
        "Accept": "application/json",
    }

    # Test API connectivity (single request, no pagination)
    print("Testing Dataverse API connectivity...")
    try:
        test_url = f"{api_base}/EntityDefinitions"
        test_headers = dict(headers)
        test_headers["Prefer"] = "odata.maxpagesize=1"
        ctx = ssl.create_default_context()
        req = urllib.request.Request(test_url, headers=test_headers)
        with urllib.request.urlopen(req, context=ctx, timeout=30) as resp:
            body = json.loads(resp.read().decode("utf-8"))
            test_result = body.get("value", [])
        if test_result:
            print(f"  API OK. Sample entity: {test_result[0].get('LogicalName', '?')}")
        else:
            print("  API returned empty result.", file=sys.stderr)
            sys.exit(1)
    except Exception as e:
        print(f"  API connectivity test failed: {e}", file=sys.stderr)
        sys.exit(1)

    # Resolve entity JSON files
    if args.all:
        pattern = os.path.join(args.d365_dir, "*.json")
        json_files = sorted(glob.glob(pattern))
        if not json_files:
            print(f"No JSON files found in {args.d365_dir}", file=sys.stderr)
            sys.exit(1)
        print(f"Processing {len(json_files)} entities...")
    else:
        json_path = os.path.join(args.d365_dir, f"{args.entity}.json")
        if not os.path.isfile(json_path):
            print(f"Entity JSON not found: {json_path}", file=sys.stderr)
            sys.exit(1)
        json_files = [json_path]
        print(f"Processing entity: {args.entity}")

    # Query all plugin step registrations once
    print("\nQuerying plugin step registrations...")
    plugin_step_lookup = get_all_plugin_steps(api_base, headers)
    print(f"  Plugin types found: {len(plugin_step_lookup)}")

    # Process entities
    successful = 0
    failed = 0
    total_enriched = 0
    total_removed = 0

    for json_path in json_files:
        entity = os.path.splitext(os.path.basename(json_path))[0]
        print(f"\n--- {entity} ---")
        try:
            result = process_entity(api_base, headers, json_path, args.dry_run, plugin_step_lookup)
            if result is not None:
                successful += 1
                total_enriched += result[1]
                total_removed += result[2]
            else:
                failed += 1
        except Exception as e:
            print(f"  Unexpected error: {e}", file=sys.stderr)
            failed += 1

    # Summary
    mode = " (dry run)" if args.dry_run else ""
    print(f"\nComplete{mode}: {successful} enriched, {failed} failed.")
    print(f"Total: {total_enriched} fields enriched, {total_removed} cross-entity artifacts removed.")


if __name__ == "__main__":
    main()
