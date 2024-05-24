using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.NotifierApp
{
    internal abstract class BaseDecorator : Notifier
    {
        protected Notifier? notifier;

        protected BaseDecorator(Notifier? notifier = null)
        {
            this.notifier = notifier;
        }
    }
}
