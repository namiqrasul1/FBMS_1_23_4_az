using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkWater.Models
{
    internal class User
    {
        public string Name { get; set; } = default!;
        public double Weight { get; set; }
        public double AvgLitr => Weight / 20;
        public List<DateInfo> History { get; set; } = new();
        public DateInfo Current { get; set; }


    }
}
