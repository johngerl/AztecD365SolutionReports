#!/usr/bin/env python3
"""
generate_field_usage.py

Analyzes D365CE solution extract (SolutionExtract) to determine every field
on a target entity that is actively used across forms, views, charts, workflows,
JavaScript, formulas, plugins, controls, and ribbon customizations.

Generates one comprehensive Markdown file per entity.

Usage:
    python generate_field_usage.py <entity> [--output-dir <path>]
"""

import xml.etree.ElementTree as ET
import csv
import html
import re
import os
import sys
import glob
import argparse
from collections import defaultdict
from datetime import date

PROJECT_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
SOLUTION_DIR = os.path.join(PROJECT_DIR, "SolutionExtract")
CUSTOMIZATIONS_FILE = os.path.join(SOLUTION_DIR, "customizations.xml")
PLUGINS_DIR = os.path.join(PROJECT_DIR, "plugins")
REPORTS_DIR = os.path.join(SOLUTION_DIR, "Reports")
DEFAULT_OUTPUT_DIR = os.path.join(PROJECT_DIR, "reports")
DEFAULT_MAPPING_DIR = os.path.join(PROJECT_DIR, "mapping")
SF_ENTITIES_DIR = os.path.join(PROJECT_DIR, "salesforce-entities")

SF_COLUMNS = [
    "sfObjectName",
    "sfFieldDisplayName",
    "sfFieldApiName",
    "sfSuggestedObjectName",
    "sfSuggestedFieldDisplayName",
    "sfSuggestedFieldApiName",
]

D365_COLUMNS = ["displayName", "dataType", "requiredLevel", "isCustom"]
REPORT_COLUMNS = ["picklistValues", "mappingSuggested"]

# Reference count columns: CSV header -> count_field_references key
REF_COUNT_COLUMNS = [
    ("refForms", "forms"),
    ("refViews", "views"),
    ("refChartVisualizations", "charts"),
    ("refReports", "reports"),
    ("refDashboards", "dashboards"),
    ("refWorkflows", "workflows"),
    ("refFormulas", "formulas"),
    ("refPlugins", "plugins"),
    ("refPcfControls", "pcf"),
    ("refRelationships", "rels"),
    ("refRibbon", "ribbon"),
]

CSV_COLUMNS = (D365_COLUMNS + REPORT_COLUMNS
               + [col for col, _ in REF_COUNT_COLUMNS] + SF_COLUMNS)


CLASSID_SUBGRID = "{e7a81278-8bb2-4f1d-acd7-36f4db40e15e}"
CLASSID_WEBRESOURCE = "{9fdf5f91-18b7-4a41-8f8c-b0bd4ec1c21e}"

QUERY_TYPES = {
    "0": "Standard",
    "1": "Advanced Find",
    "2": "Associated View",
    "4": "Quick Find",
    "16": "SubGrid",
    "32": "Multi-Entity Quick Find",
    "64": "Lookup View",
    "128": "Custom",
    "256": "Quick Find v2",
    "4096": "Kanban",
    "8192": "InteractiveWorkflow",
}


# ---------------------------------------------------------------------------
# ENCODING HELPER
# ---------------------------------------------------------------------------

def read_file(path):
    for encoding in ('utf-8-sig', 'utf-16', 'latin-1'):
        try:
            with open(path, 'r', encoding=encoding) as f:
                content = f.read()
            if encoding != 'utf-8-sig':
                print(f"  WARNING: {os.path.basename(path)} decoded with {encoding} (not UTF-8)", file=sys.stderr)
            return content
        except UnicodeDecodeError:
            continue
    return ''


def slugify(text):
    text = text.lower()
    text = re.sub(r'[^\w\s-]', '', text)
    text = re.sub(r'[\s]+', '-', text)
    text = re.sub(r'-+', '-', text)
    return text.strip('-')


def get_localized_name(el, tag='LocalizedName'):
    container = el.find('LocalizedNames')
    if container is None:
        return ''
    for ln in container.findall(tag):
        if ln.get('languagecode') == '1033':
            return ln.get('description', '')
    return ''


def get_display_name(el):
    displaynames = el.find('displaynames')
    if displaynames is not None:
        for dn in displaynames.findall('displayname'):
            if dn.get('languagecode') == '1033':
                return dn.get('description', '')
    return ''


def get_description(el):
    """Extract English description from <Descriptions><Description> child."""
    container = el.find('Descriptions')
    if container is None:
        return ''
    for desc in container.findall('Description'):
        if desc.get('languagecode') == '1033':
            return desc.get('description', '')
    return ''


def text_of(el, tag, default=''):
    """Return text content of a direct child element, or default."""
    child = el.find(tag)
    if child is not None and child.text:
        return child.text
    return default


# ---------------------------------------------------------------------------
# 1. FIELD DEFINITIONS
# ---------------------------------------------------------------------------

def parse_field_definitions(entity_el):
    fields = []
    entity_info = entity_el.find("EntityInfo")
    if entity_info is None:
        return fields
    entity_inner = entity_info.find("entity")
    if entity_inner is None:
        return fields
    attributes = entity_inner.find("attributes")
    if attributes is None:
        return fields

    for attr in attributes.findall("attribute"):
        name_el = attr.find('Name')
        type_el = attr.find('Type')
        req_el = attr.find('RequiredLevel')
        custom_el = attr.find('IsCustomField')
        version_el = attr.find('IntroducedVersion')

        schema_name = name_el.text if name_el is not None and name_el.text else ''
        display_name = get_display_name(attr)
        optionset = attr.find('optionset')
        if not display_name:
            if optionset is not None:
                display_name = get_display_name(optionset)

        # Extract picklist/optionset values
        picklist_values = []
        if optionset is not None:
            options_el = optionset.find('options')
            if options_el is not None:
                for option in options_el.findall('option'):
                    value = option.get('value', '')
                    label = ''
                    labels_el = option.find('labels')
                    if labels_el is not None:
                        label_el = labels_el.find("label[@languagecode='1033']")
                        if label_el is not None:
                            label = label_el.get('description', '')
                    picklist_values.append({'label': label, 'value': value})

        # New metadata attributes
        max_length_str = text_of(attr, 'MaxLength')
        max_length = int(max_length_str) if max_length_str else None

        fields.append({
            'schema_name': schema_name,
            'display_name': display_name,
            'description': get_description(attr),
            'data_type': type_el.text if type_el is not None and type_el.text else '',
            'required_level': req_el.text if req_el is not None and req_el.text else 'none',
            'is_custom': (custom_el.text == '1') if custom_el is not None and custom_el.text else False,
            'introduced_version': version_el.text if version_el is not None and version_el.text else '',
            'is_audit_enabled': text_of(attr, 'IsAuditEnabled', '0') == '1',
            'is_secured': text_of(attr, 'IsSecured', '0') == '1',
            'max_length': max_length,
            'display_mask': text_of(attr, 'DisplayMask'),
            'picklist_values': picklist_values,
        })

    return sorted(fields, key=lambda f: f['schema_name'].lower())


def parse_entity_metadata(entity_el):
    """Extract entity-level metadata from customizations.xml Entity element.

    Returns a dict with display_name, description, ownership_type, and
    is_audit_enabled sourced from <EntityInfo><entity>.
    """
    entity_inner = entity_el.find("EntityInfo/entity")
    if entity_inner is None:
        return {
            'display_name': '',
            'description': '',
            'ownership_type': '',
            'is_audit_enabled': False,
        }
    return {
        'display_name': get_localized_name(entity_inner),
        'description': get_description(entity_inner),
        'ownership_type': text_of(entity_inner, 'OwnershipTypeMask'),
        'is_audit_enabled': text_of(entity_inner, 'IsAuditEnabled', '0') == '1',
    }


# ---------------------------------------------------------------------------
# 2. FORMS
# ---------------------------------------------------------------------------

def parse_cell_control(cell_el):
    control_el = cell_el.find('control')
    if control_el is None:
        return None

    classid = (control_el.get('classid') or '').lower()
    datafieldname = control_el.get('datafieldname', '')
    control_id = control_el.get('id', '')
    field_name = datafieldname if datafieldname else control_id

    label = ''
    cell_labels = cell_el.find('labels')
    if cell_labels is not None:
        for lbl in cell_labels.findall('label'):
            if lbl.get('languagecode') == '1033':
                label = lbl.get('description', '')
                break

    result = {
        'name': field_name,
        'control_id': control_id,
        'classid': classid,
        'disabled': control_el.get('disabled', 'false'),
        'visible': cell_el.get('visible', 'true'),
        'label': label,
        'is_subgrid': classid == CLASSID_SUBGRID.lower(),
        'is_webresource': classid == CLASSID_WEBRESOURCE.lower(),
        'subgrid_entity': '',
        'subgrid_relationship': '',
    }

    if result['is_subgrid']:
        params = control_el.find('parameters')
        if params is not None:
            t = params.find('TargetEntityType')
            if t is not None and t.text:
                result['subgrid_entity'] = t.text
            r = params.find('RelationshipName')
            if r is not None and r.text:
                result['subgrid_relationship'] = r.text

    return result


def parse_section(section_el):
    label = ''
    labels_el = section_el.find('labels')
    if labels_el is not None:
        for lbl in labels_el.findall('label'):
            if lbl.get('languagecode') == '1033':
                label = lbl.get('description', '')
                break
    if not label:
        label = section_el.get('name', '')

    fields = []
    rows_el = section_el.find('rows')
    if rows_el is not None:
        for row_el in rows_el.findall('row'):
            for cell_el in row_el.findall('cell'):
                ctrl = parse_cell_control(cell_el)
                if ctrl and ctrl['name']:
                    fields.append(ctrl)

    return {
        'name': section_el.get('name', ''),
        'label': label,
        'visible': section_el.get('visible', 'true'),
        'fields': fields,
    }


def parse_tab(tab_el):
    label = ''
    labels_el = tab_el.find('labels')
    if labels_el is not None:
        for lbl in labels_el.findall('label'):
            if lbl.get('languagecode') == '1033':
                label = lbl.get('description', '')
                break
    if not label:
        label = tab_el.get('name', '')

    sections = []
    columns_el = tab_el.find('columns')
    if columns_el is not None:
        for column_el in columns_el.findall('column'):
            sections_el = column_el.find('sections')
            if sections_el is not None:
                for section_el in sections_el.findall('section'):
                    sections.append(parse_section(section_el))

    return {
        'name': tab_el.get('name', ''),
        'label': label,
        'expanded': tab_el.get('expanded', 'true'),
        'visible': tab_el.get('visible', 'true'),
        'sections': sections,
    }


