using System;

namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacityTank = 255;
            int inLeters = 0;

            for (int i = 0; i < n; i++)
            {
                int leters = int.Parse(Console.ReadLine());

                if (leters + inLeters > capacityTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    inLeters += leters;
                }
            }

            Console.WriteLine(inLeters);

        }
    }
}
