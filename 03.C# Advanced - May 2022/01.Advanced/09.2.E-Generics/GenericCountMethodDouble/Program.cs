using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                list.Add(input);
            }

            double value = double.Parse(Console.ReadLine());

            Console.WriteLine(GraterString(list, value));
        }

        public static int GraterString<T>(List<T> list, T value)
            where T : IComparable
        {
            int counter = 0;

            foreach (T item in list)
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