def parse_header_footer(el):
    fields = []
    for row_el in el.iter('row'):
        for cell_el in row_el.findall('cell'):
            ctrl = parse_cell_control(cell_el)
            if ctrl and ctrl['name']:
                fields.append({'name': ctrl['name'], 'label': ctrl['label']})
    return fields


def parse_forms(entity_el):
    forms = []
    form_xml = entity_el.find("FormXml")
    if form_xml is None:
        return forms

    for forms_group in form_xml.findall("forms"):
        form_type = forms_group.get("type", "unknown")
        for sys_form in forms_group.findall("systemform"):
            form_data = {
                'form_type': form_type,
                'form_id': '',
                'name': '',
                'is_active': True,
                'presentation': '',
                'tabs': [],
                'header_fields': [],
                'footer_fields': [],
                'events': [],
                'subgrids': [],
                'web_resources': [],
                'all_fields': set(),
            }

            formid_el = sys_form.find('formid')
            if formid_el is not None and formid_el.text:
                form_data['form_id'] = formid_el.text

            activation_el = sys_form.find('FormActivationState')
            if activation_el is not None and activation_el.text:
                form_data['is_active'] = activation_el.text == '1'

            pres_el = sys_form.find('FormPresentation')
            if pres_el is not None and pres_el.text:
                pres_map = {'0': 'Classic', '1': 'UCI/Tablet', '2': 'Other'}
                form_data['presentation'] = pres_map.get(pres_el.text, pres_el.text)

            form_data['name'] = get_localized_name(sys_form)

            form_el = sys_form.find('form')
            if form_el is not None:
                tabs_el = form_el.find('tabs')
                if tabs_el is not None:
                    for tab_el in tabs_el.findall('tab'):
                        tab_data = parse_tab(tab_el)
                        form_data['tabs'].append(tab_data)
                        for section in tab_data['sections']:
                            for field in section['fields']:
                                if not field['is_subgrid'] and not field['is_webresource']:
                                    form_data['all_fields'].add(field['name'].lower())

                header_el = form_el.find('header')
                if header_el is not None:
                    hf = parse_header_footer(header_el)
                    form_data['header_fields'] = hf
                    for f in hf:
                        form_data['all_fields'].add(f['name'].lower())

                footer_el = form_el.find('footer')
                if footer_el is not None:
                    ff = parse_header_footer(footer_el)
                    form_data['footer_fields'] = ff
                    for f in ff:
                        form_data['all_fields'].add(f['name'].lower())

                events_el = form_el.find('events')
                if events_el is not None:
                    for event_el in events_el.findall('event'):
                        event_name = event_el.get('name', '')
                        handlers_el = event_el.find('Handlers')
                        if handlers_el is None:
                            handlers_el = event_el.find('handlers')
                        if handlers_el is not None:
                            for handler in handlers_el:
                                form_data['events'].append({
                                    'event': event_name,
                                    'attribute': event_el.get('attribute', ''),
                                    'function': handler.get('functionName', ''),
                                    'library': (handler.get('libraryName') or '').replace('$webresource:', ''),
                                    'enabled': handler.get('enabled', 'true'),
                                })

                for control in form_el.iter('control'):
                    classid = (control.get('classid') or '').lower()
                    if classid == CLASSID_SUBGRID.lower():
                        sg = {'control_id': control.get('id', ''), 'entity': '', 'relationship': ''}
                        params = control.find('parameters')
                        if params is not None:
                            t = params.find('TargetEntityType')
                            if t is not None and t.text:
                                sg['entity'] = t.text
                            r = params.find('RelationshipName')
                            if r is not None and r.text:
                                sg['relationship'] = r.text
                        form_data['subgrids'].append(sg)
                    elif classid == CLASSID_WEBRESOURCE.lower():
                        wr = {'control_id': control.get('id', ''), 'url': ''}
                        params = control.find('parameters')
                        if params is not None:
                            u = params.find('Url')
                            if u is not None and u.text:
                                wr['url'] = u.text
                        form_data['web_resources'].append(wr)

            forms.append(form_data)

    return forms


# ---------------------------------------------------------------------------
# 3. VIEWS
# ---------------------------------------------------------------------------

def parse_views(entity_el):
    views = []
    saved_queries = entity_el.find("SavedQueries")
    if saved_queries is None:
        return views
    sq_container = saved_queries.find("savedqueries")
    if sq_container is None:
        return views

    for sq in sq_container.findall("savedquery"):
        view = {
            'name': get_localized_name(sq),
            'query_type': '',
            'query_type_name': '',
            'is_default': False,
            'columns': [],
            'filter_fields': [],
            'sort_fields': [],
        }

        qt = sq.find('querytype')
        if qt is not None and qt.text:
            view['query_type'] = qt.text
            view['query_type_name'] = QUERY_TYPES.get(qt.text, f'Unknown ({qt.text})')

        is_def = sq.find('isdefault')
        if is_def is not None and is_def.text:
            view['is_default'] = is_def.text == '1'

        layout_el = sq.find('layoutxml')
        if layout_el is not None:
            for cell in layout_el.iter('cell'):
                col_name = cell.get('name', '')
                if col_name:
                    view['columns'].append({'name': col_name, 'width': cell.get('width', '')})

        fetch_el = sq.find('fetchxml')
        if fetch_el is not None:
            for attr in fetch_el.iter('attribute'):
                attr_name = attr.get('name', '')
                if attr_name and attr_name not in [c['name'] for c in view['columns']]:
                    view['columns'].append({'name': attr_name, 'width': ''})

            for cond in fetch_el.iter('condition'):
                cond_attr = cond.get('attribute', '')
                if cond_attr:
                    view['filter_fields'].append({
                        'field': cond_attr,
                        'operator': cond.get('operator', ''),
                        'value': cond.get('value', ''),
                    })

            for order in fetch_el.iter('order'):
                order_attr = order.get('attribute', '')
                if order_attr:
                    view['sort_fields'].append({
                        'field': order_attr,
                        'descending': order.get('descending', 'false') == 'true',
                    })

        views.append(view)

    return views


# ---------------------------------------------------------------------------
# 4. CHART VISUALIZATIONS
# ---------------------------------------------------------------------------

def parse_chart_visualizations(entity_el, entity_name):
    charts = []
    entity_lower = entity_name.lower()

    viz_container = entity_el.find("Visualizations")
    if viz_container is None:
        return charts

    for viz_el in viz_container.findall("visualization"):
        chart = {
            'name': get_localized_name(viz_el),
            'viz_id': '',
            'measure_fields': [],
            'groupby_fields': [],
            'filter_fields': [],
            'sort_fields': [],
            'entity_name': '',
        }

        viz_id_el = viz_el.find('savedqueryvisualizationid')
        if viz_id_el is not None and viz_id_el.text:
            chart['viz_id'] = viz_id_el.text

        data_desc = viz_el.find('datadescription')
        if data_desc is not None:
            for fetch_el in data_desc.iter('fetch'):
                for ent_el in fetch_el.findall('entity'):
                    chart['entity_name'] = ent_el.get('name', '')

            for attr_el in data_desc.iter('attribute'):
                attr_name = attr_el.get('name', '')
                if not attr_name:
                    continue
                aggregate = attr_el.get('aggregate', '')
                groupby = attr_el.get('groupby', '')
                alias = attr_el.get('alias', '')
                if groupby == 'true':
                    chart['groupby_fields'].append({
                        'field': attr_name,
                        'alias': alias,
                        'dategrouping': attr_el.get('dategrouping', ''),
                    })
                elif aggregate:
                    chart['measure_fields'].append({
                        'field': attr_name,
                        'aggregate': aggregate,
                        'alias': alias,
                    })
                else:
                    chart['measure_fields'].append({
                        'field': attr_name,
                        'aggregate': '',
                        'alias': alias,
                    })

            for cond_el in data_desc.iter('condition'):
                cond_attr = cond_el.get('attribute', '')
                if cond_attr:
                    chart['filter_fields'].append({
                        'field': cond_attr,
                        'operator': cond_el.get('operator', ''),
                        'value': cond_el.get('value', ''),
                    })

            for order_el in data_desc.iter('order'):
                order_attr = order_el.get('attribute', '')
                if order_attr:
                    chart['sort_fields'].append({
                        'field': order_attr,
                        'descending': order_el.get('descending', 'false') == 'true',
                    })

        if chart['entity_name'].lower() == entity_lower or not chart['entity_name']:
            charts.append(chart)

    return charts


# ---------------------------------------------------------------------------
# 5. REPORTS (RDL)
# ---------------------------------------------------------------------------

def extract_fetchxml_fields(fetch_root, target_entity):
    """Extract fields from a FetchXML tree, returning per-entity field data."""
    datasets_fields = []

    for entity_el in fetch_root.findall('entity'):
        entity_name = (entity_el.get('name') or '').lower()
        attrs = []
        conditions = []
        orders = []
        link_entities = []

        for attr_el in entity_el.findall('attribute'):
            attr_name = attr_el.get('name', '')
            if attr_name:
                attrs.append(attr_name.lower())

        for filter_el in entity_el.iter('filter'):
            for cond_el in filter_el.findall('condition'):
                cond_attr = cond_el.get('attribute', '')
                if cond_attr:
                    conditions.append({
                        'field': cond_attr.lower(),
                        'operator': cond_el.get('operator', ''),
                        'value': cond_el.get('value', ''),
                    })

        for order_el in entity_el.findall('order'):
            order_attr = order_el.get('attribute', '')
            if order_attr:
                orders.append({
                    'field': order_attr.lower(),
                    'descending': order_el.get('descending', 'false') == 'true',
                })

        def parse_link_entity(parent_el, depth=0):
            links = []
            for le in parent_el.findall('link-entity'):
                link = {
                    'entity': (le.get('name') or '').lower(),
                    'from_field': (le.get('from') or '').lower(),
                    'to_field': (le.get('to') or '').lower(),
                    'link_type': le.get('link-type', 'inner'),
                    'alias': le.get('alias', ''),
                    'attributes': [],
                    'conditions': [],
                    'orders': [],
                    'nested_links': [],
                }
                for attr_el in le.findall('attribute'):
                    attr_name = attr_el.get('name', '')
                    if attr_name:
                        link['attributes'].append(attr_name.lower())
                for filter_el in le.iter('filter'):
                    for cond_el in filter_el.findall('condition'):
                        cond_attr = cond_el.get('attribute', '')
                        if cond_attr:
                            link['conditions'].append({
                                'field': cond_attr.lower(),
                                'operator': cond_el.get('operator', ''),
                                'value': cond_el.get('value', ''),
                            })
                for order_el in le.findall('order'):
                    order_attr = order_el.get('attribute', '')
                    if order_attr:
                        link['orders'].append({
                            'field': order_attr.lower(),
                            'descending': order_el.get('descending', 'false') == 'true',
                        })
                if depth < 5:
                    link['nested_links'] = parse_link_entity(le, depth + 1)
                links.append(link)
            return links

        link_entities = parse_link_entity(entity_el)

        datasets_fields.append({
            'entity': entity_name,
            'attributes': attrs,
            'conditions': conditions,
            'orders': orders,
            'link_entities': link_entities,
        })

    return datasets_fields


