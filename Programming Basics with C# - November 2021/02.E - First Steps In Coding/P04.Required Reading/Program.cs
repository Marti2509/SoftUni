using System;

namespace P04.Required_Reading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brstr = int.Parse(Console.ReadLine());
            int str = int.Parse(Console.ReadLine());
            int brdni = int.Parse(Console.ReadLine());

            int brchasnaden = (brstr / str) / brdni;

            Console.WriteLine(brchasnaden);
        }
    }
}
