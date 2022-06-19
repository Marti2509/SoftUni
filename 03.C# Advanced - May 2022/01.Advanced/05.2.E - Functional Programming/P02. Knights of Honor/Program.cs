using System;

namespace P02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = x => Console.WriteLine("Sir " + x);

            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}
