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
    public class OrderStageTracking : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if(context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_orderstage.EntityLogicalName)
            {
                try
                {
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    azt_orderstage stage = ((Entity)context.InputParameters["Target"]).ToEntity<azt_orderstage>();
                    EntityReference orderRef = stage.azt_OrderId;
                    Entity orderProcess = GetOrderProcess(service, orderRef.Id);
                    int ageInBPF = orderProcess.GetAttributeValue<int>("bpf_duration");

                    EntityCollection audits = GetStageAuditRecords(service, orderRef.Id);
                    if (audits is null || audits.Entities.Count < 2) return;
                    azt_orderstage prevStage = ((Entity)audits.Entities[1]).ToEntity<azt_orderstage>();
                    tracingService.Trace("Order Id: " + prevStage.azt_orderstageId.ToString());
                    azt_orderstage uStage = new azt_orderstage()
                    {
                        azt_orderstageId = prevStage.azt_orderstageId,
                        azt_AgeEndedStage = ageInBPF,
                        azt_DateExitedStage = DateTime.Now.ToUniversalTime()
                    };
                    service.Update(uStage);
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
        }
        private Entity GetOrderProcess(IOrganizationService service, Guid id)
        {
            Entity e = new Entity();
            try
            {
                #region Query
                QueryExpression query = new QueryExpression()
                {
                    EntityName = "azt_orderfulfillment",
                    ColumnSet = new ColumnSet("businessprocessflowinstanceid", "bpf_duration"),
                    Criteria =
                    {
                        Filters =
                        {
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                                {
                                    new ConditionExpression("bpf_salesorderid", ConditionOperator.Equal, id)
                                }
                            }
                        }
                    }
                };
                #endregion
                EntityCollection ec = service.RetrieveMultiple(query);
                if (ec.Entities.Count != 1) throw new InvalidPluginExecutionException("Could not find Business Process Flow");
                e = ec.Entities[0];
                //int bpfDuration = process.GetAttributeValue<int>("bpf_duration");
                //Guid processId = (Guid)ec.Entities[0].Attributes["businessprocessflowinstanceid"];
                //er = new EntityReference("azt_orderfulfillment", processId);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting stage in the OrderStageTracking plugin: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw;
            }
            #endregion
            return e;
        }
        private EntityCollection GetStageAuditRecords(IOrganizationService service, Guid orderId)
        {
            EntityCollection ec = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false' top='2'>
  <entity name='azt_orderstage'>
    <attribute name='azt_orderstageid' />
    <attribute name='createdon' />
    <order attribute='createdon' descending='true' />
    <filter type='and'>
      <condition attribute='azt_orderid' operator='eq' uitype='salesorder' value='{0}' />
    </filter>
  </entity>
</fetch>
", orderId);
                #endregion
                ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region SyncronousErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
            return ec;
        }
    }
}
