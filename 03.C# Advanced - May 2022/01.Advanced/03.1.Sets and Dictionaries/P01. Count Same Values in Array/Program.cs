using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> dic = new Dictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (double number in input)
            {
                if (!dic.ContainsKey(number))
                    dic.Add(number, 0);
                dic[number]++;
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
