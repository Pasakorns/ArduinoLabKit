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
    class SerialData<T> : IData
    {
        private String _dInSting;
        private Char[] _dInChar;
        private Byte[] _dInByte;
        private Int32 _offset;
        private Int32 _len;
        private SerialPort _port;

        public SerialData(String _cmd, String labData, SerialPort serialPort)
        {
            this._dInSting = labData;
        }
        public SerialData(Char[] labData, SerialPort serialPort, Int32 length,  Int32 offset = 0)
        {
            this._dInChar = labData;
            this._offset = offset;
            this._len = length;
            this._port = serialPort;
        }
        public SerialData(Byte[] labData, SerialPort serialPort, Int32 length,  Int32 offset = 0)
        {
            this._dInByte = labData;
            this._offset = offset;
            this._len = length;
            this._port = serialPort;
        }

        public void DataSend()
        {
            //throw new NotImplementedException();
            if (_port.IsOpen)
            {
                if (typeof(T) == typeof(String))
                    {
                        _port.Write(_dInSting);
                    }
                else if (typeof(T) == typeof(Char))
                    {
                        _port.Write(_dInChar, _offset, _len);   
                    }
                else if (typeof(T) == typeof(Byte))
                    {
                        _port.Write(_dInByte, _offset, _len);
                    }
                else
                {
                    MessageBox.Show("Input data not correct!","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Serial comunication time out", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
