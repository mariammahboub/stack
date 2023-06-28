using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ19
    {

        static void Main()
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            bool areEqual = AreStacksEqual(stack1, stack2);
            Console.WriteLine("Are the stacks equal? " + areEqual);
        }
        static bool AreStacksEqual(Stack<int> stack1, Stack<int> stack2)
        {
            if (stack1.Count != stack2.Count)
                return false;

            while (stack1.Count > 0)
            {
                if (stack1.Pop() != stack2.Pop())
                    return false;
            }

            return true;
        }

    }
}
