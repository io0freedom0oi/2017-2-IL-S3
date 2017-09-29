using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Collections
{
    public class ArrayListInt
    {
        int[] _values;
        int _count;

        public ArrayListInt()
        {
            _values = new int[4];
        }

        public void Add(int value)
        {
            if (_count == _values.Length) DoubleCapacity();
            _values[_count] = value;
            _count++;
        }

        public int GetAt(int index)
        {
            return _values[index];
        }

        void DoubleCapacity()
        {
            int[] newValues = new int[_values.Length * 2];
            Array.Copy(_values, newValues, _values.Length);
        }
    }
}
