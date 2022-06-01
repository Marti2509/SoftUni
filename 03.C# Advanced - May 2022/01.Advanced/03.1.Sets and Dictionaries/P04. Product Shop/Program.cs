using System;
using System.Collections.Generic;

namespace P04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> stores = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {
                if (!stores.ContainsKey(input[0]))
                    stores.Add(input[0], new Dictionary<string, double>());
                stores[input[0]][input[1]] = double.Parse(input[2]);


                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var store in stores)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var item in store.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
