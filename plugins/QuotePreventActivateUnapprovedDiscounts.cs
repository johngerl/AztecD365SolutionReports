using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
namespace AztecPlugins
{
    public class QuotePreventActivateUnapprovedDiscounts : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity")
            {
                if (context.InputParameters.Contains("EntityMoniker") && context.InputParameters.Contains("State"))
                {
                    OptionSetValue _statecode = (OptionSetValue)context.InputParameters["State"];
                    if (_statecode.Value != (int)QuoteState.Active) return;
                    else
                    //if (_statecode.Value != 1) return;
                    //if (_statecode.Value == 1)
                    {
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        EntityReference quoteRef = (EntityReference)context.InputParameters["EntityMoniker"];
                        Quote quote = service.Retrieve(Quote.EntityLogicalName, quoteRef.Id, new ColumnSet("quoteid", "opportunityid")).ToEntity<Quote>();

                        tracingService.Trace("State: " + _statecode.Value + " QuoteId: " + quoteRef.Id);
                        bool discountsApproved = GetAllProductDiscountsApproved(service, tracingService, quoteRef.Id);
                        try
                        {
                            tracingService.Trace("Any Discounts Unapproved? " + discountsApproved);
                            if (!discountsApproved) throw new Exception("There are unapproved discounts on one or more Quote Products. Quotes cannot be Activated until all Discounts have been approved.");
                            else
                            {
                                DeleteOpportunityProducts(service, tracingService, quote.OpportunityId.Id);
                                ReplaceOpportunityLines(service, tracingService, quote);
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidPluginExecutionException(ex.Message);
                        }
                    }
                }
            }
        }
        private void DeleteOpportunityProducts(IOrganizationService service, ITracingService tracingService, Guid oppId)
        {
            try
            {
                #region Query
                QueryExpression Query = new QueryExpression()
                {
                    EntityName = OpportunityProduct.EntityLogicalName,
                    ColumnSet = new ColumnSet(false),
                    Criteria =
                    {
                        Filters =
                        {
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                                {
                                    new ConditionExpression("opportunityid", ConditionOperator.Equal, oppId)
                                }
                            }
                        }
                    }
                };
                #endregion
                EntityCollection retOpportunityProducts = service.RetrieveMultiple(Query);
                foreach (Entity OP in retOpportunityProducts.Entities)
                {
                    Guid OPId = (Guid)OP.Attributes["opportunityproductid"];
                    service.Delete(OpportunityProduct.EntityLogicalName, OPId);
                }
            }
            #region ErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
        }
        private void ReplaceOpportunityLines(IOrganizationService service, ITracingService tracingService, Quote quote)
        {
            try
            {
                EntityReference oppRef = quote.OpportunityId;
                #region Fields
                string[] _fields =
                {
"quotedetailid",
"productid",
"productdescription",
"uomid",
"azt_licensetermmonths",
"azt_licensetype",
"ispriceoverridden",
"priceperunit",
"quantity",
"baseamount",
"manualdiscountamount",
"tax",
"extendedamount"
                };
                #endregion
                #region Query
                QueryExpression Query = new QueryExpression()
                {
                    EntityName = QuoteDetail.EntityLogicalName,
                    ColumnSet = new ColumnSet(_fields),
                    Criteria =
                    {
                        Filters =
                        {
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                                {
                                    new ConditionExpression("quoteid", ConditionOperator.Equal, quote.QuoteId)
                                }
                            }
                        }
                    }
                };
                #endregion
                EntityCollection retQP = service.RetrieveMultiple(Query);
                foreach (Entity QP in retQP.Entities)
                {
                    Guid quoteLineId = (Guid)QP.Attributes["quotedetailid"];
                    Guid newOPId = Guid.Empty;
                    #region ExistingProducts
                    if (QP.Attributes.Contains("productid"))
                    {
                        EntityReference productId = (EntityReference)QP.Attributes["productid"];
                        EntityReference uomId = (EntityReference)QP.Attributes["uomid"];
                        int licenseTerm = QP.GetAttributeValue<int>("azt_licensetermmonths");
                        OptionSetValue licenseType = QP.Attributes.Contains("azt_licensetype") ? (OptionSetValue)QP.Attributes["azt_licensetype"] : new OptionSetValue(0);
                        bool priceOverridden = (bool)QP.Attributes["ispriceoverridden"];
                        Money pricePerUnit = QP.Attributes.Contains("priceperunit") ? (Money)QP.Attributes["priceperunit"] : new Money(0);
                        decimal qty = (decimal)QP.Attributes["quantity"];
                        Money manualDiscount = QP.Attributes.Contains("manualdiscountamount") ? (Money)QP.Attributes["manualdiscountamount"] : new Money(0);
                        Money tax = QP.Attributes.Contains("tax") ? (Money)QP.Attributes["tax"] : new Money(0);
                        EntityReference salesRep = QP.Attributes.Contains("salesrepid") ? (EntityReference)QP.Attributes["salesrepid"] : new EntityReference();
                        Money extAmt = QP.Attributes.Contains("extendedamount") ? (Money)QP.Attributes["extendedamount"] : new Money(0);
                        OpportunityProduct nOP = new OpportunityProduct()
                        {
                            OpportunityId = oppRef,
                            ProductId = productId,
                            UoMId = uomId,
                            IsPriceOverridden = priceOverridden,
                            Quantity = qty,
                            ManualDiscountAmount = manualDiscount,
                            Tax = tax
                        };
                        if (licenseTerm != 0) nOP.azt_LicenseTermMonths = licenseTerm;
                        if (licenseType.Value != 0) nOP.azt_LicenseType = licenseType;
                        if (priceOverridden)
                        {
                            nOP.PricePerUnit = pricePerUnit;
                            nOP.ExtendedAmount = extAmt;
                        }
                        newOPId = service.Create(nOP);
                    }
                    #endregion
                    #region WriteInProduct
                    else
                    {
                        string writeInProduct = QP.GetAttributeValue<string>("productdescription");
                        int licenseTerm = QP.GetAttributeValue<int>("azt_licensetermmonths");
                        OptionSetValue licenseType = QP.Attributes.Contains("azt_licensetype") ? (OptionSetValue)QP.Attributes["azt_licensetype"] : new OptionSetValue(0);
                        Money pricePerUnit = QP.Attributes.Contains("priceperunit") ? (Money)QP.Attributes["priceperunit"] : new Money(0);
                        decimal qty = (decimal)QP.Attributes["quantity"];
                        Money amt = (Money)QP.Attributes["baseamount"];
                        Money manualDiscount = QP.Attributes.Contains("manualdiscountamount") ? (Money)QP.Attributes["manualdiscountamount"] : new Money(0);
                        Money tax = QP.Attributes.Contains("tax") ? (Money)QP.Attributes["tax"] : new Money(0);
                        Money extAmt = QP.Attributes.Contains("extendedamount") ? (Money)QP.Attributes["extendedamount"] : new Money(0);
                        OpportunityProduct nOP = new OpportunityProduct()
                        {
                            OpportunityId = oppRef,
                            ProductDescription = writeInProduct,
                            IsProductOverridden = true,
                            PricePerUnit = pricePerUnit,
                            Quantity = qty,
                            BaseAmount = amt,
                            ManualDiscountAmount = manualDiscount,
                            Tax = tax,
                            ExtendedAmount = extAmt
                        };
                        if (licenseTerm != 0) nOP.azt_LicenseTermMonths = licenseTerm;
                        if (licenseType.Value != 0) nOP.azt_LicenseType = licenseType;
                        newOPId = service.Create(nOP);
                    }
                    #endregion
                    #region AppendDiscounts
                    #region Query
                    QueryExpression DiscountQuery = new QueryExpression()
                    {
                        EntityName = azt_productdiscount.EntityLogicalName,
                        ColumnSet = new ColumnSet(false),
                        Criteria =
                        {
                            Filters =
                            {
                                new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    Conditions =
                                    {
                                        new ConditionExpression("azt_quoteproductid", ConditionOperator.Equal, quoteLineId)
                                    }
                                }
                            }
                        }
                    };
                    #endregion
                    EntityCollection discounts = service.RetrieveMultiple(DiscountQuery);
                    foreach(Entity d in discounts.Entities)
                    {
                        Guid discId = (Guid)d.Attributes["azt_productdiscountid"];
                        azt_productdiscount uDisc = new azt_productdiscount()
                        {
                            azt_productdiscountId = discId,
                            azt_OpportunityProductId = new EntityReference(OpportunityProduct.EntityLogicalName, newOPId)
                        };
                        service.Update(uDisc);
                    }
                    #endregion
                }
            }
            #region ErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
        }
        private bool GetAllProductDiscountsApproved(IOrganizationService service, ITracingService tracingService, Guid quoteId)
        {
            bool allApproved = true;
            try
            {
                #region Query
                QueryExpression Query = new QueryExpression()
                {
                    EntityName = QuoteDetail.EntityLogicalName,
                    ColumnSet = new ColumnSet(false),
                    Criteria =
                    {
                        Filters =
                        {
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                                {
                                    new ConditionExpression("quoteid", ConditionOperator.Equal, quoteId)
                                }
                            }
                        }
                    }
                };
                #endregion
                EntityCollection retQuoteLines = service.RetrieveMultiple(Query);
                foreach (Entity QP in retQuoteLines.Entities)
                {
                    Guid QPId = (Guid)QP.Attributes["quotedetailid"];
                    tracingService.Trace("QuoteProductId: " + QPId.ToString());
                    if (ScanDiscountsForUnapproved(service, tracingService, QPId)) return false;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the QuotePreventActivateUnapprovedDiscounts Plugin: {0}", ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the QuotePreventActivateUnapprovedDiscounts Plugin: {0}", ex.InnerException.ToString());
                throw;
            }
            #endregion ErrorHandling
            return allApproved;
        }
        private bool ScanDiscountsForUnapproved(IOrganizationService service, ITracingService tracingService, Guid qPId)
        {
            bool anyDiscountsUnapproved = false;
            #region Query
            QueryExpression Query = new QueryExpression()
            {
                EntityName = azt_productdiscount.EntityLogicalName,
                ColumnSet = new ColumnSet("azt_approvalstatus"),
                Criteria =
                {
                    Filters =
                    {
                        new FilterExpression
                        {
                            FilterOperator = LogicalOperator.And,
                            Conditions =
                            {
                                new ConditionExpression("azt_quoteproductid", ConditionOperator.Equal, qPId)
                            }
                        }
                    }
                }
            };
            try
            {
                #endregion
                EntityCollection retDiscounts = service.RetrieveMultiple(Query);
                tracingService.Trace("Number of Discounts: " + retDiscounts.Entities.Count);
                if (retDiscounts.Entities.Count == 0) return false;
                foreach (Entity D in retDiscounts.Entities)
                {
                    if (D.Attributes.Contains("azt_approvalstatus"))
                    {
                        tracingService.Trace("Contains Approval Status: " + D.Attributes.Contains("azt_approvalstatus") + " Approval Status: " + ((OptionSetValue)D.Attributes["azt_approvalstatus"]).Value);
                        OptionSetValue appStatus = (OptionSetValue)D.Attributes["azt_approvalstatus"];
                        if (appStatus.Value != 276530001) return true;
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the QuotePreventActivateUnapprovedDiscounts Plugin: {0}", ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the QuotePreventActivateUnapprovedDiscounts Plugin: {0}", ex.InnerException.ToString());
                throw;
            }
            #endregion ErrorHandling
            return anyDiscountsUnapproved;
        }
    }
}
