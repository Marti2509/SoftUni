using System;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            Console.WriteLine(seat.Start());
            Console.WriteLine(seat.Stop());
            ICar tesla = new Tesla("Model 3", "Red", 2);
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.Stop());

            Console.WriteLine(seat);
            Console.WriteLine(tesla);
        }
    }
}
