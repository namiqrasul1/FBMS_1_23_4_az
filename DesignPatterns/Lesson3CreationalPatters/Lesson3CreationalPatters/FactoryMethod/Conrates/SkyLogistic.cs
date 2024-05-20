using Lesson3CreationalPatters.FactoryMethod.Abstacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.FactoryMethod.Conrates
{
    internal class SkyLogistic : Logistic
    {
        public override void PlanDelivery() => Console.WriteLine("Sky Delivery");
        public override ITransport CreateTranport() => new Airplane();
    }
}
