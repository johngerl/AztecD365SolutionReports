Generate field usage report(s) from d365-entities/*.json and mapping/*.csv.

This is Step 9 of the pipeline. It reads from d365-entities/*.json (not SolutionExtract/ directly) and mapping/*.csv. Run Steps 1-8 first if the JSON, CSV, or SF suggestion data is stale. Step 1 (SF refresh) can run independently at any time.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
else
  ARG="$ARGUMENTS"
fi

python scripts/generate_d365_report_from_json_and_csv.py $ARG
```

After completion, report:
- Number of reports generated (count files in reports/)
- Any warnings or errors from the run

Note: This script reads mapping/*.csv for display only. To update SF suggestions in the CSVs, run `/update-d365-csv-with-sf` (Step 7) first.
