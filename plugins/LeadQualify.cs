using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using System.Net;
namespace AztecPlugins
{
    public class LeadQualify : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "QualifyLead")
            {
                context.InputParameters["CreateContact"] = false;
                EntityReference leadRef = (EntityReference)context.InputParameters["LeadId"];
                Guid userId = (Guid)context.InitiatingUserId;
                context.SharedVariables.Add("LeadQualifyUser", userId);
                #region Service
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                Lead lead = service.Retrieve(Lead.EntityLogicalName, leadRef.Id, new ColumnSet("parentaccountid")).ToEntity<Lead>();
                if (lead.Attributes.Contains("parentaccountid"))
                {
                    EntityReference acctRef = lead.ParentAccountId;
                    context.InputParameters["CustomerId"] = acctRef;
                }
                else
                {
                    if (!lead.Attributes.Contains("parentaccountid"))
                    {
                        try
                        {
                            throw new Exception("A lead must have a parent account before it can be qualified.");
                        }
                        #region
                        catch (FaultException<OrganizationServiceFault> ex)
                        {
                            throw new InvalidPluginExecutionException("A lead must have a parent account before it can be qualified." + ex.Detail.InnerFault.Message.ToString());
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidPluginExecutionException(ex.Message);
                        }
                        #endregion
                    }
                }
            }
        }
    }
}
