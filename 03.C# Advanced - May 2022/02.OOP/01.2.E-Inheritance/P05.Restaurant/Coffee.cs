using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double coffeine)
            : base(name, 3.50m, 50.00)
        {
            Coffeine = coffeine;
        }

        public double Coffeine { get; set; }
    }
}
