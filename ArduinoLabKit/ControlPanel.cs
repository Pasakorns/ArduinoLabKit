using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    public abstract class PanelElement
    {
        public abstract Control Element();
    }

    public interface IPanel
    {
        void AddControl();
    }

    public interface IContainer
    {
        void ClearContainer();
    }

    public abstract class PanelManager
    {
        public abstract void AddSouce(IPanel panel);
        public abstract void ClearContainer(IContainer container);
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
