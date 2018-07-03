using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    public class PanelContainer
    {
        private TabPage _tab;

        public PanelContainer(){ }

        public PanelContainer(TabPage tabControl)
        {
            this._tab = tabControl;
        }

        public TabPage Tab
        {
            get
            {
                if (_tab == null)
                {
                    _tab = new TabPage();
                }
                return _tab;
            }

            set => _tab = value;
        }
    }

    public class PanelSource
    {
        private Control _control;

        public PanelSource(){}

        public PanelSource(Control userControl)
        {
            this._control = userControl;
        }

        public Control Control
        {
            get
            {
                if (_control == null)
                {
                    _control = new Control();
                }
                return _control;
            }

            set => _control = value;
        }
    }

    public class PanelIndexing
    {
        private Dictionary<string, Control> _pIndex = new Dictionary<string, Control>();

        public Dictionary<string, Control> PIndex { get => _pIndex; set => _pIndex = value; }

        public void AddPanel(string name, Control control)
        {
            _pIndex.Add(name, control);
        }
    }

    public class PanelManagement
    {
        private PanelContainer _container;
        private PanelSource _source;

        public PanelManagement(PanelContainer container, PanelSource control)
        {
            this._container = container;
            this._source = control;
        }

        public void ShowPanel()
        {
            _container.Tab.Controls.Clear();
            _container.Tab.Controls.Add(_source.Control);
        }
    }


}
