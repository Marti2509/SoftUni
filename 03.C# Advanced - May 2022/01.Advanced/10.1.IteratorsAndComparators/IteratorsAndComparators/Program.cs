using System;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("a", 2000, "someone");
            Book bookTwo = new Book("b", 2002,
                "someone", "someone");
            Book bookThree = new Book("a", 2001);

            Library library = new Library(bookOne, bookTwo, bookThree);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }

        }
    }
}
