using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetThrows = lostGamesCount / 2;
            int mouseThrows = lostGamesCount / 3;
            int keyboardThrows = lostGamesCount / 6;
            int displayThrows = lostGamesCount / 12;

            double priceForNewHeadsets = headsetThrows * headsetPrice;
            double priceForNewMouses = mouseThrows * mousePrice;
            double priceForNewKeyboards = keyboardThrows * keyboardPrice;
            double priceForNewDisplays = displayThrows * displayPrice;

            double endPrice = priceForNewHeadsets + priceForNewMouses + priceForNewKeyboards + priceForNewDisplays;

            Console.WriteLine($"Rage expenses: {endPrice:f2} lv.");
        }
    }
}
