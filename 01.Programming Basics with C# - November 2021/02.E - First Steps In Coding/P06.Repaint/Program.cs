using System;

namespace P06.Repaint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());
            double torbichki = 0.40;

            double obshtonailon = (nailon + 2) * 1.50;
            double obshtoboq = (boq + (boq * 0.10)) * 14.50;
            double obshtorazreditel = razreditel * 5;

            double obshtomat = obshtonailon + obshtoboq + obshtorazreditel + torbichki;
            double maistori = (obshtomat * 0.30) * chasove;

            double obshto = obshtomat + maistori;
            Console.WriteLine(obshto);
        }
    }
}
