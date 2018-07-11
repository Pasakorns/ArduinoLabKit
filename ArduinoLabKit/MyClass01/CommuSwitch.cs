using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArduinoLabKit.MyClass01
{
    public class CommuSwitch
    {
        private CommuManager _selectedCommu;

        public CommuManager SelectedCommu { get => _selectedCommu; set => _selectedCommu = value; }

        public CommuManager Switch (CommuManager newCommu)
        {
            _selectedCommu = newCommu;
            return _selectedCommu;
        }

        
    }
}
