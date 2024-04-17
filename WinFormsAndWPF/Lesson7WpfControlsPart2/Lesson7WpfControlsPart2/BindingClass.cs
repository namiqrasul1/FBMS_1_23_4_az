using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lesson7WpfControlsPart2
{
    internal class BindingClass
    {
        public string Name { get; set; }
        public SolidColorBrush BackColor { get; set; } = new(Colors.DarkMagenta);
        public void Foo()
        {
            var t = Name;
        }
    }
}