def parse_reports(entity_name, known_fields):
    reports = []
    if not os.path.isdir(REPORTS_DIR):
        return reports

    entity_lower = entity_name.lower()
    rdl_ns = {'rd': 'http://schemas.microsoft.com/SQLServer/reporting/reportdesigner',
              'df': 'http://schemas.microsoft.com/sqlserver/reporting/2016/01/reportdefinition/defaultfontfamily',
              'r': 'http://schemas.microsoft.com/sqlserver/reporting/2016/01/reportdefinition'}

    for report_file in sorted(os.listdir(REPORTS_DIR)):
        full_path = os.path.join(REPORTS_DIR, report_file)
        if not os.path.isfile(full_path):
            continue

        report_name = re.sub(r'rdl[a-f0-9]{8}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{12}$',
                             '', report_file, flags=re.IGNORECASE)
        if not report_name:
            report_name = report_file

        content = read_file(full_path)
        if not content:
            continue

        try:
            root = ET.fromstring(content)
        except ET.ParseError:
            continue

        datasets = []
        involves_entity = False

        for ds_el in root.iter():
            tag = ds_el.tag.split('}')[-1] if '}' in ds_el.tag else ds_el.tag
            if tag != 'DataSet':
                continue

            ds_name = ds_el.get('Name', '')
            command_text = ''
            report_fields = []

            for child in ds_el.iter():
                child_tag = child.tag.split('}')[-1] if '}' in child.tag else child.tag
                if child_tag == 'CommandText' and child.text:
                    command_text = html.unescape(child.text.strip())
                elif child_tag == 'Field':
                    field_name = child.get('Name', '')
                    data_field = ''
                    for df_child in child:
                        df_tag = df_child.tag.split('}')[-1] if '}' in df_child.tag else df_child.tag
                        if df_tag == 'DataField' and df_child.text:
                            data_field = df_child.text
                    if field_name:
                        report_fields.append({'name': field_name, 'data_field': data_field})

            if not command_text:
                continue

            fetchxml_data = []
            try:
                fetch_root = ET.fromstring(command_text)
                fetchxml_data = extract_fetchxml_fields(fetch_root, entity_lower)
            except ET.ParseError:
                pass

            for fd in fetchxml_data:
                if fd['entity'] == entity_lower:
                    involves_entity = True
                for le in fd['link_entities']:
                    if le['entity'] == entity_lower:
                        involves_entity = True
                    for nle in le.get('nested_links', []):
                        if nle['entity'] == entity_lower:
                            involves_entity = True

            ds_params = []
            for child in ds_el.iter():
                child_tag = child.tag.split('}')[-1] if '}' in child.tag else child.tag
                if child_tag == 'QueryParameter':
                    ds_params.append(child.get('Name', ''))

            datasets.append({
                'name': ds_name,
                'fetchxml_data': fetchxml_data,
                'report_fields': report_fields,
                'parameters': ds_params,
            })

        if involves_entity and datasets:
            reports.append({
                'name': report_name,
                'file': report_file,
                'datasets': datasets,
            })

    return reports


# ---------------------------------------------------------------------------
# 6. DASHBOARDS
# ---------------------------------------------------------------------------

def parse_dashboards(entity_name, root):
    dashboards = []
    entity_lower = entity_name.lower()

    dashboards_el = root.find('Dashboards')
    if dashboards_el is None:
        return dashboards

    for dash_el in dashboards_el.findall('Dashboard'):
        name = ''
        names_el = dash_el.find('LocalizedNames')
        if names_el is not None:
            for ln in names_el.findall('LocalizedName'):
                if ln.get('languagecode') == '1033':
                    name = ln.get('description', '')
                    break

        form_id = ''
        fid_el = dash_el.find('FormId')
        if fid_el is not None and fid_el.text:
            form_id = fid_el.text

        controls = []
        involves_entity = False

        form_xml_el = dash_el.find('FormXml')
        if form_xml_el is not None:
            for control_el in form_xml_el.iter('control'):
                params = control_el.find('parameters')
                if params is None:
                    continue

                target_entity = ''
                view_id = ''
                viz_id = ''
                chart_grid_mode = ''
                relationship = ''

                te = params.find('TargetEntityType')
                if te is not None and te.text:
                    target_entity = te.text.lower()
                vi = params.find('ViewId')
                if vi is not None and vi.text:
                    view_id = vi.text
                vz = params.find('VisualizationId')
                if vz is not None and vz.text:
                    viz_id = vz.text
                cgm = params.find('ChartGridMode')
                if cgm is not None and cgm.text:
                    chart_grid_mode = cgm.text
                rn = params.find('RelationshipName')
                if rn is not None and rn.text:
                    relationship = rn.text

                if target_entity:
                    if target_entity == entity_lower:
                        involves_entity = True
                    controls.append({
                        'control_id': control_el.get('id', ''),
                        'entity': target_entity,
                        'view_id': view_id,
                        'viz_id': viz_id,
                        'chart_grid_mode': chart_grid_mode,
                        'relationship': relationship,
                    })

        if involves_entity:
            dashboards.append({
                'name': name,
                'form_id': form_id,
                'controls': controls,
            })

    return dashboards


# ---------------------------------------------------------------------------
# 7. WORKFLOWS
# ---------------------------------------------------------------------------

def parse_workflows(entity_name, known_fields, cust_root=None):
    workflows = []
    workflow_dir = os.path.join(SOLUTION_DIR, "Workflows")
    if not os.path.isdir(workflow_dir):
        return workflows

    entity_lower = entity_name.lower()
    field_set = set(f.lower() for f in known_fields)

    trigger_lookup = {}
    if cust_root is not None:
        for wf_el in cust_root.iter('Workflow'):
            xaml_el = wf_el.find('XamlFileName')
            if xaml_el is None or not xaml_el.text:
                continue
            xaml_basename = os.path.basename(xaml_el.text)
            trigger_meta = {}
            scope_el = wf_el.find('ProcessTriggerScope')
            if scope_el is not None and scope_el.text:
                scope_map = {'1': 'Form', '2': 'Entity'}
                trigger_meta['scope'] = scope_map.get(scope_el.text, scope_el.text)
            form_id_el = wf_el.find('ProcessTriggerFormId')
            if form_id_el is not None and form_id_el.text:
                trigger_meta['form_id'] = form_id_el.text
            primary_el = wf_el.find('PrimaryEntity')
            if primary_el is not None and primary_el.text:
                trigger_meta['primary_entity'] = primary_el.text
            if trigger_meta:
                trigger_lookup[xaml_basename.lower()] = trigger_meta

    for xaml_file in sorted(glob.glob(os.path.join(workflow_dir, "*.xaml"))):
        filename = os.path.basename(xaml_file)
        parts = filename.rsplit('-', 5)
        workflow_name = parts[0] if len(parts) > 1 else filename.replace('.xaml', '')

        content = read_file(xaml_file)
        if not content:
            continue

        fields_read = set()
        fields_written = set()
        custom_actions = []
        entity_refs = []

        try:
            root = ET.fromstring(content)
            for elem in root.iter():
                tag = elem.tag.split('}')[-1] if '}' in elem.tag else elem.tag

                if tag == 'GetEntityProperty':
                    attr_name = (elem.get('Attribute') or '').lower()
                    ent_name = (elem.get('EntityName') or '').lower()
                    if attr_name and ent_name == entity_lower:
                        fields_read.add(attr_name)
                        if entity_lower not in entity_refs:
                            entity_refs.append(entity_lower)

                elif tag == 'SetEntityProperty':
                    attr_name = (elem.get('Attribute') or '').lower()
                    ent_name = (elem.get('EntityName') or '').lower()
                    if attr_name and ent_name == entity_lower:
                        fields_written.add(attr_name)
                        if entity_lower not in entity_refs:
                            entity_refs.append(entity_lower)

                elif tag in ('UpdateEntity', 'AssignEntity'):
                    ent_name = (elem.get('EntityName') or '').lower()
                    if ent_name == entity_lower and entity_lower not in entity_refs:
                        entity_refs.append(entity_lower)

                elif tag == 'ActivityReference':
                    asm = elem.get('AssemblyQualifiedName', '')
                    if 'AztecPlugins' in asm or 'AztecWorkflows' in asm:
                        class_name = asm.split(',')[0].strip()
                        if class_name and class_name not in custom_actions:
                            custom_actions.append(class_name)

                elif tag == 'SetAttributeValue':
                    ent_name = (elem.get('EntityName') or '').lower()
                    if ent_name == entity_lower and entity_lower not in entity_refs:
                        entity_refs.append(entity_lower)

        except ET.ParseError:
            pass

        if not entity_refs:
            if re.search(rf'EntityName="{entity_lower}"', content, re.IGNORECASE):
                entity_refs.append(entity_lower)

        if not entity_refs:
            for match in re.finditer(r'Attribute="(\w+)"', content):
                if match.group(1).lower() in field_set:
                    entity_refs.append(entity_lower)
                    break

        if entity_refs:
            for match in re.finditer(r'Attribute="(\w+)"', content):
                fn = match.group(1).lower()
                if fn in field_set and fn not in fields_read and fn not in fields_written:
                    ctx_start = max(0, match.start() - 300)
                    ctx = content[ctx_start:match.start()]
                    if 'SetEntityProperty' in ctx or 'SetAttributeValue' in ctx:
                        fields_written.add(fn)
                    else:
                        fields_read.add(fn)

            trigger_meta = trigger_lookup.get(filename.lower(), {})
            workflows.append({
                'name': workflow_name,
                'file': filename,
                'entity_refs': entity_refs,
                'fields_read': sorted(fields_read),
                'fields_written': sorted(fields_written),
                'custom_actions': custom_actions,
                'trigger_scope': trigger_meta.get('scope', ''),
                'trigger_form_id': trigger_meta.get('form_id', ''),
                'trigger_primary_entity': trigger_meta.get('primary_entity', ''),
            })

    return workflows


