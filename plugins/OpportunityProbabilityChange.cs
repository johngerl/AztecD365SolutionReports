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
    public class OpportunityProbabilityChange : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context/Tracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if ((context.MessageName == "Create" || context.MessageName == "Update") && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Opportunity.EntityLogicalName)
            {
                Opportunity opportunity = ((Entity)context.InputParameters["Target"]).ToEntity<Opportunity>();
                if (opportunity.Attributes.Contains("azt_probability"))
                {
                    opportunity.azt_ProbabilityChangedOn = DateTime.Now;

                    if (context.MessageName == "Update")
                    {
                        Opportunity preOpportunity = ((Entity)context.PreEntityImages["PreProbabilityChange"]).ToEntity<Opportunity>();
                        if (preOpportunity.Attributes.Contains("azt_probability"))
                        {
                            int previousProbability = ((OptionSetValue)preOpportunity.Attributes["azt_probability"]).Value;
                            int postProbability = opportunity.GetAttributeValue<OptionSetValue>("azt_probability").Value;
                            if (GetProbabilityIsGreater(previousProbability, postProbability))
                            {
                                opportunity.azt_ProbabilityIncreased = true;
                            }
                        }
                    }
                }
            }
        }
        private bool GetProbabilityIsGreater(int previousProbability, int postProbability)
        {
            bool isGreater = false;
            int prev = 0;
            int post = 0;
            #region Pre
            switch (previousProbability)
            {
                case 276530010:
                    prev = 1;
                    break;
                case 276530000:
                    prev = 2;
                    break;
                case 276530001:
                    prev = 3;
                    break;
                case 276530002:
                    prev = 4;
                    break;
                case 100000001:
                    prev = 5;
                    break;
                case 276530003:
                    prev = 6;
                    break;
                case 276530004:
                    prev = 7;
                    break;
                case 100000000:
                    prev = 8;
                    break;
                case 276530005:
                    prev = 9;
                    break;
                case 276530006:
                    prev = 10;
                    break;
                case 100530010:
                    prev = 11;
                    break;
                case 276530007:
                    prev = 12;
                    break;
                case 276530008:
                    prev = 13;
                    break;
                case 327630000:
                    prev = 14;
                    break;
                case 276530009:
                    prev = 15;
                    break;
            }
            #endregion
            #region Post
            switch (postProbability)
            {
                case 276530010:
                    post = 1;
                    break;
                case 276530000:
                    post = 2;
                    break;
                case 276530001:
                    post = 3;
                    break;
                case 276530002:
                    post = 4;
                    break;
                case 100000001:
                    post = 5;
                    break;
                case 276530003:
                    post = 6;
                    break;
                case 276530004:
                    post = 7;
                    break;
                case 100000000:
                    post = 8;
                    break;
                case 276530005:
                    post = 9;
                    break;
                case 276530006:
                    post = 10;
                    break;
                case 100530010:
                    post = 11;
                    break;
                case 276530007:
                    post = 12;
                    break;
                case 276530008:
                    post = 13;
                    break;
                case 327630000:
                    post = 14;
                    break;
                case 276530009:
                    post = 15;
                    break;
            }
            #endregion
            if(post > prev)
                isGreater = true;
            return isGreater;
        }
    }
}
