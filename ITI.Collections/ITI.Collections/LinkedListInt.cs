using System;

namespace ITI.Collections
{
    public class LinkedListInt
    {
        ItemInt _first;

        public void Add(int value)
        {
            ItemInt newItem = new ItemInt(value, _first);
            _first = newItem;
        }

        public int GetAt(int index)
        {
            ItemInt current = _first;
            for(int x = 0; x < index; x++)
            {
                current = current.Next;
                if (current == null) throw new ArgumentOutOfRangeException(nameof(index));
            }

            return current.Value;
        }
    }
}
