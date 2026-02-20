# Plan: D365CE Entity Field Usage Analysis

## Context

We need to analyze a 20+ year D365CE solution extract to determine every field on target entities that is actively used across forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, controls, and ribbon customizations. This feeds a data migration plan for re-platforming to Salesforce.

**Output:** One comprehensive Markdown file per entity, each with a Table of Contents, per-area sections, cross-linked field references, and a book-style alphabetical index.

**Decisions:**
- Plugin source code: Full C# static analysis of 92 plugin files at `plugins/` — extract field references, entity targets, pipeline stage, and operation type
- Field definitions: Include ALL defined fields (helps identify dead/legacy fields)
- Inactive forms: Include with full detail (client may reactivate or reference)
- Related views: Only target entity views (not views on other entities)

---

## Approach

**Single Python script** (`generate_field_usage.py`) using only stdlib (`xml.etree.ElementTree`, `html`, `re`, `os`, `glob`, `collections`, `argparse`). Parses all solution artifacts, collects field references per area, and emits Markdown files.

The script is parameterized by entity name and accepts an optional `--output-dir` parameter:

```
python generate_field_usage.py <entity> [--output-dir <path>]
```

- `<entity>` — required positional argument: target entity schema name
- `--output-dir` — optional: directory for generated `.md` files (defaults to current directory)

---

## Implementation Steps

### Step 1: Parse `customizations.xml` — Field Definitions

Parse `<Entity>` blocks for the target entity. For each:

- **Field definitions** from `<attributes>` → `<attribute>`:
  - Schema name: `<Name>` element text
  - Data type: `<Type>` element text
  - Display name: `<displaynames>` → `<displayname description="...">`
  - Required level: `<RequiredLevel>`
  - Custom flag: `<IsCustomField>`
  - Introduced version: `<IntroducedVersion>`

### Step 2: Parse Forms

From `<FormXml>` → `<forms type="...">` → `<systemform>`:

- Form metadata: `<formid>`, `<FormPresentation>` (0=Quick Create, 1=Main), `<FormActivationState>`, localized name from `<LocalizedNames>`
- Parse inner `<form>` XML — traverse: `<tabs>` → `<tab>` → `<columns>` → `<column>` → `<sections>` → `<section>` → `<rows>` → `<row>` → `<cell>` → `<control>`
- For each `<control>`: `id` attribute = field schema name; `classid` identifies control type
- Detect subgrids (classid `{E7A81278-...}`): extract `TargetEntityType`, `RelationshipName` from `<parameters>`
- Detect web resources (classid `{9FDF5F91-...}`)
- Track: visibility (cell `visible` attr), disabled state (control `disabled` attr), labels
- Parse `<header>` and `<footer>` for fields there
- Parse `<events>` → `<Handler>` for JS library references and function names
- Include **all** forms — active and inactive — with full tab/section/field detail

### Step 3: Parse Views (SavedQueries)

From `<savedqueries>` → `<savedquery>`:

- Name from `<LocalizedNames>` → `<LocalizedName description="...">`
- Query type from `<querytype>` (0=Standard, 1=Advanced Find, 2=Associated, 4=Quick Find, 16=SubGrid, 32=Multi-Entity Quick Find, 64=Lookup, 128=Custom, 256=Quick Find v2, 4096=Kanban). Unknown types render as `Unknown ({n})`.
- Fields from `<fetchxml>` → `<attribute name="...">` and `<filter>` → `<condition attribute="...">` and `<order attribute="...">`
- Layout columns from `<layoutxml>` → `<grid>` → `<row>` → `<cell name="..." width="...">`

### Step 4: Parse Workflow XAML Files

For each `.xaml` in `Workflows/`:

1. Parse with ElementTree (handle XAML namespaces)
2. Extract workflow name from `x:Class` or `<Activity>` attributes
3. Identify primary entity (scan for entity name references)
4. Scan for field references using multiple strategies:
   - Element attributes containing field schema names
   - Text content with field name patterns
   - Regex fallback for known field prefixes and standard field names
