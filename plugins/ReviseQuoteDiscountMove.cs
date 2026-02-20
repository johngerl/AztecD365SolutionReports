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
    public class ReviseQuoteDiscountMove : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName && context.ParentContext.ParentContext != null && context.ParentContext.ParentContext.MessageName == "Revise")
            {
                try
                {
                    QuoteDetail newQD = ((Entity)context.InputParameters["Target"]).ToEntity<QuoteDetail>();

                    EntityReference newQuoteRef = newQD.QuoteId;
                    Quote uQuote = new Quote()
                    {
                        QuoteId = newQuoteRef.Id,
                        DiscountAmount = null
                    };
                    try
                    {
                        service.Update(uQuote);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        throw new InvalidPluginExecutionException(ex.Message);
                    }

                    catch (Exception ex)
                    {
                        tracingService.Trace("ReviseQuoteDiscountMove: {0}", ex.ToString());
                        throw;
                    }
                    #endregion ErrorHandling

                    
                    Guid parentQuoteId = (Guid)context.ParentContext.ParentContext.InputParameters["QuoteId"];

                    EntityReference newProdRef = newQD.GetAttributeValue<EntityReference>("productid");
                    decimal newQty = (decimal)newQD.Quantity;
                    //Money newExtAmt = newQDId.ExtendedAmount;
                    string newWriteIn = newQD.GetAttributeValue<string>("productdescription");

                    Guid originalQDId = Guid.Empty;
                    EntityCollection retParentLines = GetParentQuoteLines(tracingService, service, parentQuoteId); if (retParentLines.Entities.Count == 0) return;
                    //EntityCollection retNewQuoteLines = GetNewQuoteLines(tracingService, service, newQuoteRef.Id);
                    foreach (var p in retParentLines.Entities)
                    {
                        if (newProdRef != null && newProdRef.Id != Guid.Empty)
                        {
                            EntityReference prodId = p.GetAttributeValue<EntityReference>("productid");
                            decimal qty = p.GetAttributeValue<decimal>("quantity");
                            Money extAmt = p.GetAttributeValue<Money>("extendedamount");

                            if(prodId.Id == newProdRef.Id && qty == newQty)
                            {
                                originalQDId = (Guid)p.Attributes["quotedetailid"];
                                EntityCollection retDiscounts = GetDiscounts(tracingService, service, originalQDId);
                                if(retDiscounts.Entities.Count > 0)
                                {
                                    foreach (var d in retDiscounts.Entities)
                                    {
                                        Guid discId = (Guid)d.Attributes["azt_productdiscountid"];
                                        azt_productdiscount u = new azt_productdiscount()
                                        {
                                            azt_productdiscountId = discId,
                                            azt_QuoteProductId = new EntityReference(QuoteDetail.EntityLogicalName, (Guid)newQD.QuoteDetailId)
                                        }; service.Update(u);
                                    }
                                }
                            }
                        }
                        else
                        {
                            decimal qty = p.GetAttributeValue<decimal>("quantity");
                            string writeInProduct = p.GetAttributeValue<string>("productdescription");

                            if(writeInProduct == newWriteIn && qty == newQty)
                            {
                                originalQDId = (Guid)p.Attributes["quotedetailid"];
                            }
                        }

                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }

                catch (Exception ex)
                {
                    tracingService.Trace("ReviseQuoteDiscountMove: {0}", ex.ToString());
                    throw;
                }
                #endregion ErrorHandling
            }
        }
        private EntityCollection GetDiscounts(ITracingService tracingService, IOrganizationService service, Guid originalQDId)
        {
            EntityCollection col = new EntityCollection();
            try
            {
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_productdiscount'>
    <attribute name='azt_productdiscountid' />
    <order attribute='azt_name' descending='false' />
    <filter type='and'>
      <condition attribute='azt_quoteproductid' operator='eq' uitype='quotedetail' value='{0}' />
    </filter>
  </entity>
</fetch>
", originalQDId);
                col = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting Discounts in the ReviseQuoteDiscountMove plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting Discounts in the ReviseQuoteDiscountMove plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion ErrorHandling
            return col;
        }

        private Guid GetQuoteLineId(ITracingService tracingService, EntityCollection retNewQuoteLines, Guid prodId, decimal qty, Money extAmt, string writeInProduct)
        {
            Guid id = Guid.Empty;
            try
            {
                foreach (var i in retNewQuoteLines.Entities)
                {
                    if (prodId != Guid.Empty)
                    {
                        Guid newProdId = (Guid)i.GetAttributeValue<Guid>("productid");
                        decimal newQty = i.GetAttributeValue<decimal>("quantity");
                        Money newExtAmt = i.GetAttributeValue<Money>("extendedamount");
                        if (newProdId == prodId && newQty == qty) id = (Guid)i.GetAttributeValue<Guid>("quotedetailid");
                    }
                    else if (writeInProduct != string.Empty)
                    {
                        decimal newQty = i.GetAttributeValue<decimal>("quantity");
                        Money newExtAmt = i.GetAttributeValue<Money>("extendedamount");
                        string newWriteIn = i.GetAttributeValue<string>("productdescription");
                        if (newWriteIn == writeInProduct && newQty == qty) id = (Guid)i.GetAttributeValue<Guid>("quotedetailid");
                    }
                }
                if(id == Guid.Empty) throw new InvalidPluginExecutionException("Quote Line Not found.");
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting matching new quote lines in the ReviseQuoteDiscountMove plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting matching new quote lines in the ReviseQuoteDiscountMove plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion ErrorHandling
            return id;
        }
        private EntityCollection GetNewQuoteLines(ITracingService tracingService, IOrganizationService service, Guid newQuoteId)
        {
            EntityCollection ret = new EntityCollection();
            try
            {
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quotedetail'>
    <attribute name='productid' />
    <attribute name='productdescription' />
    <attribute name='quantity' />
    <attribute name='extendedamount' />
    <attribute name='baseamount' />
    <attribute name='quotedetailid' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='quoteid' operator='eq' uitype='quote' value='{0}' />
    </filter>
  </entity>
</fetch>
", newQuoteId);
                ret = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting new quote lines in the ReviseQuoteDiscountMove plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting new quote lines in the ReviseQuoteDiscountMove plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion ErrorHandling
            return ret;
        }
        private EntityCollection GetParentQuoteLines(ITracingService tracingService, IOrganizationService service, Guid parentQuoteId)
        {
            EntityCollection ret = new EntityCollection();
            try
            {
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quotedetail'>
    <attribute name='productid' />
    <attribute name='productdescription' />
    <attribute name='quantity' />
    <attribute name='extendedamount' />
    <attribute name='baseamount' />
    <attribute name='quotedetailid' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='quoteid' operator='eq' uitype='quote' value='{0}' />
    </filter>
  </entity>
</fetch>
", parentQuoteId);
                ret = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting parent quote lines in the ReviseQuoteDiscountMove plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting quote parent lines in the ReviseQuoteDiscountMove plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion ErrorHandling
            return ret;
        }
    }
}
