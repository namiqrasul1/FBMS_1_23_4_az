using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2SolidPrinciples.OpenClosePrinciple.Services
{
    internal class YahooMailService : IMailService
    {
        public bool IsValidMail(string mail)
        {
            throw new NotImplementedException();
        }

        public void SendMail(string to, string subject, string body)
        {
                Console.WriteLine("YahooService");

        }
    }
}
