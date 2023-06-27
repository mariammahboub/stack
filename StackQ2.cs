using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ2{
        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();
            stackObj.Push(3);
            stackObj.Push(1);
            stackObj.Push(4);
            stackObj.Push(2);
            stackObj.SortDescending();
        }
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
            public void SortDescending()
            {
                T temp;
                for (int i = 0; i < top; i++)
                {
                    for (int j = i + 1; j <= top; j++)
                    {
                        if (Comparer<T>.Default.Compare(data[i], data[j]) < 0)
                        {
                            temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}


