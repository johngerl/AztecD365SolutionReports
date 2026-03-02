Generate enriched D365 entity JSON(s) from SolutionExtract/ and plugins/ sources.

This is Step 1 of the pipeline. The enriched JSON contains entity-level `sections` (full parse outputs) and per-field section datasets (13 section arrays per field). No SF mapping data is included — that lives in the mapping CSVs.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/enrich_entity_json.py $ARG
```

After completion, report:
- Number of entity JSONs generated (count files in d365-entities/)
- Number of fields enriched with section references
- Any warnings or errors from the run
