using System;

namespace P03.Time___15_minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int mins15 = mins + 15;
            int hours1 = hours;

            if (mins15 >= 60)
            {
                hours1 = hours + 1;
                mins15 = mins15 - 60;
            }

            if (hours1 == 24)
            {
                hours1 = 0;
            }

            if (mins15 < 10)
            {
                Console.WriteLine($"{hours1}:0{mins15}");
            }
            else
            {
                Console.WriteLine($"{hours1}:{mins15}");
            }
        }
    }
}
