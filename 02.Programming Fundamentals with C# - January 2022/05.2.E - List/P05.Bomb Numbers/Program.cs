using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bomb = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] specialNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int specNumber = specialNumbers[0];
            int power = specialNumbers[1];

            for (int i = 0; i < bomb.Count; i++)
            {
                if (bomb[i] == specNumber)
                {
                    if (bomb[i] - power >= 0 && bomb[i] + power <= bomb.Count - 1)
                    {
                        bomb.RemoveRange(bomb[i] - 2, power);
                        bomb.RemoveRange(bomb[i] + 1, power);

                        bomb.RemoveAt(i - 2);
                    }

                }
            }

            Console.WriteLine(bomb.Sum());
        }
    }
}
