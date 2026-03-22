#!/usr/bin/env python3
"""
compute_d365_reference_counts.py

Step 4 of the pipeline. Run steps 1-3 first.

Reads d365-entities/*.json and pre-computes reference counts from per-field
section arrays. Writes counts at both entity level (sum across all fields)
and field level (length of each section array) into the JSON.

Usage:
    python compute_d365_reference_counts.py account   # single entity
    python compute_d365_reference_counts.py --all     # all entities
"""

import argparse
import glob
import json
import os
import sys
from collections import OrderedDict

SCRIPT_DIR = os.path.dirname(os.path.abspath(__file__))
PROJECT_DIR = os.path.dirname(SCRIPT_DIR)
DEFAULT_D365_DIR = os.path.join(PROJECT_DIR, "d365-entities")

# Mapping: count property name -> JSON section array key
COUNT_COLUMNS = [
    ("countForms", "forms"),
    ("countViews", "views"),
    ("countChartVisualizations", "chartVisualizations"),
    ("countReports", "reports"),
    ("countDashboards", "dashboards"),
    ("countWorkflows", "workflows"),
    ("countFormulasAndRollups", "formulas"),
    ("countPlugins", "plugins"),
    ("countPCFControls", "pcfControls"),
    ("countRelationships", "relationships"),
    ("countRibbonCustomizations", "ribbon"),
]

COUNT_KEYS = [k for k, _ in COUNT_COLUMNS]


# ---------------------------------------------------------------------------
# Key ordering helpers
# ---------------------------------------------------------------------------

def insert_entity_counts(data, counts):
    """Insert entity-level count properties after primaryNameField."""
    # Remove existing count keys first
    for key in COUNT_KEYS:
        data.pop(key, None)

    items = list(data.items())
    new_items = []
    inserted = False
    for k, v in items:
        new_items.append((k, v))
        if k == "primaryNameField" and not inserted:
            for count_key in COUNT_KEYS:
                new_items.append((count_key, counts.get(count_key, 0)))
            inserted = True

    if not inserted:
        # primaryNameField not found; append at end before sections
        for count_key in COUNT_KEYS:
            new_items.append((count_key, counts.get(count_key, 0)))

    data.clear()
    for k, v in new_items:
        data[k] = v


def insert_field_counts(field, counts):
    """Insert field-level count properties before the first section array key."""
    # Remove existing count keys first
    for key in COUNT_KEYS:
        field.pop(key, None)

    items = list(field.items())
    new_items = []
    inserted = False
    for k, v in items:
        if k == "forms" and not inserted:
            for count_key in COUNT_KEYS:
                new_items.append((count_key, counts.get(count_key, 0)))
            inserted = True
        new_items.append((k, v))

    if not inserted:
        for count_key in COUNT_KEYS:
            new_items.append((count_key, counts.get(count_key, 0)))

    field.clear()
    for k, v in new_items:
        field[k] = v


# ---------------------------------------------------------------------------
# Entity processing
# ---------------------------------------------------------------------------

def process_entity(entity_name, d365_dir):
    """Process a single entity: compute and write reference counts."""
    json_path = os.path.join(d365_dir, f"{entity_name}.json")
    if not os.path.isfile(json_path):
        print(f"  SKIP: {json_path} not found")
        return None

    with open(json_path, "r", encoding="utf-8") as f:
        data = json.load(f, object_pairs_hook=OrderedDict)

    fields = data.get("fields", [])
    entity_counts = {k: 0 for k in COUNT_KEYS}

    for field in fields:
        field_counts = {}
        for count_key, section_key in COUNT_COLUMNS:
            section = field.get(section_key)
            count = len(section) if isinstance(section, list) else 0
            field_counts[count_key] = count
            entity_counts[count_key] += count

        insert_field_counts(field, field_counts)

    insert_entity_counts(data, entity_counts)

    with open(json_path, "w", encoding="utf-8") as f:
        json.dump(data, f, indent=2, ensure_ascii=False)
        f.write("\n")

    total_refs = sum(entity_counts.values())
    print(f"  {entity_name}: {len(fields)} fields, {total_refs} total references")
    return entity_counts


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def main():
    parser = argparse.ArgumentParser(
        description="Step 4: Pre-compute reference counts into D365 entity JSON"
    )
    parser.add_argument("entity", nargs="?", default=None,
                        help="Target entity schema name (e.g., account, contact)")
    parser.add_argument("--all", action="store_true",
                        help="Process all entities in d365-entities/")
    parser.add_argument("--d365-dir", default=DEFAULT_D365_DIR,
                        help="Directory containing D365 entity JSONs")
    args = parser.parse_args()

    if not args.all and not args.entity:
        parser.error("Specify an entity name or --all")

    d365_dir = args.d365_dir

    if args.all:
        entities = sorted(
            os.path.splitext(os.path.basename(p))[0]
            for p in glob.glob(os.path.join(d365_dir, "*.json"))
        )
    else:
        entities = [args.entity.lower()]

    print("=" * 60)
    print(f"Step 4: Compute Reference Counts")
    print(f"  Entities: {len(entities)}")
    print("=" * 60)
    print()

    success = 0
    failed = 0

    for entity_name in entities:
        result = process_entity(entity_name, d365_dir)
        if result is not None:
            success += 1
        else:
            failed += 1

    print()
    print("=" * 60)
    print(f"Complete: {success} succeeded, {failed} failed")
    print("=" * 60)


if __name__ == "__main__":
    main()
