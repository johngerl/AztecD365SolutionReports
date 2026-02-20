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
    public class OpportunityProbabilityNumber : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if(context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Opportunity.EntityLogicalName)
            {
                try
                {
                    Opportunity opp = ((Entity)context.InputParameters["Target"]).ToEntity<Opportunity>();
                    if (opp.Contains("azt_probability") && opp.azt_Probability != null)
                    {
                        Guid oppId = (Guid)opp.OpportunityId;
                        int probNum = getProbabilityNumber(opp.azt_Probability);
                        Opportunity uOpp = new Opportunity()
                        {
                            OpportunityId = oppId,
                            CloseProbability = probNum
                        };
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        service.Update(uOpp);
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error setting closeprobability in the OpportunityProbabilityNumber Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error setting closeprobability in the OpportunityProbabilityNumber Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error setting closeprobability in the OpportunityProbabilityNumber Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private static int getProbabilityNumber(OptionSetValue prob)
        {
            int retOpt = 0;
            switch (prob.Value)
            {
                case 276530000:
                    retOpt = 10;
                    break;
                case 276530001:
                    retOpt = 20;
                    break;
                case 276530002:
                    retOpt = 30;
                    break;
                case 100000001:
                    retOpt = 35;
                    break;
                case 276530003:
                    retOpt = 40;
                    break;
                case 276530004:
                    retOpt = 50;
                    break;
                case 100000000:
                    retOpt = 55;
                    break;
                case 276530005:
                    retOpt = 60;
                    break;
                case 276530006:
                    retOpt = 70;
                    break;
                case 100530010:
                    retOpt = 75;
                    break;
                case 276530007:
                    retOpt = 80;
                    break;
                case 276530008:
                    retOpt = 90;
                    break;
                case 327630000:
                    retOpt = 95;
                    break;
                case 276530009:
                    retOpt = 100;
                    break;
                case 276530010:
                    retOpt = 1;
                    break;
            }
            return retOpt;
        }
    }
}
