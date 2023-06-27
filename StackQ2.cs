﻿using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    internal class StackQ2{
    static void Main(string[] args)
            {
                Stack<int> stackObj = new Stack<int>();
                stackObj.Push(3);
                stackObj.Push(1);
                stackObj.Push(4);
                stackObj.Push(2);
                stackObj.SortDescending();
            }
            public class Stack<T>
            {
                private List<T> data = new List<T>();
                public void Push(T item)
                {
                    data.Add(item);
                }
                public void SortDescending()
                {
                    data.Sort();
                    data.Reverse();
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }



