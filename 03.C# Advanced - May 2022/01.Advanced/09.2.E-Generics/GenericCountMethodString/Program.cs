using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                list.Add(input);
            }

            string value = Console.ReadLine();

            Console.WriteLine(GraterString(list, value));
        }

        public static int GraterString(List<string> list, string value)
        {
            int counter = 0;

            foreach (string item in list)
            {
                if (item.CompareTo(value) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
