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
    public partial class Form1 : Form
    {

        PanelIndexing LabList;
        PanelManagement panel;
        PanelContainer tab;
        PanelSource labPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /// Indexing all Lab control panels
            LabList = new PanelIndexing();
            LabList.AddPanel("Lab 01 : LED control", uscLab01.Instance);
            LabList.AddPanel("Lab 02 : Analog R/W", uscLab02.Instance);
            LabList.AddPanel("Lab 03 : Step motor control", uscLab03.Instance);

            // Show selection list in combo box
            foreach (var item in LabList.PIndex)
            {
                cboLabSelect.Items.Add(item.Key.ToString());
            }

            /// Initialize tab
            tab = new PanelContainer();
            labPanel = new PanelSource();
            tab.Tab = tabControl;
         
        }

        private void cboLabSelect_TextChanged(object sender, EventArgs e)
        {
            /// show Select Lab on tab
            labPanel.Control = LabList.PIndex[cboLabSelect.Text.Trim()];
            panel = new PanelManagement(tab, labPanel);
            panel.ShowPanel();
        }

        private void cboCommuSelect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
