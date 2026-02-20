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
namespace AztecPlugins
{
    public sealed class ActivityRegardingGetState : CodeActivity
    {
        #region Arguments
        [RequiredArgument]
        [Input("Regarding")]
        [ReferenceTarget("activitypointer")]
        public InArgument<EntityReference> regardingObjectIn { get; set; }

        [Output("State")]
        public OutArgument<string> stateName { get; set; }

        //[Output("Regarding Found?")]
        //public OutArgument<bool> teamFound { get; set; }
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
                #region Service
                IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
                IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                EntityReference regRef = regardingObjectIn.Get(executionContext);
                ActivityPointer pointer = service.Retrieve(ActivityPointer.EntityLogicalName, regRef.Id, new ColumnSet("activitytypecode","activityid","regardingobjectid")).ToEntity<ActivityPointer>();
                switch (pointer.RegardingObjectId.LogicalName)
                {
                    case Account.EntityLogicalName:
                        stateName.Set(executionContext, GetAcctState(service, tracingService, pointer.RegardingObjectId));
                        break;
                    case Contact.EntityLogicalName:
                        stateName.Set(executionContext, GetContState(service, tracingService, pointer.RegardingObjectId));
                        break;
                    case Opportunity.EntityLogicalName:
                        stateName.Set(executionContext, GetOpportunityState(service, tracingService, pointer.RegardingObjectId));
                        break;
                    case azt_engagement.EntityLogicalName:
                        stateName.Set(executionContext, GetEngagementState(service, tracingService, pointer.RegardingObjectId));
                        break;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in ActivityRegardingGetState workflow: {0}", e.ToString());
                throw;
            }
            #endregion
        }
        private string GetEngagementState(IOrganizationService service, ITracingService tracingService, EntityReference regardingObjectId)
        {
            string text = string.Empty;
            try
            {
                azt_engagement eng = service.Retrieve(azt_engagement.EntityLogicalName, regardingObjectId.Id, new ColumnSet("azt_accountid")).ToEntity<azt_engagement>();
                Account acct = service.Retrieve(Account.EntityLogicalName, eng.azt_AccountId.Id, new ColumnSet("address1_stateorprovince")).ToEntity<Account>();
                if (acct != null && acct.Contains("address1_stateorprovince"))
                    text = acct.Address1_StateOrProvince;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured getting Engagement State in ActivityRegardingGetState workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return text;
        }
        private string GetContState(IOrganizationService service, ITracingService tracingService, EntityReference regardingObjectId)
        {
            string text = string.Empty;
            try
            {
                Contact cont = service.Retrieve(Contact.EntityLogicalName, regardingObjectId.Id, new ColumnSet("parentcustomerid")).ToEntity<Contact>();
                if (cont.Attributes.Contains("parentcustomerid"))
                {
                    Account acct = service.Retrieve(Account.EntityLogicalName, cont.ParentCustomerId.Id, new ColumnSet("address1_stateorprovince")).ToEntity<Account>();
                    if (acct != null && acct.Contains("address1_stateorprovince"))
                        text = acct.Address1_StateOrProvince;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured getting Contact State in ActivityRegardingGetState workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return text;
        }
        private string GetAcctState(IOrganizationService service, ITracingService tracingService, EntityReference regardingObjectId)
        {
            string text = string.Empty;
            try
            {
                Account acct = service.Retrieve(Account.EntityLogicalName, regardingObjectId.Id, new ColumnSet("address1_stateorprovince")).ToEntity<Account>();
                if (acct != null && acct.Contains("address1_stateorprovince"))
                    text = acct.Address1_StateOrProvince;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured getting Acct State in ActivityRegardingGetState workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return text;
        }
        private string GetOpportunityState(IOrganizationService service, ITracingService tracingService, EntityReference regardingObjectId)
        {
            string text = string.Empty;
            try
            {
                Opportunity opp = service.Retrieve(Opportunity.EntityLogicalName, regardingObjectId.Id, new ColumnSet("customerid")).ToEntity<Opportunity>();
                EntityReference acctRef = opp.CustomerId;
                Account acct = service.Retrieve(Account.EntityLogicalName, acctRef.Id, new ColumnSet("ownerid","address1_stateorprovince")).ToEntity<Account>();
                if (acct != null && acct.Contains("address1_stateorprovince"))
                text = acct.Address1_StateOrProvince;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in ActivityRegardingGetState workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return text;
        }
    }
}
