using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArduinoLabKit
{
    public partial class uscLab02 : UserControl
    {

        private static uscLab02 _instance;
        public static uscLab02 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uscLab02();
                }
                return _instance;
            }
        }

        private string _receiveValue = "";
        private bool _status = false;

        public uscLab02()
        {
            InitializeComponent();       
        }

        private void uscLab02_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            _status = true;
            ReadValue();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _status = false;
            lblDisplay.Text = "*_*";

        }

        private async void ReadValue()
        {
            try
            {
                while (_status)
                {
                    ArrayList message = Form1.SelectedCommu.Read();
                    if (message.Count > 0)
                    {
                        _receiveValue = message[message.Count-1].ToString();
                    }
                    else
                    {
                        _receiveValue = "---";
                    }
                    lblDisplay.Text = _receiveValue;
                    _receiveValue = "";
                    await Task.Delay(50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
    }
}
