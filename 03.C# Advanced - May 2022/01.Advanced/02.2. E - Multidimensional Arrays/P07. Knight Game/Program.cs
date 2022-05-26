using System;

namespace P07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int boardSize = int.Parse(Console.ReadLine());

            char[,] board = new char[boardSize, boardSize];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = input[col];
                }
            }

            if (boardSize <= 2)
            {
                Console.WriteLine(0);
                return;
            }

            int removedKinghts = 0;
            int count = 0;
            int max = 0;

            while (max != int.MinValue)
            {
                max = int.MinValue;
                int bestRow = -1;
                int bestCol = -1;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        if (board[row, col] == 'K')
                        {
                            //UP LEFT
                            if (row >= 2 && col >= 1 && board[row - 2, col - 1] == 'K')
                            {
                                count++;
                            }

                            //UP RIGHT
                            if (row >= 2 && col <= board.GetLength(1) - 2 && board[row - 2, col + 1] == 'K')
                            {
                                count++;
                            }

                            //DOWN LEFT
                            if (row <= (board.GetLength(0)) - 3 && col >= 1 && board[row + 2, col - 1] == 'K')
                            {
                                count++;
                            }

                            //DOWN RIGHT
                            if (row <= (board.GetLength(0)) - 3 && col <= board.GetLength(1) - 2 && board[row + 2, col + 1] == 'K')
                            {
                                count++;
                            }

                            //LEFT UP
                            if (row >= 1 && col >= 2 && board[row - 1, col - 2] == 'K')
                            {
                                count++;
                            }

                            //LEFT DOWN
                            if (row <= board.GetLength(0) - 2 && col >= 2 && board[row + 1, col - 2] == 'K')
                            {
                                count++;
                            }

                            //RIGHT UP
                            if (row >= 1 && col <= board.GetLength(1) - 3 && board[row - 1, col + 2] == 'K')
                            {
                                count++;
                            }

                            //RIGHT DOWN
                            if (row <= board.GetLength(0) - 2 && col <= board.GetLength(1) - 3 && board[row + 1, col + 2] == 'K')
                            {
                                count++;
                            }

                            if (max < count)
                            {
                                max = count;
                                bestRow = row;
                                bestCol = col;
                            }

                            count = 0;
                        }

                    }
                }
                if (max > 0)
                {
                    removedKinghts++;
                    board[bestRow, bestCol] = '0';
                }
                else
                {
                    Console.WriteLine(removedKinghts);
                    break;
                }
            }
        }
    }
}
