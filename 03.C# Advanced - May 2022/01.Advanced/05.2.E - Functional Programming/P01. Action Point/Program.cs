using System;

namespace P01._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = x => Console.WriteLine(x);

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}
