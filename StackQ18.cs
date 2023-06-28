using System;
namespace ConsoleApp1
{
    internal class StackQ18
    {
        class Program
        {
            static void Main()
            {
                int[] mainStack = { 1, 2, 3, 4, 5 };
                int[] subsetStack = { 1, 2, 3 };
                StackSubsetChecker stackSubsetChecker = new StackSubsetChecker(mainStack, subsetStack);
                bool isSubset = stackSubsetChecker.IsSubset();
                Console.WriteLine($"Is subset: {isSubset}");
            }
            class StackSubsetChecker
        {
            private int[] mainStack;
            private int[] subsetStack;
            public StackSubsetChecker(int[] mainStack, int[] subsetStack)
            {
                this.mainStack = mainStack;
                this.subsetStack = subsetStack;
            }
            public bool IsSubset()
            {
                if (subsetStack.Length == 0)
                {
                    return true;
                }
                    if (subsetStack.Length > mainStack.Length)
                    {
                        return false;
                    }
                int mainIndex = 0;
                int subsetIndex = 0;
                while (mainIndex < mainStack.Length && subsetIndex < subsetStack.Length)
                {
                    if (mainStack[mainIndex] == subsetStack[subsetIndex])
                    {
                        subsetIndex++;
                    }

                    mainIndex++;
                }
                return subsetIndex == subsetStack.Length;
            }
        }
      
        }
    }
}