# ---------------------------------------------------------------------------
# 6. JAVASCRIPT
# ---------------------------------------------------------------------------

def parse_javascript_files(entity_name, known_fields):
    js_files = []
    wr_dir = os.path.join(SOLUTION_DIR, "WebResources")
    if not os.path.isdir(wr_dir):
        return js_files

    entity_lower = entity_name.lower()
    field_set = set(f.lower() for f in known_fields)

    for wr_file in sorted(os.listdir(wr_dir)):
        full_path = os.path.join(wr_dir, wr_file)
        if not os.path.isfile(full_path):
            continue

        content = read_file(full_path)
        if not content:
            continue

        if not any(p in content for p in ['function ', 'getAttribute', 'getControl', '=>']):
            continue

        clean_name = re.sub(r'[A-F0-9]{8}-[A-F0-9]{4}-[A-F0-9]{4}-[A-F0-9]{4}-[A-F0-9]{12}$', '', wr_file, flags=re.IGNORECASE).rstrip('-')
        if not clean_name:
            clean_name = wr_file

        is_relevant = entity_lower in clean_name.lower()

        field_refs = defaultdict(lambda: {'read': False, 'write': False, 'control': False})

        for match in re.finditer(r'getAttribute\s*\(\s*["\'](\w+)["\']\s*\)', content):
            field = match.group(1).lower()
            if field in field_set:
                is_relevant = True
                after = content[match.end():match.end() + 150]
                if '.setValue' in after or '.setSubmitMode' in after:
                    field_refs[field]['write'] = True
                if '.getValue' in after or '.getText' in after:
                    field_refs[field]['read'] = True
                if not field_refs[field]['read'] and not field_refs[field]['write']:
                    field_refs[field]['read'] = True

        for match in re.finditer(r'getControl\s*\(\s*["\'](\w+)["\']\s*\)', content):
            field = match.group(1).lower()
            if field in field_set:
                is_relevant = True
                field_refs[field]['control'] = True

        # Xrm.WebApi calls — extract $select field lists
        for match in re.finditer(
            r'Xrm\.WebApi\.\w+\s*\(\s*["\'](\w+)["\']',
            content
        ):
            ent = match.group(1).lower()
            if ent == entity_lower:
                is_relevant = True
        for match in re.finditer(r'\$select=([^&"\'}\s]+)', content):
            for f in match.group(1).split(','):
                f = f.strip().lower()
                if f in field_set:
                    is_relevant = True
                    field_refs[f]['read'] = True

        # OData URL strings — $filter, $orderby
        for match in re.finditer(r'\$filter=(\w+)\s', content):
            f = match.group(1).lower()
            if f in field_set:
                is_relevant = True
                field_refs[f]['read'] = True
        for match in re.finditer(r'\$orderby=(\w+)', content):
            f = match.group(1).lower()
            if f in field_set:
                is_relevant = True
                field_refs[f]['read'] = True

        # Event handler registration — addOnChange, removeOnChange, fireOnChange
        for match in re.finditer(r'(?:addOnChange|removeOnChange|fireOnChange)\s*\(\s*["\'](\w+)["\']', content):
            field = match.group(1).lower()
            if field in field_set:
                is_relevant = True
                field_refs[field]['control'] = True

        # Embedded FetchXML in JS strings
        for match in re.finditer(r'<attribute\s+name=["\'](\w+)["\']', content):
            field = match.group(1).lower()
            if field in field_set:
                is_relevant = True
                field_refs[field]['read'] = True
        for match in re.finditer(r'<condition\s+attribute=["\'](\w+)["\']', content):
            field = match.group(1).lower()
            if field in field_set:
                is_relevant = True
                field_refs[field]['read'] = True
        for match in re.finditer(r'<order\s+attribute=["\'](\w+)["\']', content):
            field = match.group(1).lower()
            if field in field_set:
                is_relevant = True
                field_refs[field]['read'] = True

        # formContext.data.entity.attributes.get("field")
        for match in re.finditer(r'attributes\.get\s*\(\s*["\'](\w+)["\']\s*\)', content):
            field = match.group(1).lower()
            if field in field_set:
                is_relevant = True
                field_refs[field]['read'] = True

        # String literals matching field patterns (fallback)
        for match in re.finditer(r'["\'](\w+)["\']', content):
            field = match.group(1).lower()
            if field in field_set and field not in field_refs:
                ctx = content[max(0, match.start() - 60):match.end() + 60]
                if 'getAttribute' in ctx or 'getControl' in ctx or 'Attribute' in ctx:
                    is_relevant = True
                    field_refs[field]['read'] = True

        func_fields = {}
        for func_match in re.finditer(
            r'(?:(\w+)\s*:\s*function\s*\([^)]*\)\s*\{|function\s+(\w+)\s*\([^)]*\)\s*\{)', content
        ):
            func_name = func_match.group(1) or func_match.group(2)
            func_start = func_match.end() - 1
            brace_count = 0
            func_end = func_start
            for i in range(func_start, min(func_start + 8000, len(content))):
                if content[i] == '{':
                    brace_count += 1
                elif content[i] == '}':
                    brace_count -= 1
                    if brace_count == 0:
                        func_end = i
                        break
            func_body = content[func_start:func_end]
            func_field_refs = {}
            for fm in re.finditer(r'(?:getAttribute|getControl)\s*\(\s*["\'](\w+)["\']\s*\)', func_body):
                fn = fm.group(1).lower()
                if fn in field_set:
                    ops = []
                    after = func_body[fm.end():fm.end() + 150]
                    if '.getValue' in after or '.getText' in after:
                        ops.append('read')
                    if '.setValue' in after or '.setSubmitMode' in after:
                        ops.append('write')
                    if '.setVisible' in after or '.setDisabled' in after:
                        ops.append('UI')
                    if '.addOption' in after or '.removeOption' in after or '.clearOptions' in after:
                        ops.append('UI')
                    if not ops:
                        ops.append('access')
                    func_field_refs[fn] = ops

            # Xrm.WebApi in function body
            for fm in re.finditer(r'\$select=([^&"\'}\s]+)', func_body):
                for f in fm.group(1).split(','):
                    f = f.strip().lower()
                    if f in field_set and f not in func_field_refs:
                        func_field_refs[f] = ['read (WebApi)']

            # addOnChange in function body
            for fm in re.finditer(r'(?:addOnChange|removeOnChange|fireOnChange)\s*\(\s*["\'](\w+)["\']', func_body):
                fn = fm.group(1).lower()
                if fn in field_set and fn not in func_field_refs:
                    func_field_refs[fn] = ['event handler']

            # Embedded FetchXML in function body
            for fm in re.finditer(r'<(?:attribute\s+name|condition\s+attribute|order\s+attribute)=["\'](\w+)["\']', func_body):
                fn = fm.group(1).lower()
                if fn in field_set and fn not in func_field_refs:
                    func_field_refs[fn] = ['FetchXML']

            if func_field_refs:
                func_fields[func_name] = func_field_refs

        if is_relevant and (field_refs or func_fields):
            js_files.append({
                'file': wr_file,
                'clean_name': clean_name,
                'field_refs': dict(field_refs),
                'func_fields': func_fields,
            })

    return js_files


# ---------------------------------------------------------------------------
# 7. FORMULAS
# ---------------------------------------------------------------------------

def parse_formulas(entity_name):
    formulas = []
    formula_dir = os.path.join(SOLUTION_DIR, "Formulas")
    if not os.path.isdir(formula_dir):
        return formulas

    entity_lower = entity_name.lower()

    for formula_file in sorted(glob.glob(os.path.join(formula_dir, "*.xaml"))):
        filename = os.path.basename(formula_file)
        parts = filename.replace('.xaml', '').split('-', 1)
        if len(parts) != 2:
            continue
        if parts[0].lower() != entity_lower:
            continue

        formula = {
            'field': parts[1].lower(),
            'file': filename,
            'source_fields': [],
            'source_entity': '',
            'aggregation': '',
            'formula_type': 'Calculated',
        }

        content = read_file(formula_file)
        if not content:
            formula['formula_type'] = 'Unknown (unreadable)'
            formulas.append(formula)
            continue

        try:
            root = ET.fromstring(content)

            # Primary method: scan all elements and attributes for field names
            for elem in root.iter():
                tag = elem.tag.split('}')[-1] if '}' in elem.tag else elem.tag
                if tag == 'GetEntityProperty':
                    attr_name = (elem.get('Attribute') or '').lower()
                    ent_name = (elem.get('EntityName') or '').lower()
                    if attr_name:
                        formula['source_fields'].append({'field': attr_name, 'entity': ent_name or entity_lower})
                elif tag == 'SetAttributeValue':
                    ent_name = (elem.get('EntityName') or '').lower()
                    if ent_name and ent_name != entity_lower:
                        formula['source_entity'] = ent_name

                # Scan all attributes on any element for field-like values
                for attr_key, attr_val in elem.attrib.items():
                    if attr_key in ('Attribute', 'EntityName', 'AssemblyQualifiedName'):
                        continue
                    val_lower = attr_val.lower()
                    if re.match(r'^[a-z][a-z0-9_]*$', val_lower) and ('_' in val_lower or val_lower.startswith('azt')):
                        already = any(sf['field'] == val_lower for sf in formula['source_fields'])
                        if not already and val_lower != formula['field']:
                            formula['source_fields'].append({'field': val_lower, 'entity': entity_lower})

            if 'RollupRuleStep' in content:
                formula['formula_type'] = 'Rollup'
                for agg in ['Sum', 'Count', 'Max', 'Min', 'Avg']:
                    if agg in content:
                        formula['aggregation'] = agg.upper()
                        break
            elif 'DiffInDays' in content:
                formula['formula_type'] = 'Calculated (Date Diff)'
            elif 'Subtract' in content or 'Add' in content:
                formula['formula_type'] = 'Calculated (Arithmetic)'

        except ET.ParseError:
            # Fallback: filename-based extraction only
            formula['formula_type'] = 'Unknown (parse error)'

        formulas.append(formula)

    return formulas


