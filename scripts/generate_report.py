#!/usr/bin/env python3
"""
generate_report.py

Reads enriched D365 entity JSON from d365-entities/ and mapping CSVs from
mapping/, then generates comprehensive Markdown field usage reports.

This is Step 4b of the pipeline. Run Steps 1-3 and 4a first.

Usage:
    python generate_report.py <entity> [--output-dir <path>]
    python generate_report.py --all
"""

import csv
import html
import json
import re
import os
import sys
import argparse
from collections import defaultdict
from datetime import date

PROJECT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
DEFAULT_OUTPUT_DIR = os.path.join(PROJECT_DIR, "reports")
DEFAULT_MAPPING_DIR = os.path.join(PROJECT_DIR, "mapping")
DEFAULT_D365_DIR = os.path.join(PROJECT_DIR, "d365-entities")


def slugify(text):
    text = text.lower()
    text = re.sub(r'[^\w\s-]', '', text)
    text = re.sub(r'[\s]+', '-', text)
    text = re.sub(r'-+', '-', text)
    return text.strip('-')


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
    """Convert enriched JSON field dicts to the parse-output key format
    expected by generate_markdown and other functions."""
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
# CSV READER (read-only, for report display)
# ---------------------------------------------------------------------------

def read_mapping_csv(mapping_dir, entity_name):
    """Read mapping CSV into a dict keyed by fieldName for report display."""
    csv_path = os.path.join(mapping_dir, f"{entity_name}.csv")
    if not os.path.isfile(csv_path):
        return {}
    mapping = {}
    with open(csv_path, "r", encoding="utf-8") as f:
        for row in csv.DictReader(f):
            fn = row.get("fieldName", "").lower()
            if fn:
                mapping[fn] = row
    return mapping


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
# MARKDOWN GENERATION
# ---------------------------------------------------------------------------

