using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using CrmContext;
using System.ServiceModel;
namespace AztecPlugins
{
    public class CommissionPreventDelete : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Delete" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference && ((EntityReference)context.InputParameters["Target"]).LogicalName == azt_commission.EntityLogicalName)
            {
                try
                {
                    throw new InvalidPluginExecutionException("Commision Records cannot be deleted.");
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the CommissionPreventDelete plugin." + ex.Detail.InnerFault.Message.ToString());
                }
                catch (Exception ex)
                {
                    tracingService.Trace("An error occurred in the CommissionPreventDelete plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
    }
}
