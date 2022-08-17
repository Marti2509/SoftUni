using System;

namespace P03.Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingMoneyCounter = 0;

            while (money < tripPrice && spendingMoneyCounter < 5)
            {
                string command = Console.ReadLine();
                double currMoney = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save")
                {
                    money += currMoney;
                    spendingMoneyCounter = 0;
                }
                else
                {
                    money -= currMoney;
                    spendingMoneyCounter++;

                    if (money < 0)
                        money = 0;
                }
            }

            if (spendingMoneyCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
