using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3CreationalPatters.PrototypePattern
{
    class Product : ICloneable //, IPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public object Clone() => new Product { Id = Id, Name = Name, Description = Description };


        //public IPrototype Clone()
        //{
        //    return new Product { Id = Id, Name = Name, Description = Description };
        //}
    }
}
