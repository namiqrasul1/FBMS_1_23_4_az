using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal class MobilePhone(string model)
    {
        public string Model { get; set; } = model;

        public void Accept(IMobileVisitor visitor) => visitor.Visit(this);
    }
}
