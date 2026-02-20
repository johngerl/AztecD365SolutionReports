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
    public class SendQuoteReport : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region ContextTracing
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            #endregion
            try
            {
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                string PDFString = (string)context.InputParameters["PDFString"];
                EntityReference quoteRef = (EntityReference)context.InputParameters["Target"];
                EntityReference emailRef = (EntityReference)context.OutputParameters["EmailRef"];
                string quoteNum = (string)context.InputParameters["QuoteNumber"];
                Guid emailId = emailRef.Id;
                AddAttachmentsToEmail(service, tracingService, emailRef.Id, quoteNum + ".pdf", PDFString, "application/pdf");
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the AddAttachmentsToEmail function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the AddAttachmentsToEmail function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the AddAttachmentsToEmail function: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private void AddAttachmentsToEmail(IOrganizationService service, ITracingService tracingService, Guid emailId, string fileName, string documentBody, string mimeType)
        {
            //var body = EncodeTo64(documentBody);
            ActivityMimeAttachment emailAttachment = new ActivityMimeAttachment()
            {
                Subject = fileName + " Attachment",
                FileName = fileName,
                MimeType = mimeType,
                Body = documentBody,
                ObjectId = new EntityReference(Email.EntityLogicalName, emailId),
                ObjectTypeCode = "email"
            };
            try
            {
                service.Create(emailAttachment);
            }
            #region ErrorHandling
            catch (FaultException<OrganizationServiceFault> ex)
            {
                tracingService.Trace("An error occurred in the AddAttachmentsToEmail function: {0}", ex.ToString());
                tracingService.Trace("Error Details: {0}", ex.Detail.InnerFault.Message);
                throw new InvalidPluginExecutionException("An error occurred in the AddAttachmentsToEmail function." + ex.Detail.InnerFault.Message.ToString());
            }
            catch (Exception ex)
            {
                tracingService.Trace("An error occurred in the AddAttachmentsToEmail function: {0}", ex.ToString());
                throw;
            }
            #endregion
        }
        private string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
    }
}
