using System;

namespace P04.Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (Lenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (LettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (TwoDigets(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (Lenght(password) == false && LettersAndDigits(password) == false && TwoDigets(password) == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool Lenght(string password)
        {
            int count = password.Length;

            if (count >= 6 && count <= 10)
            {
                return false;
            }
            
            return true;
        }

        static bool LettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char curChar = password[i];

                if (!(curChar >= 'a' && curChar <= 'z' || curChar >= 'A' && curChar <= 'Z' || curChar >= '0' && curChar <= '9'))
                {
                    return true;
                }
            }

            return false;
        }

        static bool TwoDigets(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char curChar = password[i];

                if (curChar >= '0' && curChar <= '9')
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return false;
            }

            return true;
        }
    }
}
