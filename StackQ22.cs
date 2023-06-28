using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ22
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack<int>(new[] { 1, 2, 3 });
            var stack2 = new Stack<int>(new[] { 3, 4, 5 });
            var mergedStack = MergeStacks(stack1, stack2);

            Console.WriteLine("Merged Stack:");
            while (mergedStack.Count > 0)
            {
                Console.WriteLine(mergedStack.Pop());
            }
        }
        static Stack<int> MergeStacks(Stack<int> stack1, Stack<int> stack2)
        {
            var mergedStack = new Stack<int>();
            var tempStack = new Stack<int>();

            while (stack1.Count > 0)
            {
                int element = stack1.Pop();
                tempStack.Push(element);
            }
            while (tempStack.Count > 0)
            {
                int element = tempStack.Pop();
                if (!stack2.Contains(element))
                {
                    mergedStack.Push(element);
                }
            }
            while (stack2.Count > 0)
            {
                int element = stack2.Pop();
                mergedStack.Push(element);
            }
            return mergedStack;
        }
    }
}
