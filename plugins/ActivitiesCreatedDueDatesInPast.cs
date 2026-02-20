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
    public class ActivitiesCreatedDueDatesInPast : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName == "Create" && context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                if (((Entity)context.InputParameters["Target"]).LogicalName == PhoneCall.EntityLogicalName)
                {
                    Entity phonecall = (Entity)context.InputParameters["Target"];
                    if (!phonecall.Attributes.Contains("scheduledend")) return;
                    DateTime due = (DateTime)phonecall.Attributes["scheduledend"];
                    if (IsOld(due)) throw new InvalidPluginExecutionException("This activity has a due date in the past!!");
                }
                if (((Entity)context.InputParameters["Target"]).LogicalName == CrmContext.Task.EntityLogicalName)
                {
                    Entity task = (Entity)context.InputParameters["Target"];
                    if (!task.Attributes.Contains("scheduledend")) return;
                    DateTime due = (DateTime)task.Attributes["scheduledend"];
                    if (IsOld(due)) throw new InvalidPluginExecutionException("This activity has a due date in the past!!");
                }
                if (((Entity)context.InputParameters["Target"]).LogicalName == Appointment.EntityLogicalName)
                {
                    Entity appointment = (Entity)context.InputParameters["Target"];
                    if (!appointment.Attributes.Contains("scheduledend")) return;
                    DateTime due = (DateTime)appointment.Attributes["scheduledend"];
                    if (IsOld(due)) throw new InvalidPluginExecutionException("This activity has a due date in the past!!");
                }
            }
        }
        private bool IsOld(DateTime due)
        {
            bool IsOld = false;
            DateTime oldDate = DateTime.Today.AddDays(-7);
            int old = DateTime.Compare(due, oldDate);
            if (old < 0) IsOld = true;
            return IsOld;
        }
    }
}
