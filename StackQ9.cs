using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class StackQ9
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
            public void RemoveDuplicates()
            {
                List<T> temp = new List<T>();
                Stack<T> theTemp = new Stack<T>();

                for (int i = 0; i <= top; i++)
                {
                    if (!temp.Contains(data[i]))
                    {
                        temp.Add(data[i]);
                        theTemp.Push(data[i]);
                    }
                }
                data = theTemp.data;
                top = theTemp.top;
                capacity = theTemp.capacity;
                foreach (T item in data)
                {
                    Console.WriteLine(item);
                }
            }
            public void Push(T item)
            {
                capacity++;
                top++;
                data.Add(item);
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();
            stackObj.Push(1);
            stackObj.Push(2);
            stackObj.Push(3);
            stackObj.Push(2);
            stackObj.RemoveDuplicates();
        }
    }
}
