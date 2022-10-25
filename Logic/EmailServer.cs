using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Logic
{
    public  class EmailServer
    {
        public static void SendLoginDetailsThroughSMTP(string email, string userName, string password)
        {

            var builder = new ConfigurationBuilder()
                .AddJsonFile("emailConfig.json");
            var config = builder.Build();

            var smtpClient = new SmtpClient(config["Smtp:Host"])
            {
                Port = int.Parse(config["Smtp:Port"]),
                Credentials = new NetworkCredential(config["Smtp:Email"], config["Smtp:Password"]),
                EnableSsl = true,
            };

            smtpClient.Send(config["Smtp:Email"], email, "YourLoginDetails", $"Here are your LoginDetails username: {userName} password: {password}");
            smtpClient.Dispose();
        }
    }
}