# ---------------------------------------------------------------------------
# 8. PLUGIN C# SOURCE ANALYSIS
# ---------------------------------------------------------------------------

def build_property_lookup(plugins_dir):
    entities_file = os.path.join(plugins_dir, 'AztecEntities.cs')
    if not os.path.isfile(entities_file):
        return {}, {}

    content = read_file(entities_file)
    if not content:
        return {}, {}

    # Map: class_name → entity_logical_name
    class_to_entity = {}
    for match in re.finditer(
        r'\[Microsoft\.Xrm\.Sdk\.Client\.EntityLogicalNameAttribute\("([^"]+)"\)\]'
        r'[\s\S]*?'
        r'public\s+partial\s+class\s+(\w+)',
        content
    ):
        class_to_entity[match.group(2)] = match.group(1)

    # Map: property_name → field_logical_name
    # We scan for [AttributeLogicalNameAttribute("...")] followed by a property declaration
    property_to_field = {}
    for match in re.finditer(
        r'\[Microsoft\.Xrm\.Sdk\.AttributeLogicalNameAttribute\("([^"]+)"\)\]\s+'
        r'public\s+[\w.<>?\[\], ]+?\s+(\w+)\s*\{',
        content, re.DOTALL
    ):
        property_to_field[match.group(2)] = match.group(1)

    return property_to_field, class_to_entity


def parse_plugin_sources(entity_name, plugins_dir, property_to_field, class_to_entity):
    plugins = []
    entity_lower = entity_name.lower()

    if not os.path.isdir(plugins_dir):
        return plugins

    for cs_file in sorted(glob.glob(os.path.join(plugins_dir, '*.cs'))):
        filename = os.path.basename(cs_file)
        if filename in ('AztecEntities.cs', 'AssemblyInfo.cs'):
            continue
        if filename.endswith('.csproj') or filename == 'packages.config':
            continue

        content = read_file(cs_file)
        if not content:
            continue

        # Determine class name
        class_match = re.search(r'public\s+(?:sealed\s+)?class\s+(\w+)', content)
        class_name = class_match.group(1) if class_match else filename.replace('.cs', '')

        # Determine target entity
        target_entity = ''
        for m in re.finditer(r'\.LogicalName\s*==\s*"([^"]+)"', content):
            target_entity = m.group(1)
        eln_match = re.search(r'EntityLogicalName\s*=\s*"([^"]+)"', content)
        if eln_match:
            target_entity = eln_match.group(1)
        pen_match = re.search(r'PrimaryEntityName\s*==\s*"([^"]+)"', content)
        if pen_match:
            target_entity = pen_match.group(1)

        # Determine message type
        message = ''
        msg_match = re.search(r'MessageName\s*==\s*"([^"]+)"', content)
        if msg_match:
            message = msg_match.group(1)
        elif not message:
            for pattern, msg in [('Create', 'Create'), ('Update', 'Update'), ('Delete', 'Delete'),
                                 ('Clone', 'Create'), ('Split', 'Create'), ('Assign', 'Assign'),
                                 ('Share', 'GrantAccess'), ('Qualify', 'QualifyLead')]:
                if pattern in class_name:
                    message = f'{msg} (inferred)'
                    break

        # Extract field references
        fields_read = set()
        fields_written = set()
        fields_filtered = set()
        fields_sorted = set()
        fields_joined = set()
        image_fields = set()
        cross_entity_refs = []
        selects_all = False

        # 1. GetAttributeValue<T>("field")
        for m in re.finditer(r'\.GetAttributeValue<[^>]+>\s*\(\s*"([^"]+)"\s*\)', content):
            fields_read.add(m.group(1).lower())

        # 2. Attributes["field"]
        for m in re.finditer(r'\.Attributes\[\s*"([^"]+)"\s*\]', content):
            field = m.group(1).lower()
            ctx_after = content[m.end():m.end() + 20]
            if re.match(r'\s*=\s*[^=]', ctx_after):
                fields_written.add(field)
            else:
                fields_read.add(field)

        # 3. entity["field"] (indexer shorthand)
        for m in re.finditer(r'\w+\[\s*"([a-z][a-z0-9_]+)"\s*\]', content):
            field = m.group(1).lower()
            if re.match(r'^[a-z_][a-z0-9_]*$', field) and not field.startswith('{'):
                ctx_after = content[m.end():m.end() + 20]
                if re.match(r'\s*=\s*[^=]', ctx_after):
                    fields_written.add(field)
                else:
                    fields_read.add(field)

        # 4. .Contains("field")
        for m in re.finditer(r'\.Contains\s*\(\s*"([a-z][a-z0-9_]+)"\s*\)', content):
            fields_read.add(m.group(1).lower())

        # 5. SetAttributeValue("field", ...)
        for m in re.finditer(r'\.SetAttributeValue\s*\(\s*"([^"]+)"', content):
            fields_written.add(m.group(1).lower())

        # 6. FetchXML in C# strings
        for m in re.finditer(r"<attribute\s+name=['\"]([^'\"]+)['\"]", content):
            fields_read.add(m.group(1).lower())
        for m in re.finditer(r"<condition\s+attribute=['\"]([^'\"]+)['\"]", content):
            fields_filtered.add(m.group(1).lower())
        for m in re.finditer(r"<order\s+attribute=['\"]([^'\"]+)['\"]", content):
            fields_sorted.add(m.group(1).lower())
        for m in re.finditer(r"(?:from|to)=['\"]([a-z][a-z0-9_]+)['\"]", content):
            field = m.group(1).lower()
            if re.match(r'^[a-z_][a-z0-9_]+$', field):
                fields_joined.add(field)

        # 7. ConditionExpression("field", ...)
        for m in re.finditer(r'new\s+ConditionExpression\s*\(\s*"([^"]+)"', content):
            fields_filtered.add(m.group(1).lower())
        for m in re.finditer(r'\.AddCondition\s*\(\s*"([^"]+)"', content):
            fields_filtered.add(m.group(1).lower())

        # 8. ColumnSet("f1", "f2", ...)
        for m in re.finditer(r'new\s+ColumnSet\s*\(([^)]+)\)', content):
            args = m.group(1).strip()
            if args == 'true':
                selects_all = True
            else:
                for fm in re.finditer(r'"([^"]+)"', args):
                    fields_read.add(fm.group(1).lower())

        # 9. LinkFromAttributeName / LinkToAttributeName
        for m in re.finditer(r'Link(?:From|To)AttributeName\s*=\s*"([^"]+)"', content):
            fields_joined.add(m.group(1).lower())

        # 10. OrderExpression
        for m in re.finditer(r'new\s+OrderExpression\s*\(\s*"([^"]+)"', content):
            fields_sorted.add(m.group(1).lower())

        # 11. QueryByAttribute
        for m in re.finditer(r'\.Attributes\.(?:Add|AddRange)\s*\(\s*"([^"]+)"', content):
            fields_filtered.add(m.group(1).lower())

        # 12. Pre/Post Entity Images
        has_pre_image = 'PreEntityImages' in content
        has_post_image = 'PostEntityImages' in content
        for m in re.finditer(r'(?:Pre|Post)EntityImages\s*\[\s*"([^"]+)"\s*\]', content):
            after = content[m.end():m.end() + 500]
            for fm in re.finditer(r'\.GetAttributeValue<[^>]+>\s*\(\s*"([^"]+)"', after):
                image_fields.add(fm.group(1).lower())
            for fm in re.finditer(r'\[\s*"([a-z][a-z0-9_]+)"\s*\]', after):
                if re.match(r'^[a-z_][a-z0-9_]+$', fm.group(1)):
                    image_fields.add(fm.group(1).lower())

        # 13. AliasedValue
        for m in re.finditer(r'GetAttributeValue<AliasedValue>\s*\(\s*"([^"]+)"', content):
            alias_field = m.group(1)
            if '.' in alias_field:
                parts = alias_field.split('.', 1)
                cross_entity_refs.append({'alias': parts[0], 'field': parts[1].lower(), 'operation': 'Read'})
            else:
                fields_read.add(alias_field.lower())

        # 14. Typed custom property access (azt_, ezt_ prefixed)
        for m in re.finditer(r'\.([ae]zt_\w+)\b', content):
            prop_name = m.group(1)
            field_logical = property_to_field.get(prop_name, prop_name.lower())
            ctx_after = content[m.end():m.end() + 10].strip()
            if ctx_after.startswith('=') and not ctx_after.startswith('=='):
                fields_written.add(field_logical)
            else:
                fields_read.add(field_logical)

        # 15. Object initializers: new EntityClass() { Prop = val, ... }
        for m in re.finditer(r'new\s+(\w+)\s*\(\s*\)\s*\{([^}]{5,})\}', content, re.DOTALL):
            init_class = m.group(1)
            init_body = m.group(2)
            init_entity = class_to_entity.get(init_class, '')
            if init_entity:
                for pm in re.finditer(r'(\w+)\s*=\s*', init_body):
                    prop = pm.group(1)
                    field = property_to_field.get(prop, '')
                    if field:
                        fields_written.add(field)

        all_fields = fields_read | fields_written | fields_filtered | fields_sorted | fields_joined | image_fields
        if all_fields or cross_entity_refs or selects_all:
            plugins.append({
                'class_name': class_name,
                'file': filename,
                'target_entity': target_entity,
                'message': message,
                'fields_read': sorted(fields_read),
                'fields_written': sorted(fields_written),
                'fields_filtered': sorted(fields_filtered),
                'fields_sorted': sorted(fields_sorted),
                'fields_joined': sorted(fields_joined),
                'image_fields': sorted(image_fields),
                'cross_entity_refs': cross_entity_refs,
                'selects_all': selects_all,
                'has_pre_image': has_pre_image,
                'has_post_image': has_post_image,
            })

    return plugins


# ---------------------------------------------------------------------------
# 9. PCF CONTROLS
# ---------------------------------------------------------------------------

