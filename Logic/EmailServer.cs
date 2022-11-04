
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;

namespace Logic
{
    public  class EmailServer
    {
        public static void SendLoginDetailsThroughSMTP(string email, string userName, string password)
        {
            try
            {
                var builder = new ConfigurationBuilder()
                .AddJsonFile("emailConfig.json");
                var config = builder.Build();

                SmtpClient smtpCilent = new SmtpClient(config["Smtp:Host"])
                {
                    Port = int.Parse(config["Smtp:Port"]),
                    Credentials = new NetworkCredential(config["Smtp:Email"], config["Smtp:Password"]),
                    EnableSsl = true,
                };

                smtpCilent.Send(config["Smtp:Email"], email, "YourLoginDetails", $"Here are your LoginDetails username: {userName} password: {password}");
                smtpCilent.Dispose();

            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Unable to find the email config file");
            }
            catch (SmtpFailedRecipientsException ) 
            {
                throw new SmtpFailedRecipientsException($"Unable to send email to {email}");
            }
            catch(Exception exp )
            {

            }
        }
    }
}
