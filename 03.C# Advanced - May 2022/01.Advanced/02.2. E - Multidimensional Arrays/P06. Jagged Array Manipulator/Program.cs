using System;
using System.Linq;

namespace P06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] matrix = new long[n][];

            for (int row = 0; row < matrix.Length; row++)
            {
                long[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

                matrix[row] = new long[info.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = info[col];
                }
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] = matrix[row][col] * 2;
                        matrix[row + 1][col] = matrix[row + 1][col] * 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] = matrix[row][col] / 2;
                    }

                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] = matrix[row + 1][col] / 2;
                    }
                }
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= 0 && col >= 0 && matrix.Length > row && matrix[row].Length > col)
                {
                    if (command[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(' ', matrix[row]));
            }
        }
    }
}
