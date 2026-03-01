#!/usr/bin/env python3
"""
refresh_sf_entities.py

Refreshes Salesforce object schema JSON files in salesforce-entities/
by calling the Salesforce REST API (SObject Describe).

Authentication (tried in order):
  1. Salesforce CLI (`sf org display`) — uses existing authenticated session
  2. OAuth 2.0 Client Credentials — reads from .mcp.json salesforce config

Preserves existing d365 mapping fields when updating.

Usage:
    python refresh_sf_entities.py Account           # single SF object
    python refresh_sf_entities.py --all              # all objects in salesforce-entities/
    python refresh_sf_entities.py --all --output-dir PATH
    python refresh_sf_entities.py --all --auth oauth # force OAuth (skip SF CLI)
"""

import argparse
import json
import os
import shutil
import ssl
import subprocess
import sys
import urllib.error
import urllib.parse
import urllib.request

PROJECT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
DEFAULT_OUTPUT_DIR = os.path.join(PROJECT_DIR, "salesforce-entities")
MCP_CONFIG_PATH = os.path.join(PROJECT_DIR, ".mcp.json")

API_VERSION = "62.0"

D365_MAPPING_FIELDS = [
    "d365EntityName",
    "d365DisplayName",
    "d365InternalName",
    "d365SuggestedEntityName",
    "d365SuggestedDisplayName",
    "d365SuggestedInternalName",
]


# ---------------------------------------------------------------------------
# Authentication: SF CLI
# ---------------------------------------------------------------------------

def find_sf_cli_org(instance_url):
    """Find a matching SF CLI org alias by instance URL.

    Returns the alias/username or None.
    """
    sf_cmd = shutil.which("sf")
    if not sf_cmd:
        return None

    try:
        result = subprocess.run(
            [sf_cmd, "org", "list", "--json"],
            capture_output=True, text=True, timeout=30,
        )
        if result.returncode != 0:
            return None

        data = json.loads(result.stdout)
        target = instance_url.rstrip("/").lower()
        for org in data.get("result", {}).get("nonScratchOrgs", []):
            org_url = org.get("instanceUrl", "").rstrip("/").lower()
            if org_url == target:
                return org.get("alias") or org.get("username")
    except (subprocess.TimeoutExpired, json.JSONDecodeError, OSError):
        pass
    return None


def authenticate_sf_cli(target_org=None):
    """Authenticate using Salesforce CLI stored session.

    If no target_org specified, attempts to find one matching the
    instance URL from .mcp.json.

    Returns (access_token, instance_url) or (None, None) if unavailable.
    """
    sf_cmd = shutil.which("sf")
    if not sf_cmd:
        return None, None

    # Auto-discover org from .mcp.json instance URL if no target specified
    if not target_org:
        _, _, mcp_url = load_sf_credentials(MCP_CONFIG_PATH)
        if mcp_url:
            target_org = find_sf_cli_org(mcp_url)

    cmd = [sf_cmd, "org", "display", "--json"]
    if target_org:
        cmd.extend(["--target-org", target_org])

    try:
        result = subprocess.run(
            cmd, capture_output=True, text=True, timeout=30,
        )
        if result.returncode != 0:
            return None, None

        data = json.loads(result.stdout)
        r = data.get("result", {})
        token = r.get("accessToken")
        url = r.get("instanceUrl", "").rstrip("/")

        if token and url:
            return token, url
    except (subprocess.TimeoutExpired, json.JSONDecodeError, OSError):
        pass

    return None, None


# ---------------------------------------------------------------------------
# Authentication: OAuth 2.0 Client Credentials
# ---------------------------------------------------------------------------

def load_sf_credentials(mcp_path):
    """Read Salesforce credentials from .mcp.json salesforce server config."""
    if not os.path.isfile(mcp_path):
        return None, None, None

    with open(mcp_path, "r", encoding="utf-8") as f:
        config = json.load(f)

    sf_env = (
        config.get("mcpServers", {})
        .get("salesforce", {})
        .get("env", {})
    )

    client_id = sf_env.get("SALESFORCE_CLIENT_ID")
    client_secret = sf_env.get("SALESFORCE_CLIENT_SECRET")
    instance_url = sf_env.get("SALESFORCE_INSTANCE_URL", "").rstrip("/")

    if not all([client_id, client_secret, instance_url]):
        return None, None, None

    return client_id, client_secret, instance_url


