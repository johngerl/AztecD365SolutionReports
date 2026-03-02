Generate field usage report(s) and update mapping CSV(s) with SF suggestions.

This is Step 4 of the pipeline. It reads from d365-entities/*.json (not SolutionExtract/ directly), salesforce-entities/*.json, and mapping/*.csv. Run Steps 1-2 first if the JSON or CSV files are stale.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/generate_field_usage.py $ARG
```

After completion, report:
- Number of reports generated (count files in reports/)
- Number of mapping CSVs updated (count files in mapping/)
- Any warnings or errors from the run

Note: This also updates mapping/*.csv files with SF suggested mappings sourced from salesforce-entities/ JSON schemas.
