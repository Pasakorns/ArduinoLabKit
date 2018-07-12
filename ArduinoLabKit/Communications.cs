using System.Collections;

namespace ArduinoLabKit
{
    public interface ICommunication
    {
        bool Connect();
        void Disconnect();
        ArrayList Read();
        void Write(ArrayList cmd);
    }
}
