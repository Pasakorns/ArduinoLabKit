using System;
using System.Collections;
using System.IO.Ports;
using System.Linq;
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
        private SerialPort _port;
        public SerialPort Port { get => _port; set => _port = value; }

        private Int32 _offset = 0;
        private Int32 _len;

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
                _port = new SerialPort
                {
                    PortName = _portName,
                    BaudRate = _baudRate,
                    DataBits = _dataSize,
                    Handshake = _handShake,
                    Parity = _parity
                };

                _port.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        public void Disconnect()
        {
            //throw new NotImplementedException();
            try
            {
                if (this._port.IsOpen)
                {
                    _port.Close();
                    // Clear data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        public ArrayList Read()
        {
            //throw new NotImplementedException();
            String str = _port.ReadLine();
            ArrayList buffer = new ArrayList();
            buffer.AddRange(str.ToArray());

            //UNDONE: add return for serial read
            return buffer;
        }
        public void Write(ArrayList message)
        {
            //throw new NotImplementedException
            int size = message.Count;
            byte[] data = new byte[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = Convert.ToByte(message[i]);
            }
            _len = data.Length;
            
            if (_port.IsOpen)
            {
                _port.Write(data, _offset, _len);
            }
            else
            {
                MessageBox.Show("Serial comunication time out", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }
    }
}
