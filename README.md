# Aztec D365CE Solution Reports

Field usage analysis and cross-platform mapping tooling for a 20+ year Dynamics 365 Customer Engagement (D365CE) solution extract. Generates comprehensive Markdown reports documenting every field on each entity that is actively used across forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, controls, and ribbon customizations — with Salesforce field mapping suggestions.

This analysis feeds a data migration plan for re-platforming from D365CE to Salesforce.

## Project Structure

```
.
├── scripts/
│   ├── generate_sf_entity_json_from_api.py                       # Step 1: Salesforce schema refresh via REST API
│   ├── generate_d365_entity_json_from_solution.py                # Step 2: Enriched D365 entity JSON builder
│   ├── enrich_d365_entity_json_from_api.py                       # Step 3: Enrich stub fields from Dataverse API
│   ├── compute_d365_reference_counts.py                          # Step 4: Pre-compute reference counts
│   ├── refresh_d365_field_lastupdates_tds.py                     # Step 5: Refresh lastUpdate via Dataverse TDS
│   ├── evaluate_d365_migration_eligibility.py                     # Step 6: Evaluate migration eligibility per field
│   ├── generate_d365_sf_suggestions.py                            # Step 7: Generate SF field suggestions
│   ├── generate_d365_entity_csv_mapping.py                       # Step 8: Extract mapping CSV from enriched JSON
│   ├── generate_d365_report_from_json_and_csv.py                 # Step 9: Field usage Markdown reports
│   └── pipeline_shared.py                                        # Shared utility functions (steps 6, 7 & 9)
├── reports/                       # Generated Markdown reports (94 entities)
├── mapping/                       # Field mapping CSVs with SF columns (94 entities)
├── d365-entities/                 # Enriched D365 entity JSON (94 entities)
├── salesforce-entities/           # Salesforce object describe JSON (50 objects)
├── SolutionExtract/               # D365CE solution extract
│   ├── customizations.xml         # Entity defs, forms, views, charts, dashboards, ribbons
│   ├── Reports/                   # RDL report files (13)
│   ├── Workflows/                 # Workflow XAML files (113)
│   ├── WebResources/              # JavaScript web resources (107)
│   ├── Formulas/                  # Rollup/calculated field XAML files (42)
│   └── Controls/                  # PCF control manifests
├── plugins/                       # Plugin C# source code (87 files)
├── plans/                         # Architecture and implementation plans
├── .claude/commands/              # Claude Code slash commands
└── CLAUDE.md                      # AI assistant instructions
```

## Scripts

Pipeline scripts run in order: Step 1 → 2 → 3 → 4 → 5 → 6 → 7 → 8 → 9.

### Step 1: generate_sf_entity_json_from_api.py

Refreshes Salesforce object schema JSON from the org via REST API (SObject Describe). No dependencies on other scripts.

```bash
python scripts/generate_sf_entity_json_from_api.py Account   # single SF object
python scripts/generate_sf_entity_json_from_api.py --all     # all existing objects
```

**Outputs:** `salesforce-entities/{object}.json`

**Prerequisites:** Salesforce Connected App must have `Manage user data via APIs (api)` OAuth scope configured. Credentials are read from `.mcp.json` (`salesforce` server → `SALESFORCE_CLIENT_ID`, `SALESFORCE_CLIENT_SECRET`, `SALESFORCE_INSTANCE_URL`).

### Step 2: generate_d365_entity_json_from_solution.py

Builds enriched per-entity JSON with 13 section datasets (forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, PCF controls, relationships, ribbon, conflicts).

```bash
python scripts/generate_d365_entity_json_from_solution.py account   # single entity
python scripts/generate_d365_entity_json_from_solution.py --all     # all entities
```

**Outputs:** `d365-entities/{entity}.json`

### Step 3: enrich_d365_entity_json_from_api.py

Queries the Dataverse Web API to enrich stub fields (those with empty dataType) with metadata: dataType, displayName, description, requiredLevel, maxLength, isCustom. Fields already populated by Step 2 are left untouched.

```bash
python scripts/enrich_d365_entity_json_from_api.py account         # single entity
python scripts/enrich_d365_entity_json_from_api.py --all            # all entities
python scripts/enrich_d365_entity_json_from_api.py account --dry-run
```

**Outputs:** `d365-entities/{entity}.json` (enriched in-place)

**Prerequisites:** `msal` (pip install) and `scripts/config.local.json` with Dataverse credentials.

### Step 4: compute_d365_reference_counts.py

Pre-computes reference counts at entity level and field level from per-field section arrays. Downstream steps (8, 9) read these counts instead of recomputing them.

```bash
python scripts/compute_d365_reference_counts.py account   # single entity
python scripts/compute_d365_reference_counts.py --all     # all entities
```

**Outputs:** `d365-entities/{entity}.json` (with count properties at entity and field level)

### Step 5: refresh_d365_field_lastupdates_tds.py

Refreshes entity-level and field-level lastUpdate values by querying the D365 Dataverse TDS endpoint.

```bash
python scripts/refresh_d365_field_lastupdates_tds.py account   # single entity
python scripts/refresh_d365_field_lastupdates_tds.py --all     # all entities
```

