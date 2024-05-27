using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    internal class OracleSqlEngine : SqlEngine
    {
        public override void Connect()
        {
            Console.WriteLine("Has been connected with Oracle");
        }

        public override void Disconnect()
        {
            Console.WriteLine("Has been disconnected with Oracle");
        }

        public override void Execute(string command)
        {
            Console.WriteLine($"Executed {command} on Oracle");
        }
    }
}
