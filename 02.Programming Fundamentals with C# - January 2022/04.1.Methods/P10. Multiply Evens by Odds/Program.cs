using System;

namespace P10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);

            Console.WriteLine(Math.Abs(GetMultipleOfEvenAndOdds(evenSum, oddSum)));
        }

        static int GetSumOfEvenDigits(string number)
        {
            int evenSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int curNum = number[i] - 48;

                if (curNum % 2 == 0)
                {
                    evenSum += curNum;
                }
            }

            return evenSum;
        }

        static int GetSumOfOddDigits(string number)
        {
            int oddSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int curNum = number[i] - 48;

                if (curNum % 2 == 1)
                {
                    oddSum += curNum;
                }
            }

            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
