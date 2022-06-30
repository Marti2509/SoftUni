using System;

namespace P04.Toy_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacPr = double.Parse(Console.ReadLine());

            int puzeli = int.Parse(Console.ReadLine());
            int kukli = int.Parse(Console.ReadLine());
            int mecheta = int.Parse(Console.ReadLine());
            int minioni = int.Parse(Console.ReadLine());
            int kamioncheta = int.Parse(Console.ReadLine());

            double pizeliPr = puzeli * 2.60;
            double kukliPr = kukli * 3.00;
            double mechetaPr = mecheta * 4.10;
            double minioniPr = minioni * 8.20;
            double kamionchetamPr = kamioncheta * 2.00;

            int broiIgrachki = puzeli + kukli + mecheta + minioni + kamioncheta;
            double obshtoPr = pizeliPr + kukliPr + mechetaPr + minioniPr + kamionchetamPr;

            if (broiIgrachki >= 50)
            {
                double otstupka = obshtoPr * 0.25;
                obshtoPr = obshtoPr - otstupka;
            }

            obshtoPr = obshtoPr - obshtoPr * 0.1;

            if (obshtoPr >= vacPr)
            {
                Console.WriteLine($"Yes! {(obshtoPr - vacPr):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(vacPr - obshtoPr):f2} lv needed.");
            }
        }
    }
}
