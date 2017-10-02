using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Collections
{
    class Item<T>
    {
        T _value;
        Item<T> _next;

        public Item(T value, Item<T> next)
        {
            _value = value;
            _next = next;
        }

        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public Item<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
}
