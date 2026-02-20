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
    public class AutoNumber : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            try
            {
                IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
                if (context.MessageName == "Create")
                {
                    if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
                    {
                        #region Members
                        Guid _recordId = Guid.Empty;
                        Entity entity = (Entity)context.InputParameters["Target"];
                        string _entityLogicalName = entity.LogicalName;
                        string _entityId = _entityLogicalName + "id";
                        string _prefix = string.Empty;
                        string _suffix = string.Empty;
                        _recordId = (Guid)entity.Attributes[_entityId];
                        string _fieldToAutonumber = string.Empty;
                        #endregion
                        IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                        IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
                        #region fields
                        string[] _fields =
    {
"azt_autonumberid",
"azt_name",
"azt_fieldtoautonumber",
"azt_currentnumber",
"azt_prefix",
"azt_suffix",
"azt_prefixhasseparator",
"azt_prefixseparator",
"azt_suffixhasseparator",
"azt_suffixseparator",
"azt_prefixseparatorisspace",
"azt_suffixseparatorisspace"
};
                        #endregion
                        QueryByAttribute AutoNumberQuery = new QueryByAttribute("azt_autonumber");
                        AutoNumberQuery.ColumnSet = new ColumnSet(_fields);
                        AutoNumberQuery.Attributes.Add("azt_name");
                        AutoNumberQuery.Values.Add(_entityLogicalName);
                        EntityCollection retrievedNextNumber = service.RetrieveMultiple(AutoNumberQuery);
                        if (retrievedNextNumber.Entities.Count > 1) throw new Exception("There is more than one Auto-Number configuration record for this entity");
                        if (retrievedNextNumber.Entities.Count == 0) return;
                        foreach (Entity nn in retrievedNextNumber.Entities)
                        {
                            _fieldToAutonumber = (string)nn.Attributes["azt_fieldtoautonumber"];
                            int _currentNumber = (int)nn.Attributes["azt_currentnumber"];
                            int _newNum = _currentNumber;
                            int _nextNumber = ++_newNum;
                            #region Prefix
                            if (nn.Attributes.Contains("azt_prefix") && (string)nn.Attributes["azt_prefix"] != null)
                            {
                                if (nn.Attributes.Contains("azt_prefixhasseparator") && (bool)nn.Attributes["azt_prefixhasseparator"] == true)
                                {
                                    if (nn.Attributes.Contains("azt_prefixseparatorisspace") && (bool)nn.Attributes["azt_prefixseparatorisspace"] == true)
                                    {
                                        _prefix = (string)nn.Attributes["azt_prefix"] + " ";
                                    }
                                    else
                                    {
                                        string _prefixSeparator = (string)nn.Attributes["azt_prefixseparator"];
                                        _prefix = (string)nn.Attributes["azt_prefix"] + _prefixSeparator;
                                    }
                                }
                                else if (nn.Attributes.Contains("azt_prefixhasseparator") && (bool)nn.Attributes["azt_prefixhasseparator"] == false)
                                {
                                    _prefix = (string)nn.Attributes["azt_prefix"];
                                }
                            }
                            #endregion
                            #region Suffix
                            if (nn.Attributes.Contains("azt_suffix") && (string)nn.Attributes["azt_suffix"] != null)
                            {
                                if (nn.Attributes.Contains("azt_suffixhasseparator") && (bool)nn.Attributes["azt_suffixhasseparator"] == true)
                                {
                                    if (nn.Attributes.Contains("azt_suffixseparatorisspace") && (bool)nn.Attributes["azt_suffixseparatorisspace"] == true)
                                    {
                                        _suffix = " " + (string)nn.Attributes["azt_suffix"];
                                    }
                                    else
                                    {
                                        string _suffixSeparator = (string)nn.Attributes["azt_suffixseparator"];
                                        _suffix = _suffixSeparator + (string)nn.Attributes["azt_suffix"];
                                    }
                                }
                                else if (nn.Attributes.Contains("azt_suffixhasseparator") && (bool)nn.Attributes["azt_suffixhasseparator"] == false)
                                {
                                    _suffix = (string)nn.Attributes["azt_suffix"];
                                }
                            }
                            #endregion
                            string _autonumberedFieldValue = string.Empty;
                            _autonumberedFieldValue = _prefix + _nextNumber.ToString() + _suffix;
                            entity[_fieldToAutonumber] = _autonumberedFieldValue;

                            Entity autoNumber = new Entity("azt_autonumber");
                            autoNumber["azt_autonumberid"] = (Guid)nn.Attributes["azt_autonumberid"];
                            autoNumber["azt_currentnumber"] = _nextNumber;
                            service.Update(autoNumber);
                        }
                    }
                }
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("Error creating autonumber in the Autonumbering Plugin: {0}", ex.Detail.ToString());
                throw new InvalidPluginExecutionException("Error creating autonumber in the Autonumbering Plugin", ex);
            }
            catch (Exception ex)
            {
                tracingService.Trace("Error creating autonumber in the Autonumbering Plugin: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
    }
}
