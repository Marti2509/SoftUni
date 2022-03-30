using System;

namespace P03.Sum_From_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (!(sum >= number))
            {
                int curNum = int.Parse(Console.ReadLine());

                sum += curNum;
            }

            Console.WriteLine(sum);
        }
    }
}
