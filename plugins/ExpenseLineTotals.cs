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
    public class ExpenseLineTotals : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName == "Create" || context.MessageName == "Update")
            {
                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == "azt_expense")
                {
                    try
                    {
                        Entity entity = (Entity)context.PostEntityImages["PostExpenseImage"];
                        if (entity.Attributes.Contains("azt_expensereportid"))
                        {
                            //Money _expenseAmount;
                            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                            #region Old
                            /*
                            if (!entity.Attributes.Contains("crm3_expenseamount"))
                            {
                                _expenseAmount = new Money(0);
                            }
                            else
                            {
                                _expenseAmount = (Money)entity.Attributes["crm3_expenseamount"];
                            }
                            */
                            #endregion
                            Guid _expenseReportId = ((EntityReference)entity.Attributes["azt_expensereportid"]).Id;
                            Money _totalledAmount = getTotalAmount(service, _expenseReportId, tracingService);
                            Entity ExpenseReport = new Entity("azt_expensereport");
                            ExpenseReport["azt_totalreimbursement"] = _totalledAmount;
                            ExpenseReport["azt_expensereportid"] = _expenseReportId;
                            try
                            {
                                service.Update(ExpenseReport);
                            }
                            catch (FaultException<OrganizationServiceFault> ex)
                            {
                                throw new InvalidPluginExecutionException("An error occurred totalling Expense line totals.", ex);
                            }
                            #region AppendContacts
                            /*
                            QueryExpression contacts = new QueryExpression()
                            {
                                EntityName = "contact",
                                ColumnSet = new ColumnSet("crm3_parentleadid"),
                                Criteria =
                                {
                                    Filters =
                                    {
                                        new FilterExpression
                                        {
                                            FilterOperator = LogicalOperator.And,
                                            Conditions =
                                            {
                                                new ConditionExpression("crm3_parentleadid",ConditionOperator.Equal,_leadId)
                                            },
                                        },
                                    }
                                }
                            };
                            EntityCollection leadContacts = service.RetrieveMultiple(contacts);
                            if (leadContacts.Entities.Count > 0)
                            {
                                foreach (Entity c in leadContacts.Entities)
                                {
                                    Contact newContact = new Contact()
                                    {
                                        ContactId = (Guid)c.Attributes["contactid"],
                                        ParentCustomerId = new EntityReference("account", _acctId)
                                    };
                                    service.Update(newContact);
                                }
                            }
                            */
                            #endregion AppendContacts
                        }
                    }
                    #region ErrorHandling
                    catch (FaultException<OrganizationServiceFault> ex)
                    {
                        tracingService.Trace("Error calculating Expense Amounts in the ExpenseLineTotals Plugin: {0}", ex.Detail.ToString());
                        throw new InvalidPluginExecutionException("Error calculating Expense Amounts in the ExpenseLineTotals Plugin", ex);
                    }
                    catch (Exception ex)
                    {
                        tracingService.Trace("Error calculating Expense Amounts in the ExpenseLineTotals Plugin: {0}", ex.ToString());
                        throw;
                    }
                    #endregion
                }
            }
        }
        private Money getTotalAmount(IOrganizationService service, Guid _expenseReportId, ITracingService tracingService)
        {
            Money _returnedTotalAmount = new Money(0);
            decimal _amount = new decimal(0.00);
            #region Query
            QueryExpression queryAllExpenses = new QueryExpression()
            {
                EntityName = azt_expense.EntityLogicalName,
                NoLock = true,
                ColumnSet = new ColumnSet("azt_expenseamount"),
                Criteria =
                {
                    Filters =
                                {
                                    new FilterExpression
                                    {
                                        FilterOperator = LogicalOperator.And,
                                        Conditions =
                                        {
                                            new ConditionExpression("azt_expensereportid",ConditionOperator.Equal,_expenseReportId)
                                        },
                                    },
                                }
                }
            };
            #endregion
            try
            {
                EntityCollection expenseLines = service.RetrieveMultiple(queryAllExpenses);
                if (expenseLines.Entities.Count > 0)
                {
                    foreach (Entity amounts in expenseLines.Entities)
                    {
                        Money _expenseAmount = new Money(0);
                        if (!amounts.Attributes.Contains("azt_expenseamount"))
                        {
                            _expenseAmount = new Money(0);
                        }
                        else
                        {
                            _expenseAmount = (Money)amounts.Attributes["azt_expenseamount"];
                        }
                        _amount += ((Money)_expenseAmount).Value;
                    }
                }
                _returnedTotalAmount = new Money(_amount);
                return _returnedTotalAmount;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occured totaling Expense Lines in the ExpenseLineTotals Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("An error occured totaling Expense Lines in the ExpenseLineTotals Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occured totaling Expense Lines in the ExpenseLineTotals Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
