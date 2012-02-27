﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argon.Models;
using Argon.Windows.Forms;
using System.Windows.Forms;

namespace Argon.UseCase
{
    public abstract class UseCaseSmartView
    {
        /// <summary>
        /// Executes the display smart view.
        /// </summary>
        public static void ExecuteDisplaySmartView()
        {
            FormMain form = ViewModel.MainView;

            if (!form.SmartView)
            {
                // to avoid refresh problem, hidden the form
                form.Visible = false;
                form.OldSize = form.Size;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.Height = form.pnlRibbonContainer.Height + SystemInformation.CaptionHeight + 4;
                form.Width = form.rpAutoDetect.Bounds.Right+120;
                form.rbtnSmartView.SmallImage = global::Argon.Windows.Forms.Properties.Resources.lightbulb_on_16x16;
                form.MaximizeBox = false;
                // restore form view
                form.Visible = true;
                
            }

            form.SmartView = !form.SmartView;
            form.rbtnSmartView.Checked = !form.rbtnSmartView.Checked;
        }

        /// <summary>
        /// Executes the hide smart view.
        /// </summary>
        public static void ExecuteHideSmartView()
        {
            FormMain form = ViewModel.MainView;
            if (form.SmartView)
            {
                // to avoid refresh problem, hidden the form
                form.Visible = false;                
                form.Size = form.OldSize;
                form.FormBorderStyle = FormBorderStyle.Sizable;
                form.rbtnSmartView.SmallImage = global::Argon.Windows.Forms.Properties.Resources.lightbulb_16x16;
                form.MaximizeBox = true;
                // restore form view
                form.Visible = true;
            }

            form.SmartView = !form.SmartView;
            form.rbtnSmartView.Checked = !form.rbtnSmartView.Checked;
        }

        /// <summary>
        /// Executes the toggle smart view.
        /// </summary>
        public static void ExecuteToggleSmartView()
        {
            FormMain form = ViewModel.MainView;

            if (!form.SmartView)
            {
                ExecuteDisplaySmartView();
            }
            else
            {
                ExecuteHideSmartView();
            }

            form.rbtnSmartView.Checked = !form.rbtnSmartView.Checked;
        }
    }
}
