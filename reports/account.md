# Account Field Usage Analysis
> Date: 2026-03-21

## Table of Contents

- [1. Field Definitions](#1-field-definitions)
- [2. Forms](#2-forms)
  - [2.1. TimelineWallControl - Account- Main (main) -- Active](#21-timelinewallcontrol-account-main-main-active)
  - [2.2. iGrad Account (main) -- Active](#22-igrad-account-main-active)
  - [2.3. AI for Sales (main) -- Inactive](#23-ai-for-sales-main-inactive)
  - [2.4. Information (main) -- Inactive](#24-information-main-inactive)
  - [2.5. Account (main) -- Active](#25-account-main-active)
  - [2.6. Purchased Software Licenses (quick) -- Active](#26-purchased-software-licenses-quick-active)
  - [2.7. Account Owner Card (quick) -- Active](#27-account-owner-card-quick-active)
  - [2.8. Last Purchase Dates Quick View (quick) -- Active](#28-last-purchase-dates-quick-view-quick-active)
  - [2.9. Allocated Software Licenses (quick) -- Active](#29-allocated-software-licenses-quick-active)
  - [2.10. Account Lead Quick View (quick) -- Active](#210-account-lead-quick-view-quick-active)
  - [2.11. Account Owner Quick View (quick) -- Active](#211-account-owner-quick-view-quick-active)
  - [2.12. Engagement Contacts (quick) -- Active](#212-engagement-contacts-quick-active)
- [3. Views](#3-views)
  - [3.1. Account Advanced Find View](#31-account-advanced-find-view)
  - [3.2. Account Associated View](#32-account-associated-view)
  - [3.3. Account BulkOperation View](#33-account-bulkoperation-view)
  - [3.4. Account List Member View](#34-account-list-member-view)
  - [3.5. Account Lookup View](#35-account-lookup-view)
  - [3.6. Account Sharing Associated View](#36-account-sharing-associated-view)
  - [3.7. Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
  - [3.8. Accounts: No Orders in Last 6 Months](#38-accounts-no-orders-in-last-6-months)
  - [3.9. Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
  - [3.10. Active Accounts](#310-active-accounts)
  - [3.11. All Accounts](#311-all-accounts)
  - [3.12. Duplicate Accounts](#312-duplicate-accounts)
  - [3.13. GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
  - [3.14. GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
  - [3.15. GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
  - [3.16. HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
  - [3.17. Inactive Accounts](#317-inactive-accounts)
  - [3.18. My Active Accounts](#318-my-active-accounts)
  - [3.19. My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
  - [3.20. My Connections](#320-my-connections)
  - [3.21. New Customer Introduction List](#321-new-customer-introduction-list)
  - [3.22. Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
  - [3.23. Quick Find Active Accounts](#323-quick-find-active-accounts)
  - [3.24. TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [4. Chart Visualizations](#4-chart-visualizations)
- [5. Reports](#5-reports)
  - [5.1. PAQuoteReport](#51-paquotereport)
  - [5.2. SharedAccountRecords](#52-sharedaccountrecords)
- [6. Dashboards](#6-dashboards)
- [7. Workflows](#7-workflows)
  - [7.1. 0ChangeQuoteRecordOwner](#71-0changequoterecordowner)
  - [7.2. 0EngagementNames](#72-0engagementnames)
  - [7.3. AccountAuto-Assign](#73-accountauto-assign)
  - [7.4. AccountClearCustomerIntro](#74-accountclearcustomerintro)
  - [7.5. AllocationsAssigntoTeam](#75-allocationsassigntoteam)
  - [7.6. AppointmentAuto-Assign](#76-appointmentauto-assign)
  - [7.7. BatchConverttoLead](#77-batchconverttolead)
  - [7.8. BatchCreateEngagements](#78-batchcreateengagements)
  - [7.9. BatchCreateIntroCall](#79-batchcreateintrocall)
  - [7.10. BatchLooseOpportunities](#710-batchlooseopportunities)
  - [7.11. BatchOpportunityTransfer](#711-batchopportunitytransfer)
  - [7.12. BulkChangeLeadSource](#712-bulkchangeleadsource)
  - [7.13. CasePendingAssignmentNotification](#713-casependingassignmentnotification)
  - [7.14. CaseRecordOwner](#714-caserecordowner)
  - [7.15. CaseRecordOwnerAssign](#715-caserecordownerassign)
  - [7.16. CaseRecordOwnerAssignmentNotification](#716-caserecordownerassignmentnotification)
  - [7.17. CaseResolutionNotificationEmail](#717-caseresolutionnotificationemail)
  - [7.18. CloneAndDeleteQuote](#718-cloneanddeletequote)
  - [7.19. CloneCommissionPayment](#719-clonecommissionpayment)
  - [7.20. CloneLicense](#720-clonelicense)
  - [7.21. CloneOpportunity](#721-cloneopportunity)
  - [7.22. CloneOrder](#722-cloneorder)
  - [7.23. ContactAuto-Assign](#723-contactauto-assign)
  - [7.24. ContactMapAddresses](#724-contactmapaddresses)
  - [7.25. CreateLeadFromLeadGen](#725-createleadfromleadgen)
  - [7.26. CreateLeadfromAccount](#726-createleadfromaccount)
  - [7.27. CustomLeadCreation](#727-customleadcreation)
  - [7.28. EngagementRecordOwner](#728-engagementrecordowner)
  - [7.29. EngagementRecordOwnerTeam](#729-engagementrecordownerteam)
  - [7.30. FSRLeadDistibutionNotification](#730-fsrleaddistibutionnotification)
  - [7.31. InvoiceRecordOwner](#731-invoicerecordowner)
  - [7.32. LeadAssignment](#732-leadassignment)
  - [7.33. LeadQualifyDisqualifyDate](#733-leadqualifydisqualifydate)
  - [7.34. LeadSourceChange](#734-leadsourcechange)
  - [7.35. MarkAccountsExcludefromAuto-assign](#735-markaccountsexcludefromauto-assign)
  - [7.36. NewFSRLeadNotification](#736-newfsrleadnotification)
  - [7.37. OpportunityAuditRemoval](#737-opportunityauditremoval)
  - [7.38. OpportunityRecordOwner](#738-opportunityrecordowner)
  - [7.39. OpportunityRecordOwnerTeam](#739-opportunityrecordownerteam)
  - [7.40. OrderRecordOwner](#740-orderrecordowner)
  - [7.41. PhonecallAuto-Assign](#741-phonecallauto-assign)
  - [7.42. PrintPurchaseAssigntoTeam](#742-printpurchaseassigntoteam)
  - [7.43. QualifyLead](#743-qualifylead)
  - [7.44. QuoteRecordOwner](#744-quoterecordowner)
  - [7.45. QuoteRecordOwnerTeam](#745-quoterecordownerteam)
  - [7.46. RenameEngagements](#746-renameengagements)
  - [7.47. SendQuote](#747-sendquote)
  - [7.48. SetBusinessAddressNameField](#748-setbusinessaddressnamefield)
  - [7.49. SetLeadTemperature](#749-setleadtemperature)
  - [7.50. SetPhysicalAddressNameField](#750-setphysicaladdressnamefield)
  - [7.51. SoftwareLicenseAssigntoTeam](#751-softwarelicenseassigntoteam)
  - [7.52. SoftwareLicenseCreateEngagement](#752-softwarelicensecreateengagement)
  - [7.53. SoftwareLicenseSetOwner](#753-softwarelicensesetowner)
  - [7.54. TaskAuto-Assign](#754-taskauto-assign)
  - [7.55. TaskCreateReorderLead](#755-taskcreatereorderlead)
  - [7.56. WonOpportunityEmail](#756-wonopportunityemail)
  - [7.57. WorkforceAccountAuto-assign](#757-workforceaccountauto-assign)
  - [7.58. WorkforceAppointmentAuto-Assign](#758-workforceappointmentauto-assign)
  - [7.59. WorkforceCaseAuto-assign](#759-workforcecaseauto-assign)
  - [7.60. WorkforceContactAuto-assign](#760-workforcecontactauto-assign)
  - [7.61. WorkforceEngagementAuto-assign](#761-workforceengagementauto-assign)
  - [7.62. WorkforceLeadAuto-Assign](#762-workforceleadauto-assign)
  - [7.63. WorkforceOpportunityAuto-assign](#763-workforceopportunityauto-assign)
  - [7.64. WorkforcePhone-callAuto-assign](#764-workforcephone-callauto-assign)
  - [7.65. WorkforceQuoteAuto-assign](#765-workforcequoteauto-assign)
  - [7.66. iGradAppointmentAuto-Assign](#766-igradappointmentauto-assign)
  - [7.67. iGradCaseAuto-Assign](#767-igradcaseauto-assign)
  - [7.68. iGradPhone-callAuto-assign](#768-igradphone-callauto-assign)
- [8. JavaScript Web Resources](#8-javascript-web-resources)
  - [8.1. azt_FindAccountsWithinBoundModified](#81-azt_findaccountswithinboundmodified)
  - [8.2. azt_accountlibrary](#82-azt_accountlibrary)
  - [8.3. azt_addresslibrary](#83-azt_addresslibrary)
  - [8.4. azt_caselibrary](#84-azt_caselibrary)
  - [8.5. azt_contactlibrary](#85-azt_contactlibrary)
  - [8.6. azt_engagementlibrary](#86-azt_engagementlibrary)
  - [8.7. azt_invoicelibrary](#87-azt_invoicelibrary)
  - [8.8. azt_leadlibrary](#88-azt_leadlibrary)
  - [8.9. azt_opportunitylibrary](#89-azt_opportunitylibrary)
  - [8.10. azt_opportunitytrackdiscount](#810-azt_opportunitytrackdiscount)
  - [8.11. azt_orderlibrary](#811-azt_orderlibrary)
  - [8.12. azt_phonecalllibrary](#812-azt_phonecalllibrary)
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

## 1. Field Definitions

Total fields: **136**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Last Update | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [accountclassificationcode](#accountclassificationcode) | Account Classification | picklist | 1: A, 276530000: B, 276530001: C, 100000001: D, 100000000: E, 276530002: S, 276530003: N/A, 276530004: aa, 276530005: bb, 276530006: cc, 276530007: ss | No | none | 2026-03-20 21:14:01 | true | Account | CRM Account Classification | CRM_Account_Classification__c |  |  |  | [2](#2-forms) | [12](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 2 | [accountid](#accountid) | Account | uniqueidentifier |  | No | required | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  | [23](#3-views) |  | [1](#5-reports) |  | [8](#7-workflows) |  | [12](#10-plugin-source-code-analysis) |  |  |  |  |
| 3 | [accountnumber](#accountnumber) | Sequence Number | nvarchar |  | No | none | 2026-03-10 20:08:23 | true |  |  |  | Account | AccountNumber | AccountNumber |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 4 | [address1_addresstypecode](#address1_addresstypecode) | Physical Address Type | picklist | 3: Physical, 1: Bill To, 2: Ship To, 4: Other | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [5](#7-workflows) |  |  |  |  |  |  |
| 5 | [address1_city](#address1_city) | Physical Address City | nvarchar |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) | [17](#3-views) |  |  |  | [3](#7-workflows) |  |  |  |  |  |  |
| 6 | [address1_composite](#address1_composite) | Physical Address | ntext |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 7 | [address1_country](#address1_country) | Physical Address Country/Region | nvarchar |  | No | recommended | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 8 | [address1_county](#address1_county) | Physical Address County | nvarchar |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 9 | [address1_fax](#address1_fax) | Physical Address Fax | nvarchar |  | No | none | Never | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 10 | [address1_freighttermscode](#address1_freighttermscode) | Physical Address Freight Terms | picklist | 1: FOB, 2: No Charge | No | none | 2026-03-10 20:01:05 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 11 | [address1_latitude](#address1_latitude) | Physical Address Latitude | float |  | No | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 12 | [address1_line1](#address1_line1) | Physical Address Street 1 | nvarchar |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [3](#2-forms) |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 13 | [address1_line2](#address1_line2) | Physical Address Street 2 | nvarchar |  | No | none | 2026-03-20 15:33:16 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 14 | [address1_line3](#address1_line3) | Physical Address Street 3 | nvarchar |  | No | none | 2026-03-20 20:23:34 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 15 | [address1_longitude](#address1_longitude) | Physical Address Longitude | float |  | No | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 16 | [address1_name](#address1_name) | Physical Address Name | nvarchar |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) | [1](#3-views) |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 17 | [address1_postalcode](#address1_postalcode) | Physical Address ZIP/Postal Code | nvarchar |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 18 | [address1_postofficebox](#address1_postofficebox) | Physical Address Post Office Box | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 19 | [address1_primarycontactname](#address1_primarycontactname) | Physical Address Primary Contact Name | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 20 | [address1_shippingmethodcode](#address1_shippingmethodcode) | Physical Address Shipping Method | picklist | 1: Airborne, 2: DHL, 3: FedEx, 4: UPS, 5: Postal Mail, 6: Full Load, 7: Will Call | No | none | 2026-03-10 20:01:05 | true |  |  |  |  |  |  |  |  |  |  |  | [5](#7-workflows) |  |  |  |  |  |  |
| 21 | [address1_stateorprovince](#address1_stateorprovince) | Physical Address State/Province | nvarchar |  | No | recommended | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) | [15](#3-views) |  |  |  | [10](#7-workflows) |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 22 | [address1_telephone1](#address1_telephone1) | Physical Address Phone | nvarchar |  | No | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 23 | [address1_telephone2](#address1_telephone2) | Physical Address Telephone 2 | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 24 | [address1_telephone3](#address1_telephone3) | Physical Address Telephone 3 | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 25 | [address1_upszone](#address1_upszone) | Physical Address UPS Zone | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 26 | [address1_utcoffset](#address1_utcoffset) | Physical Address UTC Offset | int |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 27 | [address2_addresstypecode](#address2_addresstypecode) | Bill To Address Type | picklist | 3: Physical, 1: Bill To, 2: Ship To, 4: Other | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  |  |  | [5](#7-workflows) |  |  |  |  |  |  |
| 28 | [address2_city](#address2_city) | Bill To City | nvarchar |  | No | none | 2026-03-21 01:28:31 | false | Account | BillingCity | BillingCity |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 29 | [address2_composite](#address2_composite) | Bill To Address | ntext |  | No | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 30 | [address2_country](#address2_country) | Bill To Country/Region | nvarchar |  | No | none | 2026-03-21 01:28:31 | true | Account | BillingCountry | BillingCountry |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 31 | [address2_county](#address2_county) | Bill To County | nvarchar |  | No | none | 2026-03-19 19:41:31 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 32 | [address2_fax](#address2_fax) | Bill To Fax | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 33 | [address2_freighttermscode](#address2_freighttermscode) | Bill To Freight Terms | picklist | 1: Default Value | No | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 34 | [address2_latitude](#address2_latitude) | Bill To Latitude | float |  | No | none | 2026-03-10 20:01:05 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 35 | [address2_line1](#address2_line1) | Bill To Street 1 | nvarchar |  | No | none | 2026-03-21 01:28:31 | true | Account | BillingStreet | BillingStreet |  |  |  |  |  |  | [1](#5-reports) |  |  |  |  |  |  |  |  |
| 36 | [address2_line2](#address2_line2) | Bill To Street 2 | nvarchar |  | No | none | 2026-03-20 15:33:16 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 37 | [address2_line3](#address2_line3) | Bill To Street 3 | nvarchar |  | No | none | 2026-03-19 02:27:01 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 38 | [address2_longitude](#address2_longitude) | Bill To Longitude | float |  | No | none | 2026-03-10 20:01:05 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 39 | [address2_name](#address2_name) | Bill To Address Name | nvarchar |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 40 | [address2_postalcode](#address2_postalcode) | Bill To ZIP/Postal Code | nvarchar |  | No | none | 2026-03-21 01:28:31 | false | Account | BillingPostalCode | BillingPostalCode |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 41 | [address2_postofficebox](#address2_postofficebox) | Bill To Post Office Box | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 42 | [address2_primarycontactname](#address2_primarycontactname) | Bill To Primary Contact Name | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 43 | [address2_shippingmethodcode](#address2_shippingmethodcode) | Bill To Shipping Method | picklist | 1: Default Value | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  |  |  | [5](#7-workflows) |  |  |  |  |  |  |
| 44 | [address2_stateorprovince](#address2_stateorprovince) | Bill To State/Province | nvarchar |  | No | none | 2026-03-21 01:28:31 | false | Account | BillingState | BillingState |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 45 | [address2_telephone1](#address2_telephone1) | Bill To Telephone 1 | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 46 | [address2_telephone2](#address2_telephone2) | Bill To Telephone 2 | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 47 | [address2_telephone3](#address2_telephone3) | Bill To Telephone 3 | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 48 | [address2_upszone](#address2_upszone) | Bill To UPS Zone | nvarchar |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 49 | [address2_utcoffset](#address2_utcoffset) | Bill To UTC Offset | int |  | No | none | Never | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 50 | [azt_accountalert](#azt_accountalert) | Account Alert | nvarchar |  | Yes | none | 2026-03-19 18:49:26 | true | Account | Account Alert | Account_Alert__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 51 | [azt_accountleadgenname](#azt_accountleadgenname) | Account Lead Gen Name | nvarchar |  | Yes | none | 2026-03-17 12:50:21 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 52 | [azt_accountnumber](#azt_accountnumber) | Account Number | nvarchar |  | Yes | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 53 | [azt_accountspend](#azt_accountspend) | Lifetime Spend | money |  | Yes | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 54 | [azt_accountspend_base](#azt_accountspend_base) | Account Spend (Base) | money |  | Yes | none | 2026-03-21 01:28:31 | false | Account | CRM Account Spend (Base) | CRM_Account_Spend__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 55 | [azt_accounttype](#azt_accounttype) | Account Type | picklist | 276530000: Active Account, 276530001: Expired Account, 276530007: Prospect, 276530005: Trade Show, 276530003: Partner, 276530006: Vendor, 276530004: Pilot, 276530002: Other, 100000000: Active | Yes | none | 2026-03-21 01:28:31 | true | Account | Account Status | Account_Status__c |  |  |  | [5](#2-forms) | [11](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 56 | [azt_addresssearch](#azt_addresssearch) | Address Search | nvarchar |  | Yes | none | 2026-03-17 12:51:08 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 57 | [azt_addresssearch2](#azt_addresssearch2) | Address Search 2 | nvarchar |  | Yes | none | 2026-02-02 16:03:14 | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 58 | [azt_aeflafunding](#azt_aeflafunding) | AEFLA Funding | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 20:23:34 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 59 | [azt_customerintrocompletedby](#azt_customerintrocompletedby) | Customer Intro Completed By | nvarchar |  | Yes | none | 2026-03-20 16:12:24 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 60 | [azt_customerintrocompletedon](#azt_customerintrocompletedon) | Customer Intro Completed On | nvarchar |  | Yes | none | 2026-03-20 16:12:24 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 61 | [azt_customerintroductioncompleted](#azt_customerintroductioncompleted) | Customer Introduction Completed | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 21:14:01 | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  | [1](#7-workflows) |  |  |  |  |  |  |
| 62 | [azt_customernumber](#azt_customernumber) | Customer Number | nvarchar |  | Yes | recommended | 2026-03-21 01:28:31 | true | Account | Customer Number | Customer_Number__c |  |  |  | [4](#2-forms) | [5](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 63 | [azt_customerof](#azt_customerof) | Customer Of | picklist | 276530000: Aztec, 276530001: Life Skills, 276530002: Aztec & Life Skills | Yes | none | 2026-03-20 20:23:34 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 64 | [azt_digitalstatus](#azt_digitalstatus) | Digital Status | picklist |  | Yes | none | 2026-03-19 01:47:33 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 65 | [azt_duplicate](#azt_duplicate) | Duplicate? | nvarchar |  | Yes | none | 2026-03-16 15:50:13 | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 66 | [azt_excludefromautoassign](#azt_excludefromautoassign) | Exclude from Autoassign? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [3](#7-workflows) |  |  |  |  |  |  |
| 67 | [azt_executivesummary](#azt_executivesummary) | Executive Summary | ntext |  | Yes | none | 2026-03-21 01:28:31 | true | Account | Executive Summary | Executive_Summary__c |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 68 | [azt_extension](#azt_extension) | Ext | nvarchar |  | Yes | none | 2026-03-20 17:22:24 | true | Account | Ext | Ext__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 69 | [azt_fiscalyearend](#azt_fiscalyearend) | Fiscal Year End | picklist |  | Yes | none | 2026-03-20 20:23:34 | true | Account | Fiscal Year End | Fiscal_Year_End__c |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 70 | [azt_fsradminpassword](#azt_fsradminpassword) | FSR Admin Password | nvarchar |  | Yes | none | 2026-03-20 20:23:34 | false | Account | FSR Admin Password | FSR_Admin_Password__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 71 | [azt_fsradminusername](#azt_fsradminusername) | FSR Admin Username | nvarchar |  | Yes | none | 2026-03-20 20:23:34 | false | Account | FSR Admin Username | FSR_Admin_Username__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 72 | [azt_gedprintnoflashplay](#azt_gedprintnoflashplay) | GED Print NO Flash/Play | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 21:14:01 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 73 | [azt_gedprintnogedsoftware](#azt_gedprintnogedsoftware) | GED Print - NO GED Software | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 21:14:01 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 74 | [azt_historicalowner](#azt_historicalowner) | Historical Owner | nvarchar |  | Yes | none | 2026-03-20 15:01:37 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 75 | [azt_isautoduplicate](#azt_isautoduplicate) | Is Auto Duplicate? | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 21:14:01 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 76 | [azt_isduplicate](#azt_isduplicate) | Is Duplicate | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 18:32:49 | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 77 | [azt_isinquickbooks](#azt_isinquickbooks) | Is In Quickbooks? | picklist | 0: Yes, 1: No, 2: Possible | Yes | none | 2026-03-19 14:27:05 | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 78 | [azt_ismatched](#azt_ismatched) | Is Matched? | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 21:14:01 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 79 | [azt_lastactivitydate](#azt_lastactivitydate) | Last Activity Date | datetime |  | Yes | none | Never | true |  |  |  |  |  |  |  | [2](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 80 | [azt_lastprintpurchase](#azt_lastprintpurchase) | Last Print Purchase | datetime |  | Yes | none | 2026-03-20 21:14:01 | true | Account | CRM Last Print Purchase | CRM_Last_Print_Purchase__c |  |  |  | [3](#2-forms) | [5](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 81 | [azt_lastsaaspurchase](#azt_lastsaaspurchase) | Last SaaS Purchase | datetime |  | Yes | none | 2026-03-20 21:14:01 | true | Account | CRM Last SaaS Purchase | CRM_Last_SaaS_Purchase__c |  |  |  | [3](#2-forms) | [5](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 82 | [azt_lastsuccessfulconnection](#azt_lastsuccessfulconnection) | Last Successful Connection | datetime |  | Yes | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 83 | [azt_lastyearspend](#azt_lastyearspend) | Last Year Spend | money |  | Yes | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 84 | [azt_lastyearspend_base](#azt_lastyearspend_base) | Last Year Spend (Base) | money |  | Yes | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 85 | [azt_leadsourceid](#azt_leadsourceid) | Lead Source | lookup |  | Yes | none | 2026-03-20 20:23:34 | true | Account | Account Source | AccountSource |  |  |  | [2](#2-forms) |  |  |  |  | [8](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 86 | [azt_nomatch](#azt_nomatch) | No Match? | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 87 | [azt_nonsaasstatus](#azt_nonsaasstatus) | Non-SaaS Status | picklist |  | Yes | none | 2026-03-20 21:14:01 | true | Account | CRM Non-SaaS Status | Non_SaaS_Status__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 88 | [azt_numberofcomputers](#azt_numberofcomputers) | # Computers | int |  | Yes | none | 2026-03-19 02:08:44 | true | Account | # Computers | NumofComputers__c |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 89 | [azt_numberofstudents](#azt_numberofstudents) | # Students | int |  | Yes | none | 2026-03-19 02:27:00 | true | Account | # Students | NumofStudents__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 90 | [azt_oldbusinessunit](#azt_oldbusinessunit) | Old Business Unit | nvarchar |  | Yes | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 91 | [azt_parentaccountspend](#azt_parentaccountspend) | Parent Account Spend | money |  | Yes | none | 2026-03-20 15:01:37 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 92 | [azt_parentaccountspend_base](#azt_parentaccountspend_base) | Parent Account Spend (Base) | money |  | Yes | none | 2026-03-20 15:01:37 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 93 | [azt_parentlastyearspend](#azt_parentlastyearspend) | Parent Last Year Spend | money |  | Yes | none | 2026-03-20 15:01:37 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 94 | [azt_parentlastyearspend_base](#azt_parentlastyearspend_base) | Parent Last Year Spend (Base) | money |  | Yes | none | 2026-03-20 15:01:37 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 95 | [azt_parentytdspend](#azt_parentytdspend) | Parent YTD Spend | money |  | Yes | none | 2026-03-20 15:01:37 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 96 | [azt_parentytdspend_base](#azt_parentytdspend_base) | Parent YTD Spend (Base) | money |  | Yes | none | 2026-03-20 15:01:37 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 97 | [azt_possiblematchid](#azt_possiblematchid) | Possible Match | lookup |  | Yes | none | 2026-03-10 20:07:36 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 98 | [azt_productfamilies](#azt_productfamilies) | Product Families | multiselectpicklist |  | Yes | none | 2026-03-20 21:14:01 | true |  |  |  |  |  |  | [2](#2-forms) | [2](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 99 | [azt_recordownerid](#azt_recordownerid) | Record Owner | lookup |  | Yes | none | 2026-03-20 21:14:01 | true | Account | Record Owner | OwnerId |  |  |  | [2](#2-forms) | [6](#3-views) |  | [2](#5-reports) |  | [37](#7-workflows) |  | [9](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 100 | [azt_saasstatus](#azt_saasstatus) | SaaS Status | picklist |  | Yes | none | 2026-03-20 21:14:01 | true | Account | CRM SaaS Status | CRM_SaaS_Status__c |  |  |  | [2](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 101 | [azt_score](#azt_score) | Score | nvarchar |  | Yes | none | 2026-03-19 16:55:19 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 102 | [azt_tax_exempt_certificate__c](#azt_tax_exempt_certificate__c) | Tax_Exempt_Certificate__c | bit | 1: Yes, 0: No | Yes | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 103 | [azt_taxexemptcertificate](#azt_taxexemptcertificate) | Tax Exempt Certificate # | nvarchar |  | Yes | none | 2026-03-20 21:14:01 | true |  |  |  | Account | Tax_Exempt__c | Tax_Exempt__c | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 104 | [azt_ttprintnotto](#azt_ttprintnotto) | TTPrint - No TTO | bit | 1: Yes, 0: No | Yes | none | 2026-03-20 21:14:01 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 105 | [azt_type](#azt_type) | Type | nvarchar |  | Yes | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 106 | [azt_verticalmarket](#azt_verticalmarket) | Vertical Market | picklist |  | Yes | none | 2026-03-21 01:28:31 | true |  | Industry |  |  |  |  | [5](#2-forms) |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 107 | [azt_yearbeforelastspend](#azt_yearbeforelastspend) | Year Before Last Spend | money |  | Yes | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 108 | [azt_yearbeforelastspend_base](#azt_yearbeforelastspend_base) | Year Before Last Spend (Base) | money |  | Yes | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 109 | [azt_ytdspend](#azt_ytdspend) | YTD Spend | money |  | Yes | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  | [1](#9-formulas-rollups) |  |  |  |  |  |
| 110 | [azt_ytdspend_base](#azt_ytdspend_base) | YTD Spend (Base) | money |  | Yes | none | 2026-03-21 01:28:31 | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 111 | [createdby](#createdby) | Created By | lookup |  | No | none | 2026-03-21 01:28:31 | true |  |  |  | Account | Legacy_Created_By__c | Legacy_Created_By__c |  |  |  |  |  | [2](#7-workflows) |  |  |  |  |  |  |
| 112 | [createdon](#createdon) | Created On | datetime |  | No | none | Skipped (createdon) | true |  |  |  | Account | Legacy_Created_On_Date__c | Legacy_Created_On_Date__c |  |  |  |  |  |  |  | [10](#10-plugin-source-code-analysis) |  |  |  |  |
| 113 | [description](#description) | Description | ntext |  | No | none | 2026-03-19 14:32:19 | true |  |  |  | Account | Description | Description | [2](#2-forms) |  |  |  |  |  |  | [7](#10-plugin-source-code-analysis) |  |  |  |  |
| 114 | [donotsendmm](#donotsendmm) | Send Marketing Materials | bit |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 115 | [emailaddress1](#emailaddress1) | Email | nvarchar |  | No | none | 2025-11-17 17:18:21 | true |  |  |  |  |  |  |  | [2](#3-views) |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 116 | [fax](#fax) | Fax | nvarchar |  | No | none | 2026-03-20 16:12:24 | true |  |  |  |  |  |  |  | [1](#3-views) |  |  |  |  |  |  |  |  |  |  |
| 117 | [lastusedincampaign](#lastusedincampaign) | Last Date Included in Campaign | datetime |  | No | none | Never | true |  |  |  |  |  |  | [1](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |
| 118 | [modifiedon](#modifiedon) | Modified On | datetime |  | No | none | Skipped (modifiedon) | true |  |  |  | Account | Legacy_Modified_On__c | Legacy_Modified_On__c |  |  |  |  |  |  |  | [4](#10-plugin-source-code-analysis) |  |  |  |  |
| 119 | [msa_managingpartnerid](#msa_managingpartnerid) | Managing Partner | lookup |  | Yes | none | 2026-03-19 02:18:42 | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#12-relationships) |  |  |
| 120 | [msdyn_accountkpiid](#msdyn_accountkpiid) | KPI | lookup |  | Yes | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 121 | [msdyn_salesaccelerationinsightid](#msdyn_salesaccelerationinsightid) | Sales Acceleration Insights ID | lookup |  | Yes | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 122 | [msdyn_segmentid](#msdyn_segmentid) | Segment Id | lookup |  | Yes | none | Never | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 123 | [name](#name) | Account Name | nvarchar |  | No | required | 2026-03-21 01:28:31 | true | Account | Account Name | Name |  |  |  | [3](#2-forms) | [46](#3-views) |  | [3](#5-reports) |  | [16](#7-workflows) |  | [23](#10-plugin-source-code-analysis) |  |  |  |  |
| 124 | [new_sharedwith](#new_sharedwith) | Shared With | lookup |  | Yes | none | 2026-03-19 19:19:43 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  |  |  |  |  | [1](#12-relationships) |  |  |
| 125 | [originatingleadid](#originatingleadid) | Originating Lead | lookup |  | No | none | Never | true |  |  |  |  |  |  | [3](#2-forms) |  |  |  |  |  |  | [2](#10-plugin-source-code-analysis) |  | [1](#12-relationships) |  |  |
| 126 | [ownerid](#ownerid) | Owner | owner |  | No | systemrequired | 2026-03-21 01:28:31 | true | Account | Record type | RecordType |  |  |  | [3](#2-forms) | [9](#3-views) |  | [1](#5-reports) |  | [24](#7-workflows) |  | [22](#10-plugin-source-code-analysis) |  |  |  |  |
| 127 | [owningteam](#owningteam) | Owning Team | lookup |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  |  |  | [1](#7-workflows) |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 128 | [parentaccountid](#parentaccountid) | Parent Account | lookup |  | No | none | 2026-03-19 19:24:25 | true | Account | ParentId | ParentId |  |  |  | [2](#2-forms) | [1](#3-views) |  |  |  | [12](#7-workflows) |  | [4](#10-plugin-source-code-analysis) |  | [2](#12-relationships) |  |  |
| 129 | [primarycontactid](#primarycontactid) | Primary Contact | lookup |  | No | none | 2026-03-20 20:23:34 | true |  |  |  |  |  |  | [2](#2-forms) |  |  |  |  | [2](#7-workflows) |  | [2](#10-plugin-source-code-analysis) |  |  |  |  |
| 130 | [shippingmethodcode](#shippingmethodcode) | Shipping Method | picklist |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  | [1](#5-reports) |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 131 | [statecode](#statecode) | Status | state |  | No | systemrequired | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  | [17](#3-views) |  |  |  | [10](#7-workflows) | [3](#9-formulas-rollups) | [20](#10-plugin-source-code-analysis) |  |  |  |  |
| 132 | [statuscode](#statuscode) | Status Reason | picklist |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10-plugin-source-code-analysis) |  |  |  |  |
| 133 | [telephone1](#telephone1) | Main Phone | nvarchar |  | No | none | 2026-03-21 01:28:31 | true |  | Phone |  |  |  |  | [3](#2-forms) | [23](#3-views) |  |  |  |  |  | [1](#10-plugin-source-code-analysis) |  |  |  |  |
| 134 | [telephone2](#telephone2) | Other Phone | nvarchar |  | No | none | 2026-03-19 14:30:50 | false | Account | Other Phone | OtherPhone__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 135 | [transactioncurrencyid](#transactioncurrencyid) | Currency | lookup |  | No | none | 2026-03-21 01:28:31 | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10-plugin-source-code-analysis) |  |  |  |  |
| 136 | [websiteurl](#websiteurl) | Website | nvarchar |  | No | none | 2026-03-20 21:14:01 | true |  |  |  | Account | Website | Website | [2](#2-forms) |  |  |  |  |  |  |  |  |  |  |  |

---

## 2. Forms

Total forms: **12**

### 2.1. TimelineWallControl - Account- Main (main) -- Active

- **Form ID:** `{6df8e8ce-7655-468c-925e-660d59aa7f4c}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: SUMMARY_TAB

##### Section: SOCIAL_PANE_TAB

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#notescontrol) | Notes Properties | No | Yes |

### 2.2. iGrad Account (main) -- Active

- **Form ID:** `{a7fc2a6c-bdca-4294-9533-77d161f541b1}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Header Fields

| Field | Label |
|-------|-------|
| [azt_accounttype](#azt_accounttype) | Account Type |
| [azt_verticalmarket](#azt_verticalmarket) | Vertical Market |
| [ownerid](#ownerid) | Owner |
| [azt_lastsuccessfulconnection](#azt_lastsuccessfulconnection) | Last Successful Connection |

#### Tab: Summary

##### Section: ACCOUNT INFORMATION

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_customernumber](#azt_customernumber) | Customer Number | Yes | Yes |
| [azt_excludefromautoassign](#azt_excludefromautoassign) | Exclude from Autoassign? | No | No |
| [azt_customerof](#azt_customerof) | Customer Of | No | No |
| [telephone1](#telephone1) | Phone | No | No |
| [name](#name) | Account Name | No | Yes |
| [azt_leadsourceid](#azt_leadsourceid) | Lead Source | No | Yes |
| [telephone1](#telephone1) | Phone | No | Yes |
| [azt_extension](#azt_extension) | Ext | No | Yes |
| [websiteurl](#websiteurl) | Website | No | Yes |
| [parentaccountid](#parentaccountid) | Parent Account | No | Yes |
| [azt_taxexemptcertificate](#azt_taxexemptcertificate) | Tax Exempt Certificate # | No | Yes |
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |

##### Section: Account Status

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_accounttype](#azt_accounttype) | Account Type | No | Yes |
| [azt_saasstatus](#azt_saasstatus) | SaaS Status | Yes | Yes |
| [azt_nonsaasstatus](#azt_nonsaasstatus) | Non-SaaS Status | Yes | Yes |

##### Section: CHILD ACCOUNTS

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ChildAccounts](#childaccounts) | Child Accounts | No | Yes |

##### Section: COMPANY PROFILE

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_verticalmarket](#azt_verticalmarket) | Vertical Market | No | Yes |
| [azt_numberofstudents](#azt_numberofstudents) | # Students | No | Yes |

##### Section: Address
*Hidden section*

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [address1_line1](#address1_line1) | Physical Address Street 1 | No | Yes |

##### Section: PHYSICAL ADDRESS

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_addresssearch](#azt_addresssearch) | Search for an Address: | No | Yes |
| [address1_addresstypecode](#address1_addresstypecode) | Address Type | No | No |
| [address1_name](#address1_name) | Address Name | No | No |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [address1_line1](#address1_line1) | Street 1 | No | Yes |
| [address1_line2](#address1_line2) | Street 2 | No | Yes |
| [address1_city](#address1_city) | City | No | Yes |
| [address1_stateorprovince](#address1_stateorprovince) | State | No | Yes |
| [address1_postalcode](#address1_postalcode) | Zip | No | Yes |
| [address1_country](#address1_country) | Country | No | Yes |

##### Section: MapSection

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [mapcontrol](#mapcontrol) | Map View | No | Yes |

##### Section: Executive Summary

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_executivesummary](#azt_executivesummary) | Executive Summary | No | Yes |

##### Section: SOCIAL PANE

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#notescontrol) | Notes Properties | No | Yes |
| [addresses](#addresses) | Addresses | No | Yes |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Contacts](#contacts) | CONTACTS | No | Yes |
| [Connections](#connections) | CONNECTIONS | No | Yes |
| [accountopportunitiesgrid](#accountopportunitiesgrid) | Opportunities | No | Yes |
| [accountcasessgrid](#accountcasessgrid) | Cases | No | Yes |

#### Tab: Opportunities

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [opportunities](#opportunities) | Opportunities | No | Yes |

#### Tab: Engagements

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [engagements](#engagements) | Engagements | No | Yes |

#### Tab: Software

##### Section: Purchased Software

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [purchasedsoftware](#purchasedsoftware) | Purchased Software | No | Yes |

#### Tab: Print

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [print](#print) | Print Purchases | No | Yes |

#### Tab: Allocations

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [allocations](#allocations) | Licenses Allocated | No | Yes |

#### Tab: Assets and Locations

##### Section: Assets and Locations

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [name](#name) | Account Name | No | Yes |

#### Tab: Files

##### Section: Documents Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [DocumentsSubGrid](#documentssubgrid) | Documents | No | Yes |

#### Tab: LinkedIn Sales Navigator
*Hidden tab*

##### Section: LinkedIn Account Profile

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [name](#name) | Account Name | No | Yes |

##### Section: LinkedIn Member Profile

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [primarycontactid](#primarycontactid) | Primary Contact | No | Yes |

##### Section: LinkedIn InMail

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [primarycontactid](#primarycontactid) | Primary Contact | No | Yes |

#### Tab: Details

##### Section: Description

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_productfamilies](#azt_productfamilies) | Product Families | Yes | Yes |
| [azt_lastprintpurchase](#azt_lastprintpurchase) | Last Print Purchase | Yes | Yes |
| [azt_lastsaaspurchase](#azt_lastsaaspurchase) | Last SaaS Purchase | Yes | Yes |
| [originatingleadid](#originatingleadid) | Originating Lead | No | Yes |
| [description](#description) | Description | No | Yes |
| [new_sharedwith](#new_sharedwith) | Shared With | No | Yes |

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [accessteam](#accessteam) | Read Access Team | No | Yes |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [sharedwith](#sharedwith) | Shared With | No | Yes |

##### Section: MARKETING

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [originatingleadid](#originatingleadid) | Originating Lead | No | Yes |
| [lastusedincampaign](#lastusedincampaign) | Last Campaign Date | Yes | Yes |
| [donotsendmm](#donotsendmm) | Marketing Materials | No | Yes |

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [writeteam](#writeteam) | Write Access Team | No | Yes |

#### Tab: Quotes Orders Invoices

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quotes](#quotes) | Quotes | No | Yes |
| [orders](#orders) | Orders | No | Yes |
| [invoices](#invoices) | Invoices | No | Yes |

#### Tab: Account Alert

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_accountalert](#azt_accountalert) | Account Alert | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [azt_historicalowner](#azt_historicalowner) | Historical Owner |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `AssetCommon.Account.OnLoad` | `msdyn_/Account/AssetCommon.Account.Library.js` | true |
| onload |  | `LinkedInExtensions.Account.Instance.handleOrgChartModifiedNotification` | `LinkedInExtensions/Account/LinkedInExtensions_Account.js` | true |
| onload |  | `A.AccountFunctions.accountAlert` | `azt_accountlibrary` | true |
| onload |  | `A.AccountFunctions.onLoad` | `azt_accountlibrary` | true |
| onload |  | `SalesOmniChannel.SalesPhoneNumber.SalesPhoneNumberLibrary.onFormLoad` | `msdyn_SalesOmniChannel/SalesPhoneNumber.Library.js` | true |
| onload |  | `LinkedInIntegration.LinkedInIntegrationCommon.Instance.Form_OnLoad` | `LinkedInIntegration/Common/msdyn_LinkedInIntegrationCommon.js` | true |
| onload |  | `Sales.AddressSuggestionsControl.shouldShowAddressSuggestionsControl` | `Sales/ClientCommon/Sales_ClientCommon.js` | true |
| onload |  | `Sales.DocumentsTabController.shouldShowDocumentsTab` | `Sales/ClientCommon/Sales_ClientCommon.js` | true |
| onchange | address1_addresstypecode | `A.AccountFunctions.setPrimAddressName` | `azt_accountlibrary` | true |

### 2.3. AI for Sales (main) -- Inactive

- **Form ID:** `{cb430327-bcc1-416d-959d-db7592e685af}`
- **Presentation:** UCI/Tablet
- **Status:** Inactive

#### Tab: SUMMARY_TAB

##### Section: ACCOUNT_INFORMATION

##### Section: ADDRESS

##### Section: SUMMARY_TAB_section_6

#### Tab: RAV2
*Hidden tab*

##### Section: RAV2_section_1

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [RICONTAINER_CHARTS](#ricontainer_charts) |  | No | Yes |

#### Tab: DETAILS_TAB

##### Section: COMPANY_PROFILE

##### Section: DETAILS_TAB_section_6

##### Section: MARKETING

##### Section: BILLING

### 2.4. Information (main) -- Inactive

- **Form ID:** `{b053a39a-041a-4356-acef-ddf00182762b}`
- **Presentation:** Classic
- **Status:** Inactive

#### Tab: general

##### Section: account information

##### Section: description

#### Tab: details

##### Section: professional information

##### Section: description

##### Section: billing information

#### Tab: contacts

#### Tab: notes and activities

#### Tab: administration

##### Section: internal information

##### Section: marketing information

##### Section: service preferences

#### Tab: What's New

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [WebResource_RecordWall](#webresource_recordwall) | RecordWall | No | Yes |

### 2.5. Account (main) -- Active

- **Form ID:** `{8448b78f-8f42-454e-8e2a-f8196b0419af}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Header Fields

| Field | Label |
|-------|-------|
| [azt_accounttype](#azt_accounttype) | Account Type |
| [azt_verticalmarket](#azt_verticalmarket) | Vertical Market |
| [azt_lastsuccessfulconnection](#azt_lastsuccessfulconnection) | Last Successful Connection |

#### Tab: SUMMARY_TAB

##### Section: ACCOUNT_INFORMATION

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [telephone1](#telephone1) |  | No | Yes |
| [websiteurl](#websiteurl) |  | No | Yes |
| [azt_customernumber](#azt_customernumber) | Customer Number | Yes | Yes |
| [azt_excludefromautoassign](#azt_excludefromautoassign) | Exclude from Autoassign? | No | No |
| [azt_customerof](#azt_customerof) | Customer Of | No | No |
| [azt_leadsourceid](#azt_leadsourceid) | Lead Source | No | Yes |
| [azt_extension](#azt_extension) | Ext | No | Yes |
| [accountclassificationcode](#accountclassificationcode) | Acct Classification | No | Yes |
| [azt_taxexemptcertificate](#azt_taxexemptcertificate) | Tax Exempt Certificate # | No | Yes |
| [azt_recordownerid](#azt_recordownerid) | Record Owner | No | Yes |

##### Section: PHYSICAL ADDRESS

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_addresssearch](#azt_addresssearch) | Search for an Address: | No | Yes |
| [address1_addresstypecode](#address1_addresstypecode) | Address Type | No | No |
| [address1_name](#address1_name) | Address Name | No | No |

##### Section: SUMMARY_TAB_ADDRESSINPUT_SECTION
*Hidden section*

##### Section: MapSection

##### Section: Account Status

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_accounttype](#azt_accounttype) | Account Type | No | Yes |
| [azt_saasstatus](#azt_saasstatus) | SaaS Status | Yes | Yes |
| [azt_nonsaasstatus](#azt_nonsaasstatus) | Non-SaaS Status | Yes | Yes |

##### Section: CHILD ACCOUNTS

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ChildAccounts](#childaccounts) | Child Accounts | No | Yes |

##### Section: COMPANY PROFILE

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_verticalmarket](#azt_verticalmarket) | Vertical Market | No | Yes |
| [azt_numberofcomputers](#azt_numberofcomputers) | # Computers | No | Yes |
| [azt_numberofstudents](#azt_numberofstudents) | # Students | No | Yes |
| [azt_fiscalyearend](#azt_fiscalyearend) | Fiscal Year End | No | Yes |
| [azt_aeflafunding](#azt_aeflafunding) | AEFLA Funding | No | Yes |

##### Section: Funding

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [funding](#funding) | New SG control 1762723683807 | No | Yes |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [address1_line1](#address1_line1) | Street 1 | No | Yes |
| [address1_line2](#address1_line2) | Street 2 | No | Yes |
| [address1_city](#address1_city) | City | No | Yes |
| [address1_stateorprovince](#address1_stateorprovince) | State | No | Yes |
| [address1_postalcode](#address1_postalcode) | Zip | No | Yes |
| [address1_country](#address1_country) | Country | No | Yes |

##### Section: SOCIAL_PANE_TAB

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#notescontrol) | Notes Properties | No | Yes |
| [addresses](#addresses) | Addresses | No | Yes |

##### Section: Executive Summary

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_executivesummary](#azt_executivesummary) | Executive Summary | No | Yes |

##### Section: Summary_section_6

##### Section: SUMMARY_TAB_section_6

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Contacts](#contacts) |  | No | Yes |
| [accountopportunitiesgrid](#accountopportunitiesgrid) | Opportunities | No | Yes |
| [accountcasessgrid](#accountcasessgrid) | Cases | No | Yes |
| [Connections](#connections) | CONNECTIONS | No | Yes |

##### Section: Previews

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [previews](#previews) | Previews | No | Yes |

#### Tab: DETAILS_TAB

##### Section: COMPANY_PROFILE

##### Section: DETAILS_TAB_section_6

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [description](#description) | Description | No | Yes |
| [azt_productfamilies](#azt_productfamilies) | Product Families | Yes | Yes |
| [azt_lastprintpurchase](#azt_lastprintpurchase) | Last Print Purchase | Yes | Yes |
| [azt_lastsaaspurchase](#azt_lastsaaspurchase) | Last SaaS Purchase | Yes | Yes |
| [originatingleadid](#originatingleadid) | Originating Lead | No | Yes |
| [new_sharedwith](#new_sharedwith) | Shared With | No | Yes |

##### Section: MARKETING

##### Section: CONTACT_PREFERENCES

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [accessteam](#accessteam) | Read Access Team | No | Yes |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [sharedwith](#sharedwith) | Shared With | No | Yes |

##### Section: BILLING

##### Section: SHIPPING

##### Section: ChildAccounts

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [writeteam](#writeteam) | Write Access Team | No | Yes |

#### Tab: AssetsAndLocationsTab

##### Section: AssetsAndLocationsSection

#### Tab: documents_sharepoint

#### Tab: linkedin_v2_tab
*Hidden tab*

##### Section: linkedin_v2_tab_section_3

#### Tab: Opportunities

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [opportunities](#opportunities) | Opportunities | No | Yes |

#### Tab: Engagements

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [engagements](#engagements) | Engagements | No | Yes |

#### Tab: Software

##### Section: Purchased Software

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [purchasedsoftware](#purchasedsoftware) | Purchased Software | No | Yes |

#### Tab: Print

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [print](#print) | Print Purchases | No | Yes |

#### Tab: Allocations

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [allocations](#allocations) | Licenses Allocated | No | Yes |

#### Tab: Quotes Orders Invoices

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quotes](#quotes) | Quotes | No | Yes |
| [orders](#orders) | Orders | No | Yes |
| [invoices](#invoices) | Invoices | No | Yes |

#### Tab: Account Alert

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_accountalert](#azt_accountalert) | Account Alert | No | Yes |

#### Tab: Administration

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_accountspend](#azt_accountspend) | Lifetime Spend | No | Yes |
| [azt_ytdspend](#azt_ytdspend) | YTD Spend | No | Yes |
| [azt_lastyearspend](#azt_lastyearspend) | Last Year Spend | No | Yes |
| [azt_parentaccountspend](#azt_parentaccountspend) | Parent Account Spend | Yes | Yes |
| [azt_parentytdspend](#azt_parentytdspend) | Parent YTD Spend | No | Yes |
| [azt_parentlastyearspend](#azt_parentlastyearspend) | Parent Last Year Spend | No | Yes |
| [azt_yearbeforelastspend](#azt_yearbeforelastspend) | Year Before Last Spend | No | Yes |
| [azt_score](#azt_score) | Score | No | Yes |
| [azt_possiblematchid](#azt_possiblematchid) | Possible Match | No | Yes |
| [azt_oldbusinessunit](#azt_oldbusinessunit) | Old Business Unit | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [azt_historicalowner](#azt_historicalowner) | Historical Owner |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `SalesOmniChannel.SalesPhoneNumber.SalesPhoneNumberLibrary.onFormLoad` | `msdyn_SalesOmniChannel/SalesPhoneNumber.Library.js` | true |
| onload |  | `LinkedInIntegration.LinkedInIntegrationCommon.Instance.Form_OnLoad` | `LinkedInIntegration/Common/msdyn_LinkedInIntegrationCommon.js` | true |
| onload |  | `Sales.DocumentsTabController.shouldShowDocumentsTab` | `Sales/ClientCommon/Sales_ClientCommon.js` | true |
| onload |  | `Sales.AddressSuggestionsControl.shouldShowAddressSuggestionsControl` | `Sales/ClientCommon/Sales_ClientCommon.js` | true |
| onload |  | `A.AccountFunctions.accountAlert` | `azt_accountlibrary` | true |
| onload |  | `A.AccountFunctions.onLoad` | `azt_accountlibrary` | true |
| onchange | address1_addresstypecode | `A.AccountFunctions.setPrimAddressName` | `azt_accountlibrary` | true |

### 2.6. Purchased Software Licenses (quick) -- Active

- **Form ID:** `{0f2248fc-4264-4bf9-9f9b-49c807c7c276}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [purchasedsoftware](#purchasedsoftware) | Purchased Software | No | Yes |

### 2.7. Account Owner Card (quick) -- Active

- **Form ID:** `{b6e88028-6990-40e6-ba5b-562bf68e363a}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#ownerid) | Account Owner | No | Yes |

### 2.8. Last Purchase Dates Quick View (quick) -- Active

- **Form ID:** `{a3764c0b-4fd3-482e-ac69-6585b3532833}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_aeflafunding](#azt_aeflafunding) | AEFLA Funding | No | Yes |
| [azt_lastprintpurchase](#azt_lastprintpurchase) | Last Print Purchase | No | Yes |
| [azt_lastsaaspurchase](#azt_lastsaaspurchase) | Last SaaS Purchase | No | Yes |

##### Section: Funding

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [fundinggrid](#fundinggrid) | fundinggrid | No | Yes |

### 2.9. Allocated Software Licenses (quick) -- Active

- **Form ID:** `{b7be8bd7-c202-4f04-b412-8dcce39af644}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [softwarelicenseallocations](#softwarelicenseallocations) | Software License Allocations | No | Yes |

### 2.10. Account Lead Quick View (quick) -- Active

- **Form ID:** `{75c9e52b-54cd-46c3-8d52-ba6f22026631}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [accountclassificationcode](#accountclassificationcode) | Account Classification | No | Yes |
| [azt_customernumber](#azt_customernumber) | Customer Number | No | Yes |
| [azt_accounttype](#azt_accounttype) | Account Type | No | Yes |
| [azt_verticalmarket](#azt_verticalmarket) | Vertical Market | No | Yes |
| [parentaccountid](#parentaccountid) | Parent Account | No | Yes |
| [address1_composite](#address1_composite) | Physical Address | No | Yes |

### 2.11. Account Owner Quick View (quick) -- Active

- **Form ID:** `{ef3fdf29-170b-49dc-8107-dc01b314b785}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_customernumber](#azt_customernumber) | Customer Number | No | Yes |
| [ownerid](#ownerid) | Account Owner | No | Yes |

### 2.12. Engagement Contacts (quick) -- Active

- **Form ID:** `{4d5a456e-575a-4b58-b668-e31386e38e47}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [engagementcontacts](#engagementcontacts) | Contacts | No | Yes |

---

## 3. Views

Total views: **24**

### 3.1. Account Advanced Find View

- **Type:** Advanced Find (querytype=1)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [telephone1](#telephone1) | 100px |
| 3 | [accountid](#accountid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.2. Account Associated View

- **Type:** Associated View (querytype=2)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [telephone1](#telephone1) | 100px |
| 3 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.3. Account BulkOperation View

- **Type:** Associated View (querytype=2)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [telephone1](#telephone1) | 100px |
| 3 | [accountid](#accountid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.4. Account List Member View

- **Type:** Associated View (querytype=2)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [telephone1](#telephone1) | 100px |
| 3 | [emailaddress1](#emailaddress1) |  |
| 4 | [accountid](#accountid) |  |

### 3.5. Account Lookup View

- **Type:** Lookup View (querytype=64)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [emailaddress1](#emailaddress1) | 200px |
| 3 | [telephone1](#telephone1) | 100px |
| 4 | [accountnumber](#accountnumber) | 100px |
| 5 | [address1_city](#address1_city) | 100px |
| 6 | [fax](#fax) | 100px |
| 7 | [address1_name](#address1_name) | 100px |
| 8 | [address1_fax](#address1_fax) | 100px |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.6. Account Sharing Associated View

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [SharedUser.fullname](#shareduserfullname) | 150px |
| 2 | [fullname](#fullname) |  |

### 3.7. Accounts With Product Family Purchases

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_customernumber](#azt_customernumber) | 150px |
| 3 | [azt_accounttype](#azt_accounttype) | 125px |
| 4 | [accountclassificationcode](#accountclassificationcode) | 150px |
| 5 | [telephone1](#telephone1) | 125px |
| 6 | [address1_city](#address1_city) | 150px |
| 7 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 8 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 9 | [azt_productfamilies](#azt_productfamilies) | 300px |
| 10 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_productfamilies](#azt_productfamilies) | not-null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.8. Accounts: No Orders in Last 6 Months

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [telephone1](#telephone1) | 100px |
| 3 | [address1_city](#address1_city) | 100px |
| 4 | [accountid](#accountid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.9. Active Accounts in Quickbooks

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_customernumber](#azt_customernumber) | 125px |
| 3 | [azt_accounttype](#azt_accounttype) | 100px |
| 4 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 5 | [telephone1](#telephone1) | 100px |
| 6 | [address1_city](#address1_city) | 125px |
| 7 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 8 | [ownerid](#ownerid) | 150px |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_isinquickbooks](#azt_isinquickbooks) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.10. Active Accounts

- **Type:** Standard (querytype=0)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_customernumber](#azt_customernumber) | 125px |
| 3 | [azt_accounttype](#azt_accounttype) | 100px |
| 4 | [accountclassificationcode](#accountclassificationcode) | 125px |
| 5 | [azt_lastsaaspurchase](#azt_lastsaaspurchase) | 100px |
| 6 | [azt_lastprintpurchase](#azt_lastprintpurchase) | 100px |
| 7 | [telephone1](#telephone1) | 125px |
| 8 | [address1_city](#address1_city) | 125px |
| 9 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 10 | [ownerid](#ownerid) | 100px |
| 11 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.11. All Accounts

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 3 | [telephone1](#telephone1) | 100px |
| 4 | [address1_stateorprovince](#address1_stateorprovince) | 100px |
| 5 | [address1_city](#address1_city) | 100px |
| 6 | [statecode](#statecode) | 100px |
| 7 | [accountid](#accountid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.12. Duplicate Accounts

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_recordownerid](#azt_recordownerid) | 150px |
| 3 | [telephone1](#telephone1) | 100px |
| 4 | [address1_stateorprovince](#address1_stateorprovince) | 100px |
| 5 | [address1_city](#address1_city) | 100px |
| 6 | [statecode](#statecode) | 100px |
| 7 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_duplicate](#azt_duplicate) | not-null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |
| [azt_recordownerid](#azt_recordownerid) | Ascending |

### 3.13. GED Customers Without Kaplan

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_accounttype](#azt_accounttype) | 125px |
| 2 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 3 | [name](#name) | 300px |
| 4 | [telephone1](#telephone1) | 100px |
| 5 | [address1_city](#address1_city) | 125px |
| 6 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 7 | [ownerid](#ownerid) | 150px |
| 8 | [azt_softwarelicenseid](#azt_softwarelicenseid) |  |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [productnumber](#productnumber) | eq | GED-P |
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [azt_softwareproductid](#azt_softwareproductid) | eq | {D79C00D6-05DE-E411-80D0-00155D0ABD03} |
| [statecode](#statecode) | eq | 0 |
| [azt_accountid](#azt_accountid) | null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.14. GED Flash/Play Without Any GED

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_accounttype](#azt_accounttype) | 125px |
| 3 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 4 | [telephone1](#telephone1) | 100px |
| 5 | [address1_city](#address1_city) | 125px |
| 6 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 7 | [ownerid](#ownerid) | 150px |
| 8 | [azt_softwarelicenseid](#azt_softwarelicenseid) |  |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [productnumber](#productnumber) | eq | GEDF |
| [productnumber](#productnumber) | eq | GEDP |
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [azt_softwareproductid](#azt_softwareproductid) | eq | {19FB685E-D0BF-E411-80C7-00155D0ABD03} |
| [azt_softwareproductid](#azt_softwareproductid) | eq | {D79C00D6-05DE-E411-80D0-00155D0ABD03} |
| [azt_accountid](#azt_accountid) | null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.15. GED/KaplanGED Customers Without Flash

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_accounttype](#azt_accounttype) | 125px |
| 3 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 4 | [telephone1](#telephone1) | 100px |
| 5 | [address1_city](#address1_city) | 125px |
| 6 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 7 | [ownerid](#ownerid) | 150px |
| 8 | [azt_softwarelicenseid](#azt_softwarelicenseid) |  |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [productnumber](#productnumber) | eq | GED-P |
| [productnumber](#productnumber) | eq | K-GED-P |
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [azt_softwareproductid](#azt_softwareproductid) | eq | {270C7C1D-2734-E811-815F-00155D0ABD09} |
| [azt_accountid](#azt_accountid) | null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.16. HiSET Customers Without Kaplan HiSET

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_accounttype](#azt_accounttype) | 125px |
| 3 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 4 | [telephone1](#telephone1) | 100px |
| 5 | [address1_city](#address1_city) | 125px |
| 6 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 7 | [ownerid](#ownerid) | 150px |
| 8 | [azt_softwarelicenseid](#azt_softwarelicenseid) |  |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [productnumber](#productnumber) | eq | HiSET-P |
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [azt_softwareproductid](#azt_softwareproductid) | eq | {42F17A3A-06DE-E411-80D0-00155D0ABD03} |
| [azt_accountid](#azt_accountid) | null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.17. Inactive Accounts

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [telephone1](#telephone1) | 100px |
| 3 | [address1_city](#address1_city) | 100px |
| 4 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.18. My Active Accounts

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 3 | [telephone1](#telephone1) | 100px |
| 4 | [address1_city](#address1_city) | 125px |
| 5 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 6 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#azt_recordownerid) | eq-userid |  |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.19. My Active Customers With Purchase Dates

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 200px |
| 2 | [accountclassificationcode](#accountclassificationcode) | 150px |
| 3 | [azt_lastprintpurchase](#azt_lastprintpurchase) | 125px |
| 4 | [azt_lastsaaspurchase](#azt_lastsaaspurchase) | 125px |
| 5 | [azt_lastactivitydate](#azt_lastactivitydate) | 125px |
| 6 | [telephone1](#telephone1) | 150px |
| 7 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 8 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_lastprintpurchase](#azt_lastprintpurchase) | not-null |  |
| [azt_lastsaaspurchase](#azt_lastsaaspurchase) | not-null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.20. My Connections

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [telephone1](#telephone1) | 100px |
| 3 | [address1_city](#address1_city) | 100px |
| 4 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [record1id](#record1id) | eq-userid |  |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.21. New Customer Introduction List

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 200px |
| 2 | [accountclassificationcode](#accountclassificationcode) | 150px |
| 3 | [azt_lastprintpurchase](#azt_lastprintpurchase) | 125px |
| 4 | [azt_lastsaaspurchase](#azt_lastsaaspurchase) | 125px |
| 5 | [azt_lastactivitydate](#azt_lastactivitydate) | 125px |
| 6 | [telephone1](#telephone1) | 125px |
| 7 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 8 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_customerintroductioncompleted](#azt_customerintroductioncompleted) | ne | 1 |
| [azt_lastprintpurchase](#azt_lastprintpurchase) | on-or-after | 2020-01-18 |
| [azt_lastsaaspurchase](#azt_lastsaaspurchase) | on-or-after | 2020-07-18 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.22. Old Duplicate Accounts View

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 200px |
| 2 | [azt_accounttype](#azt_accounttype) | 150px |
| 3 | [parentaccountid](#parentaccountid) | 150px |
| 4 | [address1_city](#address1_city) | 150px |
| 5 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 6 | [ownerid](#ownerid) | 150px |
| 7 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_isduplicate](#azt_isduplicate) | eq | 1 |
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.23. Quick Find Active Accounts

- **Type:** Quick Find (querytype=4)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_customernumber](#azt_customernumber) | 125px |
| 3 | [address1_city](#address1_city) | 125px |
| 4 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 5 | [azt_accounttype](#azt_accounttype) | 100px |
| 6 | [telephone1](#telephone1) | 100px |
| 7 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 8 | [ownerid](#ownerid) | 150px |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [telephone1](#telephone1) | like | {0} |
| [azt_customernumber](#azt_customernumber) | like | {0} |
| [azt_accounttype](#azt_accounttype) | like | {0} |
| [name](#name) | like | {0} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

### 3.24. TASC Customers Without Kaplan TASC

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#name) | 300px |
| 2 | [azt_accounttype](#azt_accounttype) | 125px |
| 3 | [accountclassificationcode](#accountclassificationcode) | 100px |
| 4 | [telephone1](#telephone1) | 100px |
| 5 | [address1_city](#address1_city) | 125px |
| 6 | [address1_stateorprovince](#address1_stateorprovince) | 150px |
| 7 | [ownerid](#ownerid) | 150px |
| 8 | [azt_softwarelicenseid](#azt_softwarelicenseid) |  |
| 9 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [productnumber](#productnumber) | eq | TASC-P |
| [azt_licensestatus](#azt_licensestatus) | eq | 276530000 |
| [azt_softwareproductid](#azt_softwareproductid) | eq | {0660437F-06DE-E411-80D0-00155D0ABD03} |
| [azt_accountid](#azt_accountid) | null |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#name) | Ascending |

---

## 4. Chart Visualizations

Total charts: **0**

---

## 5. Reports

Total reports referencing Account: **2**

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

### 5.2. SharedAccountRecords

- **File:** `SharedAccountRecordsrdl8302bffa-7478-ee11-8179-000d3a993b8f`
- **DataSets:** 1

#### DataSet: Users

**Parameters:** CRM_FilteredUser

**Primary Entity:** `systemuser`

**Selected Fields:**

- [fullname](#fullname)

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [objecttypecode](#objecttypecode) | eq | 1 |
| [accessrightsmask](#accessrightsmask) | ne | 0 |

**Link Entity:** `principalobjectaccess` (alias: `Share`, type: inner, from: `principalid` to: `systemuserid`)

Fields:

- [objecttypecode](#objecttypecode) *(via principalobjectaccess)*
- [objectid](#objectid) *(via principalobjectaccess)*
- [accessrightsmask](#accessrightsmask) *(via principalobjectaccess)*
- [changedon](#changedon) *(via principalobjectaccess)*

Conditions:

| Field | Operator | Value |
|-------|----------|-------|
| [objecttypecode](#objecttypecode) | eq | 1 |
| [accessrightsmask](#accessrightsmask) | ne | 0 |

Sort:

- [objecttypecode](#objecttypecode) Ascending

  **Link Entity:** `account` (alias: `Acct`, type: inner, from: `accountid` to: `objectid`)

  Fields:

  - [accountid](#accountid) *(via account)*
  - [name](#name) *(via account)*
  - [azt_recordownerid](#azt_recordownerid) *(via account)*
  - [ownerid](#ownerid) *(via account)*

**Report Field Mappings:**

| Report Field | Data Field |
|-------------|------------|
| fullname | fullname |
| Share_objecttypecode | Share_objecttypecode |
| Share_objectid | Share_objectid |
| Share_accessrightsmask | Share_accessrightsmask |
| Share_accessrightsmaskValue | Share_accessrightsmaskValue |
| Share_changedon | Share_changedon |
| Share_changedonValue | Share_changedonValue |
| Acct_accountid | Acct_accountid |
| Acct_name | Acct_name |
| Acct_azt_recordownerid | Acct_azt_recordownerid |
| Acct_azt_recordowneridValue | Acct_azt_recordowneridValue |
| Acct_azt_recordowneridEntityName | Acct_azt_recordowneridEntityName |
| Acct_ownerid | Acct_ownerid |
| Acct_owneridValue | Acct_owneridValue |
| Acct_owneridEntityName | Acct_owneridEntityName |

---

## 6. Dashboards

Total dashboards referencing Account: **0**

---

## 7. Workflows

Total workflows referencing Account: **68**

### 7.1. 0ChangeQuoteRecordOwner

- **File:** `0ChangeQuoteRecordOwner-938FE262-FF96-42CB-8332-50B6A947A533.xaml`
- **Entity References:** account
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.2. 0EngagementNames

- **File:** `0EngagementNames-BC419DA7-86F1-43E4-88B5-509514704A0C.xaml`
- **Entity References:** account
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#name)

### 7.3. AccountAuto-Assign

- **File:** `AccountAuto-Assign-6DE252A4-C0D8-4C6B-800E-3985440C88D1.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Read:**

- [address1_country](#address1_country)
- [address1_stateorprovince](#address1_stateorprovince)
- [azt_excludefromautoassign](#azt_excludefromautoassign)
- [createdby](#createdby)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`

### 7.4. AccountClearCustomerIntro

- **File:** `AccountClearCustomerIntro-A1FC9E6A-CD0C-473A-88A7-45E3CDA7C245.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Written:**

- [azt_customerintrocompletedby](#azt_customerintrocompletedby)
- [azt_customerintrocompletedon](#azt_customerintrocompletedon)
- [azt_customerintroductioncompleted](#azt_customerintroductioncompleted)

### 7.5. AllocationsAssigntoTeam

- **File:** `AllocationsAssigntoTeam-B7D19816-C216-4C9D-81B7-9FE73CB2D066.xaml`
- **Entity References:** account
- **Primary Entity:** azt_allocatedlicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.6. AppointmentAuto-Assign

- **File:** `AppointmentAuto-Assign-1A553A9D-514D-42CA-A9AE-73FEED04E1E5.xaml`
- **Entity References:** account
- **Primary Entity:** Appointment

**Fields Read:**

- [accountid](#accountid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.7. BatchConverttoLead

- **File:** `BatchConverttoLead-CC0F2DBB-B8CB-4B06-B891-DB6D97252DB8.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [accountid](#accountid)
- [name](#name)

**Fields Written:**

- [address1_addresstypecode](#address1_addresstypecode)
- [address1_shippingmethodcode](#address1_shippingmethodcode)
- [address2_addresstypecode](#address2_addresstypecode)
- [address2_shippingmethodcode](#address2_shippingmethodcode)
- [azt_leadsourceid](#azt_leadsourceid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [statecode](#statecode)

### 7.8. BatchCreateEngagements

- **File:** `BatchCreateEngagements-CC9CDFC6-4BC9-4635-B786-0C7BE2C34344.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Read:**

- [accountid](#accountid)
- [name](#name)

**Fields Written:**

- [azt_executivesummary](#azt_executivesummary)
- [azt_recordownerid](#azt_recordownerid)

### 7.9. BatchCreateIntroCall

- **File:** `BatchCreateIntroCall-F45065DE-1A7E-487C-A3CA-CB5CE209B242.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Read:**

- [accountid](#accountid)

### 7.10. BatchLooseOpportunities

- **File:** `BatchLooseOpportunities-BFF14F2D-338D-4CBD-B2CE-C0907E02E6C7.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

### 7.11. BatchOpportunityTransfer

- **File:** `BatchOpportunityTransfer-744FEB80-2251-4252-875E-ED9958CB448A.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.12. BulkChangeLeadSource

- **File:** `BulkChangeLeadSource-95E84234-8EE8-433E-B68A-78A0837A91CE.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)

### 7.13. CasePendingAssignmentNotification

- **File:** `CasePendingAssignmentNotification-177DE8B3-E0C3-4F1C-A7B5-DA84B3629AED.xaml`
- **Entity References:** account
- **Primary Entity:** Incident

**Fields Read:**

- [ownerid](#ownerid)

### 7.14. CaseRecordOwner

- **File:** `CaseRecordOwner-E2135799-C146-4E0B-A0A5-F9917895B23E.xaml`
- **Entity References:** account
- **Primary Entity:** Incident

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.15. CaseRecordOwnerAssign

- **File:** `CaseRecordOwnerAssign-02EE1A9D-1658-4013-BF63-9C0E5C65AAD0.xaml`
- **Entity References:** account
- **Primary Entity:** Incident

**Fields Read:**

- [owningteam](#owningteam)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.16. CaseRecordOwnerAssignmentNotification

- **File:** `CaseRecordOwnerAssignmentNotification-2F6035E6-1FBC-476B-9C97-4554E8360B7C.xaml`
- **Entity References:** account
- **Primary Entity:** Incident

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.17. CaseResolutionNotificationEmail

- **File:** `CaseResolutionNotificationEmail-734E721F-7454-4437-8BAC-8B20F496DF12.xaml`
- **Entity References:** account
- **Primary Entity:** Incident

**Fields Read:**

- [statecode](#statecode)

### 7.18. CloneAndDeleteQuote

- **File:** `CloneAndDeleteQuote-1D87A694-5A08-4C93-9925-447BB4FE7DA6.xaml`
- **Entity References:** account
- **Primary Entity:** Quote

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_historicalowner](#azt_historicalowner)
- [ownerid](#ownerid)

### 7.19. CloneCommissionPayment

- **File:** `CloneCommissionPayment-7E83F6F0-D101-4045-B686-0B6C658CC9A2.xaml`
- **Entity References:** account
- **Primary Entity:** azt_commissionpayment

**Fields Written:**

- [ownerid](#ownerid)

### 7.20. CloneLicense

- **File:** `CloneLicense-49354120-2D2D-4DED-8C24-4ACA5F6D82D9.xaml`
- **Entity References:** account
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.21. CloneOpportunity

- **File:** `CloneOpportunity-1A3FF4B3-79FD-420C-8A10-375E8892CA44.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#name)

**Fields Written:**

- [azt_historicalowner](#azt_historicalowner)
- [azt_recordownerid](#azt_recordownerid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

### 7.22. CloneOrder

- **File:** `CloneOrder-D2A6AD48-A603-4150-BC84-72092AFB3D79.xaml`
- **Entity References:** account
- **Primary Entity:** SalesOrder

**Fields Read:**

- [name](#name)

**Fields Written:**

- [statecode](#statecode)

### 7.23. ContactAuto-Assign

- **File:** `ContactAuto-Assign-25759C22-AE58-4CC7-81E1-9BBF37E76F3E.xaml`
- **Entity References:** account
- **Primary Entity:** Contact

**Fields Read:**

- [address1_stateorprovince](#address1_stateorprovince)
- [azt_excludefromautoassign](#azt_excludefromautoassign)
- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`
- `AztecPlugins.GetAcctTeamOwned`

### 7.24. ContactMapAddresses

- **File:** `ContactMapAddresses-E83A0E4F-F6B0-401F-AE31-F05DA5B89206.xaml`
- **Entity References:** account
- **Primary Entity:** Contact

**Fields Read:**

- [address1_city](#address1_city)
- [address1_county](#address1_county)
- [address1_line1](#address1_line1)
- [address1_line2](#address1_line2)
- [address1_postalcode](#address1_postalcode)
- [address1_stateorprovince](#address1_stateorprovince)

**Fields Written:**

- [address2_country](#address2_country)
- [address2_county](#address2_county)

### 7.25. CreateLeadFromLeadGen

- **File:** `CreateLeadFromLeadGen-2EA14729-4B62-4F91-95FA-76D258DA0831.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Read:**

- [accountid](#accountid)
- [address1_city](#address1_city)
- [address1_country](#address1_country)
- [address1_postalcode](#address1_postalcode)
- [address1_stateorprovince](#address1_stateorprovince)
- [azt_accountleadgenname](#azt_accountleadgenname)
- [azt_verticalmarket](#azt_verticalmarket)
- [name](#name)
- [primarycontactid](#primarycontactid)

**Fields Written:**

- [address1_addresstypecode](#address1_addresstypecode)
- [address1_shippingmethodcode](#address1_shippingmethodcode)
- [address2_addresstypecode](#address2_addresstypecode)
- [address2_shippingmethodcode](#address2_shippingmethodcode)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [statecode](#statecode)

### 7.26. CreateLeadfromAccount

- **File:** `CreateLeadfromAccount-B5E04C1C-B038-4018-B602-645B1E766884.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Read:**

- [accountid](#accountid)
- [address1_city](#address1_city)
- [address1_stateorprovince](#address1_stateorprovince)
- [azt_verticalmarket](#azt_verticalmarket)
- [name](#name)
- [primarycontactid](#primarycontactid)

**Fields Written:**

- [address1_addresstypecode](#address1_addresstypecode)
- [address1_shippingmethodcode](#address1_shippingmethodcode)
- [address2_addresstypecode](#address2_addresstypecode)
- [address2_shippingmethodcode](#address2_shippingmethodcode)
- [azt_leadsourceid](#azt_leadsourceid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)
- [statecode](#statecode)

### 7.27. CustomLeadCreation

- **File:** `CustomLeadCreation-B26AC2BB-4660-4A50-9229-AD056DE0D9E1.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [address1_stateorprovince](#address1_stateorprovince)
- [name](#name)

**Fields Written:**

- [address1_addresstypecode](#address1_addresstypecode)
- [address1_shippingmethodcode](#address1_shippingmethodcode)
- [address2_addresstypecode](#address2_addresstypecode)
- [address2_shippingmethodcode](#address2_shippingmethodcode)
- [azt_leadsourceid](#azt_leadsourceid)
- [parentaccountid](#parentaccountid)
- [statecode](#statecode)

### 7.28. EngagementRecordOwner

- **File:** `EngagementRecordOwner-00BE88CF-37E2-46ED-951B-A553329BC127.xaml`
- **Entity References:** account
- **Primary Entity:** azt_engagement

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.29. EngagementRecordOwnerTeam

- **File:** `EngagementRecordOwnerTeam-190EE5B4-5775-4B9D-BFD7-FB769C19977A.xaml`
- **Entity References:** account
- **Primary Entity:** azt_engagement

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.30. FSRLeadDistibutionNotification

- **File:** `FSRLeadDistibutionNotification-2D276CE9-54BF-4703-A56C-933E5C57F3C7.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Read:**

- [address1_stateorprovince](#address1_stateorprovince)

**Fields Written:**

- [ownerid](#ownerid)

### 7.31. InvoiceRecordOwner

- **File:** `InvoiceRecordOwner-C59ED476-F5C4-47B7-BD33-E88881D2B5EE.xaml`
- **Entity References:** account
- **Primary Entity:** Invoice

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.32. LeadAssignment

- **File:** `LeadAssignment-5FC23C73-5B6B-423C-8721-57EDA4553E31.xaml`
- **Entity References:** account
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

### 7.33. LeadQualifyDisqualifyDate

- **File:** `LeadQualifyDisqualifyDate-4DF6EBF4-0F22-4433-AB4F-A241C91F8B5A.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Read:**

- [statecode](#statecode)

### 7.34. LeadSourceChange

- **File:** `LeadSourceChange-2F1F8085-9B50-4FE8-A756-20DAF80158A8.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Written:**

- [azt_leadsourceid](#azt_leadsourceid)

### 7.35. MarkAccountsExcludefromAuto-assign

- **File:** `MarkAccountsExcludefromAuto-assign-C61F6CB6-75C5-40F1-849D-66E38D81E06C.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Written:**

- [azt_excludefromautoassign](#azt_excludefromautoassign)

### 7.36. NewFSRLeadNotification

- **File:** `NewFSRLeadNotification-53E6AF89-E489-4977-8D9F-1579FF72FAC5.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Read:**

- [address1_stateorprovince](#address1_stateorprovince)
- [name](#name)

### 7.37. OpportunityAuditRemoval

- **File:** `OpportunityAuditRemoval-DB05BF90-221B-4B58-8AA0-D1A0799EA0A1.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [statecode](#statecode)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.OppAuditRemoval`

### 7.38. OpportunityRecordOwner

- **File:** `OpportunityRecordOwner-B0889237-722A-47CC-B102-D507B14FED98.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.39. OpportunityRecordOwnerTeam

- **File:** `OpportunityRecordOwnerTeam-7F60084D-807B-43D1-ACED-B0CC90F02F02.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.40. OrderRecordOwner

- **File:** `OrderRecordOwner-701C3E67-4733-423C-BC31-5C846B542B76.xaml`
- **Entity References:** account
- **Primary Entity:** SalesOrder

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.41. PhonecallAuto-Assign

- **File:** `PhonecallAuto-Assign-D7FD43A4-5AFF-4929-BD37-A1917C4F2391.xaml`
- **Entity References:** account
- **Primary Entity:** PhoneCall

**Fields Read:**

- [accountid](#accountid)
- [address1_stateorprovince](#address1_stateorprovince)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.42. PrintPurchaseAssigntoTeam

- **File:** `PrintPurchaseAssigntoTeam-9620B3F1-4852-4FFA-8FA7-09615D8CCAFD.xaml`
- **Entity References:** account
- **Primary Entity:** azt_printpurchase

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.43. QualifyLead

- **File:** `QualifyLead-F6899272-F476-48C4-B703-D5ACDD9EDFF7.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Written:**

- [name](#name)
- [parentaccountid](#parentaccountid)

### 7.44. QuoteRecordOwner

- **File:** `QuoteRecordOwner-C5266A8C-E23D-41C4-B51F-3A637538DDBF.xaml`
- **Entity References:** account
- **Primary Entity:** Quote

**Fields Read:**

- [ownerid](#ownerid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.45. QuoteRecordOwnerTeam

- **File:** `QuoteRecordOwnerTeam-7ACFAD91-65CC-4C8D-8A3E-673373DEA880.xaml`
- **Entity References:** account
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.46. RenameEngagements

- **File:** `RenameEngagements-9D4DC906-B3F2-498A-AC17-7D302597E96C.xaml`
- **Entity References:** account
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#name)

### 7.47. SendQuote

- **File:** `SendQuote-FF6FE214-20D6-4541-AEC6-BD5D18258481.xaml`
- **Entity References:** account
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)

### 7.48. SetBusinessAddressNameField

- **File:** `SetBusinessAddressNameField-EA86DE66-A018-EB11-A813-000D3A303954.xaml`
- **Entity References:** account
- **Trigger Scope:** Form
- **Trigger Form ID:** `{8448b78f-8f42-454e-8e2a-f8196b0419af}`
- **Primary Entity:** Account

**Fields Read:**

- [address2_name](#address2_name)

**Fields Written:**

- [address2_name](#address2_name)

### 7.49. SetLeadTemperature

- **File:** `SetLeadTemperature-91BC905B-86CD-4317-BC84-E50EE444C775.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Read:**

- [azt_leadsourceid](#azt_leadsourceid)

### 7.50. SetPhysicalAddressNameField

- **File:** `SetPhysicalAddressNameField-FBA89CF2-9F18-EB11-A813-000D3A303954.xaml`
- **Entity References:** account
- **Trigger Scope:** Form
- **Trigger Form ID:** `{8448b78f-8f42-454e-8e2a-f8196b0419af}`
- **Primary Entity:** Account

**Fields Read:**

- [address1_name](#address1_name)

**Fields Written:**

- [address1_name](#address1_name)

### 7.51. SoftwareLicenseAssigntoTeam

- **File:** `SoftwareLicenseAssigntoTeam-2CFFBE82-9E25-47FD-A201-E6DB0C220DDE.xaml`
- **Entity References:** account
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.52. SoftwareLicenseCreateEngagement

- **File:** `SoftwareLicenseCreateEngagement-ABFE722A-CAC3-4A3B-AF5C-419EA2CE9CBD.xaml`
- **Entity References:** account
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [address1_stateorprovince](#address1_stateorprovince)

**Fields Written:**

- [azt_executivesummary](#azt_executivesummary)

### 7.53. SoftwareLicenseSetOwner

- **File:** `SoftwareLicenseSetOwner-438596B2-A87C-4F1E-AC53-3B3197DEF67C.xaml`
- **Entity References:** account
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.54. TaskAuto-Assign

- **File:** `TaskAuto-Assign-89E60667-3F7F-4ADD-8274-57C2BE011059.xaml`
- **Entity References:** account
- **Primary Entity:** Task

**Fields Read:**

- [accountid](#accountid)
- [ownerid](#ownerid)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.55. TaskCreateReorderLead

- **File:** `TaskCreateReorderLead-3193EB56-8E56-46A3-B079-A7CFD1CE90B7.xaml`
- **Entity References:** account
- **Primary Entity:** Task

**Fields Read:**

- [name](#name)
- [parentaccountid](#parentaccountid)

**Fields Written:**

- [address1_addresstypecode](#address1_addresstypecode)
- [address1_shippingmethodcode](#address1_shippingmethodcode)
- [address2_addresstypecode](#address2_addresstypecode)
- [address2_shippingmethodcode](#address2_shippingmethodcode)
- [azt_leadsourceid](#azt_leadsourceid)
- [azt_recordownerid](#azt_recordownerid)
- [ownerid](#ownerid)
- [statecode](#statecode)

### 7.56. WonOpportunityEmail

- **File:** `WonOpportunityEmail-DB2872A0-18C2-4157-B6BD-480230C97D32.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#azt_recordownerid)
- [name](#name)
- [statecode](#statecode)

### 7.57. WorkforceAccountAuto-assign

- **File:** `WorkforceAccountAuto-assign-1AD2C544-E6F9-4FC7-AA17-810AEB8939C2.xaml`
- **Entity References:** account
- **Primary Entity:** Account

**Fields Read:**

- [createdby](#createdby)

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.58. WorkforceAppointmentAuto-Assign

- **File:** `WorkforceAppointmentAuto-Assign-803829FB-077B-4F0B-B238-105814F5B202.xaml`
- **Entity References:** account
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.59. WorkforceCaseAuto-assign

- **File:** `WorkforceCaseAuto-assign-24BA0A9C-F8BD-45CB-A5F6-6DCE42CD998F.xaml`
- **Entity References:** account
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.60. WorkforceContactAuto-assign

- **File:** `WorkforceContactAuto-assign-65B65E23-A8F5-46DB-A35A-C5DC8542B6AE.xaml`
- **Entity References:** account
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.61. WorkforceEngagementAuto-assign

- **File:** `WorkforceEngagementAuto-assign-DA5CDD7F-2A3B-4A0A-861D-75305D10254E.xaml`
- **Entity References:** account
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.62. WorkforceLeadAuto-Assign

- **File:** `WorkforceLeadAuto-Assign-E5A4054C-5F7E-478C-87E3-529C1EEAB0DC.xaml`
- **Entity References:** account
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.63. WorkforceOpportunityAuto-assign

- **File:** `WorkforceOpportunityAuto-assign-7D379FBE-C672-41EB-90A3-A80451C62533.xaml`
- **Entity References:** account
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.64. WorkforcePhone-callAuto-assign

- **File:** `WorkforcePhone-callAuto-assign-BE1CB211-7C3C-4E39-8913-2DFCE7EDFC85.xaml`
- **Entity References:** account
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.65. WorkforceQuoteAuto-assign

- **File:** `WorkforceQuoteAuto-assign-E64BB2BB-5CD6-4327-AB1B-BF8C9D4D2385.xaml`
- **Entity References:** account
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.66. iGradAppointmentAuto-Assign

- **File:** `iGradAppointmentAuto-Assign-CE88A0C4-AA60-44F4-B33D-B57FB8279CCF.xaml`
- **Entity References:** account
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.67. iGradCaseAuto-Assign

- **File:** `iGradCaseAuto-Assign-CAF5021E-07E1-4689-92D5-FC59E9F30F78.xaml`
- **Entity References:** account
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

### 7.68. iGradPhone-callAuto-assign

- **File:** `iGradPhone-callAuto-assign-04423D55-3225-429E-BAC6-8DD37BC53F1B.xaml`
- **Entity References:** account
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#azt_recordownerid)

---

## 8. JavaScript Web Resources

Total JS files referencing Account fields: **15**

### 8.1. azt_FindAccountsWithinBoundModified

- **File:** `azt_FindAccountsWithinBoundModified937711DC-D189-E911-A864-000D3A37207B`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [azt_accounttype](#azt_accounttype) | Yes |  |  |

### 8.2. azt_accountlibrary

- **File:** `azt_accountlibraryF30D2BCC-3AFA-E811-A983-000D3A1A9151`

**Per-Function Field Usage:**

`accountAlert`:

| Field | Operations |
|-------|-----------|
| [azt_accountalert](#azt_accountalert) | read |

`createLead`:

| Field | Operations |
|-------|-----------|
| [address1_stateorprovince](#address1_stateorprovince) | read |
| [name](#name) | read |

`createNewLead`:

| Field | Operations |
|-------|-----------|
| [name](#name) | read |

`formatMe`:

| Field | Operations |
|-------|-----------|
| [telephone1](#telephone1) | write |

`formatNumber`:

| Field | Operations |
|-------|-----------|
| [telephone1](#telephone1) | access |

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_customerintrocompletedby](#azt_customerintrocompletedby) | UI |
| [azt_customerintrocompletedon](#azt_customerintrocompletedon) | UI |
| [azt_excludefromautoassign](#azt_excludefromautoassign) | UI |

`parentAccountSpend`:

| Field | Operations |
|-------|-----------|
| [azt_accountspend](#azt_accountspend) | UI |
| [azt_parentaccountspend](#azt_parentaccountspend) | UI |
| [parentaccountid](#parentaccountid) | read, UI |

`setBillAddressName`:

| Field | Operations |
|-------|-----------|
| [address2_addresstypecode](#address2_addresstypecode) | read |
| [address2_name](#address2_name) | write |

`setCustIntroCompletedBy`:

| Field | Operations |
|-------|-----------|
| [azt_customerintrocompletedby](#azt_customerintrocompletedby) | write |
| [azt_customerintrocompletedon](#azt_customerintrocompletedon) | write |
| [azt_customerintroductioncompleted](#azt_customerintroductioncompleted) | read |

`setNonIgradVerticalMarket`:

| Field | Operations |
|-------|-----------|
| [azt_verticalmarket](#azt_verticalmarket) | UI |

`setPrimAddressName`:

| Field | Operations |
|-------|-----------|
| [address1_addresstypecode](#address1_addresstypecode) | read |
| [address1_name](#address1_name) | write |

`setiGradVerticalMarket`:

| Field | Operations |
|-------|-----------|
| [azt_verticalmarket](#azt_verticalmarket) | UI |

### 8.3. azt_addresslibrary

- **File:** `azt_addresslibrary34ACDB9B-C570-EB11-A812-00224809A7CD`

**Per-Function Field Usage:**

`addAddress`:

| Field | Operations |
|-------|-----------|
| [address1_city](#address1_city) | read |
| [address1_country](#address1_country) | read |
| [address1_line1](#address1_line1) | read |
| [address1_line2](#address1_line2) | read |
| [address1_postalcode](#address1_postalcode) | read |
| [address1_stateorprovince](#address1_stateorprovince) | read |
| [name](#name) | read |

### 8.4. azt_caselibrary

- **File:** `azt_caselibraryD1BC3A04-FA9F-EC11-B400-00224824F1A0`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.5. azt_contactlibrary

- **File:** `azt_contactlibrary7B2881FE-42FA-E811-A983-000D3A1A9151`

**Per-Function Field Usage:**

`setAddressName`:

| Field | Operations |
|-------|-----------|
| [address1_addresstypecode](#address1_addresstypecode) | read, write |
| [address1_name](#address1_name) | write |

### 8.6. azt_engagementlibrary

- **File:** `azt_engagementlibraryE672CD7D-C50C-E911-A97C-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

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

### 8.9. azt_opportunitylibrary

- **File:** `azt_opportunitylibrary43000452-0710-E911-A980-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.10. azt_opportunitytrackdiscount

- **File:** `azt_opportunitytrackdiscount8AAC767D-5D0E-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`trackDiscount`:

| Field | Operations |
|-------|-----------|
| [name](#name) | read |

### 8.11. azt_orderlibrary

- **File:** `azt_orderlibrary2892D28D-D5C4-EB11-BACC-00224809B8F2`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#azt_recordownerid) | UI |

### 8.12. azt_phonecalllibrary

- **File:** `azt_phonecalllibrary521EF713-0F0C-E911-A976-000D3A1A941E`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [telephone1](#telephone1) | read (WebApi) |

### 8.13. azt_productdiscountlibrary

- **File:** `azt_productdiscountlibraryBF6468B0-3230-E911-A950-000D3A3B9CD8`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [ownerid](#ownerid) | Yes |  |  |

### 8.14. azt_quotelibrary

- **File:** `azt_quotelibrary117BF74F-580A-E911-A983-000D3A1A9151`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [azt_recordownerid](#azt_recordownerid) |  |  | Yes |

### 8.15. azt_sendquote

- **File:** `azt_sendquote0A31A45C-E217-E911-A97D-000D3A1A9FA9`

**Field References:**

| Field | Read | Write | Control |
|-------|------|-------|---------|
| [name](#name) | Yes |  |  |

---

## 9. Formulas & Rollups

Total formulas for Account: **4**

### azt_accountspend

- **File:** `account-azt_accountspend.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunity

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | account |
| [rolluprulestep1_2](#rolluprulestep1_2) | account |
| [rolluprulestep1_3](#rolluprulestep1_3) | account |
| statecode | opportunity |
| [rolluprulestep1_4](#rolluprulestep1_4) | account |
| [rolluprulestep1_5](#rolluprulestep1_5) | account |
| actualvalue | opportunity |

### azt_lastyearspend

- **File:** `account-azt_lastyearspend.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunity

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | account |
| [rolluprulestep1_2](#rolluprulestep1_2) | account |
| [rolluprulestep1_3](#rolluprulestep1_3) | account |
| [rolluprulestep1_4](#rolluprulestep1_4) | account |
| [rolluprulestep1_5](#rolluprulestep1_5) | account |
| [rolluprulestep1_6](#rolluprulestep1_6) | account |
| [rolluprulestep1_7](#rolluprulestep1_7) | account |
| [rolluprulestep1_8](#rolluprulestep1_8) | account |
| [rolluprulestep1_9](#rolluprulestep1_9) | account |
| [rolluprulestep1_10](#rolluprulestep1_10) | account |
| [rolluprulestep1_11](#rolluprulestep1_11) | account |
| statecode | opportunity |
| actualclosedate | opportunity |
| actualclosedate | opportunity |
| [rolluprulestep1_12](#rolluprulestep1_12) | account |
| [rolluprulestep1_13](#rolluprulestep1_13) | account |
| actualvalue | opportunity |

### azt_yearbeforelastspend

- **File:** `account-azt_yearbeforelastspend.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunityclose

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | account |
| [rolluprulestep1_2](#rolluprulestep1_2) | account |
| [rolluprulestep1_3](#rolluprulestep1_3) | account |
| [rolluprulestep1_4](#rolluprulestep1_4) | account |
| [rolluprulestep1_5](#rolluprulestep1_5) | account |
| [rolluprulestep1_6](#rolluprulestep1_6) | account |
| [rolluprulestep1_7](#rolluprulestep1_7) | account |
| actualend | opportunityclose |
| actualend | opportunityclose |
| [rolluprulestep1_8](#rolluprulestep1_8) | account |
| [rolluprulestep1_9](#rolluprulestep1_9) | account |
| actualrevenue | opportunityclose |

### azt_ytdspend

- **File:** `account-azt_ytdspend.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** opportunity

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#rolluprulestep1_1) | account |
| [rolluprulestep1_2](#rolluprulestep1_2) | account |
| [rolluprulestep1_3](#rolluprulestep1_3) | account |
| [rolluprulestep1_4](#rolluprulestep1_4) | account |
| [rolluprulestep1_5](#rolluprulestep1_5) | account |
| [rolluprulestep1_6](#rolluprulestep1_6) | account |
| [rolluprulestep1_7](#rolluprulestep1_7) | account |
| statecode | opportunity |
| actualclosedate | opportunity |
| [rolluprulestep1_8](#rolluprulestep1_8) | account |
| [rolluprulestep1_9](#rolluprulestep1_9) | account |
| actualvalue | opportunity |

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

Total relationships involving Account: **43**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| Account_Annotation | 1:N | Account | Annotation | [ObjectId](#objectid) |
| Account_Appointments | 1:N | Account | Appointment | [RegardingObjectId](#regardingobjectid) |
| Account_CustomerAddress | 1:N | Account | CustomerAddress | [ParentId](#parentid) |
| Account_Emails | 1:N | Account | Email | [RegardingObjectId](#regardingobjectid) |
| Account_Letters | 1:N | Account | Letter | [RegardingObjectId](#regardingobjectid) |
| Account_Phonecalls | 1:N | Account | PhoneCall | [RegardingObjectId](#regardingobjectid) |
| Account_Tasks | 1:N | Account | Task | [RegardingObjectId](#regardingobjectid) |
| account_OpportunityCloses | 1:N | Account | OpportunityClose | [RegardingObjectId](#regardingobjectid) |
| account_OrderCloses | 1:N | Account | OrderClose | [RegardingObjectId](#regardingobjectid) |
| account_QuoteCloses | 1:N | Account | QuoteClose | [RegardingObjectId](#regardingobjectid) |
| account_originating_lead | N:1 | Lead | Account | [OriginatingLeadId](#originatingleadid) |
| account_parent_account | 1:N | Account | Account | [ParentAccountId](#parentaccountid) |
| azt_Funding_Account_Account | 1:N | Account | azt_Funding | [azt_Account](#azt_account) |
| azt_account_account | 1:N | Account | Account | [azt_PossibleMatchId](#azt_possiblematchid) |
| azt_account_azt_allocatedlicense | 1:N | Account | azt_allocatedlicense | [azt_CustomerId](#azt_customerid) |
| azt_account_azt_customertraining | 1:N | Account | azt_customertraining | [azt_AccountId](#azt_accountid) |
| azt_account_azt_engagement | 1:N | Account | azt_engagement | [azt_AccountId](#azt_accountid) |
| azt_account_azt_expense | 1:N | Account | azt_expense | [azt_CustomerId](#azt_customerid) |
| azt_account_azt_preview | 1:N | Account | azt_preview | [azt_AccountId](#azt_accountid) |
| azt_account_azt_printpurchase | 1:N | Account | azt_printpurchase | [azt_CustomerId](#azt_customerid) |
| azt_account_azt_productdiscount | 1:N | Account | azt_productdiscount | [azt_CustomerId](#azt_customerid) |
| azt_account_azt_softwarelicense | 1:N | Account | azt_softwarelicense | [azt_AccountId](#azt_accountid) |
| azt_account_azt_training | 1:N | Account | azt_training | [azt_AccountId](#azt_accountid) |
| azt_allocatedaccount_azt_allocatedlicense | 1:N | Account | azt_allocatedlicense | [azt_AllocatedToId](#azt_allocatedtoid) |
| azt_azt_leadsource_account | N:1 | azt_leadsource | Account | [azt_LeadSourceId](#azt_leadsourceid) |
| azt_parentaccount_azt_softwarelicense | 1:N | Account | azt_softwarelicense | [azt_ParentAccountId](#azt_parentaccountid) |
| azt_systemuser_account | N:1 | SystemUser | Account | [azt_RecordOwnerId](#azt_recordownerid) |
| contact_customer_accounts | 1:N | Account | Contact | [ParentCustomerId](#parentcustomerid) |
| incident_customer_accounts | 1:N | Account | Incident | [CustomerId](#customerid) |
| invoice_customer_accounts | 1:N | Account | Invoice | [CustomerId](#customerid) |
| lead_customer_accounts | 1:N | Account | Lead | [CustomerId](#customerid) |
| msa_account_incident | 1:N | Account | Incident | [msa_partnerid](#msa_partnerid) |
| msa_account_managingpartner | 1:N | Account | Account | [msa_managingpartnerid](#msa_managingpartnerid) |
| msa_contact_managingpartner | 1:N | Account | Contact | [msa_managingpartnerid](#msa_managingpartnerid) |
| msa_partner_opportunity | 1:N | Account | Opportunity | [msa_partnerid](#msa_partnerid) |
| msdyn_insightsid_salesaccelerationinsights | N:1 | msdyn_salesaccelerationinsight | Account | [msdyn_salesaccelerationinsightid](#msdyn_salesaccelerationinsightid) |
| msdyn_msdyn_accountkpiitem_account_accountkpiid | N:1 | msdyn_accountkpiitem | Account | [msdyn_accountkpiid](#msdyn_accountkpiid) |
| msdyn_msdyn_segment_account | N:1 | msdyn_segment | Account | [msdyn_segmentid](#msdyn_segmentid) |
| new_systemuser_account_SharedWith | N:1 | SystemUser | Account | [new_SharedWith](#new_sharedwith) |
| opportunity_customer_accounts | 1:N | Account | Opportunity | [CustomerId](#customerid) |
| opportunity_parent_account | 1:N | Account | Opportunity | [ParentAccountId](#parentaccountid) |
| order_customer_accounts | 1:N | Account | SalesOrder | [CustomerId](#customerid) |
| quote_customer_accounts | 1:N | Account | Quote | [CustomerId](#customerid) |

---

## 13. Ribbon Customizations

### Custom Buttons

| Button Label | Location | Command |
|-------------|----------|---------|
| Create Lead | Mscrm.Form.account.MainTab.Save.Controls._children | `azt.account.CreateLead.Command` |

### Command Definitions

| Command ID | JavaScript Function | Library |
|-----------|-------------------|---------|
| `azt.account.CreateLead.Command` | `A.AccountFunctions.createLead` | `azt_accountlibrary` |

---

## 14. Conflicts & Observations

### 14.1 Per-Form Conflicts

Fields with inconsistent settings across forms: **4**

| Field | Issue | Forms |
|-------|-------|-------|
| [azt_customernumber](#azt_customernumber) | Disabled state | iGrad Account (main), Account (main), Account Lead Quick View (quick), Account Owner Quick View (quick) |
| [azt_lastprintpurchase](#azt_lastprintpurchase) | Disabled state | iGrad Account (main), Account (main), Last Purchase Dates Quick View (quick) |
| [azt_lastsaaspurchase](#azt_lastsaaspurchase) | Disabled state | iGrad Account (main), Account (main), Last Purchase Dates Quick View (quick) |
| [telephone1](#telephone1) | Visibility | iGrad Account (main), iGrad Account (main), Account (main) |

### 14.2 Global Observations

**Fields in code but not on any form (314):**

- [accessrightsmask](#accessrightsmask)
- [accountid](#accountid)
- [activityid](#activityid)
- [activitytypecode](#activitytypecode)
- [actualclosedate](#actualclosedate)
- [address1_county](#address1_county)
- [address1_shippingmethodcode](#address1_shippingmethodcode)
- [address1_telephone1](#address1_telephone1)
- [address2_addresstypecode](#address2_addresstypecode)
- [address2_country](#address2_country)
- [address2_county](#address2_county)
- [address2_name](#address2_name)
- [address2_shippingmethodcode](#address2_shippingmethodcode)
- [adx_resolutiondate](#adx_resolutiondate)
- [amountdatatype](#amountdatatype)
- [annotationid](#annotationid)
- [azt_account](#azt_account)
- [azt_accountid](#azt_accountid)
- [azt_accountleadgenerationid](#azt_accountleadgenerationid)
- [azt_accountleadgenname](#azt_accountleadgenname)
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
- [azt_customerintrocompletedby](#azt_customerintrocompletedby)
- [azt_customerintrocompletedon](#azt_customerintrocompletedon)
- [azt_customerintroductioncompleted](#azt_customerintroductioncompleted)
- [azt_customertrainingid](#azt_customertrainingid)
- [azt_dateexitedstage](#azt_dateexitedstage)
- [azt_defaultfreightamount](#azt_defaultfreightamount)
- [azt_description](#azt_description)
- [azt_discountamount](#azt_discountamount)
- [azt_discretionarydiscount](#azt_discretionarydiscount)
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
- [azt_recapnotes](#azt_recapnotes)
- [azt_recordowner](#azt_recordowner)
- [azt_replacementproductid](#azt_replacementproductid)
- [azt_requestedfreightamt](#azt_requestedfreightamt)
- [azt_resolvedbyid](#azt_resolvedbyid)
- [azt_result](#azt_result)
- [azt_saas](#azt_saas)
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
- [azt_taxamount](#azt_taxamount)
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
- [discountamount](#discountamount)
- [discountpercentage](#discountpercentage)
- [effectivefrom](#effectivefrom)
- [effectiveto](#effectiveto)
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
- [manualdiscountamount](#manualdiscountamount)
- [metricid](#metricid)
- [mimetype](#mimetype)
- [mobilephone](#mobilephone)
- [modifiedon](#modifiedon)
- [objectid](#objectid)
- [objecttypecode](#objecttypecode)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [owningteam](#owningteam)
- [parentcontactid](#parentcontactid)
- [parentcustomerid](#parentcustomerid)
- [parentgoalid](#parentgoalid)
- [parentsystemuserid](#parentsystemuserid)
- [partyid](#partyid)
- [phonenumber](#phonenumber)
- [pricelevelid](#pricelevelid)
- [priceperunit](#priceperunit)
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
- [shipto_contactname](#shipto_contactname)
- [shipto_country](#shipto_country)
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
- [title](#title)
- [tm.systemuserid](#tmsystemuserid)
- [to](#to)
- [totalamount](#totalamount)
- [totallineitemamount](#totallineitemamount)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)
- [{0}](#0)

**Fields on forms but never in logic (44):**

- [accessteam](#accessteam)
- [accountcasessgrid](#accountcasessgrid)
- [accountopportunitiesgrid](#accountopportunitiesgrid)
- [address1_composite](#address1_composite)
- [addresses](#addresses)
- [allocations](#allocations)
- [azt_aeflafunding](#azt_aeflafunding)
- [azt_customerof](#azt_customerof)
- [azt_fiscalyearend](#azt_fiscalyearend)
- [azt_lastsuccessfulconnection](#azt_lastsuccessfulconnection)
- [azt_numberofcomputers](#azt_numberofcomputers)
- [azt_numberofstudents](#azt_numberofstudents)
- [azt_oldbusinessunit](#azt_oldbusinessunit)
- [azt_parentlastyearspend](#azt_parentlastyearspend)
- [azt_parentytdspend](#azt_parentytdspend)
- [azt_possiblematchid](#azt_possiblematchid)
- [azt_score](#azt_score)
- [azt_taxexemptcertificate](#azt_taxexemptcertificate)
- [childaccounts](#childaccounts)
- [connections](#connections)
- [contacts](#contacts)
- [documentssubgrid](#documentssubgrid)
- [donotsendmm](#donotsendmm)
- [engagementcontacts](#engagementcontacts)
- [engagements](#engagements)
- [funding](#funding)
- [fundinggrid](#fundinggrid)
- [invoices](#invoices)
- [lastusedincampaign](#lastusedincampaign)
- [mapcontrol](#mapcontrol)
- [new_sharedwith](#new_sharedwith)
- [notescontrol](#notescontrol)
- [opportunities](#opportunities)
- [orders](#orders)
- [previews](#previews)
- [print](#print)
- [purchasedsoftware](#purchasedsoftware)
- [quotes](#quotes)
- [ricontainer_charts](#ricontainer_charts)
- [sharedwith](#sharedwith)
- [softwarelicenseallocations](#softwarelicenseallocations)
- [webresource_recordwall](#webresource_recordwall)
- [websiteurl](#websiteurl)
- [writeteam](#writeteam)

---

## Index

Alphabetical field index -- 484 unique fields referenced.

#### accessrightsmask

- [Report: SharedAccountRecords > Users (Filter)](#52-sharedaccountrecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess](#52-sharedaccountrecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess (Filter)](#52-sharedaccountrecords)

#### accessteam

- [Form: iGrad Account > Details > section](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > section](#25-account-main-active)

#### accountcasessgrid

- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#25-account-main-active)

#### accountclassificationcode

- [Field Definitions](#1-field-definitions)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)
- [Form: Account Lead Quick View > Tab > section](#210-account-lead-quick-view-quick-active)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: My Active Accounts](#318-my-active-accounts)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)

#### accountid

- [Field Definitions](#1-field-definitions)
- [View: Account Advanced Find View](#31-account-advanced-find-view)
- [View: Account Associated View](#32-account-associated-view)
- [View: Account BulkOperation View](#33-account-bulkoperation-view)
- [View: Account List Member View](#34-account-list-member-view)
- [View: Account Lookup View](#35-account-lookup-view)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Accounts: No Orders in Last 6 Months](#38-accounts-no-orders-in-last-6-months)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: All Accounts](#311-all-accounts)
- [View: Duplicate Accounts](#312-duplicate-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: Inactive Accounts](#317-inactive-accounts)
- [View: My Active Accounts](#318-my-active-accounts)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: My Connections](#320-my-connections)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [View: Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [Report: SharedAccountRecords > Users > account](#52-sharedaccountrecords)
- [Workflow: AppointmentAuto-Assign (Read)](#76-appointmentauto-assign)
- [Workflow: BatchConverttoLead (Read)](#77-batchconverttolead)
- [Workflow: BatchCreateEngagements (Read)](#78-batchcreateengagements)
- [Workflow: BatchCreateIntroCall (Read)](#79-batchcreateintrocall)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#726-createleadfromaccount)
- [Workflow: PhonecallAuto-Assign (Read)](#741-phonecallauto-assign)
- [Workflow: TaskAuto-Assign (Read)](#754-taskauto-assign)
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

#### accountnumber

- [Field Definitions](#1-field-definitions)
- [View: Account Lookup View](#35-account-lookup-view)

#### accountopportunitiesgrid

- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#25-account-main-active)

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

- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### actualend

- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)

#### actualrevenue

- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)

#### actualvalue

- [Formula: azt_accountspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### address1_addresstypecode

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > PHYSICAL ADDRESS](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > PHYSICAL ADDRESS](#25-account-main-active)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: CreateLeadFromLeadGen (Write)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#727-customleadcreation)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)
- [JS: azt_accountlibrary > setPrimAddressName()](#82-azt_accountlibrary)
- [JS: azt_contactlibrary > setAddressName()](#85-azt_contactlibrary)

#### address1_city

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Section](#25-account-main-active)
- [View: Account Lookup View](#35-account-lookup-view)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Accounts: No Orders in Last 6 Months](#38-accounts-no-orders-in-last-6-months)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: All Accounts](#311-all-accounts)
- [View: Duplicate Accounts](#312-duplicate-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: Inactive Accounts](#317-inactive-accounts)
- [View: My Active Accounts](#318-my-active-accounts)
- [View: My Connections](#320-my-connections)
- [View: Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [Workflow: ContactMapAddresses (Read)](#724-contactmapaddresses)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#726-createleadfromaccount)
- [JS: azt_addresslibrary > addAddress()](#83-azt_addresslibrary)

#### address1_composite

- [Field Definitions](#1-field-definitions)
- [Form: Account Lead Quick View > Tab > section](#210-account-lead-quick-view-quick-active)

#### address1_country

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Section](#25-account-main-active)
- [Workflow: AccountAuto-Assign (Read)](#73-accountauto-assign)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [JS: azt_addresslibrary > addAddress()](#83-azt_addresslibrary)

#### address1_county

- [Field Definitions](#1-field-definitions)
- [Workflow: ContactMapAddresses (Read)](#724-contactmapaddresses)

#### address1_fax

- [Field Definitions](#1-field-definitions)
- [View: Account Lookup View](#35-account-lookup-view)

#### address1_freighttermscode

- [Field Definitions](#1-field-definitions)

#### address1_latitude

- [Field Definitions](#1-field-definitions)

#### address1_line1

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Address](#22-igrad-account-main-active)
- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Section](#25-account-main-active)
- [Workflow: ContactMapAddresses (Read)](#724-contactmapaddresses)
- [JS: azt_addresslibrary > addAddress()](#83-azt_addresslibrary)

#### address1_line2

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Section](#25-account-main-active)
- [Workflow: ContactMapAddresses (Read)](#724-contactmapaddresses)
- [JS: azt_addresslibrary > addAddress()](#83-azt_addresslibrary)

#### address1_line3

- [Field Definitions](#1-field-definitions)

#### address1_longitude

- [Field Definitions](#1-field-definitions)

#### address1_name

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > PHYSICAL ADDRESS](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > PHYSICAL ADDRESS](#25-account-main-active)
- [View: Account Lookup View](#35-account-lookup-view)
- [Workflow: SetPhysicalAddressNameField (Read)](#750-setphysicaladdressnamefield)
- [Workflow: SetPhysicalAddressNameField (Write)](#750-setphysicaladdressnamefield)
- [JS: azt_accountlibrary > setPrimAddressName()](#82-azt_accountlibrary)
- [JS: azt_contactlibrary > setAddressName()](#85-azt_contactlibrary)

#### address1_postalcode

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Section](#25-account-main-active)
- [Workflow: ContactMapAddresses (Read)](#724-contactmapaddresses)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [JS: azt_addresslibrary > addAddress()](#83-azt_addresslibrary)

#### address1_postofficebox

- [Field Definitions](#1-field-definitions)

#### address1_primarycontactname

- [Field Definitions](#1-field-definitions)

#### address1_shippingmethodcode

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: CreateLeadFromLeadGen (Write)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#727-customleadcreation)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)

#### address1_stateorprovince

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Section](#25-account-main-active)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: All Accounts](#311-all-accounts)
- [View: Duplicate Accounts](#312-duplicate-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: My Active Accounts](#318-my-active-accounts)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [View: Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [Workflow: AccountAuto-Assign (Read)](#73-accountauto-assign)
- [Workflow: ContactAuto-Assign (Read)](#723-contactauto-assign)
- [Workflow: ContactMapAddresses (Read)](#724-contactmapaddresses)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Read)](#727-customleadcreation)
- [Workflow: FSRLeadDistibutionNotification (Read)](#730-fsrleaddistibutionnotification)
- [Workflow: NewFSRLeadNotification (Read)](#736-newfsrleadnotification)
- [Workflow: PhonecallAuto-Assign (Read)](#741-phonecallauto-assign)
- [Workflow: SoftwareLicenseCreateEngagement (Read)](#752-softwarelicensecreateengagement)
- [JS: azt_accountlibrary > createLead()](#82-azt_accountlibrary)
- [JS: azt_addresslibrary > addAddress()](#83-azt_addresslibrary)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: AutoAssignStateAbb (Read)](#1012-autoassignstateabb)
- [Plugin: AutoAssignStateAbb (Write)](#1012-autoassignstateabb)
- [Plugin: LeadImport (Write)](#1036-leadimport)

#### address1_telephone1

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

#### address1_telephone2

- [Field Definitions](#1-field-definitions)

#### address1_telephone3

- [Field Definitions](#1-field-definitions)

#### address1_upszone

- [Field Definitions](#1-field-definitions)

#### address1_utcoffset

- [Field Definitions](#1-field-definitions)

#### address2_addresstypecode

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: CreateLeadFromLeadGen (Write)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#727-customleadcreation)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)
- [JS: azt_accountlibrary > setBillAddressName()](#82-azt_accountlibrary)

#### address2_city

- [Field Definitions](#1-field-definitions)

#### address2_composite

- [Field Definitions](#1-field-definitions)

#### address2_country

- [Field Definitions](#1-field-definitions)
- [Workflow: ContactMapAddresses (Write)](#724-contactmapaddresses)

#### address2_county

- [Field Definitions](#1-field-definitions)
- [Workflow: ContactMapAddresses (Write)](#724-contactmapaddresses)

#### address2_fax

- [Field Definitions](#1-field-definitions)

#### address2_freighttermscode

- [Field Definitions](#1-field-definitions)

#### address2_latitude

- [Field Definitions](#1-field-definitions)

#### address2_line1

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader > account](#51-paquotereport)

#### address2_line2

- [Field Definitions](#1-field-definitions)

#### address2_line3

- [Field Definitions](#1-field-definitions)

#### address2_longitude

- [Field Definitions](#1-field-definitions)

#### address2_name

- [Field Definitions](#1-field-definitions)
- [Workflow: SetBusinessAddressNameField (Read)](#748-setbusinessaddressnamefield)
- [Workflow: SetBusinessAddressNameField (Write)](#748-setbusinessaddressnamefield)
- [JS: azt_accountlibrary > setBillAddressName()](#82-azt_accountlibrary)

#### address2_postalcode

- [Field Definitions](#1-field-definitions)

#### address2_postofficebox

- [Field Definitions](#1-field-definitions)

#### address2_primarycontactname

- [Field Definitions](#1-field-definitions)

#### address2_shippingmethodcode

- [Field Definitions](#1-field-definitions)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: CreateLeadFromLeadGen (Write)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#727-customleadcreation)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)

#### address2_stateorprovince

- [Field Definitions](#1-field-definitions)

#### address2_telephone1

- [Field Definitions](#1-field-definitions)

#### address2_telephone2

- [Field Definitions](#1-field-definitions)

#### address2_telephone3

- [Field Definitions](#1-field-definitions)

#### address2_upszone

- [Field Definitions](#1-field-definitions)

#### address2_utcoffset

- [Field Definitions](#1-field-definitions)

#### addresses

- [Form: iGrad Account > Summary > SOCIAL PANE](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > SOCIAL_PANE_TAB](#25-account-main-active)

#### adx_resolutiondate

- [Plugin: CaseClose (Write)](#1015-caseclose)

#### allocations

- [Form: iGrad Account > Allocations > Section](#22-igrad-account-main-active)
- [Form: Account > Allocations > Section](#25-account-main-active)

#### amountdatatype

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)

#### annotationid

- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

#### associatedconnectionroleid

- [Plugin: ContactSetConnectionRole (Join)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Join)](#1075-setprimarycontact)

#### azt_account

- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Relationship: azt_Funding_Account_Account](#12-relationships)

#### azt_accountalert

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Account Alert > Section](#22-igrad-account-main-active)
- [Form: Account > Account Alert > Section](#25-account-main-active)
- [JS: azt_accountlibrary > accountAlert()](#82-azt_accountlibrary)

#### azt_accountid

- [View: GED Customers Without Kaplan (Filter)](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED (Filter)](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash (Filter)](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET (Filter)](#316-hiset-customers-without-kaplan-hiset)
- [View: TASC Customers Without Kaplan TASC (Filter)](#324-tasc-customers-without-kaplan-tasc)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Filter)](#104-accountreassignmentsharerecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)
- [Relationship: azt_account_azt_customertraining](#12-relationships)
- [Relationship: azt_account_azt_engagement](#12-relationships)
- [Relationship: azt_account_azt_preview](#12-relationships)
- [Relationship: azt_account_azt_softwarelicense](#12-relationships)
- [Relationship: azt_account_azt_training](#12-relationships)

#### azt_accountleadgenerationid

- [Plugin: AccountLeadGen (Filter)](#102-accountleadgen)
- [Plugin: AccountLeadGenAssociate (Read)](#103-accountleadgenassociate)
- [Plugin: AccountLeadGenAssociate (Filter)](#103-accountleadgenassociate)

#### azt_accountleadgenname

- [Field Definitions](#1-field-definitions)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [Plugin: AccountLeadGenAssociate (Write)](#103-accountleadgenassociate)

#### azt_accountnumber

- [Field Definitions](#1-field-definitions)

#### azt_accountspend

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)
- [JS: azt_accountlibrary > parentAccountSpend()](#82-azt_accountlibrary)
- [Formula: azt_accountspend (Target)](#9-formulas-rollups)

#### azt_accountspend_base

- [Field Definitions](#1-field-definitions)

#### azt_accounttype

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account (Header)](#22-igrad-account-main-active)
- [Form: iGrad Account > Summary > Account Status](#22-igrad-account-main-active)
- [Form: Account (Header)](#25-account-main-active)
- [Form: Account > SUMMARY_TAB > Account Status](#25-account-main-active)
- [Form: Account Lead Quick View > Tab > section](#210-account-lead-quick-view-quick-active)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: Quick Find Active Accounts (Filter)](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [JS: azt_FindAccountsWithinBoundModified](#81-azt_findaccountswithinboundmodified)
- [Plugin: AccountTypeSet (Write)](#105-accounttypeset)

#### azt_addresssearch

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > PHYSICAL ADDRESS](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > PHYSICAL ADDRESS](#25-account-main-active)
- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

#### azt_addresssearch2

- [Field Definitions](#1-field-definitions)
- [Plugin: AddressSearchCleanupFields (Read)](#1010-addresssearchcleanupfields)
- [Plugin: AddressSearchCleanupFields (Write)](#1010-addresssearchcleanupfields)

#### azt_addtocrtqueue

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_aeflafunding

- [Field Definitions](#1-field-definitions)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#25-account-main-active)
- [Form: Last Purchase Dates Quick View > Tab > section](#28-last-purchase-dates-quick-view-quick-active)

#### azt_ageendedstage

- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

#### azt_allocatedtoid

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Relationship: azt_allocatedaccount_azt_allocatedlicense](#12-relationships)

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
- [Relationship: azt_account_azt_allocatedlicense](#12-relationships)
- [Relationship: azt_account_azt_expense](#12-relationships)
- [Relationship: azt_account_azt_printpurchase](#12-relationships)
- [Relationship: azt_account_azt_productdiscount](#12-relationships)

#### azt_customerintrocompletedby

- [Field Definitions](#1-field-definitions)
- [Workflow: AccountClearCustomerIntro (Write)](#74-accountclearcustomerintro)
- [JS: azt_accountlibrary > onLoad()](#82-azt_accountlibrary)
- [JS: azt_accountlibrary > setCustIntroCompletedBy()](#82-azt_accountlibrary)

#### azt_customerintrocompletedon

- [Field Definitions](#1-field-definitions)
- [Workflow: AccountClearCustomerIntro (Write)](#74-accountclearcustomerintro)
- [JS: azt_accountlibrary > onLoad()](#82-azt_accountlibrary)
- [JS: azt_accountlibrary > setCustIntroCompletedBy()](#82-azt_accountlibrary)

#### azt_customerintroductioncompleted

- [Field Definitions](#1-field-definitions)
- [View: New Customer Introduction List (Filter)](#321-new-customer-introduction-list)
- [Workflow: AccountClearCustomerIntro (Write)](#74-accountclearcustomerintro)
- [JS: azt_accountlibrary > setCustIntroCompletedBy()](#82-azt_accountlibrary)

#### azt_customernumber

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)
- [Form: Account Lead Quick View > Tab > section](#210-account-lead-quick-view-quick-active)
- [Form: Account Owner Quick View > Tab > section](#211-account-owner-quick-view-quick-active)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: Quick Find Active Accounts (Filter)](#323-quick-find-active-accounts)

#### azt_customerof

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)

#### azt_customertrainingid

- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)

#### azt_dateexitedstage

- [Plugin: OrderStageTracking (Write)](#1057-orderstagetracking)

#### azt_defaultfreightamount

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_description

- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

#### azt_digitalstatus

- [Field Definitions](#1-field-definitions)

#### azt_discountamount

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)

#### azt_discretionarydiscount

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### azt_discretionarydiscountamt

- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#1050-opptytoquotefieldmappings)

#### azt_duedate

- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### azt_duplicate

- [Field Definitions](#1-field-definitions)
- [View: Duplicate Accounts (Filter)](#312-duplicate-accounts)

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

#### azt_excludefromautoassign

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)
- [Workflow: AccountAuto-Assign (Read)](#73-accountauto-assign)
- [Workflow: ContactAuto-Assign (Read)](#723-contactauto-assign)
- [Workflow: MarkAccountsExcludefromAuto-assign (Write)](#735-markaccountsexcludefromauto-assign)
- [JS: azt_accountlibrary > onLoad()](#82-azt_accountlibrary)

#### azt_executivesummary

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Executive Summary](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Executive Summary](#25-account-main-active)
- [Workflow: BatchCreateEngagements (Write)](#78-batchcreateengagements)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#752-softwarelicensecreateengagement)

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

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)
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

#### azt_fiscalyearend

- [Field Definitions](#1-field-definitions)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#25-account-main-active)

#### azt_freightamtapproved

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_fsradminpassword

- [Field Definitions](#1-field-definitions)

#### azt_fsradminusername

- [Field Definitions](#1-field-definitions)

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

#### azt_gedprintnoflashplay

- [Field Definitions](#1-field-definitions)

#### azt_gedprintnogedsoftware

- [Field Definitions](#1-field-definitions)

#### azt_goaltype

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

#### azt_historicalowner

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account (Footer)](#22-igrad-account-main-active)
- [Form: Account (Footer)](#25-account-main-active)
- [Workflow: CloneAndDeleteQuote (Write)](#718-cloneanddeletequote)
- [Workflow: CloneOpportunity (Write)](#721-cloneopportunity)

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

#### azt_isautoduplicate

- [Field Definitions](#1-field-definitions)

#### azt_isbn

- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

#### azt_iscompanion

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### azt_isduplicate

- [Field Definitions](#1-field-definitions)
- [View: Old Duplicate Accounts View (Filter)](#322-old-duplicate-accounts-view)

#### azt_isinquickbooks

- [Field Definitions](#1-field-definitions)
- [View: Active Accounts in Quickbooks (Filter)](#39-active-accounts-in-quickbooks)

#### azt_ismatched

- [Field Definitions](#1-field-definitions)

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

- [Field Definitions](#1-field-definitions)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [Plugin: OpportunityLastActivityDate (Write)](#1045-opportunitylastactivitydate)

#### azt_lastmodifiedbyid

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)

#### azt_lastname

- [Plugin: LeadImport (Read)](#1036-leadimport)

#### azt_lastprintpurchase

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > Description](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#25-account-main-active)
- [Form: Last Purchase Dates Quick View > Tab > section](#28-last-purchase-dates-quick-view-quick-active)
- [View: Active Accounts](#310-active-accounts)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: My Active Customers With Purchase Dates (Filter)](#319-my-active-customers-with-purchase-dates)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [View: New Customer Introduction List (Filter)](#321-new-customer-introduction-list)

#### azt_lastsaaspurchase

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > Description](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#25-account-main-active)
- [Form: Last Purchase Dates Quick View > Tab > section](#28-last-purchase-dates-quick-view-quick-active)
- [View: Active Accounts](#310-active-accounts)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: My Active Customers With Purchase Dates (Filter)](#319-my-active-customers-with-purchase-dates)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [View: New Customer Introduction List (Filter)](#321-new-customer-introduction-list)

#### azt_lastsuccessfulconnection

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account (Header)](#22-igrad-account-main-active)
- [Form: Account (Header)](#25-account-main-active)

#### azt_lastyearspend

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)
- [Formula: azt_lastyearspend (Target)](#9-formulas-rollups)

#### azt_lastyearspend_base

- [Field Definitions](#1-field-definitions)

#### azt_leadimportid

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### azt_leadsourceid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: BulkChangeLeadSource (Write)](#712-bulkchangeleadsource)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#727-customleadcreation)
- [Workflow: LeadAssignment (Read)](#732-leadassignment)
- [Workflow: LeadSourceChange (Write)](#734-leadsourcechange)
- [Workflow: SetLeadTemperature (Read)](#749-setleadtemperature)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Relationship: azt_azt_leadsource_account](#12-relationships)

#### azt_licensestatus

- [View: GED Customers Without Kaplan (Filter)](#313-ged-customers-without-kaplan)
- [View: GED Customers Without Kaplan (Filter)](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED (Filter)](#314-ged-flashplay-without-any-ged)
- [View: GED Flash/Play Without Any GED (Filter)](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash (Filter)](#315-gedkaplanged-customers-without-flash)
- [View: GED/KaplanGED Customers Without Flash (Filter)](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET (Filter)](#316-hiset-customers-without-kaplan-hiset)
- [View: HiSET Customers Without Kaplan HiSET (Filter)](#316-hiset-customers-without-kaplan-hiset)
- [View: TASC Customers Without Kaplan TASC (Filter)](#324-tasc-customers-without-kaplan-tasc)
- [View: TASC Customers Without Kaplan TASC (Filter)](#324-tasc-customers-without-kaplan-tasc)
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

#### azt_nomatch

- [Field Definitions](#1-field-definitions)

#### azt_nonsaasstatus

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Account Status](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Account Status](#25-account-main-active)
- [Plugin: AccountTypeSet (Read)](#105-accounttypeset)
- [Plugin: AccountTypeSet (Image)](#105-accounttypeset)

#### azt_nonsaastype

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### azt_numberofcomputers

- [Field Definitions](#1-field-definitions)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#25-account-main-active)

#### azt_numberoflicenses

- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)

#### azt_numberofstudents

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > COMPANY PROFILE](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#25-account-main-active)

#### azt_oldbusinessunit

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)

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

#### azt_parentaccountid

- [Relationship: azt_parentaccount_azt_softwarelicense](#12-relationships)

#### azt_parentaccountspend

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)
- [JS: azt_accountlibrary > parentAccountSpend()](#82-azt_accountlibrary)

#### azt_parentaccountspend_base

- [Field Definitions](#1-field-definitions)

#### azt_parentlastyearspend

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)

#### azt_parentlastyearspend_base

- [Field Definitions](#1-field-definitions)

#### azt_parentopportunityid

- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityAudit (Image)](#1043-opportunityaudit)

#### azt_parentorderid

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### azt_parentytdspend

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)

#### azt_parentytdspend_base

- [Field Definitions](#1-field-definitions)

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

- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### azt_possiblematchid

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)
- [Relationship: azt_account_account](#12-relationships)

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

#### azt_productfamilies

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > Description](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#25-account-main-active)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Accounts With Product Family Purchases (Filter)](#37-accounts-with-product-family-purchases)

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

#### azt_recapnotes

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### azt_recordowner

- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)

#### azt_recordownerid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: All Accounts](#311-all-accounts)
- [View: All Accounts (Sort)](#311-all-accounts)
- [View: Duplicate Accounts](#312-duplicate-accounts)
- [View: Duplicate Accounts (Sort)](#312-duplicate-accounts)
- [View: My Active Accounts (Filter)](#318-my-active-accounts)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SharedAccountRecords > Users > account](#52-sharedaccountrecords)
- [Workflow: 0ChangeQuoteRecordOwner (Write)](#71-0changequoterecordowner)
- [Workflow: AccountAuto-Assign (Write)](#73-accountauto-assign)
- [Workflow: AppointmentAuto-Assign (Write)](#76-appointmentauto-assign)
- [Workflow: BatchCreateEngagements (Write)](#78-batchcreateengagements)
- [Workflow: BatchOpportunityTransfer (Write)](#711-batchopportunitytransfer)
- [Workflow: CaseRecordOwner (Write)](#714-caserecordowner)
- [Workflow: CaseRecordOwnerAssign (Write)](#715-caserecordownerassign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#716-caserecordownerassignmentnotification)
- [Workflow: CloneLicense (Write)](#720-clonelicense)
- [Workflow: CloneOpportunity (Write)](#721-cloneopportunity)
- [Workflow: ContactAuto-Assign (Write)](#723-contactauto-assign)
- [Workflow: EngagementRecordOwner (Write)](#728-engagementrecordowner)
- [Workflow: EngagementRecordOwnerTeam (Read)](#729-engagementrecordownerteam)
- [Workflow: InvoiceRecordOwner (Write)](#731-invoicerecordowner)
- [Workflow: LeadAssignment (Write)](#732-leadassignment)
- [Workflow: OpportunityRecordOwner (Write)](#738-opportunityrecordowner)
- [Workflow: OpportunityRecordOwnerTeam (Read)](#739-opportunityrecordownerteam)
- [Workflow: OrderRecordOwner (Write)](#740-orderrecordowner)
- [Workflow: PhonecallAuto-Assign (Write)](#741-phonecallauto-assign)
- [Workflow: QuoteRecordOwner (Write)](#744-quoterecordowner)
- [Workflow: QuoteRecordOwnerTeam (Read)](#745-quoterecordownerteam)
- [Workflow: SendQuote (Read)](#747-sendquote)
- [Workflow: TaskAuto-Assign (Write)](#754-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#756-wonopportunityemail)
- [Workflow: WorkforceAccountAuto-assign (Write)](#757-workforceaccountauto-assign)
- [Workflow: WorkforceAppointmentAuto-Assign (Write)](#758-workforceappointmentauto-assign)
- [Workflow: WorkforceCaseAuto-assign (Write)](#759-workforcecaseauto-assign)
- [Workflow: WorkforceContactAuto-assign (Write)](#760-workforcecontactauto-assign)
- [Workflow: WorkforceEngagementAuto-assign (Write)](#761-workforceengagementauto-assign)
- [Workflow: WorkforceLeadAuto-Assign (Write)](#762-workforceleadauto-assign)
- [Workflow: WorkforceOpportunityAuto-assign (Write)](#763-workforceopportunityauto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Write)](#764-workforcephone-callauto-assign)
- [Workflow: WorkforceQuoteAuto-assign (Write)](#765-workforcequoteauto-assign)
- [Workflow: iGradAppointmentAuto-Assign (Write)](#766-igradappointmentauto-assign)
- [Workflow: iGradCaseAuto-Assign (Write)](#767-igradcaseauto-assign)
- [Workflow: iGradPhone-callAuto-assign (Write)](#768-igradphone-callauto-assign)
- [JS: azt_caselibrary > onLoad()](#84-azt_caselibrary)
- [JS: azt_engagementlibrary > onLoad()](#86-azt_engagementlibrary)
- [JS: azt_invoicelibrary > onLoad()](#87-azt_invoicelibrary)
- [JS: azt_opportunitylibrary > onLoad()](#89-azt_opportunitylibrary)
- [JS: azt_orderlibrary > onLoad()](#811-azt_orderlibrary)
- [JS: azt_quotelibrary](#814-azt_quotelibrary)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#108-activitycloseforcerecordowner)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#1021-createsoftwarelicenses)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)
- [Relationship: azt_systemuser_account](#12-relationships)

#### azt_replacementproductid

- [Plugin: Utility (Read)](#1081-utility)

#### azt_requestedfreightamt

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

#### azt_resolvedbyid

- [Plugin: CaseClose (Read)](#1015-caseclose)
- [Plugin: CaseClose (Write)](#1015-caseclose)

#### azt_result

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### azt_saas

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: Utility (Read)](#1081-utility)

#### azt_saasstatus

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > Account Status](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > Account Status](#25-account-main-active)
- [Plugin: AccountTypeSet (Read)](#105-accounttypeset)
- [Plugin: AccountTypeSet (Image)](#105-accounttypeset)

#### azt_salesrepid

- [Plugin: CreateCompGoals (Write)](#1020-createcompgoals)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)
- [Plugin: InvoiceCompCompleted (Read)](#1035-invoicecompcompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#1035-invoicecompcompleted)

#### azt_score

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)

#### azt_softwarelicenseid

- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: AllocationValidation (Read)](#1011-allocationvalidation)
- [Plugin: AllocationValidation (Filter)](#1011-allocationvalidation)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#1055-ordermanuallycreatesoftwarelicense)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### azt_softwareproductid

- [View: GED Customers Without Kaplan (Filter)](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED (Filter)](#314-ged-flashplay-without-any-ged)
- [View: GED Flash/Play Without Any GED (Filter)](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash (Filter)](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET (Filter)](#316-hiset-customers-without-kaplan-hiset)
- [View: TASC Customers Without Kaplan TASC (Filter)](#324-tasc-customers-without-kaplan-tasc)
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

#### azt_tax_exempt_certificate__c

- [Field Definitions](#1-field-definitions)

#### azt_taxamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### azt_taxexemptcertificate

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)

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

#### azt_ttprintnotto

- [Field Definitions](#1-field-definitions)

#### azt_type

- [Field Definitions](#1-field-definitions)

#### azt_verticalmarket

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account (Header)](#22-igrad-account-main-active)
- [Form: iGrad Account > Summary > COMPANY PROFILE](#22-igrad-account-main-active)
- [Form: Account (Header)](#25-account-main-active)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#25-account-main-active)
- [Form: Account Lead Quick View > Tab > section](#210-account-lead-quick-view-quick-active)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#726-createleadfromaccount)
- [JS: azt_accountlibrary > setNonIgradVerticalMarket()](#82-azt_accountlibrary)
- [JS: azt_accountlibrary > setiGradVerticalMarket()](#82-azt_accountlibrary)

#### azt_year

- [Plugin: FundingYearSync (Write)](#1030-fundingyearsync)

#### azt_yearbeforelastspend

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)
- [Formula: azt_yearbeforelastspend (Target)](#9-formulas-rollups)

#### azt_yearbeforelastspend_base

- [Field Definitions](#1-field-definitions)

#### azt_ytdspend

- [Field Definitions](#1-field-definitions)
- [Form: Account > Administration > Section](#25-account-main-active)
- [Formula: azt_ytdspend (Target)](#9-formulas-rollups)

#### azt_ytdspend_base

- [Field Definitions](#1-field-definitions)

#### baseamount

- [Report: PAQuoteReport > QuoteHeader > quotedetail](#51-paquotereport)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

#### billto_city

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### billto_line1

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_line2

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_line3

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_name

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_postalcode

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### billto_stateorprovince

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
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

- [Plugin: ContactSetConnectionRole (Sort)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Sort)](#1075-setprimarycontact)

#### changedon

- [Report: SharedAccountRecords > Users > principalobjectaccess](#52-sharedaccountrecords)

#### childaccounts

- [Form: iGrad Account > Summary > CHILD ACCOUNTS](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > CHILD ACCOUNTS](#25-account-main-active)

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

#### connections

- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#25-account-main-active)

#### consideronlygoalownersrecords

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### contactid

- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Write)](#1026-expenselinetotals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)

#### contacts

- [Form: iGrad Account > Summary > Section](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#25-account-main-active)

#### country

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### county

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### createdby

- [Field Definitions](#1-field-definitions)
- [Workflow: AccountAuto-Assign (Read)](#73-accountauto-assign)
- [Workflow: WorkforceAccountAuto-assign (Read)](#757-workforceaccountauto-assign)

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

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
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
- [Relationship: incident_customer_accounts](#12-relationships)
- [Relationship: invoice_customer_accounts](#12-relationships)
- [Relationship: lead_customer_accounts](#12-relationships)
- [Relationship: opportunity_customer_accounts](#12-relationships)
- [Relationship: order_customer_accounts](#12-relationships)
- [Relationship: quote_customer_accounts](#12-relationships)

#### datefulfilled

- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

#### defaultuomid

- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### description

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > Description](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#25-account-main-active)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

#### discountamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)

#### discountpercentage

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

#### documentssubgrid

- [Form: iGrad Account > Files > Documents Section](#22-igrad-account-main-active)

#### donotsendmm

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > MARKETING](#22-igrad-account-main-active)

#### effectivefrom

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### effectiveto

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### emailaddress1

- [Field Definitions](#1-field-definitions)
- [View: Account List Member View](#34-account-list-member-view)
- [View: Account Lookup View](#35-account-lookup-view)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadImport (Filter)](#1036-leadimport)

#### engagementcontacts

- [Form: Engagement Contacts > Tab > section](#212-engagement-contacts-quick-active)

#### engagements

- [Form: iGrad Account > Engagements > Section](#22-igrad-account-main-active)
- [Form: Account > Engagements > Section](#25-account-main-active)

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

#### fax

- [Field Definitions](#1-field-definitions)
- [View: Account Lookup View](#35-account-lookup-view)

#### fetchxml

- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### filename

- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### firstname

- [Plugin: LeadImport (Write)](#1036-leadimport)

#### fiscalperiod

- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

#### freightamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### freighttermscode

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### from

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### fullname

- [View: Account Sharing Associated View](#36-account-sharing-associated-view)
- [Report: PAQuoteReport > QuoteHeader > contact](#51-paquotereport)
- [Report: SharedAccountRecords > Users (Select)](#52-sharedaccountrecords)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Sort)](#1036-leadimport)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Plugin: Utility (Read)](#1081-utility)
- [Plugin: Utility (Sort)](#1081-utility)

#### funding

- [Form: Account > SUMMARY_TAB > Funding](#25-account-main-active)

#### fundinggrid

- [Form: Last Purchase Dates Quick View > Tab > Funding](#28-last-purchase-dates-quick-view-quick-active)

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

#### invoices

- [Form: iGrad Account > Quotes Orders Invoices > Section](#22-igrad-account-main-active)
- [Form: Account > Quotes Orders Invoices > Section](#25-account-main-active)

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

#### lastusedincampaign

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > MARKETING](#22-igrad-account-main-active)

#### manualdiscountamount

- [Report: PAQuoteReport > QuoteHeader > quotedetail](#51-paquotereport)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#1023-discretionarydiscountsetheader)
- [Plugin: ManualDiscountKill (Read)](#1040-manualdiscountkill)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)

#### mapcontrol

- [Form: iGrad Account > Summary > MapSection](#22-igrad-account-main-active)

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

#### msa_managingpartnerid

- [Field Definitions](#1-field-definitions)
- [Relationship: msa_account_managingpartner](#12-relationships)
- [Relationship: msa_contact_managingpartner](#12-relationships)

#### msa_partnerid

- [Relationship: msa_account_incident](#12-relationships)
- [Relationship: msa_partner_opportunity](#12-relationships)

#### msdyn_accountkpiid

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_accountkpiitem_account_accountkpiid](#12-relationships)

#### msdyn_salesaccelerationinsightid

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_insightsid_salesaccelerationinsights](#12-relationships)

#### msdyn_segmentid

- [Field Definitions](#1-field-definitions)
- [Relationship: msdyn_msdyn_segment_account](#12-relationships)

#### name

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: iGrad Account > Assets and Locations > Assets and Locations](#22-igrad-account-main-active)
- [Form: iGrad Account > LinkedIn Sales Navigator > LinkedIn Account Profile](#22-igrad-account-main-active)
- [View: Account Advanced Find View](#31-account-advanced-find-view)
- [View: Account Advanced Find View (Sort)](#31-account-advanced-find-view)
- [View: Account Associated View](#32-account-associated-view)
- [View: Account Associated View (Sort)](#32-account-associated-view)
- [View: Account BulkOperation View](#33-account-bulkoperation-view)
- [View: Account BulkOperation View (Sort)](#33-account-bulkoperation-view)
- [View: Account List Member View](#34-account-list-member-view)
- [View: Account Lookup View](#35-account-lookup-view)
- [View: Account Lookup View (Sort)](#35-account-lookup-view)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Accounts With Product Family Purchases (Sort)](#37-accounts-with-product-family-purchases)
- [View: Accounts: No Orders in Last 6 Months](#38-accounts-no-orders-in-last-6-months)
- [View: Accounts: No Orders in Last 6 Months (Sort)](#38-accounts-no-orders-in-last-6-months)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts in Quickbooks (Sort)](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: Active Accounts (Sort)](#310-active-accounts)
- [View: All Accounts](#311-all-accounts)
- [View: All Accounts (Sort)](#311-all-accounts)
- [View: Duplicate Accounts](#312-duplicate-accounts)
- [View: Duplicate Accounts (Sort)](#312-duplicate-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Customers Without Kaplan (Sort)](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED Flash/Play Without Any GED (Sort)](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: GED/KaplanGED Customers Without Flash (Sort)](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: HiSET Customers Without Kaplan HiSET (Sort)](#316-hiset-customers-without-kaplan-hiset)
- [View: Inactive Accounts](#317-inactive-accounts)
- [View: Inactive Accounts (Sort)](#317-inactive-accounts)
- [View: My Active Accounts](#318-my-active-accounts)
- [View: My Active Accounts (Sort)](#318-my-active-accounts)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: My Active Customers With Purchase Dates (Sort)](#319-my-active-customers-with-purchase-dates)
- [View: My Connections](#320-my-connections)
- [View: My Connections (Sort)](#320-my-connections)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [View: New Customer Introduction List (Sort)](#321-new-customer-introduction-list)
- [View: Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
- [View: Old Duplicate Accounts View (Sort)](#322-old-duplicate-accounts-view)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: Quick Find Active Accounts (Filter)](#323-quick-find-active-accounts)
- [View: Quick Find Active Accounts (Sort)](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [View: TASC Customers Without Kaplan TASC (Sort)](#324-tasc-customers-without-kaplan-tasc)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PAQuoteReport > QuoteHeader (Sort)](#51-paquotereport)
- [Report: SharedAccountRecords > Users > account](#52-sharedaccountrecords)
- [Workflow: 0EngagementNames (Read)](#72-0engagementnames)
- [Workflow: BatchConverttoLead (Read)](#77-batchconverttolead)
- [Workflow: BatchCreateEngagements (Read)](#78-batchcreateengagements)
- [Workflow: BatchLooseOpportunities (Read)](#710-batchlooseopportunities)
- [Workflow: BatchOpportunityTransfer (Read)](#711-batchopportunitytransfer)
- [Workflow: CloneAndDeleteQuote (Read)](#718-cloneanddeletequote)
- [Workflow: CloneOpportunity (Read)](#721-cloneopportunity)
- [Workflow: CloneOrder (Read)](#722-cloneorder)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Read)](#727-customleadcreation)
- [Workflow: NewFSRLeadNotification (Read)](#736-newfsrleadnotification)
- [Workflow: QualifyLead (Write)](#743-qualifylead)
- [Workflow: RenameEngagements (Read)](#746-renameengagements)
- [Workflow: TaskCreateReorderLead (Read)](#755-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#756-wonopportunityemail)
- [JS: azt_accountlibrary > createLead()](#82-azt_accountlibrary)
- [JS: azt_accountlibrary > createNewLead()](#82-azt_accountlibrary)
- [JS: azt_addresslibrary > addAddress()](#83-azt_addresslibrary)
- [JS: azt_opportunitytrackdiscount > trackDiscount()](#810-azt_opportunitytrackdiscount)
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

#### new_sharedwith

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > Description](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#25-account-main-active)
- [Relationship: new_systemuser_account_SharedWith](#12-relationships)

#### notescontrol

- [Form: TimelineWallControl - Account- Main > SUMMARY_TAB > SOCIAL_PANE_TAB](#21-timelinewallcontrol-account-main-main-active)
- [Form: iGrad Account > Summary > SOCIAL PANE](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > SOCIAL_PANE_TAB](#25-account-main-active)

#### objectid

- [Report: SharedAccountRecords > Users > principalobjectaccess](#52-sharedaccountrecords)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)
- [Relationship: Account_Annotation](#12-relationships)

#### objecttypecode

- [Report: SharedAccountRecords > Users (Filter)](#52-sharedaccountrecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess](#52-sharedaccountrecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess (Filter)](#52-sharedaccountrecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess (Sort)](#52-sharedaccountrecords)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

#### opportunities

- [Form: iGrad Account > Opportunities > Section](#22-igrad-account-main-active)
- [Form: Account > Opportunities > Section](#25-account-main-active)

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

#### orders

- [Form: iGrad Account > Quotes Orders Invoices > Section](#22-igrad-account-main-active)
- [Form: Account > Quotes Orders Invoices > Section](#25-account-main-active)

#### originatingleadid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Details > Description](#22-igrad-account-main-active)
- [Form: iGrad Account > Details > MARKETING](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#25-account-main-active)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: OpportunityAssignFromLead (Read)](#1042-opportunityassignfromlead)
- [Relationship: account_originating_lead](#12-relationships)

#### ownerid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account (Header)](#22-igrad-account-main-active)
- [Form: Account Owner Card > Tab > section](#27-account-owner-card-quick-active)
- [Form: Account Owner Quick View > Tab > section](#211-account-owner-quick-view-quick-active)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [Report: SharedAccountRecords > Users > account](#52-sharedaccountrecords)
- [Workflow: AllocationsAssigntoTeam (Read)](#75-allocationsassigntoteam)
- [Workflow: AppointmentAuto-Assign (Read)](#76-appointmentauto-assign)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: CasePendingAssignmentNotification (Read)](#713-casependingassignmentnotification)
- [Workflow: CaseRecordOwner (Read)](#714-caserecordowner)
- [Workflow: CloneAndDeleteQuote (Write)](#718-cloneanddeletequote)
- [Workflow: CloneCommissionPayment (Write)](#719-clonecommissionpayment)
- [Workflow: CloneOpportunity (Write)](#721-cloneopportunity)
- [Workflow: ContactAuto-Assign (Read)](#723-contactauto-assign)
- [Workflow: CreateLeadFromLeadGen (Write)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: EngagementRecordOwner (Read)](#728-engagementrecordowner)
- [Workflow: FSRLeadDistibutionNotification (Write)](#730-fsrleaddistibutionnotification)
- [Workflow: InvoiceRecordOwner (Read)](#731-invoicerecordowner)
- [Workflow: LeadAssignment (Read)](#732-leadassignment)
- [Workflow: OpportunityRecordOwner (Read)](#738-opportunityrecordowner)
- [Workflow: OrderRecordOwner (Read)](#740-orderrecordowner)
- [Workflow: PhonecallAuto-Assign (Read)](#741-phonecallauto-assign)
- [Workflow: PrintPurchaseAssigntoTeam (Read)](#742-printpurchaseassigntoteam)
- [Workflow: QuoteRecordOwner (Read)](#744-quoterecordowner)
- [Workflow: SoftwareLicenseAssigntoTeam (Read)](#751-softwarelicenseassigntoteam)
- [Workflow: SoftwareLicenseSetOwner (Read)](#753-softwarelicensesetowner)
- [Workflow: TaskAuto-Assign (Read)](#754-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)
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

#### owningteam

- [Field Definitions](#1-field-definitions)
- [Workflow: CaseRecordOwnerAssign (Read)](#715-caserecordownerassign)
- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)

#### owninguser

- [Plugin: GetAcctTeamOwned (Join)](#1031-getacctteamowned)

#### parentaccountid

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account Lead Quick View > Tab > section](#210-account-lead-quick-view-quick-active)
- [View: Old Duplicate Accounts View](#322-old-duplicate-accounts-view)
- [Workflow: AppointmentAuto-Assign (Read)](#76-appointmentauto-assign)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: CloneOpportunity (Write)](#721-cloneopportunity)
- [Workflow: CreateLeadFromLeadGen (Write)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#727-customleadcreation)
- [Workflow: LeadAssignment (Read)](#732-leadassignment)
- [Workflow: OpportunityRecordOwner (Read)](#738-opportunityrecordowner)
- [Workflow: PhonecallAuto-Assign (Read)](#741-phonecallauto-assign)
- [Workflow: QualifyLead (Write)](#743-qualifylead)
- [Workflow: TaskAuto-Assign (Read)](#754-taskauto-assign)
- [Workflow: TaskCreateReorderLead (Read)](#755-taskcreatereorderlead)
- [JS: azt_accountlibrary > parentAccountSpend()](#82-azt_accountlibrary)
- [JS: azt_leadlibrary > getAccountPopulated()](#88-azt_leadlibrary)
- [JS: azt_leadlibrary > qualifyLead()](#88-azt_leadlibrary)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadQualify (Read)](#1038-leadqualify)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)
- [Relationship: account_parent_account](#12-relationships)
- [Relationship: opportunity_parent_account](#12-relationships)

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
- [Relationship: contact_customer_accounts](#12-relationships)

#### parentgoalid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)

#### parentid

- [Relationship: Account_CustomerAddress](#12-relationships)

#### parentsystemuserid

- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: Utility (Read)](#1081-utility)

#### partyid

- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### phonenumber

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### previews

- [Form: Account > SUMMARY_TAB > Previews](#25-account-main-active)

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

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > LinkedIn Sales Navigator > LinkedIn Member Profile](#22-igrad-account-main-active)
- [Form: iGrad Account > LinkedIn Sales Navigator > LinkedIn InMail](#22-igrad-account-main-active)
- [Workflow: CreateLeadFromLeadGen (Read)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Read)](#726-createleadfromaccount)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

#### print

- [Form: iGrad Account > Print > Section](#22-igrad-account-main-active)
- [Form: Account > Print > Section](#25-account-main-active)

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

- [View: GED Customers Without Kaplan (Filter)](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED (Filter)](#314-ged-flashplay-without-any-ged)
- [View: GED Flash/Play Without Any GED (Filter)](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash (Filter)](#315-gedkaplanged-customers-without-flash)
- [View: GED/KaplanGED Customers Without Flash (Filter)](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET (Filter)](#316-hiset-customers-without-kaplan-hiset)
- [View: TASC Customers Without Kaplan TASC (Filter)](#324-tasc-customers-without-kaplan-tasc)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)
- [Plugin: RestrictProductLookups (Filter)](#1069-restrictproductlookups)
- [Plugin: Utility (Filter)](#1081-utility)

#### producttypecode

- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)

#### purchasedsoftware

- [Form: iGrad Account > Software > Purchased Software](#22-igrad-account-main-active)
- [Form: Account > Software > Purchased Software](#25-account-main-active)
- [Form: Purchased Software Licenses > Tab > section](#26-purchased-software-licenses-quick-active)

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

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
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

#### quotenumber

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### quotes

- [Form: iGrad Account > Quotes Orders Invoices > Section](#22-igrad-account-main-active)
- [Form: Account > Quotes Orders Invoices > Section](#25-account-main-active)

#### record1id

- [View: My Connections (Filter)](#320-my-connections)
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
- [Relationship: Account_Appointments](#12-relationships)
- [Relationship: Account_Emails](#12-relationships)
- [Relationship: Account_Letters](#12-relationships)
- [Relationship: Account_Phonecalls](#12-relationships)
- [Relationship: Account_Tasks](#12-relationships)
- [Relationship: account_OpportunityCloses](#12-relationships)
- [Relationship: account_OrderCloses](#12-relationships)
- [Relationship: account_QuoteCloses](#12-relationships)

#### requestdeliveryby

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### ricontainer_charts

- [Form: AI for Sales > RAV2 > RAV2_section_1](#23-ai-for-sales-main-inactive)

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

- [Formula: azt_accountspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_10

- [Formula: azt_lastyearspend](#9-formulas-rollups)

#### rolluprulestep1_11

- [Formula: azt_lastyearspend](#9-formulas-rollups)

#### rolluprulestep1_12

- [Formula: azt_lastyearspend](#9-formulas-rollups)

#### rolluprulestep1_13

- [Formula: azt_lastyearspend](#9-formulas-rollups)

#### rolluprulestep1_2

- [Formula: azt_accountspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_3

- [Formula: azt_accountspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_4

- [Formula: azt_accountspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_5

- [Formula: azt_accountspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_6

- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_7

- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_8

- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

#### rolluprulestep1_9

- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_yearbeforelastspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)

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

- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#107-activitiescreatedduedatesinpast)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

#### shareduser.fullname

- [View: Account Sharing Associated View](#36-account-sharing-associated-view)

#### sharedwith

- [Form: iGrad Account > Details > Section](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > Section](#25-account-main-active)

#### shippingmethodcode

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_city

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### shipto_contactname

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### shipto_country

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

#### shipto_line1

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_line2

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_line3

- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_name

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_postalcode

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### shipto_stateorprovince

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

#### softwarelicenseallocations

- [Form: Allocated Software Licenses > Tab > section](#29-allocated-software-licenses-quick-active)

#### state

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### statecode

- [Field Definitions](#1-field-definitions)
- [View: Account Associated View (Filter)](#32-account-associated-view)
- [View: Account Lookup View (Filter)](#35-account-lookup-view)
- [View: Accounts With Product Family Purchases (Filter)](#37-accounts-with-product-family-purchases)
- [View: Active Accounts in Quickbooks (Filter)](#39-active-accounts-in-quickbooks)
- [View: Active Accounts (Filter)](#310-active-accounts)
- [View: All Accounts](#311-all-accounts)
- [View: Duplicate Accounts](#312-duplicate-accounts)
- [View: Duplicate Accounts (Filter)](#312-duplicate-accounts)
- [View: GED Customers Without Kaplan (Filter)](#313-ged-customers-without-kaplan)
- [View: Inactive Accounts (Filter)](#317-inactive-accounts)
- [View: My Active Accounts (Filter)](#318-my-active-accounts)
- [View: My Active Customers With Purchase Dates (Filter)](#319-my-active-customers-with-purchase-dates)
- [View: My Connections (Filter)](#320-my-connections)
- [View: My Connections (Filter)](#320-my-connections)
- [View: New Customer Introduction List (Filter)](#321-new-customer-introduction-list)
- [View: Old Duplicate Accounts View (Filter)](#322-old-duplicate-accounts-view)
- [View: Quick Find Active Accounts (Filter)](#323-quick-find-active-accounts)
- [Workflow: BatchConverttoLead (Write)](#77-batchconverttolead)
- [Workflow: CaseResolutionNotificationEmail (Read)](#717-caseresolutionnotificationemail)
- [Workflow: CloneOrder (Write)](#722-cloneorder)
- [Workflow: CreateLeadFromLeadGen (Write)](#725-createleadfromleadgen)
- [Workflow: CreateLeadfromAccount (Write)](#726-createleadfromaccount)
- [Workflow: CustomLeadCreation (Write)](#727-customleadcreation)
- [Workflow: LeadQualifyDisqualifyDate (Read)](#733-leadqualifydisqualifydate)
- [Workflow: OpportunityAuditRemoval (Read)](#737-opportunityauditremoval)
- [Workflow: TaskCreateReorderLead (Write)](#755-taskcreatereorderlead)
- [Workflow: WonOpportunityEmail (Read)](#756-wonopportunityemail)
- [Formula: azt_accountspend](#9-formulas-rollups)
- [Formula: azt_lastyearspend](#9-formulas-rollups)
- [Formula: azt_ytdspend](#9-formulas-rollups)
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

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)
- [View: Account Advanced Find View](#31-account-advanced-find-view)
- [View: Account Associated View](#32-account-associated-view)
- [View: Account BulkOperation View](#33-account-bulkoperation-view)
- [View: Account List Member View](#34-account-list-member-view)
- [View: Account Lookup View](#35-account-lookup-view)
- [View: Accounts With Product Family Purchases](#37-accounts-with-product-family-purchases)
- [View: Accounts: No Orders in Last 6 Months](#38-accounts-no-orders-in-last-6-months)
- [View: Active Accounts in Quickbooks](#39-active-accounts-in-quickbooks)
- [View: Active Accounts](#310-active-accounts)
- [View: All Accounts](#311-all-accounts)
- [View: Duplicate Accounts](#312-duplicate-accounts)
- [View: GED Customers Without Kaplan](#313-ged-customers-without-kaplan)
- [View: GED Flash/Play Without Any GED](#314-ged-flashplay-without-any-ged)
- [View: GED/KaplanGED Customers Without Flash](#315-gedkaplanged-customers-without-flash)
- [View: HiSET Customers Without Kaplan HiSET](#316-hiset-customers-without-kaplan-hiset)
- [View: Inactive Accounts](#317-inactive-accounts)
- [View: My Active Accounts](#318-my-active-accounts)
- [View: My Active Customers With Purchase Dates](#319-my-active-customers-with-purchase-dates)
- [View: My Connections](#320-my-connections)
- [View: New Customer Introduction List](#321-new-customer-introduction-list)
- [View: Quick Find Active Accounts](#323-quick-find-active-accounts)
- [View: Quick Find Active Accounts (Filter)](#323-quick-find-active-accounts)
- [View: TASC Customers Without Kaplan TASC](#324-tasc-customers-without-kaplan-tasc)
- [JS: azt_accountlibrary > formatMe()](#82-azt_accountlibrary)
- [JS: azt_accountlibrary > formatNumber()](#82-azt_accountlibrary)
- [JS: azt_phonecalllibrary > onLoad()](#812-azt_phonecalllibrary)
- [Plugin: LeadImport (Write)](#1036-leadimport)

#### telephone2

- [Field Definitions](#1-field-definitions)

#### title

- [Report: PAQuoteReport > QuoteHeader > systemuser](#51-paquotereport)
- [Plugin: CreateUserGoals (Write)](#1022-createusergoals)
- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

#### tm.systemuserid

- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)

#### to

- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

#### totalamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Plugin: FundingSetAnnualSpend (Read)](#1028-fundingsetannualspend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#1034-invoiceclosepaidonpercentage)
- [Plugin: PaymentUpdate (Read)](#1058-paymentupdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#1066-quotesynctotaltoopportunity)

#### totallineitemamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)

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

#### webresource_recordwall

- [Form: Information > What's New > Section](#24-information-main-inactive)

#### websiteurl

- [Field Definitions](#1-field-definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#22-igrad-account-main-active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#25-account-main-active)

#### writeteam

- [Form: iGrad Account > Details > section](#22-igrad-account-main-active)
- [Form: Account > DETAILS_TAB > section](#25-account-main-active)

#### zipcode

- [PCF: Bing Address Autocomplete](#11-pcf-controls)

#### {0}

- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
