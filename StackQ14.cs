using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ14{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        Console.WriteLine("Stack Before left rotation:");
        PrintStack(stack);
        RotateLeft(stack);
        Console.WriteLine("Stack after left rotation first three elments in stack :");
        PrintStack(stack);
    }
    static void RotateLeft(Stack<int> stack)
    {
        if (stack.Count <= 1)
            return;
        LinkedList<int> linkedList = new LinkedList<int>(stack);
        LinkedListNode<int> firstNode = linkedList.First;
        linkedList.RemoveFirst();
        linkedList.AddLast(firstNode);
        stack.Clear();
        foreach (int element in linkedList)
        {
            stack.Push(element);
        }
    }
    static void PrintStack(Stack<int> stack)
    {
        foreach (int element in stack)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
}
