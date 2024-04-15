using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6WpfControls.Models
{
    public class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString() => $"{Vendor} {Model} {Year}";
    }
}
