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
    public class CloneExpenseLine : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_clonedexpenseline.EntityLogicalName)
            {
                try
                {
                    Guid _clonedExpLineId = Guid.Empty;
                    Entity entity = (Entity)context.InputParameters["Target"];
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #region fields
                    string[] _fields =
    {
"azt_customerid",
"azt_mileage",
"azt_expenseamount",
"azt_reasonforexpense",
"azt_expensetype",
"azt_description",
"azt_expensereportid"
};
                    #endregion
                    Guid _clonedExpenseLineId = new Guid(((string)entity.Attributes["azt_name"]));
                    QueryByAttribute opptyQuery = new QueryByAttribute(azt_expense.EntityLogicalName);
                    opptyQuery.ColumnSet = new ColumnSet(_fields);
                    opptyQuery.Attributes.Add("azt_expenseid");
                    opptyQuery.Values.Add(_clonedExpenseLineId);
                    EntityCollection retrievedExpense = service.RetrieveMultiple(opptyQuery);
                    foreach (Entity e in retrievedExpense.Entities)
                    {
                        Entity newExpense = new Entity("azt_expense");
                        #region Mapping
                        if (e.Attributes.Contains("azt_customerid")) newExpense["azt_customerid"] = (EntityReference)e.Attributes["azt_customerid"];
                        if (e.Attributes.Contains("azt_mileage")) newExpense["azt_mileage"] = (int)e.Attributes["azt_mileage"];
                        if (e.Attributes.Contains("azt_expenseamount")) newExpense["azt_expenseamount"] = (Money)e.Attributes["azt_expenseamount"];
                        if (e.Attributes.Contains("transactioncurrencyid")) newExpense["transactioncurrencyid"] = (EntityReference)e.Attributes["transactioncurrencyid"];
                        if (e.Attributes.Contains("azt_reasonforexpense")) newExpense["azt_reasonforexpense"] = (OptionSetValue)e.Attributes["azt_reasonforexpense"];
                        if (e.Attributes.Contains("azt_expensetype")) newExpense["azt_expensetype"] = (OptionSetValue)e.Attributes["azt_expensetype"];
                        if (e.Attributes.Contains("azt_description")) newExpense["azt_description"] = (string)e.Attributes["azt_description"];
                        if (e.Attributes.Contains("azt_expensereportid")) newExpense["azt_expensereportid"] = (EntityReference)e.Attributes["azt_expensereportid"];
                        #endregion
                        _clonedExpLineId = service.Create(newExpense);
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error Cloning Expense Line in the CloneExpenseLine Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error Cloning Expense Line in the CloneExpenseLine Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error Cloning Expense Line in the CloneExpenseLine Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
    }
}
