using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public static class EmailController
    {
        public static void SendEmail(string[] args, string messageContent, string addressMail)
        {
            string fromMail = "golesson.inc@gmail.com";
            string fromPassword = "123MuDaR";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Test Subject";
            message.To.Add(new MailAddress(addressMail));
            message.Body = messageContent;
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}
