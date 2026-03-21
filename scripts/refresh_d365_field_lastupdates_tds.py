#!/usr/bin/env python3
"""
refresh_d365_field_lastupdates_tds.py

Standalone utility (not part of the numbered pipeline).

Connects to the D365 Dataverse TDS endpoint and queries MAX(modifiedon)
per field to update the lastUpdate values in d365-entities/*.json in-place.

Requires pyodbc, msal, and ODBC Driver 18 for SQL Server.

Usage:
    python refresh_d365_field_lastupdates_tds.py account
    python refresh_d365_field_lastupdates_tds.py --all
    python refresh_d365_field_lastupdates_tds.py account --performance-report
"""

import json
import os
import sys
import glob
import struct
import argparse
import time
from collections import OrderedDict
from datetime import datetime

try:
    import pyodbc
except ImportError:
    print("pyodbc is required. Install with:  pip install pyodbc", file=sys.stderr)
    sys.exit(1)

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

SKIP_DATATYPES = {"image", "partylist"}
SKIP_FIELDS = {"modifiedon", "createdon"}
STRING_DATATYPES = {"nvarchar", "ntext"}
NO_DATATYPE_SKIP = ""


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

    required_keys = ["server", "port", "database", "tenant_id", "client_id", "client_secret"]
    missing = [k for k in required_keys if not dv.get(k)]
    if missing:
        print(f"Config missing dataverse keys: {', '.join(missing)}", file=sys.stderr)
        sys.exit(1)

    return config


def get_access_token(config):
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
# TDS Connection
# ---------------------------------------------------------------------------

def create_connection(config, access_token):
    """Create a TDS connection to Dataverse with token auth."""
    dv = config["dataverse"]

    token_bytes = access_token.encode("utf-16-le")
    token_struct = struct.pack(f"<I{len(token_bytes)}s", len(token_bytes), token_bytes)

    connection_string = (
        f"Driver={{ODBC Driver 18 for SQL Server}};"
        f"Server={dv['server']},{dv['port']};"
        f"Database={dv['database']};"
        f"Encrypt=yes;"
        f"TrustServerCertificate=no;"
        f"Connection Timeout=60;"
    )

    # autocommit=True is REQUIRED for Dataverse TDS endpoint
    conn = pyodbc.connect(connection_string, attrs_before={1256: token_struct}, autocommit=True)
    return conn


# ---------------------------------------------------------------------------
# Field Query
# ---------------------------------------------------------------------------

def query_field_last_update(conn, entity_name, field_name, is_string_type):
    """Query MAX(modifiedon) for rows where the field is populated."""
    cursor = conn.cursor()
    try:
        if is_string_type:
            query = (
                f"SELECT MAX(modifiedon) FROM [{entity_name}] "
                f"WHERE [{field_name}] IS NOT NULL AND [{field_name}] != ''"
            )
        else:
            query = (
                f"SELECT MAX(modifiedon) FROM [{entity_name}] "
                f"WHERE [{field_name}] IS NOT NULL"
            )
        cursor.execute(query)
        row = cursor.fetchone()
        if row and row[0]:
            return row[0], None
        return None, None
    except pyodbc.Error as e:
        return None, str(e)[:200]
    finally:
        cursor.close()


# ---------------------------------------------------------------------------
# Entity Processing
# ---------------------------------------------------------------------------

def process_entity(config, access_token, entity_json_path, perf_log):
    """Process a single entity JSON — query TDS and update lastUpdate in-place."""
    # Load JSON preserving key order
    with open(entity_json_path, "r", encoding="utf-8") as f:
        data = json.load(f, object_pairs_hook=OrderedDict)

    entity_name = data.get("entityName", os.path.splitext(os.path.basename(entity_json_path))[0])
    fields = data.get("fields", [])

    if not fields:
        print(f"  No fields found in {entity_json_path}, skipping.")
        return False

    # Create fresh connection for this entity
    try:
        conn = create_connection(config, access_token)
    except Exception as e:
        print(f"  Connection failed for {entity_name}: {e}", file=sys.stderr)
        return False

    queried = 0
    skipped = 0
    errors = 0

    try:
        for i, field in enumerate(fields, 1):
            field_name = field.get("fieldName", "")
            data_type = field.get("dataType", "")

            # Skip rules
            if not data_type:
                field["lastUpdate"] = "Skipped (no dataType)"
                skipped += 1
                if perf_log is not None:
                    perf_log.append((entity_name, field_name, data_type, 0, "Skipped (no dataType)"))
                continue

            if data_type in SKIP_DATATYPES:
                skip_msg = f"Skipped ({data_type})"
                field["lastUpdate"] = skip_msg
                skipped += 1
                if perf_log is not None:
                    perf_log.append((entity_name, field_name, data_type, 0, skip_msg))
                continue

            if field_name.lower() in SKIP_FIELDS:
                field["lastUpdate"] = f"Skipped ({field_name})"
                skipped += 1
                if perf_log is not None:
                    perf_log.append((entity_name, field_name, data_type, 0, f"Skipped ({field_name})"))
                continue

            # Query TDS
            is_string = data_type in STRING_DATATYPES
            start = time.time()
            value, error = query_field_last_update(conn, entity_name, field_name, is_string)
            elapsed = time.time() - start

            if error:
                field["lastUpdate"] = "Error"
                errors += 1
                if perf_log is not None:
                    perf_log.append((entity_name, field_name, data_type, elapsed, f"Error: {error[:80]}"))
                if errors <= 3:
                    print(f"    Error querying {field_name}: {error[:100]}", file=sys.stderr)
            elif value:
                if isinstance(value, datetime):
                    formatted = value.strftime("%Y-%m-%d %H:%M:%S")
                else:
                    formatted = str(value)
                field["lastUpdate"] = formatted
                if perf_log is not None:
                    perf_log.append((entity_name, field_name, data_type, elapsed, formatted))
            else:
                field["lastUpdate"] = "Never"
                if perf_log is not None:
                    perf_log.append((entity_name, field_name, data_type, elapsed, "Never"))

            queried += 1

            if queried % 25 == 0:
                print(f"    Queried {queried} fields...")
    finally:
        conn.close()

    # Write back JSON preserving order
    with open(entity_json_path, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=2, ensure_ascii=False)
        f.write("\n")

    print(f"  {entity_name}: {queried} queried, {skipped} skipped, {errors} errors")
    return True


