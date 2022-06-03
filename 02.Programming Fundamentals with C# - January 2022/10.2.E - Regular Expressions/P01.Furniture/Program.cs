using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furnitureName>[A-Z]{1}[a-z]+|[A-Z]+)<<(?<price>\d+|\d+.\d+)!(?<quabtity>[0-9]+)";

            Regex regex = new Regex(pattern);

            List<string> purchased = new List<string>();
            decimal endPrice = 0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    purchased.Add(match.Groups[1].Value);

                    endPrice += decimal.Parse(match.Groups[2].Value) * int.Parse(match.Groups[3].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            foreach (string name in purchased)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Total money spend: {endPrice:f2}");
        }
    }
}
