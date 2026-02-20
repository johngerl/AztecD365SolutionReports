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
    public class GetUserHasRoleToAction : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

            EntityReference userRef = (EntityReference)context.InputParameters["UserName"];
            string _roleToCheck = (string)context.InputParameters["RoleName"];
            bool userHasRole = UserHasRole(service, userRef.Id, _roleToCheck);
            if (userHasRole) context.OutputParameters["HasRole"] = true;
        }
        private bool UserHasRole(IOrganizationService service, Guid _userId, string _givenRole)
        {
            bool isUserInRole = false;
            #region FindRole
            QueryExpression query = new QueryExpression
            {
                EntityName = Role.EntityLogicalName,
                ColumnSet = new ColumnSet("roleid"),
                Criteria = new FilterExpression
                {
                    Conditions =
                                {

                                    new ConditionExpression
                                    {
                                        AttributeName = "name",
                                        Operator = ConditionOperator.Equal,
                                        Values = {_givenRole}
                                    }
                                }
                }
            };
            #endregion FindRole
            #region GetRole
            EntityCollection givenRoles = service.RetrieveMultiple(query);

            if (givenRoles.Entities.Count > 0)
            {
                Role givenRole = givenRoles.Entities[0].ToEntity<Role>();
                //Console.WriteLine("Checking association between user and role.");
                // Establish a SystemUser link for a query.
                LinkEntity systemUserLink = new LinkEntity()
                {
                    LinkFromEntityName = SystemUserRoles.EntityLogicalName,
                    LinkFromAttributeName = "systemuserid",
                    LinkToEntityName = SystemUser.EntityLogicalName,
                    LinkToAttributeName = "systemuserid",
                    LinkCriteria =
                    {
                        Conditions =
                                    {
                                        new ConditionExpression(
                                            "systemuserid", ConditionOperator.Equal, _userId)
                                    }
                    }
                };
                #endregion GetRole
                #region Query
                QueryExpression linkQuery = new QueryExpression()
                {
                    EntityName = Role.EntityLogicalName,
                    ColumnSet = new ColumnSet("roleid"),
                    LinkEntities =
                                {
                                    new LinkEntity()
                                    {
                                        LinkFromEntityName = Role.EntityLogicalName,
                                        LinkFromAttributeName = "roleid",
                                        LinkToEntityName = SystemUserRoles.EntityLogicalName,
                                        LinkToAttributeName = "roleid",
                                        LinkEntities = {systemUserLink}
                                    }
                                },
                    Criteria =
                    {
                        Conditions =
                                    {
                                        new ConditionExpression("roleid", ConditionOperator.Equal, givenRole.Id)
                                    }
                    }
                };
                #endregion Query
                // Retrieve matching roles.
                EntityCollection matchEntities = service.RetrieveMultiple(linkQuery);

                // if an entity is returned then the user is a member
                // of the role
                isUserInRole = (matchEntities.Entities.Count > 0);

                //if (isUserInRole)
                //    Console.WriteLine("User do not belong to the role.");
                //else
                //    Console.WriteLine("User belong to this role.");
            }
            return isUserInRole;
        }
    }
}