def generate_markdown(entity_name, fields, forms, views, chart_visualizations,
                      reports, dashboards,
                      workflows, js_files, formulas, plugin_refs, controls,
                      relationships, ribbon, conflicts,
                      sf_mapping=None, field_mapping_suggested=None):
    field_index = defaultdict(list)
    field_ref_counts = count_field_references(
        entity_name, forms, views, chart_visualizations,
        reports, dashboards, workflows, formulas,
        plugin_refs, controls, relationships, ribbon, conflicts
    )
    lines = []
    a = lines.append

    def ref(field_name, section_slug, desc):
        field_index[field_name.lower()].append((section_slug, desc))

    def fl(field_name):
        return f'[{field_name}](#index-{slugify(field_name)})'

    entity_title = entity_name.capitalize()
    today = date.today().isoformat()

    # HEADER
    a(f'# {entity_title} Field Usage Analysis')
    a(f'> Date: {today}')
    a('')

    # TABLE OF CONTENTS
    a('## Table of Contents')
    a('')
    a('- [1. Field Definitions](#1-field-definitions)')
    a('- [2. Forms](#2-forms)')
    for i, form in enumerate(forms, 1):
        status = "Active" if form['is_active'] else "Inactive"
        s = slugify(f"2{i} {form['name']} {form['form_type']} {status}")
        a(f'  - [2.{i}. {form["name"]} ({form["form_type"]}) -- {status}](#{s})')
    a('- [3. Views](#3-views)')
    for i, view in enumerate(views, 1):
        s = slugify(f"3{i} {view['name']}")
        a(f'  - [3.{i}. {view["name"]}](#{s})')
    a('- [4. Chart Visualizations](#4-chart-visualizations)')
    for i, chart in enumerate(chart_visualizations, 1):
        s = slugify(f"4{i} {chart['name']}")
        a(f'  - [4.{i}. {chart["name"]}](#{s})')
    a('- [5. Reports](#5-reports)')
    for i, rpt in enumerate(reports, 1):
        s = slugify(f"5{i} {rpt['name']}")
        a(f'  - [5.{i}. {rpt["name"]}](#{s})')
    a('- [6. Dashboards](#6-dashboards)')
    for i, dash in enumerate(dashboards, 1):
        s = slugify(f"6{i} {dash['name']}")
        a(f'  - [6.{i}. {dash["name"]}](#{s})')
    a('- [7. Workflows](#7-workflows)')
    for i, wf in enumerate(workflows, 1):
        s = slugify(f"7{i} {wf['name']}")
        a(f'  - [7.{i}. {wf["name"]}](#{s})')
    a('- [8. JavaScript Web Resources](#8-javascript-web-resources)')
    for i, js in enumerate(js_files, 1):
        s = slugify(f"8{i} {js['clean_name']}")
        a(f'  - [8.{i}. {js["clean_name"]}](#{s})')
    a('- [9. Formulas & Rollups](#9-formulas-rollups)')
    a('- [10. Plugin Source Code Analysis](#10-plugin-source-code-analysis)')
    for i, plugin in enumerate(plugin_refs, 1):
        s = slugify(f"10{i} {plugin['class_name']}")
        a(f'  - [10.{i}. {plugin["class_name"]}](#{s})')
    a('- [11. PCF Controls](#11-pcf-controls)')
    a('- [12. Relationships](#12-relationships)')
    a('- [13. Ribbon Customizations](#13-ribbon-customizations)')
    a('- [14. Conflicts & Observations](#14-conflicts-observations)')
    a('- [Index](#index)')
    a('')

    # 1. FIELD DEFINITIONS
    a('---')
    a('')
    a('## <a id="1-field-definitions"></a>1. Field Definitions')
    a('')
    a(f'Total fields: **{len(fields)}**')
    a('')
    a('| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |')
    a('|---|-------------|-------------|------|-----------------|--------|----------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|')
    section_cols = [
        ('forms', '#2-forms'),
        ('views', '#3-views'),
        ('charts', '#4-chart-visualizations'),
        ('reports', '#5-reports'),
        ('dashboards', '#6-dashboards'),
        ('workflows', '#7-workflows'),
        ('formulas', '#9-formulas-rollups'),
        ('plugins', '#10-plugin-source-code-analysis'),
        ('pcf', '#11-pcf-controls'),
        ('rels', '#12-relationships'),
        ('ribbon', '#13-ribbon-customizations'),
        ('conflicts', '#14-conflicts-observations'),
    ]
    _sf_mapping = sf_mapping or {}
    for i, field in enumerate(fields, 1):
        sn = field['schema_name']
        sn_lower = sn.lower()
        csv_row = _sf_mapping.get(sn_lower, {})
        # D365 metadata from CSV
        display_name = csv_row.get('displayName', '') or field.get('display_name', '')
        data_type = csv_row.get('dataType', '') or field.get('data_type', '')
        custom = 'Yes' if csv_row.get('isCustom', '') == 'True' else (
            'Yes' if field.get('is_custom') else 'No')
        required_level = csv_row.get('requiredLevel', '') or field.get('required_level', '')
        # Picklist values from CSV (pre-formatted)
        pv_str = csv_row.get('picklistValues', '')
        # SF mapping columns from CSV
        suggested = csv_row.get('mappingSuggested', 'false')
        sf_obj = csv_row.get('sfObjectName', '')
        sf_field_name = csv_row.get('sfFieldDisplayName', '')
        sf_api = csv_row.get('sfFieldApiName', '')
        sf_sug_obj = csv_row.get('sfSuggestedObjectName', '')
        sf_sug_field = csv_row.get('sfSuggestedFieldDisplayName', '')
        sf_sug_api = csv_row.get('sfSuggestedFieldApiName', '')
        sf_str = f'{suggested} | {sf_obj} | {sf_field_name} | {sf_api} | {sf_sug_obj} | {sf_sug_field} | {sf_sug_api}'
        # Section heatmap columns
        refs_for_field = field_ref_counts.get(sn_lower, {})
        cells = []
        for key, slug in section_cols:
            c = refs_for_field.get(key, 0)
            cells.append(f'[{c}]({slug})' if c > 0 else '')
        section_str = ' | '.join(cells)
        a(f'| {i} | {fl(sn)} | {display_name} | {data_type} | {pv_str} | {custom} | {required_level} | {sf_str} | {section_str} |')
        ref(sn, '1-field-definitions', 'Field Definitions')
    a('')

    # 2. FORMS
    a('---')
    a('')
    a('## <a id="2-forms"></a>2. Forms')
    a('')
    a(f'Total forms: **{len(forms)}**')
    a('')

    for i, form in enumerate(forms, 1):
        status = "Active" if form['is_active'] else "Inactive"
        heading = f'2.{i}. {form["name"]} ({form["form_type"]}) -- {status}'
        form_slug = slugify(f"2{i} {form['name']} {form['form_type']} {status}")
        a(f'### <a id="{form_slug}"></a>{heading}')
        a('')
        a(f'- **Form ID:** `{form["form_id"]}`')
        a(f'- **Presentation:** {form["presentation"]}')
        a(f'- **Status:** {status}')
        a('')

        if form['header_fields']:
            a('#### Header Fields')
            a('')
            a('| Field | Label |')
            a('|-------|-------|')
            for hf in form['header_fields']:
                a(f'| {fl(hf["name"])} | {hf["label"]} |')
                ref(hf['name'], form_slug, f'Form: {form["name"]} (Header)')
            a('')

        for tab in form['tabs']:
            a(f'#### Tab: {tab["label"]}')
            if tab['visible'] == 'false':
                a('*Hidden tab*')
            a('')
            for section in tab['sections']:
                slabel = section['label'] or section['name']
                a(f'##### Section: {slabel}')
                if section['visible'] == 'false':
                    a('*Hidden section*')
                a('')

                regular = [f for f in section['fields'] if not f['is_subgrid'] and not f['is_webresource']]
                subgrids = [f for f in section['fields'] if f['is_subgrid']]
                webres = [f for f in section['fields'] if f['is_webresource']]

                if regular:
                    a('| Field | Label | Disabled | Visible |')
                    a('|-------|-------|----------|---------|')
                    for fld in regular:
                        dis = 'Yes' if fld['disabled'] == 'true' else 'No'
                        vis = 'No' if fld['visible'] == 'false' else 'Yes'
                        a(f'| {fl(fld["name"])} | {fld["label"]} | {dis} | {vis} |')
                        ref(fld['name'], form_slug, f'Form: {form["name"]} > {tab["label"]} > {slabel}')
                    a('')

                if subgrids:
                    a('**Subgrids:**')
                    a('')
                    a('| Control ID | Related Entity | Relationship |')
                    a('|------------|---------------|-------------|')
                    for sg in subgrids:
                        a(f'| {sg["control_id"]} | {sg["subgrid_entity"]} | {sg["subgrid_relationship"]} |')
                    a('')

                if webres:
                    a('**Embedded Web Resources:**')
                    a('')
                    for wr in webres:
                        a(f'- `{wr["control_id"]}`')
                    a('')

        if form['footer_fields']:
            a('#### Footer Fields')
            a('')
            a('| Field | Label |')
            a('|-------|-------|')
            for ff in form['footer_fields']:
                a(f'| {fl(ff["name"])} | {ff["label"]} |')
                ref(ff['name'], form_slug, f'Form: {form["name"]} (Footer)')
            a('')

        if form['events']:
            a('#### Form Events & Libraries')
            a('')
            a('| Event | Attribute | Function | Library | Enabled |')
            a('|-------|-----------|----------|---------|---------|')
            for ev in form['events']:
                a(f'| {ev["event"]} | {ev["attribute"]} | `{ev["function"]}` | `{ev["library"]}` | {ev["enabled"]} |')
            a('')

        seen = set()
        unique_subgrids = []
        for sg in form['subgrids']:
            key = sg['control_id']
            if key not in seen and sg['entity']:
                seen.add(key)
                unique_subgrids.append(sg)
        if unique_subgrids:
            a('#### All Subgrids')
            a('')
            a('| Control ID | Related Entity | Relationship |')
            a('|------------|---------------|-------------|')
            for sg in unique_subgrids:
                a(f'| {sg["control_id"]} | {sg["entity"]} | {sg["relationship"]} |')
            a('')

    # 3. VIEWS
    a('---')
    a('')
    a('## <a id="3-views"></a>3. Views')
    a('')
    a(f'Total views: **{len(views)}**')
    a('')

    for i, view in enumerate(views, 1):
        heading = f'3.{i}. {view["name"]}'
        view_slug = slugify(f"3{i} {view['name']}")
        a(f'### <a id="{view_slug}"></a>{heading}')
        a('')
        a(f'- **Type:** {view["query_type_name"]} (querytype={view["query_type"]})')
        a(f'- **Default:** {"Yes" if view["is_default"] else "No"}')
        a('')

        if view['columns']:
            a('**Display Columns:**')
            a('')
            a('| # | Field | Width |')
            a('|---|-------|-------|')
            for j, col in enumerate(view['columns'], 1):
                w = f'{col["width"]}px' if col['width'] else ''
                a(f'| {j} | {fl(col["name"])} | {w} |')
                ref(col['name'], view_slug, f'View: {view["name"]}')
            a('')

        if view['filter_fields']:
            a('**Filter Conditions:**')
            a('')
            a('| Field | Operator | Value |')
            a('|-------|----------|-------|')
            for fc in view['filter_fields']:
                a(f'| {fl(fc["field"])} | {fc["operator"]} | {fc["value"]} |')
                ref(fc['field'], view_slug, f'View: {view["name"]} (Filter)')
            a('')

        if view['sort_fields']:
            a('**Sort Order:**')
            a('')
            a('| Field | Direction |')
            a('|-------|-----------|')
            for sf in view['sort_fields']:
                d = 'Descending' if sf['descending'] else 'Ascending'
                a(f'| {fl(sf["field"])} | {d} |')
                ref(sf['field'], view_slug, f'View: {view["name"]} (Sort)')
            a('')

    # 4. CHART VISUALIZATIONS
    a('---')
    a('')
    a('## <a id="4-chart-visualizations"></a>4. Chart Visualizations')
    a('')
    a(f'Total charts: **{len(chart_visualizations)}**')
    a('')

    for i, chart in enumerate(chart_visualizations, 1):
        heading = f'4.{i}. {chart["name"]}'
        chart_slug = slugify(f"4{i} {chart['name']}")
        a(f'### <a id="{chart_slug}"></a>{heading}')
        a('')
        if chart['viz_id']:
            a(f'- **Visualization ID:** `{chart["viz_id"]}`')
        if chart['entity_name']:
            a(f'- **Entity:** {chart["entity_name"]}')
        a('')

        if chart['measure_fields']:
            a('**Measure Fields:**')
            a('')
            a('| Field | Aggregate | Alias |')
            a('|-------|-----------|-------|')
            for mf in chart['measure_fields']:
                a(f'| {fl(mf["field"])} | {mf["aggregate"]} | {mf["alias"]} |')
                ref(mf['field'], chart_slug, f'Chart: {chart["name"]} (Measure)')
            a('')

        if chart['groupby_fields']:
            a('**Group-By Fields:**')
            a('')
            a('| Field | Alias | Date Grouping |')
            a('|-------|-------|---------------|')
            for gf in chart['groupby_fields']:
                a(f'| {fl(gf["field"])} | {gf["alias"]} | {gf["dategrouping"]} |')
                ref(gf['field'], chart_slug, f'Chart: {chart["name"]} (Group-By)')
            a('')

        if chart['filter_fields']:
            a('**Filter Conditions:**')
            a('')
            a('| Field | Operator | Value |')
            a('|-------|----------|-------|')
            for ff in chart['filter_fields']:
                a(f'| {fl(ff["field"])} | {ff["operator"]} | {ff["value"]} |')
                ref(ff['field'], chart_slug, f'Chart: {chart["name"]} (Filter)')
            a('')

        if chart['sort_fields']:
            a('**Sort Order:**')
            a('')
            a('| Field | Direction |')
            a('|-------|-----------|')
            for sf in chart['sort_fields']:
                d = 'Descending' if sf['descending'] else 'Ascending'
                a(f'| {fl(sf["field"])} | {d} |')
                ref(sf['field'], chart_slug, f'Chart: {chart["name"]} (Sort)')
            a('')

    # 5. REPORTS
    a('---')
    a('')
    a('## <a id="5-reports"></a>5. Reports')
    a('')
    a(f'Total reports referencing {entity_title}: **{len(reports)}**')
    a('')

    for i, rpt in enumerate(reports, 1):
        heading = f'5.{i}. {rpt["name"]}'
        rpt_slug = slugify(f"5{i} {rpt['name']}")
        a(f'### <a id="{rpt_slug}"></a>{heading}')
        a('')
        a(f'- **File:** `{rpt["file"]}`')
        a(f'- **DataSets:** {len(rpt["datasets"])}')
        a('')

        for ds in rpt['datasets']:
            a(f'#### DataSet: {ds["name"]}')
            a('')

            if ds['parameters']:
                a(f'**Parameters:** {", ".join(ds["parameters"])}')
                a('')

            for fd in ds['fetchxml_data']:
                a(f'**Primary Entity:** `{fd["entity"]}`')
                a('')

                if fd['attributes']:
                    a('**Selected Fields:**')
                    a('')
                    for attr in fd['attributes']:
                        a(f'- {fl(attr)}')
                        ref(attr, rpt_slug, f'Report: {rpt["name"]} > {ds["name"]} (Select)')
                    a('')

                if fd['conditions']:
                    a('**Filter Conditions:**')
                    a('')
                    a('| Field | Operator | Value |')
                    a('|-------|----------|-------|')
                    for cond in fd['conditions']:
                        a(f'| {fl(cond["field"])} | {cond["operator"]} | {cond["value"]} |')
                        ref(cond['field'], rpt_slug, f'Report: {rpt["name"]} > {ds["name"]} (Filter)')
                    a('')

                if fd['orders']:
                    a('**Sort Order:**')
                    a('')
                    a('| Field | Direction |')
                    a('|-------|-----------|')
                    for order in fd['orders']:
                        d = 'Descending' if order['descending'] else 'Ascending'
                        a(f'| {fl(order["field"])} | {d} |')
                        ref(order['field'], rpt_slug, f'Report: {rpt["name"]} > {ds["name"]} (Sort)')
                    a('')

                def render_link_entities(link_list, indent=0):
                    for le in link_list:
                        prefix = '  ' * indent
                        a(f'{prefix}**Link Entity:** `{le["entity"]}` (alias: `{le["alias"]}`, type: {le["link_type"]}, from: `{le["from_field"]}` to: `{le["to_field"]}`)')
                        a('')
                        if le['attributes']:
                            a(f'{prefix}Fields:')
                            a('')
                            for attr in le['attributes']:
                                a(f'{prefix}- {fl(attr)} *(via {le["entity"]})*')
                                ref(attr, rpt_slug, f'Report: {rpt["name"]} > {ds["name"]} > {le["entity"]}')
                            a('')
                        if le['conditions']:
                            a(f'{prefix}Conditions:')
                            a('')
                            a(f'{prefix}| Field | Operator | Value |')
                            a(f'{prefix}|-------|----------|-------|')
                            for cond in le['conditions']:
                                a(f'{prefix}| {fl(cond["field"])} | {cond["operator"]} | {cond["value"]} |')
                                ref(cond['field'], rpt_slug, f'Report: {rpt["name"]} > {ds["name"]} > {le["entity"]} (Filter)')
                            a('')
                        if le['orders']:
                            a(f'{prefix}Sort:')
                            a('')
                            for order in le['orders']:
                                d = 'Descending' if order['descending'] else 'Ascending'
                                a(f'{prefix}- {fl(order["field"])} {d}')
                                ref(order['field'], rpt_slug, f'Report: {rpt["name"]} > {ds["name"]} > {le["entity"]} (Sort)')
                            a('')
                        if le['nested_links']:
                            render_link_entities(le['nested_links'], indent + 1)

                if fd['link_entities']:
                    render_link_entities(fd['link_entities'])

            if ds['report_fields']:
                a('**Report Field Mappings:**')
                a('')
                a('| Report Field | Data Field |')
                a('|-------------|------------|')
                for rf in ds['report_fields']:
                    a(f'| {rf["name"]} | {rf["data_field"]} |')
                a('')

    # 6. DASHBOARDS
    a('---')
    a('')
    a('## <a id="6-dashboards"></a>6. Dashboards')
    a('')
    a(f'Total dashboards referencing {entity_title}: **{len(dashboards)}**')
    a('')

    for i, dash in enumerate(dashboards, 1):
        heading = f'6.{i}. {dash["name"]}'
        dash_slug = slugify(f"6{i} {dash['name']}")
        a(f'### <a id="{dash_slug}"></a>{heading}')
        a('')
        a(f'- **Form ID:** `{dash["form_id"]}`')
        a('')

        if dash['controls']:
            a('| Control | Entity | Mode | View ID | Chart ID |')
            a('|---------|--------|------|---------|----------|')
            for ctrl in dash['controls']:
                a(f'| `{ctrl["control_id"]}` | {ctrl["entity"]} | {ctrl["chart_grid_mode"]} | `{ctrl["view_id"]}` | `{ctrl["viz_id"]}` |')
            a('')

    # 7. WORKFLOWS
    a('---')
    a('')
    a('## <a id="7-workflows"></a>7. Workflows')
    a('')
    a(f'Total workflows referencing {entity_title}: **{len(workflows)}**')
    a('')

    for i, wf in enumerate(workflows, 1):
        heading = f'7.{i}. {wf["name"]}'
        wf_slug = slugify(f"7{i} {wf['name']}")
        a(f'### <a id="{wf_slug}"></a>{heading}')
        a('')
        a(f'- **File:** `{wf["file"]}`')
        a(f'- **Entity References:** {", ".join(wf["entity_refs"])}')
        if wf.get('trigger_scope'):
            a(f'- **Trigger Scope:** {wf["trigger_scope"]}')
        if wf.get('trigger_form_id'):
            a(f'- **Trigger Form ID:** `{wf["trigger_form_id"]}`')
        if wf.get('trigger_primary_entity'):
            a(f'- **Primary Entity:** {wf["trigger_primary_entity"]}')
        a('')

        if wf['fields_read']:
            a('**Fields Read:**')
            a('')
            for fn in wf['fields_read']:
                a(f'- {fl(fn)}')
                ref(fn, wf_slug, f'Workflow: {wf["name"]} (Read)')
            a('')

        if wf['fields_written']:
            a('**Fields Written:**')
            a('')
            for fn in wf['fields_written']:
                a(f'- {fl(fn)}')
                ref(fn, wf_slug, f'Workflow: {wf["name"]} (Write)')
            a('')

        if wf['custom_actions']:
            a('**Custom Actions / Plugin Calls:**')
            a('')
            for ca in wf['custom_actions']:
                a(f'- `{ca}`')
            a('')

    # 8. JAVASCRIPT
    a('---')
    a('')
    a('## <a id="8-javascript-web-resources"></a>8. JavaScript Web Resources')
    a('')
    a(f'Total JS files referencing {entity_title} fields: **{len(js_files)}**')
    a('')

    for i, js in enumerate(js_files, 1):
        heading = f'8.{i}. {js["clean_name"]}'
        js_slug = slugify(f"8{i} {js['clean_name']}")
        a(f'### <a id="{js_slug}"></a>{heading}')
        a('')
        a(f'- **File:** `{js["file"]}`')
        a('')

        if js['func_fields']:
            a('**Per-Function Field Usage:**')
            a('')
            for func_name, func_refs in sorted(js['func_fields'].items()):
                a(f'`{func_name}`:')
                a('')
                a('| Field | Operations |')
                a('|-------|-----------|')
                for fn, ops in sorted(func_refs.items()):
                    a(f'| {fl(fn)} | {", ".join(ops)} |')
                    ref(fn, js_slug, f'JS: {js["clean_name"]} > {func_name}()')
                a('')
        elif js['field_refs']:
            a('**Field References:**')
            a('')
            a('| Field | Read | Write | Control |')
            a('|-------|------|-------|---------|')
            for fn, refs in sorted(js['field_refs'].items()):
                rd = 'Yes' if refs['read'] else ''
                wr = 'Yes' if refs['write'] else ''
                ct = 'Yes' if refs['control'] else ''
                a(f'| {fl(fn)} | {rd} | {wr} | {ct} |')
                ref(fn, js_slug, f'JS: {js["clean_name"]}')
            a('')

    # 9. FORMULAS
    a('---')
    a('')
    a('## <a id="9-formulas-rollups"></a>9. Formulas & Rollups')
    a('')
    a(f'Total formulas for {entity_title}: **{len(formulas)}**')
    a('')

    formulas_slug = '9-formulas-rollups'
    for formula in formulas:
        a(f'### {formula["field"]}')
        a('')
        a(f'- **File:** `{formula["file"]}`')
        a(f'- **Type:** {formula["formula_type"]}')
        if formula['aggregation']:
            a(f'- **Aggregation:** {formula["aggregation"]}')
        if formula['source_entity']:
            a(f'- **Source Entity:** {formula["source_entity"]}')
        a('')

        if formula['source_fields']:
            a('**Source Fields:**')
            a('')
            a('| Field | Entity |')
            a('|-------|--------|')
            for sf in formula['source_fields']:
                if sf['entity'] == entity_name.lower():
                    a(f'| {fl(sf["field"])} | {sf["entity"]} |')
                else:
                    a(f'| {sf["field"]} | {sf["entity"]} |')
                ref(sf['field'], formulas_slug, f'Formula: {formula["field"]}')
            a('')

        ref(formula['field'], formulas_slug, f'Formula: {formula["field"]} (Target)')

    # 10. PLUGIN SOURCE CODE ANALYSIS
    a('---')
    a('')
    a('## <a id="10-plugin-source-code-analysis"></a>10. Plugin Source Code Analysis')
    a('')
    a(f'Total plugins analyzed: **{len(plugin_refs)}**')
    a('')

    for i, plugin in enumerate(plugin_refs, 1):
        heading = f'10.{i}. {plugin["class_name"]}'
        plugin_slug = slugify(f"10{i} {plugin['class_name']}")
        a(f'### <a id="{plugin_slug}"></a>{heading}')
        a('')
        a(f'- **File:** `{plugin["file"]}`')
        if plugin['target_entity']:
            a(f'- **Target entity:** {plugin["target_entity"]}')
        if plugin['message']:
            a(f'- **Message:** {plugin["message"]}')
        if plugin['selects_all']:
            a(f'- **Note:** Uses `ColumnSet(true)` — selects all fields')
        if plugin['has_pre_image'] or plugin['has_post_image']:
            images = []
            if plugin['has_pre_image']:
                images.append('Pre')
            if plugin['has_post_image']:
                images.append('Post')
            a(f'- **Entity Images:** {", ".join(images)}')
        a('')

        if plugin['fields_read']:
            a('**Fields Read:**')
            a('')
            for fn in plugin['fields_read']:
                a(f'- {fl(fn)}')
                ref(fn, plugin_slug, f'Plugin: {plugin["class_name"]} (Read)')
            a('')

        if plugin['fields_written']:
            a('**Fields Written:**')
            a('')
            for fn in plugin['fields_written']:
                a(f'- {fl(fn)}')
                ref(fn, plugin_slug, f'Plugin: {plugin["class_name"]} (Write)')
            a('')

        if plugin['fields_filtered']:
            a('**Fields Filtered:**')
            a('')
            for fn in plugin['fields_filtered']:
                a(f'- {fl(fn)}')
                ref(fn, plugin_slug, f'Plugin: {plugin["class_name"]} (Filter)')
            a('')

        if plugin['fields_sorted']:
            a('**Fields Sorted:**')
            a('')
            for fn in plugin['fields_sorted']:
                a(f'- {fl(fn)}')
                ref(fn, plugin_slug, f'Plugin: {plugin["class_name"]} (Sort)')
            a('')

        if plugin['fields_joined']:
            a('**Fields Joined:**')
            a('')
            for fn in plugin['fields_joined']:
                a(f'- {fl(fn)}')
                ref(fn, plugin_slug, f'Plugin: {plugin["class_name"]} (Join)')
            a('')

        if plugin['image_fields']:
            a('**Pre/Post Image Fields:**')
            a('')
            for fn in plugin['image_fields']:
                a(f'- {fl(fn)}')
                ref(fn, plugin_slug, f'Plugin: {plugin["class_name"]} (Image)')
            a('')

        if plugin['cross_entity_refs']:
            a('**Cross-Entity References (AliasedValue):**')
            a('')
            a('| Alias | Field | Operation |')
            a('|-------|-------|-----------|')
            for xref in plugin['cross_entity_refs']:
                a(f'| {xref["alias"]} | {xref["field"]} | {xref["operation"]} |')
            a('')

    # 11. PCF CONTROLS
    a('---')
    a('')
    a('## <a id="11-pcf-controls"></a>11. PCF Controls')
    a('')

    controls_slug = '11-pcf-controls'
    if controls:
        for ctrl in controls:
            a(f'### {ctrl["display_name"]}')
            a('')
            a(f'- **Namespace:** {ctrl["namespace"]}')
            a(f'- **Constructor:** {ctrl["constructor"]}')
            a(f'- **Version:** {ctrl["version"]}')
            a('')

            if ctrl['bound_properties']:
                a('**Bound Properties (map to entity fields):**')
                a('')
                a('| Property | Display Name | Type | Required |')
                a('|----------|-------------|------|----------|')
                for prop in ctrl['bound_properties']:
                    req = 'Yes' if prop['required'] else 'No'
                    a(f'| {prop["name"]} | {prop["display_name"]} | {prop["type"]} | {req} |')
                    ref(prop['name'], controls_slug, f'PCF: {ctrl["display_name"]}')
                a('')

            if ctrl['input_properties']:
                a('**Input Properties:**')
                a('')
                a('| Property | Display Name | Type |')
                a('|----------|-------------|------|')
                for prop in ctrl['input_properties']:
                    a(f'| {prop["name"]} | {prop["display_name"]} | {prop["type"]} |')
                a('')
    else:
        a('No PCF controls found.')
        a('')

    # 12. RELATIONSHIPS
    a('---')
    a('')
    a('## <a id="12-relationships"></a>12. Relationships')
    a('')
    a(f'Total relationships involving {entity_title}: **{len(relationships)}**')
    a('')

    rels_slug = '12-relationships'
    if relationships:
        a('| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |')
        a('|-------------------|------|-------------------|-------------------|-------------|')
        for rel in relationships:
            lookup = fl(rel['referencing_attribute']) if rel['referencing_attribute'] else ''
            a(f'| {rel["name"]} | {rel["type"]} | {rel["referenced_entity"]} | {rel["referencing_entity"]} | {lookup} |')
            if rel['referencing_attribute']:
                ref(rel['referencing_attribute'], rels_slug, f'Relationship: {rel["name"]}')
        a('')

    # 13. RIBBON
    a('---')
    a('')
    a('## <a id="13-ribbon-customizations"></a>13. Ribbon Customizations')
    a('')

    if ribbon['custom_actions'] or ribbon['commands']:
        if ribbon['custom_actions']:
            a('### Custom Buttons')
            a('')
            a('| Button Label | Location | Command |')
            a('|-------------|----------|---------|')
            for action in ribbon['custom_actions']:
                a(f'| {action["button_label"]} | {action["location"]} | `{action["command_id"]}` |')
            a('')

        if ribbon['commands']:
            a('### Command Definitions')
            a('')
            a('| Command ID | JavaScript Function | Library |')
            a('|-----------|-------------------|---------|')
            for cmd in ribbon['commands']:
                for js_func in cmd['js_functions']:
                    a(f'| `{cmd["id"]}` | `{js_func["function"]}` | `{js_func["library"]}` |')
            a('')
    else:
        a('No custom ribbon actions found.')
        a('')

    # 14. CONFLICTS & OBSERVATIONS
    a('---')
    a('')
    a('## <a id="14-conflicts-observations"></a>14. Conflicts & Observations')
    a('')

    a('### 14.1 Per-Form Conflicts')
    a('')
    if conflicts['per_form_conflicts']:
        a(f'Fields with inconsistent settings across forms: **{len(conflicts["per_form_conflicts"])}**')
        a('')
        a('| Field | Issue | Forms |')
        a('|-------|-------|-------|')
        for conflict in conflicts['per_form_conflicts']:
            issues = []
            if conflict['inconsistent_visibility']:
                issues.append('Visibility')
            if conflict['inconsistent_disabled']:
                issues.append('Disabled state')
            form_names = ', '.join(f'{e["form"]} ({e["form_type"]})' for e in conflict['entries'])
            a(f'| {fl(conflict["field"])} | {", ".join(issues)} | {form_names} |')
        a('')
    else:
        a('No per-form conflicts detected.')
        a('')

    a('### 14.2 Global Observations')
    a('')

    if conflicts['in_code_not_on_forms']:
        a(f'**Fields in code but not on any form ({len(conflicts["in_code_not_on_forms"])}):**')
        a('')
        for fn in conflicts['in_code_not_on_forms']:
            a(f'- {fl(fn)}')
        a('')

    if conflicts['on_forms_not_in_logic']:
        a(f'**Fields on forms but never in logic ({len(conflicts["on_forms_not_in_logic"])}):**')
        a('')
        for fn in conflicts['on_forms_not_in_logic']:
            a(f'- {fl(fn)}')
        a('')

    if not conflicts['in_code_not_on_forms'] and not conflicts['on_forms_not_in_logic']:
        a('No global observations.')
        a('')

    # INDEX
    a('---')
    a('')
    a('## <a id="index"></a>Index')
    a('')
    a(f'Alphabetical field index -- {len(field_index)} unique fields referenced.')
    a('')

    for field_name in sorted(field_index.keys()):
        refs = field_index[field_name]
        a(f'**<a id="index-{slugify(field_name)}"></a>`{field_name}`**')
        a('')
        for section_slug, desc in refs:
            a(f'- [{desc}](#{section_slug})')
        a('')

    return '\n'.join(lines), field_index


