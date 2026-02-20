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
using System.Threading;
namespace AztecPlugins
{
    public sealed class GetUserHasRole : CodeActivity
    {
        #region Arguments
        [RequiredArgument]
        [Input("Role Name")]
        public InArgument<string> RoleNames { get; set; }

        [RequiredArgument]
        [Input("Created By")]
        [ReferenceTarget("systemuser")]
        public InArgument<EntityReference> CreatedByRef { get; set; }

        [Output("User Has Role?")]
        public OutArgument<bool> UserHasRole { get; set; }
        #endregion
        protected override void Execute(CodeActivityContext executionContext)
        {
            #region TracingService
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();
            if (tracingService == null)
            {
                throw new InvalidPluginExecutionException("Failed to retrieve tracing service.");
            }
            tracingService.Trace("Entered GetUserHasRole.Execute(), Activity Instance Id: {0}, Workflow Instance Id: {1}",
                executionContext.ActivityInstanceId,
                executionContext.WorkflowInstanceId);
            #endregion
            #region Service
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            try
            {
                string roleNames = RoleNames.Get(executionContext);
                tracingService.Trace("RoleNames: " + roleNames);
                var roleNameArray = roleNames.Split(';');
                EntityReference createdBy = CreatedByRef.Get(executionContext);
                tracingService.Trace("CreatedById: " + createdBy.Id);
                SystemUser user = service.Retrieve(SystemUser.EntityLogicalName, createdBy.Id, new ColumnSet("businessunitid")).ToEntity<SystemUser>();
                bool userHasRole = false;
                foreach (var roleName in roleNameArray)
                {
                    string roleNameString = roleName.Trim();
                    if (Utility.UserHasRole(service, createdBy.Id, user.BusinessUnitId.Id, roleNameString, tracingService))
                    {
                        userHasRole = true;
                    }
                }
                UserHasRole.Set(executionContext, userHasRole);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error in the GetUserHasRole Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error in the GetUserHasRole Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error in the GetUserHasRole Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
