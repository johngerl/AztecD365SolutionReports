# Quote Field Usage Analysis
> Date: 2026-03-25

| Property | Value |
|---|---|
| **Entity Name** | quote |
| **Display Name** | Quote |
| **Description** | Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer. |
| **Object Type** | Standard |
| **Ownership Type** | UserOwned |
| **Audit Enabled** | True |
| **Total Rows** | 0 |
| **Last Update** |  |
| **Primary ID Field** | quoteid |
| **Primary Name Field** | name |
| **Count Forms** | 23 |
| **Count Views** | 47 |
| **Count Chart Visualizations** | 0 |
| **Count Reports** | 133 |
| **Count Dashboards** | 0 |
| **Count Workflows** | 182 |
| **Count Formulas & Rollups** | 4 |
| **Count Plugins** | 971 |
| **Count PCF Controls** | 7 |
| **Count Relationships** | 5 |
| **Count Ribbon Customizations** | 0 |

## Table of Contents

- [1. Field Definitions](#1.%20Field%20Definitions)
- [2. Forms](#2.%20Forms)
  - [2.1. Quote - main - Active](#2.1.%20Quote%20-%20main%20-%20Active)
- [3. Views](#3.%20Views)
  - [3.1. Active Quotes](#3.1.%20Active%20Quotes)
  - [3.2. All Quotes](#3.2.%20All%20Quotes)
  - [3.3. My Quotes](#3.3.%20My%20Quotes)
  - [3.4. Quick Find All Quotes](#3.4.%20Quick%20Find%20All%20Quotes)
  - [3.5. Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [4. Chart Visualizations](#4.%20Chart%20Visualizations)
- [5. Reports](#5.%20Reports)
  - [5.1. PAQuoteReport](#5.1.%20PAQuoteReport)
  - [5.2. PackingSlip](#5.2.%20PackingSlip)
  - [5.3. SoleSourceLetter](#5.3.%20SoleSourceLetter)
  - [5.4. SummaryQuoteReport](#5.4.%20SummaryQuoteReport)
  - [5.5. iGradQuoteReport](#5.5.%20iGradQuoteReport)
- [6. Dashboards](#6.%20Dashboards)
- [7. Workflows](#7.%20Workflows)
  - [7.1. 0ChangeQuoteRecordOwner](#7.1.%200ChangeQuoteRecordOwner)
  - [7.2. 0EngagementNames](#7.2.%200EngagementNames)
  - [7.3. AccountAuto-Assign](#7.3.%20AccountAuto-Assign)
  - [7.4. AppointmentAuto-Assign](#7.4.%20AppointmentAuto-Assign)
  - [7.5. BatchCloseQuotes](#7.5.%20BatchCloseQuotes)
  - [7.6. BatchConverttoLead](#7.6.%20BatchConverttoLead)
  - [7.7. BatchCreateEngagements](#7.7.%20BatchCreateEngagements)
  - [7.8. BatchLooseOpportunities](#7.8.%20BatchLooseOpportunities)
  - [7.9. BatchOpportunityTransfer](#7.9.%20BatchOpportunityTransfer)
  - [7.10. CasePendingAssignmentNotification](#7.10.%20CasePendingAssignmentNotification)
  - [7.11. CaseRecordOwner](#7.11.%20CaseRecordOwner)
  - [7.12. CaseRecordOwnerAssign](#7.12.%20CaseRecordOwnerAssign)
  - [7.13. CaseRecordOwnerAssignmentNotification](#7.13.%20CaseRecordOwnerAssignmentNotification)
  - [7.14. CaseResolutionNotificationEmail](#7.14.%20CaseResolutionNotificationEmail)
  - [7.15. CloneAndDeleteQuote](#7.15.%20CloneAndDeleteQuote)
  - [7.16. CloneLicense](#7.16.%20CloneLicense)
  - [7.17. CloneOpportunity](#7.17.%20CloneOpportunity)
  - [7.18. CloneOrder](#7.18.%20CloneOrder)
  - [7.19. ContactAuto-Assign](#7.19.%20ContactAuto-Assign)
  - [7.20. CreateLeadFromLeadGen](#7.20.%20CreateLeadFromLeadGen)
  - [7.21. CreateLeadfromAccount](#7.21.%20CreateLeadfromAccount)
  - [7.22. CreateSoftwareLicense](#7.22.%20CreateSoftwareLicense)
  - [7.23. CustomLeadCreation](#7.23.%20CustomLeadCreation)
  - [7.24. EffectiveTo](#7.24.%20EffectiveTo)
  - [7.25. EmailDeleteSendQuoteDrafts](#7.25.%20EmailDeleteSendQuoteDrafts)
  - [7.26. EmailRemoveUnsentEmails](#7.26.%20EmailRemoveUnsentEmails)
  - [7.27. EngagementRecordOwner](#7.27.%20EngagementRecordOwner)
  - [7.28. EngagementRecordOwnerTeam](#7.28.%20EngagementRecordOwnerTeam)
  - [7.29. InvoiceRecordOwner](#7.29.%20InvoiceRecordOwner)
  - [7.30. LeadAssignment](#7.30.%20LeadAssignment)
  - [7.31. LeadQualifyDisqualifyDate](#7.31.%20LeadQualifyDisqualifyDate)
  - [7.32. NewFSRLeadNotification](#7.32.%20NewFSRLeadNotification)
  - [7.33. OpportunityAuditRemoval](#7.33.%20OpportunityAuditRemoval)
  - [7.34. OpportunityRecordOwner](#7.34.%20OpportunityRecordOwner)
  - [7.35. OpportunityRecordOwnerTeam](#7.35.%20OpportunityRecordOwnerTeam)
  - [7.36. OrderRecordOwner](#7.36.%20OrderRecordOwner)
  - [7.37. PhonecallAuto-Assign](#7.37.%20PhonecallAuto-Assign)
  - [7.38. QualifyLead](#7.38.%20QualifyLead)
  - [7.39. QuoteRecordOwner](#7.39.%20QuoteRecordOwner)
  - [7.40. QuoteRecordOwnerTeam](#7.40.%20QuoteRecordOwnerTeam)
  - [7.41. RenameEngagements](#7.41.%20RenameEngagements)
  - [7.42. SendQuote](#7.42.%20SendQuote)
  - [7.43. SoftwareLicenseCreateEngagement](#7.43.%20SoftwareLicenseCreateEngagement)
  - [7.44. TaskAuto-Assign](#7.44.%20TaskAuto-Assign)
  - [7.45. TaskCreateReorderLead](#7.45.%20TaskCreateReorderLead)
  - [7.46. WonOpportunityEmail](#7.46.%20WonOpportunityEmail)
  - [7.47. WorkforceAccountAuto-assign](#7.47.%20WorkforceAccountAuto-assign)
  - [7.48. WorkforceAppointmentAuto-Assign](#7.48.%20WorkforceAppointmentAuto-Assign)
  - [7.49. WorkforceCaseAuto-assign](#7.49.%20WorkforceCaseAuto-assign)
  - [7.50. WorkforceContactAuto-assign](#7.50.%20WorkforceContactAuto-assign)
  - [7.51. WorkforceEngagementAuto-assign](#7.51.%20WorkforceEngagementAuto-assign)
  - [7.52. WorkforceLeadAuto-Assign](#7.52.%20WorkforceLeadAuto-Assign)
  - [7.53. WorkforceOpportunityAuto-assign](#7.53.%20WorkforceOpportunityAuto-assign)
  - [7.54. WorkforcePhone-callAuto-assign](#7.54.%20WorkforcePhone-callAuto-assign)
  - [7.55. WorkforceQuoteAuto-assign](#7.55.%20WorkforceQuoteAuto-assign)
  - [7.56. iGradAppointmentAuto-Assign](#7.56.%20iGradAppointmentAuto-Assign)
  - [7.57. iGradCaseAuto-Assign](#7.57.%20iGradCaseAuto-Assign)
  - [7.58. iGradPhone-callAuto-assign](#7.58.%20iGradPhone-callAuto-assign)
- [8. JavaScript Web Resources](#8.%20JavaScript%20Web%20Resources)
  - [8.1. azt_accountlibrary](#8.1.%20azt_accountlibrary)
  - [8.2. azt_addresslibrary](#8.2.%20azt_addresslibrary)
  - [8.3. azt_caselibrary](#8.3.%20azt_caselibrary)
  - [8.4. azt_createsoftwarelicense](#8.4.%20azt_createsoftwarelicense)
  - [8.5. azt_engagementlibrary](#8.5.%20azt_engagementlibrary)
  - [8.6. azt_expensereportlibrary](#8.6.%20azt_expensereportlibrary)
  - [8.7. azt_invoicelibrary](#8.7.%20azt_invoicelibrary)
  - [8.8. azt_opportunitylibrary](#8.8.%20azt_opportunitylibrary)
  - [8.9. azt_opportunitytrackdiscount](#8.9.%20azt_opportunitytrackdiscount)
  - [8.10. azt_orderlibrary](#8.10.%20azt_orderlibrary)
  - [8.11. azt_quotelibrary](#8.11.%20azt_quotelibrary)
  - [8.12. azt_sendquote](#8.12.%20azt_sendquote)
  - [8.13. azt_splitinvoice](#8.13.%20azt_splitinvoice)
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

Total fields: **328**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Last Update | Flags | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------|-------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [accountid](#accountid) |  |  |  | No |  |  |  | true |  |  |  | Quote | Account ID | AccountId |  |  |  |  |  |  |  | [12](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 2 | [activityid](#activityid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 3 | [activitytypecode](#activitytypecode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 4 | [actualclosedate](#actualclosedate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 5 | [address1_stateorprovince](#address1_stateorprovince) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 6 | [address1_telephone1](#address1_telephone1) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 7 | [adx_resolutiondate](#adx_resolutiondate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 8 | [amountdatatype](#amountdatatype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 9 | [annotationid](#annotationid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 10 | [azt_account](#azt_account) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 11 | [azt_accountid](#azt_accountid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 12 | [azt_accountleadgenerationid](#azt_accountleadgenerationid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 13 | [azt_accounttype](#azt_accounttype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 14 | [azt_addresssearch](#azt_addresssearch) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 15 | [azt_addresssearch2](#azt_addresssearch2) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 16 | [azt_ageendedstage](#azt_ageendedstage) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 17 | [azt_allocatedtoid](#azt_allocatedtoid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 18 | [azt_allocationtype](#azt_allocationtype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 19 | [azt_amount](#azt_amount) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 20 | [azt_annualspend](#azt_annualspend) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 21 | [azt_approvalstatus](#azt_approvalstatus) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 22 | [azt_autonumberid](#azt_autonumberid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 23 | [azt_bookingurl](#azt_bookingurl) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 24 | [azt_caseid](#azt_caseid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 25 | [azt_commissionamount](#azt_commissionamount) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 26 | [azt_commissionid](#azt_commissionid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 27 | [azt_commissionpaymentid](#azt_commissionpaymentid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 28 | [azt_companyname](#azt_companyname) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 29 | [azt_compcompleted](#azt_compcompleted) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 30 | [azt_compgoalid](#azt_compgoalid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 31 | [azt_compgoaltypeid](#azt_compgoaltypeid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 32 | [azt_compplanamountid](#azt_compplanamountid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 33 | [azt_concurrentusers](#azt_concurrentusers) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 34 | [azt_currentnumber](#azt_currentnumber) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 35 | [azt_customerid](#azt_customerid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 36 | [azt_customertrainingid](#azt_customertrainingid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 37 | [azt_dateexitedstage](#azt_dateexitedstage) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 38 | [azt_defaultfreightamount](#azt_defaultfreightamount) | Default Freight Amount | money |  | Yes | none |  | C R U | true |  |  |  | Quote | Default Freight Amount | Default_Freight_Amount__c | [1](#2.%20Forms) | [1](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 39 | [azt_defaultfreightamount_base](#azt_defaultfreightamount_base) | Default Freight Amount (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 40 | [azt_description](#azt_description) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 41 | [azt_discountamount](#azt_discountamount) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 42 | [azt_discretionarydiscount](#azt_discretionarydiscount) | Discretionary Discount | money |  | Yes | none |  | R | true |  |  |  | Quote | Discretionary Discount | Discretionary_Discount__c | [1](#2.%20Forms) | [2](#3.%20Views) |  | [3](#5.%20Reports) |  |  | [1](#9.%20Formulas%20and%20Rollups) |  |  |  |  |  |
| 43 | [azt_discretionarydiscount_base](#azt_discretionarydiscount_base) | Discretionary Discount (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 44 | [azt_discretionarydiscountamt](#azt_discretionarydiscountamt) | Discretionary Discount Amt | money |  | Yes | none |  | C R U | false |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  | [1](#9.%20Formulas%20and%20Rollups) | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 45 | [azt_discretionarydiscountamt_base](#azt_discretionarydiscountamt_base) | Discretionary Discount Amt (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 46 | [azt_effectivedate](#azt_effectivedate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 47 | [azt_email](#azt_email) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 48 | [azt_enddate](#azt_enddate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 49 | [azt_engagementid](#azt_engagementid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 50 | [azt_estfulfillmentdate](#azt_estfulfillmentdate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 51 | [azt_evaluate](#azt_evaluate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 52 | [azt_expenseamount](#azt_expenseamount) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 53 | [azt_expenseid](#azt_expenseid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 54 | [azt_expensereportid](#azt_expensereportid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 55 | [azt_expensetype](#azt_expensetype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 56 | [azt_expirationdate](#azt_expirationdate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 57 | [azt_extension](#azt_extension) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 58 | [azt_fieldtoautonumber](#azt_fieldtoautonumber) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 59 | [azt_firstname](#azt_firstname) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 60 | [azt_fiscalperiodend](#azt_fiscalperiodend) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 61 | [azt_fiscalperiodstart](#azt_fiscalperiodstart) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 62 | [azt_freightamtapproved](#azt_freightamtapproved) | Freight Amt Approved? | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  | Quote | Freight Approved | Freight_Approved__c | [1](#2.%20Forms) |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 63 | [azt_fsrassignedon](#azt_fsrassignedon) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 64 | [azt_fsremail](#azt_fsremail) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 65 | [azt_fsrid](#azt_fsrid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 66 | [azt_fsrmobiletelephone](#azt_fsrmobiletelephone) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 67 | [azt_fsrtelephone](#azt_fsrtelephone) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 68 | [azt_fsrtelephoneextension](#azt_fsrtelephoneextension) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 69 | [azt_fundingid](#azt_fundingid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 70 | [azt_fundingyear](#azt_fundingyear) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 71 | [azt_goaltype](#azt_goaltype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 72 | [azt_historicalowner](#azt_historicalowner) | Historical Owner | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Quote | Historical Owner | Historical_Owner__c | [1](#2.%20Forms) |  |  |  |  | [3](#7.%20Workflows) |  |  |  |  |  |  |
| 73 | [azt_importname](#azt_importname) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 74 | [azt_invoiceid](#azt_invoiceid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [10](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 75 | [azt_invoiceproductid](#azt_invoiceproductid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 76 | [azt_isbn](#azt_isbn) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 77 | [azt_iscompanion](#azt_iscompanion) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 78 | [azt_isprint](#azt_isprint) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 79 | [azt_issaas](#azt_issaas) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 80 | [azt_jobrole](#azt_jobrole) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 81 | [azt_jobtitle](#azt_jobtitle) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 82 | [azt_lastactivitydate](#azt_lastactivitydate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 83 | [azt_lastmodifiedbyid](#azt_lastmodifiedbyid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 84 | [azt_lastname](#azt_lastname) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 85 | [azt_leadimportid](#azt_leadimportid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 86 | [azt_leadsourceid](#azt_leadsourceid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 87 | [azt_licensestatus](#azt_licensestatus) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 88 | [azt_licenseterm](#azt_licenseterm) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 89 | [azt_licensetermmonths](#azt_licensetermmonths) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [22](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 90 | [azt_licensetype](#azt_licensetype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [25](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 91 | [azt_masecommission](#azt_masecommission) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 92 | [azt_mileage](#azt_mileage) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 93 | [azt_monthstofilteron](#azt_monthstofilteron) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 94 | [azt_name](#azt_name) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [18](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 95 | [azt_newestclosedate](#azt_newestclosedate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 96 | [azt_newestimatedvalue](#azt_newestimatedvalue) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 97 | [azt_newownerid](#azt_newownerid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 98 | [azt_newprobability](#azt_newprobability) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 99 | [azt_nonsaasstatus](#azt_nonsaasstatus) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 100 | [azt_nonsaastype](#azt_nonsaastype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 101 | [azt_numberoflicenses](#azt_numberoflicenses) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 102 | [azt_opportunityauditrecordid](#azt_opportunityauditrecordid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 103 | [azt_opportunityid](#azt_opportunityid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 104 | [azt_opportunityproductid](#azt_opportunityproductid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [10](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 105 | [azt_orderid](#azt_orderid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 106 | [azt_orderlineid](#azt_orderlineid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 107 | [azt_orderproductid](#azt_orderproductid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 108 | [azt_orderstageid](#azt_orderstageid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 109 | [azt_ordertemplatelines](#azt_ordertemplatelines) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 110 | [azt_ordertype](#azt_ordertype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 111 | [azt_originatingleadimportid](#azt_originatingleadimportid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 112 | [azt_paid](#azt_paid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 113 | [azt_paidon](#azt_paidon) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 114 | [azt_parentopportunityid](#azt_parentopportunityid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 115 | [azt_parentorderid](#azt_parentorderid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 116 | [azt_payablecommission](#azt_payablecommission) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 117 | [azt_paymentdate](#azt_paymentdate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 118 | [azt_paymentid](#azt_paymentid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 119 | [azt_percentage](#azt_percentage) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 120 | [azt_percentagepaid](#azt_percentagepaid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 121 | [azt_periodend](#azt_periodend) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 122 | [azt_periodstart](#azt_periodstart) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 123 | [azt_phone](#azt_phone) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 124 | [azt_ponumber](#azt_ponumber) | PO Number | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Quote | PO Number | PO_Number__c | [1](#2.%20Forms) |  |  | [1](#5.%20Reports) |  | [3](#7.%20Workflows) |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 125 | [azt_prefix](#azt_prefix) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 126 | [azt_prefixhasseparator](#azt_prefixhasseparator) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 127 | [azt_prefixseparator](#azt_prefixseparator) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 128 | [azt_prefixseparatorisspace](#azt_prefixseparatorisspace) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 129 | [azt_previousestclosedate](#azt_previousestclosedate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 130 | [azt_previousestimatedvalue](#azt_previousestimatedvalue) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 131 | [azt_previousownerid](#azt_previousownerid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 132 | [azt_previousprobability](#azt_previousprobability) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 133 | [azt_printproductid](#azt_printproductid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 134 | [azt_printpurchaseid](#azt_printpurchaseid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 135 | [azt_probability](#azt_probability) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 136 | [azt_probabilitychangedon](#azt_probabilitychangedon) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 137 | [azt_probabilityincreased](#azt_probabilityincreased) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 138 | [azt_productdiscountid](#azt_productdiscountid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [11](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 139 | [azt_producttype](#azt_producttype) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 140 | [azt_purchasedate](#azt_purchasedate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 141 | [azt_quantity](#azt_quantity) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 142 | [azt_quoteapproval](#azt_quoteapproval) | Quote Approval | picklist | 276530000: Does not need approval, 276530001: Needs approval, 276530002: Approved | Yes | none |  | C R U | true |  |  |  | Quote | Quote Approval | Quote_Approval__c |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 143 | [azt_quotedcontactid](#azt_quotedcontactid) | Quoted Contact | lookup |  | Yes | none |  | C R U | true |  |  |  | Quote | Contact ID | ContactId | [1](#2.%20Forms) |  |  | [1](#5.%20Reports) |  | [3](#7.%20Workflows) |  |  |  | [1](#12.%20Relationships) |  |  |
| 144 | [azt_quotenumber](#azt_quotenumber) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 145 | [azt_quoteproductid](#azt_quoteproductid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [9](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 146 | [azt_reasonforexpense](#azt_reasonforexpense) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 147 | [azt_recapnotes](#azt_recapnotes) | Recap Notes | ntext |  | Yes | none |  | C R U | true |  |  |  | Quote | Recap Notes | Recap_Notes__c | [1](#2.%20Forms) |  |  | [3](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 148 | [azt_recapnotescannedoptions](#azt_recapnotescannedoptions) | Recap Notes (Canned Options) | picklist | 100000004: Internet Renewal, 276530000: Internet, 100000003: Kaplan Series, 100000001: GED Flash, 100000000: Life Skills Print, 276530001: LAN, 276530002: GED Ready Vouchers, 100000002: Third party vendors (ie..SHI), 276530003: COVID-19, 327630000: Print, 327630001: PassAssured | Yes | none |  | C R U | true |  |  |  | Quote | Recap Notes Canned Options | Recap_Notes_Canned_Options__c | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 149 | [azt_recordowner](#azt_recordowner) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 150 | [azt_recordownerid](#azt_recordownerid) | Record Owner | lookup |  | Yes | none |  | C R U | true |  |  |  | Quote | Record Type ID | RecordTypeId | [1](#2.%20Forms) | [1](#3.%20Views) |  | [3](#5.%20Reports) |  | [37](#7.%20Workflows) |  | [9](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 151 | [azt_replacementproductid](#azt_replacementproductid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 152 | [azt_requestedfreightamt](#azt_requestedfreightamt) | Requested Freight Amt | money |  | Yes | none |  | C R U | true |  |  |  | Quote | Requested Freight Amt | Requested_Freight_Amt__c | [1](#2.%20Forms) | [1](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 153 | [azt_requestedfreightamt_base](#azt_requestedfreightamt_base) | Requested Freight Amt (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 154 | [azt_resolvedbyid](#azt_resolvedbyid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 155 | [azt_result](#azt_result) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 156 | [azt_saas](#azt_saas) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 157 | [azt_saasstatus](#azt_saasstatus) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 158 | [azt_salesrepid](#azt_salesrepid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 159 | [azt_shippingcompany](#azt_shippingcompany) | Ship To Company | nvarchar |  | Yes | none |  | C R U | true |  |  |  | Quote | Ship To Country | ShippingCountry | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 160 | [azt_signedquotereceived](#azt_signedquotereceived) | Signed Quote Received? | bit | 1: Yes, 0: No | Yes | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 161 | [azt_softwarelicenseid](#azt_softwarelicenseid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 162 | [azt_softwareproductid](#azt_softwareproductid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 163 | [azt_startdate](#azt_startdate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 164 | [azt_stateabbreviation](#azt_stateabbreviation) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 165 | [azt_stateprovince](#azt_stateprovince) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 166 | [azt_suffix](#azt_suffix) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 167 | [azt_suffixhasseparator](#azt_suffixhasseparator) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 168 | [azt_suffixseparator](#azt_suffixseparator) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 169 | [azt_suffixseparatorisspace](#azt_suffixseparatorisspace) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 170 | [azt_supportexpirationdate](#azt_supportexpirationdate) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 171 | [azt_taxamount](#azt_taxamount) | Tax Amount | money |  | Yes | none |  | C R U | true |  |  |  | Quote | Tax Amount | Tax_Amount__c | [1](#2.%20Forms) |  |  | [3](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 172 | [azt_taxamount_base](#azt_taxamount_base) | Tax Amount (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 173 | [azt_total](#azt_total) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 174 | [azt_totalamountpaid](#azt_totalamountpaid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 175 | [azt_totalfunding](#azt_totalfunding) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 176 | [azt_trackingnumber](#azt_trackingnumber) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 177 | [azt_trackingnumbers](#azt_trackingnumbers) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 178 | [azt_trainingid](#azt_trainingid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 179 | [azt_year](#azt_year) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 180 | [baseamount](#baseamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [3](#5.%20Reports) |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 181 | [billto_city](#billto_city) |  |  |  | No |  |  |  | true |  |  |  | Quote | Bill To City | BillingCity |  |  |  | [5](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 182 | [billto_contactname](#billto_contactname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 183 | [billto_country](#billto_country) |  |  |  | No |  |  |  | true |  |  |  | Quote | Bill To Country | BillingCountry |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 184 | [billto_fax](#billto_fax) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 185 | [billto_line1](#billto_line1) |  |  |  | No |  |  |  | true |  |  |  | Quote | Bill To Street 1 | Bill_To_Street_1__c |  |  |  | [5](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 186 | [billto_line2](#billto_line2) |  |  |  | No |  |  |  | true |  |  |  | Quote | Bill To Street 2 | Bill_To_Street_2__c |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 187 | [billto_line3](#billto_line3) |  |  |  | No |  |  |  | true |  |  |  | Quote | Bill To Street 3 | Bill_To_Street_3__c |  |  |  | [1](#5.%20Reports) |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 188 | [billto_name](#billto_name) |  |  |  | No |  |  |  | true |  |  |  | Quote | Client: Bill To Name | Client_Bill_To_Name__c |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 189 | [billto_postalcode](#billto_postalcode) |  |  |  | No |  |  |  | true |  |  |  | Quote | Bill To Zip/Postal Code | BillingPostalCode |  |  |  | [5](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 190 | [billto_stateorprovince](#billto_stateorprovince) |  |  |  | No |  |  |  | true |  |  |  | Quote | Bill To Stateprovince | Bill_To_Stateprovince__c |  |  |  | [5](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 191 | [billto_telephone](#billto_telephone) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 192 | [body](#body) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 193 | [bpf_duration](#bpf_duration) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 194 | [bpf_salesorderid](#bpf_salesorderid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 195 | [businessprocessflowinstanceid](#businessprocessflowinstanceid) | Business Process Flow Instance Id | uniqueidentifier |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 196 | [businessunitid](#businessunitid) | Business Unit | lookup |  | No | required |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 197 | [campaignid](#campaignid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 198 | [category](#category) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 199 | [city](#city) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11.%20PCF%20Controls) |  |  |  |
| 200 | [closedon](#closedon) |  |  |  | No |  |  |  | true |  |  |  | Quote | Closed On | Closed_On__c |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 201 | [closeprobability](#closeprobability) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 202 | [companyname](#companyname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 203 | [connectionid](#connectionid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 204 | [connectionroleid](#connectionroleid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 205 | [consideronlygoalownersrecords](#consideronlygoalownersrecords) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 206 | [contactid](#contactid) |  |  |  | No |  |  |  | true |  |  |  | Quote | Contact ID | ContactId |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 207 | [country](#country) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11.%20PCF%20Controls) |  |  |  |
| 208 | [county](#county) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11.%20PCF%20Controls) |  |  |  |
| 209 | [createdby](#createdby) | Created By | lookup |  | No | none |  | R | true |  |  |  | Quote | Created By ID | CreatedById |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 210 | [createdon](#createdon) | Created On | datetime |  | No | none |  | R | true |  |  |  | Quote | Created Date | CreatedDate | [1](#2.%20Forms) | [7](#3.%20Views) |  | [1](#5.%20Reports) |  | [1](#7.%20Workflows) |  | [10](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 211 | [customerid](#customerid) | Potential Customer | customer |  | No | required |  | C R U So G Re | true |  |  |  | Quote | Potential Customer | Potential_Customer__c |  | [5](#3.%20Views) |  | [5](#5.%20Reports) |  | [14](#7.%20Workflows) |  | [11](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 212 | [datefulfilled](#datefulfilled) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 213 | [defaultuomid](#defaultuomid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 214 | [description](#description) | Description | ntext |  | No | none |  | R | true |  |  |  | Quote | Description | Description |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 215 | [discountamount](#discountamount) |  |  |  | No |  |  |  | true |  |  |  | Quote | Quote Discount Amount | Quote_Discount_Amount__c | [1](#2.%20Forms) |  |  | [3](#5.%20Reports) |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 216 | [discountpercentage](#discountpercentage) |  |  |  | No |  |  |  | true |  |  |  | Quote | Quote Discount | Quote_Discount__c | [1](#2.%20Forms) |  |  | [3](#5.%20Reports) |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 217 | [effectivefrom](#effectivefrom) |  |  |  | No |  |  |  | true |  |  |  | Quote | Effective From | Effective_From__c | [1](#2.%20Forms) |  |  | [3](#5.%20Reports) |  | [3](#7.%20Workflows) |  |  |  |  |  |  |
| 218 | [effectiveto](#effectiveto) |  |  |  | No |  |  |  | true |  |  |  | Quote | Effective To | Effective_To__c | [1](#2.%20Forms) | [1](#3.%20Views) |  | [3](#5.%20Reports) |  | [4](#7.%20Workflows) |  |  |  |  |  |  |
| 219 | [emailaddress](#emailaddress) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 220 | [emailaddress1](#emailaddress1) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 221 | [estimatedclosedate](#estimatedclosedate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 222 | [estimatedvalue](#estimatedvalue) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 223 | [expireson](#expireson) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 224 | [ext_amt](#ext_amt) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 225 | [extendedamount](#extendedamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [13](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 226 | [fetchxml](#fetchxml) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 227 | [filename](#filename) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 228 | [firstname](#firstname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 229 | [freightamount](#freightamount) | Freight Amount | money |  | No | none |  | C R U | true |  |  |  | Quote | Freight Amount | Freight_Amount__c | [1](#2.%20Forms) | [1](#3.%20Views) |  | [4](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 230 | [freightamount_base](#freightamount_base) | Freight Amount (Base) | money |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 231 | [freighttermscode](#freighttermscode) |  |  |  | No |  |  |  | true |  |  |  | Quote | Freight Terms CRM | Freight_Terms_CRM__c |  |  |  |  |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 232 | [fullname](#fullname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [3](#5.%20Reports) |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 233 | [goalenddate](#goalenddate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 234 | [goalid](#goalid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 235 | [goalownerid](#goalownerid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 236 | [goalrollupqueryid](#goalrollupqueryid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 237 | [goalstartdate](#goalstartdate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 238 | [incidentid](#incidentid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 239 | [internalemailaddress](#internalemailaddress) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 240 | [invoicedetailid](#invoicedetailid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 241 | [invoiceid](#invoiceid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 242 | [invoicenumber](#invoicenumber) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 243 | [isamount](#isamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 244 | [isfiscalperiodgoal](#isfiscalperiodgoal) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 245 | [isocurrencycode](#isocurrencycode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 246 | [ispriceoverridden](#ispriceoverridden) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 247 | [isproductoverridden](#isproductoverridden) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 248 | [isrevenuesystemcalculated](#isrevenuesystemcalculated) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 249 | [jobtitle](#jobtitle) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 250 | [lastname](#lastname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 251 | [manualdiscountamount](#manualdiscountamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [3](#5.%20Reports) |  |  |  | [9](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 252 | [metricid](#metricid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 253 | [mimetype](#mimetype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 254 | [mobilephone](#mobilephone) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 255 | [modifiedon](#modifiedon) | Modified On | datetime |  | No | none |  | R | true |  |  |  | Quote | Last Modified Date | LastModifiedDate |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 256 | [name](#name) | Name | nvarchar |  | No | required |  | C R U S Re | true |  |  |  | Quote | Quote Name | Name |  | [8](#3.%20Views) |  | [10](#5.%20Reports) |  | [17](#7.%20Workflows) |  | [23](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 257 | [objectid](#objectid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 258 | [objecttypecode](#objecttypecode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 259 | [opportunityid](#opportunityid) |  |  |  | No |  |  |  | true |  |  |  | Quote | Opportunity ID | OpportunityId |  | [1](#3.%20Views) |  |  |  | [2](#7.%20Workflows) |  | [32](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 260 | [opportunityproductid](#opportunityproductid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [14](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 261 | [originatingleadid](#originatingleadid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 262 | [ownerid](#ownerid) |  |  |  | No |  |  |  | true |  |  |  | Quote | Owner ID | OwnerId | [1](#2.%20Forms) |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [22](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 263 | [parentaccountid](#parentaccountid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 264 | [parentcontactid](#parentcontactid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 265 | [parentcustomerid](#parentcustomerid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 266 | [parentgoalid](#parentgoalid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 267 | [parentsystemuserid](#parentsystemuserid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 268 | [paymenttermscode](#paymenttermscode) |  |  |  | No |  |  |  | true |  |  |  | Quote | Payment Terms | Payment_Terms__c |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 269 | [pricelevelid](#pricelevelid) |  |  |  | No |  |  |  | true |  |  |  | Quote | Price List | Price_List__c |  |  |  |  |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 270 | [priceperunit](#priceperunit) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 271 | [primarycontactid](#primarycontactid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 272 | [productdescription](#productdescription) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [13](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 273 | [productid](#productid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [33](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 274 | [productname](#productname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 275 | [productnumber](#productnumber) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 276 | [producttypecode](#producttypecode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 277 | [quantity](#quantity) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [18](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 278 | [queryentitytype](#queryentitytype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 279 | [quotedetailid](#quotedetailid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [14](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 280 | [quoteid](#quoteid) | Quote | uniqueidentifier |  | No | required |  | R | true |  |  |  | Quote | Quote GUID | Quote_GUID__c |  | [5](#3.%20Views) |  | [4](#5.%20Reports) |  | [3](#7.%20Workflows) |  | [20](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 281 | [quotenumber](#quotenumber) | Quote ID | nvarchar |  | No | systemrequired |  | C R S | true |  |  |  | Quote | Quote Number | QuoteNumber |  | [1](#3.%20Views) |  | [4](#5.%20Reports) |  |  |  |  |  |  |  |  |
| 282 | [record1id](#record1id) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 283 | [record1roleid](#record1roleid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 284 | [record2id](#record2id) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 285 | [record2roleid](#record2roleid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 286 | [regardingobjectid](#regardingobjectid) | Regarding | lookup |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 287 | [requestdeliveryby](#requestdeliveryby) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 288 | [roleid](#roleid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 289 | [rolluponlyfromchildgoals](#rolluponlyfromchildgoals) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 290 | [rollupqueryactualmoneyid](#rollupqueryactualmoneyid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 291 | [rolluprulestep1_1](#rolluprulestep1_1) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  | [1](#9.%20Formulas%20and%20Rollups) |  |  |  |  |  |
| 292 | [rolluprulestep1_2](#rolluprulestep1_2) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  | [1](#9.%20Formulas%20and%20Rollups) |  |  |  |  |  |
| 293 | [salesorderdetailid](#salesorderdetailid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [9](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 294 | [salesorderdetailname](#salesorderdetailname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 295 | [salesorderid](#salesorderid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  |  |  | [13](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 296 | [salesrepid](#salesrepid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 297 | [scheduledend](#scheduledend) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 298 | [shippingmethodcode](#shippingmethodcode) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Zip/Postal Code | ShippingPostalCode |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 299 | [shipto_city](#shipto_city) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To City | ShippingCity |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 300 | [shipto_contactname](#shipto_contactname) | Shipping Contact | nvarchar |  | No | none |  | C R U | true |  |  |  | Quote | Shipping Contact | Shipping_Contact__c | [1](#2.%20Forms) |  |  | [3](#5.%20Reports) |  | [3](#7.%20Workflows) |  |  |  |  |  |  |
| 301 | [shipto_country](#shipto_country) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Country | ShippingCountry |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 302 | [shipto_fax](#shipto_fax) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 303 | [shipto_freighttermscode](#shipto_freighttermscode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 304 | [shipto_line1](#shipto_line1) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Street 1 | Ship_To_Street_1__c |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 305 | [shipto_line2](#shipto_line2) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Street 2 | Ship_To_Street_2__c |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 306 | [shipto_line3](#shipto_line3) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Street 3 | Ship_To_Street_3__c |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 307 | [shipto_name](#shipto_name) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Name | ShippingName | [1](#2.%20Forms) |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 308 | [shipto_postalcode](#shipto_postalcode) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Zip/Postal Code | ShippingPostalCode |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 309 | [shipto_stateorprovince](#shipto_stateorprovince) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To Stateprovince | Ship_To_Stateprovince__c |  |  |  | [2](#5.%20Reports) |  | [2](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 310 | [shipto_telephone](#shipto_telephone) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [1](#5.%20Reports) |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 311 | [state](#state) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11.%20PCF%20Controls) |  |  |  |
| 312 | [statecode](#statecode) | Status | state |  | No | systemrequired |  | R U Re | true |  |  |  | Quote | Status | Status |  | [8](#3.%20Views) |  | [1](#5.%20Reports) |  | [10](#7.%20Workflows) |  | [20](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 313 | [statuscode](#statuscode) | Status Reason | status |  | No | none |  | C R U | true |  |  |  | Quote | Status | Status |  |  |  | [2](#5.%20Reports) |  | [5](#7.%20Workflows) |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 314 | [street](#street) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11.%20PCF%20Controls) |  |  |  |
| 315 | [subject](#subject) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 316 | [systemuserid](#systemuserid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 317 | [tax](#tax) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 318 | [teamid](#teamid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 319 | [teamtype](#teamtype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 320 | [telephone1](#telephone1) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 321 | [title](#title) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  | [3](#5.%20Reports) |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 322 | [totalamount](#totalamount) | Total Amount | money |  | No | none |  | R U So G Re | true |  |  |  | Quote | Total Amount | Total_Amount__c |  | [5](#3.%20Views) |  | [5](#5.%20Reports) |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 323 | [totallineitemamount](#totallineitemamount) |  |  |  | No |  |  |  | true |  |  |  | Quote | Total Detail Amount | Total_Detail_Amount__c |  |  |  | [3](#5.%20Reports) |  |  |  |  |  |  |  |  |
| 324 | [transactioncurrencyid](#transactioncurrencyid) | Currency | lookup |  | No | none |  | R | true |  |  |  | Quote | Currency | Currency__c |  |  |  |  |  | [1](#7.%20Workflows) |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 325 | [uomid](#uomid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 326 | [value](#value) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11.%20PCF%20Controls) |  |  |  |
| 327 | [willcall](#willcall) |  |  |  | No |  |  |  | true |  |  |  | Quote | Ship To | Ship_To__c | [1](#2.%20Forms) |  |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 328 | [zipcode](#zipcode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#11.%20PCF%20Controls) |  |  |  |

---

## 2. Forms

Total forms: **1**

### 2.1. Quote - main - Active

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
| [quotedetailsGrid](#quotedetailsGrid) | PRODUCTS | No | Yes |

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
| 5 | [quotecustomeridcontactcontactid.emailaddress1](#quotecustomeridcontactcontactid.emailaddress1) | 150px |
| 6 | [azt_discretionarydiscount](#azt_discretionarydiscount) | 125px |
| 7 | [opportunityid](#opportunityid) | 200px |
| 8 | [quoteid](#quoteid) |  |

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
| 5 | [quotecustomeridcontactcontactid.emailaddress1](#quotecustomeridcontactcontactid.emailaddress1) | 150px |
| 6 | [createdon](#createdon) | 150px |
| 7 | [quoteid](#quoteid) |  |

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

## 9. Formulas and Rollups

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

Total relationships involving Quote: **5**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| azt_contact_quote | N:1 | Contact | Quote | [azt_QuotedContactId](#azt_QuotedContactId) |
| azt_systemuser_quote | N:1 | SystemUser | Quote | [azt_RecordOwnerId](#azt_RecordOwnerId) |
| opportunity_quotes | N:1 | Opportunity | Quote | [OpportunityId](#OpportunityId) |
| quote_customer_accounts | N:1 | Account | Quote | [CustomerId](#CustomerId) |
| quote_orders | 1:N | Quote | SalesOrder | [QuoteId](#QuoteId) |

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

## 14. Conflicts and Observations

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
- [tm.systemuserid](#tm.systemuserid)
- [to](#to)
- [totalamount](#totalamount)
- [totallineitemamount](#totallineitemamount)
- [transactioncurrencyid](#transactioncurrencyid)
- [uomid](#uomid)
- [{0}](#%7B0%7D)

**Fields on forms but never in logic (1):**

- [azt_shippingcompany](#azt_shippingcompany)

---

## Index

Alphabetical field index -- 361 unique fields referenced.

#### accessteam

- [Form: Quote > Summary_tab > description_section](#2.1.%20Quote%20-%20main%20-%20Active)

#### accountid

- [Field Definitions](#1.%20Field%20Definitions)
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

#### activityid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Image)](#10.59.%20PhonecallCreateCallback)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### activitytypecode

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)

#### actualclosedate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### address1_stateorprovince

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: AutoAssignStateAbb (Read)](#10.12.%20AutoAssignStateAbb)
- [Plugin: AutoAssignStateAbb (Write)](#10.12.%20AutoAssignStateAbb)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### address1_telephone1

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### address2_line1

- [Report: PAQuoteReport > QuoteHeader > account](#5.1.%20PAQuoteReport)

#### adx_resolutiondate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### amountdatatype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### annotationid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### associatedconnectionroleid

- [Plugin: ContactSetConnectionRole (Join)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Join)](#10.75.%20SetPrimaryContact)

#### azt_account

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)

#### azt_accountid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Filter)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### azt_accountleadgenerationid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountLeadGen (Filter)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGenAssociate (Read)](#10.3.%20AccountLeadGenAssociate)
- [Plugin: AccountLeadGenAssociate (Filter)](#10.3.%20AccountLeadGenAssociate)

#### azt_accountleadgenname

- [Plugin: AccountLeadGenAssociate (Write)](#10.3.%20AccountLeadGenAssociate)

#### azt_accounttype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountTypeSet (Write)](#10.5.%20AccountTypeSet)

#### azt_addresssearch

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AddressSearchCleanupFields (Read)](#10.10.%20AddressSearchCleanupFields)
- [Plugin: AddressSearchCleanupFields (Write)](#10.10.%20AddressSearchCleanupFields)

#### azt_addresssearch2

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AddressSearchCleanupFields (Read)](#10.10.%20AddressSearchCleanupFields)
- [Plugin: AddressSearchCleanupFields (Write)](#10.10.%20AddressSearchCleanupFields)

#### azt_addtocrtqueue

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_ageendedstage

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_allocatedtoid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_allocationtype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_amount

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_annualspend

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: FundingSetAnnualSpend (Write)](#10.28.%20FundingSetAnnualSpend)

#### azt_approvalstatus

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityPreventCreateQuote (Read)](#10.47.%20OpportunityPreventCreateQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### azt_autocreatecallback

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_autonumberid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)
- [Plugin: AutoNumber (Write)](#10.13.%20AutoNumber)

#### azt_azteccustomerid

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_bookingurl

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)
- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_callbackin

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_callbackon

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_caseid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CaseAudit (Write)](#10.14.%20CaseAudit)

#### azt_commissionamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)

#### azt_commissionid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_commissionpaymentid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)

#### azt_companyname

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_compcompleted

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)

#### azt_compgoalid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_compgoaltypeid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)

#### azt_compplanamountid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_concurrentusers

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_copydescription

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_copysubject

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_currentnumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)
- [Plugin: AutoNumber (Write)](#10.13.%20AutoNumber)

#### azt_customerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_customertrainingid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)

#### azt_dateexitedstage

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_defaultfreightamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > Freight](#2.1.%20Quote%20-%20main%20-%20Active)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [JS: azt_opportunitylibrary > setFreightAmt()](#8.8.%20azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#8.11.%20azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

#### azt_defaultfreightamount_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_description

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_discountamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)

#### azt_discretionarydiscount

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > totals](#2.1.%20Quote%20-%20main%20-%20Active)
- [View: Active Quotes](#3.1.%20Active%20Quotes)
- [View: All Quotes](#3.2.%20All%20Quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Formula: azt_discretionarydiscount (Target)](#9.%20Formulas%20and%20Rollups)

#### azt_discretionarydiscount_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_discretionarydiscountamt

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > totals](#2.1.%20Quote%20-%20main%20-%20Active)
- [Formula: azt_discretionarydiscount](#9.%20Formulas%20and%20Rollups)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)

#### azt_discretionarydiscountamt_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_duedate

- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### azt_effectivedate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_email

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImportPopulateName (Read)](#10.37.%20LeadImportPopulateName)

#### azt_enddate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: EngagementSetEndDate (Write)](#10.25.%20EngagementSetEndDate)

#### azt_engagementid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: EngagementFSRAssignedOn (Read)](#10.24.%20EngagementFSRAssignedOn)
- [Plugin: EngagementFSRAssignedOn (Write)](#10.24.%20EngagementFSRAssignedOn)
- [Plugin: EngagementSetEndDate (Write)](#10.25.%20EngagementSetEndDate)

#### azt_estfulfillmentdate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_evaluate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Image)](#10.2.%20AccountLeadGen)

#### azt_expenseamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)

#### azt_expenseid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Filter)](#10.17.%20CloneExpenseLine)

#### azt_expensereportid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Filter)](#10.26.%20ExpenseLineTotals)

#### azt_expensetype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_expirationdate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_extension

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fieldtoautonumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_firstname

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_fiscalperiodend

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: Utility (Write)](#10.81.%20Utility)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### azt_fiscalperiodstart

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Sort)](#10.20.%20CreateCompGoals)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_freightamtapproved

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > Freight](#2.1.%20Quote%20-%20main%20-%20Active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#8.8.%20azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#8.11.%20azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

#### azt_fsrassignedon

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: EngagementFSRAssignedOn (Write)](#10.24.%20EngagementFSRAssignedOn)

#### azt_fsremail

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrmobiletelephone

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrtelephone

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fsrtelephoneextension

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Write)](#10.52.%20OrderFSRSetTemplateFields)

#### azt_fundingid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: FundingSetAnnualSpend (Write)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: FundingTotalAmt (Write)](#10.29.%20FundingTotalAmt)

#### azt_fundingyear

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: FundingYearSync (Read)](#10.30.%20FundingYearSync)

#### azt_goaltype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### azt_historicalowner

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote (Footer)](#2.1.%20Quote%20-%20main%20-%20Active)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneOpportunity (Write)](#7.17.%20CloneOpportunity)

#### azt_importname

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImportPopulateName (Read)](#10.37.%20LeadImportPopulateName)

#### azt_invoiceid

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#10.63.%20QuoteOrderProductsTrackDiscount)

#### azt_isbn

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_iscompanion

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_isprint

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_issaas

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: SetOppProductDefaults (Write)](#10.74.%20SetOppProductDefaults)

#### azt_jobrole

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: RestrictProductLookups (Read)](#10.69.%20RestrictProductLookups)

#### azt_jobtitle

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_lastactivitydate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityLastActivityDate (Write)](#10.45.%20OpportunityLastActivityDate)

#### azt_lastmodifiedbyid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)

#### azt_lastname

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_leadimportid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_leadsourceid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_licensestatus

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_licenseterm

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderLinePopulateLicType (Read)](#10.53.%20OrderLinePopulateLicType)

#### azt_licensetermmonths

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_mileage

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_monthstofilteron

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Image)](#10.2.%20AccountLeadGen)

#### azt_name

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_newestimatedvalue

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_newownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CaseAudit (Write)](#10.14.%20CaseAudit)

#### azt_newprobability

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_nonsaasstatus

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountTypeSet (Read)](#10.5.%20AccountTypeSet)
- [Plugin: AccountTypeSet (Image)](#10.5.%20AccountTypeSet)

#### azt_nonsaastype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_numberoflicenses

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_opportunityauditrecordid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OppAuditRemoval (Read)](#10.41.%20OppAuditRemoval)

#### azt_opportunityid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OppAuditRemoval (Filter)](#10.41.%20OppAuditRemoval)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)
- [Plugin: OpptyToQuoteFieldMappings (Filter)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)

#### azt_opportunityproductid

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CompGoalCreate (Write)](#10.18.%20CompGoalCreate)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)
- [Plugin: OrderStageTracking (Filter)](#10.57.%20OrderStageTracking)
- [Plugin: ShipmentSetTrackingNumber (Read)](#10.79.%20ShipmentSetTrackingNumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_orderlineid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: ShipmentSetTrackingNumber (Sort)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_orderproductid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: QuoteOrderProductsTrackDiscount (Write)](#10.63.%20QuoteOrderProductsTrackDiscount)
- [Plugin: QuoteOrderProductsTrackDiscount (Filter)](#10.63.%20QuoteOrderProductsTrackDiscount)

#### azt_orderstageid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)
- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_ordertemplatelines

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderLinePopulateTemplateFields (Write)](#10.54.%20OrderLinePopulateTemplateFields)

#### azt_ordertype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_originatingleadimportid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_paid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_paidon

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: FundingSetAnnualSpend (Filter)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_parentopportunityid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityAudit (Image)](#10.43.%20OpportunityAudit)

#### azt_parentorderid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_payablecommission

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### azt_paymentdate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Sort)](#10.81.%20Utility)

#### azt_paymentid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_percentage

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_percentagepaid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### azt_periodend

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_periodstart

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_phone

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_ponumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > quote information](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneOrder (Read)](#7.18.%20CloneOrder)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_prefix

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_prefixhasseparator

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_prefixseparator

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_prefixseparatorisspace

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_previousestclosedate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_previousestimatedvalue

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_previousownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CaseAudit (Write)](#10.14.%20CaseAudit)

#### azt_previousprobability

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Write)](#10.43.%20OpportunityAudit)

#### azt_printproductid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_printpurchaseid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_probability

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)
- [Plugin: OpportunityProbabilityChange (Read)](#10.48.%20OpportunityProbabilityChange)
- [Plugin: OpportunityProbabilityChange (Image)](#10.48.%20OpportunityProbabilityChange)
- [Plugin: OpportunityProbabilityNumber (Read)](#10.49.%20OpportunityProbabilityNumber)

#### azt_probabilitychangedon

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityProbabilityChange (Write)](#10.48.%20OpportunityProbabilityChange)

#### azt_probabilityincreased

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityProbabilityChange (Write)](#10.48.%20OpportunityProbabilityChange)

#### azt_productdiscountid

- [Field Definitions](#1.%20Field%20Definitions)
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

#### azt_producttype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#10.35.%20InvoiceCompCompleted)

#### azt_purchasedate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_quantity

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_quoteapproval

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### azt_quotedcontactid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > quote information](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: SendQuote (Read)](#7.42.%20SendQuote)
- [Relationship: azt_contact_quote](#12.%20Relationships)

#### azt_quotenumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_quoteproductid

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_recapnotes

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > Section](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### azt_recapnotescannedoptions

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > Section](#2.1.%20Quote%20-%20main%20-%20Active)

#### azt_recordowner

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)

#### azt_recordownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > quote information](#2.1.%20Quote%20-%20main%20-%20Active)
- [View: My Quotes (Filter)](#3.3.%20My%20Quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: 0ChangeQuoteRecordOwner (Write)](#7.1.%200ChangeQuoteRecordOwner)
- [Workflow: AccountAuto-Assign (Write)](#7.3.%20AccountAuto-Assign)
- [Workflow: AppointmentAuto-Assign (Write)](#7.4.%20AppointmentAuto-Assign)
- [Workflow: BatchCreateEngagements (Write)](#7.7.%20BatchCreateEngagements)
- [Workflow: BatchOpportunityTransfer (Write)](#7.9.%20BatchOpportunityTransfer)
- [Workflow: CaseRecordOwner (Write)](#7.11.%20CaseRecordOwner)
- [Workflow: CaseRecordOwnerAssign (Write)](#7.12.%20CaseRecordOwnerAssign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#7.13.%20CaseRecordOwnerAssignmentNotification)
- [Workflow: CloneLicense (Write)](#7.16.%20CloneLicense)
- [Workflow: CloneOpportunity (Write)](#7.17.%20CloneOpportunity)
- [Workflow: ContactAuto-Assign (Write)](#7.19.%20ContactAuto-Assign)
- [Workflow: EngagementRecordOwner (Write)](#7.27.%20EngagementRecordOwner)
- [Workflow: EngagementRecordOwnerTeam (Read)](#7.28.%20EngagementRecordOwnerTeam)
- [Workflow: InvoiceRecordOwner (Write)](#7.29.%20InvoiceRecordOwner)
- [Workflow: LeadAssignment (Write)](#7.30.%20LeadAssignment)
- [Workflow: OpportunityRecordOwner (Write)](#7.34.%20OpportunityRecordOwner)
- [Workflow: OpportunityRecordOwnerTeam (Read)](#7.35.%20OpportunityRecordOwnerTeam)
- [Workflow: OrderRecordOwner (Write)](#7.36.%20OrderRecordOwner)
- [Workflow: PhonecallAuto-Assign (Write)](#7.37.%20PhonecallAuto-Assign)
- [Workflow: QuoteRecordOwner (Write)](#7.39.%20QuoteRecordOwner)
- [Workflow: QuoteRecordOwnerTeam (Read)](#7.40.%20QuoteRecordOwnerTeam)
- [Workflow: SendQuote (Read)](#7.42.%20SendQuote)
- [Workflow: TaskAuto-Assign (Write)](#7.44.%20TaskAuto-Assign)
- [Workflow: TaskCreateReorderLead (Write)](#7.45.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Read)](#7.46.%20WonOpportunityEmail)
- [Workflow: WorkforceAccountAuto-assign (Write)](#7.47.%20WorkforceAccountAuto-assign)
- [Workflow: WorkforceAppointmentAuto-Assign (Write)](#7.48.%20WorkforceAppointmentAuto-Assign)
- [Workflow: WorkforceCaseAuto-assign (Write)](#7.49.%20WorkforceCaseAuto-assign)
- [Workflow: WorkforceContactAuto-assign (Write)](#7.50.%20WorkforceContactAuto-assign)
- [Workflow: WorkforceEngagementAuto-assign (Write)](#7.51.%20WorkforceEngagementAuto-assign)
- [Workflow: WorkforceLeadAuto-Assign (Write)](#7.52.%20WorkforceLeadAuto-Assign)
- [Workflow: WorkforceOpportunityAuto-assign (Write)](#7.53.%20WorkforceOpportunityAuto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Write)](#7.54.%20WorkforcePhone-callAuto-assign)
- [Workflow: WorkforceQuoteAuto-assign (Write)](#7.55.%20WorkforceQuoteAuto-assign)
- [Workflow: iGradAppointmentAuto-Assign (Write)](#7.56.%20iGradAppointmentAuto-Assign)
- [Workflow: iGradCaseAuto-Assign (Write)](#7.57.%20iGradCaseAuto-Assign)
- [Workflow: iGradPhone-callAuto-assign (Write)](#7.58.%20iGradPhone-callAuto-assign)
- [JS: azt_caselibrary > onLoad()](#8.3.%20azt_caselibrary)
- [JS: azt_engagementlibrary > onLoad()](#8.5.%20azt_engagementlibrary)
- [JS: azt_invoicelibrary > onLoad()](#8.7.%20azt_invoicelibrary)
- [JS: azt_opportunitylibrary > onLoad()](#8.8.%20azt_opportunitylibrary)
- [JS: azt_orderlibrary > onLoad()](#8.10.%20azt_orderlibrary)
- [Plugin: ActivityCloseForceRecordOwner (Read)](#10.8.%20ActivityCloseForceRecordOwner)
- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)
- [Relationship: azt_systemuser_quote](#12.%20Relationships)

#### azt_replacementproductid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_requestedfreightamt

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > Freight](#2.1.%20Quote%20-%20main%20-%20Active)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [JS: azt_opportunitylibrary > setFreightAmt()](#8.8.%20azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#8.11.%20azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

#### azt_requestedfreightamt_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_resolvedbyid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CaseClose (Read)](#10.15.%20CaseClose)
- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### azt_result

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_saas

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### azt_saasstatus

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountTypeSet (Read)](#10.5.%20AccountTypeSet)
- [Plugin: AccountTypeSet (Image)](#10.5.%20AccountTypeSet)

#### azt_salesrepid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#10.35.%20InvoiceCompCompleted)

#### azt_shippingcompany

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > quote information](#2.1.%20Quote%20-%20main%20-%20Active)

#### azt_signedquotereceived

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_softwarelicenseid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: AllocationValidation (Filter)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_softwareproductid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_startdate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_stateabbreviation

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountAutoAssign (Filter)](#10.1.%20AccountAutoAssign)

#### azt_stateprovince

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_suffix

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_suffixhasseparator

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_suffixseparator

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_suffixseparatorisspace

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)

#### azt_supportexpirationdate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_taxamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > sales_information](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### azt_taxamount_base

- [Field Definitions](#1.%20Field%20Definitions)

#### azt_total

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_totalamountpaid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_totalfunding

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: FundingTotalAmt (Write)](#10.29.%20FundingTotalAmt)

#### azt_totalreimbursement

- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)

#### azt_trackingnumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: ShipmentSetTrackingNumber (Read)](#10.79.%20ShipmentSetTrackingNumber)
- [Plugin: ShipmentSetTrackingNumber (Filter)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_trackingnumbers

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ShipmentSetTrackingNumber (Write)](#10.79.%20ShipmentSetTrackingNumber)

#### azt_trainingid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)

#### azt_year

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: FundingYearSync (Write)](#10.30.%20FundingYearSync)

#### baseamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader > quotedetail](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader > quotedetail](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader > quotedetail](#5.5.%20iGradQuoteReport)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### billto_city

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### billto_contactname

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### billto_country

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### billto_fax

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### billto_line1

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_line2

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_line3

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_name

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_postalcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_stateorprovince

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_telephone

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### body

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### bpf_duration

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)

#### bpf_salesorderid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderStageTracking (Filter)](#10.57.%20OrderStageTracking)

#### businessprocessflowinstanceid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)

#### businessunitid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountAutoAssign (Read)](#10.1.%20AccountAutoAssign)
- [Plugin: ExpenseRestrictVisibility (Read)](#10.27.%20ExpenseRestrictVisibility)
- [Plugin: GetUserHasRole (Read)](#10.32.%20GetUserHasRole)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)
- [Plugin: RestrictProductLookups (Read)](#10.69.%20RestrictProductLookups)
- [Plugin: RestrictWinOpportunities (Read)](#10.70.%20RestrictWinOpportunities)
- [Plugin: RestrictWinQuote (Read)](#10.71.%20RestrictWinQuote)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### campaignid

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### category

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ContactSetConnectionRole (Sort)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Sort)](#10.75.%20SetPrimaryContact)

#### city

- [Field Definitions](#1.%20Field%20Definitions)
- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### closedon

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### closeprobability

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityProbabilityNumber (Write)](#10.49.%20OpportunityProbabilityNumber)

#### companyname

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### connectionid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)

#### connectionroleid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ContactSetConnectionRole (Read)](#10.19.%20ContactSetConnectionRole)
- [Plugin: ContactSetConnectionRole (Join)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Join)](#10.75.%20SetPrimaryContact)

#### consideronlygoalownersrecords

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### contactid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)

#### country

- [Field Definitions](#1.%20Field%20Definitions)
- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### county

- [Field Definitions](#1.%20Field%20Definitions)
- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### createdby

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: QuoteRecordOwner (Read)](#7.39.%20QuoteRecordOwner)
- [Workflow: WorkforceQuoteAuto-assign (Read)](#7.55.%20WorkforceQuoteAuto-assign)

#### createdon

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > details_tab > tab_2_section_2](#2.1.%20Quote%20-%20main%20-%20Active)
- [View: Active Quotes](#3.1.%20Active%20Quotes)
- [View: Active Quotes (Sort)](#3.1.%20Active%20Quotes)
- [View: My Quotes](#3.3.%20My%20Quotes)
- [View: My Quotes (Sort)](#3.3.%20My%20Quotes)
- [View: Quick Find All Quotes](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [View: Quotes Needing Freight Approval (Sort)](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: EffectiveTo (Read)](#7.24.%20EffectiveTo)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Quotes](#3.1.%20Active%20Quotes)
- [View: All Quotes](#3.2.%20All%20Quotes)
- [View: My Quotes](#3.3.%20My%20Quotes)
- [View: Quick Find All Quotes](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CasePendingAssignmentNotification (Read)](#7.10.%20CasePendingAssignmentNotification)
- [Workflow: CaseRecordOwner (Read)](#7.11.%20CaseRecordOwner)
- [Workflow: CaseRecordOwnerAssign (Read)](#7.12.%20CaseRecordOwnerAssign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#7.13.%20CaseRecordOwnerAssignmentNotification)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneOpportunity (Write)](#7.17.%20CloneOpportunity)
- [Workflow: CloneOrder (Write)](#7.18.%20CloneOrder)
- [Workflow: CreateSoftwareLicense (Write)](#7.22.%20CreateSoftwareLicense)
- [Workflow: InvoiceRecordOwner (Read)](#7.29.%20InvoiceRecordOwner)
- [Workflow: OrderRecordOwner (Read)](#7.36.%20OrderRecordOwner)
- [Workflow: QualifyLead (Write)](#7.38.%20QualifyLead)
- [Workflow: QuoteRecordOwner (Read)](#7.39.%20QuoteRecordOwner)
- [Workflow: TaskCreateReorderLead (Write)](#7.45.%20TaskCreateReorderLead)
- [JS: azt_createsoftwarelicense > CreateLicense()](#8.4.%20azt_createsoftwarelicense)
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
- [Relationship: quote_customer_accounts](#12.%20Relationships)

#### datefulfilled

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### defaultuomid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)

#### description

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)

#### discountamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > totals](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#10.72.%20ReviseQuoteDiscountMove)

#### discountpercentage

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > totals](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)

#### effectivefrom

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > details_tab > tab_2_section_2](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: EffectiveTo (Write)](#7.24.%20EffectiveTo)

#### effectiveto

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > details_tab > tab_2_section_2](#2.1.%20Quote%20-%20main%20-%20Active)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: EffectiveTo (Read)](#7.24.%20EffectiveTo)
- [Workflow: EffectiveTo (Write)](#7.24.%20EffectiveTo)

#### emailaddress

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### emailaddress1

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Filter)](#10.36.%20LeadImport)

#### estimatedclosedate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityClone (Write)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)

#### estimatedvalue

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)

#### expireson

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### ext_amt

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)

#### extendedamount

- [Field Definitions](#1.%20Field%20Definitions)
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

#### fetchxml

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### filename

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### firstname

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: SoleSourceLetter > QuoteHeader > contact](#5.3.%20SoleSourceLetter)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### fiscalperiod

- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)

#### freightamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > totals](#2.1.%20Quote%20-%20main%20-%20Active)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [JS: azt_opportunitylibrary > onLoad()](#8.8.%20azt_opportunitylibrary)
- [JS: azt_opportunitylibrary > setFreightAmt()](#8.8.%20azt_opportunitylibrary)
- [JS: azt_opportunitylibrary > success()](#8.8.%20azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#8.11.%20azt_quotelibrary)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#10.66.%20QuoteSyncTotalToOpportunity)

#### freightamount_base

- [Field Definitions](#1.%20Field%20Definitions)

#### freighttermscode

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### from

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### fullname

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader > contact](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader > contact](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader > contact](#5.5.%20iGradQuoteReport)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Sort)](#10.36.%20LeadImport)
- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Sort)](#10.81.%20Utility)

#### goalenddate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### goalid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### goalownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### goalrollupqueryid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### goalstartdate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### incidentid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### internalemailaddress

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### invline.productid

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)

#### invoicedetailid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: QuoteOrderProductsTrackDiscount (Read)](#10.63.%20QuoteOrderProductsTrackDiscount)

#### invoiceid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountLeadGen (Join)](#10.2.%20AccountLeadGen)
- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateCompGoals (Filter)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Join)](#10.22.%20CreateUserGoals)
- [Plugin: DiscretionaryDiscountSetHeader (Join)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### invoicenumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CompGoalCreate (Read)](#10.18.%20CompGoalCreate)

#### isamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### isfiscalperiodgoal

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### isocurrencycode

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### ispriceoverridden

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### isproductoverridden

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### isrevenuesystemcalculated

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: QuoteSyncTotalToOpportunity (Write)](#10.66.%20QuoteSyncTotalToOpportunity)

#### jobtitle

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader > systemuser](#5.1.%20PAQuoteReport)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### lastname

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### manualdiscountamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader > quotedetail](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader > quotedetail](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader > quotedetail](#5.5.%20iGradQuoteReport)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: ManualDiscountKill (Read)](#10.40.%20ManualDiscountKill)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#10.50.%20OpptyToQuoteFieldMappings)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### metricid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### mimetype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### mobilephone

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### modifiedon

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: OpportunityLineSyncToQuote (Sort)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: UpdateOppFromQuote (Sort)](#10.80.%20UpdateOppFromQuote)

#### name

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Quotes](#3.1.%20Active%20Quotes)
- [View: All Quotes](#3.2.%20All%20Quotes)
- [View: All Quotes (Sort)](#3.2.%20All%20Quotes)
- [View: My Quotes](#3.3.%20My%20Quotes)
- [View: Quick Find All Quotes](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quick Find All Quotes (Filter)](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quick Find All Quotes (Sort)](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PAQuoteReport > QuoteHeader (Sort)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: PackingSlip > OrderHeader (Sort)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SoleSourceLetter > QuoteHeader (Sort)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Sort)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Sort)](#5.5.%20iGradQuoteReport)
- [Workflow: 0EngagementNames (Read)](#7.2.%200EngagementNames)
- [Workflow: BatchConverttoLead (Read)](#7.6.%20BatchConverttoLead)
- [Workflow: BatchCreateEngagements (Read)](#7.7.%20BatchCreateEngagements)
- [Workflow: BatchLooseOpportunities (Read)](#7.8.%20BatchLooseOpportunities)
- [Workflow: BatchOpportunityTransfer (Read)](#7.9.%20BatchOpportunityTransfer)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneOpportunity (Read)](#7.17.%20CloneOpportunity)
- [Workflow: CloneOrder (Read)](#7.18.%20CloneOrder)
- [Workflow: CreateLeadFromLeadGen (Read)](#7.20.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Read)](#7.21.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Read)](#7.23.%20CustomLeadCreation)
- [Workflow: NewFSRLeadNotification (Read)](#7.32.%20NewFSRLeadNotification)
- [Workflow: QualifyLead (Write)](#7.38.%20QualifyLead)
- [Workflow: RenameEngagements (Read)](#7.41.%20RenameEngagements)
- [Workflow: TaskCreateReorderLead (Read)](#7.45.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Read)](#7.46.%20WonOpportunityEmail)
- [JS: azt_accountlibrary > createLead()](#8.1.%20azt_accountlibrary)
- [JS: azt_accountlibrary > createNewLead()](#8.1.%20azt_accountlibrary)
- [JS: azt_addresslibrary > addAddress()](#8.2.%20azt_addresslibrary)
- [JS: azt_opportunitytrackdiscount > trackDiscount()](#8.9.%20azt_opportunitytrackdiscount)
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

#### objectid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### objecttypecode

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### opportunityid

- [Field Definitions](#1.%20Field%20Definitions)
- [View: All Quotes](#3.2.%20All%20Quotes)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
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
- [Relationship: opportunity_quotes](#12.%20Relationships)

#### opportunityproductid

- [Field Definitions](#1.%20Field%20Definitions)
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

#### ordernumber

- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)

#### originatingleadid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: OpportunityAssignFromLead (Read)](#10.42.%20OpportunityAssignFromLead)

#### ownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > description_section](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
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

- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)

#### owninguser

- [Plugin: GetAcctTeamOwned (Join)](#10.31.%20GetAcctTeamOwned)

#### parentaccountid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: LeadQualify (Read)](#10.38.%20LeadQualify)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)

#### parentcontactid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### parentcustomerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### parentgoalid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### parentsystemuserid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: Utility (Read)](#10.81.%20Utility)

#### partyid

- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### paymenttermscode

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### phonenumber

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### pricelevelid

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### priceperunit

- [Field Definitions](#1.%20Field%20Definitions)
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
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)

#### prod.productid

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)

#### productdescription

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)

#### productnumber

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: RestrictProductLookups (Filter)](#10.69.%20RestrictProductLookups)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### producttypecode

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)

#### quantity

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### queueid

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### queueitemid

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### quotecustomeridcontactcontactid.emailaddress1

- [View: All Quotes](#3.2.%20All%20Quotes)
- [View: My Quotes](#3.3.%20My%20Quotes)

#### quotedetailid

- [Field Definitions](#1.%20Field%20Definitions)
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

#### quotedetailsgrid

- [Form: Quote > Administration > Section](#2.1.%20Quote%20-%20main%20-%20Active)

#### quoteid

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Quotes](#3.1.%20Active%20Quotes)
- [View: All Quotes](#3.2.%20All%20Quotes)
- [View: My Quotes](#3.3.%20My%20Quotes)
- [View: Quick Find All Quotes](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: QuoteRecordOwnerTeam (Read)](#7.40.%20QuoteRecordOwnerTeam)
- [Workflow: SendQuote (Read)](#7.42.%20SendQuote)
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
- [Relationship: quote_orders](#12.%20Relationships)

#### quotelines

- [Form: Quote > Summary_tab > products](#2.1.%20Quote%20-%20main%20-%20Active)

#### quotenumber

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Quick Find All Quotes (Filter)](#3.4.%20Quick%20Find%20All%20Quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader > quote](#5.2.%20PackingSlip)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [JS: azt_sendquote > sendLifeSkillsQuote()](#8.12.%20azt_sendquote)
- [JS: azt_sendquote > sendPAQuote()](#8.12.%20azt_sendquote)
- [JS: azt_sendquote > sendQuote()](#8.12.%20azt_sendquote)

#### record1id

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: LeadQualifyParentStakeholderContacts (Filter)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Filter)](#10.75.%20SetPrimaryContact)

#### record1roleid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)

#### record2id

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ContactSetConnectionRole (Write)](#10.19.%20ContactSetConnectionRole)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: LeadQualifyParentStakeholderContacts (Sort)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Filter)](#10.75.%20SetPrimaryContact)

#### record2roleid

- [Field Definitions](#1.%20Field%20Definitions)
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

#### requestdeliveryby

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### roleid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: GetUserHasRoleToAction (Read)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: GetUserHasRoleToAction (Filter)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: GetUserHasRoleToAction (Join)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Filter)](#10.81.%20Utility)
- [Plugin: Utility (Join)](#10.81.%20Utility)

#### rolluponlyfromchildgoals

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### rollupqueryactualmoneyid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### rolluprulestep1_1

- [Field Definitions](#1.%20Field%20Definitions)
- [Formula: azt_discretionarydiscount](#9.%20Formulas%20and%20Rollups)

#### rolluprulestep1_2

- [Field Definitions](#1.%20Field%20Definitions)
- [Formula: azt_discretionarydiscount](#9.%20Formulas%20and%20Rollups)

#### salesorderdetailid

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderLinePopulateTemplateFields (Read)](#10.54.%20OrderLinePopulateTemplateFields)

#### salesorderid

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### scheduledend

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#10.7.%20ActivitiesCreatedDueDatesInPast)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### shippingmethodcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_city

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### shipto_contactname

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > quote information](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneOrder (Write)](#7.18.%20CloneOrder)

#### shipto_country

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### shipto_fax

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### shipto_freighttermscode

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### shipto_line1

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_line2

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_line3

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_name

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > quote information](#2.1.%20Quote%20-%20main%20-%20Active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_postalcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_stateorprovince

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_telephone

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: CloneAndDeleteQuote (Read)](#7.15.%20CloneAndDeleteQuote)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### state

- [Field Definitions](#1.%20Field%20Definitions)
- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### statecode

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Quotes](#3.1.%20Active%20Quotes)
- [View: Active Quotes (Filter)](#3.1.%20Active%20Quotes)
- [View: All Quotes](#3.2.%20All%20Quotes)
- [View: My Quotes](#3.3.%20My%20Quotes)
- [View: My Quotes (Filter)](#3.3.%20My%20Quotes)
- [View: My Quotes (Filter)](#3.3.%20My%20Quotes)
- [View: Quick Find All Quotes](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Workflow: BatchConverttoLead (Write)](#7.6.%20BatchConverttoLead)
- [Workflow: CaseResolutionNotificationEmail (Read)](#7.14.%20CaseResolutionNotificationEmail)
- [Workflow: CloneOrder (Write)](#7.18.%20CloneOrder)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.20.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.21.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.23.%20CustomLeadCreation)
- [Workflow: LeadQualifyDisqualifyDate (Read)](#7.31.%20LeadQualifyDisqualifyDate)
- [Workflow: OpportunityAuditRemoval (Read)](#7.33.%20OpportunityAuditRemoval)
- [Workflow: TaskCreateReorderLead (Write)](#7.45.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Read)](#7.46.%20WonOpportunityEmail)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Workflow: BatchCreateEngagements (Write)](#7.7.%20BatchCreateEngagements)
- [Workflow: CloneOrder (Write)](#7.18.%20CloneOrder)
- [Workflow: EmailDeleteSendQuoteDrafts (Read)](#7.25.%20EmailDeleteSendQuoteDrafts)
- [Workflow: EmailRemoveUnsentEmails (Read)](#7.26.%20EmailRemoveUnsentEmails)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#7.43.%20SoftwareLicenseCreateEngagement)
- [JS: azt_expensereportlibrary > corporateApprove()](#8.6.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > getCanApprove()](#8.6.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > onLoad()](#8.6.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > reject()](#8.6.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setManagerApproval()](#8.6.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setPaid()](#8.6.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > submit()](#8.6.%20azt_expensereportlibrary)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Write)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### street

- [Field Definitions](#1.%20Field%20Definitions)
- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### subject

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### systemuserid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: GetAcctTeamOwned (Join)](#10.31.%20GetAcctTeamOwned)
- [Plugin: GetUserHasRoleToAction (Filter)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: GetUserHasRoleToAction (Join)](#10.33.%20GetUserHasRoleToAction)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: Utility (Filter)](#10.81.%20Utility)
- [Plugin: Utility (Join)](#10.81.%20Utility)

#### tax

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLineSyncToQuote (Read)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)

#### teamid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountAutoAssign (Read)](#10.1.%20AccountAutoAssign)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)

#### teamtype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountAutoAssign (Filter)](#10.1.%20AccountAutoAssign)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)

#### telephone1

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### title

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader > systemuser](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader > systemuser](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader > systemuser](#5.5.%20iGradQuoteReport)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)

#### tm.systemuserid

- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)

#### to

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### totalamount

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Quotes](#3.1.%20Active%20Quotes)
- [View: All Quotes](#3.2.%20All%20Quotes)
- [View: My Quotes](#3.3.%20My%20Quotes)
- [View: Quick Find All Quotes](#3.4.%20Quick%20Find%20All%20Quotes)
- [View: Quotes Needing Freight Approval](#3.5.%20Quotes%20Needing%20Freight%20Approval)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: PackingSlip > OrderHeader (Select)](#5.2.%20PackingSlip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#5.3.%20SoleSourceLetter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)
- [JS: azt_splitinvoice > splitInvoice()](#8.13.%20azt_splitinvoice)
- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#10.66.%20QuoteSyncTotalToOpportunity)

#### totallineitemamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#5.1.%20PAQuoteReport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#5.4.%20SummaryQuoteReport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#5.5.%20iGradQuoteReport)

#### transactioncurrencyid

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### uomid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)

#### value

- [Field Definitions](#1.%20Field%20Definitions)
- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### willcall

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Quote > Summary_tab > addresses](#2.1.%20Quote%20-%20main%20-%20Active)
- [Workflow: CloneAndDeleteQuote (Write)](#7.15.%20CloneAndDeleteQuote)

#### zipcode

- [Field Definitions](#1.%20Field%20Definitions)
- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### {0}

- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
