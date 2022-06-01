using System;
using System.Text.RegularExpressions;

namespace P03.Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})(.)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string phones = Console.ReadLine();

            MatchCollection matches = Regex.Matches(phones, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine($"Day: {m.Groups["day"]}, Month: {m.Groups["month"]}, Year: {m.Groups["year"]}");
            }
        }
    }
}
