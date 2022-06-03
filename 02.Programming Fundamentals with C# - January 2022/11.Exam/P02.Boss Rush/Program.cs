using System;
using System.Text.RegularExpressions;

namespace P02.Boss_Rush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<bossName>[A-Z]{4,})\|:#(?<title>[A-Za-z]+) (?<title2>[A-Za-z]+)#";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups["bossName"]}, The {match.Groups["title"]} {match.Groups["title2"]}");
                    Console.WriteLine($">> Strength: {match.Groups["bossName"].Length}");
                    Console.WriteLine($">> Armor: {match.Groups["title"].Length + match.Groups["title2"].Length + 1}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
