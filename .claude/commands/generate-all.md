Run the full pipeline: refresh SF entities, generate D365 JSON, enrich from API, compute reference counts, refresh lastUpdate via TDS, set SF mapping flags, generate SF suggestions, extract CSV, and generate reports.

Runs Steps 1 → 2 → 3 → 4 → 5 → 6 → 7 → 8 → 9 in sequence.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
  echo "============================================================"
  echo "Full Pipeline: All Entities"
  echo "============================================================"
  echo ""
  echo "Step 1/9: Refreshing SF entity JSON from API..."
  echo "------------------------------------------------------------"
  python scripts/generate_sf_entity_json_from_api.py --all
  echo ""
  echo "Step 2/9: Generating D365 entity JSON from solution..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_json_from_solution.py --all
  echo ""
  echo "Step 3/9: Enriching D365 entity JSON from Dataverse API..."
  echo "------------------------------------------------------------"
  python scripts/enrich_d365_entity_json_from_api.py --all
  echo ""
  echo "Step 4/9: Computing reference counts..."
  echo "------------------------------------------------------------"
  python scripts/compute_d365_reference_counts.py --all
  echo ""
  echo "Step 5/9: Refreshing lastUpdate via Dataverse TDS..."
  echo "------------------------------------------------------------"
  python scripts/refresh_d365_field_lastupdates_tds.py --all
  echo ""
  echo "Step 6/9: Setting sfSuggestedMapping flags..."
  echo "------------------------------------------------------------"
  python scripts/set_d365_sf_suggested_mapping.py --all
  echo ""
  echo "Step 7/9: Generating SF suggestions (5-tier matching)..."
  echo "------------------------------------------------------------"
  python scripts/update_d365_entity_csv_mapping_with_sf_suggestions.py --all
  echo ""
  echo "Step 8/9: Generating D365 entity CSV mappings..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_csv_mapping.py --all
  echo ""
  echo "Step 9/9: Generating D365 field usage reports..."
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
  echo "Step 1/9: Refreshing SF entity JSON from API ($SF_NAME)..."
  echo "------------------------------------------------------------"
  python scripts/generate_sf_entity_json_from_api.py $SF_NAME
  echo ""
  echo "Step 2/9: Generating D365 entity JSON from solution..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_json_from_solution.py $ARG
  echo ""
  echo "Step 3/9: Enriching D365 entity JSON from Dataverse API..."
  echo "------------------------------------------------------------"
  python scripts/enrich_d365_entity_json_from_api.py $ARG
  echo ""
  echo "Step 4/9: Computing reference counts..."
  echo "------------------------------------------------------------"
  python scripts/compute_d365_reference_counts.py $ARG
  echo ""
  echo "Step 5/9: Refreshing lastUpdate via Dataverse TDS..."
  echo "------------------------------------------------------------"
  python scripts/refresh_d365_field_lastupdates_tds.py $ARG
  echo ""
  echo "Step 6/9: Setting sfSuggestedMapping flags..."
  echo "------------------------------------------------------------"
  python scripts/set_d365_sf_suggested_mapping.py $ARG
  echo ""
  echo "Step 7/9: Generating SF suggestions (5-tier matching)..."
  echo "------------------------------------------------------------"
  python scripts/update_d365_entity_csv_mapping_with_sf_suggestions.py $ARG
  echo ""
  echo "Step 8/9: Generating D365 entity CSV mapping..."
  echo "------------------------------------------------------------"
  python scripts/generate_d365_entity_csv_mapping.py $ARG
  echo ""
  echo "Step 9/9: Generating D365 field usage report..."
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
- Reference counts computed
- Number of entities refreshed via TDS
- Number of fields with sfSuggestedMapping=true vs false
- Number of SF suggestions generated (by tier)
- Number of mapping CSVs updated
- Number of reports generated
- Any warnings or errors from the run
