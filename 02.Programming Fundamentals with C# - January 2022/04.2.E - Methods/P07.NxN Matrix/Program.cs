using System;

namespace P07.NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            NxN(num);
        }

        static void NxN(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
