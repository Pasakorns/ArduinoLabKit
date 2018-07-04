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

        public uscLab02()
        {
            InitializeComponent();
        }
    }
}
