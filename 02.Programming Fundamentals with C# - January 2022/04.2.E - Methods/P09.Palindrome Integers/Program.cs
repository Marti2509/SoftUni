using System;

namespace P09.Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string reversedNumber = ReversedNumber(command);

                if (Palindrome(reversedNumber, command))
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }

                command = Console.ReadLine();
            }
        }

        static string ReversedNumber(string command)
        {
            uint number = uint.Parse(command);
            string reversedNumber = string.Empty;

            for (int i = command.Length - 1; i >= 0; i--)
            {
                reversedNumber += command[i];
            }

            return reversedNumber;
        }

        static bool Palindrome(string reversedNumber, string command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] != reversedNumber[i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}
