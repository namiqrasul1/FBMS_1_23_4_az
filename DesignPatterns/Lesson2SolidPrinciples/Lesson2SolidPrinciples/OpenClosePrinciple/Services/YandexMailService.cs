using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2SolidPrinciples.OpenClosePrinciple.Services
{
    internal class YandexMailService : IMailService
    {
        public bool IsValidMail(string email)
        {
            // amazing code
            // amazing code
            // amazing code
            return !string.IsNullOrWhiteSpace(email);
        }

        public void SendMail(string to, string subject, string body)
        {
            string from = "mygmail@gmail.com";
            if (IsValidMail(to))
            {
                // amazing code
                // amazing code
                // send mail
                Console.WriteLine("YandexService");

            }
            else
                throw new Exception("email is not valid");
        }
    }
}
