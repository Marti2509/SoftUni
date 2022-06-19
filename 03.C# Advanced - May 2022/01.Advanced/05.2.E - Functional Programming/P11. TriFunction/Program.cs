using System;
using System.Collections.Generic;
using System.Linq;

namespace P11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                 .Split(' ')
                 .ToList();

            foreach (string name in names)
            {
                int currSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    currSum += name[i];
                }

                if (currSum >= n)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }
    }
}
