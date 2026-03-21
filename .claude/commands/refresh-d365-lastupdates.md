Refresh entity-level and field-level lastUpdate values in d365-entities/*.json by querying the D365 Dataverse TDS endpoint.

This is a standalone utility (not part of the numbered pipeline). It connects to Dataverse via TDS, queries entity-level totalRows and MAX(modifiedon) (inserted after auditEnabled), then queries MAX(modifiedon) per field, and updates the JSON in-place.

Requires: pyodbc, msal, ODBC Driver 18 for SQL Server, and scripts/config.local.json with Dataverse credentials.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/refresh_d365_field_lastupdates_tds.py $ARG
```

After completion, report:
- Number of entities processed
- Number of fields queried vs skipped vs errors
- Any warnings or errors from the run
