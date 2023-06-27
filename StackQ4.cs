using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ4
    {
        public class Stack<T>
        {
            private List<T> data;
            private int top;
            private int capacity;

            public Stack()
            {
                data = new List<T>();
                top = -1;
                capacity = 0;
            }

            public void Push(T item)
            {
                capacity++;
                top++;
                data.Add(item);
            }

            public void MaxNumber()
            {
                T temp = data[0];
                for (int i = 0; i <= top; i++)
                {
                    if (Comparer<T>.Default.Compare(temp, data[i]) < 0)
                    {
                        temp = data[i];
                    }
                }
                Console.WriteLine(temp);
            }
        }

        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();
            stackObj.Push(3);
            stackObj.Push(5);
            stackObj.Push(2);
            stackObj.Push(7);
            stackObj.MaxNumber();
        }
    }
}