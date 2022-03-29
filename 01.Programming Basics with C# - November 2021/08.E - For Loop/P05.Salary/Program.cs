using System;

namespace P05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int pay = int.Parse(Console.ReadLine());

            int minus = 0;

            for (int i = 1; i <= n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    minus += 150;
                }
                else if (site == "Instagram")
                {
                    minus += 100;
                }
                else if (site == "Reddit")
                {
                    minus += 50;
                }

                if (minus >= pay)
                {
                    break;
                }
            }

            int end = pay - minus;

            if (end > 0)
            {
                Console.WriteLine(end);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
