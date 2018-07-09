using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    // ------------------------------------------------------------------------- //
    public class PanelIndexing
    {
        private Dictionary<string, UserControl> _pIndex = new Dictionary<string, UserControl>();

        public Dictionary<string, UserControl> PIndex { get => _pIndex; set => _pIndex = value; }

        public void AddPanel(string name, UserControl control)
        {
            _pIndex.Add(name, control);
        }
    }
    // ------------------------------------------------------------------------- //
}
