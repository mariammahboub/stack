using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ8
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(3);
            stack.Push(7);
            stack.Push(5);
            stack.Push(2);
            stack.Push(9);
            Console.WriteLine("Original Stack:");
            PrintStack(stack);
            int elementToRemove = 5;
            RemoveElementFromStack(stack, elementToRemove);
            Console.WriteLine("\nStack after removing {0}:", elementToRemove);
            PrintStack(stack);
        }
        static void PrintStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void RemoveElementFromStack(Stack<int> stack, int element)
        {
            List<int> tempList = stack.ToList();
            tempList.RemoveAll(item => item == element);
            stack.Clear();
            foreach (int item in tempList)
            {
                stack.Push(item);
            }
        }
        }
    }