**Outputs:** `d365-entities/{entity}.json` (with lastUpdate values)

**Prerequisites:** `pyodbc`, `msal`, ODBC Driver 18 for SQL Server, and `scripts/config.local.json` with Dataverse credentials.

### Step 6: evaluate_d365_migration_eligibility.py

Single source of truth for migration eligibility. Sets `sfSuggestedMapping` (true/false) per field based on staleness + usage + required level. Clears all `sfSuggested*` fields when false.

```bash
python scripts/evaluate_d365_migration_eligibility.py account       # single entity
python scripts/evaluate_d365_migration_eligibility.py --all         # all entities
python scripts/evaluate_d365_migration_eligibility.py --all --reset # clear all sfSuggested* first
```

**Outputs:** `d365-entities/{entity}.json` (with sfSuggestedMapping)

### Step 7: generate_d365_sf_suggestions.py

5-tier SF field matching (exact, fuzzy, synonym, rule-based, AI). Only processes fields with `sfSuggestedMapping=true`. Writes suggestions to `d365-entities/*.json` (source of truth). CSV generation is handled by Step 8.

```bash
python scripts/generate_d365_sf_suggestions.py account   # single entity
python scripts/generate_d365_sf_suggestions.py --all     # all entities
```

**Outputs:** `d365-entities/{entity}.json` (with sfSuggested* fields)

### Step 8: generate_d365_entity_csv_mapping.py

Extracts mapping CSV from enriched entity JSON. Preserves confirmed SF columns, reads sfSuggested*, sfSuggestedMapping, and count properties from JSON.

```bash
python scripts/generate_d365_entity_csv_mapping.py account   # single entity
python scripts/generate_d365_entity_csv_mapping.py --all     # all entities
```

**Outputs:** `mapping/{entity}.csv`

### Step 9: generate_d365_report_from_json_and_csv.py

Generates comprehensive Markdown field usage reports with 14 sections. Reads pre-computed count properties from JSON for field heatmap. Displays entity-level counts in report header.

```bash
python scripts/generate_d365_report_from_json_and_csv.py account          # single entity
python scripts/generate_d365_report_from_json_and_csv.py --all            # all 94 entities
python scripts/generate_d365_report_from_json_and_csv.py account --output-dir ./out
```

**Outputs:** `reports/{entity}.md`

## Report Sections

Each generated report contains 14 sections plus an alphabetical field index:

| # | Section | Description |
|---|---------|-------------|
| 1 | Field Definitions | All fields with schema name, type, custom flag, required level, and 6 SF mapping columns |
| 2 | Forms | Per-form tab/section/field layout, subgrids, events, JS libraries |
| 3 | Views | Display columns, filter conditions, sort order |
| 4 | Chart Visualizations | Measure fields, group-by fields, filters |
| 5 | Reports | RDL report FetchXML: selected fields, filters, linked entities |
| 6 | Dashboards | Dashboard controls with referenced views and charts |
| 7 | Workflows | Fields read/written, custom actions, trigger metadata |
| 8 | JavaScript Web Resources | Per-function field usage with operation type |
| 9 | Formulas & Rollups | Source fields, aggregation type, formula classification |
| 10 | Plugin Source Code Analysis | C# static analysis: fields read/written/filtered, entity images |
| 11 | PCF Controls | Bound and input properties |
| 12 | Relationships | 1:N, N:1, N:N with lookup fields |
| 13 | Ribbon Customizations | Custom buttons, command definitions, JS references |
| 14 | Conflicts & Observations | Cross-form inconsistencies, fields in code but not on forms |

### SF Mapping Columns (Section 1)

The Field Definitions table includes 6 Salesforce mapping columns:

- **Mapping Object** / **Mapping Field** / **Mapping API** — Human-confirmed Salesforce equivalents
- **Suggested Object** / **Suggested Field** / **Suggested API** — AI-suggested matches from `salesforce-entities/` schemas

## Claude Code Slash Commands

| Command | Purpose |
|---|---|
| `/generate-d365-json [entity]` | Step 1: Generate enriched D365 entity JSON(s) |
| `/enrich-d365-json [entity]` | Step 2: Enrich stub fields with Dataverse API metadata |
| `/generate-d365-csv [entity]` | Step 3: Extract mapping CSV(s) from enriched JSON |
| `/generate-sf-json [object]` | Step 4: Refresh Salesforce object schema(s) from org |
| `/generate-d365-sf-suggestions [entity]` | Step 7: Generate SF field suggestions |
| `/generate-d365-report [entity]` | Step 6: Generate field usage Markdown report(s) |
| `/generate-all [entity]` | Run full pipeline (Steps 1 → 2 → 3 → 4 → 5 → 6) |

All commands default to `--all` when no argument is provided.

## Requirements

- Python 3.6+ (stdlib only for steps 1, 3-6; no external dependencies)
- `msal` (pip install) for Step 2 (`enrich_d365_entity_json_from_api.py`) and the standalone `refresh_d365_field_lastupdates_tds.py`
- Network access to Salesforce org (for `generate_sf_entity_json_from_api.py` only)
