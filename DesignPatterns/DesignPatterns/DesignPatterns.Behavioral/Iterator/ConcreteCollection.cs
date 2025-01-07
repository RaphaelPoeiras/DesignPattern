using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class ConcreteCollection : IAbstractCollection
    {
        private List<Cliente> _clientes = new List<Cliente>();
        public int Count { get { return _clientes.Count; } }
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        internal void AddCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        internal Cliente GetCliente(int current)
        {
            if (current < _clientes.Count)
            {
                return _clientes[current];
            }

            return null;
        }
    }
}