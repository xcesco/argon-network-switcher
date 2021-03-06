﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using Argon.Models;
using System.Diagnostics;

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

        /// <summary>
        /// Views the data on form.
        /// </summary>
        public virtual void ViewDataOnForm() { }

        /// <summary>
        /// Stores the form on data.
        /// </summary>
        public virtual void StoreFormOnData() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ArgonDockContent
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ArgonDockContent";
            this.Activated += new System.EventHandler(this.ArgonDockContent_Activated);      
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Handles the Activated event of the ArgonDockContent control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected virtual void ArgonDockContent_Activated(object sender, EventArgs e)
        {            
            ViewModel.SelectedView = this;
            Debug.WriteLine("Activated window " + this.Name + " typeof " + this.GetType().ToString());
        }        
    }
}
