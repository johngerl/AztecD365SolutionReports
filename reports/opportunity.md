# Opportunity Field Usage Analysis
> Date: 2026-03-21

| Property | Value |
|---|---|
| **Entity Name** | opportunity |
| **Display Name** | Opportunity |
| **Description** | Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion. |
| **Object Type** | Standard |
| **Ownership Type** | UserOwned |
| **Audit Enabled** | True |
| **Total Rows** | 53257 |
| **Last Update** | 2026-03-21 01:27:04 |
| **Primary ID Field** | opportunityid |
| **Primary Name Field** | name |

## Table of Contents

- [1. Field Definitions](#1-field-definitions)
- [2. Forms](#2-forms)
  - [2.1. AI for Sales - main - Active](#21-ai-for-sales---main---active)
  - [2.2. iGrad - main - Active](#22-igrad---main---active)
  - [2.3. Opportunity - main - Active](#23-opportunity---main---active)
  - [2.4. Information - main - Inactive](#24-information---main---inactive)
  - [2.5. Opportunity - quickCreate - Active](#25-opportunity---quickcreate---active)
  - [2.6. Opportunity Quick - quickCreate - Active](#26-opportunity-quick---quickcreate---active)
  - [2.7. Opportunity Record Owner - quick - Active](#27-opportunity-record-owner---quick---active)
  - [2.8. Opportunity Owner Quick View - quick - Active](#28-opportunity-owner-quick-view---quick---active)
  - [2.9. Order Opportunity Owner Quick View - quick - Active](#29-order-opportunity-owner-quick-view---quick---active)
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
  - [3.52. Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
  - [3.53. Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
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
- [9. Formulas and Rollups](#9-formulas-and-rollups)
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
- [14. Conflicts and Observations](#14-conflicts-and-observations)
- [Index](#index)

---

## 1. Field Definitions

Total fields: **126**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Last Update | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [accountid](#accountid) | Account | lookup |  | No | none | 2026-03-21 01:27:04 | true |  |  |  | Opportunity | AccountId | AccountId |  |  |  |  |  |  |  | [12](#10-plugin-source-code-analysis) |  |  |  |  |
| 2 | [actualclosedate](#actualclosedate) | Actual Close Date | datetime |  | No | none | 2026-03-20 20:16:40 | true |  |  |  | Opportunity | CloseDate | CloseDate | [2](#2-forms) | [27](#3-views) | [5](#4-chart-visualizations) |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 3 | [actualvalue](#actualvalue) | Actual Revenue | money |  | No | none | 2026-03-20 20:16:40 | true |  |  |  |  |  |  |  | [15](#3-views) | [2](#4-chart-visualizations) |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 4 | [actualvalue_base](#actualvalue_base) | Actual Revenue (Base) | money |  | No | none | 2026-03-20 20:16:40 | true |  |  |  |  |  |  |  | [2](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 5 | [azt_accountclassification](#azt_accountclassification) | Account Classification | picklist | 276530000: A, 276530001: B, 276530002: C, 100000001: D, 100000000: E, 276530003: S, 276530004: N/A | Yes | none | 2026-03-20 21:44:40 | true | Opportunity | CRM Account Classification | CRM_Account_Classification__c |  |  |  | [2](#2-forms) | [9](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 6 | [azt_addonopportunitytotal](#azt_addonopportunitytotal) | Add-On Opportunity Total | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Add On Opportunity Total | CRM_Add_On_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 7 | [azt_addonopportunitytotal_base](#azt_addonopportunitytotal_base) | Add-On Opportunity Total (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 8 | [azt_assignedamid](#azt_assignedamid) | Assigned AM | lookup |  | Yes | none | 2026-03-21 00:56:55 | true | Opportunity | CRM Assigned AM | CRM_Assigned_AM__c |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 9 | [azt_committoestimatedclose](#azt_committoestimatedclose) | Commit to Pipeline? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 10 | [azt_dayssincecreated](#azt_dayssincecreated) | Days Since Created | int |  | Yes | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [2](#2-forms) | [3](#3-views) |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 11 | [azt_dayssinceprobabilitychanged](#azt_dayssinceprobabilitychanged) | Days Since Probability Changed | int |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Days Since Probability Changed | CRM_Days_Since_Probability_Changed__c |  |  |  | [2](#2-forms) | [4](#3-views) |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 12 | [azt_defaultfreightamount](#azt_defaultfreightamount) | Default Freight Amount | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Default Freight Amount | CRM_Default_Freight_Amount__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 13 | [azt_defaultfreightamount_base](#azt_defaultfreightamount_base) | Default Freight Amount (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 14 | [azt_deliverytype](#azt_deliverytype) | Delivery Type | picklist | 276530000: Internet, 276530001: LAN, 276530002: Print, 276530003: LAN & Print, 276530004: Internet & Print, 276530005: Internet Year 2, 276530006: Internet Year 3+, 276530007: SA, 276530008: WAN | Yes | none | 2026-03-21 00:56:55 | true | Opportunity | CRM Delivery Type | CRM_Delivery_Type__c |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 15 | [azt_discretionarydiscount](#azt_discretionarydiscount) | Discretionary Discount | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Discretionary Discount | CRM_Discretionary_Discount__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 16 | [azt_discretionarydiscount_base](#azt_discretionarydiscount_base) | Discretionary Discount (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 17 | [azt_discretionarydiscountamt](#azt_discretionarydiscountamt) | Discretionary Discount Amt | money |  | Yes | none | 2026-02-27 20:44:28 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 18 | [azt_discretionarydiscountamt_base](#azt_discretionarydiscountamt_base) | Discretionary Discount Amt (Base) | money |  | Yes | none | 2026-02-27 20:44:28 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 19 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | Expected Renewal Value | money |  | Yes | none | 2026-03-20 21:44:40 | true |  |  |  |  |  |  | [2](#2-forms) | [8](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 20 | [azt_expectedrenewalvalue_base](#azt_expectedrenewalvalue_base) | Expected Renewal Value (Base) | money |  | Yes | none | 2026-03-20 21:44:40 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 21 | [azt_freightamtapproved](#azt_freightamtapproved) | Freight Amt Approved? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 22 | [azt_fundingsource](#azt_fundingsource) | Funding Source | picklist | 276530000: Annual Budget, 276530001: Discretionary Budget, 276530002: Grant - Federal, 276530003: Grant - Private, 276530004: Grant - State, 276530005: Grant - Perkins, 276530006: Title 1 Funds, 276530007: Other, 276530008: Use or Lose Funds | Yes | none | 2026-03-20 21:44:40 | true | Opportunity | Funding Source | Funding_Source__c |  |  |  | [4](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 23 | [azt_historicalowner](#azt_historicalowner) | Historical Owner | nvarchar |  | Yes | none | 2026-03-20 15:49:24 | true | Opportunity | CRM Historical Owner | CRM_Historical_Owner__c |  |  |  |  |  |  |  |  | [3](#7-workflows) |  |  |  |  |  |  |
| 24 | [azt_initialopportunitytotal](#azt_initialopportunitytotal) | Initial Opportunity Total | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Initial Opportunity Total | CRM_Initial_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 25 | [azt_initialopportunitytotal_base](#azt_initialopportunitytotal_base) | Initial Opportunity Total (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 26 | [azt_internalaztecnotes](#azt_internalaztecnotes) | Internal Aztec Notes | ntext |  | Yes | none | 2026-03-20 21:16:46 | true | Opportunity | CRM Internal Aztec Notes | CRM_Internal_Aztec_Notes__c |  |  |  | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 27 | [azt_invoicenumber](#azt_invoicenumber) | Invoice Number | nvarchar |  | Yes | none | Never | false | Opportunity | CRM Invoice Number | CRM_Invoice_Number__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 28 | [azt_iscrossselloppty](#azt_iscrossselloppty) | Is Cross-sell Oppty? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | Cross-Sell | Cross_Sell__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 29 | [azt_lastactivitydate](#azt_lastactivitydate) | Last Activity Date | datetime |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | Legacy Last Activity Date | Legacy_Last_Activity_Date__c |  |  |  | [2](#2-forms) | [1](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 30 | [azt_lastmodifiedbyid](#azt_lastmodifiedbyid) | Last Modified By | lookup |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | Legacy Modified By | Legacy_Modified_By__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 31 | [azt_leadsource](#azt_leadsource) | Lead Source (Old) | picklist |  | Yes | none | 2026-03-20 16:52:47 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 32 | [azt_leadsourceid](#azt_leadsourceid) | Lead Source | lookup |  | Yes | none | 2026-03-21 00:56:55 | true | Opportunity | CRM Lead Source | CRM_Lead_Source__c |  |  |  | [1](#2-forms) | [1](#3-views) |  |  |  | [8](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 33 | [azt_opportunitynumber](#azt_opportunitynumber) | Opp# | nvarchar |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Opportunity Number | CRM_Opportunity_Number__c |  |  |  | [2](#2-forms) | [7](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 34 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | Opportunity Product Category | picklist | 276530000: P12 & Legacy, 276530001: Kaplan Book, 276530002: GED Flash, 276530003: P12 Prep, 276530004: Legacy, 276530005: APT - Free, 276530006: APT - Paid, 276530007: OPT - Free, 276530008: OPT - Paid, 276530009: Workbooks, 276530010: LSE Booklets | Yes | none | 2026-03-20 17:38:23 | true | Opportunity | CRM Opportunity Product Category | CRM_Opportunity_Product_Category__c |  |  |  | [2](#2-forms) | [25](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 35 | [azt_opportunitytype](#azt_opportunitytype) | Opportunity Type | picklist | 276530005: Renewal, 276530004: Initial, 276530002: Print, 276530003: Add-On, 276530001: Vouchers, 276530000: Pilot, 276530008: Professional Development, 276530006: Monthly, 100000000: Win Back, 327630000: Sample, 100000001: PA, 276530007: Other, 327630001: Add On - Reseller | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | Type | Type |  |  |  | [4](#2-forms) | [57](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 36 | [azt_otheropportunitytotal](#azt_otheropportunitytotal) | Other Opportunity Total | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Other Opportunity Total | CRM_Other_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 37 | [azt_otheropportunitytotal_base](#azt_otheropportunitytotal_base) | Other Opportunity Total (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 38 | [azt_parentopportunityid](#azt_parentopportunityid) | Parent Opportunity | lookup |  | Yes | none | 2026-03-20 21:44:40 | true | Opportunity | CRM Parent Opportunity Name | CRM_Parent_Opportunity_Name__c |  |  |  |  |  |  |  |  | [1](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 39 | [azt_pilotopportunitytotal](#azt_pilotopportunitytotal) | Pilot Opportunity Total | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Pilot Opportunity Total | CRM_Pilot_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 40 | [azt_pilotopportunitytotal_base](#azt_pilotopportunitytotal_base) | Pilot Opportunity Total (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 41 | [azt_pipelinestage](#azt_pipelinestage) | Pipeline Stage | picklist | 276530000: Identify, 276530001: Qualified, 276530002: Prospecting, 276530003: Cultivating, 276530004: Proposing, 276530005: Closing, 276530006: Delivering, 276530007: Awaiting Payment, 276530008: Won | Yes | none | 2026-03-21 00:56:55 | true | Opportunity | Stage | StageName |  |  |  | [4](#2-forms) | [23](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 42 | [azt_previewcompleted](#azt_previewcompleted) | Preview Completed | picklist | 276530000: Yes, 276530001: No | Yes | none | 2025-11-21 19:17:05 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 43 | [azt_previousprobability](#azt_previousprobability) | Previous Probability | nvarchar |  | Yes | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 44 | [azt_printopportunitytotal](#azt_printopportunitytotal) | Print Opportunity Total | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Print Opportunity Total | CRM_Print_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 45 | [azt_printopportunitytotal_base](#azt_printopportunitytotal_base) | Print Opportunity Total (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 46 | [azt_probability](#azt_probability) | Probability | picklist | 276530010: 1%, 276530000: 10%, 276530001: 20%, 276530002: 30%, 100000001: 35%, 276530003: 40%, 276530004: 50%, 100000000: 55%, 276530005: 60%, 276530006: 70%, 100530010: 75%, 276530007: 80%, 276530008: 90%, 327630000: 95%, 276530009: 99% | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Probability | CRM_Probability__c |  |  |  | [4](#2-forms) | [32](#3-views) |  |  |  | [2](#7-workflows) |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 47 | [azt_probabilitychangedon](#azt_probabilitychangedon) | Probability Changed On | datetime |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | Probability Last Changed | Probability_Last_Changed__c |  |  |  |  | [7](#3-views) |  |  |  |  | [1](#9-formulas-and-rollups) | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 48 | [azt_probabilityincreased](#azt_probabilityincreased) | Probability Increased? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 49 | [azt_quotesent](#azt_quotesent) | Quote Sent | picklist | 276530000: Yes, 276530001: No | Yes | none | 2025-11-21 19:16:23 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 50 | [azt_recordownerid](#azt_recordownerid) | Record Owner | lookup |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | Record Owner | OwnerId |  |  |  | [6](#2-forms) | [66](#3-views) | [32](#4-chart-visualizations) |  |  | [39](#7-workflows) |  | [9](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 51 | [azt_renewalnotes](#azt_renewalnotes) | Renewal Notes | nvarchar |  | Yes | none | 2026-03-20 20:21:37 | true | Opportunity | Renewal Notes | Renewal_Notes__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 52 | [azt_renewalopportunitytotal](#azt_renewalopportunitytotal) | Renewal Opportunity Total | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Renewal Opportunity Total | CRM_Renewal_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 53 | [azt_renewalopportunitytotal_base](#azt_renewalopportunitytotal_base) | Renewal Opportunity Total (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 54 | [azt_requestedfreightamt](#azt_requestedfreightamt) | Requested Freight Amt | money |  | Yes | none | 2025-04-02 16:39:05 | true | Opportunity | CRM Requested Freight Amount | CRM_Requested_Freight_Amount__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 55 | [azt_requestedfreightamt_base](#azt_requestedfreightamt_base) | Requested Freight Amt (Base) | money |  | Yes | none | 2025-04-02 16:39:05 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 56 | [azt_salesstage](#azt_salesstage) | Sales Stage | picklist |  | Yes | none | 2026-03-02 14:12:04 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 57 | [azt_webinarpresentationcompleted](#azt_webinarpresentationcompleted) | Webinar/Presentation Completed | picklist | 276530000: Yes, 276530001: No | Yes | none | 2025-11-21 19:17:05 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 58 | [azt_winbackopportunitytotal](#azt_winbackopportunitytotal) | Win-Back Opportunity Total | money |  | Yes | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Win Back Opportunity Total | CRM_Win_Back_Opportunity_Total__c |  |  |  | [2](#2-forms) |  |  |  |  |  | [1](#9-formulas-and-rollups) |  |  |  |  |  |
| 59 | [azt_winbackopportunitytotal_base](#azt_winbackopportunitytotal_base) | Win-Back Opportunity Total (Base) | money |  | Yes | none | 2026-03-21 01:27:04 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 60 | [budgetamount](#budgetamount) | Budget amount | money |  | No | none | 2026-03-20 21:44:40 | true |  |  |  | Opportunity | Budget_Amount__c | Budget_Amount__c | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 61 | [budgetstatus](#budgetstatus) | Budget | picklist |  | No | none | Never | true |  |  |  | Opportunity | Budget_Confirmed__c | Budget_Confirmed__c |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 62 | [captureproposalfeedback](#captureproposalfeedback) | Proposal Feedback Captured | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 63 | [closeprobability](#closeprobability) | Probability Number | int |  | No | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Probability Number | CRM_Probability_Number__c |  |  |  | [2](#2-forms) | [2](#3-views) | [3](#4-chart-visualizations) |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 64 | [completefinalproposal](#completefinalproposal) | Final Proposal Ready | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 65 | [completeinternalreview](#completeinternalreview) | Complete Internal Review | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 66 | [confirminterest](#confirminterest) | Confirm Interest | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 67 | [contactid](#contactid) | Contact | lookup |  | No | none | 2026-03-05 02:19:28 | true |  |  |  | Opportunity | ContactId | ContactId |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 68 | [createdby](#createdby) | Created By | lookup |  | No | none | 2026-03-21 01:27:04 | true |  |  |  | Opportunity | Legacy_Created_By__c | Legacy_Created_By__c | [2](#2-forms) | [9](#3-views) | [14](#4-chart-visualizations) |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 69 | [createdon](#createdon) | Created On | datetime |  | No | none | Skipped (createdon) | true |  |  |  | Opportunity | Legacy_Created_On__c | Legacy_Created_On__c | [2](#2-forms) | [39](#3-views) | [3](#4-chart-visualizations) |  |  |  | [1](#9-formulas-and-rollups) | [10](#10-plugin-source-code-analysis) |  |  |  |  |
| 70 | [currentsituation](#currentsituation) | Current Situation | ntext |  | No | none | 2026-03-20 22:27:05 | true |  |  |  | Opportunity | NextStep | NextStep | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 71 | [customerid](#customerid) | Potential Customer | customer |  | No | required | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  | [48](#3-views) |  |  |  | [14](#7-workflows) |  | [11](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 72 | [customerneed](#customerneed) | Customer Need | ntext |  | No | none | 2026-03-20 22:27:05 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 73 | [customerpainpoints](#customerpainpoints) | Customer Pain Points | ntext |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 74 | [decisionmaker](#decisionmaker) | Decision Maker? | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 75 | [description](#description) | Description | ntext |  | No | none | 2026-03-21 01:27:04 | true |  |  |  | Opportunity | Description | Description | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 76 | [developproposal](#developproposal) | Develop Proposal | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 77 | [discountamount](#discountamount) | Opportunity Discount Amount | money |  | No | none | 2026-03-09 21:14:59 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 78 | [discountpercentage](#discountpercentage) | Opportunity Discount (%) | decimal |  | No | none | 2025-11-21 19:17:58 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 79 | [emailaddress](#emailaddress) | Email Address | nvarchar |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 80 | [estimatedclosedate](#estimatedclosedate) | Est. Close Date | datetime |  | No | none | 2026-03-21 01:27:04 | true | Opportunity | Close Date | CRM_Estimated_Close_Date__c |  |  |  | [3](#2-forms) | [81](#3-views) | [7](#4-chart-visualizations) |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 81 | [estimatedvalue](#estimatedvalue) | Est. Revenue | money |  | No | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Estimated Revenue | CRM_Estimated_Revenue__c |  |  |  | [4](#2-forms) | [41](#3-views) | [8](#4-chart-visualizations) |  |  | [2](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 82 | [evaluatefit](#evaluatefit) | Evaluate Fit | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 83 | [filedebrief](#filedebrief) | File Debrief | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 84 | [freightamount](#freightamount) | Freight Amount | money |  | No | none | 2026-03-21 01:27:04 | true |  |  |  | Opportunity | Freight_Amount__c | Freight_Amount__c | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 85 | [identifycompetitors](#identifycompetitors) | Identify Competitors | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 86 | [identifycustomercontacts](#identifycustomercontacts) | Identify Customer Contacts | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 87 | [identifypursuitteam](#identifypursuitteam) | Identify Sales Team | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 88 | [initialcommunication](#initialcommunication) | Initial Communication | picklist |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 89 | [isrevenuesystemcalculated](#isrevenuesystemcalculated) | Revenue | bit | 1: System Calculated, 0: User Provided | No | none | 2026-03-21 01:27:04 | true | Opportunity | CRM Revenue | CRM_Revenue__c |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 90 | [modifiedon](#modifiedon) | Modified On | datetime |  | No | none | Skipped (modifiedon) | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 91 | [msa_partnerid](#msa_partnerid) | Partner | lookup |  | Yes | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 92 | [msa_partneroppid](#msa_partneroppid) | Partner Contact | lookup |  | Yes | none | 2026-01-20 19:08:41 | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 93 | [msdyn_forecastcategory](#msdyn_forecastcategory) | Forecast category | picklist |  | Yes | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 94 | [msdyn_opportunitykpiid](#msdyn_opportunitykpiid) | KPI | lookup |  | Yes | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 95 | [msdyn_predictivescoreid](#msdyn_predictivescoreid) | Predictive Score | lookup |  | Yes | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 96 | [msdyn_segmentid](#msdyn_segmentid) | Segment Id | lookup |  | Yes | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 97 | [name](#name) | Topic | nvarchar |  | No | required | 2026-03-21 01:27:04 | true |  |  |  | Opportunity | Name | Name | [2](#2-forms) | [75](#3-views) |  |  |  | [19](#7-workflows) |  | [23](#10-plugin-source-code-analysis) |  |  |  |  |
| 98 | [need](#need) | Need | picklist |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 99 | [opportunityid](#opportunityid) | Opportunity | uniqueidentifier |  | No | required | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  | [65](#3-views) |  |  |  | [11](#7-workflows) |  | [32](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 100 | [opportunityratingcode](#opportunityratingcode) | Rating | picklist |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 101 | [originatingleadid](#originatingleadid) | Originating Lead | lookup |  | No | none | 2026-03-20 20:30:47 | true |  |  |  | Opportunity | Sales_Lead__c | Sales_Lead__c | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 102 | [ownerid](#ownerid) | Owner | owner |  | No | systemrequired | 2026-03-21 01:27:04 | true | Opportunity | Record Type | RecordTypeId |  |  |  | [4](#2-forms) | [27](#3-views) | [9](#4-chart-visualizations) |  |  | [25](#7-workflows) |  | [22](#10-plugin-source-code-analysis) |  |  |  |  |
| 103 | [owningbusinessunit](#owningbusinessunit) | Owning Business Unit | lookup |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  | [5](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 104 | [parentaccountid](#parentaccountid) | Account | lookup |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [5](#2-forms) | [1](#3-views) |  |  |  | [13](#7-workflows) |  | [4](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 105 | [parentcontactid](#parentcontactid) | Contact | lookup |  | No | none | 2026-03-21 01:27:04 | true | Opportunity | Contact name | ContactId |  |  |  | [5](#2-forms) | [1](#3-views) |  |  |  | [10](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 106 | [presentfinalproposal](#presentfinalproposal) | Present Final Proposal | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 107 | [presentproposal](#presentproposal) | Presented Proposal | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 108 | [pricelevelid](#pricelevelid) | Price List | lookup |  | No | required | 2026-03-21 01:27:04 | true | Opportunity | Price Book | Pricebook2Id |  |  |  | [2](#2-forms) |  |  |  |  | [7](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 109 | [prioritycode](#prioritycode) | Priority | picklist |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 110 | [proposedsolution](#proposedsolution) | Proposed Solution | ntext |  | No | none | 2026-03-20 22:27:05 | true |  |  |  | Opportunity | Proposed_Solution__c | Proposed_Solution__c | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 111 | [purchaseprocess](#purchaseprocess) | Purchase Process | picklist |  | No | none | 2026-03-20 21:44:40 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 112 | [purchasetimeframe](#purchasetimeframe) | Purchase Timeframe | picklist |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 113 | [pursuitdecision](#pursuitdecision) | Decide Go/No-Go | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 114 | [qualificationcomments](#qualificationcomments) | Qualification Comments | ntext |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 115 | [quotecomments](#quotecomments) | Quote Comments | ntext |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 116 | [resolvefeedback](#resolvefeedback) | Feedback Resolved | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 117 | [salesstage](#salesstage) | Deprecated Sales Stage | picklist |  | No | none | 2026-03-20 20:16:40 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 118 | [salesstagecode](#salesstagecode) | Process Code | picklist |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 119 | [sendthankyounote](#sendthankyounote) | Send Thank You Note | bit |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 120 | [statecode](#statecode) | Status | state |  | No | systemrequired | 2026-03-21 01:27:04 | true | Opportunity | CRM Status | CRM_Status__c |  |  |  |  | [58](#3-views) | [2](#4-chart-visualizations) |  |  | [10](#7-workflows) |  | [20](#10-plugin-source-code-analysis) |  |  |  |  |
| 121 | [statuscode](#statuscode) | Status Reason | status |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  |  | [10](#3-views) |  |  |  | [5](#7-workflows) |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 122 | [totalamount](#totalamount) | Total Amount | money |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 123 | [totalamountlessfreight](#totalamountlessfreight) | Total Pre-Freight Amount | money |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 124 | [totallineitemamount](#totallineitemamount) | Total Detail Amount | money |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 125 | [totaltax](#totaltax) | Total Tax | money |  | No | none | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 126 | [transactioncurrencyid](#transactioncurrencyid) | Currency | lookup |  | No | required | 2026-03-21 01:27:04 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |

---

## 2. Forms

Total forms: **9**

### 2.1. AI for Sales - main - Active

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
| [RICONTAINER_CHARTS](#ricontainer_charts) |  | No | Yes |

#### Tab: QUOTES

##### Section: opportunityquotes

#### Tab: Products

##### Section: opportunityproducts

#### Tab: linkedin_v2_tab
*Hidden tab*

##### Section: linkedin_v2_tab_section_1

##### Section: linkedin_v2_tab_section_2

##### Section: linkedin_v2_tab_section_3

### 2.2. iGrad - main - Active

- **Form ID:** `{62b5695a-d153-4bdc-9638-79409d3abcc1}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Header Fields

| Field | Label |
|-------|-------|
| [azt_recordownerid](#azt_recordownerid) | Record Owner |
| [ownerid](#ownerid) | Owner |
| [estimatedvalue](#estimatedvalue) | Est. Revenue |
| [parentaccountid](#parentaccountid) | Account |

#### Tab: Summary

##### Section: Opportunity Information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [name](#name) | Topic | No | Yes |
| [parentaccountid](#parentaccountid) | Account Owner | No | Yes |
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |
| [azt_opportunitynumber](#azt_opportunitynumber) | Opportunity Number | Yes | Yes |
| [parentcontactid](#parentcontactid) | Contact | No | Yes |
| [azt_opportunitytype](#azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_iscrossselloppty](#azt_iscrossselloppty) | Is Cross-sell Oppty? | No | Yes |
| [azt_opportunityproductcategory](#azt_opportunityproductcategory) | Product Category | No | No |
| [azt_deliverytype](#azt_deliverytype) | Delivery Type | No | Yes |
| [azt_accountclassification](#azt_accountclassification) | Account Classification | No | Yes |
| [azt_pipelinestage](#azt_pipelinestage) | Pipeline Stage | No | Yes |
| [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | Expected Renewal Value | No | Yes |
| [originatingleadid](#originatingleadid) | Originating Lead | Yes | Yes |
| [Competitors](#competitors) | Competitors | No | Yes |
| [msdyn_forecastcategory](#msdyn_forecastcategory) | Forecast category | No | No |

##### Section: Opportunity Details

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [currentsituation](#currentsituation) | Current Situation | No | Yes |
| [azt_renewalnotes](#azt_renewalnotes) | Renewal Notes | No | Yes |

##### Section: Opportunity Audit

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [opportunityaudit](#opportunityaudit) | Opportunity Audit Records (Opportunity) | No | Yes |

##### Section: Up next

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [CadenceWidgetControl](#cadencewidgetcontrol) | Up next | No | Yes |

##### Section: Assistant

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ActionCards](#actioncards) | Assistant | No | Yes |

##### Section: Sales Team

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Pursuit_Team](#pursuit_team) | SALES TEAM | No | Yes |
| [Stakeholders](#stakeholders) | STAKEHOLDERS | No | Yes |

##### Section: Rollup Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_initialopportunitytotal](#azt_initialopportunitytotal) | Initial Opportunity Total | No | Yes |
| [azt_addonopportunitytotal](#azt_addonopportunitytotal) | Add-On Opportunity Total | No | Yes |
| [azt_renewalopportunitytotal](#azt_renewalopportunitytotal) | Renewal Opportunity Total | No | Yes |
| [azt_pilotopportunitytotal](#azt_pilotopportunitytotal) | Pilot Opportunity Total | No | Yes |
| [azt_winbackopportunitytotal](#azt_winbackopportunitytotal) | Win-Back Opportunity Total | No | Yes |
| [azt_printopportunitytotal](#azt_printopportunitytotal) | Print Opportunity Total | No | Yes |
| [azt_otheropportunitytotal](#azt_otheropportunitytotal) | Other Opportunity Total | No | Yes |
| [azt_dayssincecreated](#azt_dayssincecreated) | Days Since Created | No | Yes |

##### Section: Competitors

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Competitors](#competitors) | Competitors | No | Yes |

#### Tab: Forecast/Activities

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [estimatedvalue](#estimatedvalue) | Est. Revenue | No | Yes |
| [estimatedclosedate](#estimatedclosedate) | Est. Close Date | No | Yes |
| [purchasetimeframe](#purchasetimeframe) | Purchase Timeframe | No | Yes |
| [azt_probability](#azt_probability) | Probability | No | Yes |
| [azt_dayssinceprobabilitychanged](#azt_dayssinceprobabilitychanged) | Days Since Probability Changed | Yes | Yes |
| [azt_pipelinestage](#azt_pipelinestage) | Pipeline Stage | No | Yes |
| [budgetamount](#budgetamount) | Budget Amount | No | Yes |
| [closeprobability](#closeprobability) | Probability Number | No | No |
| [purchaseprocess](#purchaseprocess) | Purchase Process | No | Yes |
| [azt_fundingsource](#azt_fundingsource) | Funding Source | No | Yes |
| [azt_lastactivitydate](#azt_lastactivitydate) | Last Activity Date | Yes | Yes |
| [azt_lastmodifiedbyid](#azt_lastmodifiedbyid) | Last Modified By | No | No |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [activities](#activities) | Activities | No | Yes |

#### Tab: Product line items

##### Section: Opportunity Products

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [pricelevelid](#pricelevelid) | Price List | No | Yes |
| [isrevenuesystemcalculated](#isrevenuesystemcalculated) | Revenue | No | Yes |
| [opportunityproductsGrid](#opportunityproductsgrid) | Line Items | No | Yes |

##### Section: Suggestions

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ProductSuggestions_LinkControl](#productsuggestions_linkcontrol) |  | No | Yes |

##### Section: Dynamic properties

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [DynamicPropertiesList_LinkControl](#dynamicpropertieslist_linkcontrol) |  | No | Yes |

##### Section: Product Line Item Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [transactioncurrencyid](#transactioncurrencyid) | Currency | No | Yes |
| [totallineitemamount](#totallineitemamount) | Detail Amount | Yes | Yes |
| [discountpercentage](#discountpercentage) | (-) Discount (%) | No | Yes |
| [discountamount](#discountamount) | (-) Discount | Yes | Yes |
| [azt_discretionarydiscount](#azt_discretionarydiscount) | Discretionary Discount | No | Yes |
| [azt_discretionarydiscountamt](#azt_discretionarydiscountamt) | Discretionary Discount Amt | Yes | No |
| [totalamountlessfreight](#totalamountlessfreight) | Pre-freight amount | Yes | Yes |
| [freightamount](#freightamount) | (+) freight amount | Yes | Yes |
| [totaltax](#totaltax) | (+) Total tax | Yes | Yes |
| [totalamount](#totalamount) | Total Amount | Yes | Yes |

##### Section: Freight

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_defaultfreightamount](#azt_defaultfreightamount) | Default Freight Amount | Yes | Yes |
| [azt_requestedfreightamt](#azt_requestedfreightamt) | Requested Freight Amt | No | Yes |
| [azt_freightamtapproved](#azt_freightamtapproved) | Freight Amt Approved? | No | Yes |

#### Tab: Discretionary Discounts

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discounts](#discounts) | Product Discounts (Opportunity) | No | Yes |

#### Tab: Files

##### Section: Documents Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [DocumentsSubGrid](#documentssubgrid) | Documents | No | Yes |

#### Tab: LinkedIn Sales Navigator
*Hidden tab*

##### Section: LinkedIn Member Profile

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentcontactid](#parentcontactid) | Contact | No | Yes |

##### Section: LinkedIn Account Profile

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentaccountid](#parentaccountid) | Account | No | Yes |

##### Section: LinkedIn InMail

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentcontactid](#parentcontactid) | Contact | No | Yes |

#### Tab: Quotes

##### Section: Quotes

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quote](#quote) | Action Cards | No | Yes |

#### Tab: Documents

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [documents](#documents) | Document Locations (Regarding) | No | Yes |

#### Tab: Notes

##### Section: Notes pane

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#notescontrol) |  | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [actualclosedate](#actualclosedate) | Actual Close Date |
| [createdon](#createdon) | Created On |
| [createdby](#createdby) | Created By |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `LinkedInIntegration.LinkedInIntegrationCommon.Instance.Form_OnLoad` | `LinkedInIntegration/Common/msdyn_LinkedInIntegrationCommon.js` | true |
| onload |  | `Sales.DocumentsTabController.shouldShowDocumentsTab` | `Sales/ClientCommon/Sales_ClientCommon.js` | true |
| onload |  | `OPP.OPPFunctions.onLoad` | `azt_opportunitylibrary` | true |
| onrecordselect |  | `Mscrm.onRecordSelect` | `Sales/Opportunity/Opportunity_main_system_library.js` | true |
| onrecordselect |  | `DSC.DiscountFunctions.gridSelectRow` | `azt_discountgridfunctions` | true |
| onchange | azt_freightamtapproved | `OPP.OPPFunctions.setFreightAmt` | `azt_opportunitylibrary` | true |

### 2.3. Opportunity - main - Active

- **Form ID:** `{a837e4a7-01b8-4f82-a475-be9abd67e667}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Header Fields

| Field | Label |
|-------|-------|
| [azt_recordownerid](#azt_recordownerid) | Record Owner |

#### Tab: Summary

##### Section: Opportunity Information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [parentaccountid](#parentaccountid) | Account Owner | No | Yes |
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |
| [azt_opportunitynumber](#azt_opportunitynumber) | Opportunity Number | Yes | Yes |
| [parentcontactid](#parentcontactid) | Contact | No | Yes |
| [azt_opportunitytype](#azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_iscrossselloppty](#azt_iscrossselloppty) | Is Cross-sell Oppty? | No | Yes |
| [azt_leadsourceid](#azt_leadsourceid) | Lead Source | No | Yes |
| [azt_opportunityproductcategory](#azt_opportunityproductcategory) | Product Category | No | No |
| [azt_deliverytype](#azt_deliverytype) | Delivery Type | No | Yes |
| [azt_accountclassification](#azt_accountclassification) | Account Classification | No | Yes |
| [azt_committoestimatedclose](#azt_committoestimatedclose) | Commit to Pipeline? | No | Yes |
| [azt_pipelinestage](#azt_pipelinestage) | Pipeline Stage | No | Yes |
| [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | Expected Renewal Value | No | Yes |
| [azt_assignedamid](#azt_assignedamid) | Assigned AM | No | Yes |
| [originatingleadid](#originatingleadid) | Originating Lead | Yes | Yes |
| [Competitors](#competitors) | Competitors | No | Yes |

##### Section: Opportunity_details

##### Section: Record_Summary_Widget
*Hidden section*

##### Section: Summary_CadenceWidget

##### Section: Notes_pane

##### Section: Opportunity Details

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [description](#description) | Description | No | Yes |
| [currentsituation](#currentsituation) | Current Situation | No | Yes |
| [customerneed](#customerneed) | Customer Need | No | Yes |
| [proposedsolution](#proposedsolution) | Proposed Solution | No | Yes |
| [azt_internalaztecnotes](#azt_internalaztecnotes) | Internal Aztec Notes | No | Yes |
| [azt_renewalnotes](#azt_renewalnotes) | Renewal Notes | No | Yes |

##### Section: Opportunity Audit

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [opportunityaudit](#opportunityaudit) | Opportunity Audit Records (Opportunity) | No | Yes |

##### Section: Sales Team

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Pursuit_Team](#pursuit_team) | SALES TEAM | No | Yes |

##### Section: Competitors_Section

##### Section: Rollup Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_initialopportunitytotal](#azt_initialopportunitytotal) | Initial Opportunity Total | No | Yes |
| [azt_addonopportunitytotal](#azt_addonopportunitytotal) | Add-On Opportunity Total | No | Yes |
| [azt_renewalopportunitytotal](#azt_renewalopportunitytotal) | Renewal Opportunity Total | No | Yes |
| [azt_pilotopportunitytotal](#azt_pilotopportunitytotal) | Pilot Opportunity Total | No | Yes |
| [azt_winbackopportunitytotal](#azt_winbackopportunitytotal) | Win-Back Opportunity Total | No | Yes |
| [azt_printopportunitytotal](#azt_printopportunitytotal) | Print Opportunity Total | No | Yes |
| [azt_otheropportunitytotal](#azt_otheropportunitytotal) | Other Opportunity Total | No | Yes |
| [azt_dayssincecreated](#azt_dayssincecreated) | Days Since Created | No | Yes |

#### Tab: Products

##### Section: Opportunity Products

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [pricelevelid](#pricelevelid) | Price List | No | Yes |
| [isrevenuesystemcalculated](#isrevenuesystemcalculated) |  | No | Yes |
| [opportunityproductsGrid](#opportunityproductsgrid) | Line Items | No | Yes |

##### Section: Product Line Item Totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discountamount](#discountamount) |  | Yes | Yes |
| [freightamount](#freightamount) | (+) Freight Amount | Yes | Yes |
| [transactioncurrencyid](#transactioncurrencyid) | Currency | No | Yes |
| [azt_discretionarydiscount](#azt_discretionarydiscount) | Discretionary Discount | No | Yes |
| [azt_discretionarydiscountamt](#azt_discretionarydiscountamt) | Discretionary Discount Amt | Yes | No |

##### Section: Freight

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_defaultfreightamount](#azt_defaultfreightamount) | Default Freight Amount | Yes | Yes |
| [azt_requestedfreightamt](#azt_requestedfreightamt) | Requested Freight Amt | No | Yes |
| [azt_freightamtapproved](#azt_freightamtapproved) | Freight Amt Approved? | No | Yes |

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
| [estimatedvalue](#estimatedvalue) | Est. Revenue | No | Yes |
| [estimatedclosedate](#estimatedclosedate) | Est. Close Date | No | Yes |
| [purchasetimeframe](#purchasetimeframe) | Purchase Timeframe | No | Yes |
| [azt_probability](#azt_probability) | Probability | No | Yes |
| [azt_dayssinceprobabilitychanged](#azt_dayssinceprobabilitychanged) | Days Since Probability Changed | Yes | Yes |
| [azt_pipelinestage](#azt_pipelinestage) | Pipeline Stage | No | Yes |
| [budgetamount](#budgetamount) | Budget Amount | No | Yes |
| [closeprobability](#closeprobability) | Probability Number | No | No |
| [purchaseprocess](#purchaseprocess) | Purchase Process | No | Yes |
| [azt_fundingsource](#azt_fundingsource) | Funding Source | No | Yes |
| [azt_lastactivitydate](#azt_lastactivitydate) | Last Activity Date | Yes | Yes |
| [azt_lastmodifiedbyid](#azt_lastmodifiedbyid) | Last Modified By | No | No |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [activities](#activities) | Activities | No | Yes |

#### Tab: Discretionary Discounts

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discounts](#discounts) | Product Discounts (Opportunity) | No | Yes |

#### Tab: Documents

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [documents](#documents) | Document Locations (Regarding) | No | Yes |

#### Tab: Notes

##### Section: Notes pane

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#notescontrol) |  | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [actualclosedate](#actualclosedate) | Actual Close Date |
| [createdon](#createdon) | Created On |
| [createdby](#createdby) | Created By |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `SalesCopilot.CopilotSummaryWidget.copilotHelper.shouldShowSummaryWidget` | `msdyn_SalesCopilot/CopilotSummaryWidget.Library.js` | true |
| onload |  | `OPP.OPPFunctions.onLoad` | `azt_opportunitylibrary` | true |
| onrecordselect |  | `DSC.DiscountFunctions.gridSelectRow` | `azt_discountgridfunctions` | true |
| onchange | azt_freightamtapproved | `OPP.OPPFunctions.setFreightAmt` | `azt_opportunitylibrary` | true |

### 2.4. Information - main - Inactive

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
| [WebResource_RecordWall](#webresource_recordwall) | RecordWall | No | Yes |

### 2.5. Opportunity - quickCreate - Active

- **Form ID:** `{e3c588ee-8e11-49da-a5fe-3800f3f683de}`
- **Presentation:** Classic
- **Status:** Active

#### Tab: newOpportunity

##### Section: quickOpportunity_column1

##### Section: quickOpportunity_column2

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_opportunitytype](#azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_probability](#azt_probability) | Probability | No | Yes |
| [azt_fundingsource](#azt_fundingsource) | Funding Source | No | Yes |

##### Section: quickOpportunity_column3

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#ownerid) | Owner | No | Yes |
| [estimatedvalue](#estimatedvalue) | Est. Revenue | No | Yes |

### 2.6. Opportunity Quick - quickCreate - Active

- **Form ID:** `{1f4f9cba-78e3-4bf7-b194-65d71fa84200}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [name](#name) | Topic | No | Yes |
| [parentcontactid](#parentcontactid) | Contact | No | Yes |
| [parentaccountid](#parentaccountid) | Account | No | Yes |

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [estimatedclosedate](#estimatedclosedate) | Est. Close Date | No | Yes |
| [azt_opportunitytype](#azt_opportunitytype) | Opportunity Type | No | Yes |
| [azt_probability](#azt_probability) | Probability | No | Yes |
| [azt_fundingsource](#azt_fundingsource) | Funding Source | No | Yes |

##### Section: Customer Info

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [customerneed](#customerneed) | Customer Need | No | Yes |

### 2.7. Opportunity Record Owner - quick - Active

- **Form ID:** `{7305dc75-69b6-4d33-8caa-82516d20a507}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |

### 2.8. Opportunity Owner Quick View - quick - Active

- **Form ID:** `{087cefcf-a5f8-4eb0-bb5a-8f30fbce0ac8}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Opportunity Owner

##### Section: Opportunity Owner

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |
| [ownerid](#ownerid) | Opportunity Owner | No | No |

### 2.9. Order Opportunity Owner Quick View - quick - Active

- **Form ID:** `{8ae9ecb5-a042-4c4d-b1f4-df762846bbcf}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#ownerid) | Opportunity Owner | No | Yes |

---

## 3. Views

Total views: **65**

### 3.1. All Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [statecode](#statecode) | 100px |
| 2 | [createdon](#createdon) | 100px |
| 3 | [name](#name) | 300px |
| 4 | [azt_opportunitynumber](#azt_opportunitynumber) | 86px |
| 5 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 6 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 125px |
| 7 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 8 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 9 | [azt_probability](#azt_probability) | 100px |
| 10 | [ownerid](#ownerid) | 125px |
| 11 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 12 | [customerid](#customerid) | 150px |
| 13 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 14 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 15 | [statuscode](#statuscode) | 100px |
| 16 | [actualclosedate](#actualclosedate) | 100px |
| 17 | [actualvalue_base](#actualvalue_base) | 100px |
| 18 | [actualvalue](#actualvalue) | 100px |
| 19 | [estimatedvalue](#estimatedvalue) | 100px |
| 20 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 21 | [address1_city](#address1_city) |  |
| 22 | [opportunityid](#opportunityid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Descending |
| [name](#name) | Ascending |

### 3.2. Closed Opportunities in Current Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 125px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [actualclosedate](#actualclosedate) | 125px |
| 5 | [actualvalue](#actualvalue) | 125px |
| 6 | [customerid](#customerid) | 150px |
| 7 | [ownerid](#ownerid) | 150px |
| 8 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 9 | [statuscode](#statuscode) | 150px |
| 10 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [statecode](#statecode) | eq | 2 |
| [actualclosedate](#actualclosedate) | this-fiscal-year |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#actualvalue) | Descending |

### 3.3. Closed Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunitynumber](#azt_opportunitynumber) | 77px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 125px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [actualclosedate](#actualclosedate) | 125px |
| 6 | [actualvalue](#actualvalue) | 125px |
| 7 | [customerid](#customerid) | 150px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 10 | [ownerid](#ownerid) | 150px |
| 11 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 12 | [statuscode](#statuscode) | 150px |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [statecode](#statecode) | eq | 2 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualclosedate](#actualclosedate) | Descending |

### 3.4. Executive Sales Measure 30 Day Pipeline

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdon](#createdon) | 100px |
| 2 | [owningbusinessunit](#owningbusinessunit) | 150px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 4 | [customerid](#customerid) | 200px |
| 5 | [name](#name) | 200px |
| 6 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 7 | [estimatedvalue](#estimatedvalue) | 125px |
| 8 | [azt_probability](#azt_probability) | 100px |
| 9 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 10 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#createdon) | last-x-days | 30 |
| [azt_opportunitytype](#azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Ascending |
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.5. Executive Sales Measure Advanced 30 Day Pipeline

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probabilitychangedon](#azt_probabilitychangedon) | 150px |
| 2 | [owningbusinessunit](#owningbusinessunit) | 150px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 4 | [customerid](#customerid) | 200px |
| 5 | [name](#name) | 200px |
| 6 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 7 | [estimatedvalue](#estimatedvalue) | 125px |
| 8 | [azt_probability](#azt_probability) | 100px |
| 9 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 10 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_probabilitychangedon](#azt_probabilitychangedon) | last-x-days | 30 |
| [azt_opportunitytype](#azt_opportunitytype) | ne | 276530005 |
| [azt_probabilityincreased](#azt_probabilityincreased) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [owningbusinessunit](#owningbusinessunit) | Ascending |
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.6. GEDSRM Opps

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [statecode](#statecode) | 100px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [name](#name) | 300px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 125px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 7 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 8 | [azt_probability](#azt_probability) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 11 | [actualclosedate](#actualclosedate) | 100px |
| 12 | [actualvalue_base](#actualvalue_base) | 100px |
| 13 | [actualvalue](#actualvalue) | 100px |
| 14 | [estimatedvalue](#estimatedvalue) | 100px |
| 15 | [ownerid](#ownerid) | 125px |
| 16 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 17 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 18 | [address1_city](#address1_city) |  |
| 19 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [name](#name) | like | %SRM% |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Descending |
| [name](#name) | Ascending |

### 3.7. Lost Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunitynumber](#azt_opportunitynumber) | 77px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 5 | [actualclosedate](#actualclosedate) | 125px |
| 6 | [customerid](#customerid) | 150px |
| 7 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 9 | [statuscode](#statuscode) | 150px |
| 10 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 11 | [address1_city](#address1_city) |  |
| 12 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 2 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualclosedate](#actualclosedate) | Descending |

### 3.8. My Aged or Stuck Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_lastactivitydate](#azt_lastactivitydate) | 100px |
| 2 | [azt_dayssincecreated](#azt_dayssincecreated) | 100px |
| 3 | [createdon](#createdon) | 100px |
| 4 | [name](#name) | 150px |
| 5 | [azt_opportunitytype](#azt_opportunitytype) | 100px |
| 6 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 7 | [azt_dayssinceprobabilitychanged](#azt_dayssinceprobabilitychanged) | 100px |
| 8 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 9 | [azt_probabilitychangedon](#azt_probabilitychangedon) | 100px |
| 10 | [azt_probability](#azt_probability) | 100px |
| 11 | [estimatedvalue](#estimatedvalue) | 100px |
| 12 | [customerid](#customerid) | 100px |
| 13 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 14 | [ownerid](#ownerid) | 100px |
| 15 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_opportunitytype](#azt_opportunitytype) | not-in |  |
| [azt_dayssinceprobabilitychanged](#azt_dayssinceprobabilitychanged) | ge | 60 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_probabilitychangedon](#azt_probabilitychangedon) | Descending |

### 3.9. My Closed Opportunities in Current Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [actualclosedate](#actualclosedate) | 125px |
| 5 | [actualvalue](#actualvalue) | 125px |
| 6 | [customerid](#customerid) | 150px |
| 7 | [statuscode](#statuscode) | 150px |
| 8 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [statecode](#statecode) | eq | 2 |
| [actualclosedate](#actualclosedate) | this-fiscal-year |  |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#actualvalue) | Descending |

### 3.10. My Initial/Add-on Opportunities Added Last Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 125px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#createdon) | 100px |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_opportunitytype](#azt_opportunitytype) | in |  |
| [createdon](#createdon) | last-week |  |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Ascending |

### 3.11. My Initial/Add-on Opportunities Added This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 125px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#createdon) | 100px |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_opportunitytype](#azt_opportunitytype) | in |  |
| [createdon](#createdon) | this-month |  |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Ascending |

### 3.12. My Initial/Add-on Opportunities Added This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 125px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 125px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#createdon) | 100px |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_opportunitytype](#azt_opportunitytype) | in |  |
| [createdon](#createdon) | this-week |  |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Ascending |

### 3.13. My Open Opportunities Created This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [createdon](#createdon) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [createdon](#createdon) | this-month |  |
| [statecode](#statecode) | eq | 0 |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.14. My Open Opportunities Created This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [createdon](#createdon) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [createdon](#createdon) | this-week |  |
| [statecode](#statecode) | eq | 0 |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.15. My Open Opportunities Created This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [createdon](#createdon) | 100px |
| 3 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [createdon](#createdon) | this-fiscal-year |  |
| [statecode](#statecode) | eq | 0 |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.16. My Open Opportunities

- **Type:** Standard (querytype=0)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunitynumber](#azt_opportunitynumber) | 83px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 125px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 110px |
| 8 | [customerid](#customerid) | 125px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 300px |
| 10 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 11 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |

### 3.17. My Open Renewal Opportunities as Account Owner

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [customerid](#customerid) | 150px |
| 9 | [closeprobability](#closeprobability) | 100px |
| 10 | [createdon](#createdon) | 100px |
| 11 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Ascending |

### 3.18. My Opportunities Closing Next Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 100px |
| 2 | [name](#name) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 100px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 100px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket](#a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket) | 100px |
| 9 | [customerid](#customerid) | 100px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [azt_verticalmarket](#azt_verticalmarket) |  |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | next-year |  |
| [statecode](#statecode) | eq | 0 |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Descending |

### 3.19. My Opportunities Closing This Fiscal Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 100px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket](#a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket) | 100px |
| 10 | [customerid](#customerid) | 150px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 12 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 125px |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [azt_verticalmarket](#azt_verticalmarket) |  |
| 16 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | this-fiscal-period |  |
| [statecode](#statecode) | eq | 0 |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |

### 3.20. My Opportunities Closing This Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 125px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 125px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket](#a_ef7baa35fe04e911a94d000d3a3b9f01azt_verticalmarket) | 100px |
| 10 | [customerid](#customerid) | 150px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 12 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 125px |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [azt_verticalmarket](#azt_verticalmarket) |  |
| 16 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | this-fiscal-year |  |
| [statecode](#statecode) | eq | 0 |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |

### 3.21. My Opportunities Closing This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 100px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 125px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 125px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 125px |
| 12 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 13 | [address1_city](#address1_city) |  |
| 14 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | this-month |  |
| [statecode](#statecode) | eq | 0 |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |

### 3.22. My Opportunities Closing This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 3 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | this-week |  |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.23. My Opportunities Created This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [createdby](#createdby) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [estimatedvalue](#estimatedvalue) | 100px |
| 6 | [ownerid](#ownerid) | 100px |
| 7 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdby](#createdby) | eq-userid |  |
| [createdon](#createdon) | this-fiscal-period |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.24. My Opportunities Created This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [createdon](#createdon) | 100px |
| 3 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 4 | [estimatedvalue](#estimatedvalue) | 100px |
| 5 | [ownerid](#ownerid) | 100px |
| 6 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdby](#createdby) | eq-userid |  |
| [createdon](#createdon) | this-fiscal-year |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.25. My Opportunities Won This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-fiscal-period |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.26. My Opportunities Won This Year No Renewals

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 125px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_city](#a_887fa82ffe04e911a94d000d3a3b9f01address1_city) | 125px |
| 11 | [a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_887fa82ffe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [createdon](#createdon) | 100px |
| 13 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 14 | [address1_city](#address1_city) |  |
| 15 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-fiscal-year |  |
| [azt_opportunitytype](#azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Ascending |

### 3.27. My Overdue Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 3 | [estimatedclosedate](#estimatedclosedate) | 125px |
| 4 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 5 | [azt_probability](#azt_probability) | 100px |
| 6 | [estimatedvalue](#estimatedvalue) | 100px |
| 7 | [customerid](#customerid) | 150px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_composite](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_composite) | 300px |
| 9 | [address1_composite](#address1_composite) |  |
| 10 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [ownerid](#ownerid) | eq-userid |  |
| [estimatedclosedate](#estimatedclosedate) | olderthan-x-days | 1 |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |

### 3.28. My Overdue Opps

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probabilitychangedon](#azt_probabilitychangedon) | 150px |
| 2 | [customerid](#customerid) | 200px |
| 3 | [name](#name) | 200px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedvalue](#estimatedvalue) | 125px |
| 6 | [azt_probability](#azt_probability) | 100px |
| 7 | [estimatedclosedate](#estimatedclosedate) | 125px |
| 8 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | olderthan-x-days | 45 |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [statecode](#statecode) | eq | 0 |
| [azt_opportunitytype](#azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Descending |

### 3.29. My Stalled Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probabilitychangedon](#azt_probabilitychangedon) | 150px |
| 2 | [customerid](#customerid) | 200px |
| 3 | [name](#name) | 200px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedvalue](#estimatedvalue) | 125px |
| 6 | [azt_probability](#azt_probability) | 100px |
| 7 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 8 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [azt_probabilitychangedon](#azt_probabilitychangedon) | olderthan-x-days | 60 |
| [statecode](#statecode) | eq | 0 |
| [azt_opportunitytype](#azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Descending |

### 3.30. My Won Opps this Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [actualclosedate](#actualclosedate) | 125px |
| 5 | [actualvalue](#actualvalue) | 100px |
| 6 | [customerid](#customerid) | 150px |
| 7 | [ownerid](#ownerid) | 150px |
| 8 | [statuscode](#statuscode) | 150px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.ownerid](#a_ef7baa35fe04e911a94d000d3a3b9f01ownerid) | 100px |
| 10 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-year |  |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#actualvalue) | Descending |

### 3.31. Open Opportunities by Sales Rep

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 3 | [estimatedvalue](#estimatedvalue) | 100px |
| 4 | [customerid](#customerid) | 100px |
| 5 | [closeprobability](#closeprobability) | 100px |
| 6 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 7 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | this-fiscal-period |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.32. Open Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdon](#createdon) | 100px |
| 2 | [azt_dayssincecreated](#azt_dayssincecreated) | 100px |
| 3 | [name](#name) | 300px |
| 4 | [azt_opportunitynumber](#azt_opportunitynumber) | 87px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [azt_dayssinceprobabilitychanged](#azt_dayssinceprobabilitychanged) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 13 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 14 | [a_ef7baa35fe04e911a94d000d3a3b9f01.ownerid](#a_ef7baa35fe04e911a94d000d3a3b9f01ownerid) | 100px |
| 15 | [statecode](#statecode) | 150px |
| 16 | [ownerid](#ownerid) |  |
| 17 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 18 | [address1_city](#address1_city) |  |
| 19 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |

### 3.33. Open Renewal Opps 90 Days Past Due

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 5 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | olderthan-x-months | 3 |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.34. Open Renewal Opps Close Date Last Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 5 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | last-month |  |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.35. Open Renewal Opps Closing Next Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 5 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | next-month |  |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.36. Open Renewal Opps Closing This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 5 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | this-month |  |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.37. Open Renewal Opps Closing Within 90 Days

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 5 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | next-x-months | 3 |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.38. Opportunities Closing Next Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accountclassification](#azt_accountclassification) | 100px |
| 2 | [name](#name) | 300px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 7 | [azt_probability](#azt_probability) | 75px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 13 | [address1_city](#address1_city) |  |
| 14 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | next-fiscal-year |  |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.39. Opportunities Closing Next Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [customerid](#customerid) | 150px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 10 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 11 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | next-month |  |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |

### 3.40. Opportunities Closing This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | this-month |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.41. Opportunities Closing This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | this-week |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.42. Opportunities Created This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdby](#createdby) | 100px |
| 2 | [createdon](#createdon) | 150px |
| 3 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 4 | [estimatedvalue](#estimatedvalue) | 100px |
| 5 | [ownerid](#ownerid) | 100px |
| 6 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#createdon) | this-fiscal-year |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdby](#createdby) | Ascending |

### 3.43. Opportunities in Current Fiscal Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_probability](#azt_probability) | 100px |
| 2 | [name](#name) | 100px |
| 3 | [customerid](#customerid) | 100px |
| 4 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 5 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 6 | [statecode](#statecode) | 100px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 9 | [actualvalue](#actualvalue) | 100px |
| 10 | [ownerid](#ownerid) | 100px |
| 11 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 12 | [address1_city](#address1_city) |  |
| 13 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | this-fiscal-year |  |
| [statecode](#statecode) | in |  |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#actualvalue) | Ascending |
| [estimatedclosedate](#estimatedclosedate) | Descending |

### 3.44. Opportunities Opened Last Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [ownerid](#ownerid) | 150px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 13 | [address1_city](#address1_city) |  |
| 14 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#createdon) | last-week |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedvalue](#estimatedvalue) | Descending |

### 3.45. Opportunities Opened This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [createdby](#createdby) | 100px |
| 3 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 4 | [estimatedvalue](#estimatedvalue) | 100px |
| 5 | [ownerid](#ownerid) | 100px |
| 6 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#createdon) | this-month |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdby](#createdby) | Ascending |

### 3.46. Opportunities Opened This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdby](#createdby) | 100px |
| 2 | [createdon](#createdon) | 100px |
| 3 | [name](#name) | 150px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [estimatedvalue](#estimatedvalue) | 100px |
| 6 | [ownerid](#ownerid) | 100px |
| 7 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#createdon) | this-fiscal-period |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.47. Opportunities Opened This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [ownerid](#ownerid) | 150px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 11 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 12 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 13 | [address1_city](#address1_city) |  |
| 14 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [createdon](#createdon) | this-week |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedvalue](#estimatedvalue) | Descending |

### 3.48. Opportunities Opened This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [ownerid](#ownerid) | 100px |
| 2 | [createdby](#createdby) | 100px |
| 3 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 4 | [createdon](#createdon) | 100px |
| 5 | [estimatedvalue](#estimatedvalue) | 100px |
| 6 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [createdon](#createdon) | this-week |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [ownerid](#ownerid) | Ascending |

### 3.49. Opportunity Advanced Find View

- **Type:** Advanced Find (querytype=1)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [ownerid](#ownerid) | 150px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [statuscode](#statuscode) | 150px |
| 11 | [opportunityid](#opportunityid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.50. Opportunity Associated View

- **Type:** Associated View (querytype=2)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [actualvalue](#actualvalue) | 100px |
| 9 | [ownerid](#ownerid) | 150px |
| 10 | [customerid](#customerid) | 150px |
| 11 | [opportunityid](#opportunityid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.51. Opportunity Lookup View

- **Type:** Lookup View (querytype=64)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | ne | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.52. Out of Territory Opportunities - Open

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 2 | [azt_dayssincecreated](#azt_dayssincecreated) | 100px |
| 3 | [azt_dayssinceprobabilitychanged](#azt_dayssinceprobabilitychanged) | 100px |
| 4 | [name](#name) | 300px |
| 5 | [azt_opportunitytype](#azt_opportunitytype) | 100px |
| 6 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 7 | [azt_probability](#azt_probability) | 100px |
| 8 | [estimatedvalue](#estimatedvalue) | 100px |
| 9 | [ownerid](#ownerid) | 100px |
| 10 | [customerid](#customerid) | 100px |
| 11 | [statuscode](#statuscode) | 100px |
| 12 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [new_sharedwith](#new_sharedwith) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.53. Overdue Opportunities > 45 Days

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [owningbusinessunit](#owningbusinessunit) | 150px |
| 2 | [customerid](#customerid) | 200px |
| 3 | [name](#name) | 200px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [estimatedvalue](#estimatedvalue) | 100px |
| 6 | [azt_probability](#azt_probability) | 100px |
| 7 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 8 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 9 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | olderthan-x-days | 45 |
| [statecode](#statecode) | eq | 0 |
| [azt_opportunitytype](#azt_opportunitytype) | ne | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.54. Quick Find Open Opportunities

- **Type:** Quick Find (querytype=4)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [ownerid](#ownerid) | 150px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [name](#name) | like | {0} |
| [azt_opportunitytype](#azt_opportunitytype) | like | {0} |
| [azt_opportunitynumber](#azt_opportunitynumber) | like | {0} |
| [parentcontactid](#parentcontactid) | like | {0} |
| [parentaccountid](#parentaccountid) | like | {0} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.55. Recent Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 5 | [azt_pipelinestage](#azt_pipelinestage) | 100px |
| 6 | [azt_probability](#azt_probability) | 75px |
| 7 | [estimatedvalue](#estimatedvalue) | 100px |
| 8 | [ownerid](#ownerid) | 150px |
| 9 | [customerid](#customerid) | 150px |
| 10 | [statecode](#statecode) | 100px |
| 11 | [actualclosedate](#actualclosedate) | 100px |
| 12 | [actualvalue](#actualvalue) | 100px |
| 13 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [actualclosedate](#actualclosedate) | last-x-months | 12 |
| [statecode](#statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [statecode](#statecode) | Ascending |
| [estimatedclosedate](#estimatedclosedate) | Descending |
| [modifiedon](#modifiedon) | Descending |

### 3.56. Self Sourced Pipeline per rep in Last 30 Days

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [customerid](#customerid) | 200px |
| 2 | [name](#name) | 200px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 150px |
| 4 | [estimatedvalue](#estimatedvalue) | 100px |
| 5 | [azt_probability](#azt_probability) | 100px |
| 6 | [estimatedclosedate](#estimatedclosedate) | 100px |
| 7 | [owningbusinessunit](#owningbusinessunit) | 100px |
| 8 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 9 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_leadsourceid](#azt_leadsourceid) | eq | {C9910CBF-EC69-EF11-BFE2-000D3A9A34C1} |
| [createdon](#createdon) | last-x-days | 30 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | Ascending |
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.57. Upcoming Internet Renewals

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 3 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 4 | [azt_probability](#azt_probability) | 100px |
| 5 | [estimatedvalue](#estimatedvalue) | 100px |
| 6 | [customerid](#customerid) | 150px |
| 7 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 9 | [ownerid](#ownerid) | 150px |
| 10 | [statuscode](#statuscode) | 100px |
| 11 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 12 | [address1_city](#address1_city) |  |
| 13 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [estimatedclosedate](#estimatedclosedate) | next-x-months | 3 |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.58. Won Opportunities This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 3 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualclosedate](#actualclosedate) | this-month |  |
| [statecode](#statecode) | eq | 1 |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.59. Won Opportunities This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [ownerid](#ownerid) | 100px |
| 2 | [createdon](#createdon) | 100px |
| 3 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualclosedate](#actualclosedate) | this-fiscal-period |  |
| [statecode](#statecode) | eq | 1 |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [ownerid](#ownerid) | Ascending |

### 3.60. Won Opportunities This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 3 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-week |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.61. Won Opportunities This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-year |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.62. Won Opportunities

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_opportunitynumber](#azt_opportunitynumber) | 85px |
| 3 | [azt_opportunityproductcategory](#azt_opportunityproductcategory) | 150px |
| 4 | [azt_opportunitytype](#azt_opportunitytype) | 125px |
| 5 | [actualclosedate](#actualclosedate) | 125px |
| 6 | [actualvalue](#actualvalue) | 100px |
| 7 | [customerid](#customerid) | 150px |
| 8 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_stateorprovince) | 100px |
| 9 | [a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city](#a_ef7baa35fe04e911a94d000d3a3b9f01address1_city) | 100px |
| 10 | [ownerid](#ownerid) | 150px |
| 11 | [statuscode](#statuscode) | 150px |
| 12 | [address1_stateorprovince](#address1_stateorprovince) |  |
| 13 | [address1_city](#address1_city) |  |
| 14 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualvalue](#actualvalue) | Descending |

### 3.63. Won Renewal Opps This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [actualclosedate](#actualclosedate) | 100px |
| 5 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 6 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-month |  |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.64. Won Renewal Opps This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [actualclosedate](#actualclosedate) | 100px |
| 5 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 6 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-fiscal-period |  |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.65. Won Renewal Opps This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 150px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | 150px |
| 4 | [actualclosedate](#actualclosedate) | 100px |
| 5 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 6 | [opportunityid](#opportunityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [actualclosedate](#actualclosedate) | this-year |  |
| [azt_opportunitytype](#azt_opportunitytype) | eq | 276530005 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | Ascending |

---

## 4. Chart Visualizations

Total charts: **39**

### 4.1. Closing This Fiscal Year

- **Visualization ID:** `{06B6016E-7942-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.2. Closing this Fiscal Quarter

- **Visualization ID:** `{E0C0D292-7942-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.3. Closing This Month

- **Visualization ID:** `{BCC5130E-7B42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.4. Initial/Add-on Opened This Month

- **Visualization ID:** `{E777E51F-7C42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.5. Initial/Add-on Opportunities Added Last Week

- **Visualization ID:** `{D1F0FB58-7D42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.6. Initial/Add-on Added This Week

- **Visualization ID:** `{64598626-7E42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.7. Invoiced but Unpaid in Last 90 Days

- **Visualization ID:** `{10B71290-7F42-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.8. Won This Fiscal Year

- **Visualization ID:** `{49CEA254-8042-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualvalue](#actualvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.9. Won This Year (No Renewals)

- **Visualization ID:** `{EA74DAAA-8042-EA11-A812-000D3A3B3EF9}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualvalue](#actualvalue) | sum | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [ownerid](#ownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.10. Opportunities Opened This Quarter By Rep

- **Visualization ID:** `{5EBA1132-A7E2-EB11-BACB-000D3A5AC826}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.11. Won Opportunities This Quarter By Rep

- **Visualization ID:** `{9EBD86E0-A7E2-EB11-BACB-000D3A5AC826}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.12. My Opportunities Created This Quarter

- **Visualization ID:** `{ECDDB271-66E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.13. My Opportunities Closing This Quarter

- **Visualization ID:** `{DEC70FB3-67E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.14. My Opportunities Won This Quarter

- **Visualization ID:** `{1781BA01-68E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.15. My Opportunities Created This Year By Quarter

- **Visualization ID:** `{32C03EC3-6CE2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdon](#createdon) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### 4.16. My Open Opportunities Created This Year By Quarter

- **Visualization ID:** `{F83F178E-6DE2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdon](#createdon) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### 4.17. My Won Opportunities This Year By Quarter

- **Visualization ID:** `{5D9A3811-6EE2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [actualclosedate](#actualclosedate) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### 4.18. Opportunities Created This Year By Owner

- **Visualization ID:** `{E8057C5A-86E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdon](#createdon) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### 4.19. Open Opportunities By Owner

- **Visualization ID:** `{67D2CBA1-86E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.20. Won Opportunities This Year By Owner

- **Visualization ID:** `{1854741E-87E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [actualclosedate](#actualclosedate) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### 4.21. Sales Pipeline

- **Visualization ID:** `{87293554-2482-DE11-9FF3-00155DA3B012}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedvalue](#estimatedvalue) | sum | sum_estimatedvalue |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [closeprobability](#closeprobability) | stepname |  |

### 4.22. Opportunities Opened This Month By Rep

- **Visualization ID:** `{7732E166-C001-EC11-94EF-002248047923}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.23. Opportunities Closing This Month

- **Visualization ID:** `{4B128E21-C101-EC11-94EF-002248047923}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | NumOppsOver70 |
| [azt_recordownerid](#azt_recordownerid) | count | NumOppsUnder70 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | RecordOwner |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | this-month |  |
| [closeprobability](#closeprobability) | ge | 70 |
| [statecode](#statecode) | eq | 0 |
| [estimatedclosedate](#estimatedclosedate) | this-month |  |
| [closeprobability](#closeprobability) | lt | 70 |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

### 4.24. Won Opportunities This Month

- **Visualization ID:** `{C3FCA470-C101-EC11-94EF-002248047923}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.25. Opportunities Opened This Week By Rep

- **Visualization ID:** `{872489E8-EF13-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.26. Opportunities Closing This Week By Rep

- **Visualization ID:** `{56BEF679-F013-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.27. Won Opportunities This Week

- **Visualization ID:** `{65FF74C9-F013-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.28. My Opportunities Created This Week

- **Visualization ID:** `{095B2FF4-F513-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.29. My Opportunities Closing This Week

- **Visualization ID:** `{0A8E4D4E-F613-EC11-B6E6-002248047CFA}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.30. My Open Opportunities Created This Month

- **Visualization ID:** `{C7A5DA94-D538-ED11-9DB0-002248296C23}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [createdby](#createdby) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [createdby](#createdby) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.31. My Opportunities Closing This Month

- **Visualization ID:** `{06205766-D638-ED11-9DB0-002248296C23}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.32. Open Renewal Opps Close Date Last Month

- **Visualization ID:** `{04DE3FDF-9E20-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.33. Open Renewal Opps Closing This Month

- **Visualization ID:** `{D381ADF2-9E20-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.34. Open Renewal Opps Closing Next Month

- **Visualization ID:** `{67F7F343-A020-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.35. Open Renewal Opps Closing Within 90 Days

- **Visualization ID:** `{B9AB34C9-A020-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.36. Open Renewal Opps 90 Days Past Due

- **Visualization ID:** `{1F029EE6-A020-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [estimatedclosedate](#estimatedclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.37. Won Renewal Opps This Month

- **Visualization ID:** `{D1DD4BE2-A220-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualclosedate](#actualclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.38. Won Renewal Opps This Quarter

- **Visualization ID:** `{CA7A8DF6-A220-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualclosedate](#actualclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.39. Won Renewal Opps This Year

- **Visualization ID:** `{1E457E0A-A320-EF11-840B-6045BDD5F34A}`
- **Entity:** opportunity

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [actualclosedate](#actualclosedate) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

---

## 5. Reports

Total reports referencing Opportunity: **0**

---

## 6. Dashboards

Total dashboards referencing Opportunity: **11**

### 6.1. Client Relations Renewal Dashboard

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

### 6.2. Executive Sales Measurement Pipeline

- **Form ID:** `{440de58f-6060-ef11-bfe2-7c1e52158f4e}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component6941e2b` | opportunity | Grid | `{CB6F754B-6060-EF11-BFE2-7C1E52158F4E}` | `` |
| `Component4ae8fb8` | opportunity | Grid | `{BEC25DEE-5E68-EF11-BFE2-000D3A9A34C1}` | `` |
| `Componentfb0a8b7` | lead | Grid | `{9D1294F7-AB6A-EF11-BFE2-000D3A18BCFA}` | `` |
| `Component94e0c6c` | opportunity | Grid | `{9AE8C70E-AD6A-EF11-BFE2-000D3A18BCFA}` | `` |
| `Component8866206` | opportunity | Grid | `{628942DC-AD6A-EF11-BFE2-000D3A18BCFA}` | `` |

### 6.3. Monthly Account Manager KPIs

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

### 6.4. My Annual KPIs

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

### 6.5. My Monthly KPI's

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

### 6.6. My Pipeline Dashboard

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

### 6.7. My Quarterly KPIs

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

### 6.8. My Weekly KPIs

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

### 6.9. Quarterly Account Manager KPIs

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

### 6.10. Sales Activity Social Dashboard

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

### 6.11. Weekly Account Manager KPIs

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

## 7. Workflows

Total workflows referencing Opportunity: **70**

### 7.1. 0ChangeQuoteRecordOwner

- **File:** `0ChangeQuoteRecordOwner-938FE262-FF96-42CB-8332-50B6A947A533.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.2. 0EngagementNames

- **File:** `0EngagementNames-BC419DA7-86F1-43E4-88B5-509514704A0C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#name)

### 7.3. AccountAuto-Assign

- **File:** `AccountAuto-Assign-6DE252A4-C0D8-4C6B-800E-3985440C88D1.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`

### 7.4. AllocationsAssigntoTeam

- **File:** `AllocationsAssigntoTeam-B7D19816-C216-4C9D-81B7-9FE73CB2D066.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_allocatedlicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.5. AppointmentAuto-Assign

- **File:** `AppointmentAuto-Assign-1A553A9D-514D-42CA-A9AE-73FEED04E1E5.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Appointment

**Fields Read:**

- [opportunityid](#opportunityid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.6. BatchConverttoLead

- **File:** `BatchConverttoLead-CC0F2DBB-B8CB-4B06-B891-DB6D97252DB8.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)
- [opportunityid](#opportunityid)
- [ownerid](#ownerid)
- [parentcontactid](#parentcontactid)

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)
- [parentaccountid](#parentaccountid)
- [statecode](#statecode)

### 7.7. BatchCreateEngagements

- **File:** `BatchCreateEngagements-CC9CDFC6-4BC9-4635-B786-0C7BE2C34344.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)
- [statuscode](#statuscode)

### 7.8. BatchLooseOpportunities

- **File:** `BatchLooseOpportunities-BFF14F2D-338D-4CBD-B2CE-C0907E02E6C7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

**Fields Written:**

- [actualvalue](#actualvalue)
- [name](#name)

### 7.9. BatchOpportunityTransfer

- **File:** `BatchOpportunityTransfer-744FEB80-2251-4252-875E-ED9958CB448A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [!process_custom_attribute_url_](#process_custom_attribute_url_)
- [azt_recordownerid](#azt_recordownerid)
- [name](#name)
- [opportunityid](#opportunityid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)
- [name](#name)

### 7.10. BulkChangeLeadSource

- **File:** `BulkChangeLeadSource-95E84234-8EE8-433E-B68A-78A0837A91CE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)

### 7.11. CasePendingAssignmentNotification

- **File:** `CasePendingAssignmentNotification-177DE8B3-E0C3-4F1C-A7B5-DA84B3629AED.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#customerid)
- [ownerid](#ownerid)

### 7.12. CaseRecordOwner

- **File:** `CaseRecordOwner-E2135799-C146-4E0B-A0A5-F9917895B23E.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#customerid)
- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.13. CaseRecordOwnerAssign

- **File:** `CaseRecordOwnerAssign-02EE1A9D-1658-4013-BF63-9C0E5C65AAD0.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#customerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.14. CaseRecordOwnerAssignmentNotification

- **File:** `CaseRecordOwnerAssignmentNotification-2F6035E6-1FBC-476B-9C97-4554E8360B7C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [customerid](#customerid)

### 7.15. CaseResolutionNotificationEmail

- **File:** `CaseResolutionNotificationEmail-734E721F-7454-4437-8BAC-8B20F496DF12.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Read:**

- [statecode](#statecode)

### 7.16. CloneAndDeleteQuote

- **File:** `CloneAndDeleteQuote-1D87A694-5A08-4C93-9925-447BB4FE7DA6.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_historicalowner](#azt_historicalowner)
- [customerid](#customerid)
- [ownerid](#ownerid)
- [pricelevelid](#pricelevelid)

### 7.17. CloneCommissionPayment

- **File:** `CloneCommissionPayment-7E83F6F0-D101-4045-B686-0B6C658CC9A2.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_commissionpayment

**Fields Written:**

- [ownerid](#ownerid)

### 7.18. CloneLicense

- **File:** `CloneLicense-49354120-2D2D-4DED-8C24-4ACA5F6D82D9.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.19. CloneOpportunity

- **File:** `CloneOpportunity-1A3FF4B3-79FD-420C-8A10-375E8892CA44.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_accountclassification](#azt_accountclassification)
- [azt_deliverytype](#azt_deliverytype)
- [azt_fundingsource](#azt_fundingsource)
- [azt_historicalowner](#azt_historicalowner)
- [azt_internalaztecnotes](#azt_internalaztecnotes)
- [azt_opportunityproductcategory](#azt_opportunityproductcategory)
- [azt_opportunitytype](#azt_opportunitytype)
- [azt_pipelinestage](#azt_pipelinestage)
- [azt_probability](#azt_probability)
- [azt_recordownerid](#azt_recordownerid)
- [budgetamount](#budgetamount)
- [budgetstatus](#budgetstatus)
- [closeprobability](#closeprobability)
- [currentsituation](#currentsituation)
- [customerid](#customerid)
- [customerpainpoints](#customerpainpoints)
- [description](#description)
- [discountpercentage](#discountpercentage)
- [emailaddress](#emailaddress)
- [estimatedvalue](#estimatedvalue)
- [initialcommunication](#initialcommunication)
- [name](#name)
- [need](#need)
- [opportunityid](#opportunityid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [pricelevelid](#pricelevelid)
- [proposedsolution](#proposedsolution)
- [purchaseprocess](#purchaseprocess)
- [purchasetimeframe](#purchasetimeframe)
- [qualificationcomments](#qualificationcomments)
- [quotecomments](#quotecomments)

**Fields Written:**

- [azt_accountclassification](#azt_accountclassification)
- [azt_committoestimatedclose](#azt_committoestimatedclose)
- [azt_deliverytype](#azt_deliverytype)
- [azt_fundingsource](#azt_fundingsource)
- [azt_historicalowner](#azt_historicalowner)
- [azt_internalaztecnotes](#azt_internalaztecnotes)
- [azt_opportunityproductcategory](#azt_opportunityproductcategory)
- [azt_opportunitytype](#azt_opportunitytype)
- [azt_parentopportunityid](#azt_parentopportunityid)
- [azt_pipelinestage](#azt_pipelinestage)
- [azt_probability](#azt_probability)
- [azt_recordownerid](#azt_recordownerid)
- [budgetamount](#budgetamount)
- [budgetstatus](#budgetstatus)
- [captureproposalfeedback](#captureproposalfeedback)
- [closeprobability](#closeprobability)
- [completefinalproposal](#completefinalproposal)
- [completeinternalreview](#completeinternalreview)
- [confirminterest](#confirminterest)
- [currentsituation](#currentsituation)
- [customerid](#customerid)
- [customerneed](#customerneed)
- [customerpainpoints](#customerpainpoints)
- [decisionmaker](#decisionmaker)
- [description](#description)
- [developproposal](#developproposal)
- [discountpercentage](#discountpercentage)
- [emailaddress](#emailaddress)
- [estimatedvalue](#estimatedvalue)
- [evaluatefit](#evaluatefit)
- [filedebrief](#filedebrief)
- [identifycompetitors](#identifycompetitors)
- [identifycustomercontacts](#identifycustomercontacts)
- [identifypursuitteam](#identifypursuitteam)
- [initialcommunication](#initialcommunication)
- [isrevenuesystemcalculated](#isrevenuesystemcalculated)
- [name](#name)
- [need](#need)
- [opportunityratingcode](#opportunityratingcode)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [presentfinalproposal](#presentfinalproposal)
- [presentproposal](#presentproposal)
- [pricelevelid](#pricelevelid)
- [prioritycode](#prioritycode)
- [proposedsolution](#proposedsolution)
- [purchaseprocess](#purchaseprocess)
- [purchasetimeframe](#purchasetimeframe)
- [pursuitdecision](#pursuitdecision)
- [qualificationcomments](#qualificationcomments)
- [quotecomments](#quotecomments)
- [resolvefeedback](#resolvefeedback)
- [salesstagecode](#salesstagecode)
- [sendthankyounote](#sendthankyounote)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.20. CloneOrder

- **File:** `CloneOrder-D2A6AD48-A603-4150-BC84-72092AFB3D79.xaml`
- **Entity References:** opportunity
- **Primary Entity:** SalesOrder

**Fields Read:**

- [name](#name)

**Fields Written:**

- [customerid](#customerid)
- [pricelevelid](#pricelevelid)
- [statecode](#statecode)
- [statuscode](#statuscode)

### 7.21. ContactAuto-Assign

- **File:** `ContactAuto-Assign-25759C22-AE58-4CC7-81E1-9BBF37E76F3E.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Contact

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`
- `AztecPlugins.GetAcctTeamOwned`

### 7.22. CreateLeadFromLeadGen

- **File:** `CreateLeadFromLeadGen-2EA14729-4B62-4F91-95FA-76D258DA0831.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Read:**

- [name](#name)

**Fields Written:**

- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [statecode](#statecode)

### 7.23. CreateLeadfromAccount

- **File:** `CreateLeadfromAccount-B5E04C1C-B038-4018-B602-645B1E766884.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [statecode](#statecode)

### 7.24. CreateSoftwareLicense

- **File:** `CreateSoftwareLicense-82C11935-B2A2-4E45-94B4-F0EEA6641A08.xaml`
- **Entity References:** opportunity
- **Primary Entity:** SalesOrder

**Fields Written:**

- [customerid](#customerid)

### 7.25. CustomLeadCreation

- **File:** `CustomLeadCreation-B26AC2BB-4660-4A50-9229-AD056DE0D9E1.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)
- [opportunityid](#opportunityid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)
- [statecode](#statecode)

### 7.26. EmailDeleteSendQuoteDrafts

- **File:** `EmailDeleteSendQuoteDrafts-ED77962D-F57D-4F2F-A580-1F5D27E1280C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#statuscode)

### 7.27. EmailRemoveUnsentEmails

- **File:** `EmailRemoveUnsentEmails-2F1954B7-77B4-4D54-AA84-DBB10DFB6A71.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#statuscode)

### 7.28. EngagementRecordOwner

- **File:** `EngagementRecordOwner-00BE88CF-37E2-46ED-951B-A553329BC127.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.29. EngagementRecordOwnerTeam

- **File:** `EngagementRecordOwnerTeam-190EE5B4-5775-4B9D-BFD7-FB769C19977A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.30. FSRLeadDistibutionNotification

- **File:** `FSRLeadDistibutionNotification-2D276CE9-54BF-4703-A56C-933E5C57F3C7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [ownerid](#ownerid)

### 7.31. InvoiceRecordOwner

- **File:** `InvoiceRecordOwner-C59ED476-F5C4-47B7-BD33-E88881D2B5EE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Invoice

**Fields Read:**

- [customerid](#customerid)
- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.32. LeadAssignment

- **File:** `LeadAssignment-5FC23C73-5B6B-423C-8721-57EDA4553E31.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [azt_leadsourceid](#azt_leadsourceid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.33. LeadPopulateFirstNamefromContact

- **File:** `LeadPopulateFirstNamefromContact-62D3EE54-156C-4BEB-8AC6-5E59E788DFB6.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [parentcontactid](#parentcontactid)

### 7.34. LeadQualifyDisqualifyDate

- **File:** `LeadQualifyDisqualifyDate-4DF6EBF4-0F22-4433-AB4F-A241C91F8B5A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [statecode](#statecode)

### 7.35. LeadSourceChange

- **File:** `LeadSourceChange-2F1F8085-9B50-4FE8-A756-20DAF80158A8.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)

### 7.36. LeadTempPopulatefirstlastnamefromcontact

- **File:** `LeadTempPopulatefirstlastnamefromcontact-E1A85925-A97D-44F9-BB18-4CA0F569A49C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [parentcontactid](#parentcontactid)

### 7.37. NewFSRLeadNotification

- **File:** `NewFSRLeadNotification-53E6AF89-E489-4977-8D9F-1579FF72FAC5.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [name](#name)

### 7.38. OpportunityAuditRemoval

- **File:** `OpportunityAuditRemoval-DB05BF90-221B-4B58-8AA0-D1A0799EA0A1.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [opportunityid](#opportunityid)
- [statecode](#statecode)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.OppAuditRemoval`

### 7.39. OpportunityRecordOwner

- **File:** `OpportunityRecordOwner-B0889237-722A-47CC-B102-D507B14FED98.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.40. OpportunityRecordOwnerTeam

- **File:** `OpportunityRecordOwnerTeam-7F60084D-807B-43D1-ACED-B0CC90F02F02.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [opportunityid](#opportunityid)

### 7.41. OpportunitySalesProcessAdvanceBPF

- **File:** `OpportunitySalesProcessAdvanceBPF-0BDB4648-C002-4184-ABA1-FDEB77B6A7AA.xaml`
- **Entity References:** opportunity
- **Primary Entity:** OpportunitySalesProcess

**Fields Written:**

- [azt_salesstage](#azt_salesstage)

### 7.42. OrderRecordOwner

- **File:** `OrderRecordOwner-701C3E67-4733-423C-BC31-5C846B542B76.xaml`
- **Entity References:** opportunity
- **Primary Entity:** SalesOrder

**Fields Read:**

- [customerid](#customerid)
- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.43. PhonecallAuto-Assign

- **File:** `PhonecallAuto-Assign-D7FD43A4-5AFF-4929-BD37-A1917C4F2391.xaml`
- **Entity References:** opportunity
- **Primary Entity:** PhoneCall

**Fields Read:**

- [opportunityid](#opportunityid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.44. PrintPurchaseAssigntoTeam

- **File:** `PrintPurchaseAssigntoTeam-9620B3F1-4852-4FFA-8FA7-09615D8CCAFD.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_printpurchase

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.45. QualifyLead

- **File:** `QualifyLead-F6899272-F476-48C4-B703-D5ACDD9EDFF7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_committoestimatedclose](#azt_committoestimatedclose)
- [captureproposalfeedback](#captureproposalfeedback)
- [completefinalproposal](#completefinalproposal)
- [completeinternalreview](#completeinternalreview)
- [confirminterest](#confirminterest)
- [customerid](#customerid)
- [decisionmaker](#decisionmaker)
- [developproposal](#developproposal)
- [evaluatefit](#evaluatefit)
- [filedebrief](#filedebrief)
- [identifycompetitors](#identifycompetitors)
- [identifycustomercontacts](#identifycustomercontacts)
- [identifypursuitteam](#identifypursuitteam)
- [isrevenuesystemcalculated](#isrevenuesystemcalculated)
- [name](#name)
- [opportunityratingcode](#opportunityratingcode)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [presentfinalproposal](#presentfinalproposal)
- [presentproposal](#presentproposal)
- [pricelevelid](#pricelevelid)
- [prioritycode](#prioritycode)
- [pursuitdecision](#pursuitdecision)
- [resolvefeedback](#resolvefeedback)
- [salesstagecode](#salesstagecode)
- [sendthankyounote](#sendthankyounote)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.46. QuoteRecordOwner

- **File:** `QuoteRecordOwner-C5266A8C-E23D-41C4-B51F-3A637538DDBF.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [customerid](#customerid)
- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.47. QuoteRecordOwnerTeam

- **File:** `QuoteRecordOwnerTeam-7ACFAD91-65CC-4C8D-8A3E-673373DEA880.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.48. RenameEngagements

- **File:** `RenameEngagements-9D4DC906-B3F2-498A-AC17-7D302597E96C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#name)

### 7.49. SendQuote

- **File:** `SendQuote-FF6FE214-20D6-4541-AEC6-BD5D18258481.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.50. SetDefaultPriceListonOpportunities

- **File:** `SetDefaultPriceListonOpportunities-6C392B18-AF72-4940-8C5C-D8BE3658E03A.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Written:**

- [pricelevelid](#pricelevelid)

### 7.51. SetLeadTemperature

- **File:** `SetLeadTemperature-91BC905B-86CD-4317-BC84-E50EE444C775.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Read:**

- [azt_leadsourceid](#azt_leadsourceid)

### 7.52. SoftwareLicenseAssigntoTeam

- **File:** `SoftwareLicenseAssigntoTeam-2CFFBE82-9E25-47FD-A201-E6DB0C220DDE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.53. SoftwareLicenseCreateEngagement

- **File:** `SoftwareLicenseCreateEngagement-ABFE722A-CAC3-4A3B-AF5C-419EA2CE9CBD.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [statuscode](#statuscode)

### 7.54. SoftwareLicenseSetOwner

- **File:** `SoftwareLicenseSetOwner-438596B2-A87C-4F1E-AC53-3B3197DEF67C.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.55. TaskAuto-Assign

- **File:** `TaskAuto-Assign-89E60667-3F7F-4ADD-8274-57C2BE011059.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Task

**Fields Read:**

- [opportunityid](#opportunityid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.56. TaskCreateReorderLead

- **File:** `TaskCreateReorderLead-3193EB56-8E56-46A3-B079-A7CFD1CE90B7.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Task

**Fields Read:**

- [name](#name)
- [opportunityid](#opportunityid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)
- [azt_recordownerid](#azt_recordownerid)
- [customerid](#customerid)
- [ownerid](#ownerid)
- [statecode](#statecode)

### 7.57. TempSetDefaultPricelist

- **File:** `TempSetDefaultPricelist-D46A3A4C-18D7-4686-B933-D78929185E3D.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Written:**

- [pricelevelid](#pricelevelid)

### 7.58. WonOpportunityEmail

- **File:** `WonOpportunityEmail-DB2872A0-18C2-4157-B6BD-480230C97D32.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [!process_custom_attribute_url_](#process_custom_attribute_url_)
- [azt_recordownerid](#azt_recordownerid)
- [name](#name)
- [opportunityid](#opportunityid)
- [statecode](#statecode)

### 7.59. WorkforceAccountAuto-assign

- **File:** `WorkforceAccountAuto-assign-1AD2C544-E6F9-4FC7-AA17-810AEB8939C2.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.60. WorkforceAppointmentAuto-Assign

- **File:** `WorkforceAppointmentAuto-Assign-803829FB-077B-4F0B-B238-105814F5B202.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.61. WorkforceCaseAuto-assign

- **File:** `WorkforceCaseAuto-assign-24BA0A9C-F8BD-45CB-A5F6-6DCE42CD998F.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.62. WorkforceContactAuto-assign

- **File:** `WorkforceContactAuto-assign-65B65E23-A8F5-46DB-A35A-C5DC8542B6AE.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.63. WorkforceEngagementAuto-assign

- **File:** `WorkforceEngagementAuto-assign-DA5CDD7F-2A3B-4A0A-861D-75305D10254E.xaml`
- **Entity References:** opportunity
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.64. WorkforceLeadAuto-Assign

- **File:** `WorkforceLeadAuto-Assign-E5A4054C-5F7E-478C-87E3-529C1EEAB0DC.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.65. WorkforceOpportunityAuto-assign

- **File:** `WorkforceOpportunityAuto-assign-7D379FBE-C672-41EB-90A3-A80451C62533.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Opportunity

**Fields Read:**

- [createdby](#createdby)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.66. WorkforcePhone-callAuto-assign

- **File:** `WorkforcePhone-callAuto-assign-BE1CB211-7C3C-4E39-8913-2DFCE7EDFC85.xaml`
- **Entity References:** opportunity
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.67. WorkforceQuoteAuto-assign

- **File:** `WorkforceQuoteAuto-assign-E64BB2BB-5CD6-4327-AB1B-BF8C9D4D2385.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.68. iGradAppointmentAuto-Assign

- **File:** `iGradAppointmentAuto-Assign-CE88A0C4-AA60-44F4-B33D-B57FB8279CCF.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.69. iGradCaseAuto-Assign

- **File:** `iGradCaseAuto-Assign-CAF5021E-07E1-4689-92D5-FC59E9F30F78.xaml`
- **Entity References:** opportunity
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.70. iGradPhone-callAuto-assign

- **File:** `iGradPhone-callAuto-assign-04423D55-3225-429E-BAC6-8DD37BC53F1B.xaml`
- **Entity References:** opportunity
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

---

## 8. JavaScript Web Resources

Total JS files referencing Opportunity fields: **15**

### 8.1. azt_accountlibrary

- **File:** `azt_accountlibraryF30D2BCC-3AFA-E811-A983-000D3A1A9151`

**Per-Function Field Usage:**

`createLead`:

| Field | Operations |
|-------|-----------|
| [name](#name) | read |

`createNewLead`:

| Field | Operations |
|-------|-----------|
| [name](#name) | read |

`parentAccountSpend`:

| Field | Operations |
|-------|-----------|
| [parentaccountid](#parentaccountid) | read, UI |

### 8.2. azt_addresslibrary

- **File:** `azt_addresslibrary34ACDB9B-C570-EB11-A812-00224809A7CD`

**Per-Function Field Usage:**

`addAddress`:

| Field | Operations |
|-------|-----------|
| [name](#name) | read |

### 8.3. azt_caselibrary

- **File:** `azt_caselibraryD1BC3A04-FA9F-EC11-B400-00224824F1A0`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.4. azt_createsoftwarelicense

- **File:** `azt_createsoftwarelicense1929C51B-2D25-E911-A985-000D3A1A9151`

**Per-Function Field Usage:**

`CreateLicense`:

| Field | Operations |
|-------|-----------|
| [customerid](#customerid) | read |

### 8.5. azt_engagementlibrary

- **File:** `azt_engagementlibraryE672CD7D-C50C-E911-A97C-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.6. azt_expensereportlibrary

- **File:** `azt_expensereportlibraryE56605D3-7B07-E911-A977-000D3A1A9FA9`

**Per-Function Field Usage:**

`corporateApprove`:

| Field | Operations |
|-------|-----------|
| [statuscode](#statuscode) | UI |

`getCanApprove`:

| Field | Operations |
|-------|-----------|
| [statuscode](#statuscode) | UI |

`onLoad`:

| Field | Operations |
|-------|-----------|
| [statuscode](#statuscode) | read, UI |

`reject`:

| Field | Operations |
|-------|-----------|
| [statuscode](#statuscode) | write |

`setManagerApproval`:

| Field | Operations |
|-------|-----------|
| [statuscode](#statuscode) | UI |

`setPaid`:

| Field | Operations |
|-------|-----------|
| [statuscode](#statuscode) | UI |

`submit`:

| Field | Operations |
|-------|-----------|
| [statuscode](#statuscode) | write |

### 8.7. azt_invoicelibrary

- **File:** `azt_invoicelibrary25F065BD-0B9E-EB11-B1AC-000D3A378944`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.8. azt_leadlibrary

- **File:** `azt_leadlibraryD08FB550-34A2-EB11-B1AC-002248093E98`

**Per-Function Field Usage:**

`getAccountPopulated`:

| Field | Operations |
|-------|-----------|
| [parentaccountid](#parentaccountid) | read |

`onSave`:

| Field | Operations |
|-------|-----------|
| [ownerid](#ownerid) | read |

`qualifyLead`:

| Field | Operations |
|-------|-----------|
| [parentaccountid](#parentaccountid) | read |

### 8.9. azt_opportunityclone

- **File:** `azt_opportunityclone9EADDE70-C221-E911-A94F-000D3A3B9B3D`

**Per-Function Field Usage:**

`cloneOpportunity`:

| Field | Operations |
|-------|-----------|
| [estimatedclosedate](#estimatedclosedate) | read |

### 8.10. azt_opportunitylibrary

- **File:** `azt_opportunitylibrary43000452-0710-E911-A980-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_committoestimatedclose](#azt_committoestimatedclose) | UI |
| [azt_expectedrenewalvalue](#azt_expectedrenewalvalue) | read, UI |
| [azt_lastmodifiedbyid](#azt_lastmodifiedbyid) | write |
| [azt_recordownerid](#azt_recordownerid) | UI |
| [pricelevelid](#pricelevelid) | write |

`setFreightAmt`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#azt_requestedfreightamt) | read |

`success`:

| Field | Operations |
|-------|-----------|
| [pricelevelid](#pricelevelid) | write |

### 8.11. azt_opportunitytrackdiscount

- **File:** `azt_opportunitytrackdiscount8AAC767D-5D0E-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`trackDiscount`:

| Field | Operations |
|-------|-----------|
| [name](#name) | read |

### 8.12. azt_orderlibrary

- **File:** `azt_orderlibrary2892D28D-D5C4-EB11-BACC-00224809B8F2`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.13. azt_productdiscountlibrary

- **File:** `azt_productdiscountlibraryBF6468B0-3230-E911-A950-000D3A3B9CD8`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [ownerid](#ownerid) | Yes |  |  |

### 8.14. azt_quotelibrary

- **File:** `azt_quotelibrary117BF74F-580A-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`setFreight`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#azt_requestedfreightamt) | read |

### 8.15. azt_sendquote

- **File:** `azt_sendquote0A31A45C-E217-E911-A97D-000D3A1A9FA9`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [name](#name) | Yes |  |  |

---

## 9. Formulas and Rollups

Total formulas for Opportunity: **10**

### azt_addonopportunitytotal

- **File:** `opportunity-azt_addonopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_dayssincecreated

- **File:** `opportunity-azt_dayssincecreated.xaml`
- **Type:** Calculated (Date Diff)

**Source Fields:**

| Field | Entity |
|-------|--------|
| [conditionbranchstep2_1](#conditionbranchstep2_1) | opportunity |
| [setattributevaluestep4_1](#setattributevaluestep4_1) | opportunity |
| [setattributevaluestep4_2](#setattributevaluestep4_2) | opportunity |
| [setattributevaluestep4_3](#setattributevaluestep4_3) | opportunity |
| [setattributevaluestep4_4](#setattributevaluestep4_4) | opportunity |
| [setattributevaluestep4_5](#setattributevaluestep4_5) | opportunity |
| [createdon](#createdon) | opportunity |

### azt_dayssinceprobabilitychanged

- **File:** `opportunity-azt_dayssinceprobabilitychanged.xaml`
- **Type:** Calculated (Date Diff)

**Source Fields:**

| Field | Entity |
|-------|--------|
| [conditionbranchstep2_1](#conditionbranchstep2_1) | opportunity |
| [setattributevaluestep4_1](#setattributevaluestep4_1) | opportunity |
| [setattributevaluestep4_2](#setattributevaluestep4_2) | opportunity |
| [setattributevaluestep4_3](#setattributevaluestep4_3) | opportunity |
| [setattributevaluestep4_4](#setattributevaluestep4_4) | opportunity |
| [setattributevaluestep4_5](#setattributevaluestep4_5) | opportunity |
| [azt_probabilitychangedon](#azt_probabilitychangedon) | opportunity |

### azt_discretionarydiscount

- **File:** `opportunity-azt_discretionarydiscount.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** azt_productdiscount

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_approvalstatus | azt_productdiscount |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| azt_discountamount | azt_productdiscount |

### azt_initialopportunitytotal

- **File:** `opportunity-azt_initialopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_otheropportunitytotal

- **File:** `opportunity-azt_otheropportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_pilotopportunitytotal

- **File:** `opportunity-azt_pilotopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_printopportunitytotal

- **File:** `opportunity-azt_printopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_renewalopportunitytotal

- **File:** `opportunity-azt_renewalopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

### azt_winbackopportunitytotal

- **File:** `opportunity-azt_winbackopportunitytotal.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityproduct

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | opportunity |
| [rolluprulestep1_2](#rolluprulestep1_2) | opportunity |
| [rolluprulestep1_3](#rolluprulestep1_3) | opportunity |
| azt_licensetype | opportunityproduct |
| [rolluprulestep1_4](#rolluprulestep1_4) | opportunity |
| [rolluprulestep1_5](#rolluprulestep1_5) | opportunity |
| extendedamount | opportunityproduct |

---

## 10. Plugin Source Code Analysis

Total plugins analyzed: **81**

### 10.1. AccountAutoAssign

- **File:** `AccountAutoAssign.cs`
- **Message:** Assign (inferred)

**Fields Read:**

- [businessunitid](#businessunitid)
- [teamid](#teamid)

**Fields Filtered:**

- [azt_stateabbreviation](#azt_stateabbreviation)
- [name](#name)
- [teamtype](#teamtype)

**Fields Sorted:**

- [name](#name)

### 10.2. AccountLeadGen

- **File:** `AccountLeadGen.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [accountid](#accountid)
- [azt_evaluate](#azt_evaluate)
- [azt_monthstofilteron](#azt_monthstofilteron)
- [invline.productid](#invlineproductid)
- [prod.productid](#prodproductid)
- [productid](#productid)

**Fields Written:**

- [accountid](#accountid)
- [productid](#productid)

**Fields Filtered:**

- [azt_accountleadgenerationid](#azt_accountleadgenerationid)
- [createdon](#createdon)
- [productid](#productid)
- [statecode](#statecode)

**Fields Joined:**

- [accountid](#accountid)
- [customerid](#customerid)
- [invoiceid](#invoiceid)
- [productid](#productid)

**Pre/Post Image Fields:**

- [azt_evaluate](#azt_evaluate)
- [azt_monthstofilteron](#azt_monthstofilteron)

**Cross-Entity References (AliasedValue):**

| Alias | Field | Operation |
|-------|-------|-----------|
| Prod | productid | Read |
| Prod | productid | Read |
| InvLine | productid | Read |

### 10.3. AccountLeadGenAssociate

- **File:** `AccountLeadGenAssociate.cs`
- **Target entity:** azt_accountleadgeneration
- **Message:** Associate

**Fields Read:**

- [azt_accountleadgenerationid](#azt_accountleadgenerationid)
- [azt_name](#azt_name)

**Fields Written:**

- [accountid](#accountid)
- [azt_accountleadgenname](#azt_accountleadgenname)

**Fields Filtered:**

- [azt_accountleadgenerationid](#azt_accountleadgenerationid)

**Fields Sorted:**

- [azt_name](#azt_name)

### 10.4. AccountReassignmentShareRecords

- **File:** `AccountReassignmentShareRecords.cs`
- **Message:** GrantAccess (inferred)

**Fields Read:**

- [activityid](#activityid)
- [activitytypecode](#activitytypecode)
- [azt_accountid](#azt_accountid)
- [azt_customertrainingid](#azt_customertrainingid)
- [azt_engagementid](#azt_engagementid)
- [azt_softwarelicenseid](#azt_softwarelicenseid)
- [azt_trainingid](#azt_trainingid)
- [incidentid](#incidentid)
- [opportunityid](#opportunityid)
- [ownerid](#ownerid)

**Fields Filtered:**

- [azt_accountid](#azt_accountid)
- [customerid](#customerid)
- [regardingobjectid](#regardingobjectid)

**Fields Sorted:**

- [azt_accountid](#azt_accountid)
- [azt_name](#azt_name)
- [azt_trainingid](#azt_trainingid)
- [modifiedon](#modifiedon)
- [name](#name)

### 10.5. AccountTypeSet

- **File:** `AccountTypeSet.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [azt_nonsaasstatus](#azt_nonsaasstatus)
- [azt_saasstatus](#azt_saasstatus)

**Fields Written:**

- [accountid](#accountid)
- [azt_accounttype](#azt_accounttype)

**Pre/Post Image Fields:**

- [azt_nonsaasstatus](#azt_nonsaasstatus)
- [azt_saasstatus](#azt_saasstatus)

### 10.6. ActivateOrReviseQuote

- **File:** `ActivateOrReviseQuote.cs`
- **Message:** Create

**Fields Read:**

- [quotedetailid](#quotedetailid)

**Fields Filtered:**

- [azt_quoteproductid](#azt_quoteproductid)
- [quoteid](#quoteid)

### 10.7. ActivitiesCreatedDueDatesInPast

- **File:** `ActivitiesCreatedDueDatesInPast.cs`
- **Message:** Create

**Fields Read:**

- [scheduledend](#scheduledend)

### 10.8. ActivityCloseForceRecordOwner

- **File:** `ActivityCloseForceRecordOwner.cs`
- **Message:** Update
- **Entity Images:** Pre

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [statecode](#statecode)

### 10.9. ActivityRegardingGetState

- **File:** `ActivityRegardingGetState.cs`

**Fields Read:**

- [activityid](#activityid)
- [activitytypecode](#activitytypecode)
- [address1_stateorprovince](#address1_stateorprovince)
- [azt_accountid](#azt_accountid)
- [customerid](#customerid)
- [ownerid](#ownerid)
- [parentcustomerid](#parentcustomerid)
- [regardingobjectid](#regardingobjectid)

### 10.10. AddressSearchCleanupFields

- **File:** `AddressSearchCleanupFields.cs`
- **Message:** Create

**Fields Read:**

- [azt_addresssearch](#azt_addresssearch)
- [azt_addresssearch2](#azt_addresssearch2)

**Fields Written:**

- [azt_addresssearch](#azt_addresssearch)
- [azt_addresssearch2](#azt_addresssearch2)

### 10.11. AllocationValidation

- **File:** `AllocationValidation.cs`
- **Message:** Create
- **Entity Images:** Post

**Fields Read:**

- [azt_allocationtype](#azt_allocationtype)
- [azt_concurrentusers](#azt_concurrentusers)
- [azt_numberoflicenses](#azt_numberoflicenses)
- [azt_softwarelicenseid](#azt_softwarelicenseid)

**Fields Filtered:**

- [azt_softwarelicenseid](#azt_softwarelicenseid)
- [statecode](#statecode)

### 10.12. AutoAssignStateAbb

- **File:** `AutoAssignStateAbb.cs`
- **Target entity:** customeraddress
- **Message:** Create

**Fields Read:**

- [address1_stateorprovince](#address1_stateorprovince)
- [stateorprovince](#stateorprovince)

**Fields Written:**

- [address1_stateorprovince](#address1_stateorprovince)
- [stateorprovince](#stateorprovince)

### 10.13. AutoNumber

- **File:** `AutoNumber.cs`
- **Message:** Create

**Fields Read:**

- [azt_autonumberid](#azt_autonumberid)
- [azt_currentnumber](#azt_currentnumber)
- [azt_fieldtoautonumber](#azt_fieldtoautonumber)
- [azt_prefix](#azt_prefix)
- [azt_prefixhasseparator](#azt_prefixhasseparator)
- [azt_prefixseparator](#azt_prefixseparator)
- [azt_prefixseparatorisspace](#azt_prefixseparatorisspace)
- [azt_suffix](#azt_suffix)
- [azt_suffixhasseparator](#azt_suffixhasseparator)
- [azt_suffixseparator](#azt_suffixseparator)
- [azt_suffixseparatorisspace](#azt_suffixseparatorisspace)

**Fields Written:**

- [azt_autonumberid](#azt_autonumberid)
- [azt_currentnumber](#azt_currentnumber)

**Fields Filtered:**

- [azt_name](#azt_name)

### 10.14. CaseAudit

- **File:** `CaseAudit.cs`
- **Message:** Create
- **Entity Images:** Pre

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_caseid](#azt_caseid)
- [azt_newownerid](#azt_newownerid)
- [azt_previousownerid](#azt_previousownerid)

### 10.15. CaseClose

- **File:** `CaseClose.cs`
- **Message:** SetState

**Fields Read:**

- [azt_resolvedbyid](#azt_resolvedbyid)

**Fields Written:**

- [adx_resolutiondate](#adx_resolutiondate)
- [azt_resolvedbyid](#azt_resolvedbyid)
- [incidentid](#incidentid)

### 10.16. ChangeLicenseType

- **File:** `ChangeLicenseType.cs`

**Fields Read:**

- [opportunityproductid](#opportunityproductid)

**Fields Written:**

- [azt_licensetype](#azt_licensetype)
- [opportunityproductid](#opportunityproductid)

**Fields Filtered:**

- [opportunityid](#opportunityid)

**Fields Sorted:**

- [createdon](#createdon)

### 10.17. CloneExpenseLine

- **File:** `CloneExpenseLine.cs`
- **Message:** Create

**Fields Read:**

- [azt_customerid](#azt_customerid)
- [azt_description](#azt_description)
- [azt_expenseamount](#azt_expenseamount)
- [azt_expensereportid](#azt_expensereportid)
- [azt_expensetype](#azt_expensetype)
- [azt_mileage](#azt_mileage)
- [azt_name](#azt_name)
- [azt_reasonforexpense](#azt_reasonforexpense)
- [transactioncurrencyid](#transactioncurrencyid)

**Fields Written:**

- [azt_customerid](#azt_customerid)
- [azt_description](#azt_description)
- [azt_expenseamount](#azt_expenseamount)
- [azt_expensereportid](#azt_expensereportid)
- [azt_expensetype](#azt_expensetype)
- [azt_mileage](#azt_mileage)
- [azt_reasonforexpense](#azt_reasonforexpense)
- [transactioncurrencyid](#transactioncurrencyid)

**Fields Filtered:**

- [azt_expenseid](#azt_expenseid)

### 10.18. CompGoalCreate

- **File:** `CompGoalCreate.cs`
- **Message:** Create

**Fields Read:**

- [azt_invoiceid](#azt_invoiceid)
- [invoicenumber](#invoicenumber)
- [salesorderid](#salesorderid)

**Fields Written:**

- [azt_name](#azt_name)
- [azt_orderid](#azt_orderid)

### 10.19. ContactSetConnectionRole

- **File:** `ContactSetConnectionRole.cs`
- **Message:** azt_ContactSetConnectionRole

**Fields Read:**

- [connectionroleid](#connectionroleid)
- [statecode](#statecode)

**Fields Written:**

- [description](#description)
- [record1id](#record1id)
- [record1roleid](#record1roleid)
- [record2id](#record2id)
- [record2roleid](#record2roleid)

**Fields Filtered:**

- [name](#name)

**Fields Sorted:**

- [category](#category)

**Fields Joined:**

- [associatedconnectionroleid](#associatedconnectionroleid)
- [connectionroleid](#connectionroleid)

### 10.20. CreateCompGoals

- **File:** `CreateCompGoals.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_commissionid](#azt_commissionid)
- [azt_licensetype](#azt_licensetype)
- [azt_name](#azt_name)
- [azt_recordownerid](#azt_recordownerid)
- [ext_amt](#ext_amt)
- [extendedamount](#extendedamount)

**Fields Written:**

- [azt_amount](#azt_amount)
- [azt_commissionid](#azt_commissionid)
- [azt_compcompleted](#azt_compcompleted)
- [azt_effectivedate](#azt_effectivedate)
- [azt_invoiceid](#azt_invoiceid)
- [azt_name](#azt_name)
- [azt_opportunityid](#azt_opportunityid)
- [azt_orderid](#azt_orderid)
- [azt_percentage](#azt_percentage)
- [azt_producttype](#azt_producttype)
- [azt_salesrepid](#azt_salesrepid)
- [azt_total](#azt_total)
- [invoiceid](#invoiceid)
- [ownerid](#ownerid)

**Fields Filtered:**

- [invoiceid](#invoiceid)
- [ownerid](#ownerid)

**Fields Sorted:**

- [azt_fiscalperiodstart](#azt_fiscalperiodstart)

### 10.21. CreateSoftwareLicenses

- **File:** `CreateSoftwareLicenses.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [azt_iscompanion](#azt_iscompanion)
- [azt_isprint](#azt_isprint)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_nonsaastype](#azt_nonsaastype)
- [azt_parentorderid](#azt_parentorderid)
- [azt_recordownerid](#azt_recordownerid)
- [azt_saas](#azt_saas)
- [customerid](#customerid)
- [datefulfilled](#datefulfilled)
- [name](#name)
- [productid](#productid)
- [productnumber](#productnumber)
- [quantity](#quantity)
- [salesorderdetailid](#salesorderdetailid)
- [salesorderid](#salesorderid)
- [statecode](#statecode)

**Fields Written:**

- [azt_accountid](#azt_accountid)
- [azt_allocatedtoid](#azt_allocatedtoid)
- [azt_allocationtype](#azt_allocationtype)
- [azt_concurrentusers](#azt_concurrentusers)
- [azt_customerid](#azt_customerid)
- [azt_expirationdate](#azt_expirationdate)
- [azt_isbn](#azt_isbn)
- [azt_licensestatus](#azt_licensestatus)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_name](#azt_name)
- [azt_numberoflicenses](#azt_numberoflicenses)
- [azt_ordertype](#azt_ordertype)
- [azt_printproductid](#azt_printproductid)
- [azt_printpurchaseid](#azt_printpurchaseid)
- [azt_purchasedate](#azt_purchasedate)
- [azt_quantity](#azt_quantity)
- [azt_softwarelicenseid](#azt_softwarelicenseid)
- [azt_softwareproductid](#azt_softwareproductid)
- [azt_startdate](#azt_startdate)
- [azt_supportexpirationdate](#azt_supportexpirationdate)
- [salesorderdetailid](#salesorderdetailid)

**Fields Filtered:**

- [salesorderid](#salesorderid)

**Fields Sorted:**

- [productid](#productid)

**Pre/Post Image Fields:**

- [azt_recordownerid](#azt_recordownerid)
- [customerid](#customerid)
- [statecode](#statecode)

### 10.22. CreateUserGoals

- **File:** `CreateUserGoals.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [amountdatatype](#amountdatatype)
- [azt_amount](#azt_amount)
- [azt_compgoaltypeid](#azt_compgoaltypeid)
- [azt_compplanamountid](#azt_compplanamountid)
- [azt_effectivedate](#azt_effectivedate)
- [azt_invoiceid](#azt_invoiceid)
- [azt_jobrole](#azt_jobrole)
- [azt_masecommission](#azt_masecommission)
- [azt_orderid](#azt_orderid)
- [azt_payablecommission](#azt_payablecommission)
- [azt_percentage](#azt_percentage)
- [azt_percentagepaid](#azt_percentagepaid)
- [azt_producttype](#azt_producttype)
- [azt_salesrepid](#azt_salesrepid)
- [azt_total](#azt_total)
- [createdon](#createdon)
- [extendedamount](#extendedamount)
- [fullname](#fullname)
- [goalenddate](#goalenddate)
- [goalid](#goalid)
- [goalrollupqueryid](#goalrollupqueryid)
- [goalstartdate](#goalstartdate)
- [isamount](#isamount)
- [name](#name)
- [opportunityproductid](#opportunityproductid)
- [ownerid](#ownerid)
- [parentgoalid](#parentgoalid)
- [parentsystemuserid](#parentsystemuserid)
- [priceperunit](#priceperunit)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [statuscode](#statuscode)

**Fields Written:**

- [azt_goaltype](#azt_goaltype)
- [consideronlygoalownersrecords](#consideronlygoalownersrecords)
- [fetchxml](#fetchxml)
- [goalenddate](#goalenddate)
- [goalownerid](#goalownerid)
- [goalstartdate](#goalstartdate)
- [isfiscalperiodgoal](#isfiscalperiodgoal)
- [metricid](#metricid)
- [name](#name)
- [ownerid](#ownerid)
- [parentgoalid](#parentgoalid)
- [queryentitytype](#queryentitytype)
- [rolluponlyfromchildgoals](#rolluponlyfromchildgoals)
- [rollupqueryactualmoneyid](#rollupqueryactualmoneyid)
- [title](#title)

**Fields Filtered:**

- [actualclosedate](#actualclosedate)
- [azt_compcompleted](#azt_compcompleted)
- [azt_effectivedate](#azt_effectivedate)
- [azt_goaltype](#azt_goaltype)
- [azt_issaas](#azt_issaas)
- [azt_producttype](#azt_producttype)
- [azt_recordownerid](#azt_recordownerid)
- [azt_salesrepid](#azt_salesrepid)
- [goalenddate](#goalenddate)
- [goalownerid](#goalownerid)
- [goalstartdate](#goalstartdate)
- [name](#name)
- [ownerid](#ownerid)
- [statecode](#statecode)

**Fields Sorted:**

- [azt_producttype](#azt_producttype)
- [azt_salesrepid](#azt_salesrepid)
- [createdon](#createdon)
- [fiscalperiod](#fiscalperiod)
- [productid](#productid)
- [title](#title)

**Fields Joined:**

- [azt_invoiceid](#azt_invoiceid)
- [invoiceid](#invoiceid)
- [opportunityid](#opportunityid)

### 10.23. DiscretionaryDiscountSetHeader

- **File:** `DiscretionaryDiscountSetHeader.cs`
- **Message:** Delete
- **Entity Images:** Post

**Fields Read:**

- [azt_discountamount](#azt_discountamount)
- [azt_invoiceproductid](#azt_invoiceproductid)
- [azt_opportunityid](#azt_opportunityid)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [azt_orderproductid](#azt_orderproductid)
- [azt_productdiscountid](#azt_productdiscountid)
- [azt_quoteproductid](#azt_quoteproductid)
- [invoicedetailid](#invoicedetailid)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [parentaccountid](#parentaccountid)
- [quotedetailid](#quotedetailid)
- [quoteid](#quoteid)
- [salesorderdetailid](#salesorderdetailid)
- [statecode](#statecode)

**Fields Written:**

- [azt_customerid](#azt_customerid)
- [azt_discretionarydiscountamt](#azt_discretionarydiscountamt)
- [azt_opportunityid](#azt_opportunityid)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [azt_productdiscountid](#azt_productdiscountid)
- [invoicedetailid](#invoicedetailid)
- [manualdiscountamount](#manualdiscountamount)
- [opportunityproductid](#opportunityproductid)
- [quotedetailid](#quotedetailid)
- [salesorderdetailid](#salesorderdetailid)

**Fields Filtered:**

- [invoicedetailid](#invoicedetailid)
- [opportunityproductid](#opportunityproductid)
- [quotedetailid](#quotedetailid)
- [salesorderdetailid](#salesorderdetailid)
- [statecode](#statecode)
- [{0}](#0)

**Fields Sorted:**

- [productid](#productid)

**Fields Joined:**

- [invoiceid](#invoiceid)
- [opportunityid](#opportunityid)
- [quoteid](#quoteid)
- [salesorderid](#salesorderid)

### 10.24. EngagementFSRAssignedOn

- **File:** `EngagementFSRAssignedOn.cs`
- **Message:** Update

**Fields Read:**

- [azt_engagementid](#azt_engagementid)
- [ownerid](#ownerid)

**Fields Written:**

- [azt_engagementid](#azt_engagementid)
- [azt_fsrassignedon](#azt_fsrassignedon)

### 10.25. EngagementSetEndDate

- **File:** `EngagementSetEndDate.cs`
- **Message:** SetState

**Fields Written:**

- [azt_enddate](#azt_enddate)
- [azt_engagementid](#azt_engagementid)

### 10.26. ExpenseLineTotals

- **File:** `ExpenseLineTotals.cs`
- **Target entity:** azt_expense
- **Message:** Create
- **Entity Images:** Post

**Fields Read:**

- [azt_expenseamount](#azt_expenseamount)
- [azt_expensereportid](#azt_expensereportid)
- [contactid](#contactid)
- [crm3_expenseamount](#crm3_expenseamount)
- [crm3_parentleadid](#crm3_parentleadid)

**Fields Written:**

- [azt_expensereportid](#azt_expensereportid)
- [azt_totalreimbursement](#azt_totalreimbursement)
- [contactid](#contactid)
- [parentcustomerid](#parentcustomerid)

**Fields Filtered:**

- [azt_expensereportid](#azt_expensereportid)
- [crm3_parentleadid](#crm3_parentleadid)

### 10.27. ExpenseRestrictVisibility

- **File:** `ExpenseRestrictVisibility.cs`

**Fields Read:**

- [businessunitid](#businessunitid)

**Fields Filtered:**

- [statecode](#statecode)

### 10.28. FundingSetAnnualSpend

- **File:** `FundingSetAnnualSpend.cs`
- **Message:** Create

**Fields Read:**

- [azt_account](#azt_account)
- [azt_fundingyear](#azt_fundingyear)
- [invoiceid](#invoiceid)
- [totalamount](#totalamount)

**Fields Written:**

- [azt_annualspend](#azt_annualspend)
- [azt_fundingid](#azt_fundingid)

**Fields Filtered:**

- [azt_paidon](#azt_paidon)
- [customerid](#customerid)
- [statecode](#statecode)

### 10.29. FundingTotalAmt

- **File:** `FundingTotalAmt.cs`
- **Message:** Create
- **Entity Images:** Post

**Fields Written:**

- [azt_fundingid](#azt_fundingid)
- [azt_totalfunding](#azt_totalfunding)

### 10.30. FundingYearSync

- **File:** `FundingYearSync.cs`
- **Message:** Create

**Fields Read:**

- [azt_fundingyear](#azt_fundingyear)

**Fields Written:**

- [azt_year](#azt_year)

### 10.31. GetAcctTeamOwned

- **File:** `GetAcctTeamOwned.cs`

**Fields Read:**

- [accountid](#accountid)
- [name](#name)

**Fields Filtered:**

- [accountid](#accountid)

**Fields Sorted:**

- [name](#name)

**Fields Joined:**

- [owninguser](#owninguser)
- [systemuserid](#systemuserid)

### 10.32. GetUserHasRole

- **File:** `GetUserHasRole.cs`

**Fields Read:**

- [businessunitid](#businessunitid)

### 10.33. GetUserHasRoleToAction

- **File:** `GetUserHasRoleToAction.cs`

**Fields Read:**

- [roleid](#roleid)

**Fields Filtered:**

- [roleid](#roleid)
- [systemuserid](#systemuserid)

**Fields Joined:**

- [roleid](#roleid)
- [systemuserid](#systemuserid)

### 10.34. InvoiceClosePaidOnPercentage

- **File:** `InvoiceClosePaidOnPercentage.cs`
- **Message:** Update
- **Entity Images:** Pre

**Fields Read:**

- [azt_amount](#azt_amount)
- [azt_compcompleted](#azt_compcompleted)
- [azt_invoiceid](#azt_invoiceid)
- [azt_paymentid](#azt_paymentid)
- [statecode](#statecode)
- [totalamount](#totalamount)

### 10.35. InvoiceCompCompleted

- **File:** `InvoiceCompCompleted.cs`
- **Message:** Update

**Fields Read:**

- [azt_amount](#azt_amount)
- [azt_commissionpaymentid](#azt_commissionpaymentid)
- [azt_compcompleted](#azt_compcompleted)
- [azt_compgoaltypeid](#azt_compgoaltypeid)
- [azt_compplanamountid](#azt_compplanamountid)
- [azt_effectivedate](#azt_effectivedate)
- [azt_invoiceid](#azt_invoiceid)
- [azt_orderid](#azt_orderid)
- [azt_percentage](#azt_percentage)
- [azt_producttype](#azt_producttype)
- [azt_salesrepid](#azt_salesrepid)
- [azt_total](#azt_total)
- [ownerid](#ownerid)
- [statuscode](#statuscode)

**Fields Written:**

- [azt_commissionamount](#azt_commissionamount)
- [azt_commissionid](#azt_commissionid)
- [azt_commissionpaymentid](#azt_commissionpaymentid)
- [azt_compgoalid](#azt_compgoalid)
- [azt_compgoaltypeid](#azt_compgoaltypeid)
- [azt_invoiceid](#azt_invoiceid)
- [azt_name](#azt_name)
- [azt_periodend](#azt_periodend)
- [azt_periodstart](#azt_periodstart)
- [ownerid](#ownerid)
- [statecode](#statecode)
- [statuscode](#statuscode)

**Fields Filtered:**

- [azt_amount](#azt_amount)
- [azt_compgoalid](#azt_compgoalid)
- [azt_invoiceid](#azt_invoiceid)
- [azt_masecommission](#azt_masecommission)
- [azt_percentage](#azt_percentage)
- [azt_periodend](#azt_periodend)
- [azt_periodstart](#azt_periodstart)
- [ownerid](#ownerid)
- [statuscode](#statuscode)

**Fields Sorted:**

- [azt_producttype](#azt_producttype)
- [azt_salesrepid](#azt_salesrepid)
- [createdon](#createdon)

### 10.36. LeadImport

- **File:** `LeadImport.cs`
- **Message:** Create

**Fields Read:**

- [accountid](#accountid)
- [azt_companyname](#azt_companyname)
- [azt_email](#azt_email)
- [azt_firstname](#azt_firstname)
- [azt_importname](#azt_importname)
- [azt_jobtitle](#azt_jobtitle)
- [azt_lastname](#azt_lastname)
- [azt_leadsourceid](#azt_leadsourceid)
- [azt_phone](#azt_phone)
- [azt_stateprovince](#azt_stateprovince)
- [contactid](#contactid)
- [fullname](#fullname)
- [name](#name)
- [parentcustomerid](#parentcustomerid)

**Fields Written:**

- [address1_stateorprovince](#address1_stateorprovince)
- [azt_leadimportid](#azt_leadimportid)
- [azt_leadsourceid](#azt_leadsourceid)
- [azt_originatingleadimportid](#azt_originatingleadimportid)
- [azt_result](#azt_result)
- [companyname](#companyname)
- [emailaddress1](#emailaddress1)
- [firstname](#firstname)
- [jobtitle](#jobtitle)
- [lastname](#lastname)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [subject](#subject)
- [telephone1](#telephone1)

**Fields Filtered:**

- [emailaddress1](#emailaddress1)
- [name](#name)
- [statecode](#statecode)

**Fields Sorted:**

- [fullname](#fullname)
- [name](#name)

### 10.37. LeadImportPopulateName

- **File:** `LeadImportPopulateName.cs`
- **Message:** Create

**Fields Read:**

- [azt_email](#azt_email)
- [azt_importname](#azt_importname)

**Fields Written:**

- [azt_name](#azt_name)

### 10.38. LeadQualify

- **File:** `LeadQualify.cs`
- **Message:** QualifyLead

**Fields Read:**

- [parentaccountid](#parentaccountid)

### 10.39. LeadQualifyParentStakeholderContacts

- **File:** `LeadQualifyParentStakeholderContacts.cs`
- **Target entity:** account
- **Message:** Create

**Fields Read:**

- [accountid](#accountid)
- [connectionid](#connectionid)
- [name](#name)
- [originatingleadid](#originatingleadid)
- [record2id](#record2id)
- [record2roleid](#record2roleid)

**Fields Written:**

- [contactid](#contactid)
- [parentcustomerid](#parentcustomerid)

**Fields Filtered:**

- [record1id](#record1id)

**Fields Sorted:**

- [record2id](#record2id)

### 10.40. ManualDiscountKill

- **File:** `ManualDiscountKill.cs`

**Fields Read:**

- [manualdiscountamount](#manualdiscountamount)

### 10.41. OppAuditRemoval

- **File:** `OppAuditRemoval.cs`

**Fields Read:**

- [azt_opportunityauditrecordid](#azt_opportunityauditrecordid)

**Fields Filtered:**

- [azt_opportunityid](#azt_opportunityid)

### 10.42. OpportunityAssignFromLead

- **File:** `OpportunityAssignFromLead.cs`
- **Message:** Create

**Fields Read:**

- [originatingleadid](#originatingleadid)

**Fields Written:**

- [opportunityid](#opportunityid)
- [ownerid](#ownerid)

### 10.43. OpportunityAudit

- **File:** `OpportunityAudit.cs`
- **Message:** Update
- **Entity Images:** Pre, Post

**Fields Read:**

- [azt_lastmodifiedbyid](#azt_lastmodifiedbyid)
- [azt_parentopportunityid](#azt_parentopportunityid)
- [azt_probability](#azt_probability)
- [estimatedclosedate](#estimatedclosedate)
- [estimatedvalue](#estimatedvalue)
- [fullname](#fullname)
- [opportunityid](#opportunityid)

**Fields Written:**

- [azt_name](#azt_name)
- [azt_newestclosedate](#azt_newestclosedate)
- [azt_newestimatedvalue](#azt_newestimatedvalue)
- [azt_newprobability](#azt_newprobability)
- [azt_opportunityid](#azt_opportunityid)
- [azt_previousestclosedate](#azt_previousestclosedate)
- [azt_previousestimatedvalue](#azt_previousestimatedvalue)
- [azt_previousprobability](#azt_previousprobability)

**Pre/Post Image Fields:**

- [azt_parentopportunityid](#azt_parentopportunityid)

### 10.44. OpportunityClone

- **File:** `OpportunityClone.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [description](#description)
- [extendedamount](#extendedamount)
- [ispriceoverridden](#ispriceoverridden)
- [isproductoverridden](#isproductoverridden)
- [manualdiscountamount](#manualdiscountamount)
- [opportunityproductid](#opportunityproductid)
- [priceperunit](#priceperunit)
- [productdescription](#productdescription)
- [productid](#productid)
- [productname](#productname)
- [producttypecode](#producttypecode)
- [quantity](#quantity)
- [tax](#tax)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)

**Fields Written:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [estimatedclosedate](#estimatedclosedate)
- [opportunityid](#opportunityid)

**Fields Filtered:**

- [opportunityid](#opportunityid)

**Fields Sorted:**

- [productid](#productid)

### 10.45. OpportunityLastActivityDate

- **File:** `OpportunityLastActivityDate.cs`
- **Message:** Update

**Fields Read:**

- [azt_probability](#azt_probability)
- [estimatedclosedate](#estimatedclosedate)
- [estimatedvalue](#estimatedvalue)
- [regardingobjectid](#regardingobjectid)

**Fields Written:**

- [azt_lastactivitydate](#azt_lastactivitydate)
- [opportunityid](#opportunityid)

### 10.46. OpportunityLineSyncToQuote

- **File:** `OpportunityLineSyncToQuote.cs`
- **Message:** Update
- **Entity Images:** Pre, Post

**Fields Read:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [defaultuomid](#defaultuomid)
- [manualdiscountamount](#manualdiscountamount)
- [opportunityid](#opportunityid)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [quotedetailid](#quotedetailid)
- [quoteid](#quoteid)
- [statecode](#statecode)
- [tax](#tax)

**Fields Written:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [quotedetailid](#quotedetailid)

**Fields Filtered:**

- [opportunityid](#opportunityid)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [quoteid](#quoteid)

**Fields Sorted:**

- [modifiedon](#modifiedon)

**Pre/Post Image Fields:**

- [opportunityid](#opportunityid)

### 10.47. OpportunityPreventCreateQuote

- **File:** `OpportunityPreventCreateQuote.cs`
- **Message:** Create

**Fields Read:**

- [azt_approvalstatus](#azt_approvalstatus)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)

**Fields Filtered:**

- [azt_opportunityproductid](#azt_opportunityproductid)
- [opportunityid](#opportunityid)

### 10.48. OpportunityProbabilityChange

- **File:** `OpportunityProbabilityChange.cs`
- **Message:** Create
- **Entity Images:** Pre

**Fields Read:**

- [azt_probability](#azt_probability)

**Fields Written:**

- [azt_probabilitychangedon](#azt_probabilitychangedon)
- [azt_probabilityincreased](#azt_probabilityincreased)

**Pre/Post Image Fields:**

- [azt_probability](#azt_probability)

### 10.49. OpportunityProbabilityNumber

- **File:** `OpportunityProbabilityNumber.cs`

**Fields Read:**

- [azt_probability](#azt_probability)

**Fields Written:**

- [closeprobability](#closeprobability)
- [opportunityid](#opportunityid)

### 10.50. OpptyToQuoteFieldMappings

- **File:** `OpptyToQuoteFieldMappings.cs`
- **Message:** Create

**Fields Read:**

- [azt_approvalstatus](#azt_approvalstatus)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_productdiscountid](#azt_productdiscountid)
- [extendedamount](#extendedamount)
- [manualdiscountamount](#manualdiscountamount)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [quotedetailid](#quotedetailid)
- [quoteid](#quoteid)

**Fields Written:**

- [azt_discretionarydiscountamt](#azt_discretionarydiscountamt)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [azt_productdiscountid](#azt_productdiscountid)
- [azt_quoteproductid](#azt_quoteproductid)
- [quotedetailid](#quotedetailid)

**Fields Filtered:**

- [azt_licensetype](#azt_licensetype)
- [azt_opportunityid](#azt_opportunityid)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [extendedamount](#extendedamount)
- [opportunityid](#opportunityid)
- [productid](#productid)
- [quoteid](#quoteid)

**Fields Sorted:**

- [azt_name](#azt_name)
- [createdon](#createdon)

### 10.51. OrderClone

- **File:** `OrderClone.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [description](#description)
- [extendedamount](#extendedamount)
- [ispriceoverridden](#ispriceoverridden)
- [isproductoverridden](#isproductoverridden)
- [manualdiscountamount](#manualdiscountamount)
- [priceperunit](#priceperunit)
- [productdescription](#productdescription)
- [productid](#productid)
- [productname](#productname)
- [producttypecode](#producttypecode)
- [quantity](#quantity)
- [salesorderdetailid](#salesorderdetailid)
- [tax](#tax)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)

**Fields Written:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)

**Fields Filtered:**

- [salesorderid](#salesorderid)

**Fields Sorted:**

- [productid](#productid)

### 10.52. OrderFSRSetTemplateFields

- **File:** `OrderFSRSetTemplateFields.cs`
- **Message:** Update

**Fields Read:**

- [address1_telephone1](#address1_telephone1)
- [azt_bookingurl](#azt_bookingurl)
- [azt_extension](#azt_extension)
- [azt_fsrid](#azt_fsrid)
- [internalemailaddress](#internalemailaddress)
- [mobilephone](#mobilephone)

**Fields Written:**

- [azt_bookingurl](#azt_bookingurl)
- [azt_fsremail](#azt_fsremail)
- [azt_fsrmobiletelephone](#azt_fsrmobiletelephone)
- [azt_fsrtelephone](#azt_fsrtelephone)
- [azt_fsrtelephoneextension](#azt_fsrtelephoneextension)

### 10.53. OrderLinePopulateLicType

- **File:** `OrderLinePopulateLicType.cs`
- **Message:** Create

**Fields Read:**

- [azt_licenseterm](#azt_licenseterm)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [quotedetailid](#quotedetailid)

**Fields Written:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [salesorderdetailid](#salesorderdetailid)

### 10.54. OrderLinePopulateTemplateFields

- **File:** `OrderLinePopulateTemplateFields.cs`
- **Message:** Create

**Fields Read:**

- [quantity](#quantity)
- [salesorderdetailname](#salesorderdetailname)

**Fields Written:**

- [azt_ordertemplatelines](#azt_ordertemplatelines)
- [salesorderid](#salesorderid)

**Fields Filtered:**

- [salesorderid](#salesorderid)

**Fields Sorted:**

- [productid](#productid)

### 10.55. OrderManuallyCreateSoftwareLicense

- **File:** `OrderManuallyCreateSoftwareLicense.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [ownerid](#ownerid)
- [productid](#productid)
- [quantity](#quantity)

**Fields Written:**

- [azt_allocatedtoid](#azt_allocatedtoid)
- [azt_customerid](#azt_customerid)
- [azt_expirationdate](#azt_expirationdate)
- [azt_licensestatus](#azt_licensestatus)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_name](#azt_name)
- [azt_numberoflicenses](#azt_numberoflicenses)
- [azt_orderlineid](#azt_orderlineid)
- [azt_purchasedate](#azt_purchasedate)
- [azt_softwarelicenseid](#azt_softwarelicenseid)
- [azt_softwareproductid](#azt_softwareproductid)
- [azt_startdate](#azt_startdate)
- [azt_supportexpirationdate](#azt_supportexpirationdate)
- [ownerid](#ownerid)

### 10.56. OrderSplit

- **File:** `OrderSplit.cs`
- **Message:** Create (inferred)

**Fields Read:**

- [azt_estfulfillmentdate](#azt_estfulfillmentdate)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_parentorderid](#azt_parentorderid)
- [azt_ponumber](#azt_ponumber)
- [azt_quotenumber](#azt_quotenumber)
- [azt_recordownerid](#azt_recordownerid)
- [azt_trackingnumber](#azt_trackingnumber)
- [description](#description)
- [extendedamount](#extendedamount)
- [ispriceoverridden](#ispriceoverridden)
- [isproductoverridden](#isproductoverridden)
- [priceperunit](#priceperunit)
- [productdescription](#productdescription)
- [productid](#productid)
- [productname](#productname)
- [producttypecode](#producttypecode)
- [quantity](#quantity)
- [salesorderdetailid](#salesorderdetailid)
- [tax](#tax)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)

**Fields Written:**

- [azt_estfulfillmentdate](#azt_estfulfillmentdate)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_parentorderid](#azt_parentorderid)
- [azt_ponumber](#azt_ponumber)
- [azt_quotenumber](#azt_quotenumber)
- [azt_recordownerid](#azt_recordownerid)
- [azt_trackingnumber](#azt_trackingnumber)
- [billto_line1](#billto_line1)
- [billto_line2](#billto_line2)
- [billto_line3](#billto_line3)
- [billto_name](#billto_name)
- [billto_postalcode](#billto_postalcode)
- [billto_stateorprovince](#billto_stateorprovince)
- [customerid](#customerid)
- [description](#description)
- [freighttermscode](#freighttermscode)
- [name](#name)
- [opportunityid](#opportunityid)
- [pricelevelid](#pricelevelid)
- [quoteid](#quoteid)
- [requestdeliveryby](#requestdeliveryby)
- [shippingmethodcode](#shippingmethodcode)
- [shipto_line1](#shipto_line1)
- [shipto_line2](#shipto_line2)
- [shipto_line3](#shipto_line3)
- [shipto_name](#shipto_name)
- [shipto_postalcode](#shipto_postalcode)
- [shipto_stateorprovince](#shipto_stateorprovince)
- [transactioncurrencyid](#transactioncurrencyid)

**Fields Filtered:**

- [salesorderid](#salesorderid)

**Fields Sorted:**

- [productid](#productid)

### 10.57. OrderStageTracking

- **File:** `OrderStageTracking.cs`
- **Message:** Create

**Fields Read:**

- [azt_orderid](#azt_orderid)
- [azt_orderstageid](#azt_orderstageid)
- [bpf_duration](#bpf_duration)
- [businessprocessflowinstanceid](#businessprocessflowinstanceid)
- [createdon](#createdon)

**Fields Written:**

- [azt_ageendedstage](#azt_ageendedstage)
- [azt_dateexitedstage](#azt_dateexitedstage)
- [azt_orderstageid](#azt_orderstageid)

**Fields Filtered:**

- [azt_orderid](#azt_orderid)
- [bpf_salesorderid](#bpf_salesorderid)

**Fields Sorted:**

- [createdon](#createdon)

### 10.58. PaymentUpdate

- **File:** `PaymentUpdate.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [azt_amount](#azt_amount)
- [azt_compcompleted](#azt_compcompleted)
- [azt_invoiceid](#azt_invoiceid)
- [azt_paymentdate](#azt_paymentdate)
- [azt_paymentid](#azt_paymentid)
- [statuscode](#statuscode)
- [totalamount](#totalamount)

### 10.59. PhonecallCreateCallback

- **File:** `PhonecallCreateCallback.cs`
- **Target entity:** team
- **Message:** Create
- **Entity Images:** Post

**Fields Read:**

- [activityid](#activityid)
- [azt_addtocrtqueue](#azt_addtocrtqueue)
- [azt_autocreatecallback](#azt_autocreatecallback)
- [azt_azteccustomerid](#azt_azteccustomerid)
- [azt_callbackin](#azt_callbackin)
- [azt_callbackon](#azt_callbackon)
- [azt_copydescription](#azt_copydescription)
- [azt_copysubject](#azt_copysubject)
- [azt_recordownerid](#azt_recordownerid)
- [azt_softwarelicenseid](#azt_softwarelicenseid)
- [customerid](#customerid)
- [description](#description)
- [from](#from)
- [ownerid](#ownerid)
- [parentcustomerid](#parentcustomerid)
- [phonenumber](#phonenumber)
- [queueid](#queueid)
- [queueitemid](#queueitemid)
- [regardingobjectid](#regardingobjectid)
- [scheduledend](#scheduledend)
- [statecode](#statecode)
- [subject](#subject)
- [to](#to)

**Fields Written:**

- [azt_duedate](#azt_duedate)
- [from](#from)
- [objectid](#objectid)
- [partyid](#partyid)
- [queueid](#queueid)
- [to](#to)

**Fields Filtered:**

- [accountid](#accountid)
- [activityid](#activityid)
- [contactid](#contactid)
- [name](#name)
- [objectid](#objectid)

**Pre/Post Image Fields:**

- [activityid](#activityid)
- [ownerid](#ownerid)

### 10.60. ProductDiscountPreventOnActiveQuote

- **File:** `ProductDiscountPreventOnActiveQuote.cs`
- **Message:** Create
- **Entity Images:** Pre

**Fields Read:**

- [azt_quoteproductid](#azt_quoteproductid)
- [quoteid](#quoteid)
- [statecode](#statecode)

### 10.61. QuoteCloneAndDelete

- **File:** `QuoteCloneAndDelete.cs`
- **Message:** Delete (inferred)

**Fields Read:**

- [extendedamount](#extendedamount)
- [invoiceid](#invoiceid)
- [priceperunit](#priceperunit)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [quotedetailid](#quotedetailid)
- [salesorderid](#salesorderid)
- [uomid](#uomid)

**Fields Written:**

- [quantity](#quantity)
- [quoteid](#quoteid)

**Fields Filtered:**

- [quoteid](#quoteid)
- [salesorderid](#salesorderid)

**Fields Sorted:**

- [name](#name)
- [productid](#productid)

### 10.62. QuoteLinesSyncToOppty

- **File:** `QuoteLinesSyncToOppty.cs`
- **Target entity:** quote
- **Message:** Create
- **Entity Images:** Pre, Post

**Fields Read:**

- [defaultuomid](#defaultuomid)
- [discountamount](#discountamount)
- [discountpercentage](#discountpercentage)
- [manualdiscountamount](#manualdiscountamount)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [quoteid](#quoteid)
- [tax](#tax)
- [uomid](#uomid)

**Fields Written:**

- [azt_opportunityproductid](#azt_opportunityproductid)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [quantity](#quantity)
- [quotedetailid](#quotedetailid)

**Fields Filtered:**

- [extendedamount](#extendedamount)
- [opportunityid](#opportunityid)
- [productdescription](#productdescription)
- [productid](#productid)

**Fields Sorted:**

- [productid](#productid)

### 10.63. QuoteOrderProductsTrackDiscount

- **File:** `QuoteOrderProductsTrackDiscount.cs`
- **Message:** Create

**Fields Read:**

- [azt_opportunityproductid](#azt_opportunityproductid)
- [azt_productdiscountid](#azt_productdiscountid)
- [invoicedetailid](#invoicedetailid)
- [quotedetailid](#quotedetailid)
- [salesorderdetailid](#salesorderdetailid)

**Fields Written:**

- [azt_invoiceproductid](#azt_invoiceproductid)
- [azt_orderproductid](#azt_orderproductid)
- [azt_productdiscountid](#azt_productdiscountid)

**Fields Filtered:**

- [azt_orderproductid](#azt_orderproductid)

**Fields Sorted:**

- [azt_name](#azt_name)

### 10.64. QuotePreventActivateUnapprovedDiscounts

- **File:** `QuotePreventActivateUnapprovedDiscounts.cs`
- **Message:** SetState

**Fields Read:**

- [azt_approvalstatus](#azt_approvalstatus)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_productdiscountid](#azt_productdiscountid)
- [baseamount](#baseamount)
- [extendedamount](#extendedamount)
- [ispriceoverridden](#ispriceoverridden)
- [manualdiscountamount](#manualdiscountamount)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [priceperunit](#priceperunit)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [quotedetailid](#quotedetailid)
- [quoteid](#quoteid)
- [salesrepid](#salesrepid)
- [tax](#tax)
- [uomid](#uomid)

**Fields Written:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [azt_productdiscountid](#azt_productdiscountid)
- [baseamount](#baseamount)
- [extendedamount](#extendedamount)
- [ispriceoverridden](#ispriceoverridden)
- [isproductoverridden](#isproductoverridden)
- [manualdiscountamount](#manualdiscountamount)
- [opportunityid](#opportunityid)
- [priceperunit](#priceperunit)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [tax](#tax)
- [uomid](#uomid)

**Fields Filtered:**

- [azt_quoteproductid](#azt_quoteproductid)
- [opportunityid](#opportunityid)
- [quoteid](#quoteid)

### 10.65. QuotePreventActivateUnapprovedFreight

- **File:** `QuotePreventActivateUnapprovedFreight.cs`
- **Message:** SetState

**Fields Read:**

- [azt_defaultfreightamount](#azt_defaultfreightamount)
- [azt_freightamtapproved](#azt_freightamtapproved)
- [azt_requestedfreightamt](#azt_requestedfreightamt)
- [quoteid](#quoteid)

### 10.66. QuoteSyncTotalToOpportunity

- **File:** `QuoteSyncTotalToOpportunity.cs`
- **Message:** Update
- **Entity Images:** Post

**Fields Read:**

- [freightamount](#freightamount)
- [opportunityid](#opportunityid)
- [totalamount](#totalamount)

**Fields Written:**

- [isrevenuesystemcalculated](#isrevenuesystemcalculated)
- [opportunityid](#opportunityid)

### 10.67. RecordOwnerRestrictEdit

- **File:** `RecordOwnerRestrictEdit.cs`
- **Message:** Update
- **Entity Images:** Pre

**Fields Read:**

- [azt_opportunityid](#azt_opportunityid)
- [azt_quoteproductid](#azt_quoteproductid)
- [azt_recordowner](#azt_recordowner)
- [azt_recordownerid](#azt_recordownerid)
- [businessunitid](#businessunitid)
- [ownerid](#ownerid)

### 10.68. RestrictCreateQuote

- **File:** `RestrictCreateQuote.cs`
- **Message:** Create

**Fields Read:**

- [quoteid](#quoteid)

**Fields Filtered:**

- [opportunityid](#opportunityid)
- [statecode](#statecode)

**Fields Sorted:**

- [name](#name)

### 10.69. RestrictProductLookups

- **File:** `RestrictProductLookups.cs`
- **Message:** RetrieveMultiple

**Fields Read:**

- [azt_jobrole](#azt_jobrole)
- [businessunitid](#businessunitid)

**Fields Filtered:**

- [productnumber](#productnumber)

### 10.70. RestrictWinOpportunities

- **File:** `RestrictWinOpportunities.cs`

**Fields Read:**

- [businessunitid](#businessunitid)

### 10.71. RestrictWinQuote

- **File:** `RestrictWinQuote.cs`

**Fields Read:**

- [businessunitid](#businessunitid)

### 10.72. ReviseQuoteDiscountMove

- **File:** `ReviseQuoteDiscountMove.cs`
- **Message:** Create

**Fields Read:**

- [azt_productdiscountid](#azt_productdiscountid)
- [baseamount](#baseamount)
- [extendedamount](#extendedamount)
- [productdescription](#productdescription)
- [productid](#productid)
- [quantity](#quantity)
- [quotedetailid](#quotedetailid)

**Fields Written:**

- [azt_productdiscountid](#azt_productdiscountid)
- [azt_quoteproductid](#azt_quoteproductid)
- [discountamount](#discountamount)
- [quoteid](#quoteid)

**Fields Filtered:**

- [azt_quoteproductid](#azt_quoteproductid)
- [quoteid](#quoteid)

**Fields Sorted:**

- [azt_name](#azt_name)
- [productid](#productid)

### 10.73. SendQuoteReport

- **File:** `SendQuoteReport.cs`

**Fields Written:**

- [body](#body)
- [filename](#filename)
- [mimetype](#mimetype)
- [objectid](#objectid)
- [objecttypecode](#objecttypecode)
- [subject](#subject)

### 10.74. SetOppProductDefaults

- **File:** `SetOppProductDefaults.cs`
- **Message:** Create

**Fields Read:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [opportunityproductid](#opportunityproductid)
- [productid](#productid)

**Fields Written:**

- [azt_issaas](#azt_issaas)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [opportunityproductid](#opportunityproductid)

### 10.75. SetPrimaryContact

- **File:** `SetPrimaryContact.cs`
- **Message:** Create

**Fields Read:**

- [category](#category)
- [connectionid](#connectionid)
- [connectionroleid](#connectionroleid)
- [name](#name)
- [primarycontactid](#primarycontactid)
- [record1id](#record1id)
- [record1roleid](#record1roleid)
- [record2id](#record2id)
- [record2roleid](#record2roleid)
- [statecode](#statecode)

**Fields Written:**

- [accountid](#accountid)
- [description](#description)
- [primarycontactid](#primarycontactid)
- [record1id](#record1id)
- [record1roleid](#record1roleid)
- [record2id](#record2id)
- [record2roleid](#record2roleid)

**Fields Filtered:**

- [name](#name)
- [record1id](#record1id)
- [record2id](#record2id)

**Fields Sorted:**

- [category](#category)

**Fields Joined:**

- [associatedconnectionroleid](#associatedconnectionroleid)
- [connectionroleid](#connectionroleid)
- [record2roleid](#record2roleid)

### 10.76. ShareBasedOnAccessTeam

- **File:** `ShareBasedOnAccessTeam.cs`
- **Message:** GrantAccess (inferred)

**Fields Read:**

- [activityid](#activityid)
- [customerid](#customerid)
- [fullname](#fullname)
- [name](#name)
- [opportunityid](#opportunityid)
- [parentaccountid](#parentaccountid)
- [quoteid](#quoteid)
- [regardingobjectid](#regardingobjectid)
- [salesorderid](#salesorderid)
- [systemuserid](#systemuserid)
- [teamid](#teamid)
- [tm.systemuserid](#tmsystemuserid)

**Fields Filtered:**

- [accountid](#accountid)
- [regardingobjectid](#regardingobjectid)
- [teamtype](#teamtype)

**Fields Joined:**

- [owningteam](#owningteam)
- [systemuserid](#systemuserid)
- [teamid](#teamid)

**Cross-Entity References (AliasedValue):**

| Alias | Field | Operation |
|-------|-------|-----------|
| tm | systemuserid | Read |

### 10.77. ShareFromAccountShares

- **File:** `ShareFromAccountShares.cs`
- **Message:** Create

**Fields Read:**

- [customerid](#customerid)
- [name](#name)
- [parentcustomerid](#parentcustomerid)
- [regardingobjectid](#regardingobjectid)
- [teamtype](#teamtype)

### 10.78. ShareWithAccountOwner

- **File:** `ShareWithAccountOwner.cs`
- **Message:** GrantAccess (inferred)

**Fields Read:**

- [activityid](#activityid)
- [annotationid](#annotationid)
- [azt_accountid](#azt_accountid)
- [customerid](#customerid)
- [objectid](#objectid)
- [ownerid](#ownerid)
- [parentcustomerid](#parentcustomerid)
- [regardingobjectid](#regardingobjectid)

**Fields Filtered:**

- [salesorderid](#salesorderid)

### 10.79. ShipmentSetTrackingNumber

- **File:** `ShipmentSetTrackingNumber.cs`
- **Message:** Create

**Fields Read:**

- [azt_orderid](#azt_orderid)
- [azt_trackingnumber](#azt_trackingnumber)

**Fields Written:**

- [azt_trackingnumbers](#azt_trackingnumbers)
- [salesorderid](#salesorderid)

**Fields Filtered:**

- [azt_orderid](#azt_orderid)
- [azt_trackingnumber](#azt_trackingnumber)

**Fields Sorted:**

- [azt_orderlineid](#azt_orderlineid)
- [createdon](#createdon)

### 10.80. UpdateOppFromQuote

- **File:** `UpdateOppFromQuote.cs`
- **Message:** Update
- **Entity Images:** Pre, Post

**Fields Read:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [createdon](#createdon)
- [modifiedon](#modifiedon)
- [opportunityid](#opportunityid)
- [productid](#productid)
- [quoteid](#quoteid)
- [tax](#tax)
- [uomid](#uomid)

**Fields Written:**

- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [baseamount](#baseamount)
- [extendedamount](#extendedamount)
- [ispriceoverridden](#ispriceoverridden)
- [opportunityid](#opportunityid)
- [priceperunit](#priceperunit)
- [quantity](#quantity)

**Fields Filtered:**

- [opportunityid](#opportunityid)

**Fields Sorted:**

- [modifiedon](#modifiedon)

### 10.81. Utility

- **File:** `Utility.cs`

**Fields Read:**

- [azt_amount](#azt_amount)
- [azt_commissionid](#azt_commissionid)
- [azt_paymentdate](#azt_paymentdate)
- [azt_paymentid](#azt_paymentid)
- [azt_productdiscountid](#azt_productdiscountid)
- [azt_replacementproductid](#azt_replacementproductid)
- [azt_saas](#azt_saas)
- [businessunitid](#businessunitid)
- [fullname](#fullname)
- [name](#name)
- [parentsystemuserid](#parentsystemuserid)
- [productid](#productid)
- [roleid](#roleid)
- [statecode](#statecode)
- [transactioncurrencyid](#transactioncurrencyid)

**Fields Written:**

- [azt_fiscalperiodend](#azt_fiscalperiodend)
- [azt_fiscalperiodstart](#azt_fiscalperiodstart)
- [azt_name](#azt_name)
- [azt_paid](#azt_paid)
- [azt_paidon](#azt_paidon)
- [azt_totalamountpaid](#azt_totalamountpaid)
- [invoiceid](#invoiceid)
- [ownerid](#ownerid)
- [transactioncurrencyid](#transactioncurrencyid)

**Fields Filtered:**

- [azt_fiscalperiodend](#azt_fiscalperiodend)
- [azt_invoiceid](#azt_invoiceid)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [azt_quoteproductid](#azt_quoteproductid)
- [isocurrencycode](#isocurrencycode)
- [ownerid](#ownerid)
- [productnumber](#productnumber)
- [roleid](#roleid)
- [statuscode](#statuscode)
- [systemuserid](#systemuserid)

**Fields Sorted:**

- [azt_name](#azt_name)
- [azt_paymentdate](#azt_paymentdate)
- [fullname](#fullname)
- [ownerid](#ownerid)

**Fields Joined:**

- [roleid](#roleid)
- [systemuserid](#systemuserid)

---

## 11. PCF Controls

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

## 12. Relationships

Total relationships involving Opportunity: **20**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| Opportunity_Phonecalls | 1:N | Opportunity | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| azt_amsystemuser_opportunity | N:1 | SystemUser | Opportunity | [azt_AssignedAMId](#azt_assignedamid) |
| azt_azt_leadsource_opportunity | N:1 | azt_leadsource | Opportunity | [azt_LeadSourceId](#azt_leadsourceid) |
| azt_opportunity_azt_compgoaltype | 1:N | Opportunity | azt_compgoaltype | [azt_OpportunityId](#azt_opportunityid) |
| azt_opportunity_azt_opportunityauditrecord | 1:N | Opportunity | azt_opportunityauditrecord | [azt_OpportunityId](#azt_opportunityid) |
| azt_opportunity_azt_productdiscount | 1:N | Opportunity | azt_productdiscount | [azt_OpportunityId](#azt_opportunityid) |
| azt_opportunity_clonedopportunity | 1:N | Opportunity | Opportunity | [azt_ParentOpportunityId](#azt_parentopportunityid) |
| azt_opportunity_lead | 1:N | Opportunity | Lead | [azt_OpportunityLeadId](#azt_opportunityleadid) |
| azt_opportunity_task | 1:N | Opportunity | Task | [azt_ReorderOpportunityId](#azt_reorderopportunityid) |
| azt_systemuser_opportunity | N:1 | SystemUser | Opportunity | [azt_RecordOwnerId](#azt_recordownerid) |
| azt_systemusermodified_opportunity | N:1 | SystemUser | Opportunity | [azt_LastModifiedById](#azt_lastmodifiedbyid) |
| msa_contact_opportunity | N:1 | Contact | Opportunity | [msa_partneroppid](#msa_partneroppid) |
| msa_partner_opportunity | N:1 | Account | Opportunity | [msa_partnerid](#msa_partnerid) |
| msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid | N:1 | msdyn_opportunitykpiitem | Opportunity | [msdyn_opportunitykpiid](#msdyn_opportunitykpiid) |
| msdyn_msdyn_predictivescore_opportunity | N:1 | msdyn_predictivescore | Opportunity | [msdyn_PredictiveScoreId](#msdyn_predictivescoreid) |
| msdyn_msdyn_segment_opportunity | N:1 | msdyn_segment | Opportunity | [msdyn_segmentid](#msdyn_segmentid) |
| opportunity_customer_accounts | N:1 | Account | Opportunity | [CustomerId](#customerid) |
| opportunity_originating_lead | N:1 | Lead | Opportunity | [OriginatingLeadId](#originatingleadid) |
| opportunity_parent_account | N:1 | Account | Opportunity | [ParentAccountId](#parentaccountid) |
| opportunity_quotes | 1:N | Opportunity | Quote | [OpportunityId](#opportunityid) |

---

## 13. Ribbon Customizations

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

## 14. Conflicts and Observations

### 14.1 Per-Form Conflicts

Fields with inconsistent settings across forms: **1**

| Field | Issue | Forms |
|-------|-------|-------|
| [ownerid](#ownerid) | Visibility | Opportunity (quickCreate), Opportunity Owner Quick View (quick), Order Opportunity Owner Quick View (quick) |

### 14.2 Global Observations

**Fields in code but not on any form (308):**

- [!process_custom_attribute_url_](#process_custom_attribute_url_)
- [accountid](#accountid)
- [activityid](#activityid)
- [activitytypecode](#activitytypecode)
- [actualvalue](#actualvalue)
- [address1_stateorprovince](#address1_stateorprovince)
- [address1_telephone1](#address1_telephone1)
- [adx_resolutiondate](#adx_resolutiondate)
- [amountdatatype](#amountdatatype)
- [annotationid](#annotationid)
- [azt_account](#azt_account)
- [azt_accountid](#azt_accountid)
- [azt_accountleadgenerationid](#azt_accountleadgenerationid)
- [azt_accountleadgenname](#azt_accountleadgenname)
- [azt_accounttype](#azt_accounttype)
- [azt_addresssearch](#azt_addresssearch)
- [azt_addresssearch2](#azt_addresssearch2)
- [azt_addtocrtqueue](#azt_addtocrtqueue)
- [azt_ageendedstage](#azt_ageendedstage)
- [azt_allocatedtoid](#azt_allocatedtoid)
- [azt_allocationtype](#azt_allocationtype)
- [azt_amount](#azt_amount)
- [azt_annualspend](#azt_annualspend)
- [azt_approvalstatus](#azt_approvalstatus)
- [azt_autocreatecallback](#azt_autocreatecallback)
- [azt_autonumberid](#azt_autonumberid)
- [azt_azteccustomerid](#azt_azteccustomerid)
- [azt_bookingurl](#azt_bookingurl)
- [azt_callbackin](#azt_callbackin)
- [azt_callbackon](#azt_callbackon)
- [azt_caseid](#azt_caseid)
- [azt_commissionamount](#azt_commissionamount)
- [azt_commissionid](#azt_commissionid)
- [azt_commissionpaymentid](#azt_commissionpaymentid)
- [azt_companyname](#azt_companyname)
- [azt_compcompleted](#azt_compcompleted)
- [azt_compgoalid](#azt_compgoalid)
- [azt_compgoaltypeid](#azt_compgoaltypeid)
- [azt_compplanamountid](#azt_compplanamountid)
- [azt_concurrentusers](#azt_concurrentusers)
- [azt_copydescription](#azt_copydescription)
- [azt_copysubject](#azt_copysubject)
- [azt_currentnumber](#azt_currentnumber)
- [azt_customerid](#azt_customerid)
- [azt_customertrainingid](#azt_customertrainingid)
- [azt_dateexitedstage](#azt_dateexitedstage)
- [azt_description](#azt_description)
- [azt_discountamount](#azt_discountamount)
- [azt_duedate](#azt_duedate)
- [azt_effectivedate](#azt_effectivedate)
- [azt_email](#azt_email)
- [azt_enddate](#azt_enddate)
- [azt_engagementid](#azt_engagementid)
- [azt_estfulfillmentdate](#azt_estfulfillmentdate)
- [azt_evaluate](#azt_evaluate)
- [azt_expenseamount](#azt_expenseamount)
- [azt_expenseid](#azt_expenseid)
- [azt_expensereportid](#azt_expensereportid)
- [azt_expensetype](#azt_expensetype)
- [azt_expirationdate](#azt_expirationdate)
- [azt_extension](#azt_extension)
- [azt_fieldtoautonumber](#azt_fieldtoautonumber)
- [azt_firstname](#azt_firstname)
- [azt_fiscalperiodend](#azt_fiscalperiodend)
- [azt_fiscalperiodstart](#azt_fiscalperiodstart)
- [azt_fsrassignedon](#azt_fsrassignedon)
- [azt_fsremail](#azt_fsremail)
- [azt_fsrid](#azt_fsrid)
- [azt_fsrmobiletelephone](#azt_fsrmobiletelephone)
- [azt_fsrtelephone](#azt_fsrtelephone)
- [azt_fsrtelephoneextension](#azt_fsrtelephoneextension)
- [azt_fundingid](#azt_fundingid)
- [azt_fundingyear](#azt_fundingyear)
- [azt_goaltype](#azt_goaltype)
- [azt_historicalowner](#azt_historicalowner)
- [azt_importname](#azt_importname)
- [azt_invoiceid](#azt_invoiceid)
- [azt_invoiceproductid](#azt_invoiceproductid)
- [azt_isbn](#azt_isbn)
- [azt_iscompanion](#azt_iscompanion)
- [azt_isprint](#azt_isprint)
- [azt_issaas](#azt_issaas)
- [azt_jobrole](#azt_jobrole)
- [azt_jobtitle](#azt_jobtitle)
- [azt_lastname](#azt_lastname)
- [azt_leadimportid](#azt_leadimportid)
- [azt_licensestatus](#azt_licensestatus)
- [azt_licenseterm](#azt_licenseterm)
- [azt_licensetermmonths](#azt_licensetermmonths)
- [azt_licensetype](#azt_licensetype)
- [azt_masecommission](#azt_masecommission)
- [azt_mileage](#azt_mileage)
- [azt_monthstofilteron](#azt_monthstofilteron)
- [azt_name](#azt_name)
- [azt_newestclosedate](#azt_newestclosedate)
- [azt_newestimatedvalue](#azt_newestimatedvalue)
- [azt_newownerid](#azt_newownerid)
- [azt_newprobability](#azt_newprobability)
- [azt_nonsaasstatus](#azt_nonsaasstatus)
- [azt_nonsaastype](#azt_nonsaastype)
- [azt_numberoflicenses](#azt_numberoflicenses)
- [azt_opportunityauditrecordid](#azt_opportunityauditrecordid)
- [azt_opportunityid](#azt_opportunityid)
- [azt_opportunityproductid](#azt_opportunityproductid)
- [azt_orderid](#azt_orderid)
- [azt_orderlineid](#azt_orderlineid)
- [azt_orderproductid](#azt_orderproductid)
- [azt_orderstageid](#azt_orderstageid)
- [azt_ordertemplatelines](#azt_ordertemplatelines)
- [azt_ordertype](#azt_ordertype)
- [azt_originatingleadimportid](#azt_originatingleadimportid)
- [azt_paid](#azt_paid)
- [azt_paidon](#azt_paidon)
- [azt_parentopportunityid](#azt_parentopportunityid)
- [azt_parentorderid](#azt_parentorderid)
- [azt_payablecommission](#azt_payablecommission)
- [azt_paymentdate](#azt_paymentdate)
- [azt_paymentid](#azt_paymentid)
- [azt_percentage](#azt_percentage)
- [azt_percentagepaid](#azt_percentagepaid)
- [azt_periodend](#azt_periodend)
- [azt_periodstart](#azt_periodstart)
- [azt_phone](#azt_phone)
- [azt_ponumber](#azt_ponumber)
- [azt_prefix](#azt_prefix)
- [azt_prefixhasseparator](#azt_prefixhasseparator)
- [azt_prefixseparator](#azt_prefixseparator)
- [azt_prefixseparatorisspace](#azt_prefixseparatorisspace)
- [azt_previousestclosedate](#azt_previousestclosedate)
- [azt_previousestimatedvalue](#azt_previousestimatedvalue)
- [azt_previousownerid](#azt_previousownerid)
- [azt_previousprobability](#azt_previousprobability)
- [azt_printproductid](#azt_printproductid)
- [azt_printpurchaseid](#azt_printpurchaseid)
- [azt_probabilitychangedon](#azt_probabilitychangedon)
- [azt_probabilityincreased](#azt_probabilityincreased)
- [azt_productdiscountid](#azt_productdiscountid)
- [azt_producttype](#azt_producttype)
- [azt_purchasedate](#azt_purchasedate)
- [azt_quantity](#azt_quantity)
- [azt_quotenumber](#azt_quotenumber)
- [azt_quoteproductid](#azt_quoteproductid)
- [azt_reasonforexpense](#azt_reasonforexpense)
- [azt_recordowner](#azt_recordowner)
- [azt_replacementproductid](#azt_replacementproductid)
- [azt_resolvedbyid](#azt_resolvedbyid)
- [azt_result](#azt_result)
- [azt_saas](#azt_saas)
- [azt_saasstatus](#azt_saasstatus)
- [azt_salesrepid](#azt_salesrepid)
- [azt_salesstage](#azt_salesstage)
- [azt_softwarelicenseid](#azt_softwarelicenseid)
- [azt_softwareproductid](#azt_softwareproductid)
- [azt_startdate](#azt_startdate)
- [azt_stateabbreviation](#azt_stateabbreviation)
- [azt_stateprovince](#azt_stateprovince)
- [azt_suffix](#azt_suffix)
- [azt_suffixhasseparator](#azt_suffixhasseparator)
- [azt_suffixseparator](#azt_suffixseparator)
- [azt_suffixseparatorisspace](#azt_suffixseparatorisspace)
- [azt_supportexpirationdate](#azt_supportexpirationdate)
- [azt_total](#azt_total)
- [azt_totalamountpaid](#azt_totalamountpaid)
- [azt_totalfunding](#azt_totalfunding)
- [azt_totalreimbursement](#azt_totalreimbursement)
- [azt_trackingnumber](#azt_trackingnumber)
- [azt_trackingnumbers](#azt_trackingnumbers)
- [azt_trainingid](#azt_trainingid)
- [azt_year](#azt_year)
- [baseamount](#baseamount)
- [billto_line1](#billto_line1)
- [billto_line2](#billto_line2)
- [billto_line3](#billto_line3)
- [billto_name](#billto_name)
- [billto_postalcode](#billto_postalcode)
- [billto_stateorprovince](#billto_stateorprovince)
- [body](#body)
- [bpf_duration](#bpf_duration)
- [bpf_salesorderid](#bpf_salesorderid)
- [budgetstatus](#budgetstatus)
- [businessprocessflowinstanceid](#businessprocessflowinstanceid)
- [businessunitid](#businessunitid)
- [captureproposalfeedback](#captureproposalfeedback)
- [category](#category)
- [companyname](#companyname)
- [completefinalproposal](#completefinalproposal)
- [completeinternalreview](#completeinternalreview)
- [confirminterest](#confirminterest)
- [connectionid](#connectionid)
- [connectionroleid](#connectionroleid)
- [consideronlygoalownersrecords](#consideronlygoalownersrecords)
- [contactid](#contactid)
- [crm3_expenseamount](#crm3_expenseamount)
- [crm3_parentleadid](#crm3_parentleadid)
- [customerid](#customerid)
- [customerpainpoints](#customerpainpoints)
- [datefulfilled](#datefulfilled)
- [decisionmaker](#decisionmaker)
- [defaultuomid](#defaultuomid)
- [developproposal](#developproposal)
- [emailaddress](#emailaddress)
- [emailaddress1](#emailaddress1)
- [evaluatefit](#evaluatefit)
- [ext_amt](#ext_amt)
- [extendedamount](#extendedamount)
- [fetchxml](#fetchxml)
- [filedebrief](#filedebrief)
- [filename](#filename)
- [firstname](#firstname)
- [freighttermscode](#freighttermscode)
- [from](#from)
- [fullname](#fullname)
- [goalenddate](#goalenddate)
- [goalid](#goalid)
- [goalownerid](#goalownerid)
- [goalrollupqueryid](#goalrollupqueryid)
- [goalstartdate](#goalstartdate)
- [identifycompetitors](#identifycompetitors)
- [identifycustomercontacts](#identifycustomercontacts)
- [identifypursuitteam](#identifypursuitteam)
- [incidentid](#incidentid)
- [initialcommunication](#initialcommunication)
- [internalemailaddress](#internalemailaddress)
- [invline.productid](#invlineproductid)
- [invoicedetailid](#invoicedetailid)
- [invoiceid](#invoiceid)
- [invoicenumber](#invoicenumber)
- [isamount](#isamount)
- [isfiscalperiodgoal](#isfiscalperiodgoal)
- [isocurrencycode](#isocurrencycode)
- [ispriceoverridden](#ispriceoverridden)
- [isproductoverridden](#isproductoverridden)
- [jobtitle](#jobtitle)
- [lastname](#lastname)
- [manualdiscountamount](#manualdiscountamount)
- [metricid](#metricid)
- [mimetype](#mimetype)
- [mobilephone](#mobilephone)
- [modifiedon](#modifiedon)
- [need](#need)
- [objectid](#objectid)
- [objecttypecode](#objecttypecode)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [opportunityratingcode](#opportunityratingcode)
- [parentcustomerid](#parentcustomerid)
- [parentgoalid](#parentgoalid)
- [parentsystemuserid](#parentsystemuserid)
- [partyid](#partyid)
- [phonenumber](#phonenumber)
- [presentfinalproposal](#presentfinalproposal)
- [presentproposal](#presentproposal)
- [priceperunit](#priceperunit)
- [primarycontactid](#primarycontactid)
- [prioritycode](#prioritycode)
- [prod.productid](#prodproductid)
- [productdescription](#productdescription)
- [productid](#productid)
- [productname](#productname)
- [productnumber](#productnumber)
- [producttypecode](#producttypecode)
- [pursuitdecision](#pursuitdecision)
- [qualificationcomments](#qualificationcomments)
- [quantity](#quantity)
- [queryentitytype](#queryentitytype)
- [queueid](#queueid)
- [queueitemid](#queueitemid)
- [quotecomments](#quotecomments)
- [quotedetailid](#quotedetailid)
- [quoteid](#quoteid)
- [record1id](#record1id)
- [record1roleid](#record1roleid)
- [record2id](#record2id)
- [record2roleid](#record2roleid)
- [regardingobjectid](#regardingobjectid)
- [requestdeliveryby](#requestdeliveryby)
- [resolvefeedback](#resolvefeedback)
- [roleid](#roleid)
- [rolluponlyfromchildgoals](#rolluponlyfromchildgoals)
- [rollupqueryactualmoneyid](#rollupqueryactualmoneyid)
- [salesorderdetailid](#salesorderdetailid)
- [salesorderdetailname](#salesorderdetailname)
- [salesorderid](#salesorderid)
- [salesrepid](#salesrepid)
- [salesstagecode](#salesstagecode)
- [scheduledend](#scheduledend)
- [sendthankyounote](#sendthankyounote)
- [shippingmethodcode](#shippingmethodcode)
- [shipto_line1](#shipto_line1)
- [shipto_line2](#shipto_line2)
- [shipto_line3](#shipto_line3)
- [shipto_name](#shipto_name)
- [shipto_postalcode](#shipto_postalcode)
- [shipto_stateorprovince](#shipto_stateorprovince)
- [statecode](#statecode)
- [stateorprovince](#stateorprovince)
- [statuscode](#statuscode)
- [subject](#subject)
- [systemuserid](#systemuserid)
- [tax](#tax)
- [teamid](#teamid)
- [teamtype](#teamtype)
- [telephone1](#telephone1)
- [title](#title)
- [tm.systemuserid](#tmsystemuserid)
- [to](#to)
- [uomid](#uomid)
- [{0}](#0)

**Fields on forms but never in logic (24):**

- [actioncards](#actioncards)
- [activities](#activities)
- [azt_assignedamid](#azt_assignedamid)
- [azt_iscrossselloppty](#azt_iscrossselloppty)
- [azt_renewalnotes](#azt_renewalnotes)
- [cadencewidgetcontrol](#cadencewidgetcontrol)
- [competitors](#competitors)
- [discounts](#discounts)
- [documents](#documents)
- [documentssubgrid](#documentssubgrid)
- [dynamicpropertieslist_linkcontrol](#dynamicpropertieslist_linkcontrol)
- [msdyn_forecastcategory](#msdyn_forecastcategory)
- [notescontrol](#notescontrol)
- [opportunityaudit](#opportunityaudit)
- [opportunityproductsgrid](#opportunityproductsgrid)
- [productsuggestions_linkcontrol](#productsuggestions_linkcontrol)
- [pursuit_team](#pursuit_team)
- [quote](#quote)
- [ricontainer_charts](#ricontainer_charts)
- [stakeholders](#stakeholders)
- [totalamountlessfreight](#totalamountlessfreight)
- [totallineitemamount](#totallineitemamount)
- [totaltax](#totaltax)
- [webresource_recordwall](#webresource_recordwall)

---

## Index

Alphabetical field index -- 446 unique fields referenced.

#### !process_custom_attribute_url_

- [Workflow: BatchOpportunityTransfer (Read)](#79-batchopportunitytransfer)
- [Workflow: WonOpportunityEmail (Read)](#758-wonopportunityemail)

#### a_887fa82ffe04e911a94d000d3a3b9f01.address1_city

- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)

#### a_887fa82ffe04e911a94d000d3a3b9f01.address1_stateorprovince

- [View: My Initial/Add-on Opportunities Added Last Week](#310-my-initialadd-on-opportunities-added-last-week)
- [View: My Initial/Add-on Opportunities Added This Month](#311-my-initialadd-on-opportunities-added-this-month)
- [View: My Initial/Add-on Opportunities Added This Week](#312-my-initialadd-on-opportunities-added-this-week)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)
- [View: My Opportunities Closing This Month](#321-my-opportunities-closing-this-month)
- [View: My Opportunities Won This Year No Renewals](#326-my-opportunities-won-this-year-no-renewals)

#### a_ef7baa35fe04e911a94d000d3a3b9f01.address1_city

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

#### a_ef7baa35fe04e911a94d000d3a3b9f01.address1_composite

- [View: My Overdue Opportunities](#327-my-overdue-opportunities)

#### a_ef7baa35fe04e911a94d000d3a3b9f01.address1_stateorprovince

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

#### a_ef7baa35fe04e911a94d000d3a3b9f01.azt_verticalmarket

- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)

#### a_ef7baa35fe04e911a94d000d3a3b9f01.ownerid

- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Open Opportunities](#332-open-opportunities)

#### accountid

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

#### actioncards

- [Form: iGrad > Summary > Assistant](#22-igrad---main---active)

#### activities

- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)

#### activityid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Image)](#1059-phonecallcreatecallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### activitytypecode

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)

#### actualclosedate

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Footer)](#22-igrad---main---active)
- [Form: Opportunity (Footer)](#23-opportunity---main---active)
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

#### actualvalue

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

#### actualvalue_base

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: GEDSRM Opps](#36-gedsrm-opps)

#### address1_city

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

#### address1_composite

- [View: My Overdue Opportunities](#327-my-overdue-opportunities)

#### address1_stateorprovince

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

#### address1_telephone1

- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

#### adx_resolutiondate

- [Plugin: CaseClose (Write)](#1015-caseclose)

#### amountdatatype

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

#### annotationid

- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### associatedconnectionroleid

- [Plugin: ContactSetConnectionRole (Join)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Join)](#1075-setprimarycontact)

#### azt_account

- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)

#### azt_accountclassification

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
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

#### azt_accountid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Filter)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### azt_accountleadgenerationid

- [Plugin: AccountLeadGen (Filter)](#102-accountleadgen)
- [Plugin: AccountLeadGenAssociate (Read)](#103-accountleadgenassociate)
- [Plugin: AccountLeadGenAssociate (Filter)](#103-accountleadgenassociate)

#### azt_accountleadgenname

- [Plugin: AccountLeadGenAssociate (Write)](#103-accountleadgenassociate)

#### azt_accounttype

- [Plugin: AccountTypeSet (Write)](#105-accounttypeset)

#### azt_addonopportunitytotal

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [Formula: azt_addonopportunitytotal (Target)](#9-formulas-and-rollups)

#### azt_addonopportunitytotal_base

- [Field Definitions](#1-field-definitions)

#### azt_addresssearch

- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

#### azt_addresssearch2

- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

#### azt_addtocrtqueue

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_ageendedstage

- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

#### azt_allocatedtoid

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_allocationtype

- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_amount

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Read)](#1081-utility)

#### azt_annualspend

- [Plugin: FundingSetAnnualSpend (Write)](#1028-fundingsetannualspend)

#### azt_approvalstatus

- [Formula: azt_discretionarydiscount](#9-formulas-and-rollups)
- [Plugin: OpportunityPreventCreateQuote (Read)](#1047-opportunitypreventcreatequote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)

#### azt_assignedamid

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Relationship: azt_amsystemuser_opportunity](#12-relationships)

#### azt_autocreatecallback

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_autonumberid

- [Plugin: AutoNumber (Read)](#1013-autonumber)
- [Plugin: AutoNumber (Write)](#1013-autonumber)

#### azt_azteccustomerid

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_bookingurl

- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)
- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

#### azt_callbackin

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_callbackon

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_caseid

- [Plugin: CaseAudit (Write)](#1014-caseaudit)

#### azt_commissionamount

- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)

#### azt_commissionid

- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: Utility (Read)](#1081-utility)

#### azt_commissionpaymentid

- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)

#### azt_committoestimatedclose

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)

#### azt_companyname

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_compcompleted

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)

#### azt_compgoalid

- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

#### azt_compgoaltypeid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)

#### azt_compplanamountid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)

#### azt_concurrentusers

- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_copydescription

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_copysubject

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_currentnumber

- [Plugin: AutoNumber (Read)](#1013-autonumber)
- [Plugin: AutoNumber (Write)](#1013-autonumber)

#### azt_customerid

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_customertrainingid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)

#### azt_dateexitedstage

- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

#### azt_dayssincecreated

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [Formula: azt_dayssincecreated (Target)](#9-formulas-and-rollups)

#### azt_dayssinceprobabilitychanged

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Aged or Stuck Opportunities (Filter)](#38-my-aged-or-stuck-opportunities)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [Formula: azt_dayssinceprobabilitychanged (Target)](#9-formulas-and-rollups)

#### azt_defaultfreightamount

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Freight](#22-igrad---main---active)
- [Form: Opportunity > Products > Freight](#23-opportunity---main---active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#810-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#814-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_defaultfreightamount_base

- [Field Definitions](#1-field-definitions)

#### azt_deliverytype

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### azt_description

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_discountamount

- [Formula: azt_discretionarydiscount](#9-formulas-and-rollups)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)

#### azt_discretionarydiscount

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity---main---active)
- [Formula: azt_discretionarydiscount (Target)](#9-formulas-and-rollups)

#### azt_discretionarydiscount_base

- [Field Definitions](#1-field-definitions)

#### azt_discretionarydiscountamt

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity---main---active)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)

#### azt_discretionarydiscountamt_base

- [Field Definitions](#1-field-definitions)

#### azt_duedate

- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### azt_effectivedate

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)

#### azt_email

- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImportPopulateName (Read)](#1037-leadimportpopulatename)

#### azt_enddate

- [Plugin: EngagementSetEndDate (Write)](#1025-engagementsetenddate)

#### azt_engagementid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: EngagementFSRAssignedOn (Read)](#1024-engagementfsrassignedon)
- [Plugin: EngagementFSRAssignedOn (Write)](#1024-engagementfsrassignedon)
- [Plugin: EngagementSetEndDate (Write)](#1025-engagementsetenddate)

#### azt_estfulfillmentdate

- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### azt_evaluate

- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Image)](#102-accountleadgen)

#### azt_expectedrenewalvalue

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [View: Open Renewal Opps 90 Days Past Due](#333-open-renewal-opps-90-days-past-due)
- [View: Open Renewal Opps Close Date Last Month](#334-open-renewal-opps-close-date-last-month)
- [View: Open Renewal Opps Closing Next Month](#335-open-renewal-opps-closing-next-month)
- [View: Open Renewal Opps Closing This Month](#336-open-renewal-opps-closing-this-month)
- [View: Open Renewal Opps Closing Within 90 Days](#337-open-renewal-opps-closing-within-90-days)
- [View: Won Renewal Opps This Month](#363-won-renewal-opps-this-month)
- [View: Won Renewal Opps This Quarter](#364-won-renewal-opps-this-quarter)
- [View: Won Renewal Opps This Year](#365-won-renewal-opps-this-year)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)

#### azt_expectedrenewalvalue_base

- [Field Definitions](#1-field-definitions)

#### azt_expenseamount

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)

#### azt_expenseid

- [Plugin: CloneExpenseLine (Filter)](#1017-cloneexpenseline)

#### azt_expensereportid

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Filter)](#1026-expenselinetotals)

#### azt_expensetype

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_expirationdate

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_extension

- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

#### azt_fieldtoautonumber

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_firstname

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_fiscalperiodend

- [Plugin: Utility (Write)](#1081-utility)
- [Plugin: Utility (Filter)](#1081-utility)

#### azt_fiscalperiodstart

- [Plugin: CreateCompGoals (Sort)](#1020-createcompgoals)
- [Plugin: Utility (Write)](#1081-utility)

#### azt_freightamtapproved

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Freight](#22-igrad---main---active)
- [Form: Opportunity > Products > Freight](#23-opportunity---main---active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#810-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#814-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_fsrassignedon

- [Plugin: EngagementFSRAssignedOn (Write)](#1024-engagementfsrassignedon)

#### azt_fsremail

- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

#### azt_fsrid

- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

#### azt_fsrmobiletelephone

- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

#### azt_fsrtelephone

- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

#### azt_fsrtelephoneextension

- [Plugin: OrderFSRSetTemplateFields (Write)](#1052-orderfsrsettemplatefields)

#### azt_fundingid

- [Plugin: FundingSetAnnualSpend (Write)](#1028-fundingsetannualspend)
- [Plugin: FundingTotalAmt (Write)](#1029-fundingtotalamt)

#### azt_fundingsource

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column2](#25-opportunity---quickcreate---active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick---quickcreate---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### azt_fundingyear

- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: FundingYearSync (Read)](#1030-fundingyearsync)

#### azt_goaltype

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### azt_historicalowner

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Write)](#716-cloneanddeletequote)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### azt_importname

- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImportPopulateName (Read)](#1037-leadimportpopulatename)

#### azt_initialopportunitytotal

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [Formula: azt_initialopportunitytotal (Target)](#9-formulas-and-rollups)

#### azt_initialopportunitytotal_base

- [Field Definitions](#1-field-definitions)

#### azt_internalaztecnotes

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### azt_invoiceid

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

#### azt_invoicenumber

- [Field Definitions](#1-field-definitions)

#### azt_invoiceproductid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#1063-quoteorderproductstrackdiscount)

#### azt_isbn

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_iscompanion

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### azt_iscrossselloppty

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)

#### azt_isprint

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### azt_issaas

- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: SetOppProductDefaults (Write)](#1074-setoppproductdefaults)

#### azt_jobrole

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

#### azt_jobtitle

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_lastactivitydate

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [Plugin: OpportunityLastActivityDate (Write)](#1045-opportunitylastactivitydate)

#### azt_lastmodifiedbyid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [JS: azt_opportunitylibrary > onLoad()](#810-azt_opportunitylibrary)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Relationship: azt_systemusermodified_opportunity](#12-relationships)

#### azt_lastname

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_leadimportid

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### azt_leadsource

- [Field Definitions](#1-field-definitions)

#### azt_leadsourceid

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
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

#### azt_licensestatus

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_licenseterm

- [Plugin: OrderLinePopulateLicType (Read)](#1053-orderlinepopulatelictype)

#### azt_licensetermmonths

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

#### azt_licensetype

- [Formula: azt_addonopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-and-rollups)
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

#### azt_masecommission

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

#### azt_mileage

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_monthstofilteron

- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)
- [Plugin: AccountLeadGen (Image)](#102-accountleadgen)

#### azt_name

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

#### azt_newestclosedate

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_newestimatedvalue

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_newownerid

- [Plugin: CaseAudit (Write)](#1014-caseaudit)

#### azt_newprobability

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_nonsaasstatus

- [Plugin: AccountTypeSet (Read)](#105-accounttypeset)
- [Plugin: AccountTypeSet (Image)](#105-accounttypeset)

#### azt_nonsaastype

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### azt_numberoflicenses

- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_opportunityauditrecordid

- [Plugin: OppAuditRemoval (Read)](#1041-oppauditremoval)

#### azt_opportunityid

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

#### azt_opportunityleadid

- [Relationship: azt_opportunity_lead](#12-relationships)

#### azt_opportunitynumber

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Open Opportunities](#316-my-open-opportunities)
- [View: Open Opportunities](#332-open-opportunities)
- [View: Quick Find Open Opportunities (Filter)](#354-quick-find-open-opportunities)
- [View: Won Opportunities](#362-won-opportunities)

#### azt_opportunityproductcategory

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
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

#### azt_opportunityproductid

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

#### azt_opportunitytype

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column2](#25-opportunity---quickcreate---active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick---quickcreate---active)
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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
- [View: Overdue Opportunities > 45 Days (Filter)](#353-overdue-opportunities--45-days)
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

#### azt_orderid

- [Plugin: CompGoalCreate (Write)](#1018-compgoalcreate)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)
- [Plugin: OrderStageTracking (Filter)](#1057-orderstagetracking)
- [Plugin: ShipmentSetTrackingNumber (Read)](#1079-shipmentsettrackingnumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#1079-shipmentsettrackingnumber)

#### azt_orderlineid

- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: ShipmentSetTrackingNumber (Sort)](#1079-shipmentsettrackingnumber)

#### azt_orderproductid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#1063-quoteorderproductstrackdiscount)
- [Plugin: QuoteOrderProductsTrackDiscount (Filter)](#1063-quoteorderproductstrackdiscount)

#### azt_orderstageid

- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)
- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

#### azt_ordertemplatelines

- [Plugin: OrderLinePopulateTemplateFields (Write)](#1054-orderlinepopulatetemplatefields)

#### azt_ordertype

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_originatingleadimportid

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### azt_otheropportunitytotal

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [Formula: azt_otheropportunitytotal (Target)](#9-formulas-and-rollups)

#### azt_otheropportunitytotal_base

- [Field Definitions](#1-field-definitions)

#### azt_paid

- [Plugin: Utility (Write)](#1081-utility)

#### azt_paidon

- [Plugin: FundingSetAnnualSpend (Filter)](#1028-fundingsetannualspend)
- [Plugin: Utility (Write)](#1081-utility)

#### azt_parentopportunityid

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityAudit (Image)](#1043-opportunityaudit)
- [Relationship: azt_opportunity_clonedopportunity](#12-relationships)

#### azt_parentorderid

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### azt_payablecommission

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

#### azt_paymentdate

- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Sort)](#1081-utility)

#### azt_paymentid

- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Read)](#1081-utility)

#### azt_percentage

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

#### azt_percentagepaid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

#### azt_periodend

- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

#### azt_periodstart

- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)

#### azt_phone

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_pilotopportunitytotal

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [Formula: azt_pilotopportunitytotal (Target)](#9-formulas-and-rollups)

#### azt_pilotopportunitytotal_base

- [Field Definitions](#1-field-definitions)

#### azt_pipelinestage

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Quick Find Open Opportunities](#354-quick-find-open-opportunities)
- [View: Recent Opportunities](#355-recent-opportunities)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### azt_ponumber

- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### azt_prefix

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_prefixhasseparator

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_prefixseparator

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_prefixseparatorisspace

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_previewcompleted

- [Field Definitions](#1-field-definitions)

#### azt_previousestclosedate

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_previousestimatedvalue

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_previousownerid

- [Plugin: CaseAudit (Write)](#1014-caseaudit)

#### azt_previousprobability

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_printopportunitytotal

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [Formula: azt_printopportunitytotal (Target)](#9-formulas-and-rollups)

#### azt_printopportunitytotal_base

- [Field Definitions](#1-field-definitions)

#### azt_printproductid

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_printpurchaseid

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_probability

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column2](#25-opportunity---quickcreate---active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick---quickcreate---active)
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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
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

#### azt_probabilitychangedon

- [Field Definitions](#1-field-definitions)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Filter)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: My Aged or Stuck Opportunities](#38-my-aged-or-stuck-opportunities)
- [View: My Aged or Stuck Opportunities (Sort)](#38-my-aged-or-stuck-opportunities)
- [View: My Overdue Opps](#328-my-overdue-opps)
- [View: My Stalled Opportunities](#329-my-stalled-opportunities)
- [View: My Stalled Opportunities (Filter)](#329-my-stalled-opportunities)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-and-rollups)
- [Plugin: OpportunityProbabilityChange (Write)](#1048-opportunityprobabilitychange)

#### azt_probabilityincreased

- [Field Definitions](#1-field-definitions)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Filter)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [Plugin: OpportunityProbabilityChange (Write)](#1048-opportunityprobabilitychange)

#### azt_productdiscountid

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

#### azt_producttype

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#1035-invoicecompcompleted)

#### azt_purchasedate

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_quantity

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_quotenumber

- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### azt_quoteproductid

- [Plugin: ActivateOrReviseQuote (Filter)](#106-activateorrevisequote)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)
- [Plugin: ProductDiscountPreventOnActiveQuote (Read)](#1060-productdiscountpreventonactivequote)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Filter)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)
- [Plugin: ReviseQuoteDiscountMove (Filter)](#1072-revisequotediscountmove)
- [Plugin: Utility (Filter)](#1081-utility)

#### azt_quotesent

- [Field Definitions](#1-field-definitions)

#### azt_reasonforexpense

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_recordowner

- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)

#### azt_recordownerid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad---main---active)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity (Header)](#23-opportunity---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Form: Opportunity Record Owner > Tab > section](#27-opportunity-record-owner---quick---active)
- [Form: Opportunity Owner Quick View > Opportunity Owner > Opportunity Owner](#28-opportunity-owner-quick-view---quick---active)
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
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
- [View: Overdue Opportunities > 45 Days (Sort)](#353-overdue-opportunities--45-days)
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

#### azt_renewalnotes

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Details](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity---main---active)

#### azt_renewalopportunitytotal

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [Formula: azt_renewalopportunitytotal (Target)](#9-formulas-and-rollups)

#### azt_renewalopportunitytotal_base

- [Field Definitions](#1-field-definitions)

#### azt_reorderopportunityid

- [Relationship: azt_opportunity_task](#12-relationships)

#### azt_replacementproductid

- [Plugin: Utility (Read)](#1081-utility)

#### azt_requestedfreightamt

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Freight](#22-igrad---main---active)
- [Form: Opportunity > Products > Freight](#23-opportunity---main---active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#810-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#814-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_requestedfreightamt_base

- [Field Definitions](#1-field-definitions)

#### azt_resolvedbyid

- [Plugin: CaseClose (Read)](#1015-caseclose)
- [Plugin: CaseClose (Write)](#1015-caseclose)

#### azt_result

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### azt_saas

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: Utility (Read)](#1081-utility)

#### azt_saasstatus

- [Plugin: AccountTypeSet (Read)](#105-accounttypeset)
- [Plugin: AccountTypeSet (Image)](#105-accounttypeset)

#### azt_salesrepid

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#1035-invoicecompcompleted)

#### azt_salesstage

- [Field Definitions](#1-field-definitions)
- [Workflow: OpportunitySalesProcessAdvanceBPF (Write)](#741-opportunitysalesprocessadvancebpf)

#### azt_softwarelicenseid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: AllocationValidation (Filter)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_softwareproductid

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_startdate

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_stateabbreviation

- [Plugin: AccountAutoAssign (Filter)](#101-accountautoassign)

#### azt_stateprovince

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_suffix

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_suffixhasseparator

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_suffixseparator

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_suffixseparatorisspace

- [Plugin: AutoNumber (Read)](#1013-autonumber)

#### azt_supportexpirationdate

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_total

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)

#### azt_totalamountpaid

- [Plugin: Utility (Write)](#1081-utility)

#### azt_totalfunding

- [Plugin: FundingTotalAmt (Write)](#1029-fundingtotalamt)

#### azt_totalreimbursement

- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)

#### azt_trackingnumber

- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: ShipmentSetTrackingNumber (Read)](#1079-shipmentsettrackingnumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#1079-shipmentsettrackingnumber)

#### azt_trackingnumbers

- [Plugin: ShipmentSetTrackingNumber (Write)](#1079-shipmentsettrackingnumber)

#### azt_trainingid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)

#### azt_verticalmarket

- [View: My Opportunities Closing Next Year](#318-my-opportunities-closing-next-year)
- [View: My Opportunities Closing This Fiscal Quarter](#319-my-opportunities-closing-this-fiscal-quarter)
- [View: My Opportunities Closing This Fiscal Year](#320-my-opportunities-closing-this-fiscal-year)

#### azt_webinarpresentationcompleted

- [Field Definitions](#1-field-definitions)

#### azt_winbackopportunitytotal

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Rollup Totals](#22-igrad---main---active)
- [Form: Opportunity > Summary > Rollup Totals](#23-opportunity---main---active)
- [Formula: azt_winbackopportunitytotal (Target)](#9-formulas-and-rollups)

#### azt_winbackopportunitytotal_base

- [Field Definitions](#1-field-definitions)

#### azt_year

- [Plugin: FundingYearSync (Write)](#1030-fundingyearsync)

#### baseamount

- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

#### billto_line1

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_line2

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_line3

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_name

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_postalcode

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_stateorprovince

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### body

- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### bpf_duration

- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)

#### bpf_salesorderid

- [Plugin: OrderStageTracking (Filter)](#1057-orderstagetracking)

#### budgetamount

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### budgetstatus

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### businessprocessflowinstanceid

- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)

#### businessunitid

- [Plugin: AccountAutoAssign (Read)](#101-accountautoassign)
- [Plugin: ExpenseRestrictVisibility (Read)](#1027-expenserestrictvisibility)
- [Plugin: GetUserHasRole (Read)](#1032-getuserhasrole)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Plugin: RestrictProductLookups (Read)](#1069-restrictproductlookups)
- [Plugin: RestrictWinOpportunities (Read)](#1070-restrictwinopportunities)
- [Plugin: RestrictWinQuote (Read)](#1071-restrictwinquote)
- [Plugin: Utility (Read)](#1081-utility)

#### cadencewidgetcontrol

- [Form: iGrad > Summary > Up next](#22-igrad---main---active)

#### captureproposalfeedback

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### category

- [Plugin: ContactSetConnectionRole (Sort)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Sort)](#1075-setprimarycontact)

#### city

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### closeprobability

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [View: My Open Renewal Opportunities as Account Owner](#317-my-open-renewal-opportunities-as-account-owner)
- [View: Open Opportunities by Sales Rep](#331-open-opportunities-by-sales-rep)
- [Chart: Sales Pipeline (Group-By)](#421-sales-pipeline)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Chart: Opportunities Closing This Month (Filter)](#423-opportunities-closing-this-month)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: OpportunityProbabilityNumber (Write)](#1049-opportunityprobabilitynumber)

#### companyname

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### competitors

- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: iGrad > Summary > Competitors](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)

#### completefinalproposal

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### completeinternalreview

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### conditionbranchstep2_1

- [Formula: azt_dayssincecreated](#9-formulas-and-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-and-rollups)

#### confirminterest

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### connectionid

- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)

#### connectionroleid

- [Plugin: ContactSetConnectionRole (Read)](#1019-contactsetconnectionrole)
- [Plugin: ContactSetConnectionRole (Join)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Join)](#1075-setprimarycontact)

#### consideronlygoalownersrecords

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### contactid

- [Field Definitions](#1-field-definitions)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)

#### country

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### county

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### createdby

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Footer)](#22-igrad---main---active)
- [Form: Opportunity (Footer)](#23-opportunity---main---active)
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

#### createdon

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Footer)](#22-igrad---main---active)
- [Form: Opportunity (Footer)](#23-opportunity---main---active)
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
- [Formula: azt_dayssincecreated](#9-formulas-and-rollups)
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

#### crm3_expenseamount

- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)

#### crm3_parentleadid

- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Filter)](#1026-expenselinetotals)

#### currentsituation

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Details](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### customerid

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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
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

#### customerneed

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity---main---active)
- [Form: Opportunity Quick > Tab > Customer Info](#26-opportunity-quick---quickcreate---active)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### customerpainpoints

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### datefulfilled

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### decisionmaker

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### defaultuomid

- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### description

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

#### developproposal

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### discountamount

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity---main---active)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)

#### discountpercentage

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### discounts

- [Form: iGrad > Discretionary Discounts > Section](#22-igrad---main---active)
- [Form: Opportunity > Discretionary Discounts > Section](#23-opportunity---main---active)

#### documents

- [Form: iGrad > Documents > Section](#22-igrad---main---active)
- [Form: Opportunity > Documents > Section](#23-opportunity---main---active)

#### documentssubgrid

- [Form: iGrad > Files > Documents Section](#22-igrad---main---active)

#### dynamicpropertieslist_linkcontrol

- [Form: iGrad > Product line items > Dynamic properties](#22-igrad---main---active)

#### emailaddress

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### emailaddress1

- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadImport (Filter)](#1036-leadimport)

#### estimatedclosedate

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick---quickcreate---active)
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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
- [View: Overdue Opportunities > 45 Days (Filter)](#353-overdue-opportunities--45-days)
- [View: Overdue Opportunities > 45 Days (Sort)](#353-overdue-opportunities--45-days)
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

#### estimatedvalue

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad---main---active)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column3](#25-opportunity---quickcreate---active)
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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
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

#### evaluatefit

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### ext_amt

- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)

#### extendedamount

- [Formula: azt_addonopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-and-rollups)
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

#### fetchxml

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### filedebrief

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### filename

- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### firstname

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### fiscalperiod

- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

#### freightamount

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity---main---active)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### freighttermscode

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### from

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### fullname

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Sort)](#1036-leadimport)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Sort)](#1081-utility)

#### goalenddate

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### goalid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

#### goalownerid

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### goalrollupqueryid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

#### goalstartdate

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### identifycompetitors

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### identifycustomercontacts

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### identifypursuitteam

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### incidentid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: CaseClose (Write)](#1015-caseclose)

#### initialcommunication

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### internalemailaddress

- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

#### invline.productid

- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)

#### invoicedetailid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#1063-quoteorderproductstrackdiscount)

#### invoiceid

- [Plugin: AccountLeadGen (Join)](#102-accountleadgen)
- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateCompGoals (Filter)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Join)](#1022-createusergoals)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#1023-discretionarydiscountsetheader)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: Utility (Write)](#1081-utility)

#### invoicenumber

- [Plugin: CompGoalCreate (Read)](#1018-compgoalcreate)

#### isamount

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

#### isfiscalperiodgoal

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### isocurrencycode

- [Plugin: Utility (Filter)](#1081-utility)

#### ispriceoverridden

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

#### isproductoverridden

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)

#### isrevenuesystemcalculated

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Opportunity Products](#22-igrad---main---active)
- [Form: Opportunity > Products > Opportunity Products](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)
- [Plugin: QuoteSyncTotalToOpportunity (Write)](#1066-quotesynctotaltoopportunity)

#### jobtitle

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### lastname

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### manualdiscountamount

- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: ManualDiscountKill (Read)](#1040-manualdiscountkill)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)

#### metricid

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### mimetype

- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### mobilephone

- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

#### modifiedon

- [Field Definitions](#1-field-definitions)
- [View: Recent Opportunities (Sort)](#355-recent-opportunities)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: OpportunityLineSyncToQuote (Sort)](#1046-opportunitylinesynctoquote)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Sort)](#1080-updateoppfromquote)

#### msa_partnerid

- [Field Definitions](#1-field-definitions)
- [Relationship: msa_partner_opportunity](#12-relationships)

#### msa_partneroppid

- [Field Definitions](#1-field-definitions)
- [Relationship: msa_contact_opportunity](#12-relationships)

#### msdyn_forecastcategory

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)

#### msdyn_opportunitykpiid

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_opportunitykpiitem_opportunity_opportunitykpiid](#12-relationships)

#### msdyn_predictivescoreid

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_predictivescore_opportunity](#12-relationships)

#### msdyn_segmentid

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_segment_opportunity](#12-relationships)

#### name

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick---quickcreate---active)
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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Out of Territory Opportunities - Open (Sort)](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
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

#### need

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### new_sharedwith

- [View: Out of Territory Opportunities - Open (Filter)](#352-out-of-territory-opportunities---open)

#### notescontrol

- [Form: iGrad > Notes > Notes pane](#22-igrad---main---active)
- [Form: Opportunity > Notes > Notes pane](#23-opportunity---main---active)

#### objectid

- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### objecttypecode

- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### opportunityaudit

- [Form: iGrad > Summary > Opportunity Audit](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Audit](#23-opportunity---main---active)

#### opportunityid

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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
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

#### opportunityproductid

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

#### opportunityproductsgrid

- [Form: iGrad > Product line items > Opportunity Products](#22-igrad---main---active)
- [Form: Opportunity > Products > Opportunity Products](#23-opportunity---main---active)

#### opportunityratingcode

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### originatingleadid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: OpportunityAssignFromLead (Read)](#1042-opportunityassignfromlead)
- [Relationship: opportunity_originating_lead](#12-relationships)

#### ownerid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad---main---active)
- [Form: Opportunity > newOpportunity > quickOpportunity_column3](#25-opportunity---quickcreate---active)
- [Form: Opportunity Owner Quick View > Opportunity Owner > Opportunity Owner](#28-opportunity-owner-quick-view---quick---active)
- [Form: Order Opportunity Owner Quick View > Tab > section](#29-order-opportunity-owner-quick-view---quick---active)
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
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
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

#### owningbusinessunit

- [Field Definitions](#1-field-definitions)
- [View: Executive Sales Measure 30 Day Pipeline](#34-executive-sales-measure-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Executive Sales Measure Advanced 30 Day Pipeline (Sort)](#35-executive-sales-measure-advanced-30-day-pipeline)
- [View: Overdue Opportunities > 45 Days](#353-overdue-opportunities--45-days)
- [View: Self Sourced Pipeline per rep in Last 30 Days](#356-self-sourced-pipeline-per-rep-in-last-30-days)

#### owningteam

- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)

#### owninguser

- [Plugin: GetAcctTeamOwned (Join)](#1031-getacctteamowned)

#### parentaccountid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad (Header)](#22-igrad---main---active)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: iGrad > LinkedIn Sales Navigator > LinkedIn Account Profile](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick---quickcreate---active)
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

#### parentcontactid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Summary > Opportunity Information](#22-igrad---main---active)
- [Form: iGrad > LinkedIn Sales Navigator > LinkedIn Member Profile](#22-igrad---main---active)
- [Form: iGrad > LinkedIn Sales Navigator > LinkedIn InMail](#22-igrad---main---active)
- [Form: Opportunity > Summary > Opportunity Information](#23-opportunity---main---active)
- [Form: Opportunity Quick > Tab > section](#26-opportunity-quick---quickcreate---active)
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

#### parentcustomerid

- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### parentgoalid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### parentsystemuserid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: Utility (Read)](#1081-utility)

#### partyid

- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### phonenumber

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### presentfinalproposal

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### presentproposal

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### pricelevelid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Opportunity Products](#22-igrad---main---active)
- [Form: Opportunity > Products > Opportunity Products](#23-opportunity---main---active)
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

#### priceperunit

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

#### primarycontactid

- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

#### prioritycode

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### prod.productid

- [Plugin: AccountLeadGen (Read)](#102-accountleadgen)

#### productdescription

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

#### productid

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

#### productname

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)

#### productnumber

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: RestrictProductLookups (Filter)](#1069-restrictproductlookups)
- [Plugin: Utility (Filter)](#1081-utility)

#### productsuggestions_linkcontrol

- [Form: iGrad > Product line items > Suggestions](#22-igrad---main---active)

#### producttypecode

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)

#### proposedsolution

- [Field Definitions](#1-field-definitions)
- [Form: Opportunity > Summary > Opportunity Details](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### purchaseprocess

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### purchasetimeframe

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Forecast/Activities > Section](#22-igrad---main---active)
- [Form: Opportunity > Forecast/Activities > Section](#23-opportunity---main---active)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### pursuit_team

- [Form: iGrad > Summary > Sales Team](#22-igrad---main---active)
- [Form: Opportunity > Summary > Sales Team](#23-opportunity---main---active)

#### pursuitdecision

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### qualificationcomments

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### quantity

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

#### queryentitytype

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### queueid

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### queueitemid

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### quote

- [Form: iGrad > Quotes > Quotes](#22-igrad---main---active)

#### quotecomments

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Read)](#719-cloneopportunity)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)

#### quotedetailid

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

#### quoteid

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

#### record1id

- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: LeadQualifyParentStakeholderContacts (Filter)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Filter)](#1075-setprimarycontact)

#### record1roleid

- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

#### record2id

- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: LeadQualifyParentStakeholderContacts (Sort)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Filter)](#1075-setprimarycontact)

#### record2roleid

- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Join)](#1075-setprimarycontact)

#### regardingobjectid

- [Plugin: AccountReassignmentShareRecords (Filter)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#1076-sharebasedonaccessteam)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)
- [Relationship: Opportunity_Phonecalls](#12-relationships)

#### requestdeliveryby

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### resolvefeedback

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### ricontainer_charts

- [Form: AI for Sales > RAV2 > RAV2_section_1](#21-ai-for-sales---main---active)

#### roleid

- [Plugin: GetUserHasRoleToAction (Read)](#1033-getuserhasroletoaction)
- [Plugin: GetUserHasRoleToAction (Filter)](#1033-getuserhasroletoaction)
- [Plugin: GetUserHasRoleToAction (Join)](#1033-getuserhasroletoaction)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Filter)](#1081-utility)
- [Plugin: Utility (Join)](#1081-utility)

#### rolluponlyfromchildgoals

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### rollupqueryactualmoneyid

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### rolluprulestep1_1

- [Formula: azt_addonopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-and-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-and-rollups)

#### rolluprulestep1_2

- [Formula: azt_addonopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-and-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-and-rollups)

#### rolluprulestep1_3

- [Formula: azt_addonopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-and-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-and-rollups)

#### rolluprulestep1_4

- [Formula: azt_addonopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-and-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-and-rollups)

#### rolluprulestep1_5

- [Formula: azt_addonopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_discretionarydiscount](#9-formulas-and-rollups)
- [Formula: azt_initialopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_otheropportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_pilotopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_printopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_renewalopportunitytotal](#9-formulas-and-rollups)
- [Formula: azt_winbackopportunitytotal](#9-formulas-and-rollups)

#### salesorderdetailid

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderLinePopulateLicType (Write)](#1053-orderlinepopulatelictype)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#1063-quoteorderproductstrackdiscount)

#### salesorderdetailname

- [Plugin: OrderLinePopulateTemplateFields (Read)](#1054-orderlinepopulatetemplatefields)

#### salesorderid

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

#### salesrepid

- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)

#### salesstage

- [Field Definitions](#1-field-definitions)

#### salesstagecode

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### scheduledend

- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#107-activitiescreatedduedatesinpast)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### sendthankyounote

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneOpportunity (Write)](#719-cloneopportunity)
- [Workflow: QualifyLead (Write)](#745-qualifylead)

#### setattributevaluestep4_1

- [Formula: azt_dayssincecreated](#9-formulas-and-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-and-rollups)

#### setattributevaluestep4_2

- [Formula: azt_dayssincecreated](#9-formulas-and-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-and-rollups)

#### setattributevaluestep4_3

- [Formula: azt_dayssincecreated](#9-formulas-and-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-and-rollups)

#### setattributevaluestep4_4

- [Formula: azt_dayssincecreated](#9-formulas-and-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-and-rollups)

#### setattributevaluestep4_5

- [Formula: azt_dayssincecreated](#9-formulas-and-rollups)
- [Formula: azt_dayssinceprobabilitychanged](#9-formulas-and-rollups)

#### shippingmethodcode

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_line1

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_line2

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_line3

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_name

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_postalcode

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_stateorprovince

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### stakeholders

- [Form: iGrad > Summary > Sales Team](#22-igrad---main---active)

#### state

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### statecode

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
- [View: Out of Territory Opportunities - Open (Filter)](#352-out-of-territory-opportunities---open)
- [View: Overdue Opportunities > 45 Days (Filter)](#353-overdue-opportunities--45-days)
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

#### stateorprovince

- [Plugin: AutoAssignStateAbb (Read)](#1012-autoassignstateabb)
- [Plugin: AutoAssignStateAbb (Write)](#1012-autoassignstateabb)

#### statuscode

- [Field Definitions](#1-field-definitions)
- [View: All Opportunities](#31-all-opportunities)
- [View: Closed Opportunities in Current Fiscal Year](#32-closed-opportunities-in-current-fiscal-year)
- [View: Closed Opportunities](#33-closed-opportunities)
- [View: Lost Opportunities](#37-lost-opportunities)
- [View: My Closed Opportunities in Current Fiscal Year](#39-my-closed-opportunities-in-current-fiscal-year)
- [View: My Won Opps this Year](#330-my-won-opps-this-year)
- [View: Opportunity Advanced Find View](#349-opportunity-advanced-find-view)
- [View: Out of Territory Opportunities - Open](#352-out-of-territory-opportunities---open)
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

#### street

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### subject

- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### systemuserid

- [Plugin: GetAcctTeamOwned (Join)](#1031-getacctteamowned)
- [Plugin: GetUserHasRoleToAction (Filter)](#1033-getuserhasroletoaction)
- [Plugin: GetUserHasRoleToAction (Join)](#1033-getuserhasroletoaction)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)
- [Plugin: Utility (Filter)](#1081-utility)
- [Plugin: Utility (Join)](#1081-utility)

#### tax

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)

#### teamid

- [Plugin: AccountAutoAssign (Read)](#101-accountautoassign)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)

#### teamtype

- [Plugin: AccountAutoAssign (Filter)](#101-accountautoassign)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#1076-sharebasedonaccessteam)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)

#### telephone1

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### title

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

#### tm.systemuserid

- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)

#### to

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### totalamount

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### totalamountlessfreight

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)

#### totallineitemamount

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)

#### totaltax

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)

#### transactioncurrencyid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad > Product line items > Product Line Item Totals](#22-igrad---main---active)
- [Form: Opportunity > Products > Product Line Item Totals](#23-opportunity---main---active)
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

#### uomid

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: QuoteCloneAndDelete (Read)](#1061-quotecloneanddelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)

#### value

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### webresource_recordwall

- [Form: Information > What's New > Section](#24-information---main---inactive)

#### zipcode

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### {0}

- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
