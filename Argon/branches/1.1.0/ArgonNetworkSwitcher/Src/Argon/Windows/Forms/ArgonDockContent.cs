using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace Argon.Windows.Forms
{
    /// <summary>
    /// Generic form is docked to main form
    /// </summary>
    public class ArgonDockContent : DockContent
    {
        /// <summary>
        /// Gets or sets the old state of the dock.
        /// </summary>
        /// <value>
        /// The old state of the dock.
        /// </value>
        public DockState OldDockState { get; set; }
    }
}
