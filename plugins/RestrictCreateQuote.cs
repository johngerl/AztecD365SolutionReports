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
    public class RestrictCreateQuote : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Quote.EntityLogicalName)
            {
                try
                {
                    Quote quote = ((Entity)context.InputParameters["Target"]).ToEntity<Quote>();
                    if (quote.StateCode == QuoteState.Draft)
                    {
                        EntityReference oppRef = quote.OpportunityId;
                        string name = quote.Name.Substring(0, 4);
                        if (name == "Copy") return;
                        #region Query
                        string _fetch =
    string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quote'>
    <attribute name='quoteid' />
    <order attribute='name' descending='false' />
    <filter type='and'>
      <condition attribute='opportunityid' operator='eq' uiname='New Opportunity' uitype='opportunity' value='{0}' />
      <condition attribute='statecode' operator='in'>
        <value>1</value>
        <value>0</value>
        <value>2</value>
      </condition>
    </filter>
  </entity>
</fetch>
", oppRef.Id);
                        #endregion
                        EntityCollection retOpps = service.RetrieveMultiple(new FetchExpression(_fetch));
                        if (retOpps.Entities.Count > 1) throw new InvalidPluginExecutionException("There is already an existing quote for this opportunity and additional quotes are not allowed please revise the existing quote or close the existing quote as \"Canceled\"");
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the RestrictCreateQuote plugin." + ex.Detail.InnerFault.Message.ToString());
                }
                catch (Exception ex)
                {
                    tracingService.Trace("An error occurred in the RestrictCreateQuote plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
    }
}
