# Aztec D365CE Solution Reports

Field usage analysis and cross-platform mapping tooling for a 20+ year Dynamics 365 Customer Engagement (D365CE) solution extract. Generates comprehensive Markdown reports documenting every field on each entity that is actively used across forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, controls, and ribbon customizations — with Salesforce field mapping suggestions.

This analysis feeds a data migration plan for re-platforming from D365CE to Salesforce.

## Project Structure

```
.
├── scripts/
│   ├── enrich_entity_json.py      # Step 1: Enriched D365 entity JSON builder
│   ├── extract_mapping_csv.py     # Step 2: Extract mapping CSV from enriched JSON
│   ├── refresh_sf_entities.py     # Step 3: Salesforce schema refresh via REST API
│   ├── update_mapping_csv.py      # Step 4a: Update CSVs with SF suggestions
│   └── generate_report.py         # Step 4b: Field usage Markdown reports
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

Pipeline scripts run in order: Step 1 → Step 2 → Step 3 → Step 4a → Step 4b.

### Step 1: enrich_entity_json.py

Builds enriched per-entity JSON with 13 section datasets (forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, PCF controls, relationships, ribbon, conflicts).

```bash
python scripts/enrich_entity_json.py account                # single entity
python scripts/enrich_entity_json.py --all                   # all entities
```

**Outputs:** `d365-entities/{entity}.json`

### Step 2: extract_mapping_csv.py

Extracts mapping CSV from enriched entity JSON. Preserves confirmed SF columns, clears suggested columns.

```bash
python scripts/extract_mapping_csv.py account               # single entity
python scripts/extract_mapping_csv.py --all                  # all entities
```

**Outputs:** `mapping/{entity}.csv`

### Step 3: refresh_sf_entities.py

Refreshes Salesforce object schema JSON from the org via REST API (SObject Describe). Preserves existing d365 cross-reference fields when updating.

```bash
python scripts/refresh_sf_entities.py Account               # single SF object
python scripts/refresh_sf_entities.py --all                  # all existing objects
```

**Outputs:** `salesforce-entities/{object}.json`

**Prerequisites:** Salesforce Connected App must have `Manage user data via APIs (api)` OAuth scope configured. Credentials are read from `.mcp.json` (`salesforce` server → `SALESFORCE_CLIENT_ID`, `SALESFORCE_CLIENT_SECRET`, `SALESFORCE_INSTANCE_URL`).

### Step 4a: update_mapping_csv.py

Updates mapping CSVs with SF suggestions and per-field reference counts sourced from `salesforce-entities/` JSON schemas.

```bash
python scripts/update_mapping_csv.py account                # single entity
python scripts/update_mapping_csv.py --all                   # all entities
```

**Outputs:** `mapping/{entity}.csv` (with SF suggestion columns populated)

### Step 4b: generate_report.py

Generates comprehensive Markdown field usage reports with 14 sections. Reads mapping CSVs for SF column display (read-only).

```bash
python scripts/generate_report.py account                   # single entity
python scripts/generate_report.py --all                      # all 94 entities
python scripts/generate_report.py account --output-dir ./out
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
| `/enrich-d365-entity [entity]` | Step 1: Generate enriched D365 entity JSON(s) |
| `/refresh-sf-entity [object]` | Step 3: Refresh Salesforce object schema(s) from org |
| `/update-mapping-csv [entity]` | Step 4a: Update mapping CSV(s) with SF suggestions |
| `/generate-report [entity]` | Step 4b: Generate field usage Markdown report(s) |
| `/generate-all [entity]` | Run full pipeline (Steps 1 → 2 → 3 → 4a → 4b) |

All commands default to `--all` when no argument is provided.

## Requirements

- Python 3.6+ (stdlib only, no external dependencies)
- Network access to Salesforce org (for `refresh_sf_entities.py` only)
