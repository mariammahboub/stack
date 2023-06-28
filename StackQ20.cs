using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class StackQ20
    {
        static void Main(string[] args)
        {
            var stack1 = new Stack<int>(new[] { 1, 2, 3, 4, 5 });
            var stack2 = new Stack<int>(new[] { 3, 4, 5, 6, 7 });
            var commonElements = FindCommonElements(stack1, stack2);
            Console.WriteLine("Common Elements:");
            while (commonElements.Count > 0)
            {
                int element = commonElements.Pop();
                Console.WriteLine(element);
            }
        }
        static Stack<int> FindCommonElements(Stack<int> stack1, Stack<int> stack2)
        {
            return new Stack<int>(stack2.Where(element => stack1.Contains(element)));
        }

    }
}
