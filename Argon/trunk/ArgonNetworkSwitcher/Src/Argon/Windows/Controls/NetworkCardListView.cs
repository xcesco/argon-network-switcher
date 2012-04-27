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
using Argon.Models;

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
namespace Argon.Windows.Controls
{
    public partial class NetworkCardListView : UserControl
    {
        public NetworkCardListView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                       ControlStyles.UserPaint |
                       ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
            // impostiamo il modo trasparente prima di inizializzare
            BackColor = Color.Transparent;

            colName.ImageGetter = delegate(Object row)
            {
                return 0;
            };
            colName.Renderer = new ImageRenderer();

            List<WindowsNetworkCard> lista = DataModel.NetworkCardList;
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
                if (value == null) return;

                foreach (OLVListItem item2 in listView.Items)
                {
                        item2.Checked = false;
                }

                WindowsNetworkCard nic;
                
                foreach (WindowsNetworkCard item in value)
                {
                    foreach (OLVListItem item2 in listView.Items)
                    {
                        nic = (WindowsNetworkCard)item2.RowObject;

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
