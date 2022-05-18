using System;

namespace P01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilomiters = meters / 1000.0m;

            Console.WriteLine($"{kilomiters:f2}");
        }
    }
}
