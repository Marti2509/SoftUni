using System;
using System.Collections.Generic;

namespace P03.Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            bool flag = false;

            while (!(materials["shards"] >= 250 || materials["motes"] >= 250 || materials["fragments"] >= 250))
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i += 2)
                {
                    int currQuantity = int.Parse(input[i]);
                    string currMaterial = input[i + 1].ToLower();

                    if (materials.ContainsKey(currMaterial))
                    {
                        materials[currMaterial] += currQuantity;
                    }
                    else
                    {
                        materials.Add(currMaterial, currQuantity);
                    }

                    if (materials["shards"] >= 250 || materials["motes"] >= 250 || materials["fragments"] >= 250)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            if (materials["shards"] >= 250)
            {
                materials["shards"] -= 250;

                Console.WriteLine($"Shadowmourne obtained!");
            }
            else if (materials["motes"] >= 250)
            {
                materials["motes"] -= 250;

                Console.WriteLine($"Dragonwrath obtained!");
            }
            else if (materials["fragments"] >= 250)
            {
                materials["fragments"] -= 250;

                Console.WriteLine($"Valanyr obtained!");
            }

            foreach (var item in materials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
