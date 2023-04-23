using System;

namespace Exam_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int kilos = int.Parse(Console.ReadLine());
            double firstElen = double.Parse(Console.ReadLine());
            double secondElen = double.Parse(Console.ReadLine());
            double thirdElen = double.Parse(Console.ReadLine());

            double firstElenKg = days * firstElen;
            double secondElenKg = days * secondElen;
            double thirdElenKg = days * thirdElen;

            double obshto = firstElenKg + secondElenKg + thirdElenKg;

            if (obshto <= kilos)
            {
                Console.WriteLine($"{Math.Floor(kilos - obshto)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(obshto - kilos)} more kilos of food are needed.");
            }
        }
    }
}
