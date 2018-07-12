using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    public partial class CircuitViewer : Form
    {
        private static CircuitViewer _instance;
        public static CircuitViewer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CircuitViewer();
                }
                return _instance;
            }
        }

        public CircuitViewer()
        {
            InitializeComponent();
        }

        private void CircuitViewer_Load(object sender, EventArgs e)
        {
            pnImage.BackgroundImage = Form1.LabDetails.imgPath;
        }
    }
}
