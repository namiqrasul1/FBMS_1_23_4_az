using Lesson3CreationalPatters.FactoryMethod.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.FactoryMethod.Conrates
{
    internal class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by land");
        }
    }
}
