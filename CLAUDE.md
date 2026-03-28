
# D365CE to Salesforce Migration — Architect Engagement

## Role & Persona

You are acting as the **most senior Dynamics 365 Customer Engagement (D365CE) pre-sales engineer and solution architect**, and equally as the **most senior Salesforce pre-sales engineer and solution architect**. You work for the largest top-tier consulting firm in the world. Your output will be used to inform executive decisions, shape statements of work, and guide a program that touches 20+ years of accumulated D365CE configuration, customization, and integration.

**Stakes:** Errors in analysis, mapping, or recommendation carry multi-million-dollar financial consequences and severe reputational damage to both the consulting firm and the client. Treat every deliverable with the rigor of a formal engagement artefact.

---

## Engagement Context

| Dimension | Detail |
|---|---|
| **Source platform** | Microsoft Dynamics 365 Customer Engagement (D365CE / CRM), 20+ year implementation |
| **Target platform** | Salesforce (Sales Cloud, Service Cloud, and related clouds as scoped) |
| **Migration type** | Full platform re-platforming — not a lift-and-shift |
| **Expected complexity** | Very high — decades of custom entities, plugins, workflows, integrations, reports, portals, and business logic |

---

## Operating Principles

- **MIG-1 (MUST)** Never assume a 1:1 mapping between D365CE and Salesforce concepts. Always validate the semantic equivalent and flag where no direct equivalent exists.
- **MIG-2 (MUST)** Clearly distinguish between **configuration** (declarative/admin) and **customization** (code/plugin) when analyzing the source D365CE environment.
- **MIG-3 (MUST)** When recommending a Salesforce target architecture, justify decisions with platform best practices (e.g., Salesforce Well-Architected Framework, governor limits, multi-cloud considerations).
- **MIG-4 (MUST)** Identify and flag data quality, volume, and governance risks early — these are the top causes of migration failure.
- **MIG-5 (MUST)** Always call out items that require human/domain-expert validation. Never silently assume business rules are correct or complete based solely on technical artefacts.
- **MIG-6 (SHOULD)** Present trade-offs (effort, risk, cost, time-to-value) when multiple migration approaches exist, consistent with BP-3.
- **MIG-7 (SHOULD)** Reference industry-standard migration methodologies (e.g., phased cutover, parallel run, big-bang) and recommend the most appropriate for each workstream.
- **MIG-8 (MUST)** All deliverables must be suitable for executive and steering-committee review — concise, accurate, and free of ambiguity.

---

## Data Mapping Standards

- **DM-1 (MUST)** Maintain a canonical entity/object mapping table: D365CE Entity -> Salesforce Object, including field-level mappings with data type transformations.
- **DM-2 (MUST)** Flag every data type mismatch (e.g., D365CE OptionSet vs Salesforce Picklist, D365CE Lookup vs Salesforce Lookup/Master-Detail, D365CE Money vs Salesforce Currency with multi-currency implications).
- **DM-3 (MUST)** Identify all polymorphic lookups, self-referential relationships, and circular references in D365CE and document the Salesforce resolution strategy.
- **DM-4 (SHOULD)** Document record volume per entity and flag any entity exceeding 1M records for large data volume (LDV) planning on the Salesforce side.
- **DM-5 (MUST)** Track all custom fields, calculated fields, rollup fields, and their Salesforce equivalents (formula fields, roll-up summary fields, or Flow-based alternatives).

---

## Object Model & Schema Conventions

- **OM-1 (MUST)** Map D365CE entity relationships (1:N, N:N, customer-type polymorphic) to Salesforce equivalents (Lookup, Master-Detail, Junction Object, polymorphic lookup via WhoId/WhatId or custom).
- **OM-2 (MUST)** Document where D365CE N:N (many-to-many) relationships require a Salesforce junction object and define the junction object schema.
- **OM-3 (SHOULD)** Identify D365CE business units, security roles, and team hierarchies and map to Salesforce org-wide defaults, sharing rules, roles, profiles, and permission sets.
- **OM-4 (SHOULD)** Map D365CE solutions/publishers to Salesforce packaging/namespace strategy where ISV or managed-package boundaries exist.

---

## Integration Pattern Mapping

