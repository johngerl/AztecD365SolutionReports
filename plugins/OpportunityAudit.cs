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
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
namespace AztecPlugins
{
    public class OpportunityAudit : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
                {
                    Entity opp = (Entity)context.InputParameters["Target"];
                    Entity preOpp = (Entity)context.PreEntityImages["PreOpp"];
                    Entity postOpp = (Entity)context.PostEntityImages["PostOpp"];
                    EntityReference parentOpp = postOpp.GetAttributeValue<EntityReference>("azt_parentopportunityid");
                    if (parentOpp != null) return;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    //SystemUser initUser = (service.Retrieve(SystemUser.EntityLogicalName, context.InitiatingUserId, new ColumnSet("fullname"))).ToEntity<SystemUser>();
                    //if (initUser.FullName.Contains("SYSTEM")) return; //Init user seems to be SYSTEM even when it shouldn't be
                    azt_opportunityauditrecord auditRec = new azt_opportunityauditrecord();

                    if (opp.Attributes.Contains("estimatedclosedate"))
                    {
                        DateTime preCloseDate;
                        DateTime postCloseDate = (DateTime)postOpp.Attributes["estimatedclosedate"];

                        if (preOpp.Attributes.Contains("estimatedclosedate"))
                        {
                            preCloseDate = (DateTime)preOpp.Attributes["estimatedclosedate"];
                            if (DateTime.Compare(preCloseDate, postCloseDate) != 0)
                            {
                                auditRec.azt_PreviousEstCloseDate = (DateTime)preOpp.Attributes["estimatedclosedate"];
                                auditRec.azt_NewEstCloseDate = (DateTime)postOpp.Attributes["estimatedclosedate"];
                            }
                        }
                    }
                    if (opp.Attributes.Contains("estimatedvalue"))
                    {
                        auditRec.azt_NewEstimatedValue = (Money)postOpp.Attributes["estimatedvalue"];
                        if (preOpp.Attributes.Contains("estimatedvalue"))
                            auditRec.azt_PreviousEstimatedValue = (Money)preOpp.Attributes["estimatedvalue"];

                    }
                    if (opp.Attributes.Contains("azt_probability"))
                    {
                        OptionSetValue prob = opp.GetAttributeValue<OptionSetValue>("azt_probability");
                        //OptionSetValue prob = (OptionSetValue)opp.Attributes["azt_probability"];
                        string probText = string.Empty;
                        if (prob != null)
                            probText = GetOptionSetValueLabel("opportunity", "azt_probability", prob.Value, service);
                        else
                            probText = "Null";
                        auditRec.azt_NewProbability = probText;
                        string prevProbability = string.Empty;
                        if (preOpp.Attributes.Contains("azt_probability")){
                            prevProbability = GetOptionSetValueLabel("opportunity", "azt_probability", ((OptionSetValue)preOpp.Attributes["azt_probability"]).Value, service);
                            auditRec.azt_PreviousProbability = prevProbability;
                        }
                        else
                        {
                            prevProbability = "Null";
                            auditRec.azt_PreviousProbability = prevProbability;
                        }
                    }
                    EntityReference changedBy = postOpp.GetAttributeValue<EntityReference>("azt_lastmodifiedbyid");
                    string changedByString = string.Empty;
                    if (changedBy != null)
                    {
                        auditRec.OwnerId = changedBy;
                        changedByString = changedBy.Name;
                    }
                    else
                        changedByString = "No Changed By";
                    auditRec.azt_name = changedByString + " " + DateTime.Now.ToString();
                    auditRec.azt_OpportunityId = new EntityReference(Opportunity.EntityLogicalName, (Guid)opp.Attributes["opportunityid"]);
                    service.Create(auditRec);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred while creating an Opportunity Audit Record: {0}", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while creating an Opportunity Audit Record: {0}", ex);
                throw;
            }
            #endregion ErrorHandling
        }
        private string getStringValue(OptionSetValue optionSetValue)
        {
            string retOpt = string.Empty;
            switch (optionSetValue.Value)
            {
                case 276530000:
                    retOpt = "10%";
                    break;
                case 276530001:
                    retOpt = "20%";
                    break;
                case 276530002:
                    retOpt = "30%";
                    break;
                case 276530003:
                    retOpt = "40%";
                    break;
                case 276530004:
                    retOpt = "50%";
                    break;
                case 276530005:
                    retOpt = "60%";
                    break;
                case 276530006:
                    retOpt = "70%";
                    break;
                case 276530007:
                    retOpt = "80%";
                    break;
                case 276530008:
                    retOpt = "90%";
                    break;
                case 276530009:
                    retOpt = "100%";
                    break;
            }
            return retOpt;
        }
        private string GetOptionSetValueLabel(string entityName, string fieldName, int optionSetValue, IOrganizationService service)
        {
            var attReq = new RetrieveAttributeRequest();
            attReq.EntityLogicalName = entityName;
            attReq.LogicalName = fieldName;
            attReq.RetrieveAsIfPublished = true;

            var attResponse = (RetrieveAttributeResponse)service.Execute(attReq);
            var attMetadata = (EnumAttributeMetadata)attResponse.AttributeMetadata;

            return attMetadata.OptionSet.Options.Where(x => x.Value == optionSetValue).FirstOrDefault().Label.UserLocalizedLabel.Label;
        }
    }
}
