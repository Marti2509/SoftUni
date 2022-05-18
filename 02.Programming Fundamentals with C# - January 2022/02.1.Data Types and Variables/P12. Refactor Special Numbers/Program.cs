using System;

namespace P12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNum; i++)
            {
                int currentNum = i;
                int sum = 0;

                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool isSpecialNum = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpecialNum}");
            }
        }
    }
}
