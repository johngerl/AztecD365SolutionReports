using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmContext;
using Microsoft.Xrm.Sdk.Query;
using System.ServiceModel;
namespace AztecPlugins
{
    public class AccountTypeSet : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Context/Tracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            if (context.MessageName == "Update" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity && ((Entity)context.InputParameters["Target"]).LogicalName == Account.EntityLogicalName)
            {
                try
                {
                    Account account = ((Entity)context.InputParameters["Target"]).ToEntity<Account>();
                    if (account.Attributes.Contains("azt_nonsaasstatus") || account.Attributes.Contains("azt_saasstatus"))
                    {
                        #region Service
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #endregion
                        Account postAccount = ((Entity)context.PostEntityImages["PostAccountType"]).ToEntity<Account>();
                        if (account.Attributes.Contains("azt_saasstatus") && account.Attributes.Contains("azt_nonsaasstatus"))
                        {
                            OptionSetValue saasStatus = account.GetAttributeValue<OptionSetValue>("azt_saasstatus");
                            OptionSetValue printStatus = account.GetAttributeValue<OptionSetValue>("azt_nonsaasstatus");

                            OptionSetValue acctStatus = GetAcctStatus(tracingService, saasStatus, printStatus);
                            Account a = new Account()
                            {
                                AccountId = account.Id,
                                azt_AccountType = acctStatus
                            };
                            service.Update(a);
                        }
                        if (account.Attributes.Contains("azt_saasstatus") && !account.Attributes.Contains("azt_nonsaasstatus"))
                        {
                            OptionSetValue saasStatus = account.GetAttributeValue<OptionSetValue>("azt_saasstatus");
                            OptionSetValue printStatus = postAccount.GetAttributeValue<OptionSetValue>("azt_nonsaasstatus");

                            OptionSetValue acctStatus = GetAcctStatus(tracingService, saasStatus, printStatus);
                            Account a = new Account()
                            {
                                AccountId = account.Id,
                                azt_AccountType = acctStatus
                            };
                            service.Update(a);
                        }
                        if (!account.Attributes.Contains("azt_saasstatus") && account.Attributes.Contains("azt_nonsaasstatus"))
                        {
                            OptionSetValue saasStatus = postAccount.GetAttributeValue<OptionSetValue>("azt_saasstatus");
                            OptionSetValue printStatus = account.GetAttributeValue<OptionSetValue>("azt_nonsaasstatus");

                            OptionSetValue acctStatus = GetAcctStatus(tracingService, saasStatus, printStatus);
                            Account a = new Account()
                            {
                                AccountId = account.Id,
                                azt_AccountType = acctStatus
                            };
                            service.Update(a);
                        }
                    }
                }
                #region ErrorHandling
                catch (FaultException<OrganizationServiceFault> ex)
                {
                    tracingService.Trace("Error calculating Expense Amounts in the AccountTypeSet Plugin: {0}", ex.Detail.ToString());
                    throw new InvalidPluginExecutionException("Error calculating Expense Amounts in the AccountTypeSet Plugin", ex);
                }
                catch (Exception ex)
                {
                    tracingService.Trace("Error in the AccountTypeSet Plugin: {0}", ex.ToString());
                    throw;
                }
                #endregion
            }
        }
        private OptionSetValue GetAcctStatus(ITracingService tracingService, OptionSetValue saasStatus, OptionSetValue printStatus)
        {
            OptionSetValue acctStatus = new OptionSetValue();
            try
            {
                //SaaS Active or Pilot OR Print is Current or Matured
                if ((saasStatus != null && (saasStatus.Value == 327630000 || saasStatus.Value == 327630002)) || (printStatus != null && (printStatus.Value == 327630000 || printStatus.Value == 327630001)))
                {
                    acctStatus = new OptionSetValue(276530000);
                }
                else if ((saasStatus != null && saasStatus.Value == 327630001) || (printStatus != null && printStatus.Value == 327630002))
                {
                    acctStatus = new OptionSetValue(276530001);
                }
                else
                {
                    acctStatus = new OptionSetValue(276530007);
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error calculating Expense Amounts in the AccountTypeSet Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error calculating Expense Amounts in the AccountTypeSet Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error in the AccountTypeSet Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
            return acctStatus;
        }
    }
}
