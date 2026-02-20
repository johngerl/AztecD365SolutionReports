using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using System.Net;
namespace AztecPlugins
{
    public class OpportunityAssignFromLead : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if(context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Opportunity.EntityLogicalName)
            {
                try
                {
                    Opportunity opp = ((Entity)context.InputParameters["Target"]).ToEntity<Opportunity>();
                    if (!opp.Attributes.Contains("originatingleadid")) return;
                    if (context.ParentContext.ParentContext != null && context.ParentContext.ParentContext.SharedVariables.ContainsKey("LeadQualifyUser"))
                    {
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        Guid ownerId = (Guid)context.ParentContext.ParentContext.SharedVariables["LeadQualifyUser"];
                        Guid oppId = (Guid)opp.OpportunityId;
                        Opportunity uOpp = new Opportunity()
                        {
                            OpportunityId = oppId,
                            OwnerId = new EntityReference(SystemUser.EntityLogicalName, ownerId)
                        };
                        service.Update(uOpp);
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
