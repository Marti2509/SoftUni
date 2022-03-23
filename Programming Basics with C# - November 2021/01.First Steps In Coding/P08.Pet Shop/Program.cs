using System;

namespace P08.Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int cat = int.Parse(Console.ReadLine());

            double dogm = dog * 2.50;
            int catm = cat * 4;

            Console.WriteLine(dogm + catm + " lv.");
        }
    }
}
