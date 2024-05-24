using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal interface IDevice
    {
        bool IsEnabled { get; set; }
        short Volume { get; set; }
        short Channel { get; set; }
    }
}
