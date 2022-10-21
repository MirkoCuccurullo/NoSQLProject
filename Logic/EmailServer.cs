using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public  class EmailServer
    {
        public static void SendLoginDetailsThroughSMTP(string email, string userName, string password)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("sapkotabijay1313@gmail.com", "vtcrandygtyvkvev"),
                EnableSsl = true,
            };
            smtpClient.Send("sapkotabijay1313@gmail.com", email, "YourLoginDetails", $"Here are your LoginDetails username: {userName} password: {password}");
            smtpClient.Dispose();
        }
    }
}
