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
using Microsoft.Crm.Sdk.Messages;
using System.IdentityModel.Metadata;
namespace AztecPlugins
{
    public class ShareBasedOnAccessTeam : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region PluginMembers
            Guid _recordToShareOwnerId = Guid.Empty;
            string _recordToShareEntityType = string.Empty;
            Guid activityId = Guid.Empty;
            Guid _recordToShareId = Guid.Empty;
            Guid _accountOwnerId = Guid.Empty;
            string _regardedToEntityType = string.Empty;

            #endregion
            #region TracingContext
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
                {
                    Entity entity = (Entity)context.InputParameters["Target"];
                    _recordToShareEntityType = entity.LogicalName;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    switch (_recordToShareEntityType)
                    {
                        case "phonecall":
                            ShareActivity(service, tracingService, entity, _recordToShareEntityType, new Guid("AC096708-B161-ED11-9562-000D3A993B8F"));
                            break;
                        case "appointment":
                            ShareActivity(service, tracingService, entity, _recordToShareEntityType, new Guid("6CD8320A-CD61-ED11-9562-000D3A993B8F"));
                            break;
                        case "email":
                            ShareActivity(service, tracingService, entity, _recordToShareEntityType, new Guid("70430DB6-4C62-ED11-9562-000D3A993B8F"));
                            break;
                        case "task":
                            ShareActivity(service, tracingService, entity, _recordToShareEntityType, new Guid("CB561BFB-5562-ED11-9562-000D3A9934F2"));
                            break;
                        case "opportunity":
                            ShareOpportunity(service, tracingService, entity, _recordToShareEntityType);
                            break;
                        case "quote":
                            ShareQuote(service, tracingService, entity, _recordToShareEntityType);
                            break;
                        case "salesorder":
                            ShareOrder(service, tracingService, entity, _recordToShareEntityType);
                            break;
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the ShareBasedOnAccessTeam function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void ShareOrder(IOrganizationService service, ITracingService tracingService, Entity entity, string recordToShareEntityType)
        {
            try
            {
                EntityReference custRef = (EntityReference)entity.Attributes["customerid"];
                if (custRef.LogicalName != Account.EntityLogicalName) return;
                Guid quoteId = (Guid)entity.Attributes["salesorderid"];
                Guid orderTeamTemplateId = new Guid("0E65FADF-8662-ED11-9562-000D3A993B8F");
                EntityCollection ec = GetAccessTeamMembers(service, tracingService, custRef);
                if (ec.Entities.Count == 0) return;
                foreach (var i in ec.Entities)
                {
                    Guid userId = i.GetAttributeValue<Guid>("systemuserid");
                    if (GetIsUserInOwnerTeamForAccount(service, tracingService, custRef, userId)) continue;
                    CreateAccessTeam(service, tracingService, new EntityReference(recordToShareEntityType, quoteId), userId, orderTeamTemplateId);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating Order Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating Order Access Team in the ShareBasedOnAccessTeam action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating Order Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void ShareQuote(IOrganizationService service, ITracingService tracingService, Entity entity, string recordToShareEntityType)
        {
            try
            {
                EntityReference custRef = (EntityReference)entity.Attributes["customerid"];
                if (custRef.LogicalName != Account.EntityLogicalName) return;
                Guid quoteId = (Guid)entity.Attributes["quoteid"];
                Guid quoteTeamTemplateId = new Guid("5C6E64C1-39A1-EB11-B1AC-0022480932F3");
                EntityCollection ec = GetAccessTeamMembers(service, tracingService, custRef);
                if(ec.Entities.Count == 0) return;
                foreach (var i in ec.Entities)
                {
                    Guid userId = i.GetAttributeValue<Guid>("systemuserid");
                    if (GetIsUserInOwnerTeamForAccount(service, tracingService, custRef, userId)) continue;
                    CreateAccessTeam(service, tracingService, new EntityReference(recordToShareEntityType, quoteId), userId, quoteTeamTemplateId);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating Quote Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating Quote Access Team in the ShareBasedOnAccessTeam action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating Quote Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void ShareOpportunity(IOrganizationService service, ITracingService tracingService, Entity entity, string recordToShareEntityType)
        {
            try
            {
                if (!entity.Attributes.Contains("parentaccountid")) return;
                EntityReference parentAcctRef = (EntityReference)entity.Attributes["parentaccountid"];
                Guid oppId = (Guid)entity.Attributes["opportunityid"];
                Guid oppWriteTeamTemplateId = new Guid("A66F3FB5-39A1-EB11-B1AC-0022480932F3");
                EntityCollection ec = GetAccessTeamMembers(service, tracingService, parentAcctRef);
                if (ec.Entities.Count == 0) return;
                foreach (var i in ec.Entities)
                {
                    Guid userId = i.GetAttributeValue<Guid>("systemuserid");
                    if (GetIsUserInOwnerTeamForAccount(service, tracingService, parentAcctRef, userId)) continue;
                    CreateAccessTeam(service, tracingService, new EntityReference(recordToShareEntityType, oppId), userId, oppWriteTeamTemplateId);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating Opportunity Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating Opportunity Access Team in the ShareBasedOnAccessTeam action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating Opportunity Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void ShareActivity(IOrganizationService service, ITracingService tracingService, Entity entity, string activityEntityName, Guid teamTemplateId)
        {
            try
            {
                if (!entity.Attributes.Contains("regardingobjectid")) return;
                EntityReference regardingRef = entity.GetAttributeValue<EntityReference>("regardingobjectid");
                Guid activityId = entity.GetAttributeValue<Guid>("activityid");
                if (regardingRef.LogicalName != Account.EntityLogicalName) return;
                EntityCollection ec = GetAccessTeamMembers(service, tracingService, regardingRef);
                if (ec.Entities.Count == 0) return;
                foreach (var u in ec.Entities)
                {
                    Guid userId = u.GetAttributeValue<Guid>("systemuserid");
                    if (GetIsUserInOwnerTeamForAccount(service, tracingService, regardingRef, userId)) continue;
                    CreateAccessTeam(service, tracingService, new EntityReference(activityEntityName, activityId), userId, teamTemplateId);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating  Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating  Access Team in the ShareBasedOnAccessTeam action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating  Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private static EntityCollection GetAccessTeamMembers(IOrganizationService service, ITracingService tracingService, EntityReference regardingRef)
        {
            EntityCollection entityCollection = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
    string.Format(@"<fetch>
  <entity name='teammembership'>
    <attribute name='systemuserid' />
    <link-entity name='team' from='teamid' to='teamid' link-type='inner' alias='t'>
      <attribute name='teamid' />
      <filter>
        <condition attribute='regardingobjectid' operator='eq' value='{0}' />
      </filter>
    </link-entity>
    <link-entity name='systemuser' from='systemuserid' to='systemuserid' link-type='inner' alias='user'>
      <attribute name='fullname' />
    </link-entity>
  </entity>
</fetch>", regardingRef.Id);
                #endregion
                entityCollection = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred getting Access Team members in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred getting Access Team members in the ShareBasedOnAccessTeam action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting Access Team members in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
            return entityCollection;
        }
        private bool GetIsUserInOwnerTeamForAccount(IOrganizationService service, ITracingService tracingService, EntityReference regardingRef, Guid userId)
        {
            bool isInOwnerTeam = false;
            try
            {
                #region Query
                string _fetch =
string.Format(@"<fetch>
  <entity name='account'>
    <filter>
      <condition attribute='accountid' operator='eq' value='{0}' />
    </filter>
    <link-entity name='team' from='teamid' to='owningteam' alias='team' link-type='inner'>
      <attribute name='name' />
      <filter>
        <condition attribute='teamtype' operator='eq' value='0' />
      </filter>
      <link-entity name='teammembership' from='teamid' to='teamid' link-type='inner' alias='tm' intersect='true'>
        <attribute name='systemuserid' />
        <link-entity name='systemuser' from='systemuserid' to='systemuserid' alias='user' intersect='true'>
          <attribute name='fullname' />
        </link-entity>
      </link-entity>
    </link-entity>
  </entity>
</fetch>", regardingRef.Id);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (var u in ec.Entities)
                {
                    Guid teamMemberId = (Guid)u.GetAttributeValue<AliasedValue>("tm.systemuserid").Value;
                    if (userId == teamMemberId)
                        return true;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred getting if user is in Owner Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred getting if user is in Owner Team in the ShareBasedOnAccessTeam action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting if user is in Owner Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
            return isInOwnerTeam;
        }
        private void CreateAccessTeam(IOrganizationService service, ITracingService tracingService, EntityReference recordRef, Guid userId, Guid teamTemplateId)
        {
            try
            {
                AddUserToRecordTeamRequest adduser = new AddUserToRecordTeamRequest()
                {
                    Record = recordRef,
                    SystemUserId = userId,
                    TeamTemplateId = teamTemplateId
                };
                service.Execute(adduser);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating Phonecall Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating Phonecall Access Team in the ShareBasedOnAccessTeam action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating Phonecall Access Team in the ShareBasedOnAccessTeam action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
