using Lesson2SolidPrinciples.OpenClosePrinciple.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2SolidPrinciples.OpenClosePrinciple
{
    internal class AccountViewModel
    {
        private readonly IMailService _mailService;

        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public AccountViewModel(IMailService mailService)
        {
            _mailService = mailService;
        }

        public void RegisterCommandMethod()
        {
            _mailService.SendMail(Email, "confirmation email", "some message");
        }
    }
}
