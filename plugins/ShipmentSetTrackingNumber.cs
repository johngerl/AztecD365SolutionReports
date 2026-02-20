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
    public class ShipmentSetTrackingNumber : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if ((context.MessageName == "Create" || context.MessageName == "Update") && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_shipment.EntityLogicalName)
            {
                try
                {
                    azt_shipment shipment = ((Entity)context.InputParameters["Target"]).ToEntity<azt_shipment>();
                    if (!shipment.Contains("azt_trackingnumber")) return;
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    EntityReference orderRef = shipment.azt_OrderId;
                    string trackingNumber = shipment.azt_TrackingNumber;
                    SetTrackingNumber(orderRef, trackingNumber, service, tracingService);
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error in the ShipmentSetTrackingNumber Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error creating Software Licenses in the CreateSoftwareLicenses Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error in the ShipmentSetTrackingNumber Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private void SetTrackingNumber(EntityReference orderRef, string trackingNumber, IOrganizationService service, ITracingService tracingService)
        {
            try
            {
                string trackingNumbers = string.Empty;
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_shipment'>
    <attribute name='azt_trackingnumber' />
    <order attribute='createdon' descending='true' />
    <order attribute='azt_orderlineid' descending='false' />
    <filter type='and'>
      <condition attribute='azt_orderid' operator='eq' uitype='salesorder' value='{0}' />
      <condition attribute='azt_trackingnumber' operator='not-null' />
    </filter>
  </entity>
</fetch>
", orderRef.Id);
                #endregion
                EntityCollection retShipments = service.RetrieveMultiple(new FetchExpression(_fetch));
                int number = 1;
                foreach(Entity s in retShipments.Entities)
                {
                    string retTrackingNumbers = (string)s.Attributes["azt_trackingnumber"];
                    if (number == retShipments.Entities.Count)
                        trackingNumbers += retTrackingNumbers;
                    else trackingNumbers += retTrackingNumbers + ";";
                    number++;
                }
                if(trackingNumbers != string.Empty)
                {
                    SalesOrder uO = new SalesOrder()
                    {
                        SalesOrderId = orderRef.Id,
                        azt_TrackingNumbers = trackingNumbers
                    };
                    service.Update(uO);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error in the ShipmentSetTrackingNumber Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error creating Software Licenses in the CreateSoftwareLicenses Plugin: " + ex.Message);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error in the ShipmentSetTrackingNumber Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
