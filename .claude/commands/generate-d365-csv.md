Extract mapping CSV(s) from enriched d365-entities/ JSON files.

This is Step 7 of the pipeline. Preserves confirmed SF mapping columns (sfObjectName, sfFieldDisplayName, sfFieldApiName) from existing CSVs. Reads sfSuggested* and sfSuggestedMapping from JSON.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/generate_d365_entity_csv_mapping.py $ARG
```

After completion, report:
- Number of mapping CSVs generated (count files in mapping/)
- Any warnings or errors from the run
