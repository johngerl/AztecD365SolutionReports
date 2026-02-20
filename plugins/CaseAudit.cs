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
    public class CaseAudit : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Tracing/Context
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Incident.EntityLogicalName)
                {
                    if (context.MessageName == "Create")
                    {
                        Incident updatedCase = ((Entity)context.InputParameters["Target"]).ToEntity<Incident>();
                        if (updatedCase.Contains("ownerid"))
                        {
                            EntityReference newOwnerRef = updatedCase.OwnerId;
                            azt_caseaudit c = new azt_caseaudit()
                            {
                                azt_NewOwnerId = newOwnerRef,
                                azt_CaseId = new EntityReference(Incident.EntityLogicalName, (Guid)updatedCase.IncidentId)
                            };
                            #region Service
                            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                            #endregion
                            try
                            {
                                service.Create(c);
                            }
                            #region ErrorHandling
                            catch (FaultException<OrganizationServiceFault> ex)
                            {
                                tracingService.Trace("An error occurred while creating an CaseAudit Audit Record: {0}", ex.InnerException.ToString());
                            }
                            catch (Exception ex)
                            {
                                tracingService.Trace("An error occurred while creating an CaseAudit Audit Record: {0}", ex.InnerException.ToString());
                                throw;
                            }
                            #endregion ErrorHandling
                        }
                    }
                    else if(context.MessageName == "Update")
                    {
                        Incident updatedCase = ((Entity)context.InputParameters["Target"]).ToEntity<Incident>();
                        Incident preCase = ((Entity)context.PreEntityImages["PreCase"]).ToEntity<Incident>();
                        EntityReference preOwnerRef = preCase.OwnerId;
                        EntityReference newOwnerRef = updatedCase.OwnerId;
                        azt_caseaudit c = new azt_caseaudit()
                        {
                            azt_NewOwnerId = newOwnerRef,
                            azt_CaseId = new EntityReference(Incident.EntityLogicalName, (Guid)updatedCase.IncidentId),
                            azt_PreviousOwnerId = preOwnerRef
                        };
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        try
                        {
                            service.Create(c);
                        }
                        #region ErrorHandling
                        catch (FaultException<OrganizationServiceFault> ex)
                        {
                            tracingService.Trace("An error occurred while creating an CaseAudit Audit Record: {0}", ex.InnerException.ToString());
                        }
                        catch (Exception ex)
                        {
                            tracingService.Trace("An error occurred while creating an CaseAudit Audit Record: {0}", ex.InnerException.ToString());
                            throw;
                        }
                        #endregion ErrorHandling
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred while creating an CaseAudit Audit Record: {0}", ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while creating an CaseAudit Audit Record: {0}", ex.InnerException.ToString());
                throw;
            }
            #endregion ErrorHandling
        }
    }
}
