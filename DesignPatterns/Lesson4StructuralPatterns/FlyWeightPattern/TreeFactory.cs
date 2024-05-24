using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    internal class TreeFactory
    {
        static readonly List<TreeType> types = [];

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var type = types.FirstOrDefault(t => t.Name == name && t.Color == color && t.Texture == texture);
            if(type is null)
            {
                type = new TreeType { Name = name, Color = color, Texture = texture };
                types.Add(type);
            }
            return type;
        }
    }
}
