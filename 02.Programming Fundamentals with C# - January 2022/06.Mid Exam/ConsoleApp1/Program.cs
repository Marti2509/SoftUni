using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double packageOfFlour = double.Parse(Console.ReadLine());
            double oneEgg = double.Parse(Console.ReadLine());
            double oneApron = double.Parse(Console.ReadLine());

            int freeFlour = students / 5;

            double price = oneApron * (students + Math.Ceiling(students * 0.2)) + (oneEgg * 10) * students + packageOfFlour * (students - freeFlour);

            if (buget >= price)
            {
                Console.WriteLine($"Items purchased for {price:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(price - buget):f2}$ more needed.");
            }
        }
    }
}
