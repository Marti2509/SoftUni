using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string names = personInput[0] + " " + personInput[1];
            string address = personInput[2];

            Tuple<string, string> personalInfo = new Tuple<string, string>(names, address);

            Console.WriteLine(personalInfo);

            string[] beerInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = beerInput[0];
            int leters = int.Parse(beerInput[1]);

            Tuple<string, int> beerInfo = new Tuple<string, int>(name, leters);

            Console.WriteLine(beerInfo);

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int intNum = int.Parse(input[0]);
            double doubleNum = double.Parse(input[1]);

            Tuple<int, double> info = new Tuple<int, double>(intNum, doubleNum);

            Console.WriteLine(info);
        }
    }
}
