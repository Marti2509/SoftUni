using System;

namespace Exam_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double obshtoRakiq = 0;
            double obshtogradusi = 0;

            for (int i = 1; i <= n; i++)
            {
                double rakiq = double.Parse(Console.ReadLine());
                double gradusi = double.Parse(Console.ReadLine());

                obshtoRakiq = obshtoRakiq + rakiq;
                obshtogradusi = obshtogradusi + rakiq * gradusi;
            }

            double srednaStoinostNaGradusite = obshtogradusi / obshtoRakiq;

            Console.WriteLine($"Liter: {obshtoRakiq:f2}");
            Console.WriteLine($"Degrees: {srednaStoinostNaGradusite:f2}");
            if (srednaStoinostNaGradusite < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (srednaStoinostNaGradusite < 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
