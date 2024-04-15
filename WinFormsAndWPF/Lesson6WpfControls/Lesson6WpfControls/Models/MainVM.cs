using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6WpfControls.Models
{
    public class MainVM
    {
        public ObservableCollection<Car> Cars { get; set; } = new()
        {
            new Car{ Vendor = "Nissan", Model ="Skyline R34", Year = 1999 },
            new Car{ Vendor = "Toyota", Model ="Supra Mk-4", Year = 1999 },
            new Car{ Vendor = "Ford", Model ="Mustang Shelby", Year = 1963 },
        };
    }
}
