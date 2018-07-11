using System.Collections;
using System.Net;

namespace ArduinoLabKit.MyClass01
{
    //UNDONE: Tcp class
    public class TcpIp : ICommunication
    {
        private IPAddress _ip;
        private int _portNumber;

        public IPAddress ip { get => _ip; set => _ip = value; }
        public int PortNumber { get => _portNumber; set => _portNumber = value; }
        
        public void Connect()
        {
            //throw new NotImplementedException();
        }

        public void Disconnect()
        {
            //throw new NotImplementedException();
        }

        public ArrayList Read()
        {
            //throw new NotImplementedException();
            return null;
        }

        public void Write(ArrayList cmd)
        {
            //throw new NotImplementedException();
        }
    }
}
