using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal interface IMobileVisitor
    {
        void Visit(MobilePhone phone);
    }
}
