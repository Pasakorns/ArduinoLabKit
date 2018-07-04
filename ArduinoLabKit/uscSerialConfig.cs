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
    }
}
