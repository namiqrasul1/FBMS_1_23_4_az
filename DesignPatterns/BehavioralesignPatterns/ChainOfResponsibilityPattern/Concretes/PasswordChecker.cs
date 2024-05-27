using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Concretes
{
    internal class PasswordChecker : BaseChecker
    {
        public override void Check(object request)
        {
            if(request is Human human)
            {
                if(7 < human.Password.Length)
                {
                    Console.WriteLine("Password is valid");
                    Next?.Check(request);
                }
            }
        }
    }
}
