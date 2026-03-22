Pre-compute reference counts into D365 entity JSON at both entity and field level.

This is Step 4 of the pipeline. Run Steps 1-3 first.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/compute_d365_reference_counts.py $ARG
```

After completion, report:
- Number of entities processed
- Total reference counts computed
- Any warnings or errors from the run
