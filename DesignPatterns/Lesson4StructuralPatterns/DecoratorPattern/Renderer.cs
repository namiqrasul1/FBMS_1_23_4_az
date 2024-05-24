using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Renderer : AbstractRenderer
    {
        public override void RenderInformation(string info) => Console.WriteLine(info);
    }
}
