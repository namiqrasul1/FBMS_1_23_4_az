using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.NotifierApp
{
    internal abstract class Notifier
    {
        public abstract void Send(string message);
    }
}
