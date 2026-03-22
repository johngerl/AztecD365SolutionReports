Generate SF field suggestions via 5-tier matching and write them to d365-entities/*.json.

This is Step 7 of the pipeline. It reads from d365-entities/*.json and salesforce-entities/*.json. Run Steps 1-6 first. CSV generation is handled by Step 8.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/generate_d365_sf_suggestions.py $ARG
```

After completion, report:
- Number of SF suggestions generated (by tier)
- Any warnings or errors from the run
