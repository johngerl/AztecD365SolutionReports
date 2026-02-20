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
    public class OpptyToQuoteFieldMappings : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Quote.EntityLogicalName)
            {
                try
                {
                    Entity createdQuote = (Entity)context.InputParameters["Target"];
                    if (!createdQuote.Attributes.Contains("opportunityid")) return;
                    Guid quoteId = (Guid)createdQuote.Attributes["quoteid"];
                    EntityReference oppRef = (EntityReference)createdQuote.Attributes["opportunityid"];
                    Guid oppId = oppRef.Id;

                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                    #region OPQuery
                    string OPFetch =
    string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='opportunityproduct'>
    <attribute name='opportunityproductid' />
    <attribute name='opportunityid' />
    <attribute name='productid' />
    <attribute name='productdescription' />
    <attribute name='quantity' />
    <attribute name='azt_licensetype' />
    <attribute name='azt_licensetermmonths' />
    <attribute name='manualdiscountamount' />
    <attribute name='extendedamount' />
    <filter type='and'>
      <condition attribute='opportunityid' operator='eq' uitype='opportunity' value='{0}' />
    </filter>
  </entity>
</fetch>
", oppId);
                    #endregion
                    EntityCollection retOP = service.RetrieveMultiple(new FetchExpression(OPFetch));
                    if (retOP.Entities.Count == 0) return;
                    List<Guid> QPIDs = new List<Guid>(); //If the QuoteDetailId has already been mapped to an Opportunity Product - skips
                    #region UpdateQuoteProducts
                    //List<string> products = new List<string>(); //Do not know what this is for
                    foreach (Entity OP in retOP.Entities)
                    {
                        Guid OPId = (Guid)OP.Attributes["opportunityproductid"];
                        Money OPExtAmt = (Money)OP.Attributes["extendedamount"];
                        decimal OPQty = OP.GetAttributeValue<decimal>("quantity");
                        OptionSetValue opLicType = OP.GetAttributeValue<OptionSetValue>("azt_licensetype");
                        int opLicTerm = OP.GetAttributeValue<int>("azt_licensetermmonths");
                        string writeInProduct = OP.GetAttributeValue<string>("productdescription");
                        Money discretionaryDiscount = OP.Attributes.Contains("manualdiscountamount") ? (Money)OP.Attributes["manualdiscountamount"] : new Money(0);

                        #region NewLogic
                        EntityCollection retQD = getQuoteProducts2(tracingService, service, quoteId);
                        #region ExistingProduct
                        if (OP.Contains("productid"))
                        {
                            EntityReference OPProdRef = OP.GetAttributeValue<EntityReference>("productid");
                            foreach (var qd in retQD.Entities)
                            {
                                Guid qdId = qd.GetAttributeValue<Guid>("quotedetailid");
                                string quoteName = ((EntityReference)qd.GetAttributeValue<EntityReference>("quoteid")).Name;
                                if (QPIDs.Contains(qdId)) continue;
                                EntityReference qdProdRef = qd.GetAttributeValue<EntityReference>("productid");
                                if (qdProdRef == null || qdProdRef.Id == Guid.Empty) continue;
                                decimal qdQty = qd.GetAttributeValue<decimal>("quantity");
                                if(OPProdRef.Id == qdProdRef.Id && OPQty == qdQty)
                                {
                                    QPIDs.Add(qdId);
                                    QuoteDetail uQD = new QuoteDetail()
                                    {
                                        QuoteDetailId = qdId,
                                        azt_OpportunityProductId = new EntityReference(OpportunityProduct.EntityLogicalName, OPId)
                                    };
                                    if (opLicType != null) uQD.azt_LicenseType = opLicType;
                                    if (opLicTerm != 0) uQD.azt_LicenseTermMonths = opLicTerm;
                                    try
                                    {
                                        EntityCollection retDiscounts = Utility.getOpportunityDiscounts(service, OPId, tracingService); tracingService.Trace("Number of Quote Discounts: " + retDiscounts.Entities.Count);
                                        if (retDiscounts.Entities.Count > 0)
                                        {
                                            foreach (Entity D in retDiscounts.Entities)
                                            {
                                                Guid discountId = (Guid)D.Attributes["azt_productdiscountid"];
                                                azt_productdiscount uDiscount = new azt_productdiscount()
                                                {
                                                    azt_productdiscountId = discountId,
                                                    azt_QuoteProductId = new EntityReference(SalesOrderDetail.EntityLogicalName, qdId)
                                                };
                                                service.Update(uDiscount);
                                            }
                                            tracingService.Trace("Quote Number: " + quoteName);
                                        }
                                        service.Update(uQD);
                                    }
                                    #region ErrorHandling
                                    catch (FaultException<OrganizationServiceFault> ex)
                                    {
                                        tracingService.Trace("Error setting OppProdRef from Oppty in the OpptyToQuoteFieldMappings Plugin: {0}", ex.Detail.ToString());
                                        throw new InvalidPluginExecutionException("Error setting OppProdRef from Oppty in the OpptyToQuoteFieldMappings Plugin", ex);
                                    }
                                    catch (Exception ex)
                                    {
                                        tracingService.Trace("Error setting OppProdRef from Oppty in the OpptyToQuoteFieldMappings Plugin: {0}", ex.ToString());
                                        throw;
                                    }
                                    #endregion
                                }
                            }
                        }
                        #endregion
                        #region WriteInProduct
                        else
                        {
                            foreach (var qd in retQD.Entities)
                            {
                                Guid qdId = qd.GetAttributeValue<Guid>("quotedetailid");
                                string quoteNum = ((EntityReference)qd.GetAttributeValue<EntityReference>("quoteid")).Name;
                                if (QPIDs.Contains(qdId)) continue;
                                string qdWriteIn = qd.GetAttributeValue<string>("productdescription");
                                decimal qdQty = qd.GetAttributeValue<decimal>("quantity");
                                if(writeInProduct == qdWriteIn && OPQty == qdQty)
                                {
                                    QPIDs.Add(qdId);
                                    QuoteDetail uQD = new QuoteDetail()
                                    {
                                        QuoteDetailId = qdId,
                                        azt_OpportunityProductId = new EntityReference(OpportunityProduct.EntityLogicalName, OPId)
                                    };
                                    if (opLicType != null) uQD.azt_LicenseType = opLicType;
                                    if (opLicTerm != 0) uQD.azt_LicenseTermMonths = opLicTerm;
                                    try
                                    {
                                        tracingService.Trace("Quote Number: " + quoteNum);
                                        service.Update(uQD);
                                    }
                                    #region ErrorHandling
                                    catch (FaultException<OrganizationServiceFault> ex)
                                    {
                                        tracingService.Trace("Error setting OppProdRef from Oppty in the OpptyToQuoteFieldMappings Plugin: {0}", ex.Detail.ToString());
                                        throw new InvalidPluginExecutionException("Error setting OppProdRef from Oppty in the OpptyToQuoteFieldMappings Plugin", ex);
                                    }
                                    catch (Exception ex)
                                    {
                                        tracingService.Trace("Error setting OppProdRef from Oppty in the OpptyToQuoteFieldMappings Plugin: {0}", ex.ToString());
                                        throw;
                                    }
                                    #endregion
                                }
                            }
                        }
                        #endregion
                        #endregion
                        #region Old
                        /*
                        if (OP.Attributes.Contains("azt_licensetype") && OP.Attributes.Contains("productid"))
                        {
                            #region OPLicType
                            OptionSetValue licenseType = (OptionSetValue)OP.Attributes["azt_licensetype"];
                            int licenseTerm = OP.GetAttributeValue<int>("azt_licensetermmonths");
                            Guid OP_ProductId = ((EntityReference)OP.Attributes["productid"]).Id;
                            #endregion
                            EntityCollection retQPs = getQuoteProducts(service, OP_ProductId, quoteId, OPExtAmt, tracingService);

                            if (retQPs.Entities.Count > 0)
                            {
                                Guid QPId = (Guid)retQPs.Entities[0].Attributes["quotedetailid"];
                                QuoteDetail uQP = new QuoteDetail()
                                {
                                    QuoteDetailId = QPId,
                                    azt_LicenseType = licenseType,
                                    azt_OpportunityProductId = new EntityReference(OpportunityProduct.EntityLogicalName, OPId)//,
                                    //azt_DiscretionaryDiscountAmt = discretionaryDiscount
                                };
                                if (licenseTerm > 0) uQP.azt_LicenseTermMonths = licenseTerm;
                                service.Update(uQP);
                                tracingService.Trace("OPId: " + OPId.ToString() + " QPId: " + QPId.ToString() + " oppId: " + oppId.ToString());
                                TrackDiscount(service, OPId, QPId, oppId, tracingService);
                            }
                            else return;
                            #region Old
                            //foreach (Entity QP in retQP.Entities)
                            //{
                            //    #region QPFields

                            //    //products = new List<string>();
                            //    Guid QPId = (Guid)QP.Attributes["quotedetailid"];
                            //    Guid QP_ProductId = ((EntityReference)QP.Attributes["productid"]).Id;
                            //    Money QPExtAmt = (Money)QP.Attributes["extendedamount"];
                            //    #endregion
                            //    if (QP_ProductId == OP_ProductId && QPExtAmt.Value == OPExtAmt.Value)
                            //    {
                            //        stringToCheck = OPId.ToString() + licenseType.Value.ToString();
                            //        bool exists = getExists(stringToCheck, products);
                            //        if (exists) continue;
                            //        products.Add(stringToCheck);

                            //        QuoteDetail uQD = new QuoteDetail()
                            //        {
                            //            QuoteDetailId = QPId,
                            //            azt_LicenseType = licenseType,
                            //            azt_LicenseTermMonths = licenseTerm
                            //        };
                            //        service.Update(uQD);
                            //        TrackDiscount(service, OPId, QPId, tracingService);
                            //    }
                            //}
                            #endregion
                        }
                        */
                        #endregion
                        #endregion
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error mapping fields from Oppty in the OpptyToQuoteFieldMappings Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error mapping fields from Oppty in the OpptyToQuoteFieldMappings Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error mapping fields from Oppty in the OpptyToQuoteFieldMappings Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private EntityCollection getQuoteProducts2(ITracingService tracingService, IOrganizationService service, Guid quoteId)
        {
            EntityCollection retQP = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quotedetail'>
    <attribute name='productid' />
    <attribute name='productdescription' />
    <attribute name='quantity' />
    <attribute name='quotedetailid' />
    <attribute name='quoteid' />
    <order attribute='createdon' descending='false' />
    <filter type='and'>
      <condition attribute='quoteid' operator='eq' uitype='quote' value='{0}' />
    </filter>
  </entity>
</fetch>
", quoteId);
                #endregion
                retQP = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error retrieving Quote Products in the OpptyToQuoteFieldMappings Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error retrieving Quote Products in the OpptyToQuoteFieldMappings Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error retrieving Quote Products in the OpptyToQuoteFieldMappings Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retQP;
        }
        private EntityCollection getQuoteProducts(IOrganizationService service, Guid oP_ProductId, Guid quoteId, Money OPExtAmt, ITracingService tracingService)
        {
            EntityCollection retQP = new EntityCollection();
            try
            {
                #region QPQuery
                string QPFetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='quotedetail'>
    <attribute name='quotedetailid' />
    <attribute name='productid' />
    <attribute name='extendedamount' />
    <filter type='and'>
      <condition attribute='quoteid' operator='eq' uitype='quote' value='{0}' />
      <condition attribute='productid' operator='eq' uitype='product' value='{1}' />
      <condition attribute='extendedamount' operator='eq' value='{2}' />
      <condition attribute='azt_licensetype' operator='null' />
    </filter>
  </entity>
</fetch>
", quoteId, oP_ProductId, OPExtAmt.Value);
                #endregion
                retQP = service.RetrieveMultiple(new FetchExpression(QPFetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error retrieving Quote Products in the OpptyToQuoteFieldMappings Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error retrieving Quote Products in the OpptyToQuoteFieldMappings Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error retrieving Quote Products in the OpptyToQuoteFieldMappings Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return retQP;
        }
        private bool getExists(string stringToCheck, List<string> products)
        {
            bool exists = false;
            foreach (var e in products)
            {
                if (stringToCheck == e) return true;
            }
            return exists;
        }
        private static void TrackDiscount(IOrganizationService service, Guid oPProductId, Guid QPId, Guid oppId, ITracingService tracingService)
        {
            try
            {
                #region GetDiscounts
                string _productDiscountFetch =
    string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_productdiscount'>
    <attribute name='azt_productdiscountid' />
    <attribute name='azt_approvalstatus' />
    <order attribute='azt_name' descending='false' />
    <filter type='and'>
      <condition attribute='azt_opportunityproductid' operator='eq' uitype='opportunityproduct' value='{0}' />
      <condition attribute='azt_opportunityid' operator='eq' uitype='opportunity' value='{1}' />
    </filter>
  </entity>
</fetch>
", oPProductId, oppId);
                #endregion

                //Approved=276530001
                EntityCollection retDiscounts = service.RetrieveMultiple(new FetchExpression(_productDiscountFetch));
                if (retDiscounts.Entities.Count == 0) return;
                foreach (Entity d in retDiscounts.Entities)
                {
                    OptionSetValue approvedStatus = (OptionSetValue)d.Attributes["azt_approvalstatus"];
                    if (approvedStatus.Value != 276530001) throw new Exception("Not all Discounts have been Approved!");
                    Guid discountId = (Guid)d.Attributes["azt_productdiscountid"];
                    azt_productdiscount uDiscount = new azt_productdiscount()
                    {
                        azt_productdiscountId = discountId,
                        azt_QuoteProductId = new EntityReference(QuoteDetail.EntityLogicalName, QPId)
                    };
                    service.Update(uDiscount);
                }
            }
            #region ErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
        }
    }
}
