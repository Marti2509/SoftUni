using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(input);
            }

            int startIndex = 0;

            while (true)
            {
                int totalLitersOfPetrol = 0;
                bool isTourComplete = true;

                foreach (int[] item in queue)
                {
                    int currentLiters = item[0];
                    int currentDistance = item[1];

                    totalLitersOfPetrol += currentLiters;

                    if (totalLitersOfPetrol - currentDistance < 0)
                    {
                        startIndex++;
                        int[] currentPump = queue.Dequeue();
                        queue.Enqueue(currentPump);
                        isTourComplete = false;
                        break;
                    }

                    totalLitersOfPetrol -= currentDistance;
                }

                if (isTourComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }

            }
        }
    }
}
