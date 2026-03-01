# Aztec D365CE Solution Reports

Field usage analysis and cross-platform mapping tooling for a 20+ year Dynamics 365 Customer Engagement (D365CE) solution extract. Generates comprehensive Markdown reports documenting every field on each entity that is actively used across forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, controls, and ribbon customizations — with Salesforce field mapping suggestions.

This analysis feeds a data migration plan for re-platforming from D365CE to Salesforce.

## Project Structure

```
.
├── scripts/
│   ├── generate_field_usage.py    # Field usage reports + mapping CSVs
│   ├── enrich_entity_json.py      # Enriched D365 entity JSON builder
│   ├── refresh_sf_entities.py     # Salesforce schema refresh via REST API
│   └── extract_mapping_csv.py     # Extract mapping CSV from enriched JSON
├── reports/                       # Generated Markdown reports (94 entities)
├── mapping/                       # Field mapping CSVs with SF columns (93 entities)
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

### generate_field_usage.py

Parses the D365CE solution extract and generates a comprehensive Markdown report per entity with 14 sections covering all field usage. Also updates mapping CSVs with Salesforce field suggestions sourced from `salesforce-entities/` JSON schemas.

```bash
python scripts/generate_field_usage.py account              # single entity
python scripts/generate_field_usage.py --all                 # all 94 entities
python scripts/generate_field_usage.py account --output-dir ./out
```

**Outputs:** `reports/{entity}_field_usage.md`, `mapping/{entity}.csv`

### enrich_entity_json.py

Builds enriched per-field JSON with 13 section datasets (forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, PCF controls, relationships, ribbon, conflicts) and merges SF mapping data from CSVs.

```bash
python scripts/enrich_entity_json.py account                # single entity
python scripts/enrich_entity_json.py --all                   # all entities
```

**Outputs:** `d365-entities/{entity}.json`

### refresh_sf_entities.py

Refreshes Salesforce object schema JSON from the org via REST API (SObject Describe). Reads credentials from `.mcp.json`. Preserves existing d365 cross-reference fields when updating.

```bash
python scripts/refresh_sf_entities.py Account               # single SF object
python scripts/refresh_sf_entities.py --all                  # all existing objects
```

**Outputs:** `salesforce-entities/{object}.json`

**Prerequisites:** Salesforce Connected App must have `Manage user data via APIs (api)` OAuth scope configured. Credentials are read from `.mcp.json` (`salesforce` server → `SALESFORCE_CLIENT_ID`, `SALESFORCE_CLIENT_SECRET`, `SALESFORCE_INSTANCE_URL`).

### extract_mapping_csv.py

Extracts mapping CSV from enriched entity JSON files.

```bash
python scripts/extract_mapping_csv.py account               # single entity
python scripts/extract_mapping_csv.py --all                  # all entities
```

**Outputs:** `mapping/{entity}.csv`

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
| `/generate-report [entity]` | Generate field usage report(s) and update mapping CSV(s) |
| `/enrich-d365-entity [entity]` | Generate enriched D365 entity JSON(s) |
| `/refresh-sf-entity [entity]` | Refresh Salesforce object schema(s) from org |

All commands default to `--all` when no entity argument is provided.

## Requirements

- Python 3.6+ (stdlib only, no external dependencies)
- Network access to Salesforce org (for `refresh_sf_entities.py` only)
