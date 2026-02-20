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
    public class QuoteCloneAndDelete : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.OutputParameters.Contains("NewQuote"))
            {
                try
                {
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    EntityReference newQuoteRef = (EntityReference)context.OutputParameters["NewQuote"];
                    Guid oldQuoteId = new Guid((string)context.InputParameters["OldQuoteId"]);
                    EntityCollection retOrders = GetOrders(service, oldQuoteId);
                    #region NewQuote
                    EntityCollection retQuoteLines = GetQuoteLines(service, oldQuoteId);
                    foreach (var l in retQuoteLines.Entities)
                    {
                        Guid quoteLineId = l.GetAttributeValue<Guid>("quotedetailid");
                        EntityReference productRef = l.GetAttributeValue<EntityReference>("productid");
                        EntityReference uomRef = l.GetAttributeValue<EntityReference>("uomid");
                        string writeInProduct = l.GetAttributeValue<string>("productdescription");
                        Money pricePerUnit = l.GetAttributeValue<Money>("priceperunit");
                        decimal qty = l.GetAttributeValue<decimal>("quantity");
                        Money extAmt = l.GetAttributeValue<Money>("extendedamount");
                        QuoteDetail nLine = new QuoteDetail()
                        {
                            QuoteId = newQuoteRef,
                            Quantity = qty
                        };
                        if (productRef != null && productRef.Id != Guid.Empty)
                        {
                            nLine.ProductId = productRef;
                            if(uomRef != null && uomRef.Id != Guid.Empty) nLine.UoMId = uomRef;
                        }
                        else
                        {
                            nLine.ProductDescription = writeInProduct;
                            nLine.PricePerUnit = pricePerUnit;
                        }
                        service.Create(nLine);
                    }
                    #endregion
                    #region ExistingOrders
                    if (retOrders.Entities.Count > 0)
                    {
                        foreach (var o in retOrders.Entities)
                        {
                            Guid orderId = (Guid)o.Attributes["salesorderid"];
                            EntityCollection retInvoices = GetInvoices(service, orderId);
                            foreach (var i in retInvoices.Entities)
                            {
                                Guid invoiceId = (Guid)i.Attributes["invoiceid"];
                                try
                                {
                                    service.Delete("invoice", invoiceId);
                                }
                                #region ErrorHandling
                                catch (FaultException<OrganizationServiceFault> ex)
                                {
                                    throw new InvalidPluginExecutionException("An error occurred deleting invoices in the QuoteCloneAndDelete function." + ex.Detail.InnerFault.Message.ToString());
                                }
                                #endregion
                            }
                            try
                            {
                                service.Delete("salesorder", orderId);
                            }
                            #region ErrorHandling
                            catch (FaultException<OrganizationServiceFault> ex)
                            {
                                throw new InvalidPluginExecutionException("An error occurred deleting orders in the QuoteCloneAndDelete function." + ex.Detail.InnerFault.Message.ToString());
                            }
                            #endregion
                        }
                    }
                    #endregion
                    #region DeleteQuote
                    try
                    {
                        service.Delete(Quote.EntityLogicalName, oldQuoteId);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        throw new InvalidPluginExecutionException("An error occurred in the QuoteCloneAndDelete function." + ex.Message.ToString());
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    #endregion
                    #endregion
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the QuoteCloneAndDelete function." + ex.Message.ToString());
                }
                catch (Exception ex)
                {
                    throw;
                }
                #endregion
            }
        }
        private EntityCollection GetQuoteLines(IOrganizationService service, Guid quoteId)
        {
            EntityCollection ec = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quotedetail'>
    <attribute name='productid' />
    <attribute name='productdescription' />
    <attribute name='priceperunit' />
    <attribute name='quantity' />
    <attribute name='extendedamount' />
    <attribute name='quotedetailid' />
    <attribute name='uomid' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='quoteid' operator='eq' uitype='quote' value='{0}' />
    </filter>
  </entity>
</fetch>
", quoteId);
                #endregion
                ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting Quote Lines in the QuoteCloneAndDelete function." + ex.Detail.InnerFault.Message.ToString());
            }
            #endregion
            return ec;
        }
        private EntityCollection GetOrders(IOrganizationService service, Guid id)
        {
            EntityCollection ec = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='salesorder'>
    <attribute name='salesorderid' />
    <order attribute='name' descending='false' />
    <filter type='and'>
      <condition attribute='quoteid' operator='eq' uitype='quote' value='{0}' />
    </filter>
  </entity>
</fetch>
", id);
                #endregion
                ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting orders in the QuoteCloneAndDelete function." + ex.Detail.InnerFault.Message.ToString());
            }
            #endregion
            return ec;
        }
        private EntityCollection GetInvoices(IOrganizationService service, Guid id)
        {
            EntityCollection ec = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='invoice'>
    <attribute name='invoiceid' />
    <filter type='and'>
      <condition attribute='salesorderid' operator='eq' uitype='salesorder' value='{0}' />
    </filter>
  </entity>
</fetch>
", id);
                #endregion
                ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting orders in the QuoteCloneAndDelete function." + ex.Detail.InnerFault.Message.ToString());
            }
            #endregion
            return ec;
        }
    }
}
