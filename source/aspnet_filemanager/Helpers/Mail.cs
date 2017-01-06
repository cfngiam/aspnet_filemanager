using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace aspnet_filemanager.Helpers
{
    public class Mail
    {
        public static void SendPasswordLinkByEmail(string email, string resetPasswordCode)
        {
            try
            {
                //MailMessage mail = new MailMessage("raphaelivo.net@gmail.com", email);
                //SmtpClient client = new SmtpClient();
                //client.Port = 465;
                //client.DeliveryMethod = SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = false;
                //client.EnableSsl = true;
                //client.Host = "smtp.gmail.com";
                //mail.Subject = "[DO NOT REPLY] - aspnet File Manager password";
                //mail.Body = "this is my test email body";
                //client.Send(mail);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}