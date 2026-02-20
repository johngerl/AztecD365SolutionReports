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
    public class SetPrimaryContact : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context/Tracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            #region CreateConnection
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && context.PrimaryEntityName == Connection.EntityLogicalName)
            {
                try
                {
                    Entity conn = (Entity)context.InputParameters["Target"];
                    if (conn.Attributes.Contains("record1id") && ((EntityReference)conn.Attributes["record1id"]).LogicalName == Account.EntityLogicalName && conn.Attributes.Contains("record2id") && ((EntityReference)conn.Attributes["record2id"]).LogicalName == Contact.EntityLogicalName
                        && conn.Attributes.Contains("record1roleid"))
                    {
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                        EntityReference roleRef = (EntityReference)conn.Attributes["record2roleid"];
                        Entity connRole = service.Retrieve("connectionrole", roleRef.Id, new ColumnSet("name"));
                        string roleName = (string)connRole.Attributes["name"];
                        if (roleName != "Ed Tech Primary Contact" || roleName != "Print Primary Contact") return;
                        EntityReference acctRef = (EntityReference)conn.Attributes["record1id"];
                        EntityReference contRef = (EntityReference)conn.Attributes["record2id"];


                        RemoveExistingPrimaryContact(service, acctRef.Id, roleName);     //I do not want to do this when a connection is created, but rather when the action is called.
                        //Connection nconn = new Connection()
                        //{
                        //    Record2Id = contRef,
                        //    Record1Id = acctRef,
                        //    Record2RoleId = new EntityReference(ConnectionRole.EntityLogicalName, (Guid)connRole.Attributes["connectionroleid"]),
                        //    Description = "Primary Contact Replaced!"
                        //};
                        try
                        {
                            //service.Create(nconn);
                        }
                        #region SyncronousErrorHandling
                        catch (Exception ex)
                        {
                            throw new InvalidPluginExecutionException(ex.Message);
                        }
                        #endregion

                        Account acct = service.Retrieve(Account.EntityLogicalName, acctRef.Id, new ColumnSet("primarycontactid")).ToEntity<Account>();
                        //if (acct.Attributes.Contains("primarycontactid")) return;
                        Account uA = new Account()
                        {
                            AccountId = acctRef.Id,
                            PrimaryContactId = contRef
                        };
                        service.Update(uA);
                    }
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
            #endregion
            #region ActionCall
            else if (context.MessageName == "azt_ContactSetPrimary")
            {
                try
                {
                    #region
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Guid acctId = new Guid((string)context.InputParameters["AccountId"]);
                    Guid contId = new Guid((string)context.InputParameters["ContactId"]);
                    bool isPrint = (bool)context.InputParameters["isPrint"];
                    string roleName = string.Empty;
                    if (isPrint)
                        roleName = "Print Primary Contact";
                    else
                        roleName = "Ed Tech Primary Contact";
                    RemoveExistingPrimaryContact(service, acctId, roleName);
                    EntityReference roleRef = GetPrimContactRole(service, roleName);
                    EntityReference roleToRef = GetPrimContactToRole(service, roleName);
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
            #endregion
        }
        private EntityReference GetPrimContactToRole(IOrganizationService service, string roleName)
        {
            EntityReference er = new EntityReference();
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
        private EntityReference GetPrimContactRole(IOrganizationService service, string v)
        {
            EntityReference er = new EntityReference();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='connectionrole'>
    <attribute name='category' />
    <attribute name='name' />
    <attribute name='connectionroleid' />
    <attribute name='statecode' />
    <order attribute='category' descending='false' />
    <filter type='and'>
      <condition attribute='name' operator='eq' value='{0}' />
    </filter>
  </entity>
</fetch>
", v);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (ec.Entities.Count != 1) throw new Exception("No Connection Role Found for Primary Contact: " + v);
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
        internal void RemoveExistingPrimaryContact(IOrganizationService service, Guid acctId, string roleName)
        {
            #region Query
            string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='connection'>
    <attribute name='connectionid' />
    <filter type='and'>
      <condition attribute='record1id' operator='eq' uitype='account' value='{0}' />
    </filter>
    <link-entity name='connectionrole' from='connectionroleid' to='record2roleid' link-type='inner' alias='ac'>
      <filter type='and'>
        <condition attribute='name' operator='eq' value='{1}' />
      </filter>
    </link-entity>
  </entity>
</fetch>
", acctId, roleName);
            //      <!--<condition attribute='record2id' operator='eq' uitype='contact' value='{4567}' />-->
            #endregion
            EntityCollection retConns = service.RetrieveMultiple(new FetchExpression(_fetch));
            //throw new Exception("Number: " + retConns.Entities.Count.ToString());
            if (retConns.Entities.Count == 0) return;
            EntityReference primContRole = GetPrimContactRole(service, roleName);
            foreach (var c in retConns.Entities)
            {
                Guid connId = c.GetAttributeValue<Guid>("connectionid");
                try
                {
                    service.Delete(Connection.EntityLogicalName, connId);
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
        }
    }
}
