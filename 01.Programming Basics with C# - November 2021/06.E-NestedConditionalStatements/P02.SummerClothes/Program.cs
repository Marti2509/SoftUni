using System;

namespace P02.Summer_clothes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (day == "Morning")
            {
                if (degree >= 10 && degree <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degree > 18 && degree <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (day == "Afternoon")
            {
                if (degree >= 10 && degree <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree > 18 && degree <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (degree >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (day == "Evening")
            {
                if (degree >= 10 && degree <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree > 18 && degree <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degree >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }
    }
}