def authenticate_oauth(client_id, client_secret, instance_url):
    """Authenticate via OAuth 2.0 Client Credentials flow.

    Returns (access_token, instance_url) or (None, None) on failure.
    """
    token_url = f"{instance_url}/services/oauth2/token"
    data = urllib.parse.urlencode({
        "grant_type": "client_credentials",
        "client_id": client_id,
        "client_secret": client_secret,
    }).encode("utf-8")

    req = urllib.request.Request(token_url, data=data, method="POST")
    req.add_header("Content-Type", "application/x-www-form-urlencoded")

    ctx = ssl.create_default_context()
    try:
        with urllib.request.urlopen(req, context=ctx) as resp:
            body = json.loads(resp.read().decode("utf-8"))
    except urllib.error.HTTPError as e:
        error_body = e.read().decode("utf-8", errors="replace")
        print(f"  OAuth failed ({e.code}): {error_body}", file=sys.stderr)
        if "no valid scopes" in error_body.lower():
            print(
                "  HINT: Add 'Manage user data via APIs (api)' scope to the Connected App.",
                file=sys.stderr,
            )
        return None, None

    access_token = body.get("access_token")
    returned_url = body.get("instance_url", instance_url).rstrip("/")
    if not access_token:
        return None, None

    return access_token, returned_url


def resolve_auth(auth_mode):
    """Try authentication methods and return (access_token, instance_url).

    Exits with error if all methods fail.
    """
    # SF CLI first (unless forced to oauth)
    if auth_mode != "oauth":
        print("Trying Salesforce CLI authentication...")
        token, url = authenticate_sf_cli()
        if token:
            print(f"  Authenticated via SF CLI ({url})")
            return token, url
        print("  SF CLI not available or not authenticated.")

    # OAuth fallback
    if auth_mode != "cli":
        print("Trying OAuth 2.0 Client Credentials from .mcp.json...")
        cid, csecret, iurl = load_sf_credentials(MCP_CONFIG_PATH)
        if cid:
            token, url = authenticate_oauth(cid, csecret, iurl)
            if token:
                print(f"  Authenticated via OAuth ({url})")
                return token, url
        else:
            print("  No credentials found in .mcp.json.")

    print(
        "\nERROR: All authentication methods failed.\n"
        "Options:\n"
        "  1. Install SF CLI and run: sf org login web --instance-url <url>\n"
        "  2. Configure OAuth in .mcp.json with a Connected App that has 'api' scope",
        file=sys.stderr,
    )
    sys.exit(1)


# ---------------------------------------------------------------------------
# SObject Describe API
# ---------------------------------------------------------------------------

def describe_sobject(object_name, access_token, instance_url):
    """Call GET /services/data/vXX.0/sobjects/{ObjectName}/describe.

    Returns the parsed JSON response.
    """
    url = f"{instance_url}/services/data/v{API_VERSION}/sobjects/{object_name}/describe"
    req = urllib.request.Request(url, method="GET")
    req.add_header("Authorization", f"Bearer {access_token}")
    req.add_header("Accept", "application/json")

    ctx = ssl.create_default_context()
    try:
        with urllib.request.urlopen(req, context=ctx) as resp:
            return json.loads(resp.read().decode("utf-8"))
    except urllib.error.HTTPError as e:
        error_body = e.read().decode("utf-8", errors="replace")
        print(f"  ERROR describing {object_name} ({e.code}): {error_body}", file=sys.stderr)
        return None


# ---------------------------------------------------------------------------
# JSON building
# ---------------------------------------------------------------------------

def build_field_entry(sf_field, existing_d365):
    """Build a single field dict from SF describe field metadata.

    Merges d365 mapping fields from existing_d365 dict if available.
    """
    field_name = sf_field.get("name", "")

    # Determine relatedTo from referenceTo array
    ref_to = sf_field.get("referenceTo", [])
    related_to = ", ".join(ref_to) if ref_to else "None"

    # Required: nillable=false and not defaultedOnCreate means required
    required = "No"
    if not sf_field.get("nillable", True) and not sf_field.get("defaultedOnCreate", False):
        required = "Yes"

    # Picklist values
    picklist_values = None
    pv_list = sf_field.get("picklistValues", [])
    if pv_list:
        picklist_values = [
            {"label": pv.get("label", ""), "value": pv.get("value", ""), "active": pv.get("active", True)}
            for pv in pv_list
        ]

    entry = {
        "fieldName": field_name,
        "dataType": sf_field.get("type", ""),
        "required": required,
        "relatedTo": related_to,
        "maxLength": sf_field.get("length") or None,
        "picklistValues": picklist_values,
    }

    # Merge d365 mapping from existing data
    d365_data = existing_d365.get(field_name, {})
    for key in D365_MAPPING_FIELDS:
        entry[key] = d365_data.get(key)

    return entry


