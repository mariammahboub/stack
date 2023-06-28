using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ8
    {
            public class Stack
        {
            private List<int> data;
            private int top;
            private int capacity;
            public Stack()
            {
                data = new List<int>();
                top = -1;
                capacity = 0;
            }

            public void Push(int item)
            {
                capacity++;
                top++;
                data.Add(item);
            }
            public bool CheckNumber(int value)
            {
                int count = 0;
                foreach (int i in data)
                {
                    if (i == value)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static void Main(string[] args)
            {
                Stack stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                Console.WriteLine(stack.CheckNumber(7));
            }
            }
    }
}

