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
                    capacity++;
                    top++;
                    data.Add(item);
                }
            public int PeekNthFromTop(int n)
            {
                if (n < 1 || n > data.Count)
                {
                    return -1;
                }
                else
                {
                    int index = data.Count - n;
                    return data[index];
                }
            }
        }
        public static void Main(string[] args)
            {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            int nthElement = 6;
            int element = stack.PeekNthFromTop(nthElement);
            if (element != -1)
            {
                Console.WriteLine("Element at position {0} from the top: {1}", nthElement, element);
            }
            else
            {
                Console.WriteLine("Invalid position. Position must be between 1 and the stack size.");
            }
        }
        }
