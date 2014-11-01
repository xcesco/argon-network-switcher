using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Windows.Forms;
using Argon.Windows.Network.Profile;

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
namespace Argon.Models
{
    /// <summary>
    /// Rapresent view model of program.
    /// </summary>
    public static class ViewModel
    {

        public static String[] ImageNames = { "profile_0_48x48", "profile_1_48x48", 
                                                "profile_2_48x48", "profile_3_48x48", 
                                                "profile_4_48x48", "profile_5_48x48", 
                                                "profile_6_48x48", "profile_7_48x48", 
                                                "profile_8_48x48","profile_9_48x48" };

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
        /// Gets or sets the settings view.
        /// </summary>
        /// <value>
        /// The settings view.
        /// </value>
        public static FormOptions OptionsView { get; set; }

        /// <summary>
        /// Gets or sets the adapter view list.
        /// </summary>
        /// <value>
        /// The adapter view list.
        /// </value>
        public static List<FormNetworkCard> NetworkCardViewList { get; set; }

        /// <summary>
        /// Gets or sets the selected view.
        /// </summary>
        /// <value>
        /// The selected view.
        /// </value>
        public static ArgonDockContent SelectedView { get; set; }

 
    }
}
