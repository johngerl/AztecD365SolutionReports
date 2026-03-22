Display available slash commands and their usage.

Do NOT run any scripts. Simply display the following information to the user:

## Available Commands

| Command | Usage | Description |
|---|---|---|
| `/generate-d365-json [entity]` | `/generate-d365-json account` or `/generate-d365-json` (all) | Step 1: Parse SolutionExtract/ and plugins/ to generate enriched D365 entity JSON(s). Caches and restores sfSuggested* values across regenerations. |
| `/enrich-d365-json [entity]` | `/enrich-d365-json account` or `/enrich-d365-json` (all) | Step 2: Enrich stub fields with Dataverse API metadata. Also enriches plugin sections with registration metadata (mode, stage, state). |
| `/refresh-d365-lastupdates [entity]` | `/refresh-d365-lastupdates account` or `/refresh-d365-lastupdates` (all) | Step 3: Refresh lastUpdate fields via D365 Dataverse TDS endpoint. Requires pyodbc, msal, and scripts/config.local.json |
| `/generate-sf-json [object]` | `/generate-sf-json Account` or `/generate-sf-json` (all) | Step 5: Refresh Salesforce object schema(s) from the org via REST API. Use SF API names (e.g., Account, Custom_Object__c) |
| `/update-d365-csv-with-sf [entity]` | `/update-d365-csv-with-sf account` or `/update-d365-csv-with-sf` (all) | Step 6: 5-tier SF field matching (exact, fuzzy, synonym, rule-based, AI). Writes suggestions to JSON (source of truth) and CSV. Uses DataTypeCompatibilityMatrix.md for type-aware matching. |
| `/generate-d365-csv [entity]` | `/generate-d365-csv account` or `/generate-d365-csv` (all) | Step 4: Extract mapping CSV(s) from enriched JSON. Reads sfSuggested* from JSON, preserves confirmed SF columns from CSV. |
| `/generate-d365-report [entity]` | `/generate-d365-report opportunity` or `/generate-d365-report` (all) | Step 7: Generate field usage report(s). Reads from d365-entities/*.json and mapping/*.csv |
| `/generate-all [entity]` | `/generate-all account` or `/generate-all` (all) | Run full pipeline: Steps 1 → 2 → 3 → 5 → 6 → 4 → 7 |

All commands default to `--all` when no argument is provided.

### Pipeline Order

SF refresh and suggestions run before CSV generation so suggestions flow into the CSV from the JSON source of truth.

```
Step 1:  /generate-d365-json         SolutionExtract/ + plugins/  →  d365-entities/*.json
Step 2:  /enrich-d365-json           d365-entities/*.json + API   →  d365-entities/*.json (enriched + plugin registrations)
Step 3:  /refresh-d365-lastupdates   d365-entities/*.json + TDS   →  d365-entities/*.json (with lastUpdate)
Step 5:  /generate-sf-json           Salesforce API                →  salesforce-entities/*.json
Step 6:  /update-d365-csv-with-sf    JSON + SF entities + matrix   →  d365-entities/*.json (with sfSuggested*) + mapping/*.csv
Step 4:  /generate-d365-csv          d365-entities/*.json          →  mapping/*.csv (with suggestions from JSON)
Step 7:  /generate-d365-report       JSON + CSV                    →  reports/*.md
```

### Key Files

| File | Purpose |
|---|---|
| `DataTypeCompatibilityMatrix.md` | User-editable D365→SF data type compatibility rules (read by Step 6) |
| `d365-entities/*.json` | Source of truth for sfSuggested* field mappings |
| `mapping/*.csv` | Source of truth for confirmed SF mappings (sfObjectName, sfFieldDisplayName, sfFieldApiName) |
