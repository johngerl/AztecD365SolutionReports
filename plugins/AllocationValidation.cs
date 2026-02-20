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
    public class AllocationValidation : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if ((context.MessageName == "Create" || context.MessageName == "Update") && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_allocatedlicense.EntityLogicalName)
            {
                if (context.Depth > 1) return;
                try
                {
                    azt_allocatedlicense allocation = new azt_allocatedlicense();
                    if (context.MessageName == "Update")
                    {
                        allocation = ((Entity)context.PostEntityImages["PostAllocation"]).ToEntity<azt_allocatedlicense>();
                    }
                    else if (context.MessageName == "Create")
                    {
                        allocation = ((Entity)context.InputParameters["Target"]).ToEntity<azt_allocatedlicense>();
                    }
                    if (!allocation.Contains("azt_allocationtype") || !allocation.Contains("azt_numberoflicenses")) return;
                    OptionSetValue allocationType = allocation.azt_AllocationType;
                    if (allocationType.Value == 327630000) //Software
                    {
                        EntityReference softwareLicenseRef = allocation.azt_SoftwareLicenseId;
                        if (softwareLicenseRef == null || softwareLicenseRef.Id == Guid.Empty) throw new Exception("This allocation does not specify a Software License");
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        int numberAllocations = GetLicenseAllocations(tracingService, service, softwareLicenseRef.Id);
                        azt_softwarelicense license = service.Retrieve(azt_softwarelicense.EntityLogicalName, softwareLicenseRef.Id, new ColumnSet("azt_concurrentusers")).ToEntity<azt_softwarelicense>();
                        int numberLicenses = (int)license.azt_ConcurrentUsers;
                        if (numberAllocations > numberLicenses) throw new Exception("The number of allocations exceeds the number of Licenses or Print Products available.");
                    }
                    else if (allocationType.Value == 327630001) //Print
                    {

                    }
                }
                #region Exception
                catch (Exception ex)
                {
                    throw new InvalidPluginExecutionException(ex.Message);
                }
                #endregion
            }
        }
        private int GetLicenseAllocations(ITracingService tracingService, IOrganizationService service, Guid id)
        {
            int num = 0;
            try
            {
                #region Query
                string _fetch =
string.Format(@"
<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
  <entity name='azt_allocatedlicense'>
    <attribute name='azt_numberoflicenses' />
    <filter type='and'>
      <condition attribute='azt_softwarelicenseid' operator='eq' uitype='azt_softwarelicense' value='{0}' />
    </filter>
  </entity>
</fetch>
", id);

                #region Query
                QueryExpression Query = new QueryExpression()
                {
                    EntityName = azt_allocatedlicense.EntityLogicalName,
                    NoLock = true,
                    ColumnSet = new ColumnSet("azt_numberoflicenses"),
                    Criteria =
                    {
                        Filters =
                        {
                            new FilterExpression
                            {
                                FilterOperator = LogicalOperator.And,
                                Conditions =
                                {
                                    new ConditionExpression("statecode",ConditionOperator.Equal,0),
                                    new ConditionExpression("azt_softwarelicenseid",ConditionOperator.Equal,id)
                                },
                            },
                        }
                    }
                };
                #endregion
                #endregion
                EntityCollection ec = service.RetrieveMultiple(Query);
                foreach (var a in ec.Entities)
                {
                    num += a.GetAttributeValue<int>("azt_numberoflicenses");
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error in the AllocationValidation Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error in the AllocationValidation Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error in the AllocationValidation Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return num;
        }
    }
}
