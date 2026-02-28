#!/usr/bin/env python3
"""
enrich_entity_json.py

Derives entity/field definitions from SolutionExtract/customizations.xml,
enriches each field with 13 per-field section datasets (including JavaScript),
and merges Salesforce mapping data from mapping/ CSV files.

No dependency on external Migration JSON files.

Usage:
    python enrich_entity_json.py account
    python enrich_entity_json.py --all
    python enrich_entity_json.py --all --mapping-dir PATH --output-dir PATH
"""

import csv
import json
import os
import sys
import argparse
import xml.etree.ElementTree as ET
from collections import defaultdict

# ---------------------------------------------------------------------------
# Import parse functions from generate_field_usage.py (sibling module)
# ---------------------------------------------------------------------------

SCRIPTS_DIR = os.path.dirname(os.path.abspath(__file__))
if SCRIPTS_DIR not in sys.path:
    sys.path.insert(0, SCRIPTS_DIR)

from generate_field_usage import (
    discover_entities,
    parse_field_definitions,
    parse_forms,
    parse_views,
    parse_chart_visualizations,
    parse_reports,
    parse_dashboards,
    parse_workflows,
    parse_javascript_files,
    parse_formulas,
    parse_plugin_sources,
    parse_pcf_controls,
    parse_relationships,
    parse_ribbon,
    compute_conflicts,
    build_property_lookup,
    CUSTOMIZATIONS_FILE,
    PLUGINS_DIR,
)

# ---------------------------------------------------------------------------
# Constants
# ---------------------------------------------------------------------------

PROJECT_DIR = os.path.dirname(SCRIPTS_DIR)
DEFAULT_MAPPING_DIR = os.path.join(PROJECT_DIR, "mapping")
DEFAULT_OUTPUT_DIR = os.path.join(PROJECT_DIR, "json")
REPORTS_DIR = os.path.join(PROJECT_DIR, "reports")

SECTION_KEYS = [
    'forms', 'views', 'chartVisualizations', 'reports', 'dashboards',
    'workflows', 'javaScript', 'formulas', 'plugins', 'pcfControls',
    'relationships', 'ribbon', 'conflicts',
]

SF_COLUMNS = [
    "sfObjectName",
    "sfFieldDisplayName",
    "sfFieldApiName",
    "sfSuggestedObjectName",
    "sfSuggestedFieldDisplayName",
    "sfSuggestedFieldApiName",
]


# ---------------------------------------------------------------------------
# camelCase key conversion
# ---------------------------------------------------------------------------

def snake_to_camel(name):
    """Convert snake_case to camelCase: 'form_type' -> 'formType'."""
    parts = name.split('_')
    return parts[0] + ''.join(p.capitalize() for p in parts[1:])


def convert_keys_to_camel(obj):
    """Recursively convert all dict keys from snake_case to camelCase.

    Also converts sets to sorted lists for JSON serialization.
    """
    if isinstance(obj, dict):
        return {snake_to_camel(k): convert_keys_to_camel(v) for k, v in obj.items()}
    if isinstance(obj, list):
        return [convert_keys_to_camel(item) for item in obj]
    if isinstance(obj, set):
        return sorted(obj)
    if isinstance(obj, defaultdict):
        return {snake_to_camel(k): convert_keys_to_camel(v) for k, v in obj.items()}
    return obj


def json_serializer(obj):
    """Fallback serializer for types json.dumps cannot handle."""
    if isinstance(obj, set):
        return sorted(obj)
    if isinstance(obj, defaultdict):
        return dict(obj)
    raise TypeError(f"Object of type {type(obj).__name__} is not JSON serializable")


# ---------------------------------------------------------------------------
# Mapping CSV loader
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
                    col: row.get(col, "") or None for col in SF_COLUMNS
                }
    return mapping


# ---------------------------------------------------------------------------
# Per-field reference extraction
# ---------------------------------------------------------------------------

