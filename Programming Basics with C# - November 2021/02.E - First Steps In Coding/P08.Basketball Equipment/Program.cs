using System;

namespace P08.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gt = int.Parse(Console.ReadLine());

            double kecove = gt * 0.60;
            double ekip = kecove * 0.80;
            double topka = ekip / 4;
            double aksesoari = topka / 5;

            double obshto = gt + kecove + ekip + topka + aksesoari;

            Console.WriteLine(obshto);
        }
    }
}
