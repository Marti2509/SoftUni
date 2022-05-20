using System;

namespace _04._Revere_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            string[] reversedArray = new string[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[array.Length - i - 1] = array[i];
            }

            Console.WriteLine(string.Join(' ', reversedArray));
        }
    }
}
