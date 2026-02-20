using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using Microsoft.Xrm.Sdk.Query;
using System.ServiceModel;
namespace AztecPlugins
{
    public class ContactSetConnectionRole : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context/Tracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "azt_ContactSetConnectionRole")
            {
                try
                {
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Guid acctId = new Guid((string)context.InputParameters["AccountId"]);
                    Guid contId = new Guid((string)context.InputParameters["ContactId"]);
                    string roleName = (string)context.InputParameters["RoleName"];

                    EntityReference roleRef = GetRole(service, roleName);
                    EntityReference roleToRef = GetToRole(service, roleName);
                    Connection nconn = new Connection()
                    {
                        Record2Id = new EntityReference(Contact.EntityLogicalName, contId),
                        Record1Id = new EntityReference(Account.EntityLogicalName, acctId),
                        Record2RoleId = roleRef,
                        Record1RoleId = roleToRef//,
                        //Description = "New Primary Contact!"
                    };
                    try
                    {
                        service.Create(nconn);
                    }
                    #region SyncronousErrorHandling
                    catch (Exception ex)
                    {
                        throw new InvalidPluginExecutionException(ex.Message);
                    }
                    #endregion
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
        }
        private EntityReference GetToRole(IOrganizationService service, string roleName)
        {
            EntityReference er;
            try
            {
                #region Fetch
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='true'>
  <entity name='connectionrole'>
    <attribute name='connectionroleid' />
    <order attribute='category' descending='false' />
    <link-entity name='connectionroleassociation' from='associatedconnectionroleid' to='connectionroleid' visible='false' intersect='true'>
      <link-entity name='connectionrole' from='connectionroleid' to='connectionroleid' alias='ac'>
        <filter type='and'>
          <condition attribute='name' operator='eq' value='{0}' />
        </filter>
      </link-entity>
    </link-entity>
  </entity>
</fetch>
", roleName);
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (ec.Entities.Count != 1) throw new Exception("No Connection To Connection Role Found.");
                er = new EntityReference(ConnectionRole.EntityLogicalName, ec[0].GetAttributeValue<Guid>("connectionroleid"));
                #endregion
            }
            #region SyncronousErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
            return er;
        }
        private EntityReference GetRole(IOrganizationService service, string roleName)
        {
            EntityReference er;
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='connectionrole'>
    <attribute name='connectionroleid' />
    <attribute name='statecode' />
    <order attribute='category' descending='false' />
    <filter type='and'>
      <condition attribute='name' operator='eq' value='{0}' />
    </filter>
  </entity>
</fetch>
", roleName);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (ec.Entities.Count != 1) throw new Exception("No Connection Role Found for Primary Contact: " + roleName);
                er = new EntityReference(ConnectionRole.EntityLogicalName, ec[0].GetAttributeValue<Guid>("connectionroleid"));
            }
            #region SyncronousErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
            return er;
        }
    }
}
