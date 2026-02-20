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
    class UpdateOppFromQuote : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #region Update
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                if (((Entity)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName)
                {
                    QuoteDetail QD = ((Entity)context.PostEntityImages["PostQD"]).ToEntity<QuoteDetail>();

                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    if (QD.Contains("azt_opportunityproductid") && IsLatestQuote(service, tracingService, QD))
                    {
                        Guid oppProdId = QD.azt_OpportunityProductId.Id;
                        Guid QuoteLineId = (Guid)QD.QuoteDetailId;

                    }


                }
                #region Quote
                else if (((Entity)context.InputParameters["Target"]).LogicalName == Opportunity.EntityLogicalName)
                {
                    Opportunity OPP = ((Entity)context.InputParameters["Target"]).ToEntity<Opportunity>();
                }
                #endregion
            }
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                if (((Entity)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName)
                {
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    QuoteDetail nQuoteLine = ((Entity)context.InputParameters["Target"]).ToEntity<QuoteDetail>();
                    EntityReference parentQuoteRef = (EntityReference)nQuoteLine.QuoteId;
                    Quote parentQuote = service.Retrieve(Quote.EntityLogicalName, parentQuoteRef.Id, new ColumnSet("createdon", "opportunityid")).ToEntity<Quote>();
                    DateTime quoteCreatedOn = (DateTime)parentQuote.CreatedOn;
                    if(IsLatestQuote(service, tracingService, nQuoteLine) && quoteCreatedOn.AddMinutes(1) < DateTime.Now)
                    {
                        UpdateOpportunity(service, tracingService, parentQuote, nQuoteLine);
                    }
                }
            }
            #region Delete
            if(context.MessageName == "Delete" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference)
            {
                #region QuoteLine
                if(((EntityReference)context.InputParameters["Target"]).LogicalName == QuoteDetail.EntityLogicalName)
                {
                    QuoteDetail QD = context.PreEntityImages["PreDelete"].ToEntity<QuoteDetail>();
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    if (IsLatestQuote(service, tracingService, QD) && QD.Contains("azt_opportunityproductid"))
                    {
                        DeleteOpportunityProduct(service, tracingService, (Guid)QD.azt_OpportunityProductId.Id);
                    }
                }
                #endregion
            }

            #endregion
        }
        private void UpdateOpportunity(IOrganizationService service, ITracingService tracingService, Quote parentQuote, QuoteDetail nQuoteLine)
        {
            try
            {
                OpportunityProduct nOppLine = new OpportunityProduct()
                {
                    OpportunityId = parentQuote.OpportunityId,
                    Quantity = nQuoteLine.Quantity,
                    IsPriceOverridden = nQuoteLine.IsPriceOverridden,
                    PricePerUnit = nQuoteLine.PricePerUnit,
                    BaseAmount = nQuoteLine.BaseAmount,
                    ExtendedAmount = nQuoteLine.ExtendedAmount
                };
                if (nQuoteLine.Contains("uomid")) nOppLine.UoMId = nQuoteLine.UoMId;
                if (nQuoteLine.Contains("azt_licensetermmonths")) nOppLine.azt_LicenseTermMonths = nQuoteLine.azt_LicenseTermMonths;
                if (nQuoteLine.Contains("azt_licensetype")) nOppLine.azt_LicenseType = nQuoteLine.azt_LicenseType;
                if (nQuoteLine.Contains("tax")) nOppLine.Tax = nQuoteLine.Tax;
                if (nQuoteLine.Contains("productid"))
                {
                    nOppLine.ProductId = nQuoteLine.ProductId;
                }
                else
                {
                    nOppLine.ProductDescription = nQuoteLine.ProductDescription;
                }
                service.Create(nOppLine);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error updating the opportunityproduct in the UpdateOppFromQuote Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("rror updating the opportunityproduct in the UpdateOppFromQuote Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("rror updating the opportunityproduct in the UpdateOppFromQuote Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void DeleteOpportunityProduct(IOrganizationService service, ITracingService tracingService, Guid OppProdId)
        {
            try
            {
                service.Delete(OpportunityProduct.EntityLogicalName, OppProdId);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error deleting the opportunityproduct in the UpdateOppFromQuote Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("rror deleting the opportunityproduct in the UpdateOppFromQuote Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("rror deleting the opportunityproduct in the UpdateOppFromQuote Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private bool IsLatestQuote(IOrganizationService service, ITracingService tracingService, QuoteDetail QD)
        {
            bool isLatest = false;
            try
            {
                Guid quoteId = ((EntityReference)QD.QuoteId).Id;
                Quote QUO = service.Retrieve(Quote.EntityLogicalName, quoteId, new ColumnSet("opportunityid")).ToEntity<Quote>();
                Guid OppId = QUO.OpportunityId.Id;

                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false' count='1'>
  <entity name='quote'>
    <attribute name='quoteid' />
    <attribute name='modifiedon' />
    <order attribute='modifiedon' descending='true' />
    <filter type='and'>
      <condition attribute='opportunityid' operator='eq' uitype='opportunity' value='{0}' />
    </filter>
  </entity>
</fetch>
", OppId);
                #endregion
                EntityCollection retQuotes = service.RetrieveMultiple(new FetchExpression(_fetch));
                Guid mostRecentQuoteId = (Guid)retQuotes.Entities[0].Attributes["quoteid"];
                if (quoteId == mostRecentQuoteId) isLatest = true;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error getting if quote is the latest in the UpdateOppFromQuote Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error getting if quote is the latest in the UpdateOppFromQuote Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error getting if quote is the latest in the UpdateOppFromQuote Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return isLatest;
        }
    }
}
