using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class RemoteController
    {
        public RemoteController(IDevice device)
        {
            Device = device;
        }

        public IDevice Device { get; set; }

        public void TogglePower()
        {
            Device.IsEnabled = !Device.IsEnabled;
        }

        public void VolumeUp()
        {
            if (Device.Volume < 100)
                Device.Volume++;
        }
        public void VolumeDown()
        {
            if (Device.Volume > 0)
                Device.Volume--;
        }

        public void ChannelUp()
        {
            Device.Channel++;
        }
        public void ChannelDown()
        {
            Device.Channel--;
        }
    }
}
