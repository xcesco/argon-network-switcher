using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Argon.Network
{
    public class WifiProfile
    {
        public string Name { get; set; }

        public string Xml { get; set; }

        public string InterfaceName { get; set; }

        public string InterfaceGuid { get; set; }

        public string InterfaceDescription { get; set; }

        public string InterfaceMAC { get; set; }
    }
}
