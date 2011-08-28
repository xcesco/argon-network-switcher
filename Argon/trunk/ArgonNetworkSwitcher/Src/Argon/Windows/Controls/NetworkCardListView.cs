using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.OperatingSystem;
using BrightIdeasSoftware;

namespace Argon.Windows.Controls
{
    public partial class NetworkCardListView : UserControl
    {
        public NetworkCardListView()
        {
            InitializeComponent();

            colName.ImageGetter = delegate(Object row)
            {
                return 0;
            };
            colName.Renderer = new BaseRenderer();

            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.GetWindowsNetworkCardList();
            listView.ClearObjects();
            listView.AddObjects(lista);

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
