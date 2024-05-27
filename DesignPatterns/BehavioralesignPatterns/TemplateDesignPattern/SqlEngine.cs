using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    internal abstract class SqlEngine
    {
        public abstract void Connect();
        public abstract void Disconnect();
        public abstract void Execute(string command);

        public void TemplateMethod(string command)
        {
            Connect();
            Execute(command);
            Disconnect();
        }
    }
}