# ---------------------------------------------------------------------------
# Performance Report
# ---------------------------------------------------------------------------

def write_performance_report(perf_log, output_path):
    """Write a Markdown performance report from the perf_log."""
    total_queried = sum(1 for r in perf_log if not r[4].startswith("Skipped"))
    total_skipped = sum(1 for r in perf_log if r[4].startswith("Skipped"))
    total_errors = sum(1 for r in perf_log if r[4].startswith("Error"))
    total_never = sum(1 for r in perf_log if r[4] == "Never")
    total_with_data = total_queried - total_errors - total_never
    query_times = [r[3] for r in perf_log if not r[4].startswith("Skipped")]
    total_time = sum(query_times)
    avg_time = total_time / len(query_times) if query_times else 0
    max_time = max(query_times) if query_times else 0

    entities = sorted(set(r[0] for r in perf_log))

    lines = []
    lines.append("# TDS Query Performance Report")
    lines.append(f"Generated: {datetime.now().strftime('%Y-%m-%d %H:%M:%S')}")
    lines.append("")
    lines.append("## Summary")
    lines.append("")
    lines.append("| Metric | Value |")
    lines.append("|---|---|")
    lines.append(f"| Entities processed | {len(entities)} |")
    lines.append(f"| Fields queried | {total_queried} |")
    lines.append(f"| Fields skipped | {total_skipped} |")
    lines.append(f"| Fields with data | {total_with_data} |")
    lines.append(f"| Fields never populated | {total_never} |")
    lines.append(f"| Fields with errors | {total_errors} |")
    lines.append(f"| Total query time | {total_time:.1f}s |")
    lines.append(f"| Avg query time | {avg_time:.3f}s |")
    lines.append(f"| Max query time | {max_time:.3f}s |")
    lines.append("")
    lines.append("## Detail")
    lines.append("")
    lines.append("| Entity | Field | DataType | Time (s) | Result |")
    lines.append("|---|---|---|---|---|")

    for entity, field, dtype, elapsed, result in perf_log:
        # Truncate long results for readability
        display_result = result[:60] if len(result) > 60 else result
        lines.append(f"| {entity} | {field} | {dtype} | {elapsed:.3f} | {display_result} |")

    lines.append("")

    os.makedirs(os.path.dirname(output_path), exist_ok=True)
    with open(output_path, "w", encoding="utf-8") as f:
        f.write("\n".join(lines))

    print(f"Performance report written to {output_path}")


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def main():
    parser = argparse.ArgumentParser(
        description="Refresh lastUpdate fields in d365-entities/*.json via Dataverse TDS endpoint."
    )
    parser.add_argument("entity", nargs="?", help="Entity name (e.g. account)")
    parser.add_argument("--all", action="store_true", help="Process all entities")
    parser.add_argument("--config", default=DEFAULT_CONFIG, help="Path to config.local.json")
    parser.add_argument("--d365-dir", default=DEFAULT_D365_DIR, help="Path to d365-entities/ directory")
    parser.add_argument("--performance-report", action="store_true", help="Generate performance report")

    args = parser.parse_args()

    if not args.entity and not args.all:
        parser.error("Provide an entity name or use --all")

    # Load config and authenticate
    config = load_config(args.config)
    print("Acquiring access token...")
    access_token = get_access_token(config)
    print("  Token acquired.")

    # Test connection
    print("Testing TDS connection...")
    try:
        conn = create_connection(config, access_token)
        cursor = conn.cursor()
        cursor.execute("SELECT TOP 1 name FROM account")
        row = cursor.fetchone()
        print(f"  Connection OK. Sample: {row[0] if row else 'no data'}")
        cursor.close()
        conn.close()
    except Exception as e:
        print(f"  Connection test failed: {e}", file=sys.stderr)
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

    perf_log = [] if args.performance_report else None

    # Process entities
    successful = 0
    failed = 0

    for json_path in json_files:
        entity = os.path.splitext(os.path.basename(json_path))[0]
        print(f"\n--- {entity} ---")
        try:
            if process_entity(config, access_token, json_path, perf_log):
                successful += 1
            else:
                failed += 1
        except Exception as e:
            print(f"  Unexpected error: {e}", file=sys.stderr)
            failed += 1

    # Summary
    print(f"\nComplete: {successful} successful, {failed} failed.")

    # Performance report
    if perf_log is not None:
        report_path = os.path.join(PROJECT_DIR, "plans", "tds_performance_report.md")
        write_performance_report(perf_log, report_path)


if __name__ == "__main__":
    main()
