using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Collections
{
    class ItemInt
    {
        int _value;
        ItemInt _next;

        public ItemInt(int value, ItemInt next)
        {
            _value = value;
            _next = next;
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public ItemInt Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
}
