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
    class QuoteCloneDiscountForRevisionsPost : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            try
            {
                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Quote.EntityLogicalName)
                {
                    if (context.SharedVariables.Contains("NewQuoteId") && context.SharedVariables.Contains("OriginalQuoteId"))
                    {
                        Guid newQuoteId = new Guid((string)context.SharedVariables["NewQuoteId"]);
                        Guid OriginalQuoteId = new Guid((string)context.SharedVariables["OriginalQuoteId"]);

                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                        throw new InvalidPluginExecutionException("NewQuoteId: " + newQuoteId.ToString() + " OrigQuoteId: " + OriginalQuoteId.ToString());
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the QuoteCloneDiscountForRevisionsPost plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("QuoteCloneDiscountForRevisionsPost: {0}", ex.ToString());
                throw;
            }
            #endregion ErrorHandling
        }
    }
}
