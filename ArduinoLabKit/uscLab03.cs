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
    public partial class uscLab03 : UserControl
    {
        private static uscLab03 _instance;
        public static uscLab03 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uscLab03();
                }
                return _instance;
            }
        }

        public uscLab03()
        {
            InitializeComponent();
        }

        private void uscLab03_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
        }
    }
}
