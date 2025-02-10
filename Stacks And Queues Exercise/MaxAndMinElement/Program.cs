using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int querie = arr[0];
                if (querie == 1)
                {
                    int currNum = arr[1];
                    stack.Push(currNum);
                }
                else if (querie == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (querie == 3)
                {
                    if (stack.Count > 0)
                    {
                        int maxEl = int.MinValue;
                        foreach (int item in stack)
                        {
                            if (maxEl < item)
                            {
                                maxEl = item;
                            }
                        }
                        Console.WriteLine(maxEl);
                    }
                }
                else if (querie == 4)
                {
                    if (stack.Count > 0)
                    {
                        int minEl = int.MaxValue;
                        foreach (int item in stack)
                        {
                            if (minEl > item)
                            {
                                minEl = item;
                            }
                        }
                        Console.WriteLine(minEl);
                    }
                }
            }

            while (stack.Count != 0)
            {
                if (stack.Count != 1)
                {
                    Console.Write($"{stack.Pop()}, ");
                }
                else if (stack.Count == 1)
                {
                    Console.Write($"{stack.Pop()}");
                }
            }
        }
    }
}
