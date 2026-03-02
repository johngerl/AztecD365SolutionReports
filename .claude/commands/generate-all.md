Run the full pipeline: generate D365 JSON, extract CSV, refresh SF entities, update SF suggestions, and generate reports.

Runs Steps 1 → 2 → 3 → 4 → 5 in sequence.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
  echo "============================================================"
  echo "Full Pipeline: All Entities"
  echo "============================================================"
  echo ""
  echo "Step 1/5: Generating D365 entity JSON from solution..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_json_from_solution_step_01.py --all
  echo ""
  echo "Step 2/5: Generating D365 entity CSV mappings..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_csv_mapping_step_02.py --all
  echo ""
  echo "Step 3/5: Generating SF entity JSON from API..."
  echo "------------------------------------------------------------"
  python scripts/generate_sf_entity_json_from_api_step_03.py --all
  echo ""
  echo "Step 4/5: Updating D365 CSV mappings with SF suggestions..."
  echo "------------------------------------------------------------"
  python scripts/update_d365_entity_csv_mapping_with_sf_suggestions_step_04.py --all
  echo ""
  echo "Step 5/5: Generating D365 field usage reports..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_report_from_json_and_csv_step_05.py --all
else
  ARG="$ARGUMENTS"
  # Capitalize first letter as heuristic SF object name
  SF_NAME="$(echo "$ARG" | sed 's/^./\U&/')"
  echo "============================================================"
  echo "Full Pipeline: $ARG"
  echo "============================================================"
  echo ""
  echo "Step 1/5: Generating D365 entity JSON from solution..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_json_from_solution_step_01.py $ARG
  echo ""
  echo "Step 2/5: Generating D365 entity CSV mapping..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_csv_mapping_step_02.py $ARG
  echo ""
  echo "Step 3/5: Generating SF entity JSON from API ($SF_NAME)..."
  echo "------------------------------------------------------------"
  python scripts/generate_sf_entity_json_from_api_step_03.py $SF_NAME
  echo ""
  echo "Step 4/5: Updating D365 CSV mapping with SF suggestions..."
  echo "------------------------------------------------------------"
  python scripts/update_d365_entity_csv_mapping_with_sf_suggestions_step_04.py $ARG
  echo ""
  echo "Step 5/5: Generating D365 field usage report..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_report_from_json_and_csv_step_05.py $ARG
fi

echo ""
echo "============================================================"
echo "Pipeline complete!"
echo "============================================================"
```

After completion, report:
- Number of entity JSONs generated
- Number of mapping CSVs updated
- Number of reports generated
- Any warnings or errors from the run
