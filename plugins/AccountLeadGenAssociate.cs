using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using Microsoft.Xrm.Sdk.Query;
using System.ServiceModel;
using Microsoft.Xrm.Sdk.Messages;
namespace AztecPlugins
{
    public class AccountLeadGenAssociate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Associate" && ((Relationship)context.InputParameters["Relationship"]).SchemaName == "azt_azt_accountleadgeneration_account" && ((EntityReference)context.InputParameters["Target"]).LogicalName == "azt_accountleadgeneration")
            {
                try
                {
                    Guid acctLeadGenId = ((EntityReference)context.InputParameters["Target"]).Id;
                    Guid acctId = ((EntityReferenceCollection)context.InputParameters["RelatedEntities"])[0].Id;

                    #region Get Account Lead Gen Record
                    string _fetch =
    string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_accountleadgeneration'>
    <attribute name='azt_accountleadgenerationid' />
    <attribute name='azt_name' />
    <order attribute='azt_name' descending='false' />
    <filter type='and'>
      <condition attribute='azt_accountleadgenerationid' operator='eq' uitype='azt_accountleadgeneration' value='{0}' />
    </filter>
  </entity>
</fetch>", acctLeadGenId);
                    #endregion
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    EntityCollection acctLeadGens = service.RetrieveMultiple(new FetchExpression(_fetch));
                    if (acctLeadGens.Entities.Count != 1)
                        throw new InvalidPluginExecutionException("No Account Lead Gen Records found");
                    string leadGenName = acctLeadGens[0].GetAttributeValue<string>("azt_name");

                    Account a = new Account()
                    {
                        AccountId = acctId,
                        azt_AccountLeadGenName = leadGenName
                    };
                    service.Update(a);
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("An error occurred in the AccountLeadGenAssociate function: {0}", ex.ToString());
                    tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                    throw new InvalidPluginExecutionException("An error occurred in the AccountLeadGenAssociate function." + ex.Detail.InnerFault.Message.ToString());
                }
                catch (Exception ex)
                {
                    tracingService.Trace("An error occurred in the AccountLeadGenAssociate function: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
    }
}
