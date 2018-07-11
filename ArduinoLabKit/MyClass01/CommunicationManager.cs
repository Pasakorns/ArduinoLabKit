using System.Collections;

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

        public void Write(ArrayList list)
        {
            _port.Write(list);
        }

        public ArrayList Read()
        {
            ArrayList buff = _port.Read();
            return buff;
        }
    }
}
