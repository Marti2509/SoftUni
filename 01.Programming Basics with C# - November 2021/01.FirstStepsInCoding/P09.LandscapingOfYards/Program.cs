using System;

namespace P09.Landscaping_Of_Yards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kvm - kv metra ; frprice - first price ; otsprice - price s otsupkata ; flprice - final price

            double kvm = double.Parse(Console.ReadLine());

            double frprice = kvm * 7.61;
            double otsprice = frprice * 0.18;
            double flprice = frprice - otsprice;

            Console.WriteLine("The final price is: " + flprice + " lv.");
            Console.WriteLine("The discount is: " + otsprice + " lv.");
        }
    }
}
