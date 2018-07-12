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
        ArrayList _buffer;

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

            _buffer = new ArrayList();
        }
        /// <summary>
        /// Open Serial port
        /// </summary>
        /// <returns>true if port connected</returns>
        public bool Connect()
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
                return true;  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error : " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
        /// <summary>
        /// Read all data in buffer. Separate data by "\n"
        /// </summary>
        /// <returns>Array of string</returns>
        public ArrayList Read()
        {
            //throw new NotImplementedException();
            string str = "";

            foreach (var item in _port.ReadExisting())
            {
                if (item.ToString() != "\n" && item.ToString() != Environment.NewLine)
                {
                    str += item;
                }
                else
                {
                    _buffer.Add(str);
                    str = "";
                }
            }
            return _buffer;
        }
        /// <summary>
        /// Write data to serial with Byte[] type
        /// </summary>
        /// <param name="message">data to write</param>
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
