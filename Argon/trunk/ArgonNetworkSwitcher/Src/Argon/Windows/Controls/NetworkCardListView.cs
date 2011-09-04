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

        public bool CheckBoxes
        {
            get { return listView.CheckBoxes; }
            set { listView.CheckBoxes = value; }
        }

        public IList<IWindowsNetworkCardInfo> SelectedItems
        {
            get
            {
                IList<IWindowsNetworkCardInfo> list = new List<IWindowsNetworkCardInfo>();

                foreach (OLVListItem item1 in listView.Items)
                {

                    if (item1.Checked)
                    {
                        list.Add((IWindowsNetworkCardInfo)item1.RowObject);
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
