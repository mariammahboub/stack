using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class StackQ2
    {
        static void Main(string[] args)
        {
            Stack<int> stackObj = new Stack<int>();
            stackObj.SortDescending();
        }
        public class Stack<T>
            {
                private List<T> data;
                private int top;
                private int capacity;
                public Stack()
                {
                    data = new List<T>();
                    top = -1;
                    capacity = 0;
                }
                public void SortDescending()
                {
                    T temp;
                    for (int i = 0; i < top; i++)
                    {
                        for (int j = i + 1; j <= top; j++)
                        {
                            if (Comparer<T>.Default.Compare(data[i], data[j]) < 0)
                            {
                                temp = data[i];
                                data[i] = data[j];
                                data[j] = temp;
                            }
                        }
                    }
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

        }
    }


