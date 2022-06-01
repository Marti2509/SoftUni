using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            string names = Console.ReadLine();

            List<string> sucNames = new List<string>();

            //foreach (string name in names)
            //{
            //    Match match = Regex.Match(name, pattern);

            //    if (match.Success)
            //    {
            //        sucNames.Add(match.Value);
            //    }
            //}

            MatchCollection matches = Regex.Matches(names, pattern);

            Console.WriteLine(string.Join(' ', matches));
        }
    }
}
