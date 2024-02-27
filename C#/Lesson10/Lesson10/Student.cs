using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BDay { get; set; }


        public override string ToString() => $"{Name} {Surname} {BDay}";
    }
}
