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
    public class ManualDiscountKill : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == OpportunityProduct.EntityLogicalName || ((Entity)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName)
            {
                try
                {
                    Guid _userId = (Guid)context.InitiatingUserId;
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    SystemUser user = Utility.getUser(service, tracingService, _userId);
                    EntityReference BURef = user.BusinessUnitId;
                    Role sysAdmin = Utility.getSecurityRole(service, "System Administrator", BURef.Id, tracingService);
                    bool hasRole = Utility.UserHasRoleId(service, (Guid)sysAdmin.RoleId, _userId, tracingService);
                    if (hasRole) return;
                    Entity entity = (Entity)context.InputParameters["Target"];
                    if (entity.Attributes.Contains("manualdiscountamount") && ((Money)entity.Attributes["manualdiscountamount"]).Value > 0) throw new Exception("Only System Administrators can set a manual discount.");
                }
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("Only System Administrators can set a manual discount.", ex.InnerException);
                }
            }
        }
    }
}