def build_per_field_refs(forms, views, chart_visualizations, reports, dashboards,
                         workflows, js_files, formulas, plugin_refs, pcf_controls,
                         relationships, ribbon, conflicts):
    """Build a dict mapping field_name_lower -> {section: [references]}.

    Each reference is a detailed record showing exactly where/how the field
    is used within that section.
    """
    refs = defaultdict(lambda: {k: [] for k in SECTION_KEYS})

    # --- Forms ---
    for form in forms:
        form_name = form['name']
        form_type = form['form_type']
        form_id = form['form_id']
        is_active = form['is_active']

        for hf in form['header_fields']:
            fn = hf['name'].lower()
            refs[fn]['forms'].append({
                'form_name': form_name, 'form_type': form_type,
                'form_id': form_id, 'is_active': is_active,
                'location': 'header', 'label': hf['label'],
                'visible': 'true', 'disabled': 'false',
            })

        for tab in form['tabs']:
            for section in tab['sections']:
                for fld in section['fields']:
                    if fld['is_subgrid'] or fld['is_webresource']:
                        continue
                    fn = fld['name'].lower()
                    refs[fn]['forms'].append({
                        'form_name': form_name, 'form_type': form_type,
                        'form_id': form_id, 'is_active': is_active,
                        'location': f"{tab['label']} > {section['label'] or section['name']}",
                        'label': fld['label'],
                        'visible': fld['visible'], 'disabled': fld['disabled'],
                    })

        for ff in form['footer_fields']:
            fn = ff['name'].lower()
            refs[fn]['forms'].append({
                'form_name': form_name, 'form_type': form_type,
                'form_id': form_id, 'is_active': is_active,
                'location': 'footer', 'label': ff['label'],
                'visible': 'true', 'disabled': 'false',
            })

    # --- Views ---
    for view in views:
        view_name = view['name']
        query_type = view['query_type_name']

        for col in view['columns']:
            fn = col['name'].lower()
            refs[fn]['views'].append({
                'view_name': view_name, 'query_type': query_type,
                'usage': 'column', 'width': col['width'],
            })

        for fc in view['filter_fields']:
            fn = fc['field'].lower()
            refs[fn]['views'].append({
                'view_name': view_name, 'query_type': query_type,
                'usage': 'filter', 'operator': fc['operator'], 'value': fc['value'],
            })

        for sf in view['sort_fields']:
            fn = sf['field'].lower()
            refs[fn]['views'].append({
                'view_name': view_name, 'query_type': query_type,
                'usage': 'sort', 'descending': sf['descending'],
            })

    # --- Chart Visualizations ---
    for chart in chart_visualizations:
        chart_name = chart['name']

        for mf in chart['measure_fields']:
            fn = mf['field'].lower()
            refs[fn]['chartVisualizations'].append({
                'chart_name': chart_name, 'usage': 'measure',
                'aggregate': mf['aggregate'], 'alias': mf['alias'],
            })

        for gf in chart['groupby_fields']:
            fn = gf['field'].lower()
            refs[fn]['chartVisualizations'].append({
                'chart_name': chart_name, 'usage': 'groupby',
                'alias': gf['alias'], 'dategrouping': gf.get('dategrouping', ''),
            })

        for ff in chart['filter_fields']:
            fn = ff['field'].lower()
            refs[fn]['chartVisualizations'].append({
                'chart_name': chart_name, 'usage': 'filter',
                'operator': ff['operator'], 'value': ff['value'],
            })

        for sf in chart['sort_fields']:
            fn = sf['field'].lower()
            refs[fn]['chartVisualizations'].append({
                'chart_name': chart_name, 'usage': 'sort',
                'descending': sf['descending'],
            })

    # --- Reports ---
    def collect_report_link_refs(link_list, report_name, dataset_name):
        for le in link_list:
            for attr in le['attributes']:
                refs[attr.lower()]['reports'].append({
                    'report_name': report_name, 'dataset': dataset_name,
                    'entity': le['entity'], 'usage': 'attribute',
                    'link_type': le['link_type'], 'alias': le['alias'],
                })
            for cond in le['conditions']:
                refs[cond['field'].lower()]['reports'].append({
                    'report_name': report_name, 'dataset': dataset_name,
                    'entity': le['entity'], 'usage': 'condition',
                    'operator': cond['operator'], 'value': cond['value'],
                    'link_type': le['link_type'], 'alias': le['alias'],
                })
            for order in le['orders']:
                refs[order['field'].lower()]['reports'].append({
                    'report_name': report_name, 'dataset': dataset_name,
                    'entity': le['entity'], 'usage': 'order',
                    'descending': order['descending'],
                    'link_type': le['link_type'], 'alias': le['alias'],
                })
            if le.get('nested_links'):
                collect_report_link_refs(le['nested_links'], report_name, dataset_name)

    for rpt in reports:
        report_name = rpt['name']
        for ds in rpt['datasets']:
            dataset_name = ds['name']
            for fd in ds['fetchxml_data']:
                for attr in fd['attributes']:
                    refs[attr.lower()]['reports'].append({
                        'report_name': report_name, 'dataset': dataset_name,
                        'entity': fd['entity'], 'usage': 'attribute',
                    })
                for cond in fd['conditions']:
                    refs[cond['field'].lower()]['reports'].append({
                        'report_name': report_name, 'dataset': dataset_name,
                        'entity': fd['entity'], 'usage': 'condition',
                        'operator': cond['operator'], 'value': cond['value'],
                    })
                for order in fd['orders']:
                    refs[order['field'].lower()]['reports'].append({
                        'report_name': report_name, 'dataset': dataset_name,
                        'entity': fd['entity'], 'usage': 'order',
                        'descending': order['descending'],
                    })
                collect_report_link_refs(fd['link_entities'], report_name, dataset_name)

    # --- Dashboards ---
    # Dashboards reference views/charts by ID, not fields directly.
    # No per-field refs to emit.

    # --- Workflows ---
    for wf in workflows:
        wf_name = wf['name']
        wf_file = wf['file']
        for fn in wf['fields_read']:
            refs[fn.lower()]['workflows'].append({
                'workflow_name': wf_name, 'file': wf_file, 'usage': 'read',
            })
        for fn in wf['fields_written']:
            refs[fn.lower()]['workflows'].append({
                'workflow_name': wf_name, 'file': wf_file, 'usage': 'write',
            })

    # --- JavaScript ---
    for js in js_files:
        js_file = js['file']
        # File-level field refs (read/write/control)
        for field_name, usage_flags in js['field_refs'].items():
            usages = [k for k, v in usage_flags.items() if v]
            if usages:
                refs[field_name.lower()]['javaScript'].append({
                    'file': js_file, 'usage': usages,
                })

        # Function-level field refs (per function, per field with operations)
        for func_name, func_field_refs in js['func_fields'].items():
            for field_name, operations in func_field_refs.items():
                refs[field_name.lower()]['javaScript'].append({
                    'file': js_file, 'function': func_name,
                    'usage': operations,
                })

    # --- Formulas ---
    for formula in formulas:
        target_fn = formula['field'].lower()
        refs[target_fn]['formulas'].append({
            'field': formula['field'], 'file': formula['file'],
            'usage': 'target', 'formula_type': formula['formula_type'],
            'aggregation': formula['aggregation'],
            'source_entity': formula['source_entity'],
        })
        for sf in formula['source_fields']:
            fn = sf['field'].lower()
            refs[fn]['formulas'].append({
                'field': formula['field'], 'file': formula['file'],
                'usage': 'source', 'formula_type': formula['formula_type'],
                'source_entity': sf.get('entity', ''),
            })

    # --- Plugins ---
    for plugin in plugin_refs:
        class_name = plugin['class_name']
        p_file = plugin['file']
        target_entity = plugin['target_entity']
        message = plugin['message']

        base = {
            'class_name': class_name, 'file': p_file,
            'target_entity': target_entity, 'message': message,
        }
        for fn in plugin['fields_read']:
            refs[fn.lower()]['plugins'].append({**base, 'usage': 'read'})
        for fn in plugin['fields_written']:
            refs[fn.lower()]['plugins'].append({**base, 'usage': 'write'})
        for fn in plugin['fields_filtered']:
            refs[fn.lower()]['plugins'].append({**base, 'usage': 'filter'})
        for fn in plugin['fields_sorted']:
            refs[fn.lower()]['plugins'].append({**base, 'usage': 'sort'})
        for fn in plugin['fields_joined']:
            refs[fn.lower()]['plugins'].append({**base, 'usage': 'join'})
        for fn in plugin['image_fields']:
            refs[fn.lower()]['plugins'].append({**base, 'usage': 'image'})

    # --- PCF Controls ---
    for ctrl in pcf_controls:
        ctrl_name = ctrl.get('display_name') or ctrl.get('constructor', '')
        for prop in ctrl['bound_properties']:
            if prop['name']:
                refs[prop['name'].lower()]['pcfControls'].append({
                    'control_name': ctrl_name,
                    'namespace': ctrl['namespace'],
                    'property_name': prop['name'],
                    'property_type': prop['type'],
                    'usage': 'bound',
                })
        for prop in ctrl['input_properties']:
            if prop['name']:
                refs[prop['name'].lower()]['pcfControls'].append({
                    'control_name': ctrl_name,
                    'namespace': ctrl['namespace'],
                    'property_name': prop['name'],
                    'property_type': prop['type'],
                    'usage': 'input',
                })

    # --- Relationships ---
    for rel in relationships:
        if rel['referencing_attribute']:
            fn = rel['referencing_attribute'].lower()
            refs[fn]['relationships'].append({
                'relationship_name': rel['name'],
                'type': rel['type'],
                'referenced_entity': rel['referenced_entity'],
                'referencing_entity': rel['referencing_entity'],
            })

    # --- Ribbon ---
    # Ribbon defines buttons/commands, not field-level references.
    # No per-field refs to emit.

    # --- Conflicts ---
    for conflict in conflicts.get('per_form_conflicts', []):
        fn = conflict['field'].lower()
        refs[fn]['conflicts'].append({
            'type': 'per_form_conflict',
            'inconsistent_visibility': conflict['inconsistent_visibility'],
            'inconsistent_disabled': conflict['inconsistent_disabled'],
            'entries': conflict['entries'],
        })

    code_not_on_forms = set(conflicts.get('in_code_not_on_forms', []))
    forms_not_in_logic = set(conflicts.get('on_forms_not_in_logic', []))
    for fn in code_not_on_forms:
        refs[fn.lower()]['conflicts'].append({'type': 'in_code_not_on_forms'})
    for fn in forms_not_in_logic:
        refs[fn.lower()]['conflicts'].append({'type': 'on_forms_not_in_logic'})

    return refs


