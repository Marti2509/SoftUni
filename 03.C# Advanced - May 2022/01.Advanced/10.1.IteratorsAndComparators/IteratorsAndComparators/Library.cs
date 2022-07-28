using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.books = books.ToList();
            //this.books.Sort();
            this.books.Sort(new BookComparator());
        }

        private List<Book> books;

        public IEnumerator<Book> GetEnumerator()
        {
            // default:
            //      return Books.GetEnumerator();
            //
            // mine:
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;

            public LibraryIterator(List<Book> books)
            {
                Reset();
                this.books = books;
            }

            public Book Current => books[index];

            public bool MoveNext()
            {
                index++;
                return index < books.Count;

            }

            public void Reset()
            {
                index = -1;
            }

            // legacy
            object IEnumerator.Current => Current;

            // don't need
            public void Dispose() { }

        }
    }
}
