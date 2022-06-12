using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, uint>> wardrobe = new Dictionary<string, Dictionary<string, uint>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                List<string> currItems = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();

                wardrobe.TryAdd(input[0], new Dictionary<string, uint>());

                for (int j = 0; j < currItems.Count; j++)
                {
                    wardrobe[input[0]].TryAdd(currItems[j], 0);
                    wardrobe[input[0]][currItems[j]]++;
                }
            }

            string[] findCloth = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                if (item.Key == findCloth[0])
                {
                    foreach (var cloth in item.Value)
                    {
                        if (cloth.Key == findCloth[1])
                        {
                            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var cloth in item.Value)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