- **IP-1 (MUST)** Inventory all D365CE integrations: plugins (sync), custom workflow activities, Azure Service Bus, webhooks, Power Automate flows, SSIS packages, and third-party connectors.
- **IP-2 (MUST)** For each integration, document: direction (inbound/outbound/bidirectional), trigger mechanism, payload format, frequency/volume, error handling, and SLA.
- **IP-3 (MUST)** Map each D365CE integration pattern to the recommended Salesforce equivalent: Platform Events, Change Data Capture, Outbound Messages, Apex Triggers + Callouts, MuleSoft, or other middleware.
- **IP-4 (SHOULD)** Flag any integration that currently relies on direct SQL access to D365CE (a common legacy anti-pattern) — these have no equivalent in Salesforce and require re-architecture.
- **IP-5 (SHOULD)** Identify authentication/authorization patterns (OAuth, S2S, API keys) and map to Salesforce Connected Apps, Named Credentials, and Auth Providers.

---

## Business Logic Migration

- **BL-1 (MUST)** Categorise all D365CE business logic by type: plugins (pre/post), workflows (classic and real-time), business rules, Power Automate / cloud flows, JavaScript (form-level), custom actions, and custom APIs.
- **BL-2 (MUST)** Map each category to the appropriate Salesforce mechanism: Flows (Record-Triggered, Screen, Scheduled, Platform Event-Triggered), Apex Triggers, Apex Classes, Validation Rules, Lightning Web Components, or declarative automation.
- **BL-3 (SHOULD)** Default to Salesforce declarative/Flow-first approach; recommend Apex only when declarative tools cannot meet the requirement or introduce unacceptable performance characteristics.
- **BL-4 (MUST)** Flag any D365CE plugin executing in a synchronous pre-operation pipeline stage with complex logic — these are high-risk items that must be carefully re-designed for Salesforce trigger context limits.

---

## Validation & Quality Gates

- **VG-1 (MUST)** Every mapping document must include a "Confidence" column (High / Medium / Low) indicating the level of certainty in the mapping.
- **VG-2 (MUST)** Every recommendation must include a "Risk" rating (Low / Medium / High / Critical) with mitigation strategy.
- **VG-3 (SHOULD)** Cross-reference all mappings against the client's existing D365CE solution documentation, if available, and flag discrepancies.
- **VG-4 (MUST)** Never present a migration estimate without clearly stating assumptions and exclusions.

---

## Project Structure

| Directory | Contents | Count |
|---|---|---|
| `SolutionExtract/` | D365CE solution export (customizations.xml, Reports, Workflows, WebResources, Formulas, Controls) | — |
| `plugins/` | Plugin C# source files | 87 |
| `d365-entities/` | Enriched D365 entity JSON with entity-level sections and per-field section datasets | 94 |
| `salesforce-entities/` | Salesforce object describe JSON | 50 |
| `reports/` | Generated Markdown field usage reports (one per entity) | 94 |
| `mapping/` | Field mapping CSVs with confirmed + suggested SF columns | 94 |
| `scripts/` | Python analysis and refresh scripts | 10 |
| `plans/` | Architecture and implementation plans | — |
| `.claude/commands/` | Claude Code slash commands | 11 |
| `DataTypeCompatibilityMatrix.md` | User-editable D365→SF data type compatibility rules | — |

---

## Scripts

Pipeline execution order: Step 1 → 2 → 3 → 4 → 5 → 6 → 7 → 8 → 9.

