using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Services
{
    internal class GmailService : IMailService
    {
        public bool IsValid(string email) { return true; }
        public void Send(string email, string subject, string message) { }
        // SOLID 
    }
}
