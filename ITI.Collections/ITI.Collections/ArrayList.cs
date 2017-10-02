using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Collections
{
    public class ArrayList<T>
    {
        T[] _values;
        int _count;

        public ArrayList()
        {
            _values = new T[4];
        }

        public void Add(T value)
        {
            if (_count == _values.Length) DoubleCapacity();
            _values[_count] = value;
            _count++;
        }

        public T GetAt(int index)
        {
            return _values[index];
        }

        void DoubleCapacity()
        {
            T[] newValues = new T[_values.Length * 2];
            Array.Copy(_values, newValues, _values.Length);
        }
    }
}