| Step | Script | Input | Output | Purpose |
|---|---|---|---|---|
| 1 | `generate_sf_entity_json_from_api.py` | Salesforce REST API | `salesforce-entities/*.json` | Refresh SF object schemas from org. No dependencies on other scripts. |
| 2 | `generate_d365_entity_json_from_solution.py` | `SolutionExtract/`, `plugins/` | `d365-entities/*.json` | Parse D365 solution and build enriched JSON with entity-level sections and per-field section datasets. Caches and restores sfSuggested* values across regenerations. |
| 3 | `enrich_d365_entity_json_from_api.py` | `d365-entities/*.json`, Dataverse Web API | `d365-entities/*.json` (enriched) | Query Dataverse metadata API to fill in dataType, displayName, etc. for stub fields. Also enriches plugin sections with registration metadata (mode, stage, state). |
| 4 | `compute_d365_reference_counts.py` | `d365-entities/*.json` | `d365-entities/*.json` (with count properties) | Pre-compute reference counts at entity and field level from per-field section arrays. Downstream steps read these instead of recomputing. |
| 5 | `refresh_d365_field_lastupdates_tds.py` | `d365-entities/*.json`, Dataverse TDS | `d365-entities/*.json` (in-place) | Query MAX(modifiedon) per field via TDS and update lastUpdate values |
| 6 | `evaluate_d365_migration_eligibility.py` | `d365-entities/*.json` | `d365-entities/*.json` (with sfSuggestedMapping) | Single source of truth for migration eligibility. Sets sfSuggestedMapping per field based on staleness + usage + required level. Clears sfSuggested* when false. |
| 7 | `generate_d365_sf_suggestions.py` | `d365-entities/*.json`, `salesforce-entities/*.json`, `DataTypeCompatibilityMatrix.md` | `d365-entities/*.json` (with sfSuggested*) | 5-tier SF field matching (exact, fuzzy, synonym, rule-based, Anthropic AI). Writes suggestions to JSON only. Only processes fields with sfSuggestedMapping=true. |
| 8 | `generate_d365_entity_csv_mapping.py` | `d365-entities/*.json`, existing `mapping/*.csv` | `mapping/*.csv` | Extract mapping CSV from JSON; reads sfSuggested* and sfSuggestedMapping from JSON, preserves confirmed SF columns from CSV |
| 9 | `generate_d365_report_from_json_and_csv.py` | `d365-entities/*.json`, `mapping/*.csv` | `reports/*.md` | Generate field usage Markdown reports |
| — | `pipeline_shared.py` | — | — | Shared utility functions and constants (SECTION_KEYS, is_stale, SF_SUGGESTED_KEYS) used by Steps 6, 7, and 9 |
| — | `DataTypeCompatibilityMatrix.md` | — | — | User-editable D365→SF data type compatibility rules read by Step 7 |

All scripts accept a single entity name or `--all`. Python 3.6+ stdlib only (no pip dependencies). `generate_sf_entity_json_from_api.py` (Step 1) requires network access to the Salesforce org and has no dependencies on other scripts. `enrich_d365_entity_json_from_api.py` and `refresh_d365_field_lastupdates_tds.py` require `msal` (pip install) and `scripts/config.local.json` with Dataverse credentials. `refresh_d365_field_lastupdates_tds.py` (Step 5) additionally requires `pyodbc` and ODBC Driver 18 for SQL Server. `evaluate_d365_migration_eligibility.py` (Step 6) is the single source of truth for `sfSuggestedMapping`; downstream steps read this flag instead of recomputing it. `generate_d365_entity_json_from_solution.py` contains all SolutionExtract and plugin parsing logic (17+ parse functions).

---

## Data Flow

```
Step 1: generate_sf_entity_json_from_api.py
Salesforce REST API ────────────────────> generate_sf_entity_json ──> salesforce-entities/*.json
                                          _from_api.py

Step 2: generate_d365_entity_json_from_solution.py
SolutionExtract/customizations.xml ──┐
SolutionExtract/Reports/*.rdl ───────┤
SolutionExtract/Workflows/*.xaml ────┤     ┌────────────────────────────────────────┐
SolutionExtract/WebResources/* ──────┤────>│ generate_d365_entity_json_from         │──> d365-entities/*.json
SolutionExtract/Formulas/*.xaml ─────┤     │ _solution.py                           │
SolutionExtract/Controls/* ──────────┤     └────────────────────────────────────────┘
plugins/*.cs ────────────────────────┘
                                                    │
Step 3: enrich_d365_entity_json_from_api.py         v
d365-entities/*.json ───────────────┐     ┌────────────────────────────────────────┐
Dataverse Web API ──────────────────┼────>│ enrich_d365_entity_json_from           │──> d365-entities/*.json (enriched)
                                    └     │ _api.py                                │
                                          └────────────────────────────────────────┘
                                                    │
Step 4: compute_d365_reference_counts.py            v
d365-entities/*.json ───────────────────> compute_d365_reference   ──> d365-entities/*.json (with count properties)
                                          _counts.py
                                                    │
Step 5: refresh_d365_field_lastupdates_tds.py       v
d365-entities/*.json ───────────────┐     ┌────────────────────────────────────────┐
Dataverse TDS ──────────────────────┼────>│ refresh_d365_field_lastupdates         │──> d365-entities/*.json (with lastUpdate)
                                    └     │ _tds.py                                │
                                          └────────────────────────────────────────┘
                                                    │
Step 6: evaluate_d365_migration_eligibility.py       v
d365-entities/*.json ───────────────────> evaluate_d365_migration  ──> d365-entities/*.json (with sfSuggestedMapping)
                                          _eligibility.py
                                                    │
Step 7: generate_d365_sf_suggestions.py
d365-entities/*.json ───────────────┐     ┌────────────────────────────────────────┐
salesforce-entities/*.json ─────────┼────>│ generate_d365_sf                       │──> d365-entities/*.json (with sfSuggested*)
                                    └     │ _suggestions.py                        │
                                          └────────────────────────────────────────┘
                                                    │
Step 8: generate_d365_entity_csv_mapping.py         v
d365-entities/*.json ───────────────────> generate_d365_entity_csv ──> mapping/*.csv
existing mapping/*.csv (confirmed SF) ──┘ _mapping.py
                                                    │
Step 9: generate_d365_report_from_json_and_csv.py   v
d365-entities/*.json ───────────────┐
mapping/*.csv ──────────────────────┼────> generate_d365_report_from ──> reports/*.md
                                    └──── _json_and_csv.py
```

