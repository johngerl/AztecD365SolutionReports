Enrich stub fields in d365-entities/*.json with metadata from the Dataverse Web API.

This is Step 2 of the pipeline. Runs after Step 1 to fill in dataType, displayName,
and other metadata for fields that exist in Dataverse but were not in the solution export.

Requires: msal and scripts/config.local.json with Dataverse credentials.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi
python scripts/enrich_d365_entity_json_from_api.py $ARG
```