5. Classify operations: read, write, condition check
6. Detect custom action/plugin calls
7. **Only include** workflows that reference the target entity (by entity name or field pattern)
8. **ProcessTrigger enrichment:** When `customizations.xml` root is provided, build a lookup from workflow `<XamlFileName>` to `<ProcessTriggerScope>` (1=Form, 2=Entity), `<ProcessTriggerFormId>`, and `<PrimaryEntity>`. Append this metadata to each matching workflow entry as trigger scope, form association, and primary entity.

### Step 4b: Parse Chart Visualizations (SavedQueryVisualizations)

From `<savedqueryvisualizations>` → `<savedqueryvisualization>`:

1. Extract chart name from `<LocalizedNames>` → `<LocalizedName description="...">`
2. Parse `<datadescription>` — embedded FetchXML containing:
   - `<attribute name="...">` — measure/group-by fields
   - `<condition attribute="...">` — filter fields
   - `<order attribute="...">` — sort fields
3. Parse `<presentationdescription>` — chart layout XML containing:
   - `<measurecollection>` → `<measure attribute="...">` — charted measure fields
   - Category/series bindings referencing field names
4. Only include charts for the target entity (match via `<primaryentitytypecode>` or FetchXML entity name)

### Step 4c: Parse Reports (RDL Files)

For each file in `Reports/`:

1. Read with `read_file()` (encoding cascade)
2. Extract report name from filename (strip `rdl` + GUID suffix via regex)
3. Parse XML with namespace handling (RDL 2016 schema)
4. For each `<DataSet>`:
   - Decode `<CommandText>` HTML entities (`html.unescape()`) — the FetchXML is HTML-encoded
   - Parse the decoded FetchXML string
   - Extract primary entity name from `<entity name="...">`
   - Extract `<attribute name="...">` — select fields
   - Extract `<condition attribute="...">` within `<filter>` — filter fields
   - Extract `<order attribute="...">` — sort fields
   - Extract `<link-entity>` recursively (up to 5 levels) — linked entity fields with alias, from/to fields, link type
   - Extract `<Field>` definitions from `<Fields>` section for field-to-alias mapping
   - Extract `<QueryParameter>` names
5. Filter: only include reports where the target entity appears as primary entity or in a `<link-entity>`
6. Data provider is `MSCRMFETCH` — all CommandText content is FetchXML

### Step 4d: Parse Dashboards

From `<Dashboards>` → `<Dashboard>` in `customizations.xml`:

1. Extract name from `<LocalizedNames>` → `<LocalizedName description="...">`
2. Extract `<FormId>` — unique GUID
3. Parse `<FormXml>` — traverse tab/section/row/cell/control hierarchy (same structure as entity forms)
4. For each control, extract parameters: `TargetEntityType`, `ViewId`, `VisualizationId`, `ChartGridMode`, `RelationshipName`
5. Filter: only include dashboards that reference the target entity in at least one `<TargetEntityType>`
6. No direct field-level references — dashboards reference views and charts (which are parsed separately). The value is documenting which views/charts are used on dashboards.

### Step 5: Parse JavaScript Web Resources

For each file in `WebResources/`:

1. Read content (JavaScript source)
2. Extract field references via regex — covering all D365CE client API patterns:
   - **Form attribute access:** `getAttribute(["']fieldname["'])` → read, `getControl(["']fieldname["'])` → UI access
   - **Value operations:** `setValue` / `getValue` patterns → write/read
   - **Xrm.WebApi calls:** `retrieveRecord`, `updateRecord`, `createRecord`, `deleteRecord` — extract entity name and `$select` field lists from option strings
   - **OData URL strings:** `$select=f1,f2`, `$filter=field eq ...`, `$orderby=field`, `$expand=...($select=f1,f2)` — extract field names from inline URL construction
   - **Event handler registration:** `addOnChange("field", ...)`, `removeOnChange`, `fireOnChange` — extract target field names
   - **Lookup manipulation:** `addPreSearch`, `addCustomFilter` — parse any embedded FetchXML strings for `<condition attribute="...">` references
   - **Form context patterns:** `formContext.data.entity.attributes.get("field")`, `Xrm.Utility.openEntityForm` parameter objects with field defaults
   - **Embedded FetchXML in JS:** regex scan for `<attribute name=`, `<condition attribute=`, `<order attribute=` within string literals
   - **String literals:** matching custom field prefixes (`ezt_`, `new_`, etc.) and known standard field names
