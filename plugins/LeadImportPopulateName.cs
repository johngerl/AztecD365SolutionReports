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
    public class LeadImportPopulateName : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_leadimport.EntityLogicalName)
            {
                try
                {
                    azt_leadimport import = ((Entity)context.InputParameters["Target"]).ToEntity<azt_leadimport>();
                    string email = import.GetAttributeValue<string>("azt_email");
                    string importName = import.GetAttributeValue<string>("azt_importname");
                    import.azt_name = importName + " " + email;
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred populating name field on lead import in the LeadImportPopulateName plug-in.", ex);
                }
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
        }
    }
}
