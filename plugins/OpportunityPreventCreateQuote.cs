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
    public class OpportunityPreventCreateQuote : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            try
            {
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Quote.EntityLogicalName)
                {
                    Quote quote = ((Entity)context.InputParameters["Target"]).ToEntity<Quote>();
                    if (!quote.Contains("opportunityid")) return;
                    EntityReference oppRef = quote.OpportunityId;
                    EntityCollection retOppProducts = GetOppProducts(service, tracingService, oppRef.Id);
                    if (retOppProducts.Entities.Count == 0) return;
                    foreach(Entity op in retOppProducts.Entities)
                    {
                        Guid oppProductId = (Guid)op.Attributes["opportunityproductid"];
                        if (GetHasUnapprovedDiscount(service, tracingService, oppProductId)) throw new InvalidPluginExecutionException("Quotes cannot be created when an unapproved Discount exists.");
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred with Line Discounts in the OpportunityPreventCreateQuote plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred with Line Discounts in the OpportunityPreventCreateQuote plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private bool GetHasUnapprovedDiscount(IOrganizationService service, ITracingService tracingService, Guid oppProductId)
        {
            bool hasUnapprovedDiscount = false;
            try
            {
                #region Query
                string _fetch =
        string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_productdiscount'>
    <attribute name='azt_approvalstatus' />
    <filter type='and'>
      <condition attribute='azt_opportunityproductid' operator='eq' value='{0}' />
    </filter>
  </entity>
</fetch>
", oppProductId);
                #endregion
                EntityCollection discounts = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (Entity d in discounts.Entities)
                {
                    OptionSetValue approvalStatus = (OptionSetValue)d.Attributes["azt_approvalstatus"];
                    if (approvalStatus.Value != 276530001) hasUnapprovedDiscount = true;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the GetHasUnapprovedDiscount method in the OpportunityPreventCreateQuote plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the GetHasUnapprovedDiscount method in the OpportunityPreventCreateQuote plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return hasUnapprovedDiscount;
        }
        private EntityCollection GetOppProducts(IOrganizationService service, ITracingService tracingService, Guid oppId)
        {
            EntityCollection oppProducts = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='opportunityproduct'>
    <attribute name='opportunityproductid' />
    <filter type='and'>
      <condition attribute='opportunityid' operator='eq' uitype='opportunity' value='{0}' />
    </filter>
  </entity>
</fetch>
", oppId);
                #endregion
                oppProducts = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred obtaining Opportunity Products in the OpportunityPreventCreateQuote plug-in.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred obtaining Opportunity Products in the OpportunityPreventCreateQuote plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return oppProducts;
        }
    }
}
