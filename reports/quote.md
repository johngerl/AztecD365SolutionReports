# Quote Field Usage Analysis
> Date: 2026-03-21

## Table of Contents

- [1. Field Definitions](#1-field-definitions)
- [2. Forms](#2-forms)
  - [2.1. Quote (main) -- Active](#21-quote-main-active)
- [3. Views](#3-views)
  - [3.1. Active Quotes](#31-active-quotes)
  - [3.2. All Quotes](#32-all-quotes)
  - [3.3. My Quotes](#33-my-quotes)
  - [3.4. Quick Find All Quotes](#34-quick-find-all-quotes)
  - [3.5. Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [4. Chart Visualizations](#4-chart-visualizations)
- [5. Reports](#5-reports)
  - [5.1. PAQuoteReport](#51-paquotereport)
  - [5.2. PackingSlip](#52-packingslip)
  - [5.3. SoleSourceLetter](#53-solesourceletter)
  - [5.4. SummaryQuoteReport](#54-summaryquotereport)
  - [5.5. iGradQuoteReport](#55-igradquotereport)
- [6. Dashboards](#6-dashboards)
- [7. Workflows](#7-workflows)
  - [7.1. 0ChangeQuoteRecordOwner](#71-0changequoterecordowner)
  - [7.2. 0EngagementNames](#72-0engagementnames)
  - [7.3. AccountAuto-Assign](#73-accountauto-assign)
  - [7.4. AppointmentAuto-Assign](#74-appointmentauto-assign)
  - [7.5. BatchCloseQuotes](#75-batchclosequotes)
  - [7.6. BatchConverttoLead](#76-batchconverttolead)
  - [7.7. BatchCreateEngagements](#77-batchcreateengagements)
  - [7.8. BatchLooseOpportunities](#78-batchlooseopportunities)
  - [7.9. BatchOpportunityTransfer](#79-batchopportunitytransfer)
  - [7.10. CasePendingAssignmentNotification](#710-casependingassignmentnotification)
  - [7.11. CaseRecordOwner](#711-caserecordowner)
  - [7.12. CaseRecordOwnerAssign](#712-caserecordownerassign)
  - [7.13. CaseRecordOwnerAssignmentNotification](#713-caserecordownerassignmentnotification)
  - [7.14. CaseResolutionNotificationEmail](#714-caseresolutionnotificationemail)
  - [7.15. CloneAndDeleteQuote](#715-cloneanddeletequote)
  - [7.16. CloneLicense](#716-clonelicense)
  - [7.17. CloneOpportunity](#717-cloneopportunity)
  - [7.18. CloneOrder](#718-cloneorder)
  - [7.19. ContactAuto-Assign](#719-contactauto-assign)
  - [7.20. CreateLeadFromLeadGen](#720-createleadfromleadgen)
  - [7.21. CreateLeadfromAccount](#721-createleadfromaccount)
  - [7.22. CreateSoftwareLicense](#722-createsoftwarelicense)
  - [7.23. CustomLeadCreation](#723-customleadcreation)
  - [7.24. EffectiveTo](#724-effectiveto)
  - [7.25. EmailDeleteSendQuoteDrafts](#725-emaildeletesendquotedrafts)
  - [7.26. EmailRemoveUnsentEmails](#726-emailremoveunsentemails)
  - [7.27. EngagementRecordOwner](#727-engagementrecordowner)
  - [7.28. EngagementRecordOwnerTeam](#728-engagementrecordownerteam)
  - [7.29. InvoiceRecordOwner](#729-invoicerecordowner)
  - [7.30. LeadAssignment](#730-leadassignment)
  - [7.31. LeadQualifyDisqualifyDate](#731-leadqualifydisqualifydate)
  - [7.32. NewFSRLeadNotification](#732-newfsrleadnotification)
  - [7.33. OpportunityAuditRemoval](#733-opportunityauditremoval)
  - [7.34. OpportunityRecordOwner](#734-opportunityrecordowner)
  - [7.35. OpportunityRecordOwnerTeam](#735-opportunityrecordownerteam)
  - [7.36. OrderRecordOwner](#736-orderrecordowner)
  - [7.37. PhonecallAuto-Assign](#737-phonecallauto-assign)
  - [7.38. QualifyLead](#738-qualifylead)
  - [7.39. QuoteRecordOwner](#739-quoterecordowner)
  - [7.40. QuoteRecordOwnerTeam](#740-quoterecordownerteam)
  - [7.41. RenameEngagements](#741-renameengagements)
  - [7.42. SendQuote](#742-sendquote)
  - [7.43. SoftwareLicenseCreateEngagement](#743-softwarelicensecreateengagement)
  - [7.44. TaskAuto-Assign](#744-taskauto-assign)
  - [7.45. TaskCreateReorderLead](#745-taskcreatereorderlead)
  - [7.46. WonOpportunityEmail](#746-wonopportunityemail)
  - [7.47. WorkforceAccountAuto-assign](#747-workforceaccountauto-assign)
  - [7.48. WorkforceAppointmentAuto-Assign](#748-workforceappointmentauto-assign)
  - [7.49. WorkforceCaseAuto-assign](#749-workforcecaseauto-assign)
  - [7.50. WorkforceContactAuto-assign](#750-workforcecontactauto-assign)
  - [7.51. WorkforceEngagementAuto-assign](#751-workforceengagementauto-assign)
  - [7.52. WorkforceLeadAuto-Assign](#752-workforceleadauto-assign)
  - [7.53. WorkforceOpportunityAuto-assign](#753-workforceopportunityauto-assign)
  - [7.54. WorkforcePhone-callAuto-assign](#754-workforcephone-callauto-assign)
  - [7.55. WorkforceQuoteAuto-assign](#755-workforcequoteauto-assign)
  - [7.56. iGradAppointmentAuto-Assign](#756-igradappointmentauto-assign)
  - [7.57. iGradCaseAuto-Assign](#757-igradcaseauto-assign)
  - [7.58. iGradPhone-callAuto-assign](#758-igradphone-callauto-assign)
- [8. JavaScript Web Resources](#8-javascript-web-resources)
  - [8.1. azt_accountlibrary](#81-azt_accountlibrary)
  - [8.2. azt_addresslibrary](#82-azt_addresslibrary)
  - [8.3. azt_caselibrary](#83-azt_caselibrary)
  - [8.4. azt_createsoftwarelicense](#84-azt_createsoftwarelicense)
  - [8.5. azt_engagementlibrary](#85-azt_engagementlibrary)
  - [8.6. azt_expensereportlibrary](#86-azt_expensereportlibrary)
  - [8.7. azt_invoicelibrary](#87-azt_invoicelibrary)
  - [8.8. azt_opportunitylibrary](#88-azt_opportunitylibrary)
  - [8.9. azt_opportunitytrackdiscount](#89-azt_opportunitytrackdiscount)
  - [8.10. azt_orderlibrary](#810-azt_orderlibrary)
  - [8.11. azt_quotelibrary](#811-azt_quotelibrary)
  - [8.12. azt_sendquote](#812-azt_sendquote)
  - [8.13. azt_splitinvoice](#813-azt_splitinvoice)
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

Total fields: **76**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Last Update | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [accountid](#accountid) | Account | lookup |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | AccountId | AccountId |  |  |  |  |  |  |  | [12](#10-plugin-source-code-analysis) |  |  |  |  |
| 2 | [azt_defaultfreightamount](#azt_defaultfreightamount) | Default Freight Amount | money |  | Yes | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) | [1](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 3 | [azt_defaultfreightamount_base](#azt_defaultfreightamount_base) | Default Freight Amount (Base) | money |  | Yes | none | 2026-03-20 22:35:47 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 4 | [azt_discretionarydiscount](#azt_discretionarydiscount) | Discretionary Discount | money |  | Yes | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) | [2](#3-views) |  | [3](#5-reports) |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 5 | [azt_discretionarydiscount_base](#azt_discretionarydiscount_base) | Discretionary Discount (Base) | money |  | Yes | none | 2026-03-20 22:35:47 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 6 | [azt_discretionarydiscountamt](#azt_discretionarydiscountamt) | Discretionary Discount Amt | money |  | Yes | none | 2024-11-10 17:15:24 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 7 | [azt_discretionarydiscountamt_base](#azt_discretionarydiscountamt_base) | Discretionary Discount Amt (Base) | money |  | Yes | none | 2024-11-10 17:15:24 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 8 | [azt_freightamtapproved](#azt_freightamtapproved) | Freight Amt Approved? | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | Freight_Approved__c | Freight_Approved__c | [1](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 9 | [azt_historicalowner](#azt_historicalowner) | Historical Owner | nvarchar |  | Yes | none | 2026-02-13 16:44:19 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  | [3](#7-workflows) |  |  |  |  |  |  |
| 10 | [azt_ponumber](#azt_ponumber) | PO Number | nvarchar |  | Yes | none | 2026-01-22 16:04:03 | true |  |  |  | Quote | PO_Number__c | PO_Number__c | [1](#2-forms) |  |  | [1](#5-reports) |  | [3](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 11 | [azt_quoteapproval](#azt_quoteapproval) | Quote Approval | picklist | 276530000: Does not need approval, 276530001: Needs approval, 276530002: Approved | Yes | none | 2026-01-21 01:13:24 | true |  |  |  | Quote | Approved__c | Approved__c |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 12 | [azt_quotedcontactid](#azt_quotedcontactid) | Quoted Contact | lookup |  | Yes | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) |  |  | [1](#5-reports) |  | [3](#7-workflows) |  |  |  | [1](#12-relationships) |  |  |
| 13 | [azt_recapnotes](#azt_recapnotes) | Recap Notes | ntext |  | Yes | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | Quote_Summary__c | Quote_Summary__c | [1](#2-forms) |  |  | [3](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 14 | [azt_recapnotescannedoptions](#azt_recapnotescannedoptions) | Recap Notes (Canned Options) | picklist | 100000004: Internet Renewal, 276530000: Internet, 100000003: Kaplan Series, 100000001: GED Flash, 100000000: Life Skills Print, 276530001: LAN, 276530002: GED Ready Vouchers, 100000002: Third party vendors (ie..SHI), 276530003: COVID-19, 327630000: Print, 327630001: PassAssured | Yes | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 15 | [azt_recordownerid](#azt_recordownerid) | Record Owner | lookup |  | Yes | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) | [1](#3-views) |  | [3](#5-reports) |  | [37](#7-workflows) |  | [9](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 16 | [azt_requestedfreightamt](#azt_requestedfreightamt) | Requested Freight Amt | money |  | Yes | none | 2026-03-19 15:27:57 | true |  |  |  | Quote | Freight_Requested__c | Freight_Requested__c | [1](#2-forms) | [1](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 17 | [azt_requestedfreightamt_base](#azt_requestedfreightamt_base) | Requested Freight Amt (Base) | money |  | Yes | none | 2026-03-19 15:27:57 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 18 | [azt_shippingcompany](#azt_shippingcompany) | Ship To Company | nvarchar |  | Yes | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 19 | [azt_signedquotereceived](#azt_signedquotereceived) | Signed Quote Received? | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 22:35:47 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 20 | [azt_taxamount](#azt_taxamount) | Tax Amount | money |  | Yes | none | 2026-02-24 16:32:32 | true |  |  |  |  |  |  | [1](#2-forms) |  |  | [3](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 21 | [azt_taxamount_base](#azt_taxamount_base) | Tax Amount (Base) | money |  | Yes | none | 2026-02-24 16:32:32 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 22 | [billto_city](#billto_city) | Bill To City | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | BillingCity | BillingCity |  |  |  | [5](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 23 | [billto_contactname](#billto_contactname) | Bill To Contact Name | nvarchar |  | No | none | 2024-11-08 03:09:28 | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 24 | [billto_country](#billto_country) | Bill To Country/Region | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | BillingCountry | BillingCountry |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 25 | [billto_fax](#billto_fax) | Bill To Fax | nvarchar |  | No | none | Never | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 26 | [billto_line1](#billto_line1) | Bill To Street 1 | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | BillingStreet | BillingStreet |  |  |  | [5](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 27 | [billto_line2](#billto_line2) | Bill To Street 2 | nvarchar |  | No | none | 2026-03-20 16:28:01 | true |  |  |  |  |  |  |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 28 | [billto_line3](#billto_line3) | Bill To Street 3 | nvarchar |  | No | none | 2026-03-20 21:44:41 | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 29 | [billto_name](#billto_name) | Bill To Name | nvarchar |  | No | none | 2026-01-21 01:13:24 | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 30 | [billto_postalcode](#billto_postalcode) | Bill To ZIP/Postal Code | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | BillingPostalCode | BillingPostalCode |  |  |  | [5](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 31 | [billto_stateorprovince](#billto_stateorprovince) | Bill To State/Province | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | BillingState | BillingState |  |  |  | [5](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 32 | [billto_telephone](#billto_telephone) | Bill To Phone | nvarchar |  | No | none | 2021-09-07 02:22:59 | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 33 | [campaignid](#campaignid) | Source Campaign | lookup |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 34 | [closedon](#closedon) | Closed On | datetime |  | No | none | 2026-03-20 22:14:10 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 35 | [contactid](#contactid) | Contact | lookup |  | No | none | 2026-01-20 19:16:35 | true |  |  |  | Quote | ContactId | ContactId |  |  |  |  |  |  |  | [5](#10-plugin-source-code-analysis) |  |  |  |  |
| 36 | [createdby](#createdby) | Created By | lookup |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | CreatedById | CreatedById |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 37 | [createdon](#createdon) | Created On | datetime |  | No | none | Skipped (createdon) | true |  |  |  | Quote | CreatedDate | CreatedDate | [1](#2-forms) | [7](#3-views) |  | [1](#5-reports) |  | [1](#7-workflows) |  | [10](#10-plugin-source-code-analysis) |  |  |  |  |
| 38 | [customerid](#customerid) | Potential Customer | customer |  | No | required | 2026-03-20 22:35:47 | true |  |  |  |  |  |  |  | [5](#3-views) |  | [5](#5-reports) |  | [14](#7-workflows) |  | [11](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 39 | [description](#description) | Description | ntext |  | No | none | 2026-03-20 21:44:41 | true |  |  |  | Quote | Description | Description |  |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 40 | [discountamount](#discountamount) | Quote Discount Amount | money |  | No | none | 2026-02-20 19:23:10 | true |  |  |  | Quote | Discount | Discount | [1](#2-forms) |  |  | [3](#5-reports) |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 41 | [discountpercentage](#discountpercentage) | Quote Discount (%) | decimal |  | No | none | 2025-07-09 16:14:07 | true |  |  |  |  |  |  | [1](#2-forms) |  |  | [3](#5-reports) |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 42 | [effectivefrom](#effectivefrom) | Effective from | datetime |  | No | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) |  |  | [3](#5-reports) |  | [3](#7-workflows) |  |  |  |  |  |  |
| 43 | [effectiveto](#effectiveto) | Effective to | datetime |  | No | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) | [1](#3-views) |  | [3](#5-reports) |  | [4](#7-workflows) |  |  |  |  |  |  |
| 44 | [emailaddress](#emailaddress) | Email Address | nvarchar |  | No | none | Never | true |  |  |  | Quote | Email | Email |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 45 | [expireson](#expireson) | Due By | datetime |  | No | none | Never | true |  |  |  | Quote | ExpirationDate | ExpirationDate |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 46 | [freightamount](#freightamount) | Freight Amount | money |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | ShippingHandling | ShippingHandling | [1](#2-forms) | [1](#3-views) |  | [4](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 47 | [freightamount_base](#freightamount_base) | Freight Amount (Base) | money |  | No | none | 2026-03-20 22:35:47 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 48 | [freighttermscode](#freighttermscode) | Freight Terms | picklist |  | No | none | 2026-03-20 22:27:06 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 49 | [modifiedon](#modifiedon) | Modified On | datetime |  | No | none | Skipped (modifiedon) | true |  |  |  | Quote | LastModifiedDate | LastModifiedDate |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 50 | [name](#name) | Name | nvarchar |  | No | required | 2026-03-20 22:35:47 | true |  |  |  | Quote | Name | Name |  | [8](#3-views) |  | [10](#5-reports) |  | [17](#7-workflows) |  | [23](#10-plugin-source-code-analysis) |  |  |  |  |
| 51 | [opportunityid](#opportunityid) | Opportunity | lookup |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | OpportunityId | OpportunityId |  | [1](#3-views) |  |  |  | [2](#7-workflows) |  | [32](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 52 | [ownerid](#ownerid) | Owner | lookup |  | No | required | 2026-03-20 22:35:47 | true |  |  |  | Quote | OwnerId | OwnerId | [1](#2-forms) |  |  | [1](#5-reports) |  | [2](#7-workflows) |  | [22](#10-plugin-source-code-analysis) |  |  |  |  |
| 53 | [paymenttermscode](#paymenttermscode) | Payment Terms | picklist |  | No | none | 2025-07-18 12:45:13 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 54 | [pricelevelid](#pricelevelid) | Price List | lookup |  | No | required | 2026-03-20 22:35:47 | true |  |  |  | Quote | Pricebook2Id | Pricebook2Id |  |  |  |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 55 | [quoteid](#quoteid) | Quote | uniqueidentifier |  | No | required | 2026-03-20 22:35:47 | true |  |  |  |  |  |  |  | [5](#3-views) |  | [4](#5-reports) |  | [3](#7-workflows) |  | [20](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 56 | [quotenumber](#quotenumber) | Quote ID | nvarchar |  | No | systemrequired | 2026-03-20 22:35:47 | true |  |  |  | Quote | QuoteNumber | QuoteNumber |  | [1](#3-views) |  | [4](#5-reports) |  |  |  |  |  |  |  |  |
| 57 | [requestdeliveryby](#requestdeliveryby) | Requested Delivery Date | datetime |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 58 | [shippingmethodcode](#shippingmethodcode) | Shipping Method | picklist |  | No | none | 2026-03-20 22:27:06 | true |  |  |  |  |  |  |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 59 | [shipto_city](#shipto_city) | Ship To City | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | ShippingCity | ShippingCity |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 60 | [shipto_contactname](#shipto_contactname) | Shipping Contact | nvarchar |  | No | none | 2025-08-12 17:04:53 | true |  |  |  |  |  |  | [1](#2-forms) |  |  | [3](#5-reports) |  | [3](#7-workflows) |  |  |  |  |  |  |
| 61 | [shipto_country](#shipto_country) | Ship To Country/Region | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | ShippingCountry | ShippingCountry |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 62 | [shipto_fax](#shipto_fax) | Ship To Fax | nvarchar |  | No | none | Never | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 63 | [shipto_freighttermscode](#shipto_freighttermscode) | Ship To Freight Terms | picklist |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 64 | [shipto_line1](#shipto_line1) | Ship To Street 1 | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | ShippingStreet | ShippingStreet |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 65 | [shipto_line2](#shipto_line2) | Ship To Street 2 | nvarchar |  | No | none | 2026-03-20 16:28:01 | true |  |  |  |  |  |  |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 66 | [shipto_line3](#shipto_line3) | Ship To Street 3 | nvarchar |  | No | none | 2026-03-20 22:14:10 | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 67 | [shipto_name](#shipto_name) | Ship To Name | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) |  |  | [2](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 68 | [shipto_postalcode](#shipto_postalcode) | Ship To ZIP/Postal Code | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | ShippingPostalCode | ShippingPostalCode |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 69 | [shipto_stateorprovince](#shipto_stateorprovince) | Ship To State/Province | nvarchar |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | ShippingState | ShippingState |  |  |  | [2](#5-reports) |  | [2](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 70 | [shipto_telephone](#shipto_telephone) | Ship To Phone | nvarchar |  | No | none | 2021-05-31 23:15:13 | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  | [2](#7-workflows) |  |  |  |  |  |  |
| 71 | [statecode](#statecode) | Status | state |  | No | systemrequired | 2026-03-20 22:35:47 | true |  |  |  |  |  |  |  | [8](#3-views) |  | [1](#5-reports) |  | [10](#7-workflows) |  | [20](#10-plugin-source-code-analysis) |  |  |  |  |
| 72 | [statuscode](#statuscode) | Status Reason | status |  | No | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  |  |  |  | [2](#5-reports) |  | [5](#7-workflows) |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 73 | [totalamount](#totalamount) | Total Amount | money |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | GrandTotal | GrandTotal |  | [5](#3-views) |  | [5](#5-reports) |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 74 | [totallineitemamount](#totallineitemamount) | Total Detail Amount | money |  | No | none | 2026-03-20 22:35:47 | true |  |  |  | Quote | Subtotal | Subtotal |  |  |  | [3](#5-reports) |  |  |  |  |  |  |  |  |
| 75 | [transactioncurrencyid](#transactioncurrencyid) | Currency | lookup |  | No | required | 2026-03-20 22:35:47 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 76 | [willcall](#willcall) | Ship To | bit |  | No | none | 2026-03-20 22:35:47 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |

---

## 2. Forms

Total forms: **1**

### 2.1. Quote (main) -- Active

- **Form ID:** `{54076a2d-d043-4a1b-b061-4d06846371a9}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Summary_tab

##### Section: quote information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_ponumber](#azt_ponumber) | PO Number | No | Yes |
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |
| [azt_quotedcontactid](#azt_quotedcontactid) | Quoted Contact | No | Yes |
| [shipto_name](#shipto_name) | Ship To Name | No | Yes |
| [azt_shippingcompany](#azt_shippingcompany) | Ship To Company | No | Yes |
| [shipto_contactname](#shipto_contactname) | Shipping Contact: | No | No |

##### Section: shipping information

##### Section: addresses

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [willcall](#willcall) | Ship To | No | Yes |

##### Section: products

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quotelines](#quotelines) | Quote Products | No | Yes |

##### Section: totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discountpercentage](#discountpercentage) |  | Yes | Yes |
| [discountamount](#discountamount) |  | Yes | Yes |
| [freightamount](#freightamount) |  | Yes | Yes |
| [azt_discretionarydiscount](#azt_discretionarydiscount) | Discretionary Discount | No | Yes |
| [azt_discretionarydiscountamt](#azt_discretionarydiscountamt) | Discretionary Discount Amt | Yes | No |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recapnotes](#azt_recapnotes) | Recap Notes | No | Yes |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recapnotescannedoptions](#azt_recapnotescannedoptions) | Recap Notes (Canned Options) | No | Yes |

##### Section: sales_information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_taxamount](#azt_taxamount) | Tax Amount | No | Yes |

##### Section: description_section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#ownerid) | Owner | No | Yes |
| [accessteam](#accessteam) | Access Team Members | No | Yes |

##### Section: Freight

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_defaultfreightamount](#azt_defaultfreightamount) | Default Freight Amount | Yes | Yes |
| [azt_requestedfreightamt](#azt_requestedfreightamt) | Requested Freight Amt | No | Yes |
| [azt_freightamtapproved](#azt_freightamtapproved) | Freight Amt Approved? | No | Yes |

#### Tab: details_tab

##### Section: tab_2_section_2

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [effectivefrom](#effectivefrom) | Effective From | No | Yes |
| [effectiveto](#effectiveto) | Effective To | No | Yes |
| [createdon](#createdon) | Created On | No | Yes |

#### Tab: Administration

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quotedetailsGrid](#quotedetailsgrid) | PRODUCTS | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [azt_historicalowner](#azt_historicalowner) | Historical Owner |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `QUO.QuoteFunctions.setFreight` | `azt_quotelibrary` | true |
| onchange | azt_recapnotescannedoptions | `QUO.QuoteFunctions.onLoad` | `azt_quotelibrary` | true |
| onchange | azt_freightamtapproved | `QUO.QuoteFunctions.setFreight` | `azt_quotelibrary` | true |
| onchange | azt_freightamtapproved | `QUO.QuoteFunctions.getProductInfo` | `azt_quotelibrary` | false |

---

## 3. Views

Total views: **5**

### 3.1. Active Quotes

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [statecode](#statecode) | 100px |
| 3 | [totalamount](#totalamount) | 100px |
| 4 | [customerid](#customerid) | 150px |
| 5 | [azt_discretionarydiscount](#azt_discretionarydiscount) | 125px |
| 6 | [createdon](#createdon) | 150px |
| 7 | [quoteid](#quoteid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Descending |

### 3.2. All Quotes

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [statecode](#statecode) | 100px |
| 3 | [totalamount](#totalamount) | 100px |
| 4 | [customerid](#customerid) | 150px |
| 5 | [quotecustomeridcontactcontactid.emailaddress1](#quotecustomeridcontactcontactidemailaddress1) | 150px |
| 6 | [azt_discretionarydiscount](#azt_discretionarydiscount) | 125px |
| 7 | [opportunityid](#opportunityid) | 200px |
| 8 | [emailaddress1](#emailaddress1) |  |
| 9 | [quoteid](#quoteid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Descending |

### 3.3. My Quotes

- **Type:** Standard (querytype=0)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [statecode](#statecode) | 100px |
| 3 | [totalamount](#totalamount) | 100px |
| 4 | [customerid](#customerid) | 150px |
| 5 | [quotecustomeridcontactcontactid.emailaddress1](#quotecustomeridcontactcontactidemailaddress1) | 150px |
| 6 | [createdon](#createdon) | 150px |
| 7 | [emailaddress1](#emailaddress1) |  |
| 8 | [quoteid](#quoteid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [statecode](#statecode) | eq | 0 |
| [statecode](#statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Descending |

### 3.4. Quick Find All Quotes

- **Type:** Quick Find (querytype=4)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [customerid](#customerid) | 150px |
| 3 | [statecode](#statecode) | 100px |
| 4 | [totalamount](#totalamount) | 100px |
| 5 | [createdon](#createdon) | 150px |
| 6 | [quoteid](#quoteid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [quotenumber](#quotenumber) | like | {0} |
| [name](#name) | like | {0} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.5. Quotes Needing Freight Approval

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [statecode](#statecode) | 100px |
| 3 | [totalamount](#totalamount) | 100px |
| 4 | [customerid](#customerid) | 150px |
| 5 | [effectiveto](#effectiveto) | 100px |
| 6 | [azt_defaultfreightamount](#azt_defaultfreightamount) | 150px |
| 7 | [azt_requestedfreightamt](#azt_requestedfreightamt) | 150px |
| 8 | [freightamount](#freightamount) | 150px |
| 9 | [createdon](#createdon) | 100px |
| 10 | [quoteid](#quoteid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Ascending |

---

## 4. Chart Visualizations

Total charts: **0**

---

## 5. Reports

Total reports referencing Quote: **5**

### 5.1. PAQuoteReport

- **File:** `PAQuoteReportrdl2a31f328-ff1a-ec11-b6e6-0022480b3758`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#name)
- [customerid](#customerid)
- [totalamount](#totalamount)
- [quoteid](#quoteid)
- [effectiveto](#effectiveto)
- [effectivefrom](#effectivefrom)
- [quotenumber](#quotenumber)
- [azt_recapnotes](#azt_recapnotes)
- [totallineitemamount](#totallineitemamount)
- [discountpercentage](#discountpercentage)
- [discountamount](#discountamount)
- [freightamount](#freightamount)
- [billto_line1](#billto_line1)
- [billto_city](#billto_city)
- [billto_postalcode](#billto_postalcode)
- [billto_stateorprovince](#billto_stateorprovince)
- [shipto_line1](#shipto_line1)
- [shipto_line2](#shipto_line2)
- [shipto_city](#shipto_city)
- [shipto_stateorprovince](#shipto_stateorprovince)
- [shipto_postalcode](#shipto_postalcode)
- [shipto_country](#shipto_country)
- [azt_taxamount](#azt_taxamount)
- [shippingmethodcode](#shippingmethodcode)
- [azt_recordownerid](#azt_recordownerid)
- [shipto_contactname](#shipto_contactname)
- [shipto_name](#shipto_name)
- [azt_discretionarydiscount](#azt_discretionarydiscount)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

**Link Entity:** `account` (alias: `Customer`, type: inner, from: `accountid` to: `customerid`)

Fields:

- [address2_line1](#address2_line1) *(via account)*

**Link Entity:** `systemuser` (alias: `Owner`, type: outer, from: `systemuserid` to: `azt_recordownerid`)

Fields:

- [title](#title) *(via systemuser)*
- [jobtitle](#jobtitle) *(via systemuser)*

**Link Entity:** `contact` (alias: `QuotedContact`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [fullname](#fullname) *(via contact)*

**Link Entity:** `quotedetail` (alias: `Lines`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [manualdiscountamount](#manualdiscountamount) *(via quotedetail)*
- [baseamount](#baseamount) *(via quotedetail)*

**Report Field Mappings:**

| Report Field | Data Field |
|-------------|------------|
| name | name |
| customerid | customerid |
| effectivefrom | effectivefrom |
| customeridValue | customeridValue |
| effectiveto | effectiveto |
| customeridEntityName | customeridEntityName |
| totalamountValue | totalamountValue |
| quotenumber | quotenumber |
| quoteid | quoteid |
| effectivetoValue | effectivetoValue |
| totalamount | totalamount |
| totallineitemamount | totallineitemamount |
| effectivefromValue | effectivefromValue |
| freightamount | freightamount |
| discountamount | discountamount |
| azt_recapnotes | azt_recapnotes |
| discountpercentage | discountpercentage |
| totallineitemamountValue | totallineitemamountValue |
| billto_line1 | billto_line1 |
| billto_stateorprovince | billto_stateorprovince |
| DiscountAmountCalc |  |
| discountpercentageValue | discountpercentageValue |
| billto_city | billto_city |
| discountamountValue | discountamountValue |
| shippingmethodcode | shippingmethodcode |
| freightamountValue | freightamountValue |
| billto_postalcode | billto_postalcode |
| azt_taxamount | azt_taxamount |
| azt_taxamountValue | azt_taxamountValue |
| shippingmethodcodeValue | shippingmethodcodeValue |
| ownerid | ownerid |
| owneridValue | owneridValue |
| Owner_title | Owner_title |
| DiscretionaryDiscount | DiscretionaryDiscount |
| ShipLine1 | ShipLine1 |
| DiscretionaryDiscountValue | DiscretionaryDiscountValue |
| ShipLine2 | ShipLine2 |
| Owner_jobtitle | Owner_jobtitle |
| Attention | Attention |
| ShipCity | ShipCity |
| AddressName | AddressName |
| owneridEntityName | owneridEntityName |
| AcctAddLine1 | AcctAddLine1 |
| ShipState | ShipState |
| QuotedContact_fullname | QuotedContact_fullname |
| ShipZip | ShipZip |
| LineDiscount | LineDiscount |
| ShipCountry | ShipCountry |
| ExtAmt | ExtAmt |
| TotalPlusTax |  |
| LineDiscountValue | LineDiscountValue |
| ExtAmtValue | ExtAmtValue |

### 5.2. PackingSlip

- **File:** `PackingSliprdl2dc9c68e-7c7c-eb11-a812-000d3a3ab0fe`
- **DataSets:** 1

#### DataSet: OrderHeader

**Parameters:** CRM_FilteredSalesOrder

**Primary Entity:** `salesorder`

**Selected Fields:**

- [name](#name)
- [customerid](#customerid)
- [statuscode](#statuscode)
- [totalamount](#totalamount)
- [salesorderid](#salesorderid)
- [statecode](#statecode)
- [ordernumber](#ordernumber)
- [shippingmethodcode](#shippingmethodcode)
- [shipto_fax](#shipto_fax)
- [shipto_country](#shipto_country)
- [shipto_contactname](#shipto_contactname)
- [shipto_city](#shipto_city)
- [shipto_line3](#shipto_line3)
- [shipto_line2](#shipto_line2)
- [shipto_line1](#shipto_line1)
- [shipto_postalcode](#shipto_postalcode)
- [shipto_stateorprovince](#shipto_stateorprovince)
- [shipto_name](#shipto_name)
- [shipto_telephone](#shipto_telephone)
- [freightamount](#freightamount)
- [billto_postalcode](#billto_postalcode)
- [billto_line3](#billto_line3)
- [billto_line2](#billto_line2)
- [billto_line1](#billto_line1)
- [billto_stateorprovince](#billto_stateorprovince)
- [billto_telephone](#billto_telephone)
- [billto_name](#billto_name)
- [billto_fax](#billto_fax)
- [billto_country](#billto_country)
- [billto_contactname](#billto_contactname)
- [billto_city](#billto_city)
- [datefulfilled](#datefulfilled)
- [createdon](#createdon)
- [azt_trackingnumber](#azt_trackingnumber)
- [azt_ponumber](#azt_ponumber)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

**Link Entity:** `quote` (alias: `Quote`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [quotenumber](#quotenumber) *(via quote)*

**Report Field Mappings:**

| Report Field | Data Field |
|-------------|------------|
| name | name |
| customerid | customerid |
| customeridValue | customeridValue |
| customeridEntityName | customeridEntityName |
| statuscode | statuscode |
| statuscodeValue | statuscodeValue |
| totalamount | totalamount |
| OrderNumber | ordernumber |
| totalamountValue | totalamountValue |
| salesorderid | salesorderid |
| statecode | statecode |
| statecodeValue | statecodeValue |
| shippingmethodcode | shippingmethodcode |
| shippingmethodcodeValue | shippingmethodcodeValue |
| shipto_fax | shipto_fax |
| shipto_country | shipto_country |
| shipto_contactname | shipto_contactname |
| shipto_city | shipto_city |
| shipto_line3 | shipto_line3 |
| shipto_line2 | shipto_line2 |
| shipto_line1 | shipto_line1 |
| shipto_postalcode | shipto_postalcode |
| shipto_stateorprovince | shipto_stateorprovince |
| shipto_name | shipto_name |
| shipto_telephone | shipto_telephone |
| freightamount | freightamount |
| freightamountValue | freightamountValue |
| billto_postalcode | billto_postalcode |
| billto_line3 | billto_line3 |
| billto_line2 | billto_line2 |
| billto_line1 | billto_line1 |
| billto_stateorprovince | billto_stateorprovince |
| CreatedOn | createdon |
| billto_telephone | billto_telephone |
| DateFulfilled | datefulfilled |
| billto_name | billto_name |
| billto_fax | billto_fax |
| billto_country | billto_country |
| billto_contactname | billto_contactname |
| billto_city | billto_city |
| datefulfilledValue | datefulfilledValue |
| createdonValue | createdonValue |
| azt_trackingnumber | azt_trackingnumber |
| azt_ponumber | azt_ponumber |
| Quote_quotenumber | Quote_quotenumber |

### 5.3. SoleSourceLetter

- **File:** `SoleSourceLetterrdl0625ed05-ce6b-ee11-8df0-000d3a993b8f`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#name)
- [customerid](#customerid)
- [statuscode](#statuscode)
- [totalamount](#totalamount)
- [azt_quotedcontactid](#azt_quotedcontactid)
- [quoteid](#quoteid)
- [billto_stateorprovince](#billto_stateorprovince)
- [billto_postalcode](#billto_postalcode)
- [billto_line2](#billto_line2)
- [billto_line1](#billto_line1)
- [billto_city](#billto_city)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

**Link Entity:** `contact` (alias: `Cont`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [firstname](#firstname) *(via contact)*

**Report Field Mappings:**

| Report Field | Data Field |
|-------------|------------|
| name | name |
| customerid | customerid |
| customeridValue | customeridValue |
| customeridEntityName | customeridEntityName |
| statuscode | statuscode |
| statuscodeValue | statuscodeValue |
| totalamount | totalamount |
| totalamountValue | totalamountValue |
| azt_quotedcontactid | azt_quotedcontactid |
| azt_quotedcontactidValue | azt_quotedcontactidValue |
| azt_quotedcontactidEntityName | azt_quotedcontactidEntityName |
| quoteid | quoteid |
| billto_stateorprovince | billto_stateorprovince |
| billto_postalcode | billto_postalcode |
| Cont_firstname | Cont_firstname |
| billto_line2 | billto_line2 |
| billto_line1 | billto_line1 |
| billto_city | billto_city |

### 5.4. SummaryQuoteReport

- **File:** `SummaryQuoteReportrdl3ce3296b-d1de-e911-a960-000d3a3b9b3d`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#name)
- [customerid](#customerid)
- [totalamount](#totalamount)
- [quoteid](#quoteid)
- [effectivefrom](#effectivefrom)
- [effectiveto](#effectiveto)
- [ownerid](#ownerid)
- [quotenumber](#quotenumber)
- [azt_recapnotes](#azt_recapnotes)
- [discountpercentage](#discountpercentage)
- [totallineitemamount](#totallineitemamount)
- [freightamount](#freightamount)
- [discountamount](#discountamount)
- [billto_line1](#billto_line1)
- [billto_city](#billto_city)
- [billto_stateorprovince](#billto_stateorprovince)
- [billto_postalcode](#billto_postalcode)
- [azt_taxamount](#azt_taxamount)
- [azt_recordownerid](#azt_recordownerid)
- [azt_discretionarydiscount](#azt_discretionarydiscount)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

**Link Entity:** `contact` (alias: `quotedcontact`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [fullname](#fullname) *(via contact)*

**Link Entity:** `systemuser` (alias: `owner`, type: outer, from: `systemuserid` to: `owninguser`)

Fields:

- [title](#title) *(via systemuser)*

**Link Entity:** `quotedetail` (alias: `Lines`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [manualdiscountamount](#manualdiscountamount) *(via quotedetail)*
- [baseamount](#baseamount) *(via quotedetail)*

**Report Field Mappings:**

| Report Field | Data Field |
|-------------|------------|
| name | name |
| customerid | customerid |
| customeridValue | customeridValue |
| customeridEntityName | customeridEntityName |
| totalamount | totalamount |
| totalamountValue | totalamountValue |
| quoteid | quoteid |
| effectivefrom | effectivefrom |
| effectivefromValue | effectivefromValue |
| effectiveto | effectiveto |
| effectivetoValue | effectivetoValue |
| ownerid | ownerid |
| owneridValue | owneridValue |
| owneridEntityName | owneridEntityName |
| quotenumber | quotenumber |
| azt_recapnotes | azt_recapnotes |
| discountpercentage | discountpercentage |
| discountpercentageValue | discountpercentageValue |
| totallineitemamount | totallineitemamount |
| totallineitemamountValue | totallineitemamountValue |
| freightamount | freightamount |
| freightamountValue | freightamountValue |
| discountamount | discountamount |
| discountamountValue | discountamountValue |
| billto_line1 | billto_line1 |
| billto_city | billto_city |
| billto_stateorprovince | billto_stateorprovince |
| billto_postalcode | billto_postalcode |
| azt_taxamount | azt_taxamount |
| azt_taxamountValue | azt_taxamountValue |
| DiscretionaryDiscount | DiscretionaryDiscount |
| RecordOwner | RecordOwner |
| quotedcontact_fullname | quotedcontact_fullname |
| RecordOwnerValue | RecordOwnerValue |
| RecordOwnerEntityName | RecordOwnerEntityName |
| DiscretionaryDiscountValue | DiscretionaryDiscountValue |
| owner_title | owner_title |
| LineDiscount | LineDiscount |
| LineDiscountValue | LineDiscountValue |
| ExtAmt | ExtAmt |
| ExtAmtValue | ExtAmtValue |

### 5.5. iGradQuoteReport

- **File:** `iGradQuoteReportrdlc630364e-748a-ed11-81ad-000d3a993b8f`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#name)
- [customerid](#customerid)
- [totalamount](#totalamount)
- [quoteid](#quoteid)
- [effectivefrom](#effectivefrom)
- [effectiveto](#effectiveto)
- [azt_recordownerid](#azt_recordownerid)
- [quotenumber](#quotenumber)
- [azt_recapnotes](#azt_recapnotes)
- [discountpercentage](#discountpercentage)
- [totallineitemamount](#totallineitemamount)
- [freightamount](#freightamount)
- [discountamount](#discountamount)
- [billto_line1](#billto_line1)
- [billto_city](#billto_city)
- [billto_stateorprovince](#billto_stateorprovince)
- [billto_postalcode](#billto_postalcode)
- [azt_taxamount](#azt_taxamount)
- [shipto_contactname](#shipto_contactname)
- [azt_discretionarydiscount](#azt_discretionarydiscount)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

**Link Entity:** `contact` (alias: `quotedcontact`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [fullname](#fullname) *(via contact)*

**Link Entity:** `systemuser` (alias: `owner`, type: outer, from: `systemuserid` to: `azt_recordownerid`)

Fields:

- [title](#title) *(via systemuser)*

**Link Entity:** `quotedetail` (alias: `Lines`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [manualdiscountamount](#manualdiscountamount) *(via quotedetail)*
- [baseamount](#baseamount) *(via quotedetail)*

**Report Field Mappings:**

| Report Field | Data Field |
|-------------|------------|
| name | name |
| customerid | customerid |
| customeridValue | customeridValue |
| customeridEntityName | customeridEntityName |
| totalamount | totalamount |
| totalamountValue | totalamountValue |
| quoteid | quoteid |
| effectivefrom | effectivefrom |
| effectivefromValue | effectivefromValue |
| effectiveto | effectiveto |
| effectivetoValue | effectivetoValue |
| ownerid | ownerid |
| owneridValue | owneridValue |
| owneridEntityName | owneridEntityName |
| quotenumber | quotenumber |
| azt_recapnotes | azt_recapnotes |
| discountpercentage | discountpercentage |
| discountpercentageValue | discountpercentageValue |
| totallineitemamount | totallineitemamount |
| totallineitemamountValue | totallineitemamountValue |
| freightamount | freightamount |
| freightamountValue | freightamountValue |
| discountamount | discountamount |
| discountamountValue | discountamountValue |
| billto_line1 | billto_line1 |
| billto_city | billto_city |
| billto_stateorprovince | billto_stateorprovince |
| billto_postalcode | billto_postalcode |
| azt_taxamount | azt_taxamount |
| azt_taxamountValue | azt_taxamountValue |
| Attention | Attention |
| DiscretionaryDiscount | DiscretionaryDiscount |
| quotedcontact_fullname | quotedcontact_fullname |
| DiscretionaryDiscountValue | DiscretionaryDiscountValue |
| owner_title | owner_title |
| LineDiscount | LineDiscount |
| LineDiscountValue | LineDiscountValue |
| ExtAmt | ExtAmt |
| ExtAmtValue | ExtAmtValue |

---

## 6. Dashboards

Total dashboards referencing Quote: **0**

---

## 7. Workflows

Total workflows referencing Quote: **58**

### 7.1. 0ChangeQuoteRecordOwner

- **File:** `0ChangeQuoteRecordOwner-938FE262-FF96-42CB-8332-50B6A947A533.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.2. 0EngagementNames

- **File:** `0EngagementNames-BC419DA7-86F1-43E4-88B5-509514704A0C.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#name)

### 7.3. AccountAuto-Assign

- **File:** `AccountAuto-Assign-6DE252A4-C0D8-4C6B-800E-3985440C88D1.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`

### 7.4. AppointmentAuto-Assign

- **File:** `AppointmentAuto-Assign-1A553A9D-514D-42CA-A9AE-73FEED04E1E5.xaml`
- **Entity References:** quote
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.5. BatchCloseQuotes

- **File:** `BatchCloseQuotes-57805330-A998-42E2-A194-2935648BCAD7.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

### 7.6. BatchConverttoLead

- **File:** `BatchConverttoLead-CC0F2DBB-B8CB-4B06-B891-DB6D97252DB8.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

**Fields Written:**

- [statecode](#statecode)

### 7.7. BatchCreateEngagements

- **File:** `BatchCreateEngagements-CC9CDFC6-4BC9-4635-B786-0C7BE2C34344.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)
- [statuscode](#statuscode)

### 7.8. BatchLooseOpportunities

- **File:** `BatchLooseOpportunities-BFF14F2D-338D-4CBD-B2CE-C0907E02E6C7.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

### 7.9. BatchOpportunityTransfer

- **File:** `BatchOpportunityTransfer-744FEB80-2251-4252-875E-ED9958CB448A.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.10. CasePendingAssignmentNotification

- **File:** `CasePendingAssignmentNotification-177DE8B3-E0C3-4F1C-A7B5-DA84B3629AED.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#customerid)

### 7.11. CaseRecordOwner

- **File:** `CaseRecordOwner-E2135799-C146-4E0B-A0A5-F9917895B23E.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#customerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.12. CaseRecordOwnerAssign

- **File:** `CaseRecordOwnerAssign-02EE1A9D-1658-4013-BF63-9C0E5C65AAD0.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#customerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.13. CaseRecordOwnerAssignmentNotification

- **File:** `CaseRecordOwnerAssignmentNotification-2F6035E6-1FBC-476B-9C97-4554E8360B7C.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [customerid](#customerid)

### 7.14. CaseResolutionNotificationEmail

- **File:** `CaseResolutionNotificationEmail-734E721F-7454-4437-8BAC-8B20F496DF12.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [statecode](#statecode)

### 7.15. CloneAndDeleteQuote

- **File:** `CloneAndDeleteQuote-1D87A694-5A08-4C93-9925-447BB4FE7DA6.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [azt_historicalowner](#azt_historicalowner)
- [azt_ponumber](#azt_ponumber)
- [azt_quoteapproval](#azt_quoteapproval)
- [azt_quotedcontactid](#azt_quotedcontactid)
- [azt_recapnotes](#azt_recapnotes)
- [azt_taxamount](#azt_taxamount)
- [billto_city](#billto_city)
- [billto_contactname](#billto_contactname)
- [billto_country](#billto_country)
- [billto_fax](#billto_fax)
- [billto_line1](#billto_line1)
- [billto_line2](#billto_line2)
- [billto_name](#billto_name)
- [billto_postalcode](#billto_postalcode)
- [billto_stateorprovince](#billto_stateorprovince)
- [billto_telephone](#billto_telephone)
- [campaignid](#campaignid)
- [closedon](#closedon)
- [customerid](#customerid)
- [effectivefrom](#effectivefrom)
- [effectiveto](#effectiveto)
- [emailaddress](#emailaddress)
- [expireson](#expireson)
- [freightamount](#freightamount)
- [freighttermscode](#freighttermscode)
- [name](#name)
- [opportunityid](#opportunityid)
- [ownerid](#ownerid)
- [paymenttermscode](#paymenttermscode)
- [pricelevelid](#pricelevelid)
- [quoteid](#quoteid)
- [requestdeliveryby](#requestdeliveryby)
- [shippingmethodcode](#shippingmethodcode)
- [shipto_city](#shipto_city)
- [shipto_contactname](#shipto_contactname)
- [shipto_country](#shipto_country)
- [shipto_fax](#shipto_fax)
- [shipto_freighttermscode](#shipto_freighttermscode)
- [shipto_line1](#shipto_line1)
- [shipto_line2](#shipto_line2)
- [shipto_line3](#shipto_line3)
- [shipto_name](#shipto_name)
- [shipto_postalcode](#shipto_postalcode)
- [shipto_stateorprovince](#shipto_stateorprovince)
- [shipto_telephone](#shipto_telephone)

**Fields Written:**

- [azt_historicalowner](#azt_historicalowner)
- [azt_ponumber](#azt_ponumber)
- [azt_quoteapproval](#azt_quoteapproval)
- [azt_quotedcontactid](#azt_quotedcontactid)
- [azt_recapnotes](#azt_recapnotes)
- [azt_taxamount](#azt_taxamount)
- [billto_city](#billto_city)
- [billto_contactname](#billto_contactname)
- [billto_country](#billto_country)
- [billto_fax](#billto_fax)
- [billto_line1](#billto_line1)
- [billto_line2](#billto_line2)
- [billto_name](#billto_name)
- [billto_postalcode](#billto_postalcode)
- [billto_stateorprovince](#billto_stateorprovince)
- [billto_telephone](#billto_telephone)
- [campaignid](#campaignid)
- [closedon](#closedon)
- [customerid](#customerid)
- [effectivefrom](#effectivefrom)
- [effectiveto](#effectiveto)
- [emailaddress](#emailaddress)
- [expireson](#expireson)
- [freightamount](#freightamount)
- [freighttermscode](#freighttermscode)
- [name](#name)
- [opportunityid](#opportunityid)
- [ownerid](#ownerid)
- [paymenttermscode](#paymenttermscode)
- [pricelevelid](#pricelevelid)
- [requestdeliveryby](#requestdeliveryby)
- [shippingmethodcode](#shippingmethodcode)
- [shipto_city](#shipto_city)
- [shipto_contactname](#shipto_contactname)
- [shipto_country](#shipto_country)
- [shipto_fax](#shipto_fax)
- [shipto_freighttermscode](#shipto_freighttermscode)
- [shipto_line1](#shipto_line1)
- [shipto_line2](#shipto_line2)
- [shipto_line3](#shipto_line3)
- [shipto_name](#shipto_name)
- [shipto_postalcode](#shipto_postalcode)
- [shipto_stateorprovince](#shipto_stateorprovince)
- [shipto_telephone](#shipto_telephone)
- [transactioncurrencyid](#transactioncurrencyid)
- [willcall](#willcall)

### 7.16. CloneLicense

- **File:** `CloneLicense-49354120-2D2D-4DED-8C24-4ACA5F6D82D9.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.17. CloneOpportunity

- **File:** `CloneOpportunity-1A3FF4B3-79FD-420C-8A10-375E8892CA44.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_historicalowner](#azt_historicalowner)
- [azt_recordownerid](#azt_recordownerid)
- [customerid](#customerid)

### 7.18. CloneOrder

- **File:** `CloneOrder-D2A6AD48-A603-4150-BC84-72092AFB3D79.xaml`
- **Entity References:** quote
- **Primary Entity:** SalesOrder

**Fields Read:**

- [azt_ponumber](#azt_ponumber)
- [name](#name)

**Fields Written:**

- [customerid](#customerid)
- [shipto_contactname](#shipto_contactname)
- [statecode](#statecode)
- [statuscode](#statuscode)

### 7.19. ContactAuto-Assign

- **File:** `ContactAuto-Assign-25759C22-AE58-4CC7-81E1-9BBF37E76F3E.xaml`
- **Entity References:** quote
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`
- `AztecPlugins.GetAcctTeamOwned`

### 7.20. CreateLeadFromLeadGen

- **File:** `CreateLeadFromLeadGen-2EA14729-4B62-4F91-95FA-76D258DA0831.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Read:**

- [name](#name)

**Fields Written:**

- [statecode](#statecode)

### 7.21. CreateLeadfromAccount

- **File:** `CreateLeadfromAccount-B5E04C1C-B038-4018-B602-645B1E766884.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Read:**

- [name](#name)

**Fields Written:**

- [statecode](#statecode)

### 7.22. CreateSoftwareLicense

- **File:** `CreateSoftwareLicense-82C11935-B2A2-4E45-94B4-F0EEA6641A08.xaml`
- **Entity References:** quote
- **Primary Entity:** SalesOrder

**Fields Written:**

- [customerid](#customerid)

### 7.23. CustomLeadCreation

- **File:** `CustomLeadCreation-B26AC2BB-4660-4A50-9229-AD056DE0D9E1.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

**Fields Written:**

- [statecode](#statecode)

### 7.24. EffectiveTo

- **File:** `EffectiveTo-C96A6885-1A20-E911-A94F-000D3A3B9B3D.xaml`
- **Entity References:** quote
- **Trigger Scope:** Form
- **Trigger Form ID:** `{54076a2d-d043-4a1b-b061-4d06846371a9}`
- **Primary Entity:** Quote

**Fields Read:**

- [createdon](#createdon)
- [effectiveto](#effectiveto)

**Fields Written:**

- [effectivefrom](#effectivefrom)
- [effectiveto](#effectiveto)

### 7.25. EmailDeleteSendQuoteDrafts

- **File:** `EmailDeleteSendQuoteDrafts-ED77962D-F57D-4F2F-A580-1F5D27E1280C.xaml`
- **Entity References:** quote
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#statuscode)

### 7.26. EmailRemoveUnsentEmails

- **File:** `EmailRemoveUnsentEmails-2F1954B7-77B4-4D54-AA84-DBB10DFB6A71.xaml`
- **Entity References:** quote
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#statuscode)

### 7.27. EngagementRecordOwner

- **File:** `EngagementRecordOwner-00BE88CF-37E2-46ED-951B-A553329BC127.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.28. EngagementRecordOwnerTeam

- **File:** `EngagementRecordOwnerTeam-190EE5B4-5775-4B9D-BFD7-FB769C19977A.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.29. InvoiceRecordOwner

- **File:** `InvoiceRecordOwner-C59ED476-F5C4-47B7-BD33-E88881D2B5EE.xaml`
- **Entity References:** quote
- **Primary Entity:** Invoice

**Fields Read:**

- [customerid](#customerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.30. LeadAssignment

- **File:** `LeadAssignment-5FC23C73-5B6B-423C-8721-57EDA4553E31.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.31. LeadQualifyDisqualifyDate

- **File:** `LeadQualifyDisqualifyDate-4DF6EBF4-0F22-4433-AB4F-A241C91F8B5A.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Read:**

- [statecode](#statecode)

### 7.32. NewFSRLeadNotification

- **File:** `NewFSRLeadNotification-53E6AF89-E489-4977-8D9F-1579FF72FAC5.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Read:**

- [name](#name)

### 7.33. OpportunityAuditRemoval

- **File:** `OpportunityAuditRemoval-DB05BF90-221B-4B58-8AA0-D1A0799EA0A1.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [statecode](#statecode)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.OppAuditRemoval`

### 7.34. OpportunityRecordOwner

- **File:** `OpportunityRecordOwner-B0889237-722A-47CC-B102-D507B14FED98.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.35. OpportunityRecordOwnerTeam

- **File:** `OpportunityRecordOwnerTeam-7F60084D-807B-43D1-ACED-B0CC90F02F02.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.36. OrderRecordOwner

- **File:** `OrderRecordOwner-701C3E67-4733-423C-BC31-5C846B542B76.xaml`
- **Entity References:** quote
- **Primary Entity:** SalesOrder

**Fields Read:**

- [customerid](#customerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.37. PhonecallAuto-Assign

- **File:** `PhonecallAuto-Assign-D7FD43A4-5AFF-4929-BD37-A1917C4F2391.xaml`
- **Entity References:** quote
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.38. QualifyLead

- **File:** `QualifyLead-F6899272-F476-48C4-B703-D5ACDD9EDFF7.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Written:**

- [customerid](#customerid)
- [name](#name)

### 7.39. QuoteRecordOwner

- **File:** `QuoteRecordOwner-C5266A8C-E23D-41C4-B51F-3A637538DDBF.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [createdby](#createdby)
- [customerid](#customerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.40. QuoteRecordOwnerTeam

- **File:** `QuoteRecordOwnerTeam-7ACFAD91-65CC-4C8D-8A3E-673373DEA880.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [quoteid](#quoteid)

### 7.41. RenameEngagements

- **File:** `RenameEngagements-9D4DC906-B3F2-498A-AC17-7D302597E96C.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#name)

### 7.42. SendQuote

- **File:** `SendQuote-FF6FE214-20D6-4541-AEC6-BD5D18258481.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [azt_quotedcontactid](#azt_quotedcontactid)
- [azt_recordownerid](#azt_recordownerid)
- [quoteid](#quoteid)

### 7.43. SoftwareLicenseCreateEngagement

- **File:** `SoftwareLicenseCreateEngagement-ABFE722A-CAC3-4A3B-AF5C-419EA2CE9CBD.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [statuscode](#statuscode)

### 7.44. TaskAuto-Assign

- **File:** `TaskAuto-Assign-89E60667-3F7F-4ADD-8274-57C2BE011059.xaml`
- **Entity References:** quote
- **Primary Entity:** Task

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.45. TaskCreateReorderLead

- **File:** `TaskCreateReorderLead-3193EB56-8E56-46A3-B079-A7CFD1CE90B7.xaml`
- **Entity References:** quote
- **Primary Entity:** Task

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)
- [customerid](#customerid)
- [statecode](#statecode)

### 7.46. WonOpportunityEmail

- **File:** `WonOpportunityEmail-DB2872A0-18C2-4157-B6BD-480230C97D32.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [name](#name)
- [statecode](#statecode)

### 7.47. WorkforceAccountAuto-assign

- **File:** `WorkforceAccountAuto-assign-1AD2C544-E6F9-4FC7-AA17-810AEB8939C2.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.48. WorkforceAppointmentAuto-Assign

- **File:** `WorkforceAppointmentAuto-Assign-803829FB-077B-4F0B-B238-105814F5B202.xaml`
- **Entity References:** quote
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.49. WorkforceCaseAuto-assign

- **File:** `WorkforceCaseAuto-assign-24BA0A9C-F8BD-45CB-A5F6-6DCE42CD998F.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.50. WorkforceContactAuto-assign

- **File:** `WorkforceContactAuto-assign-65B65E23-A8F5-46DB-A35A-C5DC8542B6AE.xaml`
- **Entity References:** quote
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.51. WorkforceEngagementAuto-assign

- **File:** `WorkforceEngagementAuto-assign-DA5CDD7F-2A3B-4A0A-861D-75305D10254E.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.52. WorkforceLeadAuto-Assign

- **File:** `WorkforceLeadAuto-Assign-E5A4054C-5F7E-478C-87E3-529C1EEAB0DC.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.53. WorkforceOpportunityAuto-assign

- **File:** `WorkforceOpportunityAuto-assign-7D379FBE-C672-41EB-90A3-A80451C62533.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.54. WorkforcePhone-callAuto-assign

- **File:** `WorkforcePhone-callAuto-assign-BE1CB211-7C3C-4E39-8913-2DFCE7EDFC85.xaml`
- **Entity References:** quote
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.55. WorkforceQuoteAuto-assign

- **File:** `WorkforceQuoteAuto-assign-E64BB2BB-5CD6-4327-AB1B-BF8C9D4D2385.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [createdby](#createdby)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.56. iGradAppointmentAuto-Assign

- **File:** `iGradAppointmentAuto-Assign-CE88A0C4-AA60-44F4-B33D-B57FB8279CCF.xaml`
- **Entity References:** quote
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.57. iGradCaseAuto-Assign

- **File:** `iGradCaseAuto-Assign-CAF5021E-07E1-4689-92D5-FC59E9F30F78.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.58. iGradPhone-callAuto-assign

- **File:** `iGradPhone-callAuto-assign-04423D55-3225-429E-BAC6-8DD37BC53F1B.xaml`
- **Entity References:** quote
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

---

## 8. JavaScript Web Resources

Total JS files referencing Quote fields: **13**

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

### 8.8. azt_opportunitylibrary

- **File:** `azt_opportunitylibrary43000452-0710-E911-A980-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |
| [freightamount](#freightamount) | access |

`setFreightAmt`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#azt_requestedfreightamt) | read |
| [freightamount](#freightamount) | write |

`success`:

| Field | Operations |
|-------|-----------|
| [freightamount](#freightamount) | access |

### 8.9. azt_opportunitytrackdiscount

- **File:** `azt_opportunitytrackdiscount8AAC767D-5D0E-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`trackDiscount`:

| Field | Operations |
|-------|-----------|
| [name](#name) | read |

### 8.10. azt_orderlibrary

- **File:** `azt_orderlibrary2892D28D-D5C4-EB11-BACC-00224809B8F2`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.11. azt_quotelibrary

- **File:** `azt_quotelibrary117BF74F-580A-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`setFreight`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#azt_requestedfreightamt) | read |
| [freightamount](#freightamount) | write |

### 8.12. azt_sendquote

- **File:** `azt_sendquote0A31A45C-E217-E911-A97D-000D3A1A9FA9`

**Per-Function Field Usage:**

`sendLifeSkillsQuote`:

| Field | Operations |
|-------|-----------|
| [quotenumber](#quotenumber) | read |

`sendPAQuote`:

| Field | Operations |
|-------|-----------|
| [quotenumber](#quotenumber) | read |

`sendQuote`:

| Field | Operations |
|-------|-----------|
| [quotenumber](#quotenumber) | read |

### 8.13. azt_splitinvoice

- **File:** `azt_splitinvoice868121CA-C008-E911-A97C-000D3A1A9EFB`

**Per-Function Field Usage:**

`splitInvoice`:

| Field | Operations |
|-------|-----------|
| [totalamount](#totalamount) | read |

---

## 9. Formulas & Rollups

Total formulas for Quote: **1**

### azt_discretionarydiscount

- **File:** `quote-azt_discretionarydiscount.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** quotedetail

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | quote |
| [rolluprulestep1_2](#rolluprulestep1_2) | quote |
| azt_discretionarydiscountamt | quotedetail |

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

Total relationships involving Quote: **5**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| azt_contact_quote | N:1 | Contact | Quote | [azt_QuotedContactId](#azt_quotedcontactid) |
| azt_systemuser_quote | N:1 | SystemUser | Quote | [azt_RecordOwnerId](#azt_recordownerid) |
| opportunity_quotes | N:1 | Opportunity | Quote | [OpportunityId](#opportunityid) |
| quote_customer_accounts | N:1 | Account | Quote | [CustomerId](#customerid) |
| quote_orders | 1:N | Quote | SalesOrder | [QuoteId](#quoteid) |

---

## 13. Ribbon Customizations

### Custom Buttons

| Button Label | Location | Command |
|-------------|----------|---------|
| Clone & Delete | Mscrm.Form.quote.MainTab.Save.Controls._children | `azt.quote.CloneAndDelete.CloneAndDeleteCommand` |
| Send Aztec Quote | Mscrm.Form.quote.MainTab.Actions.Controls._children | `azt.quote.SendQuoteCommand.Command` |

### Command Definitions

| Command ID | JavaScript Function | Library |
|-----------|-------------------|---------|
| `azt.quote.CloneAndDelete.CloneAndDeleteCommand` | `cloneAndDelete` | `azt_quotelibrary` |
| `azt.quote.SendQuoteCommand.Command` | `sendQuote` | `azt_sendquote` |

---

## 14. Conflicts & Observations

### 14.1 Per-Form Conflicts

No per-form conflicts detected.

### 14.2 Global Observations

**Fields in code but not on any form (313):**

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
- [azt_quoteapproval](#azt_quoteapproval)
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
- [billto_city](#billto_city)
- [billto_contactname](#billto_contactname)
- [billto_country](#billto_country)
- [billto_fax](#billto_fax)
- [billto_line1](#billto_line1)
- [billto_line2](#billto_line2)
- [billto_line3](#billto_line3)
- [billto_name](#billto_name)
- [billto_postalcode](#billto_postalcode)
- [billto_stateorprovince](#billto_stateorprovince)
- [billto_telephone](#billto_telephone)
- [body](#body)
- [bpf_duration](#bpf_duration)
- [bpf_salesorderid](#bpf_salesorderid)
- [businessprocessflowinstanceid](#businessprocessflowinstanceid)
- [businessunitid](#businessunitid)
- [campaignid](#campaignid)
- [category](#category)
- [closedon](#closedon)
- [closeprobability](#closeprobability)
- [companyname](#companyname)
- [connectionid](#connectionid)
- [connectionroleid](#connectionroleid)
- [consideronlygoalownersrecords](#consideronlygoalownersrecords)
- [contactid](#contactid)
- [createdby](#createdby)
- [crm3_expenseamount](#crm3_expenseamount)
- [crm3_parentleadid](#crm3_parentleadid)
- [customerid](#customerid)
- [datefulfilled](#datefulfilled)
- [defaultuomid](#defaultuomid)
- [description](#description)
- [emailaddress](#emailaddress)
- [emailaddress1](#emailaddress1)
- [estimatedclosedate](#estimatedclosedate)
- [estimatedvalue](#estimatedvalue)
- [expireson](#expireson)
- [ext_amt](#ext_amt)
- [extendedamount](#extendedamount)
- [fetchxml](#fetchxml)
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
- [ordernumber](#ordernumber)
- [originatingleadid](#originatingleadid)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [parentcustomerid](#parentcustomerid)
- [parentgoalid](#parentgoalid)
- [parentsystemuserid](#parentsystemuserid)
- [partyid](#partyid)
- [paymenttermscode](#paymenttermscode)
- [phonenumber](#phonenumber)
- [pricelevelid](#pricelevelid)
- [priceperunit](#priceperunit)
- [primarycontactid](#primarycontactid)
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
- [quotenumber](#quotenumber)
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
- [shipto_city](#shipto_city)
- [shipto_country](#shipto_country)
- [shipto_fax](#shipto_fax)
- [shipto_freighttermscode](#shipto_freighttermscode)
- [shipto_line1](#shipto_line1)
- [shipto_line2](#shipto_line2)
- [shipto_line3](#shipto_line3)
- [shipto_postalcode](#shipto_postalcode)
- [shipto_stateorprovince](#shipto_stateorprovince)
- [shipto_telephone](#shipto_telephone)
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
- [totalamount](#totalamount)
- [totallineitemamount](#totallineitemamount)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)
- [{0}](#0)

**Fields on forms but never in logic (4):**

- [accessteam](#accessteam)
- [azt_shippingcompany](#azt_shippingcompany)
- [quotedetailsgrid](#quotedetailsgrid)
- [quotelines](#quotelines)

---

## Index

Alphabetical field index -- 361 unique fields referenced.

#### accessteam

- [Form: Quote > Summary_tab > description_section](#21-quote-main-active)

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

- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### address1_stateorprovince

- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: AutoAssignStateAbb (Read)](#1012-autoassignstateabb)
- [Plugin: AutoAssignStateAbb (Write)](#1012-autoassignstateabb)
- [Plugin: LeadImport (Write)](#1036-leadimport)

#### address1_telephone1

- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

#### address2_line1

- [Report: PAQuoteReport > QuoteHeader > account](#51-paquotereport)

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

#### azt_defaultfreightamount

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Freight](#21-quote-main-active)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [JS: azt_opportunitylibrary > setFreightAmt()](#88-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#811-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_defaultfreightamount_base

- [Field Definitions](#1-field-definitions)

#### azt_description

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_discountamount

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)

#### azt_discretionarydiscount

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [View: Active Quotes](#31-active-quotes)
- [View: All Quotes](#32-all-quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Formula: azt_discretionarydiscount (Target)](#9-formulas-rollups)

#### azt_discretionarydiscount_base

- [Field Definitions](#1-field-definitions)

#### azt_discretionarydiscountamt

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
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
- [Form: Quote > Summary_tab > Freight](#21-quote-main-active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#88-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#811-azt_quotelibrary)
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
- [Form: Quote (Footer)](#21-quote-main-active)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOpportunity (Write)](#717-cloneopportunity)

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

#### azt_ponumber

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOrder (Read)](#718-cloneorder)
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

#### azt_quoteapproval

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### azt_quotedcontactid

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: SendQuote (Read)](#742-sendquote)
- [Relationship: azt_contact_quote](#12-relationships)

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

#### azt_recapnotes

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Section](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### azt_recapnotescannedoptions

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Section](#21-quote-main-active)

#### azt_recordowner

- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)

#### azt_recordownerid

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [View: My Quotes (Filter)](#33-my-quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: 0ChangeQuoteRecordOwner (Write)](#71-0changequoterecordowner)
- [Workflow: AccountAuto-Assign (Write)](#73-accountauto-assign)
- [Workflow: AppointmentAuto-Assign (Write)](#74-appointmentauto-assign)
- [Workflow: BatchCreateEngagements (Write)](#77-batchcreateengagements)
- [Workflow: BatchOpportunityTransfer (Write)](#79-batchopportunitytransfer)
- [Workflow: CaseRecordOwner (Write)](#711-caserecordowner)
- [Workflow: CaseRecordOwnerAssign (Write)](#712-caserecordownerassign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#713-caserecordownerassignmentnotification)
- [Workflow: CloneLicense (Write)](#716-clonelicense)
- [Workflow: CloneOpportunity (Write)](#717-cloneopportunity)
- [Workflow: ContactAuto-Assign (Write)](#719-contactauto-assign)
- [Workflow: EngagementRecordOwner (Write)](#727-engagementrecordowner)
- [Workflow: EngagementRecordOwnerTeam (Read)](#728-engagementrecordownerteam)
- [Workflow: InvoiceRecordOwner (Write)](#729-invoicerecordowner)
- [Workflow: LeadAssignment (Write)](#730-leadassignment)
- [Workflow: OpportunityRecordOwner (Write)](#734-opportunityrecordowner)
- [Workflow: OpportunityRecordOwnerTeam (Read)](#735-opportunityrecordownerteam)
- [Workflow: OrderRecordOwner (Write)](#736-orderrecordowner)
- [Workflow: PhonecallAuto-Assign (Write)](#737-phonecallauto-assign)
- [Workflow: QuoteRecordOwner (Write)](#739-quoterecordowner)
- [Workflow: QuoteRecordOwnerTeam (Read)](#740-quoterecordownerteam)
- [Workflow: SendQuote (Read)](#742-sendquote)
- [Workflow: TaskAuto-Assign (Write)](#744-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Write)](#745-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#746-wonopportunityemail)
- [Workflow: WorkforceAccountAuto-assign (Write)](#747-workforceaccountauto-assign)
- [Workflow: WorkforceAppointmentAuto-Assign (Write)](#748-workforceappointmentauto-assign)
- [Workflow: WorkforceCaseAuto-assign (Write)](#749-workforcecaseauto-assign)
- [Workflow: WorkforceContactAuto-assign (Write)](#750-workforcecontactauto-assign)
- [Workflow: WorkforceEngagementAuto-assign (Write)](#751-workforceengagementauto-assign)
- [Workflow: WorkforceLeadAuto-Assign (Write)](#752-workforceleadauto-assign)
- [Workflow: WorkforceOpportunityAuto-assign (Write)](#753-workforceopportunityauto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Write)](#754-workforcephone-callauto-assign)
- [Workflow: WorkforceQuoteAuto-assign (Write)](#755-workforcequoteauto-assign)
- [Workflow: iGradAppointmentAuto-Assign (Write)](#756-igradappointmentauto-assign)
- [Workflow: iGradCaseAuto-Assign (Write)](#757-igradcaseauto-assign)
- [Workflow: iGradPhone-callAuto-assign (Write)](#758-igradphone-callauto-assign)
- [JS: azt_caselibrary > onLoad()](#83-azt_caselibrary)
- [JS: azt_engagementlibrary > onLoad()](#85-azt_engagementlibrary)
- [JS: azt_invoicelibrary > onLoad()](#87-azt_invoicelibrary)
- [JS: azt_opportunitylibrary > onLoad()](#88-azt_opportunitylibrary)
- [JS: azt_orderlibrary > onLoad()](#810-azt_orderlibrary)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#108-activitycloseforcerecordowner)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Relationship: azt_systemuser_quote](#12-relationships)

#### azt_replacementproductid

- [Plugin: Utility (Read)](#1081-utility)

#### azt_requestedfreightamt

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Freight](#21-quote-main-active)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [JS: azt_opportunitylibrary > setFreightAmt()](#88-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#811-azt_quotelibrary)
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

#### azt_shippingcompany

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)

#### azt_signedquotereceived

- [Field Definitions](#1-field-definitions)

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

#### azt_taxamount

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > sales_information](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### azt_taxamount_base

- [Field Definitions](#1-field-definitions)

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

- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
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

- [Report: PAQuoteReport > QuoteHeader > quotedetail](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader > quotedetail](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader > quotedetail](#55-igradquotereport)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

#### billto_city

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### billto_contactname

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### billto_country

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### billto_fax

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### billto_line1

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_line2

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_line3

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_name

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_postalcode

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_stateorprovince

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_telephone

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

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

#### campaignid

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### category

- [Plugin: ContactSetConnectionRole (Sort)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Sort)](#1075-setprimarycontact)

#### city

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### closedon

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

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
- [Workflow: QuoteRecordOwner (Read)](#739-quoterecordowner)
- [Workflow: WorkforceQuoteAuto-assign (Read)](#755-workforcequoteauto-assign)

#### createdon

- [Field Definitions](#1-field-definitions)
- [Form: Quote > details_tab > tab_2_section_2](#21-quote-main-active)
- [View: Active Quotes](#31-active-quotes)
- [View: Active Quotes (Sort)](#31-active-quotes)
- [View: My Quotes](#33-my-quotes)
- [View: My Quotes (Sort)](#33-my-quotes)
- [View: Quick Find All Quotes](#34-quick-find-all-quotes)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [View: Quotes Needing Freight Approval (Sort)](#35-quotes-needing-freight-approval)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: EffectiveTo (Read)](#724-effectiveto)
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

- [Field Definitions](#1-field-definitions)
- [View: Active Quotes](#31-active-quotes)
- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)
- [View: Quick Find All Quotes](#34-quick-find-all-quotes)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CasePendingAssignmentNotification (Read)](#710-casependingassignmentnotification)
- [Workflow: CaseRecordOwner (Read)](#711-caserecordowner)
- [Workflow: CaseRecordOwnerAssign (Read)](#712-caserecordownerassign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#713-caserecordownerassignmentnotification)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOpportunity (Write)](#717-cloneopportunity)
- [Workflow: CloneOrder (Write)](#718-cloneorder)
- [Workflow: CreateSoftwareLicense (Write)](#722-createsoftwarelicense)
- [Workflow: InvoiceRecordOwner (Read)](#729-invoicerecordowner)
- [Workflow: OrderRecordOwner (Read)](#736-orderrecordowner)
- [Workflow: QualifyLead (Write)](#738-qualifylead)
- [Workflow: QuoteRecordOwner (Read)](#739-quoterecordowner)
- [Workflow: TaskCreateReorderLead (Write)](#745-taskcreatereorderlead)
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
- [Relationship: quote_customer_accounts](#12-relationships)

#### datefulfilled

- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### defaultuomid

- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### description

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

#### discountamount

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)

#### discountpercentage

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### effectivefrom

- [Field Definitions](#1-field-definitions)
- [Form: Quote > details_tab > tab_2_section_2](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: EffectiveTo (Write)](#724-effectiveto)

#### effectiveto

- [Field Definitions](#1-field-definitions)
- [Form: Quote > details_tab > tab_2_section_2](#21-quote-main-active)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: EffectiveTo (Read)](#724-effectiveto)
- [Workflow: EffectiveTo (Write)](#724-effectiveto)

#### emailaddress

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### emailaddress1

- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadImport (Filter)](#1036-leadimport)

#### estimatedclosedate

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityClone (Write)](#1044-opportunityclone)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

#### estimatedvalue

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

#### expireson

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

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

- [Report: SoleSourceLetter > QuoteHeader > contact](#53-solesourceletter)
- [Plugin: LeadImport (Write)](#1036-leadimport)

#### fiscalperiod

- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

#### freightamount

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [JS: azt_opportunitylibrary > onLoad()](#88-azt_opportunitylibrary)
- [JS: azt_opportunitylibrary > setFreightAmt()](#88-azt_opportunitylibrary)
- [JS: azt_opportunitylibrary > success()](#88-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#811-azt_quotelibrary)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### freightamount_base

- [Field Definitions](#1-field-definitions)

#### freighttermscode

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### from

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### fullname

- [Report: PAQuoteReport > QuoteHeader > contact](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader > contact](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader > contact](#55-igradquotereport)
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

- [Report: PAQuoteReport > QuoteHeader > systemuser](#51-paquotereport)
- [Plugin: LeadImport (Write)](#1036-leadimport)

#### lastname

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### manualdiscountamount

- [Report: PAQuoteReport > QuoteHeader > quotedetail](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader > quotedetail](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader > quotedetail](#55-igradquotereport)
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

- [Field Definitions](#1-field-definitions)
- [View: Active Quotes](#31-active-quotes)
- [View: All Quotes](#32-all-quotes)
- [View: All Quotes (Sort)](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)
- [View: Quick Find All Quotes](#34-quick-find-all-quotes)
- [View: Quick Find All Quotes (Filter)](#34-quick-find-all-quotes)
- [View: Quick Find All Quotes (Sort)](#34-quick-find-all-quotes)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PAQuoteReport > QuoteHeader (Sort)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: PackingSlip > OrderHeader (Sort)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SoleSourceLetter > QuoteHeader (Sort)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Sort)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Sort)](#55-igradquotereport)
- [Workflow: 0EngagementNames (Read)](#72-0engagementnames)
- [Workflow: BatchConverttoLead (Read)](#76-batchconverttolead)
- [Workflow: BatchCreateEngagements (Read)](#77-batchcreateengagements)
- [Workflow: BatchLooseOpportunities (Read)](#78-batchlooseopportunities)
- [Workflow: BatchOpportunityTransfer (Read)](#79-batchopportunitytransfer)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOpportunity (Read)](#717-cloneopportunity)
- [Workflow: CloneOrder (Read)](#718-cloneorder)
- [Workflow: CreateLeadFromLeadGen (Read)](#720-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#721-createleadfromaccount)
- [Workflow: CustomLeadCreation (Read)](#723-customleadcreation)
- [Workflow: NewFSRLeadNotification (Read)](#732-newfsrleadnotification)
- [Workflow: QualifyLead (Write)](#738-qualifylead)
- [Workflow: RenameEngagements (Read)](#741-renameengagements)
- [Workflow: TaskCreateReorderLead (Read)](#745-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#746-wonopportunityemail)
- [JS: azt_accountlibrary > createLead()](#81-azt_accountlibrary)
- [JS: azt_accountlibrary > createNewLead()](#81-azt_accountlibrary)
- [JS: azt_addresslibrary > addAddress()](#82-azt_addresslibrary)
- [JS: azt_opportunitytrackdiscount > trackDiscount()](#89-azt_opportunitytrackdiscount)
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

- [Field Definitions](#1-field-definitions)
- [View: All Quotes](#32-all-quotes)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
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

#### ordernumber

- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)

#### originatingleadid

- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: OpportunityAssignFromLead (Read)](#1042-opportunityassignfromlead)

#### ownerid

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > description_section](#21-quote-main-active)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
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

#### paymenttermscode

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### phonenumber

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### pricelevelid

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
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

#### quotecustomeridcontactcontactid.emailaddress1

- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)

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

#### quotedetailsgrid

- [Form: Quote > Administration > Section](#21-quote-main-active)

#### quoteid

- [Field Definitions](#1-field-definitions)
- [View: Active Quotes](#31-active-quotes)
- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)
- [View: Quick Find All Quotes](#34-quick-find-all-quotes)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: QuoteRecordOwnerTeam (Read)](#740-quoterecordownerteam)
- [Workflow: SendQuote (Read)](#742-sendquote)
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
- [Relationship: quote_orders](#12-relationships)

#### quotelines

- [Form: Quote > Summary_tab > products](#21-quote-main-active)

#### quotenumber

- [Field Definitions](#1-field-definitions)
- [View: Quick Find All Quotes (Filter)](#34-quick-find-all-quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader > quote](#52-packingslip)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [JS: azt_sendquote > sendLifeSkillsQuote()](#812-azt_sendquote)
- [JS: azt_sendquote > sendPAQuote()](#812-azt_sendquote)
- [JS: azt_sendquote > sendQuote()](#812-azt_sendquote)

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

#### requestdeliveryby

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
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

#### rolluprulestep1_1

- [Formula: azt_discretionarydiscount](#9-formulas-rollups)

#### rolluprulestep1_2

- [Formula: azt_discretionarydiscount](#9-formulas-rollups)

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

- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
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

- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#107-activitiescreatedduedatesinpast)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### shippingmethodcode

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_city

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### shipto_contactname

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOrder (Write)](#718-cloneorder)

#### shipto_country

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### shipto_fax

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### shipto_freighttermscode

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### shipto_line1

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_line2

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_line3

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_name

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_postalcode

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_stateorprovince

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_telephone

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### state

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### statecode

- [Field Definitions](#1-field-definitions)
- [View: Active Quotes](#31-active-quotes)
- [View: Active Quotes (Filter)](#31-active-quotes)
- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)
- [View: My Quotes (Filter)](#33-my-quotes)
- [View: My Quotes (Filter)](#33-my-quotes)
- [View: Quick Find All Quotes](#34-quick-find-all-quotes)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: BatchConverttoLead (Write)](#76-batchconverttolead)
- [Workflow: CaseResolutionNotificationEmail (Read)](#714-caseresolutionnotificationemail)
- [Workflow: CloneOrder (Write)](#718-cloneorder)
- [Workflow: CreateLeadFromLeadGen (Write)](#720-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#721-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#723-customleadcreation)
- [Workflow: LeadQualifyDisqualifyDate (Read)](#731-leadqualifydisqualifydate)
- [Workflow: OpportunityAuditRemoval (Read)](#733-opportunityauditremoval)
- [Workflow: TaskCreateReorderLead (Write)](#745-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#746-wonopportunityemail)
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
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Workflow: BatchCreateEngagements (Write)](#77-batchcreateengagements)
- [Workflow: CloneOrder (Write)](#718-cloneorder)
- [Workflow: EmailDeleteSendQuoteDrafts (Read)](#725-emaildeletesendquotedrafts)
- [Workflow: EmailRemoveUnsentEmails (Read)](#726-emailremoveunsentemails)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#743-softwarelicensecreateengagement)
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

- [Report: PAQuoteReport > QuoteHeader > systemuser](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader > systemuser](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader > systemuser](#55-igradquotereport)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

#### tm.systemuserid

- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)

#### to

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### totalamount

- [Field Definitions](#1-field-definitions)
- [View: Active Quotes](#31-active-quotes)
- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)
- [View: Quick Find All Quotes](#34-quick-find-all-quotes)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [JS: azt_splitinvoice > splitInvoice()](#813-azt_splitinvoice)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### totallineitemamount

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)

#### transactioncurrencyid

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
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

#### willcall

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > addresses](#21-quote-main-active)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

#### zipcode

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### {0}

- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
