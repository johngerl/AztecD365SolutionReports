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
using System.Runtime.Remoting.Contexts;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
namespace AztecPlugins
{
    public class RestrictProductLookups : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context|Tracing|Service
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            SystemUser initiatingUser = service.Retrieve(SystemUser.EntityLogicalName, context.InitiatingUserId, new ColumnSet("businessunitid", "azt_jobrole")).ToEntity<SystemUser>();
            if (initiatingUser.azt_JobRole != null && initiatingUser.GetAttributeValue<OptionSetValue>("azt_jobrole") != null)
            {
                EntityReference buRef = initiatingUser.GetAttributeValue<EntityReference>("businessunitid");
                int jobRole = initiatingUser.azt_JobRole.Value;
                if (/* Utility.UserHasRole(service, context.InitiatingUserId, buRef.Id, "System Administrator", tracingService) && */ jobRole == 327630000 && context.MessageName == "RetrieveMultiple" && context.InputParameters["Query"] is FetchExpression)
                {
                    string fetchXml = ((FetchExpression)context.InputParameters["Query"]).Query;
                    FetchXmlToQueryExpressionRequest conversionRequest = new FetchXmlToQueryExpressionRequest
                    {
                        FetchXml = fetchXml
                    };
                    FetchXmlToQueryExpressionResponse conversionResponse = (FetchXmlToQueryExpressionResponse)service.Execute(conversionRequest);
                    QueryExpression queryExpression = conversionResponse.Query;
                    if (queryExpression.EntityName == "product")
                    {
                        int[] products = { 20010, 20018 };
                        FilterExpression filter = new FilterExpression();
                        filter.AddCondition("productnumber", ConditionOperator.NotIn, products);
                        queryExpression.Criteria.AddFilter(filter);
                    }
                }
            }
        }
    }
}