def parse_pcf_controls():
    controls = []
    controls_dir = os.path.join(SOLUTION_DIR, "Controls")
    if not os.path.isdir(controls_dir):
        return controls

    for manifest_path in sorted(glob.glob(os.path.join(controls_dir, "*", "ControlManifest.xml"))):
        try:
            tree = ET.parse(manifest_path)
            root = tree.getroot()
            for control_el in root.iter('control'):
                ctrl = {
                    'namespace': control_el.get('namespace', ''),
                    'constructor': control_el.get('constructor', ''),
                    'version': control_el.get('version', ''),
                    'display_name': control_el.get('display-name-key', ''),
                    'description': control_el.get('description-key', ''),
                    'bound_properties': [],
                    'input_properties': [],
                }
                for prop in control_el.findall('property'):
                    pd = {
                        'name': prop.get('name', ''),
                        'display_name': prop.get('display-name-key', ''),
                        'type': prop.get('of-type', ''),
                        'usage': prop.get('usage', ''),
                        'required': prop.get('required', 'false') == 'true',
                    }
                    if pd['usage'] == 'bound':
                        ctrl['bound_properties'].append(pd)
                    else:
                        ctrl['input_properties'].append(pd)
                controls.append(ctrl)
        except (ET.ParseError, IOError):
            continue

    return controls


# ---------------------------------------------------------------------------
# 10. RELATIONSHIPS
# ---------------------------------------------------------------------------

def parse_relationships(root, entity_name):
    relationships = []
    entity_lower = entity_name.lower()

    for rel_el in root.iter('EntityRelationship'):
        rel_name = rel_el.get('Name', '')
        rel_type_el = rel_el.find('EntityRelationshipType')
        rel_type = rel_type_el.text if rel_type_el is not None and rel_type_el.text else ''

        ref_el = rel_el.find('ReferencedEntityName')
        ref_entity = ref_el.text if ref_el is not None and ref_el.text else ''

        refing_el = rel_el.find('ReferencingEntityName')
        refing_entity = refing_el.text if refing_el is not None and refing_el.text else ''

        refing_attr_el = rel_el.find('ReferencingAttributeName')
        refing_attr = refing_attr_el.text if refing_attr_el is not None and refing_attr_el.text else ''

        e1_el = rel_el.find('Entity1LogicalName')
        e2_el = rel_el.find('Entity2LogicalName')
        e1 = e1_el.text if e1_el is not None and e1_el.text else ''
        e2 = e2_el.text if e2_el is not None and e2_el.text else ''

        involves = (
            ref_entity.lower() == entity_lower
            or refing_entity.lower() == entity_lower
            or e1.lower() == entity_lower
            or e2.lower() == entity_lower
        )

        if involves:
            if rel_type == 'ManyToManyRelationship':
                intersect_el = rel_el.find('IntersectEntityName')
                intersect = intersect_el.text if intersect_el is not None and intersect_el.text else ''
                other = e2 if e1.lower() == entity_lower else e1
                relationships.append({
                    'name': rel_name,
                    'type': 'N:N',
                    'referenced_entity': other,
                    'referencing_entity': intersect,
                    'referencing_attribute': '',
                })
            else:
                rtype = '1:N' if ref_entity.lower() == entity_lower else 'N:1'
                relationships.append({
                    'name': rel_name,
                    'type': rtype,
                    'referenced_entity': ref_entity,
                    'referencing_entity': refing_entity,
                    'referencing_attribute': refing_attr,
                })

    return sorted(relationships, key=lambda r: r['name'])


# ---------------------------------------------------------------------------
# 11. RIBBON
# ---------------------------------------------------------------------------

def parse_ribbon(entity_el):
    ribbon_data = {'custom_actions': [], 'commands': []}
    ribbon_el = entity_el.find('RibbonDiffXml')
    if ribbon_el is None:
        return ribbon_data

    loc_labels = {}
    loc_labels_el = ribbon_el.find('LocLabels')
    if loc_labels_el is not None:
        for ll in loc_labels_el.findall('LocLabel'):
            label_id = ll.get('Id', '')
            for title in ll.iter('Title'):
                if title.get('languagecode') == '1033':
                    loc_labels[label_id] = title.get('description', '')
                    break

    custom_actions = ribbon_el.find('CustomActions')
    if custom_actions is not None:
        for ca in custom_actions.findall('CustomAction'):
            action = {
                'id': ca.get('Id', ''),
                'location': ca.get('Location', ''),
                'button_label': '',
                'command_id': '',
            }
            for el in ca.iter():
                tag = el.tag.split('}')[-1] if '}' in el.tag else el.tag
                if tag in ('Button', 'FlyoutAnchor'):
                    raw_label = el.get('LabelText', '')
                    label_key = raw_label.replace('$LocLabels:', '')
                    action['button_label'] = loc_labels.get(label_key, label_key)
                    action['command_id'] = el.get('Command', '')
                    break
            ribbon_data['custom_actions'].append(action)

    cmd_defs = ribbon_el.find('CommandDefinitions')
    if cmd_defs is not None:
        for cmd in cmd_defs.findall('CommandDefinition'):
            command = {'id': cmd.get('Id', ''), 'js_functions': []}
            actions_el = cmd.find('Actions')
            if actions_el is not None:
                for js in actions_el.findall('JavaScriptFunction'):
                    command['js_functions'].append({
                        'function': js.get('FunctionName', ''),
                        'library': (js.get('Library') or '').replace('$webresource:', ''),
                    })
            ribbon_data['commands'].append(command)

    return ribbon_data


# ---------------------------------------------------------------------------
# CONFLICTS & OBSERVATIONS
# ---------------------------------------------------------------------------

def compute_conflicts(entity_name, fields, forms, views, workflows, js_files,
                      formulas, plugin_refs, chart_visualizations, reports=None):
    # Per-form conflicts: same field with different visibility/disabled across forms
    field_form_data = defaultdict(list)
    for form in forms:
        for tab in form['tabs']:
            for section in tab['sections']:
                for fld in section['fields']:
                    if not fld['is_subgrid'] and not fld['is_webresource']:
                        field_form_data[fld['name'].lower()].append({
                            'form': form['name'],
                            'form_type': form['form_type'],
                            'visible': fld['visible'],
                            'disabled': fld['disabled'],
                        })

    per_form_conflicts = []
    for field_name, entries in sorted(field_form_data.items()):
        if len(entries) < 2:
            continue
        vis_values = set(e['visible'] for e in entries)
        dis_values = set(e['disabled'] for e in entries)
        if len(vis_values) > 1 or len(dis_values) > 1:
            per_form_conflicts.append({
                'field': field_name,
                'entries': entries,
                'inconsistent_visibility': len(vis_values) > 1,
                'inconsistent_disabled': len(dis_values) > 1,
            })

    # Fields on forms
    form_fields = set()
    for form in forms:
        form_fields.update(form['all_fields'])

    # Fields in code (plugins, workflows, JS)
    code_fields = set()
    for wf in workflows:
        code_fields.update(f.lower() for f in wf['fields_read'])
        code_fields.update(f.lower() for f in wf['fields_written'])
    for js in js_files:
        code_fields.update(f.lower() for f in js['field_refs'].keys())
        for func_refs in js['func_fields'].values():
            code_fields.update(f.lower() for f in func_refs.keys())
    for plugin in plugin_refs:
        code_fields.update(f.lower() for f in plugin['fields_read'])
        code_fields.update(f.lower() for f in plugin['fields_written'])
        code_fields.update(f.lower() for f in plugin['fields_filtered'])

    # Fields in any logic (code + views + formulas + charts)
    logic_fields = set(code_fields)
    for view in views:
        for col in view['columns']:
            logic_fields.add(col['name'].lower())
        for fc in view['filter_fields']:
            logic_fields.add(fc['field'].lower())
    for formula in formulas:
        logic_fields.add(formula['field'].lower())
        for sf in formula['source_fields']:
            logic_fields.add(sf['field'].lower())
    for chart in chart_visualizations:
        for mf in chart['measure_fields']:
            logic_fields.add(mf['field'].lower())
        for gf in chart['groupby_fields']:
            logic_fields.add(gf['field'].lower())
        for ff in chart['filter_fields']:
            logic_fields.add(ff['field'].lower())

    if reports:
        for rpt in reports:
            for ds in rpt['datasets']:
                for fd in ds['fetchxml_data']:
                    for attr in fd['attributes']:
                        code_fields.add(attr.lower())
                        logic_fields.add(attr.lower())
                    for cond in fd['conditions']:
                        code_fields.add(cond['field'].lower())
                        logic_fields.add(cond['field'].lower())
                    for order in fd['orders']:
                        code_fields.add(order['field'].lower())
                        logic_fields.add(order['field'].lower())
                    for le in fd['link_entities']:
                        for attr in le['attributes']:
                            logic_fields.add(attr.lower())
                        for cond in le['conditions']:
                            logic_fields.add(cond['field'].lower())

    in_code_not_on_forms = sorted(code_fields - form_fields)
    on_forms_not_in_logic = sorted(form_fields - logic_fields)

    return {
        'per_form_conflicts': per_form_conflicts,
        'in_code_not_on_forms': in_code_not_on_forms,
        'on_forms_not_in_logic': on_forms_not_in_logic,
    }


# ---------------------------------------------------------------------------
# SF MAPPING
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
                    col: row.get(col, "") or "" for col in CSV_COLUMNS
                }
    return mapping


def build_sf_entity_index(sf_entities_dir):
    """Scan salesforce-entities/*.json and build {objectName_lower: objectName}.

    Returns dict mapping lowercase object name to its canonical casing.
    """
    import json
    index = {}
    if not os.path.isdir(sf_entities_dir):
        return index
    for fname in os.listdir(sf_entities_dir):
        if not fname.endswith('.json'):
            continue
        fpath = os.path.join(sf_entities_dir, fname)
        try:
            with open(fpath, 'r', encoding='utf-8') as f:
                data = json.load(f)
            obj_name = data.get('objectName', '')
            if obj_name:
                index[obj_name.lower()] = obj_name
        except (json.JSONDecodeError, IOError):
            continue
    return index


