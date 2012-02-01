﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.OperatingSystem.Network;
using Argon.OperatingSystem.Network.Profile;

namespace Argon.Models
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class DataModel
    {

        /// <summary>
        /// Gets or sets the network card list.
        /// </summary>
        /// <value>
        /// The network card list.
        /// </value>
        public static List<WindowsNetworkCard> NetworkCardList { get; set; }

        /// <summary>
        /// Gets or sets the network profile list.
        /// </summary>
        /// <value>
        /// The network profile list.
        /// </value>
        public static List<NetworkProfile> NetworkProfileList { get; set; }
    }
}