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
    public class LeadQualifyParentStakeholderContacts : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            try
            {
                if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity &&
                    ((Entity)context.InputParameters["Target"]).LogicalName == "account")
                {
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    Entity acct = (Entity)context.InputParameters["Target"];
                    if (!acct.Attributes.Contains("originatingleadid")) return;
                    Guid acctId = (Guid)acct.Attributes["accountid"];
                    string acctName = (string)acct.Attributes["name"];
                    Guid origLeadId = ((EntityReference)acct.Attributes["originatingleadid"]).Id;

                    #region Query
                    string fetch =
    string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='connection'>
    <attribute name='record2id' />
    <attribute name='record2roleid' />
    <attribute name='connectionid' />
    <order attribute='record2id' descending='false' />
    <filter type='and'>
      <condition attribute='record1id' operator='eq' uitype='lead' value='{0}' />
    </filter>
  </entity>
</fetch>
", origLeadId);
                    #endregion
                    EntityCollection conts = service.RetrieveMultiple(new FetchExpression(fetch));
                    foreach (Entity C in conts.Entities)
                    {
                        Guid contId = ((EntityReference)C.Attributes["record2id"]).Id;
                        Contact uCont = new Contact()
                        {
                            ContactId = contId,
                            ParentCustomerId = new EntityReference(Account.EntityLogicalName, acctId)
                        };
                        service.Update(uCont);
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error Parenting Contacts to Qualified Account in the LeadQualifyParentStakeholdersContacts Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error Parenting Contacts to Qualified Account in the LeadQualifyParentStakeholdersContacts Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error Parenting Contacts to Qualified Account in the LeadQualifyParentStakeholdersContacts Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
