using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using System.Security.Principal;
using System.Web;
namespace AztecPlugins
{
    public class LeadImport : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_leadimport.EntityLogicalName)
            {
                try
                {
                    azt_leadimport import = ((Entity)context.InputParameters["Target"]).ToEntity<azt_leadimport>();
                    Guid importId = import.Id;
                    string email = import.GetAttributeValue<string>("azt_email");
                    string companyName = import.GetAttributeValue<string>("azt_companyname");
                    #region Contact Query
                    string _contactFetch =
string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='contact'>
    <attribute name='fullname' />
    <attribute name='contactid' />
    <attribute name='parentcustomerid' />
    <order attribute='fullname' descending='false' />
    <filter type='and'>
      <condition attribute='emailaddress1' operator='eq' value='{0}' />
      <condition attribute='statecode' operator='eq' value='0' />
    </filter>
  </entity>
</fetch>", HttpUtility.HtmlEncode(email));
                    #endregion
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    EntityCollection contactCollection = service.RetrieveMultiple(new FetchExpression(_contactFetch));
                    if (contactCollection.Entities.Count > 1)
                        UpdateLeadImportMultipleContacts(service, tracingService, import);
                    else if (contactCollection.Entities.Count == 1)
                    {
                        Entity contact = contactCollection.Entities[0];
                        CreateLeadWithContact(service, tracingService, import, contact);
                    }
                    else if(contactCollection.Entities.Count == 0)
                    {
                        if (import.GetAttributeValue<string>("azt_companyname") != null && import.GetAttributeValue<string>("azt_companyname") != string.Empty)
                        {
                            #region Account Query
                            string _accountFetch =
string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='account'>
    <attribute name='name' />
    <attribute name='accountid' />
    <order attribute='name' descending='false' />
    <filter type='and'>
      <condition attribute='name' operator='eq' value='{0}' />
      <condition attribute='statecode' operator='eq' value='0' />
    </filter>
  </entity>
</fetch>", HttpUtility.HtmlEncode(companyName));
                            #endregion
                            EntityCollection ac = service.RetrieveMultiple(new FetchExpression(_accountFetch));
                            if(ac.Entities.Count == 1)
                            {
                                CreateLeadWithAccount(service, tracingService, ac.Entities[0], import);
                            }
                            else if (ac.Entities.Count > 1) //Mark Multiple Accounts Found
                            {
                                Lead l = new Lead()
                                {
                                    Subject = import.GetAttributeValue<string>("azt_importname") + " " + import.GetAttributeValue<string>("azt_email"),
                                    azt_OriginatingLeadImportId = new EntityReference(azt_leadimport.EntityLogicalName, import.Id),
                                    FirstName = import.GetAttributeValue<string>("azt_firstname"),
                                    LastName = import.GetAttributeValue<string>("azt_lastname"),
                                    JobTitle = import.GetAttributeValue<string>("azt_jobtitle"),
                                    CompanyName = import.GetAttributeValue<string>("azt_companyname"),
                                    EMailAddress1 = import.GetAttributeValue<string>("azt_email"),
                                    Telephone1 = import.GetAttributeValue<string>("azt_phone"),
                                    Address1_StateOrProvince = import.GetAttributeValue<string>("azt_stateprovince")
                                };
                                if (import.GetAttributeValue<EntityReference>("azt_leadsourceid") != null) l.azt_LeadSourceId = import.azt_LeadSourceId;
                                service.Create(l);

                                azt_leadimport li = new azt_leadimport()
                                {
                                    azt_leadimportId = import.Id,
                                    azt_Result = new OptionSetValue(327630004)
                                };
                                service.Update(li);
                            }
                            else //No Account OR Contact found 
                            {
                                Lead l = new Lead()
                                {
                                    Subject = import.GetAttributeValue<string>("azt_importname") + " " + import.GetAttributeValue<string>("azt_email"),
                                    azt_OriginatingLeadImportId = new EntityReference(azt_leadimport.EntityLogicalName, import.Id),
                                    FirstName = import.GetAttributeValue<string>("azt_firstname"),
                                    LastName = import.GetAttributeValue<string>("azt_lastname"),
                                    JobTitle = import.GetAttributeValue<string>("azt_jobtitle"),
                                    CompanyName = import.GetAttributeValue<string>("azt_companyname"),
                                    EMailAddress1 = import.GetAttributeValue<string>("azt_email"),
                                    Telephone1 = import.GetAttributeValue<string>("azt_phone"),
                                    Address1_StateOrProvince = import.GetAttributeValue<string>("azt_stateprovince")
                                };
                                if (import.GetAttributeValue<EntityReference>("azt_leadsourceid") != null) l.azt_LeadSourceId = import.azt_LeadSourceId;
                                service.Create(l);

                                azt_leadimport li = new azt_leadimport()
                                {
                                    azt_leadimportId = import.Id,
                                    azt_Result = new OptionSetValue(327630002)
                                };
                                service.Update(li);
                            }
                        }
                        else //No Company Name in file
                        {
                            Lead l = new Lead()
                            {
                                Subject = import.GetAttributeValue<string>("azt_importname") + " " + import.GetAttributeValue<string>("azt_email"),
                                azt_OriginatingLeadImportId = new EntityReference(azt_leadimport.EntityLogicalName, import.Id),
                                FirstName = import.GetAttributeValue<string>("azt_firstname"),
                                LastName = import.GetAttributeValue<string>("azt_lastname"),
                                JobTitle = import.GetAttributeValue<string>("azt_jobtitle"),
                                CompanyName = import.GetAttributeValue<string>("azt_companyname"),
                                EMailAddress1 = import.GetAttributeValue<string>("azt_email"),
                                Telephone1 = import.GetAttributeValue<string>("azt_phone"),
                                Address1_StateOrProvince = import.GetAttributeValue<string>("azt_stateprovince")
                            };
                            if (import.GetAttributeValue<EntityReference>("azt_leadsourceid") != null) l.azt_LeadSourceId = import.azt_LeadSourceId;
                            service.Create(l);

                            azt_leadimport li = new azt_leadimport()
                            {
                                azt_leadimportId = import.Id,
                                azt_Result = new OptionSetValue(327630002)
                            };
                            service.Update(li);
                        }
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("An error occurred in the LeadImport plugin: {0}", ex.ToString());
                    tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                    throw new InvalidPluginExecutionException("An error occurred in the LeadImport plugin." + ex.Detail.InnerFault.Message.ToString());
                }
                catch (Exception ex)
                {
                    tracingService.Trace("An error occurred in the LeadImport plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private void CreateLeadWithAccount(IOrganizationService service, ITracingService tracingService, Entity account, azt_leadimport import)
        {
            try
            {
                Lead l = new Lead()
                {
                    Subject = import.GetAttributeValue<string>("azt_importname") + " " + import.GetAttributeValue<string>("azt_email"),
                    ParentAccountId = new EntityReference(Account.EntityLogicalName, account.Id),
                    azt_OriginatingLeadImportId = new EntityReference(azt_leadimport.EntityLogicalName, import.Id),
                    FirstName = import.GetAttributeValue<string>("azt_firstname"),
                    LastName = import.GetAttributeValue<string>("azt_lastname"),
                    JobTitle = import.GetAttributeValue<string>("azt_jobtitle"),
                    CompanyName = import.GetAttributeValue<string>("azt_companyname"),
                    EMailAddress1 = import.GetAttributeValue<string>("azt_email"),
                    Telephone1 = import.GetAttributeValue<string>("azt_phone"),
                    Address1_StateOrProvince = import.GetAttributeValue<string>("azt_stateprovince")
                };
                if (import.GetAttributeValue<EntityReference>("azt_leadsourceid") != null) l.azt_LeadSourceId = import.azt_LeadSourceId;
                service.Create(l);

                azt_leadimport li = new azt_leadimport()
                {
                    azt_leadimportId = import.Id,
                    azt_Result = new OptionSetValue(327630001)
                };
                service.Update(li);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating lead with account in the LeadImport plugin: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating lead with account in the LeadImport plugin." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating lead with account in the LeadImport plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void CreateLeadWithContact(IOrganizationService service, ITracingService tracingService, azt_leadimport import, Entity contact)
        {
            try
            {
                Lead l = new Lead()
                {
                    Subject = import.GetAttributeValue<string>("azt_importname") + " " + import.GetAttributeValue<string>("azt_email"),
                    ParentContactId = new EntityReference(Contact.EntityLogicalName, contact.Id),
                    azt_OriginatingLeadImportId = new EntityReference(azt_leadimport.EntityLogicalName, import.Id),
                    FirstName = import.GetAttributeValue<string>("azt_firstname"),
                    LastName = import.GetAttributeValue<string>("azt_lastname"),
                    JobTitle = import.GetAttributeValue<string>("azt_jobtitle"),
                    CompanyName = import.GetAttributeValue<string>("azt_companyname"),
                    EMailAddress1 = import.GetAttributeValue<string>("azt_email"),
                    Telephone1 = import.GetAttributeValue<string>("azt_phone"),
                    Address1_StateOrProvince = import.GetAttributeValue<string>("azt_stateprovince")
                };
                if (contact.GetAttributeValue<EntityReference>("parentcustomerid") != null) l.ParentAccountId = contact.GetAttributeValue<EntityReference>("parentcustomerid");
                if (import.GetAttributeValue<EntityReference>("azt_leadsourceid") != null) l.azt_LeadSourceId = import.azt_LeadSourceId;
                service.Create(l);

                azt_leadimport li = new azt_leadimport()
                {
                    azt_leadimportId = import.Id,
                    azt_Result = new OptionSetValue(327630000)
                };
                service.Update(li);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred updating Lead Import with Contact-Account in the LeadImport plugin: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred updating Lead Import with Contact-Account in the LeadImport plugin." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred updating Lead Import with Contact-Account in the LeadImport plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void UpdateLeadImportMultipleContacts(IOrganizationService service, ITracingService tracingService, azt_leadimport import)
        {
            try
            {
                Lead l = new Lead()
                {
                    Subject = import.GetAttributeValue<string>("azt_importname") + " " + import.GetAttributeValue<string>("azt_email"),
                    azt_OriginatingLeadImportId = new EntityReference(azt_leadimport.EntityLogicalName, import.Id),
                    FirstName = import.GetAttributeValue<string>("azt_firstname"),
                    LastName = import.GetAttributeValue<string>("azt_lastname"),
                    JobTitle = import.GetAttributeValue<string>("azt_jobtitle"),
                    CompanyName = import.GetAttributeValue<string>("azt_companyname"),
                    EMailAddress1 = import.GetAttributeValue<string>("azt_email"),
                    Telephone1 = import.GetAttributeValue<string>("azt_phone"),
                    Address1_StateOrProvince = import.GetAttributeValue<string>("azt_stateprovince")
                };
                if (import.GetAttributeValue<EntityReference>("azt_leadsourceid") != null) l.azt_LeadSourceId = import.azt_LeadSourceId;
                service.Create(l);

                azt_leadimport li = new azt_leadimport()
                {
                    azt_leadimportId = import.Id,
                    azt_Result = new OptionSetValue(327630003)
                };
                service.Update(li);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred updating Lead Import Multiple Contacts Found in the LeadImport plugin: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred updating Lead Import Multiple Contacts Found in the LeadImport plugin." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred updating Lead Import Multiple Contacts Found in the LeadImport plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
