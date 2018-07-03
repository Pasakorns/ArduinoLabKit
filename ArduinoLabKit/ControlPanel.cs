using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoLabKit
{
    public abstract class PanelContainer
    {
        private object _container ;
    }

    public abstract class PanelSource
    {
        private object _source;
    }

    public interface IAddSource 
    {
        void Add(PanelSource source, PanelContainer container);
    }

    public interface IDataManagemnet
    {
        void SetData(object data);
        void GetData(object data);
    }

    class ControlPanel : IAddSource, IDataManagemnet
    {
        private object _container;
        private object _source;

        public object Container { get => _container; set => _container = value; }
        public object Source { get => _source; set => _source = value; }

        public void Add(PanelSource source, PanelContainer container)
        {
            throw new NotImplementedException();
        }

        public void GetData(object data)
        {
            throw new NotImplementedException();
        }

        public void SetData(object data)
        {
            throw new NotImplementedException();
        }
    }
}
