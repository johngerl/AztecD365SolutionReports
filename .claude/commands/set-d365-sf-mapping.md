Set sfSuggestedMapping on D365 entity field(s) based on usage and staleness rules.

This is Step 5 of the pipeline. Run Steps 1-4 first. This is the single source of truth for "should this field be suggested for SF migration?"

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/set_d365_sf_suggested_mapping.py $ARG
```

After completion, report:
- Number of entities processed
- Number of fields set to sfSuggestedMapping=true vs false
- Number of sfSuggested* fields cleared
- Any warnings or errors from the run
