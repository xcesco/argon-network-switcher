using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.OperatingSystem.Network;

namespace Argon.Models
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class DataModel
    {
        public List<WindowsNetworkCard> NetworkCard { get; set; }
    }
}
