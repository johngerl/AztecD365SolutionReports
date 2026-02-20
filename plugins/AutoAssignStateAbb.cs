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
    public class AutoAssignStateAbb : IPlugin
    {
        private static List<KeyValuePair<string, string>> states = new List<KeyValuePair<string, string>>();
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                #region Tracing
                ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
                IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
                #endregion
                PopulateStates();
                if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
                {
                    #region Create
                    if (context.MessageName == "Create" || context.MessageName == "Update")
                    {
                        #region Address
                        if (((Entity)context.InputParameters["Target"]).LogicalName == "customeraddress")
                        {
                            Entity add = (Entity)context.InputParameters["Target"];
                            if (add.Attributes.Contains("stateorprovince"))
                            {
                                string stateOrProvince = add.GetAttributeValue<string>("stateorprovince");

                                string newState = GetNewState(stateOrProvince.ToUpper());
                                if (newState != string.Empty && newState != null)
                                {
                                    add["stateorprovince"] = newState;
                                }
                            }
                        }
                        #endregion
                        #region Others
                        //if (((Entity)context.InputParameters["Target"]).LogicalName == "account")
                        else
                        {
                            Entity acct = (Entity)context.InputParameters["Target"];
                            if (acct.Attributes.Contains("address1_stateorprovince"))
                            {
                                string stateOrProvince = acct.GetAttributeValue<string>("address1_stateorprovince");

                                string newState = GetNewState(stateOrProvince.ToUpper());
                                if (newState != string.Empty)
                                {
                                    acct["address1_stateorprovince"] = newState;
                                }
                                ////var v = d.FirstOrDefault(x => x.Value == "mystring");
                                //var rDVP = states.SingleOrDefault(x => x.Value == stateOrProvince.ToUpper());

                                //var replacedDVP = states.Where(kvp => kvp.Key == stateOrProvince.ToUpper());
                                //if(rDVP.Count() > 0)
                                //{
                                //    string newState = rDVP.SingleOrDefault().Value;
                                //    acct["address1_stateorprovince"] = newState;
                                //}
                            }
                        }
                        #endregion
                    }
                    #endregion
                    //#region Update
                    //else if (context.MessageName == "Update")
                    //{
                    //    #region Address
                    //    if (((Entity)context.InputParameters["Target"]).LogicalName == "customeraddress")
                    //    {
                    //        Entity add = (Entity)context.InputParameters["Target"];
                    //        if (add.Attributes.Contains("stateorprovince"))
                    //        {
                    //            string stateOrProvince = add.GetAttributeValue<string>("stateorprovince");

                    //            string newState = GetNewState(stateOrProvince.ToUpper());
                    //            if (newState != string.Empty)
                    //            {
                    //                add["stateorprovince"] = newState;
                    //            }
                    //        }
                    //    }
                    //    #endregion
                    //}
                    //#endregion
                }
            }
            #region Exception
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
        }
        private string GetNewState(string inputStateUpper)
        {
            string ret = string.Empty;
            try
            {
                foreach (var i in states)
                {
                    if (i.Key.Trim() == inputStateUpper.Trim())
                        return i.Value;
                }
            }
            #region Exception
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
            return ret;
        }
        private void PopulateStates()
        {
            try
            {
                states.Add(new KeyValuePair<string, string>("ALABAMA", "AL"));
                states.Add(new KeyValuePair<string, string>("ALASKA", "AK"));
                states.Add(new KeyValuePair<string, string>("ARIZONA ", "AZ"));
                states.Add(new KeyValuePair<string, string>("ARKANSAS", "AR"));
                states.Add(new KeyValuePair<string, string>("CALIFORNIA ", "CA"));
                states.Add(new KeyValuePair<string, string>("COLORADO ", "CO"));
                states.Add(new KeyValuePair<string, string>("CONNECTICUT", "CT"));
                states.Add(new KeyValuePair<string, string>("DELAWARE", "DE"));
                states.Add(new KeyValuePair<string, string>("DISTRICT OF COLUMBIA", "DC"));
                states.Add(new KeyValuePair<string, string>("FLORIDA", "FL"));
                states.Add(new KeyValuePair<string, string>("GEORGIA", "GA"));
                states.Add(new KeyValuePair<string, string>("HAWAII", "HI"));
                states.Add(new KeyValuePair<string, string>("IDAHO", "ID"));
                states.Add(new KeyValuePair<string, string>("ILLINOIS", "IL"));
                states.Add(new KeyValuePair<string, string>("INDIANA", "IN"));
                states.Add(new KeyValuePair<string, string>("IOWA", "IA"));
                states.Add(new KeyValuePair<string, string>("KANSAS", "KS"));
                states.Add(new KeyValuePair<string, string>("KENTUCKY", "KY"));
                states.Add(new KeyValuePair<string, string>("LOUISIANA", "LA"));
                states.Add(new KeyValuePair<string, string>("MAINE", "ME"));
                states.Add(new KeyValuePair<string, string>("MARYLAND", "MD"));
                states.Add(new KeyValuePair<string, string>("MASSACHUSETTS", "MA"));
                states.Add(new KeyValuePair<string, string>("MICHIGAN", "MI"));
                states.Add(new KeyValuePair<string, string>("MINNESOTA", "MN"));
                states.Add(new KeyValuePair<string, string>("MISSISSIPPI", "MS"));
                states.Add(new KeyValuePair<string, string>("MISSOURI", "MO"));
                states.Add(new KeyValuePair<string, string>("MONTANA", "MT"));
                states.Add(new KeyValuePair<string, string>("NEBRASKA", "NE"));
                states.Add(new KeyValuePair<string, string>("NEVADA", "NV"));
                states.Add(new KeyValuePair<string, string>("NEW HAMPSHIRE", "NH"));
                states.Add(new KeyValuePair<string, string>("NEW JERSEY", "NJ"));
                states.Add(new KeyValuePair<string, string>("NEW MEXICO", "NM"));
                states.Add(new KeyValuePair<string, string>("NEW YORK", "NY"));
                states.Add(new KeyValuePair<string, string>("NORTH CAROLINA", "NC"));
                states.Add(new KeyValuePair<string, string>("NORTH DAKOTA", "ND"));
                states.Add(new KeyValuePair<string, string>("OHIO", "OH"));
                states.Add(new KeyValuePair<string, string>("OKLAHOMA", "OK"));
                states.Add(new KeyValuePair<string, string>("OREGON", "OR"));
                states.Add(new KeyValuePair<string, string>("PENNSYLVANIA", "PA"));
                states.Add(new KeyValuePair<string, string>("RHODE ISLAND", "RI"));
                states.Add(new KeyValuePair<string, string>("SOUTH CAROLINA", "SC"));
                states.Add(new KeyValuePair<string, string>("SOUTH DAKOTA", "SD"));
                states.Add(new KeyValuePair<string, string>("TENNESSEE", "TN"));
                states.Add(new KeyValuePair<string, string>("TEXAS", "TX"));
                states.Add(new KeyValuePair<string, string>("UTAH", "UT"));
                states.Add(new KeyValuePair<string, string>("VERMONT", "VT"));
                states.Add(new KeyValuePair<string, string>("VIRGINIA ", "VA"));
                states.Add(new KeyValuePair<string, string>("WASHINGTON", "WA"));
                states.Add(new KeyValuePair<string, string>("WEST VIRGINIA", "WV"));
                states.Add(new KeyValuePair<string, string>("WISCONSIN", "WI"));
                states.Add(new KeyValuePair<string, string>("WYOMING", "WY"));
            }
            #region Exception
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.Message);
            }
            #endregion
        }
    }
}