3. Extract function names: `function\s+(\w+)`
4. Map each function to the fields it touches
5. Map JS file to entity by name pattern

### Step 6: Parse Formula XAML Files

For each `.xaml` in `Formulas/`:

1. **Primary method — XAML content parsing:** Parse the XAML XML structure and scan all elements and attributes for field schema names. Field references appear in various XAML elements as attribute values and text content (e.g., source fields in rollup aggregations, operands in calculated field expressions).
2. **Fallback — filename extraction:** Extract entity and field from filename pattern `{entity}-{fieldname}.xaml` when XAML parsing yields no results or the file is malformed.
3. Classify as rollup or calculated field based on XAML content structure.
4. Document: target field, formula type, all source fields referenced, aggregation type (for rollups).

### Step 7: Analyze Plugin C# Source Code

Full static analysis of all 92 C# plugin files at `plugins/`. This replaces the previous assembly-inventory approach since complete source code is available.

#### 7a. Build Property → Schema Name Lookup

Parse `plugins/AztecEntities.cs` (CrmContext-generated entity proxy classes) to build a mapping of typed property names to schema names:

- Scan for `[AttributeLogicalNameAttribute("schema_name")]` decorators
- Map the decorated property name (e.g., `IncidentId`) to the schema name (e.g., `incidentid`)
- Also extract `[EntityLogicalNameAttribute("entity")]` to associate properties with entities
- This lookup table is used to resolve typed property access throughout all plugins

#### 7b. Extract Field References — Pattern Categories

For each `.cs` file in `plugins/`, apply the following regex/parse patterns:

1. **Direct attribute access:**
   - `entity.Attributes["field"]` — read/write depending on context
   - `entity["field"]` — indexer shorthand, read/write
   - `.Contains("field")` — field presence check (read)
   - `.GetAttributeValue<T>("field")` — typed read
   - `.SetAttributeValue("field", ...)` — write

2. **Typed property access (via lookup table from 7a):**
   - CrmContext-generated properties (e.g., `incident.IncidentId`, `account.Name`)
   - Resolve property name → schema name using the lookup table
   - Object initializer syntax: `new ezt_softwarelicense() { ezt_AccountId = ref, ... }` — extract property names from initializer block and map through lookup

3. **FetchXML embedded in C# strings:**
   - `<attribute name='field'/>` or `<attribute name="field"/>`
   - `<condition attribute='field' .../>` — filter
   - `<order attribute='field' .../>` — sort
   - `<link-entity ... from='field' to='field'>` — join fields

4. **QueryExpression patterns:**
   - `new ConditionExpression("field", ...)` — filter
   - `new ColumnSet("f1", "f2", ...)` — read (select)
   - `ColumnSet(true)` — all columns (flag as "selects all fields")
   - `.LinkFromAttributeName = "field"` — join
   - `.LinkToAttributeName = "field"` — join
   - `query.Criteria.AddCondition("field", ...)` — filter
   - `new OrderExpression("field", ...)` — sort

5. **QueryByAttribute patterns:**
   - `.Attributes.Add("field")` — filter attribute
   - `.Attributes.AddRange("f1", "f2")` — filter attributes
   - `.Values.Add(...)` — correlates positionally with Attributes

6. **Pre/Post Entity Images:**
   - `context.PreEntityImages["image_name"]` — access to pre-image entity
   - `context.PostEntityImages["image_name"]` — access to post-image entity
   - Track subsequent field access on the retrieved image entity

7. **AliasedValue access:**
   - `GetAttributeValue<AliasedValue>("alias.field")` — cross-entity field read via linked entity alias

