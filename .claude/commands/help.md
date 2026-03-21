Display available slash commands and their usage.

Do NOT run any scripts. Simply display the following information to the user:

## Available Commands

| Command | Usage | Description |
|---|---|---|
| `/generate-d365-json [entity]` | `/generate-d365-json account` or `/generate-d365-json` (all) | Step 1: Parse SolutionExtract/ and plugins/ to generate enriched D365 entity JSON(s) with entity-level sections and per-field section datasets |
| `/generate-d365-csv [entity]` | `/generate-d365-csv account` or `/generate-d365-csv` (all) | Step 2: Extract mapping CSV(s) from enriched d365-entities/ JSON. Preserves confirmed SF columns, clears suggested columns |
| `/generate-sf-json [object]` | `/generate-sf-json Account` or `/generate-sf-json` (all) | Step 3: Refresh Salesforce object schema(s) from the org via REST API. Use SF API names (e.g., Account, Custom_Object__c) |
| `/update-d365-csv-with-sf [entity]` | `/update-d365-csv-with-sf account` or `/update-d365-csv-with-sf` (all) | Step 4: Update mapping CSV(s) with SF suggestions from salesforce-entities/*.json. Reads from d365-entities/*.json, salesforce-entities/*.json, and mapping/*.csv |
| `/generate-d365-report [entity]` | `/generate-d365-report opportunity` or `/generate-d365-report` (all) | Step 5: Generate field usage report(s). Reads from d365-entities/*.json and mapping/*.csv |
| `/generate-all [entity]` | `/generate-all account` or `/generate-all` (all) | Run full pipeline: Steps 1 → 2 → 3 → 4 → 5 |

### Standalone Utilities

| Command | Usage | Description |
|---|---|---|
| `/refresh-d365-lastupdates [entity]` | `/refresh-d365-lastupdates account` or `/refresh-d365-lastupdates` (all) | Refresh lastUpdate fields in d365-entities/*.json by querying the D365 Dataverse TDS endpoint. Requires pyodbc, msal, and scripts/config.local.json |

All commands default to `--all` when no argument is provided.

### Pipeline Order

```
Step 1:  /generate-d365-json       SolutionExtract/ + plugins/  →  d365-entities/*.json
Step 2:  /generate-d365-csv        d365-entities/*.json          →  mapping/*.csv
Step 3:  /generate-sf-json         Salesforce API                →  salesforce-entities/*.json
Step 4:  /update-d365-csv-with-sf  JSON + SF entities + CSV      →  mapping/*.csv (with suggestions)
Step 5:  /generate-d365-report     JSON + CSV                    →  reports/*.md
```
