using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
namespace AztecPlugins
{
    public class ActivityCloseForceRecordOwner : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            try
            {
                if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
                {
                    if (((Entity)context.InputParameters["Target"]).LogicalName == Appointment.EntityLogicalName)
                    {
                        Appointment app = ((Entity)context.InputParameters["Target"]).ToEntity<Appointment>();
                        Appointment preApp = ((Entity)context.PreEntityImages["PreAppt"]).ToEntity<Appointment>();
                        if (app.Attributes.Contains("statecode"))
                        {
                            if (app.StateCode == AppointmentState.Completed)
                            {
                                if (!preApp.Attributes.Contains("azt_recordownerid"))
                                {
                                    throw new InvalidPluginExecutionException("This appointment does not have a record owner. Please contact Aztec Support.");
                                }
                            }
                        }
                    }
                    else if (((Entity)context.InputParameters["Target"]).LogicalName == PhoneCall.EntityLogicalName)
                    {
                        PhoneCall pc = ((Entity)context.InputParameters["Target"]).ToEntity<PhoneCall>();
                        PhoneCall prePc = ((Entity)context.PreEntityImages["PrePC"]).ToEntity<PhoneCall>();
                        if (pc.Attributes.Contains("statecode"))
                        {
                            if (pc.StateCode == PhoneCallState.Completed)
                            {
                                if (!prePc.Attributes.Contains("azt_recordownerid"))
                                {
                                    throw new InvalidPluginExecutionException("This phone call does not have a record owner. Please contact Aztec Support.");
                                }
                            }
                        }
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the ActivityCloseForceRecordOwner plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the ActivityCloseForceRecordOwner plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
