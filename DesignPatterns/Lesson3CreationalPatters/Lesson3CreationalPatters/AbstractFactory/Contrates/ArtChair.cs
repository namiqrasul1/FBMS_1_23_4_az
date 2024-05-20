using Lesson3CreationalPatters.AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.AbstractFactory.Contrates
{
    internal class ArtChair : Chair
    {
        public override void WhoAreYou() => Console.WriteLine("Art Chair");
    }
}
