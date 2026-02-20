using System;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System.ServiceModel;
using Microsoft.Xrm.Sdk.Query;
using CrmContext;
namespace AztecPlugins
{
    public sealed class OppAuditRemoval : CodeActivity
    {
        #region Arguments
        [RequiredArgument]
        [Input("Opportunity")]
        [ReferenceTarget("opportunity")]
        public InArgument<EntityReference> OpportunityRef { get; set; }
        #endregion
        protected override void Execute(CodeActivityContext executionContext)
        {
            #region TracingService
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();
            if (tracingService == null)
            {
                throw new InvalidPluginExecutionException("Failed to retrieve tracing service.");
            }
            tracingService.Trace("Entered ActivityRegardingGetState.Execute(), Activity Instance Id: {0}, Workflow Instance Id: {1}",
                executionContext.ActivityInstanceId,
                executionContext.WorkflowInstanceId);
            #endregion
            try
            {
                EntityReference oppRef = executionContext.GetValue(this.OpportunityRef);
                #region Query
                string _fetch =
    string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
	<entity name='azt_opportunityauditrecord'>
		<attribute name='azt_opportunityauditrecordid' />
		<filter type='and'>
			<condition attribute='azt_opportunityid' operator='eq' uitype='opportunity' value='{0}' />
		</filter>
	</entity>
</fetch>", oppRef.Id);
                #endregion
                #region Service
                IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
                IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (Entity i in ec.Entities)
                {
                    Guid recordId = i.Id;
                    service.Delete(azt_opportunityauditrecord.EntityLogicalName, recordId);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in OppAuditRemoval workflow: {0}", e.ToString());
                throw;
            }
            #endregion
        }
    }
}
