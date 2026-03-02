Display available slash commands and their usage.

Do NOT run any scripts. Simply display the following information to the user:

## Available Commands

| Command | Usage | Description |
|---|---|---|
| `/enrich-d365-entity [entity]` | `/enrich-d365-entity account` or `/enrich-d365-entity` (all) | Step 1: Parse SolutionExtract/ and plugins/ to generate enriched D365 entity JSON(s) with entity-level sections and per-field section datasets |
| `/generate-report [entity]` | `/generate-report opportunity` or `/generate-report` (all) | Step 4: Generate field usage report(s) and update mapping CSV(s) with SF suggestions. Reads from d365-entities/*.json, salesforce-entities/*.json, and mapping/*.csv |
| `/refresh-sf-entity [object]` | `/refresh-sf-entity Account` or `/refresh-sf-entity` (all) | Step 3: Refresh Salesforce object schema(s) from the org via REST API. Use SF API names (e.g., Account, Custom_Object__c) |

All commands default to `--all` when no argument is provided.

### Pipeline Order

```
Step 1: /enrich-d365-entity    SolutionExtract/ + plugins/  →  d365-entities/*.json
Step 2: (run extract_mapping_csv.py manually)                →  mapping/*.csv
Step 3: /refresh-sf-entity     Salesforce API               →  salesforce-entities/*.json
Step 4: /generate-report       JSON + SF + CSV               →  reports/*.md + mapping/*.csv
```
