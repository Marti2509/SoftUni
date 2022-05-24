﻿using System;
using System.Linq;

namespace P02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[info[0], info[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    currSum += matrix[row, col];
                }

                Console.WriteLine(currSum);
            }
        }
    }
}
