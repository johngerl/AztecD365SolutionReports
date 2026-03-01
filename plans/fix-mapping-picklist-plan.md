# Plan: Fix SF Mapping Logic, Add Picklist Values to Reports & JSON

## Overview

Three related changes across `generate_field_usage.py` and `enrich_entity_json.py`:
1. Fix SF suggestion/mapping validation logic in CSVs
2. Add "Picklist Values" column to Field Definitions table in Markdown reports
3. Add `picklistValues` array to enriched D365 entity JSON

---

## Task 1: Fix SF Mapping Logic (`generate_field_usage.py`)

### Current Bugs

**Lines 2963-2981** — The suggestion loop:
- Populates `sfSuggestedObjectName` for ALL fields without existing mapping, even if the field has zero usage (no forms, views, charts, reports, dashboards, workflows, formulas, plugins, PCF controls, relationships)
- Sets `sfSuggestedObjectName = sf_object` even when `match_sf_field()` returns `('', '')` — resulting in rows like `accessrightsmask,,,,Account,,` (object name but no field match)
- Never clears stale `sfSuggested*` values when a field becomes unused
- Never validates that `sfObjectName` has corresponding `sfFieldDisplayName` + `sfFieldApiName`

**Lines 2988-3000** — `field_mapping_suggested` is computed AFTER CSV is written, so it's only used for display — it never gates the actual CSV data.

### Changes

#### 1.1 Move `field_ref_counts` computation BEFORE the SF mapping loop

Currently `count_field_references()` is called at line 2989, after the CSV is already written. Move it before line 2963 so usage data is available for gating suggestions.

#### 1.2 Gate suggestion generation on field usage (Rule 1a + 1d)

In the suggestion loop (~line 2965), add a usage check:

```python
# Compute usage for this field
refs = field_ref_counts.get(sn_lower, {})
has_usage = any(refs.get(k, 0) > 0 for k in refs)

# Only generate suggestions if field has usage AND lacks confirmed mapping
has_confirmed = all(data.get(c, '') for c in (
    'sfObjectName', 'sfFieldDisplayName', 'sfFieldApiName'))

if has_usage and not has_confirmed and sf_object:
    sf_display, sf_api = match_sf_field(...)
    if sf_display and sf_api:  # Only set object when field match found
        data['sfSuggestedObjectName'] = sf_object
        data['sfSuggestedFieldDisplayName'] = sf_display
        data['sfSuggestedFieldApiName'] = sf_api
```

#### 1.3 Clear sfSuggested* for unused fields (Rule 1a)

After the suggestion loop, iterate fields and clear `sfSuggested*` for fields with zero usage:

```python
if not has_usage:
    data['sfSuggestedObjectName'] = ''
    data['sfSuggestedFieldDisplayName'] = ''
    data['sfSuggestedFieldApiName'] = ''
```

#### 1.4 Validate orphan sfObjectName (Rule 1b)

Clear `sfObjectName` if `sfFieldDisplayName` AND `sfFieldApiName` are both empty:

```python
if data.get('sfObjectName') and not (data.get('sfFieldDisplayName') and data.get('sfFieldApiName')):
    data['sfObjectName'] = ''
```

#### 1.5 Validate orphan sfSuggestedObjectName (Rule 1c)

Clear `sfSuggestedObjectName` if `sfSuggestedFieldDisplayName` AND `sfSuggestedFieldApiName` are both empty:

```python
if data.get('sfSuggestedObjectName') and not (data.get('sfSuggestedFieldDisplayName') and data.get('sfSuggestedFieldApiName')):
    data['sfSuggestedObjectName'] = ''
```

#### 1.6 Salesforce naming convention compliance (Rule 1d)

When generating `sfSuggestedFieldApiName`, ensure it follows SF conventions:
- Custom fields end with `__c`
- Use PascalCase with underscores (e.g., `Account_Number__c`)
- Standard field names use PascalCase without suffix (e.g., `AccountNumber`)

The current `match_sf_field()` returns the SF `fieldName` from the JSON (which is already in correct SF format), so this is handled for matched fields. For unmatched fields, we return empty strings so no naming issue.

### Files Modified
- `scripts/generate_field_usage.py`: Lines ~2953-3003

---

## Task 2: Add "Picklist Values" to Markdown Reports

### Changes

#### 2.1 Modify `parse_field_definitions()` to extract picklist values

**Location**: Lines 111-146 of `generate_field_usage.py`

Parse the `<optionset>/<options>/<option>` elements within each attribute:

```python
# Inside parse_field_definitions(), after line 135
picklist_values = []
optionset = attr.find('optionset')
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
```

Add `'picklist_values': picklist_values` to the field dict.

#### 2.2 Add "Picklist Values" column to Field Definitions table

**Location**: Lines 2042-2081 of `generate_field_usage.py`

- Add `Picklist Values` column after `Required` in the table header
- Format cell as: `1: A, 276530000: B, 276530001: C, ...` (value: label pairs, comma-separated)

### Files Modified
- `scripts/generate_field_usage.py`: `parse_field_definitions()` + `generate_markdown()` Field Definitions section

---

## Task 3: Add `picklistValues` to Enriched Entity JSON

### Changes

#### 3.1 Pass picklist values through to enriched JSON

**Location**: `enrich_entity_json.py`, lines 496-522

The `parse_field_definitions()` function (shared from `generate_field_usage.py`) will now return `picklist_values` in each field dict. Add it to the enriched output:

```python
field_out = {
    'fieldName': fdef['schema_name'],
    ...
    'picklistValues': fdef.get('picklist_values') or None,
}
```

Output format per the user's example:
```json
"picklistValues": [
  {"label": "A", "value": "1"},
  {"label": "B", "value": "276530000"}
]
```

Fields without picklist values will have `"picklistValues": null`.

### Files Modified
- `scripts/enrich_entity_json.py`: `enrich_entity()` function

---

## Testing Strategy

Test one entity at a time before running `--all`:

1. **Task 1 test**: Run `generate_field_usage.py account`, then inspect `mapping/account.csv`:
   - Verify unused fields (e.g., `accessrightsmask` if it has no usage) have empty sfSuggested* columns
   - Verify fields with sfObjectName but empty sfFieldDisplayName+sfFieldApiName have sfObjectName cleared (e.g., `address1_addresstypecode`)
   - Verify fields with usage that lack confirmed mapping get suggestions only when a match is found

2. **Task 2 test**: Inspect `reports/account_field_usage.md` Field Definitions table:
   - Verify `accountclassificationcode` row has "Picklist Values" showing `1: A, 276530000: B, ...`
   - Verify non-picklist fields have empty Picklist Values cell

3. **Task 3 test**: Run `enrich_entity_json.py account`, then inspect `d365-entities/account.json`:
   - Verify `accountclassificationcode` has `picklistValues` array with 11 entries
   - Verify non-picklist fields have `picklistValues: null`

4. **Full run**: Run both scripts with `--all` after single-entity tests pass.

---

## Execution Order

1. Task 2.1 first (modify `parse_field_definitions()`) — both scripts depend on this
2. Task 1 (fix SF mapping logic) — affects CSV and report output
3. Task 2.2 (add column to report) — uses picklist data from 2.1
4. Task 3 (add to JSON) — uses picklist data from 2.1
5. Test with single entity (`account`)
6. Run `--all` for both scripts
