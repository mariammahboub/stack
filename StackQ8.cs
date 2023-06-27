using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ8
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

            public bool CheckNumber(T value)
            {
                foreach (T item in data)
                {
                    if (EqualityComparer<T>.Default.Equals(item, value))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
