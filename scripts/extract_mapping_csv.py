#!/usr/bin/env python3
"""
extract_mapping_csv.py

One-time extraction of Salesforce mapping fields from the Migration source
JSON files into per-entity CSV files in mapping/.

Once the CSVs exist, the enrichment script reads them instead of the external
Migration directory — decoupling this project from the source JSONs entirely.

Usage:
    python extract_mapping_csv.py account           # single entity
    python extract_mapping_csv.py --all             # all source JSONs
"""

import csv
import json
import os
import sys
import argparse

SCRIPTS_DIR = os.path.dirname(os.path.abspath(__file__))
PROJECT_DIR = os.path.dirname(SCRIPTS_DIR)
DEFAULT_SOURCE_DIR = os.path.normpath(
    os.path.join(PROJECT_DIR, "..", "Migration", "D365CE-Entities", "json")
)
DEFAULT_MAPPING_DIR = os.path.join(PROJECT_DIR, "mapping")

SF_COLUMNS = [
    "sfObjectName",
    "sfFieldDisplayName",
    "sfFieldApiName",
    "sfSuggestedObjectName",
    "sfSuggestedFieldDisplayName",
    "sfSuggestedFieldApiName",
]


def extract_mapping(source_file, output_file):
    """Read a source JSON and write a mapping CSV with non-empty SF rows."""
    with open(source_file, "r", encoding="utf-8") as f:
        data = json.load(f)

    rows = []
    for field in data.get("fields", []):
        field_name = field.get("fieldName", "")
        sf_values = {col: field.get(col) or "" for col in SF_COLUMNS}
        if any(sf_values.values()):
            rows.append({"fieldName": field_name, **sf_values})

    rows.sort(key=lambda r: r["fieldName"].lower())

    os.makedirs(os.path.dirname(output_file), exist_ok=True)
    with open(output_file, "w", encoding="utf-8", newline="") as f:
        writer = csv.DictWriter(f, fieldnames=["fieldName"] + SF_COLUMNS)
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
