using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Simbelmawa.Email
{
    public class SmtpEmailSender : IEmailSender
    {
        public SmtpEmailSender(string host, int port, bool enableSsl, string userName, string password)
        {
            Host = host;
            Port = port;
            EnableSsl = enableSsl;
            UserName = userName;
            Password = password;
        }

        public string Password { get; set; }

        public string UserName { get; set; }

        public bool EnableSsl { get; set; }

        public int Port { get; set; }

        public string Host { get; set; }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(Host, Port)
            {
                Credentials = new NetworkCredential(UserName, Password),
                EnableSsl = EnableSsl
            };

            return client.SendMailAsync(
                new MailMessage(UserName, email, subject, htmlMessage) {IsBodyHtml = true}
            );
        }
    }
}
