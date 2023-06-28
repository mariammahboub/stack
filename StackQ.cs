using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class StackDemo
    {
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(2);
            stack.Push(4);
            stack.Push(2);
            int targetElement = 2;
            int count = CountElementInStack(stack, targetElement);
            Console.WriteLine($"The number of occurrences of {targetElement} in the stack is: {count}");
        }
        static int CountElementInStack(Stack<int> stack, int target)
        {
            int count = 0;

            foreach (int element in stack)
            {
                if (element == target)
                    count++;
            }

            return count;
        }
    }
}
}
