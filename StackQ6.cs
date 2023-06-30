using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class StackQ6
    {
            public class Stack
            {
                private List<int> data;
                private int top;
                private int capacity;
                public Stack()
                {
                    data = new List<int>();
                    top = -1;
                    capacity = 0;
                }
                public void Push(int item)
                {
                    data.Add(item);
                    top++;
                }
                public List<int> DeleteAtPosition(int num)
                {
                    List<int> temp = new List<int>();

                    for (int i = 0; i <= top; i++)
                    {
                        if (num != data[i])
                        {
                            temp.Add(data[i]);
                        }
                    }

                    return temp;
                }

                static void Main(string[] args)
                {
                    Stack stackObj = new Stack();
                    stackObj.Push(1);
                    stackObj.Push(2);
                    stackObj.Push(3);
                    stackObj.Push(4);
                    List<int> result = stackObj.DeleteAtPosition(2);
                    foreach (int item in result)
                    {
                        Console.WriteLine(item);
                    }
                }
    }
}

