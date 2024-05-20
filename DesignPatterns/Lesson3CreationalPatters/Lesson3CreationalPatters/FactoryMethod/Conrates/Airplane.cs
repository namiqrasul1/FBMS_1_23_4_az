using Lesson3CreationalPatters.FactoryMethod.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.FactoryMethod.Conrates
{
    internal class Airplane : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by sky");
        }
    }
}
