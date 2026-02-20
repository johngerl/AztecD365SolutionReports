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
    public sealed class ChangeLicenseType : CodeActivity
    {
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
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='opportunityproduct'>
    <attribute name='opportunityproductid' />
    <order attribute='createdon' descending='false' />
    <filter type='and'>
      <condition attribute='opportunityid' operator='eq' uitype='opportunity' value='{0}' />
    </filter>
  </entity>
</fetch>
", oppId);
                #endregion
                EntityCollection retLines = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (var l in retLines.Entities)
                {
                    Guid opLineId = (Guid)l.Attributes["opportunityproductid"];
                    OpportunityProduct uLine = new OpportunityProduct()
                    {
                        OpportunityProductId = opLineId,
                        azt_LicenseType = new OptionSetValue(276530002)
                    };
                    try
                    {
                        service.Update(uLine);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> e)
                    {
                        tracingService.Trace("Exception setting Opportunity Line ChangeLicenseType workflow: {0}", e.ToString());
                        throw;
                    }
                    #endregion
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception in ChangeLicenseType workflow: {0}", e.ToString());
                throw;
            }
            #endregion
        }
    }
}
