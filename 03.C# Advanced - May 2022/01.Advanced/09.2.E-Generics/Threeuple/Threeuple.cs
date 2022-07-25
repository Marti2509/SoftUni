using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<TItem1, TItem2, TItem3>
    {
        private TItem1 item1;
        private TItem2 item2;
        private TItem3 item3;

        public Threeuple(TItem1 item1, TItem2 item2, TItem3 item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }
}
