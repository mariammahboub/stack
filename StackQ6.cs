using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ6
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

            public Stack<T> DeleteAtPosition(T num)
            {
                Stack<T> temp = new Stack<T>();

                for (int i = 0; i <= top; i++)
                {
                    if (!EqualityComparer<T>.Default.Equals(num, data[i]))
                    {
                        temp.Push(data[i]);
                    }
                }

                return temp;
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();
            stackObj.Push(1);
            stackObj.Push(2);
            stackObj.Push(3);
            stackObj.Push(4);
            stackObj.DeleteAtPosition(2);
        }
    }
}

