using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLabKit.MyClass01
{
    public class Serial : ICommunication
    {
        private string _portName;
        private int _baudRate;
        private int _dataSize;
        private Parity _parity;
        private Handshake _handShake;
        public string PortName { get => _portName; }
        public int BaudRate { get => _baudRate; }
        public int DataSize { get => _dataSize; }
        public Handshake Handshake { get => _handShake; }
        public Parity Parity { get => _parity; }
        public SerialPort serialPort;


        public Serial(string portName,
                         int baudRate,
                         int dataSize = 8,
                         Handshake handShack = Handshake.None,
                         Parity parity = Parity.None)
        {
            this._portName = portName;
            this._baudRate = baudRate;
            this._dataSize = dataSize;
            this._handShake = handShack;
            this._parity = parity;
        }

        public void Connect()
        {
            //throw new NotImplementedException();
            try
            {
                serialPort = new SerialPort();
                serialPort.PortName = _portName;
                serialPort.BaudRate = _baudRate;
                serialPort.DataBits = _dataSize;
                serialPort.Handshake = _handShake;
                serialPort.Parity = _parity;

                serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        public void Disconnet()
        {
            //throw new NotImplementedException();
            try
            {
                if (this.serialPort.IsOpen)
                {
                    serialPort.Close();
                    // Clear data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        public void Read(IData data)
        {
            //throw new NotImplementedException();
            serialPort.ReadLine();
        }
        public void Write(IData data)
        {
            //throw new NotImplementedException
            data.DataSend();
        }
        
    }
}
