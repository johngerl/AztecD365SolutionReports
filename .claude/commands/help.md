Display available slash commands and their usage.

Do NOT run any scripts. Simply display the following information to the user:

## Available Commands

| Command | Usage | Description |
|---|---|---|
| `/generate-d365-json [entity]` | `/generate-d365-json account` or `/generate-d365-json` (all) | Step 1: Parse SolutionExtract/ and plugins/ to generate enriched D365 entity JSON(s) with entity-level sections and per-field section datasets |
| `/enrich-d365-json [entity]` | `/enrich-d365-json account` or `/enrich-d365-json` (all) | Step 2: Enrich stub fields in d365-entities/*.json with metadata from the Dataverse Web API. Fills in dataType, displayName, etc. for fields not in the solution export |
| `/refresh-d365-lastupdates [entity]` | `/refresh-d365-lastupdates account` or `/refresh-d365-lastupdates` (all) | Step 3: Refresh lastUpdate fields in d365-entities/*.json by querying the D365 Dataverse TDS endpoint. Requires pyodbc, msal, and scripts/config.local.json |
| `/generate-d365-csv [entity]` | `/generate-d365-csv account` or `/generate-d365-csv` (all) | Step 4: Extract mapping CSV(s) from enriched d365-entities/ JSON. Preserves confirmed SF columns, clears suggested columns |
| `/generate-sf-json [object]` | `/generate-sf-json Account` or `/generate-sf-json` (all) | Step 5: Refresh Salesforce object schema(s) from the org via REST API. Use SF API names (e.g., Account, Custom_Object__c) |
| `/update-d365-csv-with-sf [entity]` | `/update-d365-csv-with-sf account` or `/update-d365-csv-with-sf` (all) | Step 6: Update mapping CSV(s) with SF suggestions from salesforce-entities/*.json. Reads from d365-entities/*.json, salesforce-entities/*.json, and mapping/*.csv |
| `/generate-d365-report [entity]` | `/generate-d365-report opportunity` or `/generate-d365-report` (all) | Step 7: Generate field usage report(s). Reads from d365-entities/*.json and mapping/*.csv |
| `/generate-all [entity]` | `/generate-all account` or `/generate-all` (all) | Run full pipeline: Steps 1 → 2 → 3 → 4 → 5 → 6 → 7 |

All commands default to `--all` when no argument is provided.

### Pipeline Order

```
Step 1:  /generate-d365-json         SolutionExtract/ + plugins/  →  d365-entities/*.json
Step 2:  /enrich-d365-json           d365-entities/*.json + API   →  d365-entities/*.json (enriched)
Step 3:  /refresh-d365-lastupdates   d365-entities/*.json + TDS   →  d365-entities/*.json (with lastUpdate)
Step 4:  /generate-d365-csv          d365-entities/*.json          →  mapping/*.csv
Step 5:  /generate-sf-json           Salesforce API                →  salesforce-entities/*.json
Step 6:  /update-d365-csv-with-sf    JSON + SF entities + CSV      →  mapping/*.csv (with suggestions)
Step 7:  /generate-d365-report       JSON + CSV                    →  reports/*.md
```
