Refresh Salesforce object schema(s) from the org via REST API.

If `$ARGUMENTS` is empty, run for all existing objects. Otherwise run for the specified Salesforce object (use API name, e.g., Account, Opportunity, Custom_Object__c).

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/refresh_sf_entities.py $ARG
```

After completion, report:
- Number of objects refreshed (count files in salesforce-entities/)
- Number of fields per object
- Number of fields with d365 mapping data preserved
- Any API errors encountered

Prerequisites: Salesforce Connected App must have 'Manage user data via APIs (api)' OAuth scope configured.
