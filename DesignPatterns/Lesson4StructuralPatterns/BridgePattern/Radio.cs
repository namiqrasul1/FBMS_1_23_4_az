using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Radio : IDevice
    {
        public bool IsEnabled { get; set; }
        public short Volume { get; set; }
        public short Channel { get; set; }
    }
}
