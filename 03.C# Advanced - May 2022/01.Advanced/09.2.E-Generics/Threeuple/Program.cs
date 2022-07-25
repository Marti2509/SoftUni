using System;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string names = personInput[0] + " " + personInput[1];
            string country = personInput[2];
            string town = personInput[3];

            Threeuple<string, string, string> personalInfo = new Threeuple<string, string, string>(names, country, town);

            Console.WriteLine(personalInfo);

            string[] beerInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = beerInput[0];
            int leters = int.Parse(beerInput[1]);
            bool isDrunk = false;

            if (beerInput[2] == "drunk")
                isDrunk = true;

            Threeuple<string, int, bool> beerInfo = new Threeuple<string, int, bool>(name, leters, isDrunk);

            Console.WriteLine(beerInfo);

            string[] bankInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string personName = bankInput[0];
            double bankBalance = double.Parse(bankInput[1]);
            string bankName = bankInput[2];

            Threeuple<string, double, string> bankInfo = new Threeuple<string, double, string>(personName, bankBalance, bankName);

            Console.WriteLine(bankInfo);
        }
    }
}
