# Azt_expensereport Field Usage Analysis
> Date: 2026-03-25

| Property | Value |
|---|---|
| **Entity Name** | azt_expensereport |
| **Display Name** | Expense Report |
| **Description** |  |
| **Object Type** | Custom |
| **Ownership Type** | UserOwned |
| **Audit Enabled** | True |
| **Total Rows** | 0 |
| **Last Update** |  |
| **Primary ID Field** | azt_expensereportid |
| **Primary Name Field** | azt_name |
| **Count Forms** | 30 |
| **Count Views** | 190 |
| **Count Chart Visualizations** | 0 |
| **Count Reports** | 0 |
| **Count Dashboards** | 0 |
| **Count Workflows** | 113 |
| **Count Formulas & Rollups** | 0 |
| **Count Plugins** | 273 |
| **Count PCF Controls** | 0 |
| **Count Relationships** | 18 |
| **Count Ribbon Customizations** | 0 |

## Table of Contents

- [1. Field Definitions](#1.%20Field%20Definitions)
- [2. Forms](#2.%20Forms)
  - [2.1. Information - card - Active](#2.1.%20Information%20-%20card%20-%20Active)
  - [2.2. Expense Report - main - Active](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
  - [2.3. Information - quick - Active](#2.3.%20Information%20-%20quick%20-%20Active)
- [3. Views](#3.%20Views)
  - [3.1. Active Expense Reports](#3.1.%20Active%20Expense%20Reports)
  - [3.2. All Expense Reports](#3.2.%20All%20Expense%20Reports)
  - [3.3. Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
  - [3.4. Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
  - [3.5. Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
  - [3.6. Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
  - [3.7. Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
  - [3.8. Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
  - [3.9. Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
  - [3.10. Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
  - [3.11. My Expense Reports](#3.11.%20My%20Expense%20Reports)
  - [3.12. My Expense Reports](#3.12.%20My%20Expense%20Reports)
  - [3.13. My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
  - [3.14. Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
  - [3.15. Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [4. Chart Visualizations](#4.%20Chart%20Visualizations)
- [5. Reports](#5.%20Reports)
- [6. Dashboards](#6.%20Dashboards)
- [7. Workflows](#7.%20Workflows)
  - [7.1. 0EngagementNames](#7.1.%200EngagementNames)
  - [7.2. AccountAuto-Assign](#7.2.%20AccountAuto-Assign)
  - [7.3. AllocationsAssigntoTeam](#7.3.%20AllocationsAssigntoTeam)
  - [7.4. AppointmentAuto-Assign](#7.4.%20AppointmentAuto-Assign)
  - [7.5. BatchConverttoLead](#7.5.%20BatchConverttoLead)
  - [7.6. BatchCreateEngagements](#7.6.%20BatchCreateEngagements)
  - [7.7. BatchOpportunityTransfer](#7.7.%20BatchOpportunityTransfer)
  - [7.8. CasePendingAssignmentNotification](#7.8.%20CasePendingAssignmentNotification)
  - [7.9. CaseRecordOwner](#7.9.%20CaseRecordOwner)
  - [7.10. CaseRecordOwnerAssign](#7.10.%20CaseRecordOwnerAssign)
  - [7.11. CaseRecordOwnerAssignmentNotification](#7.11.%20CaseRecordOwnerAssignmentNotification)
  - [7.12. CaseResolutionNotificationEmail](#7.12.%20CaseResolutionNotificationEmail)
  - [7.13. CloneAndDeleteQuote](#7.13.%20CloneAndDeleteQuote)
  - [7.14. CloneCommissionPayment](#7.14.%20CloneCommissionPayment)
  - [7.15. CloneCompGoal](#7.15.%20CloneCompGoal)
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
  - [7.28. ExpenseNotificationManager](#7.28.%20ExpenseNotificationManager)
  - [7.29. ExpenseReportRejectedNotification](#7.29.%20ExpenseReportRejectedNotification)
  - [7.30. FSRLeadDistibutionNotification](#7.30.%20FSRLeadDistibutionNotification)
  - [7.31. InvoiceRecordOwner](#7.31.%20InvoiceRecordOwner)
  - [7.32. LeadAssignment](#7.32.%20LeadAssignment)
  - [7.33. LeadQualifyDisqualifyDate](#7.33.%20LeadQualifyDisqualifyDate)
  - [7.34. NewFSRLeadNotification](#7.34.%20NewFSRLeadNotification)
  - [7.35. OpportunityAuditRemoval](#7.35.%20OpportunityAuditRemoval)
  - [7.36. OpportunityRecordOwner](#7.36.%20OpportunityRecordOwner)
  - [7.37. Order-CreateOrderStageTracking](#7.37.%20Order-CreateOrderStageTracking)
  - [7.38. OrderRecordOwner](#7.38.%20OrderRecordOwner)
  - [7.39. PhonecallAuto-Assign](#7.39.%20PhonecallAuto-Assign)
  - [7.40. PrintPurchaseAssigntoTeam](#7.40.%20PrintPurchaseAssigntoTeam)
  - [7.41. QualifyLead](#7.41.%20QualifyLead)
  - [7.42. QuoteRecordOwner](#7.42.%20QuoteRecordOwner)
  - [7.43. RenameEngagements](#7.43.%20RenameEngagements)
  - [7.44. SoftwareLicenseAssigntoTeam](#7.44.%20SoftwareLicenseAssigntoTeam)
  - [7.45. SoftwareLicenseCreateEngagement](#7.45.%20SoftwareLicenseCreateEngagement)
  - [7.46. SoftwareLicenseSetOwner](#7.46.%20SoftwareLicenseSetOwner)
  - [7.47. TaskAuto-Assign](#7.47.%20TaskAuto-Assign)
  - [7.48. TaskCreateReorderLead](#7.48.%20TaskCreateReorderLead)
  - [7.49. WonOpportunityEmail](#7.49.%20WonOpportunityEmail)
  - [7.50. WorkforceAccountAuto-assign](#7.50.%20WorkforceAccountAuto-assign)
  - [7.51. WorkforceAppointmentAuto-Assign](#7.51.%20WorkforceAppointmentAuto-Assign)
  - [7.52. WorkforceCaseAuto-assign](#7.52.%20WorkforceCaseAuto-assign)
  - [7.53. WorkforceContactAuto-assign](#7.53.%20WorkforceContactAuto-assign)
  - [7.54. WorkforceEngagementAuto-assign](#7.54.%20WorkforceEngagementAuto-assign)
  - [7.55. WorkforceLeadAuto-Assign](#7.55.%20WorkforceLeadAuto-Assign)
  - [7.56. WorkforceOpportunityAuto-assign](#7.56.%20WorkforceOpportunityAuto-assign)
  - [7.57. WorkforcePhone-callAuto-assign](#7.57.%20WorkforcePhone-callAuto-assign)
  - [7.58. WorkforceQuoteAuto-assign](#7.58.%20WorkforceQuoteAuto-assign)
  - [7.59. iGradAppointmentAuto-Assign](#7.59.%20iGradAppointmentAuto-Assign)
  - [7.60. iGradCaseAuto-Assign](#7.60.%20iGradCaseAuto-Assign)
  - [7.61. iGradPhone-callAuto-assign](#7.61.%20iGradPhone-callAuto-assign)
- [8. JavaScript Web Resources](#8.%20JavaScript%20Web%20Resources)
  - [8.1. azt_engagementlibrary](#8.1.%20azt_engagementlibrary)
  - [8.2. azt_expensereportlibrary](#8.2.%20azt_expensereportlibrary)
  - [8.3. azt_leadlibrary](#8.3.%20azt_leadlibrary)
  - [8.4. azt_paymentlibrary](#8.4.%20azt_paymentlibrary)
  - [8.5. azt_productdiscountlibrary](#8.5.%20azt_productdiscountlibrary)
  - [8.6. azt_splitallocation](#8.6.%20azt_splitallocation)
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

Total fields: **112**

| # | Schema Name | Display Name | Type | Picklist Values | Custom | Required | Last Update | Flags | Mapping Suggested | SF Object | SF Field | SF API Name | SF Suggested Object | SF Suggested Field | SF Suggested API Name | Forms | Views | Chart Visualizations | Reports | Dashboards | Workflows | Formulas & Rollups | Plugins | PCF Controls | Relationships | Ribbon Customizations | Conflicts & Observations |
|---|-------------|-------------|------|-----------------|--------|----------|-------------|-------|-------------------|-----------|----------|-------------|---------------------|--------------------|-----------------------|-------|-------|----------------------|---------|------------|-----------|--------------------|---------|--------------|--------------|-----------------------|--------------------------|
| 1 | [!process_custom_attribute_url_](#%21process_custom_attribute_url_) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 2 | [activityid](#activityid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 3 | [activitytypecode](#activitytypecode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 4 | [actualclosedate](#actualclosedate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 5 | [adx_resolutiondate](#adx_resolutiondate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 6 | [amountdatatype](#amountdatatype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 7 | [azt_approvingcorporatemanagerid](#azt_approvingcorporatemanagerid) | Approving Corporate Manager | lookup |  | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 8 | [azt_approvingmanagerid](#azt_approvingmanagerid) | Approving Manager | lookup |  | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 9 | [azt_compplanamountid](#azt_compplanamountid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 10 | [azt_corporateapproved](#azt_corporateapproved) | Corporate Approved? | bit | 1: Approved, 0: Not Approved | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 11 | [azt_datecorporateapproved](#azt_datecorporateapproved) | Date Corporate Approved | datetime |  | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 12 | [azt_datemanagerapproved](#azt_datemanagerapproved) | Date Manager Approved | datetime |  | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  |  |  |  |
| 13 | [azt_datepaid](#azt_datepaid) | Date Paid | datetime |  | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) | [1](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 14 | [azt_datesubmitted](#azt_datesubmitted) | Date Submitted | datetime |  | Yes | none |  | C R U Re | true |  |  |  |  |  |  | [1](#2.%20Forms) | [17](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 15 | [azt_enddate](#azt_enddate) | End Date | datetime |  | Yes | none |  | C R U Re | true |  |  |  |  |  |  | [1](#2.%20Forms) | [11](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 16 | [azt_expenseid](#azt_expenseid) | Expense ID | nvarchar |  | Yes | none |  | C R U S Re | true |  |  |  |  |  |  | [1](#2.%20Forms) | [12](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 17 | [azt_expensereportid](#azt_expensereportid) | Expense Report | primarykey |  | No | systemrequired |  | C R F Re | true |  |  |  |  |  |  |  | [15](#3.%20Views) |  |  |  | [2](#7.%20Workflows) |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 18 | [azt_ispaid](#azt_ispaid) | Is Paid? | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) | [2](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 19 | [azt_licenseterm](#azt_licenseterm) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 20 | [azt_managerapproved](#azt_managerapproved) | Manager Approved? | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) | [2](#3.%20Views) |  |  |  |  |  |  |  |  |  |  |
| 21 | [azt_masecommission](#azt_masecommission) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 22 | [azt_name](#azt_name) | Name | nvarchar |  | Yes | required |  | C R U S Re | true |  |  |  |  |  |  | [3](#2.%20Forms) | [20](#3.%20Views) |  |  |  | [9](#7.%20Workflows) |  | [18](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 23 | [azt_paidbyid](#azt_paidbyid) | Paid By | lookup |  | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 24 | [azt_payablecommission](#azt_payablecommission) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 25 | [azt_percentagepaid](#azt_percentagepaid) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 26 | [azt_recordowner](#azt_recordowner) |  |  |  | Yes |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 27 | [azt_reject](#azt_reject) | Reject | bit | 1: Yes, 0: No | Yes | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  | [2](#7.%20Workflows) |  |  |  |  |  |  |
| 28 | [azt_startdate](#azt_startdate) | Start Date | datetime |  | Yes | none |  | C R U Re | true |  |  |  |  |  |  | [1](#2.%20Forms) | [11](#3.%20Views) |  |  |  | [2](#7.%20Workflows) |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 29 | [azt_submitted](#azt_submitted) | Submitted? | bit | 1: Yes, 0: No | Yes | none |  | C R U Re | true |  |  |  |  |  |  | [1](#2.%20Forms) | [11](#3.%20Views) |  |  |  | [1](#7.%20Workflows) |  |  |  |  |  |  |
| 30 | [azt_submittedbyid](#azt_submittedbyid) | Submitted By | lookup |  | Yes | none |  | C R U S Re | true |  |  |  |  |  |  | [1](#2.%20Forms) | [17](#3.%20Views) |  |  |  | [1](#7.%20Workflows) |  |  |  | [1](#12.%20Relationships) |  |  |
| 31 | [azt_totalreimbursement](#azt_totalreimbursement) | Total Reimbursement | money |  | Yes | none |  | C R U Re | true |  |  |  |  |  |  | [2](#2.%20Forms) | [14](#3.%20Views) |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 32 | [azt_totalreimbursement_base](#azt_totalreimbursement_base) | Total Reimbursement (Base) | money |  | Yes | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 33 | [baseamount](#baseamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 34 | [billto_line1](#billto_line1) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 35 | [billto_line2](#billto_line2) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 36 | [billto_line3](#billto_line3) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 37 | [billto_name](#billto_name) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 38 | [billto_postalcode](#billto_postalcode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 39 | [billto_stateorprovince](#billto_stateorprovince) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 40 | [body](#body) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 41 | [businessprocessflowinstanceid](#businessprocessflowinstanceid) | Business Process Flow Instance Id | uniqueidentifier |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 42 | [category](#category) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 43 | [consideronlygoalownersrecords](#consideronlygoalownersrecords) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 44 | [createdby](#createdby) | Created By | lookup |  | No | none |  | R | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  | [25](#7.%20Workflows) |  |  |  | [1](#12.%20Relationships) |  |  |
| 45 | [createdon](#createdon) | Created On | datetime |  | No | none |  | R F Re | true |  |  |  |  |  |  | [1](#2.%20Forms) | [19](#3.%20Views) |  |  |  | [7](#7.%20Workflows) |  | [10](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 46 | [createdonbehalfby](#createdonbehalfby) | Created By (Delegate) | lookup |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 47 | [datefulfilled](#datefulfilled) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 48 | [defaultuomid](#defaultuomid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 49 | [description](#description) | Description | ntext |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [7](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 50 | [discountamount](#discountamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 51 | [exchangerate](#exchangerate) | Exchange Rate | decimal |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 52 | [ext_amt](#ext_amt) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 53 | [extendedamount](#extendedamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [13](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 54 | [fetchxml](#fetchxml) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 55 | [filename](#filename) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 56 | [goalenddate](#goalenddate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 57 | [goalownerid](#goalownerid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 58 | [goalstartdate](#goalstartdate) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 59 | [importsequencenumber](#importsequencenumber) | Import Sequence Number | int |  | No | none |  | C R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 60 | [internalemailaddress](#internalemailaddress) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 61 | [invoicenumber](#invoicenumber) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 62 | [isamount](#isamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 63 | [isfiscalperiodgoal](#isfiscalperiodgoal) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 64 | [isocurrencycode](#isocurrencycode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 65 | [ispriceoverridden](#ispriceoverridden) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 66 | [isproductoverridden](#isproductoverridden) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 67 | [jobtitle](#jobtitle) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 68 | [manualdiscountamount](#manualdiscountamount) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [9](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 69 | [mimetype](#mimetype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 70 | [mobilephone](#mobilephone) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 71 | [modifiedby](#modifiedby) | Modified By | lookup |  | No | none |  | R | true |  |  |  |  |  |  |  |  |  |  |  | [2](#7.%20Workflows) |  |  |  | [1](#12.%20Relationships) |  |  |
| 72 | [modifiedon](#modifiedon) | Modified On | datetime |  | No | none |  | R F Re | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [4](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 73 | [modifiedonbehalfby](#modifiedonbehalfby) | Modified By (Delegate) | lookup |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 74 | [objecttypecode](#objecttypecode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 75 | [originatingleadid](#originatingleadid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 76 | [overriddencreatedon](#overriddencreatedon) | Record Created On | datetime |  | No | none |  | C R | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 77 | [ownerid](#ownerid) | Owner | owner |  | No | systemrequired |  | C R U F | true |  |  |  |  |  |  | [4](#2.%20Forms) | [4](#3.%20Views) |  |  |  | [24](#7.%20Workflows) |  | [22](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 78 | [owningbusinessunit](#owningbusinessunit) | Owning Business Unit | lookup |  | No | none |  | R F | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#12.%20Relationships) |  |  |
| 79 | [owningteam](#owningteam) | Owning Team | lookup |  | No | none |  | R L | false |  |  |  |  |  |  |  |  |  |  |  | [1](#7.%20Workflows) |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 80 | [owninguser](#owninguser) | Owning User | lookup |  | No | none |  | R L | true |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 81 | [parentgoalid](#parentgoalid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 82 | [parentsystemuserid](#parentsystemuserid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 83 | [priceperunit](#priceperunit) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 84 | [processid](#processid) | Process Id | uniqueidentifier |  | No | none |  | C R U | true |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 85 | [productdescription](#productdescription) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [13](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 86 | [productname](#productname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 87 | [queryentitytype](#queryentitytype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 88 | [record1roleid](#record1roleid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 89 | [record2roleid](#record2roleid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [5](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 90 | [regardingobjectid](#regardingobjectid) | Regarding | lookup |  | No | none |  | R | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  | [6](#12.%20Relationships) |  |  |
| 91 | [requestdeliveryby](#requestdeliveryby) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 92 | [rolluponlyfromchildgoals](#rolluponlyfromchildgoals) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 93 | [rollupqueryactualmoneyid](#rollupqueryactualmoneyid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 94 | [salesorderdetailname](#salesorderdetailname) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 95 | [salesrepid](#salesrepid) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 96 | [scheduledend](#scheduledend) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 97 | [shipto_line1](#shipto_line1) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 98 | [shipto_line2](#shipto_line2) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 99 | [shipto_line3](#shipto_line3) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 100 | [shipto_name](#shipto_name) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 101 | [shipto_postalcode](#shipto_postalcode) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 102 | [shipto_stateorprovince](#shipto_stateorprovince) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [1](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 103 | [stageid](#stageid) | (Deprecated) Stage Id | uniqueidentifier |  | No | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 104 | [statecode](#statecode) | Status | state |  | No | systemrequired |  | R U F | true |  |  |  |  |  |  |  | [12](#3.%20Views) |  |  |  | [10](#7.%20Workflows) |  | [20](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 105 | [statuscode](#statuscode) | Expense Status | status |  | No | none |  | C R U S Re | true |  |  |  |  |  |  | [2](#2.%20Forms) | [22](#3.%20Views) |  |  |  | [5](#7.%20Workflows) |  | [6](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 106 | [tax](#tax) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 107 | [teamtype](#teamtype) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [3](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 108 | [timezoneruleversionnumber](#timezoneruleversionnumber) | Time Zone Rule Version Number | int |  | No | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 109 | [title](#title) |  |  |  | No |  |  |  | false |  |  |  |  |  |  |  |  |  |  |  |  |  | [2](#10.%20Plugin%20Source%20Code%20Analysis) |  |  |  |  |
| 110 | [transactioncurrencyid](#transactioncurrencyid) | Currency | lookup |  | No | none |  | C R U | true |  |  |  |  |  |  | [1](#2.%20Forms) |  |  |  |  | [20](#7.%20Workflows) |  | [8](#10.%20Plugin%20Source%20Code%20Analysis) |  | [1](#12.%20Relationships) |  |  |
| 111 | [traversedpath](#traversedpath) | (Deprecated) Traversed Path | nvarchar |  | No | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| 112 | [utcconversiontimezonecode](#utcconversiontimezonecode) | UTC Conversion Time Zone Code | int |  | No | none |  | C R U | false |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |

---

## 2. Forms

Total forms: **3**

### 2.1. Information - card - Active

- **Form ID:** `{995f36bc-d0d5-4f74-bc31-a6035b428414}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: general

##### Section: ColorStrip

##### Section: Header

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [statuscode](#statuscode) | Expense Status | No | Yes |

##### Section: Details

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_name](#azt_name) | Name | No | Yes |

##### Section: Footer

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#ownerid) | Owner | No | Yes |
| [createdon](#createdon) | Created On | No | Yes |

### 2.2. Expense Report - main - Active

- **Form ID:** `{a4f94408-eeac-49d4-b395-e57d03eb949a}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Header Fields

| Field | Label |
|-------|-------|
| [ownerid](#ownerid) | Owner |
| [createdby](#createdby) | Created By |
| [azt_totalreimbursement](#azt_totalreimbursement) | Total Reimbursement |

#### Tab: General

##### Section: General

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_name](#azt_name) | Name | No | Yes |
| [azt_startdate](#azt_startdate) | Start Date | No | Yes |
| [azt_expenseid](#azt_expenseid) | Expense ID | Yes | Yes |
| [azt_enddate](#azt_enddate) | End Date | No | Yes |
| [statuscode](#statuscode) | Approval Status | Yes | Yes |
| [azt_totalreimbursement](#azt_totalreimbursement) | Total Reimbursement | Yes | Yes |

##### Section: Submittal

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_submitted](#azt_submitted) | Submitted? | No | Yes |
| [azt_submittedbyid](#azt_submittedbyid) | Submitted By | Yes | Yes |
| [azt_datesubmitted](#azt_datesubmitted) | Submitted On | Yes | Yes |
| [azt_reject](#azt_reject) | Reject | Yes | Yes |

##### Section: Expenses

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [Expenses](#Expenses) | Expenses | No | Yes |

#### Tab: Approval Process

##### Section: Manager Approval

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_managerapproved](#azt_managerapproved) | Approved? | Yes | Yes |
| [azt_approvingmanagerid](#azt_approvingmanagerid) | Approving Manager | Yes | Yes |
| [azt_datemanagerapproved](#azt_datemanagerapproved) | Date Approved | Yes | Yes |

##### Section: Corporate Approval

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_corporateapproved](#azt_corporateapproved) | Corporate Approved? | Yes | Yes |
| [azt_approvingcorporatemanagerid](#azt_approvingcorporatemanagerid) | Approving Corporate Manager | Yes | Yes |
| [azt_datecorporateapproved](#azt_datecorporateapproved) | Date Corporate Approved | Yes | Yes |

##### Section: Paid

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_ispaid](#azt_ispaid) | Is Paid? | Yes | Yes |
| [azt_paidbyid](#azt_paidbyid) | Paid By | Yes | Yes |
| [azt_datepaid](#azt_datepaid) | Date Paid | Yes | Yes |

#### Tab: Notes

##### Section: Notes

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [notescontrol](#notescontrol) | Note Text | No | Yes |

#### Tab: Administration

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#ownerid) | Owner | No | Yes |
| [transactioncurrencyid](#transactioncurrencyid) | Currency | No | Yes |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `E.ExpenseReportFunctions.onLoad` | `azt_expensereportlibrary` | true |
| onload |  | `E.ExpenseReportFunctions.getCanApprove` | `azt_expensereportlibrary` | true |
| onchange | azt_submitted | `E.ExpenseReportFunctions.submit` | `azt_expensereportlibrary` | true |
| onchange | azt_submitted | `E.ExpenseReportFunctions.onLoad` | `azt_expensereportlibrary` | true |
| onchange | azt_reject | `reject` | `azt_expensereportlibrary` | true |
| onchange | azt_managerapproved | `E.ExpenseReportFunctions.setManagerApproval` | `azt_expensereportlibrary` | true |
| onchange | azt_managerapproved | `E.ExpenseReportFunctions.onLoad` | `azt_expensereportlibrary` | true |
| onchange | azt_corporateapproved | `E.ExpenseReportFunctions.corporateApprove` | `azt_expensereportlibrary` | true |
| onchange | azt_corporateapproved | `E.ExpenseReportFunctions.onLoad` | `azt_expensereportlibrary` | true |
| onchange | azt_ispaid | `E.ExpenseReportFunctions.setPaid` | `azt_expensereportlibrary` | true |

### 2.3. Information - quick - Active

- **Form ID:** `{38c9be42-7f96-4110-a3e7-79811857b920}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: 

##### Section: GENERAL

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_name](#azt_name) | Name | No | Yes |
| [ownerid](#ownerid) | Owner | No | Yes |

---

## 3. Views

Total views: **15**

### 3.1. Active Expense Reports

- **Type:** Standard (querytype=0)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [createdon](#createdon) | 125px |
| 2 | [ownerid](#ownerid) | 100px |
| 3 | [azt_name](#azt_name) | 300px |
| 4 | [azt_totalreimbursement](#azt_totalreimbursement) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Descending |
| [ownerid](#ownerid) | Ascending |

### 3.2. All Expense Reports

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 125px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 150px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_name](#azt_name) | Ascending |

### 3.3. Draft Expense Reports

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 100px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [statuscode](#statuscode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Descending |
| [azt_submittedbyid](#azt_submittedbyid) | Ascending |

### 3.4. Expense Report Advanced Find View

- **Type:** Advanced Find (querytype=1)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 100px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 125px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_name](#azt_name) | Ascending |

### 3.5. Expense Report Associated View

- **Type:** Associated View (querytype=2)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 125px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_name](#azt_name) | Ascending |

### 3.6. Expense Report Lookup View

- **Type:** Lookup View (querytype=64)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_name](#azt_name) | 300px |
| 2 | [azt_expenseid](#azt_expenseid) | 100px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 125px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_name](#azt_name) | Ascending |

### 3.7. Expense Report Pending Corporate Approval

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 100px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [statuscode](#statuscode) | eq | 276530001 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_datesubmitted](#azt_datesubmitted) | Descending |

### 3.8. Expense Reports Pending Manager Approval

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 100px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [statuscode](#statuscode) | eq | 276530000 |
| [statuscode](#statuscode) | null |  |
| [statuscode](#statuscode) | not-in |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Descending |
| [azt_submittedbyid](#azt_submittedbyid) | Ascending |

### 3.9. Expense Reports Pending Reimbursement

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 100px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [statuscode](#statuscode) | eq | 276530002 |
| [azt_ispaid](#azt_ispaid) | ne | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Descending |
| [azt_submittedbyid](#azt_submittedbyid) | Ascending |

### 3.10. Inactive Expense Reports

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 125px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_name](#azt_name) | Ascending |

### 3.11. My Expense Reports

- **Type:** InteractiveWorkflow (querytype=8192)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [ownerid](#ownerid) | eq-userid |  |

### 3.12. My Expense Reports

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_datesubmitted](#azt_datesubmitted) | 125px |
| 2 | [createdon](#createdon) | 125px |
| 3 | [azt_name](#azt_name) | 200px |
| 4 | [statuscode](#statuscode) | 150px |
| 5 | [azt_managerapproved](#azt_managerapproved) | 150px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 150px |
| 7 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [ownerid](#ownerid) | eq-userid |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_datesubmitted](#azt_datesubmitted) | Descending |

### 3.13. My Pending Expense Reports

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_datesubmitted](#azt_datesubmitted) | 150px |
| 2 | [createdon](#createdon) | 150px |
| 3 | [azt_name](#azt_name) | 150px |
| 4 | [statuscode](#statuscode) | 100px |
| 5 | [azt_managerapproved](#azt_managerapproved) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 100px |
| 7 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [statuscode](#statuscode) | in |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_datesubmitted](#azt_datesubmitted) | Descending |

### 3.14. Paid Expense Reports

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 100px |
| 11 | [azt_datepaid](#azt_datepaid) | 100px |
| 12 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_ispaid](#azt_ispaid) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#createdon) | Descending |
| [azt_submittedbyid](#azt_submittedbyid) | Ascending |

### 3.15. Quick Find Active Expense Reports

- **Type:** Quick Find (querytype=4)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [azt_expenseid](#azt_expenseid) | 100px |
| 2 | [azt_name](#azt_name) | 300px |
| 3 | [azt_submittedbyid](#azt_submittedbyid) | 125px |
| 4 | [azt_datesubmitted](#azt_datesubmitted) | 100px |
| 5 | [statuscode](#statuscode) | 100px |
| 6 | [azt_totalreimbursement](#azt_totalreimbursement) | 125px |
| 7 | [azt_startdate](#azt_startdate) | 100px |
| 8 | [azt_enddate](#azt_enddate) | 100px |
| 9 | [azt_submitted](#azt_submitted) | 100px |
| 10 | [createdon](#createdon) | 125px |
| 11 | [azt_expensereportid](#azt_expensereportid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#statecode) | eq | 0 |
| [azt_submittedbyid](#azt_submittedbyid) | like | {0} |
| [azt_name](#azt_name) | like | {0} |
| [statuscode](#statuscode) | like | {0} |
| [azt_expenseid](#azt_expenseid) | like | {0} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [azt_datesubmitted](#azt_datesubmitted) | Descending |
| [azt_submittedbyid](#azt_submittedbyid) | Ascending |

---

## 4. Chart Visualizations

Total charts: **0**

---

## 5. Reports

Total reports referencing Azt_expensereport: **0**

---

## 6. Dashboards

Total dashboards referencing Azt_expensereport: **0**

---

## 7. Workflows

Total workflows referencing Azt_expensereport: **61**

### 7.1. 0EngagementNames

- **File:** `0EngagementNames-BC419DA7-86F1-43E4-88B5-509514704A0C.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_name](#azt_name)

### 7.2. AccountAuto-Assign

- **File:** `AccountAuto-Assign-6DE252A4-C0D8-4C6B-800E-3985440C88D1.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Account

**Fields Read:**

- [createdby](#createdby)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`

### 7.3. AllocationsAssigntoTeam

- **File:** `AllocationsAssigntoTeam-B7D19816-C216-4C9D-81B7-9FE73CB2D066.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_allocatedlicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.4. AppointmentAuto-Assign

- **File:** `AppointmentAuto-Assign-1A553A9D-514D-42CA-A9AE-73FEED04E1E5.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Appointment

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.5. BatchConverttoLead

- **File:** `BatchConverttoLead-CC0F2DBB-B8CB-4B06-B891-DB6D97252DB8.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Written:**

- [ownerid](#ownerid)
- [statecode](#statecode)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.6. BatchCreateEngagements

- **File:** `BatchCreateEngagements-CC9CDFC6-4BC9-4635-B786-0C7BE2C34344.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Account

**Fields Written:**

- [azt_name](#azt_name)
- [azt_startdate](#azt_startdate)
- [statuscode](#statuscode)

### 7.7. BatchOpportunityTransfer

- **File:** `BatchOpportunityTransfer-744FEB80-2251-4252-875E-ED9958CB448A.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Written:**

- [transactioncurrencyid](#transactioncurrencyid)

### 7.8. CasePendingAssignmentNotification

- **File:** `CasePendingAssignmentNotification-177DE8B3-E0C3-4F1C-A7B5-DA84B3629AED.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Incident

**Fields Read:**

- [createdby](#createdby)
- [createdon](#createdon)
- [ownerid](#ownerid)

**Fields Written:**

- [transactioncurrencyid](#transactioncurrencyid)

### 7.9. CaseRecordOwner

- **File:** `CaseRecordOwner-E2135799-C146-4E0B-A0A5-F9917895B23E.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Incident

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.10. CaseRecordOwnerAssign

- **File:** `CaseRecordOwnerAssign-02EE1A9D-1658-4013-BF63-9C0E5C65AAD0.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Incident

**Fields Read:**

- [createdby](#createdby)
- [owningteam](#owningteam)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.11. CaseRecordOwnerAssignmentNotification

- **File:** `CaseRecordOwnerAssignmentNotification-2F6035E6-1FBC-476B-9C97-4554E8360B7C.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Incident

**Fields Read:**

- [createdby](#createdby)
- [createdon](#createdon)

**Fields Written:**

- [transactioncurrencyid](#transactioncurrencyid)

### 7.12. CaseResolutionNotificationEmail

- **File:** `CaseResolutionNotificationEmail-734E721F-7454-4437-8BAC-8B20F496DF12.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Incident

**Fields Read:**

- [statecode](#statecode)

**Fields Written:**

- [createdby](#createdby)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.13. CloneAndDeleteQuote

- **File:** `CloneAndDeleteQuote-1D87A694-5A08-4C93-9925-447BB4FE7DA6.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Quote

**Fields Written:**

- [ownerid](#ownerid)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.14. CloneCommissionPayment

- **File:** `CloneCommissionPayment-7E83F6F0-D101-4045-B686-0B6C658CC9A2.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_commissionpayment

**Fields Written:**

- [azt_name](#azt_name)
- [ownerid](#ownerid)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.15. CloneCompGoal

- **File:** `CloneCompGoal-156EF22C-38DA-4224-AD13-12A2524502F9.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_compgoaltype

**Fields Read:**

- [azt_name](#azt_name)

**Fields Written:**

- [transactioncurrencyid](#transactioncurrencyid)

### 7.16. CloneLicense

- **File:** `CloneLicense-49354120-2D2D-4DED-8C24-4ACA5F6D82D9.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [azt_name](#azt_name)

### 7.17. CloneOpportunity

- **File:** `CloneOpportunity-1A3FF4B3-79FD-420C-8A10-375E8892CA44.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Written:**

- [ownerid](#ownerid)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.18. CloneOrder

- **File:** `CloneOrder-D2A6AD48-A603-4150-BC84-72092AFB3D79.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** SalesOrder

**Fields Written:**

- [statecode](#statecode)
- [statuscode](#statuscode)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.19. ContactAuto-Assign

- **File:** `ContactAuto-Assign-25759C22-AE58-4CC7-81E1-9BBF37E76F3E.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Contact

**Fields Read:**

- [createdby](#createdby)
- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`
- `AztecPlugins.GetAcctTeamOwned`

### 7.20. CreateLeadFromLeadGen

- **File:** `CreateLeadFromLeadGen-2EA14729-4B62-4F91-95FA-76D258DA0831.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Account

**Fields Written:**

- [ownerid](#ownerid)
- [statecode](#statecode)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.21. CreateLeadfromAccount

- **File:** `CreateLeadfromAccount-B5E04C1C-B038-4018-B602-645B1E766884.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Account

**Fields Written:**

- [ownerid](#ownerid)
- [statecode](#statecode)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.22. CreateSoftwareLicense

- **File:** `CreateSoftwareLicense-82C11935-B2A2-4E45-94B4-F0EEA6641A08.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** SalesOrder

**Fields Written:**

- [azt_name](#azt_name)

### 7.23. CustomLeadCreation

- **File:** `CustomLeadCreation-B26AC2BB-4660-4A50-9229-AD056DE0D9E1.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Written:**

- [statecode](#statecode)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.24. EffectiveTo

- **File:** `EffectiveTo-C96A6885-1A20-E911-A94F-000D3A3B9B3D.xaml`
- **Entity References:** azt_expensereport
- **Trigger Scope:** Form
- **Trigger Form ID:** `{54076a2d-d043-4a1b-b061-4d06846371a9}`
- **Primary Entity:** Quote

**Fields Read:**

- [createdon](#createdon)

### 7.25. EmailDeleteSendQuoteDrafts

- **File:** `EmailDeleteSendQuoteDrafts-ED77962D-F57D-4F2F-A580-1F5D27E1280C.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Email

**Fields Read:**

- [createdon](#createdon)
- [statuscode](#statuscode)

### 7.26. EmailRemoveUnsentEmails

- **File:** `EmailRemoveUnsentEmails-2F1954B7-77B4-4D54-AA84-DBB10DFB6A71.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Email

**Fields Read:**

- [createdon](#createdon)
- [statuscode](#statuscode)

### 7.27. EngagementRecordOwner

- **File:** `EngagementRecordOwner-00BE88CF-37E2-46ED-951B-A553329BC127.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_engagement

**Fields Read:**

- [createdby](#createdby)
- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.28. ExpenseNotificationManager

- **File:** `ExpenseNotificationManager-5CC7F6CC-5991-401F-AEE9-20010EEBB90E.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_expensereport

**Fields Read:**

- [!process_custom_attribute_url_](#%21process_custom_attribute_url_)
- [azt_expensereportid](#azt_expensereportid)
- [azt_submitted](#azt_submitted)

**Fields Written:**

- [transactioncurrencyid](#transactioncurrencyid)

### 7.29. ExpenseReportRejectedNotification

- **File:** `ExpenseReportRejectedNotification-811FD6D5-D33F-4BEB-8F93-13D7F40F2A78.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_expensereport

**Fields Read:**

- [!process_custom_attribute_url_](#%21process_custom_attribute_url_)
- [azt_expensereportid](#azt_expensereportid)
- [azt_reject](#azt_reject)
- [azt_submittedbyid](#azt_submittedbyid)

**Fields Written:**

- [azt_reject](#azt_reject)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.30. FSRLeadDistibutionNotification

- **File:** `FSRLeadDistibutionNotification-2D276CE9-54BF-4703-A56C-933E5C57F3C7.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Lead

**Fields Read:**

- [createdby](#createdby)
- [createdon](#createdon)

**Fields Written:**

- [ownerid](#ownerid)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.31. InvoiceRecordOwner

- **File:** `InvoiceRecordOwner-C59ED476-F5C4-47B7-BD33-E88881D2B5EE.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Invoice

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.32. LeadAssignment

- **File:** `LeadAssignment-5FC23C73-5B6B-423C-8721-57EDA4553E31.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Lead

**Fields Read:**

- [createdby](#createdby)
- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### 7.33. LeadQualifyDisqualifyDate

- **File:** `LeadQualifyDisqualifyDate-4DF6EBF4-0F22-4433-AB4F-A241C91F8B5A.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Lead

**Fields Read:**

- [modifiedby](#modifiedby)
- [statecode](#statecode)

### 7.34. NewFSRLeadNotification

- **File:** `NewFSRLeadNotification-53E6AF89-E489-4977-8D9F-1579FF72FAC5.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Lead

**Fields Read:**

- [createdon](#createdon)

**Fields Written:**

- [createdby](#createdby)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.35. OpportunityAuditRemoval

- **File:** `OpportunityAuditRemoval-DB05BF90-221B-4B58-8AA0-D1A0799EA0A1.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Read:**

- [statecode](#statecode)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.OppAuditRemoval`

### 7.36. OpportunityRecordOwner

- **File:** `OpportunityRecordOwner-B0889237-722A-47CC-B102-D507B14FED98.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.37. Order-CreateOrderStageTracking

- **File:** `Order-CreateOrderStageTracking-DFFA9A38-A8AC-4A7A-AB74-ED0683908649.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_orderfulfillment

**Fields Written:**

- [azt_name](#azt_name)
- [modifiedby](#modifiedby)

### 7.38. OrderRecordOwner

- **File:** `OrderRecordOwner-701C3E67-4733-423C-BC31-5C846B542B76.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** SalesOrder

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.39. PhonecallAuto-Assign

- **File:** `PhonecallAuto-Assign-D7FD43A4-5AFF-4929-BD37-A1917C4F2391.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** PhoneCall

**Fields Read:**

- [createdby](#createdby)
- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.40. PrintPurchaseAssigntoTeam

- **File:** `PrintPurchaseAssigntoTeam-9620B3F1-4852-4FFA-8FA7-09615D8CCAFD.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_printpurchase

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.41. QualifyLead

- **File:** `QualifyLead-F6899272-F476-48C4-B703-D5ACDD9EDFF7.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Lead

**Fields Written:**

- [transactioncurrencyid](#transactioncurrencyid)

### 7.42. QuoteRecordOwner

- **File:** `QuoteRecordOwner-C5266A8C-E23D-41C4-B51F-3A637538DDBF.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Quote

**Fields Read:**

- [createdby](#createdby)
- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.43. RenameEngagements

- **File:** `RenameEngagements-9D4DC906-B3F2-498A-AC17-7D302597E96C.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_engagement

**Fields Read:**

- [azt_name](#azt_name)

### 7.44. SoftwareLicenseAssigntoTeam

- **File:** `SoftwareLicenseAssigntoTeam-2CFFBE82-9E25-47FD-A201-E6DB0C220DDE.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.45. SoftwareLicenseCreateEngagement

- **File:** `SoftwareLicenseCreateEngagement-ABFE722A-CAC3-4A3B-AF5C-419EA2CE9CBD.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [azt_name](#azt_name)
- [azt_startdate](#azt_startdate)
- [statuscode](#statuscode)

### 7.46. SoftwareLicenseSetOwner

- **File:** `SoftwareLicenseSetOwner-438596B2-A87C-4F1E-AC53-3B3197DEF67C.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_softwarelicense

**Fields Read:**

- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.47. TaskAuto-Assign

- **File:** `TaskAuto-Assign-89E60667-3F7F-4ADD-8274-57C2BE011059.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Task

**Fields Read:**

- [createdby](#createdby)
- [ownerid](#ownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### 7.48. TaskCreateReorderLead

- **File:** `TaskCreateReorderLead-3193EB56-8E56-46A3-B079-A7CFD1CE90B7.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Task

**Fields Written:**

- [ownerid](#ownerid)
- [statecode](#statecode)
- [transactioncurrencyid](#transactioncurrencyid)

### 7.49. WonOpportunityEmail

- **File:** `WonOpportunityEmail-DB2872A0-18C2-4157-B6BD-480230C97D32.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Read:**

- [statecode](#statecode)

**Fields Written:**

- [transactioncurrencyid](#transactioncurrencyid)

### 7.50. WorkforceAccountAuto-assign

- **File:** `WorkforceAccountAuto-assign-1AD2C544-E6F9-4FC7-AA17-810AEB8939C2.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Account

**Fields Read:**

- [createdby](#createdby)

### 7.51. WorkforceAppointmentAuto-Assign

- **File:** `WorkforceAppointmentAuto-Assign-803829FB-077B-4F0B-B238-105814F5B202.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Appointment

**Fields Read:**

- [createdby](#createdby)

### 7.52. WorkforceCaseAuto-assign

- **File:** `WorkforceCaseAuto-assign-24BA0A9C-F8BD-45CB-A5F6-6DCE42CD998F.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Incident

**Fields Read:**

- [createdby](#createdby)

### 7.53. WorkforceContactAuto-assign

- **File:** `WorkforceContactAuto-assign-65B65E23-A8F5-46DB-A35A-C5DC8542B6AE.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Contact

**Fields Read:**

- [createdby](#createdby)

### 7.54. WorkforceEngagementAuto-assign

- **File:** `WorkforceEngagementAuto-assign-DA5CDD7F-2A3B-4A0A-861D-75305D10254E.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** azt_engagement

**Fields Read:**

- [createdby](#createdby)

### 7.55. WorkforceLeadAuto-Assign

- **File:** `WorkforceLeadAuto-Assign-E5A4054C-5F7E-478C-87E3-529C1EEAB0DC.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Lead

**Fields Read:**

- [createdby](#createdby)

### 7.56. WorkforceOpportunityAuto-assign

- **File:** `WorkforceOpportunityAuto-assign-7D379FBE-C672-41EB-90A3-A80451C62533.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Opportunity

**Fields Read:**

- [createdby](#createdby)

### 7.57. WorkforcePhone-callAuto-assign

- **File:** `WorkforcePhone-callAuto-assign-BE1CB211-7C3C-4E39-8913-2DFCE7EDFC85.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** PhoneCall

**Fields Read:**

- [createdby](#createdby)

### 7.58. WorkforceQuoteAuto-assign

- **File:** `WorkforceQuoteAuto-assign-E64BB2BB-5CD6-4327-AB1B-BF8C9D4D2385.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Quote

**Fields Read:**

- [createdby](#createdby)

### 7.59. iGradAppointmentAuto-Assign

- **File:** `iGradAppointmentAuto-Assign-CE88A0C4-AA60-44F4-B33D-B57FB8279CCF.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Appointment

**Fields Read:**

- [createdby](#createdby)

### 7.60. iGradCaseAuto-Assign

- **File:** `iGradCaseAuto-Assign-CAF5021E-07E1-4689-92D5-FC59E9F30F78.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** Incident

**Fields Read:**

- [createdby](#createdby)

### 7.61. iGradPhone-callAuto-assign

- **File:** `iGradPhone-callAuto-assign-04423D55-3225-429E-BAC6-8DD37BC53F1B.xaml`
- **Entity References:** azt_expensereport
- **Primary Entity:** PhoneCall

**Fields Read:**

- [createdby](#createdby)

---

## 8. JavaScript Web Resources

Total JS files referencing Azt_expensereport fields: **6**

### 8.1. azt_engagementlibrary

- **File:** `azt_engagementlibraryE672CD7D-C50C-E911-A97C-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_name](#azt_name) | write |

### 8.2. azt_expensereportlibrary

- **File:** `azt_expensereportlibraryE56605D3-7B07-E911-A977-000D3A1A9FA9`

**Per-Function Field Usage:**

`corporateApprove`:

| Field | Operations |
|-------|-----------|
| [azt_approvingcorporatemanagerid](#azt_approvingcorporatemanagerid) | UI |
| [azt_corporateapproved](#azt_corporateapproved) | write |
| [azt_datecorporateapproved](#azt_datecorporateapproved) | UI |
| [azt_managerapproved](#azt_managerapproved) | read |
| [processid](#processid) | access |
| [statuscode](#statuscode) | UI |

`getCanApprove`:

| Field | Operations |
|-------|-----------|
| [azt_managerapproved](#azt_managerapproved) | UI |
| [azt_reject](#azt_reject) | UI |
| [statuscode](#statuscode) | UI |

`getManager`:

| Field | Operations |
|-------|-----------|
| [azt_datemanagerapproved](#azt_datemanagerapproved) | UI |
| [azt_managerapproved](#azt_managerapproved) | UI |
| [azt_submitted](#azt_submitted) | read |

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_approvingmanagerid](#azt_approvingmanagerid) | UI |
| [azt_corporateapproved](#azt_corporateapproved) | UI |
| [azt_datemanagerapproved](#azt_datemanagerapproved) | UI |
| [azt_ispaid](#azt_ispaid) | UI |
| [azt_managerapproved](#azt_managerapproved) | UI |
| [azt_submitted](#azt_submitted) | UI |
| [statuscode](#statuscode) | read, UI |

`reject`:

| Field | Operations |
|-------|-----------|
| [azt_reject](#azt_reject) | read, write |
| [azt_submitted](#azt_submitted) | write |
| [statuscode](#statuscode) | write |

`setManagerApproval`:

| Field | Operations |
|-------|-----------|
| [azt_approvingmanagerid](#azt_approvingmanagerid) | UI |
| [azt_datemanagerapproved](#azt_datemanagerapproved) | write, UI |
| [azt_managerapproved](#azt_managerapproved) | read |
| [azt_submittedbyid](#azt_submittedbyid) | read |
| [processid](#processid) | access |
| [statuscode](#statuscode) | UI |

`setPaid`:

| Field | Operations |
|-------|-----------|
| [azt_datepaid](#azt_datepaid) | write, UI |
| [azt_ispaid](#azt_ispaid) | UI |
| [azt_paidbyid](#azt_paidbyid) | UI |
| [processid](#processid) | access |
| [statuscode](#statuscode) | UI |

`submit`:

| Field | Operations |
|-------|-----------|
| [azt_datesubmitted](#azt_datesubmitted) | write |
| [azt_submitted](#azt_submitted) | write, UI |
| [azt_submittedbyid](#azt_submittedbyid) | write |
| [processid](#processid) | access |
| [statuscode](#statuscode) | write |

### 8.3. azt_leadlibrary

- **File:** `azt_leadlibraryD08FB550-34A2-EB11-B1AC-002248093E98`

**Per-Function Field Usage:**

`onSave`:

| Field | Operations |
|-------|-----------|
| [ownerid](#ownerid) | read |

### 8.4. azt_paymentlibrary

- **File:** `azt_paymentlibraryAFF0AF64-AC0E-E911-A976-000D3A1A941E`

**Per-Function Field Usage:**

`setName`:

| Field | Operations |
|-------|-----------|
| [azt_name](#azt_name) | write |

### 8.5. azt_productdiscountlibrary

- **File:** `azt_productdiscountlibraryBF6468B0-3230-E911-A950-000D3A3B9CD8`

**Per-Function Field Usage:**

`setName`:

| Field | Operations |
|-------|-----------|
| [azt_name](#azt_name) | write |

### 8.6. azt_splitallocation

- **File:** `azt_splitallocationA4ECB1A9-9B65-EB11-A812-00224805B3DD`

**Per-Function Field Usage:**

`splitAllocation`:

| Field | Operations |
|-------|-----------|
| [azt_name](#azt_name) | read |

---

## 9. Formulas and Rollups

Total formulas for Azt_expensereport: **0**

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

Total relationships involving Azt_expensereport: **20**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| TransactionCurrency_azt_expensereport | N:1 | TransactionCurrency | azt_expensereport | [TransactionCurrencyId](#TransactionCurrencyId) |
| azt_azt_expensereport_azt_expense | 1:N | azt_expensereport | azt_expense | [azt_ExpenseReportId](#azt_ExpenseReportId) |
| azt_corporate_azt_expensereport | N:1 | SystemUser | azt_expensereport | [azt_ApprovingCorporateManagerId](#azt_ApprovingCorporateManagerId) |
| azt_expensereport_ActivityPointers | 1:N | azt_expensereport | ActivityPointer | [RegardingObjectId](#RegardingObjectId) |
| azt_expensereport_Annotations | 1:N | azt_expensereport | Annotation | [ObjectId](#ObjectId) |
| azt_expensereport_Appointments | 1:N | azt_expensereport | Appointment | [RegardingObjectId](#RegardingObjectId) |
| azt_expensereport_Emails | 1:N | azt_expensereport | Email | [RegardingObjectId](#RegardingObjectId) |
| azt_expensereport_Letters | 1:N | azt_expensereport | Letter | [RegardingObjectId](#RegardingObjectId) |
| azt_expensereport_PhoneCalls | 1:N | azt_expensereport | PhoneCall | [RegardingObjectId](#RegardingObjectId) |
| azt_expensereport_Tasks | 1:N | azt_expensereport | Task | [RegardingObjectId](#RegardingObjectId) |
| azt_manager_azt_expensereport | N:1 | SystemUser | azt_expensereport | [azt_ApprovingManagerId](#azt_ApprovingManagerId) |
| azt_paidby_azt_expensereport | N:1 | SystemUser | azt_expensereport | [azt_PaidById](#azt_PaidById) |
| azt_systemuser_azt_expensereport | N:1 | SystemUser | azt_expensereport | [azt_SubmittedById](#azt_SubmittedById) |
| bpf_azt_expensereport_azt_expenseapprovalprocess | 1:N | azt_expensereport | azt_expenseapprovalprocess | [bpf_azt_expensereportid](#bpf_azt_expensereportid) |
| business_unit_azt_expensereport | N:1 | BusinessUnit | azt_expensereport | [OwningBusinessUnit](#OwningBusinessUnit) |
| lk_azt_expensereport_createdby | N:1 | SystemUser | azt_expensereport | [CreatedBy](#CreatedBy) |
| lk_azt_expensereport_modifiedby | N:1 | SystemUser | azt_expensereport | [ModifiedBy](#ModifiedBy) |
| owner_azt_expensereport | N:1 | Owner | azt_expensereport | [OwnerId](#OwnerId) |
| team_azt_expensereport | N:1 | Team | azt_expensereport | [OwningTeam](#OwningTeam) |
| user_azt_expensereport | N:1 | SystemUser | azt_expensereport | [OwningUser](#OwningUser) |

---

## 13. Ribbon Customizations

### Custom Buttons

| Button Label | Location | Command |
|-------------|----------|---------|
| Duplicate Expense | Mscrm.Form.azt_expensereport.MainTab.Save.Controls._children | `azt.azt_expensereport.Command0.CloneExpenseLine` |

### Command Definitions

| Command ID | JavaScript Function | Library |
|-----------|-------------------|---------|
| `azt.azt_expensereport.Command0.CloneExpenseLine` | `E.ExpenseReportFunctions.cloneLine` | `azt_expensereportlibrary` |

---

## 14. Conflicts and Observations

### 14.1 Per-Form Conflicts

Fields with inconsistent settings across forms: **1**

| Field | Issue | Forms |
|-------|-------|-------|
| [statuscode](#statuscode) | Disabled state | Information (card), Expense Report (main) |

### 14.2 Global Observations

**Fields in code but not on any form (300):**

- [!process_custom_attribute_url_](#%21process_custom_attribute_url_)
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
- [azt_defaultfreightamount](#azt_defaultfreightamount)
- [azt_description](#azt_description)
- [azt_discountamount](#azt_discountamount)
- [azt_discretionarydiscountamt](#azt_discretionarydiscountamt)
- [azt_duedate](#azt_duedate)
- [azt_effectivedate](#azt_effectivedate)
- [azt_email](#azt_email)
- [azt_engagementid](#azt_engagementid)
- [azt_estfulfillmentdate](#azt_estfulfillmentdate)
- [azt_evaluate](#azt_evaluate)
- [azt_expenseamount](#azt_expenseamount)
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
- [azt_recordownerid](#azt_recordownerid)
- [azt_replacementproductid](#azt_replacementproductid)
- [azt_requestedfreightamt](#azt_requestedfreightamt)
- [azt_resolvedbyid](#azt_resolvedbyid)
- [azt_result](#azt_result)
- [azt_saas](#azt_saas)
- [azt_saasstatus](#azt_saasstatus)
- [azt_salesrepid](#azt_salesrepid)
- [azt_softwarelicenseid](#azt_softwarelicenseid)
- [azt_softwareproductid](#azt_softwareproductid)
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
- [crm3_expenseamount](#crm3_expenseamount)
- [crm3_parentleadid](#crm3_parentleadid)
- [customerid](#customerid)
- [datefulfilled](#datefulfilled)
- [defaultuomid](#defaultuomid)
- [description](#description)
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
- [modifiedby](#modifiedby)
- [modifiedon](#modifiedon)
- [name](#name)
- [objectid](#objectid)
- [objecttypecode](#objecttypecode)
- [opportunityid](#opportunityid)
- [opportunityproductid](#opportunityproductid)
- [originatingleadid](#originatingleadid)
- [owningteam](#owningteam)
- [parentaccountid](#parentaccountid)
- [parentcontactid](#parentcontactid)
- [parentcustomerid](#parentcustomerid)
- [parentgoalid](#parentgoalid)
- [parentsystemuserid](#parentsystemuserid)
- [partyid](#partyid)
- [phonenumber](#phonenumber)
- [pricelevelid](#pricelevelid)
- [priceperunit](#priceperunit)
- [primarycontactid](#primarycontactid)
- [processid](#processid)
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
- [uomid](#uomid)
- [{0}](#%7B0%7D)

---

## Index

Alphabetical field index -- 347 unique fields referenced.

#### !process_custom_attribute_url_

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: ExpenseNotificationManager (Read)](#7.28.%20ExpenseNotificationManager)
- [Workflow: ExpenseReportRejectedNotification (Read)](#7.29.%20ExpenseReportRejectedNotification)

#### accountid

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

- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: AutoAssignStateAbb (Read)](#10.12.%20AutoAssignStateAbb)
- [Plugin: AutoAssignStateAbb (Write)](#10.12.%20AutoAssignStateAbb)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### address1_telephone1

- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### adx_resolutiondate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### amountdatatype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### annotationid

- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### associatedconnectionroleid

- [Plugin: ContactSetConnectionRole (Join)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Join)](#10.75.%20SetPrimaryContact)

#### azt_account

- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)

#### azt_accountid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Filter)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: ActivityRegardingGetState (Read)](#10.9.%20ActivityRegardingGetState)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)

#### azt_accountleadgenerationid

- [Plugin: AccountLeadGen (Filter)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGenAssociate (Read)](#10.3.%20AccountLeadGenAssociate)
- [Plugin: AccountLeadGenAssociate (Filter)](#10.3.%20AccountLeadGenAssociate)

#### azt_accountleadgenname

- [Plugin: AccountLeadGenAssociate (Write)](#10.3.%20AccountLeadGenAssociate)

#### azt_accounttype

- [Plugin: AccountTypeSet (Write)](#10.5.%20AccountTypeSet)

#### azt_addresssearch

- [Plugin: AddressSearchCleanupFields (Read)](#10.10.%20AddressSearchCleanupFields)
- [Plugin: AddressSearchCleanupFields (Write)](#10.10.%20AddressSearchCleanupFields)

#### azt_addresssearch2

- [Plugin: AddressSearchCleanupFields (Read)](#10.10.%20AddressSearchCleanupFields)
- [Plugin: AddressSearchCleanupFields (Write)](#10.10.%20AddressSearchCleanupFields)

#### azt_addtocrtqueue

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_ageendedstage

- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_allocatedtoid

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

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

#### azt_approvingcorporatemanagerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Corporate Approval](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [JS: azt_expensereportlibrary > corporateApprove()](#8.2.%20azt_expensereportlibrary)
- [Relationship: azt_corporate_azt_expensereport](#12.%20Relationships)

#### azt_approvingmanagerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Manager Approval](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [JS: azt_expensereportlibrary > onLoad()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setManagerApproval()](#8.2.%20azt_expensereportlibrary)
- [Relationship: azt_manager_azt_expensereport](#12.%20Relationships)

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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_concurrentusers

- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_copydescription

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_copysubject

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### azt_corporateapproved

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Corporate Approval](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [JS: azt_expensereportlibrary > corporateApprove()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > onLoad()](#8.2.%20azt_expensereportlibrary)

#### azt_currentnumber

- [Plugin: AutoNumber (Read)](#10.13.%20AutoNumber)
- [Plugin: AutoNumber (Write)](#10.13.%20AutoNumber)

#### azt_customerid

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_customertrainingid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)

#### azt_datecorporateapproved

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Corporate Approval](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [JS: azt_expensereportlibrary > corporateApprove()](#8.2.%20azt_expensereportlibrary)

#### azt_dateexitedstage

- [Plugin: OrderStageTracking (Write)](#10.57.%20OrderStageTracking)

#### azt_datemanagerapproved

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Manager Approval](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [JS: azt_expensereportlibrary > getManager()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > onLoad()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setManagerApproval()](#8.2.%20azt_expensereportlibrary)

#### azt_datepaid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Paid](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [JS: azt_expensereportlibrary > setPaid()](#8.2.%20azt_expensereportlibrary)

#### azt_datesubmitted

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > General > Submittal](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Report Pending Corporate Approval (Sort)](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: My Expense Reports](#3.12.%20My%20Expense%20Reports)
- [View: My Expense Reports (Sort)](#3.12.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: My Pending Expense Reports (Sort)](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [View: Quick Find Active Expense Reports (Sort)](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [JS: azt_expensereportlibrary > submit()](#8.2.%20azt_expensereportlibrary)

#### azt_defaultfreightamount

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

#### azt_description

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_discountamount

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)

#### azt_discretionarydiscountamt

- [Plugin: DiscretionaryDiscountSetHeader (Write)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: OpptyToQuoteFieldMappings (Write)](#10.50.%20OpptyToQuoteFieldMappings)

#### azt_duedate

- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### azt_effectivedate

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_email

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImportPopulateName (Read)](#10.37.%20LeadImportPopulateName)

#### azt_enddate

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > General > General](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
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

#### azt_expenseamount

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)

#### azt_expenseid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > General > General](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [View: Quick Find Active Expense Reports (Filter)](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Plugin: CloneExpenseLine (Filter)](#10.17.%20CloneExpenseLine)

#### azt_expensereportid

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Expense Reports](#3.1.%20Active%20Expense%20Reports)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: My Expense Reports](#3.11.%20My%20Expense%20Reports)
- [View: My Expense Reports](#3.12.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: ExpenseNotificationManager (Read)](#7.28.%20ExpenseNotificationManager)
- [Workflow: ExpenseReportRejectedNotification (Read)](#7.29.%20ExpenseReportRejectedNotification)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Filter)](#10.26.%20ExpenseLineTotals)
- [Relationship: azt_azt_expensereport_azt_expense](#12.%20Relationships)

#### azt_expensetype

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_expirationdate

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_extension

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

#### azt_freightamtapproved

- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#10.65.%20QuotePreventActivateUnapprovedFreight)

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

#### azt_goaltype

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

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

#### azt_isbn

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)

#### azt_iscompanion

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_ispaid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Paid](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: Expense Reports Pending Reimbursement (Filter)](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Paid Expense Reports (Filter)](#3.14.%20Paid%20Expense%20Reports)
- [JS: azt_expensereportlibrary > onLoad()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setPaid()](#8.2.%20azt_expensereportlibrary)

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

- [Plugin: OpportunityLastActivityDate (Write)](#10.45.%20OpportunityLastActivityDate)

#### azt_lastmodifiedbyid

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)

#### azt_lastname

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_leadimportid

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_leadsourceid

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### azt_licensestatus

- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_licenseterm

- [Field Definitions](#1.%20Field%20Definitions)
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

#### azt_managerapproved

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Manager Approval](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: My Expense Reports](#3.12.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
- [JS: azt_expensereportlibrary > corporateApprove()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > getCanApprove()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > getManager()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > onLoad()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setManagerApproval()](#8.2.%20azt_expensereportlibrary)

#### azt_masecommission

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Filter)](#10.35.%20InvoiceCompCompleted)

#### azt_mileage

- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)

#### azt_monthstofilteron

- [Plugin: AccountLeadGen (Read)](#10.2.%20AccountLeadGen)
- [Plugin: AccountLeadGen (Image)](#10.2.%20AccountLeadGen)

#### azt_name

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Information > general > Details](#2.1.%20Information%20-%20card%20-%20Active)
- [Form: Expense Report > General > General](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [Form: Information >  > GENERAL](#2.3.%20Information%20-%20quick%20-%20Active)
- [View: Active Expense Reports](#3.1.%20Active%20Expense%20Reports)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: All Expense Reports (Sort)](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Advanced Find View (Sort)](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Associated View (Sort)](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Lookup View (Sort)](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: Inactive Expense Reports (Sort)](#3.10.%20Inactive%20Expense%20Reports)
- [View: My Expense Reports](#3.12.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [View: Quick Find Active Expense Reports (Filter)](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: 0EngagementNames (Write)](#7.1.%200EngagementNames)
- [Workflow: BatchCreateEngagements (Write)](#7.6.%20BatchCreateEngagements)
- [Workflow: CloneCommissionPayment (Write)](#7.14.%20CloneCommissionPayment)
- [Workflow: CloneCompGoal (Read)](#7.15.%20CloneCompGoal)
- [Workflow: CloneLicense (Read)](#7.16.%20CloneLicense)
- [Workflow: CreateSoftwareLicense (Write)](#7.22.%20CreateSoftwareLicense)
- [Workflow: Order-CreateOrderStageTracking (Write)](#7.37.%20Order-CreateOrderStageTracking)
- [Workflow: RenameEngagements (Read)](#7.43.%20RenameEngagements)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#7.45.%20SoftwareLicenseCreateEngagement)
- [JS: azt_engagementlibrary > onLoad()](#8.1.%20azt_engagementlibrary)
- [JS: azt_paymentlibrary > setName()](#8.4.%20azt_paymentlibrary)
- [JS: azt_productdiscountlibrary > setName()](#8.5.%20azt_productdiscountlibrary)
- [JS: azt_splitallocation > splitAllocation()](#8.6.%20azt_splitallocation)
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

#### azt_nonsaasstatus

- [Plugin: AccountTypeSet (Read)](#10.5.%20AccountTypeSet)
- [Plugin: AccountTypeSet (Image)](#10.5.%20AccountTypeSet)

#### azt_nonsaastype

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)

#### azt_numberoflicenses

- [Plugin: AllocationValidation (Read)](#10.11.%20AllocationValidation)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

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

#### azt_paidbyid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Approval Process > Paid](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [JS: azt_expensereportlibrary > setPaid()](#8.2.%20azt_expensereportlibrary)
- [Relationship: azt_paidby_azt_expensereport](#12.%20Relationships)

#### azt_paidon

- [Plugin: FundingSetAnnualSpend (Filter)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_parentopportunityid

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityAudit (Image)](#10.43.%20OpportunityAudit)

#### azt_parentorderid

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### azt_payablecommission

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
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

#### azt_recordowner

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)

#### azt_recordownerid

- [Plugin: ActivityCloseForceRecordOwner (Read)](#10.8.%20ActivityCloseForceRecordOwner)
- [Plugin: CreateCompGoals (Read)](#10.20.%20CreateCompGoals)
- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateSoftwareLicenses (Image)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: RecordOwnerRestrictEdit (Read)](#10.67.%20RecordOwnerRestrictEdit)

#### azt_reject

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > General > Submittal](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [Workflow: ExpenseReportRejectedNotification (Read)](#7.29.%20ExpenseReportRejectedNotification)
- [Workflow: ExpenseReportRejectedNotification (Write)](#7.29.%20ExpenseReportRejectedNotification)
- [JS: azt_expensereportlibrary > getCanApprove()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > reject()](#8.2.%20azt_expensereportlibrary)

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

- [Plugin: AccountTypeSet (Read)](#10.5.%20AccountTypeSet)
- [Plugin: AccountTypeSet (Image)](#10.5.%20AccountTypeSet)

#### azt_salesrepid

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)
- [Plugin: InvoiceCompCompleted (Sort)](#10.35.%20InvoiceCompCompleted)

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

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > General > General](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: BatchCreateEngagements (Write)](#7.6.%20BatchCreateEngagements)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#7.45.%20SoftwareLicenseCreateEngagement)
- [Plugin: CreateSoftwareLicenses (Write)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: OrderManuallyCreateSoftwareLicense (Write)](#10.55.%20OrderManuallyCreateSoftwareLicense)

#### azt_stateabbreviation

- [Plugin: AccountAutoAssign (Filter)](#10.1.%20AccountAutoAssign)

#### azt_stateprovince

- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)

#### azt_submitted

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > General > Submittal](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: ExpenseNotificationManager (Read)](#7.28.%20ExpenseNotificationManager)
- [JS: azt_expensereportlibrary > getManager()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > onLoad()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > reject()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > submit()](#8.2.%20azt_expensereportlibrary)

#### azt_submittedbyid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > General > Submittal](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Draft Expense Reports (Sort)](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Manager Approval (Sort)](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Expense Reports Pending Reimbursement (Sort)](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Paid Expense Reports (Sort)](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [View: Quick Find Active Expense Reports (Filter)](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [View: Quick Find Active Expense Reports (Sort)](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: ExpenseReportRejectedNotification (Read)](#7.29.%20ExpenseReportRejectedNotification)
- [JS: azt_expensereportlibrary > setManagerApproval()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > submit()](#8.2.%20azt_expensereportlibrary)
- [Relationship: azt_systemuser_azt_expensereport](#12.%20Relationships)

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

#### azt_total

- [Plugin: CreateCompGoals (Write)](#10.20.%20CreateCompGoals)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: InvoiceCompCompleted (Read)](#10.35.%20InvoiceCompCompleted)

#### azt_totalamountpaid

- [Plugin: Utility (Write)](#10.81.%20Utility)

#### azt_totalfunding

- [Plugin: FundingTotalAmt (Write)](#10.29.%20FundingTotalAmt)

#### azt_totalreimbursement

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report (Header)](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [Form: Expense Report > General > General](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: Active Expense Reports](#3.1.%20Active%20Expense%20Reports)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: My Expense Reports](#3.12.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)

#### azt_totalreimbursement_base

- [Field Definitions](#1.%20Field%20Definitions)

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

#### azt_year

- [Plugin: FundingYearSync (Write)](#10.30.%20FundingYearSync)

#### baseamount

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#10.72.%20ReviseQuoteDiscountMove)
- [Plugin: UpdateOppFromQuote (Write)](#10.80.%20UpdateOppFromQuote)

#### billto_line1

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_line2

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_line3

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_name

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_postalcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### billto_stateorprovince

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### body

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### bpf_azt_expensereportid

- [Relationship: bpf_azt_expensereport_azt_expenseapprovalprocess](#12.%20Relationships)

#### bpf_duration

- [Plugin: OrderStageTracking (Read)](#10.57.%20OrderStageTracking)

#### bpf_salesorderid

- [Plugin: OrderStageTracking (Filter)](#10.57.%20OrderStageTracking)

#### businessprocessflowinstanceid

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ContactSetConnectionRole (Sort)](#10.19.%20ContactSetConnectionRole)
- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Sort)](#10.75.%20SetPrimaryContact)

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

#### consideronlygoalownersrecords

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### contactid

- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Write)](#10.26.%20ExpenseLineTotals)
- [Plugin: LeadImport (Read)](#10.36.%20LeadImport)
- [Plugin: LeadQualifyParentStakeholderContacts (Write)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)

#### country

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### county

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### createdby

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report (Header)](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [Workflow: AccountAuto-Assign (Read)](#7.2.%20AccountAuto-Assign)
- [Workflow: CasePendingAssignmentNotification (Read)](#7.8.%20CasePendingAssignmentNotification)
- [Workflow: CaseRecordOwnerAssign (Read)](#7.10.%20CaseRecordOwnerAssign)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#7.11.%20CaseRecordOwnerAssignmentNotification)
- [Workflow: CaseResolutionNotificationEmail (Write)](#7.12.%20CaseResolutionNotificationEmail)
- [Workflow: ContactAuto-Assign (Read)](#7.19.%20ContactAuto-Assign)
- [Workflow: EngagementRecordOwner (Read)](#7.27.%20EngagementRecordOwner)
- [Workflow: FSRLeadDistibutionNotification (Read)](#7.30.%20FSRLeadDistibutionNotification)
- [Workflow: LeadAssignment (Read)](#7.32.%20LeadAssignment)
- [Workflow: NewFSRLeadNotification (Write)](#7.34.%20NewFSRLeadNotification)
- [Workflow: PhonecallAuto-Assign (Read)](#7.39.%20PhonecallAuto-Assign)
- [Workflow: QuoteRecordOwner (Read)](#7.42.%20QuoteRecordOwner)
- [Workflow: TaskAuto-Assign (Read)](#7.47.%20TaskAuto-Assign)
- [Workflow: WorkforceAccountAuto-assign (Read)](#7.50.%20WorkforceAccountAuto-assign)
- [Workflow: WorkforceAppointmentAuto-Assign (Read)](#7.51.%20WorkforceAppointmentAuto-Assign)
- [Workflow: WorkforceCaseAuto-assign (Read)](#7.52.%20WorkforceCaseAuto-assign)
- [Workflow: WorkforceContactAuto-assign (Read)](#7.53.%20WorkforceContactAuto-assign)
- [Workflow: WorkforceEngagementAuto-assign (Read)](#7.54.%20WorkforceEngagementAuto-assign)
- [Workflow: WorkforceLeadAuto-Assign (Read)](#7.55.%20WorkforceLeadAuto-Assign)
- [Workflow: WorkforceOpportunityAuto-assign (Read)](#7.56.%20WorkforceOpportunityAuto-assign)
- [Workflow: WorkforcePhone-callAuto-assign (Read)](#7.57.%20WorkforcePhone-callAuto-assign)
- [Workflow: WorkforceQuoteAuto-assign (Read)](#7.58.%20WorkforceQuoteAuto-assign)
- [Workflow: iGradAppointmentAuto-Assign (Read)](#7.59.%20iGradAppointmentAuto-Assign)
- [Workflow: iGradCaseAuto-Assign (Read)](#7.60.%20iGradCaseAuto-Assign)
- [Workflow: iGradPhone-callAuto-assign (Read)](#7.61.%20iGradPhone-callAuto-assign)
- [Relationship: lk_azt_expensereport_createdby](#12.%20Relationships)

#### createdon

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Information > general > Footer](#2.1.%20Information%20-%20card%20-%20Active)
- [View: Active Expense Reports](#3.1.%20Active%20Expense%20Reports)
- [View: Active Expense Reports (Sort)](#3.1.%20Active%20Expense%20Reports)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Draft Expense Reports (Sort)](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Manager Approval (Sort)](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Expense Reports Pending Reimbursement (Sort)](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: My Expense Reports](#3.12.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Paid Expense Reports (Sort)](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: CasePendingAssignmentNotification (Read)](#7.8.%20CasePendingAssignmentNotification)
- [Workflow: CaseRecordOwnerAssignmentNotification (Read)](#7.11.%20CaseRecordOwnerAssignmentNotification)
- [Workflow: EffectiveTo (Read)](#7.24.%20EffectiveTo)
- [Workflow: EmailDeleteSendQuoteDrafts (Read)](#7.25.%20EmailDeleteSendQuoteDrafts)
- [Workflow: EmailRemoveUnsentEmails (Read)](#7.26.%20EmailRemoveUnsentEmails)
- [Workflow: FSRLeadDistibutionNotification (Read)](#7.30.%20FSRLeadDistibutionNotification)
- [Workflow: NewFSRLeadNotification (Read)](#7.34.%20NewFSRLeadNotification)
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

#### createdonbehalfby

- [Field Definitions](#1.%20Field%20Definitions)

#### crm3_expenseamount

- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)

#### crm3_parentleadid

- [Plugin: ExpenseLineTotals (Read)](#10.26.%20ExpenseLineTotals)
- [Plugin: ExpenseLineTotals (Filter)](#10.26.%20ExpenseLineTotals)

#### customerid

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

#### datefulfilled

- [Field Definitions](#1.%20Field%20Definitions)
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
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#10.72.%20ReviseQuoteDiscountMove)

#### discountpercentage

- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)

#### emailaddress1

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: LeadImport (Filter)](#10.36.%20LeadImport)

#### estimatedclosedate

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityClone (Write)](#10.44.%20OpportunityClone)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)

#### estimatedvalue

- [Plugin: OpportunityAudit (Read)](#10.43.%20OpportunityAudit)
- [Plugin: OpportunityLastActivityDate (Read)](#10.45.%20OpportunityLastActivityDate)

#### exchangerate

- [Field Definitions](#1.%20Field%20Definitions)

#### expenses

- [Form: Expense Report > General > Expenses](#2.2.%20Expense%20Report%20-%20main%20-%20Active)

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

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### fiscalperiod

- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)

#### freightamount

- [Plugin: QuoteSyncTotalToOpportunity (Read)](#10.66.%20QuoteSyncTotalToOpportunity)

#### freighttermscode

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### from

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### fullname

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

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### goalownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### goalrollupqueryid

- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)

#### goalstartdate

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Read)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Filter)](#10.22.%20CreateUserGoals)

#### importsequencenumber

- [Field Definitions](#1.%20Field%20Definitions)

#### incidentid

- [Plugin: AccountReassignmentShareRecords (Read)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: CaseClose (Write)](#10.15.%20CaseClose)

#### internalemailaddress

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Plugin: QuoteSyncTotalToOpportunity (Write)](#10.66.%20QuoteSyncTotalToOpportunity)

#### jobtitle

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### lastname

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### manualdiscountamount

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)

#### mimetype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

#### mobilephone

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#10.52.%20OrderFSRSetTemplateFields)

#### modifiedby

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: LeadQualifyDisqualifyDate (Read)](#7.33.%20LeadQualifyDisqualifyDate)
- [Workflow: Order-CreateOrderStageTracking (Write)](#7.37.%20Order-CreateOrderStageTracking)
- [Relationship: lk_azt_expensereport_modifiedby](#12.%20Relationships)

#### modifiedon

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountReassignmentShareRecords (Sort)](#10.4.%20AccountReassignmentShareRecords)
- [Plugin: OpportunityLineSyncToQuote (Sort)](#10.46.%20OpportunityLineSyncToQuote)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)
- [Plugin: UpdateOppFromQuote (Sort)](#10.80.%20UpdateOppFromQuote)

#### modifiedonbehalfby

- [Field Definitions](#1.%20Field%20Definitions)

#### name

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

#### notescontrol

- [Form: Expense Report > Notes > Notes](#2.2.%20Expense%20Report%20-%20main%20-%20Active)

#### objectid

- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Filter)](#10.59.%20PhonecallCreateCallback)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)
- [Plugin: ShareWithAccountOwner (Read)](#10.78.%20ShareWithAccountOwner)
- [Relationship: azt_expensereport_Annotations](#12.%20Relationships)

#### objecttypecode

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: SendQuoteReport (Write)](#10.73.%20SendQuoteReport)

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

#### originatingleadid

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#10.39.%20LeadQualifyParentStakeholderContacts)
- [Plugin: OpportunityAssignFromLead (Read)](#10.42.%20OpportunityAssignFromLead)

#### overriddencreatedon

- [Field Definitions](#1.%20Field%20Definitions)

#### ownerid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Information > general > Footer](#2.1.%20Information%20-%20card%20-%20Active)
- [Form: Expense Report (Header)](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [Form: Expense Report > Administration > Section](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [Form: Information >  > GENERAL](#2.3.%20Information%20-%20quick%20-%20Active)
- [View: Active Expense Reports](#3.1.%20Active%20Expense%20Reports)
- [View: Active Expense Reports (Sort)](#3.1.%20Active%20Expense%20Reports)
- [View: My Expense Reports (Filter)](#3.11.%20My%20Expense%20Reports)
- [View: My Expense Reports (Filter)](#3.12.%20My%20Expense%20Reports)
- [Workflow: AllocationsAssigntoTeam (Read)](#7.3.%20AllocationsAssigntoTeam)
- [Workflow: AppointmentAuto-Assign (Read)](#7.4.%20AppointmentAuto-Assign)
- [Workflow: BatchConverttoLead (Write)](#7.5.%20BatchConverttoLead)
- [Workflow: CasePendingAssignmentNotification (Read)](#7.8.%20CasePendingAssignmentNotification)
- [Workflow: CaseRecordOwner (Read)](#7.9.%20CaseRecordOwner)
- [Workflow: CloneAndDeleteQuote (Write)](#7.13.%20CloneAndDeleteQuote)
- [Workflow: CloneCommissionPayment (Write)](#7.14.%20CloneCommissionPayment)
- [Workflow: CloneOpportunity (Write)](#7.17.%20CloneOpportunity)
- [Workflow: ContactAuto-Assign (Read)](#7.19.%20ContactAuto-Assign)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.20.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.21.%20CreateLeadfromAccount)
- [Workflow: EngagementRecordOwner (Read)](#7.27.%20EngagementRecordOwner)
- [Workflow: FSRLeadDistibutionNotification (Write)](#7.30.%20FSRLeadDistibutionNotification)
- [Workflow: InvoiceRecordOwner (Read)](#7.31.%20InvoiceRecordOwner)
- [Workflow: LeadAssignment (Read)](#7.32.%20LeadAssignment)
- [Workflow: OpportunityRecordOwner (Read)](#7.36.%20OpportunityRecordOwner)
- [Workflow: OrderRecordOwner (Read)](#7.38.%20OrderRecordOwner)
- [Workflow: PhonecallAuto-Assign (Read)](#7.39.%20PhonecallAuto-Assign)
- [Workflow: PrintPurchaseAssigntoTeam (Read)](#7.40.%20PrintPurchaseAssigntoTeam)
- [Workflow: QuoteRecordOwner (Read)](#7.42.%20QuoteRecordOwner)
- [Workflow: SoftwareLicenseAssigntoTeam (Read)](#7.44.%20SoftwareLicenseAssigntoTeam)
- [Workflow: SoftwareLicenseSetOwner (Read)](#7.46.%20SoftwareLicenseSetOwner)
- [Workflow: TaskAuto-Assign (Read)](#7.47.%20TaskAuto-Assign)
- [Workflow: TaskCreateReorderLead (Write)](#7.48.%20TaskCreateReorderLead)
- [JS: azt_leadlibrary > onSave()](#8.3.%20azt_leadlibrary)
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
- [Relationship: owner_azt_expensereport](#12.%20Relationships)

#### owningbusinessunit

- [Field Definitions](#1.%20Field%20Definitions)
- [Relationship: business_unit_azt_expensereport](#12.%20Relationships)

#### owningteam

- [Field Definitions](#1.%20Field%20Definitions)
- [Workflow: CaseRecordOwnerAssign (Read)](#7.10.%20CaseRecordOwnerAssign)
- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)
- [Relationship: team_azt_expensereport](#12.%20Relationships)

#### owninguser

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: GetAcctTeamOwned (Join)](#10.31.%20GetAcctTeamOwned)
- [Relationship: user_azt_expensereport](#12.%20Relationships)

#### parentaccountid

- [Plugin: DiscretionaryDiscountSetHeader (Read)](#10.23.%20DiscretionaryDiscountSetHeader)
- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)
- [Plugin: LeadQualify (Read)](#10.38.%20LeadQualify)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)

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

#### phonenumber

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### pricelevelid

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

- [Plugin: SetPrimaryContact (Read)](#10.75.%20SetPrimaryContact)
- [Plugin: SetPrimaryContact (Write)](#10.75.%20SetPrimaryContact)

#### processid

- [Field Definitions](#1.%20Field%20Definitions)
- [JS: azt_expensereportlibrary > corporateApprove()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setManagerApproval()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setPaid()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > submit()](#8.2.%20azt_expensereportlibrary)

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

- [Plugin: CreateSoftwareLicenses (Read)](#10.21.%20CreateSoftwareLicenses)
- [Plugin: RestrictProductLookups (Filter)](#10.69.%20RestrictProductLookups)
- [Plugin: Utility (Filter)](#10.81.%20Utility)

#### producttypecode

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)

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

- [Field Definitions](#1.%20Field%20Definitions)
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

#### record1id

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
- [Relationship: azt_expensereport_ActivityPointers](#12.%20Relationships)
- [Relationship: azt_expensereport_Appointments](#12.%20Relationships)
- [Relationship: azt_expensereport_Emails](#12.%20Relationships)
- [Relationship: azt_expensereport_Letters](#12.%20Relationships)
- [Relationship: azt_expensereport_PhoneCalls](#12.%20Relationships)
- [Relationship: azt_expensereport_Tasks](#12.%20Relationships)

#### requestdeliveryby

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### roleid

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

- [Field Definitions](#1.%20Field%20Definitions)
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

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)

#### scheduledend

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#10.7.%20ActivitiesCreatedDueDatesInPast)
- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)

#### shippingmethodcode

- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_line1

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_line2

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_line3

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_name

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_postalcode

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### shipto_stateorprovince

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)

#### stageid

- [Field Definitions](#1.%20Field%20Definitions)

#### state

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### statecode

- [Field Definitions](#1.%20Field%20Definitions)
- [View: Active Expense Reports (Filter)](#3.1.%20Active%20Expense%20Reports)
- [View: Draft Expense Reports (Filter)](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Associated View (Filter)](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View (Filter)](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval (Filter)](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval (Filter)](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement (Filter)](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports (Filter)](#3.10.%20Inactive%20Expense%20Reports)
- [View: My Expense Reports (Filter)](#3.11.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports (Filter)](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: Paid Expense Reports (Filter)](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports (Filter)](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: BatchConverttoLead (Write)](#7.5.%20BatchConverttoLead)
- [Workflow: CaseResolutionNotificationEmail (Read)](#7.12.%20CaseResolutionNotificationEmail)
- [Workflow: CloneOrder (Write)](#7.18.%20CloneOrder)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.20.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.21.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.23.%20CustomLeadCreation)
- [Workflow: LeadQualifyDisqualifyDate (Read)](#7.33.%20LeadQualifyDisqualifyDate)
- [Workflow: OpportunityAuditRemoval (Read)](#7.35.%20OpportunityAuditRemoval)
- [Workflow: TaskCreateReorderLead (Write)](#7.48.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Read)](#7.49.%20WonOpportunityEmail)
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
- [Form: Information > general > Header](#2.1.%20Information%20-%20card%20-%20Active)
- [Form: Expense Report > General > General](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [View: Active Expense Reports](#3.1.%20Active%20Expense%20Reports)
- [View: All Expense Reports](#3.2.%20All%20Expense%20Reports)
- [View: Draft Expense Reports](#3.3.%20Draft%20Expense%20Reports)
- [View: Draft Expense Reports (Filter)](#3.3.%20Draft%20Expense%20Reports)
- [View: Expense Report Advanced Find View](#3.4.%20Expense%20Report%20Advanced%20Find%20View)
- [View: Expense Report Associated View](#3.5.%20Expense%20Report%20Associated%20View)
- [View: Expense Report Lookup View](#3.6.%20Expense%20Report%20Lookup%20View)
- [View: Expense Report Pending Corporate Approval](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Report Pending Corporate Approval (Filter)](#3.7.%20Expense%20Report%20Pending%20Corporate%20Approval)
- [View: Expense Reports Pending Manager Approval](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Manager Approval (Filter)](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Manager Approval (Filter)](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Manager Approval (Filter)](#3.8.%20Expense%20Reports%20Pending%20Manager%20Approval)
- [View: Expense Reports Pending Reimbursement](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Expense Reports Pending Reimbursement (Filter)](#3.9.%20Expense%20Reports%20Pending%20Reimbursement)
- [View: Inactive Expense Reports](#3.10.%20Inactive%20Expense%20Reports)
- [View: My Expense Reports](#3.12.%20My%20Expense%20Reports)
- [View: My Pending Expense Reports](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: My Pending Expense Reports (Filter)](#3.13.%20My%20Pending%20Expense%20Reports)
- [View: Paid Expense Reports](#3.14.%20Paid%20Expense%20Reports)
- [View: Quick Find Active Expense Reports](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [View: Quick Find Active Expense Reports (Filter)](#3.15.%20Quick%20Find%20Active%20Expense%20Reports)
- [Workflow: BatchCreateEngagements (Write)](#7.6.%20BatchCreateEngagements)
- [Workflow: CloneOrder (Write)](#7.18.%20CloneOrder)
- [Workflow: EmailDeleteSendQuoteDrafts (Read)](#7.25.%20EmailDeleteSendQuoteDrafts)
- [Workflow: EmailRemoveUnsentEmails (Read)](#7.26.%20EmailRemoveUnsentEmails)
- [Workflow: SoftwareLicenseCreateEngagement (Write)](#7.45.%20SoftwareLicenseCreateEngagement)
- [JS: azt_expensereportlibrary > corporateApprove()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > getCanApprove()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > onLoad()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > reject()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setManagerApproval()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > setPaid()](#8.2.%20azt_expensereportlibrary)
- [JS: azt_expensereportlibrary > submit()](#8.2.%20azt_expensereportlibrary)
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

- [Plugin: AccountAutoAssign (Read)](#10.1.%20AccountAutoAssign)
- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareBasedOnAccessTeam (Join)](#10.76.%20ShareBasedOnAccessTeam)

#### teamtype

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: AccountAutoAssign (Filter)](#10.1.%20AccountAutoAssign)
- [Plugin: ShareBasedOnAccessTeam (Filter)](#10.76.%20ShareBasedOnAccessTeam)
- [Plugin: ShareFromAccountShares (Read)](#10.77.%20ShareFromAccountShares)

#### telephone1

- [Plugin: LeadImport (Write)](#10.36.%20LeadImport)

#### timezoneruleversionnumber

- [Field Definitions](#1.%20Field%20Definitions)

#### title

- [Field Definitions](#1.%20Field%20Definitions)
- [Plugin: CreateUserGoals (Write)](#10.22.%20CreateUserGoals)
- [Plugin: CreateUserGoals (Sort)](#10.22.%20CreateUserGoals)

#### tm.systemuserid

- [Plugin: ShareBasedOnAccessTeam (Read)](#10.76.%20ShareBasedOnAccessTeam)

#### to

- [Plugin: PhonecallCreateCallback (Read)](#10.59.%20PhonecallCreateCallback)
- [Plugin: PhonecallCreateCallback (Write)](#10.59.%20PhonecallCreateCallback)

#### totalamount

- [Plugin: FundingSetAnnualSpend (Read)](#10.28.%20FundingSetAnnualSpend)
- [Plugin: InvoiceClosePaidOnPercentage (Read)](#10.34.%20InvoiceClosePaidOnPercentage)
- [Plugin: PaymentUpdate (Read)](#10.58.%20PaymentUpdate)
- [Plugin: QuoteSyncTotalToOpportunity (Read)](#10.66.%20QuoteSyncTotalToOpportunity)

#### transactioncurrencyid

- [Field Definitions](#1.%20Field%20Definitions)
- [Form: Expense Report > Administration > Section](#2.2.%20Expense%20Report%20-%20main%20-%20Active)
- [Workflow: BatchConverttoLead (Write)](#7.5.%20BatchConverttoLead)
- [Workflow: BatchOpportunityTransfer (Write)](#7.7.%20BatchOpportunityTransfer)
- [Workflow: CasePendingAssignmentNotification (Write)](#7.8.%20CasePendingAssignmentNotification)
- [Workflow: CaseRecordOwnerAssignmentNotification (Write)](#7.11.%20CaseRecordOwnerAssignmentNotification)
- [Workflow: CaseResolutionNotificationEmail (Write)](#7.12.%20CaseResolutionNotificationEmail)
- [Workflow: CloneAndDeleteQuote (Write)](#7.13.%20CloneAndDeleteQuote)
- [Workflow: CloneCommissionPayment (Write)](#7.14.%20CloneCommissionPayment)
- [Workflow: CloneCompGoal (Write)](#7.15.%20CloneCompGoal)
- [Workflow: CloneOpportunity (Write)](#7.17.%20CloneOpportunity)
- [Workflow: CloneOrder (Write)](#7.18.%20CloneOrder)
- [Workflow: CreateLeadFromLeadGen (Write)](#7.20.%20CreateLeadFromLeadGen)
- [Workflow: CreateLeadfromAccount (Write)](#7.21.%20CreateLeadfromAccount)
- [Workflow: CustomLeadCreation (Write)](#7.23.%20CustomLeadCreation)
- [Workflow: ExpenseNotificationManager (Write)](#7.28.%20ExpenseNotificationManager)
- [Workflow: ExpenseReportRejectedNotification (Write)](#7.29.%20ExpenseReportRejectedNotification)
- [Workflow: FSRLeadDistibutionNotification (Write)](#7.30.%20FSRLeadDistibutionNotification)
- [Workflow: NewFSRLeadNotification (Write)](#7.34.%20NewFSRLeadNotification)
- [Workflow: QualifyLead (Write)](#7.41.%20QualifyLead)
- [Workflow: TaskCreateReorderLead (Write)](#7.48.%20TaskCreateReorderLead)
- [Workflow: WonOpportunityEmail (Write)](#7.49.%20WonOpportunityEmail)
- [Plugin: CloneExpenseLine (Read)](#10.17.%20CloneExpenseLine)
- [Plugin: CloneExpenseLine (Write)](#10.17.%20CloneExpenseLine)
- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: OrderSplit (Write)](#10.56.%20OrderSplit)
- [Plugin: Utility (Read)](#10.81.%20Utility)
- [Plugin: Utility (Write)](#10.81.%20Utility)
- [Relationship: TransactionCurrency_azt_expensereport](#12.%20Relationships)

#### traversedpath

- [Field Definitions](#1.%20Field%20Definitions)

#### uomid

- [Plugin: OpportunityClone (Read)](#10.44.%20OpportunityClone)
- [Plugin: OrderClone (Read)](#10.51.%20OrderClone)
- [Plugin: OrderSplit (Read)](#10.56.%20OrderSplit)
- [Plugin: QuoteCloneAndDelete (Read)](#10.61.%20QuoteCloneAndDelete)
- [Plugin: QuoteLinesSyncToOppty (Read)](#10.62.%20QuoteLinesSyncToOppty)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#10.64.%20QuotePreventActivateUnapprovedDiscounts)
- [Plugin: UpdateOppFromQuote (Read)](#10.80.%20UpdateOppFromQuote)

#### utcconversiontimezonecode

- [Field Definitions](#1.%20Field%20Definitions)

#### value

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### zipcode

- [PCF: Bing Address Autocomplete](#11.%20PCF%20Controls)

#### {0}

- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#10.23.%20DiscretionaryDiscountSetHeader)
