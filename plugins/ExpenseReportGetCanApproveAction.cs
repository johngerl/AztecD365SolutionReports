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
    public class ExpenseReportGetCanApproveAction : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                if (context.MessageName == "azt_ExpenseCanApprove")
                {
                    EntityReference userToApprove = (EntityReference)context.InputParameters["UserToApprove"];
                    EntityReference expenseUser = (EntityReference)context.InputParameters["ExpenseUser"];
                    EntityReference expenseReportRef = (EntityReference)context.InputParameters["Target"];
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    bool canApprove = Utility.GetCanApproveExpense(service, userToApprove, expenseUser);

                    context.OutputParameters["CanApprove"] = canApprove;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the ExpenseReportGetCanApproveAction Action." + ex.Detail.InnerFault.Message.ToString());
            }
            #endregion
        }
    }
}
