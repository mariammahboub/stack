using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int topElement = stack.Peek();
            int bottomElement = FindBottomElement(stack);
            Console.WriteLine("Top Element: " + topElement);
            Console.WriteLine("Bottom Element: " + bottomElement);
        }
        static int FindBottomElement(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return -1; 
            }
            int bottomElement = stack.Peek();
            Stack<int> tempStack = new Stack<int>();
            while (stack.Count > 0)
            {
                int element = stack.Pop();

                if (stack.Count == 0)
                    bottomElement = element;

                tempStack.Push(element);
            }
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
            return bottomElement;
        }
    }
}
