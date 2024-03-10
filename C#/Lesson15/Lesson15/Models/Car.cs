using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Models
{
    internal class Car
    {
        public int MyProperty { get; set; }
        public User User { get; set; }

        public Car(int myProperty)
        {
            MyProperty = myProperty;
        }
    }
}
