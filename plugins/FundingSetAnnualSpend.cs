using CrmContext;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AztecPlugins
{
    public class FundingSetAnnualSpend : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context/Tracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == azt_Funding.EntityLogicalName)
            {
                azt_Funding funding = ((Entity)context.InputParameters["Target"]).ToEntity<azt_Funding>();
                if (funding.Contains("azt_account") && funding.azt_Account != null)
                {
                    Guid acctId = funding.azt_Account.Id;
                    int fundingYear = (int)funding.azt_FundingYear;
                    #region Acct Query
                    string fetch =
string.Format(@"<fetch>
  <entity name='invoice'>
    <attribute name='invoiceid' />
    <attribute name='totalamount' />
    <filter>
      <condition attribute='customerid' operator='eq' value='{0}' />
      <condition attribute='statecode' operator='eq' value='2' />
      <condition attribute='azt_paidon' operator='in-fiscal-year' value='{1}' />
    </filter>
  </entity>
</fetch>", acctId, fundingYear.ToString());
                    #endregion
                    #region Service
                    IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                    IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                    #endregion
                    EntityCollection ec = service.RetrieveMultiple(new FetchExpression(fetch));
                    Money totalSpend = new Money();
                    foreach (var i in ec.Entities)
                    {
                        Money totalAmt = i.GetAttributeValue<Money>("totalamount");
                        totalSpend.Value += totalAmt.Value;
                    }
                    azt_Funding uf = new azt_Funding()
                    {
                        azt_FundingId = funding.Id,
                        azt_AnnualSpend = totalSpend
                    };
                    service.Update(uf);
                }
            }
        }
    }
}
