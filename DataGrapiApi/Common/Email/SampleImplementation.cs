using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.Common.Email
{
    public class SampleImplementation
    {
        public void Sample()
        {
            EmailModel objMailContent = new EmailModel();
            objMailContent.To = "Test";
            objMailContent.Subject = "Test";
            objMailContent.Cc = "Test";
            objMailContent.Message = "Test";

            // Use default email provider
            IEmailProvider emailProvider = new DefaultEmailProvider();
            ISendEmail objEmailDefault = new SendEmail(emailProvider);
            _ = objEmailDefault.Send(objMailContent);

            // Extent to create new Email providers
            ISendEmail objEmail = new SendEmail(new EmailProvider<GoogleEmailProvider>() as IEmailProvider);
            _ = objEmail.Send(objMailContent);
        }
    }
}