# ---------------------------------------------------------------------------
# MAIN
# ---------------------------------------------------------------------------

def process_entity(entity_name, output_dir, mapping_dir, d365_entities_dir):
    """Load enriched JSON, read mapping CSV, and generate markdown report."""
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
    js_files = convert_keys_to_snake(sections.get('javaScript', []))
    formulas = convert_keys_to_snake(sections.get('formulas', []))
    plugin_refs = convert_keys_to_snake(sections.get('plugins', []))
    controls = convert_keys_to_snake(sections.get('pcfControls', []))
    relationships = convert_keys_to_snake(sections.get('relationships', []))
    ribbon = convert_keys_to_snake(sections.get('ribbon', {'custom_actions': [], 'commands': []}))
    conflicts = convert_keys_to_snake(sections.get('conflicts', {}))

    # 3. Convert field list from JSON keys to parse-output keys
    fields = adapt_json_fields(entity_data.get('fields', []))

    # 4. Post-conversion fixups
    for form in forms:
        form['all_fields'] = set(form.get('all_fields', []))

    conflicts.setdefault('per_form_conflicts', [])
    conflicts.setdefault('in_code_not_on_forms', [])
    conflicts.setdefault('on_forms_not_in_logic', [])

    for js in js_files:
        raw_refs = js.get('field_refs', {})
        field_refs = {}
        for k, v in raw_refs.items():
            if isinstance(v, dict):
                field_refs[k] = v
            else:
                field_refs[k] = {'read': False, 'write': False, 'control': False}
        js['field_refs'] = field_refs

    print(f"  Fields: {len(fields)}")
    print(f"  Forms: {len(forms)}")
    print(f"  Views: {len(views)}")
    print(f"  Chart Visualizations: {len(chart_visualizations)}")
    print(f"  Reports: {len(reports)}")
    print(f"  Dashboards: {len(dashboards)}")
    print(f"  Workflows: {len(workflows)}")
    print(f"  JS Files: {len(js_files)}")
    print(f"  Formulas: {len(formulas)}")
    print(f"  Plugin source files: {len(plugin_refs)}")
    print(f"  PCF controls: {len(controls)}")
    print(f"  Relationships: {len(relationships)}")
    print(f"  Ribbon Actions: {len(ribbon.get('custom_actions', []))}")
    print(f"  Ribbon Commands: {len(ribbon.get('commands', []))}")

    # 5. Read mapping CSV (read-only, for display in report)
    sf_mapping = read_mapping_csv(mapping_dir, entity_name)

    # 6. Generate markdown
    markdown, field_index = generate_markdown(
        entity_name, fields, forms, views, chart_visualizations,
        reports, dashboards,
        workflows, js_files, formulas, plugin_refs, controls,
        relationships, ribbon, conflicts,
        sf_mapping=sf_mapping, field_mapping_suggested={}
    )

    output_file = os.path.join(output_dir, f"{entity_name}.md")
    with open(output_file, 'w', encoding='utf-8') as f:
        f.write(markdown)

    link_targets = set(re.findall(r'\]\(#([^)]+)\)', markdown))
    anchor_ids = set(re.findall(r'<a id="([^"]+)">', markdown))
    orphans = link_targets - anchor_ids
    if orphans:
        print(f"  WARNING: {len(orphans)} orphan link target(s) with no matching anchor:")
        for slug in sorted(orphans):
            print(f"    - #{slug}")
    else:
        print(f"  Link integrity: OK ({len(link_targets)} targets, {len(anchor_ids)} anchors)")

    print()
    print(f"  Output: {output_file}")
    print(f"  Index entries: {len(field_index)}")

    defined = set(f['schema_name'].lower() for f in fields)
    referenced = set(field_index.keys())
    extra = referenced - defined
    if extra:
        print(f"  WARNING: {len(extra)} referenced fields not in definitions:")
        for fn in sorted(extra)[:10]:
            print(f"    - {fn}")

    form_fields = set()
    for form in forms:
        form_fields.update(form['all_fields'])
    view_fields = set()
    for view in views:
        for col in view['columns']:
            view_fields.add(col['name'].lower())
        for fc in view['filter_fields']:
            view_fields.add(fc['field'].lower())
    wf_fields = set()
    for wf in workflows:
        wf_fields.update(wf['fields_read'])
        wf_fields.update(wf['fields_written'])
    js_field_set = set()
    for js in js_files:
        js_field_set.update(js['field_refs'].keys())
    plugin_fields = set()
    for plugin in plugin_refs:
        plugin_fields.update(plugin['fields_read'])
        plugin_fields.update(plugin['fields_written'])
        plugin_fields.update(plugin['fields_filtered'])
    chart_fields = set()
    for chart in chart_visualizations:
        for mf in chart['measure_fields']:
            chart_fields.add(mf['field'].lower())
        for gf in chart['groupby_fields']:
            chart_fields.add(gf['field'].lower())
    report_fields = set()
    for rpt in reports:
        for ds in rpt['datasets']:
            for fd in ds['fetchxml_data']:
                for attr in fd['attributes']:
                    report_fields.add(attr.lower())
                for cond in fd['conditions']:
                    report_fields.add(cond['field'].lower())

    print()
    print(f"  Summary:")
    print(f"    Defined fields:       {len(defined)}")
    print(f"    Fields on forms:      {len(form_fields)}")
    print(f"    Fields in views:      {len(view_fields)}")
    print(f"    Fields in charts:     {len(chart_fields)}")
    print(f"    Fields in reports:    {len(report_fields)}")
    print(f"    Dashboards:           {len(dashboards)}")
    print(f"    Fields in workflows:  {len(wf_fields)}")
    print(f"    Fields in JavaScript: {len(js_field_set)}")
    print(f"    Fields in formulas:   {len(formulas)}")
    print(f"    Fields in plugins:    {len(plugin_fields)}")
    print(f"    Total unique indexed: {len(field_index)}")

    return True


