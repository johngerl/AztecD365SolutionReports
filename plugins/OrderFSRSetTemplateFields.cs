using CrmContext;
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
    public class OrderFSRSetTemplateFields : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == SalesOrder.EntityLogicalName)
                {
                    SalesOrder order = ((Entity)context.InputParameters["Target"]).ToEntity<SalesOrder>();
                    if (order.Attributes.Contains("azt_fsrid"))
                    {
                        EntityReference fsrRef = order.azt_FSRId;
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        SystemUser fsr = service.Retrieve(SystemUser.EntityLogicalName, fsrRef.Id, new ColumnSet("address1_telephone1", "mobilephone", "azt_extension", "internalemailaddress", "azt_bookingurl")).ToEntity<SystemUser>();
                        string mainPhone = fsr.GetAttributeValue<string>("address1_telephone1");
                        string ext = fsr.GetAttributeValue<string>("azt_extension");
                        string mobile = fsr.GetAttributeValue<string>("mobilephone");
                        string email = fsr.GetAttributeValue<string>("internalemailaddress");
                        string bookingUrl = fsr.GetAttributeValue<string>("azt_bookingurl");
                        order.azt_FSRTelephone = mainPhone;
                        order.azt_FSRTelephoneExtension = ext;
                        order.azt_FSRMobileTelephone= mobile;
                        order.azt_FSREmail = email;
                        order.azt_BookingUrl = bookingUrl;
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the OrderFSRSetTemplateFields plugin." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            #endregion
        }
    }
}
