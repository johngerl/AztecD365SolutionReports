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
    public class QuoteLinesSyncToOppty : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            try
            {
                #region QuoteLine
                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName)
                {
                    if (context.Depth > 1) return;
                    #region Create
                    if (context.MessageName == "Create")
                    {
                        try
                        {
                            #region Fields
                            string writeInProduct = string.Empty;
                            EntityReference productRef = new EntityReference();
                            EntityReference uomRef = new EntityReference();
                            Money manualDiscountAmt = new Money(0);
                            Money tax = new Money(0);
                            #endregion
                            QuoteDetail contextQuoteDetail = ((Entity)context.InputParameters["Target"]).ToEntity<QuoteDetail>();
                            Guid quoteDetailId = (Guid)contextQuoteDetail.QuoteDetailId;
                            decimal qty = contextQuoteDetail.GetAttributeValue<decimal>("quantity");
                            EntityReference quoteRef = contextQuoteDetail.QuoteId; tracingService.Trace("QuoteId: " + quoteRef.Id);
                            Guid oppId = GetOpportunityId(tracingService, service, quoteRef.Id); tracingService.Trace("OppId: " + oppId);
                            if (oppId == Guid.Empty) return;
                            if (contextQuoteDetail.Contains("productid")) productRef = contextQuoteDetail.ProductId;
                            if (contextQuoteDetail.Contains("productdescription")) writeInProduct = contextQuoteDetail.ProductDescription;
                            if (contextQuoteDetail.Contains("manualdiscountamount")) manualDiscountAmt = contextQuoteDetail.ManualDiscountAmount;
                            if (contextQuoteDetail.Contains("uomid")) uomRef = contextQuoteDetail.UoMId;
                            OpportunityProduct nOP = new OpportunityProduct()
                            {
                                OpportunityId = new EntityReference(Opportunity.EntityLogicalName, oppId),
                                Quantity = qty
                            };
                            if (productRef != null && productRef.Id != Guid.Empty) nOP.ProductId = productRef;
                            if (writeInProduct != string.Empty) nOP.ProductDescription = writeInProduct;
                            if (manualDiscountAmt.Value > 0) nOP.ManualDiscountAmount = manualDiscountAmt;
                            if (uomRef != null && uomRef.Id != Guid.Empty) nOP.UoMId = uomRef;
                            Guid nOPId = service.Create(nOP);
                            QuoteDetail uQD = new QuoteDetail()
                            {
                                QuoteDetailId = quoteDetailId,
                                azt_OpportunityProductId = new EntityReference(OpportunityProduct.EntityLogicalName, nOPId)
                            };
                            service.Update(uQD);
                        }
                        #region ErrorHandling
                        catch (FaultException<OrganizationServiceFault> ex)
                        {
                            tracingService.Trace("An error occurred creating Opportunity Line in the QuoteLinesSyncToOpportunity plugin: {0}", ex);
                        }
                        catch (Exception ex)
                        {
                            tracingService.Trace("An error occurred creating Opportunity Line in the QuoteLinesSyncToOpportunity plugin: {0}", ex.ToString());
                            throw;
                        }
                        #endregion
                    }
                    #endregion
                    #region Update
                    if (context.MessageName == "Update")
                    {
                        Entity quoteDetailContext = (Entity)context.InputParameters["Target"];
                        EntityReference productRef = new EntityReference();
                        QuoteDetail preQD = ((Entity)context.PreEntityImages["PreQP"]).ToEntity<QuoteDetail>();
                        QuoteDetail postQD = ((Entity)context.PostEntityImages["PostQP"]).ToEntity<QuoteDetail>();
                        QuoteDetail preQDContext = new QuoteDetail();
                        #region Fields
                        EntityReference preProdRef = preQD.ProductId;
                        EntityReference postProdRef = postQD.ProductId;
                        EntityReference changedUnit = GetChangedUOM(tracingService, service, preProdRef, postProdRef);
                        EntityReference preQuoteRef = preQD.QuoteId;
                        Money extAmt = preQD.ExtendedAmount;
                        decimal qty = 0.0m;
                        Money manualDiscountAmt = new Money(0);
                        Money tax = new Money(0);
                        string writeInProduct = string.Empty;
                        #endregion

                        if (context.ParentContext.ParentContext != null)
                            preQDContext = ((Entity)context.ParentContext.ParentContext.InputParameters["Target"]).ToEntity<QuoteDetail>();
                        #region Qty
                        decimal changedQty = GetChangedQTY(preQD, postQD);
                        if (changedQty > 0.0m) { qty = changedQty; }
                        else
                        {
                            if (quoteDetailContext.Contains("quantity"))
                                qty = quoteDetailContext.GetAttributeValue<decimal>("quantity");
                        }
                        #endregion
                        #region Product
                        if (quoteDetailContext.Contains("productid"))
                        {
                            productRef = quoteDetailContext.GetAttributeValue<EntityReference>("productid");
                        }
                        else if (preQDContext.Contains("productid"))
                        {
                            productRef = preQDContext.ProductId;
                        }
                        #endregion
                        if (quoteDetailContext.Contains("productdescription"))
                            writeInProduct = quoteDetailContext.GetAttributeValue<string>("productdescription");
                        if (quoteDetailContext.Contains("manualdiscountamount"))
                            manualDiscountAmt = quoteDetailContext.GetAttributeValue<Money>("manualdiscountamount");
                        if (quoteDetailContext.Contains("tax"))
                            tax = quoteDetailContext.GetAttributeValue<Money>("tax");

                        Guid oppId = GetOpportunityId(tracingService, service, preQuoteRef.Id); if (oppId == Guid.Empty) return;
                        EntityCollection retOppLines = GetOpportunityLines(service, preProdRef, extAmt, writeInProduct, oppId);
                        if (retOppLines.Entities.Count == 0) throw new InvalidPluginExecutionException("No matching opportunity lines found.");
                        OpportunityProduct op = (retOppLines.Entities[0]).ToEntity<OpportunityProduct>();
                        Guid opId = (Guid)op.OpportunityProductId;
                        OpportunityProduct uOP = new OpportunityProduct()
                        {
                            OpportunityProductId = opId
                        };
                        if (qty > 0.0m) uOP.Quantity = qty;
                        if (productRef != null && productRef.Id != Guid.Empty) uOP.ProductId = productRef;
                        if (changedUnit != null && changedUnit.Id != Guid.Empty) uOP.UoMId = changedUnit;
                        if (quoteDetailContext.Contains("manualdiscountamount")) uOP.ManualDiscountAmount = manualDiscountAmt;
                        if (quoteDetailContext.Contains("tax")) uOP.Tax = tax;
                        service.Update(uOP);
                    }
                    #endregion
                }
                #region Delete
                if (context.MessageName == "Delete" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference)
                {
                    try
                    {
                        if (context.ParentContext != null && context.ParentContext.PrimaryEntityName == "quote") return;
                        EntityReference preProdRef = new EntityReference();
                        string writeInProduct = string.Empty;
                        QuoteDetail delQuoteLine = (context.PreEntityImages["PreDeleteQD"]).ToEntity<QuoteDetail>();
                        if (!delQuoteLine.Contains("quoteid")) return;
                        EntityReference quoteRef = delQuoteLine.QuoteId;
                        EntityReference quoteLineRef = (EntityReference)context.InputParameters["Target"];
                        Guid oppId = GetOpportunityId(tracingService, service, quoteRef.Id);
                        if (delQuoteLine.Contains("productdescription")) writeInProduct = delQuoteLine.ProductDescription;
                        if (delQuoteLine.Contains("productid")) preProdRef = delQuoteLine.ProductId;
                        Money extAmt = delQuoteLine.ExtendedAmount;

                        EntityCollection retOppLines = GetOpportunityLines(service, preProdRef, extAmt, writeInProduct, oppId);
                        if (retOppLines.Entities.Count == 0) throw new InvalidPluginExecutionException("No matching opportunity lines found.");
                        OpportunityProduct op = (retOppLines.Entities[0]).ToEntity<OpportunityProduct>();
                        service.Delete(OpportunityProduct.EntityLogicalName, (Guid)op.OpportunityProductId);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("An error occurred while deleting a Quote Line in the QuoteLinesSyncToOpportunity plugin: {0}", ex);
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("An error occurred while deleting a Quote Line in the QuoteLinesSyncToOpportunity plugin: {0}", ex.ToString());
                        throw;
                    }
                    #endregion
                }
                #endregion
                #endregion
                #region Quote
                if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Quote.EntityLogicalName)
                {
                    try
                    {
                        #region Fields
                        decimal discountPercent = 0.0m;
                        Money discountAmt = new Money(0);
                        #endregion
                        Quote quote = ((Entity)context.InputParameters["Target"]).ToEntity<Quote>();
                        Quote preQuote = ((Entity)context.PreEntityImages["PreQuote"]).ToEntity<Quote>();
                        if (!preQuote.Contains("opportunityid")) return;
                        EntityReference oppRef = preQuote.OpportunityId;
                        Guid quoteId = (Guid)quote.QuoteId;
                        if (quote.Contains("discountpercentage")) discountPercent = (decimal)quote.DiscountPercentage;
                        if (quote.Contains("discountamount")) discountAmt = quote.DiscountAmount;
                        Opportunity uOpp = new Opportunity()
                        {
                            OpportunityId = oppRef.Id
                        };
                        if (quote.Contains("discountpercentage")) uOpp.DiscountPercentage = discountPercent;
                        if (quote.Contains("discountamount")) uOpp.DiscountAmount = discountAmt;
                        service.Update(uOpp);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("An error occurred while updating a Quote in the QuoteLinesSyncToOpportunity plugin: {0}", ex);
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("An error occurred while updating a Quote in the QuoteLinesSyncToOpportunity plugin: {0}", ex.ToString());
                        throw;
                    }
                    #endregion
                }
                #endregion
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the QuoteLinesSyncToOpportunity plugin: {0}", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the QuoteLinesSyncToOpportunity plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private static EntityCollection GetOpportunityLines(IOrganizationService service, EntityReference preProdRef, Money extAmt, string writeInProduct, Guid oppId)
        {
            #region QueryForOppLines
            string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='opportunityproduct'>
    <attribute name='opportunityproductid' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='opportunityid' operator='eq' uitype='opportunity' value='{0}' />
      <filter type='or'>
        <condition attribute='productid' operator='eq' uitype='product' value='{1}' />
        <condition attribute='productdescription' operator='eq' value='{2}' />
      </filter>
      <condition attribute='extendedamount' operator='eq' value='{3}' />
    </filter>
  </entity>
</fetch>
", oppId, preProdRef.Id, writeInProduct, extAmt.Value);
            #endregion
            EntityCollection retOppLines = service.RetrieveMultiple(new FetchExpression(_fetch));
            return retOppLines;
        }
        private EntityReference GetChangedUOM(ITracingService tracingService, IOrganizationService service, EntityReference preProdRef, EntityReference postProdRef)
        {
            EntityReference newUOM = new EntityReference();
            try
            {
                if (preProdRef.Id != postProdRef.Id)
                {
                    Product preProductRef = service.Retrieve(Product.EntityLogicalName, preProdRef.Id, new ColumnSet("defaultuomid")).ToEntity<Product>();
                    Product postProductRef = service.Retrieve(Product.EntityLogicalName, postProdRef.Id, new ColumnSet("defaultuomid")).ToEntity<Product>();
                    if (preProductRef.DefaultUoMId.Id != postProductRef.DefaultUoMId.Id) newUOM = postProductRef.DefaultUoMId;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred getting new UOM in the QuoteLinesSyncToOpportunity plugin: {0}", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting new UOM in the QuoteLinesSyncToOpportunity plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return newUOM;
        }
        private decimal GetChangedQTY(QuoteDetail preQD, QuoteDetail postQD)
        {
            decimal returnValue = 0.0m;
            decimal preValue = preQD.GetAttributeValue<decimal>("quantity");
            decimal postValue = postQD.GetAttributeValue<decimal>("quantity");
            if (preValue != postValue) return postValue;
            return returnValue;
        }
        private Guid GetOpportunityId(ITracingService tracingService, IOrganizationService service, Guid quoteId)
        {
            Guid id = Guid.Empty;
            try
            {
                Quote quote = ((Entity)service.Retrieve(Quote.EntityLogicalName, quoteId, new ColumnSet("opportunityid"))).ToEntity<Quote>();
                if (quote.Contains("opportunityid")) id = quote.OpportunityId.Id;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred getting OpportunityId in the QuoteLinesSyncToOpportunity plugin: {0}", ex.ToString());
                tracingService.Trace("An error occurred getting OpportunityId in the QuoteLinesSyncToOpportunity plugin: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred getting OpportunityId in the QuoteLinesSyncToOpportunity plugin." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting OpportunityId in the QuoteLinesSyncToOpportunity plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return id;
        }
    }
}