def main():
    parser = argparse.ArgumentParser(
        description='D365CE Entity Field Usage Report Generator'
    )
    parser.add_argument('entity', nargs='?', default=None,
                        help='Target entity schema name (e.g., account, contact)')
    parser.add_argument('--all', action='store_true',
                        help='Generate reports for all entities')
    parser.add_argument('--output-dir', default=DEFAULT_OUTPUT_DIR,
                        help='Directory for generated .md files (default: reports/)')
    parser.add_argument('--mapping-dir', default=DEFAULT_MAPPING_DIR,
                        help='Directory containing mapping CSVs (default: mapping/)')
    parser.add_argument('--d365-entities-dir', default=DEFAULT_D365_DIR,
                        help='Directory containing enriched D365 entity JSONs')
    args = parser.parse_args()

    if not args.all and not args.entity:
        parser.error('either provide an entity name or use --all')

    output_dir = args.output_dir
    mapping_dir = args.mapping_dir
    d365_dir = args.d365_entities_dir

    if not os.path.isdir(output_dir):
        os.makedirs(output_dir, exist_ok=True)

    print("=" * 60)
    print("D365CE Field Usage Report Generator")
    print("=" * 60)
    print()

    if args.all:
        entities = sorted(f[:-5] for f in os.listdir(d365_dir) if f.endswith('.json'))
        print(f"Discovered {len(entities)} entities in {d365_dir}.")
        success = 0
        for entity_name in entities:
            if process_entity(entity_name, output_dir,
                              mapping_dir=mapping_dir,
                              d365_entities_dir=d365_dir):
                success += 1
        print()
        print("=" * 60)
        print(f"Generation complete! {success}/{len(entities)} reports generated.")
        print("=" * 60)
    else:
        entity_name = args.entity.lower()
        if not process_entity(entity_name, output_dir,
                              mapping_dir=mapping_dir,
                              d365_entities_dir=d365_dir):
            sys.exit(1)
        print()
        print("=" * 60)
        print("Generation complete!")
        print("=" * 60)


if __name__ == '__main__':
    main()
