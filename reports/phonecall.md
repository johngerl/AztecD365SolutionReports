# Phonecall Field Usage Analysis
> Date: 2026-03-21

## Table of Contents

- [1. Field Definitions](#1-field-definitions)
- [2. Forms](#2-forms)
  - [2.1. Phone Call (main) -- Active](#21-phone-call-main-active)
- [3. Views](#3-views)
  - [3.1. Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
  - [3.2. FSR Phone Calls This Month](#32-fsr-phone-calls-this-month)
  - [3.3. FSR Phone Calls This Quarter](#33-fsr-phone-calls-this-quarter)
  - [3.4. FSR Phone Calls This Week](#34-fsr-phone-calls-this-week)
  - [3.5. My Calls This Month](#35-my-calls-this-month)
  - [3.6. My Calls This Quarter](#36-my-calls-this-quarter)
  - [3.7. My Calls This Week](#37-my-calls-this-week)
  - [3.8. My Calls This Year](#38-my-calls-this-year)
  - [3.9. My Open Phonecalls](#39-my-open-phonecalls)
  - [3.10. Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
  - [3.11. Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
  - [3.12. Phone Calls This Month](#312-phone-calls-this-month)
  - [3.13. Phone Calls This Quarter](#313-phone-calls-this-quarter)
  - [3.14. Phone Calls This Week](#314-phone-calls-this-week)
  - [3.15. Phone Calls This Year](#315-phone-calls-this-year)
- [4. Chart Visualizations](#4-chart-visualizations)
  - [4.1. Phone Calls This Quarter By Rep](#41-phone-calls-this-quarter-by-rep)
  - [4.2. My Phone Calls This Quarter](#42-my-phone-calls-this-quarter)
  - [4.3. My Phone Calls This Year](#43-my-phone-calls-this-year)
  - [4.4. Phone Calls This Year By Owner](#44-phone-calls-this-year-by-owner)
  - [4.5. Phone Calls This Month By Rep](#45-phone-calls-this-month-by-rep)
  - [4.6. Phone Calls This Week By Rep](#46-phone-calls-this-week-by-rep)
  - [4.7. My Calls This Week](#47-my-calls-this-week)
  - [4.8. My Calls This Month](#48-my-calls-this-month)
- [5. Reports](#5-reports)
- [6. Dashboards](#6-dashboards)
  - [6.1. Activity Dashboard](#61-activity-dashboard)
  - [6.2. Monthly Account Manager KPIs](#62-monthly-account-manager-kpis)
  - [6.3. Monthly FSR KPIs](#63-monthly-fsr-kpis)
  - [6.4. My Annual KPIs](#64-my-annual-kpis)
  - [6.5. My FSR Quarterly Dashboard](#65-my-fsr-quarterly-dashboard)
  - [6.6. My Monthly FSR KPI's](#66-my-monthly-fsr-kpis)
  - [6.7. My Monthly KPI's](#67-my-monthly-kpis)
  - [6.8. My Quarterly KPIs](#68-my-quarterly-kpis)
  - [6.9. My Weekly KPIs](#69-my-weekly-kpis)
  - [6.10. Quarterly Account Manager KPIs](#610-quarterly-account-manager-kpis)
  - [6.11. Quarterly FSR KPIs](#611-quarterly-fsr-kpis)
  - [6.12. Weekly Account Manager KPIs](#612-weekly-account-manager-kpis)
  - [6.13. Weekly FSR KPIs](#613-weekly-fsr-kpis)
- [7. Workflows](#7-workflows)
  - [7.1. 0ChangeQuoteRecordOwner](#71-0changequoterecordowner)
  - [7.2. AccountAuto-Assign](#72-accountauto-assign)
  - [7.3. AppointmentAuto-Assign](#73-appointmentauto-assign)
  - [7.4. BatchCancelAppointments](#74-batchcancelappointments)
  - [7.5. BatchCancelPhoneCalls](#75-batchcancelphonecalls)
  - [7.6. BatchCreateEngagements](#76-batchcreateengagements)
  - [7.7. BatchCreateIntroCall](#77-batchcreateintrocall)
  - [7.8. BatchOpportunityTransfer](#78-batchopportunitytransfer)
  - [7.9. CasePendingAssignmentNotification](#79-casependingassignmentnotification)
  - [7.10. CaseRecordOwner](#710-caserecordowner)
  - [7.11. CaseRecordOwnerAssign](#711-caserecordownerassign)
  - [7.12. CaseRecordOwnerAssignmentNotification](#712-caserecordownerassignmentnotification)
  - [7.13. CaseResolutionNotificationEmail](#713-caseresolutionnotificationemail)
  - [7.14. CloneAndDeleteQuote](#714-cloneanddeletequote)
  - [7.15. CloneLicense](#715-clonelicense)
  - [7.16. CloneOpportunity](#716-cloneopportunity)
  - [7.17. CloneOrder](#717-cloneorder)
  - [7.18. ContactAuto-Assign](#718-contactauto-assign)
  - [7.19. EngagementRecordOwner](#719-engagementrecordowner)
  - [7.20. EngagementRecordOwnerTeam](#720-engagementrecordownerteam)
  - [7.21. ExpenseNotificationManager](#721-expensenotificationmanager)
  - [7.22. ExpenseReportRejectedNotification](#722-expensereportrejectednotification)
  - [7.23. FSRLeadDistibutionNotification](#723-fsrleaddistibutionnotification)
  - [7.24. InvoiceRecordOwner](#724-invoicerecordowner)
  - [7.25. LeadAssignment](#725-leadassignment)
  - [7.26. NewFSRLeadNotification](#726-newfsrleadnotification)
  - [7.27. OpportunityRecordOwner](#727-opportunityrecordowner)
  - [7.28. OpportunityRecordOwnerTeam](#728-opportunityrecordownerteam)
  - [7.29. OrderRecordOwner](#729-orderrecordowner)
  - [7.30. PhonecallAuto-Assign](#730-phonecallauto-assign)
  - [7.31. QuoteRecordOwner](#731-quoterecordowner)
  - [7.32. QuoteRecordOwnerTeam](#732-quoterecordownerteam)
  - [7.33. SendQuote](#733-sendquote)
  - [7.34. TaskAuto-Assign](#734-taskauto-assign)
  - [7.35. TaskCreateReorderLead](#735-taskcreatereorderlead)
  - [7.36. WonOpportunityEmail](#736-wonopportunityemail)
  - [7.37. WorkforceAccountAuto-assign](#737-workforceaccountauto-assign)
  - [7.38. WorkforceAppointmentAuto-Assign](#738-workforceappointmentauto-assign)
  - [7.39. WorkforceCaseAuto-assign](#739-workforcecaseauto-assign)
  - [7.40. WorkforceContactAuto-assign](#740-workforcecontactauto-assign)
  - [7.41. WorkforceEngagementAuto-assign](#741-workforceengagementauto-assign)
  - [7.42. WorkforceLeadAuto-Assign](#742-workforceleadauto-assign)
  - [7.43. WorkforceOpportunityAuto-assign](#743-workforceopportunityauto-assign)
  - [7.44. WorkforcePhone-callAuto-assign](#744-workforcephone-callauto-assign)
  - [7.45. WorkforceQuoteAuto-assign](#745-workforcequoteauto-assign)
  - [7.46. iGradAppointmentAuto-Assign](#746-igradappointmentauto-assign)
  - [7.47. iGradCaseAuto-Assign](#747-igradcaseauto-assign)
  - [7.48. iGradPhone-callAuto-assign](#748-igradphone-callauto-assign)
- [8. JavaScript Web Resources](#8-javascript-web-resources)
  - [8.1. azt_caselibrary](#81-azt_caselibrary)
  - [8.2. azt_engagementlibrary](#82-azt_engagementlibrary)
  - [8.3. azt_invoicelibrary](#83-azt_invoicelibrary)
  - [8.4. azt_opportunitylibrary](#84-azt_opportunitylibrary)
  - [8.5. azt_orderlibrary](#85-azt_orderlibrary)
  - [8.6. azt_phonecalllibrary](#86-azt_phonecalllibrary)
  - [8.7. azt_quotelibrary](#87-azt_quotelibrary)
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

## 1. Field Definitions

Total fields: **31**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Last Update | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [activityid](#activityid) | Phone Call | uniqueidentifier |  | No | required | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  | [15](#3-views) |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 2 | [activitytypecode](#activitytypecode) | Activity Type | entityname |  | No | required | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 3 | [actualend](#actualend) | Actual End | datetime |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  | [24](#3-views) | [3](#4-chart-visualizations) |  |  |  |  |  |  |  |  |  |
| 4 | [azt_addtocrtqueue](#azt_addtocrtqueue) | Add to CRT Queue? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 5 | [azt_autocreatecallback](#azt_autocreatecallback) | Autocreate Callback? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 6 | [azt_callbackin](#azt_callbackin) | Callback In: | picklist | 276530000: 1 Day, 276530001: 2 Days, 276530002: 3 Days, 276530003: 1 Week, 276530004: 1 Month, 276530005: Specific Date | Yes | none | 2026-03-20 21:42:40 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 7 | [azt_callbackon](#azt_callbackon) | Callback On | datetime |  | Yes | none | 2026-03-20 21:24:01 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 8 | [azt_copydescription](#azt_copydescription) | Copy Description? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 9 | [azt_copysubject](#azt_copysubject) | Copy Subject? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 10 | [azt_historicalowner](#azt_historicalowner) | Historical Owner | nvarchar |  | Yes | none | 2026-02-13 16:44:14 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 11 | [azt_phonecallstatus](#azt_phonecallstatus) | Phonecall Status | picklist | 276530000: Active, 276530001: Failed, 276530002: Qualified | Yes | none | 2021-11-09 03:52:20 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 12 | [azt_recordownerid](#azt_recordownerid) | Record Owner | lookup |  | Yes | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  | [1](#2-forms) | [15](#3-views) | [13](#4-chart-visualizations) |  |  | [37](#7-workflows) |  | [9](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 13 | [azt_result](#azt_result) | Result | picklist | 327630000: Connected, 327630001: Left VM, 327630002: No Answer | Yes | none | 2026-03-20 21:42:40 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 14 | [category](#category) | Category | nvarchar |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 15 | [createdby](#createdby) | Created By | lookup |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  | [2](#3-views) |  |  |  | [3](#7-workflows) |  |  |  |  |  |  |
| 16 | [createdon](#createdon) | Created On | datetime |  | No | none | Skipped (createdon) | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [10](#10-plugin-source-code-analysis) |  |  |  |  |
| 17 | [description](#description) | Description | ntext |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  |  |  |  |  | [14](#7-workflows) |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 18 | [directioncode](#directioncode) | Direction | bit |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 19 | [from](#from) | Call From | partylist |  | No | required | Skipped (partylist) | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 20 | [leftvoicemail](#leftvoicemail) | Left Voice Mail | bit |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 21 | [modifiedon](#modifiedon) | Modified On | datetime |  | No | none | Skipped (modifiedon) | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 22 | [ownerid](#ownerid) | Owner | lookup |  | No | required | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  | [4](#3-views) |  |  |  | [1](#7-workflows) |  | [22](#10-plugin-source-code-analysis) |  |  |  |  |
| 23 | [phonenumber](#phonenumber) | Phone Number | nvarchar |  | No | none | 2026-03-20 21:02:02 | true |  |  |  |  |  |  | [1](#2-forms) | [3](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 24 | [prioritycode](#prioritycode) | Priority | picklist |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  | [3](#3-views) |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 25 | [regardingobjectid](#regardingobjectid) | Regarding | lookup |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  | [4](#3-views) |  |  |  | [14](#7-workflows) |  | [8](#10-plugin-source-code-analysis) |  | [35](#12-relationships) |  |  |
| 26 | [scheduledend](#scheduledend) | Due | datetime |  | No | none | 2026-03-20 21:42:40 | true |  |  |  |  |  |  |  | [5](#3-views) |  |  |  | [1](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 27 | [statecode](#statecode) | Activity Status | picklist |  | No | required | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  | [4](#3-views) |  |  |  |  |  | [20](#10-plugin-source-code-analysis) |  |  |  |  |
| 28 | [statuscode](#statuscode) | Status Reason | picklist |  | No | none | 2026-03-21 01:27:28 | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 29 | [subject](#subject) | Subject | nvarchar |  | No | required | 2026-03-21 01:27:28 | true |  |  |  |  |  |  | [2](#2-forms) | [20](#3-views) |  |  |  | [2](#7-workflows) |  | [3](#10-plugin-source-code-analysis) |  |  |  |  |
| 30 | [to](#to) | Call To | partylist |  | No | required | Skipped (partylist) | true |  |  |  |  |  |  |  | [3](#3-views) |  |  |  | [1](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 31 | [transactioncurrencyid](#transactioncurrencyid) | Currency | lookup |  | No | none | 2026-01-27 23:59:03 | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |

---

## 2. Forms

Total forms: **1**

### 2.1. Phone Call (main) -- Active

- **Form ID:** `{a91390a5-99bb-4d10-9eee-3a5c87f841f1}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: phonecall

##### Section: general information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [phonenumber](#phonenumber) | Phone Number | No | Yes |
| [azt_result](#azt_result) | Result | No | Yes |
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |

##### Section: phone call description

##### Section: phone call details

##### Section: tab_2_section_2

##### Section: Auto-Create Callback

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_autocreatecallback](#azt_autocreatecallback) | Autocreate Callback? | No | Yes |
| [azt_copydescription](#azt_copydescription) | Copy Description? | No | Yes |
| [azt_copysubject](#azt_copysubject) | Copy Subject? | No | Yes |
| [azt_addtocrtqueue](#azt_addtocrtqueue) | Add to CRT Queue? | No | Yes |
| [azt_callbackin](#azt_callbackin) | Callback In: | No | Yes |
| [azt_callbackon](#azt_callbackon) | Callback On | No | Yes |

##### Section: Access Team

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [accessteam](#accessteam) | Write Access Team | No | Yes |

#### Tab: tab_ci_call_summary
*Hidden tab*

##### Section: tab_ci_section_call_summary

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [subject](#subject) |  | No | Yes |

#### Tab: tab_ci_notes
*Hidden tab*

##### Section: tab_ci_section_notes

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [subject](#subject) |  | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [azt_historicalowner](#azt_historicalowner) | Historical Owner |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `onActivityFormLoad` | `msdyn_ci_activity_form` | true |
| onload |  | `PC.PhoneCallFunctions.setAutoCallbackVisibility` | `azt_phonecalllibrary` | true |
| onload |  | `PC.PhoneCallFunctions.onLoad` | `azt_phonecalllibrary` | true |
| onchange | azt_autocreatecallback | `PC.PhoneCallFunctions.setAutoCallbackVisibility` | `azt_phonecalllibrary` | true |
| onchange | azt_callbackin | `PC.PhoneCallFunctions.setAutoCallbackVisibility` | `azt_phonecalllibrary` | true |

---

## 3. Views

Total views: **15**

### 3.1. Completed CR Team Phonecalls

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [to](#to) | 125px |
| 2 | [phonenumber](#phonenumber) | 125px |
| 3 | [subject](#subject) | 300px |
| 4 | [regardingobjectid](#regardingobjectid) | 150px |
| 5 | [prioritycode](#prioritycode) | 100px |
| 6 | [actualend](#actualend) | 100px |
| 7 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |
| [ownerid](#ownerid) | eq | {F26FCC7D-981B-E911-A950-000D3A3B9CD8} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualend](#actualend) | Descending |

### 3.2. FSR Phone Calls This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [actualend](#actualend) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualend](#actualend) | this-month |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630002 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [subject](#subject) | Ascending |

### 3.3. FSR Phone Calls This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [actualend](#actualend) | 100px |
| 3 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualend](#actualend) | this-fiscal-period |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630002 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [subject](#subject) | Ascending |

### 3.4. FSR Phone Calls This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [actualend](#actualend) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualend](#actualend) | this-week |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630002 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualend](#actualend) | Ascending |
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.5. My Calls This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 3 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [actualend](#actualend) | this-month |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [subject](#subject) | Ascending |

### 3.6. My Calls This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [actualend](#actualend) | this-fiscal-period |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [subject](#subject) | Ascending |

### 3.7. My Calls This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 3 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [actualend](#actualend) | this-week |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [subject](#subject) | Ascending |

### 3.8. My Calls This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [actualend](#actualend) | this-fiscal-year |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [subject](#subject) | Ascending |

### 3.9. My Open Phonecalls

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [to](#to) | 150px |
| 2 | [phonenumber](#phonenumber) | 100px |
| 3 | [regardingobjectid](#regardingobjectid) | 200px |
| 4 | [subject](#subject) | 150px |
| 5 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 6 | [scheduledend](#scheduledend) | 100px |
| 7 | [createdby](#createdby) | 100px |
| 8 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [scheduledend](#scheduledend) | Ascending |

### 3.10. Pending CR Team Phonecalls

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [to](#to) | 100px |
| 2 | [phonenumber](#phonenumber) | 100px |
| 3 | [subject](#subject) | 300px |
| 4 | [regardingobjectid](#regardingobjectid) | 150px |
| 5 | [prioritycode](#prioritycode) | 100px |
| 6 | [scheduledend](#scheduledend) | 100px |
| 7 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [ownerid](#ownerid) | eq | {F26FCC7D-981B-E911-A950-000D3A3B9CD8} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [scheduledend](#scheduledend) | Descending |

### 3.11. Phone Call Advanced Find View

- **Type:** Advanced Find (querytype=1)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 250px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 3 | [statecode](#statecode) | 100px |
| 4 | [prioritycode](#prioritycode) | 100px |
| 5 | [scheduledend](#scheduledend) | 100px |
| 6 | [createdby](#createdby) | 100px |
| 7 | [regardingobjectid](#regardingobjectid) | 200px |
| 8 | [activityid](#activityid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [subject](#subject) | Ascending |

### 3.12. Phone Calls This Month

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [actualend](#actualend) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualend](#actualend) | this-month |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualend](#actualend) | Ascending |

### 3.13. Phone Calls This Quarter

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 2 | [actualend](#actualend) | 100px |
| 3 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualend](#actualend) | this-fiscal-period |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualend](#actualend) | Ascending |

### 3.14. Phone Calls This Week

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [subject](#subject) | 150px |
| 2 | [actualend](#actualend) | 100px |
| 3 | [azt_recordownerid](#azt_recordownerid) | 100px |
| 4 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualend](#actualend) | this-week |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [actualend](#actualend) | Ascending |

### 3.15. Phone Calls This Year

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [ownerid](#ownerid) | 100px |
| 2 | [actualend](#actualend) | 100px |
| 3 | [activityid](#activityid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [actualend](#actualend) | this-year |  |
| [azt_jobrole](#azt_jobrole) | eq | 327630000 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [ownerid](#ownerid) | Ascending |

---

## 4. Chart Visualizations

Total charts: **8**

### 4.1. Phone Calls This Quarter By Rep

- **Visualization ID:** `{F84C78B8-99E2-EB11-BACB-000D3A5ACAF8}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.2. My Phone Calls This Quarter

- **Visualization ID:** `{D70ACA64-64E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [actualend](#actualend) | _CRMAutoGen_groupby_column_Num_0 | month |

### 4.3. My Phone Calls This Year

- **Visualization ID:** `{285363BE-6BE2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [actualend](#actualend) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### 4.4. Phone Calls This Year By Owner

- **Visualization ID:** `{CEEF778D-85E2-EB11-BACB-000D3A5ACBF1}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [actualend](#actualend) | _CRMAutoGen_groupby_column_Num_0 | quarter |

### 4.5. Phone Calls This Month By Rep

- **Visualization ID:** `{6B48FBAA-BF01-EC11-94EF-002248047923}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.6. Phone Calls This Week By Rep

- **Visualization ID:** `{AEC2F1D0-EE13-EC11-B6E6-002248047CFA}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.7. My Calls This Week

- **Visualization ID:** `{6F88541F-F513-EC11-B6E6-002248047CFA}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

### 4.8. My Calls This Month

- **Visualization ID:** `{B2D8B73A-D538-ED11-9DB0-002248296C23}`
- **Entity:** phonecall

**Measure Fields:**

| Field | Aggregate | Alias |
|-------|-----------|-------|
| [azt_recordownerid](#azt_recordownerid) | count | _CRMAutoGen_aggregate_column_Num_0 |

**Group-By Fields:**

| Field | Alias | Date Grouping |
|-------|-------|---------------|
| [azt_recordownerid](#azt_recordownerid) | _CRMAutoGen_groupby_column_Num_0 |  |

---

## 5. Reports

Total reports referencing Phonecall: **0**

---

## 6. Dashboards

Total dashboards referencing Phonecall: **13**

### 6.1. Activity Dashboard

- **Form ID:** `{cda4fd41-d82f-ef11-840a-6045bda725ae}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component8f6981f` | phonecall | Grid | `{59FD0F22-D82F-EF11-840A-6045BDA725AE}` | `` |
| `Component0f985b2` | task | Grid | `{03ABA16C-D92F-EF11-840A-6045BDA725AE}` | `` |
| `Component1532808` | appointment | Grid | `{BEEA9C09-D92F-EF11-840A-6045BDA725AE}` | `` |

### 6.2. Monthly Account Manager KPIs

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

### 6.3. Monthly FSR KPIs

- **Form ID:** `{070b52b3-a9f7-ed11-8849-000d3a993b8f}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component4981c62` | appointment | Chart | `{12110AA8-98FE-ED11-8F6E-000D3A993B8F}` | `{77750752-BE01-EC11-94EF-002248047923}` |
| `Component793f3b2` | appointment | Chart | `{2533A5FC-98FE-ED11-8F6E-000D3A993B8F}` | `{5E815954-BF01-EC11-94EF-002248047923}` |
| `Component64000d5` | phonecall | Chart | `{35CF424F-99FE-ED11-8F6E-000D3A993B8F}` | `{6B48FBAA-BF01-EC11-94EF-002248047923}` |
| `Componente173003` | appointment | Chart | `{9D0D178C-99FE-ED11-8F6E-000D3A993B8F}` | `{B4A08E12-C001-EC11-94EF-002248047923}` |
| `Component4b5bddb` | azt_engagement | Chart | `{B0111926-9AFE-ED11-8F6E-000D3A993B8F}` | `{FA914474-9AFE-ED11-8F6E-000D3A993B8F}` |
| `Component8fcdf63` | azt_engagement | Chart | `{54F15726-9BFE-ED11-8F6E-000D3A993B8F}` | `{75F5A940-9BFE-ED11-8F6E-000D3A993B8F}` |
| `Component8267285` | email | Chart | `{B6DA52DD-9BFE-ED11-8F6E-000D3A993B8F}` | `{2C86C148-DF81-EC11-8D21-00224804C2A2}` |
| `Component9242819` | azt_engagement | Chart | `{C1338C0E-2A00-EE11-8F6E-000D3A993616}` | `{D4B4AFDF-2900-EE11-8F6E-000D3A993616}` |
| `Component435260` | lead | Chart | `{CA932C80-C3F8-EE11-A1FD-6045BDD61267}` | `{3EF70542-C4F8-EE11-A1FD-6045BDD61267}` |
| `Component1239023` | incident | Chart | `{ECB13663-C6F8-EE11-A1FD-6045BDD61267}` | `{B2FD4DEA-C6F8-EE11-A1FD-6045BDD61267}` |
| `Component1280573` | incident | Chart | `{85CE2345-C7F8-EE11-A1FD-6045BDD61267}` | `{D603C171-C7F8-EE11-A1FD-6045BDD61267}` |

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

### 6.5. My FSR Quarterly Dashboard

- **Form ID:** `{d8aea69f-3be2-ed11-a7c7-000d3a993b8f}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componenta0a06bc` | appointment | Chart | `{478B8C6C-60E2-EB11-BACB-000D3A5ACBF1}` | `{AFCC5E67-63E2-EB11-BACB-000D3A5ACBF1}` |
| `Componente5f2fe9` | appointment | Chart | `{5C1C2563-62E2-EB11-BACB-000D3A5ACBF1}` | `{03C6039E-96E2-EB11-BACB-000D3A5ACAF8}` |
| `Componenta4f1ef6` | phonecall | Chart | `{E7C24441-64E2-EB11-BACB-000D3A5ACBF1}` | `{D70ACA64-64E2-EB11-BACB-000D3A5ACBF1}` |
| `Component3719c87` | appointment | Chart | `{D430962C-65E2-EB11-BACB-000D3A5ACBF1}` | `{6D47FB3B-65E2-EB11-BACB-000D3A5ACBF1}` |
| `Component97417` | azt_engagement | Chart | `{EDB65EBF-79A8-EE11-BE37-6045BDD607EC}` | `{1E7D2A43-7AA8-EE11-BE37-6045BDD607EC}` |
| `Component3507197` | azt_engagement | Chart | `{EDB65EBF-79A8-EE11-BE37-6045BDD607EC}` | `{1E7D2A43-7AA8-EE11-BE37-6045BDD607EC}` |

### 6.6. My Monthly FSR KPI's

- **Form ID:** `{90c6ea5f-77a8-ee11-be37-6045bdd607ec}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componentfdc602a` | appointment | Chart | `{3E5ADF87-D238-ED11-9DB0-002248296C23}` | `{9A7F1E11-D338-ED11-9DB0-002248296C23}` |
| `Componenteb76554` | appointment | Chart | `{7B6BC3C8-D238-ED11-9DB0-002248296C23}` | `{94D9B91E-D338-ED11-9DB0-002248296C23}` |
| `Component8716945` | phonecall | Chart | `{8A663A58-D338-ED11-9DB0-002248296C23}` | `{B2D8B73A-D538-ED11-9DB0-002248296C23}` |
| `Component8447edf` | appointment | Chart | `{9B287594-D338-ED11-9DB0-002248296C23}` | `{4845C870-D538-ED11-9DB0-002248296C23}` |
| `Component55c7b55` | email | Chart | `{1D36FBEE-DC81-EC11-8D21-00224804C2A2}` | `{0B52BCD3-E481-EC11-8D21-00224804C2A2}` |
| `Componentb8e38ae` | azt_engagement | Chart | `{B2DB5537-79A8-EE11-BE37-6045BDD607EC}` | `{1E7D2A43-7AA8-EE11-BE37-6045BDD607EC}` |

### 6.7. My Monthly KPI's

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

### 6.8. My Quarterly KPIs

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

### 6.9. My Weekly KPIs

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

### 6.10. Quarterly Account Manager KPIs

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

### 6.11. Quarterly FSR KPIs

- **Form ID:** `{43e9b8d5-aaf7-ed11-8849-000d3a993b8f}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Componentc68bece` | appointment | Chart | `{8A048288-9FFE-ED11-8F6E-000D3A993B8F}` | `{BFF22505-9AE2-EB11-BACB-000D3A5ACAF8}` |
| `Component5bfeb07` | appointment | Chart | `{6424A8C4-9FFE-ED11-8F6E-000D3A993B8F}` | `{8F61FD45-9AE2-EB11-BACB-000D3A5ACAF8}` |
| `Componente85d8eb` | phonecall | Chart | `{F80E8C07-A0FE-ED11-8F6E-000D3A993B8F}` | `{F84C78B8-99E2-EB11-BACB-000D3A5ACAF8}` |
| `Component7e15331` | appointment | Chart | `{2530F243-A0FE-ED11-8F6E-000D3A993B8F}` | `{458B5E74-99E2-EB11-BACB-000D3A5ACAF8}` |
| `Componentd6b31c8` | azt_engagement | Chart | `{8A85388C-A0FE-ED11-8F6E-000D3A993B8F}` | `{1B8BB1C8-A0FE-ED11-8F6E-000D3A993B8F}` |
| `Component3d0726b` | azt_engagement | Chart | `{41E8CD0A-A1FE-ED11-8F6E-000D3A993B8F}` | `{F658F928-A1FE-ED11-8F6E-000D3A993B8F}` |
| `Component7745986` | email | Chart | `{56806C71-A1FE-ED11-8F6E-000D3A993B8F}` | `{D444DFB6-E481-EC11-8D21-00224804C2A2}` |

### 6.12. Weekly Account Manager KPIs

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

### 6.13. Weekly FSR KPIs

- **Form ID:** `{435aa539-a9f7-ed11-8849-000d3a993b8f}`

| Control | Entity | Mode | View ID | Chart ID |
|---------|--------|------|---------|----------|
| `Component7213561` | appointment | Chart | `{CBD4A704-9DFE-ED11-8F6E-000D3A993B8F}` | `{0E8B8E32-F113-EC11-B6E6-002248047CFA}` |
| `Component7c23f70` | appointment | Chart | `{5524BA69-9DFE-ED11-8F6E-000D3A993B8F}` | `{869AA5B6-EE13-EC11-B6E6-002248047CFA}` |
| `Componente92fbf0` | phonecall | Chart | `{91ABA5C7-9DFE-ED11-8F6E-000D3A993B8F}` | `{AEC2F1D0-EE13-EC11-B6E6-002248047CFA}` |
| `Component5755922` | appointment | Chart | `{B8A6CA0A-9EFE-ED11-8F6E-000D3A993B8F}` | `{73FCD2E7-EE13-EC11-B6E6-002248047CFA}` |
| `Componentf08f2ed` | azt_engagement | Chart | `{029F446A-9EFE-ED11-8F6E-000D3A993B8F}` | `{B330268F-9EFE-ED11-8F6E-000D3A993B8F}` |
| `Componentd9dbd17` | azt_engagement | Chart | `{EA0B4CD8-9EFE-ED11-8F6E-000D3A993B8F}` | `{B330268F-9EFE-ED11-8F6E-000D3A993B8F}` |
| `Component6415894` | email | Chart | `{E68D523F-9FFE-ED11-8F6E-000D3A993B8F}` | `{EFC52CA8-E481-EC11-8D21-00224804C2A2}` |

---

## 7. Workflows

Total workflows referencing Phonecall: **48**

### 7.1. 0ChangeQuoteRecordOwner

- **File:** `0ChangeQuoteRecordOwner-938FE262-FF96-42CB-8332-50B6A947A533.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.2. AccountAuto-Assign

- **File:** `AccountAuto-Assign-6DE252A4-C0D8-4C6B-800E-3985440C88D1.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`

### 7.3. AppointmentAuto-Assign

- **File:** `AppointmentAuto-Assign-1A553A9D-514D-42CA-A9AE-73FEED04E1E5.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Appointment

**Fields Read:**

- [regardingobjectid](#regardingobjectid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.4. BatchCancelAppointments

- **File:** `BatchCancelAppointments-DD0A1695-F44B-4C7D-8D09-A0243A22D35B.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Appointment

**Fields Written:**

- [description](#description)

### 7.5. BatchCancelPhoneCalls

- **File:** `BatchCancelPhoneCalls-5171315D-5F2E-48D9-8C28-7D946F12CAB9.xaml`
- **Entity References:** phonecall
- **Primary Entity:** PhoneCall

**Fields Written:**

- [description](#description)

### 7.6. BatchCreateEngagements

- **File:** `BatchCreateEngagements-CC9CDFC6-4BC9-4635-B786-0C7BE2C34344.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.7. BatchCreateIntroCall

- **File:** `BatchCreateIntroCall-F45065DE-1A7E-487C-A3CA-CB5CE209B242.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Account

**Fields Written:**

- [directioncode](#directioncode)
- [from](#from)
- [leftvoicemail](#leftvoicemail)
- [prioritycode](#prioritycode)
- [regardingobjectid](#regardingobjectid)
- [scheduledend](#scheduledend)
- [subject](#subject)
- [to](#to)

### 7.8. BatchOpportunityTransfer

- **File:** `BatchOpportunityTransfer-744FEB80-2251-4252-875E-ED9958CB448A.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)
- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.9. CasePendingAssignmentNotification

- **File:** `CasePendingAssignmentNotification-177DE8B3-E0C3-4F1C-A7B5-DA84B3629AED.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Incident

**Fields Read:**

- [description](#description)

**Fields Written:**

- [regardingobjectid](#regardingobjectid)

### 7.10. CaseRecordOwner

- **File:** `CaseRecordOwner-E2135799-C146-4E0B-A0A5-F9917895B23E.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.11. CaseRecordOwnerAssign

- **File:** `CaseRecordOwnerAssign-02EE1A9D-1658-4013-BF63-9C0E5C65AAD0.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.12. CaseRecordOwnerAssignmentNotification

- **File:** `CaseRecordOwnerAssignmentNotification-2F6035E6-1FBC-476B-9C97-4554E8360B7C.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Incident

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [description](#description)

**Fields Written:**

- [regardingobjectid](#regardingobjectid)

### 7.13. CaseResolutionNotificationEmail

- **File:** `CaseResolutionNotificationEmail-734E721F-7454-4437-8BAC-8B20F496DF12.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Incident

**Fields Written:**

- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.14. CloneAndDeleteQuote

- **File:** `CloneAndDeleteQuote-1D87A694-5A08-4C93-9925-447BB4FE7DA6.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Quote

**Fields Written:**

- [azt_historicalowner](#azt_historicalowner)

### 7.15. CloneLicense

- **File:** `CloneLicense-49354120-2D2D-4DED-8C24-4ACA5F6D82D9.xaml`
- **Entity References:** phonecall
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.16. CloneOpportunity

- **File:** `CloneOpportunity-1A3FF4B3-79FD-420C-8A10-375E8892CA44.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_historicalowner](#azt_historicalowner)
- [azt_recordownerid](#azt_recordownerid)
- [description](#description)

### 7.17. CloneOrder

- **File:** `CloneOrder-D2A6AD48-A603-4150-BC84-72092AFB3D79.xaml`
- **Entity References:** phonecall
- **Primary Entity:** SalesOrder

**Fields Written:**

- [description](#description)

### 7.18. ContactAuto-Assign

- **File:** `ContactAuto-Assign-25759C22-AE58-4CC7-81E1-9BBF37E76F3E.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`
- `AztecPlugins.GetAcctTeamOwned`

### 7.19. EngagementRecordOwner

- **File:** `EngagementRecordOwner-00BE88CF-37E2-46ED-951B-A553329BC127.xaml`
- **Entity References:** phonecall
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.20. EngagementRecordOwnerTeam

- **File:** `EngagementRecordOwnerTeam-190EE5B4-5775-4B9D-BFD7-FB769C19977A.xaml`
- **Entity References:** phonecall
- **Primary Entity:** azt_engagement

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.21. ExpenseNotificationManager

- **File:** `ExpenseNotificationManager-5CC7F6CC-5991-401F-AEE9-20010EEBB90E.xaml`
- **Entity References:** phonecall
- **Primary Entity:** azt_expensereport

**Fields Written:**

- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.22. ExpenseReportRejectedNotification

- **File:** `ExpenseReportRejectedNotification-811FD6D5-D33F-4BEB-8F93-13D7F40F2A78.xaml`
- **Entity References:** phonecall
- **Primary Entity:** azt_expensereport

**Fields Written:**

- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.23. FSRLeadDistibutionNotification

- **File:** `FSRLeadDistibutionNotification-2D276CE9-54BF-4703-A56C-933E5C57F3C7.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Lead

**Fields Written:**

- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.24. InvoiceRecordOwner

- **File:** `InvoiceRecordOwner-C59ED476-F5C4-47B7-BD33-E88881D2B5EE.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Invoice

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.25. LeadAssignment

- **File:** `LeadAssignment-5FC23C73-5B6B-423C-8721-57EDA4553E31.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.26. NewFSRLeadNotification

- **File:** `NewFSRLeadNotification-53E6AF89-E489-4977-8D9F-1579FF72FAC5.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Lead

**Fields Written:**

- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.27. OpportunityRecordOwner

- **File:** `OpportunityRecordOwner-B0889237-722A-47CC-B102-D507B14FED98.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.28. OpportunityRecordOwnerTeam

- **File:** `OpportunityRecordOwnerTeam-7F60084D-807B-43D1-ACED-B0CC90F02F02.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.29. OrderRecordOwner

- **File:** `OrderRecordOwner-701C3E67-4733-423C-BC31-5C846B542B76.xaml`
- **Entity References:** phonecall
- **Primary Entity:** SalesOrder

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.30. PhonecallAuto-Assign

- **File:** `PhonecallAuto-Assign-D7FD43A4-5AFF-4929-BD37-A1917C4F2391.xaml`
- **Entity References:** phonecall
- **Primary Entity:** PhoneCall

**Fields Read:**

- [createdby](#createdby)
- [ownerid](#ownerid)
- [regardingobjectid](#regardingobjectid)
- [subject](#subject)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.31. QuoteRecordOwner

- **File:** `QuoteRecordOwner-C5266A8C-E23D-41C4-B51F-3A637538DDBF.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.32. QuoteRecordOwnerTeam

- **File:** `QuoteRecordOwnerTeam-7ACFAD91-65CC-4C8D-8A3E-673373DEA880.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.33. SendQuote

- **File:** `SendQuote-FF6FE214-20D6-4541-AEC6-BD5D18258481.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

**Fields Written:**

- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.34. TaskAuto-Assign

- **File:** `TaskAuto-Assign-89E60667-3F7F-4ADD-8274-57C2BE011059.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Task

**Fields Read:**

- [regardingobjectid](#regardingobjectid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.35. TaskCreateReorderLead

- **File:** `TaskCreateReorderLead-3193EB56-8E56-46A3-B079-A7CFD1CE90B7.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Task

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.36. WonOpportunityEmail

- **File:** `WonOpportunityEmail-DB2872A0-18C2-4157-B6BD-480230C97D32.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

**Fields Written:**

- [description](#description)
- [regardingobjectid](#regardingobjectid)

### 7.37. WorkforceAccountAuto-assign

- **File:** `WorkforceAccountAuto-assign-1AD2C544-E6F9-4FC7-AA17-810AEB8939C2.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.38. WorkforceAppointmentAuto-Assign

- **File:** `WorkforceAppointmentAuto-Assign-803829FB-077B-4F0B-B238-105814F5B202.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.39. WorkforceCaseAuto-assign

- **File:** `WorkforceCaseAuto-assign-24BA0A9C-F8BD-45CB-A5F6-6DCE42CD998F.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.40. WorkforceContactAuto-assign

- **File:** `WorkforceContactAuto-assign-65B65E23-A8F5-46DB-A35A-C5DC8542B6AE.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.41. WorkforceEngagementAuto-assign

- **File:** `WorkforceEngagementAuto-assign-DA5CDD7F-2A3B-4A0A-861D-75305D10254E.xaml`
- **Entity References:** phonecall
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.42. WorkforceLeadAuto-Assign

- **File:** `WorkforceLeadAuto-Assign-E5A4054C-5F7E-478C-87E3-529C1EEAB0DC.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.43. WorkforceOpportunityAuto-assign

- **File:** `WorkforceOpportunityAuto-assign-7D379FBE-C672-41EB-90A3-A80451C62533.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.44. WorkforcePhone-callAuto-assign

- **File:** `WorkforcePhone-callAuto-assign-BE1CB211-7C3C-4E39-8913-2DFCE7EDFC85.xaml`
- **Entity References:** phonecall
- **Primary Entity:** PhoneCall

**Fields Read:**

- [createdby](#createdby)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.45. WorkforceQuoteAuto-assign

- **File:** `WorkforceQuoteAuto-assign-E64BB2BB-5CD6-4327-AB1B-BF8C9D4D2385.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.46. iGradAppointmentAuto-Assign

- **File:** `iGradAppointmentAuto-Assign-CE88A0C4-AA60-44F4-B33D-B57FB8279CCF.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.47. iGradCaseAuto-Assign

- **File:** `iGradCaseAuto-Assign-CAF5021E-07E1-4689-92D5-FC59E9F30F78.xaml`
- **Entity References:** phonecall
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.48. iGradPhone-callAuto-assign

- **File:** `iGradPhone-callAuto-assign-04423D55-3225-429E-BAC6-8DD37BC53F1B.xaml`
- **Entity References:** phonecall
- **Primary Entity:** PhoneCall

**Fields Read:**

- [createdby](#createdby)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

---

## 8. JavaScript Web Resources

Total JS files referencing Phonecall fields: **7**

### 8.1. azt_caselibrary

- **File:** `azt_caselibraryD1BC3A04-FA9F-EC11-B400-00224824F1A0`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.2. azt_engagementlibrary

- **File:** `azt_engagementlibraryE672CD7D-C50C-E911-A97C-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.3. azt_invoicelibrary

- **File:** `azt_invoicelibrary25F065BD-0B9E-EB11-B1AC-000D3A378944`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.4. azt_opportunitylibrary

- **File:** `azt_opportunitylibrary43000452-0710-E911-A980-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.5. azt_orderlibrary

- **File:** `azt_orderlibrary2892D28D-D5C4-EB11-BACC-00224809B8F2`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.6. azt_phonecalllibrary

- **File:** `azt_phonecalllibrary521EF713-0F0C-E911-A976-000D3A1A941E`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [regardingobjectid](#regardingobjectid) | read |

`setAutoCallbackVisibility`:

| Field | Operations |
|-------|-----------|
| [azt_addtocrtqueue](#azt_addtocrtqueue) | UI |
| [azt_autocreatecallback](#azt_autocreatecallback) | read, UI |
| [azt_callbackin](#azt_callbackin) | access |
| [azt_callbackon](#azt_callbackon) | UI |
| [azt_copydescription](#azt_copydescription) | UI |
| [azt_copysubject](#azt_copysubject) | UI |

### 8.7. azt_quotelibrary

- **File:** `azt_quotelibrary117BF74F-580A-E911-A983-000D3A1A9151`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [azt_recordownerid](#azt_recordownerid) |  |  | Yes |

---

## 9. Formulas & Rollups

Total formulas for Phonecall: **0**

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

Total relationships involving Phonecall: **36**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| Account_Phonecalls | N:1 | Account | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| Contact_Phonecalls | N:1 | Contact | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| Incident_Phonecalls | N:1 | Incident | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| Lead_Phonecalls | N:1 | Lead | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| Opportunity_Phonecalls | N:1 | Opportunity | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_ad_PhoneCalls | N:1 | Adx_ad | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_adplacement_PhoneCalls | N:1 | Adx_adplacement | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_casedeflection_PhoneCalls | N:1 | adx_casedeflection | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_communityforumaccesspermission_PhoneCalls | N:1 | Adx_communityforumaccesspermission | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_communityforumalert_PhoneCalls | N:1 | Adx_communityforumalert | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_contentaccesslevel_PhoneCalls | N:1 | adx_contentaccesslevel | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_invitation_PhoneCalls | N:1 | adx_invitation | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_poll_PhoneCalls | N:1 | Adx_poll | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_polloption_PhoneCalls | N:1 | Adx_polloption | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_pollplacement_PhoneCalls | N:1 | Adx_pollplacement | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_pollsubmission_PhoneCalls | N:1 | Adx_pollsubmission | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_publishingstatetransitionrule_PhoneCalls | N:1 | adx_publishingstatetransitionrule | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_redirect_PhoneCalls | N:1 | Adx_redirect | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_shortcut_PhoneCalls | N:1 | adx_shortcut | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_webpage_PhoneCalls | N:1 | Adx_webpage | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| adx_website_PhoneCalls | N:1 | Adx_website | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| azt_engagement_PhoneCalls | N:1 | azt_engagement | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| azt_expensereport_PhoneCalls | N:1 | azt_expensereport | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| azt_systemuser_phonecall | N:1 | SystemUser | PhoneCall | [azt_RecordOwnerId](#azt_recordownerid) |
| azt_training_PhoneCalls | N:1 | azt_training | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| msdyn_customerasset_PhoneCalls | N:1 | msdyn_customerasset | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| msdyn_playbookinstance_PhoneCalls | N:1 | msdyn_playbookinstance | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| msdyn_postalbum_PhoneCalls | N:1 | msdyn_PostAlbum | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| msdyn_salessuggestion_PhoneCalls | N:1 | msdyn_salessuggestion | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| msdyn_swarm_PhoneCalls | N:1 | msdyn_swarm | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| mspp_adplacement_PhoneCalls | N:1 | mspp_adplacement | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| mspp_pollplacement_PhoneCalls | N:1 | mspp_pollplacement | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| mspp_publishingstatetransitionrule_PhoneCalls | N:1 | mspp_publishingstatetransitionrule | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| mspp_redirect_PhoneCalls | N:1 | mspp_redirect | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| mspp_shortcut_PhoneCalls | N:1 | mspp_shortcut | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| mspp_website_PhoneCalls | N:1 | mspp_website | PhoneCall | [RegardingObjectId](#regardingobjectid) |

---

## 13. Ribbon Customizations

No custom ribbon actions found.

---

## 14. Conflicts & Observations

### 14.1 Per-Form Conflicts

No per-form conflicts detected.

### 14.2 Global Observations

**Fields in code but not on any form (299):**

- [accountid](#accountid)
- [activityid](#activityid)
- [activitytypecode](#activitytypecode)
- [actualclosedate](#actualclosedate)
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
- [azt_ageendedstage](#azt_ageendedstage)
- [azt_allocatedtoid](#azt_allocatedtoid)
- [azt_allocationtype](#azt_allocationtype)
- [azt_amount](#azt_amount)
- [azt_annualspend](#azt_annualspend)
- [azt_approvalstatus](#azt_approvalstatus)
- [azt_autonumberid](#azt_autonumberid)
- [azt_azteccustomerid](#azt_azteccustomerid)
- [azt_bookingurl](#azt_bookingurl)
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
- [azt_currentnumber](#azt_currentnumber)
- [azt_customerid](#azt_customerid)
- [azt_customertrainingid](#azt_customertrainingid)
- [azt_dateexitedstage](#azt_dateexitedstage)
- [azt_defaultfreightamount](#azt_defaultfreightamount)
- [azt_description](#azt_description)
- [azt_discountamount](#azt_discountamount)
- [azt_discretionarydiscountamt](#azt_discretionarydiscountamt)
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
- [azt_freightamtapproved](#azt_freightamtapproved)
- [azt_fsrassignedon](#azt_fsrassignedon)
- [azt_fsremail](#azt_fsremail)
- [azt_fsrid](#azt_fsrid)
- [azt_fsrmobiletelephone](#azt_fsrmobiletelephone)
- [azt_fsrtelephone](#azt_fsrtelephone)
- [azt_fsrtelephoneextension](#azt_fsrtelephoneextension)
- [azt_fundingid](#azt_fundingid)
- [azt_fundingyear](#azt_fundingyear)
- [azt_goaltype](#azt_goaltype)
- [azt_importname](#azt_importname)
- [azt_invoiceid](#azt_invoiceid)
- [azt_invoiceproductid](#azt_invoiceproductid)
- [azt_isbn](#azt_isbn)
- [azt_iscompanion](#azt_iscompanion)
- [azt_isprint](#azt_isprint)
- [azt_issaas](#azt_issaas)
- [azt_jobrole](#azt_jobrole)
- [azt_jobtitle](#azt_jobtitle)
- [azt_lastactivitydate](#azt_lastactivitydate)
- [azt_lastmodifiedbyid](#azt_lastmodifiedbyid)
- [azt_lastname](#azt_lastname)
- [azt_leadimportid](#azt_leadimportid)
- [azt_leadsourceid](#azt_leadsourceid)
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
- [azt_probability](#azt_probability)
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
- [azt_requestedfreightamt](#azt_requestedfreightamt)
- [azt_resolvedbyid](#azt_resolvedbyid)
- [azt_saas](#azt_saas)
- [azt_saasstatus](#azt_saasstatus)
- [azt_salesrepid](#azt_salesrepid)
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
- [businessprocessflowinstanceid](#businessprocessflowinstanceid)
- [businessunitid](#businessunitid)
- [category](#category)
- [closeprobability](#closeprobability)
- [companyname](#companyname)
- [connectionid](#connectionid)
- [connectionroleid](#connectionroleid)
- [consideronlygoalownersrecords](#consideronlygoalownersrecords)
- [contactid](#contactid)
- [createdby](#createdby)
- [createdon](#createdon)
- [crm3_expenseamount](#crm3_expenseamount)
- [crm3_parentleadid](#crm3_parentleadid)
- [customerid](#customerid)
- [datefulfilled](#datefulfilled)
- [defaultuomid](#defaultuomid)
- [description](#description)
- [directioncode](#directioncode)
- [discountamount](#discountamount)
- [discountpercentage](#discountpercentage)
- [emailaddress1](#emailaddress1)
- [estimatedclosedate](#estimatedclosedate)
- [estimatedvalue](#estimatedvalue)
- [ext_amt](#ext_amt)
- [extendedamount](#extendedamount)
- [fetchxml](#fetchxml)
- [filename](#filename)
- [firstname](#firstname)
- [freightamount](#freightamount)
- [freighttermscode](#freighttermscode)
- [from](#from)
- [fullname](#fullname)
- [goalenddate](#goalenddate)
- [goalid](#goalid)
- [goalownerid](#goalownerid)
- [goalrollupqueryid](#goalrollupqueryid)
- [goalstartdate](#goalstartdate)
- [incidentid](#incidentid)
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
- [isrevenuesystemcalculated](#isrevenuesystemcalculated)
- [jobtitle](#jobtitle)
- [lastname](#lastname)
- [leftvoicemail](#leftvoicemail)
- [manualdiscountamount](#manualdiscountamount)
- [metricid](#metricid)
- [mimetype](#mimetype)
- [mobilephone](#mobilephone)
- [modifiedon](#modifiedon)
- [name](#name)
- [objectid](#objectid)
- [objecttypecode](#objecttypecode)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [originatingleadid](#originatingleadid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [parentcustomerid](#parentcustomerid)
- [parentgoalid](#parentgoalid)
- [parentsystemuserid](#parentsystemuserid)
- [partyid](#partyid)
- [pricelevelid](#pricelevelid)
- [priceperunit](#priceperunit)
- [primarycontactid](#primarycontactid)
- [prioritycode](#prioritycode)
- [prod.productid](#prodproductid)
- [productdescription](#productdescription)
- [productid](#productid)
- [productname](#productname)
- [productnumber](#productnumber)
- [producttypecode](#producttypecode)
- [quantity](#quantity)
- [queryentitytype](#queryentitytype)
- [queueid](#queueid)
- [queueitemid](#queueitemid)
- [quotedetailid](#quotedetailid)
- [quoteid](#quoteid)
- [record1id](#record1id)
- [record1roleid](#record1roleid)
- [record2id](#record2id)
- [record2roleid](#record2roleid)
- [regardingobjectid](#regardingobjectid)
- [requestdeliveryby](#requestdeliveryby)
- [roleid](#roleid)
- [rolluponlyfromchildgoals](#rolluponlyfromchildgoals)
- [rollupqueryactualmoneyid](#rollupqueryactualmoneyid)
- [salesorderdetailid](#salesorderdetailid)
- [salesorderdetailname](#salesorderdetailname)
- [salesorderid](#salesorderid)
- [salesrepid](#salesrepid)
- [scheduledend](#scheduledend)
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
- [systemuserid](#systemuserid)
- [tax](#tax)
- [teamid](#teamid)
- [teamtype](#teamtype)
- [telephone1](#telephone1)
- [title](#title)
- [tm.systemuserid](#tmsystemuserid)
- [to](#to)
- [totalamount](#totalamount)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)
- [{0}](#0)

**Fields on forms but never in logic (1):**

- [accessteam](#accessteam)

---

## Index

Alphabetical field index -- 324 unique fields referenced.

#### accessteam

- [Form: Phone Call > phonecall > Access Team](#21-phone-call-main-active)

#### accountid

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

#### activityid

- [Field Definitions](#1-field-definitions)
- [View: Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
- [View: FSR Phone Calls This Month](#32-fsr-phone-calls-this-month)
- [View: FSR Phone Calls This Quarter](#33-fsr-phone-calls-this-quarter)
- [View: FSR Phone Calls This Week](#34-fsr-phone-calls-this-week)
- [View: My Calls This Month](#35-my-calls-this-month)
- [View: My Calls This Quarter](#36-my-calls-this-quarter)
- [View: My Calls This Week](#37-my-calls-this-week)
- [View: My Calls This Year](#38-my-calls-this-year)
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
- [View: Phone Calls This Month](#312-phone-calls-this-month)
- [View: Phone Calls This Quarter](#313-phone-calls-this-quarter)
- [View: Phone Calls This Week](#314-phone-calls-this-week)
- [View: Phone Calls This Year](#315-phone-calls-this-year)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Image)](#1059-phonecallcreatecallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### activitytypecode

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)

#### actualclosedate

- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### actualend

- [Field Definitions](#1-field-definitions)
- [View: Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
- [View: Completed CR Team Phonecalls (Sort)](#31-completed-cr-team-phonecalls)
- [View: FSR Phone Calls This Month](#32-fsr-phone-calls-this-month)
- [View: FSR Phone Calls This Month (Filter)](#32-fsr-phone-calls-this-month)
- [View: FSR Phone Calls This Quarter](#33-fsr-phone-calls-this-quarter)
- [View: FSR Phone Calls This Quarter (Filter)](#33-fsr-phone-calls-this-quarter)
- [View: FSR Phone Calls This Week](#34-fsr-phone-calls-this-week)
- [View: FSR Phone Calls This Week (Filter)](#34-fsr-phone-calls-this-week)
- [View: FSR Phone Calls This Week (Sort)](#34-fsr-phone-calls-this-week)
- [View: My Calls This Month (Filter)](#35-my-calls-this-month)
- [View: My Calls This Quarter (Filter)](#36-my-calls-this-quarter)
- [View: My Calls This Week (Filter)](#37-my-calls-this-week)
- [View: My Calls This Year (Filter)](#38-my-calls-this-year)
- [View: Phone Calls This Month](#312-phone-calls-this-month)
- [View: Phone Calls This Month (Filter)](#312-phone-calls-this-month)
- [View: Phone Calls This Month (Sort)](#312-phone-calls-this-month)
- [View: Phone Calls This Quarter](#313-phone-calls-this-quarter)
- [View: Phone Calls This Quarter (Filter)](#313-phone-calls-this-quarter)
- [View: Phone Calls This Quarter (Sort)](#313-phone-calls-this-quarter)
- [View: Phone Calls This Week](#314-phone-calls-this-week)
- [View: Phone Calls This Week (Filter)](#314-phone-calls-this-week)
- [View: Phone Calls This Week (Sort)](#314-phone-calls-this-week)
- [View: Phone Calls This Year](#315-phone-calls-this-year)
- [View: Phone Calls This Year (Filter)](#315-phone-calls-this-year)
- [Chart: My Phone Calls This Quarter (Group-By)](#42-my-phone-calls-this-quarter)
- [Chart: My Phone Calls This Year (Group-By)](#43-my-phone-calls-this-year)
- [Chart: Phone Calls This Year By Owner (Group-By)](#44-phone-calls-this-year-by-owner)

#### address1_stateorprovince

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

#### azt_addresssearch

- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

#### azt_addresssearch2

- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

#### azt_addtocrtqueue

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > Auto-Create Callback](#21-phone-call-main-active)
- [JS: azt_phonecalllibrary > setAutoCallbackVisibility()](#86-azt_phonecalllibrary)
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

- [Plugin: OpportunityPreventCreateQuote (Read)](#1047-opportunitypreventcreatequote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)

#### azt_autocreatecallback

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > Auto-Create Callback](#21-phone-call-main-active)
- [JS: azt_phonecalllibrary > setAutoCallbackVisibility()](#86-azt_phonecalllibrary)
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

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > Auto-Create Callback](#21-phone-call-main-active)
- [JS: azt_phonecalllibrary > setAutoCallbackVisibility()](#86-azt_phonecalllibrary)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_callbackon

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > Auto-Create Callback](#21-phone-call-main-active)
- [JS: azt_phonecalllibrary > setAutoCallbackVisibility()](#86-azt_phonecalllibrary)
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

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > Auto-Create Callback](#21-phone-call-main-active)
- [JS: azt_phonecalllibrary > setAutoCallbackVisibility()](#86-azt_phonecalllibrary)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_copysubject

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > Auto-Create Callback](#21-phone-call-main-active)
- [JS: azt_phonecalllibrary > setAutoCallbackVisibility()](#86-azt_phonecalllibrary)
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

#### azt_defaultfreightamount

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_description

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_discountamount

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)

#### azt_discretionarydiscountamt

- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)

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

#### azt_fundingyear

- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: FundingYearSync (Read)](#1030-fundingyearsync)

#### azt_goaltype

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### azt_historicalowner

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call (Footer)](#21-phone-call-main-active)
- [Workflow: CloneAndDeleteQuote (Write)](#714-cloneanddeletequote)
- [Workflow: CloneOpportunity (Write)](#716-cloneopportunity)

#### azt_importname

- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImportPopulateName (Read)](#1037-leadimportpopulatename)

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

#### azt_invoiceproductid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#1063-quoteorderproductstrackdiscount)

#### azt_isbn

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_iscompanion

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### azt_isprint

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### azt_issaas

- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: SetOppProductDefaults (Write)](#1074-setoppproductdefaults)

#### azt_jobrole

- [View: FSR Phone Calls This Month (Filter)](#32-fsr-phone-calls-this-month)
- [View: FSR Phone Calls This Quarter (Filter)](#33-fsr-phone-calls-this-quarter)
- [View: FSR Phone Calls This Week (Filter)](#34-fsr-phone-calls-this-week)
- [View: My Calls This Month (Filter)](#35-my-calls-this-month)
- [View: My Calls This Quarter (Filter)](#36-my-calls-this-quarter)
- [View: My Calls This Week (Filter)](#37-my-calls-this-week)
- [View: My Calls This Year (Filter)](#38-my-calls-this-year)
- [View: Phone Calls This Month (Filter)](#312-phone-calls-this-month)
- [View: Phone Calls This Quarter (Filter)](#313-phone-calls-this-quarter)
- [View: Phone Calls This Week (Filter)](#314-phone-calls-this-week)
- [View: Phone Calls This Year (Filter)](#315-phone-calls-this-year)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: RestrictProductLookups (Read)](#1069-restrictproductlookups)

#### azt_jobtitle

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_lastactivitydate

- [Plugin: OpportunityLastActivityDate (Write)](#1045-opportunitylastactivitydate)

#### azt_lastmodifiedbyid

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)

#### azt_lastname

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_leadimportid

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### azt_leadsourceid

- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Write)](#1036-leadimport)

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

#### azt_paid

- [Plugin: Utility (Write)](#1081-utility)

#### azt_paidon

- [Plugin: FundingSetAnnualSpend (Filter)](#1028-fundingsetannualspend)
- [Plugin: Utility (Write)](#1081-utility)

#### azt_parentopportunityid

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityAudit (Image)](#1043-opportunityaudit)

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

#### azt_phonecallstatus

- [Field Definitions](#1-field-definitions)

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

#### azt_previousestclosedate

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_previousestimatedvalue

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_previousownerid

- [Plugin: CaseAudit (Write)](#1014-caseaudit)

#### azt_previousprobability

- [Plugin: OpportunityAudit (Write)](#1043-opportunityaudit)

#### azt_printproductid

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_printpurchaseid

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_probability

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)
- [Plugin: OpportunityProbabilityChange (Read)](#1048-opportunityprobabilitychange)
- [Plugin: OpportunityProbabilityChange (Image)](#1048-opportunityprobabilitychange)
- [Plugin: OpportunityProbabilityNumber (Read)](#1049-opportunityprobabilitynumber)

#### azt_probabilitychangedon

- [Plugin: OpportunityProbabilityChange (Write)](#1048-opportunityprobabilitychange)

#### azt_probabilityincreased

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

#### azt_reasonforexpense

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_recordowner

- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)

#### azt_recordownerid

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > general information](#21-phone-call-main-active)
- [View: FSR Phone Calls This Month](#32-fsr-phone-calls-this-month)
- [View: FSR Phone Calls This Week](#34-fsr-phone-calls-this-week)
- [View: FSR Phone Calls This Week (Sort)](#34-fsr-phone-calls-this-week)
- [View: My Calls This Month](#35-my-calls-this-month)
- [View: My Calls This Month (Filter)](#35-my-calls-this-month)
- [View: My Calls This Quarter (Filter)](#36-my-calls-this-quarter)
- [View: My Calls This Week](#37-my-calls-this-week)
- [View: My Calls This Week (Filter)](#37-my-calls-this-week)
- [View: My Calls This Year (Filter)](#38-my-calls-this-year)
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: My Open Phonecalls (Filter)](#39-my-open-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
- [View: Phone Calls This Month](#312-phone-calls-this-month)
- [View: Phone Calls This Quarter](#313-phone-calls-this-quarter)
- [View: Phone Calls This Week](#314-phone-calls-this-week)
- [Chart: Phone Calls This Quarter By Rep (Measure)](#41-phone-calls-this-quarter-by-rep)
- [Chart: Phone Calls This Quarter By Rep (Group-By)](#41-phone-calls-this-quarter-by-rep)
- [Chart: My Phone Calls This Quarter (Measure)](#42-my-phone-calls-this-quarter)
- [Chart: My Phone Calls This Year (Measure)](#43-my-phone-calls-this-year)
- [Chart: Phone Calls This Year By Owner (Measure)](#44-phone-calls-this-year-by-owner)
- [Chart: Phone Calls This Month By Rep (Measure)](#45-phone-calls-this-month-by-rep)
- [Chart: Phone Calls This Month By Rep (Group-By)](#45-phone-calls-this-month-by-rep)
- [Chart: Phone Calls This Week By Rep (Measure)](#46-phone-calls-this-week-by-rep)
- [Chart: Phone Calls This Week By Rep (Group-By)](#46-phone-calls-this-week-by-rep)
- [Chart: My Calls This Week (Measure)](#47-my-calls-this-week)
- [Chart: My Calls This Week (Group-By)](#47-my-calls-this-week)
- [Chart: My Calls This Month (Measure)](#48-my-calls-this-month)
- [Chart: My Calls This Month (Group-By)](#48-my-calls-this-month)
- [Workflow: 0ChangeQuoteRecordOwner (Write)](#71-0changequoterecordowner)
- [Workflow: AccountAuto-Assign (Write)](#72-accountauto-assign)
- [Workflow: AppointmentAuto-Assign (Write)](#73-appointmentauto-assign)
- [Workflow: BatchCreateEngagements (Write)](#76-batchcreateengagements)
- [Workflow: BatchOpportunityTransfer (Write)](#78-batchopportunitytransfer)
- [Workflow: CaseRecordOwner (Write)](#710-caserecordowner)
- [Workflow: CaseRecordOwnerAssign (Write)](#711-caserecordownerassign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#712-caserecordownerassignmentnotification)
- [Workflow: CloneLicense (Write)](#715-clonelicense)
- [Workflow: CloneOpportunity (Write)](#716-cloneopportunity)
- [Workflow: ContactAuto-Assign (Write)](#718-contactauto-assign)
- [Workflow: EngagementRecordOwner (Write)](#719-engagementrecordowner)
- [Workflow: EngagementRecordOwnerTeam (Read)](#720-engagementrecordownerteam)
- [Workflow: InvoiceRecordOwner (Write)](#724-invoicerecordowner)
- [Workflow: LeadAssignment (Write)](#725-leadassignment)
- [Workflow: OpportunityRecordOwner (Write)](#727-opportunityrecordowner)
- [Workflow: OpportunityRecordOwnerTeam (Read)](#728-opportunityrecordownerteam)
- [Workflow: OrderRecordOwner (Write)](#729-orderrecordowner)
- [Workflow: PhonecallAuto-Assign (Write)](#730-phonecallauto-assign)
- [Workflow: QuoteRecordOwner (Write)](#731-quoterecordowner)
- [Workflow: QuoteRecordOwnerTeam (Read)](#732-quoterecordownerteam)
- [Workflow: SendQuote (Read)](#733-sendquote)
- [Workflow: TaskAuto-Assign (Write)](#734-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Write)](#735-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#736-wonopportunityemail)
- [Workflow: WorkforceAccountAuto-assign (Write)](#737-workforceaccountauto-assign)
- [Workflow: WorkforceAppointmentAuto-Assign (Write)](#738-workforceappointmentauto-assign)
- [Workflow: WorkforceCaseAuto-assign (Write)](#739-workforcecaseauto-assign)
- [Workflow: WorkforceContactAuto-assign (Write)](#740-workforcecontactauto-assign)
- [Workflow: WorkforceEngagementAuto-assign (Write)](#741-workforceengagementauto-assign)
- [Workflow: WorkforceLeadAuto-Assign (Write)](#742-workforceleadauto-assign)
- [Workflow: WorkforceOpportunityAuto-assign (Write)](#743-workforceopportunityauto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Write)](#744-workforcephone-callauto-assign)
- [Workflow: WorkforceQuoteAuto-assign (Write)](#745-workforcequoteauto-assign)
- [Workflow: iGradAppointmentAuto-Assign (Write)](#746-igradappointmentauto-assign)
- [Workflow: iGradCaseAuto-Assign (Write)](#747-igradcaseauto-assign)
- [Workflow: iGradPhone-callAuto-assign (Write)](#748-igradphone-callauto-assign)
- [JS: azt_caselibrary > onLoad()](#81-azt_caselibrary)
- [JS: azt_engagementlibrary > onLoad()](#82-azt_engagementlibrary)
- [JS: azt_invoicelibrary > onLoad()](#83-azt_invoicelibrary)
- [JS: azt_opportunitylibrary > onLoad()](#84-azt_opportunitylibrary)
- [JS: azt_orderlibrary > onLoad()](#85-azt_orderlibrary)
- [JS: azt_quotelibrary](#87-azt_quotelibrary)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#108-activitycloseforcerecordowner)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Relationship: azt_systemuser_phonecall](#12-relationships)

#### azt_replacementproductid

- [Plugin: Utility (Read)](#1081-utility)

#### azt_requestedfreightamt

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_resolvedbyid

- [Plugin: CaseClose (Read)](#1015-caseclose)
- [Plugin: CaseClose (Write)](#1015-caseclose)

#### azt_result

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > general information](#21-phone-call-main-active)
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

#### category

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Sort)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Sort)](#1075-setprimarycontact)

#### city

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### closeprobability

- [Plugin: OpportunityProbabilityNumber (Write)](#1049-opportunityprobabilitynumber)

#### companyname

- [Plugin: LeadImport (Write)](#1036-leadimport)

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
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
- [Workflow: PhonecallAuto-Assign (Read)](#730-phonecallauto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Read)](#744-workforcephone-callauto-assign)
- [Workflow: iGradPhone-callAuto-assign (Read)](#748-igradphone-callauto-assign)

#### createdon

- [Field Definitions](#1-field-definitions)
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

#### customerid

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

#### datefulfilled

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### defaultuomid

- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### description

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchCancelAppointments (Write)](#74-batchcancelappointments)
- [Workflow: BatchCancelPhoneCalls (Write)](#75-batchcancelphonecalls)
- [Workflow: BatchOpportunityTransfer (Write)](#78-batchopportunitytransfer)
- [Workflow: CasePendingAssignmentNotification (Read)](#79-casependingassignmentnotification)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#712-caserecordownerassignmentnotification)
- [Workflow: CaseResolutionNotificationEmail (Write)](#713-caseresolutionnotificationemail)
- [Workflow: CloneOpportunity (Write)](#716-cloneopportunity)
- [Workflow: CloneOrder (Write)](#717-cloneorder)
- [Workflow: ExpenseNotificationManager (Write)](#721-expensenotificationmanager)
- [Workflow: ExpenseReportRejectedNotification (Write)](#722-expensereportrejectednotification)
- [Workflow: FSRLeadDistibutionNotification (Write)](#723-fsrleaddistibutionnotification)
- [Workflow: NewFSRLeadNotification (Write)](#726-newfsrleadnotification)
- [Workflow: SendQuote (Write)](#733-sendquote)
- [Workflow: WonOpportunityEmail (Write)](#736-wonopportunityemail)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

#### directioncode

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)

#### discountamount

- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)

#### discountpercentage

- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### emailaddress1

- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadImport (Filter)](#1036-leadimport)

#### estimatedclosedate

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityClone (Write)](#1044-opportunityclone)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

#### estimatedvalue

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

#### ext_amt

- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)

#### extendedamount

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

#### filename

- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### firstname

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### fiscalperiod

- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

#### freightamount

- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### freighttermscode

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### from

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)
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

#### incidentid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: CaseClose (Write)](#1015-caseclose)

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

- [Plugin: QuoteSyncTotalToOpportunity (Write)](#1066-quotesynctotaltoopportunity)

#### jobtitle

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### lastname

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### leftvoicemail

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)

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
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: OpportunityLineSyncToQuote (Sort)](#1046-opportunitylinesynctoquote)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Sort)](#1080-updateoppfromquote)

#### name

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

#### objectid

- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### objecttypecode

- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### opportunityid

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

#### originatingleadid

- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: OpportunityAssignFromLead (Read)](#1042-opportunityassignfromlead)

#### ownerid

- [Field Definitions](#1-field-definitions)
- [View: Completed CR Team Phonecalls (Filter)](#31-completed-cr-team-phonecalls)
- [View: Pending CR Team Phonecalls (Filter)](#310-pending-cr-team-phonecalls)
- [View: Phone Calls This Year](#315-phone-calls-this-year)
- [View: Phone Calls This Year (Sort)](#315-phone-calls-this-year)
- [Workflow: PhonecallAuto-Assign (Read)](#730-phonecallauto-assign)
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

#### owningteam

- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)

#### owninguser

- [Plugin: GetAcctTeamOwned (Join)](#1031-getacctteamowned)

#### parentaccountid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadQualify (Read)](#1038-leadqualify)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)

#### parentcontactid

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

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > phonecall > general information](#21-phone-call-main-active)
- [View: Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### pricelevelid

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
- [View: Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
- [View: Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)

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

#### producttypecode

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)

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

- [Field Definitions](#1-field-definitions)
- [View: Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
- [Workflow: AppointmentAuto-Assign (Read)](#73-appointmentauto-assign)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)
- [Workflow: BatchOpportunityTransfer (Write)](#78-batchopportunitytransfer)
- [Workflow: CasePendingAssignmentNotification (Write)](#79-casependingassignmentnotification)
- [Workflow: CaseRecordOwnerAssignmentNotification (Write)](#712-caserecordownerassignmentnotification)
- [Workflow: CaseResolutionNotificationEmail (Write)](#713-caseresolutionnotificationemail)
- [Workflow: ExpenseNotificationManager (Write)](#721-expensenotificationmanager)
- [Workflow: ExpenseReportRejectedNotification (Write)](#722-expensereportrejectednotification)
- [Workflow: FSRLeadDistibutionNotification (Write)](#723-fsrleaddistibutionnotification)
- [Workflow: NewFSRLeadNotification (Write)](#726-newfsrleadnotification)
- [Workflow: PhonecallAuto-Assign (Read)](#730-phonecallauto-assign)
- [Workflow: SendQuote (Write)](#733-sendquote)
- [Workflow: TaskAuto-Assign (Read)](#734-taskauto-assign)
- [Workflow: WonOpportunityEmail (Write)](#736-wonopportunityemail)
- [JS: azt_phonecalllibrary > onLoad()](#86-azt_phonecalllibrary)
- [Plugin: AccountReassignmentShareRecords (Filter)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#1076-sharebasedonaccessteam)
- [Plugin: ShareFromAccountShares (Read)](#1077-sharefromaccountshares)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)
- [Relationship: Account_Phonecalls](#12-relationships)
- [Relationship: Contact_Phonecalls](#12-relationships)
- [Relationship: Incident_Phonecalls](#12-relationships)
- [Relationship: Lead_Phonecalls](#12-relationships)
- [Relationship: Opportunity_Phonecalls](#12-relationships)
- [Relationship: adx_ad_PhoneCalls](#12-relationships)
- [Relationship: adx_adplacement_PhoneCalls](#12-relationships)
- [Relationship: adx_casedeflection_PhoneCalls](#12-relationships)
- [Relationship: adx_communityforumaccesspermission_PhoneCalls](#12-relationships)
- [Relationship: adx_communityforumalert_PhoneCalls](#12-relationships)
- [Relationship: adx_contentaccesslevel_PhoneCalls](#12-relationships)
- [Relationship: adx_invitation_PhoneCalls](#12-relationships)
- [Relationship: adx_poll_PhoneCalls](#12-relationships)
- [Relationship: adx_polloption_PhoneCalls](#12-relationships)
- [Relationship: adx_pollplacement_PhoneCalls](#12-relationships)
- [Relationship: adx_pollsubmission_PhoneCalls](#12-relationships)
- [Relationship: adx_publishingstatetransitionrule_PhoneCalls](#12-relationships)
- [Relationship: adx_redirect_PhoneCalls](#12-relationships)
- [Relationship: adx_shortcut_PhoneCalls](#12-relationships)
- [Relationship: adx_webpage_PhoneCalls](#12-relationships)
- [Relationship: adx_website_PhoneCalls](#12-relationships)
- [Relationship: azt_engagement_PhoneCalls](#12-relationships)
- [Relationship: azt_expensereport_PhoneCalls](#12-relationships)
- [Relationship: azt_training_PhoneCalls](#12-relationships)
- [Relationship: msdyn_customerasset_PhoneCalls](#12-relationships)
- [Relationship: msdyn_playbookinstance_PhoneCalls](#12-relationships)
- [Relationship: msdyn_postalbum_PhoneCalls](#12-relationships)
- [Relationship: msdyn_salessuggestion_PhoneCalls](#12-relationships)
- [Relationship: msdyn_swarm_PhoneCalls](#12-relationships)
- [Relationship: mspp_adplacement_PhoneCalls](#12-relationships)
- [Relationship: mspp_pollplacement_PhoneCalls](#12-relationships)
- [Relationship: mspp_publishingstatetransitionrule_PhoneCalls](#12-relationships)
- [Relationship: mspp_redirect_PhoneCalls](#12-relationships)
- [Relationship: mspp_shortcut_PhoneCalls](#12-relationships)
- [Relationship: mspp_website_PhoneCalls](#12-relationships)

#### requestdeliveryby

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

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

#### scheduledend

- [Field Definitions](#1-field-definitions)
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: My Open Phonecalls (Sort)](#39-my-open-phonecalls)
- [View: Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
- [View: Pending CR Team Phonecalls (Sort)](#310-pending-cr-team-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)
- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#107-activitiescreatedduedatesinpast)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

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

#### state

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### statecode

- [Field Definitions](#1-field-definitions)
- [View: Completed CR Team Phonecalls (Filter)](#31-completed-cr-team-phonecalls)
- [View: My Open Phonecalls (Filter)](#39-my-open-phonecalls)
- [View: Pending CR Team Phonecalls (Filter)](#310-pending-cr-team-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
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
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Write)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#1035-invoicecompcompleted)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: Utility (Filter)](#1081-utility)

#### street

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### subject

- [Field Definitions](#1-field-definitions)
- [Form: Phone Call > tab_ci_call_summary > tab_ci_section_call_summary](#21-phone-call-main-active)
- [Form: Phone Call > tab_ci_notes > tab_ci_section_notes](#21-phone-call-main-active)
- [View: Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
- [View: FSR Phone Calls This Month](#32-fsr-phone-calls-this-month)
- [View: FSR Phone Calls This Month (Sort)](#32-fsr-phone-calls-this-month)
- [View: FSR Phone Calls This Quarter](#33-fsr-phone-calls-this-quarter)
- [View: FSR Phone Calls This Quarter (Sort)](#33-fsr-phone-calls-this-quarter)
- [View: FSR Phone Calls This Week](#34-fsr-phone-calls-this-week)
- [View: My Calls This Month](#35-my-calls-this-month)
- [View: My Calls This Month (Sort)](#35-my-calls-this-month)
- [View: My Calls This Quarter](#36-my-calls-this-quarter)
- [View: My Calls This Quarter (Sort)](#36-my-calls-this-quarter)
- [View: My Calls This Week](#37-my-calls-this-week)
- [View: My Calls This Week (Sort)](#37-my-calls-this-week)
- [View: My Calls This Year](#38-my-calls-this-year)
- [View: My Calls This Year (Sort)](#38-my-calls-this-year)
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
- [View: Phone Call Advanced Find View](#311-phone-call-advanced-find-view)
- [View: Phone Call Advanced Find View (Sort)](#311-phone-call-advanced-find-view)
- [View: Phone Calls This Month](#312-phone-calls-this-month)
- [View: Phone Calls This Week](#314-phone-calls-this-week)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)
- [Workflow: PhonecallAuto-Assign (Read)](#730-phonecallauto-assign)
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

- [Field Definitions](#1-field-definitions)
- [View: Completed CR Team Phonecalls](#31-completed-cr-team-phonecalls)
- [View: My Open Phonecalls](#39-my-open-phonecalls)
- [View: Pending CR Team Phonecalls](#310-pending-cr-team-phonecalls)
- [Workflow: BatchCreateIntroCall (Write)](#77-batchcreateintrocall)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### totalamount

- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### transactioncurrencyid

- [Field Definitions](#1-field-definitions)
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

#### zipcode

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### {0}

- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
