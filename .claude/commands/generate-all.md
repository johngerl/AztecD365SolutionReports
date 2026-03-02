Run the full pipeline: enrich JSON, extract CSV, refresh SF entities, update SF suggestions, and generate reports.

Runs Steps 1 → 2 → 3 → 4a → 4b in sequence. Step 3 (SF refresh) is only included when running for all entities, since it requires SF API names which differ from D365 entity names. To refresh a single SF object, use `/refresh-sf-entity` separately.

If `$ARGUMENTS` is empty, run for all entities. Otherwise run for the specified entity.

```bash
# Determine argument
if [ -z "$ARGUMENTS" ]; then
  ARG="--all"
  echo "============================================================"
  echo "Full Pipeline: All Entities"
  echo "============================================================"
  echo ""
  echo "Step 1/5: Enriching D365 entity JSON..."
  echo "------------------------------------------------------------"
  python scripts/enrich_entity_json.py --all
  echo ""
  echo "Step 2/5: Extracting mapping CSVs..."
  echo "------------------------------------------------------------"
  python scripts/extract_mapping_csv.py --all
  echo ""
  echo "Step 3/5: Refreshing SF entity schemas..."
  echo "------------------------------------------------------------"
  python scripts/refresh_sf_entities.py --all
  echo ""
  echo "Step 4/5: Updating mapping CSVs with SF suggestions..."
  echo "------------------------------------------------------------"
  python scripts/update_mapping_csv.py --all
  echo ""
  echo "Step 5/5: Generating field usage reports..."
  echo "------------------------------------------------------------"
  python scripts/generate_report.py --all
else
  ARG="$ARGUMENTS"
  echo "============================================================"
  echo "Full Pipeline: $ARG"
  echo "============================================================"
  echo ""
  echo "Step 1/4: Enriching D365 entity JSON..."
  echo "------------------------------------------------------------"
  python scripts/enrich_entity_json.py $ARG
  echo ""
  echo "Step 2/4: Extracting mapping CSV..."
  echo "------------------------------------------------------------"
  python scripts/extract_mapping_csv.py $ARG
  echo ""
  echo "Step 3/4: Updating mapping CSV with SF suggestions..."
  echo "------------------------------------------------------------"
  python scripts/update_mapping_csv.py $ARG
  echo ""
  echo "Step 4/4: Generating field usage report..."
  echo "------------------------------------------------------------"
  python scripts/generate_report.py $ARG
  echo ""
  echo "(Skipped SF entity refresh — use /refresh-sf-entity with SF API name separately)"
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
- For single-entity runs, remind the user to run `/refresh-sf-entity <SfObjectName>` if they need updated SF schema
