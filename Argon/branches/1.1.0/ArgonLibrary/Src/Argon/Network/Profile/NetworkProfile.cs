using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;
using Argon.Network;

namespace Argon.Network.Profile
{

    // declare a delegate for the bookpricechanged event
    public delegate void NameChangedHandler(Object objectsender, EventArgs e);
        

    /// <summary>
    /// 
    /// </summary>
    public class NetworkProfile
    {
        protected int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; FireNameChangeEvent(new EventArgs()); }
        }

        private IWindowsNetworkCardInfo _networkCardInfo;

        public IWindowsNetworkCardInfo NetworkCardInfo
        {
            get { return _networkCardInfo; }
            set { _networkCardInfo = value; }
        }

        private IList<IWindowsNetworkCardInfo> disabledNetworkCards;

        public IList<IWindowsNetworkCardInfo> DisabledNetworkCards
        {
            get { return disabledNetworkCards; }
            set { disabledNetworkCards = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected ProxyConfiguration _proxyConfig;


        /// <summary>
        /// Gets or sets the proxy config.
        /// </summary>
        /// <value>The proxy config.</value>
        public ProxyConfiguration ProxyConfig
        {
            get { return _proxyConfig; }
            set { _proxyConfig = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected String _defaultPrinter;

        /// <summary>
        /// Gets or sets the default printer.
        /// </summary>
        /// <value>The default printer.</value>
        public String DefaultPrinter
        {
            get { return _defaultPrinter; }
            set { _defaultPrinter = value; }
        }

        protected bool _isNew;

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkProfile"/> class.
        /// </summary>
        public NetworkProfile()
        {
            _id = 0;
            _name = "";

            _networkCardInfo = new NetworkCardInfoImpl();
            _proxyConfig = new ProxyConfiguration();
            _serviceList = new List<IWindowsServiceInfo>();
            _execList = new List<WindowsExecutable>();
            _driveMapList = new List<DriveMap>();

            _defaultPrinter = "";

            disabledNetworkCards = new List<IWindowsNetworkCardInfo>();
        }

        public static NetworkProfile Copy(NetworkProfile origin)
        {
            NetworkProfile profile = new NetworkProfile();
            profile.Id = 0;
            profile.Name = origin.Name;

            profile.NetworkCardInfo = NetworkCardInfoImpl.Copy(origin.NetworkCardInfo);
            profile.ProxyConfig = ProxyConfiguration.Copy(origin.ProxyConfig);

            profile.ServiceList = new List<IWindowsServiceInfo>();
            foreach (IWindowsServiceInfo item in profile.ServiceList)
            {
                WindowsServiceInfoImpl temp=(WindowsServiceInfoImpl)item;
                profile.ServiceList.Add(WindowsServiceInfoImpl.Copy(temp));
            }

            profile.ExecList = new List<WindowsExecutable>();
            foreach (WindowsExecutable item in origin.ExecList)
            {
                profile.ExecList.Add(WindowsExecutable.Copy(item));
            }

            profile.DriveMapList = new List<DriveMap>();
            foreach(DriveMap item in origin.DriveMapList)
            {
                profile.DriveMapList.Add(DriveMap.Copy(item));
            }

            profile.DefaultPrinter = origin.DefaultPrinter;

            foreach (WindowsNetworkCard item in origin.DisabledNetworkCards)
            {
                profile.DisabledNetworkCards.Add(WindowsNetworkCard.Copy(item));
            }

            return profile;
        }



        public bool IsNew
        {
            get { return _id == 0? true :false; }            
        }

        protected List<DriveMap> _driveMapList;

        public List<DriveMap> DriveMapList
        {
            get { return _driveMapList; }
            set { _driveMapList = value; }
        }

        protected List<IWindowsServiceInfo> _serviceList;

        public List<IWindowsServiceInfo> ServiceList
        {
            get { return _serviceList; }
            set { _serviceList = value; }
        }

        protected List<WindowsExecutable> _execList;

        public List<WindowsExecutable> ExecList
        {
            get { return _execList; }
            set { _execList = value; }
        }        
        
        // declare the bookpricechanged event using the bookpricechangeddelegate
        public event NameChangedHandler NameChangeEvent;

        /// <summary>
        /// Fires the name change event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public void FireNameChangeEvent(EventArgs e)
        {
            if (NameChangeEvent != null)
            {
                NameChangeEvent(this, e);
            }
        } 

    }
}
