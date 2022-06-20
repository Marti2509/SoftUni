using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Marto", 15);
            Person person2 = new Person(15);
            Person person3 = new Person();
        }
    }
}
