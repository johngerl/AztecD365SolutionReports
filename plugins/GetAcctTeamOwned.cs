using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
namespace AztecPlugins
{
    public sealed class GetAcctTeamOwned : CodeActivity
    {
        #region Members
        [RequiredArgument]
        [Input("Account")]
        [ReferenceTarget("account")]
        public InArgument<EntityReference> Acct { get; set; }

        [Output("isTeamOwned")]
        public OutArgument<bool> teamOwned { get; set; }

        #endregion
        protected override void Execute(CodeActivityContext executionContext)
        {
            #region Tracing/Service
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();
            if (tracingService == null)
            {
                throw new InvalidPluginExecutionException("Failed to retrieve tracing service.");
            }
            tracingService.Trace("Entered ChangeLicenseType.Execute(), Activity Instance Id: {0}, Workflow Instance Id: {1}",
                executionContext.ActivityInstanceId,
                executionContext.WorkflowInstanceId);

            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            Guid oppId = context.PrimaryEntityId;
            try
            {
                bool isTeamOwned = false;
                EntityReference acctRef = Acct.Get(executionContext);
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='account'>
    <attribute name='name' />
    <attribute name='accountid' />
    <order attribute='name' descending='false' />
    <link-entity name='systemuser' from='systemuserid' to='owninguser' link-type='inner' alias='aa' />
    <filter type='and'>
      <condition attribute='accountid' operator='eq' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctRef.Id);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch)); tracingService.Trace("Account with AccountId: " + acctRef.Id.ToString());
                if (ec.Entities.Count == 0)
                    isTeamOwned = true;
                tracingService.Trace("Setting Output Parameter: " + isTeamOwned.ToString());
                teamOwned.Set(executionContext, isTeamOwned);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception in AcctTeamOwned workflow: {0}", e.ToString());
                throw;
            }
            #endregion
        }
    }
}
