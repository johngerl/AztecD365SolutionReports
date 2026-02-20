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
    public class AccountReassignmentShareRecords : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Account.EntityLogicalName)
            {
                try
                {
                    Account acct = ((Entity)context.InputParameters["Target"]).ToEntity<Account>();
                    Guid acctId = (Guid)acct.AccountId;
                    EntityReference newAcctOwnerRef = acct.OwnerId;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    #region Activities
                    EntityCollection activities = GetActivities(service, tracingService, acctId);
                    if(activities.Entities.Count > 0)
                    {
                        foreach(Entity a in activities.Entities)
                        {
                            Guid activityId = (Guid)a.Attributes["activityid"];
                            Guid activityOwnerId = ((EntityReference)a.Attributes["ownerid"]).Id;
                            string activityTypeCode = (string)a.Attributes["activitytypecode"];
                            if (newAcctOwnerRef.Id != activityOwnerId) Utility.shareRecordInTargetSystem(service, activityId, newAcctOwnerRef.Id, activityTypeCode);
                        }
                    }
                    #endregion
                    #region Engagements
                    EntityCollection engagements = GetEngagements(service, tracingService, acctId);
                    if(engagements.Entities.Count > 0)
                    {
                        foreach(Entity e in engagements.Entities)
                        {
                            Guid engagementId = (Guid)e.Attributes["azt_engagementid"];
                            EntityReference engagementOwnerRef = (EntityReference)e.Attributes["ownerid"];
                            if (newAcctOwnerRef.Id != engagementOwnerRef.Id) Utility.shareRecordInTargetSystem(service, engagementId, newAcctOwnerRef.Id, azt_engagement.EntityLogicalName);
                        }
                    }
                    #endregion
                    #region Opportunities
                    EntityCollection opportunities = GetOpportunities(service, tracingService, acctId);
                    if(opportunities.Entities.Count > 0)
                    {
                        foreach(Entity o in opportunities.Entities)
                        {
                            Guid oppId = (Guid)o.Attributes["opportunityid"];
                            EntityReference oppOwnerRef = (EntityReference)o.Attributes["ownerid"];
                            if (newAcctOwnerRef.Id != oppOwnerRef.Id) Utility.shareRecordInTargetSystem(service, oppId, newAcctOwnerRef.Id, Opportunity.EntityLogicalName);
                        }
                    }
                    #endregion
                    #region Cases
                    EntityCollection cases = GetCases(service, tracingService, acctId);
                    if(cases.Entities.Count > 0)
                    {
                        foreach(Entity c in cases.Entities)
                        {
                            Guid caseId = (Guid)c.Attributes["incidentid"];
                            EntityReference caseOwnerRef = (EntityReference)c.Attributes["ownerid"];
                            if (newAcctOwnerRef.Id != caseOwnerRef.Id) Utility.shareRecordInTargetSystem(service, caseId, newAcctOwnerRef.Id, Incident.EntityLogicalName);
                        }
                    }
                    #endregion
                    #region Trainings
                    EntityCollection custTrainings = GetTrainings(service, tracingService, acctId);
                    List<Guid> trainings = new List<Guid>();
                    if(custTrainings.Entities.Count > 0)
                    {
                        foreach(Entity ct in custTrainings.Entities)
                        {
                            Guid custTrainingId = (Guid)ct.Attributes["azt_customertrainingid"];
                            EntityReference custTrainingOwnerRef = (EntityReference)ct.Attributes["ownerid"];
                            EntityReference trainingRef = (EntityReference)ct.Attributes["azt_trainingid"];
                            trainings.Add(trainingRef.Id);
                            if (newAcctOwnerRef.Id != custTrainingOwnerRef.Id) Utility.shareRecordInTargetSystem(service, custTrainingId, newAcctOwnerRef.Id, azt_customertraining.EntityLogicalName);
                            if (!trainings.Contains(trainingRef.Id)) Utility.shareRecordInTargetSystem(service, trainingRef.Id, newAcctOwnerRef.Id, azt_training.EntityLogicalName);
                        }
                    }
                    #endregion
                    #region SoftwareLicenses
                    EntityCollection softwareLicenses = GetSoftwareLicenses(service, tracingService, acctId);
                    //List<Guid> licenses = new List<Guid>();
                    if(softwareLicenses.Entities.Count > 0)
                    {
                        foreach(Entity lic in softwareLicenses.Entities)
                        {
                            Guid licId = (Guid)lic.Attributes["azt_softwarelicenseid"];
                            EntityReference licOwnerRef = (EntityReference)lic.Attributes["ownerid"];
                            //licenses.Add(licId);
                            if (licOwnerRef.Id != newAcctOwnerRef.Id) Utility.shareRecordInTargetSystem(service, licId, newAcctOwnerRef.Id, azt_softwarelicense.EntityLogicalName);
                        }
                    }
                    #endregion
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error Sharing Related Records in the AccountReassignmentShareRecords Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error Sharing Related Records in the AccountReassignmentShareRecords Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error Sharing Related Records in the AccountReassignmentShareRecords Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private EntityCollection GetSoftwareLicenses(IOrganizationService service, ITracingService tracingService, Guid acctId)
        {
            EntityCollection retLicenses = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_softwarelicense'>
    <attribute name='azt_softwarelicenseid' />
    <attribute name='ownerid' />
    <attribute name='azt_accountid' />
    <order attribute='azt_accountid' descending='false' />
    <filter type='and'>
      <condition attribute='azt_accountid' operator='eq' uitype='account' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctId);
                #endregion
                retLicenses = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error Getting Related SoftwareLicense Records in the AccountReassignmentShareRecords Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error Getting Related SoftwareLicense Records in the AccountReassignmentShareRecords Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error Getting Related SoftwareLicense Records in the AccountReassignmentShareRecords Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retLicenses;
        }
        private EntityCollection GetTrainings(IOrganizationService service, ITracingService tracingService, Guid acctId)
        {
            EntityCollection retTrainings = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_customertraining'>
    <attribute name='azt_trainingid' />
    <attribute name='ownerid' />
    <attribute name='azt_customertrainingid' />
    <order attribute='azt_trainingid' descending='false' />
    <filter type='and'>
      <condition attribute='azt_accountid' operator='eq' uitype='account' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctId);
                #endregion
                retTrainings = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error Getting Related Training Records in the AccountReassignmentShareRecords Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error Getting Related Training Records in the AccountReassignmentShareRecords Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error Getting Related Training Records in the AccountReassignmentShareRecords Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retTrainings;
        }
        private EntityCollection GetCases(IOrganizationService service, ITracingService tracingService, Guid acctId)
        {
            EntityCollection retCases = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='incident'>
    <attribute name='ownerid' />
    <attribute name='incidentid' />
    <filter type='and'>
      <condition attribute='customerid' operator='eq' uitype='account' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctId);
                #endregion
                retCases = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error Getting Related Case Records in the AccountReassignmentShareRecords Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error Getting Related Case Records in the AccountReassignmentShareRecords Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error Getting Related Case Records in the AccountReassignmentShareRecords Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retCases;
        }
        private EntityCollection GetOpportunities(IOrganizationService service, ITracingService tracingService, Guid acctId)
        {
            EntityCollection retOpps = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='opportunity'>
    <attribute name='ownerid' />
    <attribute name='opportunityid' />
    <order attribute='name' descending='false' />
    <filter type='and'>
      <condition attribute='customerid' operator='eq' uitype='account' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctId);
                #endregion
                retOpps = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error Getting Related Opportunity Records in the AccountReassignmentShareRecords Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error Getting Related Opportunity Records in the AccountReassignmentShareRecords Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error Getting Related Opportunity Records in the AccountReassignmentShareRecords Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retOpps;
        }
        private EntityCollection GetEngagements(IOrganizationService service, ITracingService tracingService, Guid acctId)
        {
            EntityCollection retEng = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_engagement'>
    <attribute name='azt_engagementid' />
    <attribute name='ownerid' />
    <order attribute='azt_name' descending='false' />
    <filter type='and'>
      <condition attribute='azt_accountid' operator='eq' uitype='account' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctId);
                #endregion
                retEng = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error Getting Related Engagements Records in the AccountReassignmentShareRecords Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error Getting Related Engagements Records in the AccountReassignmentShareRecords Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error Getting Related Engagements Records in the AccountReassignmentShareRecords Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retEng;
        }
        private EntityCollection GetActivities(IOrganizationService service, ITracingService tracingService, Guid acctId)
        {
            EntityCollection retActivities = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='activitypointer'>
    <attribute name='activityid' />
    <attribute name='activitytypecode' />
    <attribute name='ownerid' />
    <order attribute='modifiedon' descending='false' />
    <filter type='and'>
      <condition attribute='regardingobjectid' operator='eq' uitype='account' value='{0}' />
    </filter>
  </entity>
</fetch>
", acctId);
                #endregion
                retActivities = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error Getting Related Activity Records in the AccountReassignmentShareRecords Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error Getting Related Activity Records in the AccountReassignmentShareRecords Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error Getting Related Activity Records in the AccountReassignmentShareRecords Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retActivities;
        }
    }
}
