using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace Argon.Windows.Forms
{
    public class ArgonDockContent : DockContent
    {
        public DockState OldDockState { get; set; }
    }
}
