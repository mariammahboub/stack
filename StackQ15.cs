using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        Console.WriteLine("stack: ");
        PrintStack(stack);
        SwapTopTwoElements(stack);
        Console.WriteLine("Stack after swapping top two elements: ");
        PrintStack(stack);
    }
    static void SwapTopTwoElements(Stack<int> stack)
    {
        if (stack.Count < 2)
            return;
        int topElement = stack.Pop();
        int secondTopElement = stack.Pop();

        stack.Push(topElement);
        stack.Push(secondTopElement);
    }
    static void PrintStack(Stack<int> stack)
    {
        foreach (int element in stack)
        {
            Console.Write(element + "  ");
        }
        Console.WriteLine();
    }
}
