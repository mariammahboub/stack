using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ9
    {
        public class Stack1
        {
            private List<int> data;
            private int top;
            private int capacity;

            public Stack1()
            {
                data = new List<int>();
                top = -1;
                capacity = 0;
            }

            public void Push(int item)
            {
                capacity++;
                top++;
                data.Add(item);
            }

            public int Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }

                int item = data[top];
                data.RemoveAt(top--);
                capacity--;

                return item;
            }

            public int Count()
            {
                return top + 1;
            }

            public void MergeStack(Stack2 stack2)
            {
                while (stack2.Count() > 0)
                {
                    Push(stack2.Pop());
                }
            }
        }

        public class Stack2
        {
            private List<int> data;
            private int top;
            private int capacity;

            public Stack2()
            {
                data = new List<int>();
                top = -1;
                capacity = 0;
            }

            public void Push(int item)
            {
                capacity++;
                top++;
                data.Add(item);
            }

            public int Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }

                int item = data[top];
                data.RemoveAt(top--);
                capacity--;

                return item;
            }

            public int Count()
            {
                return top + 1;
            }

            public List<int> GetData()
            {
                return data;
            }

            public void MergeStack(Stack1 stack)
            {
                while (stack.Count() > 0)
                {
                    Push(stack.Pop());
                }
            }
        }
        public static void Main(string[] args)
        {
            Stack1 stack1 = new Stack1();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            Stack2 stack2 = new Stack2();
            stack2.Push(4);
            stack2.Push(5);
            stack2.Push(6);

            stack2.MergeStack(stack1);
            Console.WriteLine(string.Join(", ", stack2.GetData()));
        }
    }
}

