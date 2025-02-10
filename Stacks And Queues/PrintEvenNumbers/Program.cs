using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            foreach (var num in arr)
            {
                if (num % 2 == 0)
                {
                    queue.Enqueue(num);
                }
            }

            while (queue.Count > 0)
            {
                if (queue.Count == 1)
                {
                    Console.Write($"{queue.Dequeue()}");
                }
                else
                {
                    Console.Write($"{queue.Dequeue()}, ");
                }
            }
        }
    }
}
