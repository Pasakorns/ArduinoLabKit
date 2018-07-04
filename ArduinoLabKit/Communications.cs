using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoLabKit
{
    //---------------------------------------------
    public abstract class Communication
    {
        public static ArrayList data;
    }

    public class Serial : Communication
    {
        private string _portName;
        private int _bandRate;
        private int _dataSize;
        private bool _handShake;

        public string PortName { get => _portName; set => _portName = value; }
        public int BandRate { get => _bandRate; set => _bandRate = value; }
        public int DataSize { get => _dataSize; set => _dataSize = value; }
        public bool HandShake { get => _handShake; set => _handShake = value; }

    }

    public class TcpIp : Communication
    {
        IPAddress ip;
        int portNumber;

    }

    //---------------------------------------------
    public interface ICommuPortAction
    {
        void Connect(Communication commu);
        void Disconnet(Communication commu);
    }

    public interface ICommuDataAction
    {
        void Send(Communication commu);
        void Read(Communication commu);
    }

    public abstract class CommuManager : ICommuPortAction, ICommuDataAction
    {
        public abstract void Connect(Communication commu);

        public abstract void Disconnet(Communication commu);

        public abstract void Read(Communication commu);

        public abstract void Send(Communication commu);
    }


    //*********************************************//
}
