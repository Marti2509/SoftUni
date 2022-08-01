using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                string[] peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in peopleInfo)
                {
                    string[] personInfo = item.Split('=', StringSplitOptions.RemoveEmptyEntries);

                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);

                    Person person = new Person(name, money);
                    people.Add(person);
                }

                string[] productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in productsInfo)
                {
                    string[] productInfo = item.Split('=', StringSplitOptions.RemoveEmptyEntries);

                    string name = productInfo[0];
                    decimal cost = decimal.Parse(productInfo[1]);

                    Product product = new Product(name, cost);
                    products.Add(product);
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                string name = command[0];
                string productName = command[1];

                Product product = products.Find(x => x.Name == productName);
                Person person = people.Find(x => x.Name == name);

                if (person.Money >= product.Cost)
                {
                    person.BagOfProducts.Add(product);
                    person.Money -= product.Cost;

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Person person in people)
            {
                if (person.BagOfProducts.Count == 0)
                    Console.WriteLine($"{person.Name} - Nothing bought");
                else
                    Console.WriteLine(
                        $"{person.Name}" +
                        $" - " +
                        $"{string.Join(", ", person.BagOfProducts.Select(x => x.Name))}");
            }
        }
    }
}
