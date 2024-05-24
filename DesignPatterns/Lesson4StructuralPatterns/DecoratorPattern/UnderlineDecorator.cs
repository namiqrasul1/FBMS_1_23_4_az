using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class UnderlineDecorator : AbstractRenderer
    {
        private AbstractRenderer renderer;

        public UnderlineDecorator(AbstractRenderer renderer)
        {
            this.renderer = renderer;
        }

        public override void RenderInformation(string info)
        {
            renderer.RenderInformation(info);
            foreach (var item in info)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }
}
