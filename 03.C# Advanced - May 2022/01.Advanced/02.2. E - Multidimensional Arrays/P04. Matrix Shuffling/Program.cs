using System;
using System.Linq;

namespace P04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[matrixInfo[0], matrixInfo[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (info[0] != "END")
            {
                if (info[0] == "swap" && info.Length == 5)
                {
                    int row1 = int.Parse(info[1]);
                    int col1 = int.Parse(info[2]);
                    int row2 = int.Parse(info[3]);
                    int col2 = int.Parse(info[4]);

                    if (row1 <= matrix.GetLength(0) - 1 &&
                        row2 <= matrix.GetLength(0) - 1 &&
                        col1 <= matrix.GetLength(1) - 1 &&
                        col2 <= matrix.GetLength(1) - 1)
                    {
                        string value1 = matrix[row1, col1];
                        string value2 = matrix[row2, col2];

                        matrix[row1, col1] = value2;
                        matrix[row2, col2] = value1;

                        PrintTheMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }

        static void PrintTheMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
