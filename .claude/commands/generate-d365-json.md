Generate enriched D365 entity JSON(s) from SolutionExtract/ and plugins/ sources.

This is Step 2 of the pipeline. The enriched JSON contains entity-level `sections` (full parse outputs) and per-field section datasets (13 section arrays per field). Caches and restores sfSuggested* and notes values across regenerations.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/generate_d365_entity_json_from_solution.py $ARG
```

After completion, report:
- Number of entity JSONs generated (count files in d365-entities/)
- Number of fields enriched with section references
- Any warnings or errors from the run
