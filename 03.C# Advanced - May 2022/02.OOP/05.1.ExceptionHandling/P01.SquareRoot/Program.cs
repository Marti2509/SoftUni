using System;

namespace P01.SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(SquareRoot(number));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        public static int SquareRoot(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

            return (int)Math.Sqrt(number);
        }
    }
}
