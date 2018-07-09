using System;
using System.Collections;
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
        private SerialPort serialPort;
        public string PortName { get => _portName; }
        public int BaudRate { get => _baudRate; }
        public int DataSize { get => _dataSize; }
        public Handshake Handshake { get => _handShake; }
        public Parity Parity { get => _parity; }
        public SerialPort SerialPort { get => serialPort; set => serialPort = value; }

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
        public ArrayList Read()
        {
            //throw new NotImplementedException();
            serialPort.ReadLine();
            //UNDONE: add return for serial read 
            return null;
        }
        public void Write(ArrayList cmd)
        {
            //throw new NotImplementedException
            int size = cmd.Count;
            byte[] data = new byte[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = Convert.ToByte(cmd[i]);
            }
            _len = data.Length;
            
            if (serialPort.IsOpen)
            {
                serialPort.Write(data, _offset, _len);
            }
            else
            {
                MessageBox.Show("Serial comunication time out", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            
            
        }

    }
}
