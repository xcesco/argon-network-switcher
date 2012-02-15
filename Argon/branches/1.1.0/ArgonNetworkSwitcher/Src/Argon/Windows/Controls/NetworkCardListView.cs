using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Argon.Windows;
using BrightIdeasSoftware;
using Argon.Windows.Network;


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
            colName.Renderer = new ImageRenderer();

            List<WindowsNetworkCard> lista = WindowsNetworkCardManager.WindowsNetworkCardList;
            listView.ClearObjects();
            listView.AddObjects(lista);

        }

        public bool CheckBoxes
        {
            get { return listView.CheckBoxes; }
            set { listView.CheckBoxes = value; }
        }

        public List<WindowsNetworkCard> SelectedItems
        {
            get
            {
                List<WindowsNetworkCard> list = new List<WindowsNetworkCard>();

                foreach (OLVListItem item1 in listView.Items)
                {

                    if (item1.Checked)
                    {
                        list.Add((WindowsNetworkCard)item1.RowObject);
                    }
                }

                return list;
            }

            set
            {
                foreach (OLVListItem item2 in listView.Items)
                {
                        item2.Checked = false;
                }

                IWindowsNetworkCardInfo nic;
                foreach (IWindowsNetworkCardInfo item in value)
                {
                    foreach (OLVListItem item2 in listView.Items)
                    {
                        nic = (IWindowsNetworkCardInfo)item2.RowObject;

                        if (item.Id.Equals(nic.Id))
                        {
                            item2.Checked = true;
                        }
                    }
                }
            }
        }
    }
}
