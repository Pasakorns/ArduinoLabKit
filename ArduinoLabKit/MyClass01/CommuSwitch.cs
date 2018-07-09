using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoLabKit.MyClass01
{
    public class CommuSwitch
    {
        private CommuManager _selectedCommu;
        private IProtocal _data;

        public IProtocal Data { get => _data; set => _data = value; }
        public CommuManager SelectedCommu { get => _selectedCommu; set => _selectedCommu = value; }

        public CommuManager Switch (CommuManager newCommu)
        {
            _selectedCommu = newCommu;
            return _selectedCommu;
        }

        
    }
}
