using ArduinoLabKit.MyClass01;
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
        PanelManager panelMenager = new MyPanelMenager();
        private PanelIndexing CommuList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Add UserControl to Index when add new Arduino lab
            //Indexing all Lab control panels
            LabList = new PanelIndexing();
            LabList.AddPanel("Lab 01 : LED control", uscLab01.Instance);
            LabList.AddPanel("Lab 02 : Analog R/W", uscLab02.Instance);
            LabList.AddPanel("Lab 03 : Step motor control", uscLab03.Instance);

            //Show selection list in combo box
            foreach (var item in LabList.PIndex)
            {
                cboLabSelect.Items.Add(item.Key.ToString());
            }

            //TODO: Add UserControl to Index when add new communication method
            //Indexing all communication config panels
            CommuList = new PanelIndexing();
            CommuList.AddPanel("Serial Com.", uscSerialConfig.Instance);
            CommuList.AddPanel("TCP/IP", uscTcpConfig.Instance);

            //Show selection list in combo box
            foreach (var item in CommuList.PIndex)
            {
                cboCommuSelect.Items.Add(item.Key.ToString());
            }

        }

        private void cboLabSelect_TextChanged(object sender, EventArgs e)
        {
            //TODO: Edit when change Lab container
            //HACK: review 
            panelMenager.ClearContainer(new TabContainer(tabControl));
            panelMenager.AddSouce(new AddUscToTab(tabControl, LabList.PIndex[cboLabSelect.Text.Trim().ToString()]));
            tabMain.SelectTab(tabControl);
        }

        private void cboCommuSelect_TextChanged(object sender, EventArgs e)
        {
            //TODO: Edit when change Communication cofig container
            //HACK: review 
            panelMenager.ClearContainer(new TabContainer(tabCommu));
            panelMenager.AddSouce(new AddUscToTab(tabCommu, CommuList.PIndex[cboCommuSelect.Text.Trim().ToString()]));
            tabMain.SelectTab(tabCommu);
        }
    }
}
