using System;
using System.Collections.Generic;

namespace P08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passerPerOneGreen = int.Parse(Console.ReadLine());

            int counter = 0;

            Queue<string> cars = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < passerPerOneGreen; i++)
                    {
                        if (cars.Count >= 1)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");

                            counter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
