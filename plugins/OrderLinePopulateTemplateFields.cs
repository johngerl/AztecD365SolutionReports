using CrmContext;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
namespace AztecPlugins
{
    public class OrderLinePopulateTemplateFields : IPlugin
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
                if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == SalesOrderDetail.EntityLogicalName)
                {
                    SalesOrderDetail orderLine = ((Entity)context.InputParameters["Target"]).ToEntity<SalesOrderDetail>();
                    EntityReference orderRef = orderLine.SalesOrderId;
                    string lineField = GetLineNames(service, tracingService, orderRef.Id);
                    SalesOrder o = new SalesOrder()
                    {
                        SalesOrderId = orderRef.Id,
                        azt_OrderTemplateLines = lineField,
                    };
                    service.Update(o);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the OrderLinePopulateTemplateFields plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the OrderLinePopulateTemplateFields plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private string GetLineNames(IOrganizationService service, ITracingService tracingService, Guid id)
        {
            string myString = string.Empty;
            try
            {
                #region Query
                string _fetch =
string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='salesorderdetail'>
    <attribute name='salesorderdetailname' />
    <attribute name='quantity' />
    <order attribute='productid' descending='false' />
    <filter type='and'>
      <condition attribute='salesorderid' operator='eq' uitype='salesorder' value='{0}' />
    </filter>
  </entity>
</fetch>", id);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (var i in ec.Entities)
                {
                    string qty = i.GetAttributeValue<decimal>("quantity").ToString("0.############################");
                    myString += qty + " concurrent licenses of " + i.GetAttributeValue<string>("salesorderdetailname") + "\n";
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the OrderLinePopulateTemplateFields plug-in.", ex);
            }

            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the OrderLinePopulateTemplateFields plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return myString;
        }
    }
}
