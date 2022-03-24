using System;

namespace P06.Swimming_world_record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordOld = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double oneMeterInSec = double.Parse(Console.ReadLine());

            double allSec = meters * oneMeterInSec;
            double fiveteenMetersSlow = (Math.Floor(meters / 15)) * 12.5;
            double obshtoVreme = allSec + fiveteenMetersSlow;

            if (obshtoVreme < recordOld)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(obshtoVreme):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(recordOld - obshtoVreme):f2} seconds slower.");
            }
        }
    }
}