# ---------------------------------------------------------------------------
# Entity enrichment
# ---------------------------------------------------------------------------

def enrich_entity(entity_name, root, property_to_field, class_to_entity, mapping_dir):
    """Derive fields from customizations.xml, parse all 13 sections, merge SF
    mapping data from CSV, and return the enriched entity dict.

    Returns (enriched_dict, total_refs).
    """
    entity_name = entity_name.lower()
    empty_sections = {k: [] for k in SECTION_KEYS}

    # Find entity element in customizations.xml
    entity_el = None
    for el in root.findall(".//Entity"):
        name_el = el.find("Name")
        if name_el is not None and name_el.text and name_el.text.lower() == entity_name:
            entity_el = el
            break

    if entity_el is None:
        print(f"  WARNING: '{entity_name}' not found in customizations.xml — skipping")
        return None, 0

    # Field definitions from customizations.xml (authoritative source)
    field_defs = parse_field_definitions(entity_el)
    known_fields = {f['schema_name'] for f in field_defs}

    # Load SF mapping from CSV
    sf_mapping = load_mapping_csv(mapping_dir, entity_name)

    # Call all 13 parse functions
    forms = parse_forms(entity_el)
    views = parse_views(entity_el)
    chart_visualizations = parse_chart_visualizations(entity_el, entity_name)
    reports = parse_reports(entity_name, known_fields)
    dashboards = parse_dashboards(entity_name, root)
    workflows = parse_workflows(entity_name, known_fields, cust_root=root)
    js_files = parse_javascript_files(entity_name, known_fields)
    formulas = parse_formulas(entity_name)
    plugin_refs = parse_plugin_sources(entity_name, PLUGINS_DIR, property_to_field, class_to_entity)
    pcf_controls = parse_pcf_controls()
    relationships = parse_relationships(root, entity_name)
    ribbon = parse_ribbon(entity_el)

    conflicts = compute_conflicts(
        entity_name, field_defs, forms, views, workflows, js_files,
        formulas, plugin_refs, chart_visualizations, reports
    )

    # Build per-field reference lookup (now includes js_files)
    per_field = build_per_field_refs(
        forms, views, chart_visualizations, reports, dashboards,
        workflows, js_files, formulas, plugin_refs, pcf_controls,
        relationships, ribbon, conflicts
    )

    # Build output
    enriched_fields = []
    total_refs = 0

    for fdef in field_defs:
        fn_lower = fdef['schema_name'].lower()

        # Base field properties from customizations.xml
        field_out = {
            'fieldName': fdef['schema_name'],
            'displayName': fdef['display_name'],
            'dataType': fdef['data_type'],
            'requiredLevel': fdef['required_level'],
            'isCustom': fdef['is_custom'],
            'introducedVersion': fdef['introduced_version'],
        }

        # SF mapping from CSV (null if no mapping row exists)
        sf_row = sf_mapping.get(fn_lower, {})
        for col in SF_COLUMNS:
            val = sf_row.get(col)
            field_out[col] = val if val else None

        # 13 section datasets
        field_refs = per_field.get(fn_lower, empty_sections)
        for section_key in SECTION_KEYS:
            section_data = field_refs.get(section_key, [])
            field_out[section_key] = convert_keys_to_camel(section_data)
            total_refs += len(section_data)

        enriched_fields.append(field_out)

    enriched = {
        'entityName': entity_name,
        'fields': enriched_fields,
    }

    return enriched, total_refs


