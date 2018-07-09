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
using ArduinoLabKit.MyClass01;

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
        public static MyClass01.CommuManager serialMenager;
        public static Serial serialPort;

        public uscSerialConfig()
        {
            InitializeComponent();
        }

        private void uscSerialConfig_Load(object sender, EventArgs e)
        {
            

            foreach (var item in Enum.GetValues(typeof(Parity)))
            {
                cboParity.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Handshake)))
            {
                cboHandshake.Items.Add(item);
            }

            cboBaudRate.SelectedIndex = 0;
            cboDataSize.SelectedIndex = 1;
            cboHandshake.SelectedIndex = 0;
            cboParity.SelectedIndex = 0;

            cboPortName.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cboPortName.Items.AddRange(ports);
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string port = cboPortName.Text;
            int bd = Convert.ToInt32(cboBaudRate.Text);
            Int32 index = cboHandshake.SelectedIndex;
            serialPort = new Serial(cboPortName.Text,
                                       Convert.ToInt32(cboBaudRate.Text),
                                       Convert.ToInt32(cboDataSize.Text),
                                       (Handshake)cboHandshake.SelectedIndex,
                                       (Parity)cboParity.SelectedIndex);

            serialMenager = new MyClass01.CommuManager(serialPort);
            serialMenager.Connect();
            //TODO: !!! add this every time when add new Communication type !!!
            Form1.CommuManager = Form1.CommuSwitch.Switch(serialMenager);
            ///////////////////
            if (serialPort.SerialPort.IsOpen)
            {
                lblStatus.Visible = true;
                btnConnect.Enabled = false;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialMenager.Disconnect();
            if (!serialPort.SerialPort.IsOpen)
            {
                lblStatus.Visible = false;
                btnConnect.Enabled = true;
            }
        }


    }
}
