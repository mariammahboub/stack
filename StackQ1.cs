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
            private Node top = null;

            public void Push(int value)
            {
                Node newNode = new Node();
                newNode.data = value;
                if (IsEmpty())
                {
                    newNode.next = null;
                }
                else
                {
                    newNode.next = top;
                    top = newNode;
                }
            }
            public void Pop()
            {
                if (IsEmpty())
                    return;
                Node temp = top;
                top = top.next;
                temp = null;
            }
            public bool IsEmpty()
            {
                return (top == null);
            }
            public int Peek()
            {
                if (IsEmpty())
                    throw new InvalidOperationException("Stack is empty");
                return top.data;
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
