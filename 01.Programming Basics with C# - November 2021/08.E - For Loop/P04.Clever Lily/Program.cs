using System;

namespace P04.Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double peralnq = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double money = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money = money + (i * 5 - 1);
                }
                else
                {
                    money = money + toyPrice;
                }
            }

            if (money >= peralnq)
            {
                Console.WriteLine($"Yes! {money - peralnq:f2}");
            }
            else
            {
                Console.WriteLine($"No! {peralnq - money:f2}");
            }
        }
    }
}
