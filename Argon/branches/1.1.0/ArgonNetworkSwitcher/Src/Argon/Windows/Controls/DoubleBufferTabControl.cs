using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Argon.Windows.Controls
{

    /// <summary>
    /// 
    /// </summary>
    public class DoubleBufferedTabControl : System.Windows.Forms.TabControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleBufferedTabControl"/> class.
        /// </summary>
        public DoubleBufferedTabControl()
        {
            //this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        /*
        /// <summary>
        /// Raises the <see cref="E:Paint"/> event.
        /// </summary>
        /// <param name="pevent">The <see cref="System.Windows.Forms.PaintEventArgs"/> instance containing the event data.</param>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.SetStyle(ControlStyles.UserPaint, false);
            base.OnPaint(pevent);
            System.Drawing.Rectangle o = pevent.ClipRectangle;
            System.Drawing.Graphics.FromImage(buffer).Clear(System.Drawing.SystemColors.Control);
            if (o.Width > 0 && o.Height > 0)
            {
                DrawToBitmap(buffer, new System.Drawing.Rectangle(0, 0, Width, o.Height));
            }
            pevent.Graphics.DrawImageUnscaled(buffer, 0, 0);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            buffer = new System.Drawing.Bitmap(Width, Height);
        }
        private System.Drawing.Bitmap buffer;*/
    }

    public class DoubleBufferedTabPage : System.Windows.Forms.TabPage
    {
        public DoubleBufferedTabPage()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }
    }

}
