using System;
using System.Collections.Generic;

namespace P07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLots = new HashSet<string>();

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    parkingLots.Add(input[1]);
                }
                else if (input[0] == "OUT")
                {
                    parkingLots.Remove(input[1]);
                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (parkingLots.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
                Console.WriteLine(string.Join('\n', parkingLots));
        }
    }
}
