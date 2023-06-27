using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ1
    {
        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();
            stackObj.Push(1);
            stackObj.Push(2);
            stackObj.Push(3);
            stackObj.Push(4);
            stackObj.Pop();
            var poppedValue = stackObj.Pop();
            Console.WriteLine(stackObj.Peek());
            var isEmpty = stackObj.IsEmpty();
            Console.WriteLine(isEmpty);
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

            public T Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return default(T);
                }

                T item = data[top];
                data.RemoveAt(top--);
                capacity--;

                return item;
            }

            public T Peek()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return default(T);
                }

                return data[top];
            }
            public void Display()
            {
                foreach (var item in data)
                {
                    Console.WriteLine(item);
                }
            }
            public bool IsEmpty()
            {
                return (top == -1);
            }
        }
    }
}




