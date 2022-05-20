using System;
using System.Linq;

namespace P05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lastTopInt = int.MinValue;
            string topInts = "";

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        if (lastTopInt == arr[i])
                        {
                            continue;
                        }
                        else
                        {
                            lastTopInt = arr[i];

                            topInts += $"{arr[i]} ";
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            topInts += $"{arr[arr.Length - 1]}";

            Console.WriteLine(topInts);
        }
    }
}
