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
    public class CaseClose : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if ((context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity") && context.InputParameters.Contains("EntityMoniker"))
            {
                try
                {
                    EntityReference caseRef = (EntityReference)context.InputParameters["EntityMoniker"];
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Incident theCase = service.Retrieve(Incident.EntityLogicalName, caseRef.Id, new ColumnSet("azt_resolvedbyid")).ToEntity<Incident>();
                    OptionSetValue caseState = (OptionSetValue)context.InputParameters["State"];
                    if (caseState.Value == 1)
                    {
                        Incident i = new Incident()
                        {
                            IncidentId = caseRef.Id,
                            adx_resolutiondate = DateTime.Today.Date.AddDays(1).AddTicks(-1).ToUniversalTime()
                        };
                        if (!theCase.Contains("azt_resolvedbyid")) i.azt_ResolvedById = new EntityReference(SystemUser.EntityLogicalName, context.InitiatingUserId);
                        service.Update(i);
                    }
                    else
                    {
                        Incident i = new Incident()
                        {
                            IncidentId = caseRef.Id,
                            adx_resolutiondate = null,
                            azt_ResolvedById = null
                        };
                        service.Update(i);
                    }
                }
                #region Synchronous Error Handling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
        }
    }
}
