using CrmContext;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
namespace AztecPlugins
{
    public class CreateUserGoals : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region TracingContext
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                #region Service
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                #endregion
                EntityReference userRef = (EntityReference)context.InputParameters["UserId"];
                string goalType = (string)context.InputParameters["GoalType"];
                SystemUser u = service.Retrieve(SystemUser.EntityLogicalName, userRef.Id, new ColumnSet("fullname", "azt_jobrole", "parentsystemuserid")).ToEntity<SystemUser>();
                if (u.azt_JobRole == null || u.azt_JobRole.Value != 327630000) throw new InvalidPluginExecutionException("You cannot create goals for a non-Sales Person.");
                if (u.ParentSystemUserId == null) throw new InvalidPluginExecutionException("A Sales Rep must have a manager in order to create a goal.");
                EntityReference metricRef = GetGoalMetric(service, tracingService, goalType);
                //if (goalType == "Print") throw new InvalidPluginExecutionException("Print Goals not Done yet.");
                //if (goalType == "Combined") throw new InvalidPluginExecutionException("Combined Goals not Done yet.");

                EntityCollection ec = getExistingGoals(service, tracingService, userRef.Id, goalType);
                if (ec.Entities.Count > 1) return;
                Guid parentGoalId = CreateParentGoal(service, tracingService, u, metricRef, goalType);
                if (goalType == "Combined" && goalType == "Print")
                    CreateQuarterlyChildGoals(service, tracingService, u, metricRef, parentGoalId, goalType);
                else
                    CreateMonthlyChildGoals(service, tracingService, u, metricRef, parentGoalId, goalType);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the CreateUserGoals action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the CreateUserGoals action." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the CreateUserGoals action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void CreateMonthlyChildGoals(IOrganizationService service, ITracingService tracingService, SystemUser u, EntityReference metricRef, Guid parentGoalId, string goalType)
        {
            try
            {
                #region GoalType
                int goalTypeInt = 0;
                switch (goalType)
                {
                    case "SaaS":
                        goalTypeInt = 327630000;
                        break;
                    case "Print":
                        goalTypeInt = 327630001;
                        break;
                    case "Combined":
                        goalTypeInt = 327630002;
                        break;
                    case "SaaSOpp":
                        goalTypeInt = 327630003;
                        break;
                    case "PrintOpp":
                        goalTypeInt = 327630004;
                        break;
                    case "Initial":
                        goalTypeInt = 327630005;
                        break;
                    case "AddOn":
                        goalTypeInt = 327630006;
                        break;
                    case "WinBack":
                        goalTypeInt = 327630007;
                        break;
                    case "Renewals":
                        goalTypeInt = 327630008;
                        break;
                    case "PrintPlus":
                        goalTypeInt = 327630009;
                        break;
                }
                #endregion
                string goalTypeName = string.Empty;
                if (goalType == "SaaSOpp") goalTypeName = "SaaS Opp";
                if (goalType == "PrintOpp") goalTypeName = "Print Opp";
                if (goalType == "Initial") goalTypeName = "Initial";
                if (goalType == "AddOn") goalTypeName = "Add-On";
                if (goalType == "WinBack") goalTypeName = "Win-Back";
                if (goalType == "Renewals") goalTypeName = "Renewals";
                if (goalType == "PrintPlus") goalTypeName = "Print +";
                bool is2023Goal = false;
                if(goalType == "Initial" || goalType == "AddOn" || goalType == "WinBack" || goalType == "Renewals" || goalType == "PrintPlus")
                    is2023Goal = true;

                DateTime today = DateTime.Today;
                for (var months = 1; months < 13; months++)
                {
                    string m = "Month " + months;
                    EntityReference rollupQueryRef = CreateRollupQuery(service, tracingService, u, months, goalTypeName);
                    Goal p = new Goal()
                    {
                        Title = u.FullName + " - Target " + today.Year.ToString() + " " + goalTypeName + " " + m,
                        azt_GoalType = new OptionSetValue(goalTypeInt),
                        GoalOwnerId = new EntityReference(SystemUser.EntityLogicalName, (Guid)u.SystemUserId),
                        OwnerId = u.ParentSystemUserId,
                        MetricId = metricRef,
                        IsFiscalPeriodGoal = false,
                        GoalStartDate = new DateTime(DateTime.Today.Year, 1, 1),
                        GoalEndDate = new DateTime(DateTime.Today.Year, 12, 31),
                        RollupOnlyFromChildGoals = false,
                        ConsiderOnlyGoalOwnersRecords = false,
                        RollUpQueryActualMoneyId = rollupQueryRef,
                        ParentGoalId = new EntityReference(Goal.EntityLogicalName, parentGoalId)
                    };
                    if(is2023Goal) p.RollUpQueryInprogressMoneyId= rollupQueryRef;
                    service.Create(p);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating monthly child goals in the CreateUserGoals action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating monthly child goals in the OpportunityClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating monthly child goals in the CreateUserGoals action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void CreateQuarterlyChildGoals(IOrganizationService service, ITracingService tracingService, SystemUser u, EntityReference metricRef, Guid parentGoalId, string goalType)
        {
            try
            {
                #region GoalType
                int goalTypeInt = 0;
                switch (goalType)
                {
                    case "SaaS":
                        goalTypeInt = 327630000;
                        break;
                    case "Print":
                        goalTypeInt = 327630001;
                        break;
                    case "Combined":
                        goalTypeInt = 327630002;
                        break;
                    case "SaaSOpp":
                        goalTypeInt = 327630003;
                        break;
                }
                #endregion
                if (goalType == "SaaS") goalType = "Ed-Tech";
                if (goalType == "SaaSOpp") goalType = "SaaS Opp";
                DateTime today = DateTime.Today;
                for (var quarters = 1; quarters < 5; quarters++)
                {
                    string q = "Q" + quarters;
                    EntityReference rollupQueryRef = CreateRollupQuery(service, tracingService, u, quarters, goalType);
                    Goal p = new Goal()
                    {
                        Title = u.FullName + " - Target " + today.Year.ToString() + " " + goalType + " " + q,
                        azt_GoalType = new OptionSetValue(goalTypeInt),
                        GoalOwnerId = new EntityReference(SystemUser.EntityLogicalName, (Guid)u.SystemUserId),
                        OwnerId = u.ParentSystemUserId,
                        MetricId = metricRef,
                        IsFiscalPeriodGoal = false,
                        GoalStartDate = new DateTime(DateTime.Today.Year, 1, 1),
                        GoalEndDate = new DateTime(DateTime.Today.Year, 12, 31),
                        RollupOnlyFromChildGoals = false,
                        ConsiderOnlyGoalOwnersRecords = true,
                        RollUpQueryActualMoneyId = rollupQueryRef,
                        ParentGoalId = new EntityReference(Goal.EntityLogicalName, parentGoalId)
                    };
                    service.Create(p);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating quarterly child goals in the CreateUserGoals action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating quarterly child goals in the OpportunityClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating quarterly child goals in the CreateUserGoals action: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private EntityReference GetGoalMetric(IOrganizationService service, ITracingService tracingService, string goalType)
        {
            EntityReference metRef;
            try
            {
                string metricName = "New Target";
                if (goalType == "SaaSOpp" || goalType == "PrintOpp")
                    metricName = "Opportunity Amount";
                else
                    metricName = "Aztec Goal";
                #region Query
                string _fetch =
string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='metric'>
    <attribute name='name' />
    <attribute name='isamount' />
    <attribute name='amountdatatype' />
    <order attribute='createdon' descending='true' />
    <filter type='and'>
      <condition attribute='statecode' operator='eq' value='0' />
      <condition attribute='name' operator='eq' value='{0}' />
    </filter>
  </entity>
</fetch>", metricName);
                #endregion
                EntityCollection ec = service.RetrieveMultiple(new FetchExpression(_fetch));
                if (ec.Entities.Count == 0) throw new InvalidPluginExecutionException("Goal Metric not found.");
                Metric met = ec.Entities[0].ToEntity<Metric>();
                metRef = met.ToEntityReference();
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred getting goal metric in the CreateUserGoals action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred getting goal metric in the OpportunityClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred getting goal metric in the CreateUserGoals action: {0}", ex.ToString());
                throw;
            }
            #endregion
            return metRef;
        }
        private Guid CreateParentGoal(IOrganizationService service, ITracingService tracingService, SystemUser u, EntityReference metRef, string goalType)
        {
            Guid parentId = Guid.Empty;
            try
            {
                #region GoalType
                int goalTypeInt = 0;
                switch (goalType)
                {
                    case "SaaS":
                        goalTypeInt = 327630000;
                        break;
                    case "Print":
                        goalTypeInt = 327630001;
                        break;
                    case "Combined":
                        goalTypeInt = 327630002;
                        break;
                    case "SaaSOpp":
                        goalTypeInt = 327630003;
                        break;
                    case "PrintOpp":
                        goalTypeInt = 327630004;
                        break;
                    case "Initial":
                        goalTypeInt = 327630005;
                        break;
                    case "AddOn":
                        goalTypeInt = 327630006;
                        break;
                    case "WinBack":
                        goalTypeInt = 327630007;
                        break;
                    case "Renewals":
                        goalTypeInt = 327630008;
                        break;
                    case "PrintPlus":
                        goalTypeInt = 327630009;
                        break;
                }
                #endregion
                string goalTypeName = string.Empty;
                if (goalType == "SaaS") goalType = "Ed-Tech";
                if (goalType == "SaaSOpp") goalType = "SaaS Opp";
                if (goalType == "AddOn") goalTypeName = "Add-On";
                if (goalType == "WinBack") goalTypeName = "Win-Back";
                if (goalType == "PrintPlus") goalTypeName = "Print +";
                if (goalType == "Initial") goalTypeName = "Initial";
                if (goalType == "Renewals") goalTypeName = "Renewals";

                EntityReference mgrRef = u.ParentSystemUserId;
                DateTime today = DateTime.Today;
                Goal p = new Goal()
                {
                    Title = u.FullName + " - Target " + today.Year.ToString() + " " + goalTypeName + " Total",
                    azt_GoalType = new OptionSetValue(goalTypeInt),
                    GoalOwnerId = new EntityReference(SystemUser.EntityLogicalName, (Guid)u.SystemUserId),
                    OwnerId = mgrRef,
                    MetricId = metRef,
                    IsFiscalPeriodGoal = false,
                    GoalStartDate = new DateTime(DateTime.Today.Year, 1, 1),
                    GoalEndDate = new DateTime(DateTime.Today.Year, 12, 31),
                    RollupOnlyFromChildGoals = true,
                    ConsiderOnlyGoalOwnersRecords = false
                };
                parentId = service.Create(p);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating parent goal in the CreateUserGoals action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating parent goal in the OpportunityClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating parent goal in the CreateUserGoals action: {0}", ex.ToString());
                throw;
            }
            #endregion
            return parentId;
        }
        private EntityCollection getExistingGoals(IOrganizationService service, ITracingService tracingService, Guid id, string goalType)
        {
            EntityCollection ec = new EntityCollection();
            try
            {
                #region GoalType
                int goalTypeInt = 0;
                switch (goalType)
                {
                    case "SaaS":
                        goalTypeInt = 327630000;
                        break;
                    case "Print":
                        goalTypeInt = 327630001;
                        break;
                    case "Combined":
                        goalTypeInt = 327630002;
                        break;
                    case "SaaSOpp":
                        goalTypeInt = 327630003;
                        break;
                }
                #endregion
                DateTime today = DateTime.Today;
                DateTime firstDayOfYear = new DateTime(today.Year, 1, 1);
                DateTime lastDayOfYear = new DateTime(today.Year, 12, 31);
                //DateTime jan1 = 
                #region Query
                string _fetch =
string.Format(@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='goal'>
    <attribute name='goalid' />
    <attribute name='parentgoalid' />
    <attribute name='goalstartdate' />
    <attribute name='goalenddate' />
    <order attribute='fiscalperiod' descending='false' />
    <order attribute='title' descending='false' />
    <filter type='and'>
      <condition attribute='goalownerid' operator='eq' uitype='systemuser' value='{0}' />
      <condition attribute='goalstartdate' operator='on' value='{1}' />
      <condition attribute='goalenddate' operator='on' value='{2}' />
      <condition attribute='statecode' operator='eq' value='0' />
      <condition attribute='azt_goaltype' operator='eq' value='{3}' />
    </filter>
  </entity>
</fetch>", id, firstDayOfYear, lastDayOfYear, goalTypeInt);
                #endregion
                ec = service.RetrieveMultiple(new FetchExpression(_fetch));
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred retrieving existing user goals in the CreateUserGoals action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred retrieving existing user goals in the OpportunityClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the CreateUserGoals action: {0}", ex.ToString());
                throw;
            }
            #endregion
            return ec;
        }
        private bool GetIsMonthlyGoal(string goalTypeName)
        {
            bool isMonthlyGoal = false;
            switch (goalTypeName)
            {
                case "Initial":
                    isMonthlyGoal = true;
                    break;
                case "Add-On":
                    isMonthlyGoal = true;
                    break;
                case "Win-Back":
                    isMonthlyGoal = true;
                    break;
                case "Renewals":
                    isMonthlyGoal = true;
                    break;
                case "Print +":
                    isMonthlyGoal = true;
                    break;
            }
            return isMonthlyGoal;
        }
        private EntityReference CreateRollupQuery(IOrganizationService service, ITracingService tracingService, SystemUser u, int periodNumber, string goalTypeName)
        {
            string entityType = azt_compgoaltype.EntityLogicalName;
            string _finalFetch = string.Empty;
            Guid _rollupQueryId = Guid.Empty;
            DateTime today = DateTime.Today;
            int year = today.Year;
            int monthNumber = periodNumber;
            DateTime firstDayOfMonth = new DateTime(year, monthNumber, 1);
            DateTime lastDayOfMonth = new DateTime(firstDayOfMonth.Year, firstDayOfMonth.Month, DateTime.DaysInMonth(firstDayOfMonth.Year, firstDayOfMonth.Month));

            string firstDayString = GetDateString(firstDayOfMonth);
            string lastDayString = GetDateString(lastDayOfMonth);
            try
            {
                string periodType = "Q";
                if (GetIsMonthlyGoal(goalTypeName))
                    periodType= "M";
                #region RollupQuery
                QueryExpression rollupQuery = new QueryExpression()
                {
                    EntityName = GoalRollupQuery.EntityLogicalName,
                    ColumnSet = new ColumnSet("goalrollupqueryid"),
                    NoLock = true,
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("ownerid", ConditionOperator.Equal, (Guid)u.SystemUserId),
                            new ConditionExpression("name",ConditionOperator.Equal, u.FullName + " " + today.Year.ToString() + " " + periodType + periodNumber + " " + goalTypeName + " Rollup")
                        }
                    }
                };
                #endregion
                EntityCollection retRollups = service.RetrieveMultiple(rollupQuery);
                if (retRollups.Entities.Count > 0) _rollupQueryId = (Guid)retRollups[0].Attributes["goalrollupqueryid"];
                if (_rollupQueryId == Guid.Empty)
                {
                    int productType = 0;
                    #region Product Type
                    switch (goalTypeName)
                    {
                        case "Ed-Tech":
                            productType = 327630000;
                            break;
                        case "Print":
                            productType = 327630001;
                            break;
                        case "Combined":
                            productType = 327630002;
                            break;
                        case "SaaS Opp":
                            productType = 327630000;
                            break;
                        case "Print Opp":
                            productType = 327630001;
                            break;
                    }
                    #endregion
                    int compGoalProductType = 0;
                    #region Comp Goal Product Type
                    switch (goalTypeName)
                    {
                        case "Initial":
                            compGoalProductType = 327630000;
                            break;
                        case "Add-On":
                            compGoalProductType = 327630002;
                            break;
                        case "Win-Back":
                            compGoalProductType = 327630003;
                            break;
                        case "Renewals":
                            compGoalProductType = 327630004;
                            break;
                        case "Print +":
                            compGoalProductType = 327630001;
                            break;
                    }
                    #endregion
                    #region Fetch
                    #region SaaS Opp
                    if (goalTypeName == "SaaS Opp")
                    {
                        entityType = OpportunityProduct.EntityLogicalName;
                        periodType = "Month: ";
                        _finalFetch = string.Format(@"<fetch distinct='true' mapping='logical'>
	<entity name='opportunityproduct'>
		<attribute name='productid'/>
		<attribute name='productdescription'/>
		<attribute name='priceperunit'/>
		<attribute name='quantity'/>
		<attribute name='extendedamount'/>
		<attribute name='opportunityproductid'/>
		<order attribute='productid' descending='false'/>
		<filter type='and'>
			<condition attribute='azt_issaas' operator='eq' value='1'/>
		</filter>
		<link-entity name='opportunity' alias='aa' link-type='inner' from='opportunityid' to='opportunityid'>
			<filter type='and'>
				<condition attribute='statecode' operator='eq' value='1'/>
				<condition attribute='actualclosedate' operator='on-or-after' value='{0}'/>
				<condition attribute='actualclosedate' operator='on-or-before' value='{1}'/>
				<condition attribute='azt_recordownerid' operator='eq' value='{2}' uitype='systemuser'/>
			</filter>
		</link-entity>
	</entity>
</fetch>", firstDayString, lastDayString, (Guid)u.SystemUserId);
                    }
                    #endregion
                    #region Print Opp
                    else if (goalTypeName == "Print Opp")
                    {
                        entityType = OpportunityProduct.EntityLogicalName;
                        periodType = "Month: ";
                        _finalFetch = string.Format(@"<fetch distinct='true' mapping='logical'>
	<entity name='opportunityproduct'>
		<attribute name='productid'/>
		<attribute name='productdescription'/>
		<attribute name='priceperunit'/>
		<attribute name='quantity'/>
		<attribute name='extendedamount'/>
		<attribute name='opportunityproductid'/>
		<order attribute='productid' descending='false'/>
		<filter type='and'>
			<condition attribute='azt_issaas' operator='ne' value='1'/>
		</filter>
		<link-entity name='opportunity' alias='aa' link-type='inner' from='opportunityid' to='opportunityid'>
			<filter type='and'>
				<condition attribute='statecode' operator='eq' value='1'/>
				<condition attribute='actualclosedate' operator='on-or-after' value='{0}'/>
				<condition attribute='actualclosedate' operator='on-or-before' value='{1}'/>
				<condition attribute='azt_recordownerid' operator='eq' value='{2}' uitype='systemuser'/>
			</filter>
		</link-entity>
	</entity>
</fetch>", firstDayString, lastDayString, (Guid)u.SystemUserId);
                    }
                    #endregion
                    #region Combined
                    else if (goalTypeName == "Combined")
                    {

                        _finalFetch = string.Format(@"<fetch version='1.0' mapping='logical'>
  <entity name='azt_compplanamount'>
    <order attribute='createdon' descending='true'/>
    <attribute name='azt_total'/>
    <attribute name='statuscode'/>
    <attribute name='azt_payablecommission'/>
    <attribute name='azt_orderid'/>
    <attribute name='azt_invoiceid'/>
    <attribute name='azt_amount'/>
    <attribute name='azt_percentagepaid'/>
    <attribute name='createdon'/>
    <attribute name='ownerid'/>
    <attribute name='azt_masecommission'/>
    <attribute name='azt_compplanamountid'/>
    <filter type='and'>
      <condition attribute='ownerid' operator='eq' value='{0}' uitype='systemuser'/>
      <condition attribute='azt_producttype' operator='in'>
        <value>327630000</value>
        <value>327630001</value>
      </condition>
      <condition attribute='azt_effectivedate' operator='in-fiscal-period' value='{1}'/>
    </filter>
    <link-entity name='invoice' alias='ah' link-type='inner' from='invoiceid' to='azt_invoiceid'>
			<filter type='and'>
				<condition attribute='azt_compcompleted' operator='eq' value='1'/>
			</filter>
		</link-entity>
  </entity>
</fetch>", (Guid)u.SystemUserId, periodNumber);
                    }
                    #endregion
                    #region Print or SaaS
                    else if (goalTypeName == "Print" || goalTypeName == "SaaS")
                    {
                        _finalFetch = string.Format(@"<fetch version='1.0' mapping='logical'>
  <entity name='azt_compplanamount'>
    <order attribute='createdon' descending='true'/>
    <attribute name='azt_total'/>
    <attribute name='statuscode'/>
    <attribute name='azt_payablecommission'/>
    <attribute name='azt_orderid'/>
    <attribute name='azt_invoiceid'/>
    <attribute name='azt_amount'/>
    <attribute name='azt_percentagepaid'/>
    <attribute name='createdon'/>
    <attribute name='ownerid'/>
    <attribute name='azt_masecommission'/>
    <attribute name='azt_compplanamountid'/>
    <filter type='and'>
      <condition attribute='ownerid' operator='eq' value='{0}' uitype='systemuser'/>
      <condition attribute='azt_producttype' operator='eq' value='{1}'/>
      <condition attribute='azt_effectivedate' operator='in-fiscal-period' value='{2}'/>
    </filter>
    <link-entity name='invoice' alias='ah' link-type='inner' from='invoiceid' to='azt_invoiceid'>
			<filter type='and'>
				<condition attribute='azt_compcompleted' operator='eq' value='1'/>
			</filter>
		</link-entity>
  </entity>
</fetch>", (Guid)u.SystemUserId, productType, periodNumber);
                    }
                    #endregion
                    #region 2023 Goals
                    else if (goalTypeName == "Initial" || goalTypeName == "Renewals" || goalTypeName == "Add-On" || goalTypeName == "Win-Back" || goalTypeName == "Print +")
                    {
                        entityType = azt_compgoaltype.EntityLogicalName;
                        periodType = "Month: ";
                        _finalFetch = string.Format(@"<fetch distinct='true' mapping='logical'>
	<entity name='azt_compgoaltype'>
		<order attribute='azt_salesrepid' descending='false'/>
		<order attribute='azt_producttype' descending='false'/>
		<attribute name='azt_total'/>
		<attribute name='azt_salesrepid'/>
		<attribute name='azt_producttype'/>
		<attribute name='azt_percentage'/>
		<attribute name='azt_invoiceid'/>
		<attribute name='azt_effectivedate'/>
		<attribute name='azt_amount'/>
		<attribute name='statuscode'/>
		<attribute name='azt_orderid'/>
		<attribute name='azt_compgoaltypeid'/>
		<filter type='and'>
			<condition attribute='azt_salesrepid' operator='eq' value='{0}' uitype='systemuser'/>
			<condition attribute='azt_effectivedate' operator='on-or-after' value='{1}'/>
			<condition attribute='azt_effectivedate' operator='on-or-before' value='{2}'/>
			<condition attribute='azt_producttype' operator='eq' value='{3}'/>
		</filter>
	</entity>
</fetch>", (Guid)u.SystemUserId, firstDayString, lastDayString, compGoalProductType);
                    }
                }
                #endregion
                #endregion
                GoalRollupQuery goalRollupQuery = new GoalRollupQuery()
                {
                    Name = u.FullName + " " + today.Year.ToString() + " " + periodType + periodNumber + " " + goalTypeName + " Rollup",
                    OwnerId = new EntityReference(SystemUser.EntityLogicalName, (Guid)u.SystemUserId),
                    QueryEntityType = entityType,
                    FetchXml = _finalFetch
                };
                _rollupQueryId = service.Create(goalRollupQuery);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred creating rollup query in the CreateUserGoals action: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred creating rollup query in the OpportunityClone function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred creating rollup query in the CreateUserGoals action: {0}", ex.ToString());
                throw;
            }
            #endregion
            return new EntityReference(GoalRollupQuery.EntityLogicalName, _rollupQueryId);
        }
        private string GetDateString(DateTime dateValue)
        {
            string returnedDateString;
            try
            {
                string month = dateValue.Month.ToString();
                string day = dateValue.Day.ToString();
                string year = dateValue.Year.ToString();

                returnedDateString = month + "/" + day + "/" + year;
            }
            catch (Exception)
            {

                throw;
            }
            return returnedDateString;
        }
    }
}
