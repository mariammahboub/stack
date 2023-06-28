using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ26
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(5);
            stack.Push(13);
            stack.Push(15);
            stack.Push(-11);
            stack.Push('x');
            Console.WriteLine("Stack elements:");
            PrintStack(stack);
            bool allPositive = IsPositive(stack);
            Console.WriteLine("At least one satisfy the condition (positive): " + allPositive);
            bool allNumbers = IsNum(stack);
            Console.WriteLine("At least one satisfy the condition (numbers only): " + allNumbers);
            bool hasEvenNumber = HasEvenNumber(stack);
            Console.WriteLine("At least one even number in the stack: " + hasEvenNumber);
        }

        static bool HasEvenNumber(Stack<int> stack)
        {
            foreach (int element in stack)
            {
                if (element % 2 == 0)
                    return true;
            }
            return false;
        }
        static bool IsPositive(Stack<int> stack)
        {
            foreach (int element in stack)
            {
                if (element >=0)
                    return true;
            }
            return false;
        }

        static bool IsNum(Stack<int> stack)
        {
            foreach (int element in stack)
            {
                if (IsNumeric(element))
                    return true;
            }
            return false;
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
