using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    internal class Tree
    {
        public Tree(int x, int y, string color, string texture, string name)
        {
            X = x;
            Y = y;
            TreeType = TreeFactory.GetTreeType(name, color, texture);
        }

        public int X { get; set; }
        public int Y { get; set; }

        public TreeType TreeType { get; set; }

    }
}
