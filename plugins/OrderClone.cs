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
    public class OrderClone : IPlugin
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
                EntityReference newOrderRef = (EntityReference)context.OutputParameters["NewOrderRef"];
                EntityReference clonedOrderRef = (EntityReference)context.InputParameters["Target"];
                CreateNewOrderLines(service, tracingService, newOrderRef, clonedOrderRef);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the OrderClone function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the OrderClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the OrderClone function: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void CreateNewOrderLines(IOrganizationService service, ITracingService tracingService, EntityReference newOrderRef, EntityReference clonedOrderRef)
        {
            try
            {
                #region Fetch
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='salesorderdetail'>
    <attribute name='productid' />
    <attribute name='productdescription' />
    <attribute name='priceperunit' />
    <attribute name='quantity' />
    <attribute name='extendedamount' />
    <attribute name='salesorderdetailid' />
    <attribute name='producttypecode' />
    <attribute name='isproductoverridden' />
    <attribute name='transactioncurrencyid' />
    <attribute name='manualdiscountamount' />
    <attribute name='description' />
    <attribute name='productname' />
    <attribute name='azt_licensetype' />
    <attribute name='azt_licensetermmonths' />
    <attribute name='uomid' />
    <attribute name='tax' />
    <attribute name='ispriceoverridden' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='salesorderid' operator='eq' uitype='salesorder' value='{0}' />
    </filter>
  </entity>
</fetch>
", clonedOrderRef.Id);
                #endregion
                EntityCollection retLines = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (Entity L in retLines.Entities)
                {
                    EntityReference prodRef = L.Attributes.Contains("productid") ? (EntityReference)L.Attributes["productid"] : new EntityReference();
                    if (prodRef != null)
                        prodRef = Utility.GetCurrentProductRef(service, prodRef, tracingService);
                    string prodDesc = L.Attributes.Contains("productdescription") ? (string)L.Attributes["productdescription"] : string.Empty;
                    Money pricePerUnit = L.Attributes.Contains("priceperunit") ? (Money)L.Attributes["priceperunit"] : new Money(0);
                    decimal qty = L.Attributes.Contains("quantity") ? (decimal)L.Attributes["quantity"] : 0;
                    EntityReference uomRef = L.Attributes.Contains("uomid") ? (EntityReference)L.Attributes["uomid"] : new EntityReference();
                    Money tax = L.Attributes.Contains("tax") ? (Money)L.Attributes["tax"] : new Money(0);
                    bool isProdOverridden = (bool)L.Attributes["isproductoverridden"];
                    OptionSetValue prodTypeCode = L.Attributes.Contains("producttypecode") ? (OptionSetValue)L.Attributes["producttypecode"] : new OptionSetValue(0);
                    string prodName = L.Attributes.Contains("productname") ? (string)L.Attributes["productname"] : string.Empty;
                    bool isPriceOverridden = (bool)L.Attributes["ispriceoverridden"];
                    Money manDiscountAmt = L.Attributes.Contains("manualdiscountamount") ? (Money)L.Attributes["manualdiscountamount"] : new Money(0);
                    OptionSetValue licType = L.Attributes.Contains("azt_licensetype") ? (OptionSetValue)L.Attributes["azt_licensetype"] : new OptionSetValue(0);
                    int licTerm = L.Attributes.Contains("azt_licensetermmonths") ? (int)L.Attributes["azt_licensetermmonths"] : 0;
                    string desc = L.Attributes.Contains("description") ? (string)L.Attributes["description"] : string.Empty;
                    EntityReference curr = L.Attributes.Contains("transactioncurrencyid") ? (EntityReference)L.Attributes["transactioncurrencyid"] : new EntityReference();

                    SalesOrderDetail OP = new SalesOrderDetail();
                    if (prodRef.Id != Guid.Empty) OP.ProductId = prodRef;
                    if (prodDesc != string.Empty) OP.ProductDescription = prodDesc;
                    //if (pricePerUnit.Value != 0) OP.PricePerUnit = pricePerUnit;
                    if (qty != 0) OP.Quantity = qty;
                    if (uomRef.Id != Guid.Empty) OP.UoMId = uomRef;
                    if (tax.Value != 0) OP.Tax = tax;
                    OP.IsProductOverridden = isProdOverridden;
                    if (prodTypeCode.Value != 0) OP.ProductTypeCode = prodTypeCode;
                    if (prodName != string.Empty) OP.ProductName = prodName;
                    OP.IsPriceOverridden = isPriceOverridden;
                    if (manDiscountAmt.Value != 0) OP.ManualDiscountAmount = manDiscountAmt;
                    if (licType.Value != 0) OP.azt_LicenseType = licType;
                    if (licTerm != 0) OP.azt_LicenseTermMonths = licTerm;
                    if (desc != string.Empty) OP.Description = desc;
                    if (curr.Id != Guid.Empty) OP.TransactionCurrencyId = curr;
                    OP.SalesOrderId = newOrderRef;
                    service.Create(OP);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred while Creating New Opportunity Products in the OpportunityClone function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the CloneWithLines Method in the OpportunityClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the CloneWithLines in the OpportunityClone function: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
