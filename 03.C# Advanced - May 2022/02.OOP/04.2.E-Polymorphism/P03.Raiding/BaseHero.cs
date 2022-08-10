using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        private string name;
        private int power;

        public BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Power
        {
            get { return power; }
            private set { power = value; }
        }

        public abstract string CastAbility();
    }
}
