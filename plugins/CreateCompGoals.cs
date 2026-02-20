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
    public sealed class CreateCompGoals : CodeActivity
    {
        #region Arguments
        [RequiredArgument]
        [Input("Invoice")]
        [ReferenceTarget("invoice")]
        public InArgument<EntityReference> invoiceInput { get; set; }

        [RequiredArgument]
        [Input("Order")]
        [ReferenceTarget("salesorder")]
        public InArgument<EntityReference> orderInput { get; set; }

        [RequiredArgument]
        [Input("Opportunity")]
        [ReferenceTarget("opportunity")]
        public InArgument<EntityReference> opportunityInput { get; set; }

        [RequiredArgument]
        [Input("Invoice Number")]
        public InArgument<string> invoiceNumberInput { get; set; }

        #endregion
        protected override void Execute(CodeActivityContext executionContext)
        {
            #region TracingService
            ITracingService tracingService = executionContext.GetExtension<ITracingService>();
            if (tracingService == null)
            {
                throw new InvalidPluginExecutionException("Failed to retrieve tracing service.");
            }
            tracingService.Trace("Entered CreateCompGoals.Execute(), Activity Instance Id: {0}, Workflow Instance Id: {1}",
                executionContext.ActivityInstanceId,
                executionContext.WorkflowInstanceId);
            #endregion
            try
            {
                tracingService.Trace("Getting Invoice Info");
                EntityReference invoiceRef = invoiceInput.Get(executionContext);
                EntityReference orderRef = orderInput.Get(executionContext);
                EntityReference oppRef = opportunityInput.Get(executionContext);
                string invoiceNumber = invoiceNumberInput.Get(executionContext);
                tracingService.Trace("Invoice ID: " + invoiceRef.Id);
                #region Query
                string _fetch =
    string.Format(@"<fetch distinct='false' mapping='logical' aggregate='true'>
	<entity name='invoicedetail'>
		<attribute name='extendedamount' alias='Ext_Amt' aggregate='sum' />
		<attribute name='azt_licensetype' alias='azt_licensetype' groupby='true' />
		<filter type='and'>
			<condition attribute='invoiceid' operator='eq' uitype='invoice' value='{0}' />
		</filter>
	</entity>
</fetch>", invoiceRef.Id);
                #endregion
                #region Service
                IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
                IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                EntityReference salesRepRef = GetSalesRep(tracingService, service, oppRef.Id);
                #region SalesRep
                if (salesRepRef == null)
                {
                    Invoice i = new Invoice()
                    {
                        InvoiceId = invoiceRef.Id,
                        azt_CompCompleted= false,
                    };
                    service.Update(i);
                    throw new InvalidPluginExecutionException("There is no record owner for this opportunity.");
                }
                #endregion
                EntityReference commissionRecordRef = GetCommission(tracingService, service, salesRepRef.Id);
                if(commissionRecordRef == null)
                {
                    throw new InvalidPluginExecutionException("No commission record found for this SalesRep.");
                }
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                foreach (var i in ec.Entities)
                {
                    int licTypeInt = ((OptionSetValue)(i.GetAttributeValue<AliasedValue>("azt_licensetype")).Value).Value;
                    decimal percentage = GetSalesRepPercentage(tracingService, service, salesRepRef.Id, licTypeInt);
                    tracingService.Trace("licTypeInt: " + licTypeInt);
                    decimal extAmt = ((Money)i.GetAttributeValue<AliasedValue>("Ext_Amt").Value).Value;
                    tracingService.Trace("extAmt: " + extAmt);
                    OptionSetValue productType = GetProductType(tracingService, licTypeInt);
                    string licTypeName = GetLicenseTypeName(tracingService, licTypeInt);
                    if (productType.Value == 0) return;
                    azt_compgoaltype goalType = new azt_compgoaltype()
                    {
                        azt_InvoiceId = invoiceRef,
                        azt_OrderId = orderRef,
                        azt_SalesRepId= salesRepRef,
                        OwnerId = salesRepRef,
                        azt_OpportunityId = oppRef,
                        azt_ProductType = productType,
                        azt_Amount = new Money(extAmt),
                        azt_Percentage = percentage,
                        azt_Total = new Money((percentage * extAmt) / 100),
                        azt_EffectiveDate = DateTime.Now,
                        azt_name = invoiceNumber + " " + licTypeName
                    };
                    if (commissionRecordRef != null) goalType.azt_CommissionId = commissionRecordRef;
                    service.Create(goalType);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in CreateCompGoals workflow: {0}", e.ToString());
                throw;
            }
            #endregion
        }
        private EntityReference GetCommission(ITracingService tracingService, IOrganizationService service, Guid userId)
        {
            EntityReference commRef = new EntityReference();
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_commission'>
    <attribute name='azt_name' />
    <attribute name='azt_commissionid' />
    <order attribute='azt_fiscalperiodstart' descending='true' />
    <filter type='and'>
      <condition attribute='ownerid' operator='eq' uitype='systemuser' value='{0}' />
    </filter>
  </entity>
</fetch>
", userId);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                if(ec.Entities.Count == 0) return commRef;
                Guid commId = ec.Entities[0].Id;
                commRef = new EntityReference(azt_commission.EntityLogicalName, commId);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured getting Commission Record in CreateCompGoals workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return commRef;
        }
        private decimal GetSalesRepPercentage(ITracingService tracingService, IOrganizationService service, Guid salesRepId, int licTypeInt)
        {
            decimal repPercentage = 0;
            string percentageField = string.Empty;
            try
            {
                switch (licTypeInt)
                {
                    case 276530000:
                        percentageField = "azt_initialcomp";
                        SystemUser initial = service.Retrieve(SystemUser.EntityLogicalName, salesRepId, new ColumnSet(percentageField)).ToEntity<SystemUser>();
                        repPercentage = initial.GetAttributeValue<decimal>(percentageField);
                        break;
                    case 276530001:
                        percentageField = "azt_addoncomp";
                        SystemUser addon = service.Retrieve(SystemUser.EntityLogicalName, salesRepId, new ColumnSet(percentageField)).ToEntity<SystemUser>();
                        repPercentage = addon.GetAttributeValue<decimal>(percentageField);
                        break;
                    case 276530002:
                        percentageField = "azt_renewalcomp";
                        SystemUser renewal = service.Retrieve(SystemUser.EntityLogicalName, salesRepId, new ColumnSet(percentageField)).ToEntity<SystemUser>();
                        repPercentage = renewal.GetAttributeValue<decimal>(percentageField);
                        break;
                    case 276530004:
                        percentageField = "azt_winbackcomp";
                        SystemUser winback = service.Retrieve(SystemUser.EntityLogicalName, salesRepId, new ColumnSet(percentageField)).ToEntity<SystemUser>();
                        repPercentage = winback.GetAttributeValue<decimal>(percentageField);
                        break;
                    case 276530005:
                        percentageField = "azt_printcomp";
                        SystemUser print = service.Retrieve(SystemUser.EntityLogicalName, salesRepId, new ColumnSet(percentageField)).ToEntity<SystemUser>();
                        repPercentage = print.GetAttributeValue<decimal>(percentageField);
                        break;
                    default: return repPercentage;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured getting the SalesRep percentage in CreateCompGoals workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return repPercentage;
        }
        private EntityReference GetSalesRep(ITracingService tracingService, IOrganizationService service, Guid oppId)
        {
            EntityReference salesRep = new EntityReference();
            try
            {
                Opportunity opp = service.Retrieve(Opportunity.EntityLogicalName, oppId, new ColumnSet("azt_recordownerid")).ToEntity<Opportunity>();
                if (opp != null && opp.azt_RecordOwnerId != null)
                {
                    salesRep = opp.azt_RecordOwnerId;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured getting the SalesRep in CreateCompGoals workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return salesRep;
        }
        private OptionSetValue GetProductType(ITracingService tracingService, int licTypeInt)
        {
            OptionSetValue myOption = new OptionSetValue(0);
            int prodTypeInt = 0;
            try
            {
                switch (licTypeInt)
                {
                    case 276530000: //Initial
                        prodTypeInt = 327630000;
                        break;
                    case 276530001: //Add On
                        prodTypeInt = 327630002;
                        break;
                    case 276530002: //Renewal
                        prodTypeInt = 327630004;
                        break;
                    case 276530004: //Win Back
                        prodTypeInt = 327630003;
                        break;
                    case 276530005: //Print
                        prodTypeInt = 327630001;
                        break;
                    case 327630000: //iGrad
                        prodTypeInt = 327630005;
                        break;
                    default:
                        return myOption;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in CreateCompGoals workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            myOption = new OptionSetValue(prodTypeInt);
            return myOption;
        }
        private string GetLicenseTypeName(ITracingService tracingService, int licTypeInt)
        {
            string returnedName = string.Empty;
            try
            {
                switch(licTypeInt)
                {
                    case 276530000:
                        returnedName = "Initial";
                        break;
                    case 276530001:
                        returnedName = "Add-On";
                        break;
                    case 276530002:
                        returnedName = "Renewal";
                        break;
                    case 276530004:
                        returnedName = "Win-Back";
                        break;
                    case 276530005:
                        returnedName = "Print +";
                        break;
                    default: return returnedName;
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> e)
            {
                tracingService.Trace("Exception occured in CreateCompGoals workflow: {0}", e.ToString());
                throw;
            }
            #endregion
            return returnedName;
        }
    }
}