8. **Entity identification patterns:**
   - `.LogicalName == "entity_name"` — entity type check
   - `const string EntityLogicalName = "entity"` — static entity name declaration
   - `context.MessageName == "Create"` / `"Update"` / `"Delete"` — message type (determines operation context)
   - `context.PrimaryEntityName` — target entity of the plugin step

#### 7c. Classify Each Reference

For each extracted field reference, classify:
- **Operation:** Read, Write, Filter, Sort, Join
- **Entity context:** Primary entity (the plugin's target) vs cross-entity (via LinkEntity, FetchXML join, or separate Retrieve)
- **Pipeline stage:** Pre-Validation, Pre-Operation, Post-Operation (from plugin class attributes or registration metadata)
- **Message type:** Create, Update, Delete, Retrieve, RetrieveMultiple, Custom Action

#### 7d. Output Structure

Per-plugin subsections in the Markdown output:

```
### 7.x {PluginClassName}
- **Target entity:** {entity}
- **Message:** {Create/Update/Delete/...}
- **Pipeline stage:** {Pre/Post}
- **Fields read:** field1, field2, ...
- **Fields written:** field3, field4, ...
- **Fields filtered:** field5, ...
- **Pre/Post images:** {image fields accessed}
- **Cross-entity references:** {entity.field via join/lookup}
```

### Step 8: Parse PCF Controls

1. Read `ControlManifest.xml` from `Controls/` subdirectories
2. Extract bound property names (these map to entity fields)

### Step 9: Parse Relationships

From `<EntityRelationships>` in the entity block:
- 1:N, N:1, N:N relationships
- Extract: relationship name, related entity, lookup field, type

### Step 10: Parse Ribbon Customizations

From `<RibbonDiffXml>` in the entity block:
- Custom buttons with JavaScript references
- Command definitions with actions

### Step 11: Generate Markdown

For each entity, emit a `.md` file with this structure:

```
# {Entity} Field Usage Analysis
> Generated from D365CE Solution: {solution_name}
> Date: {date}

## Table of Contents
(linked to all sections and subsections)

## 1. Field Definitions
(ALL fields — table with Schema Name, Display Name, Type, Custom, Required)

## 2. Forms
### 2.1 {Form Name} ({Type}) — {Active/Inactive}
Per tab → per section → field table with links to index
Subgrids table, embedded web resources, form events/libraries

## 3. Views
### 3.1 {View Name}
Display columns, filter conditions, sort order — all with field links

## 4. Chart Visualizations
### 4.1 {Chart Name}
Measure fields, group-by fields, filter conditions, sort order

## 5. Reports
### 5.x {Report Name}
- DataSets count
- Per dataset: primary entity, linked entities, selected fields, filter conditions, sort order, parameters
- Report field mappings (alias to data field)

## 6. Dashboards
### 6.x {Dashboard Name}
| Control | Entity | Mode | View ID | Chart ID |

## 7. Workflows
### 7.1 {Workflow Name}
Type, primary entity, trigger scope, trigger form ID, fields read/written/conditioned, custom actions called
Cross-entity references where applicable

## 8. JavaScript Web Resources
### 8.1 {Library Name}
Per-function field usage tables with operation type

## 9. Formulas & Rollups
Per formula: source entity, source fields, aggregation type

## 10. Plugin Source Code Analysis
Per-plugin: target entity, message, pipeline stage, fields read/written/filtered, pre/post images, cross-entity references

## 11. PCF Controls
Bound fields per control

## 12. Relationships
Relationship table with type, related entity, lookup field

## 13. Ribbon Customizations
Custom buttons/actions with JS references

## 14. Conflicts & Observations

### 14.1 Per-Form Conflicts
Fields with inconsistent required levels across forms, fields with conflicting visibility settings,
fields with conflicting event handlers across forms

### 14.2 Global Observations
- **Fields in code but not on forms:** fields referenced in plugins, workflows, JS, or reports but absent from all forms
- **Fields on forms but never in logic:** fields present on forms but never referenced in plugins, workflows, JS, views, formulas, or reports
- **Cross-form inconsistencies:** same field with different required levels, visibility, or control types across forms

---

## Index
Alphabetical by field schema name, each with sub-entries listing
every section where referenced (with markdown links back)
```

**Cross-linking strategy:**
- Field names in tables: `[fieldname](#index-fieldname)`
- Index entries: `<a id="index-fieldname"></a>` with back-links to sections
- **Section anchors:** Every `##` and `###` heading that is a link target gets an explicit `<a id="slug"></a>` tag immediately before the heading. This is necessary because different Markdown renderers (GitHub, VS Code, GitLab) generate different auto-anchor slugs from heading text, making renderer-dependent slugs unreliable. The `slugify()` function in the script computes the canonical slug, and the same slug is used in both the TOC link and the `<a id>` tag.
- Slugs are generated by `slugify()` which lowercases, strips non-word characters, and **collapses consecutive hyphens** — so `Formulas & Rollups` becomes `formulas-rollups`, not `formulas--rollups`.

### Step 12: Verification

After generation:
1. Count unique fields per entity
2. Verify index completeness (every referenced field has an index entry)
3. Console summary: field counts, section counts, warnings
4. **Link integrity check:** After writing each `.md` file, the script extracts all `](#slug)` link targets and all `<a id="slug">` anchors from the generated Markdown, then reports any targets that have no matching anchor. Zero orphans expected.

### Step 13: Encoding Handling

All file reads throughout the script use a 3-tier encoding cascade:

1. **`utf-8-sig`** (primary) — handles UTF-8 with or without BOM transparently
2. **`utf-16`** (fallback) — common for some D365CE export artifacts
3. **`latin-1`** (final fallback) — single-byte encoding that never raises a decode error

Implementation: a shared `read_file(path)` helper that tries each encoding in order, catches `UnicodeDecodeError`, and falls through. Logs a warning to stderr for any file that requires non-UTF-8 decoding.

---

## Files

| File | Action | Purpose |
|------|--------|---------|
| `generate_field_usage.py` | **Create** | Python script (parameterized by entity) |
| `{entity}_field_usage.md` | **Generated** | Per-entity field usage document |

## Input Files

| Path | Purpose |
|------|---------|
| `{solution}\customizations.xml` | Entity defs, forms, views, charts, dashboards, process triggers, relationships, ribbons |
| `{solution}\Reports\*` | RDL report files with embedded FetchXML (13 files) |
| `{solution}\Workflows\*.xaml` | Workflow field references |
| `{solution}\WebResources\*` | JavaScript field references |
| `{solution}\Formulas\*.xaml` | Rollup/calculated field definitions |
| `{solution}\Controls\*\ControlManifest.xml` | PCF control bindings |
| `{plugins_dir}/*.cs` | Plugin C# source code (92 files) — full static analysis |

## Verification

1. Run: `python generate_field_usage.py <entity> [--output-dir <path>]`
2. Check `.md` files render correctly in a Markdown viewer
3. Spot-check known fields across multiple sections
4. Verify TOC links, field→index links, and index→section back-links all work
5. **Plugin field references:** Spot-check known plugins (e.g., `CreateSoftwareLicenses`) — verify extracted fields match manual source code review
6. **Chart visualization fields:** Verify chart measure/filter fields appear in the output
7. **Report fields:** Verify `SharedAccountRecords` report appears for account entity with correct FetchXML field extraction, including link-entity fields
8. **Dashboard references:** Verify dashboards referencing opportunity entity show subgrid controls with View IDs and Chart IDs
9. **Workflow trigger metadata:** Verify ProcessTriggerScope and ProcessTriggerFormId appear on applicable workflow entries
10. **Section numbering:** Verify sections 1-14 + Index are correctly numbered (Reports=5, Dashboards=6, Workflows=7, JS=8, Formulas=9, Plugins=10, PCF=11, Relationships=12, Ribbon=13, Conflicts=14)
11. **Zero link orphans:** Verify link integrity check passes (0 orphans) for account, contact, and opportunity
12. **Conflicts & Observations:** Verify report fields are included in the "fields in code but not on forms" cross-reference analysis
