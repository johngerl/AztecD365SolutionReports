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
    public class RecordOwnerRestrictEdit : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracingService
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            #endregion
            #region Update
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                if (((Entity)context.InputParameters["Target"]).LogicalName == Opportunity.EntityLogicalName)
                {
                    Opportunity opp = ((Entity)context.PreEntityImages["PreOpp"]).ToEntity<Opportunity>();
                    Guid initiatingUser = context.InitiatingUserId;
                    SystemUser user = service.Retrieve(SystemUser.EntityLogicalName, initiatingUser, new ColumnSet("businessunitid")).ToEntity<SystemUser>();
                    if (Utility.UserHasRole(service, initiatingUser, user.BusinessUnitId.Id, "System Administrator", tracingService)) return;
                    bool _userHasRole = Utility.UserHasRole(service, initiatingUser, user.BusinessUnitId.Id, "External Salesperson", tracingService);
                    if (_userHasRole && !opp.Contains("azt_recordowner") && initiatingUser != (Guid)opp.azt_RecordOwnerId.Id)
                    {
                        throw new InvalidPluginExecutionException("You do not have privileges to edit this record.");
                    }

                    EntityReference recordOwnerRef = opp.azt_RecordOwnerId;
                    EntityReference ownerRef = opp.OwnerId;

                    if (_userHasRole && initiatingUser != ownerRef.Id && initiatingUser != recordOwnerRef.Id)
                    {

                        if (_userHasRole)
                            throw new InvalidPluginExecutionException("You do not have privileges to edit this record.");
                    }
                }
                else if(((Entity)context.InputParameters["Target"]).LogicalName == Quote.EntityLogicalName)
                {
                    Quote quote = ((Entity)context.PreEntityImages["PreQuote"]).ToEntity<Quote>();
                    Guid initiatingUser = context.InitiatingUserId;
                    SystemUser user = service.Retrieve(SystemUser.EntityLogicalName, initiatingUser, new ColumnSet("businessunitid")).ToEntity<SystemUser>();
                    if (Utility.UserHasRole(service, initiatingUser, user.BusinessUnitId.Id, "System Administrator", tracingService)) return;
                    bool _userHasRole = Utility.UserHasRole(service, initiatingUser, user.BusinessUnitId.Id, "External Salesperson", tracingService);
                    if (_userHasRole && !quote.Contains("azt_recordowner") && initiatingUser != (Guid)quote.azt_RecordOwnerId.Id)
                    {
                        throw new InvalidPluginExecutionException("You do not have privileges to edit this record.");
                    }

                    EntityReference recordOwnerRef = quote.azt_RecordOwnerId;
                    EntityReference ownerRef = quote.OwnerId;

                    if (_userHasRole && initiatingUser != ownerRef.Id && initiatingUser != recordOwnerRef.Id)
                    {

                        if (_userHasRole)
                            throw new InvalidPluginExecutionException("You do not have privileges to edit this record.");
                    }
                }
            }
            #endregion
            else if(context.MessageName == "Create" && context.InputParameters.Contains("Target") && ((Entity)context.InputParameters["Target"]).LogicalName == azt_productdiscount.EntityLogicalName)
            {
                Guid initiatingUser = context.InitiatingUserId;
                SystemUser user = service.Retrieve(SystemUser.EntityLogicalName, context.InitiatingUserId, new ColumnSet("businessunitid")).ToEntity<SystemUser>();
                if (Utility.UserHasRole(service, initiatingUser, user.BusinessUnitId.Id, "System Administrator", tracingService)) return;
                azt_productdiscount disc = ((Entity)context.InputParameters["Target"]).ToEntity<azt_productdiscount>();
                if (Utility.UserHasRole(service, initiatingUser, user.BusinessUnitId.Id, "External Salesperson", tracingService) && disc.Contains("azt_opportunityid"))
                {
                    EntityReference oppRef = disc.azt_OpportunityId;
                    Opportunity opp = service.Retrieve(Opportunity.EntityLogicalName, oppRef.Id, new ColumnSet("ownerid", "azt_recordownerid")).ToEntity<Opportunity>();
                    if (opp.Contains("azt_recordownerid"))
                    {
                        EntityReference recordOwnerRef = opp.azt_RecordOwnerId;
                        EntityReference ownerRef = opp.OwnerId;
                        if(initiatingUser != recordOwnerRef.Id && initiatingUser != ownerRef.Id)
                        {
                            throw new InvalidPluginExecutionException("You do not have privileges to apply a discount.");
                        }
                    }
                }
                else if (Utility.UserHasRole(service, initiatingUser, user.BusinessUnitId.Id, "External Salesperson", tracingService) && disc.Contains("azt_quoteproductid"))
                {

                }
            }
        }
    }
}
