using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public Stack()
        {
            stack = new List<T>();
        }

        public void Push(params T[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                stack.Add(items[i]);
            }
        }

        public void Pop()
        {
            if (stack.Count == 0)
                Console.WriteLine("No elements");
            else
                stack.RemoveAt(stack.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
