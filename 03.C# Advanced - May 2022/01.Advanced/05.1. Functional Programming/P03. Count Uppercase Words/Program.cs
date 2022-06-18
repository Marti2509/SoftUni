using System;
using System.Linq;

namespace P03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUppercaseWord = x => x[0] == x.ToUpper()[0];

            string[] upperCaseWords = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => isUppercaseWord(x))
                .ToArray();

            Console.WriteLine(string.Join('\n', upperCaseWords));
        }
    }
}
