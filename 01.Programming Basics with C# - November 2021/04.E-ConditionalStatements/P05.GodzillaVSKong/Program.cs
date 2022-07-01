using System;

namespace P05.Godzilla_vs_Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double obleklo = double.Parse(Console.ReadLine());

            double dekor = buget * 0.1;
            double oblekloSuma = statisti * obleklo;

            if (statisti > 150)
            {
                oblekloSuma = oblekloSuma - oblekloSuma * 0.1;
            }

            double obshto = dekor + oblekloSuma;

            if (obshto > buget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(buget - obshto):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(obshto - buget):f2} leva left.");
            }
        }
    }
}
