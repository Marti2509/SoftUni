using System;

namespace Exam_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double procesorDolars = double.Parse(Console.ReadLine());
            double videoCardDolars = double.Parse(Console.ReadLine());
            double ramPametDolars = double.Parse(Console.ReadLine());
            int broiRamPamet = int.Parse(Console.ReadLine());
            double otstupka = double.Parse(Console.ReadLine());

            double procesorLeva = procesorDolars * 1.57;
            double videoCardLeva = videoCardDolars * 1.57;
            double RamPametLeva = ramPametDolars * 1.57;
            double obshtoRamPametLv = RamPametLeva * broiRamPamet;
            double obshtoProcesorLv = procesorLeva - procesorLeva * otstupka;
            double obshtoVideoCardLv = videoCardLeva - videoCardLeva * otstupka;

            double obshto = obshtoRamPametLv + obshtoProcesorLv + obshtoVideoCardLv;

            Console.WriteLine($"Money needed - {obshto:f2} leva.");
        }
    }
}
