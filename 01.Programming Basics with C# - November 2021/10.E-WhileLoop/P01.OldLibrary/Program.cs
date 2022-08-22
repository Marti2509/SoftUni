using System;

namespace P01.OldLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookToFind = Console.ReadLine();

            int @checked = 0;

            string nowBook = Console.ReadLine();

            while (bookToFind != nowBook)
            {
                if (nowBook == "No More Books")
                {
                    break;
                }

                @checked++;

                nowBook = Console.ReadLine();
            }

            if (bookToFind == nowBook)
            {
                Console.WriteLine($"You checked {@checked} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {@checked} books.");
            }
        }
    }
}
