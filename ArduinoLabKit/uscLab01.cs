using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    public partial class uscLab01 : UserControl
    {
        private static uscLab01 _instance;
        public static uscLab01 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uscLab01();
                }
                return _instance;
            }
        }

        private int _red;
        private int _grn;
        private int _blu;
        private int _pow;

        public int Red { get => _red; }
        public int Grn { get => _grn; }
        public int Blu { get => _blu; }
        public int Pow { get => _pow; }

        public uscLab01()
        {
            InitializeComponent();
        }

        private void uscLab01_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
             
        }

        private void pnlColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pnlColor.BackColor = colorDialog1.Color;
                _red = colorDialog1.Color.R;
                _grn = colorDialog1.Color.G;
                _blu = colorDialog1.Color.B;

                trbRed.Value = _red;
                trbGreen.Value = _grn;
                trbBlue.Value = _blu;

                txtRed.Text = _red.ToString();
                txtGreen.Text = _grn.ToString();
                txtBlue.Text = _blu.ToString();
            }
        }

        private void trbRGB_Scroll(object sender, EventArgs e)
        {
            _red = trbRed.Value;
            _grn = trbGreen.Value;
            _blu = trbBlue.Value;
            _pow = trbPower.Value;

            txtRed.Text = _red.ToString();
            txtGreen.Text = _grn.ToString();
            txtBlue.Text = _blu.ToString();
            txtPower.Text = _pow.ToString();

            pnlColor.BackColor = Color.FromArgb(_red, _grn, _blu);
        }
    }
}
