using System;

namespace P09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());

            Console.WriteLine($"{ch1}{ch2}{ch3}");
        }
    }
}
