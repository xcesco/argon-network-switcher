using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;

namespace Argon.OperatingSystem.Network
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWindowsNetworkCardInfo
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the view id.
        /// </summary>
        /// <value>The view id.</value>
        string ViewId { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        string Id { get; set;}

        /// <summary>
        /// Gets or sets the ip address.
        /// </summary>
        /// <value>The ip address.</value>
        string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the subnet mask.
        /// </summary>
        /// <value>The subnet mask.</value>
        string SubnetMask { get; set; }

        /// <summary>
        /// Gets or sets the gateway address.
        /// </summary>
        /// <value>The gateway address.</value>
        string GatewayAddress { get; set;}

        /// <summary>
        /// Gets or sets the DNS.
        /// </summary>
        /// <value>The DNS.</value>
        string Dns { get; set;}

        /// <summary>
        /// Gets or sets the DNS2.
        /// </summary>
        /// <value>The DNS2.</value>
        string Dns2 { get;set;}

        /// <summary>
        /// Gets a value indicating whether [dynamic DNS].
        /// </summary>
        /// <value><c>true</c> if [dynamic DNS]; otherwise, <c>false</c>.</value>
        bool DynamicDNS { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IWindowsNetworkCardInfo"/> is DHCP.
        /// </summary>
        /// <value><c>true</c> if DHCP; otherwise, <c>false</c>.</value>
        bool Dhcp { get; set; }

        /// <summary>
        /// Gets or sets the mac address.
        /// </summary>
        /// <value>The mac address.</value>
        string MacAddress { get; set; }
       
        /// <summary>
        /// Gets or sets the name of the hardware.
        /// </summary>
        /// <value>The name of the hardware.</value>
        string HardwareName { get; set; }

        uint Index { get; set; }
        
    }

    /// <summary>
    /// Informazioni inerenti la scheda di rete utilizzata
    /// </summary>
    public class NetworkCardInfoImpl : IWindowsNetworkCardInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkCardInfoImpl"/> class.
        /// </summary>
        public NetworkCardInfoImpl()
        {
            _name = "";
            _viewId = "";
            _id = "";
            
            _dhcp = false;
            _dns = "";
            _dns2 = "";
            _gatewayAddress = "";
            _ipAddress = "";
            _subnetMask = "";
            _macAddress = "";            
            _hardwareName = "";
            _enabled = false;

            _index = 0;
            
        }



        
        /// <summary>
        /// 
        /// </summary>
        private String _hardwareName = "";

        /// <summary>
        /// Gets or sets the name of the hardware.
        /// </summary>
        /// <value>The name of the hardware.</value>
        public String HardwareName
        {
            get { return _hardwareName; }
            set { _hardwareName = value; }
        }
              
        /// <summary>
        /// 
        /// </summary>
        protected string _macAddress;

        /// <summary>
        /// 
        /// </summary>
        protected string _name;

        /// <summary>
        /// 
        /// </summary>
        protected string _viewId;

        /// <summary>
        /// 
        /// </summary>
        protected bool _enabled;

        protected uint _index;

        public uint Index
        {
            get { return _index; }
            set { _index = value; }
        }



        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the view id.
        /// </summary>
        /// <value>The view id.</value>
        public string ViewId
        {
            get { return _viewId; }
            set { _viewId = value; }
        }

        private string _id;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private bool _dhcp;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IWindowsNetworkCardInfo"/> is DHCP.
        /// </summary>
        /// <value><c>true</c> if DHCP; otherwise, <c>false</c>.</value>
        public bool Dhcp
        {
            get { return _dhcp; }
            set { _dhcp = value; }
        }

        private string _ipAddress;

        /// <summary>
        /// Gets or sets the ip address.
        /// </summary>
        /// <value>The ip address.</value>
        public string IpAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }
        private string _subnetMask;

        /// <summary>
        /// Gets or sets the subnet mask.
        /// </summary>
        /// <value>The subnet mask.</value>
        public string SubnetMask
        {
            get { return _subnetMask; }
            set { _subnetMask = value; }
        }
        private string _dns;

        /// <summary>
        /// Gets or sets the DNS.
        /// </summary>
        /// <value>The DNS.</value>
        public string Dns
        {
            get { return _dns; }
            set { _dns = value; }
        }
        private string _dns2;

        /// <summary>
        /// Gets or sets the DNS2.
        /// </summary>
        /// <value>The DNS2.</value>
        public string Dns2
        {
            get { return _dns2; }
            set { _dns2 = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _gatewayAddress;

        /// <summary>
        /// Gets or sets the mac address.
        /// </summary>
        /// <value>The mac address.</value>
        public string MacAddress
        {
            get { return _macAddress; }
            set { _macAddress = value; }
        }

        #region WindowsNetworkCardInfo Members

        private bool _dynamicDNS;
        /// <summary>
        /// Gets a value indicating whether [enabled dynamic DNS].
        /// </summary>
        /// <value><c>true</c> if [enabled dynamic DNS]; otherwise, <c>false</c>.</value>
        public bool DynamicDNS
        {
            get { return _dynamicDNS; }
            set { _dynamicDNS = value; }
        }

        /// <summary>
        /// Gets or sets the gateway address.
        /// </summary>
        /// <value>The gateway address.</value>
        public string GatewayAddress
        {
            get { return _gatewayAddress; }
            set { _gatewayAddress = value; }
        }

        #endregion


        public static IWindowsNetworkCardInfo Copy(IWindowsNetworkCardInfo iWindowsNetworkCardInfo)
        {
            return (NetworkCardInfoImpl)(((NetworkCardInfoImpl)iWindowsNetworkCardInfo).MemberwiseClone());  
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class WindowsNetworkCard : WindowsComponent, IWindowsNetworkCardInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsNetworkCard"/> class.
        /// </summary>
        public WindowsNetworkCard()
        {
            _currentDefaultGateway = "";
            _currentDns = "";
            _currentDns2 = "";
            _currentGatewayAddress = "";
            _currentIpAddress = "";
            _currentSubnetMask = "";

            _dhcp = false;
            _dns = "";
            _dns2="";
            _gatewayAddress = "";
            _ipAddress = "";
            _subnetMask = "";

            _id = "";
            _viewId = "";
            _hardwareName = "";
            _name = "";
            _pnpDeviceId = "";

            _netConnectionStatus = -1;
            _index = 0;
        }

        protected uint _index;

        public uint Index
        {
            get { return _index; }
            set { _index = value; }
        }

        protected int _netConnectionStatus;

        public int NetConnectionStatus
        {
            get { return _netConnectionStatus; }
            set { _netConnectionStatus = value; }
        }

        /// <summary>
        /// Gets the status.
        /// </summary>
        public String Status
        {
            get
            {
                switch (_netConnectionStatus)
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
                if (_netConnectionStatus == 2) return true;
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private String _hardwareName = "";

        public String HardwareName
        {
            get { return _hardwareName; }
            set { _hardwareName = value; }
        }
      
        /// <summary>
        /// 
        /// </summary>
        protected string _id;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }


        /// <summary>
        /// Gets or sets the DNS.
        /// </summary>
        /// <value>The DNS.</value>
        public String Dns
        {
            get { return _dns; }
            set { _dns = value; }
        }

        /// <summary>
        /// Gets or sets the DNS2.
        /// </summary>
        /// <value>The DNS2.</value>
        public String Dns2
        {
            get { return _dns2; }
            set { _dns2 = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _viewId;

        /// <summary>
        /// Id della scheda usato per la visura delle informazioni della scheda.
        /// Essendo mutabile nel tempo, <bold>non è consentito usarlo come id univoco della scheda</bold>
        /// </summary>
        public string ViewId
        {
            get { return _viewId; }
            set { _viewId = value; }
        }


        /// <summary>
        /// 
        /// </summary>
        protected string _macAddress;

        /// <summary>
        /// Indirizzo MAC della scheda
        /// </summary>
        public string MacAddress
        {
            get { return _macAddress; }
            set { _macAddress = value; }
        }
 

        /// <summary>
        /// Gets or sets the ip.
        /// </summary>
        /// <value>The ip.</value>
        public string IpAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _currentIpAddress;

        /// <summary>
        /// Gets or sets the current ip address.
        /// </summary>
        /// <value>The current ip address.</value>
        public string CurrentIpAddress
        {
            get { return _currentIpAddress; }
            set { _currentIpAddress = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _currentSubnetMask;

        /// <summary>
        /// Gets or sets the current subnet mask.
        /// </summary>
        /// <value>The current subnet mask.</value>
        public string CurrentSubnetMask
        {
            get { return _currentSubnetMask; }
            set { _currentSubnetMask = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _currentDefaultGateway;

        /// <summary>
        /// Gets or sets the current default gateway.
        /// </summary>
        /// <value>The current default gateway.</value>
        public string CurrentDefaultGateway
        {
            get { return _currentDefaultGateway; }
            set { _currentDefaultGateway = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _currentDns;

        /// <summary>
        /// 
        /// </summary>
        protected string _currentDns2;

        protected bool _dynamicDNS;

        /// <summary>
        /// Gets a value indicating whether [enabled dynamic DNS].
        /// </summary>
        /// <value><c>true</c> if [enabled dynamic DNS]; otherwise, <c>false</c>.</value>
        public bool DynamicDNS
        {
            get { return _dynamicDNS; }
            set { _dynamicDNS = value; }
        }

        /// <summary>
        /// Gets or sets the DNS.
        /// </summary>
        /// <value>The DNS.</value>
        public String CurrentDns
        {
            get { return _currentDns; }
            set { _currentDns = value; }
        }

        /// <summary>
        /// Gets or sets the DNS2.
        /// </summary>
        /// <value>The DNS2.</value>
        public String CurrentDns2
        {
            get { return _currentDns2; }
            set { _currentDns2 = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected string _currentGatewayAddress;

        /// <summary>
        /// Gets or sets the gateway.
        /// </summary>
        /// <value>The gateway.</value>
        public string CurrentGatewayAddress
        {
            get { return _currentGatewayAddress; }
            set { _currentGatewayAddress = value; }
        }


        /// <summary>
        /// Gets or sets the gateway.
        /// </summary>
        /// <value>The gateway.</value>
        public string GatewayAddress
        {
            get { return _gatewayAddress; }
            set { _gatewayAddress = value; }
        }

        /// <summary>
        /// Gets or sets the subnet mask.
        /// </summary>
        /// <value>The subnet mask.</value>
        public string SubnetMask
        {
            get { return _subnetMask; }
            set { _subnetMask = value; }
        }

        /// <summary>
        /// Dhcp enabled
        /// </summary>
        protected bool _dhcp;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WindowsNetworkCard"/> is DHCP.
        /// </summary>
        /// <value><c>true</c> if DHCP; otherwise, <c>false</c>.</value>
        public bool Dhcp
        {
            get { return _dhcp; }
            set { _dhcp = value; }
        }

        /// <summary>
        /// Ip address
        /// </summary>
        protected string _ipAddress;

        /// <summary>
        /// Gateway address
        /// </summary>
        protected string _gatewayAddress;

        /// <summary>
        /// Dns
        /// </summary>
        protected string _dns;

        /// <summary>
        /// Dns2
        /// </summary>
        protected string _dns2;

        /// <summary>
        /// Subnetsmak
        /// </summary>
        protected string _subnetMask;

        /// <summary>
        /// 
        /// </summary>
        protected bool _winsEnableLMHostsLookup;

        /// <summary>
        /// 
        /// </summary>
        protected string _winsHostLookupFile;

        /// <summary>
        /// 
        /// </summary>
        protected string _winsPrimaryServer;

        /// <summary>
        /// 
        /// </summary>
        protected string _winsSecondaryServer;

        /// <summary>
        /// 
        /// </summary>
        private string _pnpDeviceId;

        /// <summary>
        /// Gets or sets the PNP device id.
        /// </summary>
        /// <value>
        /// The PNP device id.
        /// </value>
        public string PnpDeviceId
        {
            get { return _pnpDeviceId; }
            set { _pnpDeviceId = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [wins enable LM hosts lookup].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [wins enable LM hosts lookup]; otherwise, <c>false</c>.
        /// </value>
        public bool WinsEnableLMHostsLookup
        {
            get { return _winsEnableLMHostsLookup; }
            set { _winsEnableLMHostsLookup = value; }
        }

        /// <summary>
        /// Gets or sets the wins host lookup file.
        /// </summary>
        /// <value>The wins host lookup file.</value>
        public string WinsHostLookupFile
        {
            get { return _winsHostLookupFile; }
            set { _winsHostLookupFile = value; }
        }

        /// <summary>
        /// Gets or sets the wins primary server.
        /// </summary>
        /// <value>The wins primary server.</value>
        public string WinsPrimaryServer
        {
            get { return _winsPrimaryServer; }
            set { _winsPrimaryServer = value; }
        }

        /// <summary>
        /// Gets or sets the wins secondary server.
        /// </summary>
        /// <value>The wins secondary server.</value>
        public string WinsSecondaryServer
        {
            get { return _winsSecondaryServer; }
            set { _winsSecondaryServer = value; }
        }


        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WindowsNetworkCard"/> is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        public bool Enabled { get; set; }


        public static WindowsNetworkCard Copy(WindowsNetworkCard item)
        {

            return (WindowsNetworkCard)item.MemberwiseClone();       
        }

        public string AdapterType { get; set; }
    }
}
