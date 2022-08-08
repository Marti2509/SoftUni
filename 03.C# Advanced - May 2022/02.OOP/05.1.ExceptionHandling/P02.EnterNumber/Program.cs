using System;
using System.Collections.Generic;

namespace P02.EnterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int startNum = 1;
            int endNum = 100;

            while (numbers.Count < 10)
            {
                try
                {
                    int num = ReadNumber(startNum, endNum);
                    numbers.Add(num);

                    startNum = num;
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int resultNum))
            {
                throw new ArgumentException("Invalid Number!");
            }

            int number = resultNum;

            if (number <= start || number >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            }

            return number;
        }
    }
}
