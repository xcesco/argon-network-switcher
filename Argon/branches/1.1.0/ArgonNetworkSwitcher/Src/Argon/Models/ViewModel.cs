using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Forms;

namespace Argon.Models
{
    /// <summary>
    /// Rapresent view model of program.
    /// </summary>
    public static class ViewModel
    {        

        /// <summary>
        /// Gets or sets the main.
        /// </summary>
        /// <value>
        /// The main.
        /// </value>
        public static FormMain MainView { get; set; }

        /// <summary>
        /// Gets or sets the console.
        /// </summary>
        /// <value>
        /// The console.
        /// </value>
        public static FormConsole ConsoleView { get; set; }

        /// <summary>
        /// Gets or sets the profile view list.
        /// </summary>
        /// <value>
        /// The profile view list.
        /// </value>
        public static List<FormProfile> ProfileViewList { get; set; }

        /// <summary>
        /// Gets or sets the profiles view.
        /// </summary>
        /// <value>
        /// The profiles view.
        /// </value>
        public static FormProfiles ProfilesView { get; set; }

        /// <summary>
        /// Gets or sets the network cards view.
        /// </summary>
        /// <value>
        /// The network cards view.
        /// </value>
        public static FormNetworkCards NetworkCardsView { get; set; }

        /// <summary>
        /// Gets or sets the adapter view list.
        /// </summary>
        /// <value>
        /// The adapter view list.
        /// </value>
        public static List<FormNetworkCard> NetworkCardViewList { get; set; }        
    }
}
