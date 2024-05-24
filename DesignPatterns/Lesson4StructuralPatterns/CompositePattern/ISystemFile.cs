using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal interface ISystemFile // component
    {
        string Name { get; set; }
        string Path { get; set; }
        double Size { get; }

    }
}
