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
    public class EngagementFSRAssignedOn : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if(context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && 
                ((Entity)context.InputParameters["Target"]).LogicalName == azt_engagement.EntityLogicalName)
            {
                azt_engagement eng = ((Entity)context.InputParameters["Target"]).ToEntity<azt_engagement>();
                if(eng.Contains("ownerid"))
                {
                    try
                    {
                        Guid engId = (Guid)eng.azt_engagementId;
                        azt_engagement e = new azt_engagement()
                        {
                            azt_engagementId = engId,
                            azt_FSRAssignedOn = DateTime.Today.ToUniversalTime()
                        };
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        service.Update(e);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("An error occurred in the EngagementFSRAssignedOn Plugin: {0}", ex.InnerException.ToString());
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("An error occurred in the EngagementFSRAssignedOn Plugin: {0}", ex.InnerException.ToString());
                        throw;
                    }
                    #endregion ErrorHandling
                }
            }
        }
    }
}
