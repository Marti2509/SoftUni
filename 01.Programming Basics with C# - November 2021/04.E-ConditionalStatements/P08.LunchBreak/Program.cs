using System;

namespace P08.Lunch_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int epizode = int.Parse(Console.ReadLine());
            int pochivkaTime = int.Parse(Console.ReadLine());

            double vremeZaObqd = pochivkaTime * 0.125;
            double vremeZaOtdih = pochivkaTime * 0.25;
            double ostavashtoVreme = pochivkaTime - vremeZaObqd - vremeZaOtdih;

            if (ostavashtoVreme >= epizode)
            {
                double obshto = Math.Ceiling(ostavashtoVreme - epizode);
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Abs(obshto)} minutes free time.");
            }
            else
            {
                double obshto = Math.Ceiling(epizode - ostavashtoVreme);
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Abs(obshto)} more minutes.");
            }
        }
    }
}
