using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    internal class MsSqlEngine : SqlEngine
    {
        public override void Connect()
        {
            Console.WriteLine("Has been connected with MsSql");
        }

        public override void Disconnect()
        {
            Console.WriteLine("Has been disconnected with MsSql");
        }

        public override void Execute(string command)
        {
            Console.WriteLine($"Executed {command} on MsSql");
        }
    }
}
