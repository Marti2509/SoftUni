using System;

namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string bigger = string.Empty;
            decimal volume = decimal.MinValue;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volumeNew = (decimal)(Math.PI * Math.Pow((double)radius, 2) * height);

                if (volumeNew > volume)
                {
                    bigger = model;
                    volume = volumeNew;
                }
            }

            Console.WriteLine(bigger);
        }
    }
}