def load_sf_entity_fields(sf_entities_dir, sf_object_name):
    """Load the SF entity JSON for a given object and return its fields.

    Returns list of field dicts from the JSON, or empty list.
    """
    import json
    if not os.path.isdir(sf_entities_dir):
        return []
    # Filename is objectName lowered + .json
    fname = sf_object_name.lower() + '.json'
    fpath = os.path.join(sf_entities_dir, fname)
    if not os.path.isfile(fpath):
        return []
    try:
        with open(fpath, 'r', encoding='utf-8') as f:
            data = json.load(f)
        return data.get('fields', [])
    except (json.JSONDecodeError, IOError):
        return []


def resolve_sf_object(entity_name, mapping_dir, sf_entity_index):
    """Determine the SF object name for a D365 entity (data-driven only).

    1. From existing CSV data — most common sfObjectName or sfSuggestedObjectName
    2. From SF entity JSON index — match D365 entity name to SF objectName
    3. No match — returns ''
    """
    # Tier 1: scan CSV for most common SF object name
    csv_path = os.path.join(mapping_dir, f"{entity_name}.csv")
    if os.path.isfile(csv_path):
        obj_counts = defaultdict(int)
        with open(csv_path, "r", encoding="utf-8") as f:
            reader = csv.DictReader(f)
            for row in reader:
                for col in ("sfObjectName", "sfSuggestedObjectName"):
                    val = (row.get(col, "") or "").strip()
                    if val:
                        obj_counts[val] += 1
        if obj_counts:
            return max(obj_counts, key=obj_counts.get)

    # Tier 2: match against SF entity JSON objectNames
    if entity_name in sf_entity_index:
        return sf_entity_index[entity_name]

    # Tier 3: no match
    return ''


def build_sf_field_lookup(sf_fields):
    """Build lookup dicts from an SF entity's field list.

    Returns (by_d365_internal, by_d365_suggested, by_name_lower):
    - by_d365_internal: {d365InternalName_lower: sf_field_dict}
    - by_d365_suggested: {d365SuggestedInternalName_lower: sf_field_dict}
    - by_name_lower: {fieldName_lower: sf_field_dict}
    """
    by_d365_internal = {}
    by_d365_suggested = {}
    by_name_lower = {}
    for sf_field in sf_fields:
        fn = sf_field.get('fieldName', '')
        if fn:
            by_name_lower[fn.lower()] = sf_field
        d365_int = sf_field.get('d365InternalName') or ''
        if d365_int:
            by_d365_internal[d365_int.lower()] = sf_field
        d365_sug = sf_field.get('d365SuggestedInternalName') or ''
        if d365_sug:
            by_d365_suggested[d365_sug.lower()] = sf_field
    return by_d365_internal, by_d365_suggested, by_name_lower


def match_sf_field(d365_schema_name, by_d365_internal, by_d365_suggested, by_name_lower):
    """Find the best-matching SF field for a D365 field.

    Resolution order:
    1. Confirmed mapping: d365InternalName matches D365 schema_name
    2. Suggested mapping: d365SuggestedInternalName matches D365 schema_name
    3. Exact name match: SF fieldName matches D365 schema_name (case-insensitive)
    4. No match

    Returns (sf_field_api_name, sf_field_api_name) or ('', '').
    We use fieldName for both display and API since the JSON has no separate
    display name — the CSV consumer can refine the display name later.
    """
    key = d365_schema_name.lower()
    sf_field = by_d365_internal.get(key) or by_d365_suggested.get(key) or by_name_lower.get(key)
    if sf_field:
        fn = sf_field.get('fieldName', '')
        return fn, fn
    return '', ''


def update_mapping_csv(mapping_dir, entity_name, fields, sf_mapping,
                       field_mapping_suggested, field_ref_counts=None):
    """Write one row per D365 field to the mapping CSV.

    Includes D365 metadata, report columns, reference counts, and SF mapping.
    Every field is written regardless of whether SF columns are populated.
    Sorted by fieldName.
    """
    csv_path = os.path.join(mapping_dir, f"{entity_name}.csv")
    header = ["fieldName"] + CSV_COLUMNS
    if field_ref_counts is None:
        field_ref_counts = {}

    rows = []
    for field in sorted(fields, key=lambda f: f['schema_name'].lower()):
        sn_lower = field['schema_name'].lower()
        data = sf_mapping.get(sn_lower, {})
        pv = field.get('picklist_values', [])
        pv_str = ', '.join(
            f'{v["value"]}: {v["label"]}' for v in pv) if pv else ''
        suggested = field_mapping_suggested.get(sn_lower, False)
        row = {
            "fieldName": field['schema_name'],
            "displayName": field.get('display_name', ''),
            "dataType": field.get('data_type', ''),
            "requiredLevel": field.get('required_level', ''),
            "isCustom": str(field.get('is_custom', False)),
            "picklistValues": pv_str,
            "mappingSuggested": "true" if suggested else "false",
        }
        refs = field_ref_counts.get(sn_lower, {})
        for csv_col, count_key in REF_COUNT_COLUMNS:
            row[csv_col] = refs.get(count_key, 0)
        for col in SF_COLUMNS:
            row[col] = data.get(col, "") or ""
        rows.append(row)

    os.makedirs(mapping_dir, exist_ok=True)
    with open(csv_path, "w", encoding="utf-8", newline="") as f:
        writer = csv.DictWriter(f, fieldnames=header)
        writer.writeheader()
        writer.writerows(rows)


# ---------------------------------------------------------------------------
# SECTION REFERENCE COUNTING
# ---------------------------------------------------------------------------

def count_field_references(entity_name, forms, views, chart_visualizations,
                           reports, dashboards, workflows, formulas,
                           plugin_refs, controls, relationships, ribbon, conflicts):
    """Pre-compute per-field reference counts for each report section.

    Returns a defaultdict mapping field_name_lower -> {section_key: count}.
    Section keys: forms, views, charts, reports, dashboards, workflows,
    formulas, plugins, pcf, rels, ribbon, conflicts.
    """
    counts = defaultdict(lambda: defaultdict(int))

    # Forms: header_fields, tabs[].sections[].fields (non-subgrid, non-webresource), footer_fields
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

    # Views: columns, filter_fields, sort_fields
    for view in views:
        for col in view['columns']:
            counts[col['name'].lower()]['views'] += 1
        for ff in view['filter_fields']:
            counts[ff['field'].lower()]['views'] += 1
        for sf in view['sort_fields']:
            counts[sf['field'].lower()]['views'] += 1

    # Charts: measure_fields, groupby_fields, filter_fields, sort_fields
    for chart in chart_visualizations:
        for mf in chart['measure_fields']:
            counts[mf['field'].lower()]['charts'] += 1
        for gf in chart['groupby_fields']:
            counts[gf['field'].lower()]['charts'] += 1
        for ff in chart['filter_fields']:
            counts[ff['field'].lower()]['charts'] += 1
        for sf in chart['sort_fields']:
            counts[sf['field'].lower()]['charts'] += 1

    # Reports: datasets[].fetchxml_data[].attributes, conditions, orders + recursive link_entities
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

    # Dashboards: no direct field references (reference views/charts by ID)

    # Workflows: fields_read, fields_written
    for wf in workflows:
        for fn in wf['fields_read']:
            counts[fn.lower()]['workflows'] += 1
        for fn in wf['fields_written']:
            counts[fn.lower()]['workflows'] += 1

    # Formulas: field (target) + source_fields[].field
    for formula in formulas:
        counts[formula['field'].lower()]['formulas'] += 1
        for sf in formula['source_fields']:
            counts[sf['field'].lower()]['formulas'] += 1

    # Plugins: fields_read, fields_written, fields_filtered, fields_sorted, fields_joined, image_fields
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

    # PCF Controls: bound_properties[].name
    for ctrl in controls:
        for prop in ctrl['bound_properties']:
            if prop['name']:
                counts[prop['name'].lower()]['pcf'] += 1

    # Relationships: referencing_attribute
    for rel in relationships:
        if rel['referencing_attribute']:
            counts[rel['referencing_attribute'].lower()]['rels'] += 1

    # Ribbon: no direct field references (defines buttons/commands)
    # Conflicts: derived analysis, no direct field references

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

def discover_entities(root):
    entities = []
    for el in root.findall(".//Entity"):
        name_el = el.find("Name")
        if name_el is not None and name_el.text:
            entities.append(name_el.text)
    return sorted(entities, key=str.lower)


