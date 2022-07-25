using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int item = int.Parse(Console.ReadLine());

                list.Add(item);
            }

            int[] swapInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            list = Swap<int>(list, swapInfo[0], swapInfo[1]);

            foreach (int item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public static List<T> Swap<T>(List<T> list, int index1, int index2)
        {
            T item1 = list[index1];
            T item2 = list[index2];

            list[index1] = item2;
            list[index2] = item1;

            return list;
        }
    }
}
