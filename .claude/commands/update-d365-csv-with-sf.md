Generate SF field suggestions and write them to d365-entities/*.json.

This is Step 7 of the pipeline. It reads from d365-entities/*.json and salesforce-entities/*.json. Run Steps 1-6 first. CSV generation is handled by Step 8.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/update_d365_entity_csv_mapping_with_sf_suggestions.py $ARG
```

After completion, report:
- Number of mapping CSVs updated (count files in mapping/)
- Number of SF suggestions added
- Any warnings or errors from the run
