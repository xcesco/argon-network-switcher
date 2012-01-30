using System;
using System.Collections.Generic;
using System.Text;
using Argon.OperatingSystem;


namespace Argon.OperatingSystem.Network.Profile
{

    // declare a delegate for the bookpricechanged event
    public delegate void NameChangedHandler(Object objectsender, EventArgs e);
        

    /// <summary>
    /// 
    /// </summary>
    public class NetworkProfile
    {        
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; FireNameChangeEvent(new EventArgs()); }
        }

        public IWindowsNetworkCardInfo NetworkCardInfo
        {
            get;
            set;
        }
        
        public List<IWindowsNetworkCardInfo> DisabledNetworkCards { get; set; }

        /// <summary>
        /// Gets or sets the proxy config.
        /// </summary>
        /// <value>The proxy config.</value>
        public ProxyConfiguration ProxyConfig { get; set; }

        /// <summary>
        /// Gets or sets the default printer.
        /// </summary>
        /// <value>The default printer.</value>
        public String DefaultPrinter { get; set; }

        protected bool _isNew;

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkProfile"/> class.
        /// </summary>
        public NetworkProfile()
        {
            Id = 0;
            Name = "";

            NetworkCardInfo = new NetworkCardInfoImpl();
            ProxyConfig = new ProxyConfiguration();
            ServiceList = new List<IWindowsServiceInfo>();
            ExecList = new List<WindowsExecutable>();
            DriveMapList = new List<DriveMap>();

            DefaultPrinter = "";

            DisabledNetworkCards = new List<IWindowsNetworkCardInfo>();
        }

        /// <summary>
        /// Copies the specified origin.
        /// </summary>
        /// <param name="origin">The origin.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets a value indicating whether this instance is new.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is new; otherwise, <c>false</c>.
        /// </value>
        public bool IsNew
        {
            get { return Id == 0? true :false; }            
        }


        /// <summary>
        /// Gets or sets the drive map list.
        /// </summary>
        /// <value>
        /// The drive map list.
        /// </value>
        public List<DriveMap> DriveMapList { get; set; }

        /// <summary>
        /// Gets or sets the service list.
        /// </summary>
        /// <value>
        /// The service list.
        /// </value>
        public List<IWindowsServiceInfo> ServiceList { get; set; }

        /// <summary>
        /// Gets or sets the exec list.
        /// </summary>
        /// <value>
        /// The exec list.
        /// </value>
        public List<WindowsExecutable> ExecList { get; set; }
        
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

        /// <summary>
        /// Gets or sets the associated wifi profile.
        /// </summary>
        /// <value>
        /// The associated wifi profile.
        /// </value>
        public string AssociatedWifiSSID { get; set; }

    }
}
