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
    public class OpportunityLastActivityDate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Tracing/Context
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Opportunity.EntityLogicalName)
            {
                Opportunity opp = ((Entity)context.InputParameters["Target"]).ToEntity<Opportunity>();
                if (opp.Attributes.Contains("estimatedvalue") || opp.Attributes.Contains("estimatedclosedate") || opp.Attributes.Contains("azt_probability"))
                {
                    try
                    {
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        Opportunity o = new Opportunity()
                        {
                            OpportunityId = opp.Id,
                            azt_LastActivityDate = DateTime.UtcNow
                        };
                        try
                        {
                            service.Update(o);
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
            #region PhoneCall
            if ((context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity") && context.InputParameters.Contains("EntityMoniker") && context.InputParameters["EntityMoniker"] is EntityReference &&
                ((EntityReference)context.InputParameters["EntityMoniker"]).LogicalName == PhoneCall.EntityLogicalName)
            {
                Guid phonecallId = ((EntityReference)context.InputParameters["EntityMoniker"]).Id;
                #region Service
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                PhoneCall phonecall = service.Retrieve(PhoneCall.EntityLogicalName, phonecallId, new ColumnSet("regardingobjectid")).ToEntity<PhoneCall>();
                if (!phonecall.Attributes.Contains("regardingobjectid")) return;
                EntityReference regardingObjectRef = phonecall.GetAttributeValue<EntityReference>("regardingobjectid");
                if (regardingObjectRef.LogicalName != Opportunity.EntityLogicalName) return;
                Opportunity opp = new Opportunity()
                {
                    OpportunityId = regardingObjectRef.Id,
                    azt_LastActivityDate = DateTime.UtcNow
                };
                try
                {
                    service.Update(opp);
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
            #endregion
            #region Email
            if ((context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity") && context.InputParameters.Contains("EntityMoniker") && context.InputParameters["EntityMoniker"] is EntityReference &&
                ((EntityReference)context.InputParameters["EntityMoniker"]).LogicalName == Email.EntityLogicalName)
            {
                Guid emailId = ((EntityReference)context.InputParameters["EntityMoniker"]).Id;
                #region Service
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                Email email = service.Retrieve(Email.EntityLogicalName, emailId, new ColumnSet("regardingobjectid")).ToEntity<Email>();
                if (!email.Attributes.Contains("regardingobjectid")) return;
                EntityReference regardingObjectRef = email.GetAttributeValue<EntityReference>("regardingobjectid");
                if (regardingObjectRef.LogicalName != Opportunity.EntityLogicalName) return;
                Opportunity opp = new Opportunity()
                {
                    OpportunityId = regardingObjectRef.Id,
                    azt_LastActivityDate = DateTime.UtcNow
                };
                try
                {
                    service.Update(opp);
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
            #endregion
            #region Task
            if ((context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity") && context.InputParameters.Contains("EntityMoniker") && context.InputParameters["EntityMoniker"] is EntityReference &&
                ((EntityReference)context.InputParameters["EntityMoniker"]).LogicalName == CrmContext.Task.EntityLogicalName)
            {
                Guid taskId = ((EntityReference)context.InputParameters["EntityMoniker"]).Id;
                #region Service
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                CrmContext.Task task = service.Retrieve(CrmContext.Task.EntityLogicalName, taskId, new ColumnSet("regardingobjectid")).ToEntity<CrmContext.Task>();
                if (!task.Attributes.Contains("regardingobjectid")) return;
                EntityReference regardingObjectRef = task.GetAttributeValue<EntityReference>("regardingobjectid");
                if (regardingObjectRef.LogicalName != Opportunity.EntityLogicalName) return;
                Opportunity opp = new Opportunity()
                {
                    OpportunityId = regardingObjectRef.Id,
                    azt_LastActivityDate = DateTime.UtcNow
                };
                try
                {
                    service.Update(opp);
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
            #endregion
            #region Appointment
            if ((context.MessageName == "SetState" || context.MessageName == "SetStateDynamicEntity") && context.InputParameters.Contains("EntityMoniker") && context.InputParameters["EntityMoniker"] is EntityReference &&
                ((EntityReference)context.InputParameters["EntityMoniker"]).LogicalName == Appointment.EntityLogicalName)
            {
                Guid taskId = ((EntityReference)context.InputParameters["EntityMoniker"]).Id;
                #region Service
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                Appointment task = service.Retrieve(Appointment.EntityLogicalName, taskId, new ColumnSet("regardingobjectid")).ToEntity<Appointment>();
                if (!task.Attributes.Contains("regardingobjectid")) return;
                EntityReference regardingObjectRef = task.GetAttributeValue<EntityReference>("regardingobjectid");
                if (regardingObjectRef.LogicalName != Opportunity.EntityLogicalName) return;
                Opportunity opp = new Opportunity()
                {
                    OpportunityId = regardingObjectRef.Id,
                    azt_LastActivityDate = DateTime.UtcNow
                };
                try
                {
                    service.Update(opp);
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
    }
}
