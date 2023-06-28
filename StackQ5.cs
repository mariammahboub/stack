using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ5<T>
    {
        public class Stack
        {
            private List<int> data;
            private int top;
            public Stack()
            {
                data = new List<int>();
                top = -1;
            }
            public void Push(int item)
            {
                data.Add(item);
                top++;
            }
            public void MinNumber()
            {
                int temp = data[0];
                for (int i = 1; i <= top; i++)
                {

                    if (temp > data[i])
                    {
                        temp = data[i];
                    }                    
                }
                Console.WriteLine(temp);
            }
            static void Main(string[] args)
            {
                Stack stackObj = new Stack();
                stackObj.Push(3);
                stackObj.Push(5);
                stackObj.Push(10);
                stackObj.Push(7);
                stackObj.MinNumber();
            }
    }
}
