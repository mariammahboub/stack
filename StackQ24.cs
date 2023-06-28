using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class StackQ24
    {
        static void Main(string[] args)
        {
            var originalStack = new Stack<int>(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Original Stack:");
            PrintStack(originalStack);
            int startIndex = 2;
            int count = 3;
            var newStack = CreateSubStack(originalStack, startIndex, count);
            Console.WriteLine($"\nNew Stack (from index {startIndex} to {startIndex + count - 1}):");
            PrintStack(newStack);
        }
        static Stack<int> CreateSubStack(Stack<int> originalStack, int startIndex, int count)
        {
            var newStack = new Stack<int>(originalStack.Skip(startIndex).Take(count));
            return newStack;
        }
        static void PrintStack(Stack<int> stack)
        {
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
