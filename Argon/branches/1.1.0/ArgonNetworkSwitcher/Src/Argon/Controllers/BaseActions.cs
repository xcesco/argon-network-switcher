using System;
using System.Collections.Generic;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Controllers;
using Argon.Models;

namespace Argon.Controllers
{
    public abstract class BaseActions
    {
        /// <summary>
        /// Displays the form.
        /// </summary>
        /// <param name="form">The form.</param>
        protected static void DisplayForm(DockContent form)
        {
            
            switch (form.DockState)
            {
                case DockState.Unknown:
                case DockState.Hidden:
                    form.Show(ViewModel.MainView.Pannello);
                    break;
                default:
                    form.Hide();
                    break;
            }
        }
    }
}
