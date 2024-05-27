using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Concretes
{
    internal class UsernameChecker : BaseChecker
    {
        public override void Check(object request)
        {
            if (request is Human human)
            {
                if(!string.IsNullOrWhiteSpace(human.Username))
                {
                    Console.WriteLine("Username is valid");
                    Next?.Check(request);
                }
            }
        }
    }
}
