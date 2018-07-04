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
    public partial class uscTcpConfig : UserControl
    {
        private static uscTcpConfig _instance;
        public static uscTcpConfig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new uscTcpConfig();
                }
                return _instance;
            }
        }

        public uscTcpConfig()
        {
            InitializeComponent();
        }
    }
}
