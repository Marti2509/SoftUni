using System;

namespace P09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            int obshtobem = duljina * shirochina * visochina;
            double obemvlitri = obshtobem * 0.001;
            double zaetomqsto = procent / 100;

            double nujnilitri = obemvlitri * (1 - zaetomqsto);

            Console.WriteLine(nujnilitri);
        }
    }
}
