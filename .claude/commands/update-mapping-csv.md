Update mapping CSV(s) with SF suggestions from salesforce-entities/*.json.

This is Step 4a of the pipeline. It reads from d365-entities/*.json, salesforce-entities/*.json, and existing mapping/*.csv. Run Steps 1-3 first if the JSON or CSV files are stale.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/update_mapping_csv.py $ARG
```

After completion, report:
- Number of mapping CSVs updated (count files in mapping/)
- Number of SF suggestions added
- Any warnings or errors from the run
