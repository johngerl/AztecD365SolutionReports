# Account Field Usage Analysis
> Date: 2026-03-25

| Property | Value |
|---|---|
| **Entity Name** | account |
| **Display Name** | Account |
| **Description** | Business that represents a customer or potential customer. The company that is billed in business transactions. |
| **Object Type** | Standard |
| **Ownership Type** | UserOwned |
| **Audit Enabled** | True |
| **Total Rows** | 0 |
| **Last Update** |  |
| **Primary ID Field** | accountid |
| **Primary Name Field** | name |
| **Count Forms** | 106 |
| **Count Views** | 207 |
| **Count Chart Visualizations** | 0 |
| **Count Reports** | 8 |
| **Count Dashboards** | 0 |
| **Count Workflows** | 179 |
| **Count Formulas & Rollups** | 7 |
| **Count Plugins** | 132 |
| **Count PCF Controls** | 0 |
| **Count Relationships** | 23 |
| **Count Ribbon Customizations** | 0 |

## Table of Contents

- [1. Field Definitions](#1.%20Field%20Definitions)
- [2. Forms](#2.%20Forms)
  - [2.1. TimelineWallControl - Account- Main - main - Active](#2.1.%20TimelineWallControl%20-%20Account-%20Main%20-%20main%20-%20Active)
  - [2.2. iGrad Account - main - Active](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
  - [2.3. AI for Sales - main - Inactive](#2.3.%20AI%20for%20Sales%20-%20main%20-%20Inactive)
  - [2.4. Information - main - Inactive](#2.4.%20Information%20-%20main%20-%20Inactive)
  - [2.5. Account - main - Active](#2.5.%20Account%20-%20main%20-%20Active)
  - [2.6. Purchased Software Licenses - quick - Active](#2.6.%20Purchased%20Software%20Licenses%20-%20quick%20-%20Active)
  - [2.7. Account Owner Card - quick - Active](#2.7.%20Account%20Owner%20Card%20-%20quick%20-%20Active)
  - [2.8. Last Purchase Dates Quick View - quick - Active](#2.8.%20Last%20Purchase%20Dates%20Quick%20View%20-%20quick%20-%20Active)
  - [2.9. Allocated Software Licenses - quick - Active](#2.9.%20Allocated%20Software%20Licenses%20-%20quick%20-%20Active)
  - [2.10. Account Lead Quick View - quick - Active](#2.10.%20Account%20Lead%20Quick%20View%20-%20quick%20-%20Active)
  - [2.11. Account Owner Quick View - quick - Active](#2.11.%20Account%20Owner%20Quick%20View%20-%20quick%20-%20Active)
  - [2.12. Engagement Contacts - quick - Active](#2.12.%20Engagement%20Contacts%20-%20quick%20-%20Active)
- [3. Views](#3.%20Views)
  - [3.1. Account Advanced Find View](#3.1.%20Account%20Advanced%20Find%20View)
  - [3.2. Account Associated View](#3.2.%20Account%20Associated%20View)
  - [3.3. Account BulkOperation View](#3.3.%20Account%20BulkOperation%20View)
  - [3.4. Account List Member View](#3.4.%20Account%20List%20Member%20View)
  - [3.5. Account Lookup View](#3.5.%20Account%20Lookup%20View)
  - [3.6. Account Sharing Associated View](#3.6.%20Account%20Sharing%20Associated%20View)
  - [3.7. Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
  - [3.8. Accounts: No Orders in Last 6 Months](#3.8.%20Accounts%3A%20No%20Orders%20in%20Last%206%20Months)
  - [3.9. Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
  - [3.10. Active Accounts](#3.10.%20Active%20Accounts)
  - [3.11. All Accounts](#3.11.%20All%20Accounts)
  - [3.12. Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
  - [3.13. GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
  - [3.14. GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
  - [3.15. GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
  - [3.16. HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
  - [3.17. Inactive Accounts](#3.17.%20Inactive%20Accounts)
  - [3.18. My Active Accounts](#3.18.%20My%20Active%20Accounts)
  - [3.19. My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
  - [3.20. My Connections](#3.20.%20My%20Connections)
  - [3.21. New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
  - [3.22. Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
  - [3.23. Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
  - [3.24. TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [4. Chart Visualizations](#4.%20Chart%20Visualizations)
- [5. Reports](#5.%20Reports)
  - [5.1. PAQuoteReport](#5.1.%20PAQuoteReport)
  - [5.2. SharedAccountRecords](#5.2.%20SharedAccountRecords)
- [6. Dashboards](#6.%20Dashboards)
- [7. Workflows](#7.%20Workflows)
  - [7.1. 0ChangeQuoteRecordOwner](#7.1.%200ChangeQuoteRecordOwner)
  - [7.2. 0EngagementNames](#7.2.%200EngagementNames)
  - [7.3. AccountAuto-Assign](#7.3.%20AccountAuto-Assign)
  - [7.4. AccountClearCustomerIntro](#7.4.%20AccountClearCustomerIntro)
  - [7.5. AllocationsAssigntoTeam](#7.5.%20AllocationsAssigntoTeam)
  - [7.6. AppointmentAuto-Assign](#7.6.%20AppointmentAuto-Assign)
  - [7.7. BatchConverttoLead](#7.7.%20BatchConverttoLead)
  - [7.8. BatchCreateEngagements](#7.8.%20BatchCreateEngagements)
  - [7.9. BatchCreateIntroCall](#7.9.%20BatchCreateIntroCall)
  - [7.10. BatchLooseOpportunities](#7.10.%20BatchLooseOpportunities)
  - [7.11. BatchOpportunityTransfer](#7.11.%20BatchOpportunityTransfer)
  - [7.12. BulkChangeLeadSource](#7.12.%20BulkChangeLeadSource)
  - [7.13. CasePendingAssignmentNotification](#7.13.%20CasePendingAssignmentNotification)
  - [7.14. CaseRecordOwner](#7.14.%20CaseRecordOwner)
  - [7.15. CaseRecordOwnerAssign](#7.15.%20CaseRecordOwnerAssign)
  - [7.16. CaseRecordOwnerAssignmentNotification](#7.16.%20CaseRecordOwnerAssignmentNotification)
  - [7.17. CaseResolutionNotificationEmail](#7.17.%20CaseResolutionNotificationEmail)
  - [7.18. CloneAndDeleteQuote](#7.18.%20CloneAndDeleteQuote)
  - [7.19. CloneCommissionPayment](#7.19.%20CloneCommissionPayment)
  - [7.20. CloneLicense](#7.20.%20CloneLicense)
  - [7.21. CloneOpportunity](#7.21.%20CloneOpportunity)
  - [7.22. CloneOrder](#7.22.%20CloneOrder)
  - [7.23. ContactAuto-Assign](#7.23.%20ContactAuto-Assign)
  - [7.24. ContactMapAddresses](#7.24.%20ContactMapAddresses)
  - [7.25. CreateLeadFromLeadGen](#7.25.%20CreateLeadFromLeadGen)
  - [7.26. CreateLeadfromAccount](#7.26.%20CreateLeadfromAccount)
  - [7.27. CustomLeadCreation](#7.27.%20CustomLeadCreation)
  - [7.28. EngagementRecordOwner](#7.28.%20EngagementRecordOwner)
  - [7.29. EngagementRecordOwnerTeam](#7.29.%20EngagementRecordOwnerTeam)
  - [7.30. FSRLeadDistibutionNotification](#7.30.%20FSRLeadDistibutionNotification)
  - [7.31. InvoiceRecordOwner](#7.31.%20InvoiceRecordOwner)
  - [7.32. LeadAssignment](#7.32.%20LeadAssignment)
  - [7.33. LeadQualifyDisqualifyDate](#7.33.%20LeadQualifyDisqualifyDate)
  - [7.34. LeadSourceChange](#7.34.%20LeadSourceChange)
  - [7.35. MarkAccountsExcludefromAuto-assign](#7.35.%20MarkAccountsExcludefromAuto-assign)
  - [7.36. NewFSRLeadNotification](#7.36.%20NewFSRLeadNotification)
  - [7.37. OpportunityAuditRemoval](#7.37.%20OpportunityAuditRemoval)
  - [7.38. OpportunityRecordOwner](#7.38.%20OpportunityRecordOwner)
  - [7.39. OpportunityRecordOwnerTeam](#7.39.%20OpportunityRecordOwnerTeam)
  - [7.40. OrderRecordOwner](#7.40.%20OrderRecordOwner)
  - [7.41. PhonecallAuto-Assign](#7.41.%20PhonecallAuto-Assign)
  - [7.42. PrintPurchaseAssigntoTeam](#7.42.%20PrintPurchaseAssigntoTeam)
  - [7.43. QualifyLead](#7.43.%20QualifyLead)
  - [7.44. QuoteRecordOwner](#7.44.%20QuoteRecordOwner)
  - [7.45. QuoteRecordOwnerTeam](#7.45.%20QuoteRecordOwnerTeam)
  - [7.46. RenameEngagements](#7.46.%20RenameEngagements)
  - [7.47. SendQuote](#7.47.%20SendQuote)
  - [7.48. SetBusinessAddressNameField](#7.48.%20SetBusinessAddressNameField)
  - [7.49. SetLeadTemperature](#7.49.%20SetLeadTemperature)
  - [7.50. SetPhysicalAddressNameField](#7.50.%20SetPhysicalAddressNameField)
  - [7.51. SoftwareLicenseAssigntoTeam](#7.51.%20SoftwareLicenseAssigntoTeam)
  - [7.52. SoftwareLicenseCreateEngagement](#7.52.%20SoftwareLicenseCreateEngagement)
  - [7.53. SoftwareLicenseSetOwner](#7.53.%20SoftwareLicenseSetOwner)
  - [7.54. TaskAuto-Assign](#7.54.%20TaskAuto-Assign)
  - [7.55. TaskCreateReorderLead](#7.55.%20TaskCreateReorderLead)
  - [7.56. WonOpportunityEmail](#7.56.%20WonOpportunityEmail)
  - [7.57. WorkforceAccountAuto-assign](#7.57.%20WorkforceAccountAuto-assign)
  - [7.58. WorkforceAppointmentAuto-Assign](#7.58.%20WorkforceAppointmentAuto-Assign)
  - [7.59. WorkforceCaseAuto-assign](#7.59.%20WorkforceCaseAuto-assign)
  - [7.60. WorkforceContactAuto-assign](#7.60.%20WorkforceContactAuto-assign)
  - [7.61. WorkforceEngagementAuto-assign](#7.61.%20WorkforceEngagementAuto-assign)
  - [7.62. WorkforceLeadAuto-Assign](#7.62.%20WorkforceLeadAuto-Assign)
  - [7.63. WorkforceOpportunityAuto-assign](#7.63.%20WorkforceOpportunityAuto-assign)
  - [7.64. WorkforcePhone-callAuto-assign](#7.64.%20WorkforcePhone-callAuto-assign)
  - [7.65. WorkforceQuoteAuto-assign](#7.65.%20WorkforceQuoteAuto-assign)
  - [7.66. iGradAppointmentAuto-Assign](#7.66.%20iGradAppointmentAuto-Assign)
  - [7.67. iGradCaseAuto-Assign](#7.67.%20iGradCaseAuto-Assign)
  - [7.68. iGradPhone-callAuto-assign](#7.68.%20iGradPhone-callAuto-assign)
- [8. JavaScript Web Resources](#8.%20JavaScript%20Web%20Resources)
  - [8.1. azt_FindAccountsWithinBoundModified](#8.1.%20azt_FindAccountsWithinBoundModified)
  - [8.2. azt_accountlibrary](#8.2.%20azt_accountlibrary)
  - [8.3. azt_addresslibrary](#8.3.%20azt_addresslibrary)
  - [8.4. azt_caselibrary](#8.4.%20azt_caselibrary)
  - [8.5. azt_contactlibrary](#8.5.%20azt_contactlibrary)
  - [8.6. azt_engagementlibrary](#8.6.%20azt_engagementlibrary)
  - [8.7. azt_invoicelibrary](#8.7.%20azt_invoicelibrary)
  - [8.8. azt_leadlibrary](#8.8.%20azt_leadlibrary)
  - [8.9. azt_opportunitylibrary](#8.9.%20azt_opportunitylibrary)
  - [8.10. azt_opportunitytrackdiscount](#8.10.%20azt_opportunitytrackdiscount)
  - [8.11. azt_orderlibrary](#8.11.%20azt_orderlibrary)
  - [8.12. azt_phonecalllibrary](#8.12.%20azt_phonecalllibrary)
  - [8.13. azt_productdiscountlibrary](#8.13.%20azt_productdiscountlibrary)
  - [8.14. azt_quotelibrary](#8.14.%20azt_quotelibrary)
  - [8.15. azt_sendquote](#8.15.%20azt_sendquote)
- [9. Formulas and Rollups](#9.%20Formulas%20and%20Rollups)
- [10. Plugin Source Code Analysis](#10.%20Plugin%20Source%20Code%20Analysis)
  - [10.1. AccountAutoAssign](#10.1.%20AccountAutoAssign)
  - [10.2. AccountLeadGen](#10.2.%20AccountLeadGen)
  - [10.3. AccountLeadGenAssociate](#10.3.%20AccountLeadGenAssociate)
  - [10.4. AccountReassignmentShareRecords](#10.4.%20AccountReassignmentShareRecords)
  - [10.5. AccountTypeSet](#10.5.%20AccountTypeSet)
  - [10.6. ActivateOrReviseQuote](#10.6.%20ActivateOrReviseQuote)
  - [10.7. ActivitiesCreatedDueDatesInPast](#10.7.%20ActivitiesCreatedDueDatesInPast)
  - [10.8. ActivityCloseForceRecordOwner](#10.8.%20ActivityCloseForceRecordOwner)
  - [10.9. ActivityRegardingGetState](#10.9.%20ActivityRegardingGetState)
  - [10.10. AddressSearchCleanupFields](#10.10.%20AddressSearchCleanupFields)
  - [10.11. AllocationValidation](#10.11.%20AllocationValidation)
  - [10.12. AutoAssignStateAbb](#10.12.%20AutoAssignStateAbb)
  - [10.13. AutoNumber](#10.13.%20AutoNumber)
  - [10.14. CaseAudit](#10.14.%20CaseAudit)
  - [10.15. CaseClose](#10.15.%20CaseClose)
  - [10.16. ChangeLicenseType](#10.16.%20ChangeLicenseType)
  - [10.17. CloneExpenseLine](#10.17.%20CloneExpenseLine)
  - [10.18. CompGoalCreate](#10.18.%20CompGoalCreate)
  - [10.19. ContactSetConnectionRole](#10.19.%20ContactSetConnectionRole)
  - [10.20. CreateCompGoals](#10.20.%20CreateCompGoals)
  - [10.21. CreateSoftwareLicenses](#10.21.%20CreateSoftwareLicenses)
  - [10.22. CreateUserGoals](#10.22.%20CreateUserGoals)
  - [10.23. DiscretionaryDiscountSetHeader](#10.23.%20DiscretionaryDiscountSetHeader)
  - [10.24. EngagementFSRAssignedOn](#10.24.%20EngagementFSRAssignedOn)
  - [10.25. EngagementSetEndDate](#10.25.%20EngagementSetEndDate)
  - [10.26. ExpenseLineTotals](#10.26.%20ExpenseLineTotals)
  - [10.27. ExpenseRestrictVisibility](#10.27.%20ExpenseRestrictVisibility)
  - [10.28. FundingSetAnnualSpend](#10.28.%20FundingSetAnnualSpend)
  - [10.29. FundingTotalAmt](#10.29.%20FundingTotalAmt)
  - [10.30. FundingYearSync](#10.30.%20FundingYearSync)
  - [10.31. GetAcctTeamOwned](#10.31.%20GetAcctTeamOwned)
  - [10.32. GetUserHasRole](#10.32.%20GetUserHasRole)
  - [10.33. GetUserHasRoleToAction](#10.33.%20GetUserHasRoleToAction)
  - [10.34. InvoiceClosePaidOnPercentage](#10.34.%20InvoiceClosePaidOnPercentage)
  - [10.35. InvoiceCompCompleted](#10.35.%20InvoiceCompCompleted)
  - [10.36. LeadImport](#10.36.%20LeadImport)
  - [10.37. LeadImportPopulateName](#10.37.%20LeadImportPopulateName)
  - [10.38. LeadQualify](#10.38.%20LeadQualify)
  - [10.39. LeadQualifyParentStakeholderContacts](#10.39.%20LeadQualifyParentStakeholderContacts)
  - [10.40. ManualDiscountKill](#10.40.%20ManualDiscountKill)
  - [10.41. OppAuditRemoval](#10.41.%20OppAuditRemoval)
  - [10.42. OpportunityAssignFromLead](#10.42.%20OpportunityAssignFromLead)
  - [10.43. OpportunityAudit](#10.43.%20OpportunityAudit)
  - [10.44. OpportunityClone](#10.44.%20OpportunityClone)
  - [10.45. OpportunityLastActivityDate](#10.45.%20OpportunityLastActivityDate)
  - [10.46. OpportunityLineSyncToQuote](#10.46.%20OpportunityLineSyncToQuote)
  - [10.47. OpportunityPreventCreateQuote](#10.47.%20OpportunityPreventCreateQuote)
  - [10.48. OpportunityProbabilityChange](#10.48.%20OpportunityProbabilityChange)
  - [10.49. OpportunityProbabilityNumber](#10.49.%20OpportunityProbabilityNumber)
  - [10.50. OpptyToQuoteFieldMappings](#10.50.%20OpptyToQuoteFieldMappings)
  - [10.51. OrderClone](#10.51.%20OrderClone)
  - [10.52. OrderFSRSetTemplateFields](#10.52.%20OrderFSRSetTemplateFields)
  - [10.53. OrderLinePopulateLicType](#10.53.%20OrderLinePopulateLicType)
  - [10.54. OrderLinePopulateTemplateFields](#10.54.%20OrderLinePopulateTemplateFields)
  - [10.55. OrderManuallyCreateSoftwareLicense](#10.55.%20OrderManuallyCreateSoftwareLicense)
  - [10.56. OrderSplit](#10.56.%20OrderSplit)
  - [10.57. OrderStageTracking](#10.57.%20OrderStageTracking)
  - [10.58. PaymentUpdate](#10.58.%20PaymentUpdate)
  - [10.59. PhonecallCreateCallback](#10.59.%20PhonecallCreateCallback)
  - [10.60. ProductDiscountPreventOnActiveQuote](#10.60.%20ProductDiscountPreventOnActiveQuote)
  - [10.61. QuoteCloneAndDelete](#10.61.%20QuoteCloneAndDelete)
  - [10.62. QuoteLinesSyncToOppty](#10.62.%20QuoteLinesSyncToOppty)
  - [10.63. QuoteOrderProductsTrackDiscount](#10.63.%20QuoteOrderProductsTrackDiscount)
  - [10.64. QuotePreventActivateUnapprovedDiscounts](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
  - [10.65. QuotePreventActivateUnapprovedFreight](#10.65.%20QuotePreventActivateUnapprovedFreight)
  - [10.66. QuoteSyncTotalToOpportunity](#10.66.%20QuoteSyncTotalToOpportunity)
  - [10.67. RecordOwnerRestrictEdit](#10.67.%20RecordOwnerRestrictEdit)
  - [10.68. RestrictCreateQuote](#10.68.%20RestrictCreateQuote)
  - [10.69. RestrictProductLookups](#10.69.%20RestrictProductLookups)
  - [10.70. RestrictWinOpportunities](#10.70.%20RestrictWinOpportunities)
  - [10.71. RestrictWinQuote](#10.71.%20RestrictWinQuote)
  - [10.72. ReviseQuoteDiscountMove](#10.72.%20ReviseQuoteDiscountMove)
  - [10.73. SendQuoteReport](#10.73.%20SendQuoteReport)
  - [10.74. SetOppProductDefaults](#10.74.%20SetOppProductDefaults)
  - [10.75. SetPrimaryContact](#10.75.%20SetPrimaryContact)
  - [10.76. ShareBasedOnAccessTeam](#10.76.%20ShareBasedOnAccessTeam)
  - [10.77. ShareFromAccountShares](#10.77.%20ShareFromAccountShares)
  - [10.78. ShareWithAccountOwner](#10.78.%20ShareWithAccountOwner)
  - [10.79. ShipmentSetTrackingNumber](#10.79.%20ShipmentSetTrackingNumber)
  - [10.80. UpdateOppFromQuote](#10.80.%20UpdateOppFromQuote)
  - [10.81. Utility](#10.81.%20Utility)
- [11. PCF Controls](#11.%20PCF%20Controls)
- [12. Relationships](#12.%20Relationships)
- [13. Ribbon Customizations](#13.%20Ribbon%20Customizations)
- [14. Conflicts and Observations](#14.%20Conflicts%20and%20Observations)
- [Index](#index)

---

## 1. Field Definitions

Total fields: **133**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Last Update | Flags | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------|-------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [accountclassificationcode](#accountclassificationcode) | Account Classification | picklist | 1: A, 276530000: B, 276530001: C, 100000001: D, 100000000: E, 276530002: S, 276530003: N/A, 276530004: aa, 276530005: bb, 276530006: cc, 276530007: ss | No | none |  | C R U Re | true | Account | CRM Account Classification | CRM_Account_Classification__c | Account | Account Classification | Account_Classification__c | [2](#2.%20Forms) | [12](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 2 | [accountid](#accountid) | Account | uniqueidentifier |  | No | required |  | R | false |  |  |  |  |  |  |  | [23](#3.%20Views) |  | [1](#5.%20Reports) |  | [8](#7.%20Workflows) |  | [12](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 3 | [accountnumber](#accountnumber) | Sequence Number | nvarchar |  | No | none |  | C R U | true |  |  |  | Account | Account Number | AccountNumber |  | [1](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 4 | [address1_addresstypecode](#address1_addresstypecode) | Physical Address Type | picklist | 3: Physical, 1: Bill To, 2: Ship To, 4: Other | No | none |  | C R U L | true |  |  |  | Account | Physical Address Type | Physical_Address_Type__c | [2](#2.%20Forms) |  |  |  |  | [5](#7.%20Workflows) |  |  |  |  |  |  |
| 5 | [address1_city](#address1_city) | Physical Address City | nvarchar |  | No | none |  | C R U So G L Re | true |  |  |  | Account | Business Address (City) | Business_Address__City__s | [2](#2.%20Forms) | [17](#3.%20Views) |  |  |  | [3](#7.%20Workflows) |  |  |  |  |  |  |
| 6 | [address1_composite](#address1_composite) | Physical Address | ntext |  | No | none |  | R L | true |  |  |  | Account | Physical Address | Physical_Address__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 7 | [address1_country](#address1_country) | Physical Address Country/Region | nvarchar |  | No | recommended |  | C R U L | true |  |  |  | Account | Billing Country | BillingCountry | [2](#2.%20Forms) |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 8 | [address1_county](#address1_county) | Physical Address County | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Physical Address County | Physical_Address_County__c |  |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 9 | [address1_fax](#address1_fax) | Physical Address Fax | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Physical Address Fax | Physical_Address_Fax__c |  | [1](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 10 | [address1_freighttermscode](#address1_freighttermscode) | Physical Address Freight Terms | picklist | 1: FOB, 2: No Charge | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 11 | [address1_latitude](#address1_latitude) | Physical Address Latitude | float |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 12 | [address1_line1](#address1_line1) | Physical Address Street 1 | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Billing Street | BillingStreet | [3](#2.%20Forms) |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 13 | [address1_line2](#address1_line2) | Physical Address Street 2 | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Physical Address Street 2 | Physical_Address_Street_2__c | [2](#2.%20Forms) |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 14 | [address1_line3](#address1_line3) | Physical Address Street 3 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 15 | [address1_longitude](#address1_longitude) | Physical Address Longitude | float |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 16 | [address1_name](#address1_name) | Physical Address Name | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Physical Address Name | Physical_Address_Name__c | [2](#2.%20Forms) | [1](#3.%20Views) |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 17 | [address1_postalcode](#address1_postalcode) | Physical Address ZIP/Postal Code | nvarchar |  | No | none |  | C R U So G L | true |  |  |  | Account | Business Address (ZIP/Postal Code) | Business_Address__PostalCode__s | [2](#2.%20Forms) |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 18 | [address1_postofficebox](#address1_postofficebox) | Physical Address Post Office Box | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 19 | [address1_primarycontactname](#address1_primarycontactname) | Physical Address Primary Contact Name | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 20 | [address1_shippingmethodcode](#address1_shippingmethodcode) | Physical Address Shipping Method | picklist | 1: Airborne, 2: DHL, 3: FedEx, 4: UPS, 5: Postal Mail, 6: Full Load, 7: Will Call | No | none |  | C R U L | true |  |  |  | Account | Physical Address Shipping Method | Physical_Address_Shipping_Method__c |  |  |  |  |  | [5](#7.%20Workflows) |  |  |  |  |  |  |
| 21 | [address1_stateorprovince](#address1_stateorprovince) | Physical Address State/Province | nvarchar |  | No | recommended |  | C R U L Re | true |  |  |  | Account | Billing State/Province | BillingState | [2](#2.%20Forms) | [15](#3.%20Views) |  |  |  | [10](#7.%20Workflows) |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 22 | [address1_telephone1](#address1_telephone1) | Physical Address Phone | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Physical Address Phone | Physical_Address_Phone__c |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 23 | [address1_telephone2](#address1_telephone2) | Physical Address Telephone 2 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 24 | [address1_telephone3](#address1_telephone3) | Physical Address Telephone 3 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 25 | [address1_upszone](#address1_upszone) | Physical Address UPS Zone | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 26 | [address1_utcoffset](#address1_utcoffset) | Physical Address UTC Offset | int |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 27 | [address2_addresstypecode](#address2_addresstypecode) | Bill To Address Type | picklist | 3: Physical, 1: Bill To, 2: Ship To, 4: Other | No | none |  | C R U L | true |  |  |  | Account | Bill To Address Type | Bill_To_Address_Type__c |  |  |  |  |  | [5](#7.%20Workflows) |  |  |  |  |  |  |
| 28 | [address2_city](#address2_city) | Bill To City | nvarchar |  | No | none |  | C R U L | false | Account | BillingCity | BillingCity |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 29 | [address2_composite](#address2_composite) | Bill To Address | ntext |  | No | none |  | R L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 30 | [address2_country](#address2_country) | Bill To Country/Region | nvarchar |  | No | none |  | C R U L | true | Account | BillingCountry | BillingCountry | Account | Shipping Country | ShippingCountry |  |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 31 | [address2_county](#address2_county) | Bill To County | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Bill To County | Bill_To_County__c |  |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 32 | [address2_fax](#address2_fax) | Bill To Fax | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 33 | [address2_freighttermscode](#address2_freighttermscode) | Bill To Freight Terms | picklist | 1: Default Value | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 34 | [address2_latitude](#address2_latitude) | Bill To Latitude | float |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 35 | [address2_line1](#address2_line1) | Bill To Street 1 | nvarchar |  | No | none |  | C R U L | true | Account | BillingStreet | BillingStreet | Account | Shipping Street | ShippingStreet |  |  |  | [1](#5.%20Reports) |  |  |  |  |  |  |  |  |
| 36 | [address2_line2](#address2_line2) | Bill To Street 2 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 37 | [address2_line3](#address2_line3) | Bill To Street 3 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 38 | [address2_longitude](#address2_longitude) | Bill To Longitude | float |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 39 | [address2_name](#address2_name) | Bill To Address Name | nvarchar |  | No | none |  | C R U L | true |  |  |  | Account | Bill To Address Name | Bill_To_Address_Name__c |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 40 | [address2_postalcode](#address2_postalcode) | Bill To ZIP/Postal Code | nvarchar |  | No | none |  | C R U L | false | Account | BillingPostalCode | BillingPostalCode |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 41 | [address2_postofficebox](#address2_postofficebox) | Bill To Post Office Box | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 42 | [address2_primarycontactname](#address2_primarycontactname) | Bill To Primary Contact Name | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 43 | [address2_shippingmethodcode](#address2_shippingmethodcode) | Bill To Shipping Method | picklist | 1: Default Value | No | none |  | C R U L | true |  |  |  | Account | Bill To Shipping Method | Bill_To_Shipping_Method__c |  |  |  |  |  | [5](#7.%20Workflows) |  |  |  |  |  |  |
| 44 | [address2_stateorprovince](#address2_stateorprovince) | Bill To State/Province | nvarchar |  | No | none |  | C R U L | false | Account | BillingState | BillingState |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 45 | [address2_telephone1](#address2_telephone1) | Bill To Telephone 1 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 46 | [address2_telephone2](#address2_telephone2) | Bill To Telephone 2 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 47 | [address2_telephone3](#address2_telephone3) | Bill To Telephone 3 | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 48 | [address2_upszone](#address2_upszone) | Bill To UPS Zone | nvarchar |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 49 | [address2_utcoffset](#address2_utcoffset) | Bill To UTC Offset | int |  | No | none |  | C R U L | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 50 | [azt_accountalert](#azt_accountalert) | Account Alert | nvarchar |  | Yes | none |  | C R U | true | Account | Account Alert | Account_Alert__c | Account | Account Alert | Account_Alert__c | [2](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 51 | [azt_accountleadgenname](#azt_accountleadgenname) | Account Lead Gen Name | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Account Lead Gen Name | Account_Lead_Gen_Name__c |  |  |  |  |  | [1](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 52 | [azt_accountnumber](#azt_accountnumber) | Account Number | nvarchar |  | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 53 | [azt_accountspend](#azt_accountspend) | Lifetime Spend | money |  | Yes | none |  | R | true |  |  |  | Account | Lifetime Spend | Lifetime_Spend__c | [1](#2.%20Forms) |  |  |  |  |  | [1](#9.%20Formulas%20and%20Rollups) |  |  |  |  |  |
| 54 | [azt_accountspend_base](#azt_accountspend_base) | Account Spend (Base) | money |  | Yes | none |  | R | false | Account | CRM Account Spend (Base) | CRM_Account_Spend__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 55 | [azt_accounttype](#azt_accounttype) | Account Type | picklist | 276530000: Active Account, 276530001: Expired Account, 276530007: Prospect, 276530005: Trade Show, 276530003: Partner, 276530006: Vendor, 276530004: Pilot, 276530002: Other, 100000000: Active | Yes | none |  | C R U S Re | true | Account | Account Status | Account_Status__c | Account | CRM Account Spend (Base) | CRM_Account_Spend__c | [5](#2.%20Forms) | [11](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 56 | [azt_addresssearch](#azt_addresssearch) | Address Search | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Address Search | Address_Search__c | [2](#2.%20Forms) |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 57 | [azt_addresssearch2](#azt_addresssearch2) | Address Search 2 | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Address Search 2 | Address_Search_2__c |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 58 | [azt_aeflafunding](#azt_aeflafunding) | AEFLA Funding | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  | Account | Aefla Funding | Aefla_Funding__c | [2](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 59 | [azt_customerintrocompletedby](#azt_customerintrocompletedby) | Customer Intro Completed By | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Customer Intro Completed By | Customer_Intro_Completed_By__c |  |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 60 | [azt_customerintrocompletedon](#azt_customerintrocompletedon) | Customer Intro Completed On | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Customer Intro Completed On | Customer_Intro_Completed_On__c |  |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 61 | [azt_customerintroductioncompleted](#azt_customerintroductioncompleted) | Customer Introduction Completed | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  | Account | Customer Introduction Completed | Customer_Introduction_Completed__c |  | [1](#3.%20Views) |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 62 | [azt_customernumber](#azt_customernumber) | Customer Number | nvarchar |  | Yes | recommended |  | C R U S Re | true | Account | Customer Number | Customer_Number__c | Account | Customer Number | Customer_Number__c | [4](#2.%20Forms) | [5](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 63 | [azt_customerof](#azt_customerof) | Customer Of | picklist | 276530000: Aztec, 276530001: Life Skills, 276530002: Aztec & Life Skills | Yes | none |  | C R U | true |  |  |  | Account | Customer Number | Customer_Number__c | [2](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 64 | [azt_digitalstatus](#azt_digitalstatus) | Digital Status | picklist |  | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 65 | [azt_duplicate](#azt_duplicate) | Duplicate? | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Duplicate | Duplicate__c |  | [1](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 66 | [azt_excludefromautoassign](#azt_excludefromautoassign) | Exclude from Autoassign? | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  | Account | Exclude From Autoassign | Exclude_From_Autoassign__c | [2](#2.%20Forms) |  |  |  |  | [3](#7.%20Workflows) |  |  |  |  |  |  |
| 67 | [azt_executivesummary](#azt_executivesummary) | Executive Summary | ntext |  | Yes | none |  | C R U | true | Account | Executive Summary | Executive_Summary__c | Account | Executive Summary | Executive_Summary__c | [2](#2.%20Forms) |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 68 | [azt_extension](#azt_extension) | Ext | nvarchar |  | Yes | none |  | C R U | true | Account | Ext | Ext__c | Account | Ext | Ext__c | [2](#2.%20Forms) |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 69 | [azt_fiscalyearend](#azt_fiscalyearend) | Fiscal Year End | picklist |  | Yes | none |  | C R U | true | Account | Fiscal Year End | Fiscal_Year_End__c | Account | Fiscal Year End | Fiscal_Year_End__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 70 | [azt_fsradminpassword](#azt_fsradminpassword) | FSR Admin Password | nvarchar |  | Yes | none |  | C R U | false | Account | FSR Admin Password | FSR_Admin_Password__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 71 | [azt_fsradminusername](#azt_fsradminusername) | FSR Admin Username | nvarchar |  | Yes | none |  | C R U | false | Account | FSR Admin Username | FSR_Admin_Username__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 72 | [azt_gedprintnoflashplay](#azt_gedprintnoflashplay) | GED Print NO Flash/Play | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 73 | [azt_gedprintnogedsoftware](#azt_gedprintnogedsoftware) | GED Print - NO GED Software | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 74 | [azt_historicalowner](#azt_historicalowner) | Historical Owner | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Historical Owner | Historical_Owner__c | [2](#2.%20Forms) |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 75 | [azt_isautoduplicate](#azt_isautoduplicate) | Is Auto Duplicate? | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 76 | [azt_isduplicate](#azt_isduplicate) | Is Duplicate | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  | Account | Is Duplicate | Is_Duplicate__c |  | [1](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 77 | [azt_isinquickbooks](#azt_isinquickbooks) | Is In Quickbooks? | picklist | 0: Yes, 1: No, 2: Possible | Yes | none |  | C R U | true |  |  |  | Account | Is In Quickbooks | Is_In_Quickbooks__c |  | [1](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 78 | [azt_ismatched](#azt_ismatched) | Is Matched? | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 79 | [azt_lastactivitydate](#azt_lastactivitydate) | Last Activity Date | datetime |  | Yes | none |  | C R U | true |  |  |  | Account | Last Activity | LastActivityDate |  | [2](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 80 | [azt_lastprintpurchase](#azt_lastprintpurchase) | Last Print Purchase | datetime |  | Yes | none |  | C R U | true | Account | CRM Last Print Purchase | CRM_Last_Print_Purchase__c | Account | Last Print Purchase | Last_Print_Purchase__c | [3](#2.%20Forms) | [5](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 81 | [azt_lastsaaspurchase](#azt_lastsaaspurchase) | Last SaaS Purchase | datetime |  | Yes | none |  | C R U | true | Account | CRM Last SaaS Purchase | CRM_Last_SaaS_Purchase__c | Account | Last SaaS Purchase | Last_SaaS_Purchase__c | [3](#2.%20Forms) | [5](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 82 | [azt_lastsuccessfulconnection](#azt_lastsuccessfulconnection) | Last Successful Connection | datetime |  | Yes | none |  | C R U | true |  |  |  | Account | Last Successful Connection | Last_Successful_Connection__c | [2](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 83 | [azt_lastyearspend](#azt_lastyearspend) | Last Year Spend | money |  | Yes | none |  | R | true |  |  |  | Account | Last Year Spend | Last_Year_Spend__c | [1](#2.%20Forms) |  |  |  |  |  | [1](#9.%20Formulas%20and%20Rollups) |  |  |  |  |  |
| 84 | [azt_lastyearspend_base](#azt_lastyearspend_base) | Last Year Spend (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 85 | [azt_leadsourceid](#azt_leadsourceid) | Lead Source | lookup |  | Yes | none |  | C R U | true | Account | Account Source | AccountSource | Account | Lead Source | Lead_Source__c | [2](#2.%20Forms) |  |  |  |  | [8](#7.%20Workflows) |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 86 | [azt_nomatch](#azt_nomatch) | No Match? | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 87 | [azt_nonsaasstatus](#azt_nonsaasstatus) | Non-SaaS Status | picklist |  | Yes | none |  | C R U | true | Account | CRM Non-SaaS Status | Non_SaaS_Status__c | Account | Nonsaas Status | Nonsaas_Status__c | [2](#2.%20Forms) |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 88 | [azt_numberofcomputers](#azt_numberofcomputers) | # Computers | int |  | Yes | none |  | C R U | true | Account | # Computers | NumofComputers__c | Account | # Computers | NumofComputers__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 89 | [azt_numberofstudents](#azt_numberofstudents) | # Students | int |  | Yes | none |  | C R U | true | Account | # Students | NumofStudents__c | Account | # Students | NumofStudents__c | [2](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 90 | [azt_oldbusinessunit](#azt_oldbusinessunit) | Old Business Unit | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Old Business Unit | Old_Business_Unit__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 91 | [azt_parentaccountspend](#azt_parentaccountspend) | Parent Account Spend | money |  | Yes | none |  | C R U | true |  |  |  | Account | Parent Account Spend | Parent_Account_Spend__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 92 | [azt_parentaccountspend_base](#azt_parentaccountspend_base) | Parent Account Spend (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 93 | [azt_parentlastyearspend](#azt_parentlastyearspend) | Parent Last Year Spend | money |  | Yes | none |  | C R U | true |  |  |  | Account | Parent Last Year Spend | Parent_Last_Year_Spend__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 94 | [azt_parentlastyearspend_base](#azt_parentlastyearspend_base) | Parent Last Year Spend (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 95 | [azt_parentytdspend](#azt_parentytdspend) | Parent YTD Spend | money |  | Yes | none |  | C R U | true |  |  |  | Account | Parent Ytd Spend | Parent_Ytd_Spend__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 96 | [azt_parentytdspend_base](#azt_parentytdspend_base) | Parent YTD Spend (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 97 | [azt_possiblematchid](#azt_possiblematchid) | Possible Match | lookup |  | Yes | none |  | C R U | true |  |  |  | Account | Possible Match | Possible_Match__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 98 | [azt_productfamilies](#azt_productfamilies) | Product Families | multiselectpicklist |  | Yes | none |  | C R U | true |  |  |  | Account | Product Families | Product_Families__c | [2](#2.%20Forms) | [2](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 99 | [azt_recordownerid](#azt_recordownerid) | Record Owner | lookup |  | Yes | none |  | C R U | true | Account | Record Owner | OwnerId | Account | Record Type ID | RecordTypeId | [2](#2.%20Forms) | [6](#3.%20Views) |  | [2](#5.%20Reports) |  | [37](#7.%20Workflows) |  | [9](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 100 | [azt_saasstatus](#azt_saasstatus) | SaaS Status | picklist |  | Yes | none |  | C R U | true | Account | CRM SaaS Status | CRM_SaaS_Status__c | Account | Saas Status | Saas_Status__c | [2](#2.%20Forms) |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 101 | [azt_score](#azt_score) | Score | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Score | Score__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 102 | [azt_tax_exempt_certificate__c](#azt_tax_exempt_certificate__c) | Tax_Exempt_Certificate__c | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 103 | [azt_taxexemptcertificate](#azt_taxexemptcertificate) | Tax Exempt Certificate # | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Account | Tax Exempt Certificate | Tax_Exempt_Certificate__c | [2](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 104 | [azt_ttprintnotto](#azt_ttprintnotto) | TTPrint - No TTO | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 105 | [azt_type](#azt_type) | Type | nvarchar |  | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 106 | [azt_verticalmarket](#azt_verticalmarket) | Vertical Market | picklist |  | Yes | none |  | C R U | true |  | Industry |  | Account | Vertical Market | Vertical_Market__c | [5](#2.%20Forms) |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 107 | [azt_yearbeforelastspend](#azt_yearbeforelastspend) | Year Before Last Spend | money |  | Yes | none |  | R | true |  |  |  | Account | Year Before Last Spend | Year_Before_Last_Spend__c | [1](#2.%20Forms) |  |  |  |  |  | [1](#9.%20Formulas%20and%20Rollups) |  |  |  |  |  |
| 108 | [azt_yearbeforelastspend_base](#azt_yearbeforelastspend_base) | Year Before Last Spend (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 109 | [azt_ytdspend](#azt_ytdspend) | YTD Spend | money |  | Yes | none |  | R | true |  |  |  | Account | Total Spend | Total_Spend__c | [1](#2.%20Forms) |  |  |  |  |  | [1](#9.%20Formulas%20and%20Rollups) |  |  |  |  |  |
| 110 | [azt_ytdspend_base](#azt_ytdspend_base) | YTD Spend (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 111 | [createdby](#createdby) | Created By | lookup |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 112 | [description](#description) | Description | ntext |  | No | none |  | R | false |  |  |  |  |  |  | [2](#2.%20Forms) |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 113 | [donotsendmm](#donotsendmm) |  |  |  | No |  |  |  | false |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 114 | [emailaddress1](#emailaddress1) | Email | nvarchar |  | No | none |  | C R U So | true |  |  |  | Account | Email | Email__c |  | [1](#3.%20Views) |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 115 | [fax](#fax) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  | [1](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 116 | [lastusedincampaign](#lastusedincampaign) |  |  |  | No |  |  |  | false |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 117 | [msa_managingpartnerid](#msa_managingpartnerid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#12.%20Relationships) |  |  |
| 118 | [msa_partnerid](#msa_partnerid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#12.%20Relationships) |  |  |
| 119 | [msdyn_accountkpiid](#msdyn_accountkpiid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 120 | [msdyn_salesaccelerationinsightid](#msdyn_salesaccelerationinsightid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 121 | [msdyn_segmentid](#msdyn_segmentid) | Segment Id | lookup |  | Yes | none |  | C R U | true |  |  |  | Account | Segment Id | Segment_Id__c |  |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 122 | [name](#name) | Account Name | nvarchar |  | No | required |  | C R U S So Re | true | Account | Account Name | Name | Account | Account Name | Name | [3](#2.%20Forms) | [46](#3.%20Views) |  | [3](#5.%20Reports) |  | [16](#7.%20Workflows) |  | [23](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 123 | [new_sharedwith](#new_sharedwith) | Shared With | lookup |  | Yes | none |  | C R U | true |  |  |  | Account | Shared With | Shared_With__c | [2](#2.%20Forms) |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 124 | [originatingleadid](#originatingleadid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  | [3](#2.%20Forms) |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 125 | [ownerid](#ownerid) | Owner | owner |  | No | systemrequired |  | C R U G Re | true | Account | Record type | RecordType | Account | Owner ID | OwnerId | [3](#2.%20Forms) | [9](#3.%20Views) |  | [1](#5.%20Reports) |  | [24](#7.%20Workflows) |  | [22](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 126 | [owningteam](#owningteam) | Owning Team | lookup |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  | [1](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 127 | [parentaccountid](#parentaccountid) | Parent Account | lookup |  | No | none |  | C R U | true | Account | ParentId | ParentId | Account | Parent Account ID | ParentId | [2](#2.%20Forms) | [1](#3.%20Views) |  |  |  | [12](#7.%20Workflows) |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  | [2](#12.%20Relationships) |  |  |
| 128 | [parentid](#parentid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 129 | [primarycontactid](#primarycontactid) | Primary Contact | lookup |  | No | none |  | C R U So G | true |  |  |  | Account | Primary Contact | Primary_Contact__c | [2](#2.%20Forms) |  |  |  |  | [2](#7.%20Workflows) |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 130 | [regardingobjectid](#regardingobjectid) | Regarding | lookup |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  | [8](#12.%20Relationships) |  |  |
| 131 | [statecode](#statecode) | Status | state |  | No | systemrequired |  | R U F | true |  |  |  | Account | Status CRM | Status_CRM__c |  | [16](#3.%20Views) |  |  |  | [10](#7.%20Workflows) | [3](#9.%20Formulas%20and%20Rollups) | [20](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 132 | [telephone1](#telephone1) | Main Phone | nvarchar |  | No | none |  | C R U S So Re | true |  | Phone |  | Account | Other Phone | OtherPhone__c | [3](#2.%20Forms) | [23](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 133 | [telephone2](#telephone2) | Other Phone | nvarchar |  | No | none |  | C R U | false | Account | Other Phone | OtherPhone__c |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |

---

## 2. Forms

Total forms: **12**

### 2.1. TimelineWallControl - Account- Main - main - Active

- **Form ID:** `{6df8e8ce-7655-468c-925e-660d59aa7f4c}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: SUMMARY_TAB

##### Section: SOCIAL_PANE_TAB

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#notescontrol) | Notes Properties | No | Yes |

### 2.2. iGrad Account - main - Active

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
| [ChildAccounts](#ChildAccounts) | Child Accounts | No | Yes |

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
| [Contacts](#Contacts) | CONTACTS | No | Yes |
| [Connections](#Connections) | CONNECTIONS | No | Yes |
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
| [DocumentsSubGrid](#DocumentsSubGrid) | Documents | No | Yes |

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

### 2.3. AI for Sales - main - Inactive

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
| [RICONTAINER_CHARTS](#RICONTAINER_CHARTS) |  | No | Yes |

#### Tab: DETAILS_TAB

##### Section: COMPANY_PROFILE

##### Section: DETAILS_TAB_section_6

##### Section: MARKETING

##### Section: BILLING

### 2.4. Information - main - Inactive

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
| [WebResource_RecordWall](#WebResource_RecordWall) | RecordWall | No | Yes |

### 2.5. Account - main - Active

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
| [ChildAccounts](#ChildAccounts) | Child Accounts | No | Yes |

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
| [Contacts](#Contacts) |  | No | Yes |
| [accountopportunitiesgrid](#accountopportunitiesgrid) | Opportunities | No | Yes |
| [accountcasessgrid](#accountcasessgrid) | Cases | No | Yes |
| [Connections](#Connections) | CONNECTIONS | No | Yes |

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

### 2.6. Purchased Software Licenses - quick - Active

- **Form ID:** `{0f2248fc-4264-4bf9-9f9b-49c807c7c276}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [purchasedsoftware](#purchasedsoftware) | Purchased Software | No | Yes |

### 2.7. Account Owner Card - quick - Active

- **Form ID:** `{b6e88028-6990-40e6-ba5b-562bf68e363a}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#ownerid) | Account Owner | No | Yes |

### 2.8. Last Purchase Dates Quick View - quick - Active

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

### 2.9. Allocated Software Licenses - quick - Active

- **Form ID:** `{b7be8bd7-c202-4f04-b412-8dcce39af644}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [softwarelicenseallocations](#softwarelicenseallocations) | Software License Allocations | No | Yes |

### 2.10. Account Lead Quick View - quick - Active

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

### 2.11. Account Owner Quick View - quick - Active

- **Form ID:** `{ef3fdf29-170b-49dc-8107-dc01b314b785}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Tab

##### Section: section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_customernumber](#azt_customernumber) | Customer Number | No | Yes |
| [ownerid](#ownerid) | Account Owner | No | Yes |

### 2.12. Engagement Contacts - quick - Active

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
| 3 | [accountid](#accountid) |  |

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
| 1 | [SharedUser.fullname](#SharedUser.fullname) | 150px |

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
| 8 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
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
| 8 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
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
| 8 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
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
| 8 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
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
| 8 | [accountid](#accountid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
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

## 9. Formulas and Rollups

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
- [invline.productid](#invline.productid)
- [prod.productid](#prod.productid)
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
- [{0}](#%7B0%7D)

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
- [tm.systemuserid](#tm.systemuserid)

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
| Account_Annotation | 1:N | Account | Annotation | [ObjectId](#ObjectId) |
| Account_Appointments | 1:N | Account | Appointment | [RegardingObjectId](#RegardingObjectId) |
| Account_CustomerAddress | 1:N | Account | CustomerAddress | [ParentId](#ParentId) |
| Account_Emails | 1:N | Account | Email | [RegardingObjectId](#RegardingObjectId) |
| Account_Letters | 1:N | Account | Letter | [RegardingObjectId](#RegardingObjectId) |
| Account_Phonecalls | 1:N | Account | PhoneCall | [RegardingObjectId](#RegardingObjectId) |
| Account_Tasks | 1:N | Account | Task | [RegardingObjectId](#RegardingObjectId) |
| account_OpportunityCloses | 1:N | Account | OpportunityClose | [RegardingObjectId](#RegardingObjectId) |
| account_OrderCloses | 1:N | Account | OrderClose | [RegardingObjectId](#RegardingObjectId) |
| account_QuoteCloses | 1:N | Account | QuoteClose | [RegardingObjectId](#RegardingObjectId) |
| account_originating_lead | N:1 | Lead | Account | [OriginatingLeadId](#OriginatingLeadId) |
| account_parent_account | 1:N | Account | Account | [ParentAccountId](#ParentAccountId) |
| azt_Funding_Account_Account | 1:N | Account | azt_Funding | [azt_Account](#azt_Account) |
| azt_account_account | 1:N | Account | Account | [azt_PossibleMatchId](#azt_PossibleMatchId) |
| azt_account_azt_allocatedlicense | 1:N | Account | azt_allocatedlicense | [azt_CustomerId](#azt_CustomerId) |
| azt_account_azt_customertraining | 1:N | Account | azt_customertraining | [azt_AccountId](#azt_AccountId) |
| azt_account_azt_engagement | 1:N | Account | azt_engagement | [azt_AccountId](#azt_AccountId) |
| azt_account_azt_expense | 1:N | Account | azt_expense | [azt_CustomerId](#azt_CustomerId) |
| azt_account_azt_preview | 1:N | Account | azt_preview | [azt_AccountId](#azt_AccountId) |
| azt_account_azt_printpurchase | 1:N | Account | azt_printpurchase | [azt_CustomerId](#azt_CustomerId) |
| azt_account_azt_productdiscount | 1:N | Account | azt_productdiscount | [azt_CustomerId](#azt_CustomerId) |
| azt_account_azt_softwarelicense | 1:N | Account | azt_softwarelicense | [azt_AccountId](#azt_AccountId) |
| azt_account_azt_training | 1:N | Account | azt_training | [azt_AccountId](#azt_AccountId) |
| azt_allocatedaccount_azt_allocatedlicense | 1:N | Account | azt_allocatedlicense | [azt_AllocatedToId](#azt_AllocatedToId) |
| azt_azt_leadsource_account | N:1 | azt_leadsource | Account | [azt_LeadSourceId](#azt_LeadSourceId) |
| azt_parentaccount_azt_softwarelicense | 1:N | Account | azt_softwarelicense | [azt_ParentAccountId](#azt_ParentAccountId) |
| azt_systemuser_account | N:1 | SystemUser | Account | [azt_RecordOwnerId](#azt_RecordOwnerId) |
| contact_customer_accounts | 1:N | Account | Contact | [ParentCustomerId](#ParentCustomerId) |
| incident_customer_accounts | 1:N | Account | Incident | [CustomerId](#CustomerId) |
| invoice_customer_accounts | 1:N | Account | Invoice | [CustomerId](#CustomerId) |
| lead_customer_accounts | 1:N | Account | Lead | [CustomerId](#CustomerId) |
| msa_account_incident | 1:N | Account | Incident | [msa_partnerid](#msa_partnerid) |
| msa_account_managingpartner | 1:N | Account | Account | [msa_managingpartnerid](#msa_managingpartnerid) |
| msa_contact_managingpartner | 1:N | Account | Contact | [msa_managingpartnerid](#msa_managingpartnerid) |
| msa_partner_opportunity | 1:N | Account | Opportunity | [msa_partnerid](#msa_partnerid) |
| msdyn_insightsid_salesaccelerationinsights | N:1 | msdyn_salesaccelerationinsight | Account | [msdyn_salesaccelerationinsightid](#msdyn_salesaccelerationinsightid) |
| msdyn_msdyn_accountkpiitem_account_accountkpiid | N:1 | msdyn_accountkpiitem | Account | [msdyn_accountkpiid](#msdyn_accountkpiid) |
| msdyn_msdyn_segment_account | N:1 | msdyn_segment | Account | [msdyn_segmentid](#msdyn_segmentid) |
| new_systemuser_account_SharedWith | N:1 | SystemUser | Account | [new_SharedWith](#new_SharedWith) |
| opportunity_customer_accounts | 1:N | Account | Opportunity | [CustomerId](#CustomerId) |
| opportunity_parent_account | 1:N | Account | Opportunity | [ParentAccountId](#ParentAccountId) |
| order_customer_accounts | 1:N | Account | SalesOrder | [CustomerId](#CustomerId) |
| quote_customer_accounts | 1:N | Account | Quote | [CustomerId](#CustomerId) |

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

## 14. Conflicts and Observations

### 14.1 Per-Form Conflicts

Fields with inconsistent settings across forms: **4**

| Field | Issue | Forms |
|-------|-------|-------|
| [azt_customernumber](#azt_customernumber) | Disabled state | iGrad Account (main), Account (main), Account Lead Quick View (quick), Account Owner Quick View (quick) |
| [azt_lastprintpurchase](#azt_lastprintpurchase) | Disabled state | iGrad Account (main), Account (main), Last Purchase Dates Quick View (quick) |
| [azt_lastsaaspurchase](#azt_lastsaaspurchase) | Disabled state | iGrad Account (main), Account (main), Last Purchase Dates Quick View (quick) |
| [telephone1](#telephone1) | Visibility | iGrad Account (main), iGrad Account (main), Account (main) |

### 14.2 Global Observations

**Fields in code but not on any form (313):**

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
- [invline.productid](#invline.productid)
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
- [prod.productid](#prod.productid)
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
- [tm.systemuserid](#tm.systemuserid)
- [to](#to)
- [totalamount](#totalamount)
- [totallineitemamount](#totallineitemamount)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)
- [{0}](#%7B0%7D)

**Fields on forms but never in logic (17):**

- [address1_composite](#address1_composite)
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
- [donotsendmm](#donotsendmm)
- [lastusedincampaign](#lastusedincampaign)
- [new_sharedwith](#new_sharedwith)
- [websiteurl](#websiteurl)

---

## Index

Alphabetical field index -- 484 unique fields referenced.

#### accessrightsmask

- [Report: SharedAccountRecords > Users > principalobjectaccess](#5.2.%20SharedAccountRecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess (Filter)](#5.2.%20SharedAccountRecords)

#### accessteam

- [Form: iGrad Account > Details > section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > section](#2.5.%20Account%20-%20main%20-%20Active)

#### accountcasessgrid

- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)

#### accountclassificationcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Account Lead Quick View > Tab > section](#2.10.%20Account%20Lead%20Quick%20View%20-%20quick%20-%20Active)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: My Active Accounts](#3.18.%20My%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)

#### accountid

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Account Advanced Find View](#3.1.%20Account%20Advanced%20Find%20View)
- [View: Account Associated View](#3.2.%20Account%20Associated%20View)
- [View: Account BulkOperation View](#3.3.%20Account%20BulkOperation%20View)
- [View: Account List Member View](#3.4.%20Account%20List%20Member%20View)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Accounts: No Orders in Last 6 Months](#3.8.%20Accounts%3A%20No%20Orders%20in%20Last%206%20Months)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: All Accounts](#3.11.%20All%20Accounts)
- [View: Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: Inactive Accounts](#3.17.%20Inactive%20Accounts)
- [View: My Active Accounts](#3.18.%20My%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: My Connections](#3.20.%20My%20Connections)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [View: Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [Report: SharedAccountRecords > Users > account](#5.2.%20SharedAccountRecords)
- [Workflow: AppointmentAuto-Assign (Read)](#7.6.%20AppointmentAuto-Assign)
- [Workflow: BatchConverttoLead (Read)](#7.7.%20BatchConverttoLead)
- [Workflow: BatchCreateEngagements (Read)](#7.8.%20BatchCreateEngagements)
- [Workflow: BatchCreateIntroCall (Read)](#7.9.%20BatchCreateIntroCall)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Read)](#7.26.%20CreateLeadfromAccount)
- [Workflow: PhonecallAuto-Assign (Read)](#7.41.%20PhonecallAuto-Assign)
- [Workflow: TaskAuto-Assign (Read)](#7.54.%20TaskAuto-Assign)
- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Write)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Join)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGenAssociate (Write)](#10.3.%20AccountLeadGenAssociate)
- [Plugin: AccountTypeSet (Write)](#10.5.%20AccountTypeSet)
- [Plugin: GetAcctTeamOwned (Read)](#10.31.%20GetAcctTeamOwned)
- [Plugin: GetAcctTeamOwned (Filter)](#10.31.%20GetAcctTeamOwned)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#10.76.%20ShareBasedOnAccessTeam)

#### accountnumber

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)

#### accountopportunitiesgrid

- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)

#### activityid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Image)](#10.59.%20PhonecallCreateCallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### activitytypecode

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)

#### actualclosedate

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### actualend

- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)

#### actualrevenue

- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)

#### actualvalue

- [Formula: azt_accountspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### address1_addresstypecode

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > PHYSICAL ADDRESS](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > PHYSICAL ADDRESS](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.27.%20CustomLeadCreation)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)
- [JS: azt_accountlibrary > setPrimAddressName()](#8.2.%20azt_accountlibrary)
- [JS: azt_contactlibrary > setAddressName()](#8.5.%20azt_contactlibrary)

#### address1_city

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Accounts: No Orders in Last 6 Months](#3.8.%20Accounts%3A%20No%20Orders%20in%20Last%206%20Months)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: All Accounts](#3.11.%20All%20Accounts)
- [View: Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: Inactive Accounts](#3.17.%20Inactive%20Accounts)
- [View: My Active Accounts](#3.18.%20My%20Active%20Accounts)
- [View: My Connections](#3.20.%20My%20Connections)
- [View: Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [Workflow: ContactMapAddresses (Read)](#7.24.%20ContactMapAddresses)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Read)](#7.26.%20CreateLeadfromAccount)
- [JS: azt_addresslibrary > addAddress()](#8.3.%20azt_addresslibrary)

#### address1_composite

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account Lead Quick View > Tab > section](#2.10.%20Account%20Lead%20Quick%20View%20-%20quick%20-%20Active)

#### address1_country

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: AccountAuto-Assign (Read)](#7.3.%20AccountAuto-Assign)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [JS: azt_addresslibrary > addAddress()](#8.3.%20azt_addresslibrary)

#### address1_county

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: ContactMapAddresses (Read)](#7.24.%20ContactMapAddresses)

#### address1_fax

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)

#### address1_freighttermscode

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_latitude

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_line1

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Address](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: ContactMapAddresses (Read)](#7.24.%20ContactMapAddresses)
- [JS: azt_addresslibrary > addAddress()](#8.3.%20azt_addresslibrary)

#### address1_line2

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: ContactMapAddresses (Read)](#7.24.%20ContactMapAddresses)
- [JS: azt_addresslibrary > addAddress()](#8.3.%20azt_addresslibrary)

#### address1_line3

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_longitude

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_name

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > PHYSICAL ADDRESS](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > PHYSICAL ADDRESS](#2.5.%20Account%20-%20main%20-%20Active)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)
- [Workflow: SetPhysicalAddressNameField (Read)](#7.50.%20SetPhysicalAddressNameField)
- [Workflow: SetPhysicalAddressNameField (Write)](#7.50.%20SetPhysicalAddressNameField)
- [JS: azt_accountlibrary > setPrimAddressName()](#8.2.%20azt_accountlibrary)
- [JS: azt_contactlibrary > setAddressName()](#8.5.%20azt_contactlibrary)

#### address1_postalcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: ContactMapAddresses (Read)](#7.24.%20ContactMapAddresses)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [JS: azt_addresslibrary > addAddress()](#8.3.%20azt_addresslibrary)

#### address1_postofficebox

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_primarycontactname

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_shippingmethodcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.27.%20CustomLeadCreation)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)

#### address1_stateorprovince

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: All Accounts](#3.11.%20All%20Accounts)
- [View: Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: My Active Accounts](#3.18.%20My%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [View: Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [Workflow: AccountAuto-Assign (Read)](#7.3.%20AccountAuto-Assign)
- [Workflow: ContactAuto-Assign (Read)](#7.23.%20ContactAuto-Assign)
- [Workflow: ContactMapAddresses (Read)](#7.24.%20ContactMapAddresses)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Read)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Read)](#7.27.%20CustomLeadCreation)
- [Workflow: FSRLeadDistibutionNotification (Read)](#7.30.%20FSRLeadDistibutionNotification)
- [Workflow: NewFSRLeadNotification (Read)](#7.36.%20NewFSRLeadNotification)
- [Workflow: PhonecallAuto-Assign (Read)](#7.41.%20PhonecallAuto-Assign)
- [Workflow: SoftwareLicenseCreateEngagement (Read)](#7.52.%20SoftwareLicenseCreateEngagement)
- [JS: azt_accountlibrary > createLead()](#8.2.%20azt_accountlibrary)
- [JS: azt_addresslibrary > addAddress()](#8.3.%20azt_addresslibrary)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: AutoAssignStateAbb (Read)](#10.12.%20AutoAssignStateAbb)
- [Plugin: AutoAssignStateAbb (Write)](#10.12.%20AutoAssignStateAbb)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### address1_telephone1

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### address1_telephone2

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_telephone3

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_upszone

- [Field Definitions](#1.%20Field%20Definitions)

#### address1_utcoffset

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_addresstypecode

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.27.%20CustomLeadCreation)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)
- [JS: azt_accountlibrary > setBillAddressName()](#8.2.%20azt_accountlibrary)

#### address2_city

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_composite

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_country

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: ContactMapAddresses (Write)](#7.24.%20ContactMapAddresses)

#### address2_county

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: ContactMapAddresses (Write)](#7.24.%20ContactMapAddresses)

#### address2_fax

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_freighttermscode

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_latitude

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_line1

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader > account](#5.1.%20PAQuoteReport)

#### address2_line2

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_line3

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_longitude

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_name

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: SetBusinessAddressNameField (Read)](#7.48.%20SetBusinessAddressNameField)
- [Workflow: SetBusinessAddressNameField (Write)](#7.48.%20SetBusinessAddressNameField)
- [JS: azt_accountlibrary > setBillAddressName()](#8.2.%20azt_accountlibrary)

#### address2_postalcode

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_postofficebox

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_primarycontactname

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_shippingmethodcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.27.%20CustomLeadCreation)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)

#### address2_stateorprovince

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_telephone1

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_telephone2

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_telephone3

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_upszone

- [Field Definitions](#1.%20Field%20Definitions)

#### address2_utcoffset

- [Field Definitions](#1.%20Field%20Definitions)

#### addresses

- [Form: iGrad Account > Summary > SOCIAL PANE](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > SOCIAL_PANE_TAB](#2.5.%20Account%20-%20main%20-%20Active)

#### adx_resolutiondate

- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### allocations

- [Form: iGrad Account > Allocations > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Allocations > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### amountdatatype

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### annotationid

- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### associatedconnectionroleid

- [Plugin: ContactSetConnectionRole (Join)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Join)](#10.75.%20SetPrimaryContact)

#### azt_account

- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Relationship: azt_Funding_Account_Account](#12.%20Relationships)

#### azt_accountalert

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Account Alert > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Account Alert > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [JS: azt_accountlibrary > accountAlert()](#8.2.%20azt_accountlibrary)

#### azt_accountid

- [View: GED Customers Without Kaplan (Filter)](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED (Filter)](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash (Filter)](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET (Filter)](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: TASC Customers Without Kaplan TASC (Filter)](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Filter)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)
- [Relationship: azt_account_azt_customertraining](#12.%20Relationships)
- [Relationship: azt_account_azt_engagement](#12.%20Relationships)
- [Relationship: azt_account_azt_preview](#12.%20Relationships)
- [Relationship: azt_account_azt_softwarelicense](#12.%20Relationships)
- [Relationship: azt_account_azt_training](#12.%20Relationships)

#### azt_accountleadgenerationid

- [Plugin: AccountLeadGen (Filter)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGenAssociate (Read)](#10.3.%20AccountLeadGenAssociate)
- [Plugin: AccountLeadGenAssociate (Filter)](#10.3.%20AccountLeadGenAssociate)

#### azt_accountleadgenname

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [Plugin: AccountLeadGenAssociate (Write)](#10.3.%20AccountLeadGenAssociate)

#### azt_accountnumber

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_accountspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [JS: azt_accountlibrary > parentAccountSpend()](#8.2.%20azt_accountlibrary)
- [Formula: azt_accountspend (Target)](#9.%20Formulas%20and%20Rollups)

#### azt_accountspend_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_accounttype

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account (Header)](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > Summary > Account Status](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account (Header)](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Account Status](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Account Lead Quick View > Tab > section](#2.10.%20Account%20Lead%20Quick%20View%20-%20quick%20-%20Active)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: Quick Find Active Accounts (Filter)](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [JS: azt_FindAccountsWithinBoundModified](#8.1.%20azt_FindAccountsWithinBoundModified)
- [Plugin: AccountTypeSet (Write)](#10.5.%20AccountTypeSet)

#### azt_addresssearch

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > PHYSICAL ADDRESS](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > PHYSICAL ADDRESS](#2.5.%20Account%20-%20main%20-%20Active)
- [Plugin: AddressSearchCleanupFields (Read)](#10.10.%20AddressSearchCleanupFields)
- [Plugin: AddressSearchCleanupFields (Write)](#10.10.%20AddressSearchCleanupFields)

#### azt_addresssearch2

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AddressSearchCleanupFields (Read)](#10.10.%20AddressSearchCleanupFields)
- [Plugin: AddressSearchCleanupFields (Write)](#10.10.%20AddressSearchCleanupFields)

#### azt_addtocrtqueue

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_aeflafunding

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Last Purchase Dates Quick View > Tab > section](#2.8.%20Last%20Purchase%20Dates%20Quick%20View%20-%20quick%20-%20Active)

#### azt_ageendedstage

- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_allocatedtoid

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Relationship: azt_allocatedaccount_azt_allocatedlicense](#12.%20Relationships)

#### azt_allocationtype

- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_amount

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_annualspend

- [Plugin: FundingSetAnnualSpend (Write)](#10.28.%20FundingSetAnnualSpend)

#### azt_approvalstatus

- [Plugin: OpportunityPreventCreateQuote (Read)](#10.47.%20OpportunityPreventCreateQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### azt_autocreatecallback

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_autonumberid

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)
- [Plugin: AutoNumber (Write)](#10.13.%20AutoNumber)

#### azt_azteccustomerid

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_bookingurl

- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)
- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_callbackin

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_callbackon

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_caseid

- [Plugin: CaseAudit (Write)](#10.14.%20CaseAudit)

#### azt_commissionamount

- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)

#### azt_commissionid

- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_commissionpaymentid

- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)

#### azt_companyname

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_compcompleted

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)

#### azt_compgoalid

- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_compgoaltypeid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)

#### azt_compplanamountid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_concurrentusers

- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_copydescription

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_copysubject

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_currentnumber

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)
- [Plugin: AutoNumber (Write)](#10.13.%20AutoNumber)

#### azt_customerid

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Relationship: azt_account_azt_allocatedlicense](#12.%20Relationships)
- [Relationship: azt_account_azt_expense](#12.%20Relationships)
- [Relationship: azt_account_azt_printpurchase](#12.%20Relationships)
- [Relationship: azt_account_azt_productdiscount](#12.%20Relationships)

#### azt_customerintrocompletedby

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: AccountClearCustomerIntro (Write)](#7.4.%20AccountClearCustomerIntro)
- [JS: azt_accountlibrary > onLoad()](#8.2.%20azt_accountlibrary)
- [JS: azt_accountlibrary > setCustIntroCompletedBy()](#8.2.%20azt_accountlibrary)

#### azt_customerintrocompletedon

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: AccountClearCustomerIntro (Write)](#7.4.%20AccountClearCustomerIntro)
- [JS: azt_accountlibrary > onLoad()](#8.2.%20azt_accountlibrary)
- [JS: azt_accountlibrary > setCustIntroCompletedBy()](#8.2.%20azt_accountlibrary)

#### azt_customerintroductioncompleted

- [Field Definitions](#1.%20Field%20Definitions)
- [View: New Customer Introduction List (Filter)](#3.21.%20New%20Customer%20Introduction%20List)
- [Workflow: AccountClearCustomerIntro (Write)](#7.4.%20AccountClearCustomerIntro)
- [JS: azt_accountlibrary > setCustIntroCompletedBy()](#8.2.%20azt_accountlibrary)

#### azt_customernumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Account Lead Quick View > Tab > section](#2.10.%20Account%20Lead%20Quick%20View%20-%20quick%20-%20Active)
- [Form: Account Owner Quick View > Tab > section](#2.11.%20Account%20Owner%20Quick%20View%20-%20quick%20-%20Active)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: Quick Find Active Accounts (Filter)](#3.23.%20Quick%20Find%20Active%20Accounts)

#### azt_customerof

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_customertrainingid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)

#### azt_dateexitedstage

- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_defaultfreightamount

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

#### azt_description

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_digitalstatus

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_discountamount

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)

#### azt_discretionarydiscount

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### azt_discretionarydiscountamt

- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)

#### azt_duedate

- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### azt_duplicate

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Duplicate Accounts (Filter)](#3.12.%20Duplicate%20Accounts)

#### azt_effectivedate

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_email

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImportPopulateName (Read)](#10.37.%20LeadImportPopulateName)

#### azt_enddate

- [Plugin: EngagementSetEndDate (Write)](#10.25.%20EngagementSetEndDate)

#### azt_engagementid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: EngagementFSRAssignedOn (Read)](#10.24.%20EngagementFSRAssignedOn)
- [Plugin: EngagementFSRAssignedOn (Write)](#10.24.%20EngagementFSRAssignedOn)
- [Plugin: EngagementSetEndDate (Write)](#10.25.%20EngagementSetEndDate)

#### azt_estfulfillmentdate

- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_evaluate

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Image)](#10.2.%20AccountLeadGen)

#### azt_excludefromautoassign

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: AccountAuto-Assign (Read)](#7.3.%20AccountAuto-Assign)
- [Workflow: ContactAuto-Assign (Read)](#7.23.%20ContactAuto-Assign)
- [Workflow: MarkAccountsExcludefromAuto-assign (Write)](#7.35.%20MarkAccountsExcludefromAuto-assign)
- [JS: azt_accountlibrary > onLoad()](#8.2.%20azt_accountlibrary)

#### azt_executivesummary

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Executive Summary](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Executive Summary](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: BatchCreateEngagements (Write)](#7.8.%20BatchCreateEngagements)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#7.52.%20SoftwareLicenseCreateEngagement)

#### azt_expenseamount

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)

#### azt_expenseid

- [Plugin: CloneExpenseLine (Filter)](#10.17.%20CloneExpenseLine)

#### azt_expensereportid

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Filter)](#10.26.%20ExpenseLineTotals)

#### azt_expensetype

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_expirationdate

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_extension

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fieldtoautonumber

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_firstname

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_fiscalperiodend

- [Plugin: Utility (Write)](#10.81.%20Utility)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### azt_fiscalperiodstart

- [Plugin: CreateCompGoals (Sort)](#10.20.%20CreateCompGoals)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_fiscalyearend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_freightamtapproved

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

#### azt_fsradminpassword

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_fsradminusername

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_fsrassignedon

- [Plugin: EngagementFSRAssignedOn (Write)](#10.24.%20EngagementFSRAssignedOn)

#### azt_fsremail

- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrid

- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrmobiletelephone

- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrtelephone

- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrtelephoneextension

- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fundingid

- [Plugin: FundingSetAnnualSpend (Write)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: FundingTotalAmt (Write)](#10.29.%20FundingTotalAmt)

#### azt_fundingyear

- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: FundingYearSync (Read)](#10.30.%20FundingYearSync)

#### azt_gedprintnoflashplay

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_gedprintnogedsoftware

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_goaltype

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### azt_historicalowner

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account (Footer)](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account (Footer)](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: CloneAndDeleteQuote (Write)](#7.18.%20CloneAndDeleteQuote)
- [Workflow: CloneOpportunity (Write)](#7.21.%20CloneOpportunity)

#### azt_importname

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImportPopulateName (Read)](#10.37.%20LeadImportPopulateName)

#### azt_invoiceid

- [Plugin: CompGoalCreate (Read)](#10.18.%20CompGoalCreate)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Join)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### azt_invoiceproductid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#10.63.%20QuoteOrderProductsTrackDiscount)

#### azt_isautoduplicate

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_isbn

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_iscompanion

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_isduplicate

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Old Duplicate Accounts View (Filter)](#3.22.%20Old%20Duplicate%20Accounts%20View)

#### azt_isinquickbooks

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Accounts in Quickbooks (Filter)](#3.9.%20Active%20Accounts%20in%20Quickbooks)

#### azt_ismatched

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_isprint

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_issaas

- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: SetOppProductDefaults (Write)](#10.74.%20SetOppProductDefaults)

#### azt_jobrole

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: RestrictProductLookups (Read)](#10.69.%20RestrictProductLookups)

#### azt_jobtitle

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_lastactivitydate

- [Field Definitions](#1.%20Field%20Definitions)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [Plugin: OpportunityLastActivityDate (Write)](#10.45.%20OpportunityLastActivityDate)

#### azt_lastmodifiedbyid

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)

#### azt_lastname

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_lastprintpurchase

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > Description](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Last Purchase Dates Quick View > Tab > section](#2.8.%20Last%20Purchase%20Dates%20Quick%20View%20-%20quick%20-%20Active)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: My Active Customers With Purchase Dates (Filter)](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [View: New Customer Introduction List (Filter)](#3.21.%20New%20Customer%20Introduction%20List)

#### azt_lastsaaspurchase

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > Description](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Last Purchase Dates Quick View > Tab > section](#2.8.%20Last%20Purchase%20Dates%20Quick%20View%20-%20quick%20-%20Active)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: My Active Customers With Purchase Dates (Filter)](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [View: New Customer Introduction List (Filter)](#3.21.%20New%20Customer%20Introduction%20List)

#### azt_lastsuccessfulconnection

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account (Header)](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account (Header)](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_lastyearspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Formula: azt_lastyearspend (Target)](#9.%20Formulas%20and%20Rollups)

#### azt_lastyearspend_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_leadimportid

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_leadsourceid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: BulkChangeLeadSource (Write)](#7.12.%20BulkChangeLeadSource)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.27.%20CustomLeadCreation)
- [Workflow: LeadAssignment (Read)](#7.32.%20LeadAssignment)
- [Workflow: LeadSourceChange (Write)](#7.34.%20LeadSourceChange)
- [Workflow: SetLeadTemperature (Read)](#7.49.%20SetLeadTemperature)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Relationship: azt_azt_leadsource_account](#12.%20Relationships)

#### azt_licensestatus

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_licenseterm

- [Plugin: OrderLinePopulateLicType (Read)](#10.53.%20OrderLinePopulateLicType)

#### azt_licensetermmonths

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityClone (Write)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Write)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderClone (Write)](#10.51.%20OrderClone)
- [Plugin: OrderLinePopulateLicType (Read)](#10.53.%20OrderLinePopulateLicType)
- [Plugin: OrderLinePopulateLicType (Write)](#10.53.%20OrderLinePopulateLicType)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: SetOppProductDefaults (Read)](#10.74.%20SetOppProductDefaults)
- [Plugin: SetOppProductDefaults (Write)](#10.74.%20SetOppProductDefaults)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### azt_licensetype

- [Plugin: ChangeLicenseType (Write)](#10.16.%20ChangeLicenseType)
- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityClone (Write)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Write)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderClone (Write)](#10.51.%20OrderClone)
- [Plugin: OrderLinePopulateLicType (Read)](#10.53.%20OrderLinePopulateLicType)
- [Plugin: OrderLinePopulateLicType (Write)](#10.53.%20OrderLinePopulateLicType)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: SetOppProductDefaults (Read)](#10.74.%20SetOppProductDefaults)
- [Plugin: SetOppProductDefaults (Write)](#10.74.%20SetOppProductDefaults)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### azt_masecommission

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_mileage

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_monthstofilteron

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Image)](#10.2.%20AccountLeadGen)

#### azt_name

- [Plugin: AccountLeadGenAssociate (Read)](#10.3.%20AccountLeadGenAssociate)
- [Plugin: AccountLeadGenAssociate (Sort)](#10.3.%20AccountLeadGenAssociate)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AutoNumber (Filter)](#10.13.%20AutoNumber)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CompGoalCreate (Write)](#10.18.%20CompGoalCreate)
- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: LeadImportPopulateName (Write)](#10.37.%20LeadImportPopulateName)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)
- [Plugin: OpptyToQuoteFieldMappings (Sort)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: QuoteOrderProductsTrackDiscount (Sort)](#10.63.%20QuoteOrderProductsTrackDiscount)
- [Plugin: ReviseQuoteDiscountMove (Sort)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: Utility (Write)](#10.81.%20Utility)
- [Plugin: Utility (Sort)](#10.81.%20Utility)

#### azt_newestclosedate

- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_newestimatedvalue

- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_newownerid

- [Plugin: CaseAudit (Write)](#10.14.%20CaseAudit)

#### azt_newprobability

- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_nomatch

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_nonsaasstatus

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Account Status](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Account Status](#2.5.%20Account%20-%20main%20-%20Active)
- [Plugin: AccountTypeSet (Read)](#10.5.%20AccountTypeSet)
- [Plugin: AccountTypeSet (Image)](#10.5.%20AccountTypeSet)

#### azt_nonsaastype

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_numberofcomputers

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_numberoflicenses

- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_numberofstudents

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > COMPANY PROFILE](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_oldbusinessunit

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_opportunityauditrecordid

- [Plugin: OppAuditRemoval (Read)](#10.41.%20OppAuditRemoval)

#### azt_opportunityid

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OppAuditRemoval (Filter)](#10.41.%20OppAuditRemoval)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)

#### azt_opportunityproductid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpportunityPreventCreateQuote (Filter)](#10.47.%20OpportunityPreventCreateQuote)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: QuoteLinesSyncToOppty (Write)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#10.63.%20QuoteOrderProductsTrackDiscount)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### azt_orderid

- [Plugin: CompGoalCreate (Write)](#10.18.%20CompGoalCreate)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)
- [Plugin: OrderStageTracking (Filter)](#10.57.%20OrderStageTracking)
- [Plugin: ShipmentSetTrackingNumber (Read)](#10.79.%20ShipmentSetTrackingNumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_orderlineid

- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: ShipmentSetTrackingNumber (Sort)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_orderproductid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#10.63.%20QuoteOrderProductsTrackDiscount)
- [Plugin: QuoteOrderProductsTrackDiscount (Filter)](#10.63.%20QuoteOrderProductsTrackDiscount)

#### azt_orderstageid

- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)
- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_ordertemplatelines

- [Plugin: OrderLinePopulateTemplateFields (Write)](#10.54.%20OrderLinePopulateTemplateFields)

#### azt_ordertype

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_originatingleadimportid

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_paid

- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_paidon

- [Plugin: FundingSetAnnualSpend (Filter)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_parentaccountid

- [Relationship: azt_parentaccount_azt_softwarelicense](#12.%20Relationships)

#### azt_parentaccountspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [JS: azt_accountlibrary > parentAccountSpend()](#8.2.%20azt_accountlibrary)

#### azt_parentaccountspend_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_parentlastyearspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_parentlastyearspend_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_parentopportunityid

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityAudit (Image)](#10.43.%20OpportunityAudit)

#### azt_parentorderid

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_parentytdspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_parentytdspend_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_payablecommission

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### azt_paymentdate

- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Sort)](#10.81.%20Utility)

#### azt_paymentid

- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_percentage

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_percentagepaid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### azt_periodend

- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_periodstart

- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_phone

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_ponumber

- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_possiblematchid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Relationship: azt_account_account](#12.%20Relationships)

#### azt_prefix

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_prefixhasseparator

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_prefixseparator

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_prefixseparatorisspace

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_previousestclosedate

- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_previousestimatedvalue

- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_previousownerid

- [Plugin: CaseAudit (Write)](#10.14.%20CaseAudit)

#### azt_previousprobability

- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_printproductid

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_printpurchaseid

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_probability

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)
- [Plugin: OpportunityProbabilityChange (Read)](#10.48.%20OpportunityProbabilityChange)
- [Plugin: OpportunityProbabilityChange (Image)](#10.48.%20OpportunityProbabilityChange)
- [Plugin: OpportunityProbabilityNumber (Read)](#10.49.%20OpportunityProbabilityNumber)

#### azt_probabilitychangedon

- [Plugin: OpportunityProbabilityChange (Write)](#10.48.%20OpportunityProbabilityChange)

#### azt_probabilityincreased

- [Plugin: OpportunityProbabilityChange (Write)](#10.48.%20OpportunityProbabilityChange)

#### azt_productdiscountid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#10.63.%20QuoteOrderProductsTrackDiscount)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#10.63.%20QuoteOrderProductsTrackDiscount)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: ReviseQuoteDiscountMove (Write)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_productfamilies

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > Description](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Accounts With Product Family Purchases (Filter)](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)

#### azt_producttype

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#10.35.%20InvoiceCompCompleted)

#### azt_purchasedate

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_quantity

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_quotenumber

- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_quoteproductid

- [Plugin: ActivateOrReviseQuote (Filter)](#10.6.%20ActivateOrReviseQuote)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: ProductDiscountPreventOnActiveQuote (Read)](#10.60.%20ProductDiscountPreventOnActiveQuote)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Filter)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)
- [Plugin: ReviseQuoteDiscountMove (Write)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: ReviseQuoteDiscountMove (Filter)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### azt_reasonforexpense

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_recapnotes

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### azt_recordowner

- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)

#### azt_recordownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: All Accounts](#3.11.%20All%20Accounts)
- [View: All Accounts (Sort)](#3.11.%20All%20Accounts)
- [View: Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
- [View: Duplicate Accounts (Sort)](#3.12.%20Duplicate%20Accounts)
- [View: My Active Accounts (Filter)](#3.18.%20My%20Active%20Accounts)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SharedAccountRecords > Users > account](#5.2.%20SharedAccountRecords)
- [Workflow: 0ChangeQuoteRecordOwner (Write)](#7.1.%200ChangeQuoteRecordOwner)
- [Workflow: AccountAuto-Assign (Write)](#7.3.%20AccountAuto-Assign)
- [Workflow: AppointmentAuto-Assign (Write)](#7.6.%20AppointmentAuto-Assign)
- [Workflow: BatchCreateEngagements (Write)](#7.8.%20BatchCreateEngagements)
- [Workflow: BatchOpportunityTransfer (Write)](#7.11.%20BatchOpportunityTransfer)
- [Workflow: CaseRecordOwner (Write)](#7.14.%20CaseRecordOwner)
- [Workflow: CaseRecordOwnerAssign (Write)](#7.15.%20CaseRecordOwnerAssign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#7.16.%20CaseRecordOwnerAssignmentNotification)
- [Workflow: CloneLicense (Write)](#7.20.%20CloneLicense)
- [Workflow: CloneOpportunity (Write)](#7.21.%20CloneOpportunity)
- [Workflow: ContactAuto-Assign (Write)](#7.23.%20ContactAuto-Assign)
- [Workflow: EngagementRecordOwner (Write)](#7.28.%20EngagementRecordOwner)
- [Workflow: EngagementRecordOwnerTeam (Read)](#7.29.%20EngagementRecordOwnerTeam)
- [Workflow: InvoiceRecordOwner (Write)](#7.31.%20InvoiceRecordOwner)
- [Workflow: LeadAssignment (Write)](#7.32.%20LeadAssignment)
- [Workflow: OpportunityRecordOwner (Write)](#7.38.%20OpportunityRecordOwner)
- [Workflow: OpportunityRecordOwnerTeam (Read)](#7.39.%20OpportunityRecordOwnerTeam)
- [Workflow: OrderRecordOwner (Write)](#7.40.%20OrderRecordOwner)
- [Workflow: PhonecallAuto-Assign (Write)](#7.41.%20PhonecallAuto-Assign)
- [Workflow: QuoteRecordOwner (Write)](#7.44.%20QuoteRecordOwner)
- [Workflow: QuoteRecordOwnerTeam (Read)](#7.45.%20QuoteRecordOwnerTeam)
- [Workflow: SendQuote (Read)](#7.47.%20SendQuote)
- [Workflow: TaskAuto-Assign (Write)](#7.54.%20TaskAuto-Assign)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Read)](#7.56.%20WonOpportunityEmail)
- [Workflow: WorkforceAccountAuto-assign (Write)](#7.57.%20WorkforceAccountAuto-assign)
- [Workflow: WorkforceAppointmentAuto-Assign (Write)](#7.58.%20WorkforceAppointmentAuto-Assign)
- [Workflow: WorkforceCaseAuto-assign (Write)](#7.59.%20WorkforceCaseAuto-assign)
- [Workflow: WorkforceContactAuto-assign (Write)](#7.60.%20WorkforceContactAuto-assign)
- [Workflow: WorkforceEngagementAuto-assign (Write)](#7.61.%20WorkforceEngagementAuto-assign)
- [Workflow: WorkforceLeadAuto-Assign (Write)](#7.62.%20WorkforceLeadAuto-Assign)
- [Workflow: WorkforceOpportunityAuto-assign (Write)](#7.63.%20WorkforceOpportunityAuto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Write)](#7.64.%20WorkforcePhone-callAuto-assign)
- [Workflow: WorkforceQuoteAuto-assign (Write)](#7.65.%20WorkforceQuoteAuto-assign)
- [Workflow: iGradAppointmentAuto-Assign (Write)](#7.66.%20iGradAppointmentAuto-Assign)
- [Workflow: iGradCaseAuto-Assign (Write)](#7.67.%20iGradCaseAuto-Assign)
- [Workflow: iGradPhone-callAuto-assign (Write)](#7.68.%20iGradPhone-callAuto-assign)
- [JS: azt_caselibrary > onLoad()](#8.4.%20azt_caselibrary)
- [JS: azt_engagementlibrary > onLoad()](#8.6.%20azt_engagementlibrary)
- [JS: azt_invoicelibrary > onLoad()](#8.7.%20azt_invoicelibrary)
- [JS: azt_opportunitylibrary > onLoad()](#8.9.%20azt_opportunitylibrary)
- [JS: azt_orderlibrary > onLoad()](#8.11.%20azt_orderlibrary)
- [JS: azt_quotelibrary](#8.14.%20azt_quotelibrary)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#10.8.%20ActivityCloseForceRecordOwner)
- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)
- [Relationship: azt_systemuser_account](#12.%20Relationships)

#### azt_replacementproductid

- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_requestedfreightamt

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

#### azt_resolvedbyid

- [Plugin: CaseClose (Read)](#10.15.%20CaseClose)
- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### azt_result

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_saas

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_saasstatus

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > Account Status](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > Account Status](#2.5.%20Account%20-%20main%20-%20Active)
- [Plugin: AccountTypeSet (Read)](#10.5.%20AccountTypeSet)
- [Plugin: AccountTypeSet (Image)](#10.5.%20AccountTypeSet)

#### azt_salesrepid

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#10.35.%20InvoiceCompCompleted)

#### azt_score

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_softwarelicenseid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: AllocationValidation (Filter)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_softwareproductid

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_startdate

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_stateabbreviation

- [Plugin: AccountAutoAssign (Filter)](#10.1.%20AccountAutoAssign)

#### azt_stateprovince

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_suffix

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_suffixhasseparator

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_suffixseparator

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_suffixseparatorisspace

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_supportexpirationdate

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_tax_exempt_certificate__c

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_taxamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### azt_taxexemptcertificate

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)

#### azt_total

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_totalamountpaid

- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_totalfunding

- [Plugin: FundingTotalAmt (Write)](#10.29.%20FundingTotalAmt)

#### azt_totalreimbursement

- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)

#### azt_trackingnumber

- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: ShipmentSetTrackingNumber (Read)](#10.79.%20ShipmentSetTrackingNumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_trackingnumbers

- [Plugin: ShipmentSetTrackingNumber (Write)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_trainingid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)

#### azt_ttprintnotto

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_type

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_verticalmarket

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account (Header)](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > Summary > COMPANY PROFILE](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account (Header)](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > COMPANY PROFILE](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Account Lead Quick View > Tab > section](#2.10.%20Account%20Lead%20Quick%20View%20-%20quick%20-%20Active)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Read)](#7.26.%20CreateLeadfromAccount)
- [JS: azt_accountlibrary > setNonIgradVerticalMarket()](#8.2.%20azt_accountlibrary)
- [JS: azt_accountlibrary > setiGradVerticalMarket()](#8.2.%20azt_accountlibrary)

#### azt_year

- [Plugin: FundingYearSync (Write)](#10.30.%20FundingYearSync)

#### azt_yearbeforelastspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Formula: azt_yearbeforelastspend (Target)](#9.%20Formulas%20and%20Rollups)

#### azt_yearbeforelastspend_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_ytdspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Account > Administration > Section](#2.5.%20Account%20-%20main%20-%20Active)
- [Formula: azt_ytdspend (Target)](#9.%20Formulas%20and%20Rollups)

#### azt_ytdspend_base

- [Field Definitions](#1.%20Field%20Definitions)

#### baseamount

- [Report: PAQuoteReport > QuoteHeader > quotedetail](#5.1.%20PAQuoteReport)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### billto_city

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### billto_line1

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_line2

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_line3

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_name

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_postalcode

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_stateorprovince

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### body

- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### bpf_duration

- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)

#### bpf_salesorderid

- [Plugin: OrderStageTracking (Filter)](#10.57.%20OrderStageTracking)

#### businessprocessflowinstanceid

- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)

#### businessunitid

- [Plugin: AccountAutoAssign (Read)](#10.1.%20AccountAutoAssign)
- [Plugin: ExpenseRestrictVisibility (Read)](#10.27.%20ExpenseRestrictVisibility)
- [Plugin: GetUserHasRole (Read)](#10.32.%20GetUserHasRole)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)
- [Plugin: RestrictProductLookups (Read)](#10.69.%20RestrictProductLookups)
- [Plugin: RestrictWinOpportunities (Read)](#10.70.%20RestrictWinOpportunities)
- [Plugin: RestrictWinQuote (Read)](#10.71.%20RestrictWinQuote)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### category

- [Plugin: ContactSetConnectionRole (Sort)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Sort)](#10.75.%20SetPrimaryContact)

#### changedon

- [Report: SharedAccountRecords > Users > principalobjectaccess](#5.2.%20SharedAccountRecords)

#### childaccounts

- [Form: iGrad Account > Summary > CHILD ACCOUNTS](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > CHILD ACCOUNTS](#2.5.%20Account%20-%20main%20-%20Active)

#### city

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### closeprobability

- [Plugin: OpportunityProbabilityNumber (Write)](#10.49.%20OpportunityProbabilityNumber)

#### companyname

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### connectionid

- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)

#### connectionroleid

- [Plugin: ContactSetConnectionRole (Read)](#10.19.%20ContactSetConnectionRole)
- [Plugin: ContactSetConnectionRole (Join)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Join)](#10.75.%20SetPrimaryContact)

#### connections

- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)

#### consideronlygoalownersrecords

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### contactid

- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)

#### contacts

- [Form: iGrad Account > Summary > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > SUMMARY_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)

#### country

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### county

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### createdby

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: AccountAuto-Assign (Read)](#7.3.%20AccountAuto-Assign)
- [Workflow: WorkforceAccountAuto-assign (Read)](#7.57.%20WorkforceAccountAuto-assign)

#### createdon

- [Plugin: AccountLeadGen (Filter)](#10.2.%20AccountLeadGen)
- [Plugin: ChangeLicenseType (Sort)](#10.16.%20ChangeLicenseType)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Sort)](#10.35.%20InvoiceCompCompleted)
- [Plugin: OpptyToQuoteFieldMappings (Sort)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)
- [Plugin: OrderStageTracking (Sort)](#10.57.%20OrderStageTracking)
- [Plugin: ShipmentSetTrackingNumber (Sort)](#10.79.%20ShipmentSetTrackingNumber)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)

#### crm3_expenseamount

- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)

#### crm3_parentleadid

- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Filter)](#10.26.%20ExpenseLineTotals)

#### customerid

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: AccountLeadGen (Join)](#10.2.%20AccountLeadGen)
- [Plugin: AccountReassignmentShareRecords (Filter)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: FundingSetAnnualSpend (Filter)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)
- [Relationship: incident_customer_accounts](#12.%20Relationships)
- [Relationship: invoice_customer_accounts](#12.%20Relationships)
- [Relationship: lead_customer_accounts](#12.%20Relationships)
- [Relationship: opportunity_customer_accounts](#12.%20Relationships)
- [Relationship: order_customer_accounts](#12.%20Relationships)
- [Relationship: quote_customer_accounts](#12.%20Relationships)

#### datefulfilled

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### defaultuomid

- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)

#### description

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > Description](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)
- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)

#### discountamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#10.72.%20ReviseQuoteDiscountMove)

#### discountpercentage

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)

#### documentssubgrid

- [Form: iGrad Account > Files > Documents Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)

#### donotsendmm

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > MARKETING](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)

#### effectivefrom

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### effectiveto

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### emailaddress1

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Filter)](#10.36.%20LeadImport)

#### engagementcontacts

- [Form: Engagement Contacts > Tab > section](#2.12.%20Engagement%20Contacts%20-%20quick%20-%20Active)

#### engagements

- [Form: iGrad Account > Engagements > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Engagements > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### estimatedclosedate

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityClone (Write)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)

#### estimatedvalue

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)

#### ext_amt

- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)

#### extendedamount

- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### fax

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)

#### fetchxml

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### filename

- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### firstname

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### fiscalperiod

- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)

#### freightamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#10.66.%20QuoteSyncTotalToOpportunity)

#### freighttermscode

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### from

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### fullname

- [Report: PAQuoteReport > QuoteHeader > contact](#5.1.%20PAQuoteReport)
- [Report: SharedAccountRecords > Users (Select)](#5.2.%20SharedAccountRecords)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Sort)](#10.36.%20LeadImport)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Sort)](#10.81.%20Utility)

#### funding

- [Form: Account > SUMMARY_TAB > Funding](#2.5.%20Account%20-%20main%20-%20Active)

#### fundinggrid

- [Form: Last Purchase Dates Quick View > Tab > Funding](#2.8.%20Last%20Purchase%20Dates%20Quick%20View%20-%20quick%20-%20Active)

#### goalenddate

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### goalid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### goalownerid

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### goalrollupqueryid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### goalstartdate

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### incidentid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### internalemailaddress

- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### invline.productid

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)

#### invoicedetailid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#10.63.%20QuoteOrderProductsTrackDiscount)

#### invoiceid

- [Plugin: AccountLeadGen (Join)](#10.2.%20AccountLeadGen)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateCompGoals (Filter)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Join)](#10.22.%20CreateUserGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### invoicenumber

- [Plugin: CompGoalCreate (Read)](#10.18.%20CompGoalCreate)

#### invoices

- [Form: iGrad Account > Quotes Orders Invoices > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Quotes Orders Invoices > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### isamount

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### isfiscalperiodgoal

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### isocurrencycode

- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### ispriceoverridden

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### isproductoverridden

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### isrevenuesystemcalculated

- [Plugin: QuoteSyncTotalToOpportunity (Write)](#10.66.%20QuoteSyncTotalToOpportunity)

#### jobtitle

- [Report: PAQuoteReport > QuoteHeader > systemuser](#5.1.%20PAQuoteReport)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### lastname

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### lastusedincampaign

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > MARKETING](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)

#### manualdiscountamount

- [Report: PAQuoteReport > QuoteHeader > quotedetail](#5.1.%20PAQuoteReport)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: ManualDiscountKill (Read)](#10.40.%20ManualDiscountKill)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### mapcontrol

- [Form: iGrad Account > Summary > MapSection](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)

#### metricid

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### mimetype

- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### mobilephone

- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### modifiedon

- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: OpportunityLineSyncToQuote (Sort)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: UpdateOppFromQuote (Sort)](#10.80.%20UpdateOppFromQuote)

#### msa_managingpartnerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Relationship: msa_account_managingpartner](#12.%20Relationships)
- [Relationship: msa_contact_managingpartner](#12.%20Relationships)

#### msa_partnerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Relationship: msa_account_incident](#12.%20Relationships)
- [Relationship: msa_partner_opportunity](#12.%20Relationships)

#### msdyn_accountkpiid

- [Field Definitions](#1.%20Field%20Definitions)
- [Relationship: msdyn_msdyn_accountkpiitem_account_accountkpiid](#12.%20Relationships)

#### msdyn_salesaccelerationinsightid

- [Field Definitions](#1.%20Field%20Definitions)
- [Relationship: msdyn_insightsid_salesaccelerationinsights](#12.%20Relationships)

#### msdyn_segmentid

- [Field Definitions](#1.%20Field%20Definitions)
- [Relationship: msdyn_msdyn_segment_account](#12.%20Relationships)

#### name

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > Assets and Locations > Assets and Locations](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > LinkedIn Sales Navigator > LinkedIn Account Profile](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [View: Account Advanced Find View](#3.1.%20Account%20Advanced%20Find%20View)
- [View: Account Advanced Find View (Sort)](#3.1.%20Account%20Advanced%20Find%20View)
- [View: Account Associated View](#3.2.%20Account%20Associated%20View)
- [View: Account Associated View (Sort)](#3.2.%20Account%20Associated%20View)
- [View: Account BulkOperation View](#3.3.%20Account%20BulkOperation%20View)
- [View: Account BulkOperation View (Sort)](#3.3.%20Account%20BulkOperation%20View)
- [View: Account List Member View](#3.4.%20Account%20List%20Member%20View)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)
- [View: Account Lookup View (Sort)](#3.5.%20Account%20Lookup%20View)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Accounts With Product Family Purchases (Sort)](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Accounts: No Orders in Last 6 Months](#3.8.%20Accounts%3A%20No%20Orders%20in%20Last%206%20Months)
- [View: Accounts: No Orders in Last 6 Months (Sort)](#3.8.%20Accounts%3A%20No%20Orders%20in%20Last%206%20Months)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts in Quickbooks (Sort)](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: Active Accounts (Sort)](#3.10.%20Active%20Accounts)
- [View: All Accounts](#3.11.%20All%20Accounts)
- [View: All Accounts (Sort)](#3.11.%20All%20Accounts)
- [View: Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
- [View: Duplicate Accounts (Sort)](#3.12.%20Duplicate%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Customers Without Kaplan (Sort)](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED Flash/Play Without Any GED (Sort)](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: GED/KaplanGED Customers Without Flash (Sort)](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: HiSET Customers Without Kaplan HiSET (Sort)](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: Inactive Accounts](#3.17.%20Inactive%20Accounts)
- [View: Inactive Accounts (Sort)](#3.17.%20Inactive%20Accounts)
- [View: My Active Accounts](#3.18.%20My%20Active%20Accounts)
- [View: My Active Accounts (Sort)](#3.18.%20My%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: My Active Customers With Purchase Dates (Sort)](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: My Connections](#3.20.%20My%20Connections)
- [View: My Connections (Sort)](#3.20.%20My%20Connections)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [View: New Customer Introduction List (Sort)](#3.21.%20New%20Customer%20Introduction%20List)
- [View: Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Old Duplicate Accounts View (Sort)](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: Quick Find Active Accounts (Filter)](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: Quick Find Active Accounts (Sort)](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [View: TASC Customers Without Kaplan TASC (Sort)](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PAQuoteReport > QuoteHeader (Sort)](#5.1.%20PAQuoteReport)
- [Report: SharedAccountRecords > Users > account](#5.2.%20SharedAccountRecords)
- [Workflow: 0EngagementNames (Read)](#7.2.%200EngagementNames)
- [Workflow: BatchConverttoLead (Read)](#7.7.%20BatchConverttoLead)
- [Workflow: BatchCreateEngagements (Read)](#7.8.%20BatchCreateEngagements)
- [Workflow: BatchLooseOpportunities (Read)](#7.10.%20BatchLooseOpportunities)
- [Workflow: BatchOpportunityTransfer (Read)](#7.11.%20BatchOpportunityTransfer)
- [Workflow: CloneAndDeleteQuote (Read)](#7.18.%20CloneAndDeleteQuote)
- [Workflow: CloneOpportunity (Read)](#7.21.%20CloneOpportunity)
- [Workflow: CloneOrder (Read)](#7.22.%20CloneOrder)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Read)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Read)](#7.27.%20CustomLeadCreation)
- [Workflow: NewFSRLeadNotification (Read)](#7.36.%20NewFSRLeadNotification)
- [Workflow: QualifyLead (Write)](#7.43.%20QualifyLead)
- [Workflow: RenameEngagements (Read)](#7.46.%20RenameEngagements)
- [Workflow: TaskCreateReorderLead (Read)](#7.55.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Read)](#7.56.%20WonOpportunityEmail)
- [JS: azt_accountlibrary > createLead()](#8.2.%20azt_accountlibrary)
- [JS: azt_accountlibrary > createNewLead()](#8.2.%20azt_accountlibrary)
- [JS: azt_addresslibrary > addAddress()](#8.3.%20azt_addresslibrary)
- [JS: azt_opportunitytrackdiscount > trackDiscount()](#8.10.%20azt_opportunitytrackdiscount)
- [JS: azt_sendquote](#8.15.%20azt_sendquote)
- [Plugin: AccountAutoAssign (Filter)](#10.1.%20AccountAutoAssign)
- [Plugin: AccountAutoAssign (Sort)](#10.1.%20AccountAutoAssign)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ContactSetConnectionRole (Filter)](#10.19.%20ContactSetConnectionRole)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: GetAcctTeamOwned (Read)](#10.31.%20GetAcctTeamOwned)
- [Plugin: GetAcctTeamOwned (Sort)](#10.31.%20GetAcctTeamOwned)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Filter)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Sort)](#10.36.%20LeadImport)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)
- [Plugin: QuoteCloneAndDelete (Sort)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: RestrictCreateQuote (Sort)](#10.68.%20RestrictCreateQuote)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Filter)](#10.75.%20SetPrimaryContact)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### new_sharedwith

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > Description](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)
- [Relationship: new_systemuser_account_SharedWith](#12.%20Relationships)

#### notescontrol

- [Form: TimelineWallControl - Account- Main > SUMMARY_TAB > SOCIAL_PANE_TAB](#2.1.%20TimelineWallControl%20-%20Account-%20Main%20-%20main%20-%20Active)
- [Form: iGrad Account > Summary > SOCIAL PANE](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > SOCIAL_PANE_TAB](#2.5.%20Account%20-%20main%20-%20Active)

#### objectid

- [Report: SharedAccountRecords > Users > principalobjectaccess](#5.2.%20SharedAccountRecords)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)
- [Relationship: Account_Annotation](#12.%20Relationships)

#### objecttypecode

- [Report: SharedAccountRecords > Users > principalobjectaccess](#5.2.%20SharedAccountRecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess (Filter)](#5.2.%20SharedAccountRecords)
- [Report: SharedAccountRecords > Users > principalobjectaccess (Sort)](#5.2.%20SharedAccountRecords)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### opportunities

- [Form: iGrad Account > Opportunities > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Opportunities > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### opportunityid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ChangeLicenseType (Filter)](#10.16.%20ChangeLicenseType)
- [Plugin: CreateUserGoals (Join)](#10.22.%20CreateUserGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpportunityAssignFromLead (Write)](#10.42.%20OpportunityAssignFromLead)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityClone (Write)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityClone (Filter)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLastActivityDate (Write)](#10.45.%20OpportunityLastActivityDate)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Image)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityPreventCreateQuote (Read)](#10.47.%20OpportunityPreventCreateQuote)
- [Plugin: OpportunityPreventCreateQuote (Filter)](#10.47.%20OpportunityPreventCreateQuote)
- [Plugin: OpportunityProbabilityNumber (Write)](#10.49.%20OpportunityProbabilityNumber)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteLinesSyncToOppty (Write)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Filter)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#10.66.%20QuoteSyncTotalToOpportunity)
- [Plugin: QuoteSyncTotalToOpportunity (Write)](#10.66.%20QuoteSyncTotalToOpportunity)
- [Plugin: RestrictCreateQuote (Filter)](#10.68.%20RestrictCreateQuote)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)
- [Plugin: UpdateOppFromQuote (Filter)](#10.80.%20UpdateOppFromQuote)

#### opportunityproductid

- [Plugin: ChangeLicenseType (Read)](#10.16.%20ChangeLicenseType)
- [Plugin: ChangeLicenseType (Write)](#10.16.%20ChangeLicenseType)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityPreventCreateQuote (Read)](#10.47.%20OpportunityPreventCreateQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteLinesSyncToOppty (Write)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: SetOppProductDefaults (Read)](#10.74.%20SetOppProductDefaults)
- [Plugin: SetOppProductDefaults (Write)](#10.74.%20SetOppProductDefaults)

#### orders

- [Form: iGrad Account > Quotes Orders Invoices > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Quotes Orders Invoices > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### originatingleadid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Details > Description](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > Details > MARKETING](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > DETAILS_TAB_section_6](#2.5.%20Account%20-%20main%20-%20Active)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: OpportunityAssignFromLead (Read)](#10.42.%20OpportunityAssignFromLead)
- [Relationship: account_originating_lead](#12.%20Relationships)

#### ownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account (Header)](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account Owner Card > Tab > section](#2.7.%20Account%20Owner%20Card%20-%20quick%20-%20Active)
- [Form: Account Owner Quick View > Tab > section](#2.11.%20Account%20Owner%20Quick%20View%20-%20quick%20-%20Active)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [Report: SharedAccountRecords > Users > account](#5.2.%20SharedAccountRecords)
- [Workflow: AllocationsAssigntoTeam (Read)](#7.5.%20AllocationsAssigntoTeam)
- [Workflow: AppointmentAuto-Assign (Read)](#7.6.%20AppointmentAuto-Assign)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: CasePendingAssignmentNotification (Read)](#7.13.%20CasePendingAssignmentNotification)
- [Workflow: CaseRecordOwner (Read)](#7.14.%20CaseRecordOwner)
- [Workflow: CloneAndDeleteQuote (Write)](#7.18.%20CloneAndDeleteQuote)
- [Workflow: CloneCommissionPayment (Write)](#7.19.%20CloneCommissionPayment)
- [Workflow: CloneOpportunity (Write)](#7.21.%20CloneOpportunity)
- [Workflow: ContactAuto-Assign (Read)](#7.23.%20ContactAuto-Assign)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: EngagementRecordOwner (Read)](#7.28.%20EngagementRecordOwner)
- [Workflow: FSRLeadDistibutionNotification (Write)](#7.30.%20FSRLeadDistibutionNotification)
- [Workflow: InvoiceRecordOwner (Read)](#7.31.%20InvoiceRecordOwner)
- [Workflow: LeadAssignment (Read)](#7.32.%20LeadAssignment)
- [Workflow: OpportunityRecordOwner (Read)](#7.38.%20OpportunityRecordOwner)
- [Workflow: OrderRecordOwner (Read)](#7.40.%20OrderRecordOwner)
- [Workflow: PhonecallAuto-Assign (Read)](#7.41.%20PhonecallAuto-Assign)
- [Workflow: PrintPurchaseAssigntoTeam (Read)](#7.42.%20PrintPurchaseAssigntoTeam)
- [Workflow: QuoteRecordOwner (Read)](#7.44.%20QuoteRecordOwner)
- [Workflow: SoftwareLicenseAssigntoTeam (Read)](#7.51.%20SoftwareLicenseAssigntoTeam)
- [Workflow: SoftwareLicenseSetOwner (Read)](#7.53.%20SoftwareLicenseSetOwner)
- [Workflow: TaskAuto-Assign (Read)](#7.54.%20TaskAuto-Assign)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)
- [JS: azt_leadlibrary > onSave()](#8.8.%20azt_leadlibrary)
- [JS: azt_productdiscountlibrary](#8.13.%20azt_productdiscountlibrary)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: CaseAudit (Read)](#10.14.%20CaseAudit)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateCompGoals (Filter)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: EngagementFSRAssignedOn (Read)](#10.24.%20EngagementFSRAssignedOn)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)
- [Plugin: OpportunityAssignFromLead (Write)](#10.42.%20OpportunityAssignFromLead)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Image)](#10.59.%20PhonecallCreateCallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)
- [Plugin: Utility (Write)](#10.81.%20Utility)
- [Plugin: Utility (Filter)](#10.81.%20Utility)
- [Plugin: Utility (Sort)](#10.81.%20Utility)

#### owningteam

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CaseRecordOwnerAssign (Read)](#7.15.%20CaseRecordOwnerAssign)
- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)

#### owninguser

- [Plugin: GetAcctTeamOwned (Join)](#10.31.%20GetAcctTeamOwned)

#### parentaccountid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account Lead Quick View > Tab > section](#2.10.%20Account%20Lead%20Quick%20View%20-%20quick%20-%20Active)
- [View: Old Duplicate Accounts View](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [Workflow: AppointmentAuto-Assign (Read)](#7.6.%20AppointmentAuto-Assign)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: CloneOpportunity (Write)](#7.21.%20CloneOpportunity)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.27.%20CustomLeadCreation)
- [Workflow: LeadAssignment (Read)](#7.32.%20LeadAssignment)
- [Workflow: OpportunityRecordOwner (Read)](#7.38.%20OpportunityRecordOwner)
- [Workflow: PhonecallAuto-Assign (Read)](#7.41.%20PhonecallAuto-Assign)
- [Workflow: QualifyLead (Write)](#7.43.%20QualifyLead)
- [Workflow: TaskAuto-Assign (Read)](#7.54.%20TaskAuto-Assign)
- [Workflow: TaskCreateReorderLead (Read)](#7.55.%20TaskCreateReorderLead)
- [JS: azt_accountlibrary > parentAccountSpend()](#8.2.%20azt_accountlibrary)
- [JS: azt_leadlibrary > getAccountPopulated()](#8.8.%20azt_leadlibrary)
- [JS: azt_leadlibrary > qualifyLead()](#8.8.%20azt_leadlibrary)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: LeadQualify (Read)](#10.38.%20LeadQualify)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Relationship: account_parent_account](#12.%20Relationships)
- [Relationship: opportunity_parent_account](#12.%20Relationships)

#### parentcontactid

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### parentcustomerid

- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)
- [Relationship: contact_customer_accounts](#12.%20Relationships)

#### parentgoalid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### parentid

- [Field Definitions](#1.%20Field%20Definitions)
- [Relationship: Account_CustomerAddress](#12.%20Relationships)

#### parentsystemuserid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### partyid

- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### phonenumber

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### previews

- [Form: Account > SUMMARY_TAB > Previews](#2.5.%20Account%20-%20main%20-%20Active)

#### pricelevelid

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### priceperunit

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### primarycontactid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > LinkedIn Sales Navigator > LinkedIn Member Profile](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > LinkedIn Sales Navigator > LinkedIn InMail](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Read)](#7.26.%20CreateLeadfromAccount)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)

#### print

- [Form: iGrad Account > Print > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Print > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### prod.productid

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)

#### productdescription

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)

#### productid

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Write)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Filter)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Join)](#10.2.%20AccountLeadGen)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Sort)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Sort)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityClone (Sort)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderClone (Sort)](#10.51.%20OrderClone)
- [Plugin: OrderLinePopulateTemplateFields (Sort)](#10.54.%20OrderLinePopulateTemplateFields)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Sort)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteCloneAndDelete (Sort)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteLinesSyncToOppty (Filter)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteLinesSyncToOppty (Sort)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: ReviseQuoteDiscountMove (Sort)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: SetOppProductDefaults (Read)](#10.74.%20SetOppProductDefaults)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### productname

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)

#### productnumber

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: RestrictProductLookups (Filter)](#10.69.%20RestrictProductLookups)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### producttypecode

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)

#### purchasedsoftware

- [Form: iGrad Account > Software > Purchased Software](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Software > Purchased Software](#2.5.%20Account%20-%20main%20-%20Active)
- [Form: Purchased Software Licenses > Tab > section](#2.6.%20Purchased%20Software%20Licenses%20-%20quick%20-%20Active)

#### quantity

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderLinePopulateTemplateFields (Read)](#10.54.%20OrderLinePopulateTemplateFields)
- [Plugin: OrderManuallyCreateSoftwareLicense (Read)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteCloneAndDelete (Write)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteLinesSyncToOppty (Write)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### queryentitytype

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### queueid

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### queueitemid

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### quotedetailid

- [Plugin: ActivateOrReviseQuote (Read)](#10.6.%20ActivateOrReviseQuote)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Write)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderLinePopulateLicType (Read)](#10.53.%20OrderLinePopulateLicType)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Write)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#10.63.%20QuoteOrderProductsTrackDiscount)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)

#### quoteid

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: ActivateOrReviseQuote (Filter)](#10.6.%20ActivateOrReviseQuote)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpportunityLineSyncToQuote (Filter)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: ProductDiscountPreventOnActiveQuote (Read)](#10.60.%20ProductDiscountPreventOnActiveQuote)
- [Plugin: QuoteCloneAndDelete (Write)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteCloneAndDelete (Filter)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Filter)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)
- [Plugin: RestrictCreateQuote (Read)](#10.68.%20RestrictCreateQuote)
- [Plugin: ReviseQuoteDiscountMove (Write)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: ReviseQuoteDiscountMove (Filter)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)

#### quotenumber

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### quotes

- [Form: iGrad Account > Quotes Orders Invoices > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > Quotes Orders Invoices > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### record1id

- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: LeadQualifyParentStakeholderContacts (Filter)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Filter)](#10.75.%20SetPrimaryContact)

#### record1roleid

- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)

#### record2id

- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: LeadQualifyParentStakeholderContacts (Sort)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Filter)](#10.75.%20SetPrimaryContact)

#### record2roleid

- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Join)](#10.75.%20SetPrimaryContact)

#### regardingobjectid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Filter)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)
- [Relationship: Account_Appointments](#12.%20Relationships)
- [Relationship: Account_Emails](#12.%20Relationships)
- [Relationship: Account_Letters](#12.%20Relationships)
- [Relationship: Account_Phonecalls](#12.%20Relationships)
- [Relationship: Account_Tasks](#12.%20Relationships)
- [Relationship: account_OpportunityCloses](#12.%20Relationships)
- [Relationship: account_OrderCloses](#12.%20Relationships)
- [Relationship: account_QuoteCloses](#12.%20Relationships)

#### requestdeliveryby

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### ricontainer_charts

- [Form: AI for Sales > RAV2 > RAV2_section_1](#2.3.%20AI%20for%20Sales%20-%20main%20-%20Inactive)

#### roleid

- [Plugin: GetUserHasRoleToAction (Read)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: GetUserHasRoleToAction (Filter)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: GetUserHasRoleToAction (Join)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Filter)](#10.81.%20Utility)
- [Plugin: Utility (Join)](#10.81.%20Utility)

#### rolluponlyfromchildgoals

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### rollupqueryactualmoneyid

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### rolluprulestep1_1

- [Formula: azt_accountspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_10

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_11

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_12

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_13

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_2

- [Formula: azt_accountspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_3

- [Formula: azt_accountspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_4

- [Formula: azt_accountspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_5

- [Formula: azt_accountspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_6

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_7

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_8

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_9

- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_yearbeforelastspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)

#### salesorderdetailid

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderLinePopulateLicType (Write)](#10.53.%20OrderLinePopulateLicType)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#10.63.%20QuoteOrderProductsTrackDiscount)

#### salesorderdetailname

- [Plugin: OrderLinePopulateTemplateFields (Read)](#10.54.%20OrderLinePopulateTemplateFields)

#### salesorderid

- [Plugin: CompGoalCreate (Read)](#10.18.%20CompGoalCreate)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Filter)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OrderClone (Filter)](#10.51.%20OrderClone)
- [Plugin: OrderLinePopulateTemplateFields (Write)](#10.54.%20OrderLinePopulateTemplateFields)
- [Plugin: OrderLinePopulateTemplateFields (Filter)](#10.54.%20OrderLinePopulateTemplateFields)
- [Plugin: OrderSplit (Filter)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteCloneAndDelete (Filter)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareWithAccountOwner (Filter)](#10.78.%20ShareWithAccountOwner)
- [Plugin: ShipmentSetTrackingNumber (Write)](#10.79.%20ShipmentSetTrackingNumber)

#### salesrepid

- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### scheduledend

- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#10.7.%20ActivitiesCreatedDueDatesInPast)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### shareduser.fullname

- [View: Account Sharing Associated View](#3.6.%20Account%20Sharing%20Associated%20View)

#### sharedwith

- [Form: iGrad Account > Details > Section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > Section](#2.5.%20Account%20-%20main%20-%20Active)

#### shippingmethodcode

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_city

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### shipto_contactname

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### shipto_country

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### shipto_line1

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_line2

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_line3

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_name

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_postalcode

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_stateorprovince

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### softwarelicenseallocations

- [Form: Allocated Software Licenses > Tab > section](#2.9.%20Allocated%20Software%20Licenses%20-%20quick%20-%20Active)

#### state

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### statecode

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Account Associated View (Filter)](#3.2.%20Account%20Associated%20View)
- [View: Account Lookup View (Filter)](#3.5.%20Account%20Lookup%20View)
- [View: Accounts With Product Family Purchases (Filter)](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Active Accounts in Quickbooks (Filter)](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts (Filter)](#3.10.%20Active%20Accounts)
- [View: All Accounts](#3.11.%20All%20Accounts)
- [View: Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
- [View: Duplicate Accounts (Filter)](#3.12.%20Duplicate%20Accounts)
- [View: GED Customers Without Kaplan (Filter)](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: Inactive Accounts (Filter)](#3.17.%20Inactive%20Accounts)
- [View: My Active Accounts (Filter)](#3.18.%20My%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates (Filter)](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: My Connections (Filter)](#3.20.%20My%20Connections)
- [View: New Customer Introduction List (Filter)](#3.21.%20New%20Customer%20Introduction%20List)
- [View: Old Duplicate Accounts View (Filter)](#3.22.%20Old%20Duplicate%20Accounts%20View)
- [View: Quick Find Active Accounts (Filter)](#3.23.%20Quick%20Find%20Active%20Accounts)
- [Workflow: BatchConverttoLead (Write)](#7.7.%20BatchConverttoLead)
- [Workflow: CaseResolutionNotificationEmail (Read)](#7.17.%20CaseResolutionNotificationEmail)
- [Workflow: CloneOrder (Write)](#7.22.%20CloneOrder)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.25.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.26.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.27.%20CustomLeadCreation)
- [Workflow: LeadQualifyDisqualifyDate (Read)](#7.33.%20LeadQualifyDisqualifyDate)
- [Workflow: OpportunityAuditRemoval (Read)](#7.37.%20OpportunityAuditRemoval)
- [Workflow: TaskCreateReorderLead (Write)](#7.55.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Read)](#7.56.%20WonOpportunityEmail)
- [Formula: azt_accountspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_lastyearspend](#9.%20Formulas%20and%20Rollups)
- [Formula: azt_ytdspend](#9.%20Formulas%20and%20Rollups)
- [Plugin: AccountLeadGen (Filter)](#10.2.%20AccountLeadGen)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#10.8.%20ActivityCloseForceRecordOwner)
- [Plugin: AllocationValidation (Filter)](#10.11.%20AllocationValidation)
- [Plugin: ContactSetConnectionRole (Read)](#10.19.%20ContactSetConnectionRole)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: ExpenseRestrictVisibility (Filter)](#10.27.%20ExpenseRestrictVisibility)
- [Plugin: FundingSetAnnualSpend (Filter)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: LeadImport (Filter)](#10.36.%20LeadImport)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: ProductDiscountPreventOnActiveQuote (Read)](#10.60.%20ProductDiscountPreventOnActiveQuote)
- [Plugin: RestrictCreateQuote (Filter)](#10.68.%20RestrictCreateQuote)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### stateorprovince

- [Plugin: AutoAssignStateAbb (Read)](#10.12.%20AutoAssignStateAbb)
- [Plugin: AutoAssignStateAbb (Write)](#10.12.%20AutoAssignStateAbb)

#### statuscode

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### street

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### subject

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### systemuserid

- [Plugin: GetAcctTeamOwned (Join)](#10.31.%20GetAcctTeamOwned)
- [Plugin: GetUserHasRoleToAction (Filter)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: GetUserHasRoleToAction (Join)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: Utility (Filter)](#10.81.%20Utility)
- [Plugin: Utility (Join)](#10.81.%20Utility)

#### tax

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)

#### teamid

- [Plugin: AccountAutoAssign (Read)](#10.1.%20AccountAutoAssign)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)

#### teamtype

- [Plugin: AccountAutoAssign (Filter)](#10.1.%20AccountAutoAssign)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)

#### telephone1

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)
- [View: Account Advanced Find View](#3.1.%20Account%20Advanced%20Find%20View)
- [View: Account Associated View](#3.2.%20Account%20Associated%20View)
- [View: Account BulkOperation View](#3.3.%20Account%20BulkOperation%20View)
- [View: Account List Member View](#3.4.%20Account%20List%20Member%20View)
- [View: Account Lookup View](#3.5.%20Account%20Lookup%20View)
- [View: Accounts With Product Family Purchases](#3.7.%20Accounts%20With%20Product%20Family%20Purchases)
- [View: Accounts: No Orders in Last 6 Months](#3.8.%20Accounts%3A%20No%20Orders%20in%20Last%206%20Months)
- [View: Active Accounts in Quickbooks](#3.9.%20Active%20Accounts%20in%20Quickbooks)
- [View: Active Accounts](#3.10.%20Active%20Accounts)
- [View: All Accounts](#3.11.%20All%20Accounts)
- [View: Duplicate Accounts](#3.12.%20Duplicate%20Accounts)
- [View: GED Customers Without Kaplan](#3.13.%20GED%20Customers%20Without%20Kaplan)
- [View: GED Flash/Play Without Any GED](#3.14.%20GED%20Flash%2FPlay%20Without%20Any%20GED)
- [View: GED/KaplanGED Customers Without Flash](#3.15.%20GED%2FKaplanGED%20Customers%20Without%20Flash)
- [View: HiSET Customers Without Kaplan HiSET](#3.16.%20HiSET%20Customers%20Without%20Kaplan%20HiSET)
- [View: Inactive Accounts](#3.17.%20Inactive%20Accounts)
- [View: My Active Accounts](#3.18.%20My%20Active%20Accounts)
- [View: My Active Customers With Purchase Dates](#3.19.%20My%20Active%20Customers%20With%20Purchase%20Dates)
- [View: My Connections](#3.20.%20My%20Connections)
- [View: New Customer Introduction List](#3.21.%20New%20Customer%20Introduction%20List)
- [View: Quick Find Active Accounts](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: Quick Find Active Accounts (Filter)](#3.23.%20Quick%20Find%20Active%20Accounts)
- [View: TASC Customers Without Kaplan TASC](#3.24.%20TASC%20Customers%20Without%20Kaplan%20TASC)
- [JS: azt_accountlibrary > formatMe()](#8.2.%20azt_accountlibrary)
- [JS: azt_accountlibrary > formatNumber()](#8.2.%20azt_accountlibrary)
- [JS: azt_phonecalllibrary > onLoad()](#8.12.%20azt_phonecalllibrary)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### telephone2

- [Field Definitions](#1.%20Field%20Definitions)

#### title

- [Report: PAQuoteReport > QuoteHeader > systemuser](#5.1.%20PAQuoteReport)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)

#### tm.systemuserid

- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)

#### to

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### totalamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#10.66.%20QuoteSyncTotalToOpportunity)

#### totallineitemamount

- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)

#### transactioncurrencyid

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### uomid

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)

#### value

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### webresource_recordwall

- [Form: Information > What's New > Section](#2.4.%20Information%20-%20main%20-%20Inactive)

#### websiteurl

- [Form: iGrad Account > Summary > ACCOUNT INFORMATION](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > SUMMARY_TAB > ACCOUNT_INFORMATION](#2.5.%20Account%20-%20main%20-%20Active)

#### writeteam

- [Form: iGrad Account > Details > section](#2.2.%20iGrad%20Account%20-%20main%20-%20Active)
- [Form: Account > DETAILS_TAB > section](#2.5.%20Account%20-%20main%20-%20Active)

#### zipcode

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### {0}

- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
