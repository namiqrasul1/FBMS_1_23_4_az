using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2SolidPrinciples.OpenClosePrinciple.Services
{
    internal interface IMailService
    {
        bool IsValidMail(string mail);
        void SendMail(string to, string subject, string body);
    }
}
