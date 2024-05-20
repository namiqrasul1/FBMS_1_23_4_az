using Lesson3CreationalPatters.AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.AbstractFactory.Contrates
{
    internal class ModernFurnitureFactory : IFurnitureFacotry
    {
        public Chair CreateChair() => new ModernChair();

        public Sofa CreateSofa() => new ModernSofa();
    }
}
