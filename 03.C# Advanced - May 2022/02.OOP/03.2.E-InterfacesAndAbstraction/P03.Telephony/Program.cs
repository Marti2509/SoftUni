using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            List<string> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> websites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string number in numbers)
            {
                if (number.All(Char.IsDigit))
                {
                    if (number.Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (string site in websites)
            {
                if (!site.Any(Char.IsDigit))
                {
                    Console.WriteLine(smartphone.BrowseSite(site));
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }
            }
        }
    }
}
