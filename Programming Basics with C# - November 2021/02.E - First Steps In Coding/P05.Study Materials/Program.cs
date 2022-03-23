using System;

namespace P05.Study_Materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int him = int.Parse(Console.ReadLine());
            int markeri = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            double namalenie = int.Parse(Console.ReadLine());

            double himc = him * 5.80;
            double markeric = markeri * 7.20;
            double preparatc = preparat * 1.20;

            double cvs = himc + markeric + preparatc;
            double namaleniebezpr = namalenie / 100;
            double cvsminusnam = cvs * namaleniebezpr;
            double cvsnam = cvs - cvsminusnam;

            Console.WriteLine(cvsnam);
        }
    }
}
