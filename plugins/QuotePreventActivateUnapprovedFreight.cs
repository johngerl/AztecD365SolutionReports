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
    public class QuotePreventActivateUnapprovedFreight : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity")
            {
                if (context.InputParameters.Contains("EntityMoniker") && context.InputParameters.Contains("State"))
                {
                    OptionSetValue _statecode = (OptionSetValue)context.InputParameters["State"];
                    if (_statecode.Value != (int)QuoteState.Active) return;
                    else
                    {
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        EntityReference quoteRef = (EntityReference)context.InputParameters["EntityMoniker"];
                        Quote quote = service.Retrieve(Quote.EntityLogicalName, quoteRef.Id, new ColumnSet("quoteid", "azt_defaultfreightamount", "azt_requestedfreightamt", "azt_freightamtapproved")).ToEntity<Quote>();

                        tracingService.Trace("State: " + _statecode.Value + " QuoteId: " + quoteRef.Id);

                        Money defaultFreightAmt = quote.GetAttributeValue<Money>("azt_defaultfreightamount"); //quote.azt_DefaultFreightAmount;
                        Money requestedFreightAmt = quote.GetAttributeValue<Money>("azt_requestedfreightamt"); //quote.azt_RequestedFreightAmt;
                        bool isFreightApproved = quote.GetAttributeValue<bool>("azt_freightamtapproved"); //(bool)quote.azt_FreightAmtApproved;

                        if (isFreightApproved || (requestedFreightAmt == null)) return;
                        if (requestedFreightAmt != null && requestedFreightAmt.Value >= defaultFreightAmt.Value) return;

                        try
                        {
                            throw new Exception("Freight is unapproved for this quote. Quotes cannot be Activated until freight has been approved.");
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidPluginExecutionException(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
