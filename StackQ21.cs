using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp
{
    internal class StackQ21
    {
        static void Main(string[] args)
        {
            Stack<int> stack1 = new Stack<int>(new[] { 1, 2, 3, 4, 5 });
            Stack<int> stack2 = new Stack<int>(new[] { 3, 4, 5, 6, 7 });
            Stack<int> resultStack = new Stack<int>(stack1.Except(stack2));
            Console.WriteLine("Elements in the first stack but not in the second stack:");
            foreach (int element in resultStack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
