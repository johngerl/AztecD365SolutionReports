using CrmContext;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AztecPlugins
{
    public class FundingYearSync : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context/Tracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if ((context.MessageName == "Create" || context.MessageName == "Update") && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_Funding.EntityLogicalName)
            {
                azt_Funding funding = ((Entity)context.InputParameters["Target"]).ToEntity<azt_Funding>();
                if (funding.azt_FundingYear != null)
                {
                    funding.azt_Year = funding.azt_FundingYear.ToString();
                }
            }
        }
    }
}
