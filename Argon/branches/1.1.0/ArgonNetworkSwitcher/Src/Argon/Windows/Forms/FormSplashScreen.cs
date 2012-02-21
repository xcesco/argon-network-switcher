using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Argon.Windows.Forms
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();                       
        }


        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}