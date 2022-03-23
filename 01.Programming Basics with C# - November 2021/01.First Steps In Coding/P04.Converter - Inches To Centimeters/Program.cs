using System;

namespace P04.Converter___Inches_To_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());

            double cent = inch * 2.54;

            Console.WriteLine(cent);
        }
    }
}
