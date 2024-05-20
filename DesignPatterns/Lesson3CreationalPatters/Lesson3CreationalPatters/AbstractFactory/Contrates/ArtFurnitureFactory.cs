using Lesson3CreationalPatters.AbstractFactory.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.AbstractFactory.Contrates
{
    internal class ArtFurnitureFactory : IFurnitureFacotry
    {
        public Chair CreateChair() => new ArtChair();

        public Sofa CreateSofa() => new ArtSofa();
    }
}
