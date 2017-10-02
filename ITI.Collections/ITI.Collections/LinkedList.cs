using System;

namespace ITI.Collections
{
    public class LinkedList<T>
    {
        Item<T> _first;

        public void Add(T value)
        {
            Item<T> newItem = new Item<T>(value, _first);
            _first = newItem;
        }

        public T GetAt(int index)
        {
            Item<T> current = _first;
            for(int x = 0; x < index; x++)
            {
                current = current.Next;
                if (current == null) throw new ArgumentOutOfRangeException(nameof(index));
            }

            return current.Value;
        }
    }
}
