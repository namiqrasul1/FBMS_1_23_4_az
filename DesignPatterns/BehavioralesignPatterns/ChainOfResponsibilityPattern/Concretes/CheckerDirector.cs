using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Handlers;
using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Concretes
{
    internal class CheckerDirector
    {
        public BaseChecker? MakeHumanChecker()
        {
            var checkerBuilder = new CheckerBuilder();
            checkerBuilder.SetPasswordChecker();
            checkerBuilder.SetEmailChecker();
            checkerBuilder.SetUsernameChecker();

            return checkerBuilder.MakeChecker();
            
        }
    }
}
