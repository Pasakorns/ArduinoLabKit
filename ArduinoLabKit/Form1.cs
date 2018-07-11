using ArduinoLabKit.MyClass01;
using System;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    public partial class Form1 : Form
    {
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
        }

        public static PanelMenager panelMenager = new PanelMenager();
        public static LabIndex labIndex;
        public static LabDetail selectedLab;
        public static CommuIndex commuIndex;
        public static CommuDetail selectedCommu;

        public static ICommunication SelectedCommu { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: Add UserControl to Index when add new Arduino lab
            //Indexing all Lab control panels
            labIndex = new LabIndex();
            labIndex.AddLab("Lab 01 : LED control", uscLab01.Instance, "RGB_Serial_TCP_control.txt", Properties.Resources.lab01_ar);
            labIndex.AddLab("Lab 02 : Analog Read", uscLab02.Instance, "RGB_Serial_TCP_control.txt", Properties.Resources.lab02_ar);
            labIndex.AddLab("Lab 03 : Step motor control", uscLab03.Instance, "RGB_Serial_TCP_control.txt", Properties.Resources.lab01_ar);
            //......
            //Show labs name list in combo box
            foreach (var item in labIndex.Labs)
            {
                cboLabSelect.Items.Add(item.labName);
            }

            //TODO: Add UserControl to Index when add new communication method
            //Indexing all communication config panels
            commuIndex = new CommuIndex();
            commuIndex.AddCommu("Serial Com.", UscSerialConfig.Instance);
            commuIndex.AddCommu("TCP/IP", uscTcpConfig.Instance);
            //......
            //Show communication list in combo box
            foreach (var item in commuIndex.commuList)
            {
                cboCommuSelect.Items.Add(item.commuName);
            }

            cboCommuSelect.SelectedIndex = 0;
            cboLabSelect.SelectedIndex = 0;
        }

        private void cboLabSelect_TextChanged(object sender, EventArgs e)
        {
            int inx = cboLabSelect.SelectedIndex;
            selectedLab = labIndex.Labs[inx];
            panelMenager.ClearContainer(new TabContainer(tabControl));
            panelMenager.AddSouce(new AddUscToTab(tabControl, selectedLab.labPanel));
            tabMain.SelectTab(tabControl);
        }

        private void cboCommuSelect_TextChanged(object sender, EventArgs e)
        {
            int inx = cboCommuSelect.SelectedIndex;
            selectedCommu = commuIndex.commuList[inx];
            panelMenager.ClearContainer(new TabContainer(tabCommu));
            panelMenager.AddSouce(new AddUscToTab(tabCommu, selectedCommu.commuPanel));
            tabMain.SelectTab(tabCommu);
        }

        private void btnShowCode_Click(object sender, EventArgs e)
        {
            CodeViewer.Instance.ShowDialog();
        }

        private void btnShowCircuit_Click(object sender, EventArgs e)
        {
            CircuitViewer.Instance.Show();
        }
    }
}
