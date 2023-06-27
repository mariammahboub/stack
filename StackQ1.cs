using System;
using System.Collections.Generic;
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

            public void push(int value)
            {
                Node newNode = new Node();
                newNode.data = value;
                if (isEmpty())
                {
                    newNode.next = null;
                }
                else
                {
                    newNode.next = top;
                    top = newNode;
                }
            }
            public void pop()
            {
                if (isEmpty())
                    return;
                Node temp = top;
                top = top.next;
                temp = null;
            }
            public bool isEmpty()
            {
                return (top == null);
            }
        }
        static void Main(string[] args)
        {
            Stack stackObj = new Stack();
            stackObj.push(1);
            stackObj.push(2);
            stackObj.push(3);
            stackObj.push(4);
            stackObj.pop();
            stackObj.pop();
            Console.WriteLine(stackObj.isEmpty());
        }
    }
}





