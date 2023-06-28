using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ7
    {
          static void Main()
            {
                Stack<int> stack = new Stack<int>();
                stack.Push(1);
                stack.Push(2);
                stack.Push(3);
                stack.Push(4);
                Console.WriteLine("Stack before removal:");
                PrintStack(stack);
                RemoveAllElements(stack);
                Console.WriteLine("\nStack after removal:");
                PrintStack(stack);
            }
            static void RemoveAllElements<T>(Stack<T> stack)
            {
                stack.Clear();
            }
            static void PrintStack<T>(Stack<T> stack)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty\n");
            }
        }
        }
    }

