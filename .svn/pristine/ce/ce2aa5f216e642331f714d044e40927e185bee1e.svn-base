using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Web;
using Umbraco.Core.Logging;

namespace OneContact.BusinessLogic
{
    public class Mail
    {
        public static bool SendMail(MailVariables mailVariables)
        {
            try
            {
                var mailMsg = new System.Net.Mail.MailMessage
                {
                    From = new System.Net.Mail.MailAddress(HttpUtility.HtmlEncode(mailVariables.From), HttpUtility.HtmlEncode(mailVariables.FromName)),
                    Subject = mailVariables.Subject,
                    Body = mailVariables.Content,
                    IsBodyHtml = true
                };

                mailMsg.To.Add(new System.Net.Mail.MailAddress(HttpUtility.HtmlEncode(mailVariables.To), HttpUtility.HtmlEncode(mailVariables.ToName)));
                
                if(mailVariables.ReplyTo != null)
                    mailMsg.ReplyToList.Add(new System.Net.Mail.MailAddress(mailVariables.ReplyTo));

                var smtpClient = new System.Net.Mail.SmtpClient { EnableSsl = mailVariables.EnableSsl };
                
                // If PickupDirectory is relative, change it to absolute
                if(smtpClient.PickupDirectoryLocation != null && System.IO.Path.IsPathRooted(smtpClient.PickupDirectoryLocation) == false)
                    smtpClient.PickupDirectoryLocation = HttpContext.Current.Server.MapPath(smtpClient.PickupDirectoryLocation);

                smtpClient.Send(mailMsg);

                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error<Mail>("Error creating or sending contact mail, check if the is a mailFrom property has a value.", ex);
            }

            return false;
        }

        public class MailVariables
        {
            public string Content { get; set; }
            public string Subject { get; set; }
            public string To { get; set; }
            public string ToName { get; set; }
            public string From { get; set; }
            public string FromName { get; set; }
            public string ReplyTo { get; set; }
            public bool EnableSsl { get; set; }
        }
    }

    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute() : base("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,4})$") { }
        
    }
}