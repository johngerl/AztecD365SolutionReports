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
    public class OpportunityLineSyncToQuote : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            Guid quoteId = Guid.Empty;
            #region Service
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            try
            {
                if (context.Depth > 1) return;
                if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == OpportunityProduct.EntityLogicalName)
                {
                    OpportunityProduct oppLineContext = ((Entity)context.InputParameters["Target"]).ToEntity<OpportunityProduct>();
                    OpportunityProduct preOP = ((Entity)context.PreEntityImages["PreOP"]).ToEntity<OpportunityProduct>();
                    OpportunityProduct postOP = ((Entity)context.PostEntityImages["PostOP"]).ToEntity<OpportunityProduct>();
                    EntityReference oppRef = preOP.GetAttributeValue<EntityReference>("opportunityid");

                    EntityCollection quotes = GetLatestQuotes(service, oppRef.Id);
                    if(HasActiveQuote(service, quotes))
                    {
                        throw new InvalidPluginExecutionException("You cannot modify Opportunity Lines when there is an Active Quote. Please revise the quote first.");
                    }
                    Guid draftQuote = Guid.Empty;
                    foreach (var l in quotes.Entities)
                    {
                        quoteId = (Guid)l.Attributes["quoteid"];
                        OptionSetValue s = (OptionSetValue)l.Attributes["statecode"];
                        if (s.Value == 0) draftQuote = quoteId;
                    }
                    if(draftQuote != Guid.Empty)
                    {
                        EntityReference productRef = new EntityReference();
                        OptionSetValue licType = new OptionSetValue(0);
                        int licTerm = 0;
                        

                        EntityReference OppRef = oppLineContext.OpportunityId;
                        #region Fields
                        EntityReference preProdRef = preOP.ProductId;
                        EntityReference postProdRef = postOP.ProductId;
                        EntityReference changedUnit = GetChangedUOM(tracingService, service, preProdRef, postProdRef);
                        EntityReference preOppRef = preOP.OpportunityId;
                        Money extAmt = preOP.ExtendedAmount;
                        decimal qty = 0.0m;
                        Money manualDiscountAmt = new Money(0);
                        Money totalDiscount = new Money(0);
                        Money tax = new Money(0);
                        string writeInProduct = string.Empty;
                        #endregion
                        //if (context.ParentContext.ParentContext != null)
                        //    preOPContext = ((Entity)context.ParentContext.ParentContext.InputParameters["Target"]).ToEntity<OpportunityProduct>();
                        #region Qty
                        decimal changedQty = GetChangedQTY(preOP, postOP);
                        if (changedQty > 0.0m) { qty = changedQty; }
                        else
                        {
                            if (oppLineContext.Contains("quantity"))
                                qty = oppLineContext.GetAttributeValue<decimal>("quantity");
                        }
                        #endregion
                        #region Product
                        if (oppLineContext.Contains("productid"))
                        {
                            productRef = oppLineContext.GetAttributeValue<EntityReference>("productid");
                        }
                        #endregion
                        if (oppLineContext.Contains("productdescription"))
                            writeInProduct = oppLineContext.GetAttributeValue<string>("productdescription");
                        if (oppLineContext.Contains("manualdiscountamount"))
                            manualDiscountAmt = oppLineContext.GetAttributeValue<Money>("manualdiscountamount");
                        if (oppLineContext.Contains("tax"))
                            tax = oppLineContext.GetAttributeValue<Money>("tax");
                        if (oppLineContext.Contains("azt_licensetype"))
                            licType = oppLineContext.GetAttributeValue<OptionSetValue>("azt_licensetype");
                        if (oppLineContext.Contains("azt_licensetermmonths"))
                            licTerm = oppLineContext.GetAttributeValue<int>("azt_licensetermmonths");

                        //Guid quoteId = GetLatestQuote(tracingService, service, OppRef.Id); if (quoteId == Guid.Empty) return;
                        EntityCollection retQuoteLines = GetQuoteLines(tracingService, service, preProdRef, writeInProduct, quoteId, (decimal)preOP.Attributes["quantity"]);
                        if (retQuoteLines.Entities.Count == 0) throw new InvalidPluginExecutionException("No matching quote lines found.");
                        QuoteDetail ql = (retQuoteLines.Entities[0]).ToEntity<QuoteDetail>();
                        Guid qlId = (Guid)ql.QuoteDetailId;

                        QuoteDetail uQL = new QuoteDetail()
                        {
                            QuoteDetailId = qlId
                        };
                        if (qty > 0.0m) uQL.Quantity = qty;
                        if (productRef != null && productRef.Id != Guid.Empty) uQL.ProductId = productRef;
                        if (changedUnit != null && changedUnit.Id != Guid.Empty) uQL.UoMId = changedUnit;
                        if (oppLineContext.Contains("manualdiscountamount")) uQL.ManualDiscountAmount = manualDiscountAmt;
                        if (oppLineContext.Contains("tax")) uQL.Tax = tax;
                        if (licType.Value != 0) uQL.azt_LicenseType = licType;
                        if (licTerm != 0) uQL.azt_LicenseTermMonths = licTerm;
                        service.Update(uQL);
                    }
                }
            }
            #region ErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
        }
        private bool HasActiveQuote(IOrganizationService service, EntityCollection quotes)
        {
            bool has = false;
            try
            {
                foreach (var i in quotes.Entities)
                {
                    OptionSetValue s = (OptionSetValue)i.Attributes["statecode"];
                    if (s.Value == 1) return true;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            return has;
        }
        private EntityCollection GetLatestQuotes(IOrganizationService service, Guid oppId)
        {
            EntityCollection ret = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' top='1' mapping='logical' distinct='false'>
  <entity name='quote'>
    <attribute name='quoteid' />
    <attribute name='statecode' />
    <order attribute='modifiedon' descending='true' />
    <filter type='and'>
      <condition attribute='opportunityid' operator='eq' uitype='opportunity' value='{0}' />
    </filter>
  </entity>
</fetch>
", oppId);
                #endregion
                ret = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
            return ret;
        }
        private EntityReference GetChangedUOM(ITracingService tracingService, IOrganizationService service, EntityReference preProdRef, EntityReference postProdRef)
        {
            EntityReference newUOM = new EntityReference();
            try
            {
                if (preProdRef.Id != postProdRef.Id)
                {
                    Product preProductRef = service.Retrieve(Product.EntityLogicalName, preProdRef.Id, new ColumnSet("defaultuomid")).ToEntity<Product>();
                    Product postProductRef = service.Retrieve(Product.EntityLogicalName, postProdRef.Id, new ColumnSet("defaultuomid")).ToEntity<Product>();
                    if (preProductRef.DefaultUoMId.Id != postProductRef.DefaultUoMId.Id) newUOM = postProductRef.DefaultUoMId;
                }
            }
            #region ErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
            return newUOM;
        }
        private decimal GetChangedQTY(OpportunityProduct preOP, OpportunityProduct postOP)
        {
            decimal returnValue = 0.0m;
            decimal preValue = preOP.GetAttributeValue<decimal>("quantity");
            decimal postValue = postOP.GetAttributeValue<decimal>("quantity");
            if (preValue != postValue) return postValue;
            return returnValue;
        }
        private static EntityCollection GetQuoteLines(ITracingService tracingService, IOrganizationService service, EntityReference preProdRef, string writeInProduct, Guid quoteId, decimal qty)
        {
            #region QueryForQuoteLines
            string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quotedetail'>
    <attribute name='quotedetailid' />
    <filter type='and'>
      <filter type='or'>
        <condition attribute='productid' operator='eq' uitype='product' value='{0}' />
        <condition attribute='productdescription' operator='eq' value='{1}' />
      </filter>
      <condition attribute='quoteid' operator='eq' uitype='quote' value='{2}' />
      <condition attribute='quantity' operator='eq' value='{3}' />
    </filter>
  </entity>
</fetch>
", preProdRef.Id, writeInProduct, quoteId, qty);
            #endregion
            EntityCollection retOppLines = service.RetrieveMultiple(new FetchExpression(_fetch));
            return retOppLines;
        }
    }
}
