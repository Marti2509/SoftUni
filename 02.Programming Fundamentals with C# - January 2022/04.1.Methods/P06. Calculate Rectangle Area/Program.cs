using System;

namespace P06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Area(a, b));
        }

        static int Area(int a, int b)
        {
            return a * b;
        }
    }
}
