using System;

namespace Exam_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double all = dancers * points;

            if (place == "Bulgaria" && season == "summer")
            {
                all = all - all * 0.05;
            }
            else if (place == "Bulgaria" && season == "winter")
            {
                all = all - all * 0.08;
            }
            else if (place == "Abroad" && season == "summer")
            {
                all = all + all * 0.50;
                all = all - all * 0.10;
            }
            else if (place == "Abroad" && season == "winter")
            {
                all = all + all * 0.50;
                all = all - all * 0.15;
            }

            double charity = all * 0.75;
            double leftMoney = all - charity;
            double moneyForDancer = leftMoney / dancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyForDancer:f2}");
        }
    }
}
