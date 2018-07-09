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

        PanelMenager panelMenager = new PanelMenager();

        PanelIndexing LabList;
        private PanelIndexing CommuList;

        public static CommuManager CommuManager { get; set; }
        public IProtocal Data { get; set; }
        public static CommuSwitch CommuSwitch = new CommuSwitch();


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
            LabList.AddPanel("Lab 02 : Analog Read", uscLab02.Instance);
            LabList.AddPanel("Lab 03 : Step motor control", uscLab03.Instance);

            //add selection list in combo box
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

            cboCommuSelect.SelectedIndex = 0;
            cboLabSelect.SelectedIndex = 0;

        }

        private void cboLabSelect_TextChanged(object sender, EventArgs e)
        {
            //TODO: Edit when change Lab's container/source
            panelMenager.ClearContainer(new TabContainer(tabControl));
            panelMenager.AddSouce(new AddUscToTab(tabControl, LabList.PIndex[cboLabSelect.Text.Trim().ToString()]));
            tabMain.SelectTab(tabControl);
        }

        private void cboCommuSelect_TextChanged(object sender, EventArgs e)
        {
            //TODO: Edit when change Communication cofig container
            panelMenager.ClearContainer(new TabContainer(tabCommu));
            panelMenager.AddSouce(new AddUscToTab(tabCommu, CommuList.PIndex[cboCommuSelect.Text.Trim().ToString()]));
            tabMain.SelectTab(tabCommu);
        }
    }
}
