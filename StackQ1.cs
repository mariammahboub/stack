using System;
namespace ConsoleApp1
{
    internal class StackQ1
    {
        public class Node
        {
            public int data;
            public Node next;
        }
        public class Stack
        {
            private int[] data;
            private int top;
            public Stack()
            {
                data = new int[100]; // Adjust the size as needed
                top = -1;
            }
            public void Push(int value)
            {
                if (top == data.Length - 1)
                {
                    Console.WriteLine("Stack is full");
                    return;
                }
                top++;
                data[top] = value;
            }
            public void Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                top--;
            }

            public bool IsEmpty()
            {
                return (top == -1);
            }
            public int Peek()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }

                return data[top];
            }
        }
        static void Main(string[] args)
        {
            Stack stackObj = new Stack();
            stackObj.Push(1);
            stackObj.Push(2);
            stackObj.Push(3);
            stackObj.Push(4);
            stackObj.Pop();
            stackObj.Pop();
            Console.WriteLine(stackObj.Peek());
            Console.WriteLine(stackObj.IsEmpty());
        }
    }
}
