using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
using Argon.FileSystem;
using System.Windows.Forms;


namespace Argon.Windows.Network.Profile
{
    // declare a delegate for the bookpricechanged event
    public delegate void SelectProfileHandler(NetworkProfile objectsender, EventArgs e);

    [Serializable]
    public class NetworkConfiguration
    {

        protected NetworkProfile _currentProfile;

        public NetworkProfile CurrentProfile
        {
            get { return _currentProfile; }
            set {
                _currentProfile = value;
                FireSelectProfileEvent(new EventArgs());
            }
        }

        protected List<WindowsNetworkCard> nicInfo;

        public WindowsNetworkCard this[string key]
        {
            get
            {
                string temp;
                key = key.ToLower();                
                foreach (WindowsNetworkCard item in nicInfo)
                {
                    temp = item.Id.ToLower();
                    if (temp.Equals(key))
                    {
                        return item;
                    }
                }

                return null;
            }
        }
       
        public NetworkConfiguration()
        {
           Profiles = new List<NetworkProfile>();
        }

        /// <summary>
        /// Currents the windows network card.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public WindowsNetworkCard CurrentWindowsNetworkCard(string id)
        {
            if (_networkCardTable.ContainsKey(id))
                return _networkCardTable[id];
            return null;
        }

        /// <summary>
        /// Recupera tutti i NIC a parte quella di loopback, che non ci serve a nulla.
        /// </summary>
        /// <returns>elenco delle schede di rete, a parte quella di loopback</returns>
        public List<WindowsNetworkCard> GetNetworkAdapters()
        {            
            List<WindowsNetworkCard> listaNIC=WindowsNetworkCardManager.GetWindowsNetworkCardList();           
            _networkCardTable = new Dictionary<string, WindowsNetworkCard>();

            foreach (WindowsNetworkCard item in listaNIC)
            {
                _networkCardTable.Add(item.Id, item);
            }

            return listaNIC;
        }

        protected Dictionary<string, WindowsNetworkCard> _networkCardTable;

        /// <summary>
        /// Gets the windows services table.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, WindowsNetworkCard> WindowsNetworkCardTable
        {
            get
            {
                return _networkCardTable;
            }
        }

        public void AddProfile(NetworkProfile profile)
        {
            Profiles.Add(profile);
        }

        public List<NetworkProfile> Profiles { get; set; }

        // declare the bookpricechanged event using the bookpricechangeddelegate
        public event SelectProfileHandler SelectProfileEvent;


        /// <summary>
        /// Fires the select profile event.
        /// </summary>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        public void FireSelectProfileEvent(EventArgs e)
        {
            if (SelectProfileEvent != null)
            {
                SelectProfileEvent(_currentProfile, e);
            }
        } 

    }
}
