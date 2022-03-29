using System;

namespace P01.Numbers_up_to_1000_ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 1000; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
