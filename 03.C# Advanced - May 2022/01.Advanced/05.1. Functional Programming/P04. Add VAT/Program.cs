using System;
using System.Linq;

namespace P04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] addingVAT = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x + x * 0.2)
                .ToArray();

            foreach (double item in addingVAT)
                Console.WriteLine($"{item:f2}");
        }
    }
}
