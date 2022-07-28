using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i += 2)
                yield return stones[i];

            int index = stones.Count % 2 == 0 ? stones.Count - 1 : stones.Count - 2;

            for (int i = index; i >= 0; i -= 2)
                yield return stones[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
