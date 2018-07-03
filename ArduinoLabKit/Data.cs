using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoLabKit
{
    public abstract class Data<T>
    {
        private T _inputData;

        public T InputData { get => _inputData; set => _inputData = value; }
    }

    public interface IDataTransform
    {
        object Transform(Data<object> data);
    }

    public class DataSender : IDataTransform
    {
        public object Transform(Data<object> data)
        {
            throw new NotImplementedException();
        }
    }

    public class DataReader : IDataTransform
    {
        public object Transform(Data<object> data)
        {
            throw new NotImplementedException();
        }
    }
}
