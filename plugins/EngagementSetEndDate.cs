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
namespace AztecPlugins
{
    public class EngagementSetEndDate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity")
            {
                if (context.InputParameters.Contains("EntityMoniker") && context.InputParameters.Contains("State"))
                {
                    EntityReference engRef = (EntityReference)context.InputParameters["EntityMoniker"];
                    OptionSetValue _statecode = (OptionSetValue)context.InputParameters["State"];
                    if (_statecode.Value != 1) return;

                    azt_engagement uEng = new azt_engagement()
                    {
                        azt_engagementId = engRef.Id,
                        azt_EndDate = DateTime.Today
                    };
                    try
                    {
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        tracingService.Trace("EngReference: " + engRef.Id.ToString() + " Statecode: " + _statecode.Value.ToString() + " DateTime: " + DateTime.Today.ToString());
                        service.Update(uEng);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("An error occurred in the EngagementSetEndDate Plugin: {0}", ex.InnerException.ToString());
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("An error occurred in the EngagementSetEndDate Plugin: {0}", ex.InnerException.ToString());
                        throw;
                    }
                    #endregion ErrorHandling
                }
            }
        }
    }
}
