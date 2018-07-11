using ArduinoLabKit.MyClass01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    public partial class CodeViewer : Form
    {
        private static CodeViewer _instance;
        public static CodeViewer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CodeViewer();
                }
                return _instance;
            }
        }

        public CodeViewer()
        {
            InitializeComponent();
        }

        private void CodeViewer_Load(object sender, EventArgs e)
        {

            string fileName = Form1.selectedLab.codePath;
            TextReader tr = new StreamReader(path: @fileName);
            string myText = tr.ReadToEnd();
            txtCodeView.Text = myText;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCodeView.Text.Replace("\n", Environment.NewLine));
        }
    }
}
