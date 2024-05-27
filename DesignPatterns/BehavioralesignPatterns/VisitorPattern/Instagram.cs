using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class Instagram : IMobileVisitor
    {
        public void Visit(MobilePhone phone)
        {
            Console.WriteLine($"{phone.Model} telefonunda instagrama girildi");
        }
    }
}
