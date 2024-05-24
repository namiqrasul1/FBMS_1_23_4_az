using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Folder : ISystemFile
    {
        public Folder(string name, string path)
        {
            Name = name;
            Path = path;
            Items = [];
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public List<ISystemFile> Items { get; set; }

        public double Size
        {
            get
            {
                double size = 0;   
                Items.ForEach(i => size += i.Size);
                return size;
            }

        }

        public void Add(ISystemFile item) => Items.Add(item);
        public void Remove(ISystemFile item) => Items.Remove(item);
       
    }
}
