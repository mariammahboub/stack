using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ7
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

            public T Pop()
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                T item = data[top];
                data.RemoveAt(top--);
                capacity--;

                return item;
            }

            public void Count()
            {
                Console.WriteLine(top + 1);
            }

            public void SpecifiedCount(T value)
            {
                int count = 0;
                foreach (T item in data)
                {
                    if (EqualityComparer<T>.Default.Equals(item, value))
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
