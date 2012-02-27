using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Network;
using Argon.Windows.Network.Profile;

/*
 * Copyright 2012 Francesco Benincasa
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
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
