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
    public class AddressSearchCleanupFields : IPlugin
    {
        //Register on pre-create of Lead, Contact, Account
        //
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if((context.MessageName == "Create" || context.MessageName == "Update") && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && 
                (((Entity)context.InputParameters["Target"]).LogicalName == Lead.EntityLogicalName) || ((Entity)context.InputParameters["Target"]).LogicalName == Account.EntityLogicalName ||
                ((Entity)context.InputParameters["Target"]).LogicalName == Contact.EntityLogicalName)
            {
                #region Create
                if(context.MessageName == "Create" || context.MessageName == "Update")
                {
                    try
                    {
                        Entity e = (Entity)context.InputParameters["Target"];
                        if (e.Attributes.Contains("azt_addresssearch") && ((string)e.GetAttributeValue<string>("azt_addresssearch")).Length > 1)
                        {
                            e["azt_addresssearch"] = null;
                        }
                        else if (e.Attributes.Contains("azt_addresssearch2") && ((string)e.GetAttributeValue<string>("azt_addresssearch2")).Length > 1)
                        {
                            e["azt_addresssearch2"] = null;
                        }
                    }
                    #region SyncErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        throw new InvalidPluginExecutionException("An error occurred in the AddressSearchCleanupFields plugin." + ex.Detail.InnerFault.Message.ToString());
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("An error occurred in the AddressSearchCleanupFields plugin: {0}", ex.ToString());
                        throw;
                    }
                    #endregion
                }
                #endregion
            }
            #region Service
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
        }
    }
}
