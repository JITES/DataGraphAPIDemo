using DataGrapiApi.Common.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DataGrapiApi.Common.Email
{
    public class SendEmail : ISendEmail
    {
        private readonly IEmailProvider _smtp;
        private EmailModel _emailModel;
        private readonly SmtpClient client = new SmtpClient();

        public SendEmail(IEmailProvider provider)
        {
            this._smtp = provider;

            client.Port = _smtp.Port;
            client.Host = _smtp.Host;
            client.EnableSsl = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(_smtp.Server, _smtp.Password);
        }
        public string Send(EmailModel emailModel)
        {
            this._emailModel = emailModel;

            MailAddress from = new MailAddress("admin@gmail.com");
            MailMessage message = new MailMessage();

            message.From = from;
            string[] allAddress = _emailModel.To.Split(';');
            if (allAddress.Count() > 1)
            {
                foreach (var item in allAddress.ToList())
                {
                    message.To.Add(item);
                }
            }
            else
            {
                message.To.Add(_emailModel.To);
            }

            message.Subject = _emailModel.Subject;
            message.Body = _emailModel.Message;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            try
            {
                client.Send(message);
            }
            catch (Exception)
            {
                return "Failed";
            }
            finally
            {
                message.Dispose();
            }
            return Constants.EmailSuccess;
        }

        
    }
}

