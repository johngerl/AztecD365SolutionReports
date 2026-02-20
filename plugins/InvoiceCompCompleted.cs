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
    public class InvoiceCompCompleted : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Tracing|Context
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Invoice.EntityLogicalName)
                {
                    Invoice invoice = ((Entity)context.InputParameters["Target"]).ToEntity<Invoice>();
                    if (invoice.Attributes.Contains("azt_compcompleted") && invoice.azt_CompCompleted.Value)
                    {
                        Guid invoiceId = (Guid)invoice.InvoiceId;
                        #region Query
                        string _fetch =
    string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
	<entity name='azt_compgoaltype'>
		<attribute name='azt_compgoaltypeid' />
		<attribute name='azt_percentage' />
        <attribute name='azt_invoiceid' />
        <attribute name='azt_effectivedate' />
        <attribute name='azt_total' />
        <attribute name='azt_amount' />
        <attribute name='azt_salesrepid' />
		<order attribute='azt_salesrepid' descending='false' />
		<order attribute='azt_producttype' descending='false' />
		<filter type='and'>
			<condition attribute='azt_invoiceid' operator='eq' uitype='invoice' value='{0}' />
		</filter>
	</entity>
</fetch>
", invoiceId);
                        #endregion
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        EntityCollection compGoals = service.RetrieveMultiple(new FetchExpression(_fetch));
                        foreach (var c in compGoals.Entities)
                        {
                            Guid compGoalId = (Guid)c.Id;
                            EntityReference invoiceRef = c.GetAttributeValue<EntityReference>("azt_invoiceid");
                            DateTime effectiveDate = c.GetAttributeValue<DateTime>("azt_effectivedate");
                            tracingService.Trace("Payment Date: " + effectiveDate.ToString() + " Invoice: " + invoiceRef.Id.ToString());
                            Money total = c.GetAttributeValue<Money>("azt_total");
                            Money amount = c.GetAttributeValue<Money>("azt_amount");
                            decimal percentage = c.GetAttributeValue<decimal>("azt_percentage");
                            EntityReference salesRepRef = c.GetAttributeValue<EntityReference>("azt_salesrepid");
                            tracingService.Trace("Comp Plan Id: " + compGoalId.ToString() + " Commission Total: " + total.Value.ToString() + " Percentage: " + percentage.ToString() + " SalesRepId: " + salesRepRef.Id.ToString());
                            Guid commRecordId = Utility.getCommissionRecord(service, tracingService, salesRepRef, new DateTime(effectiveDate.Year, 12, 31));

                            if (percentage > 0)
                            {
                                azt_compgoaltype g = new azt_compgoaltype()
                                {
                                    azt_compgoaltypeId = c.Id,
                                    azt_CommissionId = new EntityReference(azt_commission.EntityLogicalName, commRecordId),
                                    statecode = azt_compgoaltypeState.Inactive,
                                    statuscode = new OptionSetValue(2)
                                };
                                service.Update(g);
                            }

                            
                            DateTime commPeriodStartDate = GetCommisionPeriodStart(effectiveDate);
                            DateTime commPeriodEndDate = GetCommissionPeriodEnd(effectiveDate);
                            SetCommissionPayment(service, tracingService, salesRepRef, invoiceRef, compGoalId, total, commRecordId, commPeriodStartDate, commPeriodEndDate);
                        }
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error in the InvoiceCompCompleted Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error in the InvoiceCompCompleted Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error in the InvoiceCompCompleted Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private static void SetCommissionPayment(IOrganizationService service, ITracingService tracingService, EntityReference ownerRef, EntityReference invoiceRef,
            Guid compGoalId, Money adjustedTotalPaid, Guid commRecordId, DateTime commPeriodStartDate, DateTime commPeriodEndDate)
        {
            try
            {
                #region CommissionPaymentQuery
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_commissionpayment'>
    <attribute name='azt_commissionpaymentid' />
    <filter type='and'>
      <condition attribute='ownerid' operator='eq' uiname='Michael Mayo' uitype='systemuser' value='{0}' />
      <condition attribute='azt_periodstart' operator='on' value='{1}' />
      <condition attribute='azt_periodend' operator='on' value='{2}' />
      <condition attribute='azt_compgoalid' operator='eq' uitype='azt_compgoaltype' value='{3}' />
    </filter>
  </entity>
</fetch>
", ownerRef.Id, commPeriodStartDate, commPeriodEndDate, compGoalId);
                #endregion
                EntityCollection retCommPayments = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retCommPayments.Entities.Count == 0)
                {
                    commPeriodStartDate = new DateTime(commPeriodStartDate.Year, commPeriodStartDate.Month, commPeriodStartDate.Day, 0, 0, 0);
                    commPeriodEndDate = new DateTime(commPeriodEndDate.Year, commPeriodEndDate.Month, commPeriodEndDate.Day, 0, 0, 0);

                    azt_commissionpayment comm = new azt_commissionpayment()
                    {
                        azt_InvoiceId = invoiceRef,
                        azt_CompGoalId = new EntityReference(azt_compgoaltype.EntityLogicalName, compGoalId),
                        azt_CommissionAmount = adjustedTotalPaid,
                        azt_CommissionId = new EntityReference(azt_commission.EntityLogicalName, commRecordId),
                        azt_PeriodStart = commPeriodStartDate,
                        azt_PeriodEnd = commPeriodEndDate,
                        //azt_PeriodStart = commPeriodStartDate.Date.ToUniversalTime(),
                        //azt_PeriodEnd = commPeriodEndDate.Date.AddDays(1).AddTicks(-1).ToUniversalTime(),
                        OwnerId = ownerRef,
                        azt_name = ownerRef.Name + " " + invoiceRef.Name + " " + commPeriodStartDate.ToShortDateString() + "-" + commPeriodEndDate.ToShortDateString() + " Commission Payment"
                    };
                    service.Create(comm);
                }
                else if (retCommPayments.Entities.Count > 1) throw new InvalidPluginExecutionException("There is more than one Commission payment for the given period for this user.");
                else
                {
                    foreach (Entity c in retCommPayments.Entities)
                    {
                        Guid commPaymentId = (Guid)c.Attributes["azt_commissionpaymentid"];
                        azt_commissionpayment uComm = new azt_commissionpayment()
                        {
                            azt_commissionpaymentId = commPaymentId,
                            azt_CommissionAmount = adjustedTotalPaid
                        };
                        service.Update(uComm);
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred Creating Commission Payment in the PaymentSetCommissionPayment plug-in.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred Creating Commission Payment in the PaymentSetCommissionPayment plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private DateTime GetCommisionPeriodStart(DateTime pmtDate)
        {
            DateTime start = new DateTime();
            if (pmtDate.Day <= 15) start = new DateTime(pmtDate.Year, pmtDate.Month, 1);
            else start = new DateTime(pmtDate.Year, pmtDate.Month, 16);
            return start;
        }
        private DateTime GetCommissionPeriodEnd(DateTime pmtDate)
        {
            int daysInMonth = DateTime.DaysInMonth(pmtDate.Year, pmtDate.Month);
            DateTime lastDay = new DateTime(pmtDate.Year, pmtDate.Month, daysInMonth);
            DateTime end = new DateTime();
            if (pmtDate.Day <= 15) end = new DateTime(pmtDate.Year, pmtDate.Month, 15);
            else end = lastDay;
            return end;
        }
        private Money GetTotalPaymentsMade(IOrganizationService service, ITracingService tracingService, EntityReference invoiceRef)
        {
            Money total = new Money(0);
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_payment'>
    <attribute name='azt_amount' />
    <filter type='and'>
      <condition attribute='azt_invoiceid' operator='eq' uitype='invoice' value='{0}' />
      <condition attribute='statuscode' operator='eq' value='2' />
    </filter>
  </entity>
</fetch>
", invoiceRef.Id);
                #endregion
                EntityCollection retPayments = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (retPayments.Entities.Count == 0) return total;
                foreach (Entity p in retPayments.Entities)
                {
                    Money amt = (Money)p.Attributes["azt_amount"];
                    total.Value += amt.Value;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting Payments Related to the Invoice in the PaymentSetCommissionPayment plug-in.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting Payments Related to the Invoice in the PaymentSetCommissionPayment plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return total;
        }
        private EntityCollection GetCommissionCompPlans(IOrganizationService service, ITracingService tracingService, EntityReference invoiceRef)
        {
            EntityCollection compPlans = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_compplanamount'>
    <attribute name='azt_total' />
    <attribute name='azt_amount' />
    <attribute name='ownerid' />
    <attribute name='azt_compplanamountid' />
    <attribute name='azt_percentage' />
    <attribute name='azt_effectivedate' />
    <order attribute='createdon' descending='true' />
    <filter type='and'>
      <condition attribute='azt_invoiceid' operator='eq' uitype='invoice' value='{0}' />
      <condition attribute='azt_amount' operator='gt' value='.01' />
      <condition attribute='azt_percentage' operator='gt' value='.01' />
      <condition attribute='azt_masecommission' operator='in'>
        <value>276530002</value>
        <value>276530000</value>
      </condition>
    </filter>
  </entity>
</fetch>
", invoiceRef.Id);
                #endregion
                compPlans = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting Comp Plans Related to the Invoice in the PaymentSetCommissionPayment plug-in.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting Comp Plans Related to the Invoice in the PaymentSetCommissionPayment plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return compPlans;
        }
        private EntityCollection GetCompGoals(IOrganizationService service, ITracingService tracingService, EntityReference invoiceRef)
        {
            EntityCollection ec = new EntityCollection();
            try
            {
                #region Query
                string _fetch =
@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_compgoaltype'>
    <attribute name='azt_total' />
    <attribute name='azt_salesrepid' />
    <attribute name='azt_producttype' />
    <attribute name='azt_percentage' />
    <attribute name='azt_invoiceid' />
    <attribute name='azt_effectivedate' />
    <attribute name='azt_amount' />
    <attribute name='statuscode' />
    <attribute name='azt_orderid' />
    <attribute name='azt_compgoaltypeid' />
    <order attribute='azt_salesrepid' descending='false' />
    <order attribute='azt_producttype' descending='false' />
  </entity>
</fetch>
";
                #endregion
                ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                throw new InvalidPluginExecutionException("An error occurred getting CompGoals Related to the Invoice in the PaymentSetCommissionPayment plug-in.", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting Comp CompGoals Related to the Invoice in the PaymentSetCommissionPayment plug-in: {0}", ex.ToString());
                throw;
            }
            #endregion
            return ec;
        }
    }
}
