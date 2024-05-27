using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class SnakeGame : IMobileVisitor
    {
        public void Visit(MobilePhone phone)
        {
            Console.WriteLine($"{phone.Model} telefonunda ilan oyunu oynanir");
        }
    }
}
