using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ25
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(8);
            stack.Push(10);
            Console.WriteLine("Stack elements:");
            PrintStack(stack);
            bool allPositive = IsPositive(stack);
            Console.WriteLine("All elements satisfy the condition (positive): " + allPositive);
            bool allNumbers = IsNum(stack);
            Console.WriteLine("All elements satisfy the condition (numbers only): " + allNumbers);
        }
        static bool IsPositive(Stack<int> stack)
        {
            foreach (int element in stack)
            {
                if (element <= 0)
                    return false;
            }
            return true;
        }

        static bool IsNum(Stack<int> stack)
        {
            foreach (int element in stack)
            {
                if (!IsNumeric(element))
                    return false;
            }
            return true;
        }

        static bool IsNumeric(object value)
        {
            return value is int;
        }

        static void PrintStack(Stack<int> stack)
        {
            foreach (int element in stack)
            {
                if (IsNumeric(element))
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
