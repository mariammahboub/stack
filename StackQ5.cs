using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ5<T>
    {
        private List<T> data;
        private int top;
        private int capacity;

        public StackQ5()
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

        public void MinNumber()
        {
            T temp = data[0];
            for (int i = 0; i <= top; i++)
            {
                if (Comparer<T>.Default.Compare(data[i], temp) > 0)
                {
                    temp = data[i];
                }
            }
            Console.WriteLine(temp);
        }

        static void Main(string[] args)
        {
            StackQ5<int> stackObj = new StackQ5<int>();
            stackObj.Push(4);
            stackObj.Push(2);
            stackObj.Push(6);
            stackObj.Push(1);
            stackObj.MinNumber();
        }
    }
}
