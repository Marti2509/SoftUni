using System;

namespace P05.Balance_On_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();

            double balance = 0.0;

            while (money != "NoMoreMoney")
            {
                double currMoney = double.Parse(money);

                if (currMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {balance:f2}");

                    return;
                }

                balance += currMoney;

                Console.WriteLine($"Increase: {currMoney:f2}");

                money = Console.ReadLine();
            }

            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
