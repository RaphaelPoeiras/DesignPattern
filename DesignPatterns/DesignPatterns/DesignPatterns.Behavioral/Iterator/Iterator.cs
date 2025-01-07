using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class Iterator : IAbstractIterator
    {
        private int current = 0;
        private int step= 1;
        public bool IsDone { get { return current >= collection.Count; } }

        private ConcreteCollection collection;

        public Iterator(ConcreteCollection _collection)
        {
            collection = _collection;
        }

        public Cliente First()
        {
            current = 0;
            return collection.GetCliente(current);
        }

        public Cliente Next()
        {
            current += step;

            if (!IsDone)
            {
                return collection.GetCliente(current);
            }

            return null;
        }
    }
}