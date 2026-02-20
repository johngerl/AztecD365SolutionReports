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
    public class RestrictWinQuote : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            try
            {
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                Guid _userId = context.InitiatingUserId;
                SystemUser user = service.Retrieve(SystemUser.EntityLogicalName, context.InitiatingUserId, new ColumnSet("businessunitid")).ToEntity<SystemUser>();
                bool _userHasRole = Utility.UserHasRole(service, _userId, user.BusinessUnitId.Id, "Win Quotes", tracingService);
                if (!_userHasRole)
                    throw new Exception("Only Users with the Win Quotes Role can win Quotes");
            }
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
        }
        
    }
}
