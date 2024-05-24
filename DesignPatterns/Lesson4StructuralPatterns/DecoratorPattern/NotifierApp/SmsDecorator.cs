using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.NotifierApp
{
    internal class SmsDecorator(Notifier? notifier = null) : BaseDecorator(notifier)
    {
        public override void Send(string message)
        {
            notifier?.Send(message);
            Console.WriteLine($"Sms: {message}");
        }
    }
}
