# Quote Field Usage Analysis
> Date: 2026-02-28

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

## <a id="1-field-definitions"></a>1. Field Definitions

Total fields: **357**

| # | Schema Name | Display Name | Type | Custom | Required | Source |
|---|-------------|-------------|------|--------|----------|--------|
| 1 | [accessteam](#index-accessteam) |  |  | No |  | Inferred from Usage |
| 2 | [accountid](#index-accountid) |  |  | No |  | Inferred from Usage |
| 3 | [activityid](#index-activityid) |  |  | No |  | Inferred from Usage |
| 4 | [activitytypecode](#index-activitytypecode) |  |  | No |  | Inferred from Usage |
| 5 | [actualclosedate](#index-actualclosedate) |  |  | No |  | Inferred from Usage |
| 6 | [address1_stateorprovince](#index-address1_stateorprovince) |  |  | No |  | Inferred from Usage |
| 7 | [address1_telephone1](#index-address1_telephone1) |  |  | No |  | Inferred from Usage |
| 8 | [address2_line1](#index-address2_line1) |  |  | No |  | Inferred from Usage |
| 9 | [adx_resolutiondate](#index-adx_resolutiondate) |  |  | No |  | Inferred from Usage |
| 10 | [amountdatatype](#index-amountdatatype) |  |  | No |  | Inferred from Usage |
| 11 | [annotationid](#index-annotationid) |  |  | No |  | Inferred from Usage |
| 12 | [azt_account](#index-azt_account) |  |  | Yes |  | Inferred from Usage |
| 13 | [azt_accountid](#index-azt_accountid) |  |  | Yes |  | Inferred from Usage |
| 14 | [azt_accountleadgenerationid](#index-azt_accountleadgenerationid) |  |  | Yes |  | Inferred from Usage |
| 15 | [azt_accountleadgenname](#index-azt_accountleadgenname) |  |  | Yes |  | Inferred from Usage |
| 16 | [azt_accounttype](#index-azt_accounttype) |  |  | Yes |  | Inferred from Usage |
| 17 | [azt_addresssearch](#index-azt_addresssearch) |  |  | Yes |  | Inferred from Usage |
| 18 | [azt_addresssearch2](#index-azt_addresssearch2) |  |  | Yes |  | Inferred from Usage |
| 19 | [azt_addtocrtqueue](#index-azt_addtocrtqueue) |  |  | Yes |  | Inferred from Usage |
| 20 | [azt_ageendedstage](#index-azt_ageendedstage) |  |  | Yes |  | Inferred from Usage |
| 21 | [azt_allocatedtoid](#index-azt_allocatedtoid) |  |  | Yes |  | Inferred from Usage |
| 22 | [azt_allocationtype](#index-azt_allocationtype) |  |  | Yes |  | Inferred from Usage |
| 23 | [azt_amount](#index-azt_amount) |  |  | Yes |  | Inferred from Usage |
| 24 | [azt_annualspend](#index-azt_annualspend) |  |  | Yes |  | Inferred from Usage |
| 25 | [azt_approvalstatus](#index-azt_approvalstatus) |  |  | Yes |  | Inferred from Usage |
| 26 | [azt_autocreatecallback](#index-azt_autocreatecallback) |  |  | Yes |  | Inferred from Usage |
| 27 | [azt_autonumberid](#index-azt_autonumberid) |  |  | Yes |  | Inferred from Usage |
| 28 | [azt_azteccustomerid](#index-azt_azteccustomerid) |  |  | Yes |  | Inferred from Usage |
| 29 | [azt_bookingurl](#index-azt_bookingurl) |  |  | Yes |  | Inferred from Usage |
| 30 | [azt_callbackin](#index-azt_callbackin) |  |  | Yes |  | Inferred from Usage |
| 31 | [azt_callbackon](#index-azt_callbackon) |  |  | Yes |  | Inferred from Usage |
| 32 | [azt_caseid](#index-azt_caseid) |  |  | Yes |  | Inferred from Usage |
| 33 | [azt_commissionamount](#index-azt_commissionamount) |  |  | Yes |  | Inferred from Usage |
| 34 | [azt_commissionid](#index-azt_commissionid) |  |  | Yes |  | Inferred from Usage |
| 35 | [azt_commissionpaymentid](#index-azt_commissionpaymentid) |  |  | Yes |  | Inferred from Usage |
| 36 | [azt_companyname](#index-azt_companyname) |  |  | Yes |  | Inferred from Usage |
| 37 | [azt_compcompleted](#index-azt_compcompleted) |  |  | Yes |  | Inferred from Usage |
| 38 | [azt_compgoalid](#index-azt_compgoalid) |  |  | Yes |  | Inferred from Usage |
| 39 | [azt_compgoaltypeid](#index-azt_compgoaltypeid) |  |  | Yes |  | Inferred from Usage |
| 40 | [azt_compplanamountid](#index-azt_compplanamountid) |  |  | Yes |  | Inferred from Usage |
| 41 | [azt_concurrentusers](#index-azt_concurrentusers) |  |  | Yes |  | Inferred from Usage |
| 42 | [azt_copydescription](#index-azt_copydescription) |  |  | Yes |  | Inferred from Usage |
| 43 | [azt_copysubject](#index-azt_copysubject) |  |  | Yes |  | Inferred from Usage |
| 44 | [azt_currentnumber](#index-azt_currentnumber) |  |  | Yes |  | Inferred from Usage |
| 45 | [azt_customerid](#index-azt_customerid) |  |  | Yes |  | Inferred from Usage |
| 46 | [azt_customertrainingid](#index-azt_customertrainingid) |  |  | Yes |  | Inferred from Usage |
| 47 | [azt_dateexitedstage](#index-azt_dateexitedstage) |  |  | Yes |  | Inferred from Usage |
| 48 | [azt_defaultfreightamount](#index-azt_defaultfreightamount) | Default Freight Amount | money | Yes | none | Solution Export |
| 49 | [azt_defaultfreightamount_base](#index-azt_defaultfreightamount_base) | Default Freight Amount (Base) | money | Yes | none | Solution Export |
| 50 | [azt_description](#index-azt_description) |  |  | Yes |  | Inferred from Usage |
| 51 | [azt_discountamount](#index-azt_discountamount) |  |  | Yes |  | Inferred from Usage |
| 52 | [azt_discretionarydiscount](#index-azt_discretionarydiscount) | Discretionary Discount | money | Yes | none | Solution Export |
| 53 | [azt_discretionarydiscount_base](#index-azt_discretionarydiscount_base) | Discretionary Discount (Base) | money | Yes | none | Solution Export |
| 54 | [azt_discretionarydiscountamt](#index-azt_discretionarydiscountamt) | Discretionary Discount Amt | money | Yes | none | Solution Export |
| 55 | [azt_discretionarydiscountamt_base](#index-azt_discretionarydiscountamt_base) | Discretionary Discount Amt (Base) | money | Yes | none | Solution Export |
| 56 | [azt_duedate](#index-azt_duedate) |  |  | Yes |  | Inferred from Usage |
| 57 | [azt_effectivedate](#index-azt_effectivedate) |  |  | Yes |  | Inferred from Usage |
| 58 | [azt_email](#index-azt_email) |  |  | Yes |  | Inferred from Usage |
| 59 | [azt_enddate](#index-azt_enddate) |  |  | Yes |  | Inferred from Usage |
| 60 | [azt_engagementid](#index-azt_engagementid) |  |  | Yes |  | Inferred from Usage |
| 61 | [azt_estfulfillmentdate](#index-azt_estfulfillmentdate) |  |  | Yes |  | Inferred from Usage |
| 62 | [azt_evaluate](#index-azt_evaluate) |  |  | Yes |  | Inferred from Usage |
| 63 | [azt_expenseamount](#index-azt_expenseamount) |  |  | Yes |  | Inferred from Usage |
| 64 | [azt_expenseid](#index-azt_expenseid) |  |  | Yes |  | Inferred from Usage |
| 65 | [azt_expensereportid](#index-azt_expensereportid) |  |  | Yes |  | Inferred from Usage |
| 66 | [azt_expensetype](#index-azt_expensetype) |  |  | Yes |  | Inferred from Usage |
| 67 | [azt_expirationdate](#index-azt_expirationdate) |  |  | Yes |  | Inferred from Usage |
| 68 | [azt_extension](#index-azt_extension) |  |  | Yes |  | Inferred from Usage |
| 69 | [azt_fieldtoautonumber](#index-azt_fieldtoautonumber) |  |  | Yes |  | Inferred from Usage |
| 70 | [azt_firstname](#index-azt_firstname) |  |  | Yes |  | Inferred from Usage |
| 71 | [azt_fiscalperiodend](#index-azt_fiscalperiodend) |  |  | Yes |  | Inferred from Usage |
| 72 | [azt_fiscalperiodstart](#index-azt_fiscalperiodstart) |  |  | Yes |  | Inferred from Usage |
| 73 | [azt_freightamtapproved](#index-azt_freightamtapproved) | Freight Amt Approved? | bit | Yes | none | Solution Export |
| 74 | [azt_fsrassignedon](#index-azt_fsrassignedon) |  |  | Yes |  | Inferred from Usage |
| 75 | [azt_fsremail](#index-azt_fsremail) |  |  | Yes |  | Inferred from Usage |
| 76 | [azt_fsrid](#index-azt_fsrid) |  |  | Yes |  | Inferred from Usage |
| 77 | [azt_fsrmobiletelephone](#index-azt_fsrmobiletelephone) |  |  | Yes |  | Inferred from Usage |
| 78 | [azt_fsrtelephone](#index-azt_fsrtelephone) |  |  | Yes |  | Inferred from Usage |
| 79 | [azt_fsrtelephoneextension](#index-azt_fsrtelephoneextension) |  |  | Yes |  | Inferred from Usage |
| 80 | [azt_fundingid](#index-azt_fundingid) |  |  | Yes |  | Inferred from Usage |
| 81 | [azt_fundingyear](#index-azt_fundingyear) |  |  | Yes |  | Inferred from Usage |
| 82 | [azt_goaltype](#index-azt_goaltype) |  |  | Yes |  | Inferred from Usage |
| 83 | [azt_historicalowner](#index-azt_historicalowner) | Historical Owner | nvarchar | Yes | none | Solution Export |
| 84 | [azt_importname](#index-azt_importname) |  |  | Yes |  | Inferred from Usage |
| 85 | [azt_invoiceid](#index-azt_invoiceid) |  |  | Yes |  | Inferred from Usage |
| 86 | [azt_invoiceproductid](#index-azt_invoiceproductid) |  |  | Yes |  | Inferred from Usage |
| 87 | [azt_isbn](#index-azt_isbn) |  |  | Yes |  | Inferred from Usage |
| 88 | [azt_iscompanion](#index-azt_iscompanion) |  |  | Yes |  | Inferred from Usage |
| 89 | [azt_isprint](#index-azt_isprint) |  |  | Yes |  | Inferred from Usage |
| 90 | [azt_issaas](#index-azt_issaas) |  |  | Yes |  | Inferred from Usage |
| 91 | [azt_jobrole](#index-azt_jobrole) |  |  | Yes |  | Inferred from Usage |
| 92 | [azt_jobtitle](#index-azt_jobtitle) |  |  | Yes |  | Inferred from Usage |
| 93 | [azt_lastactivitydate](#index-azt_lastactivitydate) |  |  | Yes |  | Inferred from Usage |
| 94 | [azt_lastmodifiedbyid](#index-azt_lastmodifiedbyid) |  |  | Yes |  | Inferred from Usage |
| 95 | [azt_lastname](#index-azt_lastname) |  |  | Yes |  | Inferred from Usage |
| 96 | [azt_leadimportid](#index-azt_leadimportid) |  |  | Yes |  | Inferred from Usage |
| 97 | [azt_leadsourceid](#index-azt_leadsourceid) |  |  | Yes |  | Inferred from Usage |
| 98 | [azt_licensestatus](#index-azt_licensestatus) |  |  | Yes |  | Inferred from Usage |
| 99 | [azt_licenseterm](#index-azt_licenseterm) |  |  | Yes |  | Inferred from Usage |
| 100 | [azt_licensetermmonths](#index-azt_licensetermmonths) |  |  | Yes |  | Inferred from Usage |
| 101 | [azt_licensetype](#index-azt_licensetype) |  |  | Yes |  | Inferred from Usage |
| 102 | [azt_masecommission](#index-azt_masecommission) |  |  | Yes |  | Inferred from Usage |
| 103 | [azt_mileage](#index-azt_mileage) |  |  | Yes |  | Inferred from Usage |
| 104 | [azt_monthstofilteron](#index-azt_monthstofilteron) |  |  | Yes |  | Inferred from Usage |
| 105 | [azt_name](#index-azt_name) |  |  | Yes |  | Inferred from Usage |
| 106 | [azt_newestclosedate](#index-azt_newestclosedate) |  |  | Yes |  | Inferred from Usage |
| 107 | [azt_newestimatedvalue](#index-azt_newestimatedvalue) |  |  | Yes |  | Inferred from Usage |
| 108 | [azt_newownerid](#index-azt_newownerid) |  |  | Yes |  | Inferred from Usage |
| 109 | [azt_newprobability](#index-azt_newprobability) |  |  | Yes |  | Inferred from Usage |
| 110 | [azt_nonsaasstatus](#index-azt_nonsaasstatus) |  |  | Yes |  | Inferred from Usage |
| 111 | [azt_nonsaastype](#index-azt_nonsaastype) |  |  | Yes |  | Inferred from Usage |
| 112 | [azt_numberoflicenses](#index-azt_numberoflicenses) |  |  | Yes |  | Inferred from Usage |
| 113 | [azt_opportunityauditrecordid](#index-azt_opportunityauditrecordid) |  |  | Yes |  | Inferred from Usage |
| 114 | [azt_opportunityid](#index-azt_opportunityid) |  |  | Yes |  | Inferred from Usage |
| 115 | [azt_opportunityproductid](#index-azt_opportunityproductid) |  |  | Yes |  | Inferred from Usage |
| 116 | [azt_orderid](#index-azt_orderid) |  |  | Yes |  | Inferred from Usage |
| 117 | [azt_orderlineid](#index-azt_orderlineid) |  |  | Yes |  | Inferred from Usage |
| 118 | [azt_orderproductid](#index-azt_orderproductid) |  |  | Yes |  | Inferred from Usage |
| 119 | [azt_orderstageid](#index-azt_orderstageid) |  |  | Yes |  | Inferred from Usage |
| 120 | [azt_ordertemplatelines](#index-azt_ordertemplatelines) |  |  | Yes |  | Inferred from Usage |
| 121 | [azt_ordertype](#index-azt_ordertype) |  |  | Yes |  | Inferred from Usage |
| 122 | [azt_originatingleadimportid](#index-azt_originatingleadimportid) |  |  | Yes |  | Inferred from Usage |
| 123 | [azt_paid](#index-azt_paid) |  |  | Yes |  | Inferred from Usage |
| 124 | [azt_paidon](#index-azt_paidon) |  |  | Yes |  | Inferred from Usage |
| 125 | [azt_parentopportunityid](#index-azt_parentopportunityid) |  |  | Yes |  | Inferred from Usage |
| 126 | [azt_parentorderid](#index-azt_parentorderid) |  |  | Yes |  | Inferred from Usage |
| 127 | [azt_payablecommission](#index-azt_payablecommission) |  |  | Yes |  | Inferred from Usage |
| 128 | [azt_paymentdate](#index-azt_paymentdate) |  |  | Yes |  | Inferred from Usage |
| 129 | [azt_paymentid](#index-azt_paymentid) |  |  | Yes |  | Inferred from Usage |
| 130 | [azt_percentage](#index-azt_percentage) |  |  | Yes |  | Inferred from Usage |
| 131 | [azt_percentagepaid](#index-azt_percentagepaid) |  |  | Yes |  | Inferred from Usage |
| 132 | [azt_periodend](#index-azt_periodend) |  |  | Yes |  | Inferred from Usage |
| 133 | [azt_periodstart](#index-azt_periodstart) |  |  | Yes |  | Inferred from Usage |
| 134 | [azt_phone](#index-azt_phone) |  |  | Yes |  | Inferred from Usage |
| 135 | [azt_ponumber](#index-azt_ponumber) | PO Number | nvarchar | Yes | none | Solution Export |
| 136 | [azt_prefix](#index-azt_prefix) |  |  | Yes |  | Inferred from Usage |
| 137 | [azt_prefixhasseparator](#index-azt_prefixhasseparator) |  |  | Yes |  | Inferred from Usage |
| 138 | [azt_prefixseparator](#index-azt_prefixseparator) |  |  | Yes |  | Inferred from Usage |
| 139 | [azt_prefixseparatorisspace](#index-azt_prefixseparatorisspace) |  |  | Yes |  | Inferred from Usage |
| 140 | [azt_previousestclosedate](#index-azt_previousestclosedate) |  |  | Yes |  | Inferred from Usage |
| 141 | [azt_previousestimatedvalue](#index-azt_previousestimatedvalue) |  |  | Yes |  | Inferred from Usage |
| 142 | [azt_previousownerid](#index-azt_previousownerid) |  |  | Yes |  | Inferred from Usage |
| 143 | [azt_previousprobability](#index-azt_previousprobability) |  |  | Yes |  | Inferred from Usage |
| 144 | [azt_printproductid](#index-azt_printproductid) |  |  | Yes |  | Inferred from Usage |
| 145 | [azt_printpurchaseid](#index-azt_printpurchaseid) |  |  | Yes |  | Inferred from Usage |
| 146 | [azt_probability](#index-azt_probability) |  |  | Yes |  | Inferred from Usage |
| 147 | [azt_probabilitychangedon](#index-azt_probabilitychangedon) |  |  | Yes |  | Inferred from Usage |
| 148 | [azt_probabilityincreased](#index-azt_probabilityincreased) |  |  | Yes |  | Inferred from Usage |
| 149 | [azt_productdiscountid](#index-azt_productdiscountid) |  |  | Yes |  | Inferred from Usage |
| 150 | [azt_producttype](#index-azt_producttype) |  |  | Yes |  | Inferred from Usage |
| 151 | [azt_purchasedate](#index-azt_purchasedate) |  |  | Yes |  | Inferred from Usage |
| 152 | [azt_quantity](#index-azt_quantity) |  |  | Yes |  | Inferred from Usage |
| 153 | [azt_quoteapproval](#index-azt_quoteapproval) | Quote Approval | picklist | Yes | none | Solution Export |
| 154 | [azt_quotedcontactid](#index-azt_quotedcontactid) | Quoted Contact | lookup | Yes | none | Solution Export |
| 155 | [azt_quotenumber](#index-azt_quotenumber) |  |  | Yes |  | Inferred from Usage |
| 156 | [azt_quoteproductid](#index-azt_quoteproductid) |  |  | Yes |  | Inferred from Usage |
| 157 | [azt_reasonforexpense](#index-azt_reasonforexpense) |  |  | Yes |  | Inferred from Usage |
| 158 | [azt_recapnotes](#index-azt_recapnotes) | Recap Notes | ntext | Yes | none | Solution Export |
| 159 | [azt_recapnotescannedoptions](#index-azt_recapnotescannedoptions) | Recap Notes (Canned Options) | picklist | Yes | none | Solution Export |
| 160 | [azt_recordowner](#index-azt_recordowner) |  |  | Yes |  | Inferred from Usage |
| 161 | [azt_recordownerid](#index-azt_recordownerid) | Record Owner | lookup | Yes | none | Solution Export |
| 162 | [azt_replacementproductid](#index-azt_replacementproductid) |  |  | Yes |  | Inferred from Usage |
| 163 | [azt_requestedfreightamt](#index-azt_requestedfreightamt) | Requested Freight Amt | money | Yes | none | Solution Export |
| 164 | [azt_requestedfreightamt_base](#index-azt_requestedfreightamt_base) | Requested Freight Amt (Base) | money | Yes | none | Solution Export |
| 165 | [azt_resolvedbyid](#index-azt_resolvedbyid) |  |  | Yes |  | Inferred from Usage |
| 166 | [azt_result](#index-azt_result) |  |  | Yes |  | Inferred from Usage |
| 167 | [azt_saas](#index-azt_saas) |  |  | Yes |  | Inferred from Usage |
| 168 | [azt_saasstatus](#index-azt_saasstatus) |  |  | Yes |  | Inferred from Usage |
| 169 | [azt_salesrepid](#index-azt_salesrepid) |  |  | Yes |  | Inferred from Usage |
| 170 | [azt_shippingcompany](#index-azt_shippingcompany) | Ship To Company | nvarchar | Yes | none | Solution Export |
| 171 | [azt_signedquotereceived](#index-azt_signedquotereceived) | Signed Quote Received? | bit | Yes | none | Solution Export |
| 172 | [azt_softwarelicenseid](#index-azt_softwarelicenseid) |  |  | Yes |  | Inferred from Usage |
| 173 | [azt_softwareproductid](#index-azt_softwareproductid) |  |  | Yes |  | Inferred from Usage |
| 174 | [azt_startdate](#index-azt_startdate) |  |  | Yes |  | Inferred from Usage |
| 175 | [azt_stateabbreviation](#index-azt_stateabbreviation) |  |  | Yes |  | Inferred from Usage |
| 176 | [azt_stateprovince](#index-azt_stateprovince) |  |  | Yes |  | Inferred from Usage |
| 177 | [azt_suffix](#index-azt_suffix) |  |  | Yes |  | Inferred from Usage |
| 178 | [azt_suffixhasseparator](#index-azt_suffixhasseparator) |  |  | Yes |  | Inferred from Usage |
| 179 | [azt_suffixseparator](#index-azt_suffixseparator) |  |  | Yes |  | Inferred from Usage |
| 180 | [azt_suffixseparatorisspace](#index-azt_suffixseparatorisspace) |  |  | Yes |  | Inferred from Usage |
| 181 | [azt_supportexpirationdate](#index-azt_supportexpirationdate) |  |  | Yes |  | Inferred from Usage |
| 182 | [azt_taxamount](#index-azt_taxamount) | Tax Amount | money | Yes | none | Solution Export |
| 183 | [azt_taxamount_base](#index-azt_taxamount_base) | Tax Amount (Base) | money | Yes | none | Solution Export |
| 184 | [azt_total](#index-azt_total) |  |  | Yes |  | Inferred from Usage |
| 185 | [azt_totalamountpaid](#index-azt_totalamountpaid) |  |  | Yes |  | Inferred from Usage |
| 186 | [azt_totalfunding](#index-azt_totalfunding) |  |  | Yes |  | Inferred from Usage |
| 187 | [azt_totalreimbursement](#index-azt_totalreimbursement) |  |  | Yes |  | Inferred from Usage |
| 188 | [azt_trackingnumber](#index-azt_trackingnumber) |  |  | Yes |  | Inferred from Usage |
| 189 | [azt_trackingnumbers](#index-azt_trackingnumbers) |  |  | Yes |  | Inferred from Usage |
| 190 | [azt_trainingid](#index-azt_trainingid) |  |  | Yes |  | Inferred from Usage |
| 191 | [azt_year](#index-azt_year) |  |  | Yes |  | Inferred from Usage |
| 192 | [baseamount](#index-baseamount) |  |  | No |  | Inferred from Usage |
| 193 | [billto_city](#index-billto_city) |  |  | No |  | Inferred from Usage |
| 194 | [billto_contactname](#index-billto_contactname) |  |  | No |  | Inferred from Usage |
| 195 | [billto_country](#index-billto_country) |  |  | No |  | Inferred from Usage |
| 196 | [billto_fax](#index-billto_fax) |  |  | No |  | Inferred from Usage |
| 197 | [billto_line1](#index-billto_line1) |  |  | No |  | Inferred from Usage |
| 198 | [billto_line2](#index-billto_line2) |  |  | No |  | Inferred from Usage |
| 199 | [billto_line3](#index-billto_line3) |  |  | No |  | Inferred from Usage |
| 200 | [billto_name](#index-billto_name) |  |  | No |  | Inferred from Usage |
| 201 | [billto_postalcode](#index-billto_postalcode) |  |  | No |  | Inferred from Usage |
| 202 | [billto_stateorprovince](#index-billto_stateorprovince) |  |  | No |  | Inferred from Usage |
| 203 | [billto_telephone](#index-billto_telephone) |  |  | No |  | Inferred from Usage |
| 204 | [body](#index-body) |  |  | No |  | Inferred from Usage |
| 205 | [bpf_duration](#index-bpf_duration) |  |  | No |  | Inferred from Usage |
| 206 | [bpf_salesorderid](#index-bpf_salesorderid) |  |  | No |  | Inferred from Usage |
| 207 | [businessprocessflowinstanceid](#index-businessprocessflowinstanceid) |  |  | No |  | Inferred from Usage |
| 208 | [businessunitid](#index-businessunitid) |  |  | No |  | Inferred from Usage |
| 209 | [campaignid](#index-campaignid) |  |  | No |  | Inferred from Usage |
| 210 | [category](#index-category) |  |  | No |  | Inferred from Usage |
| 211 | [city](#index-city) |  |  | No |  | Inferred from Usage |
| 212 | [closedon](#index-closedon) |  |  | No |  | Inferred from Usage |
| 213 | [closeprobability](#index-closeprobability) |  |  | No |  | Inferred from Usage |
| 214 | [companyname](#index-companyname) |  |  | No |  | Inferred from Usage |
| 215 | [connectionid](#index-connectionid) |  |  | No |  | Inferred from Usage |
| 216 | [connectionroleid](#index-connectionroleid) |  |  | No |  | Inferred from Usage |
| 217 | [consideronlygoalownersrecords](#index-consideronlygoalownersrecords) |  |  | No |  | Inferred from Usage |
| 218 | [contactid](#index-contactid) |  |  | No |  | Inferred from Usage |
| 219 | [country](#index-country) |  |  | No |  | Inferred from Usage |
| 220 | [county](#index-county) |  |  | No |  | Inferred from Usage |
| 221 | [createdby](#index-createdby) |  |  | No |  | Inferred from Usage |
| 222 | [createdon](#index-createdon) |  |  | No |  | Inferred from Usage |
| 223 | [crm3_expenseamount](#index-crm3_expenseamount) |  |  | No |  | Inferred from Usage |
| 224 | [crm3_parentleadid](#index-crm3_parentleadid) |  |  | No |  | Inferred from Usage |
| 225 | [customerid](#index-customerid) | Potential Customer | customer | No | required | Solution Export |
| 226 | [datefulfilled](#index-datefulfilled) |  |  | No |  | Inferred from Usage |
| 227 | [defaultuomid](#index-defaultuomid) |  |  | No |  | Inferred from Usage |
| 228 | [description](#index-description) |  |  | No |  | Inferred from Usage |
| 229 | [discountamount](#index-discountamount) |  |  | No |  | Inferred from Usage |
| 230 | [discountpercentage](#index-discountpercentage) |  |  | No |  | Inferred from Usage |
| 231 | [effectivefrom](#index-effectivefrom) |  |  | No |  | Inferred from Usage |
| 232 | [effectiveto](#index-effectiveto) |  |  | No |  | Inferred from Usage |
| 233 | [emailaddress](#index-emailaddress) |  |  | No |  | Inferred from Usage |
| 234 | [emailaddress1](#index-emailaddress1) |  |  | No |  | Inferred from Usage |
| 235 | [estimatedclosedate](#index-estimatedclosedate) |  |  | No |  | Inferred from Usage |
| 236 | [estimatedvalue](#index-estimatedvalue) |  |  | No |  | Inferred from Usage |
| 237 | [expireson](#index-expireson) |  |  | No |  | Inferred from Usage |
| 238 | [ext_amt](#index-ext_amt) |  |  | No |  | Inferred from Usage |
| 239 | [extendedamount](#index-extendedamount) |  |  | No |  | Inferred from Usage |
| 240 | [fetchxml](#index-fetchxml) |  |  | No |  | Inferred from Usage |
| 241 | [filename](#index-filename) |  |  | No |  | Inferred from Usage |
| 242 | [firstname](#index-firstname) |  |  | No |  | Inferred from Usage |
| 243 | [freightamount](#index-freightamount) | Freight Amount | money | No | none | Solution Export |
| 244 | [freightamount_base](#index-freightamount_base) | Freight Amount (Base) | money | No | none | Solution Export |
| 245 | [freighttermscode](#index-freighttermscode) |  |  | No |  | Inferred from Usage |
| 246 | [from](#index-from) |  |  | No |  | Inferred from Usage |
| 247 | [fullname](#index-fullname) |  |  | No |  | Inferred from Usage |
| 248 | [goalenddate](#index-goalenddate) |  |  | No |  | Inferred from Usage |
| 249 | [goalid](#index-goalid) |  |  | No |  | Inferred from Usage |
| 250 | [goalownerid](#index-goalownerid) |  |  | No |  | Inferred from Usage |
| 251 | [goalrollupqueryid](#index-goalrollupqueryid) |  |  | No |  | Inferred from Usage |
| 252 | [goalstartdate](#index-goalstartdate) |  |  | No |  | Inferred from Usage |
| 253 | [incidentid](#index-incidentid) |  |  | No |  | Inferred from Usage |
| 254 | [internalemailaddress](#index-internalemailaddress) |  |  | No |  | Inferred from Usage |
| 255 | [invline.productid](#index-invlineproductid) |  |  | No |  | Inferred from Usage |
| 256 | [invoicedetailid](#index-invoicedetailid) |  |  | No |  | Inferred from Usage |
| 257 | [invoiceid](#index-invoiceid) |  |  | No |  | Inferred from Usage |
| 258 | [invoicenumber](#index-invoicenumber) |  |  | No |  | Inferred from Usage |
| 259 | [isamount](#index-isamount) |  |  | No |  | Inferred from Usage |
| 260 | [isfiscalperiodgoal](#index-isfiscalperiodgoal) |  |  | No |  | Inferred from Usage |
| 261 | [isocurrencycode](#index-isocurrencycode) |  |  | No |  | Inferred from Usage |
| 262 | [ispriceoverridden](#index-ispriceoverridden) |  |  | No |  | Inferred from Usage |
| 263 | [isproductoverridden](#index-isproductoverridden) |  |  | No |  | Inferred from Usage |
| 264 | [isrevenuesystemcalculated](#index-isrevenuesystemcalculated) |  |  | No |  | Inferred from Usage |
| 265 | [jobtitle](#index-jobtitle) |  |  | No |  | Inferred from Usage |
| 266 | [lastname](#index-lastname) |  |  | No |  | Inferred from Usage |
| 267 | [manualdiscountamount](#index-manualdiscountamount) |  |  | No |  | Inferred from Usage |
| 268 | [metricid](#index-metricid) |  |  | No |  | Inferred from Usage |
| 269 | [mimetype](#index-mimetype) |  |  | No |  | Inferred from Usage |
| 270 | [mobilephone](#index-mobilephone) |  |  | No |  | Inferred from Usage |
| 271 | [modifiedon](#index-modifiedon) |  |  | No |  | Inferred from Usage |
| 272 | [name](#index-name) | Name | nvarchar | No | required | Solution Export |
| 273 | [objectid](#index-objectid) |  |  | No |  | Inferred from Usage |
| 274 | [objecttypecode](#index-objecttypecode) |  |  | No |  | Inferred from Usage |
| 275 | [opportunityid](#index-opportunityid) |  |  | No |  | Inferred from Usage |
| 276 | [opportunityproductid](#index-opportunityproductid) |  |  | No |  | Inferred from Usage |
| 277 | [ordernumber](#index-ordernumber) |  |  | No |  | Inferred from Usage |
| 278 | [originatingleadid](#index-originatingleadid) |  |  | No |  | Inferred from Usage |
| 279 | [ownerid](#index-ownerid) |  |  | No |  | Inferred from Usage |
| 280 | [parentaccountid](#index-parentaccountid) |  |  | No |  | Inferred from Usage |
| 281 | [parentcontactid](#index-parentcontactid) |  |  | No |  | Inferred from Usage |
| 282 | [parentcustomerid](#index-parentcustomerid) |  |  | No |  | Inferred from Usage |
| 283 | [parentgoalid](#index-parentgoalid) |  |  | No |  | Inferred from Usage |
| 284 | [parentsystemuserid](#index-parentsystemuserid) |  |  | No |  | Inferred from Usage |
| 285 | [partyid](#index-partyid) |  |  | No |  | Inferred from Usage |
| 286 | [paymenttermscode](#index-paymenttermscode) |  |  | No |  | Inferred from Usage |
| 287 | [phonenumber](#index-phonenumber) |  |  | No |  | Inferred from Usage |
| 288 | [pricelevelid](#index-pricelevelid) |  |  | No |  | Inferred from Usage |
| 289 | [priceperunit](#index-priceperunit) |  |  | No |  | Inferred from Usage |
| 290 | [primarycontactid](#index-primarycontactid) |  |  | No |  | Inferred from Usage |
| 291 | [prod.productid](#index-prodproductid) |  |  | No |  | Inferred from Usage |
| 292 | [productdescription](#index-productdescription) |  |  | No |  | Inferred from Usage |
| 293 | [productid](#index-productid) |  |  | No |  | Inferred from Usage |
| 294 | [productname](#index-productname) |  |  | No |  | Inferred from Usage |
| 295 | [productnumber](#index-productnumber) |  |  | No |  | Inferred from Usage |
| 296 | [producttypecode](#index-producttypecode) |  |  | No |  | Inferred from Usage |
| 297 | [quantity](#index-quantity) |  |  | No |  | Inferred from Usage |
| 298 | [queryentitytype](#index-queryentitytype) |  |  | No |  | Inferred from Usage |
| 299 | [queueid](#index-queueid) |  |  | No |  | Inferred from Usage |
| 300 | [queueitemid](#index-queueitemid) |  |  | No |  | Inferred from Usage |
| 301 | [quotecustomeridcontactcontactid.emailaddress1](#index-quotecustomeridcontactcontactidemailaddress1) |  |  | No |  | Inferred from Usage |
| 302 | [quotedetailid](#index-quotedetailid) |  |  | No |  | Inferred from Usage |
| 303 | [quotedetailsgrid](#index-quotedetailsgrid) |  |  | No |  | Inferred from Usage |
| 304 | [quoteid](#index-quoteid) |  |  | No |  | Inferred from Usage |
| 305 | [quotelines](#index-quotelines) |  |  | No |  | Inferred from Usage |
| 306 | [quotenumber](#index-quotenumber) | Quote ID | nvarchar | No | systemrequired | Solution Export |
| 307 | [record1id](#index-record1id) |  |  | No |  | Inferred from Usage |
| 308 | [record1roleid](#index-record1roleid) |  |  | No |  | Inferred from Usage |
| 309 | [record2id](#index-record2id) |  |  | No |  | Inferred from Usage |
| 310 | [record2roleid](#index-record2roleid) |  |  | No |  | Inferred from Usage |
| 311 | [regardingobjectid](#index-regardingobjectid) |  |  | No |  | Inferred from Usage |
| 312 | [requestdeliveryby](#index-requestdeliveryby) |  |  | No |  | Inferred from Usage |
| 313 | [roleid](#index-roleid) |  |  | No |  | Inferred from Usage |
| 314 | [rolluponlyfromchildgoals](#index-rolluponlyfromchildgoals) |  |  | No |  | Inferred from Usage |
| 315 | [rollupqueryactualmoneyid](#index-rollupqueryactualmoneyid) |  |  | No |  | Inferred from Usage |
| 316 | [rolluprulestep1_1](#index-rolluprulestep1_1) |  |  | No |  | Inferred from Usage |
| 317 | [rolluprulestep1_2](#index-rolluprulestep1_2) |  |  | No |  | Inferred from Usage |
| 318 | [salesorderdetailid](#index-salesorderdetailid) |  |  | No |  | Inferred from Usage |
| 319 | [salesorderdetailname](#index-salesorderdetailname) |  |  | No |  | Inferred from Usage |
| 320 | [salesorderid](#index-salesorderid) |  |  | No |  | Inferred from Usage |
| 321 | [salesrepid](#index-salesrepid) |  |  | No |  | Inferred from Usage |
| 322 | [scheduledend](#index-scheduledend) |  |  | No |  | Inferred from Usage |
| 323 | [shippingmethodcode](#index-shippingmethodcode) |  |  | No |  | Inferred from Usage |
| 324 | [shipto_city](#index-shipto_city) |  |  | No |  | Inferred from Usage |
| 325 | [shipto_contactname](#index-shipto_contactname) | Shipping Contact | nvarchar | No | none | Solution Export |
| 326 | [shipto_country](#index-shipto_country) |  |  | No |  | Inferred from Usage |
| 327 | [shipto_fax](#index-shipto_fax) |  |  | No |  | Inferred from Usage |
| 328 | [shipto_freighttermscode](#index-shipto_freighttermscode) |  |  | No |  | Inferred from Usage |
| 329 | [shipto_line1](#index-shipto_line1) |  |  | No |  | Inferred from Usage |
| 330 | [shipto_line2](#index-shipto_line2) |  |  | No |  | Inferred from Usage |
| 331 | [shipto_line3](#index-shipto_line3) |  |  | No |  | Inferred from Usage |
| 332 | [shipto_name](#index-shipto_name) |  |  | No |  | Inferred from Usage |
| 333 | [shipto_postalcode](#index-shipto_postalcode) |  |  | No |  | Inferred from Usage |
| 334 | [shipto_stateorprovince](#index-shipto_stateorprovince) |  |  | No |  | Inferred from Usage |
| 335 | [shipto_telephone](#index-shipto_telephone) |  |  | No |  | Inferred from Usage |
| 336 | [state](#index-state) |  |  | No |  | Inferred from Usage |
| 337 | [statecode](#index-statecode) | Status | state | No | systemrequired | Solution Export |
| 338 | [stateorprovince](#index-stateorprovince) |  |  | No |  | Inferred from Usage |
| 339 | [statuscode](#index-statuscode) | Status Reason | status | No | none | Solution Export |
| 340 | [street](#index-street) |  |  | No |  | Inferred from Usage |
| 341 | [subject](#index-subject) |  |  | No |  | Inferred from Usage |
| 342 | [systemuserid](#index-systemuserid) |  |  | No |  | Inferred from Usage |
| 343 | [tax](#index-tax) |  |  | No |  | Inferred from Usage |
| 344 | [teamid](#index-teamid) |  |  | No |  | Inferred from Usage |
| 345 | [teamtype](#index-teamtype) |  |  | No |  | Inferred from Usage |
| 346 | [telephone1](#index-telephone1) |  |  | No |  | Inferred from Usage |
| 347 | [title](#index-title) |  |  | No |  | Inferred from Usage |
| 348 | [tm.systemuserid](#index-tmsystemuserid) |  |  | No |  | Inferred from Usage |
| 349 | [to](#index-to) |  |  | No |  | Inferred from Usage |
| 350 | [totalamount](#index-totalamount) | Total Amount | money | No | none | Solution Export |
| 351 | [totallineitemamount](#index-totallineitemamount) |  |  | No |  | Inferred from Usage |
| 352 | [transactioncurrencyid](#index-transactioncurrencyid) |  |  | No |  | Inferred from Usage |
| 353 | [uomid](#index-uomid) |  |  | No |  | Inferred from Usage |
| 354 | [value](#index-value) |  |  | No |  | Inferred from Usage |
| 355 | [willcall](#index-willcall) |  |  | No |  | Inferred from Usage |
| 356 | [zipcode](#index-zipcode) |  |  | No |  | Inferred from Usage |
| 357 | [{0}](#index-0) |  |  | No |  | Inferred from Usage |

---

## <a id="2-forms"></a>2. Forms

Total forms: **1**

### <a id="21-quote-main-active"></a>2.1. Quote (main) -- Active

- **Form ID:** `{54076a2d-d043-4a1b-b061-4d06846371a9}`
- **Presentation:** UCI/Tablet
- **Status:** Active

#### Tab: Summary_tab

##### Section: quote information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_ponumber](#index-azt_ponumber) | PO Number | No | Yes |
| [azt_recordownerid](#index-azt_recordownerid) | Record Owner | No | Yes |
| [azt_quotedcontactid](#index-azt_quotedcontactid) | Quoted Contact | No | Yes |
| [shipto_name](#index-shipto_name) | Ship To Name | No | Yes |
| [azt_shippingcompany](#index-azt_shippingcompany) | Ship To Company | No | Yes |
| [shipto_contactname](#index-shipto_contactname) | Shipping Contact: | No | No |

##### Section: shipping information

##### Section: addresses

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [willcall](#index-willcall) | Ship To | No | Yes |

##### Section: products

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quotelines](#index-quotelines) | Quote Products | No | Yes |

##### Section: totals

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [discountpercentage](#index-discountpercentage) |  | Yes | Yes |
| [discountamount](#index-discountamount) |  | Yes | Yes |
| [freightamount](#index-freightamount) |  | Yes | Yes |
| [azt_discretionarydiscount](#index-azt_discretionarydiscount) | Discretionary Discount | No | Yes |
| [azt_discretionarydiscountamt](#index-azt_discretionarydiscountamt) | Discretionary Discount Amt | Yes | No |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recapnotes](#index-azt_recapnotes) | Recap Notes | No | Yes |

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_recapnotescannedoptions](#index-azt_recapnotescannedoptions) | Recap Notes (Canned Options) | No | Yes |

##### Section: sales_information

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_taxamount](#index-azt_taxamount) | Tax Amount | No | Yes |

##### Section: description_section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [ownerid](#index-ownerid) | Owner | No | Yes |
| [accessteam](#index-accessteam) | Access Team Members | No | Yes |

##### Section: Freight

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [azt_defaultfreightamount](#index-azt_defaultfreightamount) | Default Freight Amount | Yes | Yes |
| [azt_requestedfreightamt](#index-azt_requestedfreightamt) | Requested Freight Amt | No | Yes |
| [azt_freightamtapproved](#index-azt_freightamtapproved) | Freight Amt Approved? | No | Yes |

#### Tab: details_tab

##### Section: tab_2_section_2

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [effectivefrom](#index-effectivefrom) | Effective From | No | Yes |
| [effectiveto](#index-effectiveto) | Effective To | No | Yes |
| [createdon](#index-createdon) | Created On | No | Yes |

#### Tab: Administration

##### Section: Section

| Field | Label | Disabled | Visible |
|-------|-------|----------|---------|
| [quotedetailsGrid](#index-quotedetailsgrid) | PRODUCTS | No | Yes |

#### Footer Fields

| Field | Label |
|-------|-------|
| [azt_historicalowner](#index-azt_historicalowner) | Historical Owner |

#### Form Events & Libraries

| Event | Attribute | Function | Library | Enabled |
|-------|-----------|----------|---------|---------|
| onload |  | `QUO.QuoteFunctions.setFreight` | `azt_quotelibrary` | true |
| onchange | azt_recapnotescannedoptions | `QUO.QuoteFunctions.onLoad` | `azt_quotelibrary` | true |
| onchange | azt_freightamtapproved | `QUO.QuoteFunctions.setFreight` | `azt_quotelibrary` | true |
| onchange | azt_freightamtapproved | `QUO.QuoteFunctions.getProductInfo` | `azt_quotelibrary` | false |

---

## <a id="3-views"></a>3. Views

Total views: **5**

### <a id="31-active-quotes"></a>3.1. Active Quotes

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [statecode](#index-statecode) | 100px |
| 3 | [totalamount](#index-totalamount) | 100px |
| 4 | [customerid](#index-customerid) | 150px |
| 5 | [azt_discretionarydiscount](#index-azt_discretionarydiscount) | 125px |
| 6 | [createdon](#index-createdon) | 150px |
| 7 | [quoteid](#index-quoteid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [statecode](#index-statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Descending |

### <a id="32-all-quotes"></a>3.2. All Quotes

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [statecode](#index-statecode) | 100px |
| 3 | [totalamount](#index-totalamount) | 100px |
| 4 | [customerid](#index-customerid) | 150px |
| 5 | [quotecustomeridcontactcontactid.emailaddress1](#index-quotecustomeridcontactcontactidemailaddress1) | 150px |
| 6 | [azt_discretionarydiscount](#index-azt_discretionarydiscount) | 125px |
| 7 | [opportunityid](#index-opportunityid) | 200px |
| 8 | [emailaddress1](#index-emailaddress1) |  |
| 9 | [quoteid](#index-quoteid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Descending |

### <a id="33-my-quotes"></a>3.3. My Quotes

- **Type:** Standard (querytype=0)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [statecode](#index-statecode) | 100px |
| 3 | [totalamount](#index-totalamount) | 100px |
| 4 | [customerid](#index-customerid) | 150px |
| 5 | [quotecustomeridcontactcontactid.emailaddress1](#index-quotecustomeridcontactcontactidemailaddress1) | 150px |
| 6 | [createdon](#index-createdon) | 150px |
| 7 | [emailaddress1](#index-emailaddress1) |  |
| 8 | [quoteid](#index-quoteid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [azt_recordownerid](#index-azt_recordownerid) | eq-userid |  |
| [statecode](#index-statecode) | eq | 0 |
| [statecode](#index-statecode) | eq | 1 |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Descending |

### <a id="34-quick-find-all-quotes"></a>3.4. Quick Find All Quotes

- **Type:** Quick Find (querytype=4)
- **Default:** Yes

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [customerid](#index-customerid) | 150px |
| 3 | [statecode](#index-statecode) | 100px |
| 4 | [totalamount](#index-totalamount) | 100px |
| 5 | [createdon](#index-createdon) | 150px |
| 6 | [quoteid](#index-quoteid) |  |

**Filter Conditions:**

| Field | Operator | Value |
|-------|----------|-------|
| [quotenumber](#index-quotenumber) | like | {0} |
| [name](#index-name) | like | {0} |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

### <a id="35-quotes-needing-freight-approval"></a>3.5. Quotes Needing Freight Approval

- **Type:** Standard (querytype=0)
- **Default:** No

**Display Columns:**

| # | Field | Width |
|---|-------|-------|
| 1 | [name](#index-name) | 300px |
| 2 | [statecode](#index-statecode) | 100px |
| 3 | [totalamount](#index-totalamount) | 100px |
| 4 | [customerid](#index-customerid) | 150px |
| 5 | [effectiveto](#index-effectiveto) | 100px |
| 6 | [azt_defaultfreightamount](#index-azt_defaultfreightamount) | 150px |
| 7 | [azt_requestedfreightamt](#index-azt_requestedfreightamt) | 150px |
| 8 | [freightamount](#index-freightamount) | 150px |
| 9 | [createdon](#index-createdon) | 100px |
| 10 | [quoteid](#index-quoteid) |  |

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [createdon](#index-createdon) | Ascending |

---

## <a id="4-chart-visualizations"></a>4. Chart Visualizations

Total charts: **0**

---

## <a id="5-reports"></a>5. Reports

Total reports referencing Quote: **5**

### <a id="51-paquotereport"></a>5.1. PAQuoteReport

- **File:** `PAQuoteReportrdl2a31f328-ff1a-ec11-b6e6-0022480b3758`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#index-name)
- [customerid](#index-customerid)
- [totalamount](#index-totalamount)
- [quoteid](#index-quoteid)
- [effectiveto](#index-effectiveto)
- [effectivefrom](#index-effectivefrom)
- [quotenumber](#index-quotenumber)
- [azt_recapnotes](#index-azt_recapnotes)
- [totallineitemamount](#index-totallineitemamount)
- [discountpercentage](#index-discountpercentage)
- [discountamount](#index-discountamount)
- [freightamount](#index-freightamount)
- [billto_line1](#index-billto_line1)
- [billto_city](#index-billto_city)
- [billto_postalcode](#index-billto_postalcode)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [shipto_line1](#index-shipto_line1)
- [shipto_line2](#index-shipto_line2)
- [shipto_city](#index-shipto_city)
- [shipto_stateorprovince](#index-shipto_stateorprovince)
- [shipto_postalcode](#index-shipto_postalcode)
- [shipto_country](#index-shipto_country)
- [azt_taxamount](#index-azt_taxamount)
- [shippingmethodcode](#index-shippingmethodcode)
- [azt_recordownerid](#index-azt_recordownerid)
- [shipto_contactname](#index-shipto_contactname)
- [shipto_name](#index-shipto_name)
- [azt_discretionarydiscount](#index-azt_discretionarydiscount)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

**Link Entity:** `account` (alias: `Customer`, type: inner, from: `accountid` to: `customerid`)

Fields:

- [address2_line1](#index-address2_line1) *(via account)*

**Link Entity:** `systemuser` (alias: `Owner`, type: outer, from: `systemuserid` to: `azt_recordownerid`)

Fields:

- [title](#index-title) *(via systemuser)*
- [jobtitle](#index-jobtitle) *(via systemuser)*

**Link Entity:** `contact` (alias: `QuotedContact`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [fullname](#index-fullname) *(via contact)*

**Link Entity:** `quotedetail` (alias: `Lines`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [manualdiscountamount](#index-manualdiscountamount) *(via quotedetail)*
- [baseamount](#index-baseamount) *(via quotedetail)*

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

### <a id="52-packingslip"></a>5.2. PackingSlip

- **File:** `PackingSliprdl2dc9c68e-7c7c-eb11-a812-000d3a3ab0fe`
- **DataSets:** 1

#### DataSet: OrderHeader

**Parameters:** CRM_FilteredSalesOrder

**Primary Entity:** `salesorder`

**Selected Fields:**

- [name](#index-name)
- [customerid](#index-customerid)
- [statuscode](#index-statuscode)
- [totalamount](#index-totalamount)
- [salesorderid](#index-salesorderid)
- [statecode](#index-statecode)
- [ordernumber](#index-ordernumber)
- [shippingmethodcode](#index-shippingmethodcode)
- [shipto_fax](#index-shipto_fax)
- [shipto_country](#index-shipto_country)
- [shipto_contactname](#index-shipto_contactname)
- [shipto_city](#index-shipto_city)
- [shipto_line3](#index-shipto_line3)
- [shipto_line2](#index-shipto_line2)
- [shipto_line1](#index-shipto_line1)
- [shipto_postalcode](#index-shipto_postalcode)
- [shipto_stateorprovince](#index-shipto_stateorprovince)
- [shipto_name](#index-shipto_name)
- [shipto_telephone](#index-shipto_telephone)
- [freightamount](#index-freightamount)
- [billto_postalcode](#index-billto_postalcode)
- [billto_line3](#index-billto_line3)
- [billto_line2](#index-billto_line2)
- [billto_line1](#index-billto_line1)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [billto_telephone](#index-billto_telephone)
- [billto_name](#index-billto_name)
- [billto_fax](#index-billto_fax)
- [billto_country](#index-billto_country)
- [billto_contactname](#index-billto_contactname)
- [billto_city](#index-billto_city)
- [datefulfilled](#index-datefulfilled)
- [createdon](#index-createdon)
- [azt_trackingnumber](#index-azt_trackingnumber)
- [azt_ponumber](#index-azt_ponumber)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

**Link Entity:** `quote` (alias: `Quote`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [quotenumber](#index-quotenumber) *(via quote)*

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

### <a id="53-solesourceletter"></a>5.3. SoleSourceLetter

- **File:** `SoleSourceLetterrdl0625ed05-ce6b-ee11-8df0-000d3a993b8f`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#index-name)
- [customerid](#index-customerid)
- [statuscode](#index-statuscode)
- [totalamount](#index-totalamount)
- [azt_quotedcontactid](#index-azt_quotedcontactid)
- [quoteid](#index-quoteid)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [billto_postalcode](#index-billto_postalcode)
- [billto_line2](#index-billto_line2)
- [billto_line1](#index-billto_line1)
- [billto_city](#index-billto_city)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

**Link Entity:** `contact` (alias: `Cont`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [firstname](#index-firstname) *(via contact)*

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

### <a id="54-summaryquotereport"></a>5.4. SummaryQuoteReport

- **File:** `SummaryQuoteReportrdl3ce3296b-d1de-e911-a960-000d3a3b9b3d`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#index-name)
- [customerid](#index-customerid)
- [totalamount](#index-totalamount)
- [quoteid](#index-quoteid)
- [effectivefrom](#index-effectivefrom)
- [effectiveto](#index-effectiveto)
- [ownerid](#index-ownerid)
- [quotenumber](#index-quotenumber)
- [azt_recapnotes](#index-azt_recapnotes)
- [discountpercentage](#index-discountpercentage)
- [totallineitemamount](#index-totallineitemamount)
- [freightamount](#index-freightamount)
- [discountamount](#index-discountamount)
- [billto_line1](#index-billto_line1)
- [billto_city](#index-billto_city)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [billto_postalcode](#index-billto_postalcode)
- [azt_taxamount](#index-azt_taxamount)
- [azt_recordownerid](#index-azt_recordownerid)
- [azt_discretionarydiscount](#index-azt_discretionarydiscount)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

**Link Entity:** `contact` (alias: `quotedcontact`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [fullname](#index-fullname) *(via contact)*

**Link Entity:** `systemuser` (alias: `owner`, type: outer, from: `systemuserid` to: `owninguser`)

Fields:

- [title](#index-title) *(via systemuser)*

**Link Entity:** `quotedetail` (alias: `Lines`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [manualdiscountamount](#index-manualdiscountamount) *(via quotedetail)*
- [baseamount](#index-baseamount) *(via quotedetail)*

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

### <a id="55-igradquotereport"></a>5.5. iGradQuoteReport

- **File:** `iGradQuoteReportrdlc630364e-748a-ed11-81ad-000d3a993b8f`
- **DataSets:** 1

#### DataSet: QuoteHeader

**Parameters:** CRM_FilteredQuote

**Primary Entity:** `quote`

**Selected Fields:**

- [name](#index-name)
- [customerid](#index-customerid)
- [totalamount](#index-totalamount)
- [quoteid](#index-quoteid)
- [effectivefrom](#index-effectivefrom)
- [effectiveto](#index-effectiveto)
- [azt_recordownerid](#index-azt_recordownerid)
- [quotenumber](#index-quotenumber)
- [azt_recapnotes](#index-azt_recapnotes)
- [discountpercentage](#index-discountpercentage)
- [totallineitemamount](#index-totallineitemamount)
- [freightamount](#index-freightamount)
- [discountamount](#index-discountamount)
- [billto_line1](#index-billto_line1)
- [billto_city](#index-billto_city)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [billto_postalcode](#index-billto_postalcode)
- [azt_taxamount](#index-azt_taxamount)
- [shipto_contactname](#index-shipto_contactname)
- [azt_discretionarydiscount](#index-azt_discretionarydiscount)

**Sort Order:**

| Field | Direction |
|-------|-----------|
| [name](#index-name) | Ascending |

**Link Entity:** `contact` (alias: `quotedcontact`, type: outer, from: `contactid` to: `azt_quotedcontactid`)

Fields:

- [fullname](#index-fullname) *(via contact)*

**Link Entity:** `systemuser` (alias: `owner`, type: outer, from: `systemuserid` to: `azt_recordownerid`)

Fields:

- [title](#index-title) *(via systemuser)*

**Link Entity:** `quotedetail` (alias: `Lines`, type: outer, from: `quoteid` to: `quoteid`)

Fields:

- [manualdiscountamount](#index-manualdiscountamount) *(via quotedetail)*
- [baseamount](#index-baseamount) *(via quotedetail)*

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

## <a id="6-dashboards"></a>6. Dashboards

Total dashboards referencing Quote: **0**

---

## <a id="7-workflows"></a>7. Workflows

Total workflows referencing Quote: **58**

### <a id="71-0changequoterecordowner"></a>7.1. 0ChangeQuoteRecordOwner

- **File:** `0ChangeQuoteRecordOwner-938FE262-FF96-42CB-8332-50B6A947A533.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="72-0engagementnames"></a>7.2. 0EngagementNames

- **File:** `0EngagementNames-BC419DA7-86F1-43E4-88B5-509514704A0C.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#index-name)

### <a id="73-accountauto-assign"></a>7.3. AccountAuto-Assign

- **File:** `AccountAuto-Assign-6DE252A4-C0D8-4C6B-800E-3985440C88D1.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`

### <a id="74-appointmentauto-assign"></a>7.4. AppointmentAuto-Assign

- **File:** `AppointmentAuto-Assign-1A553A9D-514D-42CA-A9AE-73FEED04E1E5.xaml`
- **Entity References:** quote
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="75-batchclosequotes"></a>7.5. BatchCloseQuotes

- **File:** `BatchCloseQuotes-57805330-A998-42E2-A194-2935648BCAD7.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

### <a id="76-batchconverttolead"></a>7.6. BatchConverttoLead

- **File:** `BatchConverttoLead-CC0F2DBB-B8CB-4B06-B891-DB6D97252DB8.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [statecode](#index-statecode)

### <a id="77-batchcreateengagements"></a>7.7. BatchCreateEngagements

- **File:** `BatchCreateEngagements-CC9CDFC6-4BC9-4635-B786-0C7BE2C34344.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)
- [statuscode](#index-statuscode)

### <a id="78-batchlooseopportunities"></a>7.8. BatchLooseOpportunities

- **File:** `BatchLooseOpportunities-BFF14F2D-338D-4CBD-B2CE-C0907E02E6C7.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)

### <a id="79-batchopportunitytransfer"></a>7.9. BatchOpportunityTransfer

- **File:** `BatchOpportunityTransfer-744FEB80-2251-4252-875E-ED9958CB448A.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="710-casependingassignmentnotification"></a>7.10. CasePendingAssignmentNotification

- **File:** `CasePendingAssignmentNotification-177DE8B3-E0C3-4F1C-A7B5-DA84B3629AED.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#index-customerid)

### <a id="711-caserecordowner"></a>7.11. CaseRecordOwner

- **File:** `CaseRecordOwner-E2135799-C146-4E0B-A0A5-F9917895B23E.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#index-customerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="712-caserecordownerassign"></a>7.12. CaseRecordOwnerAssign

- **File:** `CaseRecordOwnerAssign-02EE1A9D-1658-4013-BF63-9C0E5C65AAD0.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [customerid](#index-customerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### <a id="713-caserecordownerassignmentnotification"></a>7.13. CaseRecordOwnerAssignmentNotification

- **File:** `CaseRecordOwnerAssignmentNotification-2F6035E6-1FBC-476B-9C97-4554E8360B7C.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)
- [customerid](#index-customerid)

### <a id="714-caseresolutionnotificationemail"></a>7.14. CaseResolutionNotificationEmail

- **File:** `CaseResolutionNotificationEmail-734E721F-7454-4437-8BAC-8B20F496DF12.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Read:**

- [statecode](#index-statecode)

### <a id="715-cloneanddeletequote"></a>7.15. CloneAndDeleteQuote

- **File:** `CloneAndDeleteQuote-1D87A694-5A08-4C93-9925-447BB4FE7DA6.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [azt_historicalowner](#index-azt_historicalowner)
- [azt_ponumber](#index-azt_ponumber)
- [azt_quoteapproval](#index-azt_quoteapproval)
- [azt_quotedcontactid](#index-azt_quotedcontactid)
- [azt_recapnotes](#index-azt_recapnotes)
- [azt_taxamount](#index-azt_taxamount)
- [billto_city](#index-billto_city)
- [billto_contactname](#index-billto_contactname)
- [billto_country](#index-billto_country)
- [billto_fax](#index-billto_fax)
- [billto_line1](#index-billto_line1)
- [billto_line2](#index-billto_line2)
- [billto_name](#index-billto_name)
- [billto_postalcode](#index-billto_postalcode)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [billto_telephone](#index-billto_telephone)
- [campaignid](#index-campaignid)
- [closedon](#index-closedon)
- [customerid](#index-customerid)
- [effectivefrom](#index-effectivefrom)
- [effectiveto](#index-effectiveto)
- [emailaddress](#index-emailaddress)
- [expireson](#index-expireson)
- [freightamount](#index-freightamount)
- [freighttermscode](#index-freighttermscode)
- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)
- [paymenttermscode](#index-paymenttermscode)
- [pricelevelid](#index-pricelevelid)
- [quoteid](#index-quoteid)
- [requestdeliveryby](#index-requestdeliveryby)
- [shippingmethodcode](#index-shippingmethodcode)
- [shipto_city](#index-shipto_city)
- [shipto_contactname](#index-shipto_contactname)
- [shipto_country](#index-shipto_country)
- [shipto_fax](#index-shipto_fax)
- [shipto_freighttermscode](#index-shipto_freighttermscode)
- [shipto_line1](#index-shipto_line1)
- [shipto_line2](#index-shipto_line2)
- [shipto_line3](#index-shipto_line3)
- [shipto_name](#index-shipto_name)
- [shipto_postalcode](#index-shipto_postalcode)
- [shipto_stateorprovince](#index-shipto_stateorprovince)
- [shipto_telephone](#index-shipto_telephone)

**Fields Written:**

- [azt_historicalowner](#index-azt_historicalowner)
- [azt_ponumber](#index-azt_ponumber)
- [azt_quoteapproval](#index-azt_quoteapproval)
- [azt_quotedcontactid](#index-azt_quotedcontactid)
- [azt_recapnotes](#index-azt_recapnotes)
- [azt_taxamount](#index-azt_taxamount)
- [billto_city](#index-billto_city)
- [billto_contactname](#index-billto_contactname)
- [billto_country](#index-billto_country)
- [billto_fax](#index-billto_fax)
- [billto_line1](#index-billto_line1)
- [billto_line2](#index-billto_line2)
- [billto_name](#index-billto_name)
- [billto_postalcode](#index-billto_postalcode)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [billto_telephone](#index-billto_telephone)
- [campaignid](#index-campaignid)
- [closedon](#index-closedon)
- [customerid](#index-customerid)
- [effectivefrom](#index-effectivefrom)
- [effectiveto](#index-effectiveto)
- [emailaddress](#index-emailaddress)
- [expireson](#index-expireson)
- [freightamount](#index-freightamount)
- [freighttermscode](#index-freighttermscode)
- [name](#index-name)
- [opportunityid](#index-opportunityid)
- [ownerid](#index-ownerid)
- [paymenttermscode](#index-paymenttermscode)
- [pricelevelid](#index-pricelevelid)
- [requestdeliveryby](#index-requestdeliveryby)
- [shippingmethodcode](#index-shippingmethodcode)
- [shipto_city](#index-shipto_city)
- [shipto_contactname](#index-shipto_contactname)
- [shipto_country](#index-shipto_country)
- [shipto_fax](#index-shipto_fax)
- [shipto_freighttermscode](#index-shipto_freighttermscode)
- [shipto_line1](#index-shipto_line1)
- [shipto_line2](#index-shipto_line2)
- [shipto_line3](#index-shipto_line3)
- [shipto_name](#index-shipto_name)
- [shipto_postalcode](#index-shipto_postalcode)
- [shipto_stateorprovince](#index-shipto_stateorprovince)
- [shipto_telephone](#index-shipto_telephone)
- [transactioncurrencyid](#index-transactioncurrencyid)
- [willcall](#index-willcall)

### <a id="716-clonelicense"></a>7.16. CloneLicense

- **File:** `CloneLicense-49354120-2D2D-4DED-8C24-4ACA5F6D82D9.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="717-cloneopportunity"></a>7.17. CloneOpportunity

- **File:** `CloneOpportunity-1A3FF4B3-79FD-420C-8A10-375E8892CA44.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [azt_historicalowner](#index-azt_historicalowner)
- [azt_recordownerid](#index-azt_recordownerid)
- [customerid](#index-customerid)

### <a id="718-cloneorder"></a>7.18. CloneOrder

- **File:** `CloneOrder-D2A6AD48-A603-4150-BC84-72092AFB3D79.xaml`
- **Entity References:** quote
- **Primary Entity:** SalesOrder

**Fields Read:**

- [azt_ponumber](#index-azt_ponumber)
- [name](#index-name)

**Fields Written:**

- [customerid](#index-customerid)
- [shipto_contactname](#index-shipto_contactname)
- [statecode](#index-statecode)
- [statuscode](#index-statuscode)

### <a id="719-contactauto-assign"></a>7.19. ContactAuto-Assign

- **File:** `ContactAuto-Assign-25759C22-AE58-4CC7-81E1-9BBF37E76F3E.xaml`
- **Entity References:** quote
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.AccountAutoAssign`
- `AztecPlugins.GetAcctTeamOwned`

### <a id="720-createleadfromleadgen"></a>7.20. CreateLeadFromLeadGen

- **File:** `CreateLeadFromLeadGen-2EA14729-4B62-4F91-95FA-76D258DA0831.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [statecode](#index-statecode)

### <a id="721-createleadfromaccount"></a>7.21. CreateLeadfromAccount

- **File:** `CreateLeadfromAccount-B5E04C1C-B038-4018-B602-645B1E766884.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [statecode](#index-statecode)

### <a id="722-createsoftwarelicense"></a>7.22. CreateSoftwareLicense

- **File:** `CreateSoftwareLicense-82C11935-B2A2-4E45-94B4-F0EEA6641A08.xaml`
- **Entity References:** quote
- **Primary Entity:** SalesOrder

**Fields Written:**

- [customerid](#index-customerid)

### <a id="723-customleadcreation"></a>7.23. CustomLeadCreation

- **File:** `CustomLeadCreation-B26AC2BB-4660-4A50-9229-AD056DE0D9E1.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [statecode](#index-statecode)

### <a id="724-effectiveto"></a>7.24. EffectiveTo

- **File:** `EffectiveTo-C96A6885-1A20-E911-A94F-000D3A3B9B3D.xaml`
- **Entity References:** quote
- **Trigger Scope:** Form
- **Trigger Form ID:** `{54076a2d-d043-4a1b-b061-4d06846371a9}`
- **Primary Entity:** Quote

**Fields Read:**

- [createdon](#index-createdon)
- [effectiveto](#index-effectiveto)

**Fields Written:**

- [effectivefrom](#index-effectivefrom)
- [effectiveto](#index-effectiveto)

### <a id="725-emaildeletesendquotedrafts"></a>7.25. EmailDeleteSendQuoteDrafts

- **File:** `EmailDeleteSendQuoteDrafts-ED77962D-F57D-4F2F-A580-1F5D27E1280C.xaml`
- **Entity References:** quote
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#index-statuscode)

### <a id="726-emailremoveunsentemails"></a>7.26. EmailRemoveUnsentEmails

- **File:** `EmailRemoveUnsentEmails-2F1954B7-77B4-4D54-AA84-DBB10DFB6A71.xaml`
- **Entity References:** quote
- **Primary Entity:** Email

**Fields Read:**

- [statuscode](#index-statuscode)

### <a id="727-engagementrecordowner"></a>7.27. EngagementRecordOwner

- **File:** `EngagementRecordOwner-00BE88CF-37E2-46ED-951B-A553329BC127.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="728-engagementrecordownerteam"></a>7.28. EngagementRecordOwnerTeam

- **File:** `EngagementRecordOwnerTeam-190EE5B4-5775-4B9D-BFD7-FB769C19977A.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="729-invoicerecordowner"></a>7.29. InvoiceRecordOwner

- **File:** `InvoiceRecordOwner-C59ED476-F5C4-47B7-BD33-E88881D2B5EE.xaml`
- **Entity References:** quote
- **Primary Entity:** Invoice

**Fields Read:**

- [customerid](#index-customerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="730-leadassignment"></a>7.30. LeadAssignment

- **File:** `LeadAssignment-5FC23C73-5B6B-423C-8721-57EDA4553E31.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetUserHasRole`
- `AztecPlugins.GetAcctTeamOwned`

### <a id="731-leadqualifydisqualifydate"></a>7.31. LeadQualifyDisqualifyDate

- **File:** `LeadQualifyDisqualifyDate-4DF6EBF4-0F22-4433-AB4F-A241C91F8B5A.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Read:**

- [statecode](#index-statecode)

### <a id="732-newfsrleadnotification"></a>7.32. NewFSRLeadNotification

- **File:** `NewFSRLeadNotification-53E6AF89-E489-4977-8D9F-1579FF72FAC5.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Read:**

- [name](#index-name)

### <a id="733-opportunityauditremoval"></a>7.33. OpportunityAuditRemoval

- **File:** `OpportunityAuditRemoval-DB05BF90-221B-4B58-8AA0-D1A0799EA0A1.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [statecode](#index-statecode)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.OppAuditRemoval`

### <a id="734-opportunityrecordowner"></a>7.34. OpportunityRecordOwner

- **File:** `OpportunityRecordOwner-B0889237-722A-47CC-B102-D507B14FED98.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="735-opportunityrecordownerteam"></a>7.35. OpportunityRecordOwnerTeam

- **File:** `OpportunityRecordOwnerTeam-7F60084D-807B-43D1-ACED-B0CC90F02F02.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="736-orderrecordowner"></a>7.36. OrderRecordOwner

- **File:** `OrderRecordOwner-701C3E67-4733-423C-BC31-5C846B542B76.xaml`
- **Entity References:** quote
- **Primary Entity:** SalesOrder

**Fields Read:**

- [customerid](#index-customerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="737-phonecallauto-assign"></a>7.37. PhonecallAuto-Assign

- **File:** `PhonecallAuto-Assign-D7FD43A4-5AFF-4929-BD37-A1917C4F2391.xaml`
- **Entity References:** quote
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="738-qualifylead"></a>7.38. QualifyLead

- **File:** `QualifyLead-F6899272-F476-48C4-B703-D5ACDD9EDFF7.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Written:**

- [customerid](#index-customerid)
- [name](#index-name)

### <a id="739-quoterecordowner"></a>7.39. QuoteRecordOwner

- **File:** `QuoteRecordOwner-C5266A8C-E23D-41C4-B51F-3A637538DDBF.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [createdby](#index-createdby)
- [customerid](#index-customerid)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="740-quoterecordownerteam"></a>7.40. QuoteRecordOwnerTeam

- **File:** `QuoteRecordOwnerTeam-7ACFAD91-65CC-4C8D-8A3E-673373DEA880.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)
- [quoteid](#index-quoteid)

### <a id="741-renameengagements"></a>7.41. RenameEngagements

- **File:** `RenameEngagements-9D4DC906-B3F2-498A-AC17-7D302597E96C.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Read:**

- [name](#index-name)

### <a id="742-sendquote"></a>7.42. SendQuote

- **File:** `SendQuote-FF6FE214-20D6-4541-AEC6-BD5D18258481.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [azt_quotedcontactid](#index-azt_quotedcontactid)
- [azt_recordownerid](#index-azt_recordownerid)
- [quoteid](#index-quoteid)

### <a id="743-softwarelicensecreateengagement"></a>7.43. SoftwareLicenseCreateEngagement

- **File:** `SoftwareLicenseCreateEngagement-ABFE722A-CAC3-4A3B-AF5C-419EA2CE9CBD.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_softwarelicense

**Fields Written:**

- [statuscode](#index-statuscode)

### <a id="744-taskauto-assign"></a>7.44. TaskAuto-Assign

- **File:** `TaskAuto-Assign-89E60667-3F7F-4ADD-8274-57C2BE011059.xaml`
- **Entity References:** quote
- **Primary Entity:** Task

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

**Custom Actions / Plugin Calls:**

- `AztecPlugins.GetAcctTeamOwned`

### <a id="745-taskcreatereorderlead"></a>7.45. TaskCreateReorderLead

- **File:** `TaskCreateReorderLead-3193EB56-8E56-46A3-B079-A7CFD1CE90B7.xaml`
- **Entity References:** quote
- **Primary Entity:** Task

**Fields Read:**

- [name](#index-name)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)
- [customerid](#index-customerid)
- [statecode](#index-statecode)

### <a id="746-wonopportunityemail"></a>7.46. WonOpportunityEmail

- **File:** `WonOpportunityEmail-DB2872A0-18C2-4157-B6BD-480230C97D32.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Read:**

- [azt_recordownerid](#index-azt_recordownerid)
- [name](#index-name)
- [statecode](#index-statecode)

### <a id="747-workforceaccountauto-assign"></a>7.47. WorkforceAccountAuto-assign

- **File:** `WorkforceAccountAuto-assign-1AD2C544-E6F9-4FC7-AA17-810AEB8939C2.xaml`
- **Entity References:** quote
- **Primary Entity:** Account

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="748-workforceappointmentauto-assign"></a>7.48. WorkforceAppointmentAuto-Assign

- **File:** `WorkforceAppointmentAuto-Assign-803829FB-077B-4F0B-B238-105814F5B202.xaml`
- **Entity References:** quote
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="749-workforcecaseauto-assign"></a>7.49. WorkforceCaseAuto-assign

- **File:** `WorkforceCaseAuto-assign-24BA0A9C-F8BD-45CB-A5F6-6DCE42CD998F.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="750-workforcecontactauto-assign"></a>7.50. WorkforceContactAuto-assign

- **File:** `WorkforceContactAuto-assign-65B65E23-A8F5-46DB-A35A-C5DC8542B6AE.xaml`
- **Entity References:** quote
- **Primary Entity:** Contact

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="751-workforceengagementauto-assign"></a>7.51. WorkforceEngagementAuto-assign

- **File:** `WorkforceEngagementAuto-assign-DA5CDD7F-2A3B-4A0A-861D-75305D10254E.xaml`
- **Entity References:** quote
- **Primary Entity:** azt_engagement

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="752-workforceleadauto-assign"></a>7.52. WorkforceLeadAuto-Assign

- **File:** `WorkforceLeadAuto-Assign-E5A4054C-5F7E-478C-87E3-529C1EEAB0DC.xaml`
- **Entity References:** quote
- **Primary Entity:** Lead

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="753-workforceopportunityauto-assign"></a>7.53. WorkforceOpportunityAuto-assign

- **File:** `WorkforceOpportunityAuto-assign-7D379FBE-C672-41EB-90A3-A80451C62533.xaml`
- **Entity References:** quote
- **Primary Entity:** Opportunity

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="754-workforcephone-callauto-assign"></a>7.54. WorkforcePhone-callAuto-assign

- **File:** `WorkforcePhone-callAuto-assign-BE1CB211-7C3C-4E39-8913-2DFCE7EDFC85.xaml`
- **Entity References:** quote
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="755-workforcequoteauto-assign"></a>7.55. WorkforceQuoteAuto-assign

- **File:** `WorkforceQuoteAuto-assign-E64BB2BB-5CD6-4327-AB1B-BF8C9D4D2385.xaml`
- **Entity References:** quote
- **Primary Entity:** Quote

**Fields Read:**

- [createdby](#index-createdby)

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="756-igradappointmentauto-assign"></a>7.56. iGradAppointmentAuto-Assign

- **File:** `iGradAppointmentAuto-Assign-CE88A0C4-AA60-44F4-B33D-B57FB8279CCF.xaml`
- **Entity References:** quote
- **Primary Entity:** Appointment

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="757-igradcaseauto-assign"></a>7.57. iGradCaseAuto-Assign

- **File:** `iGradCaseAuto-Assign-CAF5021E-07E1-4689-92D5-FC59E9F30F78.xaml`
- **Entity References:** quote
- **Primary Entity:** Incident

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

### <a id="758-igradphone-callauto-assign"></a>7.58. iGradPhone-callAuto-assign

- **File:** `iGradPhone-callAuto-assign-04423D55-3225-429E-BAC6-8DD37BC53F1B.xaml`
- **Entity References:** quote
- **Primary Entity:** PhoneCall

**Fields Written:**

- [azt_recordownerid](#index-azt_recordownerid)

---

## <a id="8-javascript-web-resources"></a>8. JavaScript Web Resources

Total JS files referencing Quote fields: **13**

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

### <a id="88-azt_opportunitylibrary"></a>8.8. azt_opportunitylibrary

- **File:** `azt_opportunitylibrary43000452-0710-E911-A980-000D3A1A9EFB`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | UI |
| [freightamount](#index-freightamount) | access |

`setFreightAmt`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#index-azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#index-azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#index-azt_requestedfreightamt) | read |
| [freightamount](#index-freightamount) | write |

`success`:

| Field | Operations |
|-------|-----------|
| [freightamount](#index-freightamount) | access |

### <a id="89-azt_opportunitytrackdiscount"></a>8.9. azt_opportunitytrackdiscount

- **File:** `azt_opportunitytrackdiscount8AAC767D-5D0E-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`trackDiscount`:

| Field | Operations |
|-------|-----------|
| [name](#index-name) | read |

### <a id="810-azt_orderlibrary"></a>8.10. azt_orderlibrary

- **File:** `azt_orderlibrary2892D28D-D5C4-EB11-BACC-00224809B8F2`

**Per-Function Field Usage:**

`onLoad`:

| Field | Operations |
|-------|-----------|
| [azt_recordownerid](#index-azt_recordownerid) | UI |

### <a id="811-azt_quotelibrary"></a>8.11. azt_quotelibrary

- **File:** `azt_quotelibrary117BF74F-580A-E911-A983-000D3A1A9151`

**Per-Function Field Usage:**

`setFreight`:

| Field | Operations |
|-------|-----------|
| [azt_defaultfreightamount](#index-azt_defaultfreightamount) | read, write |
| [azt_freightamtapproved](#index-azt_freightamtapproved) | read |
| [azt_requestedfreightamt](#index-azt_requestedfreightamt) | read |
| [freightamount](#index-freightamount) | write |

### <a id="812-azt_sendquote"></a>8.12. azt_sendquote

- **File:** `azt_sendquote0A31A45C-E217-E911-A97D-000D3A1A9FA9`

**Per-Function Field Usage:**

`sendLifeSkillsQuote`:

| Field | Operations |
|-------|-----------|
| [quotenumber](#index-quotenumber) | read |

`sendPAQuote`:

| Field | Operations |
|-------|-----------|
| [quotenumber](#index-quotenumber) | read |

`sendQuote`:

| Field | Operations |
|-------|-----------|
| [quotenumber](#index-quotenumber) | read |

### <a id="813-azt_splitinvoice"></a>8.13. azt_splitinvoice

- **File:** `azt_splitinvoice868121CA-C008-E911-A97C-000D3A1A9EFB`

**Per-Function Field Usage:**

`splitInvoice`:

| Field | Operations |
|-------|-----------|
| [totalamount](#index-totalamount) | read |

---

## <a id="9-formulas-rollups"></a>9. Formulas & Rollups

Total formulas for Quote: **1**

### azt_discretionarydiscount

- **File:** `quote-azt_discretionarydiscount.xaml`
- **Type:** Rollup
- **Aggregation:** SUM
- **Source Entity:** quotedetail

**Source Fields:**

| Field | Entity |
|-------|--------|
| [rolluprulestep1_1](#index-rolluprulestep1_1) | quote |
| [rolluprulestep1_2](#index-rolluprulestep1_2) | quote |
| azt_discretionarydiscountamt | quotedetail |

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

Total relationships involving Quote: **5**

| Relationship Name | Type | Referenced Entity | Referencing Entity | Lookup Field |
|-------------------|------|-------------------|-------------------|-------------|
| azt_contact_quote | N:1 | Contact | Quote | [azt_QuotedContactId](#index-azt_quotedcontactid) |
| azt_systemuser_quote | N:1 | SystemUser | Quote | [azt_RecordOwnerId](#index-azt_recordownerid) |
| opportunity_quotes | N:1 | Opportunity | Quote | [OpportunityId](#index-opportunityid) |
| quote_customer_accounts | N:1 | Account | Quote | [CustomerId](#index-customerid) |
| quote_orders | 1:N | Quote | SalesOrder | [QuoteId](#index-quoteid) |

---

## <a id="13-ribbon-customizations"></a>13. Ribbon Customizations

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

## <a id="14-conflicts-observations"></a>14. Conflicts & Observations

### 14.1 Per-Form Conflicts

No per-form conflicts detected.

### 14.2 Global Observations

**Fields in code but not on any form (313):**

- [accountid](#index-accountid)
- [activityid](#index-activityid)
- [activitytypecode](#index-activitytypecode)
- [actualclosedate](#index-actualclosedate)
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
- [azt_importname](#index-azt_importname)
- [azt_invoiceid](#index-azt_invoiceid)
- [azt_invoiceproductid](#index-azt_invoiceproductid)
- [azt_isbn](#index-azt_isbn)
- [azt_iscompanion](#index-azt_iscompanion)
- [azt_isprint](#index-azt_isprint)
- [azt_issaas](#index-azt_issaas)
- [azt_jobrole](#index-azt_jobrole)
- [azt_jobtitle](#index-azt_jobtitle)
- [azt_lastactivitydate](#index-azt_lastactivitydate)
- [azt_lastmodifiedbyid](#index-azt_lastmodifiedbyid)
- [azt_lastname](#index-azt_lastname)
- [azt_leadimportid](#index-azt_leadimportid)
- [azt_leadsourceid](#index-azt_leadsourceid)
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
- [azt_probability](#index-azt_probability)
- [azt_probabilitychangedon](#index-azt_probabilitychangedon)
- [azt_probabilityincreased](#index-azt_probabilityincreased)
- [azt_productdiscountid](#index-azt_productdiscountid)
- [azt_producttype](#index-azt_producttype)
- [azt_purchasedate](#index-azt_purchasedate)
- [azt_quantity](#index-azt_quantity)
- [azt_quoteapproval](#index-azt_quoteapproval)
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
- [billto_city](#index-billto_city)
- [billto_contactname](#index-billto_contactname)
- [billto_country](#index-billto_country)
- [billto_fax](#index-billto_fax)
- [billto_line1](#index-billto_line1)
- [billto_line2](#index-billto_line2)
- [billto_line3](#index-billto_line3)
- [billto_name](#index-billto_name)
- [billto_postalcode](#index-billto_postalcode)
- [billto_stateorprovince](#index-billto_stateorprovince)
- [billto_telephone](#index-billto_telephone)
- [body](#index-body)
- [bpf_duration](#index-bpf_duration)
- [bpf_salesorderid](#index-bpf_salesorderid)
- [businessprocessflowinstanceid](#index-businessprocessflowinstanceid)
- [businessunitid](#index-businessunitid)
- [campaignid](#index-campaignid)
- [category](#index-category)
- [closedon](#index-closedon)
- [closeprobability](#index-closeprobability)
- [companyname](#index-companyname)
- [connectionid](#index-connectionid)
- [connectionroleid](#index-connectionroleid)
- [consideronlygoalownersrecords](#index-consideronlygoalownersrecords)
- [contactid](#index-contactid)
- [createdby](#index-createdby)
- [crm3_expenseamount](#index-crm3_expenseamount)
- [crm3_parentleadid](#index-crm3_parentleadid)
- [customerid](#index-customerid)
- [datefulfilled](#index-datefulfilled)
- [defaultuomid](#index-defaultuomid)
- [description](#index-description)
- [emailaddress](#index-emailaddress)
- [emailaddress1](#index-emailaddress1)
- [estimatedclosedate](#index-estimatedclosedate)
- [estimatedvalue](#index-estimatedvalue)
- [expireson](#index-expireson)
- [ext_amt](#index-ext_amt)
- [extendedamount](#index-extendedamount)
- [fetchxml](#index-fetchxml)
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
- [incidentid](#index-incidentid)
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
- [isrevenuesystemcalculated](#index-isrevenuesystemcalculated)
- [jobtitle](#index-jobtitle)
- [lastname](#index-lastname)
- [manualdiscountamount](#index-manualdiscountamount)
- [metricid](#index-metricid)
- [mimetype](#index-mimetype)
- [mobilephone](#index-mobilephone)
- [modifiedon](#index-modifiedon)
- [name](#index-name)
- [objectid](#index-objectid)
- [objecttypecode](#index-objecttypecode)
- [opportunityid](#index-opportunityid)
- [opportunityproductid](#index-opportunityproductid)
- [ordernumber](#index-ordernumber)
- [originatingleadid](#index-originatingleadid)
- [parentaccountid](#index-parentaccountid)
- [parentcontactid](#index-parentcontactid)
- [parentcustomerid](#index-parentcustomerid)
- [parentgoalid](#index-parentgoalid)
- [parentsystemuserid](#index-parentsystemuserid)
- [partyid](#index-partyid)
- [paymenttermscode](#index-paymenttermscode)
- [phonenumber](#index-phonenumber)
- [pricelevelid](#index-pricelevelid)
- [priceperunit](#index-priceperunit)
- [primarycontactid](#index-primarycontactid)
- [prod.productid](#index-prodproductid)
- [productdescription](#index-productdescription)
- [productid](#index-productid)
- [productname](#index-productname)
- [productnumber](#index-productnumber)
- [producttypecode](#index-producttypecode)
- [quantity](#index-quantity)
- [queryentitytype](#index-queryentitytype)
- [queueid](#index-queueid)
- [queueitemid](#index-queueitemid)
- [quotedetailid](#index-quotedetailid)
- [quoteid](#index-quoteid)
- [quotenumber](#index-quotenumber)
- [record1id](#index-record1id)
- [record1roleid](#index-record1roleid)
- [record2id](#index-record2id)
- [record2roleid](#index-record2roleid)
- [regardingobjectid](#index-regardingobjectid)
- [requestdeliveryby](#index-requestdeliveryby)
- [roleid](#index-roleid)
- [rolluponlyfromchildgoals](#index-rolluponlyfromchildgoals)
- [rollupqueryactualmoneyid](#index-rollupqueryactualmoneyid)
- [salesorderdetailid](#index-salesorderdetailid)
- [salesorderdetailname](#index-salesorderdetailname)
- [salesorderid](#index-salesorderid)
- [salesrepid](#index-salesrepid)
- [scheduledend](#index-scheduledend)
- [shippingmethodcode](#index-shippingmethodcode)
- [shipto_city](#index-shipto_city)
- [shipto_country](#index-shipto_country)
- [shipto_fax](#index-shipto_fax)
- [shipto_freighttermscode](#index-shipto_freighttermscode)
- [shipto_line1](#index-shipto_line1)
- [shipto_line2](#index-shipto_line2)
- [shipto_line3](#index-shipto_line3)
- [shipto_postalcode](#index-shipto_postalcode)
- [shipto_stateorprovince](#index-shipto_stateorprovince)
- [shipto_telephone](#index-shipto_telephone)
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
- [totalamount](#index-totalamount)
- [totallineitemamount](#index-totallineitemamount)
- [transactioncurrencyid](#index-transactioncurrencyid)
- [uomid](#index-uomid)
- [{0}](#index-0)

**Fields on forms but never in logic (4):**

- [accessteam](#index-accessteam)
- [azt_shippingcompany](#index-azt_shippingcompany)
- [quotedetailsgrid](#index-quotedetailsgrid)
- [quotelines](#index-quotelines)

---

## <a id="index"></a>Index

Alphabetical field index -- 361 unique fields referenced.

**<a id="index-accessteam"></a>`accessteam`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > description_section](#21-quote-main-active)

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
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)

**<a id="index-address1_stateorprovince"></a>`address1_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ActivityRegardingGetState (Read)](#109-activityregardinggetstate)
- [Plugin: AutoAssignStateAbb (Read)](#1012-autoassignstateabb)
- [Plugin: AutoAssignStateAbb (Write)](#1012-autoassignstateabb)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-address1_telephone1"></a>`address1_telephone1`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderFSRSetTemplateFields (Read)](#1052-orderfsrsettemplatefields)

**<a id="index-address2_line1"></a>`address2_line1`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader > account](#51-paquotereport)

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
- [Plugin: OpportunityPreventCreateQuote (Read)](#1047-opportunitypreventcreatequote)
- [Plugin: OpptyToQuoteFieldMappings (Read)](#1050-opptytoquotefieldmappings)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)

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

**<a id="index-azt_defaultfreightamount"></a>`azt_defaultfreightamount`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Freight](#21-quote-main-active)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [JS: azt_opportunitylibrary > setFreightAmt()](#88-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#811-azt_quotelibrary)
- [Plugin: QuotePreventActivateUnapprovedFreight (Read)](#1065-quotepreventactivateunapprovedfreight)

**<a id="index-azt_defaultfreightamount_base"></a>`azt_defaultfreightamount_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_description"></a>`azt_description`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

**<a id="index-azt_discountamount"></a>`azt_discountamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)

**<a id="index-azt_discretionarydiscount"></a>`azt_discretionarydiscount`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [View: Active Quotes](#31-active-quotes)
- [View: All Quotes](#32-all-quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Formula: azt_discretionarydiscount (Target)](#9-formulas-rollups)

**<a id="index-azt_discretionarydiscount_base"></a>`azt_discretionarydiscount_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-azt_discretionarydiscountamt"></a>`azt_discretionarydiscountamt`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)
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
- [Form: Quote > Summary_tab > Freight](#21-quote-main-active)
- [JS: azt_opportunitylibrary > setFreightAmt()](#88-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#811-azt_quotelibrary)
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
- [Form: Quote (Footer)](#21-quote-main-active)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOpportunity (Write)](#717-cloneopportunity)

**<a id="index-azt_importname"></a>`azt_importname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImportPopulateName (Read)](#1037-leadimportpopulatename)

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

**<a id="index-azt_isprint"></a>`azt_isprint`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

**<a id="index-azt_issaas"></a>`azt_issaas`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Filter)](#1022-createusergoals)
- [Plugin: SetOppProductDefaults (Write)](#1074-setoppproductdefaults)

**<a id="index-azt_jobrole"></a>`azt_jobrole`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateUserGoals (Read)](#1022-createusergoals)
- [Plugin: RestrictProductLookups (Read)](#1069-restrictproductlookups)

**<a id="index-azt_jobtitle"></a>`azt_jobtitle`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_lastactivitydate"></a>`azt_lastactivitydate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityLastActivityDate (Write)](#1045-opportunitylastactivitydate)

**<a id="index-azt_lastmodifiedbyid"></a>`azt_lastmodifiedbyid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)

**<a id="index-azt_lastname"></a>`azt_lastname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)

**<a id="index-azt_leadimportid"></a>`azt_leadimportid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-azt_leadsourceid"></a>`azt_leadsourceid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Read)](#1036-leadimport)
- [Plugin: LeadImport (Write)](#1036-leadimport)

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

**<a id="index-azt_paid"></a>`azt_paid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-azt_paidon"></a>`azt_paidon`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingSetAnnualSpend (Filter)](#1028-fundingsetannualspend)
- [Plugin: Utility (Write)](#1081-utility)

**<a id="index-azt_parentopportunityid"></a>`azt_parentopportunityid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityAudit (Image)](#1043-opportunityaudit)

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

**<a id="index-azt_ponumber"></a>`azt_ponumber`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOrder (Read)](#718-cloneorder)
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

**<a id="index-azt_printproductid"></a>`azt_printproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_printpurchaseid"></a>`azt_printpurchaseid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateSoftwareLicenses (Write)](#1021-createsoftwarelicenses)

**<a id="index-azt_probability"></a>`azt_probability`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)
- [Plugin: OpportunityProbabilityChange (Read)](#1048-opportunityprobabilitychange)
- [Plugin: OpportunityProbabilityChange (Image)](#1048-opportunityprobabilitychange)
- [Plugin: OpportunityProbabilityNumber (Read)](#1049-opportunityprobabilitynumber)

**<a id="index-azt_probabilitychangedon"></a>`azt_probabilitychangedon`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityProbabilityChange (Write)](#1048-opportunityprobabilitychange)

**<a id="index-azt_probabilityincreased"></a>`azt_probabilityincreased`**

- [Field Definitions](#1-field-definitions)
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

**<a id="index-azt_quoteapproval"></a>`azt_quoteapproval`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-azt_quotedcontactid"></a>`azt_quotedcontactid`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: SendQuote (Read)](#742-sendquote)
- [Relationship: azt_contact_quote](#12-relationships)

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

**<a id="index-azt_reasonforexpense"></a>`azt_reasonforexpense`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CloneExpenseLine (Read)](#1017-cloneexpenseline)
- [Plugin: CloneExpenseLine (Write)](#1017-cloneexpenseline)

**<a id="index-azt_recapnotes"></a>`azt_recapnotes`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Section](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-azt_recapnotescannedoptions"></a>`azt_recapnotescannedoptions`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Section](#21-quote-main-active)

**<a id="index-azt_recordowner"></a>`azt_recordowner`**

- [Field Definitions](#1-field-definitions)
- [Plugin: RecordOwnerRestrictEdit (Read)](#1067-recordownerrestrictedit)

**<a id="index-azt_recordownerid"></a>`azt_recordownerid`**

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

**<a id="index-azt_replacementproductid"></a>`azt_replacementproductid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: Utility (Read)](#1081-utility)

**<a id="index-azt_requestedfreightamt"></a>`azt_requestedfreightamt`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > Freight](#21-quote-main-active)
- [View: Quotes Needing Freight Approval](#35-quotes-needing-freight-approval)
- [JS: azt_opportunitylibrary > setFreightAmt()](#88-azt_opportunitylibrary)
- [JS: azt_quotelibrary > setFreight()](#811-azt_quotelibrary)
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

**<a id="index-azt_shippingcompany"></a>`azt_shippingcompany`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)

**<a id="index-azt_signedquotereceived"></a>`azt_signedquotereceived`**

- [Field Definitions](#1-field-definitions)

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

**<a id="index-azt_taxamount"></a>`azt_taxamount`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > sales_information](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-azt_taxamount_base"></a>`azt_taxamount_base`**

- [Field Definitions](#1-field-definitions)

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
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
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

**<a id="index-azt_year"></a>`azt_year`**

- [Field Definitions](#1-field-definitions)
- [Plugin: FundingYearSync (Write)](#1030-fundingyearsync)

**<a id="index-baseamount"></a>`baseamount`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader > quotedetail](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader > quotedetail](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader > quotedetail](#55-igradquotereport)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Write)](#1064-quotepreventactivateunapproveddiscounts)
- [Plugin: ReviseQuoteDiscountMove (Read)](#1072-revisequotediscountmove)
- [Plugin: UpdateOppFromQuote (Write)](#1080-updateoppfromquote)

**<a id="index-billto_city"></a>`billto_city`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-billto_contactname"></a>`billto_contactname`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-billto_country"></a>`billto_country`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-billto_fax"></a>`billto_fax`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-billto_line1"></a>`billto_line1`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_line2"></a>`billto_line2`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_line3"></a>`billto_line3`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_name"></a>`billto_name`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_postalcode"></a>`billto_postalcode`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_stateorprovince"></a>`billto_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: SoleSourceLetter > QuoteHeader (Select)](#53-solesourceletter)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-billto_telephone"></a>`billto_telephone`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-body"></a>`body`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-bpf_duration"></a>`bpf_duration`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Read)](#1057-orderstagetracking)

**<a id="index-bpf_salesorderid"></a>`bpf_salesorderid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OrderStageTracking (Filter)](#1057-orderstagetracking)

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

**<a id="index-campaignid"></a>`campaignid`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-category"></a>`category`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Sort)](#1019-contactsetconnectionrole)
- [Plugin: SetPrimaryContact (Read)](#1075-setprimarycontact)
- [Plugin: SetPrimaryContact (Sort)](#1075-setprimarycontact)

**<a id="index-city"></a>`city`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-closedon"></a>`closedon`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-closeprobability"></a>`closeprobability`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityProbabilityNumber (Write)](#1049-opportunityprobabilitynumber)

**<a id="index-companyname"></a>`companyname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

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
- [Workflow: QuoteRecordOwner (Read)](#739-quoterecordowner)
- [Workflow: WorkforceQuoteAuto-assign (Read)](#755-workforcequoteauto-assign)

**<a id="index-createdon"></a>`createdon`**

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

**<a id="index-crm3_expenseamount"></a>`crm3_expenseamount`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)

**<a id="index-crm3_parentleadid"></a>`crm3_parentleadid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ExpenseLineTotals (Read)](#1026-expenselinetotals)
- [Plugin: ExpenseLineTotals (Filter)](#1026-expenselinetotals)

**<a id="index-customerid"></a>`customerid`**

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

**<a id="index-datefulfilled"></a>`datefulfilled`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Plugin: CreateSoftwareLicenses (Read)](#1021-createsoftwarelicenses)

**<a id="index-defaultuomid"></a>`defaultuomid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityLineSyncToQuote (Read)](#1046-opportunitylinesynctoquote)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

**<a id="index-description"></a>`description`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ContactSetConnectionRole (Write)](#1019-contactsetconnectionrole)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: SetPrimaryContact (Write)](#1075-setprimarycontact)

**<a id="index-discountamount"></a>`discountamount`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)
- [Plugin: ReviseQuoteDiscountMove (Write)](#1072-revisequotediscountmove)

**<a id="index-discountpercentage"></a>`discountpercentage`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > totals](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Plugin: QuoteLinesSyncToOppty (Read)](#1062-quotelinessynctooppty)

**<a id="index-effectivefrom"></a>`effectivefrom`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > details_tab > tab_2_section_2](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: EffectiveTo (Write)](#724-effectiveto)

**<a id="index-effectiveto"></a>`effectiveto`**

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

**<a id="index-emailaddress"></a>`emailaddress`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-emailaddress1"></a>`emailaddress1`**

- [Field Definitions](#1-field-definitions)
- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadImport (Filter)](#1036-leadimport)

**<a id="index-estimatedclosedate"></a>`estimatedclosedate`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityClone (Write)](#1044-opportunityclone)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

**<a id="index-estimatedvalue"></a>`estimatedvalue`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityAudit (Read)](#1043-opportunityaudit)
- [Plugin: OpportunityLastActivityDate (Read)](#1045-opportunitylastactivitydate)

**<a id="index-expireson"></a>`expireson`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-ext_amt"></a>`ext_amt`**

- [Field Definitions](#1-field-definitions)
- [Plugin: CreateCompGoals (Read)](#1020-createcompgoals)

**<a id="index-extendedamount"></a>`extendedamount`**

- [Field Definitions](#1-field-definitions)
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

**<a id="index-filename"></a>`filename`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-firstname"></a>`firstname`**

- [Field Definitions](#1-field-definitions)
- [Report: SoleSourceLetter > QuoteHeader > contact](#53-solesourceletter)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-fiscalperiod"></a>`fiscalperiod`**

- [Plugin: CreateUserGoals (Sort)](#1022-createusergoals)

**<a id="index-freightamount"></a>`freightamount`**

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

**<a id="index-freightamount_base"></a>`freightamount_base`**

- [Field Definitions](#1-field-definitions)

**<a id="index-freighttermscode"></a>`freighttermscode`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-from"></a>`from`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)

**<a id="index-fullname"></a>`fullname`**

- [Field Definitions](#1-field-definitions)
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

**<a id="index-incidentid"></a>`incidentid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AccountReassignmentShareRecords (Read)](#104-accountreassignmentsharerecords)
- [Plugin: CaseClose (Write)](#1015-caseclose)

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
- [Plugin: QuoteSyncTotalToOpportunity (Write)](#1066-quotesynctotaltoopportunity)

**<a id="index-jobtitle"></a>`jobtitle`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader > systemuser](#51-paquotereport)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-lastname"></a>`lastname`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadImport (Write)](#1036-leadimport)

**<a id="index-manualdiscountamount"></a>`manualdiscountamount`**

- [Field Definitions](#1-field-definitions)
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
- [Plugin: AccountReassignmentShareRecords (Sort)](#104-accountreassignmentsharerecords)
- [Plugin: OpportunityLineSyncToQuote (Sort)](#1046-opportunitylinesynctoquote)
- [Plugin: UpdateOppFromQuote (Read)](#1080-updateoppfromquote)
- [Plugin: UpdateOppFromQuote (Sort)](#1080-updateoppfromquote)

**<a id="index-name"></a>`name`**

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

**<a id="index-objectid"></a>`objectid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Write)](#1059-phonecallcreatecallback)
- [Plugin: PhonecallCreateCallback (Filter)](#1059-phonecallcreatecallback)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)
- [Plugin: ShareWithAccountOwner (Read)](#1078-sharewithaccountowner)

**<a id="index-objecttypecode"></a>`objecttypecode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: SendQuoteReport (Write)](#1073-sendquotereport)

**<a id="index-opportunityid"></a>`opportunityid`**

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

**<a id="index-ordernumber"></a>`ordernumber`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)

**<a id="index-originatingleadid"></a>`originatingleadid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: LeadQualifyParentStakeholderContacts (Read)](#1039-leadqualifyparentstakeholdercontacts)
- [Plugin: OpportunityAssignFromLead (Read)](#1042-opportunityassignfromlead)

**<a id="index-ownerid"></a>`ownerid`**

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

**<a id="index-owningteam"></a>`owningteam`**

- [Plugin: ShareBasedOnAccessTeam (Join)](#1076-sharebasedonaccessteam)

**<a id="index-owninguser"></a>`owninguser`**

- [Plugin: GetAcctTeamOwned (Join)](#1031-getacctteamowned)

**<a id="index-parentaccountid"></a>`parentaccountid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Read)](#1023-discretionarydiscountsetheader)
- [Plugin: LeadImport (Write)](#1036-leadimport)
- [Plugin: LeadQualify (Read)](#1038-leadqualify)
- [Plugin: ShareBasedOnAccessTeam (Read)](#1076-sharebasedonaccessteam)

**<a id="index-parentcontactid"></a>`parentcontactid`**

- [Field Definitions](#1-field-definitions)
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

**<a id="index-paymenttermscode"></a>`paymenttermscode`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-phonenumber"></a>`phonenumber`**

- [Field Definitions](#1-field-definitions)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-pricelevelid"></a>`pricelevelid`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
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

**<a id="index-producttypecode"></a>`producttypecode`**

- [Field Definitions](#1-field-definitions)
- [Plugin: OpportunityClone (Read)](#1044-opportunityclone)
- [Plugin: OrderClone (Read)](#1051-orderclone)
- [Plugin: OrderSplit (Read)](#1056-ordersplit)

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

**<a id="index-quotecustomeridcontactcontactidemailaddress1"></a>`quotecustomeridcontactcontactid.emailaddress1`**

- [Field Definitions](#1-field-definitions)
- [View: All Quotes](#32-all-quotes)
- [View: My Quotes](#33-my-quotes)

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

**<a id="index-quotedetailsgrid"></a>`quotedetailsgrid`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Administration > Section](#21-quote-main-active)

**<a id="index-quoteid"></a>`quoteid`**

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

**<a id="index-quotelines"></a>`quotelines`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > products](#21-quote-main-active)

**<a id="index-quotenumber"></a>`quotenumber`**

- [Field Definitions](#1-field-definitions)
- [View: Quick Find All Quotes (Filter)](#34-quick-find-all-quotes)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader > quote](#52-packingslip)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [JS: azt_sendquote > sendLifeSkillsQuote()](#812-azt_sendquote)
- [JS: azt_sendquote > sendPAQuote()](#812-azt_sendquote)
- [JS: azt_sendquote > sendQuote()](#812-azt_sendquote)

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

**<a id="index-requestdeliveryby"></a>`requestdeliveryby`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

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
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)

**<a id="index-rolluprulestep1_2"></a>`rolluprulestep1_2`**

- [Field Definitions](#1-field-definitions)
- [Formula: azt_discretionarydiscount](#9-formulas-rollups)

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

**<a id="index-salesrepid"></a>`salesrepid`**

- [Field Definitions](#1-field-definitions)
- [Plugin: QuotePreventActivateUnapprovedDiscounts (Read)](#1064-quotepreventactivateunapproveddiscounts)

**<a id="index-scheduledend"></a>`scheduledend`**

- [Field Definitions](#1-field-definitions)
- [Plugin: ActivitiesCreatedDueDatesInPast (Read)](#107-activitiescreatedduedatesinpast)
- [Plugin: PhonecallCreateCallback (Read)](#1059-phonecallcreatecallback)

**<a id="index-shippingmethodcode"></a>`shippingmethodcode`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_city"></a>`shipto_city`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-shipto_contactname"></a>`shipto_contactname`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Workflow: CloneOrder (Write)](#718-cloneorder)

**<a id="index-shipto_country"></a>`shipto_country`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-shipto_fax"></a>`shipto_fax`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-shipto_freighttermscode"></a>`shipto_freighttermscode`**

- [Field Definitions](#1-field-definitions)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-shipto_line1"></a>`shipto_line1`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_line2"></a>`shipto_line2`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_line3"></a>`shipto_line3`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_name"></a>`shipto_name`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > quote information](#21-quote-main-active)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_postalcode"></a>`shipto_postalcode`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_stateorprovince"></a>`shipto_stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)
- [Plugin: OrderSplit (Write)](#1056-ordersplit)

**<a id="index-shipto_telephone"></a>`shipto_telephone`**

- [Field Definitions](#1-field-definitions)
- [Report: PackingSlip > OrderHeader (Select)](#52-packingslip)
- [Workflow: CloneAndDeleteQuote (Read)](#715-cloneanddeletequote)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-state"></a>`state`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-statecode"></a>`statecode`**

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

**<a id="index-stateorprovince"></a>`stateorprovince`**

- [Field Definitions](#1-field-definitions)
- [Plugin: AutoAssignStateAbb (Read)](#1012-autoassignstateabb)
- [Plugin: AutoAssignStateAbb (Write)](#1012-autoassignstateabb)

**<a id="index-statuscode"></a>`statuscode`**

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
- [Report: PAQuoteReport > QuoteHeader > systemuser](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader > systemuser](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader > systemuser](#55-igradquotereport)
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

**<a id="index-totallineitemamount"></a>`totallineitemamount`**

- [Field Definitions](#1-field-definitions)
- [Report: PAQuoteReport > QuoteHeader (Select)](#51-paquotereport)
- [Report: SummaryQuoteReport > QuoteHeader (Select)](#54-summaryquotereport)
- [Report: iGradQuoteReport > QuoteHeader (Select)](#55-igradquotereport)

**<a id="index-transactioncurrencyid"></a>`transactioncurrencyid`**

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

**<a id="index-willcall"></a>`willcall`**

- [Field Definitions](#1-field-definitions)
- [Form: Quote > Summary_tab > addresses](#21-quote-main-active)
- [Workflow: CloneAndDeleteQuote (Write)](#715-cloneanddeletequote)

**<a id="index-zipcode"></a>`zipcode`**

- [Field Definitions](#1-field-definitions)
- [PCF: Bing Address Autocomplete](#11-pcf-controls)

**<a id="index-0"></a>`{0}`**

- [Field Definitions](#1-field-definitions)
- [Plugin: DiscretionaryDiscountSetHeader (Filter)](#1023-discretionarydiscountsetheader)
