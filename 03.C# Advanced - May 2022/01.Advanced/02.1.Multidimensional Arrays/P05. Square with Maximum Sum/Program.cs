using System;
using System.Linq;

namespace P05._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[info[0], info[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
