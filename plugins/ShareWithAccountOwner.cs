using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
namespace AztecPlugins
{
    class ShareWithAccountOwner : IPlugin
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
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                Entity entity = (Entity)context.InputParameters["Target"];
                _recordToShareEntityType = entity.LogicalName;

                //Is Activity Record
                if (entity.Attributes.Contains("regardingobjectid"))
                {
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Guid _activityid = (Guid)entity.Attributes["activityid"];
                    _regardedToEntityType = ((EntityReference)entity.Attributes["regardingobjectid"]).LogicalName;
                    Guid _regardingObjectId = (Guid)((EntityReference)entity.Attributes["regardingobjectid"]).Id;
                    _accountOwnerId = getAccountOwnerFromActivity(service, _activityid, _regardedToEntityType, _regardingObjectId, tracingService);
                    if (_accountOwnerId != _recordToShareOwnerId) shareRecordInTargetSystem(service, _activityid, _accountOwnerId, _recordToShareEntityType);
                }
                //Is Not an activity Record (but could be a note)
                else
                {
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    switch (_recordToShareEntityType)
                    {
                        case "annotation":
                            _regardedToEntityType = ((EntityReference)entity.Attributes["objectid"]).LogicalName;
                            Guid _regardingObjectId = (Guid)((EntityReference)entity.Attributes["objectid"]).Id;
                            _recordToShareId = (Guid)entity.Attributes["annotationid"];
                            _accountOwnerId = getAccountOwnerFromNote(service, _regardedToEntityType, _recordToShareId, _regardingObjectId, tracingService);
                            break;
                    }
                    if (_accountOwnerId != _recordToShareOwnerId) shareRecordInTargetSystem(service, _recordToShareId, _accountOwnerId, _recordToShareEntityType);
                }
            }
        }
        private Guid getAccountOwnerFromOrder(IOrganizationService service, Guid _salesOrderId, ITracingService tracingService)
        {
            Guid _accountOwnerId = Guid.Empty;
            Guid _accountId = Guid.Empty;
            QueryByAttribute querybyexpression = new QueryByAttribute("salesorder");
            querybyexpression.ColumnSet = new ColumnSet("customerid");
            querybyexpression.Attributes.AddRange("salesorderid");
            querybyexpression.Values.AddRange(_salesOrderId);
            EntityCollection retrievedFields = service.RetrieveMultiple(querybyexpression);
            if (retrievedFields.Entities.Count > 0)
            {
                if (((EntityReference)retrievedFields[0].Attributes["customerid"]).LogicalName != "account") throw new Exception("The Order does not have an Account Parent Customer");
                _accountId = (Guid)((EntityReference)retrievedFields[0].Attributes["customerid"]).Id;
                _accountOwnerId = getAccountOwnerFromAcccountId(service, _accountId, tracingService);
            }
            return _accountOwnerId;
        }
        private Guid getAccountOwnerFromTraining(IOrganizationService service, Guid _regardingObjectId, ITracingService tracingService)
        {
            return ((EntityReference)service.Retrieve(azt_training.EntityLogicalName, _regardingObjectId, new ColumnSet("azt_accountid")).Attributes["azt_accountid"]).Id;
        }
        private Guid getAccountOwnerFromActivity(IOrganizationService service, Guid _activityid, string _regardedToEntityType, Guid _regardingObjectId, ITracingService tracingService)
        {
            Guid _accountId = Guid.Empty;
            Guid __accountOwner = Guid.Empty;
            switch (_regardedToEntityType)
            {
                case Quote.EntityLogicalName:
                    _accountId = getQuoteCustomer(service, _activityid, _regardingObjectId);
                    break;
                case Incident.EntityLogicalName:
                    _accountId = getIncidentCustomer(service, _activityid, _regardingObjectId);
                    break;
                case Account.EntityLogicalName:
                    _accountId = _regardingObjectId;
                    break;
                case Contact.EntityLogicalName:
                    _accountId = getRegardingContactAccountId(service, _activityid, _regardingObjectId);
                    break;
                case Opportunity.EntityLogicalName:
                    _accountId = getRegardingOpportunityAccountId(service, _activityid, _regardingObjectId);
                    break;
                case azt_engagement.EntityLogicalName:
                    _accountId = getRegardingEngagementAccountId(service, _activityid, _regardingObjectId);
                    break;
            }
            __accountOwner = getAccountOwnerFromAcccountId(service, _accountId, tracingService);
            return __accountOwner;
        }
        private Guid getAccountOwnerFromNote(IOrganizationService service, string _regardedToEntityType, Guid _noteId, Guid _regardingObjectId, ITracingService tracingService)
        {
            return getAccountOwnerFromActivity(service, _noteId, _regardedToEntityType, _regardingObjectId, tracingService);
        }
        private Guid getQuoteCustomer(IOrganizationService service, Guid _activityid, Guid _regardingObjectId)
        {
            EntityReference custRef = (EntityReference)service.Retrieve(Quote.EntityLogicalName, _regardingObjectId, new ColumnSet("customerid")).Attributes["customerid"];
            if(custRef.LogicalName != Account.EntityLogicalName) throw new Exception("The quote does not have an Account Customer");
            return custRef.Id;
        }
        private Guid getIncidentCustomer(IOrganizationService service, Guid _activityid, Guid _regardingObjectId)
        {
            EntityReference custRef = (EntityReference)service.Retrieve(Incident.EntityLogicalName, _regardingObjectId, new ColumnSet("customerid")).Attributes["customerid"];
            if (custRef.LogicalName != Account.EntityLogicalName) throw new Exception("The case does not have an Account Customer");
            return custRef.Id;
        }
        private Guid getRegardingContactAccountId(IOrganizationService service, Guid _activityid, Guid _regardingObjectId)
        {
            EntityReference custRef = (EntityReference)service.Retrieve(Contact.EntityLogicalName, _regardingObjectId, new ColumnSet("parentcustomerid")).Attributes["parentcustomerid"];
            if (custRef.LogicalName != Account.EntityLogicalName) throw new Exception("The contact does not have an Account Customer");
            return custRef.Id;
        }
        private Guid getRegardingEngagementAccountId(IOrganizationService service, Guid _activityid, Guid _regardingObjectId)
        {
            EntityReference custRef = (EntityReference)service.Retrieve(azt_engagement.EntityLogicalName, _regardingObjectId, new ColumnSet("azt_accountid")).Attributes["azt_accountid"];
            if (custRef.LogicalName != Account.EntityLogicalName) throw new Exception("The engagement does not have an Account Customer");
            return custRef.Id;
        }
        private Guid getRegardingOpportunityAccountId(IOrganizationService service, Guid _activityid, Guid _regardingObjectId)
        {
            EntityReference custRef = (EntityReference)service.Retrieve(Opportunity.EntityLogicalName, _regardingObjectId, new ColumnSet("customerid")).Attributes["customerid"];
            if (custRef.LogicalName != Account.EntityLogicalName) throw new Exception("The Opportunity does not have an Account Customer");
            return custRef.Id;
        }
        private static bool shareRecordInTargetSystem(IOrganizationService service, Guid _recordId, Guid _sharedUser, string _entityLogicalName) //CHANGE TO ENTITY REFERENCE
        {
            List<KeyValuePair<AccessRights, EntityReference>> _targetSharing = new List<KeyValuePair<AccessRights, EntityReference>>();
            bool _shared = false;

            EntityReference _targetPrincipalEntityReference = new EntityReference("systemuser", _sharedUser);
            AccessRights _targetAccessRights = AccessRights.ReadAccess | AccessRights.WriteAccess | AccessRights.AppendAccess | AccessRights.AppendToAccess |
                AccessRights.AssignAccess | AccessRights.ShareAccess;

            _targetSharing.Add(new KeyValuePair<AccessRights, EntityReference>(_targetAccessRights, _targetPrincipalEntityReference));

            GrantAccessRequest grantRequest = new GrantAccessRequest()
            {
                Target = new EntityReference(_entityLogicalName, _recordId),
                PrincipalAccess = new PrincipalAccess()
                {
                    Principal = _targetPrincipalEntityReference,
                    AccessMask = _targetAccessRights
                }
            };
            GrantAccessResponse grantResponse = (GrantAccessResponse)service.Execute(grantRequest);

            return _shared;
        }
        private Guid getAccountOwnerFromAcccountId(IOrganizationService service, Guid _accountId, ITracingService tracingService)
        {
            try
            {
                return ((EntityReference)service.Retrieve(Account.EntityLogicalName, _accountId, new ColumnSet("ownerid")).Attributes["ownerid"]).Id;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error in the getAccountOwnerFromAccountId in the Share with Account Owner Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error in the getAccountOwnerFromAccountId in the Share with Account Owner Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error in the getAccountOwnerFromAccountId in the Share with Account Owner Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