---

## Mapping CSV Format

Each `mapping/{entity}.csv` contains one row per D365 field with these columns:

| Column | Source | Description |
|---|---|---|
| `fieldName` | customizations.xml | D365 field schema name |
| `displayName` | customizations.xml | D365 field display name |
| `dataType` | customizations.xml | D365 field type (Lookup, String, OptionSet, etc.) |
| `requiredLevel` | customizations.xml | none / recommended / required |
| `isCustom` | customizations.xml | True if custom field (azt_ prefix) |
| `lastUpdate` | Dataverse TDS | Last modified date for field data (datetime, "Never", or "Skipped") |
| `picklistValues` | customizations.xml | Pre-formatted picklist string: `1: Label, 2: Label, ...` |
| `mappingSuggested` | d365-entities JSON | Read from `sfSuggestedMapping` (set by Step 6 based on staleness + usage + required level) |
| `notes` | d365-entities JSON | Free-text annotation for the field |
| `refForms` | Computed | Number of form references for this field |
| `refViews` | Computed | Number of view references for this field |
| `refChartVisualizations` | Computed | Number of chart visualization references |
| `refReports` | Computed | Number of report references |
| `refDashboards` | Computed | Number of dashboard references |
| `refWorkflows` | Computed | Number of workflow references |
| `refFormulas` | Computed | Number of formula/rollup references |
| `refPlugins` | Computed | Number of plugin references |
| `refPcfControls` | Computed | Number of PCF control references |
| `refRelationships` | Computed | Number of relationship references |
| `refRibbon` | Computed | Number of ribbon customization references |
| `sfObjectName` | Human-confirmed | Confirmed Salesforce target object |
| `sfFieldDisplayName` | Human-confirmed | Confirmed Salesforce field label |
| `sfFieldApiName` | Human-confirmed | Confirmed Salesforce field API name |
| `sfSuggestedObjectName` | AI-generated | Suggested SF object (from salesforce-entities/ matching) |
| `sfSuggestedFieldDisplayName` | AI-generated | Suggested SF field label (fuzzy match) |
| `sfSuggestedFieldApiName` | AI-generated | Suggested SF field API name (fuzzy match) |

**Source of truth rule:** The `d365-entities/*.json` is the authoritative source for SF suggested mapping data (`sfSuggested*` fields per field). Suggestions are generated by Step 7 using 5-tier matching (exact, fuzzy, synonym, rule-based, AI) and persisted in the JSON. Existing suggestions are preserved across pipeline runs — Step 1 caches and restores them, Step 7 skips fields that already have suggestions. To regenerate a suggestion, clear the `sfSuggested*` fields from the JSON manually. Confirmed SF columns (`sfObjectName`, `sfFieldDisplayName`, `sfFieldApiName`) are preserved in the CSV by Step 5. The CSV and reports copy `sfSuggested*` values from the JSON.

---

## D365 Entity JSON Schema

Each `d365-entities/{entity}.json` contains:

