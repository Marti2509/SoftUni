using System;
using System.Collections.Generic;

namespace P08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (input[0] == '0')
                    vips.Add(input);
                else if (input[0] == '1')
                    vips.Add(input);
                else if (input[0] == '2')
                    vips.Add(input);
                else if (input[0] == '3')
                    vips.Add(input);
                else if (input[0] == '4')
                    vips.Add(input);
                else if (input[0] == '5')
                    vips.Add(input);
                else if (input[0] == '6')
                    vips.Add(input);
                else if (input[0] == '7')
                    vips.Add(input);
                else if (input[0] == '8')
                    vips.Add(input);
                else if (input[0] == '9')
                    vips.Add(input);
                else
                {
                    regular.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (vips.Contains(input))
                    vips.Remove(input);

                if (regular.Contains(input))
                    regular.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(vips.Count + regular.Count);
            foreach (string guest in vips)
            {
                Console.WriteLine(guest);
            }
            foreach (string guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
