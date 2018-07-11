using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;

namespace ArduinoLabKit
{
    //---------------------------------------------
    public interface ICommunication
    {
        void Connect();
        void Disconnet();
        ArrayList Read();
        void Write(ArrayList cmd);
    }

}
