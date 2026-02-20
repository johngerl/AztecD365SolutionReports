using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using System.Xml.Linq;
namespace AztecPlugins
{
    public class ExpenseRestrictVisibility : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                #region Service
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                SystemUser user = service.Retrieve(SystemUser.EntityLogicalName, context.InitiatingUserId, new ColumnSet("businessunitid")).ToEntity<SystemUser>();
                bool isSysAdmin = Utility.UserHasRole(service, context.InitiatingUserId, user.BusinessUnitId.Id, "System Administrator", tracingService);
                bool isAccounting = Utility.UserHasRole(service, context.InitiatingUserId, user.BusinessUnitId.Id, "Aztec Accounting", tracingService);
                bool isCorpExpenseApprover = Utility.UserHasRole(service, context.InitiatingUserId, user.BusinessUnitId.Id, "Corporate Expense Approvers", tracingService);
                if (isSysAdmin || isAccounting || isCorpExpenseApprover) return;
                if (context.InputParameters.Contains("Query"))
                {
                    var thisQuery = context.InputParameters["Query"];
                    var fetchExpressionQuery = thisQuery as FetchExpression;
                    var queryExpressionQuery = thisQuery as QueryExpression;
                    var queryByAttributeQuery = thisQuery as QueryByAttribute;

                    if (fetchExpressionQuery != null)
                    {
                        tracingService.Trace("Found FetchExpression Query");

                        XDocument fetchXmlDoc = XDocument.Parse(fetchExpressionQuery.Query);
                        //The required entity element
                        var entityElement = fetchXmlDoc.Descendants("entity").FirstOrDefault();
                        var entityName = entityElement.Attributes("name").FirstOrDefault().Value;

                        //Only applying to the Expense Report entity
                        if (entityName == azt_expensereport.EntityLogicalName)
                        {
                            tracingService.Trace("Query on Expense Report entity confirmed");
                            #region Example
                            //Get all filter elements
                            //var filterElements = entityElement.Descendants("filter");

                            ////Find any existing statecode conditions
                            //var stateCodeConditions = from c in filterElements.Descendants("condition")
                            //                          where c.Attribute("attribute").Value.Equals("statecode")
                            //                          select c;

                            //if (stateCodeConditions.Count() > 0)
                            //{
                            //    tracingService.Trace("Removing existing statecode filter conditions.");
                            //}
                            ////Remove statecode conditions
                            //stateCodeConditions.ToList().ForEach(x => x.Remove());
                            #endregion
                            entityElement.Add(
                                new XElement("link-entity",
                                new XAttribute("name", "systemuser"),
                                new XAttribute("from", "systemuserid"),
                                new XAttribute("to", "owninguser"),
                                new XAttribute("link-type", "inner"),
                                new XAttribute("alias", "Owner"),
                                new XElement("link-entity",
                                new XAttribute("name", "team"),
                                new XAttribute("from", "teamid"),
                                new XAttribute("to", "azt_expenseteamid"),
                                new XAttribute("link-type", "inner"),
                                new XAttribute("alias", "ExpenseTeam"),
                                new XElement("link-entity",
                                new XAttribute("name", "teammembership"),
                                new XAttribute("from", "teamid"),
                                new XAttribute("to", "teamid"),
                                new XAttribute("link-type", "inner"),
                                new XAttribute("alias", "TeamMembership"),
                                new XElement("link-entity",
                                new XAttribute("name", "systemuser"),
                                new XAttribute("from", "systemuserid"),
                                new XAttribute("to", "systemuserid"),
                                new XAttribute("link-type", "inner"),
                                new XAttribute("alias", "TeamMember"),
                                new XElement("filter",
                                new XElement("condition",
                                new XAttribute("attribute", "systemuserid"),
                                new XAttribute("operator", "eq-userid")
                                ))))))
                                );
                            #region 2nd Example
                            ////Add the condition you want in a new filter
                            //entityElement.Add(
                            //    new XElement("filter",
                            //        new XElement("condition",
                            //            new XAttribute("attribute", "statecode"),
                            //            new XAttribute("operator", "neq"), //not equal
                            //            new XAttribute("value", "1") //Inactive
                            //            )
                            //        )
                            //    );
                            #endregion
                        }
                        fetchExpressionQuery.Query = fetchXmlDoc.ToString();
                    }
                    #region Other Types
                    //if (queryExpressionQuery != null)
                    //{
                    //    tracingService.Trace("Found Query Expression Query");
                    //    if (queryExpressionQuery.EntityName.Equals("account"))
                    //    {
                    //        //tracingService.Trace("Query on Account confirmed");

                    //        ////Recursively remove any conditions referring to the statecode attribute
                    //        //foreach (FilterExpression fe in queryExpressionQuery.Criteria.Filters)
                    //        //{
                    //        //    //Remove any existing criteria based on statecode attribute
                    //        //    RemoveAttributeConditions(fe, "statecode", tracingService);
                    //        //}

                    //        ////Define the filter
                    //        //var stateCodeFilter = new FilterExpression();
                    //        //stateCodeFilter.AddCondition("statecode", ConditionOperator.NotEqual, 1);
                    //        ////Add it to the Criteria
                    //        //queryExpressionQuery.Criteria.AddFilter(stateCodeFilter);
                    //    }

                    //}
                    //if (queryByAttributeQuery != null)
                    //{
                    //    tracingService.Trace("Found Query By Attribute Query");
                    //    //Query by attribute doesn't provide a complex query model that 
                    //    // can be manipulated
                    //}
                    #endregion
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred in the ExpenseRestrictVisibility Plugin." + ex.Detail.InnerFault.Message.ToString());
            }
            #endregion
        }
    }
}
