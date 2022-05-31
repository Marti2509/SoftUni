using System;
using System.Collections.Generic;

namespace P08.Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            bool flag = false;

            while (command != "End")
            {
                string[] info = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = info[0];
                string workerId = info[1];

                foreach (var item in companies)
                {
                    if (item.Key == companyName)
                    {
                        foreach (var id in item.Value)
                        {
                            if (id == workerId)
                            {
                                flag = true;
                                continue;
                            }
                        }
                    }
                    if (flag)
                    {
                        continue;
                    }
                }
                if (flag)
                {
                    command = Console.ReadLine();
                    flag = false;
                    continue;
                }

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                companies[companyName].Add(workerId);

                command = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
