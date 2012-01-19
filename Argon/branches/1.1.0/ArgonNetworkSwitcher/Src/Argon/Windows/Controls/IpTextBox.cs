using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Argon.Windows.Controls
{
    
    /// <summary>
    /// 
    /// </summary>
    [DesignTimeVisible(true), ToolboxItem(true),
    ToolboxBitmap(typeof(Button))]  
    public partial class IpTextBox : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpTextBox"/> class.
        /// </summary>
        public IpTextBox()
        {
            // impostiamo il modo trasparente prima di inizializzare
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
                       
            InitializeComponent();        
        }

        #region Costanti
        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeAMin = 0;
        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeAMax = 255;

        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeBMin = 0;
        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeBMax = 255;

        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeCMin = 0;
        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeCMax = 255;

        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeDMin = 0;
        /// <summary>
        /// 
        /// </summary>
        protected readonly int rangeDMax = 255;
        #endregion


        #region Properties

        /// <summary>
        /// Border style
        /// </summary>
        public new BorderStyle BorderStyle
        {
            get
            {
                return txtBackground.BorderStyle;
            }
            set
            {
                txtBackground.BorderStyle = value;                
            }
        }      

        /// <summary>
        /// IP address
        /// </summary>
        public String IpAddress
        {
            get
            {                              
                return txtRA.Text + "." + txtRB.Text + "." + txtRC.Text + "." + txtRD.Text;             
            }
            set
            {
                value = value == null ? "" : value;
                if (value.Contains("."))
                {
                    string[] segments = value.Split('.');

                    if (segments.Length > 0)
                    {
                        txtRA.Text = (IsNumeric(segments[0]) ? segments[0] : rangeAMin.ToString());
                    }
                    else
                    {
                        txtRA.Text = rangeAMin.ToString();
                    }

                    if (segments.Length > 1)
                    {
                        txtRB.Text = (IsNumeric(segments[1]) ? segments[1] : rangeBMin.ToString());
                    }
                    else
                    {
                        txtRB.Text = rangeBMin.ToString();
                    }

                    if (segments.Length > 2)
                    {
                        txtRC.Text = (IsNumeric(segments[2]) ? segments[2] : rangeCMin.ToString());
                    }
                    else
                    {
                        txtRC.Text = rangeCMin.ToString();
                    }

                    if (segments.Length > 3)
                    {
                        txtRD.Text = (IsNumeric(segments[3]) ? segments[3] : rangeDMin.ToString());
                    }
                    else
                    {
                        txtRD.Text = rangeDMin.ToString();
                    }

                }
                else
                {
                    txtRA.Text = rangeAMin.ToString();
                    txtRB.Text = rangeBMin.ToString();
                    txtRC.Text = rangeCMin.ToString();
                    txtRD.Text = rangeDMin.ToString();
                }
                CheckValues();
            }
        }

        /// <summary>
        /// Gets or sets the range A value.
        /// </summary>
        /// <value>The range A value.</value>
        public int RangeAValue
        {
            get { return ConvertToNumber(txtRA.Text); }
            set
            {
                txtRA.Text = value.ToString();
                CheckValues();
            }
        }

        /// <summary>
        /// Gets or sets the range B value.
        /// </summary>
        /// <value>The range B value.</value>
        public int RangeBValue
        {
            get { return ConvertToNumber(txtRB.Text); }
            set
            {
                txtRB.Text = value.ToString();
                CheckValues();
            }
        }

        /// <summary>
        /// Gets or sets the range C value.
        /// </summary>
        /// <value>The range C value.</value>
        public int RangeCValue
        {
            get { return ConvertToNumber(txtRC.Text); }
            set
            {
                txtRC.Text = value.ToString();
                CheckValues();
            }
        }

        /// <summary>
        /// Gets or sets the range D value.
        /// </summary>
        /// <value>The range D value.</value>
        public int RangeDValue
        {
            get { return ConvertToNumber(txtRD.Text); }
            set
            {
                txtRD.Text = value.ToString();
                CheckValues();
            }
        }

        #endregion

        #region Published Methods

        /// <summary>
        /// Determines whether [is valid address].
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if [is valid address]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValidAddress()
        {
            if (IpAddress.Equals("0.0.0.0") ||
                IpAddress.Equals("255.255.255.255"))
                return false;

            return true;
        }

        #endregion

        #region Methods


        private bool IsNumeric(string input)
            {
                int app;
                return Int32.TryParse(input, out app);
            }

            private int ConvertToNumber(string input)
            {
                int app;
                Int32.TryParse(input, out app);
                return app;
            }

            /// <summary>
            /// Controlla i valori dell'ip. In caso non siano validi
            /// li imposta al massimo o al minimo.
            /// </summary>
            private void CheckValues()
            {
                TextBox[] txt ={ txtRA, txtRB, txtRC, txtRD };
                int[,] value ={ { rangeAMax, rangeAMin }, { rangeBMax, rangeBMin }, { rangeCMax, rangeCMin }, { rangeDMax, rangeDMin } };

                int i = 0;
                foreach (TextBox item in txt)
                {
                    if (IsNumeric(item.Text))
                    {
                        int app = ConvertToNumber(item.Text);
                        if (app > value[i, 0]) item.Text = value[i, 0].ToString();
                        if (app < value[i, 1]) item.Text = value[i, 1].ToString();
                    }
                    else
                    {
                        item.Text = value[i, 0].ToString();
                    }
                    i++;
                }
            }
        #endregion

        #region Published Events
            /// <summary>
            /// Occurs when [range A changed].
            /// </summary>
        [Category("Action")]
        [Description("Fires when range A is modified.")]
        public event SampleEventDelegate RangeAChanged;


        /// <summary>
        /// Occurs when [range B changed].
        /// </summary>
        [Category("Action")]
        [Description("Fires when range B is modified.")]
        public event SampleEventDelegate RangeBChanged;

        /// <summary>
        /// Occurs when [range C changed].
        /// </summary>
        [Category("Action")]
        [Description("Fires when range D is modified.")]
        public event SampleEventDelegate RangeCChanged;

        /// <summary>
        /// Occurs when [range D changed].
        /// </summary>
        [Category("Action")]
        [Description("Fires when range C is modified.")]
        public event SampleEventDelegate RangeDChanged;
        #endregion

        #region Events

        private void IpTextBox_Load(object sender, EventArgs e)
        {
            CheckValues();
            IpTextBox_Resize(null, null);
        }

        /// <summary>
        /// Cambio del bc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IpTextBox_BackColorChanged(object sender, EventArgs e)
        {
            txtBackground.BackColor = BackColor;
            txtRA.BackColor = BackColor;
            txtRB.BackColor = BackColor;
            txtRC.BackColor = BackColor;
            txtRD.BackColor = BackColor;
            txtLabel1.BackColor = BackColor;
            txtLabel2.BackColor = BackColor;
            txtLabel3.BackColor = BackColor;
        }

        /// <summary>
        /// Cambio del font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IpTextBox_FontChanged(object sender, EventArgs e)
        {
            txtRA.Font = Font;
            txtRB.Font = Font;
            txtRC.Font = Font;
            txtRD.Font = Font;
            txtLabel1.Font = Font;
            txtLabel2.Font = Font;
            txtLabel3.Font = Font;
        }

        private void IpTextBox_ForeColorChanged(object sender, EventArgs e)
        {
            txtRA.ForeColor = ForeColor;
            txtRB.ForeColor = ForeColor;
            txtRC.ForeColor = ForeColor;
            txtRD.ForeColor = ForeColor;
            txtLabel1.ForeColor = ForeColor;
            txtLabel2.ForeColor = ForeColor;
            txtLabel3.ForeColor = ForeColor;
        }

        private void IpTextBox_Resize(object sender, EventArgs e)
        {
            int txtWidth = (txtBackground.DisplayRectangle.Width - (txtLabel1.Width * 3)) / 4;
            int txtTop = ((txtBackground.DisplayRectangle.Height - txtRA.Height) / 2)+2;
            txtRA.Left = 2;
            txtRA.Top = txtTop;
            txtRA.Width = txtWidth;

            txtRB.Left = txtWidth + txtLabel1.Width;
            txtRB.Width = txtWidth;
            txtRB.Top = txtTop;

            txtRC.Left = (txtWidth + txtLabel1.Width) * 2;
            txtRC.Width = txtWidth;
            txtRC.Top = txtTop;

            txtRD.Left = (txtWidth + txtLabel1.Width) * 3;
            txtRD.Width = txtWidth;
            txtRD.Top = txtTop;

            txtLabel1.Top = txtTop;
            txtLabel2.Top = txtTop;
            txtLabel3.Top = txtTop;

            txtLabel2.Width = txtLabel1.Width;
            txtLabel3.Width = txtLabel1.Width;

            txtLabel1.Height = txtRA.Height;
            txtLabel2.Height = txtRA.Height;
            txtLabel3.Height = txtRA.Height;

            txtLabel1.Left = txtWidth;
            txtLabel2.Left = ((txtWidth + txtLabel1.Width) * 2) - txtLabel1.Width;
            txtLabel3.Left = ((txtWidth + txtLabel1.Width) * 3) - txtLabel1.Width;
             
        }

        private void Event_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
            }
            else
            {
                if (e.KeyCode == Keys.OemPeriod)
                {
                    e.Handled = true;
                    if (txt.Name.Equals("txtRA"))
                    {
                        if (txtRB.Enabled)
                        {
                            txtRB.Focus();
                            txtRB.SelectAll();
                        }
                        else if (txtRC.Enabled)
                        {
                            txtRC.Focus();
                            txtRC.SelectAll();
                        }
                        else
                        {
                            txtRD.Focus();
                            txtRD.SelectAll();
                        }
                    }

                    if (txt.Name.Equals("txtRB"))
                    {
                        if (txtRC.Enabled)
                        {
                            txtRC.Focus();
                            txtRC.SelectAll();
                        }
                        else
                        {
                            txtRD.Focus();
                            txtRD.SelectAll();
                        }
                    }

                    if (txt.Name.Equals("txtRC"))
                    {
                        txtRD.Focus();
                        txtRD.SelectAll();
                    }

                    if (txt.Name.Equals("txtRD"))
                    {
                    }
                }
                switch (e.KeyCode)
                {
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Left:
                    case Keys.Right:
                    case Keys.Delete:
                    case Keys.Back:
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }
            CheckValues();
        }

        private void Event_KeyUp(object sender, KeyEventArgs e)
        {
            CheckValues();
        }

        private void txtRA_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
            if (RangeAChanged != null)
            {
                RangeAChanged();
            }
        }

        private void txtRB_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
            if (RangeBChanged != null)
            {
                RangeBChanged();
            }
        }

        private void txtRC_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
            if (RangeCChanged != null)
            {
                RangeCChanged();
            }
        }

        private void txtRD_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
            if (RangeDChanged != null)
            {
                RangeDChanged();
            }
        }
        #endregion

        
    }

    /// <summary>
    /// Semplice metodo delegato alla gestione degli eventi.
    /// </summary>
    public delegate void SampleEventDelegate();
}