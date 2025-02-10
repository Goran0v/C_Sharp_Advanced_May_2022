using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (queue.Count != 0)
            {
                if (quantity >= queue.Peek())
                {
                    quantity -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write($"Orders left: ");
                Console.Write($"{string.Join(" ", queue)}");
            }
        }
    }
}
