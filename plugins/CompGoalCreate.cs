using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using System.ServiceModel;
using Microsoft.Xrm.Sdk.Query;
using CrmContext;
namespace AztecPlugins
{
    public class CompGoalCreate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context/Tracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_compgoaltype.EntityLogicalName)
            {
                azt_compgoaltype compGoal = ((Entity)context.InputParameters["Target"]).ToEntity<azt_compgoaltype>();
                if (compGoal.Attributes.Contains("azt_invoiceid"))
                {
                    EntityReference invoiceRef = compGoal.azt_InvoiceId;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Invoice invoice = service.Retrieve(Invoice.EntityLogicalName, invoiceRef.Id, new ColumnSet("salesorderid","invoicenumber")).ToEntity<Invoice>();
                    EntityReference orderRef = invoice.SalesOrderId;
                    compGoal.azt_name = (string)invoice.InvoiceNumber;
                    compGoal.azt_OrderId = orderRef;
                }
            }
        }
    }
}
