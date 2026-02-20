using CrmContext;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AztecPlugins
{
    public class FundingTotalAmt : IPlugin
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
                string Tfed = "azt_federalfundingamount";
                string Tsta = "azt_statefundingamount";
                string Toth = "azt_otherfundingamount";

                Money fed = funding.GetAttributeValue<Money>(Tfed);
                Money sta = funding.GetAttributeValue<Money>(Tsta);
                Money oth = funding.GetAttributeValue<Money>(Toth);

                Money fedTotal = new Money();
                Money staTotal = new Money();
                Money othTotal = new Money();

                Money total = new Money();

                azt_Funding postFunding = ((Entity)context.PostEntityImages["PostFunding"]).ToEntity<azt_Funding>();
                if (funding.Contains(Tfed) || funding.Contains(Tsta) || funding.Contains(Toth))
                {
                    if (funding.Contains(Tfed) && !funding.Contains(Tsta) && !funding.Contains(Toth))
                    {
                        fedTotal = funding.GetAttributeValue<Money>(Tfed) != null ? funding.GetAttributeValue<Money>(Tfed) : new Money(0);
                        staTotal = postFunding.GetAttributeValue<Money>(Tsta) != null ? postFunding.GetAttributeValue<Money>(Tsta) : new Money(0);
                        othTotal = postFunding.GetAttributeValue<Money>(Toth) != null ? postFunding.GetAttributeValue<Money>(Toth) : new Money(0);
                        total.Value = fedTotal.Value += staTotal.Value += othTotal.Value;

                        //total.Value += funding.GetAttributeValue<Money>(Tfed).Value += postFunding.GetAttributeValue<Money>(Tsta).Value += postFunding.GetAttributeValue<Money>(Toth).Value;
                    }
                    if (funding.Contains(Tfed) && funding.Contains(Tsta) && !funding.Contains(Toth))
                    {
                        fedTotal = funding.GetAttributeValue<Money>(Tfed) != null ? funding.GetAttributeValue<Money>(Tfed) : new Money(0);
                        staTotal = funding.GetAttributeValue<Money>(Tsta) != null ? funding.GetAttributeValue<Money>(Tsta) : new Money(0);
                        othTotal = postFunding.GetAttributeValue<Money>(Toth) != null ? postFunding.GetAttributeValue<Money>(Toth) : new Money(0);
                        total.Value = fedTotal.Value += staTotal.Value += othTotal.Value;

                        //total.Value = funding.GetAttributeValue<Money>(Tfed).Value += funding.GetAttributeValue<Money>(Tsta).Value += postFunding.GetAttributeValue<Money>(Toth).Value;
                    }
                    if (funding.Contains(Tfed) && funding.Contains(Tsta) && funding.Contains(Toth))
                    {
                        fedTotal = funding.GetAttributeValue<Money>(Tfed) != null ? funding.GetAttributeValue<Money>(Tfed) : new Money(0);
                        staTotal = funding.GetAttributeValue<Money>(Tsta) != null ? funding.GetAttributeValue<Money>(Tsta) : new Money(0);
                        othTotal = funding.GetAttributeValue<Money>(Toth) != null ? funding.GetAttributeValue<Money>(Toth) : new Money(0);
                        total.Value = fedTotal.Value += staTotal.Value += othTotal.Value;

                        //total.Value = funding.GetAttributeValue<Money>(Tfed).Value += funding.GetAttributeValue<Money>(Tsta).Value += funding.GetAttributeValue<Money>(Toth).Value;
                    }
                        

                    if (!funding.Contains(Tfed) && !funding.Contains(Tsta) && funding.Contains(Toth))
                    {
                        fedTotal = postFunding.GetAttributeValue<Money>(Tfed) != null ? postFunding.GetAttributeValue<Money>(Tfed) : new Money(0);
                        staTotal = postFunding.GetAttributeValue<Money>(Tsta) != null ? postFunding.GetAttributeValue<Money>(Tsta) : new Money(0);
                        othTotal = funding.GetAttributeValue<Money>(Toth) != null ? funding.GetAttributeValue<Money>(Toth) : new Money(0);
                        total.Value = fedTotal.Value += staTotal.Value += othTotal.Value;

                        //total.Value = postFunding.GetAttributeValue<Money>(Tfed).Value += postFunding.GetAttributeValue<Money>(Tsta).Value += funding.GetAttributeValue<Money>(Toth).Value;
                    }
                        
                    if (!funding.Contains(Tfed) && funding.Contains(Tsta) && !funding.Contains(Toth))
                    {
                        fedTotal = postFunding.GetAttributeValue<Money>(Tfed) != null ? postFunding.GetAttributeValue<Money>(Tfed) : new Money(0);
                        staTotal = funding.GetAttributeValue<Money>(Tsta) != null ? funding.GetAttributeValue<Money>(Tsta) : new Money(0);
                        othTotal = postFunding.GetAttributeValue<Money>(Toth) != null ? postFunding.GetAttributeValue<Money>(Toth) : new Money(0);
                        total.Value = fedTotal.Value += staTotal.Value += othTotal.Value;

                        //total.Value = postFunding.GetAttributeValue<Money>(Tfed).Value += funding.GetAttributeValue<Money>(Tsta).Value += postFunding.GetAttributeValue<Money>(Toth).Value;
                    }
                        
                    if (!funding.Contains(Tfed) && funding.Contains(Tsta) && funding.Contains(Toth))
                    {
                        fedTotal = postFunding.GetAttributeValue<Money>(Tfed) != null ? postFunding.GetAttributeValue<Money>(Tfed) : new Money(0);
                        staTotal = funding.GetAttributeValue<Money>(Tsta) != null ? funding.GetAttributeValue<Money>(Tsta) : new Money(0);
                        othTotal = funding.GetAttributeValue<Money>(Toth) != null ? funding.GetAttributeValue<Money>(Toth) : new Money(0);
                        total.Value = fedTotal.Value += staTotal.Value += othTotal.Value;
                    }
                        

                    if (funding.Contains(Tfed) && !funding.Contains(Tsta) && funding.Contains(Toth))
                        total.Value = funding.GetAttributeValue<Money>(Tfed).Value += postFunding.GetAttributeValue<Money>(Tsta).Value += funding.GetAttributeValue<Money>(Toth).Value;
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    azt_Funding uf = new azt_Funding()
                    {
                        azt_FundingId = funding.Id,
                        azt_TotalFunding = total
                    };
                    service.Update(uf);
                }
            }
        }
    }
}
