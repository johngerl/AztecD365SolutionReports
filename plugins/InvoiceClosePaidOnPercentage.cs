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
    public class InvoiceClosePaidOnPercentage : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                try
                {
                    if (((Entity)context.InputParameters["Target"]).LogicalName == azt_payment.EntityLogicalName)
                    {
                        azt_payment pmt = ((Entity)context.PreEntityImages["PrePayment"]).ToEntity<azt_payment>();
                        EntityReference invRef = pmt.azt_InvoiceId;
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        Invoice inv = GetInvTotal(service, tracingService, invRef.Id);
                        Money invTotalAmt = inv.TotalAmount;
                        bool compCompleted = (bool)inv.azt_CompCompleted;
                        if (!compCompleted) return;
                        var invStatecode = inv.StateCode.Value;
                        if (invStatecode != InvoiceState.Active)
                        {
                            throw new Exception("Payments can only be marked paid on Active Invoices.");
                        }
                        Guid pmtId = (Guid)pmt.azt_paymentId;
                        if (!pmt.Contains("azt_amount")) return;
                        decimal pmtAmt = pmt.Contains("azt_amount") ? (decimal)pmt.azt_Amount.Value : 0;
                        SetInvoicePaid(invRef.Id, service, invTotalAmt, pmtAmt);
                    }
                    else if(((Entity)context.InputParameters["Target"]).LogicalName == Invoice.EntityLogicalName)
                    {
                        Invoice inv = ((Entity)context.InputParameters["Target"]).ToEntity<Invoice>();
                        if (inv.Contains("azt_compcompleted"))
                        {
                            bool compCompleted = (bool)inv.azt_CompCompleted;
                            if (!compCompleted) return;
                            Guid invId = (Guid)inv.InvoiceId;
                            #region Service
                            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                            #endregion
                            Invoice retrievedInv = service.Retrieve(Invoice.EntityLogicalName, invId, new ColumnSet("totalamount")).ToEntity<Invoice>();
                            Money invTotal = retrievedInv.TotalAmount;
                            SetInvoicePaid(invId, service, invTotal, 0);
                        }
                    }
                }
                #region SyncronousErrorHandling
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
        }
        private void SetInvoicePaid(Guid invId, IOrganizationService service, Money invTotalAmt, decimal pmtAmt)
        {
            decimal paidAmt = Utility.GetPaidPayments(invId, service);
            if (paidAmt + pmtAmt >= invTotalAmt.Value)
            {
                Utility.SetPaidPercentage(service, paidAmt, pmtAmt, invId, invTotalAmt);
                SetStateRequest req = new SetStateRequest()
                {
                    State = new OptionSetValue(2),
                    Status = new OptionSetValue(100001),
                    EntityMoniker = new EntityReference(Invoice.EntityLogicalName, invId)
                };
                SetStateResponse resp = (SetStateResponse)service.Execute(req);
            }
        }
        private Invoice GetInvTotal(IOrganizationService service, ITracingService tracingService, Guid id)
        {
            Invoice ret;
            try
            {
                ret = service.Retrieve(Invoice.EntityLogicalName, id, new ColumnSet("totalamount","statecode", "azt_compcompleted")).ToEntity<Invoice>();
            }
            #region ErrorHandling
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
            return ret;
        }
    }
}
