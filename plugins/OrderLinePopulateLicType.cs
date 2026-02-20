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
    public class OrderLinePopulateLicType : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region TracingContext
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == SalesOrderDetail.EntityLogicalName)
            {
                SalesOrderDetail l = ((Entity)context.InputParameters["Target"]).ToEntity<SalesOrderDetail>();
                if (l.Contains("quotedetailid"))
                {
                    SalesOrderDetail u = new SalesOrderDetail()
                    {
                        SalesOrderDetailId = (Guid)l.SalesOrderDetailId
                    };
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Guid qdId = (Guid)l.QuoteDetailId.Id;
                    QuoteDetail ql = (service.Retrieve(QuoteDetail.EntityLogicalName, qdId, new ColumnSet("azt_licensetype"))).ToEntity<QuoteDetail>();
                    if (ql.Contains("azt_licensetype"))
                    {
                        OptionSetValue licType = ql.azt_LicenseType;
                        u.azt_LicenseType = licType;
                    }
                    if (ql.Contains("azt_licenseterm"))
                    {
                        int licTerm = (int)ql.azt_LicenseTermMonths;
                        u.azt_LicenseTermMonths = licTerm;
                    }
                    if (ql.Contains("azt_licenseterm") || ql.Contains("azt_licensetype"))
                    {
                        try
                        {
                            service.Update(u);
                        }
                        #region ErrorHandling
                        catch (FaultException<OrganizationServiceFault> ex)
                        {
                            tracingService.Trace("Error Setting License Type in the OrderLinePopulateLicType Plugin: {0}", ex.Detail.ToString());
                            throw new InvalidPluginExecutionException("Error Setting License Type in the OrderLinePopulateLicType Plugin", ex);
                        }
                        catch (Exception ex)
                        {
                            tracingService.Trace("Error Setting License Type in the OrderLinePopulateLicType Plugin: {0}", ex.ToString());
                            throw;
                        }
                        #endregion
                    }
                }
            }
        }
    }
}
