using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> player2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (player1.Count == 0)
                {
                    break;
                }
                if (player2.Count == 0)
                {
                    break;
                }

                if (player1[0] == player2[0])
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player1[0] > player2[0])
                {
                    int player1Card = player1[0];
                    int player2Card = player2[0];

                    player1.RemoveAt(0);
                    player2.RemoveAt(0);

                    player1.Add(player1Card);
                    player1.Add(player2Card);
                }
                else
                {
                    int player1Card = player1[0];
                    int player2Card = player2[0];

                    player1.RemoveAt(0);
                    player2.RemoveAt(0);

                    player2.Add(player2Card);
                    player2.Add(player1Card);
                }
            }

            if (player1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            }
        }
    }
}
