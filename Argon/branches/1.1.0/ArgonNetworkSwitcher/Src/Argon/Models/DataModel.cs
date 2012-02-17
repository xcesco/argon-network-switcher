using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Network;
using Argon.Windows.Network.Profile;

namespace Argon.Models
{
    /// <summary>
    /// 
    /// </summary>
    public static class DataModel
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

        /// <summary>
        /// Gets or sets the selected network profile.
        /// </summary>
        /// <value>
        /// The selected network profile.
        /// </value>
        public static NetworkProfile SelectedNetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the selected network card.
        /// </summary>
        /// <value>
        /// The selected network card.
        /// </value>
        public static WindowsNetworkCard SelectedNetworkCard { get; set; }
    }
}
