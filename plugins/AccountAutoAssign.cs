using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System.ServiceModel;
using Microsoft.Xrm.Sdk.Query;
using CrmContext;
using System.Runtime.Remoting.Contexts;
namespace AztecPlugins
{
    public sealed class AccountAutoAssign : CodeActivity
    {
        #region Arguments
        [RequiredArgument]
        [Input("State")]
        public InArgument<string> acctState { get; set; }

        [Output("Team")]
        [ReferenceTarget("team")]
        public InOutArgument<EntityReference> teamRef { get; set; }

        [Output("Team Found?")]
        public OutArgument<bool> teamFound { get; set; }
        #endregion
        protected override void Execute(CodeActivityContext executionContext)
        {
            #region TracingService
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();
            if (tracingService == null)
            {
                throw new InvalidPluginExecutionException("Failed to retrieve tracing service.");
            }
            tracingService.Trace("Entered NewUserGoals.Execute(), Activity Instance Id: {0}, Workflow Instance Id: {1}",
                executionContext.ActivityInstanceId,
                executionContext.WorkflowInstanceId);
            #endregion
            string acctStateAbb = acctState.Get(executionContext);
            tracingService.Trace("acctStateAbb: " + acctStateAbb);
            #region Service
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            SystemUser user = service.Retrieve(SystemUser.EntityLogicalName, context.InitiatingUserId, new ColumnSet("businessunitid")).ToEntity<SystemUser>();
            if (Utility.UserHasRole(service, context.InitiatingUserId, user.BusinessUnitId.Id, "Pass Assured", tracingService))
            {
                tracingService.Trace("context.InitiatingUserId" + context.InitiatingUserId.ToString());
                EntityReference PassTeam = GetPassAssuredTeam(service, tracingService);
                teamFound.Set(executionContext, true);
                teamRef.Set(executionContext, PassTeam);
            }
            else
            {
                EntityReference teamToReturn = GetMatchingTeam(tracingService, service, acctStateAbb);
                if (teamToReturn == null || teamToReturn.Id == Guid.Empty)
                {
                    teamFound.Set(executionContext, false);
                }
                else
                {
                    teamFound.Set(executionContext, true);
                    teamRef.Set(executionContext, teamToReturn);
                }
            }
        }
        private EntityReference GetPassAssuredTeam(IOrganizationService service, ITracingService tracingService)
        {
            EntityReference team = new EntityReference();
            try
            {
                #region Query
                string _fetch =
@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='team'>
    <attribute name='teamid' />
    <order attribute='name' descending='false' />
    <filter type='and'>
      <condition attribute='teamtype' operator='ne' value='1' />
      <condition attribute='name' operator='eq' value='CTE' />
    </filter>
  </entity>
</fetch>
";
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (ec.Entities.Count != 1) throw new InvalidPluginExecutionException("CTE Team Not Found.");
                team = new EntityReference(Team.EntityLogicalName, (Guid)ec.Entities[0].Attributes["teamid"]);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in AccountAutoAssign workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return team;
        }
        private EntityReference GetMatchingTeam(ITracingService tracingService, IOrganizationService service, string acctStateAbb)
        {
            EntityReference er;
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='team'>
    <attribute name='teamid' />
    <filter type='and'>
      <condition attribute='teamtype' operator='ne' value='1' />
      <condition attribute='azt_stateabbreviation' operator='eq' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctStateAbb);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (ec.Entities.Count < 1) return new EntityReference();//throw new Exception("Team not found");
                Guid teamId = (Guid)ec.Entities[0].Attributes["teamid"];
                er = new EntityReference(Team.EntityLogicalName, teamId);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in AccountAutoAssign workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return er;
        }
    }
}
