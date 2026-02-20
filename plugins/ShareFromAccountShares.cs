using CrmContext;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
namespace AztecPlugins
{
    public class ShareFromAccountShares : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Contact.EntityLogicalName)
                {
                    Contact contact = ((Entity)context.InputParameters["Target"]).ToEntity<Contact>();
                    if (!contact.Attributes.Contains("parentcustomerid")) return;
                    EntityReference acctRef = contact.ParentCustomerId;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    ShareRecord(service, tracingService, acctRef, contact.ToEntityReference());
                }
                else if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Opportunity.EntityLogicalName)
                {
                    Opportunity opportunity = ((Entity)context.InputParameters["Target"]).ToEntity<Opportunity>();
                    if (!opportunity.Attributes.Contains("customerid")) return;
                    EntityReference recordRef = opportunity.CustomerId;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    ShareRecord(service, tracingService, recordRef, opportunity.ToEntityReference());
                }
                else if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == PhoneCall.EntityLogicalName)
                {
                    PhoneCall phonecall = ((Entity)context.InputParameters["Target"]).ToEntity<PhoneCall>();
                    if (!phonecall.Attributes.Contains("regardingobjectid")) return;
                    if(phonecall.RegardingObjectId.LogicalName != Account.EntityLogicalName) return;
                    EntityReference recordRef = phonecall.RegardingObjectId;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    ShareRecord(service, tracingService, recordRef, phonecall.ToEntityReference());
                }
                else if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == CrmContext.Task.EntityLogicalName)
                {
                    CrmContext.Task task = ((Entity)context.InputParameters["Target"]).ToEntity<CrmContext.Task>();
                    if (!task.Attributes.Contains("regardingobjectid")) return;
                    if (task.RegardingObjectId.LogicalName != Account.EntityLogicalName) return;
                    EntityReference recordRef = task.RegardingObjectId;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    ShareRecord(service, tracingService, recordRef, task.ToEntityReference());
                }
                else if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Appointment.EntityLogicalName)
                {
                    Appointment appointment = ((Entity)context.InputParameters["Target"]).ToEntity<Appointment>();
                    if (!appointment.Attributes.Contains("regardingobjectid")) return;
                    if (appointment.RegardingObjectId.LogicalName != Account.EntityLogicalName) return;
                    EntityReference recordRef = appointment.RegardingObjectId;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    ShareRecord(service, tracingService, recordRef, appointment.ToEntityReference());
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the ShareFromAccountShares plugin: {0}", ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the ShareFromAccountShares plugin: {0}", ex.InnerException.ToString());
                throw;
            }
            #endregion ErrorHandling
        }
        private static void ShareRecord(IOrganizationService service, ITracingService tracingService, EntityReference acctRef, EntityReference recordToShareRef)
        {
            try
            {
                RetrieveSharedPrincipalsAndAccessRequest req = new RetrieveSharedPrincipalsAndAccessRequest()
                {
                    Target = acctRef
                };
                RetrieveSharedPrincipalsAndAccessResponse accessResponse = (RetrieveSharedPrincipalsAndAccessResponse)service.Execute(req);
                if (accessResponse.PrincipalAccesses.Count() == 0) return;
                foreach (var principalAccess in accessResponse.PrincipalAccesses)
                {
                    if (principalAccess.Principal.LogicalName == Team.EntityLogicalName)
                    {
                        tracingService.Trace(GetEntityReferenceString(principalAccess.Principal) + " Access: " + principalAccess.AccessMask);

                        Team team = service.Retrieve(Team.EntityLogicalName, principalAccess.Principal.Id, new ColumnSet("teamtype", "name")).ToEntity<Team>();
                        OptionSetValue teamType = team.TeamType;
                        if (teamType.Value == 1) continue;
                    }
                    var grantAccessReq = new GrantAccessRequest()
                    {
                        PrincipalAccess = principalAccess,
                        Target = recordToShareRef
                    };
                    try
                    {
                        service.Execute(grantAccessReq);
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("An error occurred while sharing in the ShareFromAccountShares plugin: {0}", ex.InnerException.ToString());
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("An error occurred while sharing in the ShareFromAccountShares plugin: {0}", ex.InnerException.ToString());
                        throw;
                    }
                    #endregion ErrorHandling
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the ShareFromAccountShares plugin: {0}", ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the ShareFromAccountShares plugin: {0}", ex.InnerException.ToString());
                throw;
            }
            #endregion ErrorHandling
        }
        private static string GetEntityReferenceString(EntityReference entityReference)
        {
            return string.Format("{0} with GUID {1}", entityReference.LogicalName,
                entityReference.Id);
        }
    }
}
