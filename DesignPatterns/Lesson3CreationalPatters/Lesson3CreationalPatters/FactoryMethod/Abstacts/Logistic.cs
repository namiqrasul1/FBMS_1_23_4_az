using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.FactoryMethod.Abstacts
{
    internal abstract class Logistic 
    {
        public virtual void PlanDelivery() { }
        public abstract ITransport CreateTranport();
    }
}
