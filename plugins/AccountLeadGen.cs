using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using Microsoft.Xrm.Sdk.Query;
using System.ServiceModel;
using Microsoft.Xrm.Sdk.Messages;
namespace AztecPlugins
{
    public class AccountLeadGen : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_accountleadgeneration.EntityLogicalName)
            {
                try
                {
                    EntityCollection allAccountLines = new EntityCollection();
                    HashSet<Guid> acctsThatHave = new HashSet<Guid>();
                    HashSet<Guid> acctsToAssociate = new HashSet<Guid>();
                    azt_accountleadgeneration leadGen = ((Entity)context.InputParameters["Target"]).ToEntity<azt_accountleadgeneration>();
                    azt_accountleadgeneration postLeadGen = ((Entity)context.PostEntityImages["PostLeadGen"]).ToEntity<azt_accountleadgeneration>();
                    bool evaluate = leadGen.GetAttributeValue<bool>("azt_evaluate");
                    if (evaluate)
                    {
                        Guid leadGenId = leadGen.Id;
                        int numMonths = postLeadGen.GetAttributeValue<int>("azt_monthstofilteron");
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        #region Has Query
                        QueryExpression HasQuery = new QueryExpression()
                        {
                            EntityName = azt_azt_accountleadgeneration_product_has.EntityLogicalName,
                            ColumnSet = new ColumnSet(false),
                            Criteria =
                            {
                                Filters =
                                {
                                    new FilterExpression
                                    {
                                        FilterOperator = LogicalOperator.And,
                                        Conditions =
                                        {
                                            new ConditionExpression("azt_accountleadgenerationid", ConditionOperator.Equal, leadGenId)
                                        }
                                    }
                                }
                            },
                            LinkEntities =
                            {
                                new LinkEntity
                                {
                                    JoinOperator = JoinOperator.Inner,
                                    LinkFromAttributeName = "productid",
                                    LinkFromEntityName = azt_azt_accountleadgeneration_product_has.EntityLogicalName,
                                    LinkToAttributeName = "productid",
                                    LinkToEntityName = Product.EntityLogicalName,
                                    EntityAlias = "Prod",
                                    Columns = new ColumnSet("productid")
                                }
                            }
                        };
                        #endregion
                        #region Has Not Query
                        QueryExpression HasNotQuery = new QueryExpression()
                        {
                            EntityName = azt_azt_accountleadgeneration_product_not.EntityLogicalName,
                            ColumnSet = new ColumnSet(false),
                            Criteria =
                            {
                                Filters =
                                {
                                    new FilterExpression
                                    {
                                        FilterOperator = LogicalOperator.And,
                                        Conditions =
                                        {
                                            new ConditionExpression("azt_accountleadgenerationid", ConditionOperator.Equal, leadGenId)
                                        }
                                    }
                                }
                            },
                            LinkEntities =
                            {
                                new LinkEntity
                                {
                                    JoinOperator = JoinOperator.Inner,
                                    LinkFromAttributeName = "productid",
                                    LinkFromEntityName = azt_azt_accountleadgeneration_product_not.EntityLogicalName,
                                    LinkToAttributeName = "productid",
                                    LinkToEntityName = Product.EntityLogicalName,
                                    EntityAlias = "Prod",
                                    Columns = new ColumnSet("productid")
                                }
                            }
                        };
                        #endregion
                        #region Populate Has Product Array
                        EntityCollection hasProducts = service.RetrieveMultiple(HasQuery);
                        List<Guid> hasProductsList = new List<Guid>();
                        foreach (var p in hasProducts.Entities)
                        {
                            hasProductsList.Add((Guid)p.GetAttributeValue<AliasedValue>("Prod.productid").Value);
                        }
                        Guid[] hasProductsArray = new Guid[hasProductsList.Count];

                        int arrayNum = 0;
                        foreach (Guid pr in hasProductsList)
                        {
                            hasProductsArray[arrayNum] = pr;
                            arrayNum++;
                        }
                        #endregion
                        #region Populate Has Not Product Array
                        EntityCollection notHasProducts = service.RetrieveMultiple(HasNotQuery);
                        List<Guid> notHasProductsList = new List<Guid>();
                        foreach (var p in notHasProducts.Entities)
                        {
                            notHasProductsList.Add((Guid)p.GetAttributeValue<AliasedValue>("Prod.productid").Value);
                        }
                        Guid[] notHasProductsArray = new Guid[notHasProductsList.Count];
                        int notArrayNum = 0;
                        foreach (Guid pr in notHasProductsList)
                        {
                            notHasProductsArray[notArrayNum] = pr;
                            notArrayNum++;
                        }
                        #endregion
                        #region All Lines Query
                        QueryExpression AllLinesQuery = new QueryExpression()
                        {
                            EntityName = Account.EntityLogicalName,
                            ColumnSet = new ColumnSet(false),
                            Criteria =
                            {
                                Filters =
                                {
                                    new FilterExpression
                                    {
                                        FilterOperator = LogicalOperator.And,
                                        Conditions =
                                        {
                                            new ConditionExpression("statecode", ConditionOperator.Equal, 0)
                                        }
                                    }
                                }
                            },
                            Orders =
                            {
                                new OrderExpression
                                {
                                    AttributeName = "accountid",
                                    OrderType = OrderType.Ascending
                                },
                            },
                            LinkEntities =
                            {
                                new LinkEntity
                                {
                                    JoinOperator = JoinOperator.Inner,
                                    LinkFromAttributeName = "accountid",
                                    LinkFromEntityName = Account.EntityLogicalName,
                                    LinkToAttributeName = "customerid",
                                    LinkToEntityName = Invoice.EntityLogicalName,
                                    EntityAlias = "Inv",

                                    LinkEntities =
                                    {
                                        new LinkEntity
                                        {
                                            JoinOperator = JoinOperator.Inner,
                                            LinkFromAttributeName = "invoiceid",
                                            LinkFromEntityName = Invoice.EntityLogicalName,
                                            LinkToAttributeName = "invoiceid",
                                            LinkToEntityName = InvoiceDetail.EntityLogicalName,
                                            EntityAlias = "InvLine",
                                            Columns = new ColumnSet("productid"),
                                            LinkCriteria =
                                            {
                                                Filters =
                                                {
                                                    new FilterExpression
                                                    {
                                                        FilterOperator = LogicalOperator.And,
                                                        Conditions =
                                                        {
                                                            new ConditionExpression("createdon",ConditionOperator.LastXMonths, numMonths),
                                                            new ConditionExpression("productid",ConditionOperator.NotNull)
                                                            //new ConditionExpression("productid",ConditionOperator.NotIn, notHasProductsArray),
                                                            //new ConditionExpression("productid",ConditionOperator.In, hasProductsArray)
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        };
                        #endregion
                        #region Populate All Lines
                        PageGetRecords(service, AllLinesQuery, (recordList) =>
                        {
                            foreach (var i in recordList.Entities)
                            {
                                Guid acctId = i.GetAttributeValue<Guid>("accountid");
                                Guid productId = ((EntityReference)i.GetAttributeValue<AliasedValue>("InvLine.productid").Value).Id;
                                Entity entity = new Entity();
                                entity["accountid"] = acctId;
                                entity["productid"] = productId;
                                allAccountLines.Entities.Add(entity);
                            }
                        });
                        #endregion
                        #region Populate Has Products List
                        foreach (var hasProdId in hasProductsArray)
                        {
                            foreach (var prod in allAccountLines.Entities)
                            {
                                if (prod.GetAttributeValue<Guid>("productid") == hasProdId)
                                    acctsThatHave.Add(prod.GetAttributeValue<Guid>("accountid"));
                            }
                        }
                        #endregion

                        foreach (Guid a in acctsThatHave)
                        {
                            bool acctHasProducts = false;
                            foreach (Guid notHaveProdId in notHasProductsArray)
                            {
                                foreach (var al in allAccountLines.Entities)
                                {
                                    Guid acctId = al.GetAttributeValue<Guid>("accountid");
                                    Guid prodId = al.GetAttributeValue<Guid>("productid");
                                    if (acctId == a && notHaveProdId == prodId)
                                        acctHasProducts = true;
                                }
                            }
                            if (!acctHasProducts)
                                acctsToAssociate.Add(a);
                        }

                        if (acctsToAssociate.Count == 5000)
                            throw new InvalidPluginExecutionException("Too many accounts.");
                        //new Guid("d3186a8b-ea6b-e211-b480-00155d0a440b")
                        EntityReferenceCollection relEntities = new EntityReferenceCollection();

                        #region Assemble Related Entities
                        foreach (var a in acctsToAssociate)
                        {
                            EntityReference acctRef = new EntityReference("account", a);
                            relEntities.Add(acctRef);
                        }
                        #endregion

                        AssociateRequest ass = new AssociateRequest()
                        {
                            Target = new EntityReference(azt_accountleadgeneration.EntityLogicalName, leadGenId),
                            Relationship = new Relationship(azt_azt_accountleadgeneration_account.EntityLogicalName),
                            RelatedEntities = relEntities
                        };
                        service.Execute(ass);
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("An error occurred in the AccountLeadGen function: {0}", ex.ToString());
                    tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                    throw new InvalidPluginExecutionException("An error occurred in the AccountLeadGen function." + ex.Detail.InnerFault.Message.ToString());
                }
                catch (Exception ex)
                {
                    tracingService.Trace("An error occurred in the AccountLeadGen function: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private static void PageGetRecords(IOrganizationService serviceProxyOnPrem, QueryExpression acctQuery, Action<EntityCollection> action)
        {
            int pageCount = 1;
            while (true)
            {
                var results = serviceProxyOnPrem.RetrieveMultiple(acctQuery);
                action(results);
                if (results.MoreRecords)
                {
                    pageCount++;
                    acctQuery.NoLock = true;
                    acctQuery.PageInfo = new PagingInfo();
                    acctQuery.PageInfo.Count = 5000;
                    acctQuery.PageInfo.PageNumber = pageCount;
                    acctQuery.PageInfo.PagingCookie = results.PagingCookie;
                }
                else
                    break;
            }
        }
    }
}
