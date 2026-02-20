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
    public class ActivateOrReviseQuote : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if(context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Quote.EntityLogicalName)
            {
                Quote quote = ((Entity)context.InputParameters["Target"]).ToEntity<Quote>();
                int revisionNumber = (int)quote.RevisionNumber;
                if(revisionNumber > 0)
                {
                    IPluginExecutionContext parentContext = context.ParentContext;
                    if(parentContext.InputParameters.Contains("QuoteId") && parentContext.InputParameters["QuoteId"] is Guid)
                    {
                        try
                        {
                            Guid revisedQuoteId = (Guid)parentContext.InputParameters["QuoteId"];
                            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                            SetRelatedProductDiscounts(service, tracingService, revisedQuoteId, (Guid)quote.QuoteId);
                        }
                        catch (Exception ex)
                        {
                            throw new InvalidPluginExecutionException(ex.Message);
                        }
                    }
                }
            }

        }
        private void SetRelatedProductDiscounts(IOrganizationService service, ITracingService tracingService, Guid revisedQuoteId, Guid quoteId)
        {
            try
            {
                #region Query
                QueryExpression Query = new QueryExpression()
                {
                    EntityName = QuoteDetail.EntityLogicalName,
                    ColumnSet = new ColumnSet(false),
                    Criteria =
                    {
                        Filters =
                        {
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                                {
                                    new ConditionExpression("quoteid", ConditionOperator.Equal, revisedQuoteId)
                                }
                            }
                        }
                    }
                };
                #endregion
                EntityCollection retQuoteLines = service.RetrieveMultiple(Query);
                foreach(Entity oldLine in retQuoteLines.Entities)
                {
                    Guid oldQuoteLineId = (Guid)oldLine.Attributes["quotedetailid"];
                    #region Query
                    QueryExpression DiscountQuery = new QueryExpression()
                    {
                        EntityName = azt_productdiscount.EntityLogicalName,
                        ColumnSet = new ColumnSet(false),
                        Criteria =
                        {
                            Filters =
                            {
                                new FilterExpression
                                {
                                    FilterOperator = LogicalOperator.And,
                                    Conditions =
                                    {
                                        new ConditionExpression("azt_quoteproductid", ConditionOperator.Equal, oldQuoteLineId)
                                    }
                                }
                            }
                        }
                    };
                    #endregion
                    EntityCollection retDiscounts = service.RetrieveMultiple(DiscountQuery);
                    foreach(Entity d in retDiscounts.Entities)
                    {

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
    }
}
