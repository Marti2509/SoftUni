using System;
using System.Linq;

namespace P03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixInfo[0], matrixInfo[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = info[col];
                }
            }

            int max = int.MinValue;
            int bestRow = 0;
            int bestcCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum = matrix[row, col] +
                                   matrix[row, col + 1] +
                                   matrix[row, col + 2] +
                                   matrix[row + 1, col] +
                                   matrix[row + 1, col + 1] +
                                   matrix[row + 1, col + 2] +
                                   matrix[row + 2, col] +
                                   matrix[row + 2, col + 1] +
                                   matrix[row + 2, col + 2];

                    if (currSum > max)
                    {
                        max = currSum;
                        bestRow = row;
                        bestcCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {max}");
            Console.WriteLine($"{matrix[bestRow, bestcCol]} {matrix[bestRow, bestcCol + 1]} {matrix[bestRow, bestcCol + 2]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestcCol]} {matrix[bestRow + 1, bestcCol + 1]} {matrix[bestRow + 1, bestcCol + 2]}");
            Console.WriteLine($"{matrix[bestRow + 2, bestcCol]} {matrix[bestRow + 2, bestcCol + 1]} {matrix[bestRow + 2, bestcCol + 2]}");
        }
    }
}
