#!/usr/bin/env python3
"""
set_d365_sf_suggested_mapping.py

Step 6 of the pipeline. Run steps 1-5 first.

Reads d365-entities/*.json and sets sfSuggestedMapping (true/false) on each
field based on staleness gate + usage references + required level. This is the
single source of truth for "should this field be suggested for SF migration?"

When sfSuggestedMapping is set to false, clears all sfSuggested* fields to null.

Usage:
    python set_d365_sf_suggested_mapping.py account         # single entity
    python set_d365_sf_suggested_mapping.py --all           # all entities
    python set_d365_sf_suggested_mapping.py --all --reset   # clear all sfSuggested* first
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

sys.path.insert(0, SCRIPT_DIR)
from pipeline_shared import SECTION_KEYS, SF_SUGGESTED_KEYS, is_stale


# ---------------------------------------------------------------------------
# Core logic
# ---------------------------------------------------------------------------

def compute_sf_suggested_mapping(field):
    """Determine if a field should be suggested for SF migration.

    Returns True if the field has usage or is required AND is not stale.
    """
    staleness = is_stale(field.get("lastUpdate"))
    if staleness is True:
        return False

    has_usage = any(
        len(field.get(k) or []) > 0
        for k in SECTION_KEYS
    )
    required_level = (field.get("requiredLevel") or "").lower()
    is_required = required_level not in ("", "none")

    return has_usage or is_required


def ensure_key_order(field):
    """Ensure sfSuggestedMapping appears before sfSuggestedObjectName.

    Rebuilds the field OrderedDict if the key needs to be repositioned.
    """
    keys = list(field.keys())
    if "sfSuggestedMapping" in keys and "sfSuggestedObjectName" in keys:
        mapping_idx = keys.index("sfSuggestedMapping")
        object_idx = keys.index("sfSuggestedObjectName")
        if mapping_idx < object_idx:
            return field  # already in correct order

    # Rebuild with sfSuggestedMapping inserted before sfSuggestedObjectName
    new_field = OrderedDict()
    inserted = False
    for k, v in field.items():
        if k == "sfSuggestedMapping":
            continue  # will be inserted before sfSuggestedObjectName
        if k == "sfSuggestedObjectName" and not inserted:
            new_field["sfSuggestedMapping"] = field.get("sfSuggestedMapping", False)
            inserted = True
        new_field[k] = v
    if not inserted:
        # sfSuggestedObjectName not found; append at end
        new_field["sfSuggestedMapping"] = field.get("sfSuggestedMapping", False)
    return new_field


# ---------------------------------------------------------------------------
# Entity processing
# ---------------------------------------------------------------------------

def process_entity(entity_name, d365_dir, reset=False):
    """Process a single entity: set sfSuggestedMapping on all fields."""
    json_path = os.path.join(d365_dir, f"{entity_name}.json")
    if not os.path.isfile(json_path):
        print(f"  SKIP: {json_path} not found")
        return None

    with open(json_path, "r", encoding="utf-8") as f:
        data = json.load(f, object_pairs_hook=OrderedDict)

    fields = data.get("fields", [])
    total = len(fields)
    mapped_true = 0
    mapped_false = 0
    cleared = 0

    for i, field in enumerate(fields):
        # Optional reset: clear all sfSuggested* fields first
        if reset:
            for key in SF_SUGGESTED_KEYS:
                if field.get(key) is not None:
                    field[key] = None
                    cleared += 1

        # Compute the mapping flag
        should_map = compute_sf_suggested_mapping(field)
        field["sfSuggestedMapping"] = should_map

        # If not mapping, clear sfSuggested* fields
        if not should_map:
            for key in SF_SUGGESTED_KEYS:
                if field.get(key) is not None:
                    field[key] = None
                    cleared += 1
            mapped_false += 1
        else:
            mapped_true += 1

        # Ensure key ordering
        fields[i] = ensure_key_order(field)

    if should_map is not None or True:  # always write
        data["fields"] = fields
        with open(json_path, "w", encoding="utf-8") as f:
            json.dump(data, f, indent=2, ensure_ascii=False)
            f.write("\n")

    print(f"  {entity_name}: {total} fields — "
          f"{mapped_true} mapped, {mapped_false} not mapped, "
          f"{cleared} sfSuggested* cleared")
    return {"total": total, "mapped": mapped_true, "not_mapped": mapped_false,
            "cleared": cleared}


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def main():
    parser = argparse.ArgumentParser(
        description="Step 6: Set sfSuggestedMapping on D365 entity fields"
    )
    parser.add_argument("entity", nargs="?", default=None,
                        help="Target entity schema name (e.g., account, contact)")
    parser.add_argument("--all", action="store_true",
                        help="Process all entities in d365-entities/")
    parser.add_argument("--reset", action="store_true",
                        help="Clear all sfSuggested* fields before computing")
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
    print(f"Step 6: Set sfSuggestedMapping")
    if args.reset:
        print("  Mode: RESET (clearing all sfSuggested* first)")
    print(f"  Entities: {len(entities)}")
    print("=" * 60)
    print()

    totals = {"total": 0, "mapped": 0, "not_mapped": 0, "cleared": 0}
    success = 0
    failed = 0

    for entity_name in entities:
        result = process_entity(entity_name, d365_dir, reset=args.reset)
        if result:
            for k in totals:
                totals[k] += result[k]
            success += 1
        else:
            failed += 1

    print()
    print("=" * 60)
    print(f"Complete: {success} succeeded, {failed} failed")
    print(f"  Total fields: {totals['total']}")
    print(f"  Mapped (true): {totals['mapped']}")
    print(f"  Not mapped (false): {totals['not_mapped']}")
    print(f"  sfSuggested* cleared: {totals['cleared']}")
    print("=" * 60)


if __name__ == "__main__":
    main()
