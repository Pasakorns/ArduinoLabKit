using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduinoLabKit
{
    public partial class uscSerialConfig : UserControl
    {
        private static uscSerialConfig _instance;
        public static uscSerialConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uscSerialConfig();
                }
                return _instance;
            }
        }

        public uscSerialConfig()
        {
            InitializeComponent();
        }

        private void uscSerialConfig_Load(object sender, EventArgs e)
        {
            cboBaudRate.SelectedIndex = 0;
            cboDataSize.SelectedIndex = 1;
            cboHandshake.SelectedIndex = 0;
            cboParity.SelectedIndex = 0;

            cboPortName.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cboPortName.Items.AddRange(ports);
        }
    }
}
