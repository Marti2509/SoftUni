using System;
using System.Collections.Generic;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> heros = new List<BaseHero>();

            while (n > heros.Count)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == "Druid")
                    heros.Add(new Druid(name));
                else if (type == "Paladin")
                    heros.Add(new Paladin(name));
                else if (type == "Rogue")
                    heros.Add(new Rogue(name));
                else if (type == "Warrior")
                    heros.Add(new Warrior(name));
                else
                    Console.WriteLine("Invalid hero!");
            }

            int heroPoints = 0;

            foreach (BaseHero hero in heros)
            {
                Console.WriteLine(hero.CastAbility());
                heroPoints += hero.Power;
            }

            int bossPoints = int.Parse(Console.ReadLine());

            if (heroPoints >= bossPoints)
                Console.WriteLine("Victory!");
            else
                Console.WriteLine("Defeat...");
        }
    }
}
