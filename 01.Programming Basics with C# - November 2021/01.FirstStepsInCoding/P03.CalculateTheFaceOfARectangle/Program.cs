using System;

namespace P03.Calculate_The_Face_Of_A_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int area = a * b;

            Console.WriteLine(area);
        }
    }
}
