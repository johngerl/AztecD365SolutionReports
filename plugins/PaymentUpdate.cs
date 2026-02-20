using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;

namespace AztecPlugins
{
    public class PaymentUpdate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region TracingContext
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_payment.EntityLogicalName)
            {
                try
                {
                    azt_payment pmt = ((Entity)context.InputParameters["Target"]).ToEntity<azt_payment>();
                    Guid paymentId = (Guid)pmt.azt_paymentId;
                    azt_payment postPmt = ((Entity)context.PostEntityImages["PostPayment"]).ToEntity<azt_payment>();
                    EntityReference invoiceRef = postPmt.azt_InvoiceId;
                    if (!postPmt.Attributes.Contains("azt_amount") || !pmt.Contains("statuscode")) return;
                    if (pmt.statuscode.Value != 2) return; //Returns if Not Paid
                    if (!postPmt.Attributes.Contains("azt_paymentdate")) throw new InvalidPluginExecutionException("Must have Payment Date to Pay!!!");
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    Money invTotalAmt = GetInvoiceTotal(service, tracingService, invoiceRef.Id);
                    decimal paidAmt = Utility.GetPaidPayments(invoiceRef.Id, service);
                    decimal pmtAmt = postPmt.azt_Amount.Value;
                    Utility.SetPaidPercentage(service, paidAmt, pmtAmt, invoiceRef.Id, invTotalAmt);
                    Invoice inv = service.Retrieve(Invoice.EntityLogicalName, invoiceRef.Id, new ColumnSet("azt_compcompleted")).ToEntity<Invoice>();
                    bool compCompleted = inv.GetAttributeValue<bool>("azt_compcompleted");
                    if (compCompleted && paidAmt + pmtAmt >= invTotalAmt.Value)
                    {
                        SetStateRequest req = new SetStateRequest()
                        {
                            State = new OptionSetValue(2),
                            Status = new OptionSetValue(100001),
                            EntityMoniker = new EntityReference(Invoice.EntityLogicalName, invoiceRef.Id)
                        };
                        SetStateResponse resp = (SetStateResponse)service.Execute(req);
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in the PaymentUpdate plug-in.", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("PaymentUpdate: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private Money GetInvoiceTotal(IOrganizationService service, ITracingService tracingService, Guid id)
        {
            Money ret = new Money();
            try
            {
                Invoice inv = service.Retrieve(Invoice.EntityLogicalName, id, new ColumnSet("totalamount")).ToEntity<Invoice>();
                ret = inv.TotalAmount;
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting invoice total in the PaymentUpdate plug-in.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("PaymentUpdate error getting invoice total: {0}", ex.ToString());
                throw;
            }
            #endregion
            return ret;
        }
    }
}
