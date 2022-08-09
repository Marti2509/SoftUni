using System;
using System.Collections.Generic;

namespace P06.MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',');

            Dictionary<int, double> accounts = new Dictionary<int, double>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] currAccount = input[i].Split('-');

                accounts.Add(int.Parse(currAccount[0]), double.Parse(currAccount[1]));
            }

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "End")
            {
                try
                {
                    DepositOrWithdraw(accounts, command);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                    command = Console.ReadLine().Split(' ');
                }
            }
        }

        private static void DepositOrWithdraw(Dictionary<int, double> accounts, string[] command)
        {
            if (command[0] != "Deposit" && command[0] != "Withdraw")
            {
                throw new ArgumentException("Invalid command!");
            }
            else if (!accounts.ContainsKey(int.Parse(command[1])))
            {
                throw new ArgumentException("Invalid account!");
            }
            else if (command[0] == "Withdraw" && accounts[int.Parse(command[1])] < double.Parse(command[2]))
            {
                throw new ArgumentException("Insufficient balance!");
            }

            if (command[0] == "Deposit")
            {
                accounts[int.Parse(command[1])] += double.Parse(command[2]);
                Console.WriteLine($"Account {int.Parse(command[1])} has new balance: {accounts[int.Parse(command[1])]:f2}");
            }
            else
            {
                accounts[int.Parse(command[1])] -= double.Parse(command[2]);
                Console.WriteLine($"Account {int.Parse(command[1])} has new balance: {accounts[int.Parse(command[1])]:f2}");
            }
        }
    }
}
