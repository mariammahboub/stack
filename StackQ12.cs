using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class StackDemo
    {
        private List<int> data;
        private int top;
        private int capacity;

        public StackDemo()
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

        public void RemoveDuplicite()
        {

            int[] temp = new int[] { };
            Stack theTemp = new Stack();
            for (int i = 0; i < top; i++)
            {
                if (!temp.Contains(data[i]))
                { 

                }
            }
        }

            public static void Main(string[] args)
        {
            StackDemo stack = new StackDemo();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.RemoveDuplicite();
            Console.WriteLine("Duplicates removed.");
        }
    }
}

