using System;

namespace P07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int videocarti = int.Parse(Console.ReadLine());
            int procesori = int.Parse(Console.ReadLine());
            int ramPament = int.Parse(Console.ReadLine());


            double videocartiPr = videocarti * 250;
            double procesoriPrice = videocartiPr * 0.35;
            double procesoriPr = procesoriPrice * procesori;
            double ramPametPrice = videocartiPr * 0.1;
            double ramPametPr = ramPametPrice * ramPament;
            double obshto = videocartiPr + procesoriPr + ramPametPr;

            if (videocarti > procesori)
            {
                obshto = obshto - obshto * 0.15;
            }

            if (obshto <= buget)
            {
                Console.WriteLine($"You have {Math.Abs(obshto - buget):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(buget - obshto):f2} leva more!");
            }
        }
    }
}
