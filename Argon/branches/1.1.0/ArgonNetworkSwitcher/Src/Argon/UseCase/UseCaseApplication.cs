using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.OperatingSystem.Network.Profile;
using Argon.Windows.Forms;
using Argon.Models;

namespace Argon.UseCase
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class UseCaseApplication
    {

        /// <summary>
        /// Loads the specified form main.
        /// </summary>
        /// <param name="formMain">The form main.</param>
        public static void Load(FormMain formMain)
        {
            // set the main window
            ViewModel.Main = formMain;            

            // load the profiles
            bool load=UseCaseConfig.Load();
        }

    }
}
