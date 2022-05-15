using System;

namespace _09.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double extraLightsabers = Math.Ceiling(students * 0.1);
            int freeBelts = students / 6;

            double priceForLightsabers = (students + extraLightsabers) * lightsabersPrice;
            double priceForRobes = students * robesPrice;
            double priceForBelts = (students - freeBelts) * beltsPrice;

            double endPrice = priceForLightsabers + priceForRobes + priceForBelts;

            if (endPrice <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {endPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {endPrice - budget:f2}lv more.");
            }
        }
    }
}
