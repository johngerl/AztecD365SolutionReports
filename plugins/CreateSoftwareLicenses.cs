using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using System.Activities.Expressions;
namespace AztecPlugins
{
    public class CreateSoftwareLicenses : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Tracing/Context
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            //#region Print
            //if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity &&
            //    ((Entity)context.InputParameters["Target"]).LogicalName == SalesOrder.EntityLogicalName)
            //{
            //    //if (context.Depth > 1) return;
            //    SalesOrder order = ((Entity)context.InputParameters["Target"]).ToEntity<SalesOrder>();
            //    Guid orderId = (Guid)order.SalesOrderId;
            //    //if (!order.Attributes.Contains("datefulfilled")) return;
            //    if (!(order.Attributes.Contains("statecode") && ((OptionSetValue)order.Attributes["statecode"]).Value == 3)) return;

            //    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            //    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

            //    EntityCollection orderLines = GetOrderLines(service, tracingService, orderId);
            //    foreach (var orderLine in orderLines.Entities)
            //    {
            //        int numberOfLicenses = Convert.ToInt32((decimal)orderLine.Attributes["quantity"]);
            //        if (!orderLine.Contains("productid")) return;
            //        Guid orderLineId = (Guid)orderLine.Attributes["salesorderdetailid"];
            //        EntityReference orderRef = order.ToEntityReference();
            //        EntityReference orderLineRef = new EntityReference(SalesOrderDetail.EntityLogicalName, orderLineId);

