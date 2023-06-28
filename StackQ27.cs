using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ27
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(5);
            stack.Push(13);
            stack.Push(15);
            stack.Push(-11);
            Console.WriteLine("Stack elements:");
            PrintStack(stack);
            Stack<int> filteredStack = FilterStack(stack);
            Console.WriteLine("\nFiltered Stack elements:");
            PrintStack(filteredStack);
        }
        static Stack<int> FilterStack(Stack<int> stack)
        {
            Stack<int> filteredStack = new Stack<int>();

            foreach (int element in stack)
            {
                if (element >= 0)
                    filteredStack.Push(element);
            }

            return filteredStack;
        }
        static void PrintStack(Stack<int> stack)
        {
            foreach (int element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
