using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Services
{
    internal interface IMailService
    {
        bool IsValid(string email);
        void Send(string email, string subject, string message);
    }
}
