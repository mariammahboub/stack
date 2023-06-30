using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class StackQ9
    {
        public class Stack
        {
            private List<int> data;
            private int top;
            public Stack()
            {
                data = new List<int>();
                top = -1;
                capacity = 0;
            }

            public void Push(int item)
            {
                top++;
                data.Add(item);
            }

            public int Count()
            {
                return top + 1;
            }
        }

        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Count());
        }
    }
}
