using System;

namespace P10.Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            int curNumber = 1;

            while (endNum >= curNumber)
            {
                if (DivisibleByEight(curNumber) && OneOddDigit(curNumber))
                {
                    Console.WriteLine(curNumber);
                }

                curNumber++;
            }
        }

        static bool DivisibleByEight(int number)
        {
            string numberString = number.ToString();

            int numberInOne = 0;

            if (numberString.Length == 1)
            {
                if (number % 8 == 0)
                {
                    return true;
                }
            }
            else
            {
                for (int i = 0; i < numberString.Length; i++)
                {
                    int curNum = numberString[i] - 48;

                    numberInOne += curNum;
                }

                if (numberInOne % 8 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static bool OneOddDigit(int number)
        {
            string numberString = number.ToString();

            for (int i = 0; i < numberString.Length; i++)
            {
                int curDigit = numberString[i] - 48;

                if (curDigit % 2 == 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
