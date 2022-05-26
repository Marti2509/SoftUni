using System;
using System.Linq;

namespace P01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = info[col];
                }
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        sum1 += matrix[row, col];
                    }

                    if (row + col == n - 1)
                    {
                        sum2 += matrix[row, col];
                    }
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Math.Abs(sum1 - sum2));
            }
        }
    }
}
