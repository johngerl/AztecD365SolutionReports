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
    public class PhonecallCreateCallback : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if ((context.MessageName == "Create" || context.MessageName == "Update") && context.InputParameters.Contains("Target") && 
                context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == PhoneCall.EntityLogicalName)
            {
                #region SetState
                if ((context.ParentContext != null && (context.ParentContext.MessageName == "SetState" || context.ParentContext.MessageName == "SetStateDynamicEntity" || context.ParentContext.MessageName == "Update")) == true)
                {
                    Entity entity = (Entity)context.InputParameters["Target"];
                    if (!entity.Attributes.Contains("statecode"))
                        return;
                    OptionSetValue recordState = entity.Attributes["statecode"] as OptionSetValue;
                    if (entity.LogicalName != "phonecall" || recordState.Value != 1)
                        return;
                    try
                    {
                        Guid _recordId = (Guid)entity.Attributes["activityid"];
                        //get Organization Service
                        // Obtain the organization service reference.
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #region Members
                        EntityReference _owner = new EntityReference();
                        bool _returnedAutoCreateCallback = false;
                        string _returnedDescription = string.Empty;
                        string _calculatedDescription = string.Empty;
                        bool _returnedCopySubject = false;
                        bool _returnedCreateCRTQueue = false;
                        string _returnedSubject = string.Empty;
                        string _calculatedSubject = string.Empty;
                        string _returnedPhoneNumber = string.Empty;
                        bool _returnedCopyDescription = false;
                        DateTime _dueDate = new DateTime();
                        DateTime _returnedCallbackOn = new DateTime();
                        DateTime _calculatedCallbackDate = DateTime.Today;
                        OptionSetValue _returnedCallbackIn = new OptionSetValue(0);
                        EntityCollection _returnedFromCollection = null;
                        EntityCollection _returnedCallToCollection = null;
                        ActivityParty[] _CallToPartyArray = new ActivityParty[] { };
                        Guid fromPartyId = Guid.Empty;
                        EntityReference _returnedRegardingObject = new EntityReference();
                        EntityReference _toPartyReference2 = new EntityReference();
                        EntityReference _toPartyReference3 = new EntityReference();

                        #endregion Members
                        #region RemoveQueueItem
                        removeQueueItem(service, _recordId);
                        #endregion
                        EntityCollection _phonecallFieldCollection = getPhonecallFields(service, _recordId);
                        foreach (var pc in _phonecallFieldCollection.Entities)
                        {
                            if (pc.Attributes.Contains("from"))
                                _returnedFromCollection = (EntityCollection)pc.Attributes["from"];
                            EntityReference _fromPartyReference = (EntityReference)_returnedFromCollection[0]["partyid"];
                            if (pc.Attributes.Contains("to"))
                                _returnedCallToCollection = (EntityCollection)pc.Attributes["to"];
                            EntityReference _toPartyReference1 = (EntityReference)_returnedCallToCollection[0]["partyid"];
                            int _numToRecords = _returnedCallToCollection.Entities.Count;
                            if (_numToRecords > 1)
                            {
                                _toPartyReference2 = (EntityReference)_returnedCallToCollection[1]["partyid"];
                            }
                            if (_numToRecords > 2)
                            {
                                _toPartyReference3 = (EntityReference)_returnedCallToCollection[2]["partyid"];
                            }
                            _owner = (EntityReference)pc.Attributes["ownerid"];
                            if (_owner.LogicalName == "team")
                            {
                                if (!pc.Attributes.Contains("azt_recordownerid") || pc.GetAttributeValue<EntityReference>("azt_recordownerid") == null) return;
                                _owner = pc.GetAttributeValue<EntityReference>("azt_recordownerid");
                                if (_owner == null || _owner.Id == Guid.Empty)
                                    return;
                            }
                            if (pc.Attributes.Contains("azt_autocreatecallback"))
                                _returnedAutoCreateCallback = (bool)pc.Attributes["azt_autocreatecallback"];
                            if (pc.Attributes.Contains("description"))
                                _returnedDescription = (string)pc.Attributes["description"];
                            if (pc.Attributes.Contains("phonenumber"))
                                _returnedPhoneNumber = (string)pc.Attributes["phonenumber"];
                            if (pc.Attributes.Contains("regardingobjectid"))
                                _returnedRegardingObject = (EntityReference)pc.Attributes["regardingobjectid"];
                            if (pc.Attributes.Contains("azt_copysubject"))
                                _returnedCopySubject = (bool)pc.Attributes["azt_copysubject"];
                            if (pc.Attributes.Contains("scheduledend"))
                                _dueDate = (DateTime)pc.Attributes["scheduledend"];
                            if (pc.Attributes.Contains("azt_copydescription"))
                                _returnedCopyDescription = (bool)pc.Attributes["azt_copydescription"];
                            if (pc.Attributes.Contains("azt_addtocrtqueue"))
                                _returnedCreateCRTQueue = (bool)pc.Attributes["azt_addtocrtqueue"];
                            if (pc.Attributes.Contains("azt_callbackon"))
                                _returnedCallbackOn = (DateTime)pc.Attributes["azt_callbackon"];
                            if (pc.Attributes.Contains("azt_callbackin"))
                            {
                                _returnedCallbackIn = (OptionSetValue)pc.Attributes["azt_callbackin"];
                                _calculatedCallbackDate = getCallBackDate(_returnedCallbackIn, _returnedCallbackOn);
                            }
                            if (pc.Attributes.Contains("subject"))
                                _returnedSubject = (string)pc.Attributes["subject"];

                            if (_returnedCopySubject == true)
                            {
                                _calculatedSubject = _returnedSubject;
                            }
                            if (_returnedCopyDescription == true)
                            {
                                _calculatedDescription = _returnedDescription;
                            }
                            if (_returnedAutoCreateCallback == true)
                            {
                                #region Parties
                                ActivityParty _callFrom = new ActivityParty()
                                {
                                    PartyId = _fromPartyReference
                                };
                                List<ActivityParty> ToAPArray = new List<ActivityParty>();
                                //Always add First 'To' Party
                                ActivityParty _callTo1 = new ActivityParty()
                                {
                                    PartyId = _toPartyReference1
                                };
                                ToAPArray.Add(_callTo1);

                                if (_numToRecords > 1)
                                {
                                    ActivityParty _callTo2 = new ActivityParty()
                                    {
                                        PartyId = _toPartyReference2
                                    };
                                    ToAPArray.Add(_callTo2);
                                }
                                if (_numToRecords > 2)
                                {
                                    ActivityParty _callTo3 = new ActivityParty()
                                    {
                                        PartyId = _toPartyReference3
                                    };
                                    ToAPArray.Add(_callTo3);
                                }
                                #endregion Parties
                                #region CreateCall
                                if (_returnedRegardingObject.Id != Guid.Empty)
                                {
                                    PhoneCall call = new PhoneCall()
                                    {
                                        To = ToAPArray,
                                        From = new ActivityParty[] { _callFrom },
                                        Subject = _calculatedSubject,
                                        Description = _calculatedDescription,
                                        ScheduledStart = _calculatedCallbackDate,
                                        PhoneNumber = _returnedPhoneNumber,
                                        RegardingObjectId = _returnedRegardingObject,
                                        OwnerId = _owner
                                    };
                                    Guid newPhoncallId = service.Create(call);
                                    if (_returnedCreateCRTQueue) createQueueItem(service, newPhoncallId, _owner, _dueDate);
                                }
                                else
                                {
                                    PhoneCall call = new PhoneCall()
                                    {
                                        To = ToAPArray,
                                        From = new ActivityParty[] { _callFrom },
                                        Subject = _calculatedSubject,
                                        Description = _calculatedDescription,
                                        PhoneNumber = _returnedPhoneNumber,
                                        ScheduledStart = _calculatedCallbackDate,
                                        OwnerId = _owner
                                    };
                                    Guid newPhoncallId = service.Create(call);
                                    if (_returnedCreateCRTQueue) createQueueItem(service, newPhoncallId, _owner, _dueDate);
                                }
                                #endregion
                            }
                        }
                    }
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("Error in Commission Logic Plugin: {0}", ex.ToString());
                        throw new InvalidPluginExecutionException("An error occured in the Auto-Create Callback Plugin: ", ex);
                    }
                }
                #endregion
                #region Create
                else if (context.ParentContext != null && context.MessageName == "Create")
                {
                    try
                    {
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        //Entity entity = (Entity)context.InputParameters["Target"];
                        Entity entity = (Entity)context.PostEntityImages["PostPhoneCall"];
                        if (entity.Attributes.Contains("regardingobjectid") == false) return;
                        Guid _recordId = (Guid)entity.Attributes["activityid"];
                        //Guid _acctOwnerId = getAcctOwnerId(service, _recordId);
                        Guid _acctOwnerId = Guid.Empty;
                        Guid _pcOwnerId = (Guid)((EntityReference)entity.Attributes["ownerid"]).Id;
                        EntityReference _regardingObject = (EntityReference)entity.Attributes["regardingobjectid"];
                        string _regObjTypeCodeName = _regardingObject.LogicalName;
                        if (_regObjTypeCodeName == "account")
                        {
                            _acctOwnerId = getAcctOwnerId(service, (Guid)_regardingObject.Id);
                        }
                        else if (_regObjTypeCodeName == "contact")
                        {
                            Guid _returnedContParentAcctId = getContactParentAcctId(service, (Guid)_regardingObject.Id);
                            if (_returnedContParentAcctId == Guid.Empty) return;
                            _acctOwnerId = getAcctOwnerId(service, _returnedContParentAcctId);
                        }
                        else if (_regObjTypeCodeName == "opportunity")
                        {
                            Guid _returnedOppParentAcctId = getOpptyParentAcctId(service, (Guid)_regardingObject.Id);
                            if (_returnedOppParentAcctId == Guid.Empty) return;
                            _acctOwnerId = getAcctOwnerId(service, _returnedOppParentAcctId);
                        }
                        else if (_regObjTypeCodeName == "incident")
                        {
                            Guid _returnedCaseParentAcctId = getCaseParentAcctId(service, (Guid)_regardingObject.Id);
                            if (_returnedCaseParentAcctId == Guid.Empty) return;
                            _acctOwnerId = getAcctOwnerId(service, _returnedCaseParentAcctId);
                        }
                        else if (_regObjTypeCodeName == "azt_softwarelicense")
                        {
                            Guid _returnedSLParentAcctId = getSLParentAcctId(service, (Guid)_regardingObject.Id);
                            if (_returnedSLParentAcctId == Guid.Empty) return;
                            _acctOwnerId = getAcctOwnerId(service, _returnedSLParentAcctId);
                        }
                        if (_acctOwnerId != Guid.Empty)
                        {
                            if (_pcOwnerId != _acctOwnerId)
                            {
                                #region OldAssign
                                //AssignRequest assign = new AssignRequest
                                //{
                                //    Assignee = new EntityReference(SystemUser.EntityLogicalName,_acctOwnerId),
                                //    Target = new EntityReference(PhoneCall.EntityLogicalName,_recordId)
                                //};
                                //service.Execute(assign);
                                #endregion
                                ////_shareRecordWithAcctOwner(service, _regardingObject, _acctOwnerId, _recordId);
                            }
                        }
                    }
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("Error in Create Callback Plugin: {0}", ex.ToString());
                        throw new InvalidPluginExecutionException("An error occured while creating auto-callback: ", ex.InnerException);
                    }
                }

                #endregion
            }
        }
        private Guid getSLParentAcctId(IOrganizationService service, Guid _recordId)
        {
            try
            {
                Guid _returnedParentAcctId = Guid.Empty;
                Entity _SL = service.Retrieve("azt_softwarelicense", _recordId, new ColumnSet("azt_softwarelicenseid"));
                EntityReference _acct = (EntityReference)_SL.Attributes["azt_azteccustomerid"];
                return _acct.Id;
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occured obtaining the Account ID from the Software License for Auto-Creating a Phonecall: ", ex.InnerException);
            }
        }
        private Guid getCaseParentAcctId(IOrganizationService service, Guid _recordId)
        {
            try
            {
                Guid _returnedParentAcctId = Guid.Empty;
                Entity _case = service.Retrieve("incident", _recordId, new ColumnSet("customerid"));
                if (_case != null && _case.Attributes.Contains("customerid"))
                {
                    EntityReference _cust = (EntityReference)_case.Attributes["customerid"];
                    if (_cust.LogicalName != "account") return Guid.Empty;
                    _returnedParentAcctId = (Guid)((EntityReference)_case.Attributes["customerid"]).Id;
                }
                return _returnedParentAcctId;
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occured obtaining the Account ID from the Case for Auto-Creating a Phonecall: ", ex.InnerException);
            }
        }
        private void _shareRecordWithAcctOwner(IOrganizationService service, EntityReference _regardingObject, Guid _acctOwnerId, Guid _recordId)
        {
            List<KeyValuePair<AccessRights, EntityReference>> _targetSharing = new List<KeyValuePair<AccessRights, EntityReference>>();
            EntityReference _targetPrincipalEntityReference = new EntityReference("systemuser", _acctOwnerId);
            AccessRights _targetAccessRights = AccessRights.ReadAccess | AccessRights.WriteAccess | AccessRights.AppendAccess | AccessRights.AppendToAccess |
                AccessRights.AssignAccess | AccessRights.ShareAccess;
            _targetSharing.Add(new KeyValuePair<AccessRights, EntityReference>(_targetAccessRights, _targetPrincipalEntityReference));
            GrantAccessRequest grantRequest = new GrantAccessRequest()
            {
                Target = new EntityReference("phonecall", _recordId),
                PrincipalAccess = new PrincipalAccess()
                {
                    Principal = _targetPrincipalEntityReference,
                    AccessMask = _targetAccessRights
                }
            };
            try
            {
                GrantAccessResponse grantResponse = (GrantAccessResponse)service.Execute(grantRequest);
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occured while sharing the record with the Account Owner: ", ex.InnerException);
            }
        }
        private void removeQueueItem(IOrganizationService service, Guid _recordId)
        {
            string[] _fields =
            {
 "objectid",
 "objecttypecode"
            };
            Guid _queueItemId = Guid.Empty;
            QueryByAttribute _queueItemQuery = new QueryByAttribute("queueitem");
            _queueItemQuery.ColumnSet = new ColumnSet(_fields);
            _queueItemQuery.Attributes.Add("objectid");
            _queueItemQuery.Values.AddRange(_recordId.ToString());
            EntityCollection _retQueueItems = service.RetrieveMultiple(_queueItemQuery);
            if (_retQueueItems.Entities.Count == 0) return;
            foreach (Entity q in _retQueueItems.Entities)
            {
                _queueItemId = (Guid)q.Attributes["queueitemid"];
                service.Delete("queueitem", _queueItemId);
            }
        }
        private Guid getOpptyParentAcctId(IOrganizationService service, Guid _oppId)
        {
            try
            {
                Guid _returnedParentAcctId = Guid.Empty;
                Entity _opp = service.Retrieve("opportunity", _oppId, new ColumnSet("customerid"));
                if (_opp != null && _opp.Attributes.Contains("customerid"))
                {
                    EntityReference _cust = (EntityReference)_opp.Attributes["customerid"];
                    if (_cust.LogicalName != "account") return Guid.Empty;
                    _returnedParentAcctId = (Guid)_cust.Id;
                }
                return _returnedParentAcctId;
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occured obtaining the Account ID from the Opportunity for Auto-Creating a Phonecall: ", ex.InnerException);
            }
        }
        private Guid getContactParentAcctId(IOrganizationService service, Guid _contactId)
        {
            try
            {
                Guid _returnedParentAcctId = Guid.Empty;
                QueryByAttribute querybyattribute = new QueryByAttribute("contact");
                querybyattribute.ColumnSet = new ColumnSet("parentcustomerid");
                querybyattribute.Attributes.Add("contactid");
                querybyattribute.Values.AddRange(_contactId.ToString());
                EntityCollection retrieved = service.RetrieveMultiple(querybyattribute);
                foreach (Entity c in retrieved.Entities)
                {
                    if (c.Attributes.Contains("parentcustomerid"))
                        _returnedParentAcctId = (Guid)((EntityReference)c.Attributes["parentcustomerid"]).Id;
                }
                return _returnedParentAcctId;
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occured obtaining the Account ID from the Contact for Auto-Creating a Phonecall: ", ex.InnerException);
            }
        }
        private Guid getAcctOwnerId(IOrganizationService service, Guid _accountId)
        {
            try
            {
                Guid _returnedOwnerId = Guid.Empty;
                QueryByAttribute querybyattribute = new QueryByAttribute("account");
                querybyattribute.ColumnSet = new ColumnSet("ownerid");
                querybyattribute.Attributes.Add("accountid");
                querybyattribute.Values.Add(_accountId.ToString());
                EntityCollection retrieved = service.RetrieveMultiple(querybyattribute);
                foreach (Entity pc in retrieved.Entities)
                {
                    _returnedOwnerId = (Guid)((EntityReference)pc.Attributes["ownerid"]).Id;
                }
                return _returnedOwnerId;
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occured obtaining the Account ID for Auto-Creating a Phonecall: ", ex.InnerException);
            }
        }
        private void createQueueItem(IOrganizationService service, Guid newPhoncallId, EntityReference _owner, DateTime _dueDate)
        {
            Guid CRTQueue = Guid.Empty;
            QueryByAttribute _qQuery = new QueryByAttribute("queue");
            _qQuery.ColumnSet = new ColumnSet("queueid");
            _qQuery.Attributes.Add("name");
            _qQuery.Values.Add("CRT");
            EntityCollection _queues = service.RetrieveMultiple(_qQuery);
            if (_queues.Entities.Count == 0) return;
            foreach (Entity q in _queues.Entities)
            {
                CRTQueue = (Guid)q.Attributes["queueid"];
            }

            //Guid CRTQueue = new Guid("3BB8BF35-D7D4-E511-80E6-00155D0ABD03");
            QueueItem qi = new QueueItem()
            {
                QueueId = new EntityReference("queue", CRTQueue),
                ObjectId = new EntityReference("phonecall", newPhoncallId),
                azt_DueDate = _dueDate
            };
            service.Create(qi);
        }
        private EntityCollection getPhonecallFields(IOrganizationService service, Guid _recordId)
        {
            #region Fields
            string[] _fields =
            {
"to",
"from",
"description",
"subject",
"azt_autocreatecallback",
"azt_copysubject",
"azt_copydescription",
"azt_addtocrtqueue",
"azt_callbackin",
"azt_callbackon",
"phonenumber",
"regardingobjectid",
"scheduledend",
"ownerid",
"azt_recordownerid"
            };
            #endregion Fields
            QueryExpression phonecallQuery = new QueryExpression("phonecall")
            {
                EntityName = PhoneCall.EntityLogicalName,
                ColumnSet = new ColumnSet(_fields),
                Criteria =
                {
                    Filters =
                    {
                        new FilterExpression
                        {
                            FilterOperator = LogicalOperator.And,
                            Conditions =
                            {
                                new ConditionExpression("activityid",ConditionOperator.Equal,_recordId)
                            },
                        },
                    }
                }
            };
            try
            {
                EntityCollection returnedPhonecallCollection = service.RetrieveMultiple(phonecallQuery);
                return returnedPhonecallCollection;
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occured in the Auto-Create Callback Plugin while fetching the Phonecall Record", ex);
            }
        }
        private DateTime getCallBackDate(OptionSetValue _callbackIn, DateTime _callbackOn)
        {
            DateTime _callBackDate = new DateTime();
            DateTime _now = DateTime.Today;
            switch (_callbackIn.Value)
            {
                case 276530000: //1 Day
                    _callBackDate = _now.AddDays(1);
                    break;
                case 276530001: //2 Days
                    _callBackDate = _now.AddDays(2);
                    break;
                case 276530002: //3 Days
                    _callBackDate = _now.AddDays(3);
                    break;
                case 276530003: //7 Days
                    _callBackDate = _now.AddDays(7);
                    break;
                case 276530004: //30 Days
                    _callBackDate = _now.AddDays(30);
                    break;
                case 276530005: //Specific Date
                    _callBackDate = _callbackOn;
                    break;
            }
            return _callBackDate;
        }
    }
}
