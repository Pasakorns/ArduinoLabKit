using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    public interface IPanel
    {
        void AddControl();
    }

    public interface IContainer
    {
        void ClearContainer();
    }

    public struct LabDetail
    {
        public string labName;
        public UserControl labPanel;
        public string codePath;
        public Image imgPath;
    }

    public struct CommuDetail
    {
        public string commuName;
        public UserControl commuPanel;
    }

    public class LabIndex
    {
        public List<LabDetail> Labs = new List<LabDetail>();

        public void AddLab(string labName, UserControl labPanel, string codePath, Image imgPath)
        {
            LabDetail lab;
            lab.labName = labName;
            lab.labPanel = labPanel;
            lab.codePath = codePath;
            lab.imgPath = imgPath;

            Labs.Add(lab);
        }
    }

    public class CommuIndex
    {
        public List<CommuDetail> commuList = new List<CommuDetail>();

        public void AddCommu(string commuName, UserControl commuPanel)
        {
            CommuDetail commu;
            commu.commuName = commuName;
            commu.commuPanel = commuPanel;

            commuList.Add(commu);
        }
    }
}
