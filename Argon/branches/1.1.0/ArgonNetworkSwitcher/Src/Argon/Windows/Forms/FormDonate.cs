using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Argon.Windows.Forms
{
    public partial class FormDonate : Form
    {
        public FormDonate()
        {
            InitializeComponent();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CNV5EUWEZE622");            
        }

        private void FormDonate_Load(object sender, EventArgs e)
        {

        }
    }
}
