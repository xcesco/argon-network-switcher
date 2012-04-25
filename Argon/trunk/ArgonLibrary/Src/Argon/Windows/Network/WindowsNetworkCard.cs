using System;
using System.Collections.Generic;
using System.Text;
using Argon.Windows;

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
namespace Argon.Windows.Network
{

    /// <summary>
    /// type of network card
    /// </summary>
    [Serializable] 
    public enum WindowsNetworkCardType
    {
        /// <summary>
        /// Wireless card
        /// </summary>
        WIRELESS,
        /// <summary>
        /// Wired card
        /// </summary>
        ETHERNET,
        /// <summary>
        /// virtual type (VMWare)
        /// </summary>
        VIRTUAL,
        /// <summary>
        /// Bluetooth card
        /// </summary>
        BLUETOOTH,
        /// <summary>
        /// Firewire
        /// </summary>
        FIREWIRE,
        /// <summary>
        /// Unspecified card
        /// </summary>
        UNKNOWN
    }


    /// <summary>
    /// 
    /// </summary>
    [Serializable] 
    public class WindowsNetworkCard : WindowsComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsNetworkCard"/> class.
        /// </summary>
        public WindowsNetworkCard()
        {            
            CurrentDns = "";
            CurrentDns2 = "";
            CurrentGatewayAddress = "";
            CurrentIpAddress = "";
            CurrentSubnetMask = "";

            Dhcp = false;
            Dns = "";
            Dns2="";
            GatewayAddress = "";
            IpAddress = "";
            SubnetMask = "";

            Id = "";
            ViewId = "";
            HardwareName = "";
            Name = "";
            PnpDeviceId = "";

            NetConnectionStatus = -1;
            Index = 0;

            CardType = WindowsNetworkCardType.UNKNOWN;
        }

        /// <summary>
        /// Gets or sets the type of the card.
        /// </summary>
        /// <value>
        /// The type of the card.
        /// </value>
        public WindowsNetworkCardType CardType { get; set; }
        
        public uint Index { get; set; }        

        public int NetConnectionStatus { get; set; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        public String Status
        {
            get
            {
                switch (NetConnectionStatus)
                {
                    case 0: return "Disconnected";
                    case 1: return "Connecting";
                    case 2: return "Connected";
                    case 3: return "Disconnecting";
                    case 4: return "Hardware not present";
                    case 5: return "Hardware disabled";
                    case 6: return "Hardware malfunction";
                    case 7: return "Media disconnected";
                    case 8: return "Authenticating";
                    case 9: return "Authentication succeeded";
                    case 10: return "Authentication failed";
                    case 11: return "Invalid address";
                    case 12: return "Credentials required";
                }

                return "Unknown";
            }
        }

        /// <summary>
        /// Gets a value indicating whether this <see cref="WindowsNetworkCard"/> is connected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if connected; otherwise, <c>false</c>.
        /// </value>
        public bool Connected
        {
            get
            {
                if (NetConnectionStatus == 2) return true;
                return false;
            }
        }

        public String HardwareName { get; set; }        
            
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id { get; set; }


        /// <summary>
        /// Gets or sets the DNS.
        /// </summary>
        /// <value>The DNS.</value>
        public String Dns { get; set; }

        /// <summary>
        /// Gets or sets the DNS2.
        /// </summary>
        /// <value>The DNS2.</value>
        public String Dns2 { get; set; }

        /// <summary>
        /// Id della scheda usato per la visura delle informazioni della scheda.
        /// Essendo mutabile nel tempo, <bold>non è consentito usarlo come id univoco della scheda</bold>
        /// </summary>
        public string ViewId { get; set; }

        /// <summary>
        /// Indirizzo MAC della scheda
        /// </summary>
        public string MacAddress {get; set;}

        /// <summary>
        /// Gets or sets the ip.
        /// </summary>
        /// <value>The ip.</value>
        public string IpAddress { get; set;}

        /// <summary>
        /// Gets or sets the current ip address.
        /// </summary>
        /// <value>The current ip address.</value>
        public string CurrentIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the current subnet mask.
        /// </summary>
        /// <value>The current subnet mask.</value>
        public string CurrentSubnetMask {get; set;}

        /// <summary>
        /// Gets a value indicating whether [enabled dynamic DNS].
        /// </summary>
        /// <value><c>true</c> if [enabled dynamic DNS]; otherwise, <c>false</c>.</value>
        public bool DynamicDNS { get; set; }

        /// <summary>
        /// Gets or sets the DNS.
        /// </summary>
        /// <value>The DNS.</value>
        public String CurrentDns { get; set; }

        /// <summary>
        /// Gets or sets the DNS2.
        /// </summary>
        /// <value>The DNS2.</value>
        public String CurrentDns2 { get; set;}

        /// <summary>
        /// Gets or sets the gateway.
        /// </summary>
        /// <value>The gateway.</value>
        public string CurrentGatewayAddress { get; set; }

        /// <summary>
        /// Gets or sets the gateway.
        /// </summary>
        /// <value>The gateway.</value>
        public string GatewayAddress {get; set; }

        /// <summary>
        /// Gets or sets the subnet mask.
        /// </summary>
        /// <value>The subnet mask.</value>
        public string SubnetMask { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WindowsNetworkCard"/> is DHCP.
        /// </summary>
        /// <value><c>true</c> if DHCP; otherwise, <c>false</c>.</value>
        public bool Dhcp {get; set;}

        /// <summary>
        /// Gets or sets the PNP device id.
        /// </summary>
        /// <value>
        /// The PNP device id.
        /// </value>
        public string PnpDeviceId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [wins enable LM hosts lookup].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [wins enable LM hosts lookup]; otherwise, <c>false</c>.
        /// </value>
        public bool WinsEnableLMHostsLookup { get; set; }        

        /// <summary>
        /// Gets or sets the wins host lookup file.
        /// </summary>
        /// <value>The wins host lookup file.</value>
        public string WinsHostLookupFile { get; set; }

        /// <summary>
        /// Gets or sets the wins primary server.
        /// </summary>
        /// <value>The wins primary server.</value>
        public string WinsPrimaryServer { get; set; }

        /// <summary>
        /// Gets or sets the wins secondary server.
        /// </summary>
        /// <value>The wins secondary server.</value>
        public string WinsSecondaryServer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WindowsNetworkCard"/> is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        public bool Enabled { get; set; }


        /// <summary>
        /// Copies the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public static WindowsNetworkCard Copy(WindowsNetworkCard item)
        {

            return (WindowsNetworkCard)item.MemberwiseClone();       
        }

        /// <summary>
        /// Gets or sets the type of the adapter.
        /// </summary>
        /// <value>
        /// The type of the adapter.
        /// </value>
        public string AdapterType { get; set; }

        /// <summary>
        /// Gets or sets the max speed.
        /// </summary>
        /// <value>
        /// The max speed.
        /// </value>
        public ulong MaxSpeed { get; set; }

    }
}
