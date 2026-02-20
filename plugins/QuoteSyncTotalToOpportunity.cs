using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
namespace AztecPlugins
{
    public class QuoteSyncTotalToOpportunity : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                try
                {
                    Quote q = ((Entity)context.InputParameters["Target"]).ToEntity<Quote>();
                    Quote postQuote = ((Entity)context.PostEntityImages["PostQuote"]).ToEntity<Quote>();
                    if (q.Attributes.Contains("totalamount") || q.Attributes.Contains("freightamount"))// && q.Attributes.Contains("opportunityid"))
                    {
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                        Guid oppId = postQuote.OpportunityId.Id;
                        Money totalAmt = q.GetAttributeValue<Money>("totalamount");
                        Money freightAmt = q.GetAttributeValue<Money>("freightamount");
                        //tracingService.Trace("Total Amount: " + totalAmt.ToString() + "Freight Amt: " + freightAmt.ToString());
                        //throw new Exception("ASDF");
                        SetOpportunityUserCalculated(service, tracingService, oppId);
                        SetOpportunityEstRevenue(service, tracingService, oppId, totalAmt, freightAmt);
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("An error occurred in the QuoteSyncTotalToOpportunity Plugin: {0}", ex.InnerException.ToString());
                }
                catch (Exception ex)
                {
                    tracingService.Trace("An error occurred in the QuoteSyncTotalToOpportunity Plugin: {0}", ex.InnerException.ToString());
                    throw;
                }
                #endregion ErrorHandling
            }
        }
        private void SetOpportunityEstRevenue(IOrganizationService service, ITracingService tracingService, Guid oppId, Money totalAmt, Money freightAmt)
        {
            try
            {
                Opportunity uo = new Opportunity()
                {
                    OpportunityId = oppId
                };
                if (totalAmt != null) uo.EstimatedValue = totalAmt;
                if(freightAmt != null) uo.FreightAmount = freightAmt;
                service.Update(uo);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred while setting the Estimated Revenue in the QuoteSyncTotalToOpportunity Plugin: {0}", ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred while setting the Estimated Revenue in the QuoteSyncTotalToOpportunity Plugin: {0}", ex.InnerException.ToString());
                throw;
            }
            #endregion ErrorHandling
        }
        private void SetOpportunityUserCalculated(IOrganizationService service, ITracingService tracingService, Guid oppId)
        {
            try
            {
                Opportunity uo = new Opportunity()
                {
                    OpportunityId = oppId,
                    IsRevenueSystemCalculated = false
                };
                service.Update(uo);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred setting the Opportunity to User Provided Revenue in the QuoteSyncTotalToOpportunity Plugin: {0}", ex.InnerException.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred setting the Opportunity to User Provided Revenue in the QuoteSyncTotalToOpportunity Plugin: {0}", ex.InnerException.ToString());
                throw;
            }
            #endregion ErrorHandling
        }
    }
}