            //        if (IsClonedOrder(service, tracingService, orderRef.Id)) return;
            //        EntityReference productRef = (EntityReference)orderLine.Attributes["productid"];
            //        tracingService.Trace("Product Name: " + productRef.Name);
            //        Product product = service.Retrieve(Product.EntityLogicalName, productRef.Id, new ColumnSet("name", "azt_saas", "azt_isprint", "azt_nonsaastype", "azt_iscompanion", "productnumber")).ToEntity<Product>(); //New
            //        SetOrderType(service, tracingService, orderLineRef, product);
            //        bool isSaaS = product.GetAttributeValue<bool>("azt_saas");
            //        Entity cust = getCustomerRef(service, orderRef.Id, tracingService);
            //        //EntityReference orderCustRef = (EntityReference)cust["custRef"];
            //        #region Print
            //        if (!isSaaS)
            //        {
            //            //Print
            //            CreatePrintPurchase(service, tracingService, product, orderLine, cust, numberOfLicenses);
            //        }
            //        #endregion
            //    }
            //}
            //#endregion
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == SalesOrder.EntityLogicalName)
            {
                try
                {
                    //if (context.Depth > 1) return;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Entity order = (Entity)context.PostEntityImages["PostOrder"];
                    if (!(order.Attributes.Contains("statecode") && ((OptionSetValue)order.Attributes["statecode"]).Value == 3)) return;
                    EntityReference custRef = order.GetAttributeValue<EntityReference>("customerid");
                    EntityReference orderRecordOwnerRef = order.GetAttributeValue<EntityReference>("azt_recordownerid");
                    if (IsClonedOrder(service, tracingService, order.Id)) return;

                    #region Line Fetch
                    string _fetch =
string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='salesorderdetail'>
    <attribute name='productid' />
    <attribute name='quantity' />
    <attribute name='salesorderdetailid' />
    <attribute name='azt_licensetype' />
    <attribute name='azt_licensetermmonths' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='salesorderid' operator='eq' uitype='salesorder' value='{0}' />
    </filter>
  </entity>
</fetch>", order.Id);
                    #endregion
                    EntityCollection lines = service.RetrieveMultiple(new FetchExpression(_fetch));
                    foreach (var l in lines.Entities)
                    {
                        Entity orderLine = (Entity)l;                                        /////////////////////BE SURE TO INCLUDE ALL THE FIELDS ON THE LINE
                        int numberOfLicenses = Convert.ToInt32((decimal)orderLine.Attributes["quantity"]);
                        if (!orderLine.Contains("productid")) return;
                        Guid orderLineId = l.Id;
                        EntityReference orderLineRef = new EntityReference(SalesOrderDetail.EntityLogicalName, orderLineId);
                        EntityReference productRef = l.GetAttributeValue<EntityReference>("productid");
                        tracingService.Trace("Product Name: " + productRef.Name);
                        Product product = service.Retrieve(Product.EntityLogicalName, productRef.Id, new ColumnSet("name", "azt_saas", "azt_isprint", "azt_nonsaastype", "azt_iscompanion", "productnumber")).ToEntity<Product>(); //New
                        bool isSaaS = product.GetAttributeValue<bool>("azt_saas");

                        SetOrderType(service, tracingService, orderLineRef, product);

                        #region Software
                        if (isSaaS)
                        {
                            bool isCompanion = product.GetAttributeValue<bool>("azt_iscompanion");
                            string prodNum = product.ProductNumber;
                            bool createMultipleLicenses = false;
                            if (prodNum == "70001" || prodNum == "70002" || prodNum == "31001" || prodNum == "31003" || prodNum == "31001" || prodNum == "31006")
                                createMultipleLicenses = true;
                            //Entity cust = getCustomerRef(service, order.Id, tracingService);
                            //EntityReference orderCustRef = (EntityReference)cust["custRef"];
                            tracingService.Trace("Customer Name: " + custRef.Name);
                            //EntityReference orderOwnerRef = (EntityReference)cust["ownerRef"];

                            int licenseTermMonths = orderLine.Attributes.Contains("azt_licensetermmonths") ? (int)orderLine.Attributes["azt_licensetermmonths"] : 0;
                            OptionSetValue licenseType = orderLine.Attributes.Contains("azt_licensetype") ? (OptionSetValue)orderLine.Attributes["azt_licensetype"] : new OptionSetValue(0);

                            if (isCompanion || createMultipleLicenses)
                            {
                                for (int i = 0; i < numberOfLicenses; i++)
                                {
                                    CreateLicenses(service, tracingService, productRef, custRef, 1, licenseTermMonths, licenseType, isCompanion, i + 1, orderLineId);
                                }
                            }
                            else CreateLicenses(service, tracingService, productRef, custRef, numberOfLicenses, licenseTermMonths, licenseType, false, 0, orderLineId);
                        }
                        #endregion
                        #region Print
                        if (!isSaaS)
                        {
                            //Print
                            CreatePrintPurchase(service, tracingService, product, orderLine, custRef, numberOfLicenses);
                        }
                        #endregion
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error creating Software Licenses in the CreateSoftwareLicenses Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error creating Software Licenses in the CreateSoftwareLicenses Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error creating Software Licenses in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private EntityCollection GetOrderLines(IOrganizationService service, ITracingService tracingService, Guid orderId)
        {
            EntityCollection ec = new EntityCollection();
            #region Query
            string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='salesorderdetail'>
    <attribute name='productid' />
    <attribute name='quantity' />
    <attribute name='salesorderdetailid' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='salesorderid' operator='eq' uitype='salesorder' value='{0}' />
    </filter>
  </entity>
</fetch>
", orderId);
            #endregion
            ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            return ec;
        }
        private void CreatePrintPurchase(IOrganizationService service, ITracingService tracingService, Product product, Entity orderLine, EntityReference orderCustRef, int numberOfLicenses)
        {
            try
            {
                //EntityReference orderCustRef = (EntityReference)cust["custRef"];
                //EntityReference orderOwnerRef = (EntityReference)cust["ownerRef"];
                string productName = product.GetAttributeValue<string>("name");
                string name = orderCustRef.Name + " " + productName + " Print Purchase";

                azt_printpurchase pp = new azt_printpurchase()
                {
                    azt_CustomerId = orderCustRef,
                    azt_name = name,
                    azt_PrintProductId = product.ToEntityReference(),
                    azt_Quantity = numberOfLicenses,
                    azt_ISBN = product.GetAttributeValue<string>("productnumber"),
                    azt_PurchaseDate = DateTime.Today
                };
                Guid createdPrintPurchase = service.Create(pp);
                azt_allocatedlicense na = new azt_allocatedlicense()
                {
                    azt_PrintPurchaseId = new EntityReference(azt_printpurchase.EntityLogicalName, createdPrintPurchase),
                    azt_AllocationType = new OptionSetValue(327630001),
                    azt_CustomerId = orderCustRef,
                    azt_name = name,
                    azt_AllocatedToId = orderCustRef,
                    azt_StartDate = DateTime.Today,
                    azt_NumberofLicenses = numberOfLicenses
                };
                service.Create(na);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error creating Print Purchase in the CreateSoftwareLicenses Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error creating Print Purchase in the CreateSoftwareLicenses Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error creating Print Purchase in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private bool IsClonedOrder(IOrganizationService service, ITracingService tracingService, Guid id)
        {
            bool isCloned = false;
            try
            {
                SalesOrder o = service.Retrieve(SalesOrder.EntityLogicalName, id, new ColumnSet("azt_parentorderid")).ToEntity<SalesOrder>();
                if (o.Attributes.Contains("azt_parentorderid") && o.azt_ParentOrderId != null && o.azt_ParentOrderId.Id != Guid.Empty)
                    isCloned = true;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error getting IsClonedOrder in the CreateSoftwareLicenses Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error getting IsClonedOrder in the CreateSoftwareLicenses Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error getting IsClonedOrder in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return isCloned;
        }
        private void SetOrderType(IOrganizationService service, ITracingService tracingService, EntityReference orderLineRef, Product product)
        {
            try
            {
                OptionSetValue orderType = new OptionSetValue(0);
                bool isSaas = product.GetAttributeValue<bool>("azt_saas");
                bool isPrint = product.GetAttributeValue<bool>("azt_isprint");
                OptionSetValue nonSaasType = product.GetAttributeValue<OptionSetValue>("azt_nonsaastype");
                bool isCompanion = product.GetAttributeValue<bool>("azt_iscompanion");

                if (isCompanion)
                {
                    orderType.Value = 276530000; //Companion
                }
                else if (nonSaasType == null || (isPrint && nonSaasType.Value == 276530000))
                {
                    orderType.Value = 276530002; //Life Skills PRINT
                }
                else if (isSaas)
                {
                    orderType.Value = 276530003; //Software
                }
                else if (nonSaasType.Value == 276530001)
                {
                    orderType.Value = 276530001; //Kaplan
                }
                else if (nonSaasType.Value == 276530003)
                {
                    return; //GED Vouchers
                }
                if (orderType.Value == 0) return;
                SalesOrderDetail uOrderLine = new SalesOrderDetail()
                {
                    SalesOrderDetailId = orderLineRef.Id,
                    azt_OrderType = orderType
                };
                service.Update(uOrderLine);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error setting order type in the CreateSoftwareLicenses Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error setting order type in the CreateSoftwareLicenses Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error setting order type in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private static void CreateLicenses(IOrganizationService service, ITracingService tracingService, EntityReference productRef, EntityReference custRef, int numberOfLicenses, int licenseTermMonths, OptionSetValue licenseType, bool isCompanion, int num, Guid orderLineId)
        {
            string licName = string.Empty;
            Guid newSoftwareLicense = Guid.Empty;
            if (isCompanion) licName = " Companion" + num + " " + productRef.Name + " Software License";
            else licName = productRef.Name + " Software License";
            azt_softwarelicense newLicense = new azt_softwarelicense()
            {
                azt_name = licName,
                azt_AccountId = custRef,
                azt_SoftwareProductId = productRef,
                azt_ConcurrentUsers = numberOfLicenses,
                azt_LicenseStatus = new OptionSetValue(276530000),
                azt_LicenseTermMonths = licenseTermMonths,
                azt_PurchaseDate = DateTime.Today,
                azt_SupportExpirationDate = DateTime.Today.AddYears(1)
            };
            if (licenseType.Value != 0) newLicense.azt_LicenseType = licenseType;
            try
            {
                newSoftwareLicense = service.Create(newLicense);
                SalesOrderDetail uOL = new SalesOrderDetail()
                {
                    SalesOrderDetailId = orderLineId,
                    azt_SoftwareLicenseId = new EntityReference(azt_softwarelicense.EntityLogicalName, newSoftwareLicense)
                };
                service.Update(uOL);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error creating Companion Software Licenses in the CreateSoftwareLicenses Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error creating Software Licenses in the CreateSoftwareLicenses Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error creating Companion Software Licenses in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion

            if (isCompanion) return;
            azt_allocatedlicense nAllocation = new azt_allocatedlicense()
            {
                azt_SoftwareLicenseId = new EntityReference(azt_softwarelicense.EntityLogicalName, newSoftwareLicense),
                azt_CustomerId = custRef,
                azt_name = custRef.Name + " " + productRef.Name + " License Allocation",
                azt_AllocatedToId = custRef,
                azt_AllocationType = new OptionSetValue(327630000),
                azt_StartDate = DateTime.Today,
                azt_ExpirationDate = DateTime.Today.AddYears(1),
                azt_LicenseStatus = new OptionSetValue(276530000),
                azt_SoftwareProductId = productRef,
                azt_NumberofLicenses = numberOfLicenses,
                azt_LicenseTermMonths = licenseTermMonths
            };
            if (licenseType.Value != 0) nAllocation.azt_LicenseType = licenseType;
            try
            {
                service.Create(nAllocation);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error creating Allocations in the CreateSoftwareLicenses Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error creating Software Licenses in the CreateSoftwareLicenses Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error creating Allocations in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private Entity getCustomerRef(IOrganizationService service, Guid orderId, ITracingService tracingService)
        {
            EntityReference custRef = new EntityReference();
            EntityReference ownerRef = new EntityReference();
            Entity returnedCustomerRef = new Entity();
            try
            {
                #region Query
                string _fetch =
string.Format(
@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='salesorder'>
    <attribute name='customerid' />
    <attribute name='salesorderid' />
    <attribute name='azt_recordownerid' />
    <filter type='and'>
      <condition attribute='salesorderid' operator='eq' uitype='salesorder' value='{0}' />
    </filter>
  </entity>
</fetch>
", orderId);
                #endregion
                EntityCollection retOrders = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retOrders.Entities.Count != 1) throw new Exception("Could not find order");
                custRef = (EntityReference)retOrders.Entities[0].Attributes["customerid"];
                ownerRef = (EntityReference)retOrders.Entities[0].Attributes["azt_recordownerid"];
                returnedCustomerRef["custRef"] = custRef;
                returnedCustomerRef["ownerRef"] = ownerRef;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error obtaining Customer in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw new InvalidPluginExecutionException("Error obtaining Customer in the CreateSoftwareLicenses Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error obtaining Customer in the CreateSoftwareLicenses Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return returnedCustomerRef;
        }
    }
}
