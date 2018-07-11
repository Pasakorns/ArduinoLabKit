using System;
using System.Windows.Forms;
using System.IO.Ports;
using ArduinoLabKit.MyClass01;

namespace ArduinoLabKit
{
    public partial class UscSerialConfig : UserControl
    {
        // Singleton
        private static UscSerialConfig _instance;
        public static UscSerialConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UscSerialConfig();
                }
                return _instance;
            }
        }

        public static Serial SerialPort;

        public UscSerialConfig()
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
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            cboPortName.Items.AddRange(ports);   
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SerialPort = new Serial(cboPortName.Text,
                                       Convert.ToInt32(cboBaudRate.Text),
                                       Convert.ToInt32(cboDataSize.Text),
                                       (Handshake)cboHandshake.SelectedIndex,
                                       (Parity)cboParity.SelectedIndex);
            SerialPort.Connect();

            //Set Serial communication to main communication
            Form1.SelectedCommu = SerialPort;

            if (SerialPort.Port.IsOpen)
            {
                lblStatus.Visible = true;
                btnConnect.Enabled = false;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            SerialPort.Disconnect();
            if (!SerialPort.Port.IsOpen)
            {
                lblStatus.Visible = false;
                btnConnect.Enabled = true;
            }
        }
    }
}
