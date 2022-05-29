using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace P01.Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();

            Random rnd = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                rnd.Next(0, text.Length - 1);
                Console.WriteLine(text[i]);
            }
        }
    }
}
