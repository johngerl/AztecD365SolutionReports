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
    public class OrderSplit : IPlugin
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
                Guid orderId = new Guid((string)context.InputParameters["ExistingOrderId"]);
                int numberToSplit = (int)context.InputParameters["NumberToSplit"];
                #region Fields
                string[] fields =
{
"azt_ponumber",
"name",
"transactioncurrencyid",
"pricelevelid",
"azt_recordownerid",
"opportunityid",
"quoteid",
"azt_quotenumber",
"customerid",
"description",
"requestdeliveryby",
"azt_estfulfillmentdate",
"azt_parentorderid",
"azt_trackingnumber",
"shippingmethodcode",
"freighttermscode",
"billto_line1",
"billto_line2",
"billto_line3",
"billto_name",
"billto_postalcode",
"billto_stateorprovince",
"shipto_line1",
"shipto_line2",
"shipto_line3",
"shipto_name",
"shipto_postalcode",
"shipto_stateorprovince"
};
                #endregion

                SalesOrder o = service.Retrieve(SalesOrder.EntityLogicalName, orderId, new ColumnSet(fields)).ToEntity<SalesOrder>();
                o.SalesOrderId = null;
                SalesOrder no = new SalesOrder()
                {
                    azt_PONumber = o.azt_PONumber,
                    Name = "Split " + o.Name,
                    TransactionCurrencyId = o.TransactionCurrencyId,
                    PriceLevelId = o.PriceLevelId,
                    azt_RecordOwnerId = o.azt_RecordOwnerId,
                    OpportunityId = o.OpportunityId,
                    QuoteId = o.QuoteId,
                    azt_QuoteNumber = o.azt_QuoteNumber,
                    CustomerId = o.CustomerId,
                    Description = o.Description,
                    RequestDeliveryBy = o.RequestDeliveryBy,
                    azt_EstFulfillmentDate = o.azt_EstFulfillmentDate,
                    azt_ParentOrderId = o.azt_ParentOrderId,
                    azt_TrackingNumber = o.azt_TrackingNumber,
                    ShippingMethodCode = o.ShippingMethodCode,
                    FreightTermsCode = o.FreightTermsCode,
                    BillTo_Line1 = o.BillTo_Line1,
                    BillTo_Line2 = o.BillTo_Line2,
                    BillTo_Line3 = o.BillTo_Line3,
                    BillTo_Name = o.BillTo_Name,
                    BillTo_PostalCode = o.BillTo_PostalCode,
                    BillTo_StateOrProvince = o.BillTo_StateOrProvince,
                    ShipTo_Line1 = o.ShipTo_Line1,
                    ShipTo_Line2 = o.ShipTo_Line2,
                    ShipTo_Line3 = o.ShipTo_Line3,
                    ShipTo_Name = o.ShipTo_Name,
                    ShipTo_PostalCode = o.ShipTo_PostalCode,
                    ShipTo_StateOrProvince = o.ShipTo_StateOrProvince
                };
                EntityCollection ec = CreateOrderLines(service, orderId, tracingService);
                for (int i = 0; i < numberToSplit; i++)
                {
                    Guid newOrderId = service.Create(no);
                    foreach (Entity L in ec.Entities)
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
                        if (licType.Value != 0) OP.azt_LicenseType = licType;
                        if (licTerm != 0) OP.azt_LicenseTermMonths = licTerm;
                        if (desc != string.Empty) OP.Description = desc;
                        if (curr.Id != Guid.Empty) OP.TransactionCurrencyId = curr;
                        OP.SalesOrderId = new EntityReference(SalesOrder.EntityLogicalName, newOrderId);
                        service.Create(OP);
                    }
                }
                context.OutputParameters["NumberSplit"] = numberToSplit;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the OrderSplit function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the OrderSplit function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the OrderSplit function: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private EntityCollection CreateOrderLines(IOrganizationService service, Guid existingOrderId, ITracingService tracingService)
        {
            EntityCollection ec = new EntityCollection();
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
", existingOrderId);
                #endregion
                EntityCollection retLines = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred while Creating New Opportunity Products in the OrderClone function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the CloneWithLines Method in the OrderClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the CloneWithLines in the OrderClone function: {0}", ex.ToString());
                throw;
            }
            #endregion
            return ec;
        }
    }
}
