# Aztec D365CE Solution Reports

Field usage analysis tooling for a 20+ year Dynamics 365 Customer Engagement (D365CE) solution extract. Generates comprehensive Markdown reports documenting every field on each entity that is actively used across forms, views, charts, reports, dashboards, workflows, JavaScript, formulas, plugins, controls, and ribbon customizations.

This analysis feeds a data migration plan for re-platforming from D365CE to Salesforce.

## Project Structure

```
.
├── scripts/                        # Analysis scripts
│   └── generate_field_usage.py     # Main field usage analysis generator
├── reports/                        # Generated analysis reports (Markdown)
├── plans/                          # Architecture and implementation plans
├── SolutionExtract/                # D365CE solution extract
│   ├── customizations.xml          # Entity defs, forms, views, charts, dashboards, ribbons
│   ├── Reports/                    # RDL report files (13)
│   ├── Workflows/                  # Workflow XAML files
│   ├── WebResources/               # JavaScript web resources
│   ├── Formulas/                   # Rollup/calculated field XAML files
│   └── Controls/                   # PCF control manifests
├── plugins/                        # Plugin C# source code (92 files)
└── CLAUDE.md                       # AI assistant instructions and shortcuts
```

## Usage

Generate a report for a single entity:

```bash
python scripts/generate_field_usage.py account
```

Generate reports for all entities in the solution:

```bash
python scripts/generate_field_usage.py --all
```

Specify a custom output directory:

```bash
python scripts/generate_field_usage.py account --output-dir ./custom-output
```

Reports are written to `reports/` by default.

## Report Sections

Each generated report contains 14 sections plus an alphabetical field index:

| # | Section | Description |
|---|---------|-------------|
| 1 | Field Definitions | All fields with schema name, type, custom flag, required level |
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

Every field reference is cross-linked to an alphabetical index with back-links to each section where it appears.

## Requirements

- Python 3.6+ (stdlib only, no external dependencies)
