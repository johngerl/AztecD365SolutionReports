#!/usr/bin/env python3
"""
pipeline_shared.py

Shared utility functions used by multiple pipeline steps.

Functions:
    camel_to_snake        — Convert camelCase to snake_case
    convert_keys_to_snake — Recursively convert dict keys from camelCase to snake_case
    adapt_json_fields     — Convert enriched JSON field dicts to parse-output key format
    count_field_references — Pre-compute per-field reference counts for each section
    is_stale              — Check if a lastUpdate value indicates stale data

Constants:
    SECTION_KEYS      — JSON section keys used for usage-based mapping decisions
    STALENESS_CUTOFF  — timedelta for staleness threshold (365 days)
    SF_SUGGESTED_KEYS — JSON keys for sfSuggested* fields
"""

import re
from collections import defaultdict
from datetime import datetime, timedelta


# ---------------------------------------------------------------------------
# Shared constants
# ---------------------------------------------------------------------------

# JSON section keys used for usage-based mapping decisions
SECTION_KEYS = [
    "forms", "views", "chartVisualizations", "reports", "dashboards",
    "workflows", "javaScript", "formulas", "plugins", "pcfControls",
    "relationships", "ribbon",
]

# sfSuggested* JSON keys (excluding sfSuggestedMapping)
SF_SUGGESTED_KEYS = [
    "sfSuggestedObjectName",
    "sfSuggestedFieldDisplayName",
    "sfSuggestedFieldApiName",
    "sfSuggestedDataType",
    "sfSuggestedMatchTier",
]

STALENESS_CUTOFF = timedelta(days=365)


# ---------------------------------------------------------------------------
# Staleness check
# ---------------------------------------------------------------------------

def is_stale(last_update_str):
    """Check if a lastUpdate value indicates stale data.

    Returns True (stale), False (recent), or None (unknown/unparseable).
    """
    if not last_update_str:
        return None
    if last_update_str == "Never":
        return True
    try:
        last_dt = datetime.strptime(last_update_str, "%Y-%m-%d %H:%M:%S")
        return (datetime.now() - last_dt) > STALENESS_CUTOFF
    except (ValueError, TypeError):
        return None


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
        'last_update': jf.get('lastUpdate', ''),
        'display_mask': jf.get('displayMask', ''),
        'valid_for_create': jf.get('validForCreate', False),
        'valid_for_read': jf.get('validForRead', False),
        'valid_for_update': jf.get('validForUpdate', False),
        'is_searchable': jf.get('isSearchable', False),
        'is_filterable': jf.get('isFilterable', False),
        'is_sortable': jf.get('isSortable', False),
        'is_global_filter_enabled': jf.get('isGlobalFilterEnabled', False),
        'is_logical': jf.get('isLogical', False),
        'is_retrievable': jf.get('isRetrievable', False),
        'is_data_source_secret': jf.get('isDataSourceSecret', False),
        'sf_suggested_mapping': jf.get('sfSuggestedMapping', False),
        'sf_suggested_object': jf.get('sfSuggestedObjectName') or '',
        'sf_suggested_display': jf.get('sfSuggestedFieldDisplayName') or '',
        'sf_suggested_api': jf.get('sfSuggestedFieldApiName') or '',
        'sf_suggested_data_type': jf.get('sfSuggestedDataType') or '',
        'sf_suggested_match_tier': jf.get('sfSuggestedMatchTier') or '',
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
