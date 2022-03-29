using System;

namespace P07.Trekking_mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int all = 0;

            double first = 0;
            double second = 0;
            double third = 0;
            double forth = 0;
            double fifth = 0;

            for (int i = 1; i <= groups; i++)
            {
                int people = int.Parse(Console.ReadLine());

                all += people;

                if (people <= 5)
                {
                    first += people;
                }
                else if (people <= 12)
                {
                    second += people;
                }
                else if (people <= 25)
                {
                    third += people;
                }
                else if (people <= 40)
                {
                    forth += people;
                }
                else if (people >= 41)
                {
                    fifth += people;
                }
            }

            first = first / all * 100;
            second = second / all * 100;
            third = third / all * 100;
            forth = forth / all * 100;
            fifth = fifth / all * 100;

            Console.WriteLine($"{first:f2}%");
            Console.WriteLine($"{second:f2}%");
            Console.WriteLine($"{third:f2}%");
            Console.WriteLine($"{forth:f2}%");
            Console.WriteLine($"{fifth:f2}%");
        }
    }
}
