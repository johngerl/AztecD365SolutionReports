#!/usr/bin/env python3
"""
generate_d365_entity_csv_mapping.py

Step 8 of the pipeline. Run steps 1-7 first.

Extracts mapping CSVs from enriched d365-entities/ JSON files. Preserves
confirmed SF mapping columns (sfObjectName, sfFieldDisplayName, sfFieldApiName)
from existing CSVs. Reads sfSuggested* and sfSuggestedMapping from JSON.

Usage:
    python generate_d365_entity_csv_mapping.py account   # single entity
    python generate_d365_entity_csv_mapping.py --all     # all source JSONs
"""

import csv
import json
import os
import sys
import argparse

SCRIPTS_DIR = os.path.dirname(os.path.abspath(__file__))
PROJECT_DIR = os.path.dirname(SCRIPTS_DIR)
DEFAULT_SOURCE_DIR = os.path.join(PROJECT_DIR, "d365-entities")
DEFAULT_MAPPING_DIR = os.path.join(PROJECT_DIR, "mapping")

SF_CONFIRMED_COLUMNS = [
    "sfObjectName",
    "sfFieldDisplayName",
    "sfFieldApiName",
]

SF_SUGGESTED_COLUMNS = [
    "sfSuggestedObjectName",
    "sfSuggestedFieldDisplayName",
    "sfSuggestedFieldApiName",
]

SF_COLUMNS = SF_CONFIRMED_COLUMNS + SF_SUGGESTED_COLUMNS

D365_COLUMNS = ["displayName", "dataType", "requiredLevel", "isCustom", "lastUpdate"]
REPORT_COLUMNS = ["picklistValues", "mappingSuggested"]

# Reference count columns: CSV header -> JSON count property (set by Step 4)
REF_COUNT_COLUMNS = [
    ("refForms", "countForms"),
    ("refViews", "countViews"),
    ("refChartVisualizations", "countChartVisualizations"),
    ("refReports", "countReports"),
    ("refDashboards", "countDashboards"),
    ("refWorkflows", "countWorkflows"),
    ("refFormulas", "countFormulasAndRollups"),
    ("refPlugins", "countPlugins"),
    ("refPcfControls", "countPCFControls"),
    ("refRelationships", "countRelationships"),
    ("refRibbon", "countRibbonCustomizations"),
]

CSV_COLUMNS = (D365_COLUMNS + REPORT_COLUMNS
               + [col for col, _ in REF_COUNT_COLUMNS] + SF_COLUMNS)


def load_existing_csv(csv_path):
    """Load confirmed SF columns from an existing mapping CSV, keyed by fieldName."""
    confirmed = {}
    if not os.path.isfile(csv_path):
        return confirmed
    with open(csv_path, "r", encoding="utf-8") as f:
        reader = csv.DictReader(f)
        for row in reader:
            field_name = row.get("fieldName", "")
            if field_name:
                confirmed[field_name] = {
                    col: row.get(col, "") for col in SF_CONFIRMED_COLUMNS
                }
    return confirmed


def extract_mapping(source_file, output_file):
    """Read a source JSON, preserve confirmed SF columns, write mapping CSV."""
    with open(source_file, "r", encoding="utf-8") as f:
        data = json.load(f)

    # Load confirmed SF mappings from existing CSV (if any)
    existing_sf = load_existing_csv(output_file)

    header = ["fieldName"] + CSV_COLUMNS
    rows = []
    for field in data.get("fields", []):
        field_name = field.get("fieldName", "")

        # Format picklist values
        pv = field.get("picklistValues")
        if isinstance(pv, list):
            pv_str = ', '.join(
                f'{v.get("value", "")}: {v.get("label", "")}' for v in pv
            ) if pv else ''
        else:
            pv_str = str(pv) if pv else ''

        # Read mappingSuggested from JSON (set by Step 6)
        mapping_suggested = "true" if field.get("sfSuggestedMapping", False) else "false"

        row = {
            "fieldName": field_name,
            "displayName": field.get("displayName", ""),
            "dataType": field.get("dataType", ""),
            "requiredLevel": field.get("requiredLevel", ""),
            "isCustom": str(field.get("isCustom", False)),
            "lastUpdate": field.get("lastUpdate", ""),
            "picklistValues": pv_str,
            "mappingSuggested": mapping_suggested,
        }

        # Reference counts from pre-computed count properties (set by Step 4)
        for csv_col, json_key in REF_COUNT_COLUMNS:
            row[csv_col] = field.get(json_key, 0)

        # Preserve confirmed SF columns from existing CSV
        prev = existing_sf.get(field_name, {})
        for col in SF_CONFIRMED_COLUMNS:
            row[col] = prev.get(col, "")

        # Read sfSuggested* columns from JSON (source of truth)
        row["sfSuggestedObjectName"] = field.get("sfSuggestedObjectName") or ""
        row["sfSuggestedFieldDisplayName"] = field.get("sfSuggestedFieldDisplayName") or ""
        row["sfSuggestedFieldApiName"] = field.get("sfSuggestedFieldApiName") or ""

        rows.append(row)

    rows.sort(key=lambda r: r["fieldName"].lower())

    os.makedirs(os.path.dirname(output_file), exist_ok=True)
    with open(output_file, "w", encoding="utf-8", newline="") as f:
        writer = csv.DictWriter(f, fieldnames=header)
        writer.writeheader()
        writer.writerows(rows)

    return len(rows)


def main():
    parser = argparse.ArgumentParser(
        description="Extract Salesforce mapping data from source JSONs into CSV files"
    )
    parser.add_argument(
        "entity", nargs="?", default=None,
        help="Entity name (e.g., account, contact)"
    )
    parser.add_argument(
        "--all", action="store_true",
        help="Process all source JSON files"
    )
    parser.add_argument(
        "--source-dir", default=DEFAULT_SOURCE_DIR,
        help=f"Source JSON directory (default: {DEFAULT_SOURCE_DIR})"
    )
    parser.add_argument(
        "--mapping-dir", default=DEFAULT_MAPPING_DIR,
        help=f"Output CSV directory (default: {DEFAULT_MAPPING_DIR})"
    )
    args = parser.parse_args()

    if not args.all and not args.entity:
        parser.error("either provide an entity name or use --all")

    if not os.path.isdir(args.source_dir):
        print(f"ERROR: Source directory not found: {args.source_dir}", file=sys.stderr)
        sys.exit(1)

    print("=" * 60)
    print("Extract Salesforce Mapping CSVs")
    print("=" * 60)

    if args.all:
        json_files = sorted(f for f in os.listdir(args.source_dir) if f.endswith(".json"))
        entity_list = [os.path.splitext(f)[0] for f in json_files]
        print(f"Found {len(entity_list)} source JSON files.\n")
    else:
        entity_list = [args.entity.lower()]

    success = 0
    skipped = 0

    for entity_name in entity_list:
        source_file = os.path.join(args.source_dir, f"{entity_name}.json")
        if not os.path.isfile(source_file):
            print(f"  SKIP: {entity_name} — source JSON not found")
            skipped += 1
            continue

        output_file = os.path.join(args.mapping_dir, f"{entity_name}.csv")
        row_count = extract_mapping(source_file, output_file)
        print(f"  {entity_name}: {row_count} mapped fields -> {output_file}")
        success += 1

    print(f"\nDone: {success} CSVs written, {skipped} skipped.")


if __name__ == "__main__":
    main()