def process_entity(entity_name, root, output_dir, property_to_field, class_to_entity,
                    mapping_dir=None, sf_entity_index=None):
    entity_name = entity_name.lower()

    print(f"\nProcessing {entity_name.upper()}...")
    print("-" * 40)

    entity_el = None
    for el in root.findall(".//Entity"):
        name_el = el.find("Name")
        if name_el is not None and name_el.text and name_el.text.lower() == entity_name:
            entity_el = el
            break

    if entity_el is None:
        print(f"  ERROR: Entity '{entity_name}' not found!")
        return False

    fields = parse_field_definitions(entity_el)
    print(f"  Fields: {len(fields)}")
    known_fields = set(f['schema_name'] for f in fields)

    forms = parse_forms(entity_el)
    print(f"  Forms: {len(forms)}")

    views = parse_views(entity_el)
    print(f"  Views: {len(views)}")

    chart_visualizations = parse_chart_visualizations(entity_el, entity_name)
    print(f"  Chart Visualizations: {len(chart_visualizations)}")

    reports = parse_reports(entity_name, known_fields)
    print(f"  Reports: {len(reports)}")

    dashboards = parse_dashboards(entity_name, root)
    print(f"  Dashboards: {len(dashboards)}")

    workflows = parse_workflows(entity_name, known_fields, cust_root=root)
    print(f"  Workflows: {len(workflows)}")

    js_files = parse_javascript_files(entity_name, known_fields)
    print(f"  JS Files: {len(js_files)}")

    formulas = parse_formulas(entity_name)
    print(f"  Formulas: {len(formulas)}")

    plugin_refs = parse_plugin_sources(entity_name, PLUGINS_DIR, property_to_field, class_to_entity)
    print(f"  Plugin source files analyzed: {len(plugin_refs)}")

    controls = parse_pcf_controls()
    print(f"  PCF controls: {len(controls)}")

    relationships = parse_relationships(root, entity_name)
    print(f"  Relationships: {len(relationships)}")

    ribbon = parse_ribbon(entity_el)
    print(f"  Ribbon Actions: {len(ribbon['custom_actions'])}")
    print(f"  Ribbon Commands: {len(ribbon['commands'])}")

    all_referenced = set()

    for form in forms:
        all_referenced.update(form['all_fields'])

    for view in views:
        for col in view['columns']:
            all_referenced.add(col['name'].lower())
        for fc in view['filter_fields']:
            all_referenced.add(fc['field'].lower())
        for sf in view['sort_fields']:
            all_referenced.add(sf['field'].lower())

    for chart in chart_visualizations:
        for mf in chart['measure_fields']:
            all_referenced.add(mf['field'].lower())
        for gf in chart['groupby_fields']:
            all_referenced.add(gf['field'].lower())
        for ff in chart['filter_fields']:
            all_referenced.add(ff['field'].lower())

    for rpt in reports:
        for ds in rpt['datasets']:
            for fd in ds['fetchxml_data']:
                for attr in fd['attributes']:
                    all_referenced.add(attr.lower())
                for cond in fd['conditions']:
                    all_referenced.add(cond['field'].lower())
                for order in fd['orders']:
                    all_referenced.add(order['field'].lower())
                for le in fd['link_entities']:
                    for attr in le['attributes']:
                        all_referenced.add(attr.lower())
                    for cond in le['conditions']:
                        all_referenced.add(cond['field'].lower())

    for wf in workflows:
        for fn in wf['fields_read']:
            all_referenced.add(fn.lower())
        for fn in wf['fields_written']:
            all_referenced.add(fn.lower())

    for js in js_files:
        for fn in js['field_refs']:
            all_referenced.add(fn.lower())
        for func_refs in js['func_fields'].values():
            for fn in func_refs:
                all_referenced.add(fn.lower())

    for formula in formulas:
        all_referenced.add(formula['field'].lower())
        for sf in formula['source_fields']:
            all_referenced.add(sf['field'].lower())

    for plugin in plugin_refs:
        for fn in plugin['fields_read']:
            all_referenced.add(fn.lower())
        for fn in plugin['fields_written']:
            all_referenced.add(fn.lower())
        for fn in plugin['fields_filtered']:
            all_referenced.add(fn.lower())

    for rel in relationships:
        if rel['referencing_attribute']:
            all_referenced.add(rel['referencing_attribute'].lower())

    for ctrl in controls:
        for prop in ctrl['bound_properties']:
            if prop['name']:
                all_referenced.add(prop['name'].lower())

    defined_names = set(f['schema_name'].lower() for f in fields)
    missing = all_referenced - defined_names

    for field_name in missing:
        fields.append({
            'schema_name': field_name,
            'display_name': '',
            'data_type': '',
            'required_level': '',
            'is_custom': field_name.startswith(('azt_', 'ezt_')),
            'introduced_version': '',
            'picklist_values': [],
        })

    fields = sorted(fields, key=lambda f: f['schema_name'].lower())
    print(f"  Augmented fields: {len(fields)} ({len(missing)} inferred from usage)")

    conflicts = compute_conflicts(
        entity_name, fields, forms, views, workflows, js_files,
        formulas, plugin_refs, chart_visualizations, reports
    )
    print(f"  Per-form conflicts: {len(conflicts['per_form_conflicts'])}")
    print(f"  Fields in code not on forms: {len(conflicts['in_code_not_on_forms'])}")
    print(f"  Fields on forms not in logic: {len(conflicts['on_forms_not_in_logic'])}")

    # SF mapping: compute usage first, then write validated suggestions to CSV
    field_mapping_suggested = {}
    field_ref_counts = count_field_references(
        entity_name, forms, views, chart_visualizations,
        reports, dashboards, workflows, formulas,
        plugin_refs, controls, relationships, ribbon, conflicts
    )
    if mapping_dir:
        sf_mapping = load_mapping_csv(mapping_dir, entity_name)
        sf_object = resolve_sf_object(entity_name, mapping_dir, sf_entity_index)

        # Load SF entity fields for suggestion matching
        sf_fields = load_sf_entity_fields(SF_ENTITIES_DIR, sf_object) if sf_object else []
        by_d365_internal, by_d365_suggested, by_name_lower = build_sf_field_lookup(sf_fields)

        # Write suggestions to CSV only for fields with usage that lack
        # confirmed mapping; also validate/clean orphan mapping values
        suggestions_added = 0
        for field in fields:
            sn_lower = field['schema_name'].lower()
            if sn_lower not in sf_mapping:
                sf_mapping[sn_lower] = {col: '' for col in SF_COLUMNS}
            data = sf_mapping[sn_lower]

            # Compute whether this field has any usage across all sections
            refs = field_ref_counts.get(sn_lower, {})
            has_usage = any(refs.get(k, 0) > 0 for k in refs)

            # Rule 1b: clear sfObjectName if sfFieldDisplayName AND
            # sfFieldApiName are both empty
            if data.get('sfObjectName') and not (
                    data.get('sfFieldDisplayName') and data.get('sfFieldApiName')):
                data['sfObjectName'] = ''

            # Rule 1a: clear sfSuggested* for fields with zero usage
            if not has_usage:
                data['sfSuggestedObjectName'] = ''
                data['sfSuggestedFieldDisplayName'] = ''
                data['sfSuggestedFieldApiName'] = ''
            else:
                # Rule 1c: clear sfSuggestedObjectName if
                # sfSuggestedFieldDisplayName AND sfSuggestedFieldApiName
                # are both empty
                if data.get('sfSuggestedObjectName') and not (
                        data.get('sfSuggestedFieldDisplayName') and
                        data.get('sfSuggestedFieldApiName')):
                    data['sfSuggestedObjectName'] = ''

                # Rule 1d: generate suggestions for fields with usage that
                # lack all three confirmed SF columns
                has_confirmed = all(data.get(c, '') for c in (
                    'sfObjectName', 'sfFieldDisplayName', 'sfFieldApiName'))
                has_suggested = all(data.get(c, '') for c in (
                    'sfSuggestedObjectName', 'sfSuggestedFieldDisplayName',
                    'sfSuggestedFieldApiName'))
                if not has_confirmed and not has_suggested and sf_object:
                    sf_display, sf_api = match_sf_field(
                        field['schema_name'],
                        by_d365_internal, by_d365_suggested, by_name_lower)
                    if sf_display and sf_api:
                        data['sfSuggestedObjectName'] = sf_object
                        data['sfSuggestedFieldDisplayName'] = sf_display
                        data['sfSuggestedFieldApiName'] = sf_api
                        suggestions_added += 1

        # Compute mapping_suggested before writing CSV so it's persisted
        for field in fields:
            sn_lower = field['schema_name'].lower()
            refs = field_ref_counts.get(sn_lower, {})
            has_usage = any(refs.get(k, 0) > 0 for k in refs)
            req = field.get('required_level', '') or ''
            is_required = req.lower() not in ('', 'none')
            field_mapping_suggested[sn_lower] = has_usage or is_required

        update_mapping_csv(mapping_dir, entity_name, fields, sf_mapping,
                           field_mapping_suggested, field_ref_counts)

        # Reload CSV as the single source of truth for the report
        sf_mapping = load_mapping_csv(mapping_dir, entity_name)

        matched = sum(1 for v in sf_mapping.values() if v.get('sfSuggestedFieldApiName', ''))
        print(f"  SF mapping: {len(sf_mapping)} CSV rows, {suggestions_added} suggestions added ({matched} with SF field match)")
    else:
        sf_mapping = {}

    markdown, field_index = generate_markdown(
        entity_name, fields, forms, views, chart_visualizations,
        reports, dashboards,
        workflows, js_files, formulas, plugin_refs, controls,
        relationships, ribbon, conflicts,
        sf_mapping=sf_mapping, field_mapping_suggested=field_mapping_suggested
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
    js_fields = set()
    for js in js_files:
        js_fields.update(js['field_refs'].keys())
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
    print(f"    Fields in JavaScript: {len(js_fields)}")
    print(f"    Fields in formulas:   {len(formulas)}")
    print(f"    Fields in plugins:    {len(plugin_fields)}")
    print(f"    Total unique indexed: {len(field_index)}")

    return True


def main():
    parser = argparse.ArgumentParser(
        description='D365CE Entity Field Usage Analysis Generator'
    )
    parser.add_argument('entity', nargs='?', default=None,
                        help='Target entity schema name (e.g., account, contact)')
    parser.add_argument('--all', action='store_true',
                        help='Generate reports for all entities in the solution')
    parser.add_argument('--output-dir', default=DEFAULT_OUTPUT_DIR,
                        help='Directory for generated .md files (default: reports/)')
    parser.add_argument('--mapping-dir', default=DEFAULT_MAPPING_DIR,
                        help='Directory containing SF mapping CSVs (default: mapping/)')
    args = parser.parse_args()

    if not args.all and not args.entity:
        parser.error('either provide an entity name or use --all')

    output_dir = args.output_dir
    mapping_dir = args.mapping_dir

    if not os.path.isdir(output_dir):
        os.makedirs(output_dir, exist_ok=True)

    print("=" * 60)
    print("D365CE Field Usage Analysis Generator")
    print("=" * 60)
    print()

    print("Parsing customizations.xml...")
    root = ET.parse(CUSTOMIZATIONS_FILE).getroot()
    print("  Done.")

    print("  Building plugin property lookup...")
    property_to_field, class_to_entity = build_property_lookup(PLUGINS_DIR)
    print(f"    Property mappings: {len(property_to_field)}")
    print(f"    Entity classes: {len(class_to_entity)}")

    print("  Building SF entity index...")
    sf_entity_index = build_sf_entity_index(SF_ENTITIES_DIR)
    print(f"    SF objects: {len(sf_entity_index)}")

    if args.all:
        entities = discover_entities(root)
        print(f"\nDiscovered {len(entities)} entities in solution.")
        success = 0
        for entity_name in entities:
            if process_entity(entity_name, root, output_dir, property_to_field, class_to_entity,
                              mapping_dir=mapping_dir, sf_entity_index=sf_entity_index):
                success += 1
        print()
        print("=" * 60)
        print(f"Generation complete! {success}/{len(entities)} entities processed.")
        print("=" * 60)
    else:
        entity_name = args.entity.lower()
        if not process_entity(entity_name, root, output_dir, property_to_field, class_to_entity,
                              mapping_dir=mapping_dir, sf_entity_index=sf_entity_index):
            sys.exit(1)
        print()
        print("=" * 60)
        print("Generation complete!")
        print("=" * 60)


if __name__ == '__main__':
    main()
