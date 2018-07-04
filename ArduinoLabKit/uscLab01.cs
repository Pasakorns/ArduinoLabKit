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

        public uscLab01()
        {
            InitializeComponent();
        }

        private void uscLab01_Load(object sender, EventArgs e)
        {

        }
    }
}
