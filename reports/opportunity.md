# Opportunity Field Usage Analysis
> Date: 2026-03-01

## Table of Contents

- [1. Field Definitions](#1-field-definitions)
- [2. Forms](#2-forms)
  - [2.1. AI for Sales (main) -- Active](#21-ai-for-sales-main-active)
  - [2.2. iGrad (main) -- Active](#22-igrad-main-active)
  - [2.3. Opportunity (main) -- Active](#23-opportunity-main-active)
  - [2.4. Information (main) -- Inactive](#24-information-main-inactive)
  - [2.5. Opportunity (quickCreate) -- Active](#25-opportunity-quickcreate-active)
  - [2.6. Opportunity Quick (quickCreate) -- Active](#26-opportunity-quick-quickcreate-active)
  - [2.7. Opportunity Record Owner (quick) -- Active](#27-opportunity-record-owner-quick-active)
  - [2.8. Opportunity Owner Quick View (quick) -- Active](#28-opportunity-owner-quick-view-quick-active)
  - [2.9. Order Opportunity Owner Quick View (quick) -- Active](#29-order-opportunity-owner-quick-view-quick-active)
- [3. Views](#3-views)
  - [3.1. All Opportunities](#31-all-opportunities)
  - [3.2. Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
  - [3.3. Closed Opportunities](#33-closed-opportunities)
  - [3.4. Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
  - [3.5. Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
  - [3.6. GEDSRM Opps](#36-gedsrm-opps)
  - [3.7. Lost Opportunities](#37-lost-opportunities)
  - [3.8. My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
  - [3.9. My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
  - [3.10. My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
  - [3.11. My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
  - [3.12. My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
  - [3.13. My Open Opportunities Created This Month](#313-my-open-opportunities-created-this-month)
  - [3.14. My Open Opportunities Created This Week](#314-my-open-opportunities-created-this-week)
  - [3.15. My Open Opportunities Created This Year](#315-my-open-opportunities-created-this-year)
  - [3.16. My Open Opportunities](#316-my-open-opportunities)
  - [3.17. My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
  - [3.18. My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
  - [3.19. My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
  - [3.20. My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
  - [3.21. My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
  - [3.22. My Opportunities Closing This Week](#322-my-opportunities-closing-this-week)
  - [3.23. My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
  - [3.24. My Opportunities Created This Year](#324-my-opportunities-created-this-year)
  - [3.25. My Opportunities Won This Quarter](#325-my-opportunities-won-this-quarter)
  - [3.26. My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
  - [3.27. My Overdue Opportunities](#327-my-overdue-opportunities)
  - [3.28. My Overdue Opps](#328-my-overdue-opps)
  - [3.29. My Stalled Opportunities](#329-my-stalled-opportunities)
  - [3.30. My Won Opps this Year](#330-my-won-opps-this-year)
  - [3.31. Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
  - [3.32. Open Opportunities](#332-open-opportunities)
  - [3.33. Open Renewal Opps 90 Days Past Due](#333-open-renewal-opps-90-days-past-due)
  - [3.34. Open Renewal Opps Close Date Last Month](#334-open-renewal-opps-close-date-last-month)
  - [3.35. Open Renewal Opps Closing Next Month](#335-open-renewal-opps-closing-next-month)
  - [3.36. Open Renewal Opps Closing This Month](#336-open-renewal-opps-closing-this-month)
  - [3.37. Open Renewal Opps Closing Within 90 Days](#337-open-renewal-opps-closing-within-90-days)
  - [3.38. Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
  - [3.39. Opportunities Closing Next Month](#339-opportunities-closing-next-month)
  - [3.40. Opportunities Closing This Month](#340-opportunities-closing-this-month)
  - [3.41. Opportunities Closing This Week](#341-opportunities-closing-this-week)
  - [3.42. Opportunities Created This Year](#342-opportunities-created-this-year)
  - [3.43. Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
  - [3.44. Opportunities Opened Last Week](#344-opportunities-opened-last-week)
  - [3.45. Opportunities Opened This Month](#345-opportunities-opened-this-month)
  - [3.46. Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
  - [3.47. Opportunities Opened This Week](#347-opportunities-opened-this-week)
  - [3.48. Opportunities Opened This Week](#348-opportunities-opened-this-week)
  - [3.49. Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
  - [3.50. Opportunity Associated View](#350-opportunity-associated-view)
  - [3.51. Opportunity Lookup View](#351-opportunity-lookup-view)
  - [3.52. Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
  - [3.53. Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
  - [3.54. Quick Find Open Opportunities](#354-quick-find-open-opportunities)
  - [3.55. Recent Opportunities](#355-recent-opportunities)
  - [3.56. Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
  - [3.57. Upcoming Internet Renewals](#357-upcoming-internet-renewals)
  - [3.58. Won Opportunities This Month](#358-won-opportunities-this-month)
  - [3.59. Won Opportunities This Quarter](#359-won-opportunities-this-quarter)
  - [3.60. Won Opportunities This Week](#360-won-opportunities-this-week)
  - [3.61. Won Opportunities This Year](#361-won-opportunities-this-year)
  - [3.62. Won Opportunities](#362-won-opportunities)
  - [3.63. Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
  - [3.64. Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
  - [3.65. Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [4. Chart Visualizations](#4-chart-visualizations)
  - [4.1. Closing This Fiscal Year](#41-closing-this-fiscal-year)
  - [4.2. Closing this Fiscal Quarter](#42-closing-this-fiscal-quarter)
  - [4.3. Closing This Month](#43-closing-this-month)
  - [4.4. Initial/Add-on Opened This Month](#44-initialadd-on-opened-this-month)
  - [4.5. Initial/Add-on Opportunities Added Last Week](#45-initialadd-on-opportunities-added-last-week)
  - [4.6. Initial/Add-on Added This Week](#46-initialadd-on-added-this-week)
  - [4.7. Invoiced but Unpaid in Last 90 Days](#47-invoiced-but-unpaid-in-last-90-days)
  - [4.8. Won This Fiscal Year](#48-won-this-fiscal-year)
  - [4.9. Won This Year (No Renewals)](#49-won-this-year-no-renewals)
  - [4.10. Opportunities Opened This Quarter By Rep](#410-opportunities-opened-this-quarter-by-rep)
  - [4.11. Won Opportunities This Quarter By Rep](#411-won-opportunities-this-quarter-by-rep)
  - [4.12. My Opportunities Created This Quarter](#412-my-opportunities-created-this-quarter)
  - [4.13. My Opportunities Closing This Quarter](#413-my-opportunities-closing-this-quarter)
  - [4.14. My Opportunities Won This Quarter](#414-my-opportunities-won-this-quarter)
  - [4.15. My Opportunities Created This Year By Quarter](#415-my-opportunities-created-this-year-by-quarter)
  - [4.16. My Open Opportunities Created This Year By Quarter](#416-my-open-opportunities-created-this-year-by-quarter)
  - [4.17. My Won Opportunities This Year By Quarter](#417-my-won-opportunities-this-year-by-quarter)
  - [4.18. Opportunities Created This Year By Owner](#418-opportunities-created-this-year-by-owner)
  - [4.19. Open Opportunities By Owner](#419-open-opportunities-by-owner)
  - [4.20. Won Opportunities This Year By Owner](#420-won-opportunities-this-year-by-owner)
  - [4.21. Sales Pipeline](#421-sales-pipeline)
  - [4.22. Opportunities Opened This Month By Rep](#422-opportunities-opened-this-month-by-rep)
  - [4.23. Opportunities Closing This Month](#423-opportunities-closing-this-month)
  - [4.24. Won Opportunities This Month](#424-won-opportunities-this-month)
  - [4.25. Opportunities Opened This Week By Rep](#425-opportunities-opened-this-week-by-rep)
  - [4.26. Opportunities Closing This Week By Rep](#426-opportunities-closing-this-week-by-rep)
  - [4.27. Won Opportunities This Week](#427-won-opportunities-this-week)
  - [4.28. My Opportunities Created This Week](#428-my-opportunities-created-this-week)
  - [4.29. My Opportunities Closing This Week](#429-my-opportunities-closing-this-week)
  - [4.30. My Open Opportunities Created This Month](#430-my-open-opportunities-created-this-month)
  - [4.31. My Opportunities Closing This Month](#431-my-opportunities-closing-this-month)
  - [4.32. Open Renewal Opps Close Date Last Month](#432-open-renewal-opps-close-date-last-month)
  - [4.33. Open Renewal Opps Closing This Month](#433-open-renewal-opps-closing-this-month)
  - [4.34. Open Renewal Opps Closing Next Month](#434-open-renewal-opps-closing-next-month)
  - [4.35. Open Renewal Opps Closing Within 90 Days](#435-open-renewal-opps-closing-within-90-days)
  - [4.36. Open Renewal Opps 90 Days Past Due](#436-open-renewal-opps-90-days-past-due)
  - [4.37. Won Renewal Opps This Month](#437-won-renewal-opps-this-month)
  - [4.38. Won Renewal Opps This Quarter](#438-won-renewal-opps-this-quarter)
  - [4.39. Won Renewal Opps This Year](#439-won-renewal-opps-this-year)
- [5. Reports](#5-reports)
- [6. Dashboards](#6-dashboards)
  - [6.1. Client Relations Renewal Dashboard](#61-client-relations-renewal-dashboard)
  - [6.2. Executive Sales Measurement Pipeline](#62-executive-sales-measurement-pipeline)
  - [6.3. Monthly Account Manager KPIs](#63-monthly-account-manager-kpis)
  - [6.4. My Annual KPIs](#64-my-annual-kpis)
  - [6.5. My Monthly KPI's](#65-my-monthly-kpis)
  - [6.6. My Pipeline Dashboard](#66-my-pipeline-dashboard)
  - [6.7. My Quarterly KPIs](#67-my-quarterly-kpis)
  - [6.8. My Weekly KPIs](#68-my-weekly-kpis)
  - [6.9. Quarterly Account Manager KPIs](#69-quarterly-account-manager-kpis)
  - [6.10. Sales Activity Social Dashboard](#610-sales-activity-social-dashboard)
  - [6.11. Weekly Account Manager KPIs](#611-weekly-account-manager-kpis)
- [7. Workflows](#7-workflows)
  - [7.1. 0ChangeQuoteRecordOwner](#71-0changequoterecordowner)
  - [7.2. 0EngagementNames](#72-0engagementnames)
  - [7.3. AccountAuto-Assign](#73-accountauto-assign)
  - [7.4. AllocationsAssigntoTeam](#74-allocationsassigntoteam)
  - [7.5. AppointmentAuto-Assign](#75-appointmentauto-assign)
  - [7.6. BatchConverttoLead](#76-batchconverttolead)
  - [7.7. BatchCreateEngagements](#77-batchcreateengagements)
  - [7.8. BatchLooseOpportunities](#78-batchlooseopportunities)
  - [7.9. BatchOpportunityTransfer](#79-batchopportunitytransfer)
  - [7.10. BulkChangeLeadSource](#710-bulkchangeleadsource)
  - [7.11. CasePendingAssignmentNotification](#711-casependingassignmentnotification)
  - [7.12. CaseRecordOwner](#712-caserecordowner)
  - [7.13. CaseRecordOwnerAssign](#713-caserecordownerassign)
  - [7.14. CaseRecordOwnerAssignmentNotification](#714-caserecordownerassignmentnotification)
  - [7.15. CaseResolutionNotificationEmail](#715-caseresolutionnotificationemail)
  - [7.16. CloneAndDeleteQuote](#716-cloneanddeletequote)
  - [7.17. CloneCommissionPayment](#717-clonecommissionpayment)
  - [7.18. CloneLicense](#718-clonelicense)
  - [7.19. CloneOpportunity](#719-cloneopportunity)
  - [7.20. CloneOrder](#720-cloneorder)
  - [7.21. ContactAuto-Assign](#721-contactauto-assign)
  - [7.22. CreateLeadFromLeadGen](#722-createleadfromleadgen)
  - [7.23. CreateLeadfromAccount](#723-createleadfromaccount)
  - [7.24. CreateSoftwareLicense](#724-createsoftwarelicense)
  - [7.25. CustomLeadCreation](#725-customleadcreation)
  - [7.26. EmailDeleteSendQuoteDrafts](#726-emaildeletesendquotedrafts)
  - [7.27. EmailRemoveUnsentEmails](#727-emailremoveunsentemails)
  - [7.28. EngagementRecordOwner](#728-engagementrecordowner)
  - [7.29. EngagementRecordOwnerTeam](#729-engagementrecordownerteam)
  - [7.30. FSRLeadDistibutionNotification](#730-fsrleaddistibutionnotification)
  - [7.31. InvoiceRecordOwner](#731-invoicerecordowner)
  - [7.32. LeadAssignment](#732-leadassignment)
  - [7.33. LeadPopulateFirstNamefromContact](#733-leadpopulatefirstnamefromcontact)
  - [7.34. LeadQualifyDisqualifyDate](#734-leadqualifydisqualifydate)
  - [7.35. LeadSourceChange](#735-leadsourcechange)
  - [7.36. LeadTempPopulatefirstlastnamefromcontact](#736-leadtemppopulatefirstlastnamefromcontact)
  - [7.37. NewFSRLeadNotification](#737-newfsrleadnotification)
  - [7.38. OpportunityAuditRemoval](#738-opportunityauditremoval)
  - [7.39. OpportunityRecordOwner](#739-opportunityrecordowner)
  - [7.40. OpportunityRecordOwnerTeam](#740-opportunityrecordownerteam)
  - [7.41. OpportunitySalesProcessAdvanceBPF](#741-opportunitysalesprocessadvancebpf)
  - [7.42. OrderRecordOwner](#742-orderrecordowner)
  - [7.43. PhonecallAuto-Assign](#743-phonecallauto-assign)
  - [7.44. PrintPurchaseAssigntoTeam](#744-printpurchaseassigntoteam)
  - [7.45. QualifyLead](#745-qualifylead)
  - [7.46. QuoteRecordOwner](#746-quoterecordowner)
  - [7.47. QuoteRecordOwnerTeam](#747-quoterecordownerteam)
  - [7.48. RenameEngagements](#748-renameengagements)
  - [7.49. SendQuote](#749-sendquote)
  - [7.50. SetDefaultPriceListonOpportunities](#750-setdefaultpricelistonopportunities)
  - [7.51. SetLeadTemperature](#751-setleadtemperature)
  - [7.52. SoftwareLicenseAssigntoTeam](#752-softwarelicenseassigntoteam)
  - [7.53. SoftwareLicenseCreateEngagement](#753-softwarelicensecreateengagement)
  - [7.54. SoftwareLicenseSetOwner](#754-softwarelicensesetowner)
  - [7.55. TaskAuto-Assign](#755-taskauto-assign)
  - [7.56. TaskCreateReorderLead](#756-taskcreatereorderlead)
  - [7.57. TempSetDefaultPricelist](#757-tempsetdefaultpricelist)
  - [7.58. WonOpportunityEmail](#758-wonopportunityemail)
  - [7.59. WorkforceAccountAuto-assign](#759-workforceaccountauto-assign)
  - [7.60. WorkforceAppointmentAuto-Assign](#760-workforceappointmentauto-assign)
  - [7.61. WorkforceCaseAuto-assign](#761-workforcecaseauto-assign)
  - [7.62. WorkforceContactAuto-assign](#762-workforcecontactauto-assign)
  - [7.63. WorkforceEngagementAuto-assign](#763-workforceengagementauto-assign)
  - [7.64. WorkforceLeadAuto-Assign](#764-workforceleadauto-assign)
  - [7.65. WorkforceOpportunityAuto-assign](#765-workforceopportunityauto-assign)
  - [7.66. WorkforcePhone-callAuto-assign](#766-workforcephone-callauto-assign)
  - [7.67. WorkforceQuoteAuto-assign](#767-workforcequoteauto-assign)
  - [7.68. iGradAppointmentAuto-Assign](#768-igradappointmentauto-assign)
  - [7.69. iGradCaseAuto-Assign](#769-igradcaseauto-assign)
  - [7.70. iGradPhone-callAuto-assign](#770-igradphone-callauto-assign)
- [8. JavaScript Web Resources](#8-javascript-web-resources)
  - [8.1. azt_accountlibrary](#81-azt_accountlibrary)
  - [8.2. azt_addresslibrary](#82-azt_addresslibrary)
  - [8.3. azt_caselibrary](#83-azt_caselibrary)
  - [8.4. azt_createsoftwarelicense](#84-azt_createsoftwarelicense)
  - [8.5. azt_engagementlibrary](#85-azt_engagementlibrary)
  - [8.6. azt_expensereportlibrary](#86-azt_expensereportlibrary)
  - [8.7. azt_invoicelibrary](#87-azt_invoicelibrary)
  - [8.8. azt_leadlibrary](#88-azt_leadlibrary)
  - [8.9. azt_opportunityclone](#89-azt_opportunityclone)
  - [8.10. azt_opportunitylibrary](#810-azt_opportunitylibrary)
  - [8.11. azt_opportunitytrackdiscount](#811-azt_opportunitytrackdiscount)
  - [8.12. azt_orderlibrary](#812-azt_orderlibrary)
  - [8.13. azt_productdiscountlibrary](#813-azt_productdiscountlibrary)
  - [8.14. azt_quotelibrary](#814-azt_quotelibrary)
  - [8.15. azt_sendquote](#815-azt_sendquote)
- [9. Formulas & Rollups](#9-formulas-rollups)
- [10. Plugin Source Code Analysis](#10-plugin-source-code-analysis)
  - [10.1. AccountAutoAssign](#101-accountautoassign)
  - [10.2. AccountLeadGen](#102-accountleadgen)
  - [10.3. AccountLeadGenAssociate](#103-accountleadgenassociate)
  - [10.4. AccountReassignmentShareRecords](#104-accountreassignmentsharerecords)
  - [10.5. AccountTypeSet](#105-accounttypeset)
  - [10.6. ActivateOrReviseQuote](#106-activateorrevisequote)
  - [10.7. ActivitiesCreatedDueDatesInPast](#107-activitiescreatedduedatesinpast)
  - [10.8. ActivityCloseForceRecordOwner](#108-activitycloseforcerecordowner)
  - [10.9. ActivityRegardingGetState](#109-activityregardinggetstate)
  - [10.10. AddressSearchCleanupFields](#1010-addresssearchcleanupfields)
  - [10.11. AllocationValidation](#1011-allocationvalidation)
  - [10.12. AutoAssignStateAbb](#1012-autoassignstateabb)
  - [10.13. AutoNumber](#1013-autonumber)
  - [10.14. CaseAudit](#1014-caseaudit)
  - [10.15. CaseClose](#1015-caseclose)
  - [10.16. ChangeLicenseType](#1016-changelicensetype)
  - [10.17. CloneExpenseLine](#1017-cloneexpenseline)
  - [10.18. CompGoalCreate](#1018-compgoalcreate)
  - [10.19. ContactSetConnectionRole](#1019-contactsetconnectionrole)
  - [10.20. CreateCompGoals](#1020-createcompgoals)
  - [10.21. CreateSoftwareLicenses](#1021-createsoftwarelicenses)
  - [10.22. CreateUserGoals](#1022-createusergoals)
  - [10.23. DiscretionaryDiscountSetHeader](#1023-discretionarydiscountsetheader)
  - [10.24. EngagementFSRAssignedOn](#1024-engagementfsrassignedon)
  - [10.25. EngagementSetEndDate](#1025-engagementsetenddate)
  - [10.26. ExpenseLineTotals](#1026-expenselinetotals)
  - [10.27. ExpenseRestrictVisibility](#1027-expenserestrictvisibility)
  - [10.28. FundingSetAnnualSpend](#1028-fundingsetannualspend)
  - [10.29. FundingTotalAmt](#1029-fundingtotalamt)
  - [10.30. FundingYearSync](#1030-fundingyearsync)
  - [10.31. GetAcctTeamOwned](#1031-getacctteamowned)
  - [10.32. GetUserHasRole](#1032-getuserhasrole)
  - [10.33. GetUserHasRoleToAction](#1033-getuserhasroletoaction)
  - [10.34. InvoiceClosePaidOnPercentage](#1034-invoiceclosepaidonpercentage)
  - [10.35. InvoiceCompCompleted](#1035-invoicecompcompleted)
  - [10.36. LeadImport](#1036-leadimport)
  - [10.37. LeadImportPopulateName](#1037-leadimportpopulatename)
  - [10.38. LeadQualify](#1038-leadqualify)
  - [10.39. LeadQualifyParentStakeholderContacts](#1039-leadqualifyparentstakeholdercontacts)
  - [10.40. ManualDiscountKill](#1040-manualdiscountkill)
  - [10.41. OppAuditRemoval](#1041-oppauditremoval)
  - [10.42. OpportunityAssignFromLead](#1042-opportunityassignfromlead)
  - [10.43. OpportunityAudit](#1043-opportunityaudit)
  - [10.44. OpportunityClone](#1044-opportunityclone)
  - [10.45. OpportunityLastActivityDate](#1045-opportunitylastactivitydate)
  - [10.46. OpportunityLineSyncToQuote](#1046-opportunitylinesynctoquote)
  - [10.47. OpportunityPreventCreateQuote](#1047-opportunitypreventcreatequote)
  - [10.48. OpportunityProbabilityChange](#1048-opportunityprobabilitychange)
  - [10.49. OpportunityProbabilityNumber](#1049-opportunityprobabilitynumber)
  - [10.50. OpptyToQuoteFieldMappings](#1050-opptytoquotefieldmappings)
  - [10.51. OrderClone](#1051-orderclone)
  - [10.52. OrderFSRSetTemplateFields](#1052-orderfsrsettemplatefields)
  - [10.53. OrderLinePopulateLicType](#1053-orderlinepopulatelictype)
  - [10.54. OrderLinePopulateTemplateFields](#1054-orderlinepopulatetemplatefields)
  - [10.55. OrderManuallyCreateSoftwareLicense](#1055-ordermanuallycreatesoftwarelicense)
  - [10.56. OrderSplit](#1056-ordersplit)
  - [10.57. OrderStageTracking](#1057-orderstagetracking)
  - [10.58. PaymentUpdate](#1058-paymentupdate)
  - [10.59. PhonecallCreateCallback](#1059-phonecallcreatecallback)
  - [10.60. ProductDiscountPreventOnActiveQuote](#1060-productdiscountpreventonactivequote)
  - [10.61. QuoteCloneAndDelete](#1061-quotecloneanddelete)
  - [10.62. QuoteLinesSyncToOppty](#1062-quotelinessynctooppty)
  - [10.63. QuoteOrderProductsTrackDiscount](#1063-quoteorderproductstrackdiscount)
  - [10.64. QuotePreventActivateUnapprovedDiscounts](#1064-quotepreventactivateunapproveddiscounts)
  - [10.65. QuotePreventActivateUnapprovedFreight](#1065-quotepreventactivateunapprovedfreight)
  - [10.66. QuoteSyncTotalToOpportunity](#1066-quotesynctotaltoopportunity)
  - [10.67. RecordOwnerRestrictEdit](#1067-recordownerrestrictedit)
  - [10.68. RestrictCreateQuote](#1068-restrictcreatequote)
  - [10.69. RestrictProductLookups](#1069-restrictproductlookups)
  - [10.70. RestrictWinOpportunities](#1070-restrictwinopportunities)
  - [10.71. RestrictWinQuote](#1071-restrictwinquote)
  - [10.72. ReviseQuoteDiscountMove](#1072-revisequotediscountmove)
  - [10.73. SendQuoteReport](#1073-sendquotereport)
  - [10.74. SetOppProductDefaults](#1074-setoppproductdefaults)
  - [10.75. SetPrimaryContact](#1075-setprimarycontact)
  - [10.76. ShareBasedOnAccessTeam](#1076-sharebasedonaccessteam)
  - [10.77. ShareFromAccountShares](#1077-sharefromaccountshares)
  - [10.78. ShareWithAccountOwner](#1078-sharewithaccountowner)
  - [10.79. ShipmentSetTrackingNumber](#1079-shipmentsettrackingnumber)
  - [10.80. UpdateOppFromQuote](#1080-updateoppfromquote)
  - [10.81. Utility](#1081-utility)
- [11. PCF Controls](#11-pcf-controls)
- [12. Relationships](#12-relationships)
- [13. Ribbon Customizations](#13-ribbon-customizations)
- [14. Conflicts & Observations](#14-conflicts-observations)
- [Index](#index)

---

## <a id="1-field-definitions"></a>1. Field Definitions

Total fields: **442**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [!process_custom_attribute_url_](#index-process_custom_attribute_url_) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 2 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) |  |  |  | No |  | true |  |  |  |  |  |  |  | [7](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 3 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) |  |  |  | No |  | true |  |  |  |  |  |  |  | [7](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 4 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) |  |  |  | No |  | true |  |  |  |  |  |  |  | [12](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 5 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_composite](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_composite) |  |  |  | No |  | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 6 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) |  |  |  | No |  | true |  |  |  |  |  |  |  | [14](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 7 | [a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket](#index-a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket) |  |  |  | No |  | true |  |  |  |  |  |  |  | [3](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.ownerid](#index-a_ef7baa35fe04e911a94d000d3a3b9f01ownerid) |  |  |  | No |  | true |  |  |  |  |  |  |  | [2](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 9 | [accountid](#index-accountid) |  |  |  | No |  | true |  |  |  | Opportunity | AccountId | AccountId |  |  |  |  |  |  |  | [12](#10-plugin-source-code-analysis) |  |  |  |  |
| 10 | [actioncards](#index-actioncards) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 11 | [activities](#index-activities) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 12 | [activityid](#index-activityid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 13 | [activitytypecode](#index-activitytypecode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 14 | [actualclosedate](#index-actualclosedate) |  |  |  | No |  | true |  |  |  | Opportunity | CloseDate | CloseDate | [2](#2-forms) | [27](#3-views) | [5](#4-chart-visualizations) |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 15 | [actualvalue](#index-actualvalue) |  |  |  | No |  | true |  |  |  |  |  |  |  | [15](#3-views) | [2](#4-chart-visualizations) |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 16 | [actualvalue_base](#index-actualvalue_base) |  |  |  | No |  | true |  |  |  |  |  |  |  | [2](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 17 | [address1_city](#index-address1_city) |  |  |  | No |  | true |  |  |  |  |  |  |  | [19](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 18 | [address1_composite](#index-address1_composite) |  |  |  | No |  | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 19 | [address1_stateorprovince](#index-address1_stateorprovince) |  |  |  | No |  | true |  |  |  |  |  |  |  | [21](#3-views) |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 20 | [address1_telephone1](#index-address1_telephone1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 21 | [adx_resolutiondate](#index-adx_resolutiondate) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 22 | [amountdatatype](#index-amountdatatype) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 23 | [annotationid](#index-annotationid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 24 | [azt_account](#index-azt_account) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 25 | [azt_accountclassification](#index-azt_accountclassification) | Account Classification | picklist | 276530000: A, 276530001: B, 276530002: C, 100000001: D, 100000000: E, 276530003: S, 276530004: N/A | Yes | none | true | Opportunity | CRM Account Classification | CRM_Account_Classification__c |  |  |  | [2](#2-forms) | [9](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 26 | [azt_accountid](#index-azt_accountid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 27 | [azt_accountleadgenerationid](#index-azt_accountleadgenerationid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 28 | [azt_accountleadgenname](#index-azt_accountleadgenname) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 29 | [azt_accounttype](#index-azt_accounttype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 30 | [azt_addonopportunitytotal](#index-azt_addonopportunitytotal) | Add-On Opportunity Total | money |  | Yes | none | true | Opportunity | CRM Add On Opportunity Total | CRM_Add_On_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 31 | [azt_addonopportunitytotal_base](#index-azt_addonopportunitytotal_base) | Add-On Opportunity Total (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 32 | [azt_addresssearch](#index-azt_addresssearch) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 33 | [azt_addresssearch2](#index-azt_addresssearch2) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 34 | [azt_addtocrtqueue](#index-azt_addtocrtqueue) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 35 | [azt_ageendedstage](#index-azt_ageendedstage) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 36 | [azt_allocatedtoid](#index-azt_allocatedtoid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 37 | [azt_allocationtype](#index-azt_allocationtype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 38 | [azt_amount](#index-azt_amount) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 39 | [azt_annualspend](#index-azt_annualspend) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 40 | [azt_approvalstatus](#index-azt_approvalstatus) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [1](#9-formulas-rollups) | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 41 | [azt_assignedamid](#index-azt_assignedamid) | Assigned AM | lookup |  | Yes | none | true | Opportunity | CRM Assigned AM | CRM_Assigned_AM__c |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 42 | [azt_autocreatecallback](#index-azt_autocreatecallback) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 43 | [azt_autonumberid](#index-azt_autonumberid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 44 | [azt_azteccustomerid](#index-azt_azteccustomerid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 45 | [azt_bookingurl](#index-azt_bookingurl) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 46 | [azt_callbackin](#index-azt_callbackin) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 47 | [azt_callbackon](#index-azt_callbackon) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 48 | [azt_caseid](#index-azt_caseid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 49 | [azt_commissionamount](#index-azt_commissionamount) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 50 | [azt_commissionid](#index-azt_commissionid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 51 | [azt_commissionpaymentid](#index-azt_commissionpaymentid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 52 | [azt_committoestimatedclose](#index-azt_committoestimatedclose) | Commit to Pipeline? | bit | 1: Yes, 0: No | Yes | none | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 53 | [azt_companyname](#index-azt_companyname) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 54 | [azt_compcompleted](#index-azt_compcompleted) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 55 | [azt_compgoalid](#index-azt_compgoalid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 56 | [azt_compgoaltypeid](#index-azt_compgoaltypeid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 57 | [azt_compplanamountid](#index-azt_compplanamountid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 58 | [azt_concurrentusers](#index-azt_concurrentusers) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 59 | [azt_copydescription](#index-azt_copydescription) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 60 | [azt_copysubject](#index-azt_copysubject) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 61 | [azt_currentnumber](#index-azt_currentnumber) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 62 | [azt_customerid](#index-azt_customerid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 63 | [azt_customertrainingid](#index-azt_customertrainingid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 64 | [azt_dateexitedstage](#index-azt_dateexitedstage) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 65 | [azt_dayssincecreated](#index-azt_dayssincecreated) | Days Since Created | int |  | Yes | none | true |  |  |  |  |  |  | [2](#2-forms) | [3](#3-views) |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 66 | [azt_dayssinceprobabilitychanged](#index-azt_dayssinceprobabilitychanged) | Days Since Probability Changed | int |  | Yes | none | true | Opportunity | CRM Days Since Probability Changed | CRM_Days_Since_Probability_Changed__c |  |  |  | [2](#2-forms) | [4](#3-views) |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 67 | [azt_defaultfreightamount](#index-azt_defaultfreightamount) | Default Freight Amount | money |  | Yes | none | true | Opportunity | CRM Default Freight Amount | CRM_Default_Freight_Amount__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 68 | [azt_defaultfreightamount_base](#index-azt_defaultfreightamount_base) | Default Freight Amount (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 69 | [azt_deliverytype](#index-azt_deliverytype) | Delivery Type | picklist | 276530000: Internet, 276530001: LAN, 276530002: Print, 276530003: LAN & Print, 276530004: Internet & Print, 276530005: Internet Year 2, 276530006: Internet Year 3+, 276530007: SA, 276530008: WAN | Yes | none | true | Opportunity | CRM Delivery Type | CRM_Delivery_Type__c |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 70 | [azt_description](#index-azt_description) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 71 | [azt_discountamount](#index-azt_discountamount) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [1](#9-formulas-rollups) | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 72 | [azt_discretionarydiscount](#index-azt_discretionarydiscount) | Discretionary Discount | money |  | Yes | none | true | Opportunity | CRM Discretionary Discount | CRM_Discretionary_Discount__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 73 | [azt_discretionarydiscount_base](#index-azt_discretionarydiscount_base) | Discretionary Discount (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 74 | [azt_discretionarydiscountamt](#index-azt_discretionarydiscountamt) | Discretionary Discount Amt | money |  | Yes | none | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 75 | [azt_discretionarydiscountamt_base](#index-azt_discretionarydiscountamt_base) | Discretionary Discount Amt (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 76 | [azt_duedate](#index-azt_duedate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 77 | [azt_effectivedate](#index-azt_effectivedate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 78 | [azt_email](#index-azt_email) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 79 | [azt_enddate](#index-azt_enddate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 80 | [azt_engagementid](#index-azt_engagementid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 81 | [azt_estfulfillmentdate](#index-azt_estfulfillmentdate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 82 | [azt_evaluate](#index-azt_evaluate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 83 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | Expected Renewal Value | money |  | Yes | none | true |  |  |  |  |  |  | [2](#2-forms) | [8](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 84 | [azt_expectedrenewalvalue_base](#index-azt_expectedrenewalvalue_base) | Expected Renewal Value (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 85 | [azt_expenseamount](#index-azt_expenseamount) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 86 | [azt_expenseid](#index-azt_expenseid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 87 | [azt_expensereportid](#index-azt_expensereportid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 88 | [azt_expensetype](#index-azt_expensetype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 89 | [azt_expirationdate](#index-azt_expirationdate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 90 | [azt_extension](#index-azt_extension) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 91 | [azt_fieldtoautonumber](#index-azt_fieldtoautonumber) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 92 | [azt_firstname](#index-azt_firstname) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 93 | [azt_fiscalperiodend](#index-azt_fiscalperiodend) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 94 | [azt_fiscalperiodstart](#index-azt_fiscalperiodstart) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 95 | [azt_freightamtapproved](#index-azt_freightamtapproved) | Freight Amt Approved? | bit | 1: Yes, 0: No | Yes | none | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 96 | [azt_fsrassignedon](#index-azt_fsrassignedon) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 97 | [azt_fsremail](#index-azt_fsremail) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 98 | [azt_fsrid](#index-azt_fsrid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 99 | [azt_fsrmobiletelephone](#index-azt_fsrmobiletelephone) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 100 | [azt_fsrtelephone](#index-azt_fsrtelephone) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 101 | [azt_fsrtelephoneextension](#index-azt_fsrtelephoneextension) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 102 | [azt_fundingid](#index-azt_fundingid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 103 | [azt_fundingsource](#index-azt_fundingsource) | Funding Source | picklist | 276530000: Annual Budget, 276530001: Discretionary Budget, 276530002: Grant - Federal, 276530003: Grant - Private, 276530004: Grant - State, 276530005: Grant - Perkins, 276530006: Title 1 Funds, 276530007: Other, 276530008: Use or Lose Funds | Yes | none | true | Opportunity | Funding Source | Funding_Source__c |  |  |  | [4](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 104 | [azt_fundingyear](#index-azt_fundingyear) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 105 | [azt_goaltype](#index-azt_goaltype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 106 | [azt_historicalowner](#index-azt_historicalowner) | Historical Owner | nvarchar |  | Yes | none | true | Opportunity | CRM Historical Owner | CRM_Historical_Owner__c |  |  |  |  |  |  |  |  | [3](#7-workflows) |  |  |  |  |  |  |
| 107 | [azt_importname](#index-azt_importname) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 108 | [azt_initialopportunitytotal](#index-azt_initialopportunitytotal) | Initial Opportunity Total | money |  | Yes | none | true | Opportunity | CRM Initial Opportunity Total | CRM_Initial_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 109 | [azt_initialopportunitytotal_base](#index-azt_initialopportunitytotal_base) | Initial Opportunity Total (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 110 | [azt_internalaztecnotes](#index-azt_internalaztecnotes) | Internal Aztec Notes | ntext |  | Yes | none | true | Opportunity | CRM Internal Aztec Notes | CRM_Internal_Aztec_Notes__c |  |  |  | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 111 | [azt_invoiceid](#index-azt_invoiceid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [10](#10-plugin-source-code-analysis) |  |  |  |  |
| 112 | [azt_invoicenumber](#index-azt_invoicenumber) | Invoice Number | nvarchar |  | Yes | none | false | Opportunity | CRM Invoice Number | CRM_Invoice_Number__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 113 | [azt_invoiceproductid](#index-azt_invoiceproductid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 114 | [azt_isbn](#index-azt_isbn) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 115 | [azt_iscompanion](#index-azt_iscompanion) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 116 | [azt_iscrossselloppty](#index-azt_iscrossselloppty) | Is Cross-sell Oppty? | bit | 1: Yes, 0: No | Yes | none | true | Opportunity | Cross-Sell | Cross_Sell__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 117 | [azt_isprint](#index-azt_isprint) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 118 | [azt_issaas](#index-azt_issaas) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 119 | [azt_jobrole](#index-azt_jobrole) |  |  |  | Yes |  | true |  |  |  |  |  |  |  | [20](#3-views) | [1](#4-chart-visualizations) |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 120 | [azt_jobtitle](#index-azt_jobtitle) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 121 | [azt_lastactivitydate](#index-azt_lastactivitydate) | Last Activity Date | datetime |  | Yes | none | true | Opportunity | Legacy Last Activity Date | Legacy_Last_Activity_Date__c |  |  |  | [2](#2-forms) | [1](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 122 | [azt_lastmodifiedbyid](#index-azt_lastmodifiedbyid) | Last Modified By | lookup |  | Yes | none | true | Opportunity | Legacy Modified By | Legacy_Modified_By__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 123 | [azt_lastname](#index-azt_lastname) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 124 | [azt_leadimportid](#index-azt_leadimportid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 125 | [azt_leadsource](#index-azt_leadsource) | Lead Source (Old) | picklist |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 126 | [azt_leadsourceid](#index-azt_leadsourceid) | Lead Source | lookup |  | Yes | none | true | Opportunity | CRM Lead Source | CRM_Lead_Source__c |  |  |  | [1](#2-forms) | [1](#3-views) |  |  |  | [8](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 127 | [azt_licensestatus](#index-azt_licensestatus) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 128 | [azt_licenseterm](#index-azt_licenseterm) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 129 | [azt_licensetermmonths](#index-azt_licensetermmonths) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [22](#10-plugin-source-code-analysis) |  |  |  |  |
| 130 | [azt_licensetype](#index-azt_licensetype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [7](#9-formulas-rollups) | [25](#10-plugin-source-code-analysis) |  |  |  |  |
| 131 | [azt_masecommission](#index-azt_masecommission) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 132 | [azt_mileage](#index-azt_mileage) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 133 | [azt_monthstofilteron](#index-azt_monthstofilteron) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 134 | [azt_name](#index-azt_name) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [18](#10-plugin-source-code-analysis) |  |  |  |  |
| 135 | [azt_newestclosedate](#index-azt_newestclosedate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 136 | [azt_newestimatedvalue](#index-azt_newestimatedvalue) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 137 | [azt_newownerid](#index-azt_newownerid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 138 | [azt_newprobability](#index-azt_newprobability) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 139 | [azt_nonsaasstatus](#index-azt_nonsaasstatus) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 140 | [azt_nonsaastype](#index-azt_nonsaastype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 141 | [azt_numberoflicenses](#index-azt_numberoflicenses) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 142 | [azt_opportunityauditrecordid](#index-azt_opportunityauditrecordid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 143 | [azt_opportunityid](#index-azt_opportunityid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  | [3](#12-relationships) |  |  |
| 144 | [azt_opportunityleadid](#index-azt_opportunityleadid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 145 | [azt_opportunitynumber](#index-azt_opportunitynumber) | Opp# | nvarchar |  | Yes | none | true | Opportunity | CRM Opportunity Number | CRM_Opportunity_Number__c |  |  |  | [2](#2-forms) | [7](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 146 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | Opportunity Product Category | picklist | 276530000: P12 & Legacy, 276530001: Kaplan Book, 276530002: GED Flash, 276530003: P12 Prep, 276530004: Legacy, 276530005: APT - Free, 276530006: APT - Paid, 276530007: OPT - Free, 276530008: OPT - Paid, 276530009: Workbooks, 276530010: LSE Booklets | Yes | none | true | Opportunity | CRM Opportunity Product Category | CRM_Opportunity_Product_Category__c |  |  |  | [2](#2-forms) | [25](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 147 | [azt_opportunityproductid](#index-azt_opportunityproductid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [10](#10-plugin-source-code-analysis) |  |  |  |  |
| 148 | [azt_opportunitytype](#index-azt_opportunitytype) | Opportunity Type | picklist | 276530005: Renewal, 276530004: Initial, 276530002: Print, 276530003: Add-On, 276530001: Vouchers, 276530000: Pilot, 276530008: Professional Development, 276530006: Monthly, 100000000: Win Back, 327630000: Sample, 100000001: PA, 276530007: Other, 327630001: Add On - Reseller | Yes | none | true | Opportunity | Type | Type |  |  |  | [4](#2-forms) | [57](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 149 | [azt_orderid](#index-azt_orderid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 150 | [azt_orderlineid](#index-azt_orderlineid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 151 | [azt_orderproductid](#index-azt_orderproductid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 152 | [azt_orderstageid](#index-azt_orderstageid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 153 | [azt_ordertemplatelines](#index-azt_ordertemplatelines) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 154 | [azt_ordertype](#index-azt_ordertype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 155 | [azt_originatingleadimportid](#index-azt_originatingleadimportid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 156 | [azt_otheropportunitytotal](#index-azt_otheropportunitytotal) | Other Opportunity Total | money |  | Yes | none | true | Opportunity | CRM Other Opportunity Total | CRM_Other_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 157 | [azt_otheropportunitytotal_base](#index-azt_otheropportunitytotal_base) | Other Opportunity Total (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 158 | [azt_paid](#index-azt_paid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 159 | [azt_paidon](#index-azt_paidon) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 160 | [azt_parentopportunityid](#index-azt_parentopportunityid) | Parent Opportunity | lookup |  | Yes | none | true | Opportunity | CRM Parent Opportunity Name | CRM_Parent_Opportunity_Name__c |  |  |  |  |  |  |  |  | [1](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 161 | [azt_parentorderid](#index-azt_parentorderid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 162 | [azt_payablecommission](#index-azt_payablecommission) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 163 | [azt_paymentdate](#index-azt_paymentdate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 164 | [azt_paymentid](#index-azt_paymentid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 165 | [azt_percentage](#index-azt_percentage) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 166 | [azt_percentagepaid](#index-azt_percentagepaid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 167 | [azt_periodend](#index-azt_periodend) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 168 | [azt_periodstart](#index-azt_periodstart) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 169 | [azt_phone](#index-azt_phone) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 170 | [azt_pilotopportunitytotal](#index-azt_pilotopportunitytotal) | Pilot Opportunity Total | money |  | Yes | none | true | Opportunity | CRM Pilot Opportunity Total | CRM_Pilot_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 171 | [azt_pilotopportunitytotal_base](#index-azt_pilotopportunitytotal_base) | Pilot Opportunity Total (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 172 | [azt_pipelinestage](#index-azt_pipelinestage) | Pipeline Stage | picklist | 276530000: Identify, 276530001: Qualified, 276530002: Prospecting, 276530003: Cultivating, 276530004: Proposing, 276530005: Closing, 276530006: Delivering, 276530007: Awaiting Payment, 276530008: Won | Yes | none | true | Opportunity | Stage | StageName |  |  |  | [4](#2-forms) | [23](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 173 | [azt_ponumber](#index-azt_ponumber) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 174 | [azt_prefix](#index-azt_prefix) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 175 | [azt_prefixhasseparator](#index-azt_prefixhasseparator) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 176 | [azt_prefixseparator](#index-azt_prefixseparator) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 177 | [azt_prefixseparatorisspace](#index-azt_prefixseparatorisspace) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 178 | [azt_previewcompleted](#index-azt_previewcompleted) | Preview Completed | picklist | 276530000: Yes, 276530001: No | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 179 | [azt_previousestclosedate](#index-azt_previousestclosedate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 180 | [azt_previousestimatedvalue](#index-azt_previousestimatedvalue) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 181 | [azt_previousownerid](#index-azt_previousownerid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 182 | [azt_previousprobability](#index-azt_previousprobability) | Previous Probability | nvarchar |  | Yes | none | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 183 | [azt_printopportunitytotal](#index-azt_printopportunitytotal) | Print Opportunity Total | money |  | Yes | none | true | Opportunity | CRM Print Opportunity Total | CRM_Print_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 184 | [azt_printopportunitytotal_base](#index-azt_printopportunitytotal_base) | Print Opportunity Total (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 185 | [azt_printproductid](#index-azt_printproductid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 186 | [azt_printpurchaseid](#index-azt_printpurchaseid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 187 | [azt_probability](#index-azt_probability) | Probability | picklist | 276530010: 1%, 276530000: 10%, 276530001: 20%, 276530002: 30%, 100000001: 35%, 276530003: 40%, 276530004: 50%, 100000000: 55%, 276530005: 60%, 276530006: 70%, 100530010: 75%, 276530007: 80%, 276530008: 90%, 327630000: 95%, 276530009: 99% | Yes | none | true | Opportunity | CRM Probability | CRM_Probability__c |  |  |  | [4](#2-forms) | [32](#3-views) |  |  |  | [2](#7-workflows) |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 188 | [azt_probabilitychangedon](#index-azt_probabilitychangedon) | Probability Changed On | datetime |  | Yes | none | true | Opportunity | Probability Last Changed | Probability_Last_Changed__c |  |  |  |  | [7](#3-views) |  |  |  |  | [1](#9-formulas-rollups) | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 189 | [azt_probabilityincreased](#index-azt_probabilityincreased) | Probability Increased? | bit | 1: Yes, 0: No | Yes | none | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 190 | [azt_productdiscountid](#index-azt_productdiscountid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [11](#10-plugin-source-code-analysis) |  |  |  |  |
| 191 | [azt_producttype](#index-azt_producttype) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 192 | [azt_purchasedate](#index-azt_purchasedate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 193 | [azt_quantity](#index-azt_quantity) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 194 | [azt_quotenumber](#index-azt_quotenumber) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 195 | [azt_quoteproductid](#index-azt_quoteproductid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [9](#10-plugin-source-code-analysis) |  |  |  |  |
| 196 | [azt_quotesent](#index-azt_quotesent) | Quote Sent | picklist | 276530000: Yes, 276530001: No | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 197 | [azt_reasonforexpense](#index-azt_reasonforexpense) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 198 | [azt_recordowner](#index-azt_recordowner) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 199 | [azt_recordownerid](#index-azt_recordownerid) | Record Owner | lookup |  | Yes | none | true | Opportunity | Record Owner | OwnerId |  |  |  | [6](#2-forms) | [66](#3-views) | [32](#4-chart-visualizations) |  |  | [39](#7-workflows) |  | [9](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 200 | [azt_renewalnotes](#index-azt_renewalnotes) | Renewal Notes | nvarchar |  | Yes | none | true | Opportunity | Renewal Notes | Renewal_Notes__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 201 | [azt_renewalopportunitytotal](#index-azt_renewalopportunitytotal) | Renewal Opportunity Total | money |  | Yes | none | true | Opportunity | CRM Renewal Opportunity Total | CRM_Renewal_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 202 | [azt_renewalopportunitytotal_base](#index-azt_renewalopportunitytotal_base) | Renewal Opportunity Total (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 203 | [azt_reorderopportunityid](#index-azt_reorderopportunityid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 204 | [azt_replacementproductid](#index-azt_replacementproductid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 205 | [azt_requestedfreightamt](#index-azt_requestedfreightamt) | Requested Freight Amt | money |  | Yes | none | true | Opportunity | CRM Requested Freight Amount | CRM_Requested_Freight_Amount__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 206 | [azt_requestedfreightamt_base](#index-azt_requestedfreightamt_base) | Requested Freight Amt (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 207 | [azt_resolvedbyid](#index-azt_resolvedbyid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 208 | [azt_result](#index-azt_result) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 209 | [azt_saas](#index-azt_saas) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 210 | [azt_saasstatus](#index-azt_saasstatus) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 211 | [azt_salesrepid](#index-azt_salesrepid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 212 | [azt_salesstage](#index-azt_salesstage) | Sales Stage | picklist |  | Yes | none | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 213 | [azt_softwarelicenseid](#index-azt_softwarelicenseid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 214 | [azt_softwareproductid](#index-azt_softwareproductid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 215 | [azt_startdate](#index-azt_startdate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 216 | [azt_stateabbreviation](#index-azt_stateabbreviation) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 217 | [azt_stateprovince](#index-azt_stateprovince) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 218 | [azt_suffix](#index-azt_suffix) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 219 | [azt_suffixhasseparator](#index-azt_suffixhasseparator) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 220 | [azt_suffixseparator](#index-azt_suffixseparator) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 221 | [azt_suffixseparatorisspace](#index-azt_suffixseparatorisspace) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 222 | [azt_supportexpirationdate](#index-azt_supportexpirationdate) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 223 | [azt_total](#index-azt_total) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 224 | [azt_totalamountpaid](#index-azt_totalamountpaid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 225 | [azt_totalfunding](#index-azt_totalfunding) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 226 | [azt_totalreimbursement](#index-azt_totalreimbursement) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 227 | [azt_trackingnumber](#index-azt_trackingnumber) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 228 | [azt_trackingnumbers](#index-azt_trackingnumbers) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 229 | [azt_trainingid](#index-azt_trainingid) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 230 | [azt_verticalmarket](#index-azt_verticalmarket) |  |  |  | Yes |  | true |  |  |  |  |  |  |  | [3](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 231 | [azt_webinarpresentationcompleted](#index-azt_webinarpresentationcompleted) | Webinar/Presentation Completed | picklist | 276530000: Yes, 276530001: No | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 232 | [azt_winbackopportunitytotal](#index-azt_winbackopportunitytotal) | Win-Back Opportunity Total | money |  | Yes | none | true | Opportunity | CRM Win Back Opportunity Total | CRM_Win_Back_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 233 | [azt_winbackopportunitytotal_base](#index-azt_winbackopportunitytotal_base) | Win-Back Opportunity Total (Base) | money |  | Yes | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 234 | [azt_year](#index-azt_year) |  |  |  | Yes |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 235 | [baseamount](#index-baseamount) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 236 | [billto_line1](#index-billto_line1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 237 | [billto_line2](#index-billto_line2) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 238 | [billto_line3](#index-billto_line3) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 239 | [billto_name](#index-billto_name) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 240 | [billto_postalcode](#index-billto_postalcode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 241 | [billto_stateorprovince](#index-billto_stateorprovince) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 242 | [body](#index-body) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 243 | [bpf_duration](#index-bpf_duration) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 244 | [bpf_salesorderid](#index-bpf_salesorderid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 245 | [budgetamount](#index-budgetamount) |  |  |  | No |  | true |  |  |  | Opportunity | Budget_Amount__c | Budget_Amount__c | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 246 | [budgetstatus](#index-budgetstatus) |  |  |  | No |  | true |  |  |  | Opportunity | Budget_Confirmed__c | Budget_Confirmed__c |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 247 | [businessprocessflowinstanceid](#index-businessprocessflowinstanceid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 248 | [businessunitid](#index-businessunitid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 249 | [cadencewidgetcontrol](#index-cadencewidgetcontrol) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 250 | [captureproposalfeedback](#index-captureproposalfeedback) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 251 | [category](#index-category) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 252 | [city](#index-city) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11-pcf-controls) |  |  |  |
| 253 | [closeprobability](#index-closeprobability) | Probability Number | int |  | No | none | true | Opportunity | CRM Probability Number | CRM_Probability_Number__c |  |  |  | [2](#2-forms) | [2](#3-views) | [3](#4-chart-visualizations) |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 254 | [companyname](#index-companyname) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 255 | [competitors](#index-competitors) |  |  |  | No |  | true |  |  |  |  |  |  | [3](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 256 | [completefinalproposal](#index-completefinalproposal) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 257 | [completeinternalreview](#index-completeinternalreview) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 258 | [conditionbranchstep2_1](#index-conditionbranchstep2_1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [2](#9-formulas-rollups) |  |  |  |  |  |
| 259 | [confirminterest](#index-confirminterest) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 260 | [connectionid](#index-connectionid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 261 | [connectionroleid](#index-connectionroleid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 262 | [consideronlygoalownersrecords](#index-consideronlygoalownersrecords) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 263 | [contactid](#index-contactid) |  |  |  | No |  | true |  |  |  | Opportunity | ContactId | ContactId |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 264 | [country](#index-country) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11-pcf-controls) |  |  |  |
| 265 | [county](#index-county) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11-pcf-controls) |  |  |  |
| 266 | [createdby](#index-createdby) |  |  |  | No |  | true |  |  |  | Opportunity | Legacy_Created_By__c | Legacy_Created_By__c | [2](#2-forms) | [9](#3-views) | [14](#4-chart-visualizations) |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 267 | [createdon](#index-createdon) |  |  |  | No |  | true |  |  |  | Opportunity | Legacy_Created_On__c | Legacy_Created_On__c | [2](#2-forms) | [39](#3-views) | [3](#4-chart-visualizations) |  |  |  | [1](#9-formulas-rollups) | [10](#10-plugin-source-code-analysis) |  |  |  |  |
| 268 | [crm3_expenseamount](#index-crm3_expenseamount) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 269 | [crm3_parentleadid](#index-crm3_parentleadid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 270 | [currentsituation](#index-currentsituation) |  |  |  | No |  | true |  |  |  | Opportunity | NextStep | NextStep | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 271 | [customerid](#index-customerid) | Potential Customer | customer |  | No | required | true |  |  |  |  |  |  |  | [48](#3-views) |  |  |  | [14](#7-workflows) |  | [11](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 272 | [customerneed](#index-customerneed) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 273 | [customerpainpoints](#index-customerpainpoints) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 274 | [datefulfilled](#index-datefulfilled) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 275 | [decisionmaker](#index-decisionmaker) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 276 | [defaultuomid](#index-defaultuomid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 277 | [description](#index-description) |  |  |  | No |  | true |  |  |  | Opportunity | Description | Description | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 278 | [developproposal](#index-developproposal) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 279 | [discountamount](#index-discountamount) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 280 | [discountpercentage](#index-discountpercentage) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 281 | [discounts](#index-discounts) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 282 | [documents](#index-documents) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 283 | [documentssubgrid](#index-documentssubgrid) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 284 | [dynamicpropertieslist_linkcontrol](#index-dynamicpropertieslist_linkcontrol) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 285 | [emailaddress](#index-emailaddress) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 286 | [emailaddress1](#index-emailaddress1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 287 | [estimatedclosedate](#index-estimatedclosedate) | Est. Close Date | datetime |  | No | none | true | Opportunity | Close Date | CRM_Estimated_Close_Date__c |  |  |  | [3](#2-forms) | [81](#3-views) | [7](#4-chart-visualizations) |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 288 | [estimatedvalue](#index-estimatedvalue) | Est. Revenue | money |  | No | none | true | Opportunity | CRM Estimated Revenue | CRM_Estimated_Revenue__c |  |  |  | [4](#2-forms) | [41](#3-views) | [8](#4-chart-visualizations) |  |  | [2](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 289 | [evaluatefit](#index-evaluatefit) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 290 | [ext_amt](#index-ext_amt) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 291 | [extendedamount](#index-extendedamount) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [7](#9-formulas-rollups) | [13](#10-plugin-source-code-analysis) |  |  |  |  |
| 292 | [fetchxml](#index-fetchxml) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 293 | [filedebrief](#index-filedebrief) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 294 | [filename](#index-filename) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 295 | [firstname](#index-firstname) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 296 | [freightamount](#index-freightamount) |  |  |  | No |  | true |  |  |  | Opportunity | Freight_Amount__c | Freight_Amount__c | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 297 | [freighttermscode](#index-freighttermscode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 298 | [from](#index-from) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 299 | [fullname](#index-fullname) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 300 | [goalenddate](#index-goalenddate) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 301 | [goalid](#index-goalid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 302 | [goalownerid](#index-goalownerid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 303 | [goalrollupqueryid](#index-goalrollupqueryid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 304 | [goalstartdate](#index-goalstartdate) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 305 | [identifycompetitors](#index-identifycompetitors) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 306 | [identifycustomercontacts](#index-identifycustomercontacts) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 307 | [identifypursuitteam](#index-identifypursuitteam) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 308 | [incidentid](#index-incidentid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 309 | [initialcommunication](#index-initialcommunication) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 310 | [internalemailaddress](#index-internalemailaddress) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 311 | [invline.productid](#index-invlineproductid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 312 | [invoicedetailid](#index-invoicedetailid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 313 | [invoiceid](#index-invoiceid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 314 | [invoicenumber](#index-invoicenumber) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 315 | [isamount](#index-isamount) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 316 | [isfiscalperiodgoal](#index-isfiscalperiodgoal) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 317 | [isocurrencycode](#index-isocurrencycode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 318 | [ispriceoverridden](#index-ispriceoverridden) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 319 | [isproductoverridden](#index-isproductoverridden) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 320 | [isrevenuesystemcalculated](#index-isrevenuesystemcalculated) | Revenue | bit | 1: System Calculated, 0: User Provided | No | none | true | Opportunity | CRM Revenue | CRM_Revenue__c |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 321 | [jobtitle](#index-jobtitle) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 322 | [lastname](#index-lastname) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 323 | [manualdiscountamount](#index-manualdiscountamount) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [9](#10-plugin-source-code-analysis) |  |  |  |  |
| 324 | [metricid](#index-metricid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 325 | [mimetype](#index-mimetype) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 326 | [mobilephone](#index-mobilephone) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 327 | [modifiedon](#index-modifiedon) |  |  |  | No |  | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 328 | [msa_partnerid](#index-msa_partnerid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 329 | [msa_partneroppid](#index-msa_partneroppid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 330 | [msdyn_forecastcategory](#index-msdyn_forecastcategory) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 331 | [msdyn_opportunitykpiid](#index-msdyn_opportunitykpiid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 332 | [msdyn_predictivescoreid](#index-msdyn_predictivescoreid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 333 | [msdyn_segmentid](#index-msdyn_segmentid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 334 | [name](#index-name) | Topic | nvarchar |  | No | required | true |  |  |  | Opportunity | Name | Name | [2](#2-forms) | [75](#3-views) |  |  |  | [19](#7-workflows) |  | [23](#10-plugin-source-code-analysis) |  |  |  |  |
| 335 | [need](#index-need) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 336 | [new_sharedwith](#index-new_sharedwith) |  |  |  | No |  | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 337 | [notescontrol](#index-notescontrol) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 338 | [objectid](#index-objectid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 339 | [objecttypecode](#index-objecttypecode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 340 | [opportunityaudit](#index-opportunityaudit) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 341 | [opportunityid](#index-opportunityid) |  |  |  | No |  | true |  |  |  |  |  |  |  | [65](#3-views) |  |  |  | [11](#7-workflows) |  | [32](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 342 | [opportunityproductid](#index-opportunityproductid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [14](#10-plugin-source-code-analysis) |  |  |  |  |
| 343 | [opportunityproductsgrid](#index-opportunityproductsgrid) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 344 | [opportunityratingcode](#index-opportunityratingcode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 345 | [originatingleadid](#index-originatingleadid) |  |  |  | No |  | true |  |  |  | Opportunity | Sales_Lead__c | Sales_Lead__c | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 346 | [ownerid](#index-ownerid) | Owner | owner |  | No | systemrequired | true | Opportunity | Record Type | RecordTypeId |  |  |  | [4](#2-forms) | [27](#3-views) | [9](#4-chart-visualizations) |  |  | [25](#7-workflows) |  | [22](#10-plugin-source-code-analysis) |  |  |  |  |
| 347 | [owningbusinessunit](#index-owningbusinessunit) |  |  |  | No |  | true |  |  |  |  |  |  |  | [5](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 348 | [parentaccountid](#index-parentaccountid) | Account | lookup |  | No | none | true |  |  |  |  |  |  | [5](#2-forms) | [1](#3-views) |  |  |  | [13](#7-workflows) |  | [4](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 349 | [parentcontactid](#index-parentcontactid) | Contact | lookup |  | No | none | true | Opportunity | Contact name | ContactId |  |  |  | [5](#2-forms) | [1](#3-views) |  |  |  | [10](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 350 | [parentcustomerid](#index-parentcustomerid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 351 | [parentgoalid](#index-parentgoalid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 352 | [parentsystemuserid](#index-parentsystemuserid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 353 | [partyid](#index-partyid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 354 | [phonenumber](#index-phonenumber) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 355 | [presentfinalproposal](#index-presentfinalproposal) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 356 | [presentproposal](#index-presentproposal) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 357 | [pricelevelid](#index-pricelevelid) | Price List | lookup |  | No | required | true | Opportunity | Price Book | Pricebook2Id |  |  |  | [2](#2-forms) |  |  |  |  | [7](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 358 | [priceperunit](#index-priceperunit) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 359 | [primarycontactid](#index-primarycontactid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 360 | [prioritycode](#index-prioritycode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 361 | [prod.productid](#index-prodproductid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 362 | [productdescription](#index-productdescription) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [13](#10-plugin-source-code-analysis) |  |  |  |  |
| 363 | [productid](#index-productid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [33](#10-plugin-source-code-analysis) |  |  |  |  |
| 364 | [productname](#index-productname) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 365 | [productnumber](#index-productnumber) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 366 | [productsuggestions_linkcontrol](#index-productsuggestions_linkcontrol) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 367 | [producttypecode](#index-producttypecode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 368 | [proposedsolution](#index-proposedsolution) |  |  |  | No |  | true |  |  |  | Opportunity | Proposed_Solution__c | Proposed_Solution__c | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 369 | [purchaseprocess](#index-purchaseprocess) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 370 | [purchasetimeframe](#index-purchasetimeframe) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 371 | [pursuit_team](#index-pursuit_team) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 372 | [pursuitdecision](#index-pursuitdecision) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 373 | [qualificationcomments](#index-qualificationcomments) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 374 | [quantity](#index-quantity) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [18](#10-plugin-source-code-analysis) |  |  |  |  |
| 375 | [queryentitytype](#index-queryentitytype) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 376 | [queueid](#index-queueid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 377 | [queueitemid](#index-queueitemid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 378 | [quote](#index-quote) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 379 | [quotecomments](#index-quotecomments) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 380 | [quotedetailid](#index-quotedetailid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [14](#10-plugin-source-code-analysis) |  |  |  |  |
| 381 | [quoteid](#index-quoteid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [20](#10-plugin-source-code-analysis) |  |  |  |  |
| 382 | [record1id](#index-record1id) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 383 | [record1roleid](#index-record1roleid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 384 | [record2id](#index-record2id) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 385 | [record2roleid](#index-record2roleid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 386 | [regardingobjectid](#index-regardingobjectid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 387 | [requestdeliveryby](#index-requestdeliveryby) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 388 | [resolvefeedback](#index-resolvefeedback) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 389 | [ricontainer_charts](#index-ricontainer_charts) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 390 | [roleid](#index-roleid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 391 | [rolluponlyfromchildgoals](#index-rolluponlyfromchildgoals) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 392 | [rollupqueryactualmoneyid](#index-rollupqueryactualmoneyid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 393 | [rolluprulestep1_1](#index-rolluprulestep1_1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [8](#9-formulas-rollups) |  |  |  |  |  |
| 394 | [rolluprulestep1_2](#index-rolluprulestep1_2) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [8](#9-formulas-rollups) |  |  |  |  |  |
| 395 | [rolluprulestep1_3](#index-rolluprulestep1_3) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [8](#9-formulas-rollups) |  |  |  |  |  |
| 396 | [rolluprulestep1_4](#index-rolluprulestep1_4) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [8](#9-formulas-rollups) |  |  |  |  |  |
| 397 | [rolluprulestep1_5](#index-rolluprulestep1_5) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [8](#9-formulas-rollups) |  |  |  |  |  |
| 398 | [salesorderdetailid](#index-salesorderdetailid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [9](#10-plugin-source-code-analysis) |  |  |  |  |
| 399 | [salesorderdetailname](#index-salesorderdetailname) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 400 | [salesorderid](#index-salesorderid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [13](#10-plugin-source-code-analysis) |  |  |  |  |
| 401 | [salesrepid](#index-salesrepid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 402 | [salesstage](#index-salesstage) | Deprecated Sales Stage | picklist |  | No | none | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 403 | [salesstagecode](#index-salesstagecode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 404 | [scheduledend](#index-scheduledend) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 405 | [sendthankyounote](#index-sendthankyounote) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 406 | [setattributevaluestep4_1](#index-setattributevaluestep4_1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [2](#9-formulas-rollups) |  |  |  |  |  |
| 407 | [setattributevaluestep4_2](#index-setattributevaluestep4_2) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [2](#9-formulas-rollups) |  |  |  |  |  |
| 408 | [setattributevaluestep4_3](#index-setattributevaluestep4_3) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [2](#9-formulas-rollups) |  |  |  |  |  |
| 409 | [setattributevaluestep4_4](#index-setattributevaluestep4_4) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [2](#9-formulas-rollups) |  |  |  |  |  |
| 410 | [setattributevaluestep4_5](#index-setattributevaluestep4_5) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  | [2](#9-formulas-rollups) |  |  |  |  |  |
| 411 | [shippingmethodcode](#index-shippingmethodcode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 412 | [shipto_line1](#index-shipto_line1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 413 | [shipto_line2](#index-shipto_line2) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 414 | [shipto_line3](#index-shipto_line3) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 415 | [shipto_name](#index-shipto_name) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 416 | [shipto_postalcode](#index-shipto_postalcode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 417 | [shipto_stateorprovince](#index-shipto_stateorprovince) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 418 | [stakeholders](#index-stakeholders) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 419 | [state](#index-state) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11-pcf-controls) |  |  |  |
| 420 | [statecode](#index-statecode) | Status | state |  | No | systemrequired | true | Opportunity | CRM Status | CRM_Status__c |  |  |  |  | [58](#3-views) | [2](#4-chart-visualizations) |  |  | [10](#7-workflows) |  | [20](#10-plugin-source-code-analysis) |  |  |  |  |
| 421 | [stateorprovince](#index-stateorprovince) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 422 | [statuscode](#index-statuscode) | Status Reason | status |  | No | none | true |  |  |  |  |  |  |  | [10](#3-views) |  |  |  | [5](#7-workflows) |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 423 | [street](#index-street) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11-pcf-controls) |  |  |  |
| 424 | [subject](#index-subject) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 425 | [systemuserid](#index-systemuserid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 426 | [tax](#index-tax) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 427 | [teamid](#index-teamid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 428 | [teamtype](#index-teamtype) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 429 | [telephone1](#index-telephone1) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 430 | [title](#index-title) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 431 | [tm.systemuserid](#index-tmsystemuserid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 432 | [to](#index-to) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 433 | [totalamount](#index-totalamount) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 434 | [totalamountlessfreight](#index-totalamountlessfreight) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 435 | [totallineitemamount](#index-totallineitemamount) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 436 | [totaltax](#index-totaltax) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 437 | [transactioncurrencyid](#index-transactioncurrencyid) |  |  |  | No |  | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 438 | [uomid](#index-uomid) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 439 | [value](#index-value) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11-pcf-controls) |  |  |  |
| 440 | [webresource_recordwall](#index-webresource_recordwall) |  |  |  | No |  | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 441 | [zipcode](#index-zipcode) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11-pcf-controls) |  |  |  |
| 442 | [{0}](#index-0) |  |  |  | No |  | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |

---

## <a id="2-forms"></a>2. Forms

Total forms: **9**

### <a id="21-ai-for-sales-main-active"></a>2.1. AI for Sales (main) -- Active

- **Form ID:** `{595978a6-704c-4aec-aab8-34f3927c1cda}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Summary

##### Section: opportunity_information

##### Section: Sales Team

#### Tab: RAV2
*Hidden tab*

##### Section: RAV2_section_1

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [RICONTAINER_CHARTS](#index-ricontainer_charts) |  | No | Yes |

#### Tab: QUOTES

##### Section: opportunityquotes

#### Tab: Products

##### Section: opportunityproducts

#### Tab: linkedin_v2_tab
*Hidden tab*

##### Section: linkedin_v2_tab_section_1

##### Section: linkedin_v2_tab_section_2

##### Section: linkedin_v2_tab_section_3

### <a id="22-igrad-main-active"></a>2.2. iGrad (main) -- Active

- **Form ID:** `{62b5695a-d153-4bdc-9638-79409d3abcc1}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Header Fields

| Field | Label |
|-------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | Record Owner |
| [ownerid](#index-ownerid) | Owner |
| [estimatedvalue](#index-estimatedvalue) | Est. Revenue |
| [parentaccountid](#index-parentaccountid) | Account |

#### Tab: Summary

##### Section: Opportunity Information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [name](#index-name) | Topic | No | Yes |
| [parentaccountid](#index-parentaccountid) | Account Owner | No | Yes |
| [azt_recordownerid](#index-azt_recordownerid) | Record Owner | No | Yes |
| [azt_opportunitynumber](#index-azt_opportunitynumber) | Opportunity Number | Yes | Yes |
| [parentcontactid](#index-parentcontactid) | Contact | No | Yes |
| [azt_opportunitytype](#index-azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_iscrossselloppty](#index-azt_iscrossselloppty) | Is Cross-sell Oppty? | No | Yes |
| [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | Product Category | No | No |
| [azt_deliverytype](#index-azt_deliverytype) | Delivery Type | No | Yes |
| [azt_accountclassification](#index-azt_accountclassification) | Account Classification | No | Yes |
| [azt_pipelinestage](#index-azt_pipelinestage) | Pipeline Stage | No | Yes |
| [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | Expected Renewal Value | No | Yes |
| [originatingleadid](#index-originatingleadid) | Originating Lead | Yes | Yes |
| [Competitors](#index-competitors) | Competitors | No | Yes |
| [msdyn_forecastcategory](#index-msdyn_forecastcategory) | Forecast category | No | No |

##### Section: Opportunity Details

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [currentsituation](#index-currentsituation) | Current Situation | No | Yes |
| [azt_renewalnotes](#index-azt_renewalnotes) | Renewal Notes | No | Yes |

##### Section: Opportunity Audit

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [opportunityaudit](#index-opportunityaudit) | Opportunity Audit Records (Opportunity) | No | Yes |

##### Section: Up next

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [CadenceWidgetControl](#index-cadencewidgetcontrol) | Up next | No | Yes |

##### Section: Assistant

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ActionCards](#index-actioncards) | Assistant | No | Yes |

##### Section: Sales Team

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Pursuit_Team](#index-pursuit_team) | SALES TEAM | No | Yes |
| [Stakeholders](#index-stakeholders) | STAKEHOLDERS | No | Yes |

##### Section: Rollup Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_initialopportunitytotal](#index-azt_initialopportunitytotal) | Initial Opportunity Total | No | Yes |
| [azt_addonopportunitytotal](#index-azt_addonopportunitytotal) | Add-On Opportunity Total | No | Yes |
| [azt_renewalopportunitytotal](#index-azt_renewalopportunitytotal) | Renewal Opportunity Total | No | Yes |
| [azt_pilotopportunitytotal](#index-azt_pilotopportunitytotal) | Pilot Opportunity Total | No | Yes |
| [azt_winbackopportunitytotal](#index-azt_winbackopportunitytotal) | Win-Back Opportunity Total | No | Yes |
| [azt_printopportunitytotal](#index-azt_printopportunitytotal) | Print Opportunity Total | No | Yes |
| [azt_otheropportunitytotal](#index-azt_otheropportunitytotal) | Other Opportunity Total | No | Yes |
| [azt_dayssincecreated](#index-azt_dayssincecreated) | Days Since Created | No | Yes |

##### Section: Competitors

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Competitors](#index-competitors) | Competitors | No | Yes |

#### Tab: Forecast/Activities

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [estimatedvalue](#index-estimatedvalue) | Est. Revenue | No | Yes |
| [estimatedclosedate](#index-estimatedclosedate) | Est. Close Date | No | Yes |
| [purchasetimeframe](#index-purchasetimeframe) | Purchase Timeframe | No | Yes |
| [azt_probability](#index-azt_probability) | Probability | No | Yes |
| [azt_dayssinceprobabilitychanged](#index-azt_dayssinceprobabilitychanged) | Days Since Probability Changed | Yes | Yes |
| [azt_pipelinestage](#index-azt_pipelinestage) | Pipeline Stage | No | Yes |
| [budgetamount](#index-budgetamount) | Budget Amount | No | Yes |
| [closeprobability](#index-closeprobability) | Probability Number | No | No |
| [purchaseprocess](#index-purchaseprocess) | Purchase Process | No | Yes |
| [azt_fundingsource](#index-azt_fundingsource) | Funding Source | No | Yes |
| [azt_lastactivitydate](#index-azt_lastactivitydate) | Last Activity Date | Yes | Yes |
| [azt_lastmodifiedbyid](#index-azt_lastmodifiedbyid) | Last Modified By | No | No |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [activities](#index-activities) | Activities | No | Yes |

#### Tab: Product line items

##### Section: Opportunity Products

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [pricelevelid](#index-pricelevelid) | Price List | No | Yes |
| [isrevenuesystemcalculated](#index-isrevenuesystemcalculated) | Revenue | No | Yes |
| [opportunityproductsGrid](#index-opportunityproductsgrid) | Line Items | No | Yes |

##### Section: Suggestions

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ProductSuggestions_LinkControl](#index-productsuggestions_linkcontrol) |  | No | Yes |

##### Section: Dynamic properties

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [DynamicPropertiesList_LinkControl](#index-dynamicpropertieslist_linkcontrol) |  | No | Yes |

##### Section: Product Line Item Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [transactioncurrencyid](#index-transactioncurrencyid) | Currency | No | Yes |
| [totallineitemamount](#index-totallineitemamount) | Detail Amount | Yes | Yes |
| [discountpercentage](#index-discountpercentage) | (-) Discount (%) | No | Yes |
| [discountamount](#index-discountamount) | (-) Discount | Yes | Yes |
| [azt_discretionarydiscount](#index-azt_discretionarydiscount) | Discretionary Discount | No | Yes |
| [azt_discretionarydiscountamt](#index-azt_discretionarydiscountamt) | Discretionary Discount Amt | Yes | No |
| [totalamountlessfreight](#index-totalamountlessfreight) | Pre-freight amount | Yes | Yes |
| [freightamount](#index-freightamount) | (+) freight amount | Yes | Yes |
| [totaltax](#index-totaltax) | (+) Total tax | Yes | Yes |
| [totalamount](#index-totalamount) | Total Amount | Yes | Yes |

##### Section: Freight

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_defaultfreightamount](#index-azt_defaultfreightamount) | Default Freight Amount | Yes | Yes |
| [azt_requestedfreightamt](#index-azt_requestedfreightamt) | Requested Freight Amt | No | Yes |
| [azt_freightamtapproved](#index-azt_freightamtapproved) | Freight Amt Approved? | No | Yes |

#### Tab: Discretionary Discounts

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discounts](#index-discounts) | Product Discounts (Opportunity) | No | Yes |

#### Tab: Files

##### Section: Documents Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [DocumentsSubGrid](#index-documentssubgrid) | Documents | No | Yes |

#### Tab: LinkedIn Sales Navigator
*Hidden tab*

##### Section: LinkedIn Member Profile

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentcontactid](#index-parentcontactid) | Contact | No | Yes |

##### Section: LinkedIn Account Profile

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentaccountid](#index-parentaccountid) | Account | No | Yes |

##### Section: LinkedIn InMail

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentcontactid](#index-parentcontactid) | Contact | No | Yes |

#### Tab: Quotes

##### Section: Quotes

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quote](#index-quote) | Action Cards | No | Yes |

#### Tab: Documents

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [documents](#index-documents) | Document Locations (Regarding) | No | Yes |

#### Tab: Notes

##### Section: Notes pane

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#index-notescontrol) |  | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [actualclosedate](#index-actualclosedate) | Actual Close Date |
| [createdon](#index-createdon) | Created On |
| [createdby](#index-createdby) | Created By |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `LinkedInIntegration.LinkedInIntegrationCommon.Instance.Form_OnLoad` | `LinkedInIntegration/Common/msdyn_LinkedInIntegrationCommon.js` | true |
| onload |  | `Sales.DocumentsTabController.shouldShowDocumentsTab` | `Sales/ClientCommon/Sales_ClientCommon.js` | true |
| onload |  | `OPP.OPPFunctions.onLoad` | `azt_opportunitylibrary` | true |
| onrecordselect |  | `Mscrm.onRecordSelect` | `Sales/Opportunity/Opportunity_main_system_library.js` | true |
| onrecordselect |  | `DSC.DiscountFunctions.gridSelectRow` | `azt_discountgridfunctions` | true |
| onchange | azt_freightamtapproved | `OPP.OPPFunctions.setFreightAmt` | `azt_opportunitylibrary` | true |

### <a id="23-opportunity-main-active"></a>2.3. Opportunity (main) -- Active

- **Form ID:** `{a837e4a7-01b8-4f82-a475-be9abd67e667}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Header Fields

| Field | Label |
|-------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | Record Owner |

#### Tab: Summary

##### Section: Opportunity Information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentaccountid](#index-parentaccountid) | Account Owner | No | Yes |
| [azt_recordownerid](#index-azt_recordownerid) | Record Owner | No | Yes |
| [azt_opportunitynumber](#index-azt_opportunitynumber) | Opportunity Number | Yes | Yes |
| [parentcontactid](#index-parentcontactid) | Contact | No | Yes |
| [azt_opportunitytype](#index-azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_iscrossselloppty](#index-azt_iscrossselloppty) | Is Cross-sell Oppty? | No | Yes |
| [azt_leadsourceid](#index-azt_leadsourceid) | Lead Source | No | Yes |
| [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | Product Category | No | No |
| [azt_deliverytype](#index-azt_deliverytype) | Delivery Type | No | Yes |
| [azt_accountclassification](#index-azt_accountclassification) | Account Classification | No | Yes |
| [azt_committoestimatedclose](#index-azt_committoestimatedclose) | Commit to Pipeline? | No | Yes |
| [azt_pipelinestage](#index-azt_pipelinestage) | Pipeline Stage | No | Yes |
| [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | Expected Renewal Value | No | Yes |
| [azt_assignedamid](#index-azt_assignedamid) | Assigned AM | No | Yes |
| [originatingleadid](#index-originatingleadid) | Originating Lead | Yes | Yes |
| [Competitors](#index-competitors) | Competitors | No | Yes |

##### Section: Opportunity_details

##### Section: Record_Summary_Widget
*Hidden section*

##### Section: Summary_CadenceWidget

##### Section: Notes_pane

##### Section: Opportunity Details

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [description](#index-description) | Description | No | Yes |
| [currentsituation](#index-currentsituation) | Current Situation | No | Yes |
| [customerneed](#index-customerneed) | Customer Need | No | Yes |
| [proposedsolution](#index-proposedsolution) | Proposed Solution | No | Yes |
| [azt_internalaztecnotes](#index-azt_internalaztecnotes) | Internal Aztec Notes | No | Yes |
| [azt_renewalnotes](#index-azt_renewalnotes) | Renewal Notes | No | Yes |

##### Section: Opportunity Audit

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [opportunityaudit](#index-opportunityaudit) | Opportunity Audit Records (Opportunity) | No | Yes |

##### Section: Sales Team

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Pursuit_Team](#index-pursuit_team) | SALES TEAM | No | Yes |

##### Section: Competitors_Section

##### Section: Rollup Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_initialopportunitytotal](#index-azt_initialopportunitytotal) | Initial Opportunity Total | No | Yes |
| [azt_addonopportunitytotal](#index-azt_addonopportunitytotal) | Add-On Opportunity Total | No | Yes |
| [azt_renewalopportunitytotal](#index-azt_renewalopportunitytotal) | Renewal Opportunity Total | No | Yes |
| [azt_pilotopportunitytotal](#index-azt_pilotopportunitytotal) | Pilot Opportunity Total | No | Yes |
| [azt_winbackopportunitytotal](#index-azt_winbackopportunitytotal) | Win-Back Opportunity Total | No | Yes |
| [azt_printopportunitytotal](#index-azt_printopportunitytotal) | Print Opportunity Total | No | Yes |
| [azt_otheropportunitytotal](#index-azt_otheropportunitytotal) | Other Opportunity Total | No | Yes |
| [azt_dayssincecreated](#index-azt_dayssincecreated) | Days Since Created | No | Yes |

#### Tab: Products

##### Section: Opportunity Products

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [pricelevelid](#index-pricelevelid) | Price List | No | Yes |
| [isrevenuesystemcalculated](#index-isrevenuesystemcalculated) |  | No | Yes |
| [opportunityproductsGrid](#index-opportunityproductsgrid) | Line Items | No | Yes |

##### Section: Product Line Item Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discountamount](#index-discountamount) |  | Yes | Yes |
| [freightamount](#index-freightamount) | (+) Freight Amount | Yes | Yes |
| [transactioncurrencyid](#index-transactioncurrencyid) | Currency | No | Yes |
| [azt_discretionarydiscount](#index-azt_discretionarydiscount) | Discretionary Discount | No | Yes |
| [azt_discretionarydiscountamt](#index-azt_discretionarydiscountamt) | Discretionary Discount Amt | Yes | No |

##### Section: Freight

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_defaultfreightamount](#index-azt_defaultfreightamount) | Default Freight Amount | Yes | Yes |
| [azt_requestedfreightamt](#index-azt_requestedfreightamt) | Requested Freight Amt | No | Yes |
| [azt_freightamtapproved](#index-azt_freightamtapproved) | Freight Amt Approved? | No | Yes |

#### Tab: QUOTES

##### Section: opportunityquotes

#### Tab: documents_sharepoint

#### Tab: linkedin_v2_tab
*Hidden tab*

##### Section: linkedin_v2_tab_section_1

##### Section: linkedin_v2_tab_section_2

##### Section: linkedin_v2_tab_section_3

#### Tab: Forecast/Activities

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [estimatedvalue](#index-estimatedvalue) | Est. Revenue | No | Yes |
| [estimatedclosedate](#index-estimatedclosedate) | Est. Close Date | No | Yes |
| [purchasetimeframe](#index-purchasetimeframe) | Purchase Timeframe | No | Yes |
| [azt_probability](#index-azt_probability) | Probability | No | Yes |
| [azt_dayssinceprobabilitychanged](#index-azt_dayssinceprobabilitychanged) | Days Since Probability Changed | Yes | Yes |
| [azt_pipelinestage](#index-azt_pipelinestage) | Pipeline Stage | No | Yes |
| [budgetamount](#index-budgetamount) | Budget Amount | No | Yes |
| [closeprobability](#index-closeprobability) | Probability Number | No | No |
| [purchaseprocess](#index-purchaseprocess) | Purchase Process | No | Yes |
| [azt_fundingsource](#index-azt_fundingsource) | Funding Source | No | Yes |
| [azt_lastactivitydate](#index-azt_lastactivitydate) | Last Activity Date | Yes | Yes |
| [azt_lastmodifiedbyid](#index-azt_lastmodifiedbyid) | Last Modified By | No | No |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [activities](#index-activities) | Activities | No | Yes |

#### Tab: Discretionary Discounts

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discounts](#index-discounts) | Product Discounts (Opportunity) | No | Yes |

#### Tab: Documents

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [documents](#index-documents) | Document Locations (Regarding) | No | Yes |

#### Tab: Notes

##### Section: Notes pane

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#index-notescontrol) |  | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [actualclosedate](#index-actualclosedate) | Actual Close Date |
| [createdon](#index-createdon) | Created On |
| [createdby](#index-createdby) | Created By |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `SalesCopilot.CopilotSummaryWidget.copilotHelper.shouldShowSummaryWidget` | `msdyn_SalesCopilot/CopilotSummaryWidget.Library.js` | true |
| onload |  | `OPP.OPPFunctions.onLoad` | `azt_opportunitylibrary` | true |
| onrecordselect |  | `DSC.DiscountFunctions.gridSelectRow` | `azt_discountgridfunctions` | true |
| onchange | azt_freightamtapproved | `OPP.OPPFunctions.setFreightAmt` | `azt_opportunitylibrary` | true |

### <a id="24-information-main-inactive"></a>2.4. Information (main) -- Inactive

- **Form ID:** `{a2a56263-ec37-4991-a3b0-e7b37a71d818}`
- **Presentation:** Classic
- **Status:** Inactive

#### Tab: general

##### Section: opportunity information

##### Section: forecast information

#### Tab: Product Line Item Details

##### Section: opportunityproducts

##### Section: totals

#### Tab: notes and activities

#### Tab: Opportunity Quotes

#### Tab: administration

##### Section: internal information

#### Tab: What's New

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [WebResource_RecordWall](#index-webresource_recordwall) | RecordWall | No | Yes |

### <a id="25-opportunity-quickcreate-active"></a>2.5. Opportunity (quickCreate) -- Active

- **Form ID:** `{e3c588ee-8e11-49da-a5fe-3800f3f683de}`
- **Presentation:** Classic
- **Status:** Active

#### Tab: newOpportunity

##### Section: quickOpportunity_column1

##### Section: quickOpportunity_column2

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_opportunitytype](#index-azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_probability](#index-azt_probability) | Probability | No | Yes |
| [azt_fundingsource](#index-azt_fundingsource) | Funding Source | No | Yes |

##### Section: quickOpportunity_column3

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#index-ownerid) | Owner | No | Yes |
| [estimatedvalue](#index-estimatedvalue) | Est. Revenue | No | Yes |

### <a id="26-opportunity-quick-quickcreate-active"></a>2.6. Opportunity Quick (quickCreate) -- Active

- **Form ID:** `{1f4f9cba-78e3-4bf7-b194-65d71fa84200}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [name](#index-name) | Topic | No | Yes |
| [parentcontactid](#index-parentcontactid) | Contact | No | Yes |
| [parentaccountid](#index-parentaccountid) | Account | No | Yes |

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [estimatedclosedate](#index-estimatedclosedate) | Est. Close Date | No | Yes |
| [azt_opportunitytype](#index-azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_probability](#index-azt_probability) | Probability | No | Yes |
| [azt_fundingsource](#index-azt_fundingsource) | Funding Source | No | Yes |

##### Section: Customer Info

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [customerneed](#index-customerneed) | Customer Need | No | Yes |

### <a id="27-opportunity-record-owner-quick-active"></a>2.7. Opportunity Record Owner (quick) -- Active

- **Form ID:** `{7305dc75-69b6-4d33-8caa-82516d20a507}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recordownerid](#index-azt_recordownerid) | Record Owner | No | Yes |

### <a id="28-opportunity-owner-quick-view-quick-active"></a>2.8. Opportunity Owner Quick View (quick) -- Active

- **Form ID:** `{087cefcf-a5f8-4eb0-bb5a-8f30fbce0ac8}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Opportunity Owner

##### Section: Opportunity Owner

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recordownerid](#index-azt_recordownerid) | Record Owner | No | Yes |
| [ownerid](#index-ownerid) | Opportunity Owner | No | No |

### <a id="29-order-opportunity-owner-quick-view-quick-active"></a>2.9. Order Opportunity Owner Quick View (quick) -- Active

- **Form ID:** `{8ae9ecb5-a042-4c4d-b1f4-df762846bbcf}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#index-ownerid) | Opportunity Owner | No | Yes |

---

## <a id="3-views"></a>3. Views

Total views: **65**

### <a id="31-all-opportunities"></a>3.1. All Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [statecode](#index-statecode) | 100px |
| 2 | [createdon](#index-createdon) | 100px |
| 3 | [name](#index-name) | 300px |
| 4 | [azt_opportunitynumber](#index-azt_opportunitynumber) | 86px |
| 5 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 6 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 125px |
| 7 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 8 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 9 | [azt_probability](#index-azt_probability) | 100px |
| 10 | [ownerid](#index-ownerid) | 125px |
| 11 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 12 | [customerid](#index-customerid) | 150px |
| 13 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 14 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 15 | [statuscode](#index-statuscode) | 100px |
| 16 | [actualclosedate](#index-actualclosedate) | 100px |
| 17 | [actualvalue_base](#index-actualvalue_base) | 100px |
| 18 | [actualvalue](#index-actualvalue) | 100px |
| 19 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 20 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 21 | [address1_city](#index-address1_city) |  |
| 22 | [opportunityid](#index-opportunityid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Descending |
| [name](#index-name) | Ascending |

### <a id="32-closed-opportunities-in-current-fiscal-year"></a>3.2. Closed Opportunities in Current Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 125px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [actualclosedate](#index-actualclosedate) | 125px |
| 5 | [actualvalue](#index-actualvalue) | 125px |
| 6 | [customerid](#index-customerid) | 150px |
| 7 | [ownerid](#index-ownerid) | 150px |
| 8 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 9 | [statuscode](#index-statuscode) | 150px |
| 10 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [statecode](#index-statecode) | eq | 2 |
| [actualclosedate](#index-actualclosedate) | this-fiscal-year |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#index-actualvalue) | Descending |

### <a id="33-closed-opportunities"></a>3.3. Closed Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunitynumber](#index-azt_opportunitynumber) | 77px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 125px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [actualclosedate](#index-actualclosedate) | 125px |
| 6 | [actualvalue](#index-actualvalue) | 125px |
| 7 | [customerid](#index-customerid) | 150px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 10 | [ownerid](#index-ownerid) | 150px |
| 11 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 12 | [statuscode](#index-statuscode) | 150px |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [statecode](#index-statecode) | eq | 2 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualclosedate](#index-actualclosedate) | Descending |

### <a id="34-executive-sales-measure-30-day-pipeline"></a>3.4. Executive Sales Measure 30 Day Pipeline

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdon](#index-createdon) | 100px |
| 2 | [owningbusinessunit](#index-owningbusinessunit) | 150px |
| 3 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 4 | [customerid](#index-customerid) | 200px |
| 5 | [name](#index-name) | 200px |
| 6 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 125px |
| 8 | [azt_probability](#index-azt_probability) | 100px |
| 9 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 10 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#index-createdon) | last-x-days | 30 |
| [azt_opportunitytype](#index-azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Ascending |
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="35-executive-sales-measure-advanced-30-day-pipeline"></a>3.5. Executive Sales Measure Advanced 30 Day Pipeline

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probabilitychangedon](#index-azt_probabilitychangedon) | 150px |
| 2 | [owningbusinessunit](#index-owningbusinessunit) | 150px |
| 3 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 4 | [customerid](#index-customerid) | 200px |
| 5 | [name](#index-name) | 200px |
| 6 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 125px |
| 8 | [azt_probability](#index-azt_probability) | 100px |
| 9 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 10 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_probabilitychangedon](#index-azt_probabilitychangedon) | last-x-days | 30 |
| [azt_opportunitytype](#index-azt_opportunitytype) | ne | 276530005 |
| [azt_probabilityincreased](#index-azt_probabilityincreased) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [owningbusinessunit](#index-owningbusinessunit) | Ascending |
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="36-gedsrm-opps"></a>3.6. GEDSRM Opps

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [statecode](#index-statecode) | 100px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [name](#index-name) | 300px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 125px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 7 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 8 | [azt_probability](#index-azt_probability) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 11 | [actualclosedate](#index-actualclosedate) | 100px |
| 12 | [actualvalue_base](#index-actualvalue_base) | 100px |
| 13 | [actualvalue](#index-actualvalue) | 100px |
| 14 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 15 | [ownerid](#index-ownerid) | 125px |
| 16 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 17 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 18 | [address1_city](#index-address1_city) |  |
| 19 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [name](#index-name) | like | %SRM% |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Descending |
| [name](#index-name) | Ascending |

### <a id="37-lost-opportunities"></a>3.7. Lost Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunitynumber](#index-azt_opportunitynumber) | 77px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 5 | [actualclosedate](#index-actualclosedate) | 125px |
| 6 | [customerid](#index-customerid) | 150px |
| 7 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 9 | [statuscode](#index-statuscode) | 150px |
| 10 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 11 | [address1_city](#index-address1_city) |  |
| 12 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 2 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualclosedate](#index-actualclosedate) | Descending |

### <a id="38-my-aged-or-stuck-opportunities"></a>3.8. My Aged or Stuck Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_lastactivitydate](#index-azt_lastactivitydate) | 100px |
| 2 | [azt_dayssincecreated](#index-azt_dayssincecreated) | 100px |
| 3 | [createdon](#index-createdon) | 100px |
| 4 | [name](#index-name) | 150px |
| 5 | [azt_opportunitytype](#index-azt_opportunitytype) | 100px |
| 6 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 7 | [azt_dayssinceprobabilitychanged](#index-azt_dayssinceprobabilitychanged) | 100px |
| 8 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 9 | [azt_probabilitychangedon](#index-azt_probabilitychangedon) | 100px |
| 10 | [azt_probability](#index-azt_probability) | 100px |
| 11 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 12 | [customerid](#index-customerid) | 100px |
| 13 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 14 | [ownerid](#index-ownerid) | 100px |
| 15 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [azt_opportunitytype](#index-azt_opportunitytype) | not-in |  |
| [azt_dayssinceprobabilitychanged](#index-azt_dayssinceprobabilitychanged) | ge | 60 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_probabilitychangedon](#index-azt_probabilitychangedon) | Descending |

### <a id="39-my-closed-opportunities-in-current-fiscal-year"></a>3.9. My Closed Opportunities in Current Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [actualclosedate](#index-actualclosedate) | 125px |
| 5 | [actualvalue](#index-actualvalue) | 125px |
| 6 | [customerid](#index-customerid) | 150px |
| 7 | [statuscode](#index-statuscode) | 150px |
| 8 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [statecode](#index-statecode) | eq | 2 |
| [actualclosedate](#index-actualclosedate) | this-fiscal-year |  |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#index-actualvalue) | Descending |

### <a id="310-my-initialadd-on-opportunities-added-last-week"></a>3.10. My Initial/Add-on Opportunities Added Last Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 125px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#index-createdon) | 100px |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_opportunitytype](#index-azt_opportunitytype) | in |  |
| [createdon](#index-createdon) | last-week |  |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Ascending |

### <a id="311-my-initialadd-on-opportunities-added-this-month"></a>3.11. My Initial/Add-on Opportunities Added This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 125px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#index-createdon) | 100px |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_opportunitytype](#index-azt_opportunitytype) | in |  |
| [createdon](#index-createdon) | this-month |  |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Ascending |

### <a id="312-my-initialadd-on-opportunities-added-this-week"></a>3.12. My Initial/Add-on Opportunities Added This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 125px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 125px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#index-createdon) | 100px |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_opportunitytype](#index-azt_opportunitytype) | in |  |
| [createdon](#index-createdon) | this-week |  |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Ascending |

### <a id="313-my-open-opportunities-created-this-month"></a>3.13. My Open Opportunities Created This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [createdon](#index-createdon) | 100px |
| 3 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 4 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [createdon](#index-createdon) | this-month |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="314-my-open-opportunities-created-this-week"></a>3.14. My Open Opportunities Created This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [createdon](#index-createdon) | 100px |
| 3 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 4 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [createdon](#index-createdon) | this-week |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="315-my-open-opportunities-created-this-year"></a>3.15. My Open Opportunities Created This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [createdon](#index-createdon) | 100px |
| 3 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [createdon](#index-createdon) | this-fiscal-year |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="316-my-open-opportunities"></a>3.16. My Open Opportunities

- **Type:** Standard (querytype=0)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunitynumber](#index-azt_opportunitynumber) | 83px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 125px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 110px |
| 8 | [customerid](#index-customerid) | 125px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 300px |
| 10 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 11 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [statecode](#index-statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |

### <a id="317-my-open-renewal-opportunities-as-account-owner"></a>3.17. My Open Renewal Opportunities as Account Owner

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [customerid](#index-customerid) | 150px |
| 9 | [closeprobability](#index-closeprobability) | 100px |
| 10 | [createdon](#index-createdon) | 100px |
| 11 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Ascending |

### <a id="318-my-opportunities-closing-next-year"></a>3.18. My Opportunities Closing Next Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 100px |
| 2 | [name](#index-name) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 100px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 100px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket](#index-a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket) | 100px |
| 9 | [customerid](#index-customerid) | 100px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [azt_verticalmarket](#index-azt_verticalmarket) |  |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | next-year |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Descending |

### <a id="319-my-opportunities-closing-this-fiscal-quarter"></a>3.19. My Opportunities Closing This Fiscal Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 100px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket](#index-a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket) | 100px |
| 10 | [customerid](#index-customerid) | 150px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 12 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 125px |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [azt_verticalmarket](#index-azt_verticalmarket) |  |
| 16 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | this-fiscal-period |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |

### <a id="320-my-opportunities-closing-this-fiscal-year"></a>3.20. My Opportunities Closing This Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 125px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 125px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket](#index-a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket) | 100px |
| 10 | [customerid](#index-customerid) | 150px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 12 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 125px |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [azt_verticalmarket](#index-azt_verticalmarket) |  |
| 16 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | this-fiscal-year |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |

### <a id="321-my-opportunities-closing-this-month"></a>3.21. My Opportunities Closing This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 100px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 125px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 125px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 125px |
| 12 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 13 | [address1_city](#index-address1_city) |  |
| 14 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | this-month |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |

### <a id="322-my-opportunities-closing-this-week"></a>3.22. My Opportunities Closing This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 3 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | this-week |  |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="323-my-opportunities-created-this-quarter"></a>3.23. My Opportunities Created This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [createdby](#index-createdby) | 100px |
| 3 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 6 | [ownerid](#index-ownerid) | 100px |
| 7 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdby](#index-createdby) | eq-userid |  |
| [createdon](#index-createdon) | this-fiscal-period |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="324-my-opportunities-created-this-year"></a>3.24. My Opportunities Created This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [createdon](#index-createdon) | 100px |
| 3 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 4 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 5 | [ownerid](#index-ownerid) | 100px |
| 6 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdby](#index-createdby) | eq-userid |  |
| [createdon](#index-createdon) | this-fiscal-year |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="325-my-opportunities-won-this-quarter"></a>3.25. My Opportunities Won This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-fiscal-period |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="326-my-opportunities-won-this-year-no-renewals"></a>3.26. My Opportunities Won This Year No Renewals

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 125px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#index-createdon) | 100px |
| 13 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 14 | [address1_city](#index-address1_city) |  |
| 15 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-fiscal-year |  |
| [azt_opportunitytype](#index-azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Ascending |

### <a id="327-my-overdue-opportunities"></a>3.27. My Overdue Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 3 | [estimatedclosedate](#index-estimatedclosedate) | 125px |
| 4 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 5 | [azt_probability](#index-azt_probability) | 100px |
| 6 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 7 | [customerid](#index-customerid) | 150px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_composite](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_composite) | 300px |
| 9 | [address1_composite](#index-address1_composite) |  |
| 10 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [ownerid](#index-ownerid) | eq-userid |  |
| [estimatedclosedate](#index-estimatedclosedate) | olderthan-x-days | 1 |
| [statecode](#index-statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |

### <a id="328-my-overdue-opps"></a>3.28. My Overdue Opps

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probabilitychangedon](#index-azt_probabilitychangedon) | 150px |
| 2 | [customerid](#index-customerid) | 200px |
| 3 | [name](#index-name) | 200px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedvalue](#index-estimatedvalue) | 125px |
| 6 | [azt_probability](#index-azt_probability) | 100px |
| 7 | [estimatedclosedate](#index-estimatedclosedate) | 125px |
| 8 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | olderthan-x-days | 45 |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [statecode](#index-statecode) | eq | 0 |
| [azt_opportunitytype](#index-azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Descending |

### <a id="329-my-stalled-opportunities"></a>3.29. My Stalled Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probabilitychangedon](#index-azt_probabilitychangedon) | 150px |
| 2 | [customerid](#index-customerid) | 200px |
| 3 | [name](#index-name) | 200px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedvalue](#index-estimatedvalue) | 125px |
| 6 | [azt_probability](#index-azt_probability) | 100px |
| 7 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 8 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [azt_probabilitychangedon](#index-azt_probabilitychangedon) | olderthan-x-days | 60 |
| [statecode](#index-statecode) | eq | 0 |
| [azt_opportunitytype](#index-azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Descending |

### <a id="330-my-won-opps-this-year"></a>3.30. My Won Opps this Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [actualclosedate](#index-actualclosedate) | 125px |
| 5 | [actualvalue](#index-actualvalue) | 100px |
| 6 | [customerid](#index-customerid) | 150px |
| 7 | [ownerid](#index-ownerid) | 150px |
| 8 | [statuscode](#index-statuscode) | 150px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.ownerid](#index-a_ef7baa35fe04e911a94d000d3a3b9f01ownerid) | 100px |
| 10 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-year |  |
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#index-actualvalue) | Descending |

### <a id="331-open-opportunities-by-sales-rep"></a>3.31. Open Opportunities by Sales Rep

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 3 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 4 | [customerid](#index-customerid) | 100px |
| 5 | [closeprobability](#index-closeprobability) | 100px |
| 6 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 7 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | this-fiscal-period |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="332-open-opportunities"></a>3.32. Open Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdon](#index-createdon) | 100px |
| 2 | [azt_dayssincecreated](#index-azt_dayssincecreated) | 100px |
| 3 | [name](#index-name) | 300px |
| 4 | [azt_opportunitynumber](#index-azt_opportunitynumber) | 87px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [azt_dayssinceprobabilitychanged](#index-azt_dayssinceprobabilitychanged) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 13 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 14 | [a_ef7baa35fe04e911a94d000d3a3b9f01.ownerid](#index-a_ef7baa35fe04e911a94d000d3a3b9f01ownerid) | 100px |
| 15 | [statecode](#index-statecode) | 150px |
| 16 | [ownerid](#index-ownerid) |  |
| 17 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 18 | [address1_city](#index-address1_city) |  |
| 19 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |

### <a id="333-open-renewal-opps-90-days-past-due"></a>3.33. Open Renewal Opps 90 Days Past Due

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 5 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | olderthan-x-months | 3 |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="334-open-renewal-opps-close-date-last-month"></a>3.34. Open Renewal Opps Close Date Last Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 5 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | last-month |  |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="335-open-renewal-opps-closing-next-month"></a>3.35. Open Renewal Opps Closing Next Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 5 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | next-month |  |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="336-open-renewal-opps-closing-this-month"></a>3.36. Open Renewal Opps Closing This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 5 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | this-month |  |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="337-open-renewal-opps-closing-within-90-days"></a>3.37. Open Renewal Opps Closing Within 90 Days

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 5 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | next-x-months | 3 |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="338-opportunities-closing-next-fiscal-year"></a>3.38. Opportunities Closing Next Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#index-azt_accountclassification) | 100px |
| 2 | [name](#index-name) | 300px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 7 | [azt_probability](#index-azt_probability) | 75px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 13 | [address1_city](#index-address1_city) |  |
| 14 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | next-fiscal-year |  |
| [statecode](#index-statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="339-opportunities-closing-next-month"></a>3.39. Opportunities Closing Next Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [customerid](#index-customerid) | 150px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 10 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 11 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | next-month |  |
| [statecode](#index-statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |

### <a id="340-opportunities-closing-this-month"></a>3.40. Opportunities Closing This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 3 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 4 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | this-month |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="341-opportunities-closing-this-week"></a>3.41. Opportunities Closing This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 3 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 4 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | this-week |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="342-opportunities-created-this-year"></a>3.42. Opportunities Created This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdby](#index-createdby) | 100px |
| 2 | [createdon](#index-createdon) | 150px |
| 3 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 4 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 5 | [ownerid](#index-ownerid) | 100px |
| 6 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#index-createdon) | this-fiscal-year |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdby](#index-createdby) | Ascending |

### <a id="343-opportunities-in-current-fiscal-year"></a>3.43. Opportunities in Current Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probability](#index-azt_probability) | 100px |
| 2 | [name](#index-name) | 100px |
| 3 | [customerid](#index-customerid) | 100px |
| 4 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 5 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 6 | [statecode](#index-statecode) | 100px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 9 | [actualvalue](#index-actualvalue) | 100px |
| 10 | [ownerid](#index-ownerid) | 100px |
| 11 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 12 | [address1_city](#index-address1_city) |  |
| 13 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | this-fiscal-year |  |
| [statecode](#index-statecode) | in |  |
| [statecode](#index-statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#index-actualvalue) | Ascending |
| [estimatedclosedate](#index-estimatedclosedate) | Descending |

### <a id="344-opportunities-opened-last-week"></a>3.44. Opportunities Opened Last Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [ownerid](#index-ownerid) | 150px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 13 | [address1_city](#index-address1_city) |  |
| 14 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#index-createdon) | last-week |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedvalue](#index-estimatedvalue) | Descending |

### <a id="345-opportunities-opened-this-month"></a>3.45. Opportunities Opened This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [createdby](#index-createdby) | 100px |
| 3 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 4 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 5 | [ownerid](#index-ownerid) | 100px |
| 6 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#index-createdon) | this-month |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdby](#index-createdby) | Ascending |

### <a id="346-opportunities-opened-this-quarter"></a>3.46. Opportunities Opened This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdby](#index-createdby) | 100px |
| 2 | [createdon](#index-createdon) | 100px |
| 3 | [name](#index-name) | 150px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 6 | [ownerid](#index-ownerid) | 100px |
| 7 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#index-createdon) | this-fiscal-period |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="347-opportunities-opened-this-week"></a>3.47. Opportunities Opened This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [ownerid](#index-ownerid) | 150px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 13 | [address1_city](#index-address1_city) |  |
| 14 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#index-createdon) | this-week |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedvalue](#index-estimatedvalue) | Descending |

### <a id="348-opportunities-opened-this-week"></a>3.48. Opportunities Opened This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [ownerid](#index-ownerid) | 100px |
| 2 | [createdby](#index-createdby) | 100px |
| 3 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 4 | [createdon](#index-createdon) | 100px |
| 5 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 6 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [createdon](#index-createdon) | this-week |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [ownerid](#index-ownerid) | Ascending |

### <a id="349-opportunity-advanced-find-view"></a>3.49. Opportunity Advanced Find View

- **Type:** Advanced Find (querytype=1)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [ownerid](#index-ownerid) | 150px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [statuscode](#index-statuscode) | 150px |
| 11 | [opportunityid](#index-opportunityid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="350-opportunity-associated-view"></a>3.50. Opportunity Associated View

- **Type:** Associated View (querytype=2)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [actualvalue](#index-actualvalue) | 100px |
| 9 | [ownerid](#index-ownerid) | 150px |
| 10 | [customerid](#index-customerid) | 150px |
| 11 | [opportunityid](#index-opportunityid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="351-opportunity-lookup-view"></a>3.51. Opportunity Lookup View

- **Type:** Lookup View (querytype=64)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | ne | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="352-out-of-territory-opportunities-open"></a>3.52. Out of Territory Opportunities - Open

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 2 | [azt_dayssincecreated](#index-azt_dayssincecreated) | 100px |
| 3 | [azt_dayssinceprobabilitychanged](#index-azt_dayssinceprobabilitychanged) | 100px |
| 4 | [name](#index-name) | 300px |
| 5 | [azt_opportunitytype](#index-azt_opportunitytype) | 100px |
| 6 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 7 | [azt_probability](#index-azt_probability) | 100px |
| 8 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 9 | [ownerid](#index-ownerid) | 100px |
| 10 | [customerid](#index-customerid) | 100px |
| 11 | [statuscode](#index-statuscode) | 100px |
| 12 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [new_sharedwith](#index-new_sharedwith) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="353-overdue-opportunities-45-days"></a>3.53. Overdue Opportunities > 45 Days

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [owningbusinessunit](#index-owningbusinessunit) | 150px |
| 2 | [customerid](#index-customerid) | 200px |
| 3 | [name](#index-name) | 200px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 100px |
| 7 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 8 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 9 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | olderthan-x-days | 45 |
| [statecode](#index-statecode) | eq | 0 |
| [azt_opportunitytype](#index-azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="354-quick-find-open-opportunities"></a>3.54. Quick Find Open Opportunities

- **Type:** Quick Find (querytype=4)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [ownerid](#index-ownerid) | 150px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [name](#index-name) | like | {0} |
| [azt_opportunitytype](#index-azt_opportunitytype) | like | {0} |
| [azt_opportunitynumber](#index-azt_opportunitynumber) | like | {0} |
| [parentcontactid](#index-parentcontactid) | like | {0} |
| [parentaccountid](#index-parentaccountid) | like | {0} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="355-recent-opportunities"></a>3.55. Recent Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#index-azt_pipelinestage) | 100px |
| 6 | [azt_probability](#index-azt_probability) | 75px |
| 7 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 8 | [ownerid](#index-ownerid) | 150px |
| 9 | [customerid](#index-customerid) | 150px |
| 10 | [statecode](#index-statecode) | 100px |
| 11 | [actualclosedate](#index-actualclosedate) | 100px |
| 12 | [actualvalue](#index-actualvalue) | 100px |
| 13 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [actualclosedate](#index-actualclosedate) | last-x-months | 12 |
| [statecode](#index-statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [statecode](#index-statecode) | Ascending |
| [estimatedclosedate](#index-estimatedclosedate) | Descending |
| [modifiedon](#index-modifiedon) | Descending |

### <a id="356-self-sourced-pipeline-per-rep-in-last-30-days"></a>3.56. Self Sourced Pipeline per rep in Last 30 Days

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [customerid](#index-customerid) | 200px |
| 2 | [name](#index-name) | 200px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 150px |
| 4 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 5 | [azt_probability](#index-azt_probability) | 100px |
| 6 | [estimatedclosedate](#index-estimatedclosedate) | 100px |
| 7 | [owningbusinessunit](#index-owningbusinessunit) | 100px |
| 8 | [azt_recordownerid](#index-azt_recordownerid) | 150px |
| 9 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_leadsourceid](#index-azt_leadsourceid) | eq | {C9910CBF-EC69-EF11-BFE2-000D3A9A34C1} |
| [createdon](#index-createdon) | last-x-days | 30 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | Ascending |
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="357-upcoming-internet-renewals"></a>3.57. Upcoming Internet Renewals

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 4 | [azt_probability](#index-azt_probability) | 100px |
| 5 | [estimatedvalue](#index-estimatedvalue) | 100px |
| 6 | [customerid](#index-customerid) | 150px |
| 7 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 9 | [ownerid](#index-ownerid) | 150px |
| 10 | [statuscode](#index-statuscode) | 100px |
| 11 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 12 | [address1_city](#index-address1_city) |  |
| 13 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | next-x-months | 3 |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="358-won-opportunities-this-month"></a>3.58. Won Opportunities This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 3 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualclosedate](#index-actualclosedate) | this-month |  |
| [statecode](#index-statecode) | eq | 1 |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="359-won-opportunities-this-quarter"></a>3.59. Won Opportunities This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [ownerid](#index-ownerid) | 100px |
| 2 | [createdon](#index-createdon) | 100px |
| 3 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualclosedate](#index-actualclosedate) | this-fiscal-period |  |
| [statecode](#index-statecode) | eq | 1 |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [ownerid](#index-ownerid) | Ascending |

### <a id="360-won-opportunities-this-week"></a>3.60. Won Opportunities This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 3 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-week |  |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="361-won-opportunities-this-year"></a>3.61. Won Opportunities This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-year |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="362-won-opportunities"></a>3.62. Won Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [azt_opportunitynumber](#index-azt_opportunitynumber) | 85px |
| 3 | [azt_opportunityproductcategory](#index-azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#index-azt_opportunitytype) | 125px |
| 5 | [actualclosedate](#index-actualclosedate) | 125px |
| 6 | [actualvalue](#index-actualvalue) | 100px |
| 7 | [customerid](#index-customerid) | 150px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 10 | [ownerid](#index-ownerid) | 150px |
| 11 | [statuscode](#index-statuscode) | 150px |
| 12 | [address1_stateorprovince](#index-address1_stateorprovince) |  |
| 13 | [address1_city](#index-address1_city) |  |
| 14 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#index-actualvalue) | Descending |

### <a id="363-won-renewal-opps-this-month"></a>3.63. Won Renewal Opps This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [actualclosedate](#index-actualclosedate) | 100px |
| 5 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 6 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-month |  |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="364-won-renewal-opps-this-quarter"></a>3.64. Won Renewal Opps This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [actualclosedate](#index-actualclosedate) | 100px |
| 5 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 6 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-fiscal-period |  |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

### <a id="365-won-renewal-opps-this-year"></a>3.65. Won Renewal Opps This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 150px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | 150px |
| 4 | [actualclosedate](#index-actualclosedate) | 100px |
| 5 | [azt_recordownerid](#index-azt_recordownerid) | 100px |
| 6 | [opportunityid](#index-opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |
| [actualclosedate](#index-actualclosedate) | this-year |  |
| [azt_opportunitytype](#index-azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | Ascending |

---

## <a id="4-chart-visualizations"></a>4. Chart Visualizations

Total charts: **39**

### <a id="41-closing-this-fiscal-year"></a>4.1. Closing This Fiscal Year

- **Visualization ID:** `{06B6016E-7942-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="42-closing-this-fiscal-quarter"></a>4.2. Closing this Fiscal Quarter

- **Visualization ID:** `{E0C0D292-7942-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="43-closing-this-month"></a>4.3. Closing This Month

- **Visualization ID:** `{BCC5130E-7B42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="44-initialadd-on-opened-this-month"></a>4.4. Initial/Add-on Opened This Month

- **Visualization ID:** `{E777E51F-7C42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="45-initialadd-on-opportunities-added-last-week"></a>4.5. Initial/Add-on Opportunities Added Last Week

- **Visualization ID:** `{D1F0FB58-7D42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="46-initialadd-on-added-this-week"></a>4.6. Initial/Add-on Added This Week

- **Visualization ID:** `{64598626-7E42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="47-invoiced-but-unpaid-in-last-90-days"></a>4.7. Invoiced but Unpaid in Last 90 Days

- **Visualization ID:** `{10B71290-7F42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="48-won-this-fiscal-year"></a>4.8. Won This Fiscal Year

- **Visualization ID:** `{49CEA254-8042-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualvalue](#index-actualvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="49-won-this-year-no-renewals"></a>4.9. Won This Year (No Renewals)

- **Visualization ID:** `{EA74DAAA-8042-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualvalue](#index-actualvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#index-ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="410-opportunities-opened-this-quarter-by-rep"></a>4.10. Opportunities Opened This Quarter By Rep

- **Visualization ID:** `{5EBA1132-A7E2-EB11-BACB-000D3A5AC826}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#index-createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="411-won-opportunities-this-quarter-by-rep"></a>4.11. Won Opportunities This Quarter By Rep

- **Visualization ID:** `{9EBD86E0-A7E2-EB11-BACB-000D3A5AC826}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="412-my-opportunities-created-this-quarter"></a>4.12. My Opportunities Created This Quarter

- **Visualization ID:** `{ECDDB271-66E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#index-createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="413-my-opportunities-closing-this-quarter"></a>4.13. My Opportunities Closing This Quarter

- **Visualization ID:** `{DEC70FB3-67E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="414-my-opportunities-won-this-quarter"></a>4.14. My Opportunities Won This Quarter

- **Visualization ID:** `{1781BA01-68E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="415-my-opportunities-created-this-year-by-quarter"></a>4.15. My Opportunities Created This Year By Quarter

- **Visualization ID:** `{32C03EC3-6CE2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdon](#index-createdon) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### <a id="416-my-open-opportunities-created-this-year-by-quarter"></a>4.16. My Open Opportunities Created This Year By Quarter

- **Visualization ID:** `{F83F178E-6DE2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdon](#index-createdon) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### <a id="417-my-won-opportunities-this-year-by-quarter"></a>4.17. My Won Opportunities This Year By Quarter

- **Visualization ID:** `{5D9A3811-6EE2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [actualclosedate](#index-actualclosedate) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### <a id="418-opportunities-created-this-year-by-owner"></a>4.18. Opportunities Created This Year By Owner

- **Visualization ID:** `{E8057C5A-86E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdon](#index-createdon) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### <a id="419-open-opportunities-by-owner"></a>4.19. Open Opportunities By Owner

- **Visualization ID:** `{67D2CBA1-86E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="420-won-opportunities-this-year-by-owner"></a>4.20. Won Opportunities This Year By Owner

- **Visualization ID:** `{1854741E-87E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [actualclosedate](#index-actualclosedate) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### <a id="421-sales-pipeline"></a>4.21. Sales Pipeline

- **Visualization ID:** `{87293554-2482-DE11-9FF3-00155DA3B012}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#index-estimatedvalue) | sum | sum_estimatedvalue |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [closeprobability](#index-closeprobability) | stepname |  |

### <a id="422-opportunities-opened-this-month-by-rep"></a>4.22. Opportunities Opened This Month By Rep

- **Visualization ID:** `{7732E166-C001-EC11-94EF-002248047923}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#index-createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="423-opportunities-closing-this-month"></a>4.23. Opportunities Closing This Month

- **Visualization ID:** `{4B128E21-C101-EC11-94EF-002248047923}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | NumOppsOver70 |
| [azt_recordownerid](#index-azt_recordownerid) | count | NumOppsUnder70 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | RecordOwner |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | this-month |  |
| [closeprobability](#index-closeprobability) | ge | 70 |
| [statecode](#index-statecode) | eq | 0 |
| [estimatedclosedate](#index-estimatedclosedate) | this-month |  |
| [closeprobability](#index-closeprobability) | lt | 70 |
| [azt_jobrole](#index-azt_jobrole) | eq | 327630000 |

### <a id="424-won-opportunities-this-month"></a>4.24. Won Opportunities This Month

- **Visualization ID:** `{C3FCA470-C101-EC11-94EF-002248047923}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="425-opportunities-opened-this-week-by-rep"></a>4.25. Opportunities Opened This Week By Rep

- **Visualization ID:** `{872489E8-EF13-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#index-createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="426-opportunities-closing-this-week-by-rep"></a>4.26. Opportunities Closing This Week By Rep

- **Visualization ID:** `{56BEF679-F013-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="427-won-opportunities-this-week"></a>4.27. Won Opportunities This Week

- **Visualization ID:** `{65FF74C9-F013-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="428-my-opportunities-created-this-week"></a>4.28. My Opportunities Created This Week

- **Visualization ID:** `{095B2FF4-F513-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#index-createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="429-my-opportunities-closing-this-week"></a>4.29. My Opportunities Closing This Week

- **Visualization ID:** `{0A8E4D4E-F613-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="430-my-open-opportunities-created-this-month"></a>4.30. My Open Opportunities Created This Month

- **Visualization ID:** `{C7A5DA94-D538-ED11-9DB0-002248296C23}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#index-createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#index-createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="431-my-opportunities-closing-this-month"></a>4.31. My Opportunities Closing This Month

- **Visualization ID:** `{06205766-D638-ED11-9DB0-002248296C23}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="432-open-renewal-opps-close-date-last-month"></a>4.32. Open Renewal Opps Close Date Last Month

- **Visualization ID:** `{04DE3FDF-9E20-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="433-open-renewal-opps-closing-this-month"></a>4.33. Open Renewal Opps Closing This Month

- **Visualization ID:** `{D381ADF2-9E20-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="434-open-renewal-opps-closing-next-month"></a>4.34. Open Renewal Opps Closing Next Month

- **Visualization ID:** `{67F7F343-A020-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="435-open-renewal-opps-closing-within-90-days"></a>4.35. Open Renewal Opps Closing Within 90 Days

- **Visualization ID:** `{B9AB34C9-A020-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="436-open-renewal-opps-90-days-past-due"></a>4.36. Open Renewal Opps 90 Days Past Due

- **Visualization ID:** `{1F029EE6-A020-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#index-estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="437-won-renewal-opps-this-month"></a>4.37. Won Renewal Opps This Month

- **Visualization ID:** `{D1DD4BE2-A220-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualclosedate](#index-actualclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="438-won-renewal-opps-this-quarter"></a>4.38. Won Renewal Opps This Quarter

- **Visualization ID:** `{CA7A8DF6-A220-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualclosedate](#index-actualclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### <a id="439-won-renewal-opps-this-year"></a>4.39. Won Renewal Opps This Year

- **Visualization ID:** `{1E457E0A-A320-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualclosedate](#index-actualclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#index-azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

---

## <a id="5-reports"></a>5. Reports

Total reports referencing Opportunity: **0**

---

## <a id="6-dashboards"></a>6. Dashboards

Total dashboards referencing Opportunity: **11**

### <a id="61-client-relations-renewal-dashboard"></a>6.1. Client Relations Renewal Dashboard

- **Form ID:** `{2b0c524a-9f20-ef11-840b-6045bdd5f34a}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componentd535def` | opportunity | Chart | `{17E7AC77-9E20-EF11-840B-6045BDD5F34A}` | `{1F029EE6-A020-EF11-840B-6045BDD5F34A}` |
| `Componentf4cf2fb` | opportunity | Chart | `{CFDBF8FE-9C20-EF11-840B-6045BDD5F34A}` | `{04DE3FDF-9E20-EF11-840B-6045BDD5F34A}` |
| `Component2b674cc` | opportunity | Chart | `{0756FBB4-9D20-EF11-840B-6045BDD5F34A}` | `{D381ADF2-9E20-EF11-840B-6045BDD5F34A}` |
| `Component46e8301` | opportunity | Chart | `{839BAC63-9D20-EF11-840B-6045BDD5F34A}` | `{67F7F343-A020-EF11-840B-6045BDD5F34A}` |
| `Componentadb213a` | opportunity | Chart | `{F10D772A-9E20-EF11-840B-6045BDD5F34A}` | `{B9AB34C9-A020-EF11-840B-6045BDD5F34A}` |
| `Component07995da` | opportunity | Chart | `{EAC40C3B-A220-EF11-840B-6045BDD5F34A}` | `{D1DD4BE2-A220-EF11-840B-6045BDD5F34A}` |
| `Component898648` | opportunity | Chart | `{B4347D74-A220-EF11-840B-6045BDD5F34A}` | `{CA7A8DF6-A220-EF11-840B-6045BDD5F34A}` |
| `Component7894237` | opportunity | Chart | `{906FD0AD-A220-EF11-840B-6045BDD5F34A}` | `{1E457E0A-A320-EF11-840B-6045BDD5F34A}` |

### <a id="62-executive-sales-measurement-pipeline"></a>6.2. Executive Sales Measurement Pipeline

- **Form ID:** `{440de58f-6060-ef11-bfe2-7c1e52158f4e}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component6941e2b` | opportunity | Grid | `{CB6F754B-6060-EF11-BFE2-7C1E52158F4E}` | `` |
| `Component4ae8fb8` | opportunity | Grid | `{BEC25DEE-5E68-EF11-BFE2-000D3A9A34C1}` | `` |
| `Componentfb0a8b7` | lead | Grid | `{9D1294F7-AB6A-EF11-BFE2-000D3A18BCFA}` | `` |
| `Component94e0c6c` | opportunity | Grid | `{9AE8C70E-AD6A-EF11-BFE2-000D3A18BCFA}` | `` |
| `Component8866206` | opportunity | Grid | `{628942DC-AD6A-EF11-BFE2-000D3A18BCFA}` | `` |

### <a id="63-monthly-account-manager-kpis"></a>6.3. Monthly Account Manager KPIs

- **Form ID:** `{1fa94e0f-c201-ec11-94ef-002248047923}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componentdc6ad51` | appointment | Chart | `{2BC5732E-BE01-EC11-94EF-002248047923}` | `{77750752-BE01-EC11-94EF-002248047923}` |
| `Componentcd46053` | appointment | Chart | `{7462FD27-BF01-EC11-94EF-002248047923}` | `{5E815954-BF01-EC11-94EF-002248047923}` |
| `Component9b5f73e` | phonecall | Chart | `{43D79997-BF01-EC11-94EF-002248047923}` | `{6B48FBAA-BF01-EC11-94EF-002248047923}` |
| `Component933431a` | appointment | Chart | `{DC688BF0-BF01-EC11-94EF-002248047923}` | `{B4A08E12-C001-EC11-94EF-002248047923}` |
| `Component45f49dd` | opportunity | Chart | `{25871C52-C001-EC11-94EF-002248047923}` | `{7732E166-C001-EC11-94EF-002248047923}` |
| `Componente47ea5d` | opportunity | Chart | `{1877DF0E-C101-EC11-94EF-002248047923}` | `{4B128E21-C101-EC11-94EF-002248047923}` |
| `Component688743` | opportunity | Chart | `{6051F860-C101-EC11-94EF-002248047923}` | `{C3FCA470-C101-EC11-94EF-002248047923}` |
| `Component5313930` | email | Chart | `{8007F667-DC81-EC11-8D21-00224804C2A2}` | `{2C86C148-DF81-EC11-8D21-00224804C2A2}` |

### <a id="64-my-annual-kpis"></a>6.4. My Annual KPIs

- **Form ID:** `{b3846a84-68e2-eb11-bacb-000d3a5acbf1}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componentc31502c` | appointment | Chart | `{07E7DBA1-7FE2-EB11-BACB-000D3A5ACBF1}` | `{C4B543BE-7FE2-EB11-BACB-000D3A5ACBF1}` |
| `Component65cd505` | appointment | Chart | `{FB7E0139-6BE2-EB11-BACB-000D3A5ACBF1}` | `{1BCB3D49-6BE2-EB11-BACB-000D3A5ACBF1}` |
| `Componentcf975f6` | appointment | Chart | `{38C91C1E-69E2-EB11-BACB-000D3A5ACBF1}` | `{1A30D739-69E2-EB11-BACB-000D3A5ACBF1}` |
| `Component96df6f9` | phonecall | Chart | `{6F8BB2B0-6BE2-EB11-BACB-000D3A5ACBF1}` | `{285363BE-6BE2-EB11-BACB-000D3A5ACBF1}` |
| `Component2c01a91` | opportunity | Chart | `{9563F9A2-6CE2-EB11-BACB-000D3A5ACBF1}` | `{32C03EC3-6CE2-EB11-BACB-000D3A5ACBF1}` |
| `Componentea66979` | opportunity | Chart | `{F8AA1E7B-6DE2-EB11-BACB-000D3A5ACBF1}` | `{32C03EC3-6CE2-EB11-BACB-000D3A5ACBF1}` |
| `Component6127653` | opportunity | Chart | `{561F18ED-F77B-E911-A95A-000D3A3B9825}` | `{5D9A3811-6EE2-EB11-BACB-000D3A5ACBF1}` |

### <a id="65-my-monthly-kpis"></a>6.5. My Monthly KPI's

- **Form ID:** `{5f27d924-d238-ed11-9db0-002248296c23}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componenta855ffe` | appointment | Chart | `{3E5ADF87-D238-ED11-9DB0-002248296C23}` | `{9A7F1E11-D338-ED11-9DB0-002248296C23}` |
| `Componentac57689` | appointment | Chart | `{7B6BC3C8-D238-ED11-9DB0-002248296C23}` | `{94D9B91E-D338-ED11-9DB0-002248296C23}` |
| `Component0d4876b` | phonecall | Chart | `{8A663A58-D338-ED11-9DB0-002248296C23}` | `{B2D8B73A-D538-ED11-9DB0-002248296C23}` |
| `Componentc4bb2f1` | appointment | Chart | `{9B287594-D338-ED11-9DB0-002248296C23}` | `{4845C870-D538-ED11-9DB0-002248296C23}` |
| `Component96faee5` | opportunity | Chart | `{F2A8DD35-D438-ED11-9DB0-002248296C23}` | `{C7A5DA94-D538-ED11-9DB0-002248296C23}` |
| `Componentab61efa` | opportunity | Chart | `{4F826EE3-7A42-EA11-A812-000D3A3B3EF9}` | `{06205766-D638-ED11-9DB0-002248296C23}` |
| `Component6123897` | email | Chart | `{1D36FBEE-DC81-EC11-8D21-00224804C2A2}` | `{0B52BCD3-E481-EC11-8D21-00224804C2A2}` |

### <a id="66-my-pipeline-dashboard"></a>6.6. My Pipeline Dashboard

- **Form ID:** `{3ee3f0d0-7942-ea11-a812-000d3a3b3ef9}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component141b0ad` | opportunity | Chart | `{85FC6E26-7842-EA11-A812-000D3A3B3EF9}` | `{06B6016E-7942-EA11-A812-000D3A3B3EF9}` |
| `Component91e8ac6` | opportunity | Chart | `{4EFF41F2-7842-EA11-A812-000D3A3B3EF9}` | `{E0C0D292-7942-EA11-A812-000D3A3B3EF9}` |
| `Componente3aea83` | opportunity | Chart | `{4F826EE3-7A42-EA11-A812-000D3A3B3EF9}` | `{BCC5130E-7B42-EA11-A812-000D3A3B3EF9}` |
| `Component67d2acf` | opportunity | Chart | `{40DF80F4-7B42-EA11-A812-000D3A3B3EF9}` | `{E777E51F-7C42-EA11-A812-000D3A3B3EF9}` |
| `Component9e12cc8` | opportunity | Chart | `{98764B40-7D42-EA11-A812-000D3A3B3EF9}` | `{D1F0FB58-7D42-EA11-A812-000D3A3B3EF9}` |
| `Component04e4761` | opportunity | Chart | `{370A040D-7E42-EA11-A812-000D3A3B3EF9}` | `{64598626-7E42-EA11-A812-000D3A3B3EF9}` |
| `Component1612834` | invoice | Chart | `{76D8E467-E442-EA11-A812-000D3A3B3EF9}` | `{E03E3180-E442-EA11-A812-000D3A3B3EF9}` |

### <a id="67-my-quarterly-kpis"></a>6.7. My Quarterly KPIs

- **Form ID:** `{8e596017-61e2-eb11-bacb-000d3a5acbf1}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component685b831` | appointment | Chart | `{478B8C6C-60E2-EB11-BACB-000D3A5ACBF1}` | `{76199AFD-60E2-EB11-BACB-000D3A5ACBF1}` |
| `Component11e5684` | appointment | Chart | `{5C1C2563-62E2-EB11-BACB-000D3A5ACBF1}` | `{03C6039E-96E2-EB11-BACB-000D3A5ACAF8}` |
| `Component0100707` | phonecall | Chart | `{E7C24441-64E2-EB11-BACB-000D3A5ACBF1}` | `{D70ACA64-64E2-EB11-BACB-000D3A5ACBF1}` |
| `Component548c7c2` | appointment | Chart | `{D430962C-65E2-EB11-BACB-000D3A5ACBF1}` | `{6D47FB3B-65E2-EB11-BACB-000D3A5ACBF1}` |
| `Component576e70e` | opportunity | Chart | `{00000000-0000-0000-00AA-000010003000}` | `{ECDDB271-66E2-EB11-BACB-000D3A5ACBF1}` |
| `Componenta54d162` | opportunity | Chart | `{4EFF41F2-7842-EA11-A812-000D3A3B3EF9}` | `{DEC70FB3-67E2-EB11-BACB-000D3A5ACBF1}` |
| `Component9827797` | opportunity | Chart | `{5D3E70F4-67E2-EB11-BACB-000D3A5ACBF1}` | `{1781BA01-68E2-EB11-BACB-000D3A5ACBF1}` |

### <a id="68-my-weekly-kpis"></a>6.8. My Weekly KPIs

- **Form ID:** `{89f5d38e-f413-ec11-b6e6-002248047cfa}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componenta37f9a8` | appointment | Chart | `{35866754-F413-EC11-B6E6-002248047CFA}` | `{F1B7A76D-F413-EC11-B6E6-002248047CFA}` |
| `Component9eb99e0` | appointment | Chart | `{D577F1C6-F413-EC11-B6E6-002248047CFA}` | `{7F91D9D1-F413-EC11-B6E6-002248047CFA}` |
| `Componentcb35b24` | phonecall | Chart | `{8FDAE10D-F513-EC11-B6E6-002248047CFA}` | `{6F88541F-F513-EC11-B6E6-002248047CFA}` |
| `Component768c494` | appointment | Chart | `{5021D162-F513-EC11-B6E6-002248047CFA}` | `{FC05B970-F513-EC11-B6E6-002248047CFA}` |
| `Component0f71e97` | opportunity | Chart | `{B8C65EBD-F513-EC11-B6E6-002248047CFA}` | `{095B2FF4-F513-EC11-B6E6-002248047CFA}` |
| `Componentde6c609` | opportunity | Chart | `{E576BB37-F613-EC11-B6E6-002248047CFA}` | `{0A8E4D4E-F613-EC11-B6E6-002248047CFA}` |
| `Component169859` | email | Chart | `{6A69422A-E381-EC11-8D21-00224804C2A2}` | `{306D2DC0-D138-ED11-9DB0-002248296C23}` |

### <a id="69-quarterly-account-manager-kpis"></a>6.9. Quarterly Account Manager KPIs

- **Form ID:** `{5aaaa1d5-7fe2-eb11-bacb-000d3a5acbf1}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component63e7361` | appointment | Chart | `{F5C741F0-99E2-EB11-BACB-000D3A5ACAF8}` | `{BFF22505-9AE2-EB11-BACB-000D3A5ACAF8}` |
| `Componentf699b11` | appointment | Chart | `{519EB137-9AE2-EB11-BACB-000D3A5ACAF8}` | `{8F61FD45-9AE2-EB11-BACB-000D3A5ACAF8}` |
| `Component7b77487` | phonecall | Chart | `{EC4C3AA8-99E2-EB11-BACB-000D3A5ACAF8}` | `{F84C78B8-99E2-EB11-BACB-000D3A5ACAF8}` |
| `Component33f7ea4` | appointment | Chart | `{92E32860-99E2-EB11-BACB-000D3A5ACAF8}` | `{458B5E74-99E2-EB11-BACB-000D3A5ACAF8}` |
| `Component54cb200` | opportunity | Chart | `{2E39C8FB-A6E2-EB11-BACB-000D3A5AC826}` | `{5EBA1132-A7E2-EB11-BACB-000D3A5AC826}` |
| `Componentf6ce56a` | opportunity | Chart | `{EB6B428A-4D00-EC11-94EF-0022480477B4}` | `{67D2CBA1-86E2-EB11-BACB-000D3A5ACBF1}` |
| `Component2608049` | opportunity | Chart | `{5E2D82C5-A7E2-EB11-BACB-000D3A5AC826}` | `{9EBD86E0-A7E2-EB11-BACB-000D3A5AC826}` |
| `Component4225729` | email | Chart | `{9E47D484-DC81-EC11-8D21-00224804C2A2}` | `{D444DFB6-E481-EC11-8D21-00224804C2A2}` |

### <a id="610-sales-activity-social-dashboard"></a>6.10. Sales Activity Social Dashboard

- **Form ID:** `{7aae400f-3c70-ef11-a670-000d3a18bcfa}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component724229e` | opportunity | Chart | `{00000000-0000-0000-00AA-000010003000}` | `{87293554-2482-DE11-9FF3-00155DA3B012}` |
| `Component99072d2` | lead | Chart | `{00000000-0000-0000-00AA-000010001005}` | `{F2BDF989-3A70-EF11-A670-000D3A18BCFA}` |
| `Component0be9445` | lead | Grid | `{01C7B387-3C70-EF11-A670-000D3A18BCFA}` | `` |
| `Component88c76fb` | activitypointer | Grid | `{00000000-0000-0000-00AA-000010001899}` | `` |
| `Componentbebdf0e` | opportunity | Grid | `{C14FA68C-3F70-EF11-A670-000D3A18BCFA}` | `` |
| `Component3ec1d01` | opportunity | Grid | `{DB2ECC96-3E70-EF11-A670-000D3A18BCFA}` | `` |
| `Component3307204` | activitypointer | Grid | `{00000000-0000-0000-00AA-000010001899}` | `` |

### <a id="611-weekly-account-manager-kpis"></a>6.11. Weekly Account Manager KPIs

- **Form ID:** `{48c840e4-ed13-ec11-b6e6-002248047cfa}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component799d3cc` | appointment | Chart | `{14C98D1D-F113-EC11-B6E6-002248047CFA}` | `{0E8B8E32-F113-EC11-B6E6-002248047CFA}` |
| `Componentf1ae43c` | appointment | Chart | `{EFA3D356-ED13-EC11-B6E6-002248047CFA}` | `{869AA5B6-EE13-EC11-B6E6-002248047CFA}` |
| `Component41b9255` | phonecall | Chart | `{83AE7514-EE13-EC11-B6E6-002248047CFA}` | `{AEC2F1D0-EE13-EC11-B6E6-002248047CFA}` |
| `Componentc703054` | appointment | Chart | `{7C899555-EE13-EC11-B6E6-002248047CFA}` | `{73FCD2E7-EE13-EC11-B6E6-002248047CFA}` |
| `Component4a7f42f` | opportunity | Chart | `{00000000-0000-0000-00AA-000010003004}` | `{872489E8-EF13-EC11-B6E6-002248047CFA}` |
| `Component7155ca7` | opportunity | Chart | `{412E054A-F013-EC11-B6E6-002248047CFA}` | `{56BEF679-F013-EC11-B6E6-002248047CFA}` |
| `Component5548817` | opportunity | Chart | `{CD3305B2-F013-EC11-B6E6-002248047CFA}` | `{65FF74C9-F013-EC11-B6E6-002248047CFA}` |
| `Component9639795` | email | Chart | `{D99372F3-E281-EC11-8D21-00224804C2A2}` | `{EFC52CA8-E481-EC11-8D21-00224804C2A2}` |

---

## <a id="7-workflows"></a>7. Workflows

Total workflows referencing Opportunity: **70**

### <a id="71-0changequoterecordowner"></a>7.1. 0ChangeQuoteRecordOwner

- **File:** `0ChangeQuoteRecordOwner-938FE262-FF96-42CB-8332-50B6A947A533.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="72-0engagementnames"></a>7.2. 0EngagementNames

- **File:** `0EngagementNames-BC419DA7-86F1-43E4-88B5-509514704A0C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#index-name)

### <a id="73-accountauto-assign"></a>7.3. AccountAuto-Assign

- **File:** `AccountAuto-Assign-6DE252A4-C0D8-4C6B-800E-3985440C88D1.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`

### <a id="74-allocationsassigntoteam"></a>7.4. AllocationsAssigntoTeam

- **File:** `AllocationsAssigntoTeam-B7D19816-C216-4C9D-81B7-9FE73CB2D066.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_allocatedlicense

**Fields Read:**

- [ownerid](#index-ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="75-appointmentauto-assign"></a>7.5. AppointmentAuto-Assign

- **File:** `AppointmentAuto-Assign-1A553A9D-514D-42CA-A9AE-73FEED04E1E5.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Appointment

**Fields Read:**

- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="76-batchconverttolead"></a>7.6. BatchConverttoLead

- **File:** `BatchConverttoLead-CC0F2DBB-B8CB-4B06-B891-DB6D97252DB8.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)
- [parentcontactid](#index-parentcontactid)

**Fields Written:**

- [azt_leadsourceid](#index-azt_leadsourceid)
- [parentaccountid](#index-parentaccountid)
- [statecode](#index-statecode)

### <a id="77-batchcreateengagements"></a>7.7. BatchCreateEngagements

- **File:** `BatchCreateEngagements-CC9CDFC6-4BC9-4635-B786-0C7BE2C34344.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)
- [statuscode](#index-statuscode)

### <a id="78-batchlooseopportunities"></a>7.8. BatchLooseOpportunities

- **File:** `BatchLooseOpportunities-BFF14F2D-338D-4CBD-B2CE-C0907E02E6C7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [actualvalue](#index-actualvalue)
- [name](#index-name)

### <a id="79-batchopportunitytransfer"></a>7.9. BatchOpportunityTransfer

- **File:** `BatchOpportunityTransfer-744FEB80-2251-4252-875E-ED9958CB448A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [!process_custom_attribute_url_](#index-process_custom_attribute_url_)
- [azt_recordownerid](#index-azt_recordownerid)
- [name](#index-name)
- [opportunityid](#index-opportunityid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)
- [name](#index-name)

### <a id="710-bulkchangeleadsource"></a>7.10. BulkChangeLeadSource

- **File:** `BulkChangeLeadSource-95E84234-8EE8-433E-B68A-78A0837A91CE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_leadsourceid](#index-azt_leadsourceid)

### <a id="711-casependingassignmentnotification"></a>7.11. CasePendingAssignmentNotification

- **File:** `CasePendingAssignmentNotification-177DE8B3-E0C3-4F1C-A7B5-DA84B3629AED.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#index-customerid)
- [ownerid](#index-ownerid)

### <a id="712-caserecordowner"></a>7.12. CaseRecordOwner

- **File:** `CaseRecordOwner-E2135799-C146-4E0B-A0A5-F9917895B23E.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#index-customerid)
- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="713-caserecordownerassign"></a>7.13. CaseRecordOwnerAssign

- **File:** `CaseRecordOwnerAssign-02EE1A9D-1658-4013-BF63-9C0E5C65AAD0.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#index-customerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### <a id="714-caserecordownerassignmentnotification"></a>7.14. CaseRecordOwnerAssignmentNotification

- **File:** `CaseRecordOwnerAssignmentNotification-2F6035E6-1FBC-476B-9C97-4554E8360B7C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)
- [customerid](#index-customerid)

### <a id="715-caseresolutionnotificationemail"></a>7.15. CaseResolutionNotificationEmail

- **File:** `CaseResolutionNotificationEmail-734E721F-7454-4437-8BAC-8B20F496DF12.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [statecode](#index-statecode)

### <a id="716-cloneanddeletequote"></a>7.16. CloneAndDeleteQuote

- **File:** `CloneAndDeleteQuote-1D87A694-5A08-4C93-9925-447BB4FE7DA6.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [azt_historicalowner](#index-azt_historicalowner)
- [customerid](#index-customerid)
- [ownerid](#index-ownerid)
- [pricelevelid](#index-pricelevelid)

### <a id="717-clonecommissionpayment"></a>7.17. CloneCommissionPayment

- **File:** `CloneCommissionPayment-7E83F6F0-D101-4045-B686-0B6C658CC9A2.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_commissionpayment

**Fields Written:**

- [ownerid](#index-ownerid)

### <a id="718-clonelicense"></a>7.18. CloneLicense

- **File:** `CloneLicense-49354120-2D2D-4DED-8C24-4ACA5F6D82D9.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="719-cloneopportunity"></a>7.19. CloneOpportunity

- **File:** `CloneOpportunity-1A3FF4B3-79FD-420C-8A10-375E8892CA44.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_accountclassification](#index-azt_accountclassification)
- [azt_deliverytype](#index-azt_deliverytype)
- [azt_fundingsource](#index-azt_fundingsource)
- [azt_historicalowner](#index-azt_historicalowner)
- [azt_internalaztecnotes](#index-azt_internalaztecnotes)
- [azt_opportunityproductcategory](#index-azt_opportunityproductcategory)
- [azt_opportunitytype](#index-azt_opportunitytype)
- [azt_pipelinestage](#index-azt_pipelinestage)
- [azt_probability](#index-azt_probability)
- [azt_recordownerid](#index-azt_recordownerid)
- [budgetamount](#index-budgetamount)
- [budgetstatus](#index-budgetstatus)
- [closeprobability](#index-closeprobability)
- [currentsituation](#index-currentsituation)
- [customerid](#index-customerid)
- [customerpainpoints](#index-customerpainpoints)
- [description](#index-description)
- [discountpercentage](#index-discountpercentage)
- [emailaddress](#index-emailaddress)
- [estimatedvalue](#index-estimatedvalue)
- [initialcommunication](#index-initialcommunication)
- [name](#index-name)
- [need](#index-need)
- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)
- [pricelevelid](#index-pricelevelid)
- [proposedsolution](#index-proposedsolution)
- [purchaseprocess](#index-purchaseprocess)
- [purchasetimeframe](#index-purchasetimeframe)
- [qualificationcomments](#index-qualificationcomments)
- [quotecomments](#index-quotecomments)

**Fields Written:**

- [azt_accountclassification](#index-azt_accountclassification)
- [azt_committoestimatedclose](#index-azt_committoestimatedclose)
- [azt_deliverytype](#index-azt_deliverytype)
- [azt_fundingsource](#index-azt_fundingsource)
- [azt_historicalowner](#index-azt_historicalowner)
- [azt_internalaztecnotes](#index-azt_internalaztecnotes)
- [azt_opportunityproductcategory](#index-azt_opportunityproductcategory)
- [azt_opportunitytype](#index-azt_opportunitytype)
- [azt_parentopportunityid](#index-azt_parentopportunityid)
- [azt_pipelinestage](#index-azt_pipelinestage)
- [azt_probability](#index-azt_probability)
- [azt_recordownerid](#index-azt_recordownerid)
- [budgetamount](#index-budgetamount)
- [budgetstatus](#index-budgetstatus)
- [captureproposalfeedback](#index-captureproposalfeedback)
- [closeprobability](#index-closeprobability)
- [completefinalproposal](#index-completefinalproposal)
- [completeinternalreview](#index-completeinternalreview)
- [confirminterest](#index-confirminterest)
- [currentsituation](#index-currentsituation)
- [customerid](#index-customerid)
- [customerneed](#index-customerneed)
- [customerpainpoints](#index-customerpainpoints)
- [decisionmaker](#index-decisionmaker)
- [description](#index-description)
- [developproposal](#index-developproposal)
- [discountpercentage](#index-discountpercentage)
- [emailaddress](#index-emailaddress)
- [estimatedvalue](#index-estimatedvalue)
- [evaluatefit](#index-evaluatefit)
- [filedebrief](#index-filedebrief)
- [identifycompetitors](#index-identifycompetitors)
- [identifycustomercontacts](#index-identifycustomercontacts)
- [identifypursuitteam](#index-identifypursuitteam)
- [initialcommunication](#index-initialcommunication)
- [isrevenuesystemcalculated](#index-isrevenuesystemcalculated)
- [name](#index-name)
- [need](#index-need)
- [opportunityratingcode](#index-opportunityratingcode)
- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)
- [presentfinalproposal](#index-presentfinalproposal)
- [presentproposal](#index-presentproposal)
- [pricelevelid](#index-pricelevelid)
- [prioritycode](#index-prioritycode)
- [proposedsolution](#index-proposedsolution)
- [purchaseprocess](#index-purchaseprocess)
- [purchasetimeframe](#index-purchasetimeframe)
- [pursuitdecision](#index-pursuitdecision)
- [qualificationcomments](#index-qualificationcomments)
- [quotecomments](#index-quotecomments)
- [resolvefeedback](#index-resolvefeedback)
- [salesstagecode](#index-salesstagecode)
- [sendthankyounote](#index-sendthankyounote)
- [transactioncurrencyid](#index-transactioncurrencyid)

### <a id="720-cloneorder"></a>7.20. CloneOrder

- **File:** `CloneOrder-D2A6AD48-A603-4150-BC84-72092AFB3D79.xaml`
- **Entity References:** opportunity
- **Primary Entity:** SalesOrder

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [customerid](#index-customerid)
- [pricelevelid](#index-pricelevelid)
- [statecode](#index-statecode)
- [statuscode](#index-statuscode)

### <a id="721-contactauto-assign"></a>7.21. ContactAuto-Assign

- **File:** `ContactAuto-Assign-25759C22-AE58-4CC7-81E1-9BBF37E76F3E.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Contact

**Fields Read:**

- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`
- `AztecPlugins.GetAcctTeamOwned`

### <a id="722-createleadfromleadgen"></a>7.22. CreateLeadFromLeadGen

- **File:** `CreateLeadFromLeadGen-2EA14729-4B62-4F91-95FA-76D258DA0831.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)
- [statecode](#index-statecode)

### <a id="723-createleadfromaccount"></a>7.23. CreateLeadfromAccount

- **File:** `CreateLeadfromAccount-B5E04C1C-B038-4018-B602-645B1E766884.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [azt_leadsourceid](#index-azt_leadsourceid)
- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)
- [statecode](#index-statecode)

### <a id="724-createsoftwarelicense"></a>7.24. CreateSoftwareLicense

- **File:** `CreateSoftwareLicense-82C11935-B2A2-4E45-94B4-F0EEA6641A08.xaml`
- **Entity References:** opportunity
- **Primary Entity:** SalesOrder

**Fields Written:**

- [customerid](#index-customerid)

### <a id="725-customleadcreation"></a>7.25. CustomLeadCreation

- **File:** `CustomLeadCreation-B26AC2BB-4660-4A50-9229-AD056DE0D9E1.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)

**Fields Written:**

- [azt_leadsourceid](#index-azt_leadsourceid)
- [statecode](#index-statecode)

### <a id="726-emaildeletesendquotedrafts"></a>7.26. EmailDeleteSendQuoteDrafts

- **File:** `EmailDeleteSendQuoteDrafts-ED77962D-F57D-4F2F-A580-1F5D27E1280C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#index-statuscode)

### <a id="727-emailremoveunsentemails"></a>7.27. EmailRemoveUnsentEmails

- **File:** `EmailRemoveUnsentEmails-2F1954B7-77B4-4D54-AA84-DBB10DFB6A71.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#index-statuscode)

### <a id="728-engagementrecordowner"></a>7.28. EngagementRecordOwner

- **File:** `EngagementRecordOwner-00BE88CF-37E2-46ED-951B-A553329BC127.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="729-engagementrecordownerteam"></a>7.29. EngagementRecordOwnerTeam

- **File:** `EngagementRecordOwnerTeam-190EE5B4-5775-4B9D-BFD7-FB769C19977A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="730-fsrleaddistibutionnotification"></a>7.30. FSRLeadDistibutionNotification

- **File:** `FSRLeadDistibutionNotification-2D276CE9-54BF-4703-A56C-933E5C57F3C7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [ownerid](#index-ownerid)

### <a id="731-invoicerecordowner"></a>7.31. InvoiceRecordOwner

- **File:** `InvoiceRecordOwner-C59ED476-F5C4-47B7-BD33-E88881D2B5EE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Invoice

**Fields Read:**

- [customerid](#index-customerid)
- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="732-leadassignment"></a>7.32. LeadAssignment

- **File:** `LeadAssignment-5FC23C73-5B6B-423C-8721-57EDA4553E31.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [azt_leadsourceid](#index-azt_leadsourceid)
- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### <a id="733-leadpopulatefirstnamefromcontact"></a>7.33. LeadPopulateFirstNamefromContact

- **File:** `LeadPopulateFirstNamefromContact-62D3EE54-156C-4BEB-8AC6-5E59E788DFB6.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [parentcontactid](#index-parentcontactid)

### <a id="734-leadqualifydisqualifydate"></a>7.34. LeadQualifyDisqualifyDate

- **File:** `LeadQualifyDisqualifyDate-4DF6EBF4-0F22-4433-AB4F-A241C91F8B5A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [statecode](#index-statecode)

### <a id="735-leadsourcechange"></a>7.35. LeadSourceChange

- **File:** `LeadSourceChange-2F1F8085-9B50-4FE8-A756-20DAF80158A8.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_leadsourceid](#index-azt_leadsourceid)

### <a id="736-leadtemppopulatefirstlastnamefromcontact"></a>7.36. LeadTempPopulatefirstlastnamefromcontact

- **File:** `LeadTempPopulatefirstlastnamefromcontact-E1A85925-A97D-44F9-BB18-4CA0F569A49C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [parentcontactid](#index-parentcontactid)

### <a id="737-newfsrleadnotification"></a>7.37. NewFSRLeadNotification

- **File:** `NewFSRLeadNotification-53E6AF89-E489-4977-8D9F-1579FF72FAC5.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [name](#index-name)

### <a id="738-opportunityauditremoval"></a>7.38. OpportunityAuditRemoval

- **File:** `OpportunityAuditRemoval-DB05BF90-221B-4B58-8AA0-D1A0799EA0A1.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [opportunityid](#index-opportunityid)
- [statecode](#index-statecode)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.OppAuditRemoval`

### <a id="739-opportunityrecordowner"></a>7.39. OpportunityRecordOwner

- **File:** `OpportunityRecordOwner-B0889237-722A-47CC-B102-D507B14FED98.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="740-opportunityrecordownerteam"></a>7.40. OpportunityRecordOwnerTeam

- **File:** `OpportunityRecordOwnerTeam-7F60084D-807B-43D1-ACED-B0CC90F02F02.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)
- [opportunityid](#index-opportunityid)

### <a id="741-opportunitysalesprocessadvancebpf"></a>7.41. OpportunitySalesProcessAdvanceBPF

- **File:** `OpportunitySalesProcessAdvanceBPF-0BDB4648-C002-4184-ABA1-FDEB77B6A7AA.xaml`
- **Entity References:** opportunity
- **Primary Entity:** OpportunitySalesProcess

**Fields Written:**

- [azt_salesstage](#index-azt_salesstage)

### <a id="742-orderrecordowner"></a>7.42. OrderRecordOwner

- **File:** `OrderRecordOwner-701C3E67-4733-423C-BC31-5C846B542B76.xaml`
- **Entity References:** opportunity
- **Primary Entity:** SalesOrder

**Fields Read:**

- [customerid](#index-customerid)
- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="743-phonecallauto-assign"></a>7.43. PhonecallAuto-Assign

- **File:** `PhonecallAuto-Assign-D7FD43A4-5AFF-4929-BD37-A1917C4F2391.xaml`
- **Entity References:** opportunity
- **Primary Entity:** PhoneCall

**Fields Read:**

- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="744-printpurchaseassigntoteam"></a>7.44. PrintPurchaseAssigntoTeam

- **File:** `PrintPurchaseAssigntoTeam-9620B3F1-4852-4FFA-8FA7-09615D8CCAFD.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_printpurchase

**Fields Read:**

- [ownerid](#index-ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="745-qualifylead"></a>7.45. QualifyLead

- **File:** `QualifyLead-F6899272-F476-48C4-B703-D5ACDD9EDFF7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_committoestimatedclose](#index-azt_committoestimatedclose)
- [captureproposalfeedback](#index-captureproposalfeedback)
- [completefinalproposal](#index-completefinalproposal)
- [completeinternalreview](#index-completeinternalreview)
- [confirminterest](#index-confirminterest)
- [customerid](#index-customerid)
- [decisionmaker](#index-decisionmaker)
- [developproposal](#index-developproposal)
- [evaluatefit](#index-evaluatefit)
- [filedebrief](#index-filedebrief)
- [identifycompetitors](#index-identifycompetitors)
- [identifycustomercontacts](#index-identifycustomercontacts)
- [identifypursuitteam](#index-identifypursuitteam)
- [isrevenuesystemcalculated](#index-isrevenuesystemcalculated)
- [name](#index-name)
- [opportunityratingcode](#index-opportunityratingcode)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)
- [presentfinalproposal](#index-presentfinalproposal)
- [presentproposal](#index-presentproposal)
- [pricelevelid](#index-pricelevelid)
- [prioritycode](#index-prioritycode)
- [pursuitdecision](#index-pursuitdecision)
- [resolvefeedback](#index-resolvefeedback)
- [salesstagecode](#index-salesstagecode)
- [sendthankyounote](#index-sendthankyounote)
- [transactioncurrencyid](#index-transactioncurrencyid)

### <a id="746-quoterecordowner"></a>7.46. QuoteRecordOwner

- **File:** `QuoteRecordOwner-C5266A8C-E23D-41C4-B51F-3A637538DDBF.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [customerid](#index-customerid)
- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="747-quoterecordownerteam"></a>7.47. QuoteRecordOwnerTeam

- **File:** `QuoteRecordOwnerTeam-7ACFAD91-65CC-4C8D-8A3E-673373DEA880.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="748-renameengagements"></a>7.48. RenameEngagements

- **File:** `RenameEngagements-9D4DC906-B3F2-498A-AC17-7D302597E96C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#index-name)

### <a id="749-sendquote"></a>7.49. SendQuote

- **File:** `SendQuote-FF6FE214-20D6-4541-AEC6-BD5D18258481.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="750-setdefaultpricelistonopportunities"></a>7.50. SetDefaultPriceListonOpportunities

- **File:** `SetDefaultPriceListonOpportunities-6C392B18-AF72-4940-8C5C-D8BE3658E03A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Written:**

- [pricelevelid](#index-pricelevelid)

### <a id="751-setleadtemperature"></a>7.51. SetLeadTemperature

- **File:** `SetLeadTemperature-91BC905B-86CD-4317-BC84-E50EE444C775.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [azt_leadsourceid](#index-azt_leadsourceid)

### <a id="752-softwarelicenseassigntoteam"></a>7.52. SoftwareLicenseAssigntoTeam

- **File:** `SoftwareLicenseAssigntoTeam-2CFFBE82-9E25-47FD-A201-E6DB0C220DDE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#index-ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="753-softwarelicensecreateengagement"></a>7.53. SoftwareLicenseCreateEngagement

- **File:** `SoftwareLicenseCreateEngagement-ABFE722A-CAC3-4A3B-AF5C-419EA2CE9CBD.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [statuscode](#index-statuscode)

### <a id="754-softwarelicensesetowner"></a>7.54. SoftwareLicenseSetOwner

- **File:** `SoftwareLicenseSetOwner-438596B2-A87C-4F1E-AC53-3B3197DEF67C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#index-ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="755-taskauto-assign"></a>7.55. TaskAuto-Assign

- **File:** `TaskAuto-Assign-89E60667-3F7F-4ADD-8274-57C2BE011059.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Task

**Fields Read:**

- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)
- [parentaccountid](#index-parentaccountid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="756-taskcreatereorderlead"></a>7.56. TaskCreateReorderLead

- **File:** `TaskCreateReorderLead-3193EB56-8E56-46A3-B079-A7CFD1CE90B7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Task

**Fields Read:**

- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)

**Fields Written:**

- [azt_leadsourceid](#index-azt_leadsourceid)
- [azt_recordownerid](#index-azt_recordownerid)
- [customerid](#index-customerid)
- [ownerid](#index-ownerid)
- [statecode](#index-statecode)

### <a id="757-tempsetdefaultpricelist"></a>7.57. TempSetDefaultPricelist

- **File:** `TempSetDefaultPricelist-D46A3A4C-18D7-4686-B933-D78929185E3D.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Written:**

- [pricelevelid](#index-pricelevelid)

### <a id="758-wonopportunityemail"></a>7.58. WonOpportunityEmail

- **File:** `WonOpportunityEmail-DB2872A0-18C2-4157-B6BD-480230C97D32.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [!process_custom_attribute_url_](#index-process_custom_attribute_url_)
- [azt_recordownerid](#index-azt_recordownerid)
- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [statecode](#index-statecode)

### <a id="759-workforceaccountauto-assign"></a>7.59. WorkforceAccountAuto-assign

- **File:** `WorkforceAccountAuto-assign-1AD2C544-E6F9-4FC7-AA17-810AEB8939C2.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="760-workforceappointmentauto-assign"></a>7.60. WorkforceAppointmentAuto-Assign

- **File:** `WorkforceAppointmentAuto-Assign-803829FB-077B-4F0B-B238-105814F5B202.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="761-workforcecaseauto-assign"></a>7.61. WorkforceCaseAuto-assign

- **File:** `WorkforceCaseAuto-assign-24BA0A9C-F8BD-45CB-A5F6-6DCE42CD998F.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="762-workforcecontactauto-assign"></a>7.62. WorkforceContactAuto-assign

- **File:** `WorkforceContactAuto-assign-65B65E23-A8F5-46DB-A35A-C5DC8542B6AE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="763-workforceengagementauto-assign"></a>7.63. WorkforceEngagementAuto-assign

- **File:** `WorkforceEngagementAuto-assign-DA5CDD7F-2A3B-4A0A-861D-75305D10254E.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="764-workforceleadauto-assign"></a>7.64. WorkforceLeadAuto-Assign

- **File:** `WorkforceLeadAuto-Assign-E5A4054C-5F7E-478C-87E3-529C1EEAB0DC.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="765-workforceopportunityauto-assign"></a>7.65. WorkforceOpportunityAuto-assign

- **File:** `WorkforceOpportunityAuto-assign-7D379FBE-C672-41EB-90A3-A80451C62533.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [createdby](#index-createdby)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="766-workforcephone-callauto-assign"></a>7.66. WorkforcePhone-callAuto-assign

- **File:** `WorkforcePhone-callAuto-assign-BE1CB211-7C3C-4E39-8913-2DFCE7EDFC85.xaml`
- **Entity References:** opportunity
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="767-workforcequoteauto-assign"></a>7.67. WorkforceQuoteAuto-assign

- **File:** `WorkforceQuoteAuto-assign-E64BB2BB-5CD6-4327-AB1B-BF8C9D4D2385.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="768-igradappointmentauto-assign"></a>7.68. iGradAppointmentAuto-Assign

- **File:** `iGradAppointmentAuto-Assign-CE88A0C4-AA60-44F4-B33D-B57FB8279CCF.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="769-igradcaseauto-assign"></a>7.69. iGradCaseAuto-Assign

- **File:** `iGradCaseAuto-Assign-CAF5021E-07E1-4689-92D5-FC59E9F30F78.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="770-igradphone-callauto-assign"></a>7.70. iGradPhone-callAuto-assign

- **File:** `iGradPhone-callAuto-assign-04423D55-3225-429E-BAC6-8DD37BC53F1B.xaml`
- **Entity References:** opportunity
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

---

## <a id="8-javascript-web-resources"></a>8. JavaScript Web Resources

Total JS files referencing Opportunity fields: **15**

### <a id="81-azt_accountlibrary"></a>8.1. azt_accountlibrary

- **File:** `azt_accountlibraryF30D2BCC-3AFA-E811-A983-000D3A1A9151`

**Per-Function Field Usage:**

`createLead`:

| Field | Operations |
|-------|-----------|
| [name](#index-name) | read |

`createNewLead`:

| Field | Operations |
|-------|-----------|
| [name](#index-name) | read |

`parentAccountSpend`:

| Field | Operations |
|-------|-----------|
| [parentaccountid](#index-parentaccountid) | read, UI |

### <a id="82-azt_addresslibrary"></a>8.2. azt_addresslibrary

- **File:** `azt_addresslibrary34ACDB9B-C570-EB11-A812-00224809A7CD`

**Per-Function Field Usage:**

`addAddress`:

| Field | Operations |
|-------|-----------|
| [name](#index-name) | read |

### <a id="83-azt_caselibrary"></a>8.3. azt_caselibrary

- **File:** `azt_caselibraryD1BC3A04-FA9F-EC11-B400-00224824F1A0`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | UI |

### <a id="84-azt_createsoftwarelicense"></a>8.4. azt_createsoftwarelicense

- **File:** `azt_createsoftwarelicense1929C51B-2D25-E911-A985-000D3A1A9151`

**Per-Function Field Usage:**

`CreateLicense`:

| Field | Operations |
|-------|-----------|
| [customerid](#index-customerid) | read |

### <a id="85-azt_engagementlibrary"></a>8.5. azt_engagementlibrary

- **File:** `azt_engagementlibraryE672CD7D-C50C-E911-A97C-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | UI |

### <a id="86-azt_expensereportlibrary"></a>8.6. azt_expensereportlibrary

- **File:** `azt_expensereportlibraryE56605D3-7B07-E911-A977-000D3A1A9FA9`

**Per-Function Field Usage:**

`corporateApprove`:

| Field | Operations |
|-------|-----------|
| [statuscode](#index-statuscode) | UI |

`getCanApprove`:

| Field | Operations |
|-------|-----------|
| [statuscode](#index-statuscode) | UI |

`onLoad`:

| Field | Operations |
|-------|-----------|
| [statuscode](#index-statuscode) | read, UI |

`reject`:

| Field | Operations |
|-------|-----------|
| [statuscode](#index-statuscode) | write |

`setManagerApproval`:

| Field | Operations |
|-------|-----------|
| [statuscode](#index-statuscode) | UI |

`setPaid`:

| Field | Operations |
|-------|-----------|
| [statuscode](#index-statuscode) | UI |

`submit`:

| Field | Operations |
|-------|-----------|
| [statuscode](#index-statuscode) | write |

### <a id="87-azt_invoicelibrary"></a>8.7. azt_invoicelibrary

- **File:** `azt_invoicelibrary25F065BD-0B9E-EB11-B1AC-000D3A378944`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | UI |

### <a id="88-azt_leadlibrary"></a>8.8. azt_leadlibrary

- **File:** `azt_leadlibraryD08FB550-34A2-EB11-B1AC-002248093E98`

**Per-Function Field Usage:**

`getAccountPopulated`:

| Field | Operations |
|-------|-----------|
| [parentaccountid](#index-parentaccountid) | read |

`onSave`:

| Field | Operations |
|-------|-----------|
| [ownerid](#index-ownerid) | read |

`qualifyLead`:

| Field | Operations |
|-------|-----------|
| [parentaccountid](#index-parentaccountid) | read |

### <a id="89-azt_opportunityclone"></a>8.9. azt_opportunityclone

- **File:** `azt_opportunityclone9EADDE70-C221-E911-A94F-000D3A3B9B3D`

**Per-Function Field Usage:**

`cloneOpportunity`:

| Field | Operations |
|-------|-----------|
| [estimatedclosedate](#index-estimatedclosedate) | read |

### <a id="810-azt_opportunitylibrary"></a>8.10. azt_opportunitylibrary

- **File:** `azt_opportunitylibrary43000452-0710-E911-A980-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_committoestimatedclose](#index-azt_committoestimatedclose) | UI |
| [azt_expectedrenewalvalue](#index-azt_expectedrenewalvalue) | read, UI |
| [azt_lastmodifiedbyid](#index-azt_lastmodifiedbyid) | write |
| [azt_recordownerid](#index-azt_recordownerid) | UI |
| [pricelevelid](#index-pricelevelid) | write |

`setFreightAmt`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#index-azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#index-azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#index-azt_requestedfreightamt) | read |

`success`:

| Field | Operations |
|-------|-----------|
| [pricelevelid](#index-pricelevelid) | write |

### <a id="811-azt_opportunitytrackdiscount"></a>8.11. azt_opportunitytrackdiscount

- **File:** `azt_opportunitytrackdiscount8AAC767D-5D0E-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`trackDiscount`:

| Field | Operations |
|-------|-----------|
| [name](#index-name) | read |

### <a id="812-azt_orderlibrary"></a>8.12. azt_orderlibrary

- **File:** `azt_orderlibrary2892D28D-D5C4-EB11-BACC-00224809B8F2`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | UI |

### <a id="813-azt_productdiscountlibrary"></a>8.13. azt_productdiscountlibrary

- **File:** `azt_productdiscountlibraryBF6468B0-3230-E911-A950-000D3A3B9CD8`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [ownerid](#index-ownerid) | Yes |  |  |

### <a id="814-azt_quotelibrary"></a>8.14. azt_quotelibrary

- **File:** `azt_quotelibrary117BF74F-580A-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`setFreight`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#index-azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#index-azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#index-azt_requestedfreightamt) | read |

### <a id="815-azt_sendquote"></a>8.15. azt_sendquote

- **File:** `azt_sendquote0A31A45C-E217-E911-A97D-000D3A1A9FA9`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [name](#index-name) | Yes |  |  |

---

## <a id="9-formulas-rollups"></a>9. Formulas & Rollups

Total formulas for Opportunity: **10**

### azt_addonopportunitytotal

- **File:** `opportunity-azt_addonopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_dayssincecreated

- **File:** `opportunity-azt_dayssincecreated.xaml`
- **Type:** Calculated (Date Diff)

**Source Fields:**

| Field | Entity |
|-------|--------|
| [conditionbranchstep2_1](#index-conditionbranchstep2_1) | opportunity |
| [setattributevaluestep4_1](#index-setattributevaluestep4_1) | opportunity |
| [setattributevaluestep4_2](#index-setattributevaluestep4_2) | opportunity |
| [setattributevaluestep4_3](#index-setattributevaluestep4_3) | opportunity |
| [setattributevaluestep4_4](#index-setattributevaluestep4_4) | opportunity |
| [setattributevaluestep4_5](#index-setattributevaluestep4_5) | opportunity |
| [createdon](#index-createdon) | opportunity |

### azt_dayssinceprobabilitychanged

- **File:** `opportunity-azt_dayssinceprobabilitychanged.xaml`
- **Type:** Calculated (Date Diff)

**Source Fields:**

| Field | Entity |
|-------|--------|
| [conditionbranchstep2_1](#index-conditionbranchstep2_1) | opportunity |
| [setattributevaluestep4_1](#index-setattributevaluestep4_1) | opportunity |
| [setattributevaluestep4_2](#index-setattributevaluestep4_2) | opportunity |
| [setattributevaluestep4_3](#index-setattributevaluestep4_3) | opportunity |
| [setattributevaluestep4_4](#index-setattributevaluestep4_4) | opportunity |
| [setattributevaluestep4_5](#index-setattributevaluestep4_5) | opportunity |
| [azt_probabilitychangedon](#index-azt_probabilitychangedon) | opportunity |

### azt_discretionarydiscount

- **File:** `opportunity-azt_discretionarydiscount.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** azt_productdiscount

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_approvalstatus | azt_productdiscount |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| azt_discountamount | azt_productdiscount |

### azt_initialopportunitytotal

- **File:** `opportunity-azt_initialopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_otheropportunitytotal

- **File:** `opportunity-azt_otheropportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_pilotopportunitytotal

- **File:** `opportunity-azt_pilotopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_printopportunitytotal

- **File:** `opportunity-azt_printopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_renewalopportunitytotal

- **File:** `opportunity-azt_renewalopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_winbackopportunitytotal

- **File:** `opportunity-azt_winbackopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#index-rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#index-rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#index-rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

---

## <a id="10-plugin-source-code-analysis"></a>10. Plugin Source Code Analysis

Total plugins analyzed: **81**

### <a id="101-accountautoassign"></a>10.1. AccountAutoAssign

- **File:** `AccountAutoAssign.cs`
- **Message:** Assign (inferred)

**Fields Read:**

- [businessunitid](#index-businessunitid)
- [teamid](#index-teamid)

**Fields Filtered:**

- [azt_stateabbreviation](#index-azt_stateabbreviation)
- [name](#index-name)
- [teamtype](#index-teamtype)

**Fields Sorted:**

- [name](#index-name)

### <a id="102-accountleadgen"></a>10.2. AccountLeadGen

- **File:** `AccountLeadGen.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [accountid](#index-accountid)
- [azt_evaluate](#index-azt_evaluate)
- [azt_monthstofilteron](#index-azt_monthstofilteron)
- [invline.productid](#index-invlineproductid)
- [prod.productid](#index-prodproductid)
- [productid](#index-productid)

**Fields Written:**

- [accountid](#index-accountid)
- [productid](#index-productid)

**Fields Filtered:**

- [azt_accountleadgenerationid](#index-azt_accountleadgenerationid)
- [createdon](#index-createdon)
- [productid](#index-productid)
- [statecode](#index-statecode)

**Fields Joined:**

- [accountid](#index-accountid)
- [customerid](#index-customerid)
- [invoiceid](#index-invoiceid)
- [productid](#index-productid)

**Pre/Post Image Fields:**

- [azt_evaluate](#index-azt_evaluate)
- [azt_monthstofilteron](#index-azt_monthstofilteron)

**Cross-Entity References (AliasedValue):**

| Alias | Field | Operation |
|-------|-------|-----------|
| Prod | productid | Read |
| Prod | productid | Read |
| InvLine | productid | Read |

### <a id="103-accountleadgenassociate"></a>10.3. AccountLeadGenAssociate

- **File:** `AccountLeadGenAssociate.cs`
- **Target entity:** azt_accountleadgeneration
- **Message:** Associate

**Fields Read:**

- [azt_accountleadgenerationid](#index-azt_accountleadgenerationid)
- [azt_name](#index-azt_name)

**Fields Written:**

- [accountid](#index-accountid)
- [azt_accountleadgenname](#index-azt_accountleadgenname)

**Fields Filtered:**

- [azt_accountleadgenerationid](#index-azt_accountleadgenerationid)

**Fields Sorted:**

- [azt_name](#index-azt_name)

### <a id="104-accountreassignmentsharerecords"></a>10.4. AccountReassignmentShareRecords

- **File:** `AccountReassignmentShareRecords.cs`
- **Message:** GrantAccess (inferred)

**Fields Read:**

- [activityid](#index-activityid)
- [activitytypecode](#index-activitytypecode)
- [azt_accountid](#index-azt_accountid)
- [azt_customertrainingid](#index-azt_customertrainingid)
- [azt_engagementid](#index-azt_engagementid)
- [azt_softwarelicenseid](#index-azt_softwarelicenseid)
- [azt_trainingid](#index-azt_trainingid)
- [incidentid](#index-incidentid)
- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)

**Fields Filtered:**

- [azt_accountid](#index-azt_accountid)
- [customerid](#index-customerid)
- [regardingobjectid](#index-regardingobjectid)

**Fields Sorted:**

- [azt_accountid](#index-azt_accountid)
- [azt_name](#index-azt_name)
- [azt_trainingid](#index-azt_trainingid)
- [modifiedon](#index-modifiedon)
- [name](#index-name)

### <a id="105-accounttypeset"></a>10.5. AccountTypeSet

- **File:** `AccountTypeSet.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [azt_nonsaasstatus](#index-azt_nonsaasstatus)
- [azt_saasstatus](#index-azt_saasstatus)

**Fields Written:**

- [accountid](#index-accountid)
- [azt_accounttype](#index-azt_accounttype)

**Pre/Post Image Fields:**

- [azt_nonsaasstatus](#index-azt_nonsaasstatus)
- [azt_saasstatus](#index-azt_saasstatus)

### <a id="106-activateorrevisequote"></a>10.6. ActivateOrReviseQuote

- **File:** `ActivateOrReviseQuote.cs`
- **Message:** Create

**Fields Read:**

- [quotedetailid](#index-quotedetailid)

**Fields Filtered:**

- [azt_quoteproductid](#index-azt_quoteproductid)
- [quoteid](#index-quoteid)

### <a id="107-activitiescreatedduedatesinpast"></a>10.7. ActivitiesCreatedDueDatesInPast

- **File:** `ActivitiesCreatedDueDatesInPast.cs`
- **Message:** Create

**Fields Read:**

- [scheduledend](#index-scheduledend)

### <a id="108-activitycloseforcerecordowner"></a>10.8. ActivityCloseForceRecordOwner

- **File:** `ActivityCloseForceRecordOwner.cs`
- **Message:** Update
- **Entity Images:** Pre

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)
- [statecode](#index-statecode)

### <a id="109-activityregardinggetstate"></a>10.9. ActivityRegardingGetState

- **File:** `ActivityRegardingGetState.cs`

**Fields Read:**

- [activityid](#index-activityid)
- [activitytypecode](#index-activitytypecode)
- [address1_stateorprovince](#index-address1_stateorprovince)
- [azt_accountid](#index-azt_accountid)
- [customerid](#index-customerid)
- [ownerid](#index-ownerid)
- [parentcustomerid](#index-parentcustomerid)
- [regardingobjectid](#index-regardingobjectid)

### <a id="1010-addresssearchcleanupfields"></a>10.10. AddressSearchCleanupFields

- **File:** `AddressSearchCleanupFields.cs`
- **Message:** Create

**Fields Read:**

- [azt_addresssearch](#index-azt_addresssearch)
- [azt_addresssearch2](#index-azt_addresssearch2)

**Fields Written:**

- [azt_addresssearch](#index-azt_addresssearch)
- [azt_addresssearch2](#index-azt_addresssearch2)

### <a id="1011-allocationvalidation"></a>10.11. AllocationValidation

- **File:** `AllocationValidation.cs`
- **Message:** Create
- **Entity Images:** Post

**Fields Read:**

- [azt_allocationtype](#index-azt_allocationtype)
- [azt_concurrentusers](#index-azt_concurrentusers)
- [azt_numberoflicenses](#index-azt_numberoflicenses)
- [azt_softwarelicenseid](#index-azt_softwarelicenseid)

**Fields Filtered:**

- [azt_softwarelicenseid](#index-azt_softwarelicenseid)
- [statecode](#index-statecode)

### <a id="1012-autoassignstateabb"></a>10.12. AutoAssignStateAbb

- **File:** `AutoAssignStateAbb.cs`
- **Target entity:** customeraddress
- **Message:** Create

**Fields Read:**

- [address1_stateorprovince](#index-address1_stateorprovince)
- [stateorprovince](#index-stateorprovince)

**Fields Written:**

- [address1_stateorprovince](#index-address1_stateorprovince)
- [stateorprovince](#index-stateorprovince)

### <a id="1013-autonumber"></a>10.13. AutoNumber

- **File:** `AutoNumber.cs`
- **Message:** Create

**Fields Read:**

- [azt_autonumberid](#index-azt_autonumberid)
- [azt_currentnumber](#index-azt_currentnumber)
- [azt_fieldtoautonumber](#index-azt_fieldtoautonumber)
- [azt_prefix](#index-azt_prefix)
- [azt_prefixhasseparator](#index-azt_prefixhasseparator)
- [azt_prefixseparator](#index-azt_prefixseparator)
- [azt_prefixseparatorisspace](#index-azt_prefixseparatorisspace)
- [azt_suffix](#index-azt_suffix)
- [azt_suffixhasseparator](#index-azt_suffixhasseparator)
- [azt_suffixseparator](#index-azt_suffixseparator)
- [azt_suffixseparatorisspace](#index-azt_suffixseparatorisspace)

**Fields Written:**

- [azt_autonumberid](#index-azt_autonumberid)
- [azt_currentnumber](#index-azt_currentnumber)

**Fields Filtered:**

- [azt_name](#index-azt_name)

### <a id="1014-caseaudit"></a>10.14. CaseAudit

- **File:** `CaseAudit.cs`
- **Message:** Create
- **Entity Images:** Pre

**Fields Read:**

- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_caseid](#index-azt_caseid)
- [azt_newownerid](#index-azt_newownerid)
- [azt_previousownerid](#index-azt_previousownerid)

### <a id="1015-caseclose"></a>10.15. CaseClose

- **File:** `CaseClose.cs`
- **Message:** SetState

**Fields Read:**

- [azt_resolvedbyid](#index-azt_resolvedbyid)

**Fields Written:**

- [adx_resolutiondate](#index-adx_resolutiondate)
- [azt_resolvedbyid](#index-azt_resolvedbyid)
- [incidentid](#index-incidentid)

### <a id="1016-changelicensetype"></a>10.16. ChangeLicenseType

- **File:** `ChangeLicenseType.cs`

**Fields Read:**

- [opportunityproductid](#index-opportunityproductid)

**Fields Written:**

- [azt_licensetype](#index-azt_licensetype)
- [opportunityproductid](#index-opportunityproductid)

**Fields Filtered:**

- [opportunityid](#index-opportunityid)

**Fields Sorted:**

- [createdon](#index-createdon)

### <a id="1017-cloneexpenseline"></a>10.17. CloneExpenseLine

- **File:** `CloneExpenseLine.cs`
- **Message:** Create

**Fields Read:**

- [azt_customerid](#index-azt_customerid)
- [azt_description](#index-azt_description)
- [azt_expenseamount](#index-azt_expenseamount)
- [azt_expensereportid](#index-azt_expensereportid)
- [azt_expensetype](#index-azt_expensetype)
- [azt_mileage](#index-azt_mileage)
- [azt_name](#index-azt_name)
- [azt_reasonforexpense](#index-azt_reasonforexpense)
- [transactioncurrencyid](#index-transactioncurrencyid)

**Fields Written:**

- [azt_customerid](#index-azt_customerid)
- [azt_description](#index-azt_description)
- [azt_expenseamount](#index-azt_expenseamount)
- [azt_expensereportid](#index-azt_expensereportid)
- [azt_expensetype](#index-azt_expensetype)
- [azt_mileage](#index-azt_mileage)
- [azt_reasonforexpense](#index-azt_reasonforexpense)
- [transactioncurrencyid](#index-transactioncurrencyid)

**Fields Filtered:**

- [azt_expenseid](#index-azt_expenseid)

### <a id="1018-compgoalcreate"></a>10.18. CompGoalCreate

- **File:** `CompGoalCreate.cs`
- **Message:** Create

**Fields Read:**

- [azt_invoiceid](#index-azt_invoiceid)
- [invoicenumber](#index-invoicenumber)
- [salesorderid](#index-salesorderid)

**Fields Written:**

- [azt_name](#index-azt_name)
- [azt_orderid](#index-azt_orderid)

### <a id="1019-contactsetconnectionrole"></a>10.19. ContactSetConnectionRole

- **File:** `ContactSetConnectionRole.cs`
- **Message:** azt_ContactSetConnectionRole

**Fields Read:**

- [connectionroleid](#index-connectionroleid)
- [statecode](#index-statecode)

**Fields Written:**

- [description](#index-description)
- [record1id](#index-record1id)
- [record1roleid](#index-record1roleid)
- [record2id](#index-record2id)
- [record2roleid](#index-record2roleid)

**Fields Filtered:**

- [name](#index-name)

**Fields Sorted:**

- [category](#index-category)

**Fields Joined:**

- [associatedconnectionroleid](#index-associatedconnectionroleid)
- [connectionroleid](#index-connectionroleid)

### <a id="1020-createcompgoals"></a>10.20. CreateCompGoals

- **File:** `CreateCompGoals.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_commissionid](#index-azt_commissionid)
- [azt_licensetype](#index-azt_licensetype)
- [azt_name](#index-azt_name)
- [azt_recordownerid](#index-azt_recordownerid)
- [ext_amt](#index-ext_amt)
- [extendedamount](#index-extendedamount)

**Fields Written:**

- [azt_amount](#index-azt_amount)
- [azt_commissionid](#index-azt_commissionid)
- [azt_compcompleted](#index-azt_compcompleted)
- [azt_effectivedate](#index-azt_effectivedate)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_name](#index-azt_name)
- [azt_opportunityid](#index-azt_opportunityid)
- [azt_orderid](#index-azt_orderid)
- [azt_percentage](#index-azt_percentage)
- [azt_producttype](#index-azt_producttype)
- [azt_salesrepid](#index-azt_salesrepid)
- [azt_total](#index-azt_total)
- [invoiceid](#index-invoiceid)
- [ownerid](#index-ownerid)

**Fields Filtered:**

- [invoiceid](#index-invoiceid)
- [ownerid](#index-ownerid)

**Fields Sorted:**

- [azt_fiscalperiodstart](#index-azt_fiscalperiodstart)

### <a id="1021-createsoftwarelicenses"></a>10.21. CreateSoftwareLicenses

- **File:** `CreateSoftwareLicenses.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [azt_iscompanion](#index-azt_iscompanion)
- [azt_isprint](#index-azt_isprint)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_nonsaastype](#index-azt_nonsaastype)
- [azt_parentorderid](#index-azt_parentorderid)
- [azt_recordownerid](#index-azt_recordownerid)
- [azt_saas](#index-azt_saas)
- [customerid](#index-customerid)
- [datefulfilled](#index-datefulfilled)
- [name](#index-name)
- [productid](#index-productid)
- [productnumber](#index-productnumber)
- [quantity](#index-quantity)
- [salesorderdetailid](#index-salesorderdetailid)
- [salesorderid](#index-salesorderid)
- [statecode](#index-statecode)

**Fields Written:**

- [azt_accountid](#index-azt_accountid)
- [azt_allocatedtoid](#index-azt_allocatedtoid)
- [azt_allocationtype](#index-azt_allocationtype)
- [azt_concurrentusers](#index-azt_concurrentusers)
- [azt_customerid](#index-azt_customerid)
- [azt_expirationdate](#index-azt_expirationdate)
- [azt_isbn](#index-azt_isbn)
- [azt_licensestatus](#index-azt_licensestatus)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_name](#index-azt_name)
- [azt_numberoflicenses](#index-azt_numberoflicenses)
- [azt_ordertype](#index-azt_ordertype)
- [azt_printproductid](#index-azt_printproductid)
- [azt_printpurchaseid](#index-azt_printpurchaseid)
- [azt_purchasedate](#index-azt_purchasedate)
- [azt_quantity](#index-azt_quantity)
- [azt_softwarelicenseid](#index-azt_softwarelicenseid)
- [azt_softwareproductid](#index-azt_softwareproductid)
- [azt_startdate](#index-azt_startdate)
- [azt_supportexpirationdate](#index-azt_supportexpirationdate)
- [salesorderdetailid](#index-salesorderdetailid)

**Fields Filtered:**

- [salesorderid](#index-salesorderid)

**Fields Sorted:**

- [productid](#index-productid)

**Pre/Post Image Fields:**

- [azt_recordownerid](#index-azt_recordownerid)
- [customerid](#index-customerid)
- [statecode](#index-statecode)

### <a id="1022-createusergoals"></a>10.22. CreateUserGoals

- **File:** `CreateUserGoals.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [amountdatatype](#index-amountdatatype)
- [azt_amount](#index-azt_amount)
- [azt_compgoaltypeid](#index-azt_compgoaltypeid)
- [azt_compplanamountid](#index-azt_compplanamountid)
- [azt_effectivedate](#index-azt_effectivedate)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_jobrole](#index-azt_jobrole)
- [azt_masecommission](#index-azt_masecommission)
- [azt_orderid](#index-azt_orderid)
- [azt_payablecommission](#index-azt_payablecommission)
- [azt_percentage](#index-azt_percentage)
- [azt_percentagepaid](#index-azt_percentagepaid)
- [azt_producttype](#index-azt_producttype)
- [azt_salesrepid](#index-azt_salesrepid)
- [azt_total](#index-azt_total)
- [createdon](#index-createdon)
- [extendedamount](#index-extendedamount)
- [fullname](#index-fullname)
- [goalenddate](#index-goalenddate)
- [goalid](#index-goalid)
- [goalrollupqueryid](#index-goalrollupqueryid)
- [goalstartdate](#index-goalstartdate)
- [isamount](#index-isamount)
- [name](#index-name)
- [opportunityproductid](#index-opportunityproductid)
- [ownerid](#index-ownerid)
- [parentgoalid](#index-parentgoalid)
- [parentsystemuserid](#index-parentsystemuserid)
- [priceperunit](#index-priceperunit)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [statuscode](#index-statuscode)

**Fields Written:**

- [azt_goaltype](#index-azt_goaltype)
- [consideronlygoalownersrecords](#index-consideronlygoalownersrecords)
- [fetchxml](#index-fetchxml)
- [goalenddate](#index-goalenddate)
- [goalownerid](#index-goalownerid)
- [goalstartdate](#index-goalstartdate)
- [isfiscalperiodgoal](#index-isfiscalperiodgoal)
- [metricid](#index-metricid)
- [name](#index-name)
- [ownerid](#index-ownerid)
- [parentgoalid](#index-parentgoalid)
- [queryentitytype](#index-queryentitytype)
- [rolluponlyfromchildgoals](#index-rolluponlyfromchildgoals)
- [rollupqueryactualmoneyid](#index-rollupqueryactualmoneyid)
- [title](#index-title)

**Fields Filtered:**

- [actualclosedate](#index-actualclosedate)
- [azt_compcompleted](#index-azt_compcompleted)
- [azt_effectivedate](#index-azt_effectivedate)
- [azt_goaltype](#index-azt_goaltype)
- [azt_issaas](#index-azt_issaas)
- [azt_producttype](#index-azt_producttype)
- [azt_recordownerid](#index-azt_recordownerid)
- [azt_salesrepid](#index-azt_salesrepid)
- [goalenddate](#index-goalenddate)
- [goalownerid](#index-goalownerid)
- [goalstartdate](#index-goalstartdate)
- [name](#index-name)
- [ownerid](#index-ownerid)
- [statecode](#index-statecode)

**Fields Sorted:**

- [azt_producttype](#index-azt_producttype)
- [azt_salesrepid](#index-azt_salesrepid)
- [createdon](#index-createdon)
- [fiscalperiod](#index-fiscalperiod)
- [productid](#index-productid)
- [title](#index-title)

**Fields Joined:**

- [azt_invoiceid](#index-azt_invoiceid)
- [invoiceid](#index-invoiceid)
- [opportunityid](#index-opportunityid)

### <a id="1023-discretionarydiscountsetheader"></a>10.23. DiscretionaryDiscountSetHeader

- **File:** `DiscretionaryDiscountSetHeader.cs`
- **Message:** Delete
- **Entity Images:** Post

**Fields Read:**

- [azt_discountamount](#index-azt_discountamount)
- [azt_invoiceproductid](#index-azt_invoiceproductid)
- [azt_opportunityid](#index-azt_opportunityid)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [azt_orderproductid](#index-azt_orderproductid)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [azt_quoteproductid](#index-azt_quoteproductid)
- [invoicedetailid](#index-invoicedetailid)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)
- [parentaccountid](#index-parentaccountid)
- [quotedetailid](#index-quotedetailid)
- [quoteid](#index-quoteid)
- [salesorderdetailid](#index-salesorderdetailid)
- [statecode](#index-statecode)

**Fields Written:**

- [azt_customerid](#index-azt_customerid)
- [azt_discretionarydiscountamt](#index-azt_discretionarydiscountamt)
- [azt_opportunityid](#index-azt_opportunityid)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [invoicedetailid](#index-invoicedetailid)
- [manualdiscountamount](#index-manualdiscountamount)
- [opportunityproductid](#index-opportunityproductid)
- [quotedetailid](#index-quotedetailid)
- [salesorderdetailid](#index-salesorderdetailid)

**Fields Filtered:**

- [invoicedetailid](#index-invoicedetailid)
- [opportunityproductid](#index-opportunityproductid)
- [quotedetailid](#index-quotedetailid)
- [salesorderdetailid](#index-salesorderdetailid)
- [statecode](#index-statecode)
- [{0}](#index-0)

**Fields Sorted:**

- [productid](#index-productid)

**Fields Joined:**

- [invoiceid](#index-invoiceid)
- [opportunityid](#index-opportunityid)
- [quoteid](#index-quoteid)
- [salesorderid](#index-salesorderid)

### <a id="1024-engagementfsrassignedon"></a>10.24. EngagementFSRAssignedOn

- **File:** `EngagementFSRAssignedOn.cs`
- **Message:** Update

**Fields Read:**

- [azt_engagementid](#index-azt_engagementid)
- [ownerid](#index-ownerid)

**Fields Written:**

- [azt_engagementid](#index-azt_engagementid)
- [azt_fsrassignedon](#index-azt_fsrassignedon)

### <a id="1025-engagementsetenddate"></a>10.25. EngagementSetEndDate

- **File:** `EngagementSetEndDate.cs`
- **Message:** SetState

**Fields Written:**

- [azt_enddate](#index-azt_enddate)
- [azt_engagementid](#index-azt_engagementid)

### <a id="1026-expenselinetotals"></a>10.26. ExpenseLineTotals

- **File:** `ExpenseLineTotals.cs`
- **Target entity:** azt_expense
- **Message:** Create
- **Entity Images:** Post

**Fields Read:**

- [azt_expenseamount](#index-azt_expenseamount)
- [azt_expensereportid](#index-azt_expensereportid)
- [contactid](#index-contactid)
- [crm3_expenseamount](#index-crm3_expenseamount)
- [crm3_parentleadid](#index-crm3_parentleadid)

**Fields Written:**

- [azt_expensereportid](#index-azt_expensereportid)
- [azt_totalreimbursement](#index-azt_totalreimbursement)
- [contactid](#index-contactid)
- [parentcustomerid](#index-parentcustomerid)

**Fields Filtered:**

- [azt_expensereportid](#index-azt_expensereportid)
- [crm3_parentleadid](#index-crm3_parentleadid)

### <a id="1027-expenserestrictvisibility"></a>10.27. ExpenseRestrictVisibility

- **File:** `ExpenseRestrictVisibility.cs`

**Fields Read:**

- [businessunitid](#index-businessunitid)

**Fields Filtered:**

- [statecode](#index-statecode)

### <a id="1028-fundingsetannualspend"></a>10.28. FundingSetAnnualSpend

- **File:** `FundingSetAnnualSpend.cs`
- **Message:** Create

**Fields Read:**

- [azt_account](#index-azt_account)
- [azt_fundingyear](#index-azt_fundingyear)
- [invoiceid](#index-invoiceid)
- [totalamount](#index-totalamount)

**Fields Written:**

- [azt_annualspend](#index-azt_annualspend)
- [azt_fundingid](#index-azt_fundingid)

**Fields Filtered:**

- [azt_paidon](#index-azt_paidon)
- [customerid](#index-customerid)
- [statecode](#index-statecode)

### <a id="1029-fundingtotalamt"></a>10.29. FundingTotalAmt

- **File:** `FundingTotalAmt.cs`
- **Message:** Create
- **Entity Images:** Post

**Fields Written:**

- [azt_fundingid](#index-azt_fundingid)
- [azt_totalfunding](#index-azt_totalfunding)

### <a id="1030-fundingyearsync"></a>10.30. FundingYearSync

- **File:** `FundingYearSync.cs`
- **Message:** Create

**Fields Read:**

- [azt_fundingyear](#index-azt_fundingyear)

**Fields Written:**

- [azt_year](#index-azt_year)

### <a id="1031-getacctteamowned"></a>10.31. GetAcctTeamOwned

- **File:** `GetAcctTeamOwned.cs`

**Fields Read:**

- [accountid](#index-accountid)
- [name](#index-name)

**Fields Filtered:**

- [accountid](#index-accountid)

**Fields Sorted:**

- [name](#index-name)

**Fields Joined:**

- [owninguser](#index-owninguser)
- [systemuserid](#index-systemuserid)

### <a id="1032-getuserhasrole"></a>10.32. GetUserHasRole

- **File:** `GetUserHasRole.cs`

**Fields Read:**

- [businessunitid](#index-businessunitid)

### <a id="1033-getuserhasroletoaction"></a>10.33. GetUserHasRoleToAction

- **File:** `GetUserHasRoleToAction.cs`

**Fields Read:**

- [roleid](#index-roleid)

**Fields Filtered:**

- [roleid](#index-roleid)
- [systemuserid](#index-systemuserid)

**Fields Joined:**

- [roleid](#index-roleid)
- [systemuserid](#index-systemuserid)

### <a id="1034-invoiceclosepaidonpercentage"></a>10.34. InvoiceClosePaidOnPercentage

- **File:** `InvoiceClosePaidOnPercentage.cs`
- **Message:** Update
- **Entity Images:** Pre

**Fields Read:**

- [azt_amount](#index-azt_amount)
- [azt_compcompleted](#index-azt_compcompleted)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_paymentid](#index-azt_paymentid)
- [statecode](#index-statecode)
- [totalamount](#index-totalamount)

### <a id="1035-invoicecompcompleted"></a>10.35. InvoiceCompCompleted

- **File:** `InvoiceCompCompleted.cs`
- **Message:** Update

**Fields Read:**

- [azt_amount](#index-azt_amount)
- [azt_commissionpaymentid](#index-azt_commissionpaymentid)
- [azt_compcompleted](#index-azt_compcompleted)
- [azt_compgoaltypeid](#index-azt_compgoaltypeid)
- [azt_compplanamountid](#index-azt_compplanamountid)
- [azt_effectivedate](#index-azt_effectivedate)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_orderid](#index-azt_orderid)
- [azt_percentage](#index-azt_percentage)
- [azt_producttype](#index-azt_producttype)
- [azt_salesrepid](#index-azt_salesrepid)
- [azt_total](#index-azt_total)
- [ownerid](#index-ownerid)
- [statuscode](#index-statuscode)

**Fields Written:**

- [azt_commissionamount](#index-azt_commissionamount)
- [azt_commissionid](#index-azt_commissionid)
- [azt_commissionpaymentid](#index-azt_commissionpaymentid)
- [azt_compgoalid](#index-azt_compgoalid)
- [azt_compgoaltypeid](#index-azt_compgoaltypeid)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_name](#index-azt_name)
- [azt_periodend](#index-azt_periodend)
- [azt_periodstart](#index-azt_periodstart)
- [ownerid](#index-ownerid)
- [statecode](#index-statecode)
- [statuscode](#index-statuscode)

**Fields Filtered:**

- [azt_amount](#index-azt_amount)
- [azt_compgoalid](#index-azt_compgoalid)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_masecommission](#index-azt_masecommission)
- [azt_percentage](#index-azt_percentage)
- [azt_periodend](#index-azt_periodend)
- [azt_periodstart](#index-azt_periodstart)
- [ownerid](#index-ownerid)
- [statuscode](#index-statuscode)

**Fields Sorted:**

- [azt_producttype](#index-azt_producttype)
- [azt_salesrepid](#index-azt_salesrepid)
- [createdon](#index-createdon)

### <a id="1036-leadimport"></a>10.36. LeadImport

- **File:** `LeadImport.cs`
- **Message:** Create

**Fields Read:**

- [accountid](#index-accountid)
- [azt_companyname](#index-azt_companyname)
- [azt_email](#index-azt_email)
- [azt_firstname](#index-azt_firstname)
- [azt_importname](#index-azt_importname)
- [azt_jobtitle](#index-azt_jobtitle)
- [azt_lastname](#index-azt_lastname)
- [azt_leadsourceid](#index-azt_leadsourceid)
- [azt_phone](#index-azt_phone)
- [azt_stateprovince](#index-azt_stateprovince)
- [contactid](#index-contactid)
- [fullname](#index-fullname)
- [name](#index-name)
- [parentcustomerid](#index-parentcustomerid)

**Fields Written:**

- [address1_stateorprovince](#index-address1_stateorprovince)
- [azt_leadimportid](#index-azt_leadimportid)
- [azt_leadsourceid](#index-azt_leadsourceid)
- [azt_originatingleadimportid](#index-azt_originatingleadimportid)
- [azt_result](#index-azt_result)
- [companyname](#index-companyname)
- [emailaddress1](#index-emailaddress1)
- [firstname](#index-firstname)
- [jobtitle](#index-jobtitle)
- [lastname](#index-lastname)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)
- [subject](#index-subject)
- [telephone1](#index-telephone1)

**Fields Filtered:**

- [emailaddress1](#index-emailaddress1)
- [name](#index-name)
- [statecode](#index-statecode)

**Fields Sorted:**

- [fullname](#index-fullname)
- [name](#index-name)

### <a id="1037-leadimportpopulatename"></a>10.37. LeadImportPopulateName

- **File:** `LeadImportPopulateName.cs`
- **Message:** Create

**Fields Read:**

- [azt_email](#index-azt_email)
- [azt_importname](#index-azt_importname)

**Fields Written:**

- [azt_name](#index-azt_name)

### <a id="1038-leadqualify"></a>10.38. LeadQualify

- **File:** `LeadQualify.cs`
- **Message:** QualifyLead

**Fields Read:**

- [parentaccountid](#index-parentaccountid)

### <a id="1039-leadqualifyparentstakeholdercontacts"></a>10.39. LeadQualifyParentStakeholderContacts

- **File:** `LeadQualifyParentStakeholderContacts.cs`
- **Target entity:** account
- **Message:** Create

**Fields Read:**

- [accountid](#index-accountid)
- [connectionid](#index-connectionid)
- [name](#index-name)
- [originatingleadid](#index-originatingleadid)
- [record2id](#index-record2id)
- [record2roleid](#index-record2roleid)

**Fields Written:**

- [contactid](#index-contactid)
- [parentcustomerid](#index-parentcustomerid)

**Fields Filtered:**

- [record1id](#index-record1id)

**Fields Sorted:**

- [record2id](#index-record2id)

### <a id="1040-manualdiscountkill"></a>10.40. ManualDiscountKill

- **File:** `ManualDiscountKill.cs`

**Fields Read:**

- [manualdiscountamount](#index-manualdiscountamount)

### <a id="1041-oppauditremoval"></a>10.41. OppAuditRemoval

- **File:** `OppAuditRemoval.cs`

**Fields Read:**

- [azt_opportunityauditrecordid](#index-azt_opportunityauditrecordid)

**Fields Filtered:**

- [azt_opportunityid](#index-azt_opportunityid)

### <a id="1042-opportunityassignfromlead"></a>10.42. OpportunityAssignFromLead

- **File:** `OpportunityAssignFromLead.cs`
- **Message:** Create

**Fields Read:**

- [originatingleadid](#index-originatingleadid)

**Fields Written:**

- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)

### <a id="1043-opportunityaudit"></a>10.43. OpportunityAudit

- **File:** `OpportunityAudit.cs`
- **Message:** Update
- **Entity Images:** Pre, Post

**Fields Read:**

- [azt_lastmodifiedbyid](#index-azt_lastmodifiedbyid)
- [azt_parentopportunityid](#index-azt_parentopportunityid)
- [azt_probability](#index-azt_probability)
- [estimatedclosedate](#index-estimatedclosedate)
- [estimatedvalue](#index-estimatedvalue)
- [fullname](#index-fullname)
- [opportunityid](#index-opportunityid)

**Fields Written:**

- [azt_name](#index-azt_name)
- [azt_newestclosedate](#index-azt_newestclosedate)
- [azt_newestimatedvalue](#index-azt_newestimatedvalue)
- [azt_newprobability](#index-azt_newprobability)
- [azt_opportunityid](#index-azt_opportunityid)
- [azt_previousestclosedate](#index-azt_previousestclosedate)
- [azt_previousestimatedvalue](#index-azt_previousestimatedvalue)
- [azt_previousprobability](#index-azt_previousprobability)

**Pre/Post Image Fields:**

- [azt_parentopportunityid](#index-azt_parentopportunityid)

### <a id="1044-opportunityclone"></a>10.44. OpportunityClone

- **File:** `OpportunityClone.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [description](#index-description)
- [extendedamount](#index-extendedamount)
- [ispriceoverridden](#index-ispriceoverridden)
- [isproductoverridden](#index-isproductoverridden)
- [manualdiscountamount](#index-manualdiscountamount)
- [opportunityproductid](#index-opportunityproductid)
- [priceperunit](#index-priceperunit)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [productname](#index-productname)
- [producttypecode](#index-producttypecode)
- [quantity](#index-quantity)
- [tax](#index-tax)
- [transactioncurrencyid](#index-transactioncurrencyid)
- [uomid](#index-uomid)

**Fields Written:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [estimatedclosedate](#index-estimatedclosedate)
- [opportunityid](#index-opportunityid)

**Fields Filtered:**

- [opportunityid](#index-opportunityid)

**Fields Sorted:**

- [productid](#index-productid)

### <a id="1045-opportunitylastactivitydate"></a>10.45. OpportunityLastActivityDate

- **File:** `OpportunityLastActivityDate.cs`
- **Message:** Update

**Fields Read:**

- [azt_probability](#index-azt_probability)
- [estimatedclosedate](#index-estimatedclosedate)
- [estimatedvalue](#index-estimatedvalue)
- [regardingobjectid](#index-regardingobjectid)

**Fields Written:**

- [azt_lastactivitydate](#index-azt_lastactivitydate)
- [opportunityid](#index-opportunityid)

### <a id="1046-opportunitylinesynctoquote"></a>10.46. OpportunityLineSyncToQuote

- **File:** `OpportunityLineSyncToQuote.cs`
- **Message:** Update
- **Entity Images:** Pre, Post

**Fields Read:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [defaultuomid](#index-defaultuomid)
- [manualdiscountamount](#index-manualdiscountamount)
- [opportunityid](#index-opportunityid)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [quotedetailid](#index-quotedetailid)
- [quoteid](#index-quoteid)
- [statecode](#index-statecode)
- [tax](#index-tax)

**Fields Written:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [quotedetailid](#index-quotedetailid)

**Fields Filtered:**

- [opportunityid](#index-opportunityid)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [quoteid](#index-quoteid)

**Fields Sorted:**

- [modifiedon](#index-modifiedon)

**Pre/Post Image Fields:**

- [opportunityid](#index-opportunityid)

### <a id="1047-opportunitypreventcreatequote"></a>10.47. OpportunityPreventCreateQuote

- **File:** `OpportunityPreventCreateQuote.cs`
- **Message:** Create

**Fields Read:**

- [azt_approvalstatus](#index-azt_approvalstatus)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)

**Fields Filtered:**

- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [opportunityid](#index-opportunityid)

### <a id="1048-opportunityprobabilitychange"></a>10.48. OpportunityProbabilityChange

- **File:** `OpportunityProbabilityChange.cs`
- **Message:** Create
- **Entity Images:** Pre

**Fields Read:**

- [azt_probability](#index-azt_probability)

**Fields Written:**

- [azt_probabilitychangedon](#index-azt_probabilitychangedon)
- [azt_probabilityincreased](#index-azt_probabilityincreased)

**Pre/Post Image Fields:**

- [azt_probability](#index-azt_probability)

### <a id="1049-opportunityprobabilitynumber"></a>10.49. OpportunityProbabilityNumber

- **File:** `OpportunityProbabilityNumber.cs`

**Fields Read:**

- [azt_probability](#index-azt_probability)

**Fields Written:**

- [closeprobability](#index-closeprobability)
- [opportunityid](#index-opportunityid)

### <a id="1050-opptytoquotefieldmappings"></a>10.50. OpptyToQuoteFieldMappings

- **File:** `OpptyToQuoteFieldMappings.cs`
- **Message:** Create

**Fields Read:**

- [azt_approvalstatus](#index-azt_approvalstatus)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [extendedamount](#index-extendedamount)
- [manualdiscountamount](#index-manualdiscountamount)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [quotedetailid](#index-quotedetailid)
- [quoteid](#index-quoteid)

**Fields Written:**

- [azt_discretionarydiscountamt](#index-azt_discretionarydiscountamt)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [azt_quoteproductid](#index-azt_quoteproductid)
- [quotedetailid](#index-quotedetailid)

**Fields Filtered:**

- [azt_licensetype](#index-azt_licensetype)
- [azt_opportunityid](#index-azt_opportunityid)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [extendedamount](#index-extendedamount)
- [opportunityid](#index-opportunityid)
- [productid](#index-productid)
- [quoteid](#index-quoteid)

**Fields Sorted:**

- [azt_name](#index-azt_name)
- [createdon](#index-createdon)

### <a id="1051-orderclone"></a>10.51. OrderClone

- **File:** `OrderClone.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [description](#index-description)
- [extendedamount](#index-extendedamount)
- [ispriceoverridden](#index-ispriceoverridden)
- [isproductoverridden](#index-isproductoverridden)
- [manualdiscountamount](#index-manualdiscountamount)
- [priceperunit](#index-priceperunit)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [productname](#index-productname)
- [producttypecode](#index-producttypecode)
- [quantity](#index-quantity)
- [salesorderdetailid](#index-salesorderdetailid)
- [tax](#index-tax)
- [transactioncurrencyid](#index-transactioncurrencyid)
- [uomid](#index-uomid)

**Fields Written:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)

**Fields Filtered:**

- [salesorderid](#index-salesorderid)

**Fields Sorted:**

- [productid](#index-productid)

### <a id="1052-orderfsrsettemplatefields"></a>10.52. OrderFSRSetTemplateFields

- **File:** `OrderFSRSetTemplateFields.cs`
- **Message:** Update

**Fields Read:**

- [address1_telephone1](#index-address1_telephone1)
- [azt_bookingurl](#index-azt_bookingurl)
- [azt_extension](#index-azt_extension)
- [azt_fsrid](#index-azt_fsrid)
- [internalemailaddress](#index-internalemailaddress)
- [mobilephone](#index-mobilephone)

**Fields Written:**

- [azt_bookingurl](#index-azt_bookingurl)
- [azt_fsremail](#index-azt_fsremail)
- [azt_fsrmobiletelephone](#index-azt_fsrmobiletelephone)
- [azt_fsrtelephone](#index-azt_fsrtelephone)
- [azt_fsrtelephoneextension](#index-azt_fsrtelephoneextension)

### <a id="1053-orderlinepopulatelictype"></a>10.53. OrderLinePopulateLicType

- **File:** `OrderLinePopulateLicType.cs`
- **Message:** Create

**Fields Read:**

- [azt_licenseterm](#index-azt_licenseterm)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [quotedetailid](#index-quotedetailid)

**Fields Written:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [salesorderdetailid](#index-salesorderdetailid)

### <a id="1054-orderlinepopulatetemplatefields"></a>10.54. OrderLinePopulateTemplateFields

- **File:** `OrderLinePopulateTemplateFields.cs`
- **Message:** Create

**Fields Read:**

- [quantity](#index-quantity)
- [salesorderdetailname](#index-salesorderdetailname)

**Fields Written:**

- [azt_ordertemplatelines](#index-azt_ordertemplatelines)
- [salesorderid](#index-salesorderid)

**Fields Filtered:**

- [salesorderid](#index-salesorderid)

**Fields Sorted:**

- [productid](#index-productid)

### <a id="1055-ordermanuallycreatesoftwarelicense"></a>10.55. OrderManuallyCreateSoftwareLicense

- **File:** `OrderManuallyCreateSoftwareLicense.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [ownerid](#index-ownerid)
- [productid](#index-productid)
- [quantity](#index-quantity)

**Fields Written:**

- [azt_allocatedtoid](#index-azt_allocatedtoid)
- [azt_customerid](#index-azt_customerid)
- [azt_expirationdate](#index-azt_expirationdate)
- [azt_licensestatus](#index-azt_licensestatus)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_name](#index-azt_name)
- [azt_numberoflicenses](#index-azt_numberoflicenses)
- [azt_orderlineid](#index-azt_orderlineid)
- [azt_purchasedate](#index-azt_purchasedate)
- [azt_softwarelicenseid](#index-azt_softwarelicenseid)
- [azt_softwareproductid](#index-azt_softwareproductid)
- [azt_startdate](#index-azt_startdate)
- [azt_supportexpirationdate](#index-azt_supportexpirationdate)
- [ownerid](#index-ownerid)

### <a id="1056-ordersplit"></a>10.56. OrderSplit

- **File:** `OrderSplit.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_estfulfillmentdate](#index-azt_estfulfillmentdate)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_parentorderid](#index-azt_parentorderid)
- [azt_ponumber](#index-azt_ponumber)
- [azt_quotenumber](#index-azt_quotenumber)
- [azt_recordownerid](#index-azt_recordownerid)
- [azt_trackingnumber](#index-azt_trackingnumber)
- [description](#index-description)
- [extendedamount](#index-extendedamount)
- [ispriceoverridden](#index-ispriceoverridden)
- [isproductoverridden](#index-isproductoverridden)
- [priceperunit](#index-priceperunit)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [productname](#index-productname)
- [producttypecode](#index-producttypecode)
- [quantity](#index-quantity)
- [salesorderdetailid](#index-salesorderdetailid)
- [tax](#index-tax)
- [transactioncurrencyid](#index-transactioncurrencyid)
- [uomid](#index-uomid)

**Fields Written:**

- [azt_estfulfillmentdate](#index-azt_estfulfillmentdate)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_parentorderid](#index-azt_parentorderid)
- [azt_ponumber](#index-azt_ponumber)
- [azt_quotenumber](#index-azt_quotenumber)
- [azt_recordownerid](#index-azt_recordownerid)
- [azt_trackingnumber](#index-azt_trackingnumber)
- [billto_line1](#index-billto_line1)
- [billto_line2](#index-billto_line2)
- [billto_line3](#index-billto_line3)
- [billto_name](#index-billto_name)
- [billto_postalcode](#index-billto_postalcode)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [customerid](#index-customerid)
- [description](#index-description)
- [freighttermscode](#index-freighttermscode)
- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [pricelevelid](#index-pricelevelid)
- [quoteid](#index-quoteid)
- [requestdeliveryby](#index-requestdeliveryby)
- [shippingmethodcode](#index-shippingmethodcode)
- [shipto_line1](#index-shipto_line1)
- [shipto_line2](#index-shipto_line2)
- [shipto_line3](#index-shipto_line3)
- [shipto_name](#index-shipto_name)
- [shipto_postalcode](#index-shipto_postalcode)
- [shipto_stateorprovince](#index-shipto_stateorprovince)
- [transactioncurrencyid](#index-transactioncurrencyid)

**Fields Filtered:**

- [salesorderid](#index-salesorderid)

**Fields Sorted:**

- [productid](#index-productid)

### <a id="1057-orderstagetracking"></a>10.57. OrderStageTracking

- **File:** `OrderStageTracking.cs`
- **Message:** Create

**Fields Read:**

- [azt_orderid](#index-azt_orderid)
- [azt_orderstageid](#index-azt_orderstageid)
- [bpf_duration](#index-bpf_duration)
- [businessprocessflowinstanceid](#index-businessprocessflowinstanceid)
- [createdon](#index-createdon)

**Fields Written:**

- [azt_ageendedstage](#index-azt_ageendedstage)
- [azt_dateexitedstage](#index-azt_dateexitedstage)
- [azt_orderstageid](#index-azt_orderstageid)

**Fields Filtered:**

- [azt_orderid](#index-azt_orderid)
- [bpf_salesorderid](#index-bpf_salesorderid)

**Fields Sorted:**

- [createdon](#index-createdon)

### <a id="1058-paymentupdate"></a>10.58. PaymentUpdate

- **File:** `PaymentUpdate.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [azt_amount](#index-azt_amount)
- [azt_compcompleted](#index-azt_compcompleted)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_paymentdate](#index-azt_paymentdate)
- [azt_paymentid](#index-azt_paymentid)
- [statuscode](#index-statuscode)
- [totalamount](#index-totalamount)

### <a id="1059-phonecallcreatecallback"></a>10.59. PhonecallCreateCallback

- **File:** `PhonecallCreateCallback.cs`
- **Target entity:** team
- **Message:** Create
- **Entity Images:** Post

**Fields Read:**

- [activityid](#index-activityid)
- [azt_addtocrtqueue](#index-azt_addtocrtqueue)
- [azt_autocreatecallback](#index-azt_autocreatecallback)
- [azt_azteccustomerid](#index-azt_azteccustomerid)
- [azt_callbackin](#index-azt_callbackin)
- [azt_callbackon](#index-azt_callbackon)
- [azt_copydescription](#index-azt_copydescription)
- [azt_copysubject](#index-azt_copysubject)
- [azt_recordownerid](#index-azt_recordownerid)
- [azt_softwarelicenseid](#index-azt_softwarelicenseid)
- [customerid](#index-customerid)
- [description](#index-description)
- [from](#index-from)
- [ownerid](#index-ownerid)
- [parentcustomerid](#index-parentcustomerid)
- [phonenumber](#index-phonenumber)
- [queueid](#index-queueid)
- [queueitemid](#index-queueitemid)
- [regardingobjectid](#index-regardingobjectid)
- [scheduledend](#index-scheduledend)
- [statecode](#index-statecode)
- [subject](#index-subject)
- [to](#index-to)

**Fields Written:**

- [azt_duedate](#index-azt_duedate)
- [from](#index-from)
- [objectid](#index-objectid)
- [partyid](#index-partyid)
- [queueid](#index-queueid)
- [to](#index-to)

**Fields Filtered:**

- [accountid](#index-accountid)
- [activityid](#index-activityid)
- [contactid](#index-contactid)
- [name](#index-name)
- [objectid](#index-objectid)

**Pre/Post Image Fields:**

- [activityid](#index-activityid)
- [ownerid](#index-ownerid)

### <a id="1060-productdiscountpreventonactivequote"></a>10.60. ProductDiscountPreventOnActiveQuote

- **File:** `ProductDiscountPreventOnActiveQuote.cs`
- **Message:** Create
- **Entity Images:** Pre

**Fields Read:**

- [azt_quoteproductid](#index-azt_quoteproductid)
- [quoteid](#index-quoteid)
- [statecode](#index-statecode)

### <a id="1061-quotecloneanddelete"></a>10.61. QuoteCloneAndDelete

- **File:** `QuoteCloneAndDelete.cs`
- **Message:** Delete (inferred)

**Fields Read:**

- [extendedamount](#index-extendedamount)
- [invoiceid](#index-invoiceid)
- [priceperunit](#index-priceperunit)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [quotedetailid](#index-quotedetailid)
- [salesorderid](#index-salesorderid)
- [uomid](#index-uomid)

**Fields Written:**

- [quantity](#index-quantity)
- [quoteid](#index-quoteid)

**Fields Filtered:**

- [quoteid](#index-quoteid)
- [salesorderid](#index-salesorderid)

**Fields Sorted:**

- [name](#index-name)
- [productid](#index-productid)

### <a id="1062-quotelinessynctooppty"></a>10.62. QuoteLinesSyncToOppty

- **File:** `QuoteLinesSyncToOppty.cs`
- **Target entity:** quote
- **Message:** Create
- **Entity Images:** Pre, Post

**Fields Read:**

- [defaultuomid](#index-defaultuomid)
- [discountamount](#index-discountamount)
- [discountpercentage](#index-discountpercentage)
- [manualdiscountamount](#index-manualdiscountamount)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [quoteid](#index-quoteid)
- [tax](#index-tax)
- [uomid](#index-uomid)

**Fields Written:**

- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)
- [quantity](#index-quantity)
- [quotedetailid](#index-quotedetailid)

**Fields Filtered:**

- [extendedamount](#index-extendedamount)
- [opportunityid](#index-opportunityid)
- [productdescription](#index-productdescription)
- [productid](#index-productid)

**Fields Sorted:**

- [productid](#index-productid)

### <a id="1063-quoteorderproductstrackdiscount"></a>10.63. QuoteOrderProductsTrackDiscount

- **File:** `QuoteOrderProductsTrackDiscount.cs`
- **Message:** Create

**Fields Read:**

- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [invoicedetailid](#index-invoicedetailid)
- [quotedetailid](#index-quotedetailid)
- [salesorderdetailid](#index-salesorderdetailid)

**Fields Written:**

- [azt_invoiceproductid](#index-azt_invoiceproductid)
- [azt_orderproductid](#index-azt_orderproductid)
- [azt_productdiscountid](#index-azt_productdiscountid)

**Fields Filtered:**

- [azt_orderproductid](#index-azt_orderproductid)

**Fields Sorted:**

- [azt_name](#index-azt_name)

### <a id="1064-quotepreventactivateunapproveddiscounts"></a>10.64. QuotePreventActivateUnapprovedDiscounts

- **File:** `QuotePreventActivateUnapprovedDiscounts.cs`
- **Message:** SetState

**Fields Read:**

- [azt_approvalstatus](#index-azt_approvalstatus)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [baseamount](#index-baseamount)
- [extendedamount](#index-extendedamount)
- [ispriceoverridden](#index-ispriceoverridden)
- [manualdiscountamount](#index-manualdiscountamount)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)
- [priceperunit](#index-priceperunit)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [quotedetailid](#index-quotedetailid)
- [quoteid](#index-quoteid)
- [salesrepid](#index-salesrepid)
- [tax](#index-tax)
- [uomid](#index-uomid)

**Fields Written:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [baseamount](#index-baseamount)
- [extendedamount](#index-extendedamount)
- [ispriceoverridden](#index-ispriceoverridden)
- [isproductoverridden](#index-isproductoverridden)
- [manualdiscountamount](#index-manualdiscountamount)
- [opportunityid](#index-opportunityid)
- [priceperunit](#index-priceperunit)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [tax](#index-tax)
- [uomid](#index-uomid)

**Fields Filtered:**

- [azt_quoteproductid](#index-azt_quoteproductid)
- [opportunityid](#index-opportunityid)
- [quoteid](#index-quoteid)

### <a id="1065-quotepreventactivateunapprovedfreight"></a>10.65. QuotePreventActivateUnapprovedFreight

- **File:** `QuotePreventActivateUnapprovedFreight.cs`
- **Message:** SetState

**Fields Read:**

- [azt_defaultfreightamount](#index-azt_defaultfreightamount)
- [azt_freightamtapproved](#index-azt_freightamtapproved)
- [azt_requestedfreightamt](#index-azt_requestedfreightamt)
- [quoteid](#index-quoteid)

### <a id="1066-quotesynctotaltoopportunity"></a>10.66. QuoteSyncTotalToOpportunity

- **File:** `QuoteSyncTotalToOpportunity.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [freightamount](#index-freightamount)
- [opportunityid](#index-opportunityid)
- [totalamount](#index-totalamount)

**Fields Written:**

- [isrevenuesystemcalculated](#index-isrevenuesystemcalculated)
- [opportunityid](#index-opportunityid)

### <a id="1067-recordownerrestrictedit"></a>10.67. RecordOwnerRestrictEdit

- **File:** `RecordOwnerRestrictEdit.cs`
- **Message:** Update
- **Entity Images:** Pre

**Fields Read:**

- [azt_opportunityid](#index-azt_opportunityid)
- [azt_quoteproductid](#index-azt_quoteproductid)
- [azt_recordowner](#index-azt_recordowner)
- [azt_recordownerid](#index-azt_recordownerid)
- [businessunitid](#index-businessunitid)
- [ownerid](#index-ownerid)

### <a id="1068-restrictcreatequote"></a>10.68. RestrictCreateQuote

- **File:** `RestrictCreateQuote.cs`
- **Message:** Create

**Fields Read:**

- [quoteid](#index-quoteid)

**Fields Filtered:**

- [opportunityid](#index-opportunityid)
- [statecode](#index-statecode)

**Fields Sorted:**

- [name](#index-name)

### <a id="1069-restrictproductlookups"></a>10.69. RestrictProductLookups

- **File:** `RestrictProductLookups.cs`
- **Message:** RetrieveMultiple

**Fields Read:**

- [azt_jobrole](#index-azt_jobrole)
- [businessunitid](#index-businessunitid)

**Fields Filtered:**

- [productnumber](#index-productnumber)

### <a id="1070-restrictwinopportunities"></a>10.70. RestrictWinOpportunities

- **File:** `RestrictWinOpportunities.cs`

**Fields Read:**

- [businessunitid](#index-businessunitid)

### <a id="1071-restrictwinquote"></a>10.71. RestrictWinQuote

- **File:** `RestrictWinQuote.cs`

**Fields Read:**

- [businessunitid](#index-businessunitid)

### <a id="1072-revisequotediscountmove"></a>10.72. ReviseQuoteDiscountMove

- **File:** `ReviseQuoteDiscountMove.cs`
- **Message:** Create

**Fields Read:**

- [azt_productdiscountid](#index-azt_productdiscountid)
- [baseamount](#index-baseamount)
- [extendedamount](#index-extendedamount)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [quantity](#index-quantity)
- [quotedetailid](#index-quotedetailid)

**Fields Written:**

- [azt_productdiscountid](#index-azt_productdiscountid)
- [azt_quoteproductid](#index-azt_quoteproductid)
- [discountamount](#index-discountamount)
- [quoteid](#index-quoteid)

**Fields Filtered:**

- [azt_quoteproductid](#index-azt_quoteproductid)
- [quoteid](#index-quoteid)

**Fields Sorted:**

- [azt_name](#index-azt_name)
- [productid](#index-productid)

### <a id="1073-sendquotereport"></a>10.73. SendQuoteReport

- **File:** `SendQuoteReport.cs`

**Fields Written:**

- [body](#index-body)
- [filename](#index-filename)
- [mimetype](#index-mimetype)
- [objectid](#index-objectid)
- [objecttypecode](#index-objecttypecode)
- [subject](#index-subject)

### <a id="1074-setoppproductdefaults"></a>10.74. SetOppProductDefaults

- **File:** `SetOppProductDefaults.cs`
- **Message:** Create

**Fields Read:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [opportunityproductid](#index-opportunityproductid)
- [productid](#index-productid)

**Fields Written:**

- [azt_issaas](#index-azt_issaas)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [opportunityproductid](#index-opportunityproductid)

### <a id="1075-setprimarycontact"></a>10.75. SetPrimaryContact

- **File:** `SetPrimaryContact.cs`
- **Message:** Create

**Fields Read:**

- [category](#index-category)
- [connectionid](#index-connectionid)
- [connectionroleid](#index-connectionroleid)
- [name](#index-name)
- [primarycontactid](#index-primarycontactid)
- [record1id](#index-record1id)
- [record1roleid](#index-record1roleid)
- [record2id](#index-record2id)
- [record2roleid](#index-record2roleid)
- [statecode](#index-statecode)

**Fields Written:**

- [accountid](#index-accountid)
- [description](#index-description)
- [primarycontactid](#index-primarycontactid)
- [record1id](#index-record1id)
- [record1roleid](#index-record1roleid)
- [record2id](#index-record2id)
- [record2roleid](#index-record2roleid)

**Fields Filtered:**

- [name](#index-name)
- [record1id](#index-record1id)
- [record2id](#index-record2id)

**Fields Sorted:**

- [category](#index-category)

**Fields Joined:**

- [associatedconnectionroleid](#index-associatedconnectionroleid)
- [connectionroleid](#index-connectionroleid)
- [record2roleid](#index-record2roleid)

### <a id="1076-sharebasedonaccessteam"></a>10.76. ShareBasedOnAccessTeam

- **File:** `ShareBasedOnAccessTeam.cs`
- **Message:** GrantAccess (inferred)

**Fields Read:**

- [activityid](#index-activityid)
- [customerid](#index-customerid)
- [fullname](#index-fullname)
- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [parentaccountid](#index-parentaccountid)
- [quoteid](#index-quoteid)
- [regardingobjectid](#index-regardingobjectid)
- [salesorderid](#index-salesorderid)
- [systemuserid](#index-systemuserid)
- [teamid](#index-teamid)
- [tm.systemuserid](#index-tmsystemuserid)

**Fields Filtered:**

- [accountid](#index-accountid)
- [regardingobjectid](#index-regardingobjectid)
- [teamtype](#index-teamtype)

**Fields Joined:**

- [owningteam](#index-owningteam)
- [systemuserid](#index-systemuserid)
- [teamid](#index-teamid)

**Cross-Entity References (AliasedValue):**

| Alias | Field | Operation |
|-------|-------|-----------|
| tm | systemuserid | Read |

### <a id="1077-sharefromaccountshares"></a>10.77. ShareFromAccountShares

- **File:** `ShareFromAccountShares.cs`
- **Message:** Create

**Fields Read:**

- [customerid](#index-customerid)
- [name](#index-name)
- [parentcustomerid](#index-parentcustomerid)
- [regardingobjectid](#index-regardingobjectid)
- [teamtype](#index-teamtype)

### <a id="1078-sharewithaccountowner"></a>10.78. ShareWithAccountOwner

- **File:** `ShareWithAccountOwner.cs`
- **Message:** GrantAccess (inferred)

**Fields Read:**

- [activityid](#index-activityid)
- [annotationid](#index-annotationid)
- [azt_accountid](#index-azt_accountid)
- [customerid](#index-customerid)
- [objectid](#index-objectid)
- [ownerid](#index-ownerid)
- [parentcustomerid](#index-parentcustomerid)
- [regardingobjectid](#index-regardingobjectid)

**Fields Filtered:**

- [salesorderid](#index-salesorderid)

### <a id="1079-shipmentsettrackingnumber"></a>10.79. ShipmentSetTrackingNumber

- **File:** `ShipmentSetTrackingNumber.cs`
- **Message:** Create

**Fields Read:**

- [azt_orderid](#index-azt_orderid)
- [azt_trackingnumber](#index-azt_trackingnumber)

**Fields Written:**

- [azt_trackingnumbers](#index-azt_trackingnumbers)
- [salesorderid](#index-salesorderid)

**Fields Filtered:**

- [azt_orderid](#index-azt_orderid)
- [azt_trackingnumber](#index-azt_trackingnumber)

**Fields Sorted:**

- [azt_orderlineid](#index-azt_orderlineid)
- [createdon](#index-createdon)

### <a id="1080-updateoppfromquote"></a>10.80. UpdateOppFromQuote

- **File:** `UpdateOppFromQuote.cs`
- **Message:** Update
- **Entity Images:** Pre, Post

**Fields Read:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [createdon](#index-createdon)
- [modifiedon](#index-modifiedon)
- [opportunityid](#index-opportunityid)
- [productid](#index-productid)
- [quoteid](#index-quoteid)
- [tax](#index-tax)
- [uomid](#index-uomid)

**Fields Written:**

- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [baseamount](#index-baseamount)
- [extendedamount](#index-extendedamount)
- [ispriceoverridden](#index-ispriceoverridden)
- [opportunityid](#index-opportunityid)
- [priceperunit](#index-priceperunit)
- [quantity](#index-quantity)

**Fields Filtered:**

- [opportunityid](#index-opportunityid)

**Fields Sorted:**

- [modifiedon](#index-modifiedon)

### <a id="1081-utility"></a>10.81. Utility

- **File:** `Utility.cs`

**Fields Read:**

- [azt_amount](#index-azt_amount)
- [azt_commissionid](#index-azt_commissionid)
- [azt_paymentdate](#index-azt_paymentdate)
- [azt_paymentid](#index-azt_paymentid)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [azt_replacementproductid](#index-azt_replacementproductid)
- [azt_saas](#index-azt_saas)
- [businessunitid](#index-businessunitid)
- [fullname](#index-fullname)
- [name](#index-name)
- [parentsystemuserid](#index-parentsystemuserid)
- [productid](#index-productid)
- [roleid](#index-roleid)
- [statecode](#index-statecode)
- [transactioncurrencyid](#index-transactioncurrencyid)

**Fields Written:**

- [azt_fiscalperiodend](#index-azt_fiscalperiodend)
- [azt_fiscalperiodstart](#index-azt_fiscalperiodstart)
- [azt_name](#index-azt_name)
- [azt_paid](#index-azt_paid)
- [azt_paidon](#index-azt_paidon)
- [azt_totalamountpaid](#index-azt_totalamountpaid)
- [invoiceid](#index-invoiceid)
- [ownerid](#index-ownerid)
- [transactioncurrencyid](#index-transactioncurrencyid)

**Fields Filtered:**

- [azt_fiscalperiodend](#index-azt_fiscalperiodend)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [azt_quoteproductid](#index-azt_quoteproductid)
- [isocurrencycode](#index-isocurrencycode)
- [ownerid](#index-ownerid)
- [productnumber](#index-productnumber)
- [roleid](#index-roleid)
- [statuscode](#index-statuscode)
- [systemuserid](#index-systemuserid)

**Fields Sorted:**

- [azt_name](#index-azt_name)
- [azt_paymentdate](#index-azt_paymentdate)
- [fullname](#index-fullname)
- [ownerid](#index-ownerid)

**Fields Joined:**

- [roleid](#index-roleid)
- [systemuserid](#index-systemuserid)

---

## <a id="11-pcf-controls"></a>11. PCF Controls

### Bing Address Autocomplete

- **Namespace:** Primary
- **Constructor:** BingAddressAutocomplete
- **Version:** 0.0.16

**Bound Properties (map to entity fields):**

| Property | Display Name | Type | Required |
|----------|-------------|------|----------|
| value | Full Address | SingleLine.Text | Yes |
| street | Street | SingleLine.Text | Yes |
| city | City | SingleLine.Text | Yes |
| county | County | SingleLine.Text | Yes |
| state | State/Region | SingleLine.Text | Yes |
| zipcode | Zip Code | SingleLine.Text | Yes |
| country | Country | SingleLine.Text | Yes |

**Input Properties:**

| Property | Display Name | Type |
|----------|-------------|------|
| bingapikey | Bing Api Key | SingleLine.Text |

---

## <a id="12-relationships"></a>12. Relationships

Total relationships involving Opportunity: **20**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| Opportunity_Phonecalls | 1:N | Opportunity | PhoneCall | [RegardingObjectId](#index-regardingobjectid) |
| azt_amsystemuser_opportunity | N:1 | SystemUser | Opportunity | [azt_AssignedAMId](#index-azt_assignedamid) |
| azt_azt_leadsource_opportunity | N:1 | azt_leadsource | Opportunity | [azt_LeadSourceId](#index-azt_leadsourceid) |
| azt_opportunity_azt_compgoaltype | 1:N | Opportunity | azt_compgoaltype | [azt_OpportunityId](#index-azt_opportunityid) |
| azt_opportunity_azt_opportunityauditrecord | 1:N | Opportunity | azt_opportunityauditrecord | [azt_OpportunityId](#index-azt_opportunityid) |
| azt_opportunity_azt_productdiscount | 1:N | Opportunity | azt_productdiscount | [azt_OpportunityId](#index-azt_opportunityid) |
| azt_opportunity_clonedopportunity | 1:N | Opportunity | Opportunity | [azt_ParentOpportunityId](#index-azt_parentopportunityid) |
| azt_opportunity_lead | 1:N | Opportunity | Lead | [azt_OpportunityLeadId](#index-azt_opportunityleadid) |
| azt_opportunity_task | 1:N | Opportunity | Task | [azt_ReorderOpportunityId](#index-azt_reorderopportunityid) |
| azt_systemuser_opportunity | N:1 | SystemUser | Opportunity | [azt_RecordOwnerId](#index-azt_recordownerid) |
| azt_systemusermodified_opportunity | N:1 | SystemUser | Opportunity | [azt_LastModifiedById](#index-azt_lastmodifiedbyid) |
| msa_contact_opportunity | N:1 | Contact | Opportunity | [msa_partneroppid](#index-msa_partneroppid) |
| msa_partner_opportunity | N:1 | Account | Opportunity | [msa_partnerid](#index-msa_partnerid) |
| msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid | N:1 | msdyn_opportunitykpiitem | Opportunity | [msdyn_opportunitykpiid](#index-msdyn_opportunitykpiid) |
| msdyn_msdyn_predictivescore_opportunity | N:1 | msdyn_predictivescore | Opportunity | [msdyn_PredictiveScoreId](#index-msdyn_predictivescoreid) |
| msdyn_msdyn_segment_opportunity | N:1 | msdyn_segment | Opportunity | [msdyn_segmentid](#index-msdyn_segmentid) |
| opportunity_customer_accounts | N:1 | Account | Opportunity | [CustomerId](#index-customerid) |
| opportunity_originating_lead | N:1 | Lead | Opportunity | [OriginatingLeadId](#index-originatingleadid) |
| opportunity_parent_account | N:1 | Account | Opportunity | [ParentAccountId](#index-parentaccountid) |
| opportunity_quotes | 1:N | Opportunity | Quote | [OpportunityId](#index-opportunityid) |

---

## <a id="13-ribbon-customizations"></a>13. Ribbon Customizations

### Custom Buttons

| Button Label | Location | Command |
|-------------|----------|---------|
| Clone Opportunity | Mscrm.Form.opportunity.MainTab.Actions.Controls._children | `azt.opportunity.CloneOpportunity.Command` |
| Track Discount | Mscrm.Form.opportunity.MainTab.Actions.Controls._children | `azt.opportunity.TrackDiscountCommand.Command` |

### Command Definitions

| Command ID | JavaScript Function | Library |
|-----------|-------------------|---------|
| `azt.opportunity.CloneOpportunity.Command` | `cloneOpportunity` | `azt_opportunityclone` |
| `azt.opportunity.TrackDiscountCommand.Command` | `trackDiscount` | `azt_opportunitytrackdiscount` |

---

## <a id="14-conflicts-observations"></a>14. Conflicts & Observations

### 14.1 Per-Form Conflicts

Fields with inconsistent settings across forms: **1**

| Field | Issue | Forms |
|-------|-------|-------|
| [ownerid](#index-ownerid) | Visibility | Opportunity (quickCreate), Opportunity Owner Quick View (quick), Order Opportunity Owner Quick View (quick) |

### 14.2 Global Observations

**Fields in code but not on any form (308):**

- [!process_custom_attribute_url_](#index-process_custom_attribute_url_)
- [accountid](#index-accountid)
- [activityid](#index-activityid)
- [activitytypecode](#index-activitytypecode)
- [actualvalue](#index-actualvalue)
- [address1_stateorprovince](#index-address1_stateorprovince)
- [address1_telephone1](#index-address1_telephone1)
- [adx_resolutiondate](#index-adx_resolutiondate)
- [amountdatatype](#index-amountdatatype)
- [annotationid](#index-annotationid)
- [azt_account](#index-azt_account)
- [azt_accountid](#index-azt_accountid)
- [azt_accountleadgenerationid](#index-azt_accountleadgenerationid)
- [azt_accountleadgenname](#index-azt_accountleadgenname)
- [azt_accounttype](#index-azt_accounttype)
- [azt_addresssearch](#index-azt_addresssearch)
- [azt_addresssearch2](#index-azt_addresssearch2)
- [azt_addtocrtqueue](#index-azt_addtocrtqueue)
- [azt_ageendedstage](#index-azt_ageendedstage)
- [azt_allocatedtoid](#index-azt_allocatedtoid)
- [azt_allocationtype](#index-azt_allocationtype)
- [azt_amount](#index-azt_amount)
- [azt_annualspend](#index-azt_annualspend)
- [azt_approvalstatus](#index-azt_approvalstatus)
- [azt_autocreatecallback](#index-azt_autocreatecallback)
- [azt_autonumberid](#index-azt_autonumberid)
- [azt_azteccustomerid](#index-azt_azteccustomerid)
- [azt_bookingurl](#index-azt_bookingurl)
- [azt_callbackin](#index-azt_callbackin)
- [azt_callbackon](#index-azt_callbackon)
- [azt_caseid](#index-azt_caseid)
- [azt_commissionamount](#index-azt_commissionamount)
- [azt_commissionid](#index-azt_commissionid)
- [azt_commissionpaymentid](#index-azt_commissionpaymentid)
- [azt_companyname](#index-azt_companyname)
- [azt_compcompleted](#index-azt_compcompleted)
- [azt_compgoalid](#index-azt_compgoalid)
- [azt_compgoaltypeid](#index-azt_compgoaltypeid)
- [azt_compplanamountid](#index-azt_compplanamountid)
- [azt_concurrentusers](#index-azt_concurrentusers)
- [azt_copydescription](#index-azt_copydescription)
- [azt_copysubject](#index-azt_copysubject)
- [azt_currentnumber](#index-azt_currentnumber)
- [azt_customerid](#index-azt_customerid)
- [azt_customertrainingid](#index-azt_customertrainingid)
- [azt_dateexitedstage](#index-azt_dateexitedstage)
- [azt_description](#index-azt_description)
- [azt_discountamount](#index-azt_discountamount)
- [azt_duedate](#index-azt_duedate)
- [azt_effectivedate](#index-azt_effectivedate)
- [azt_email](#index-azt_email)
- [azt_enddate](#index-azt_enddate)
- [azt_engagementid](#index-azt_engagementid)
- [azt_estfulfillmentdate](#index-azt_estfulfillmentdate)
- [azt_evaluate](#index-azt_evaluate)
- [azt_expenseamount](#index-azt_expenseamount)
- [azt_expenseid](#index-azt_expenseid)
- [azt_expensereportid](#index-azt_expensereportid)
- [azt_expensetype](#index-azt_expensetype)
- [azt_expirationdate](#index-azt_expirationdate)
- [azt_extension](#index-azt_extension)
- [azt_fieldtoautonumber](#index-azt_fieldtoautonumber)
- [azt_firstname](#index-azt_firstname)
- [azt_fiscalperiodend](#index-azt_fiscalperiodend)
- [azt_fiscalperiodstart](#index-azt_fiscalperiodstart)
- [azt_fsrassignedon](#index-azt_fsrassignedon)
- [azt_fsremail](#index-azt_fsremail)
- [azt_fsrid](#index-azt_fsrid)
- [azt_fsrmobiletelephone](#index-azt_fsrmobiletelephone)
- [azt_fsrtelephone](#index-azt_fsrtelephone)
- [azt_fsrtelephoneextension](#index-azt_fsrtelephoneextension)
- [azt_fundingid](#index-azt_fundingid)
- [azt_fundingyear](#index-azt_fundingyear)
- [azt_goaltype](#index-azt_goaltype)
- [azt_historicalowner](#index-azt_historicalowner)
- [azt_importname](#index-azt_importname)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_invoiceproductid](#index-azt_invoiceproductid)
- [azt_isbn](#index-azt_isbn)
- [azt_iscompanion](#index-azt_iscompanion)
- [azt_isprint](#index-azt_isprint)
- [azt_issaas](#index-azt_issaas)
- [azt_jobrole](#index-azt_jobrole)
- [azt_jobtitle](#index-azt_jobtitle)
- [azt_lastname](#index-azt_lastname)
- [azt_leadimportid](#index-azt_leadimportid)
- [azt_licensestatus](#index-azt_licensestatus)
- [azt_licenseterm](#index-azt_licenseterm)
- [azt_licensetermmonths](#index-azt_licensetermmonths)
- [azt_licensetype](#index-azt_licensetype)
- [azt_masecommission](#index-azt_masecommission)
- [azt_mileage](#index-azt_mileage)
- [azt_monthstofilteron](#index-azt_monthstofilteron)
- [azt_name](#index-azt_name)
- [azt_newestclosedate](#index-azt_newestclosedate)
- [azt_newestimatedvalue](#index-azt_newestimatedvalue)
- [azt_newownerid](#index-azt_newownerid)
- [azt_newprobability](#index-azt_newprobability)
- [azt_nonsaasstatus](#index-azt_nonsaasstatus)
- [azt_nonsaastype](#index-azt_nonsaastype)
- [azt_numberoflicenses](#index-azt_numberoflicenses)
- [azt_opportunityauditrecordid](#index-azt_opportunityauditrecordid)
- [azt_opportunityid](#index-azt_opportunityid)
- [azt_opportunityproductid](#index-azt_opportunityproductid)
- [azt_orderid](#index-azt_orderid)
- [azt_orderlineid](#index-azt_orderlineid)
- [azt_orderproductid](#index-azt_orderproductid)
- [azt_orderstageid](#index-azt_orderstageid)
- [azt_ordertemplatelines](#index-azt_ordertemplatelines)
- [azt_ordertype](#index-azt_ordertype)
- [azt_originatingleadimportid](#index-azt_originatingleadimportid)
- [azt_paid](#index-azt_paid)
- [azt_paidon](#index-azt_paidon)
- [azt_parentopportunityid](#index-azt_parentopportunityid)
- [azt_parentorderid](#index-azt_parentorderid)
- [azt_payablecommission](#index-azt_payablecommission)
- [azt_paymentdate](#index-azt_paymentdate)
- [azt_paymentid](#index-azt_paymentid)
- [azt_percentage](#index-azt_percentage)
- [azt_percentagepaid](#index-azt_percentagepaid)
- [azt_periodend](#index-azt_periodend)
- [azt_periodstart](#index-azt_periodstart)
- [azt_phone](#index-azt_phone)
- [azt_ponumber](#index-azt_ponumber)
- [azt_prefix](#index-azt_prefix)
- [azt_prefixhasseparator](#index-azt_prefixhasseparator)
- [azt_prefixseparator](#index-azt_prefixseparator)
- [azt_prefixseparatorisspace](#index-azt_prefixseparatorisspace)
- [azt_previousestclosedate](#index-azt_previousestclosedate)
- [azt_previousestimatedvalue](#index-azt_previousestimatedvalue)
- [azt_previousownerid](#index-azt_previousownerid)
- [azt_previousprobability](#index-azt_previousprobability)
- [azt_printproductid](#index-azt_printproductid)
- [azt_printpurchaseid](#index-azt_printpurchaseid)
- [azt_probabilitychangedon](#index-azt_probabilitychangedon)
- [azt_probabilityincreased](#index-azt_probabilityincreased)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [azt_producttype](#index-azt_producttype)
- [azt_purchasedate](#index-azt_purchasedate)
- [azt_quantity](#index-azt_quantity)
- [azt_quotenumber](#index-azt_quotenumber)
- [azt_quoteproductid](#index-azt_quoteproductid)
- [azt_reasonforexpense](#index-azt_reasonforexpense)
- [azt_recordowner](#index-azt_recordowner)
- [azt_replacementproductid](#index-azt_replacementproductid)
- [azt_resolvedbyid](#index-azt_resolvedbyid)
- [azt_result](#index-azt_result)
- [azt_saas](#index-azt_saas)
- [azt_saasstatus](#index-azt_saasstatus)
- [azt_salesrepid](#index-azt_salesrepid)
- [azt_salesstage](#index-azt_salesstage)
- [azt_softwarelicenseid](#index-azt_softwarelicenseid)
- [azt_softwareproductid](#index-azt_softwareproductid)
- [azt_startdate](#index-azt_startdate)
- [azt_stateabbreviation](#index-azt_stateabbreviation)
- [azt_stateprovince](#index-azt_stateprovince)
- [azt_suffix](#index-azt_suffix)
- [azt_suffixhasseparator](#index-azt_suffixhasseparator)
- [azt_suffixseparator](#index-azt_suffixseparator)
- [azt_suffixseparatorisspace](#index-azt_suffixseparatorisspace)
- [azt_supportexpirationdate](#index-azt_supportexpirationdate)
- [azt_total](#index-azt_total)
- [azt_totalamountpaid](#index-azt_totalamountpaid)
- [azt_totalfunding](#index-azt_totalfunding)
- [azt_totalreimbursement](#index-azt_totalreimbursement)
- [azt_trackingnumber](#index-azt_trackingnumber)
- [azt_trackingnumbers](#index-azt_trackingnumbers)
- [azt_trainingid](#index-azt_trainingid)
- [azt_year](#index-azt_year)
- [baseamount](#index-baseamount)
- [billto_line1](#index-billto_line1)
- [billto_line2](#index-billto_line2)
- [billto_line3](#index-billto_line3)
- [billto_name](#index-billto_name)
- [billto_postalcode](#index-billto_postalcode)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [body](#index-body)
- [bpf_duration](#index-bpf_duration)
- [bpf_salesorderid](#index-bpf_salesorderid)
- [budgetstatus](#index-budgetstatus)
- [businessprocessflowinstanceid](#index-businessprocessflowinstanceid)
- [businessunitid](#index-businessunitid)
- [captureproposalfeedback](#index-captureproposalfeedback)
- [category](#index-category)
- [companyname](#index-companyname)
- [completefinalproposal](#index-completefinalproposal)
- [completeinternalreview](#index-completeinternalreview)
- [confirminterest](#index-confirminterest)
- [connectionid](#index-connectionid)
- [connectionroleid](#index-connectionroleid)
- [consideronlygoalownersrecords](#index-consideronlygoalownersrecords)
- [contactid](#index-contactid)
- [crm3_expenseamount](#index-crm3_expenseamount)
- [crm3_parentleadid](#index-crm3_parentleadid)
- [customerid](#index-customerid)
- [customerpainpoints](#index-customerpainpoints)
- [datefulfilled](#index-datefulfilled)
- [decisionmaker](#index-decisionmaker)
- [defaultuomid](#index-defaultuomid)
- [developproposal](#index-developproposal)
- [emailaddress](#index-emailaddress)
- [emailaddress1](#index-emailaddress1)
- [evaluatefit](#index-evaluatefit)
- [ext_amt](#index-ext_amt)
- [extendedamount](#index-extendedamount)
- [fetchxml](#index-fetchxml)
- [filedebrief](#index-filedebrief)
- [filename](#index-filename)
- [firstname](#index-firstname)
- [freighttermscode](#index-freighttermscode)
- [from](#index-from)
- [fullname](#index-fullname)
- [goalenddate](#index-goalenddate)
- [goalid](#index-goalid)
- [goalownerid](#index-goalownerid)
- [goalrollupqueryid](#index-goalrollupqueryid)
- [goalstartdate](#index-goalstartdate)
- [identifycompetitors](#index-identifycompetitors)
- [identifycustomercontacts](#index-identifycustomercontacts)
- [identifypursuitteam](#index-identifypursuitteam)
- [incidentid](#index-incidentid)
- [initialcommunication](#index-initialcommunication)
- [internalemailaddress](#index-internalemailaddress)
- [invline.productid](#index-invlineproductid)
- [invoicedetailid](#index-invoicedetailid)
- [invoiceid](#index-invoiceid)
- [invoicenumber](#index-invoicenumber)
- [isamount](#index-isamount)
- [isfiscalperiodgoal](#index-isfiscalperiodgoal)
- [isocurrencycode](#index-isocurrencycode)
- [ispriceoverridden](#index-ispriceoverridden)
- [isproductoverridden](#index-isproductoverridden)
- [jobtitle](#index-jobtitle)
- [lastname](#index-lastname)
- [manualdiscountamount](#index-manualdiscountamount)
- [metricid](#index-metricid)
- [mimetype](#index-mimetype)
- [mobilephone](#index-mobilephone)
- [modifiedon](#index-modifiedon)
- [need](#index-need)
- [objectid](#index-objectid)
- [objecttypecode](#index-objecttypecode)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)
- [opportunityratingcode](#index-opportunityratingcode)
- [parentcustomerid](#index-parentcustomerid)
- [parentgoalid](#index-parentgoalid)
- [parentsystemuserid](#index-parentsystemuserid)
- [partyid](#index-partyid)
- [phonenumber](#index-phonenumber)
- [presentfinalproposal](#index-presentfinalproposal)
- [presentproposal](#index-presentproposal)
- [priceperunit](#index-priceperunit)
- [primarycontactid](#index-primarycontactid)
- [prioritycode](#index-prioritycode)
- [prod.productid](#index-prodproductid)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [productname](#index-productname)
- [productnumber](#index-productnumber)
- [producttypecode](#index-producttypecode)
- [pursuitdecision](#index-pursuitdecision)
- [qualificationcomments](#index-qualificationcomments)
- [quantity](#index-quantity)
- [queryentitytype](#index-queryentitytype)
- [queueid](#index-queueid)
- [queueitemid](#index-queueitemid)
- [quotecomments](#index-quotecomments)
- [quotedetailid](#index-quotedetailid)
- [quoteid](#index-quoteid)
- [record1id](#index-record1id)
- [record1roleid](#index-record1roleid)
- [record2id](#index-record2id)
- [record2roleid](#index-record2roleid)
- [regardingobjectid](#index-regardingobjectid)
- [requestdeliveryby](#index-requestdeliveryby)
- [resolvefeedback](#index-resolvefeedback)
- [roleid](#index-roleid)
- [rolluponlyfromchildgoals](#index-rolluponlyfromchildgoals)
- [rollupqueryactualmoneyid](#index-rollupqueryactualmoneyid)
- [salesorderdetailid](#index-salesorderdetailid)
- [salesorderdetailname](#index-salesorderdetailname)
- [salesorderid](#index-salesorderid)
- [salesrepid](#index-salesrepid)
- [salesstagecode](#index-salesstagecode)
- [scheduledend](#index-scheduledend)
- [sendthankyounote](#index-sendthankyounote)
- [shippingmethodcode](#index-shippingmethodcode)
- [shipto_line1](#index-shipto_line1)
- [shipto_line2](#index-shipto_line2)
- [shipto_line3](#index-shipto_line3)
- [shipto_name](#index-shipto_name)
- [shipto_postalcode](#index-shipto_postalcode)
- [shipto_stateorprovince](#index-shipto_stateorprovince)
- [statecode](#index-statecode)
- [stateorprovince](#index-stateorprovince)
- [statuscode](#index-statuscode)
- [subject](#index-subject)
- [systemuserid](#index-systemuserid)
- [tax](#index-tax)
- [teamid](#index-teamid)
- [teamtype](#index-teamtype)
- [telephone1](#index-telephone1)
- [title](#index-title)
- [tm.systemuserid](#index-tmsystemuserid)
- [to](#index-to)
- [uomid](#index-uomid)
- [{0}](#index-0)

**Fields on forms but never in logic (24):**

- [actioncards](#index-actioncards)
- [activities](#index-activities)
- [azt_assignedamid](#index-azt_assignedamid)
- [azt_iscrossselloppty](#index-azt_iscrossselloppty)
- [azt_renewalnotes](#index-azt_renewalnotes)
- [cadencewidgetcontrol](#index-cadencewidgetcontrol)
- [competitors](#index-competitors)
- [discounts](#index-discounts)
- [documents](#index-documents)
- [documentssubgrid](#index-documentssubgrid)
- [dynamicpropertieslist_linkcontrol](#index-dynamicpropertieslist_linkcontrol)
- [msdyn_forecastcategory](#index-msdyn_forecastcategory)
- [notescontrol](#index-notescontrol)
- [opportunityaudit](#index-opportunityaudit)
- [opportunityproductsgrid](#index-opportunityproductsgrid)
- [productsuggestions_linkcontrol](#index-productsuggestions_linkcontrol)
- [pursuit_team](#index-pursuit_team)
- [quote](#index-quote)
- [ricontainer_charts](#index-ricontainer_charts)
- [stakeholders](#index-stakeholders)
- [totalamountlessfreight](#index-totalamountlessfreight)
- [totallineitemamount](#index-totallineitemamount)
- [totaltax](#index-totaltax)
- [webresource_recordwall](#index-webresource_recordwall)

---

## <a id="index"></a>Index

Alphabetical field index -- 446 unique fields referenced.

**<a id="index-process_custom_attribute_url_"></a>`!process_custom_attribute_url_`**

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchOpportunityTransfer (Read)](#79-batchopportunitytransfer)
- [Workflow: WonOpportunityEmail (Read)](#758-wonopportunityemail)

**<a id="index-a_887fa82ffe04e911a94d000d3a3b9f01address1_city"></a>`a_887fa82ffe04e911a94d000d3a3b9f01.address1_city`**

- [Field Definitions](#1-field-definitions)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)

**<a id="index-a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince"></a>`a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)

**<a id="index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_city"></a>`a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)

**<a id="index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_composite"></a>`a_ef7baa35fe04e911a94d000d3a3b9f01.address1_composite`**

- [Field Definitions](#1-field-definitions)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)

**<a id="index-a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince"></a>`a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)

**<a id="index-a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket"></a>`a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket`**

- [Field Definitions](#1-field-definitions)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)

**<a id="index-a_ef7baa35fe04e911a94d000d3a3b9f01ownerid"></a>`a_ef7baa35fe04e911a94d000d3a3b9f01.ownerid`**

- [Field Definitions](#1-field-definitions)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Open Opportunities](#332-open-opportunities)

**<a id="index-accountid"></a>`accountid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Write)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Join)](#102-accountleadgen)
- [Plugin: AccountLeadGenAssociate (Write)](#103-accountleadgenassociate)
- [Plugin: AccountTypeSet (Write)](#105-accounttypeset)
- [Plugin: GetAcctTeamOwned (Read)](#1031-getacctteamowned)
- [Plugin: GetAcctTeamOwned (Filter)](#1031-getacctteamowned)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#1076-sharebasedonaccessteam)

**<a id="index-actioncards"></a>`actioncards`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Assistant](#22-igrad-main-active)

**<a id="index-activities"></a>`activities`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)

**<a id="index-activityid"></a>`activityid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Image)](#1059-phonecallcreatecallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

**<a id="index-activitytypecode"></a>`activitytypecode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)

**<a id="index-actualclosedate"></a>`actualclosedate`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Footer)](#22-igrad-main-active)
- [Form: Opportunity (Footer)](#23-opportunity-main-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities in Current Fiscal Year (Filter)](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Closed Opportunities (Sort)](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: Lost Opportunities (Sort)](#37-lost-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Closed Opportunities in Current Fiscal Year (Filter)](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Opportunities Won This Quarter (Filter)](#325-my-opportunities-won-this-quarter)
- [View: My Opportunities Won This Year No Renewals (Filter)](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: My Won Opps this Year (Filter)](#330-my-won-opps-this-year)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Recent Opportunities (Filter)](#355-recent-opportunities)
- [View: Won Opportunities This Month (Filter)](#358-won-opportunities-this-month)
- [View: Won Opportunities This Quarter (Filter)](#359-won-opportunities-this-quarter)
- [View: Won Opportunities This Week (Filter)](#360-won-opportunities-this-week)
- [View: Won Opportunities This Year (Filter)](#361-won-opportunities-this-year)
- [View: Won Opportunities](#362-won-opportunities)
- [View: Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Month (Filter)](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Quarter (Filter)](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [View: Won Renewal Opps This Year (Filter)](#365-won-renewal-opps-this-year)
- [Chart: My Won Opportunities This Year By Quarter (Group-By)](#417-my-won-opportunities-this-year-by-quarter)
- [Chart: Won Opportunities This Year By Owner (Group-By)](#420-won-opportunities-this-year-by-owner)
- [Chart: Won Renewal Opps This Month (Measure)](#437-won-renewal-opps-this-month)
- [Chart: Won Renewal Opps This Quarter (Measure)](#438-won-renewal-opps-this-quarter)
- [Chart: Won Renewal Opps This Year (Measure)](#439-won-renewal-opps-this-year)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

**<a id="index-actualvalue"></a>`actualvalue`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities in Current Fiscal Year (Sort)](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Closed Opportunities in Current Fiscal Year (Sort)](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: My Won Opps this Year (Sort)](#330-my-won-opps-this-year)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities in Current Fiscal Year (Sort)](#343-opportunities-in-current-fiscal-year)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Won Opportunities](#362-won-opportunities)
- [View: Won Opportunities (Sort)](#362-won-opportunities)
- [Chart: Won This Fiscal Year (Measure)](#48-won-this-fiscal-year)
- [Chart: Won This Year (No Renewals) (Measure)](#49-won-this-year-no-renewals)
- [Workflow: BatchLooseOpportunities (Write)](#78-batchlooseopportunities)

**<a id="index-actualvalue_base"></a>`actualvalue_base`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)

**<a id="index-address1_city"></a>`address1_city`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)

**<a id="index-address1_composite"></a>`address1_composite`**

- [Field Definitions](#1-field-definitions)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)

**<a id="index-address1_stateorprovince"></a>`address1_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: AutoAssignStateAbb (Read)](#1012-autoassignstateabb)
- [Plugin: AutoAssignStateAbb (Write)](#1012-autoassignstateabb)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-address1_telephone1"></a>`address1_telephone1`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

**<a id="index-adx_resolutiondate"></a>`adx_resolutiondate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CaseClose (Write)](#1015-caseclose)

**<a id="index-amountdatatype"></a>`amountdatatype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

**<a id="index-annotationid"></a>`annotationid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

**<a id="index-associatedconnectionroleid"></a>`associatedconnectionroleid`**

- [Plugin: ContactSetConnectionRole (Join)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Join)](#1075-setprimarycontact)

**<a id="index-azt_account"></a>`azt_account`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)

**<a id="index-azt_accountclassification"></a>`azt_accountclassification`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_accountid"></a>`azt_accountid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Filter)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

**<a id="index-azt_accountleadgenerationid"></a>`azt_accountleadgenerationid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Filter)](#102-accountleadgen)
- [Plugin: AccountLeadGenAssociate (Read)](#103-accountleadgenassociate)
- [Plugin: AccountLeadGenAssociate (Filter)](#103-accountleadgenassociate)

**<a id="index-azt_accountleadgenname"></a>`azt_accountleadgenname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGenAssociate (Write)](#103-accountleadgenassociate)

**<a id="index-azt_accounttype"></a>`azt_accounttype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountTypeSet (Write)](#105-accounttypeset)

**<a id="index-azt_addonopportunitytotal"></a>`azt_addonopportunitytotal`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [Formula: azt_addonopportunitytotal (Target)](#9-formulas-rollups)

**<a id="index-azt_addonopportunitytotal_base"></a>`azt_addonopportunitytotal_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_addresssearch"></a>`azt_addresssearch`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

**<a id="index-azt_addresssearch2"></a>`azt_addresssearch2`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

**<a id="index-azt_addtocrtqueue"></a>`azt_addtocrtqueue`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_ageendedstage"></a>`azt_ageendedstage`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

**<a id="index-azt_allocatedtoid"></a>`azt_allocatedtoid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_allocationtype"></a>`azt_allocationtype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_amount"></a>`azt_amount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-azt_annualspend"></a>`azt_annualspend`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingSetAnnualSpend (Write)](#1028-fundingsetannualspend)

**<a id="index-azt_approvalstatus"></a>`azt_approvalstatus`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
- [Plugin: OpportunityPreventCreateQuote (Read)](#1047-opportunitypreventcreatequote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)

**<a id="index-azt_assignedamid"></a>`azt_assignedamid`**

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Relationship: azt_amsystemuser_opportunity](#12-relationships)

**<a id="index-azt_autocreatecallback"></a>`azt_autocreatecallback`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_autonumberid"></a>`azt_autonumberid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)
- [Plugin: AutoNumber (Write)](#1013-autonumber)

**<a id="index-azt_azteccustomerid"></a>`azt_azteccustomerid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_bookingurl"></a>`azt_bookingurl`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)
- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

**<a id="index-azt_callbackin"></a>`azt_callbackin`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_callbackon"></a>`azt_callbackon`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_caseid"></a>`azt_caseid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CaseAudit (Write)](#1014-caseaudit)

**<a id="index-azt_commissionamount"></a>`azt_commissionamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)

**<a id="index-azt_commissionid"></a>`azt_commissionid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-azt_commissionpaymentid"></a>`azt_commissionpaymentid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)

**<a id="index-azt_committoestimatedclose"></a>`azt_committoestimatedclose`**

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)

**<a id="index-azt_companyname"></a>`azt_companyname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_compcompleted"></a>`azt_compcompleted`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)

**<a id="index-azt_compgoalid"></a>`azt_compgoalid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

**<a id="index-azt_compgoaltypeid"></a>`azt_compgoaltypeid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)

**<a id="index-azt_compplanamountid"></a>`azt_compplanamountid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)

**<a id="index-azt_concurrentusers"></a>`azt_concurrentusers`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_copydescription"></a>`azt_copydescription`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_copysubject"></a>`azt_copysubject`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_currentnumber"></a>`azt_currentnumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)
- [Plugin: AutoNumber (Write)](#1013-autonumber)

**<a id="index-azt_customerid"></a>`azt_customerid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_customertrainingid"></a>`azt_customertrainingid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)

**<a id="index-azt_dateexitedstage"></a>`azt_dateexitedstage`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

**<a id="index-azt_dayssincecreated"></a>`azt_dayssincecreated`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [Formula: azt_dayssincecreated (Target)](#9-formulas-rollups)

**<a id="index-azt_dayssinceprobabilitychanged"></a>`azt_dayssinceprobabilitychanged`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Aged or Stuck Opportunities (Filter)](#38-my-aged-or-stuck-opportunities)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [Formula: azt_dayssinceprobabilitychanged (Target)](#9-formulas-rollups)

**<a id="index-azt_defaultfreightamount"></a>`azt_defaultfreightamount`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Freight](#22-igrad-main-active)
- [Form: Opportunity > Products > Freight](#23-opportunity-main-active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#810-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#814-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

**<a id="index-azt_defaultfreightamount_base"></a>`azt_defaultfreightamount_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_deliverytype"></a>`azt_deliverytype`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_description"></a>`azt_description`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

**<a id="index-azt_discountamount"></a>`azt_discountamount`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)

**<a id="index-azt_discretionarydiscount"></a>`azt_discretionarydiscount`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity-main-active)
- [Formula: azt_discretionarydiscount (Target)](#9-formulas-rollups)

**<a id="index-azt_discretionarydiscount_base"></a>`azt_discretionarydiscount_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_discretionarydiscountamt"></a>`azt_discretionarydiscountamt`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity-main-active)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)

**<a id="index-azt_discretionarydiscountamt_base"></a>`azt_discretionarydiscountamt_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_duedate"></a>`azt_duedate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

**<a id="index-azt_effectivedate"></a>`azt_effectivedate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)

**<a id="index-azt_email"></a>`azt_email`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImportPopulateName (Read)](#1037-leadimportpopulatename)

**<a id="index-azt_enddate"></a>`azt_enddate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: EngagementSetEndDate (Write)](#1025-engagementsetenddate)

**<a id="index-azt_engagementid"></a>`azt_engagementid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: EngagementFSRAssignedOn (Read)](#1024-engagementfsrassignedon)
- [Plugin: EngagementFSRAssignedOn (Write)](#1024-engagementfsrassignedon)
- [Plugin: EngagementSetEndDate (Write)](#1025-engagementsetenddate)

**<a id="index-azt_estfulfillmentdate"></a>`azt_estfulfillmentdate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-azt_evaluate"></a>`azt_evaluate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Image)](#102-accountleadgen)

**<a id="index-azt_expectedrenewalvalue"></a>`azt_expectedrenewalvalue`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [View: Open Renewal Opps 90 Days Past Due](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days](#337-open-renewal-opps-closing-within-90-days)
- [View: Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)

**<a id="index-azt_expectedrenewalvalue_base"></a>`azt_expectedrenewalvalue_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_expenseamount"></a>`azt_expenseamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)

**<a id="index-azt_expenseid"></a>`azt_expenseid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Filter)](#1017-cloneexpenseline)

**<a id="index-azt_expensereportid"></a>`azt_expensereportid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Filter)](#1026-expenselinetotals)

**<a id="index-azt_expensetype"></a>`azt_expensetype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

**<a id="index-azt_expirationdate"></a>`azt_expirationdate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_extension"></a>`azt_extension`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

**<a id="index-azt_fieldtoautonumber"></a>`azt_fieldtoautonumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_firstname"></a>`azt_firstname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_fiscalperiodend"></a>`azt_fiscalperiodend`**

- [Field Definitions](#1-field-definitions)
- [Plugin: Utility (Write)](#1081-utility)
- [Plugin: Utility (Filter)](#1081-utility)

**<a id="index-azt_fiscalperiodstart"></a>`azt_fiscalperiodstart`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Sort)](#1020-createcompgoals)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-azt_freightamtapproved"></a>`azt_freightamtapproved`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Freight](#22-igrad-main-active)
- [Form: Opportunity > Products > Freight](#23-opportunity-main-active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#810-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#814-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

**<a id="index-azt_fsrassignedon"></a>`azt_fsrassignedon`**

- [Field Definitions](#1-field-definitions)
- [Plugin: EngagementFSRAssignedOn (Write)](#1024-engagementfsrassignedon)

**<a id="index-azt_fsremail"></a>`azt_fsremail`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

**<a id="index-azt_fsrid"></a>`azt_fsrid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

**<a id="index-azt_fsrmobiletelephone"></a>`azt_fsrmobiletelephone`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

**<a id="index-azt_fsrtelephone"></a>`azt_fsrtelephone`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

**<a id="index-azt_fsrtelephoneextension"></a>`azt_fsrtelephoneextension`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

**<a id="index-azt_fundingid"></a>`azt_fundingid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingSetAnnualSpend (Write)](#1028-fundingsetannualspend)
- [Plugin: FundingTotalAmt (Write)](#1029-fundingtotalamt)

**<a id="index-azt_fundingsource"></a>`azt_fundingsource`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column2](#25-opportunity-quickcreate-active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick-quickcreate-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_fundingyear"></a>`azt_fundingyear`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: FundingYearSync (Read)](#1030-fundingyearsync)

**<a id="index-azt_goaltype"></a>`azt_goaltype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

**<a id="index-azt_historicalowner"></a>`azt_historicalowner`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Write)](#716-cloneanddeletequote)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_importname"></a>`azt_importname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImportPopulateName (Read)](#1037-leadimportpopulatename)

**<a id="index-azt_initialopportunitytotal"></a>`azt_initialopportunitytotal`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [Formula: azt_initialopportunitytotal (Target)](#9-formulas-rollups)

**<a id="index-azt_initialopportunitytotal_base"></a>`azt_initialopportunitytotal_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_internalaztecnotes"></a>`azt_internalaztecnotes`**

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_invoiceid"></a>`azt_invoiceid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CompGoalCreate (Read)](#1018-compgoalcreate)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Join)](#1022-createusergoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Filter)](#1081-utility)

**<a id="index-azt_invoicenumber"></a>`azt_invoicenumber`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_invoiceproductid"></a>`azt_invoiceproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#1063-quoteorderproductstrackdiscount)

**<a id="index-azt_isbn"></a>`azt_isbn`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_iscompanion"></a>`azt_iscompanion`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

**<a id="index-azt_iscrossselloppty"></a>`azt_iscrossselloppty`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)

**<a id="index-azt_isprint"></a>`azt_isprint`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

**<a id="index-azt_issaas"></a>`azt_issaas`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: SetOppProductDefaults (Write)](#1074-setoppproductdefaults)

**<a id="index-azt_jobrole"></a>`azt_jobrole`**

- [Field Definitions](#1-field-definitions)
- [View: My Open Opportunities Created This Month (Filter)](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Week (Filter)](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Year (Filter)](#315-my-open-opportunities-created-this-year)
- [View: My Opportunities Closing Next Year (Filter)](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter (Filter)](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year (Filter)](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Week (Filter)](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Created This Quarter (Filter)](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year (Filter)](#324-my-opportunities-created-this-year)
- [View: My Opportunities Won This Quarter (Filter)](#325-my-opportunities-won-this-quarter)
- [View: My Won Opps this Year (Filter)](#330-my-won-opps-this-year)
- [View: Open Opportunities by Sales Rep (Filter)](#331-open-opportunities-by-sales-rep)
- [View: Opportunities Closing This Month (Filter)](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Week (Filter)](#341-opportunities-closing-this-week)
- [View: Opportunities Opened This Month (Filter)](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter (Filter)](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week (Filter)](#348-opportunities-opened-this-week)
- [View: Won Opportunities This Month (Filter)](#358-won-opportunities-this-month)
- [View: Won Opportunities This Quarter (Filter)](#359-won-opportunities-this-quarter)
- [View: Won Opportunities This Week (Filter)](#360-won-opportunities-this-week)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: RestrictProductLookups (Read)](#1069-restrictproductlookups)

**<a id="index-azt_jobtitle"></a>`azt_jobtitle`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_lastactivitydate"></a>`azt_lastactivitydate`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [Plugin: OpportunityLastActivityDate (Write)](#1045-opportunitylastactivitydate)

**<a id="index-azt_lastmodifiedbyid"></a>`azt_lastmodifiedbyid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Relationship: azt_systemusermodified_opportunity](#12-relationships)

**<a id="index-azt_lastname"></a>`azt_lastname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_leadimportid"></a>`azt_leadimportid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-azt_leadsource"></a>`azt_leadsource`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_leadsourceid"></a>`azt_leadsourceid`**

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [View: Self Sourced Pipeline per rep in Last 30 Days (Filter)](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [Workflow: BatchConverttoLead (Write)](#76-batchconverttolead)
- [Workflow: BulkChangeLeadSource (Write)](#710-bulkchangeleadsource)
- [Workflow: CreateLeadfromAccount (Write)](#723-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#725-customleadcreation)
- [Workflow: LeadAssignment (Read)](#732-leadassignment)
- [Workflow: LeadSourceChange (Write)](#735-leadsourcechange)
- [Workflow: SetLeadTemperature (Read)](#751-setleadtemperature)
- [Workflow: TaskCreateReorderLead (Write)](#756-taskcreatereorderlead)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Relationship: azt_azt_leadsource_opportunity](#12-relationships)

**<a id="index-azt_licensestatus"></a>`azt_licensestatus`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_licenseterm"></a>`azt_licenseterm`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderLinePopulateLicType (Read)](#1053-orderlinepopulatelictype)

**<a id="index-azt_licensetermmonths"></a>`azt_licensetermmonths`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityClone (Write)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Write)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderClone (Write)](#1051-orderclone)
- [Plugin: OrderLinePopulateLicType (Read)](#1053-orderlinepopulatelictype)
- [Plugin: OrderLinePopulateLicType (Write)](#1053-orderlinepopulatelictype)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: SetOppProductDefaults (Read)](#1074-setoppproductdefaults)
- [Plugin: SetOppProductDefaults (Write)](#1074-setoppproductdefaults)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-azt_licensetype"></a>`azt_licensetype`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_addonopportunitytotal](#9-formulas-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-rollups)
- [Plugin: ChangeLicenseType (Write)](#1016-changelicensetype)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityClone (Write)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Write)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderClone (Write)](#1051-orderclone)
- [Plugin: OrderLinePopulateLicType (Read)](#1053-orderlinepopulatelictype)
- [Plugin: OrderLinePopulateLicType (Write)](#1053-orderlinepopulatelictype)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: SetOppProductDefaults (Read)](#1074-setoppproductdefaults)
- [Plugin: SetOppProductDefaults (Write)](#1074-setoppproductdefaults)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-azt_masecommission"></a>`azt_masecommission`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

**<a id="index-azt_mileage"></a>`azt_mileage`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

**<a id="index-azt_monthstofilteron"></a>`azt_monthstofilteron`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Image)](#102-accountleadgen)

**<a id="index-azt_name"></a>`azt_name`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGenAssociate (Read)](#103-accountleadgenassociate)
- [Plugin: AccountLeadGenAssociate (Sort)](#103-accountleadgenassociate)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: AutoNumber (Filter)](#1013-autonumber)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CompGoalCreate (Write)](#1018-compgoalcreate)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: LeadImportPopulateName (Write)](#1037-leadimportpopulatename)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)
- [Plugin: OpptyToQuoteFieldMappings (Sort)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: QuoteOrderProductsTrackDiscount (Sort)](#1063-quoteorderproductstrackdiscount)
- [Plugin: ReviseQuoteDiscountMove (Sort)](#1072-revisequotediscountmove)
- [Plugin: Utility (Write)](#1081-utility)
- [Plugin: Utility (Sort)](#1081-utility)

**<a id="index-azt_newestclosedate"></a>`azt_newestclosedate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

**<a id="index-azt_newestimatedvalue"></a>`azt_newestimatedvalue`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

**<a id="index-azt_newownerid"></a>`azt_newownerid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CaseAudit (Write)](#1014-caseaudit)

**<a id="index-azt_newprobability"></a>`azt_newprobability`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

**<a id="index-azt_nonsaasstatus"></a>`azt_nonsaasstatus`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountTypeSet (Read)](#105-accounttypeset)
- [Plugin: AccountTypeSet (Image)](#105-accounttypeset)

**<a id="index-azt_nonsaastype"></a>`azt_nonsaastype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

**<a id="index-azt_numberoflicenses"></a>`azt_numberoflicenses`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_opportunityauditrecordid"></a>`azt_opportunityauditrecordid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OppAuditRemoval (Read)](#1041-oppauditremoval)

**<a id="index-azt_opportunityid"></a>`azt_opportunityid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OppAuditRemoval (Filter)](#1041-oppauditremoval)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#1050-opptytoquotefieldmappings)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Relationship: azt_opportunity_azt_compgoaltype](#12-relationships)
- [Relationship: azt_opportunity_azt_opportunityauditrecord](#12-relationships)
- [Relationship: azt_opportunity_azt_productdiscount](#12-relationships)

**<a id="index-azt_opportunityleadid"></a>`azt_opportunityleadid`**

- [Field Definitions](#1-field-definitions)
- [Relationship: azt_opportunity_lead](#12-relationships)

**<a id="index-azt_opportunitynumber"></a>`azt_opportunitynumber`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Quick Find Open Opportunities (Filter)](#354-quick-find-open-opportunities)
- [View: Won Opportunities](#362-won-opportunities)

**<a id="index-azt_opportunityproductcategory"></a>`azt_opportunityproductcategory`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_opportunityproductid"></a>`azt_opportunityproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OpportunityPreventCreateQuote (Filter)](#1047-opportunitypreventcreatequote)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#1050-opptytoquotefieldmappings)
- [Plugin: QuoteLinesSyncToOppty (Write)](#1062-quotelinessynctooppty)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#1063-quoteorderproductstrackdiscount)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: Utility (Filter)](#1081-utility)

**<a id="index-azt_opportunitytype"></a>`azt_opportunitytype`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column2](#25-opportunity-quickcreate-active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick-quickcreate-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure 30 Day Pipeline (Filter)](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Filter)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Aged or Stuck Opportunities (Filter)](#38-my-aged-or-stuck-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added Last Week (Filter)](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Month (Filter)](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Initial/Add-on Opportunities Added This Week (Filter)](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Opportunities Won This Year No Renewals (Filter)](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Overdue Opps (Filter)](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: My Stalled Opportunities (Filter)](#329-my-stalled-opportunities)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Open Renewal Opps 90 Days Past Due (Filter)](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month (Filter)](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month (Filter)](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month (Filter)](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days (Filter)](#337-open-renewal-opps-closing-within-90-days)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Overdue Opportunities > 45 Days (Filter)](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Quick Find Open Opportunities (Filter)](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Upcoming Internet Renewals (Filter)](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)
- [View: Won Renewal Opps This Month (Filter)](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter (Filter)](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year (Filter)](#365-won-renewal-opps-this-year)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_orderid"></a>`azt_orderid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CompGoalCreate (Write)](#1018-compgoalcreate)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)
- [Plugin: OrderStageTracking (Filter)](#1057-orderstagetracking)
- [Plugin: ShipmentSetTrackingNumber (Read)](#1079-shipmentsettrackingnumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#1079-shipmentsettrackingnumber)

**<a id="index-azt_orderlineid"></a>`azt_orderlineid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: ShipmentSetTrackingNumber (Sort)](#1079-shipmentsettrackingnumber)

**<a id="index-azt_orderproductid"></a>`azt_orderproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#1063-quoteorderproductstrackdiscount)
- [Plugin: QuoteOrderProductsTrackDiscount (Filter)](#1063-quoteorderproductstrackdiscount)

**<a id="index-azt_orderstageid"></a>`azt_orderstageid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)
- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

**<a id="index-azt_ordertemplatelines"></a>`azt_ordertemplatelines`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderLinePopulateTemplateFields (Write)](#1054-orderlinepopulatetemplatefields)

**<a id="index-azt_ordertype"></a>`azt_ordertype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_originatingleadimportid"></a>`azt_originatingleadimportid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-azt_otheropportunitytotal"></a>`azt_otheropportunitytotal`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [Formula: azt_otheropportunitytotal (Target)](#9-formulas-rollups)

**<a id="index-azt_otheropportunitytotal_base"></a>`azt_otheropportunitytotal_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_paid"></a>`azt_paid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-azt_paidon"></a>`azt_paidon`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingSetAnnualSpend (Filter)](#1028-fundingsetannualspend)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-azt_parentopportunityid"></a>`azt_parentopportunityid`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityAudit (Image)](#1043-opportunityaudit)
- [Relationship: azt_opportunity_clonedopportunity](#12-relationships)

**<a id="index-azt_parentorderid"></a>`azt_parentorderid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-azt_payablecommission"></a>`azt_payablecommission`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

**<a id="index-azt_paymentdate"></a>`azt_paymentdate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Sort)](#1081-utility)

**<a id="index-azt_paymentid"></a>`azt_paymentid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-azt_percentage"></a>`azt_percentage`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

**<a id="index-azt_percentagepaid"></a>`azt_percentagepaid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

**<a id="index-azt_periodend"></a>`azt_periodend`**

- [Field Definitions](#1-field-definitions)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

**<a id="index-azt_periodstart"></a>`azt_periodstart`**

- [Field Definitions](#1-field-definitions)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

**<a id="index-azt_phone"></a>`azt_phone`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_pilotopportunitytotal"></a>`azt_pilotopportunitytotal`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [Formula: azt_pilotopportunitytotal (Target)](#9-formulas-rollups)

**<a id="index-azt_pilotopportunitytotal_base"></a>`azt_pilotopportunitytotal_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_pipelinestage"></a>`azt_pipelinestage`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-azt_ponumber"></a>`azt_ponumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-azt_prefix"></a>`azt_prefix`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_prefixhasseparator"></a>`azt_prefixhasseparator`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_prefixseparator"></a>`azt_prefixseparator`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_prefixseparatorisspace"></a>`azt_prefixseparatorisspace`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_previewcompleted"></a>`azt_previewcompleted`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_previousestclosedate"></a>`azt_previousestclosedate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

**<a id="index-azt_previousestimatedvalue"></a>`azt_previousestimatedvalue`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

**<a id="index-azt_previousownerid"></a>`azt_previousownerid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CaseAudit (Write)](#1014-caseaudit)

**<a id="index-azt_previousprobability"></a>`azt_previousprobability`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

**<a id="index-azt_printopportunitytotal"></a>`azt_printopportunitytotal`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [Formula: azt_printopportunitytotal (Target)](#9-formulas-rollups)

**<a id="index-azt_printopportunitytotal_base"></a>`azt_printopportunitytotal_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_printproductid"></a>`azt_printproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_printpurchaseid"></a>`azt_printpurchaseid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_probability"></a>`azt_probability`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column2](#25-opportunity-quickcreate-active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick-quickcreate-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)
- [Plugin: OpportunityProbabilityChange (Read)](#1048-opportunityprobabilitychange)
- [Plugin: OpportunityProbabilityChange (Image)](#1048-opportunityprobabilitychange)
- [Plugin: OpportunityProbabilityNumber (Read)](#1049-opportunityprobabilitynumber)

**<a id="index-azt_probabilitychangedon"></a>`azt_probabilitychangedon`**

- [Field Definitions](#1-field-definitions)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Filter)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Aged or Stuck Opportunities (Sort)](#38-my-aged-or-stuck-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: My Stalled Opportunities (Filter)](#329-my-stalled-opportunities)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-rollups)
- [Plugin: OpportunityProbabilityChange (Write)](#1048-opportunityprobabilitychange)

**<a id="index-azt_probabilityincreased"></a>`azt_probabilityincreased`**

- [Field Definitions](#1-field-definitions)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Filter)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [Plugin: OpportunityProbabilityChange (Write)](#1048-opportunityprobabilitychange)

**<a id="index-azt_productdiscountid"></a>`azt_productdiscountid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#1063-quoteorderproductstrackdiscount)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#1063-quoteorderproductstrackdiscount)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-azt_producttype"></a>`azt_producttype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#1035-invoicecompcompleted)

**<a id="index-azt_purchasedate"></a>`azt_purchasedate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_quantity"></a>`azt_quantity`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_quotenumber"></a>`azt_quotenumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-azt_quoteproductid"></a>`azt_quoteproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ActivateOrReviseQuote (Filter)](#106-activateorrevisequote)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)
- [Plugin: ProductDiscountPreventOnActiveQuote (Read)](#1060-productdiscountpreventonactivequote)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Filter)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)
- [Plugin: ReviseQuoteDiscountMove (Filter)](#1072-revisequotediscountmove)
- [Plugin: Utility (Filter)](#1081-utility)

**<a id="index-azt_quotesent"></a>`azt_quotesent`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_reasonforexpense"></a>`azt_reasonforexpense`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

**<a id="index-azt_recordowner"></a>`azt_recordowner`**

- [Field Definitions](#1-field-definitions)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)

**<a id="index-azt_recordownerid"></a>`azt_recordownerid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad-main-active)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity (Header)](#23-opportunity-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Form: Opportunity Record Owner > Tab > section](#27-opportunity-record-owner-quick-active)
- [Form: Opportunity Owner Quick View > Opportunity Owner > Opportunity Owner](#28-opportunity-owner-quick-view-quick-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure 30 Day Pipeline (Sort)](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Sort)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year (Filter)](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Initial/Add-on Opportunities Added Last Week (Filter)](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month (Filter)](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week (Filter)](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities Created This Month](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Month (Filter)](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Week](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Week (Filter)](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Week (Sort)](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Year (Filter)](#315-my-open-opportunities-created-this-year)
- [View: My Open Opportunities (Filter)](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner (Filter)](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year (Filter)](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter (Filter)](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year (Filter)](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month (Filter)](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Closing This Week](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Closing This Week (Filter)](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Closing This Week (Sort)](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Won This Quarter (Filter)](#325-my-opportunities-won-this-quarter)
- [View: My Opportunities Won This Year No Renewals (Filter)](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities (Filter)](#327-my-overdue-opportunities)
- [View: My Overdue Opps (Filter)](#328-my-overdue-opps)
- [View: My Stalled Opportunities (Filter)](#329-my-stalled-opportunities)
- [View: My Won Opps this Year (Filter)](#330-my-won-opps-this-year)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities by Sales Rep (Sort)](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Open Renewal Opps 90 Days Past Due](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps 90 Days Past Due (Sort)](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Close Date Last Month (Sort)](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing Next Month (Sort)](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing This Month (Sort)](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days](#337-open-renewal-opps-closing-within-90-days)
- [View: Open Renewal Opps Closing Within 90 Days (Sort)](#337-open-renewal-opps-closing-within-90-days)
- [View: Opportunities Closing This Month](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Month (Sort)](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Week](#341-opportunities-closing-this-week)
- [View: Opportunities Closing This Week (Sort)](#341-opportunities-closing-this-week)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Overdue Opportunities > 45 Days (Sort)](#353-overdue-opportunities-45-days)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Self Sourced Pipeline per rep in Last 30 Days (Sort)](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Won Opportunities This Month](#358-won-opportunities-this-month)
- [View: Won Opportunities This Month (Sort)](#358-won-opportunities-this-month)
- [View: Won Opportunities This Week](#360-won-opportunities-this-week)
- [View: Won Opportunities This Week (Sort)](#360-won-opportunities-this-week)
- [View: Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Month (Sort)](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Quarter (Sort)](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [View: Won Renewal Opps This Year (Sort)](#365-won-renewal-opps-this-year)
- [Chart: Won Opportunities This Quarter By Rep (Measure)](#411-won-opportunities-this-quarter-by-rep)
- [Chart: Won Opportunities This Quarter By Rep (Group-By)](#411-won-opportunities-this-quarter-by-rep)
- [Chart: My Opportunities Closing This Quarter (Measure)](#413-my-opportunities-closing-this-quarter)
- [Chart: My Opportunities Closing This Quarter (Group-By)](#413-my-opportunities-closing-this-quarter)
- [Chart: My Opportunities Won This Quarter (Measure)](#414-my-opportunities-won-this-quarter)
- [Chart: My Opportunities Won This Quarter (Group-By)](#414-my-opportunities-won-this-quarter)
- [Chart: My Open Opportunities Created This Year By Quarter (Measure)](#416-my-open-opportunities-created-this-year-by-quarter)
- [Chart: My Won Opportunities This Year By Quarter (Measure)](#417-my-won-opportunities-this-year-by-quarter)
- [Chart: Open Opportunities By Owner (Measure)](#419-open-opportunities-by-owner)
- [Chart: Open Opportunities By Owner (Group-By)](#419-open-opportunities-by-owner)
- [Chart: Won Opportunities This Year By Owner (Measure)](#420-won-opportunities-this-year-by-owner)
- [Chart: Opportunities Closing This Month (Measure)](#423-opportunities-closing-this-month)
- [Chart: Opportunities Closing This Month (Measure)](#423-opportunities-closing-this-month)
- [Chart: Opportunities Closing This Month (Group-By)](#423-opportunities-closing-this-month)
- [Chart: Won Opportunities This Month (Measure)](#424-won-opportunities-this-month)
- [Chart: Won Opportunities This Month (Group-By)](#424-won-opportunities-this-month)
- [Chart: Opportunities Closing This Week By Rep (Measure)](#426-opportunities-closing-this-week-by-rep)
- [Chart: Opportunities Closing This Week By Rep (Group-By)](#426-opportunities-closing-this-week-by-rep)
- [Chart: Won Opportunities This Week (Measure)](#427-won-opportunities-this-week)
- [Chart: Won Opportunities This Week (Group-By)](#427-won-opportunities-this-week)
- [Chart: My Opportunities Closing This Week (Measure)](#429-my-opportunities-closing-this-week)
- [Chart: My Opportunities Closing This Week (Group-By)](#429-my-opportunities-closing-this-week)
- [Chart: My Opportunities Closing This Month (Measure)](#431-my-opportunities-closing-this-month)
- [Chart: My Opportunities Closing This Month (Group-By)](#431-my-opportunities-closing-this-month)
- [Chart: Open Renewal Opps Close Date Last Month (Group-By)](#432-open-renewal-opps-close-date-last-month)
- [Chart: Open Renewal Opps Closing This Month (Group-By)](#433-open-renewal-opps-closing-this-month)
- [Chart: Open Renewal Opps Closing Next Month (Group-By)](#434-open-renewal-opps-closing-next-month)
- [Chart: Open Renewal Opps Closing Within 90 Days (Group-By)](#435-open-renewal-opps-closing-within-90-days)
- [Chart: Open Renewal Opps 90 Days Past Due (Group-By)](#436-open-renewal-opps-90-days-past-due)
- [Chart: Won Renewal Opps This Month (Group-By)](#437-won-renewal-opps-this-month)
- [Chart: Won Renewal Opps This Quarter (Group-By)](#438-won-renewal-opps-this-quarter)
- [Chart: Won Renewal Opps This Year (Group-By)](#439-won-renewal-opps-this-year)
- [Workflow: 0ChangeQuoteRecordOwner (Write)](#71-0changequoterecordowner)
- [Workflow: AccountAuto-Assign (Write)](#73-accountauto-assign)
- [Workflow: AppointmentAuto-Assign (Write)](#75-appointmentauto-assign)
- [Workflow: BatchCreateEngagements (Write)](#77-batchcreateengagements)
- [Workflow: BatchOpportunityTransfer (Read)](#79-batchopportunitytransfer)
- [Workflow: BatchOpportunityTransfer (Write)](#79-batchopportunitytransfer)
- [Workflow: CaseRecordOwner (Write)](#712-caserecordowner)
- [Workflow: CaseRecordOwnerAssign (Write)](#713-caserecordownerassign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#714-caserecordownerassignmentnotification)
- [Workflow: CloneLicense (Write)](#718-clonelicense)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: ContactAuto-Assign (Write)](#721-contactauto-assign)
- [Workflow: EngagementRecordOwner (Write)](#728-engagementrecordowner)
- [Workflow: EngagementRecordOwnerTeam (Read)](#729-engagementrecordownerteam)
- [Workflow: InvoiceRecordOwner (Write)](#731-invoicerecordowner)
- [Workflow: LeadAssignment (Write)](#732-leadassignment)
- [Workflow: OpportunityRecordOwner (Write)](#739-opportunityrecordowner)
- [Workflow: OpportunityRecordOwnerTeam (Read)](#740-opportunityrecordownerteam)
- [Workflow: OrderRecordOwner (Write)](#742-orderrecordowner)
- [Workflow: PhonecallAuto-Assign (Write)](#743-phonecallauto-assign)
- [Workflow: QuoteRecordOwner (Write)](#746-quoterecordowner)
- [Workflow: QuoteRecordOwnerTeam (Read)](#747-quoterecordownerteam)
- [Workflow: SendQuote (Read)](#749-sendquote)
- [Workflow: TaskAuto-Assign (Write)](#755-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Write)](#756-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#758-wonopportunityemail)
- [Workflow: WorkforceAccountAuto-assign (Write)](#759-workforceaccountauto-assign)
- [Workflow: WorkforceAppointmentAuto-Assign (Write)](#760-workforceappointmentauto-assign)
- [Workflow: WorkforceCaseAuto-assign (Write)](#761-workforcecaseauto-assign)
- [Workflow: WorkforceContactAuto-assign (Write)](#762-workforcecontactauto-assign)
- [Workflow: WorkforceEngagementAuto-assign (Write)](#763-workforceengagementauto-assign)
- [Workflow: WorkforceLeadAuto-Assign (Write)](#764-workforceleadauto-assign)
- [Workflow: WorkforceOpportunityAuto-assign (Write)](#765-workforceopportunityauto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Write)](#766-workforcephone-callauto-assign)
- [Workflow: WorkforceQuoteAuto-assign (Write)](#767-workforcequoteauto-assign)
- [Workflow: iGradAppointmentAuto-Assign (Write)](#768-igradappointmentauto-assign)
- [Workflow: iGradCaseAuto-Assign (Write)](#769-igradcaseauto-assign)
- [Workflow: iGradPhone-callAuto-assign (Write)](#770-igradphone-callauto-assign)
- [JS: azt_caselibrary > onLoad()](#83-azt_caselibrary)
- [JS: azt_engagementlibrary > onLoad()](#85-azt_engagementlibrary)
- [JS: azt_invoicelibrary > onLoad()](#87-azt_invoicelibrary)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)
- [JS: azt_orderlibrary > onLoad()](#812-azt_orderlibrary)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#108-activitycloseforcerecordowner)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Relationship: azt_systemuser_opportunity](#12-relationships)

**<a id="index-azt_renewalnotes"></a>`azt_renewalnotes`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Details](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity-main-active)

**<a id="index-azt_renewalopportunitytotal"></a>`azt_renewalopportunitytotal`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [Formula: azt_renewalopportunitytotal (Target)](#9-formulas-rollups)

**<a id="index-azt_renewalopportunitytotal_base"></a>`azt_renewalopportunitytotal_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_reorderopportunityid"></a>`azt_reorderopportunityid`**

- [Field Definitions](#1-field-definitions)
- [Relationship: azt_opportunity_task](#12-relationships)

**<a id="index-azt_replacementproductid"></a>`azt_replacementproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-azt_requestedfreightamt"></a>`azt_requestedfreightamt`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Freight](#22-igrad-main-active)
- [Form: Opportunity > Products > Freight](#23-opportunity-main-active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#810-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#814-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

**<a id="index-azt_requestedfreightamt_base"></a>`azt_requestedfreightamt_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_resolvedbyid"></a>`azt_resolvedbyid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CaseClose (Read)](#1015-caseclose)
- [Plugin: CaseClose (Write)](#1015-caseclose)

**<a id="index-azt_result"></a>`azt_result`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-azt_saas"></a>`azt_saas`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-azt_saasstatus"></a>`azt_saasstatus`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountTypeSet (Read)](#105-accounttypeset)
- [Plugin: AccountTypeSet (Image)](#105-accounttypeset)

**<a id="index-azt_salesrepid"></a>`azt_salesrepid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#1035-invoicecompcompleted)

**<a id="index-azt_salesstage"></a>`azt_salesstage`**

- [Field Definitions](#1-field-definitions)
- [Workflow: OpportunitySalesProcessAdvanceBPF (Write)](#741-opportunitysalesprocessadvancebpf)

**<a id="index-azt_softwarelicenseid"></a>`azt_softwarelicenseid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: AllocationValidation (Filter)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-azt_softwareproductid"></a>`azt_softwareproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_startdate"></a>`azt_startdate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_stateabbreviation"></a>`azt_stateabbreviation`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountAutoAssign (Filter)](#101-accountautoassign)

**<a id="index-azt_stateprovince"></a>`azt_stateprovince`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_suffix"></a>`azt_suffix`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_suffixhasseparator"></a>`azt_suffixhasseparator`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_suffixseparator"></a>`azt_suffixseparator`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_suffixseparatorisspace"></a>`azt_suffixseparatorisspace`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoNumber (Read)](#1013-autonumber)

**<a id="index-azt_supportexpirationdate"></a>`azt_supportexpirationdate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

**<a id="index-azt_total"></a>`azt_total`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)

**<a id="index-azt_totalamountpaid"></a>`azt_totalamountpaid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-azt_totalfunding"></a>`azt_totalfunding`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingTotalAmt (Write)](#1029-fundingtotalamt)

**<a id="index-azt_totalreimbursement"></a>`azt_totalreimbursement`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)

**<a id="index-azt_trackingnumber"></a>`azt_trackingnumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: ShipmentSetTrackingNumber (Read)](#1079-shipmentsettrackingnumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#1079-shipmentsettrackingnumber)

**<a id="index-azt_trackingnumbers"></a>`azt_trackingnumbers`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ShipmentSetTrackingNumber (Write)](#1079-shipmentsettrackingnumber)

**<a id="index-azt_trainingid"></a>`azt_trainingid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)

**<a id="index-azt_verticalmarket"></a>`azt_verticalmarket`**

- [Field Definitions](#1-field-definitions)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)

**<a id="index-azt_webinarpresentationcompleted"></a>`azt_webinarpresentationcompleted`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_winbackopportunitytotal"></a>`azt_winbackopportunitytotal`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad-main-active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity-main-active)
- [Formula: azt_winbackopportunitytotal (Target)](#9-formulas-rollups)

**<a id="index-azt_winbackopportunitytotal_base"></a>`azt_winbackopportunitytotal_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_year"></a>`azt_year`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingYearSync (Write)](#1030-fundingyearsync)

**<a id="index-baseamount"></a>`baseamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-billto_line1"></a>`billto_line1`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_line2"></a>`billto_line2`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_line3"></a>`billto_line3`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_name"></a>`billto_name`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_postalcode"></a>`billto_postalcode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_stateorprovince"></a>`billto_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-body"></a>`body`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-bpf_duration"></a>`bpf_duration`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)

**<a id="index-bpf_salesorderid"></a>`bpf_salesorderid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Filter)](#1057-orderstagetracking)

**<a id="index-budgetamount"></a>`budgetamount`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-budgetstatus"></a>`budgetstatus`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-businessprocessflowinstanceid"></a>`businessprocessflowinstanceid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)

**<a id="index-businessunitid"></a>`businessunitid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountAutoAssign (Read)](#101-accountautoassign)
- [Plugin: ExpenseRestrictVisibility (Read)](#1027-expenserestrictvisibility)
- [Plugin: GetUserHasRole (Read)](#1032-getuserhasrole)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Plugin: RestrictProductLookups (Read)](#1069-restrictproductlookups)
- [Plugin: RestrictWinOpportunities (Read)](#1070-restrictwinopportunities)
- [Plugin: RestrictWinQuote (Read)](#1071-restrictwinquote)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-cadencewidgetcontrol"></a>`cadencewidgetcontrol`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Up next](#22-igrad-main-active)

**<a id="index-captureproposalfeedback"></a>`captureproposalfeedback`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-category"></a>`category`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Sort)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Sort)](#1075-setprimarycontact)

**<a id="index-city"></a>`city`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-closeprobability"></a>`closeprobability`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [Chart: Sales Pipeline (Group-By)](#421-sales-pipeline)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: OpportunityProbabilityNumber (Write)](#1049-opportunityprobabilitynumber)

**<a id="index-companyname"></a>`companyname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-competitors"></a>`competitors`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: iGrad > Summary > Competitors](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)

**<a id="index-completefinalproposal"></a>`completefinalproposal`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-completeinternalreview"></a>`completeinternalreview`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-conditionbranchstep2_1"></a>`conditionbranchstep2_1`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_dayssincecreated](#9-formulas-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-rollups)

**<a id="index-confirminterest"></a>`confirminterest`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-connectionid"></a>`connectionid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)

**<a id="index-connectionroleid"></a>`connectionroleid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Read)](#1019-contactsetconnectionrole)
- [Plugin: ContactSetConnectionRole (Join)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Join)](#1075-setprimarycontact)

**<a id="index-consideronlygoalownersrecords"></a>`consideronlygoalownersrecords`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-contactid"></a>`contactid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)

**<a id="index-country"></a>`country`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-county"></a>`county`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-createdby"></a>`createdby`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Footer)](#22-igrad-main-active)
- [Form: Opportunity (Footer)](#23-opportunity-main-active)
- [View: My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Quarter (Filter)](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year (Filter)](#324-my-opportunities-created-this-year)
- [View: Opportunities Created This Year](#342-opportunities-created-this-year)
- [View: Opportunities Created This Year (Sort)](#342-opportunities-created-this-year)
- [View: Opportunities Opened This Month](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Month (Sort)](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week](#348-opportunities-opened-this-week)
- [Chart: Opportunities Opened This Quarter By Rep (Measure)](#410-opportunities-opened-this-quarter-by-rep)
- [Chart: Opportunities Opened This Quarter By Rep (Group-By)](#410-opportunities-opened-this-quarter-by-rep)
- [Chart: My Opportunities Created This Quarter (Measure)](#412-my-opportunities-created-this-quarter)
- [Chart: My Opportunities Created This Quarter (Group-By)](#412-my-opportunities-created-this-quarter)
- [Chart: My Opportunities Created This Year By Quarter (Measure)](#415-my-opportunities-created-this-year-by-quarter)
- [Chart: Opportunities Created This Year By Owner (Measure)](#418-opportunities-created-this-year-by-owner)
- [Chart: Opportunities Opened This Month By Rep (Measure)](#422-opportunities-opened-this-month-by-rep)
- [Chart: Opportunities Opened This Month By Rep (Group-By)](#422-opportunities-opened-this-month-by-rep)
- [Chart: Opportunities Opened This Week By Rep (Measure)](#425-opportunities-opened-this-week-by-rep)
- [Chart: Opportunities Opened This Week By Rep (Group-By)](#425-opportunities-opened-this-week-by-rep)
- [Chart: My Opportunities Created This Week (Measure)](#428-my-opportunities-created-this-week)
- [Chart: My Opportunities Created This Week (Group-By)](#428-my-opportunities-created-this-week)
- [Chart: My Open Opportunities Created This Month (Measure)](#430-my-open-opportunities-created-this-month)
- [Chart: My Open Opportunities Created This Month (Group-By)](#430-my-open-opportunities-created-this-month)
- [Workflow: WorkforceOpportunityAuto-assign (Read)](#765-workforceopportunityauto-assign)

**<a id="index-createdon"></a>`createdon`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Footer)](#22-igrad-main-active)
- [Form: Opportunity (Footer)](#23-opportunity-main-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure 30 Day Pipeline (Filter)](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure 30 Day Pipeline (Sort)](#34-executive-sales-measure-30-day-pipeline)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added Last Week (Filter)](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added Last Week (Sort)](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Month (Filter)](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Month (Sort)](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Initial/Add-on Opportunities Added This Week (Filter)](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Initial/Add-on Opportunities Added This Week (Sort)](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities Created This Month](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Month (Filter)](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Week](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Week (Filter)](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Year](#315-my-open-opportunities-created-this-year)
- [View: My Open Opportunities Created This Year (Filter)](#315-my-open-opportunities-created-this-year)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Open Renewal Opportunities as Account Owner (Sort)](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Created This Quarter (Filter)](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year](#324-my-opportunities-created-this-year)
- [View: My Opportunities Created This Year (Filter)](#324-my-opportunities-created-this-year)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Opportunities Won This Year No Renewals (Sort)](#326-my-opportunities-won-this-year-no-renewals)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Created This Year](#342-opportunities-created-this-year)
- [View: Opportunities Created This Year (Filter)](#342-opportunities-created-this-year)
- [View: Opportunities Opened Last Week (Filter)](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Month (Filter)](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Quarter (Filter)](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week (Filter)](#347-opportunities-opened-this-week)
- [View: Opportunities Opened This Week](#348-opportunities-opened-this-week)
- [View: Opportunities Opened This Week (Filter)](#348-opportunities-opened-this-week)
- [View: Self Sourced Pipeline per rep in Last 30 Days (Filter)](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Won Opportunities This Quarter](#359-won-opportunities-this-quarter)
- [Chart: My Opportunities Created This Year By Quarter (Group-By)](#415-my-opportunities-created-this-year-by-quarter)
- [Chart: My Open Opportunities Created This Year By Quarter (Group-By)](#416-my-open-opportunities-created-this-year-by-quarter)
- [Chart: Opportunities Created This Year By Owner (Group-By)](#418-opportunities-created-this-year-by-owner)
- [Formula: azt_dayssincecreated](#9-formulas-rollups)
- [Plugin: AccountLeadGen (Filter)](#102-accountleadgen)
- [Plugin: ChangeLicenseType (Sort)](#1016-changelicensetype)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Sort)](#1035-invoicecompcompleted)
- [Plugin: OpptyToQuoteFieldMappings (Sort)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)
- [Plugin: OrderStageTracking (Sort)](#1057-orderstagetracking)
- [Plugin: ShipmentSetTrackingNumber (Sort)](#1079-shipmentsettrackingnumber)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)

**<a id="index-crm3_expenseamount"></a>`crm3_expenseamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)

**<a id="index-crm3_parentleadid"></a>`crm3_parentleadid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Filter)](#1026-expenselinetotals)

**<a id="index-currentsituation"></a>`currentsituation`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Details](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-customerid"></a>`customerid`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Open Renewal Opps 90 Days Past Due](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days](#337-open-renewal-opps-closing-within-90-days)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Opportunity Lookup View](#351-opportunity-lookup-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)
- [View: Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [Workflow: CasePendingAssignmentNotification (Read)](#711-casependingassignmentnotification)
- [Workflow: CaseRecordOwner (Read)](#712-caserecordowner)
- [Workflow: CaseRecordOwnerAssign (Read)](#713-caserecordownerassign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#714-caserecordownerassignmentnotification)
- [Workflow: CloneAndDeleteQuote (Write)](#716-cloneanddeletequote)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: CloneOrder (Write)](#720-cloneorder)
- [Workflow: CreateSoftwareLicense (Write)](#724-createsoftwarelicense)
- [Workflow: InvoiceRecordOwner (Read)](#731-invoicerecordowner)
- [Workflow: OrderRecordOwner (Read)](#742-orderrecordowner)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Workflow: QuoteRecordOwner (Read)](#746-quoterecordowner)
- [Workflow: TaskCreateReorderLead (Write)](#756-taskcreatereorderlead)
- [JS: azt_createsoftwarelicense > CreateLicense()](#84-azt_createsoftwarelicense)
- [Plugin: AccountLeadGen (Join)](#102-accountleadgen)
- [Plugin: AccountReassignmentShareRecords (Filter)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#1021-createsoftwarelicenses)
- [Plugin: FundingSetAnnualSpend (Filter)](#1028-fundingsetannualspend)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)
- [Relationship: opportunity_customer_accounts](#12-relationships)

**<a id="index-customerneed"></a>`customerneed`**

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity-main-active)
- [Form: Opportunity Quick > Tab > Customer Info](#26-opportunity-quick-quickcreate-active)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-customerpainpoints"></a>`customerpainpoints`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-datefulfilled"></a>`datefulfilled`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

**<a id="index-decisionmaker"></a>`decisionmaker`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-defaultuomid"></a>`defaultuomid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

**<a id="index-description"></a>`description`**

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

**<a id="index-developproposal"></a>`developproposal`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-discountamount"></a>`discountamount`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity-main-active)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)

**<a id="index-discountpercentage"></a>`discountpercentage`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

**<a id="index-discounts"></a>`discounts`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Discretionary Discounts > Section](#22-igrad-main-active)
- [Form: Opportunity > Discretionary Discounts > Section](#23-opportunity-main-active)

**<a id="index-documents"></a>`documents`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Documents > Section](#22-igrad-main-active)
- [Form: Opportunity > Documents > Section](#23-opportunity-main-active)

**<a id="index-documentssubgrid"></a>`documentssubgrid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Files > Documents Section](#22-igrad-main-active)

**<a id="index-dynamicpropertieslist_linkcontrol"></a>`dynamicpropertieslist_linkcontrol`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Dynamic properties](#22-igrad-main-active)

**<a id="index-emailaddress"></a>`emailaddress`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-emailaddress1"></a>`emailaddress1`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadImport (Filter)](#1036-leadimport)

**<a id="index-estimatedclosedate"></a>`estimatedclosedate`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick-quickcreate-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: All Opportunities (Sort)](#31-all-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: GEDSRM Opps (Sort)](#36-gedsrm-opps)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Opportunities (Sort)](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing Next Year (Filter)](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing Next Year (Sort)](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Quarter (Filter)](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Quarter (Sort)](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Fiscal Year (Filter)](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Fiscal Year (Sort)](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Closing This Month (Filter)](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Closing This Month (Sort)](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Closing This Week (Filter)](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year](#324-my-opportunities-created-this-year)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: My Overdue Opportunities (Filter)](#327-my-overdue-opportunities)
- [View: My Overdue Opportunities (Sort)](#327-my-overdue-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Overdue Opps (Filter)](#328-my-overdue-opps)
- [View: My Overdue Opps (Sort)](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: My Stalled Opportunities (Sort)](#329-my-stalled-opportunities)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities by Sales Rep (Filter)](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Open Opportunities (Sort)](#332-open-opportunities)
- [View: Open Renewal Opps 90 Days Past Due](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps 90 Days Past Due (Filter)](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Close Date Last Month (Filter)](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing Next Month (Filter)](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing This Month (Filter)](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days](#337-open-renewal-opps-closing-within-90-days)
- [View: Open Renewal Opps Closing Within 90 Days (Filter)](#337-open-renewal-opps-closing-within-90-days)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Fiscal Year (Filter)](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities Closing Next Month (Filter)](#339-opportunities-closing-next-month)
- [View: Opportunities Closing Next Month (Sort)](#339-opportunities-closing-next-month)
- [View: Opportunities Closing This Month](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Month (Filter)](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Week](#341-opportunities-closing-this-week)
- [View: Opportunities Closing This Week (Filter)](#341-opportunities-closing-this-week)
- [View: Opportunities Created This Year](#342-opportunities-created-this-year)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities in Current Fiscal Year (Filter)](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities in Current Fiscal Year (Sort)](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Month](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunities Opened This Week](#348-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Overdue Opportunities > 45 Days (Filter)](#353-overdue-opportunities-45-days)
- [View: Overdue Opportunities > 45 Days (Sort)](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Recent Opportunities (Sort)](#355-recent-opportunities)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Self Sourced Pipeline per rep in Last 30 Days (Sort)](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Upcoming Internet Renewals (Filter)](#357-upcoming-internet-renewals)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Chart: Open Renewal Opps Close Date Last Month (Measure)](#432-open-renewal-opps-close-date-last-month)
- [Chart: Open Renewal Opps Closing This Month (Measure)](#433-open-renewal-opps-closing-this-month)
- [Chart: Open Renewal Opps Closing Next Month (Measure)](#434-open-renewal-opps-closing-next-month)
- [Chart: Open Renewal Opps Closing Within 90 Days (Measure)](#435-open-renewal-opps-closing-within-90-days)
- [Chart: Open Renewal Opps 90 Days Past Due (Measure)](#436-open-renewal-opps-90-days-past-due)
- [JS: azt_opportunityclone > cloneOpportunity()](#89-azt_opportunityclone)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityClone (Write)](#1044-opportunityclone)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

**<a id="index-estimatedvalue"></a>`estimatedvalue`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad-main-active)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column3](#25-opportunity-quickcreate-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year](#324-my-opportunities-created-this-year)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities Created This Year](#342-opportunities-created-this-year)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened Last Week (Sort)](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Month](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunities Opened This Week (Sort)](#347-opportunities-opened-this-week)
- [View: Opportunities Opened This Week](#348-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [Chart: Closing This Fiscal Year (Measure)](#41-closing-this-fiscal-year)
- [Chart: Closing this Fiscal Quarter (Measure)](#42-closing-this-fiscal-quarter)
- [Chart: Closing This Month (Measure)](#43-closing-this-month)
- [Chart: Initial/Add-on Opened This Month (Measure)](#44-initialadd-on-opened-this-month)
- [Chart: Initial/Add-on Opportunities Added Last Week (Measure)](#45-initialadd-on-opportunities-added-last-week)
- [Chart: Initial/Add-on Added This Week (Measure)](#46-initialadd-on-added-this-week)
- [Chart: Invoiced but Unpaid in Last 90 Days (Measure)](#47-invoiced-but-unpaid-in-last-90-days)
- [Chart: Sales Pipeline (Measure)](#421-sales-pipeline)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

**<a id="index-evaluatefit"></a>`evaluatefit`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-ext_amt"></a>`ext_amt`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)

**<a id="index-extendedamount"></a>`extendedamount`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_addonopportunitytotal](#9-formulas-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-rollups)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-fetchxml"></a>`fetchxml`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-filedebrief"></a>`filedebrief`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-filename"></a>`filename`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-firstname"></a>`firstname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-fiscalperiod"></a>`fiscalperiod`**

- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

**<a id="index-freightamount"></a>`freightamount`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity-main-active)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

**<a id="index-freighttermscode"></a>`freighttermscode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-from"></a>`from`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

**<a id="index-fullname"></a>`fullname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Sort)](#1036-leadimport)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Sort)](#1081-utility)

**<a id="index-goalenddate"></a>`goalenddate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

**<a id="index-goalid"></a>`goalid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

**<a id="index-goalownerid"></a>`goalownerid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

**<a id="index-goalrollupqueryid"></a>`goalrollupqueryid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

**<a id="index-goalstartdate"></a>`goalstartdate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

**<a id="index-identifycompetitors"></a>`identifycompetitors`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-identifycustomercontacts"></a>`identifycustomercontacts`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-identifypursuitteam"></a>`identifypursuitteam`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-incidentid"></a>`incidentid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: CaseClose (Write)](#1015-caseclose)

**<a id="index-initialcommunication"></a>`initialcommunication`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-internalemailaddress"></a>`internalemailaddress`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

**<a id="index-invlineproductid"></a>`invline.productid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)

**<a id="index-invoicedetailid"></a>`invoicedetailid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#1063-quoteorderproductstrackdiscount)

**<a id="index-invoiceid"></a>`invoiceid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Join)](#102-accountleadgen)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateCompGoals (Filter)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Join)](#1022-createusergoals)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#1023-discretionarydiscountsetheader)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-invoicenumber"></a>`invoicenumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CompGoalCreate (Read)](#1018-compgoalcreate)

**<a id="index-isamount"></a>`isamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

**<a id="index-isfiscalperiodgoal"></a>`isfiscalperiodgoal`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-isocurrencycode"></a>`isocurrencycode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: Utility (Filter)](#1081-utility)

**<a id="index-ispriceoverridden"></a>`ispriceoverridden`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-isproductoverridden"></a>`isproductoverridden`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)

**<a id="index-isrevenuesystemcalculated"></a>`isrevenuesystemcalculated`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Opportunity Products](#22-igrad-main-active)
- [Form: Opportunity > Products > Opportunity Products](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Plugin: QuoteSyncTotalToOpportunity (Write)](#1066-quotesynctotaltoopportunity)

**<a id="index-jobtitle"></a>`jobtitle`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-lastname"></a>`lastname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-manualdiscountamount"></a>`manualdiscountamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: ManualDiscountKill (Read)](#1040-manualdiscountkill)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)

**<a id="index-metricid"></a>`metricid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-mimetype"></a>`mimetype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-mobilephone"></a>`mobilephone`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

**<a id="index-modifiedon"></a>`modifiedon`**

- [Field Definitions](#1-field-definitions)
- [View: Recent Opportunities (Sort)](#355-recent-opportunities)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: OpportunityLineSyncToQuote (Sort)](#1046-opportunitylinesynctoquote)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Sort)](#1080-updateoppfromquote)

**<a id="index-msa_partnerid"></a>`msa_partnerid`**

- [Field Definitions](#1-field-definitions)
- [Relationship: msa_partner_opportunity](#12-relationships)

**<a id="index-msa_partneroppid"></a>`msa_partneroppid`**

- [Field Definitions](#1-field-definitions)
- [Relationship: msa_contact_opportunity](#12-relationships)

**<a id="index-msdyn_forecastcategory"></a>`msdyn_forecastcategory`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)

**<a id="index-msdyn_opportunitykpiid"></a>`msdyn_opportunitykpiid`**

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid](#12-relationships)

**<a id="index-msdyn_predictivescoreid"></a>`msdyn_predictivescoreid`**

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_predictivescore_opportunity](#12-relationships)

**<a id="index-msdyn_segmentid"></a>`msdyn_segmentid`**

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_segment_opportunity](#12-relationships)

**<a id="index-name"></a>`name`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick-quickcreate-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: All Opportunities (Sort)](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: GEDSRM Opps (Filter)](#36-gedsrm-opps)
- [View: GEDSRM Opps (Sort)](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities Created This Month](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Month (Sort)](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Week](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Year](#315-my-open-opportunities-created-this-year)
- [View: My Open Opportunities Created This Year (Sort)](#315-my-open-opportunities-created-this-year)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Closing This Week](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Quarter (Sort)](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year](#324-my-opportunities-created-this-year)
- [View: My Opportunities Created This Year (Sort)](#324-my-opportunities-created-this-year)
- [View: My Opportunities Won This Quarter](#325-my-opportunities-won-this-quarter)
- [View: My Opportunities Won This Quarter (Sort)](#325-my-opportunities-won-this-quarter)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Fiscal Year (Sort)](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities Closing This Month](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Week](#341-opportunities-closing-this-week)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Month](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Quarter (Sort)](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Advanced Find View (Sort)](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Opportunity Associated View (Sort)](#350-opportunity-associated-view)
- [View: Opportunity Lookup View](#351-opportunity-lookup-view)
- [View: Opportunity Lookup View (Sort)](#351-opportunity-lookup-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Out of Territory Opportunities - Open (Sort)](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Quick Find Open Opportunities (Filter)](#354-quick-find-open-opportunities)
- [View: Quick Find Open Opportunities (Sort)](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Upcoming Internet Renewals (Sort)](#357-upcoming-internet-renewals)
- [View: Won Opportunities This Month](#358-won-opportunities-this-month)
- [View: Won Opportunities This Week](#360-won-opportunities-this-week)
- [View: Won Opportunities This Year](#361-won-opportunities-this-year)
- [View: Won Opportunities This Year (Sort)](#361-won-opportunities-this-year)
- [View: Won Opportunities](#362-won-opportunities)
- [View: Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [Workflow: 0EngagementNames (Read)](#72-0engagementnames)
- [Workflow: BatchConverttoLead (Read)](#76-batchconverttolead)
- [Workflow: BatchCreateEngagements (Read)](#77-batchcreateengagements)
- [Workflow: BatchLooseOpportunities (Read)](#78-batchlooseopportunities)
- [Workflow: BatchLooseOpportunities (Write)](#78-batchlooseopportunities)
- [Workflow: BatchOpportunityTransfer (Read)](#79-batchopportunitytransfer)
- [Workflow: BatchOpportunityTransfer (Write)](#79-batchopportunitytransfer)
- [Workflow: CloneAndDeleteQuote (Read)](#716-cloneanddeletequote)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: CloneOrder (Read)](#720-cloneorder)
- [Workflow: CreateLeadFromLeadGen (Read)](#722-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#723-createleadfromaccount)
- [Workflow: CustomLeadCreation (Read)](#725-customleadcreation)
- [Workflow: NewFSRLeadNotification (Read)](#737-newfsrleadnotification)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Workflow: RenameEngagements (Read)](#748-renameengagements)
- [Workflow: TaskCreateReorderLead (Read)](#756-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#758-wonopportunityemail)
- [JS: azt_accountlibrary > createLead()](#81-azt_accountlibrary)
- [JS: azt_accountlibrary > createNewLead()](#81-azt_accountlibrary)
- [JS: azt_addresslibrary > addAddress()](#82-azt_addresslibrary)
- [JS: azt_opportunitytrackdiscount > trackDiscount()](#811-azt_opportunitytrackdiscount)
- [JS: azt_sendquote](#815-azt_sendquote)
- [Plugin: AccountAutoAssign (Filter)](#101-accountautoassign)
- [Plugin: AccountAutoAssign (Sort)](#101-accountautoassign)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: ContactSetConnectionRole (Filter)](#1019-contactsetconnectionrole)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: GetAcctTeamOwned (Read)](#1031-getacctteamowned)
- [Plugin: GetAcctTeamOwned (Sort)](#1031-getacctteamowned)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Filter)](#1036-leadimport)
- [Plugin: LeadImport (Sort)](#1036-leadimport)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: QuoteCloneAndDelete (Sort)](#1061-quotecloneanddelete)
- [Plugin: RestrictCreateQuote (Sort)](#1068-restrictcreatequote)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Filter)](#1075-setprimarycontact)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-need"></a>`need`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-new_sharedwith"></a>`new_sharedwith`**

- [Field Definitions](#1-field-definitions)
- [View: Out of Territory Opportunities - Open (Filter)](#352-out-of-territory-opportunities-open)

**<a id="index-notescontrol"></a>`notescontrol`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Notes > Notes pane](#22-igrad-main-active)
- [Form: Opportunity > Notes > Notes pane](#23-opportunity-main-active)

**<a id="index-objectid"></a>`objectid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

**<a id="index-objecttypecode"></a>`objecttypecode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-opportunityaudit"></a>`opportunityaudit`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Audit](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Audit](#23-opportunity-main-active)

**<a id="index-opportunityid"></a>`opportunityid`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Open Opportunities Created This Month](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Week](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Year](#315-my-open-opportunities-created-this-year)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Closing This Week](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year](#324-my-opportunities-created-this-year)
- [View: My Opportunities Won This Quarter](#325-my-opportunities-won-this-quarter)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities](#327-my-overdue-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Open Renewal Opps 90 Days Past Due](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days](#337-open-renewal-opps-closing-within-90-days)
- [View: Opportunities Closing Next Fiscal Year](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month](#339-opportunities-closing-next-month)
- [View: Opportunities Closing This Month](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Week](#341-opportunities-closing-this-week)
- [View: Opportunities Created This Year](#342-opportunities-created-this-year)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Month](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunities Opened This Week](#348-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Opportunity Lookup View](#351-opportunity-lookup-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities This Month](#358-won-opportunities-this-month)
- [View: Won Opportunities This Quarter](#359-won-opportunities-this-quarter)
- [View: Won Opportunities This Week](#360-won-opportunities-this-week)
- [View: Won Opportunities This Year](#361-won-opportunities-this-year)
- [View: Won Opportunities](#362-won-opportunities)
- [View: Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [Workflow: AppointmentAuto-Assign (Read)](#75-appointmentauto-assign)
- [Workflow: BatchConverttoLead (Read)](#76-batchconverttolead)
- [Workflow: BatchOpportunityTransfer (Read)](#79-batchopportunitytransfer)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CustomLeadCreation (Read)](#725-customleadcreation)
- [Workflow: OpportunityAuditRemoval (Read)](#738-opportunityauditremoval)
- [Workflow: OpportunityRecordOwnerTeam (Read)](#740-opportunityrecordownerteam)
- [Workflow: PhonecallAuto-Assign (Read)](#743-phonecallauto-assign)
- [Workflow: TaskAuto-Assign (Read)](#755-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Read)](#756-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#758-wonopportunityemail)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ChangeLicenseType (Filter)](#1016-changelicensetype)
- [Plugin: CreateUserGoals (Join)](#1022-createusergoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#1023-discretionarydiscountsetheader)
- [Plugin: OpportunityAssignFromLead (Write)](#1042-opportunityassignfromlead)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityClone (Write)](#1044-opportunityclone)
- [Plugin: OpportunityClone (Filter)](#1044-opportunityclone)
- [Plugin: OpportunityLastActivityDate (Write)](#1045-opportunitylastactivitydate)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Image)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityPreventCreateQuote (Read)](#1047-opportunitypreventcreatequote)
- [Plugin: OpportunityPreventCreateQuote (Filter)](#1047-opportunitypreventcreatequote)
- [Plugin: OpportunityProbabilityNumber (Write)](#1049-opportunityprobabilitynumber)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuoteLinesSyncToOppty (Write)](#1062-quotelinessynctooppty)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Filter)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)
- [Plugin: QuoteSyncTotalToOpportunity (Write)](#1066-quotesynctotaltoopportunity)
- [Plugin: RestrictCreateQuote (Filter)](#1068-restrictcreatequote)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Filter)](#1080-updateoppfromquote)
- [Relationship: opportunity_quotes](#12-relationships)

**<a id="index-opportunityproductid"></a>`opportunityproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ChangeLicenseType (Read)](#1016-changelicensetype)
- [Plugin: ChangeLicenseType (Write)](#1016-changelicensetype)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityPreventCreateQuote (Read)](#1047-opportunitypreventcreatequote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuoteLinesSyncToOppty (Write)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: SetOppProductDefaults (Read)](#1074-setoppproductdefaults)
- [Plugin: SetOppProductDefaults (Write)](#1074-setoppproductdefaults)

**<a id="index-opportunityproductsgrid"></a>`opportunityproductsgrid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Opportunity Products](#22-igrad-main-active)
- [Form: Opportunity > Products > Opportunity Products](#23-opportunity-main-active)

**<a id="index-opportunityratingcode"></a>`opportunityratingcode`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-originatingleadid"></a>`originatingleadid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: OpportunityAssignFromLead (Read)](#1042-opportunityassignfromlead)
- [Relationship: opportunity_originating_lead](#12-relationships)

**<a id="index-ownerid"></a>`ownerid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad-main-active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column3](#25-opportunity-quickcreate-active)
- [Form: Opportunity Owner Quick View > Opportunity Owner > Opportunity Owner](#28-opportunity-owner-quick-view-quick-active)
- [Form: Order Opportunity Owner Quick View > Tab > section](#29-order-opportunity-owner-quick-view-quick-active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Opportunities Created This Quarter](#323-my-opportunities-created-this-quarter)
- [View: My Opportunities Created This Year](#324-my-opportunities-created-this-year)
- [View: My Overdue Opportunities (Filter)](#327-my-overdue-opportunities)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Opportunities Created This Year](#342-opportunities-created-this-year)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened Last Week](#344-opportunities-opened-last-week)
- [View: Opportunities Opened This Month](#345-opportunities-opened-this-month)
- [View: Opportunities Opened This Quarter](#346-opportunities-opened-this-quarter)
- [View: Opportunities Opened This Week](#347-opportunities-opened-this-week)
- [View: Opportunities Opened This Week](#348-opportunities-opened-this-week)
- [View: Opportunities Opened This Week (Sort)](#348-opportunities-opened-this-week)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Opportunity Associated View](#350-opportunity-associated-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities This Quarter](#359-won-opportunities-this-quarter)
- [View: Won Opportunities This Quarter (Sort)](#359-won-opportunities-this-quarter)
- [View: Won Opportunities](#362-won-opportunities)
- [Chart: Closing This Fiscal Year (Group-By)](#41-closing-this-fiscal-year)
- [Chart: Closing this Fiscal Quarter (Group-By)](#42-closing-this-fiscal-quarter)
- [Chart: Closing This Month (Group-By)](#43-closing-this-month)
- [Chart: Initial/Add-on Opened This Month (Group-By)](#44-initialadd-on-opened-this-month)
- [Chart: Initial/Add-on Opportunities Added Last Week (Group-By)](#45-initialadd-on-opportunities-added-last-week)
- [Chart: Initial/Add-on Added This Week (Group-By)](#46-initialadd-on-added-this-week)
- [Chart: Invoiced but Unpaid in Last 90 Days (Group-By)](#47-invoiced-but-unpaid-in-last-90-days)
- [Chart: Won This Fiscal Year (Group-By)](#48-won-this-fiscal-year)
- [Chart: Won This Year (No Renewals) (Group-By)](#49-won-this-year-no-renewals)
- [Workflow: AllocationsAssigntoTeam (Read)](#74-allocationsassigntoteam)
- [Workflow: AppointmentAuto-Assign (Read)](#75-appointmentauto-assign)
- [Workflow: BatchConverttoLead (Read)](#76-batchconverttolead)
- [Workflow: CasePendingAssignmentNotification (Read)](#711-casependingassignmentnotification)
- [Workflow: CaseRecordOwner (Read)](#712-caserecordowner)
- [Workflow: CloneAndDeleteQuote (Write)](#716-cloneanddeletequote)
- [Workflow: CloneCommissionPayment (Write)](#717-clonecommissionpayment)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: ContactAuto-Assign (Read)](#721-contactauto-assign)
- [Workflow: CreateLeadFromLeadGen (Write)](#722-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#723-createleadfromaccount)
- [Workflow: EngagementRecordOwner (Read)](#728-engagementrecordowner)
- [Workflow: FSRLeadDistibutionNotification (Write)](#730-fsrleaddistibutionnotification)
- [Workflow: InvoiceRecordOwner (Read)](#731-invoicerecordowner)
- [Workflow: LeadAssignment (Read)](#732-leadassignment)
- [Workflow: OpportunityRecordOwner (Read)](#739-opportunityrecordowner)
- [Workflow: OrderRecordOwner (Read)](#742-orderrecordowner)
- [Workflow: PhonecallAuto-Assign (Read)](#743-phonecallauto-assign)
- [Workflow: PrintPurchaseAssigntoTeam (Read)](#744-printpurchaseassigntoteam)
- [Workflow: QuoteRecordOwner (Read)](#746-quoterecordowner)
- [Workflow: SoftwareLicenseAssigntoTeam (Read)](#752-softwarelicenseassigntoteam)
- [Workflow: SoftwareLicenseSetOwner (Read)](#754-softwarelicensesetowner)
- [Workflow: TaskAuto-Assign (Read)](#755-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Write)](#756-taskcreatereorderlead)
- [JS: azt_leadlibrary > onSave()](#88-azt_leadlibrary)
- [JS: azt_productdiscountlibrary](#813-azt_productdiscountlibrary)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: CaseAudit (Read)](#1014-caseaudit)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateCompGoals (Filter)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: EngagementFSRAssignedOn (Read)](#1024-engagementfsrassignedon)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)
- [Plugin: OpportunityAssignFromLead (Write)](#1042-opportunityassignfromlead)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Image)](#1059-phonecallcreatecallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)
- [Plugin: Utility (Write)](#1081-utility)
- [Plugin: Utility (Filter)](#1081-utility)
- [Plugin: Utility (Sort)](#1081-utility)

**<a id="index-owningbusinessunit"></a>`owningbusinessunit`**

- [Field Definitions](#1-field-definitions)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Sort)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities-45-days)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)

**<a id="index-owningteam"></a>`owningteam`**

- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)

**<a id="index-owninguser"></a>`owninguser`**

- [Plugin: GetAcctTeamOwned (Join)](#1031-getacctteamowned)

**<a id="index-parentaccountid"></a>`parentaccountid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad-main-active)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: iGrad > LinkedIn Sales Navigator > LinkedIn Account Profile](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick-quickcreate-active)
- [View: Quick Find Open Opportunities (Filter)](#354-quick-find-open-opportunities)
- [Workflow: AppointmentAuto-Assign (Read)](#75-appointmentauto-assign)
- [Workflow: BatchConverttoLead (Write)](#76-batchconverttolead)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: CreateLeadFromLeadGen (Write)](#722-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#723-createleadfromaccount)
- [Workflow: CustomLeadCreation (Read)](#725-customleadcreation)
- [Workflow: LeadAssignment (Read)](#732-leadassignment)
- [Workflow: OpportunityRecordOwner (Read)](#739-opportunityrecordowner)
- [Workflow: PhonecallAuto-Assign (Read)](#743-phonecallauto-assign)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Workflow: TaskAuto-Assign (Read)](#755-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Read)](#756-taskcreatereorderlead)
- [JS: azt_accountlibrary > parentAccountSpend()](#81-azt_accountlibrary)
- [JS: azt_leadlibrary > getAccountPopulated()](#88-azt_leadlibrary)
- [JS: azt_leadlibrary > qualifyLead()](#88-azt_leadlibrary)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadQualify (Read)](#1038-leadqualify)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Relationship: opportunity_parent_account](#12-relationships)

**<a id="index-parentcontactid"></a>`parentcontactid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad-main-active)
- [Form: iGrad > LinkedIn Sales Navigator > LinkedIn Member Profile](#22-igrad-main-active)
- [Form: iGrad > LinkedIn Sales Navigator > LinkedIn InMail](#22-igrad-main-active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity-main-active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick-quickcreate-active)
- [View: Quick Find Open Opportunities (Filter)](#354-quick-find-open-opportunities)
- [Workflow: BatchConverttoLead (Read)](#76-batchconverttolead)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: CreateLeadFromLeadGen (Write)](#722-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#723-createleadfromaccount)
- [Workflow: CustomLeadCreation (Read)](#725-customleadcreation)
- [Workflow: LeadPopulateFirstNamefromContact (Read)](#733-leadpopulatefirstnamefromcontact)
- [Workflow: LeadTempPopulatefirstlastnamefromcontact (Read)](#736-leadtemppopulatefirstlastnamefromcontact)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Workflow: TaskCreateReorderLead (Read)](#756-taskcreatereorderlead)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-parentcustomerid"></a>`parentcustomerid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

**<a id="index-parentgoalid"></a>`parentgoalid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-parentsystemuserid"></a>`parentsystemuserid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-partyid"></a>`partyid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

**<a id="index-phonenumber"></a>`phonenumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-presentfinalproposal"></a>`presentfinalproposal`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-presentproposal"></a>`presentproposal`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-pricelevelid"></a>`pricelevelid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Opportunity Products](#22-igrad-main-active)
- [Form: Opportunity > Products > Opportunity Products](#23-opportunity-main-active)
- [Workflow: CloneAndDeleteQuote (Write)](#716-cloneanddeletequote)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: CloneOrder (Write)](#720-cloneorder)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Workflow: SetDefaultPriceListonOpportunities (Write)](#750-setdefaultpricelistonopportunities)
- [Workflow: TempSetDefaultPricelist (Write)](#757-tempsetdefaultpricelist)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)
- [JS: azt_opportunitylibrary > success()](#810-azt_opportunitylibrary)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-priceperunit"></a>`priceperunit`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-primarycontactid"></a>`primarycontactid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

**<a id="index-prioritycode"></a>`prioritycode`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-prodproductid"></a>`prod.productid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)

**<a id="index-productdescription"></a>`productdescription`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)

**<a id="index-productid"></a>`productid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Write)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Filter)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Join)](#102-accountleadgen)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Sort)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)
- [Plugin: DiscretionaryDiscountSetHeader (Sort)](#1023-discretionarydiscountsetheader)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityClone (Sort)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderClone (Sort)](#1051-orderclone)
- [Plugin: OrderLinePopulateTemplateFields (Sort)](#1054-orderlinepopulatetemplatefields)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Sort)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteCloneAndDelete (Sort)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#1062-quotelinessynctooppty)
- [Plugin: QuoteLinesSyncToOppty (Sort)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: ReviseQuoteDiscountMove (Sort)](#1072-revisequotediscountmove)
- [Plugin: SetOppProductDefaults (Read)](#1074-setoppproductdefaults)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-productname"></a>`productname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)

**<a id="index-productnumber"></a>`productnumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: RestrictProductLookups (Filter)](#1069-restrictproductlookups)
- [Plugin: Utility (Filter)](#1081-utility)

**<a id="index-productsuggestions_linkcontrol"></a>`productsuggestions_linkcontrol`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Suggestions](#22-igrad-main-active)

**<a id="index-producttypecode"></a>`producttypecode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)

**<a id="index-proposedsolution"></a>`proposedsolution`**

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-purchaseprocess"></a>`purchaseprocess`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-purchasetimeframe"></a>`purchasetimeframe`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad-main-active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-pursuit_team"></a>`pursuit_team`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Sales Team](#22-igrad-main-active)
- [Form: Opportunity > Summary > Sales Team](#23-opportunity-main-active)

**<a id="index-pursuitdecision"></a>`pursuitdecision`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-qualificationcomments"></a>`qualificationcomments`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-quantity"></a>`quantity`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderLinePopulateTemplateFields (Read)](#1054-orderlinepopulatetemplatefields)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteCloneAndDelete (Write)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuoteLinesSyncToOppty (Write)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-queryentitytype"></a>`queryentitytype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-queueid"></a>`queueid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

**<a id="index-queueitemid"></a>`queueitemid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-quote"></a>`quote`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Quotes > Quotes](#22-igrad-main-active)

**<a id="index-quotecomments"></a>`quotecomments`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

**<a id="index-quotedetailid"></a>`quotedetailid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ActivateOrReviseQuote (Read)](#106-activateorrevisequote)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Write)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderLinePopulateLicType (Read)](#1053-orderlinepopulatelictype)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Write)](#1062-quotelinessynctooppty)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#1063-quoteorderproductstrackdiscount)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)

**<a id="index-quoteid"></a>`quoteid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ActivateOrReviseQuote (Filter)](#106-activateorrevisequote)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#1023-discretionarydiscountsetheader)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: ProductDiscountPreventOnActiveQuote (Read)](#1060-productdiscountpreventonactivequote)
- [Plugin: QuoteCloneAndDelete (Write)](#1061-quotecloneanddelete)
- [Plugin: QuoteCloneAndDelete (Filter)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Filter)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)
- [Plugin: RestrictCreateQuote (Read)](#1068-restrictcreatequote)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)
- [Plugin: ReviseQuoteDiscountMove (Filter)](#1072-revisequotediscountmove)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)

**<a id="index-record1id"></a>`record1id`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: LeadQualifyParentStakeholderContacts (Filter)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Filter)](#1075-setprimarycontact)

**<a id="index-record1roleid"></a>`record1roleid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

**<a id="index-record2id"></a>`record2id`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: LeadQualifyParentStakeholderContacts (Sort)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Filter)](#1075-setprimarycontact)

**<a id="index-record2roleid"></a>`record2roleid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Join)](#1075-setprimarycontact)

**<a id="index-regardingobjectid"></a>`regardingobjectid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Filter)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#1076-sharebasedonaccessteam)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)
- [Relationship: Opportunity_Phonecalls](#12-relationships)

**<a id="index-requestdeliveryby"></a>`requestdeliveryby`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-resolvefeedback"></a>`resolvefeedback`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-ricontainer_charts"></a>`ricontainer_charts`**

- [Field Definitions](#1-field-definitions)
- [Form: AI for Sales > RAV2 > RAV2_section_1](#21-ai-for-sales-main-active)

**<a id="index-roleid"></a>`roleid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: GetUserHasRoleToAction (Read)](#1033-getuserhasroletoaction)
- [Plugin: GetUserHasRoleToAction (Filter)](#1033-getuserhasroletoaction)
- [Plugin: GetUserHasRoleToAction (Join)](#1033-getuserhasroletoaction)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Filter)](#1081-utility)
- [Plugin: Utility (Join)](#1081-utility)

**<a id="index-rolluponlyfromchildgoals"></a>`rolluponlyfromchildgoals`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-rollupqueryactualmoneyid"></a>`rollupqueryactualmoneyid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

**<a id="index-rolluprulestep1_1"></a>`rolluprulestep1_1`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_addonopportunitytotal](#9-formulas-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-rollups)

**<a id="index-rolluprulestep1_2"></a>`rolluprulestep1_2`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_addonopportunitytotal](#9-formulas-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-rollups)

**<a id="index-rolluprulestep1_3"></a>`rolluprulestep1_3`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_addonopportunitytotal](#9-formulas-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-rollups)

**<a id="index-rolluprulestep1_4"></a>`rolluprulestep1_4`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_addonopportunitytotal](#9-formulas-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-rollups)

**<a id="index-rolluprulestep1_5"></a>`rolluprulestep1_5`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_addonopportunitytotal](#9-formulas-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-rollups)

**<a id="index-salesorderdetailid"></a>`salesorderdetailid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderLinePopulateLicType (Write)](#1053-orderlinepopulatelictype)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#1063-quoteorderproductstrackdiscount)

**<a id="index-salesorderdetailname"></a>`salesorderdetailname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderLinePopulateTemplateFields (Read)](#1054-orderlinepopulatetemplatefields)

**<a id="index-salesorderid"></a>`salesorderid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CompGoalCreate (Read)](#1018-compgoalcreate)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Filter)](#1021-createsoftwarelicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#1023-discretionarydiscountsetheader)
- [Plugin: OrderClone (Filter)](#1051-orderclone)
- [Plugin: OrderLinePopulateTemplateFields (Write)](#1054-orderlinepopulatetemplatefields)
- [Plugin: OrderLinePopulateTemplateFields (Filter)](#1054-orderlinepopulatetemplatefields)
- [Plugin: OrderSplit (Filter)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteCloneAndDelete (Filter)](#1061-quotecloneanddelete)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareWithAccountOwner (Filter)](#1078-sharewithaccountowner)
- [Plugin: ShipmentSetTrackingNumber (Write)](#1079-shipmentsettrackingnumber)

**<a id="index-salesrepid"></a>`salesrepid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)

**<a id="index-salesstage"></a>`salesstage`**

- [Field Definitions](#1-field-definitions)

**<a id="index-salesstagecode"></a>`salesstagecode`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-scheduledend"></a>`scheduledend`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#107-activitiescreatedduedatesinpast)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-sendthankyounote"></a>`sendthankyounote`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

**<a id="index-setattributevaluestep4_1"></a>`setattributevaluestep4_1`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_dayssincecreated](#9-formulas-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-rollups)

**<a id="index-setattributevaluestep4_2"></a>`setattributevaluestep4_2`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_dayssincecreated](#9-formulas-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-rollups)

**<a id="index-setattributevaluestep4_3"></a>`setattributevaluestep4_3`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_dayssincecreated](#9-formulas-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-rollups)

**<a id="index-setattributevaluestep4_4"></a>`setattributevaluestep4_4`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_dayssincecreated](#9-formulas-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-rollups)

**<a id="index-setattributevaluestep4_5"></a>`setattributevaluestep4_5`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_dayssincecreated](#9-formulas-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-rollups)

**<a id="index-shippingmethodcode"></a>`shippingmethodcode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_line1"></a>`shipto_line1`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_line2"></a>`shipto_line2`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_line3"></a>`shipto_line3`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_name"></a>`shipto_name`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_postalcode"></a>`shipto_postalcode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_stateorprovince"></a>`shipto_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-stakeholders"></a>`stakeholders`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Sales Team](#22-igrad-main-active)

**<a id="index-state"></a>`state`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-statecode"></a>`statecode`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year (Filter)](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities in Current Fiscal Year (Filter)](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities (Filter)](#33-closed-opportunities)
- [View: Closed Opportunities (Filter)](#33-closed-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)
- [View: Lost Opportunities (Filter)](#37-lost-opportunities)
- [View: My Aged or Stuck Opportunities (Filter)](#38-my-aged-or-stuck-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year (Filter)](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Closed Opportunities in Current Fiscal Year (Filter)](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Open Opportunities Created This Month (Filter)](#313-my-open-opportunities-created-this-month)
- [View: My Open Opportunities Created This Week (Filter)](#314-my-open-opportunities-created-this-week)
- [View: My Open Opportunities Created This Year (Filter)](#315-my-open-opportunities-created-this-year)
- [View: My Open Opportunities (Filter)](#316-my-open-opportunities)
- [View: My Open Renewal Opportunities as Account Owner (Filter)](#317-my-open-renewal-opportunities-as-account-owner)
- [View: My Opportunities Closing Next Year (Filter)](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter (Filter)](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year (Filter)](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month (Filter)](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Closing This Week (Filter)](#322-my-opportunities-closing-this-week)
- [View: My Opportunities Won This Quarter (Filter)](#325-my-opportunities-won-this-quarter)
- [View: My Opportunities Won This Year No Renewals (Filter)](#326-my-opportunities-won-this-year-no-renewals)
- [View: My Overdue Opportunities (Filter)](#327-my-overdue-opportunities)
- [View: My Overdue Opps (Filter)](#328-my-overdue-opps)
- [View: My Stalled Opportunities (Filter)](#329-my-stalled-opportunities)
- [View: My Won Opps this Year (Filter)](#330-my-won-opps-this-year)
- [View: Open Opportunities by Sales Rep (Filter)](#331-open-opportunities-by-sales-rep)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Open Opportunities (Filter)](#332-open-opportunities)
- [View: Open Renewal Opps 90 Days Past Due (Filter)](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month (Filter)](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month (Filter)](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month (Filter)](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days (Filter)](#337-open-renewal-opps-closing-within-90-days)
- [View: Opportunities Closing Next Fiscal Year (Filter)](#338-opportunities-closing-next-fiscal-year)
- [View: Opportunities Closing Next Month (Filter)](#339-opportunities-closing-next-month)
- [View: Opportunities Closing This Month (Filter)](#340-opportunities-closing-this-month)
- [View: Opportunities Closing This Week (Filter)](#341-opportunities-closing-this-week)
- [View: Opportunities in Current Fiscal Year](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities in Current Fiscal Year (Filter)](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities in Current Fiscal Year (Filter)](#343-opportunities-in-current-fiscal-year)
- [View: Opportunities Opened This Week (Filter)](#348-opportunities-opened-this-week)
- [View: Opportunity Lookup View (Filter)](#351-opportunity-lookup-view)
- [View: Out of Territory Opportunities - Open (Filter)](#352-out-of-territory-opportunities-open)
- [View: Overdue Opportunities > 45 Days (Filter)](#353-overdue-opportunities-45-days)
- [View: Quick Find Open Opportunities (Filter)](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [View: Recent Opportunities (Filter)](#355-recent-opportunities)
- [View: Recent Opportunities (Filter)](#355-recent-opportunities)
- [View: Recent Opportunities (Sort)](#355-recent-opportunities)
- [View: Won Opportunities This Month (Filter)](#358-won-opportunities-this-month)
- [View: Won Opportunities This Quarter (Filter)](#359-won-opportunities-this-quarter)
- [View: Won Opportunities This Week (Filter)](#360-won-opportunities-this-week)
- [View: Won Opportunities This Year (Filter)](#361-won-opportunities-this-year)
- [View: Won Opportunities (Filter)](#362-won-opportunities)
- [View: Won Renewal Opps This Month (Filter)](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter (Filter)](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year (Filter)](#365-won-renewal-opps-this-year)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Workflow: BatchConverttoLead (Write)](#76-batchconverttolead)
- [Workflow: CaseResolutionNotificationEmail (Read)](#715-caseresolutionnotificationemail)
- [Workflow: CloneOrder (Write)](#720-cloneorder)
- [Workflow: CreateLeadFromLeadGen (Write)](#722-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#723-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#725-customleadcreation)
- [Workflow: LeadQualifyDisqualifyDate (Read)](#734-leadqualifydisqualifydate)
- [Workflow: OpportunityAuditRemoval (Read)](#738-opportunityauditremoval)
- [Workflow: TaskCreateReorderLead (Write)](#756-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#758-wonopportunityemail)
- [Plugin: AccountLeadGen (Filter)](#102-accountleadgen)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#108-activitycloseforcerecordowner)
- [Plugin: AllocationValidation (Filter)](#1011-allocationvalidation)
- [Plugin: ContactSetConnectionRole (Read)](#1019-contactsetconnectionrole)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
- [Plugin: ExpenseRestrictVisibility (Filter)](#1027-expenserestrictvisibility)
- [Plugin: FundingSetAnnualSpend (Filter)](#1028-fundingsetannualspend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: LeadImport (Filter)](#1036-leadimport)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: ProductDiscountPreventOnActiveQuote (Read)](#1060-productdiscountpreventonactivequote)
- [Plugin: RestrictCreateQuote (Filter)](#1068-restrictcreatequote)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-stateorprovince"></a>`stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoAssignStateAbb (Read)](#1012-autoassignstateabb)
- [Plugin: AutoAssignStateAbb (Write)](#1012-autoassignstateabb)

**<a id="index-statuscode"></a>`statuscode`**

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities-open)
- [View: Upcoming Internet Renewals](#357-upcoming-internet-renewals)
- [View: Won Opportunities](#362-won-opportunities)
- [Workflow: BatchCreateEngagements (Write)](#77-batchcreateengagements)
- [Workflow: CloneOrder (Write)](#720-cloneorder)
- [Workflow: EmailDeleteSendQuoteDrafts (Read)](#726-emaildeletesendquotedrafts)
- [Workflow: EmailRemoveUnsentEmails (Read)](#727-emailremoveunsentemails)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#753-softwarelicensecreateengagement)
- [JS: azt_expensereportlibrary > corporateApprove()](#86-azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > getCanApprove()](#86-azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > onLoad()](#86-azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > reject()](#86-azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setManagerApproval()](#86-azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setPaid()](#86-azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > submit()](#86-azt_expensereportlibrary)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Filter)](#1081-utility)

**<a id="index-street"></a>`street`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-subject"></a>`subject`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-systemuserid"></a>`systemuserid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: GetAcctTeamOwned (Join)](#1031-getacctteamowned)
- [Plugin: GetUserHasRoleToAction (Filter)](#1033-getuserhasroletoaction)
- [Plugin: GetUserHasRoleToAction (Join)](#1033-getuserhasroletoaction)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)
- [Plugin: Utility (Filter)](#1081-utility)
- [Plugin: Utility (Join)](#1081-utility)

**<a id="index-tax"></a>`tax`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)

**<a id="index-teamid"></a>`teamid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountAutoAssign (Read)](#101-accountautoassign)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)

**<a id="index-teamtype"></a>`teamtype`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountAutoAssign (Filter)](#101-accountautoassign)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#1076-sharebasedonaccessteam)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)

**<a id="index-telephone1"></a>`telephone1`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-title"></a>`title`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

**<a id="index-tmsystemuserid"></a>`tm.systemuserid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)

**<a id="index-to"></a>`to`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

**<a id="index-totalamount"></a>`totalamount`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

**<a id="index-totalamountlessfreight"></a>`totalamountlessfreight`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)

**<a id="index-totallineitemamount"></a>`totallineitemamount`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)

**<a id="index-totaltax"></a>`totaltax`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)

**<a id="index-transactioncurrencyid"></a>`transactioncurrencyid`**

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad-main-active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity-main-active)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-uomid"></a>`uomid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)

**<a id="index-value"></a>`value`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-webresource_recordwall"></a>`webresource_recordwall`**

- [Field Definitions](#1-field-definitions)
- [Form: Information > What's New > Section](#24-information-main-inactive)

**<a id="index-zipcode"></a>`zipcode`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-0"></a>`{0}`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
