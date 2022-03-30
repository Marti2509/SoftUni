using System;

namespace P07.The_Smallest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int min = int.MaxValue;

            while (input != "Stop")
            {
                int currNum = int.Parse(input);

                if (currNum <= min)
                {
                    min = currNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
