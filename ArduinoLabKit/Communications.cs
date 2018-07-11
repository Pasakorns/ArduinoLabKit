using System.Collections;

namespace ArduinoLabKit
{
    public interface ICommunication
    {
        void Connect();
        void Disconnect();
        ArrayList Read();
        void Write(ArrayList cmd);
    }
}
