using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkWater.Models
{
    internal class DateInfo
    {
        public DateOnly Date { get; set; }
        public double Litr { get; set; }

        public DateInfo Clone() => new DateInfo { Date = Date, Litr = Litr };

        public override string ToString() => $"Date: {Date} Litr: {Litr}";
    }
}
