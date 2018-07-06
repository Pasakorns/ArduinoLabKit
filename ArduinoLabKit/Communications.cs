using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLabKit
{
    //---------------------------------------------
    public interface ICommunication
    {
        void Connect();
        void Disconnet();
        void Read(IData data);
        void Write(IData data);
    }

}