# ---------------------------------------------------------------------------
# Post-generation cleanup
# ---------------------------------------------------------------------------

def cleanup_orphan_jsons(output_dir, reports_dir):
    """Delete output JSONs that have no matching field_usage report."""
    report_entities = set()
    if os.path.isdir(reports_dir):
        for f in os.listdir(reports_dir):
            if f.endswith('_field_usage.md'):
                report_entities.add(f.replace('_field_usage.md', ''))

    removed = []
    for f in os.listdir(output_dir):
        if f.endswith('.json'):
            entity = f.replace('.json', '')
            if entity not in report_entities:
                os.remove(os.path.join(output_dir, f))
                removed.append(entity)

    return removed


# ---------------------------------------------------------------------------
# Main
# ---------------------------------------------------------------------------

def main():
    parser = argparse.ArgumentParser(
        description='Enrich D365CE entity JSON fields with per-field solution analysis data'
    )
    parser.add_argument('entity', nargs='?', default=None,
                        help='Target entity schema name (e.g., account, contact)')
    parser.add_argument('--all', action='store_true',
                        help='Enrich all entities from customizations.xml')
    parser.add_argument('--mapping-dir', default=DEFAULT_MAPPING_DIR,
                        help=f'Mapping CSV directory (default: {DEFAULT_MAPPING_DIR})')
    parser.add_argument('--output-dir', default=DEFAULT_OUTPUT_DIR,
                        help=f'Output JSON directory (default: {DEFAULT_OUTPUT_DIR})')
    args = parser.parse_args()

    if not args.all and not args.entity:
        parser.error('either provide an entity name or use --all')

    mapping_dir = args.mapping_dir
    output_dir = args.output_dir

    os.makedirs(output_dir, exist_ok=True)

    print("=" * 60)
    print("D365CE Entity JSON Enrichment (per-field, 13 sections)")
    print("=" * 60)
    print()

    # Parse customizations.xml once
    print("Parsing customizations.xml...")
    root = ET.parse(CUSTOMIZATIONS_FILE).getroot()
    print("  Done.")

    # Build plugin property lookup once
    print("Building plugin property lookup...")
    property_to_field, class_to_entity = build_property_lookup(PLUGINS_DIR)
    print(f"  Property mappings: {len(property_to_field)}")
    print(f"  Entity classes: {len(class_to_entity)}")

    # Determine entities to process
    if args.all:
        entity_list = [e.lower() for e in discover_entities(root)]
        print(f"\nFound {len(entity_list)} entities in customizations.xml.")
    else:
        entity_list = [args.entity.lower()]

    success = 0
    skipped = 0

    for entity_name in entity_list:
        print(f"\nEnriching {entity_name}...")

        enriched, total_refs = enrich_entity(
            entity_name, root, property_to_field, class_to_entity, mapping_dir
        )

        if enriched is None:
            skipped += 1
            continue

        output_file = os.path.join(output_dir, f"{entity_name}.json")
        with open(output_file, 'w', encoding='utf-8') as f:
            json.dump(enriched, f, indent=2, ensure_ascii=False, default=json_serializer)

        field_count = len(enriched.get('fields', []))
        enriched_count = sum(
            1 for fld in enriched.get('fields', [])
            if any(fld.get(k) for k in SECTION_KEYS if k != 'dashboards')
        )
        sf_count = sum(
            1 for fld in enriched.get('fields', [])
            if any(fld.get(c) for c in SF_COLUMNS)
        )
        print(f"  {field_count} fields, {enriched_count} with refs, {sf_count} with SF mapping, {total_refs} total references")
        print(f"  -> {output_file}")
        success += 1

    # Post-generation cleanup for --all
    if args.all:
        removed = cleanup_orphan_jsons(output_dir, REPORTS_DIR)
        if removed:
            print(f"\nRemoved {len(removed)} orphan JSONs (no matching report): {', '.join(sorted(removed))}")

    print()
    print("=" * 60)
    print(f"Enrichment complete: {success} succeeded, {skipped} skipped out of {len(entity_list)} total.")
    print("=" * 60)


if __name__ == '__main__':
    main()
