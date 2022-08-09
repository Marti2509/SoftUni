using System;

namespace P04.SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            long sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    sum += AddTheNumberToTheSum(input[i]);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine(oe.Message);
                }
                finally
                {
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }

        private static int AddTheNumberToTheSum(string input)
        {
            if (!long.TryParse(input, out long result))
            {
                throw new FormatException($"The element '{input}' is in wrong format!");
            }
            else if (result < int.MinValue || result > int.MaxValue)
            {
                throw new OverflowException($"The element '{result}' is out of range!");
            }

            return (int)result;
        }
    }
}
