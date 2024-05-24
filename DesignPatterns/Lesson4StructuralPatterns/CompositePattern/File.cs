using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class File : ISystemFile // leaf
    {
        public File(string name, string path, double size)
        {
            Name = name;
            Path = path;
            Size = size;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public double Size { get; set; }
    }
}
