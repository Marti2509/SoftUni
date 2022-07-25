using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> ints = new EqualityScale<int>(8, 8);
            //EqualityScale<string> strings = new EqualityScale<string>("a", "a");

            Console.WriteLine(ints.AreEqual());
            //Console.WriteLine(strings.AreEqual());
        }
    }
}
