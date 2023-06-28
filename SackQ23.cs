using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ23
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack<int>(new[] { 1, 2, 3, 4 });
            var stack2 = new Stack<int>(new[] { 3, 4, 5, 6 });
            var exclusiveStack = GetExclusiveElements(stack1, stack2);
            Console.WriteLine("Exclusive Stack:");
            while (exclusiveStack.Count > 0)
            {
                Console.WriteLine(exclusiveStack.Pop());
            }
        }
        static Stack<int> GetExclusiveElements(Stack<int> stack1, Stack<int> stack2)
        {
            var exclusiveStack = new Stack<int>();
            var tempStack = new Stack<int>();

            while (stack1.Count > 0)
            {
                int element = stack1.Pop();
                exclusiveStack.Push(element);
                tempStack.Push(element);
            }

            while (stack2.Count > 0)
            {
                int element = stack2.Pop();
                bool existsInStack1 = true;

                while (tempStack.Count > 0)
                {
                    int tempElement = tempStack.Pop();
                    if (tempElement == element)
                    {
                        existsInStack1 = true;
                        break;
                    }
                }
                if (!existsInStack1)
                {
                    exclusiveStack.Push(element);
                }
            }
            return exclusiveStack;
        }
    }

}
