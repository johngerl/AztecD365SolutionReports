
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
| `salesforce-entities/` | Salesforce object describe JSON with d365 cross-reference fields | 50 |
| `reports/` | Generated Markdown field usage reports (one per entity) | 94 |
| `mapping/` | Field mapping CSVs with confirmed + suggested SF columns | 94 |
| `scripts/` | Python analysis and refresh scripts | 5 |
| `plans/` | Architecture and implementation plans | — |
| `.claude/commands/` | Claude Code slash commands | 5 |

---

## Scripts

Pipeline scripts run in order: Step 1 → Step 2 → Step 3 → Step 4a → Step 4b.

| Step | Script | Input | Output | Purpose |
|---|---|---|---|---|
| 1 | `enrich_entity_json.py` | `SolutionExtract/`, `plugins/` | `d365-entities/*.json` | Parse D365 solution and build enriched JSON with entity-level sections and per-field section datasets |
| 2 | `extract_mapping_csv.py` | `d365-entities/*.json`, existing `mapping/*.csv` | `mapping/*.csv` | Extract mapping CSV from JSON; preserves confirmed SF columns, clears sfSuggested columns |
| 3 | `refresh_sf_entities.py` | Salesforce REST API | `salesforce-entities/*.json` | Refresh SF object schemas from org, preserving d365 cross-references |
| 4a | `update_mapping_csv.py` | `d365-entities/*.json`, `salesforce-entities/*.json`, `mapping/*.csv` | `mapping/*.csv` | Update mapping CSVs with SF suggestions and reference counts |
| 4b | `generate_report.py` | `d365-entities/*.json`, `mapping/*.csv` | `reports/*.md` | Generate field usage Markdown reports |

All scripts accept a single entity name or `--all`. Python 3.6+ stdlib only (no pip dependencies). `refresh_sf_entities.py` requires network access to the Salesforce org. `enrich_entity_json.py` contains all SolutionExtract and plugin parsing logic (17+ parse functions).

---

## Data Flow

```
Step 1: enrich_entity_json.py
SolutionExtract/customizations.xml ──┐
SolutionExtract/Reports/*.rdl ───────┤
SolutionExtract/Workflows/*.xaml ────┤
SolutionExtract/WebResources/* ──────┤     ┌──────────────────────┐
SolutionExtract/Formulas/*.xaml ─────┼────>│ enrich_entity_json   │───> d365-entities/*.json
SolutionExtract/Controls/* ──────────┤     │        .py           │
plugins/*.cs ────────────────────────┘     └──────────────────────┘
                                                    │
Step 2: extract_mapping_csv.py                      v
d365-entities/*.json ───────────────────> extract_mapping_csv.py ──> mapping/*.csv
existing mapping/*.csv (confirmed SF) ──┘

Step 3: refresh_sf_entities.py
Salesforce REST API ────────────────────> refresh_sf_entities.py ──> salesforce-entities/*.json

Step 4a: update_mapping_csv.py
d365-entities/*.json ───────────────┐
salesforce-entities/*.json ─────────┼────> update_mapping_csv ────> mapping/*.csv (with suggestions)
mapping/*.csv ──────────────────────┘     │        .py           │
                                          └──────────────────────┘

Step 4b: generate_report.py
d365-entities/*.json ───────────────┐
mapping/*.csv ──────────────────────┼────> generate_report.py ────> reports/*.md
                                    └──────────────────────────────┘
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
| `picklistValues` | customizations.xml | Pre-formatted picklist string: `1: Label, 2: Label, ...` |
| `mappingSuggested` | Computed | `true` if field has usage refs or requiredLevel is not none/empty |
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

**Source of truth rule:** The mapping CSV is the authoritative source for confirmed SF mapping data. Confirmed columns (`sfObjectName`, `sfFieldDisplayName`, `sfFieldApiName`) are preserved across pipeline runs by `extract_mapping_csv.py`. Suggested columns (`sfSuggested*`) are cleared by step 2 and regenerated by step 4a (`update_mapping_csv.py`) using salesforce-entities/ matching. The enriched JSON (`d365-entities/`) does not contain SF columns — SF data lives only in the CSV and reports.

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
| `sections` | Parsed from SolutionExtract/ + plugins/ | Full entity-level parse outputs (forms, views, charts, reports, dashboards, workflows, JS, formulas, plugins, PCF controls, relationships, ribbon, conflicts) |

### Per-field properties

| Property | Source | Description |
|---|---|---|
| `description` | Field `<Descriptions>` | English description of the field |
| `maxLength` | `<MaxLength>` | Maximum string length (int or null) |
| `fieldSecurity` | `<IsSecured>` | Whether field-level security is enabled |
| `auditEnabled` | Field `<IsAuditEnabled>` | Whether field-level auditing is enabled |
| `relatedTo` | Relationships section | Referenced entity name from first relationship, or null |

---

## Salesforce Entity JSON Schema

Each `salesforce-entities/{object}.json` contains:

```json
{
  "objectName": "Account",
  "objectType": "Standard|Custom",
  "recordCount": 0,
  "fields": [
    {
      "fieldName": "Name",
      "dataType": "string",
      "required": "Yes|No",
      "relatedTo": "None|ObjectName",
      "maxLength": 255,
      "picklistValues": null,
      "d365EntityName": "account",
      "d365DisplayName": "Account Name",
      "d365InternalName": "name",
      "d365SuggestedEntityName": null,
      "d365SuggestedDisplayName": null,
      "d365SuggestedInternalName": null
    }
  ]
}
```

The `d365*` fields provide reverse cross-references from SF back to D365. Confirmed values come from human review; suggested values from AI matching. `refresh_sf_entities.py` preserves these fields when refreshing SF metadata.

---

## Slash Commands

| Command | Script | Usage |
|---|---|---|
| `/enrich-d365-entity [entity]` | `enrich_entity_json.py` | Generate enriched D365 entity JSON(s) |
| `/refresh-sf-entity [entity]` | `refresh_sf_entities.py` | Refresh Salesforce object schema(s) from org |
| `/update-mapping-csv [entity]` | `update_mapping_csv.py` | Update mapping CSV(s) with SF suggestions |
| `/generate-report [entity]` | `generate_report.py` | Generate field usage Markdown report(s) |
| `/generate-all [entity]` | All pipeline scripts | Run full pipeline (Steps 1 → 2 → 3 → 4a → 4b) |

All commands default to `--all` when no entity argument is provided.