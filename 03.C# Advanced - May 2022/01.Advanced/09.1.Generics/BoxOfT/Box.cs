using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> list = new List<T>();

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove()
        {
            T element = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return element;
        }

        public int Count => list.Count;
    }
}