```json
{
  "entityName": "account",
  "displayName": "Account",
  "description": "Business that represents a customer or potential customer.",
  "objectType": "Standard|Custom",
  "ownershipType": "UserOwned",
  "auditEnabled": true,
  "primaryIdField": "accountid",
  "primaryNameField": "name",
  "countForms": 0,
  "countViews": 0,
  "countChartVisualizations": 0,
  "countReports": 0,
  "countDashboards": 0,
  "countWorkflows": 0,
  "countFormulasAndRollups": 0,
  "countPlugins": 0,
  "countPCFControls": 0,
  "countRelationships": 0,
  "countRibbonCustomizations": 0,
  "sections": {
    "forms": [],
    "views": [],
    "chartVisualizations": [],
    "reports": [],
    "dashboards": [],
    "workflows": [],
    "javaScript": [],
    "formulas": [],
    "plugins": [],
    "pcfControls": [],
    "relationships": [],
    "ribbon": { "customActions": [], "commands": [] },
    "conflicts": { "perFormConflicts": [], "inCodeNotOnForms": [], "onFormsNotInLogic": [] }
  },
  "fields": [
    {
      "fieldName": "accountnumber",
      "displayName": "Account Number",
      "description": "Type an ID number or code for the account.",
      "dataType": "nvarchar",
      "requiredLevel": "none",
      "isCustom": false,
      "introducedVersion": "5.0.0.0",
      "maxLength": 20,
      "fieldSecurity": false,
      "auditEnabled": true,
      "relatedTo": null,
      "picklistValues": null,
      "countForms": 0,
      "countViews": 0,
      "countChartVisualizations": 0,
      "countReports": 0,
      "countDashboards": 0,
      "countWorkflows": 0,
      "countFormulasAndRollups": 0,
      "countPlugins": 0,
      "countPCFControls": 0,
      "countRelationships": 0,
      "countRibbonCustomizations": 0,
      "sfSuggestedMapping": false,
      "sfSuggestedObjectName": null,
      "sfSuggestedFieldDisplayName": null,
      "sfSuggestedFieldApiName": null,
      "sfSuggestedDataType": null,
      "sfSuggestedMatchTier": null,
      "notes": null,
      "forms": [],
      "views": [],
      "chartVisualizations": [],
      "reports": [],
      "dashboards": [],
      "workflows": [],
      "javaScript": [],
      "formulas": [],
      "plugins": [],
      "pcfControls": [],
      "relationships": [],
      "ribbon": [],
      "conflicts": []
    }
  ]
}
```

### Entity-level properties

| Property | Source | Description |
|---|---|---|
| `entityName` | customizations.xml | D365 entity schema name (lowercase) |
| `displayName` | `<LocalizedNames>` | English display name of the entity |
| `description` | `<Descriptions>` | English description of the entity |
| `objectType` | Derived | `"Custom"` if entity starts with `azt_`, else `"Standard"` |
| `ownershipType` | `<OwnershipTypeMask>` | Ownership model (e.g., `UserOwned`, `OrganizationOwned`) |
| `auditEnabled` | `<IsAuditEnabled>` | Whether entity-level auditing is enabled |
| `primaryIdField` | Convention | `{entityname}id` |
| `primaryNameField` | `<DisplayMask>` | Field whose DisplayMask contains `PrimaryName` |
| `countForms` | Step 4 | Total form references across all fields |
| `countViews` | Step 4 | Total view references across all fields |
| `countChartVisualizations` | Step 4 | Total chart visualization references across all fields |
| `countReports` | Step 4 | Total report references across all fields |
| `countDashboards` | Step 4 | Total dashboard references across all fields |
| `countWorkflows` | Step 4 | Total workflow references across all fields |
| `countFormulasAndRollups` | Step 4 | Total formula/rollup references across all fields |
| `countPlugins` | Step 4 | Total plugin references across all fields |
| `countPCFControls` | Step 4 | Total PCF control references across all fields |
| `countRelationships` | Step 4 | Total relationship references across all fields |
| `countRibbonCustomizations` | Step 4 | Total ribbon customization references across all fields |
| `sections` | Parsed from SolutionExtract/ + plugins/ | Full entity-level parse outputs (forms, views, charts, reports, dashboards, workflows, JS, formulas, plugins, PCF controls, relationships, ribbon, conflicts) |

### Per-field properties

