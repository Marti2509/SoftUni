using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int index = 0;


        public ListyIterator(params T[] list)
        {
            this.list = list.ToList();
        }

        public bool Move()
        {
            if (++this.index < this.list.Count)
                return true;

            this.index--;

            return false;
        }

        public void Print()
        {
            if (this.list.Count != 0)
                Console.WriteLine(this.list[this.index]);
            else
                Console.WriteLine("Invalid Operation!");
        }

        public bool HasNext()
        {
            if (++this.index < this.list.Count)
            {
                this.index--;
                return true;
            }

            this.index--;

            return false;
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(' ', list));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
