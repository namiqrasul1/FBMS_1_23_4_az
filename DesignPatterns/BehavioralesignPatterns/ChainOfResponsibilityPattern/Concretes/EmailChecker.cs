using ChainOfResponsibilityPattern.Abstracts;
using ChainOfResponsibilityPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Concretes
{
    internal class EmailChecker : BaseChecker
    {
        public override void Check(object request)
        {
            if (request is Human human)
            {
                if(human.Email.Contains('@') && human.Email.Contains('.'))
                {
                    Console.WriteLine("Email is valid");
                    Next?.Check(request);

                }
                else
                {
                    Console.WriteLine("Email is not valid");
                }

            }
        }
    }
}
