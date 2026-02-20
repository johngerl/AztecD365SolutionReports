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
    public class AddressCreate : IPlugin
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
                //if (context.Depth > 0) return;
                //EntityReference parentRef = new EntityReference(Account.EntityLogicalName, new Guid((string)context.InputParameters["AccountId"]));
                //string line1 = (string)context.InputParameters["Line1"];
                //string line2 = context.InputParameters.Contains("Line2") ? (string)context.InputParameters["Line2"] : string.Empty;
                //string city = context.InputParameters.Contains("City") ? (string)context.InputParameters["City"] : string.Empty;
                //string addState = context.InputParameters.Contains("State") ? (string)context.InputParameters["State"] : string.Empty;
                //string zip = context.InputParameters.Contains("Zip") ? (string)context.InputParameters["Zip"] : string.Empty;
                //string country = context.InputParameters.Contains("Country") ? (string)context.InputParameters["Country"] : string.Empty;

                //string addressId = string.Empty;

                //CustomerAddress a = new CustomerAddress()
                //{
                //    ParentId = parentRef,
                //    Line1 = line1,
                //    Line2 = line2,
                //    City = city,
                //    StateOrProvince = addState,
                //    PostalCode = zip,
                //    Country = country
                //};
                //Guid nAddress = service.Create(a);
                //context.OutputParameters["AddressId"] = nAddress.ToString();
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the AddressCreate function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the AddressCreate function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the AddressCreate function: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
