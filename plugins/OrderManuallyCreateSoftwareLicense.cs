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
    public class OrderManuallyCreateSoftwareLicense : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                Guid orderLineId = new Guid((string)context.InputParameters["OrderLineId"]);
                EntityReference orderRef = (EntityReference)context.InputParameters["SalesOrderRef"];
                EntityReference custRef = (EntityReference)context.InputParameters["CustomerRef"];
                EntityReference licRef = (EntityReference)context.OutputParameters["SoftwareLicenseRef"];
                #region LineFields
                string[] _fields =
                {
"productid",
"azt_licensetermmonths",
"azt_licensetype",
"quantity"
                };
                #endregion
                SalesOrderDetail line = ((Entity)service.Retrieve(SalesOrderDetail.EntityLogicalName, orderLineId, new ColumnSet(_fields))).ToEntity<SalesOrderDetail>();
                if (!line.Contains("productid")) throw new Exception("No product to create license for.");
                EntityReference prodRef = line.ProductId;
                bool isCompanion = prodRef.Name.Contains("Companion");
                if (!Utility.getIsProductSoftware(service, prodRef.Id, tracingService)) throw new Exception("Product is not a software.");
                //if (!Utility.getIsProductSoftware(service, productRef.Id, tracingService)) return;
                int licTermMonths = line.Contains("azt_licensetermmonths") ? (int)line.azt_LicenseTermMonths : 0;
                OptionSetValue licType = line.Contains("azt_licensetype") ? line.azt_LicenseType : new OptionSetValue(0);
                decimal qty = line.Contains("quantity") ? (decimal)line.Quantity : 0;
                Account cust = ((Entity)service.Retrieve(Account.EntityLogicalName, custRef.Id, new ColumnSet("ownerid"))).ToEntity<Account>();
                EntityReference ownerRef = cust.OwnerId;

                string licName = string.Empty;
                if (isCompanion) licName = custRef.Name + " Companion " + prodRef.Name + " Software License";
                else licName = custRef.Name + " " + prodRef.Name + " Software License";
                #region CreateLicense
                azt_softwarelicense lic = new azt_softwarelicense()
                {
                    azt_name = licName,
                    azt_SoftwareProductId = prodRef,
                    azt_softwarelicenseId = licRef.Id,
                    azt_LicenseTermMonths = licTermMonths,
                    azt_LicenseStatus = new OptionSetValue(276530000),
                    azt_PurchaseDate = DateTime.Today,
                    azt_SupportExpirationDate = DateTime.Today.AddMonths(licTermMonths),
                    azt_OrderLineId = new EntityReference(SalesOrderDetail.EntityLogicalName, orderLineId)
                };
                if (licType.Value != 0) lic.azt_LicenseType = licType;
                service.Update(lic);
                #endregion
                #region CreateAllocation
                if (isCompanion) return;
                azt_allocatedlicense nAllocation = new azt_allocatedlicense()
                {
                    azt_SoftwareLicenseId = new EntityReference(azt_softwarelicense.EntityLogicalName, licRef.Id),
                    azt_CustomerId = custRef,
                    azt_name = custRef.Name + " " + prodRef.Name + " License Allocation",
                    azt_AllocatedToId = custRef,
                    azt_StartDate = DateTime.Today,
                    azt_ExpirationDate = DateTime.Today.AddMonths(licTermMonths),
                    azt_SoftwareProductId = prodRef,
                    azt_NumberofLicenses = Convert.ToInt32(qty),
                    azt_LicenseTermMonths = licTermMonths,
                    OwnerId = ownerRef
                };
                if (licType.Value != 0) nAllocation.azt_LicenseType = licType;
                service.Create(nAllocation);
                #endregion
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the OrderManuallyCreateSoftwareLicense function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the OrderManuallyCreateSoftwareLicense function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the OrderManuallyCreateSoftwareLicense function: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
