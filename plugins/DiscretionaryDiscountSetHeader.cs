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
    public class DiscretionaryDiscountSetHeader : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #region Delete
            try
            {
                if (context.MessageName == "Delete" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference)
                {
                    EntityReference discountRef = (EntityReference)context.InputParameters["Target"];
                    Guid discountId = discountRef.Id;

                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    azt_productdiscount disc = service.Retrieve(azt_productdiscount.EntityLogicalName, discountId, new ColumnSet("azt_opportunityproductid", "azt_quoteproductid", "azt_orderproductid", "azt_invoiceproductid", "azt_discountamount")).ToEntity<azt_productdiscount>();
                    Money discountAmt = new Money(0);
                    if (disc.Contains("azt_discountamount"))
                    {
                        discountAmt = disc.azt_DiscountAmount;
                        #region Opportunity
                        if (disc.Contains("azt_opportunityproductid"))
                        {
                            OpportunityProduct p = service.Retrieve(OpportunityProduct.EntityLogicalName, disc.azt_OpportunityProductId.Id, new ColumnSet("opportunityid")).ToEntity<OpportunityProduct>();
                            Opportunity o = service.Retrieve(Opportunity.EntityLogicalName, p.OpportunityId.Id, new ColumnSet("statecode")).ToEntity<Opportunity>();
                            if (((OptionSetValue)o.Attributes["statecode"]).Value == 0)
                            {
                                Money OPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "opportunity", disc.azt_OpportunityProductId.Id);
                                Money newDiscountAmt = new Money(OPDiscretionaryDiscountAmt.Value - discountAmt.Value);
                                OpportunityProduct uOP = new OpportunityProduct()
                                {
                                    OpportunityProductId = disc.azt_OpportunityProductId.Id,
                                    ManualDiscountAmount = newDiscountAmt
                                };
                                service.Update(uOP);
                            }
                        }
                        #endregion
                        #region Quote
                        if (disc.Contains("azt_quoteproductid") && IsQuoteUpdateable(tracingService, service, disc.azt_QuoteProductId.Id))
                        {
                            //QuoteDetail ql = service.Retrieve(QuoteDetail.EntityLogicalName, disc.azt_QuoteProductId.Id, new ColumnSet("quoteid")).ToEntity<QuoteDetail>();
                            //Quote q = service.Retrieve(Quote.EntityLogicalName, ql.QuoteId.Id, new ColumnSet("statecode")).ToEntity<Quote>();

                            Money QPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "quote", disc.azt_QuoteProductId.Id);
                            Money newDiscountAmt = new Money(QPDiscretionaryDiscountAmt.Value - discountAmt.Value);
                            QuoteDetail uQD = new QuoteDetail()
                            {
                                QuoteDetailId = disc.azt_QuoteProductId.Id,
                                azt_DiscretionaryDiscountAmt = newDiscountAmt
                            };
                            service.Update(uQD);
                        }
                        #endregion
                        #region Order
                        if (disc.Contains("azt_orderproductid") && IsOrderUpdateable(tracingService, service, disc.azt_OrderProductId.Id))
                        {
                            Money OPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "order", disc.azt_OrderProductId.Id);
                            Money newDiscountAmt = new Money(OPDiscretionaryDiscountAmt.Value - discountAmt.Value);
                            SalesOrderDetail uOD = new SalesOrderDetail()
                            {
                                SalesOrderDetailId = disc.azt_OrderProductId.Id,
                                azt_DiscretionaryDiscountAmt = newDiscountAmt
                            };
                            service.Update(uOD);
                        }
                        #endregion
                        #region Invoice
                        if (disc.Contains("azt_invoiceproductid") && InvoiceUpdateable(tracingService, service, disc.azt_InvoiceProductId.Id))
                        {
                            Money IPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "invoice", disc.azt_InvoiceProductId.Id);
                            Money newDiscountAmt = new Money(IPDiscretionaryDiscountAmt.Value - discountAmt.Value);
                            InvoiceDetail uID = new InvoiceDetail()
                            {
                                InvoiceDetailId = disc.azt_InvoiceProductId.Id,
                                azt_DiscretionaryDiscountAmt = newDiscountAmt
                            };
                            service.Update(uID);
                        }
                        #endregion
                    }
                }
            }
            #endregion
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the DiscretionaryDiscountSetHeader plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_productdiscount.EntityLogicalName)
            {
                try
                {
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #region Create
                    if (context.MessageName == "Create")
                    {
                        azt_productdiscount cDisc = ((Entity)context.InputParameters["Target"]).ToEntity<azt_productdiscount>();
                        #region OppLine
                        if (cDisc.Contains("azt_opportunityproductid"))
                        {
                            EntityReference OPRef = cDisc.azt_OpportunityProductId;
                            #region SetOpportunityOnDiscount
                            if (!cDisc.Contains("azt_opportunityid"))
                            {
                                OpportunityProduct OPPLine = service.Retrieve(OpportunityProduct.EntityLogicalName, OPRef.Id, new ColumnSet("opportunityid")).ToEntity<OpportunityProduct>();
                                azt_productdiscount setOpp = new azt_productdiscount()
                                {
                                    azt_productdiscountId = (Guid)cDisc.azt_productdiscountId,
                                    azt_OpportunityId = OPPLine.OpportunityId
                                };
                                service.Update(setOpp);
                                //cDisc.azt_OpportunityId = OPPLine.OpportunityId;
                            }
                            #endregion
                            #region SetCustomer
                            Opportunity opp = service.Retrieve(Opportunity.EntityLogicalName, cDisc.azt_OpportunityId.Id, new ColumnSet("parentaccountid")).ToEntity<Opportunity>();
                            EntityReference acctRef = opp.ParentAccountId;
                            cDisc.azt_CustomerId = acctRef;
                            #endregion
                            #region UpdateOP
                            Money OPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "opportunity", OPRef.Id);
                            OpportunityProduct uOP = new OpportunityProduct()
                            {
                                OpportunityProductId = OPRef.Id,
                                azt_DiscretionaryDiscountAmt = OPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = OPDiscretionaryDiscountAmt
                            };
                            service.Update(uOP);
                            #endregion
                        }
                        #endregion
                        #region QuoteLine
                        if (cDisc.Contains("azt_quoteproductid"))
                        {
                            QuoteDetail QD = (service.Retrieve(QuoteDetail.EntityLogicalName, cDisc.azt_QuoteProductId.Id, new ColumnSet("azt_opportunityproductid"))).ToEntity<QuoteDetail>();
                            if (!QD.Contains("azt_opportunityproductid")) throw new InvalidPluginExecutionException("The Quote Line does not refer to an Opportunity Line. Please delete the quote and re-create from the Opportunity.");
                            SetOppLineReference(tracingService, service, cDisc, QD);
                            cDisc.azt_OpportunityProductId = QD.azt_OpportunityProductId;
                            #region UpdateQuoteLine
                            Money QPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "quote", cDisc.azt_QuoteProductId.Id);
                            QuoteDetail uQD = new QuoteDetail()
                            {
                                QuoteDetailId = cDisc.azt_QuoteProductId.Id,
                                azt_DiscretionaryDiscountAmt = QPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = QPDiscretionaryDiscountAmt
                            };
                            service.Update(uQD);
                            #endregion
                        }
                        if (!cDisc.Contains("azt_opportunityproductid") && !cDisc.Contains("azt_quoteproductid")) throw new InvalidPluginExecutionException("Discounts must be created from an Opportunity or a Quote Line!");
                        #endregion
                        #region OrderLine
                        if (cDisc.Contains("azt_orderproductid"))
                        {
                            throw new InvalidPluginExecutionException("Discounts can only be created from Opportunities or Quotes.");
                            #region UpdateOPLine
                            Money OPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "order", cDisc.azt_OrderProductId.Id);
                            SalesOrderDetail uOD = new SalesOrderDetail()
                            {
                                SalesOrderDetailId = cDisc.azt_OrderProductId.Id,
                                azt_DiscretionaryDiscountAmt = OPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = OPDiscretionaryDiscountAmt
                            };
                            service.Update(uOD);
                            #endregion
                        }
                        #endregion
                        #region InvoiceLine
                        if (cDisc.Contains("azt_invoiceproductid"))
                        {
                            throw new InvalidPluginExecutionException("Discounts can only be created from Opportunities or Quotes.");
                            #region UpdateIP
                            Money IPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "invoice", cDisc.azt_InvoiceProductId.Id);
                            InvoiceDetail uID = new InvoiceDetail()
                            {
                                InvoiceDetailId = cDisc.azt_InvoiceProductId.Id,
                                azt_DiscretionaryDiscountAmt = IPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = IPDiscretionaryDiscountAmt
                            };
                            service.Update(uID);
                            #endregion
                        }
                        #endregion
                    }
                    #endregion
                    #region Update
                    else if (context.MessageName == "Update")
                    {
                        azt_productdiscount postDisc = (context.PostEntityImages["PostDiscount"]).ToEntity<azt_productdiscount>();
                        #region OppLine
                        if (postDisc.Contains("azt_opportunityproductid") && IsOppUpdateable(tracingService, service, postDisc.azt_OpportunityProductId.Id))
                        {
                            Money OPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "opportunity", postDisc.azt_OpportunityProductId.Id);
                            OpportunityProduct uOP = new OpportunityProduct()
                            {
                                OpportunityProductId = postDisc.azt_OpportunityProductId.Id,
                                azt_DiscretionaryDiscountAmt = OPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = OPDiscretionaryDiscountAmt
                            };
                            service.Update(uOP);
                        }
                        #endregion
                        #region QuoteLine
                        if (postDisc.Contains("azt_quoteproductid") && IsQuoteUpdateable(tracingService, service, postDisc.azt_QuoteProductId.Id))
                        {
                            #region UpdateQuoteLine
                            Money QPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "quote", postDisc.azt_QuoteProductId.Id);
                            QuoteDetail uQD = new QuoteDetail()
                            {
                                QuoteDetailId = postDisc.azt_QuoteProductId.Id,
                                azt_DiscretionaryDiscountAmt = QPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = QPDiscretionaryDiscountAmt
                            };
                            service.Update(uQD);
                            #endregion
                        }
                        #endregion
                        #region OrderLine
                        if (postDisc.Contains("azt_orderproductid") && IsOrderUpdateable(tracingService, service, postDisc.azt_OrderProductId.Id))
                        {
                            Money OPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "order", postDisc.azt_OrderProductId.Id);
                            SalesOrderDetail uOD = new SalesOrderDetail()
                            {
                                SalesOrderDetailId = postDisc.azt_OrderProductId.Id,
                                azt_DiscretionaryDiscountAmt = OPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = OPDiscretionaryDiscountAmt
                            };
                            service.Update(uOD);
                        }
                        #endregion
                        #region InvoiceLine
                        if (postDisc.Contains("azt_invoiceproductid") && InvoiceUpdateable(tracingService, service, postDisc.azt_InvoiceProductId.Id))
                        {
                            Money IPDiscretionaryDiscountAmt = GetLineDiscountAmts(service, tracingService, "invoice", postDisc.azt_InvoiceProductId.Id);
                            InvoiceDetail uID = new InvoiceDetail()
                            {
                                InvoiceDetailId = postDisc.azt_InvoiceProductId.Id,
                                azt_DiscretionaryDiscountAmt = IPDiscretionaryDiscountAmt,
                                ManualDiscountAmount = IPDiscretionaryDiscountAmt
                            };
                            service.Update(uID);
                        }
                        #endregion
                    }
                    #endregion
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the DiscretionaryDiscountSetHeader plug-in.", ex);
                }

                catch (Exception ex)
                {
                    tracingService.Trace("An error occurred in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private static void SetOppLineReference(ITracingService tracingService, IOrganizationService service, azt_productdiscount cDisc, QuoteDetail QD)
        {
            try
            {
                OpportunityProduct OP = service.Retrieve(OpportunityProduct.EntityLogicalName, QD.azt_OpportunityProductId.Id, new ColumnSet("opportunityid")).ToEntity<OpportunityProduct>();
                azt_productdiscount uDiscount = new azt_productdiscount() 
                { 
                    azt_productdiscountId = (Guid)cDisc.azt_productdiscountId, 
                    azt_OpportunityProductId = QD.azt_OpportunityProductId,
                    azt_OpportunityId = OP.OpportunityId
                };
                service.Update(uDiscount);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred setting the Opportunity Line Reference in the Discount in the DiscretionaryDiscountSetHeader plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred setting the Opportunity Line Reference in the Discount in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private bool InvoiceUpdateable(ITracingService tracingService, IOrganizationService service, Guid id)
        {
            bool canUpdate = false;
            try
            {
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='invoicedetail'>
    <attribute name='invoicedetailid' />
    <filter type='and'>
      <condition attribute='invoicedetailid' operator='eq' uitype='invoicedetail' value='{0}' />
    </filter>
    <link-entity name='invoice' from='invoiceid' to='invoiceid' link-type='inner' alias='aj'>
      <filter type='and'>
        <condition attribute='statecode' operator='eq' value='0' />
      </filter>
    </link-entity>
  </entity>
</fetch>
", id);
                EntityCollection retRecs = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retRecs.Entities.Count > 0) canUpdate = true;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred while determining if the Order was editable in the DiscretionaryDiscountSetHeader plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while determining if the Order was editable in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return canUpdate;
        }
        private bool IsOrderUpdateable(ITracingService tracingService, IOrganizationService service, Guid id)
        {
            bool canUpdate = false;
            try
            {
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='salesorderdetail'>
    <attribute name='salesorderdetailid' />
    <filter type='and'>
      <condition attribute='salesorderdetailid' operator='eq' uitype='salesorderdetail' value='{0}' />
    </filter>
    <link-entity name='salesorder' from='salesorderid' to='salesorderid' link-type='inner' alias='ai'>
      <filter type='and'>
        <condition attribute='statecode' operator='in'>
          <value>1</value>
          <value>0</value>
        </condition>
      </filter>
    </link-entity>
  </entity>
</fetch>
", id);
                EntityCollection retRecs = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retRecs.Entities.Count > 0) canUpdate = true;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred while determining if the Order was editable in the DiscretionaryDiscountSetHeader plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while determining if the Order was editable in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return canUpdate;
        }
        private bool IsQuoteUpdateable(ITracingService tracingService, IOrganizationService service, Guid id)
        {
            bool canUpdate = false;
            try
            {
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quotedetail'>
    <attribute name='quotedetailid' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='quotedetailid' operator='eq' uitype='quotedetail' value='{0}' />
    </filter>
    <link-entity name='quote' from='quoteid' to='quoteid' link-type='inner' alias='ah'>
      <filter type='and'>
        <condition attribute='statecode' operator='eq' value='0' />
      </filter>
    </link-entity>
  </entity>
</fetch>
", id);
                EntityCollection retRecs = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retRecs.Entities.Count > 0) canUpdate = true;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred while determining if the Quote was editable in the DiscretionaryDiscountSetHeader plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while determining if the Quote was editable in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return canUpdate;
        }
        private bool IsOppUpdateable(ITracingService tracingService, IOrganizationService service, Guid opId)
        {
            bool canUpdate = false;
            try
            {

                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='opportunityproduct'>
    <attribute name='opportunityproductid' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='opportunityproductid' operator='eq' uitype='opportunityproduct' value='{0}' />
    </filter>
    <link-entity name='opportunity' from='opportunityid' to='opportunityid' link-type='inner' alias='Opp'>
      <filter type='and'>
        <condition attribute='statecode' operator='eq' value='0' />
      </filter>
    </link-entity>
  </entity>
</fetch>
", opId);
                EntityCollection retOpps = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retOpps.Entities.Count > 0) canUpdate = true;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred while determining if the Opp was editable in the DiscretionaryDiscountSetHeader plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while determining if the Opp was editable in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return canUpdate;
        }
        private Money GetLineDiscountAmts(IOrganizationService service, ITracingService tracingService, string entityName, Guid id)
        {
            tracingService.Trace("Getting Line Discount Amounts");
            Money retAmt = new Money(0);
            try
            {
                string condition = string.Empty;
                switch (entityName)
                {
                    case "opportunity":
                        condition = "azt_opportunityproductid";
                        break;
                    case "quote":
                        condition = "azt_quoteproductid";
                        break;
                    case "order":
                        condition = "azt_orderproductid";
                        break;
                    case "invoice":
                        condition = "azt_invoiceproductid";
                        break;
                }
                string _fetch =
    string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_productdiscount'>
    <attribute name='azt_discountamount' />
    <filter type='and'>
      <condition attribute='{0}' operator='eq' value='{1}' />
    </filter>
  </entity>
</fetch>
", condition, id);
                EntityCollection discounts = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (Entity d in discounts.Entities)
                {
                    Money disc = (Money)d.Attributes["azt_discountamount"];
                    retAmt.Value += disc.Value;
                }
                tracingService.Trace("Total Discounts for " + entityName);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error in GetLineDiscountAmts: " + ex);
                throw new InvalidPluginExecutionException("An error occurred obtaining Line Discounts in the DiscretionaryDiscountSetHeader plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred obtaining Line Discounts in the DiscretionaryDiscountSetHeader plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retAmt;
        }
    }
}
