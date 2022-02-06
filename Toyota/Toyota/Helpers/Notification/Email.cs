using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toyota.Helpers.Notification
{
    public class Email
    {
        public static string ukrNet_pswd = "ZXO7voCNRwyCHkY1";
        public static string ukrNew_user = "mikeis@ukr.net";
        public static async Task SendEmailAsync(
            string email = "mikeisisyp@gmail.com", 
            string subject = "test", 
            string message = "test")
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", ukrNew_user));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message + "<br><hr>" + "<p>Вы получили письмо, потому что оставили заявку у меня на сайте</p>"
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.ukr.net", 465, true);
                await client.AuthenticateAsync(ukrNew_user, ukrNet_pswd);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
