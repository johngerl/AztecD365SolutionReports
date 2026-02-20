using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using System.Runtime.Remoting.Contexts;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
namespace AztecPlugins
{
    public static class Utility
    {
        internal static bool getIsProductSoftware(IOrganizationService service, Guid productId, ITracingService tracingService)
        {
            bool isSoftware = false;
            try
            {
                Product product = service.Retrieve(Product.EntityLogicalName, productId, new ColumnSet("azt_saas")).ToEntity<Product>();
                isSoftware = product.GetAttributeValue<bool>("azt_saas");
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error obtaining IsSaaS in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw new InvalidPluginExecutionException("Error obtaining IsSaaS in the CreateSoftwareLicenses Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error obtaining IsSaaS in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return isSoftware;
        }
        internal static EntityReference getCurrency(IOrganizationService service, ITracingService tracingService)
        {
            EntityReference currency = new EntityReference();
            try
            {

                Guid _currId = Guid.Empty;
                QueryByAttribute currQuery = new QueryByAttribute("transactioncurrency");
                currQuery.ColumnSet = new ColumnSet("transactioncurrencyid");
                currQuery.Attributes.AddRange("isocurrencycode");
                currQuery.Values.Add("USD");
                EntityCollection currencyEntities = service.RetrieveMultiple(currQuery);
                if (currencyEntities.Entities.Count == 1)
                {
                    currency = new EntityReference("transactioncurrency", (Guid)currencyEntities[0].Attributes["transactioncurrencyid"]);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error obtaining currency: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error obtaining currency", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error obtaining currency: {0}", ex.ToString());
                throw;
            }
            #endregion
            return currency;
        }
        internal static Guid getCommissionRecord(IOrganizationService service, ITracingService tracingService, EntityReference salesRepRef, DateTime commissionDate)
        {
            Guid commRecord = Guid.Empty;
            DateTime lastDayOfYear = new DateTime(commissionDate.Year, 12, 31);
            #region Query
            string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_commission'>
    <attribute name='azt_commissionid' />
    <order attribute='ownerid' descending='false' />
    <filter type='and'>
      <condition attribute='ownerid' operator='eq' uitype='systemuser' value='{0}' />
      <condition attribute='azt_fiscalperiodend' operator='on' value='{1}' />
    </filter>
  </entity>
</fetch>
", salesRepRef.Id, lastDayOfYear);
            #endregion
            try
            {
                EntityCollection retComm = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retComm.Entities.Count == 0)
                {
                    commRecord = Utility.createCommissionRecord(service, tracingService, salesRepRef, commissionDate);
                }
                else if (retComm.Entities.Count == 1) return (Guid)retComm.Entities[0].Attributes["azt_commissionid"];
                else if (retComm.Entities.Count > 1) throw new InvalidPluginExecutionException("There is more than one commission record for this user");
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("Error getting Commission Record in the SetCommissionOnCompPlan Plugin.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error getting Commission Record in the SetCommissionOnCompPlan Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return commRecord;
        }
        internal static Guid createCommissionRecord(IOrganizationService service, ITracingService tracingService, EntityReference salesRepRef, DateTime commissionDate)
        {
            EntityReference curr = Utility.getCurrency(service, tracingService);
            Guid commRecord = Guid.Empty;
            try
            {
                string salesRepName = (string)service.Retrieve(SystemUser.EntityLogicalName, salesRepRef.Id, new ColumnSet("fullname")).Attributes["fullname"];
                int year = commissionDate.Year;
                DateTime firstDayOfYear = new DateTime(year, 1, 1);
                DateTime lastDayOfYear = new DateTime(year, 12, 31);
                azt_commission nComm = new azt_commission()
                {
                    OwnerId = salesRepRef,
                    azt_FiscalPeriodStart = firstDayOfYear,
                    azt_FiscalPeriodEnd = lastDayOfYear,
                    azt_name = salesRepName + " " + year + " Commission Record",
                    TransactionCurrencyId = curr
                };
                commRecord = service.Create(nComm);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("Error creating Commission Record in the SetCommissionOnCompPlan Plugin.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error creating Commission Record in the SetCommissionOnCompPlan Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return commRecord;
        }
        internal static bool shareRecordInTargetSystem(IOrganizationService service, Guid _recordId, Guid _sharedUser, string _entityLogicalName)
        {
            List<KeyValuePair<AccessRights, EntityReference>> _targetSharing = new List<KeyValuePair<AccessRights, EntityReference>>();
            bool _shared = false;

            EntityReference _targetPrincipalEntityReference = new EntityReference("systemuser", _sharedUser);
            AccessRights _targetAccessRights = AccessRights.ReadAccess | AccessRights.WriteAccess | AccessRights.AppendAccess | AccessRights.AppendToAccess;

            _targetSharing.Add(new KeyValuePair<AccessRights, EntityReference>(_targetAccessRights, _targetPrincipalEntityReference));

            GrantAccessRequest grantRequest = new GrantAccessRequest()
            {
                Target = new EntityReference(_entityLogicalName, _recordId),
                PrincipalAccess = new PrincipalAccess()
                {
                    Principal = _targetPrincipalEntityReference,
                    AccessMask = _targetAccessRights
                }
            };
            GrantAccessResponse grantResponse = (GrantAccessResponse)service.Execute(grantRequest);
            return _shared;
        }
        internal static SystemUser getUser(IOrganizationService service, ITracingService tracingService, Guid userId)
        {
            SystemUser retUser = new SystemUser();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='systemuser'>
    <attribute name='businessunitid' />
    <order attribute='fullname' descending='false' />
    <filter type='and'>
      <condition attribute='systemuserid' operator='eq' uitype='systemuser' value='{0}' />
    </filter>
  </entity>
</fetch>
", userId);
                #endregion
                EntityCollection retUsers = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retUsers.Entities.Count != 1) throw new InvalidPluginExecutionException("Could not find user");
                SystemUser u = retUsers.Entities[0].ToEntity<SystemUser>();
                retUser = u;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error obtaining User Business Unit in the ManualDiscountKill Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error obtaining User Business Unit in the ManualDiscountKill Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error obtaining User Business Unit in the ManualDiscountKill Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retUser;
        }
        internal static bool UserHasRoleId(IOrganizationService service, Guid _roleId, Guid _userId, ITracingService tracingService)
        {
            bool userInRole = false;

            LinkEntity systemUserLink = new LinkEntity()
            {
                LinkFromEntityName = SystemUserRoles.EntityLogicalName,
                LinkFromAttributeName = "systemuserid",
                LinkToEntityName = SystemUser.EntityLogicalName,
                LinkToAttributeName = "systemuserid",
                LinkCriteria =
                                {
                                    Conditions =
                                    {
                                        new ConditionExpression(
                                            "systemuserid", ConditionOperator.Equal, _userId)
                                    }
                                }
            };
            QueryExpression linkQuery = new QueryExpression()
            {
                EntityName = Role.EntityLogicalName,
                ColumnSet = new ColumnSet("roleid"),
                LinkEntities =
                                {
                                    new LinkEntity()
                                    {
                                        LinkFromEntityName = Role.EntityLogicalName,
                                        LinkFromAttributeName = "roleid",
                                        LinkToEntityName = SystemUserRoles.EntityLogicalName,
                                        LinkToAttributeName = "roleid",
                                        LinkEntities = {systemUserLink}
                                    }
                                },
                Criteria =
                                {
                                    Conditions =
                                    {
                                        new ConditionExpression("roleid", ConditionOperator.Equal, _roleId)
                                    }
                                }
            };
            EntityCollection matchEntities = service.RetrieveMultiple(linkQuery);
            userInRole = (matchEntities.Entities.Count > 0);
            return userInRole;
        }
        internal static Role getSecurityRole(IOrganizationService service, string _roleName, Guid _businessUnitId, ITracingService tracingService)
        {
            Role _Role = new Role();
            QueryExpression query = new QueryExpression
            {
                EntityName = Role.EntityLogicalName,
                ColumnSet = new ColumnSet("roleid", "name"),
                Criteria = new FilterExpression
                {
                    Conditions =
                                {

                                    new ConditionExpression
                                    {
                                        AttributeName = "name",
                                        Operator = ConditionOperator.Equal,
                                        Values = { _roleName }
                                    },
                                    new ConditionExpression
                                    {
                                        AttributeName = "businessunitid",
                                        Operator = ConditionOperator.Equal,
                                        Values = {_businessUnitId}
                                    },
                                }
                }
            };
            try
            {
                EntityCollection roles = service.RetrieveMultiple(query);
                if (roles.Entities.Count == 1)
                {
                    _Role = service.RetrieveMultiple(query).Entities[0].ToEntity<Role>();
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred while obtaining security role in ManualDiscountKill plug-in: {0}", ex.InnerException.ToString());
                tracingService.Trace("An error occurred while obtaining security role in ManualDiscountKill plug-in: {0}", ex.Message.ToString());
                tracingService.Trace("An error occurred while obtaining security role in ManualDiscountKill plug-in: {0}", ex.Detail.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while obtaining security role in ManualDiscountKill plug-in: {0}", ex.InnerException.ToString());
                tracingService.Trace("An error occurred while obtaining security role in ManualDiscountKill plug-in: {0}", ex.Message.ToString());
                throw;
            }
            #endregion ErrorHandling
            return _Role;
        }
        internal static bool UserHasRole(IOrganizationService service, Guid _userId, Guid _businessunitid, string _givenRole, ITracingService tracingService)
        {
            bool isUserInRole = false;
            try
            {
                #region FindRole
                QueryExpression query = new QueryExpression
                {
                    EntityName = Role.EntityLogicalName,
                    ColumnSet = new ColumnSet("roleid"),
                    Criteria = new FilterExpression
                    {
                        FilterOperator = LogicalOperator.And,
                        Conditions =
                        {
                            new ConditionExpression
                            {
                                AttributeName = "name",
                                Operator = ConditionOperator.Equal,
                                Values = {_givenRole}
                            },
                            new ConditionExpression()
                            {
                                AttributeName = "businessunitid",
                                Operator = ConditionOperator.Equal,
                                Values = {_businessunitid}
                            }
                        }
                    }
                };
                #endregion FindRole
                #region GetRole
                EntityCollection givenRoles = service.RetrieveMultiple(query);

                if (givenRoles.Entities.Count > 0)
                {
                    Role givenRole = givenRoles.Entities[0].ToEntity<Role>();
                    //Console.WriteLine("Checking association between user and role.");
                    // Establish a SystemUser link for a query.
                    LinkEntity systemUserLink = new LinkEntity()
                    {
                        LinkFromEntityName = SystemUserRoles.EntityLogicalName,
                        LinkFromAttributeName = "systemuserid",
                        LinkToEntityName = SystemUser.EntityLogicalName,
                        LinkToAttributeName = "systemuserid",
                        LinkCriteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression(
                                    "systemuserid", ConditionOperator.Equal, _userId)
                            }
                        }
                    };
                    #endregion GetRole
                    #region Query
                    QueryExpression linkQuery = new QueryExpression()
                    {
                        EntityName = Role.EntityLogicalName,
                        ColumnSet = new ColumnSet("roleid"),
                        LinkEntities =
                        {
                            new LinkEntity()
                            {
                                LinkFromEntityName = Role.EntityLogicalName,
                                LinkFromAttributeName = "roleid",
                                LinkToEntityName = SystemUserRoles.EntityLogicalName,
                                LinkToAttributeName = "roleid",
                                LinkEntities = {systemUserLink}
                            }
                        },
                        Criteria =
                        {
                            Conditions =
                            {
                                new ConditionExpression("roleid", ConditionOperator.Equal, givenRole.Id)
                            }
                        }
                    };
                    #endregion Query
                    // Retrieve matching roles.
                    EntityCollection matchEntities = service.RetrieveMultiple(linkQuery);

                    // if an entity is returned then the user is a member
                    // of the role
                    isUserInRole = (matchEntities.Entities.Count > 0);

                    //if (isUserInRole)
                    //    Console.WriteLine("User do not belong to the role.");
                    //else
                    //    Console.WriteLine("User belong to this role.");
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error restricting the win of opportunities in the userHasRole Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error restricting the win of opportunities in the userHasRole Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error restricting the win of opportunities in the userHasRole Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return isUserInRole;
        }
        internal static EntityCollection getQuoteDiscounts(IOrganizationService service, Guid quoteDetailId, ITracingService tracingService)
        {
            tracingService.Trace("method: getQuoteDiscounts");
            #region GetDiscounts
            string _productDiscountFetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_productdiscount'>
    <attribute name='azt_productdiscountid' />
    <filter type='and'>
      <condition attribute='azt_quoteproductid' operator='eq' uitype='quotedetail' value='{0}' />
    </filter>
  </entity>
</fetch>
", quoteDetailId);
            #endregion
            try
            {
                return service.RetrieveMultiple(new FetchExpression(_productDiscountFetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error retrieving Quote Line Discounts in the QuoteOrderProductsTrackDiscount Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error retrieving Quote Line Discounts in the QuoteOrderProductsTrackDiscount Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error retrieving Quote Line Discounts in the QuoteOrderProductsTrackDiscount Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        internal static EntityCollection getOpportunityDiscounts(IOrganizationService service, Guid quoteDetailId, ITracingService tracingService)
        {
            tracingService.Trace("method: getQuoteDiscounts");
            #region GetDiscounts
            string _productDiscountFetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_productdiscount'>
    <attribute name='azt_productdiscountid' />
    <filter type='and'>
      <condition attribute='azt_opportunityproductid' operator='eq' uitype='opportunityproduct' value='{0}' />
    </filter>
  </entity>
</fetch>
", quoteDetailId);
            #endregion
            try
            {
                return service.RetrieveMultiple(new FetchExpression(_productDiscountFetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error retrieving Opportunity Line Discounts in the QuoteOrderProductsTrackDiscount Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error retrieving Opportunity Line Discounts in the OpptyToQuoteFieldMappings Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error retrieving Opportunity Line Discounts in the OpptyToQuoteFieldMappings Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        internal static EntityReference GetCurrentProductRef(IOrganizationService service, EntityReference prodRef, ITracingService tracingService)
        {
            EntityReference er = new EntityReference();
            try
            {
                Entity prod = service.Retrieve(Product.EntityLogicalName, prodRef.Id, new ColumnSet("productid", "statecode", "azt_replacementproductid"));
                int stateCode = ((OptionSetValue)prod.Attributes["statecode"]).Value;
                if (stateCode == 1)
                {
                    if (prod.Attributes.Contains("azt_replacementproductid"))
                    {
                        er = (EntityReference)prod.Attributes["azt_replacementproductid"];
                    }
                    else throw new Exception("No replacement product found");

                    //                    string _fetch =
                    //string.Format(@"
                    //<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
                    //  <entity name='product'>
                    //    <attribute name='productid' />
                    //    <attribute name='statecode' />
                    //    <attribute name='azt_replacementproductid' />
                    //    <filter type='and'>
                    //      <condition attribute='productnumber' operator='eq' value='{0}' />
                    //    </filter>
                    //  </entity>
                    //</fetch>
                    //", prodRef.Id);

                    //EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                    //if (ec.Entities.Count == 1 && ec.Entities[0].Attributes.Contains("azt_replacementproductid"))
                    //    er = new EntityReference(Product.EntityLogicalName, (Guid)ec.Entities[0].Attributes["azt_replacementproductid"]);
                }
                else return prodRef;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred while Getting replacement product in the Clone function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred while Getting replacement product in the Clone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while Getting replacement product in the Clone function: {0}", ex.ToString());
                throw;
            }
            #endregion
            return er;
        }
        internal static decimal GetPaidPayments(Guid invId, IOrganizationService service)
        {
            #region Query
            string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_payment'>
    <attribute name='azt_amount' />
    <attribute name='azt_paymentid' />
    <order attribute='azt_name' descending='false' />
    <filter type='and'>
      <condition attribute='azt_invoiceid' operator='eq' uitype='invoice' value='{0}' />
      <condition attribute='statuscode' operator='eq' value='2' />
    </filter>
  </entity>
</fetch>
", invId);
            #endregion

            decimal calcAmt = 0;
            EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            foreach (var i in ec.Entities)
            {
                calcAmt += i.GetAttributeValue<Money>("azt_amount").Value;
            }
            return calcAmt;
        }
        internal static void SetPaidPercentage(IOrganizationService service, decimal paidAmt, decimal pmtAmt, Guid invId, Money invTotalAmt)
        {
            try
            {
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_payment'>
    <attribute name='azt_paymentdate' />
    <order attribute='azt_paymentdate' descending='true' />
    <filter type='and'>
      <condition attribute='azt_invoiceid' operator='eq' uitype='invoice' value='{0}' />
    </filter>
  </entity>
</fetch>
", invId);
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                DateTime pmtDate = (DateTime)ec.Entities[0].Attributes["azt_paymentdate"];
                decimal tot = (paidAmt + pmtAmt) / invTotalAmt.Value * 100;
                if (tot > 100) tot = 100m;
                Invoice inv = new Invoice()
                {
                    InvoiceId = invId,
                    azt_Paid = (int)tot,
                    azt_PaidOn = pmtDate,
                    azt_TotalAmountPaid = new Money(paidAmt)
                };
                service.Update(inv);
            }
            #region SyncronousErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
        }
        internal static bool GetCanApproveExpense(IOrganizationService service, EntityReference userToApproveRef, EntityReference expenseUserRef)
        {
            try
            {
                SystemUser expenseUserManager = service.Retrieve(SystemUser.EntityLogicalName, expenseUserRef.Id, new ColumnSet("parentsystemuserid")).ToEntity<SystemUser>();
                if (!expenseUserManager.Attributes.Contains("parentsystemuserid")) return false;
                else
                {
                    if (expenseUserManager.ParentSystemUserId.Id == userToApproveRef.Id) return true;
                    else
                    {
                        SystemUser expenseUserSecondManager = service.Retrieve(SystemUser.EntityLogicalName, expenseUserManager.Id, new ColumnSet("parentsystemuserid")).ToEntity<SystemUser>();
                        if (!expenseUserSecondManager.Attributes.Contains("parentsystemuserid")) return false;
                        else
                        {
                            if (expenseUserSecondManager.ParentSystemUserId.Id == userToApproveRef.Id) return true;
                            else
                            {
                                SystemUser expenseUserThirdManager = service.Retrieve(SystemUser.EntityLogicalName, expenseUserSecondManager.Id, new ColumnSet("parentsystemuserid")).ToEntity<SystemUser>();
                                if (!expenseUserThirdManager.Attributes.Contains("parentsystemuserid")) return false;
                                else
                                {
                                    if (expenseUserThirdManager.ParentSystemUserId.Id == userToApproveRef.Id) return true;
                                    else return false;
                                }
                            }
                        }
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the Utility Class in the ExpenseReportGetCanApproveAction Action." + ex.Detail.InnerFault.Message.ToString());
            }
            #endregion
        }
        internal static string GetOptionSetValueLabel(string entityName, string fieldName, int optionSetValue, IOrganizationService service)
        {
            var attReq = new RetrieveAttributeRequest();
            attReq.EntityLogicalName = entityName;
            attReq.LogicalName = fieldName;
            attReq.RetrieveAsIfPublished = true;

            var attResponse = (RetrieveAttributeResponse)service.Execute(attReq);
            var attMetadata = (EnumAttributeMetadata)attResponse.AttributeMetadata;

            return attMetadata.OptionSet.Options.Where(x => x.Value == optionSetValue).FirstOrDefault().Label.UserLocalizedLabel.Label;
        }
    }
}
