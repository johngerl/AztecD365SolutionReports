Display available slash commands and their usage.

Do NOT run any scripts. Simply display the following information to the user:

## Available Commands

| Command | Usage | Description |
|---|---|---|
| `/generate-sf-json [object]` | `/generate-sf-json Account` or `/generate-sf-json` (all) | Step 1: Refresh Salesforce object schema(s) from the org via REST API. No dependencies on other scripts. Use SF API names (e.g., Account, Custom_Object__c) |
| `/generate-d365-json [entity]` | `/generate-d365-json account` or `/generate-d365-json` (all) | Step 2: Parse SolutionExtract/ and plugins/ to generate enriched D365 entity JSON(s). Caches and restores sfSuggested* values across regenerations. |
| `/enrich-d365-json [entity]` | `/enrich-d365-json account` or `/enrich-d365-json` (all) | Step 3: Enrich stub fields with Dataverse API metadata. Also enriches plugin sections with registration metadata (mode, stage, state). |
| `/compute-d365-ref-counts [entity]` | `/compute-d365-ref-counts account` or `/compute-d365-ref-counts` (all) | Step 4: Pre-compute reference counts at entity and field level from section arrays. Downstream steps read these instead of recomputing. |
| `/refresh-d365-lastupdates [entity]` | `/refresh-d365-lastupdates account` or `/refresh-d365-lastupdates` (all) | Step 5: Refresh lastUpdate fields via D365 Dataverse TDS endpoint. Requires pyodbc, msal, and scripts/config.local.json |
| `/set-d365-sf-mapping [entity]` | `/set-d365-sf-mapping account` or `/set-d365-sf-mapping` (all) | Step 6: Set sfSuggestedMapping flag on each field based on usage and staleness. Clears sfSuggested* for non-qualifying fields. Single source of truth for migration eligibility. |
| `/update-d365-csv-with-sf [entity]` | `/update-d365-csv-with-sf account` or `/update-d365-csv-with-sf` (all) | Step 7: 5-tier SF field matching (exact, fuzzy, synonym, rule-based, AI). Writes suggestions to d365-entities JSON. Only processes fields with sfSuggestedMapping=true. |
| `/generate-d365-csv [entity]` | `/generate-d365-csv account` or `/generate-d365-csv` (all) | Step 8: Extract mapping CSV(s) from enriched JSON. Reads sfSuggested*, sfSuggestedMapping, and count properties from JSON. |
| `/generate-d365-report [entity]` | `/generate-d365-report opportunity` or `/generate-d365-report` (all) | Step 9: Generate field usage report(s). Reads from d365-entities/*.json and mapping/*.csv. Entity-level counts displayed in report header. |
| `/generate-all [entity]` | `/generate-all account` or `/generate-all` (all) | Run full pipeline: Steps 1 → 2 → 3 → 4 → 5 → 6 → 7 → 8 → 9 |

All commands default to `--all` when no argument is provided.

### Pipeline Order

```
Step 1:  /generate-sf-json           Salesforce API                →  salesforce-entities/*.json
Step 2:  /generate-d365-json         SolutionExtract/ + plugins/  →  d365-entities/*.json
Step 3:  /enrich-d365-json           d365-entities/*.json + API   →  d365-entities/*.json (enriched + plugin registrations)
Step 4:  /compute-d365-ref-counts    d365-entities/*.json          →  d365-entities/*.json (with count properties)
Step 5:  /refresh-d365-lastupdates   d365-entities/*.json + TDS   →  d365-entities/*.json (with lastUpdate)
Step 6:  /set-d365-sf-mapping        d365-entities/*.json          →  d365-entities/*.json (with sfSuggestedMapping)
Step 7:  /update-d365-csv-with-sf    JSON + SF entities + matrix   →  d365-entities/*.json (with sfSuggested*)
Step 8:  /generate-d365-csv          d365-entities/*.json          →  mapping/*.csv (with suggestions from JSON)
Step 9:  /generate-d365-report       JSON + CSV                    →  reports/*.md
```

### Key Files

| File | Purpose |
|---|---|
| `DataTypeCompatibilityMatrix.md` | User-editable D365→SF data type compatibility rules (read by Step 7) |
| `d365-entities/*.json` | Source of truth for count properties, sfSuggestedMapping, and sfSuggested* field mappings |
| `mapping/*.csv` | Source of truth for confirmed SF mappings (sfObjectName, sfFieldDisplayName, sfFieldApiName) |
