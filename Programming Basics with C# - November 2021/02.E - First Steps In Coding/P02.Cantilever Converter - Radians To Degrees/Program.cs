using System;

namespace P02.Cantilever_Converter___Radians_To_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double gradusi = radian * 180 / Math.PI;

            Console.WriteLine(gradusi);
        }
    }
}
