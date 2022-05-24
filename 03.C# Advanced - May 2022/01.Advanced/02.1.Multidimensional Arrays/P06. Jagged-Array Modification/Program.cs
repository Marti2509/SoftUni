using System;
using System.Linq;

namespace P06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                jagged[row] = new int[currRow.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = currRow[col];
                }
            }

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command[0] == "Add")
                {
                    if (jagged.Length - 1 >= row && jagged[row].Length - 1 >= col)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (jagged.Length - 1 >= row && jagged[row].Length - 1 >= col)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine().Split(' ');
            }

            for (int row = 0; row < jagged.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(' ', jagged[row]));
            }
        }
    }
}
