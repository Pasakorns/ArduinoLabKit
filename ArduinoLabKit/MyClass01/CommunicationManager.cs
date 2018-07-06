using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoLabKit.MyClass01
{
    public class CommuManager
    {
        private ICommunication _port;

        public CommuManager(ICommunication protocal)
        {
            this._port = protocal;
        }

        public void Connect()
        {
            _port.Connect();
        }

        public void Disconnect()
        {
            _port.Disconnet();
        }

        public void Write(IData data)
        {
            _port.Write(data);
        }

        public void Read()
        {
            //_port.Read();
        }
    }
}
