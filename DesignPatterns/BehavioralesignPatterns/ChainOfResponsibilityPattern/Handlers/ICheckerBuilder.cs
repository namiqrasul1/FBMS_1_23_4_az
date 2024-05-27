using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Handlers
{
    internal class CheckerBuilder
    {
        BaseChecker? Checker { get; set; }
        
        public CheckerBuilder SetUsernameChecker()
        {
            var checker = Checker;
            Checker = new UsernameChecker
            {
                Next = checker
            };
            return this;
        }

        public CheckerBuilder SetEmailChecker()
        {
            var checker = Checker;
            Checker = new EmailChecker
            {
                Next = checker
            };
            return this;
        }

        public CheckerBuilder SetPasswordChecker()
        {
            var checker = Checker;
            Checker = new PasswordChecker
            {
                Next = checker
            };
            return this;
        }

        public BaseChecker? MakeChecker() => Checker;

        public void Reset() => Checker = null;
    }
}
