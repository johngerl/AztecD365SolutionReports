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
    public class SetOppProductDefaults : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity &&
                ((Entity)context.InputParameters["Target"]).LogicalName == OpportunityProduct.EntityLogicalName)
            {
                try
                {
                    Entity oppProduct = (Entity)context.InputParameters["Target"];
                    if (!oppProduct.Attributes.Contains("productid")) return;
                    Guid oppProductId = (Guid)oppProduct.Attributes["opportunityproductid"];
                    EntityReference productRef = (EntityReference)oppProduct.Attributes["productid"];

                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    if(Utility.getIsProductSoftware(service, productRef.Id, tracingService))
                    {
                        OpportunityProduct OP = new OpportunityProduct()
                        {
                            OpportunityProductId = oppProductId,
                            azt_IsSaaS = true
                        };
                        if (!oppProduct.Attributes.Contains("azt_licensetype")) OP.azt_LicenseType = new OptionSetValue(276530000);
                        if (!oppProduct.Attributes.Contains("azt_licensetermmonths")) OP.azt_LicenseTermMonths = 12;
                        service.Update(OP);
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error in the SetOppProductDefaults Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error in the SetOppProductDefaults Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error in the SetOppProductDefaults Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
    }
}
