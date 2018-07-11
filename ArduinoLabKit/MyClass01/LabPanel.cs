using System.Windows.Forms;

namespace ArduinoLabKit.MyClass01
{
    public class TabContainer : IContainer
    {
        private TabPage _tab;

        public TabContainer(TabPage tab)
        {
            this._tab = tab;
        }

        public TabPage Tab { get => _tab; set => _tab = value; }

        public void ClearContainer()
        {
            _tab.Controls.Clear();
            //throw new NotImplementedException();
        }
    }

    public class AddUscToTab : IPanel
    {
        private TabPage _tabPage;
        private UserControl _control;

        public AddUscToTab(TabPage tabPage, UserControl control)
        {
            this._tabPage = tabPage;
            this._control = control;
        }

        public void AddControl()
        {
            _tabPage.Controls.Add(_control);
            //throw new NotImplementedException();
        }
    }

    public class PanelMenager
    {
        public void AddSouce(IPanel panel)
        {
            panel.AddControl();
        }

        public void ClearContainer(IContainer container)
        {
            container.ClearContainer();
        }
    }
}
