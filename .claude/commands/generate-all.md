Run the full pipeline: refresh SF entities, generate D365 JSON, enrich from API, refresh lastUpdate via TDS, generate SF suggestions, extract CSV, and generate reports.

Runs Steps 1 → 2 → 3 → 4 → 5 → 6 → 7 in sequence.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
  echo "============================================================"
  echo "Full Pipeline: All Entities"
  echo "============================================================"
  echo ""
  echo "Step 1/7: Refreshing SF entity JSON from API..."
  echo "------------------------------------------------------------"
  python scripts/generate_sf_entity_json_from_api.py --all
  echo ""
  echo "Step 2/7: Generating D365 entity JSON from solution..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_json_from_solution.py --all
  echo ""
  echo "Step 3/7: Enriching D365 entity JSON from Dataverse API..."
  echo "------------------------------------------------------------"
  python scripts/enrich_d365_entity_json_from_api.py --all
  echo ""
  echo "Step 4/7: Refreshing lastUpdate via Dataverse TDS..."
  echo "------------------------------------------------------------"
  python scripts/refresh_d365_field_lastupdates_tds.py --all
  echo ""
  echo "Step 5/7: Generating SF suggestions (5-tier matching)..."
  echo "------------------------------------------------------------"
  python scripts/update_d365_entity_csv_mapping_with_sf_suggestions.py --all
  echo ""
  echo "Step 6/7: Generating D365 entity CSV mappings..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_csv_mapping.py --all
  echo ""
  echo "Step 7/7: Generating D365 field usage reports..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_report_from_json_and_csv.py --all
else
  ARG="$ARGUMENTS"
  # Capitalize first letter as heuristic SF object name
  SF_NAME="$(echo "$ARG" | sed 's/^./\U&/')"
  echo "============================================================"
  echo "Full Pipeline: $ARG"
  echo "============================================================"
  echo ""
  echo "Step 1/7: Refreshing SF entity JSON from API ($SF_NAME)..."
  echo "------------------------------------------------------------"
  python scripts/generate_sf_entity_json_from_api.py $SF_NAME
  echo ""
  echo "Step 2/7: Generating D365 entity JSON from solution..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_json_from_solution.py $ARG
  echo ""
  echo "Step 3/7: Enriching D365 entity JSON from Dataverse API..."
  echo "------------------------------------------------------------"
  python scripts/enrich_d365_entity_json_from_api.py $ARG
  echo ""
  echo "Step 4/7: Refreshing lastUpdate via Dataverse TDS..."
  echo "------------------------------------------------------------"
  python scripts/refresh_d365_field_lastupdates_tds.py $ARG
  echo ""
  echo "Step 5/7: Generating SF suggestions (5-tier matching)..."
  echo "------------------------------------------------------------"
  python scripts/update_d365_entity_csv_mapping_with_sf_suggestions.py $ARG
  echo ""
  echo "Step 6/7: Generating D365 entity CSV mapping..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_csv_mapping.py $ARG
  echo ""
  echo "Step 7/7: Generating D365 field usage report..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_report_from_json_and_csv.py $ARG
fi

echo ""
echo "============================================================"
echo "Pipeline complete!"
echo "============================================================"
```

After completion, report:
- Number of SF objects refreshed
- Number of entity JSONs generated
- Number of entity JSONs enriched from API
- Number of entities refreshed via TDS
- Number of SF suggestions generated (by tier)
- Number of mapping CSVs updated
- Number of reports generated
- Any warnings or errors from the run
