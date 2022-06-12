using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] els = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in els)
                {
                    elements.Add(item);
                }
            }

            Console.WriteLine(string.Join(' ', elements.OrderBy(x => x).Distinct()));
        }
    }
}