def build_entity_json(describe_response, existing_json):
    """Build the full entity JSON from a describe response.

    Preserves d365 mapping fields from existing_json.
    """
    object_name = describe_response.get("name", "")
    is_custom = describe_response.get("custom", False)
    object_type = "Custom" if is_custom else "Standard"

    # Build lookup of existing d365 mapping by fieldName
    existing_d365 = {}
    if existing_json and "fields" in existing_json:
        for f in existing_json["fields"]:
            fn = f.get("fieldName", "")
            if fn:
                existing_d365[fn] = {k: f.get(k) for k in D365_MAPPING_FIELDS}

    # Build fields from describe
    fields = []
    for sf_field in describe_response.get("fields", []):
        fields.append(build_field_entry(sf_field, existing_d365))

    return {
        "objectName": object_name,
        "objectType": object_type,
        "recordCount": existing_json.get("recordCount", 0) if existing_json else 0,
        "fields": fields,
    }


# ---------------------------------------------------------------------------
# File I/O
# ---------------------------------------------------------------------------

def load_existing_json(output_dir, object_name):
    """Load existing JSON for an object, if it exists."""
    filename = f"{object_name.lower()}.json"
    filepath = os.path.join(output_dir, filename)
    if os.path.isfile(filepath):
        with open(filepath, "r", encoding="utf-8") as f:
            return json.load(f)
    return None


def save_entity_json(output_dir, object_name, data):
    """Write entity JSON to output directory."""
    filename = f"{object_name.lower()}.json"
    filepath = os.path.join(output_dir, filename)
    with open(filepath, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=2, ensure_ascii=False)
    return filepath


# ---------------------------------------------------------------------------
# Discovery
# ---------------------------------------------------------------------------

def discover_existing_objects(output_dir):
    """Find all object names from existing salesforce-entities/*.json files."""
    objects = []
    if not os.path.isdir(output_dir):
        return objects
    for filename in sorted(os.listdir(output_dir)):
        if filename.endswith(".json"):
            filepath = os.path.join(output_dir, filename)
            try:
                with open(filepath, "r", encoding="utf-8") as f:
                    data = json.load(f)
                obj_name = data.get("objectName")
                if obj_name:
                    objects.append(obj_name)
            except (json.JSONDecodeError, OSError):
                objects.append(filename.replace(".json", ""))
    return objects


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def main():
    parser = argparse.ArgumentParser(
        description="Refresh Salesforce object schema JSON from org via REST API"
    )
    parser.add_argument(
        "object", nargs="?", default=None,
        help="Salesforce object API name (e.g., Account, Opportunity)",
    )
    parser.add_argument(
        "--all", action="store_true",
        help="Refresh all objects currently in salesforce-entities/",
    )
    parser.add_argument(
        "--output-dir", default=DEFAULT_OUTPUT_DIR,
        help=f"Output directory (default: {DEFAULT_OUTPUT_DIR})",
    )
    parser.add_argument(
        "--auth", choices=["auto", "cli", "oauth"], default="auto",
        help="Authentication method: auto (try CLI then OAuth), cli, or oauth",
    )
    args = parser.parse_args()

    if not args.all and not args.object:
        parser.error("either provide an object name or use --all")

    output_dir = args.output_dir
    os.makedirs(output_dir, exist_ok=True)

    print("=" * 60)
    print("Salesforce Entity Schema Refresh")
    print("=" * 60)
    print()

    # Authenticate
    access_token, auth_url = resolve_auth(args.auth)
    print()

    # Determine objects to refresh
    if args.all:
        object_list = discover_existing_objects(output_dir)
        print(f"Found {len(object_list)} existing objects to refresh.")
    else:
        object_list = [args.object]

    success = 0
    failed = 0

    for obj_name in object_list:
        print(f"\n  Describing {obj_name}...")

        describe = describe_sobject(obj_name, access_token, auth_url)
        if describe is None:
            failed += 1
            continue

        existing = load_existing_json(output_dir, obj_name)
        entity_json = build_entity_json(describe, existing)

        filepath = save_entity_json(output_dir, obj_name, entity_json)

        field_count = len(entity_json.get("fields", []))
        d365_count = sum(
            1 for f in entity_json.get("fields", [])
            if any(f.get(k) for k in D365_MAPPING_FIELDS)
        )
        print(f"    {field_count} fields, {d365_count} with d365 mappings")
        print(f"    -> {filepath}")
        success += 1

    print()
    print("=" * 60)
    print(f"Refresh complete: {success} succeeded, {failed} failed out of {len(object_list)} total.")
    print("=" * 60)


if __name__ == "__main__":
    main()