| Property | Source | Description |
|---|---|---|
| `description` | Field `<Descriptions>` | English description of the field |
| `maxLength` | `<MaxLength>` | Maximum string length (int or null) |
| `fieldSecurity` | `<IsSecured>` | Whether field-level security is enabled |
| `auditEnabled` | Field `<IsAuditEnabled>` | Whether field-level auditing is enabled |
| `relatedTo` | Relationships section | Referenced entity name from first relationship, or null |
| `countForms` | Step 4 | Number of form references for this field |
| `countViews` | Step 4 | Number of view references for this field |
| `countChartVisualizations` | Step 4 | Number of chart visualization references for this field |
| `countReports` | Step 4 | Number of report references for this field |
| `countDashboards` | Step 4 | Number of dashboard references for this field |
| `countWorkflows` | Step 4 | Number of workflow references for this field |
| `countFormulasAndRollups` | Step 4 | Number of formula/rollup references for this field |
| `countPlugins` | Step 4 | Number of plugin references for this field |
| `countPCFControls` | Step 4 | Number of PCF control references for this field |
| `countRelationships` | Step 4 | Number of relationship references for this field |
| `countRibbonCustomizations` | Step 4 | Number of ribbon customization references for this field |
| `sfSuggestedMapping` | Step 6 | Whether this field should be suggested for SF migration (true/false). Set based on staleness + usage + required level. |
| `sfSuggestedObjectName` | Step 7 (5-tier matching) | Suggested SF target object name, or null |
| `sfSuggestedFieldDisplayName` | Step 7 | Suggested SF field display name, or null |
| `sfSuggestedFieldApiName` | Step 7 | Suggested SF field API name (e.g., `Account_Alert__c`), or null |
| `sfSuggestedDataType` | Step 7 | Expected SF data type from compatibility matrix, or null |
| `sfSuggestedMatchTier` | Step 7 | Which tier matched: `exact`, `fuzzy`, `synonym`, `generated`, `ai` |
| `notes` | Human-entered | Free-text annotation for the field, or null |

---

## Salesforce Entity JSON Schema

Each `salesforce-entities/{object}.json` contains:

```json
{
  "objectName": "Account",
  "displayName": "Account",
  "objectType": "Standard|Custom",
  "recordCount": 0,
  "fields": [
    {
      "fieldName": "Name",
      "displayName": "Account Name",
      "dataType": "string",
      "required": "Yes|No",
      "relatedTo": "None|ObjectName",
      "maxLength": 255,
      "picklistValues": null
    }
  ]
}
```

---

## Slash Commands

| Command | Script | Usage |
|---|---|---|
| `/generate-sf-json [object]` | `generate_sf_entity_json_from_api.py` | Step 1: Refresh Salesforce object schema(s) from org |
| `/generate-d365-json [entity]` | `generate_d365_entity_json_from_solution.py` | Step 2: Generate enriched D365 entity JSON(s) |
| `/enrich-d365-json [entity]` | `enrich_d365_entity_json_from_api.py` | Step 3: Enrich stub fields with Dataverse API metadata |
| `/compute-d365-ref-counts [entity]` | `compute_d365_reference_counts.py` | Step 4: Pre-compute reference counts at entity and field level |
| `/refresh-d365-lastupdates [entity]` | `refresh_d365_field_lastupdates_tds.py` | Step 5: Refresh lastUpdate via Dataverse TDS |
| `/evaluate-d365-migration [entity]` | `evaluate_d365_migration_eligibility.py` | Step 6: Evaluate migration eligibility per field (staleness + usage + required). Clears sfSuggested* when false. |
| `/generate-d365-sf-suggestions [entity]` | `generate_d365_sf_suggestions.py` | Step 7: Generate SF field suggestions via 5-tier matching. Only processes fields with sfSuggestedMapping=true. |
| `/generate-d365-csv [entity]` | `generate_d365_entity_csv_mapping.py` | Step 8: Extract mapping CSV(s) from enriched JSON (reads sfSuggested* from JSON) |
| `/generate-d365-report [entity]` | `generate_d365_report_from_json_and_csv.py` | Step 9: Generate field usage Markdown report(s) |
| `/generate-all [entity]` | All pipeline scripts | Run full pipeline (Steps 1 → 2 → 3 → 4 → 5 → 6 → 7 → 8 → 9) |

All commands default to `--all` when no entity argument is provided.