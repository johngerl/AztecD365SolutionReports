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
    public class ProductDiscountPreventOnActiveQuote : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if ((context.MessageName == "Create" || context.MessageName == "Update") && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_productdiscount.EntityLogicalName)
            {
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                try
                {
                    azt_productdiscount discount;
                    if (context.MessageName == "Create")
                    {
                        discount = ((Entity)context.InputParameters["Target"]).ToEntity<azt_productdiscount>();
                    }
                    else
                    {
                        azt_productdiscount entityDiscount = ((Entity)context.InputParameters["Target"]).ToEntity<azt_productdiscount>();
                        if (!entityDiscount.Contains("azt_quoteproductid")) return;
                        discount = ((Entity)context.PreEntityImages["PreDiscount"]).ToEntity<azt_productdiscount>();
                    }
                    if (discount.Attributes.Contains("azt_quoteproductid"))
                    {
                        QuoteDetail quoteProduct = ((Entity)service.Retrieve(QuoteDetail.EntityLogicalName, (discount.azt_QuoteProductId).Id, new ColumnSet("quoteid"))).ToEntity<QuoteDetail>();
                        EntityReference quoteRef = quoteProduct.QuoteId;
                        Quote quote = ((Entity)service.Retrieve(Quote.EntityLogicalName, quoteRef.Id, new ColumnSet("statecode"))).ToEntity<Quote>();
                        QuoteState _statecode = (QuoteState)quote.StateCode;
                        if (context.ParentContext.MessageName == "Delete" || (context.ParentContext.ParentContext != null && context.ParentContext.ParentContext.MessageName == "Revise")) return;
                        if (_statecode != QuoteState.Draft) throw new InvalidPluginExecutionException("Discounts can only be applied on a Draft Quote.");
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the ProductDiscountPreventOnActiveQuote plug-in.", ex);
                }

                catch (Exception ex)
                {
                    tracingService.Trace("ProductDiscountPreventOnActiveQuote: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
    }
}
