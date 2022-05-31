using System;
using System.Collections.Generic;

namespace P02.A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();

            string resourse = Console.ReadLine();

            while (resourse != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (miner.ContainsKey(resourse))
                {
                    miner[resourse] += quantity;
                }
                else
                {
                    miner.Add(resourse, quantity);
                }

                resourse = Console.ReadLine();
            }

            foreach (var item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
