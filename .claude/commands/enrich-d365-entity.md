Generate enriched D365 entity JSON(s) with per-field section datasets and SF mapping data.

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
- Number of fields with SF mapping data
- Any warnings or errors from the run
