using System;

namespace Exam_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetForTheDay = int.Parse(Console.ReadLine());

            string hair = Console.ReadLine();

            double price = 0;

            while (hair != "closed")
            {
                if (hair == "haircut")
                {
                    string style = Console.ReadLine();

                    if (style == "mens")
                    {
                        price = price + 15;
                    }
                    else if (style == "ladies") 
                    {
                        price = price + 20;
                    }
                    else if (style == "kids")
                    {
                        price = price + 10;
                    }

                }
                else if (hair == "color")
                {
                    string style = Console.ReadLine();

                    if (style == "touch up")
                    {
                        price = price + 20;
                    }
                    else if (style == "full color")
                    {
                        price = price + 30;
                    }
                }

                if (price >= targetForTheDay)
                {
                    break;
                }

                hair = Console.ReadLine();
            }

            if (hair != "closed")
            {
                Console.WriteLine("You have reached your target for the day!");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {targetForTheDay - price}lv. more.");
            }
            Console.WriteLine($"Earned money: {price}lv.");
        }
    }
}
