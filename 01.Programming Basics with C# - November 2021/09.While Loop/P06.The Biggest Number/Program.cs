using System;

namespace P06.The_Biggest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int max = int.MinValue;

            while (input != "Stop")
            {
                int currNum = int.Parse(input);

                if (currNum >= max)
                {
                    max = currNum;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
