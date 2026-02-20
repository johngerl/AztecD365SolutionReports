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
    public class QuoteOrderProductsTrackDiscount : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                if(/*((Entity)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName || */((Entity)context.InputParameters["Target"]).LogicalName == SalesOrderDetail.EntityLogicalName || ((Entity)context.InputParameters["Target"]).LogicalName == InvoiceDetail.EntityLogicalName)
                {
                    try
                    {
                        //#region QuoteLine
                        //if(((Entity)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName)
                        //{
                        //    Entity quoteLine = (Entity)context.InputParameters["Target"];
                        //    if (quoteLine.Contains("azt_opportunityproductid"))
                        //    {

                        //    }
                        //}
                        //#endregion
                        #region OrderLine
                        if (((Entity)context.InputParameters["Target"]).LogicalName == SalesOrderDetail.EntityLogicalName)
                        {
                            Entity orderLine = (Entity)context.InputParameters["Target"];
                            if (orderLine.Attributes.Contains("quotedetailid"))
                            {
                                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                                Guid orderLineId = (Guid)orderLine.Attributes["salesorderdetailid"]; tracingService.Trace("orderLineId: " + orderLineId.ToString());
                                Guid quoteDetailId = ((EntityReference)orderLine.Attributes["quotedetailid"]).Id; tracingService.Trace("Getting Quote Discounts");
                                EntityCollection retDiscounts = Utility.getQuoteDiscounts(service, quoteDetailId, tracingService); tracingService.Trace("Number of Quote Discounts: " + retDiscounts.Entities.Count);
                                if (retDiscounts.Entities.Count == 0) return;
                                foreach(Entity D in retDiscounts.Entities)
                                {
                                    Guid discountId = (Guid)D.Attributes["azt_productdiscountid"];
                                    azt_productdiscount uDiscount = new azt_productdiscount()
                                    {
                                        azt_productdiscountId = discountId,
                                        azt_OrderProductId = new EntityReference(SalesOrderDetail.EntityLogicalName, orderLineId)
                                    };
                                    service.Update(uDiscount);
                                }
                            }
                        }
                        #endregion
                        #region InvoiceLine
                        if (((Entity)context.InputParameters["Target"]).LogicalName == InvoiceDetail.EntityLogicalName)
                        {
                            Entity invoiceLine = (Entity)context.InputParameters["Target"];
                            if(invoiceLine.Attributes.Contains("salesorderdetailid"))
                            {
                                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                                Guid invoiceLineId = (Guid)invoiceLine.Attributes["invoicedetailid"]; tracingService.Trace("Getting Order Line Id");
                                Guid orderLineId = ((EntityReference)invoiceLine.Attributes["salesorderdetailid"]).Id; tracingService.Trace("orderLineId: " + orderLineId.ToString());
                                EntityCollection retDiscounts = getOrderDiscounts(service, orderLineId, tracingService); tracingService.Trace("Number of Discounts: " + retDiscounts.Entities.Count);
                                if (retDiscounts.Entities.Count == 0) return;
                                foreach(Entity D in retDiscounts.Entities)
                                {
                                    Guid discountId = (Guid)D.Attributes["azt_productdiscountid"]; tracingService.Trace("discountId: " + discountId.ToString());
                                    azt_productdiscount uDiscount = new azt_productdiscount()
                                    {
                                        azt_productdiscountId = discountId,
                                        azt_InvoiceProductId = new EntityReference(InvoiceDetail.EntityLogicalName, invoiceLineId)
                                    };
                                    service.Update(uDiscount);
                                }
                            }
                        }
                        #endregion
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("Error Setting Reference to Order or Invoice Line in the QuoteOrderProductsTrackDiscount Plugin: {0}", ex.Detail.ToString());
                        throw new InvalidPluginExecutionException("Error Setting Reference to Order or Invoice Line in the QuoteOrderProductsTrackDiscount Plugin", ex);
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("Error Setting Reference to Order or Invoice Line in the QuoteOrderProductsTrackDiscount Plugin: {0}", ex.ToString());
                        throw;
                    }
                    #endregion
                }
            }
        }
        private EntityCollection getOrderDiscounts(IOrganizationService service, Guid orderLineId, ITracingService tracingService)
        {
            tracingService.Trace("method: getOrderDiscounts");
            #region GetDiscounts
            string _productDiscountFetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_productdiscount'>
    <attribute name='azt_productdiscountid' />
    <order attribute='azt_name' descending='false' />
    <filter type='and'>
      <condition attribute='azt_orderproductid' operator='eq' uitype='salesorderdetail' value='{0}' />
    </filter>
  </entity>
</fetch>
", orderLineId);
            #endregion
            try
            {
                return service.RetrieveMultiple(new FetchExpression(_productDiscountFetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error retrieving Order Line Discounts in the QuoteOrderProductsTrackDiscount Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error retrieving Order Line Discounts in the QuoteOrderProductsTrackDiscount Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error retrieving Order Line Discounts in the QuoteOrderProductsTrackDiscount Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
