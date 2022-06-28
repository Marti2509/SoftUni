using System;

namespace P07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pile = int.Parse(Console.ReadLine());
            int riba = int.Parse(Console.ReadLine());
            int vegetariansko = int.Parse(Console.ReadLine());

            double pilem = pile * 10.35;
            double ribam = riba * 12.40;
            double vegetarianskom = vegetariansko * 8.15;

            double hrana = pilem + ribam + vegetarianskom;
            double desert = hrana * 0.20;
            double obshto = hrana + desert + 2.50;

            Console.WriteLine(obshto);
        }
    }
}
