using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<TItem1, TItem2>
    {
        private TItem1 item1;
        private TItem2 item2;

        public Tuple(TItem1 item1, TItem2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2}";
        }
    }
}
