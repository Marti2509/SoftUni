using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double pricePerCapsule = 0;
            int days = 0;
            int capsuleCount = 0;
            double orderPrice = 0;

            double totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsuleCount = int.Parse(Console.ReadLine());

                orderPrice = (days * capsuleCount) * pricePerCapsule;

                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
