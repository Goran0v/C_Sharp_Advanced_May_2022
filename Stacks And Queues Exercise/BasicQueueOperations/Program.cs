using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nums[0];
            int numsToDequeue = nums[1];
            int numToLookFor = nums[2];

            int[] numsToPush = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numsToPush.Length; i++)
            {
                numbers.Enqueue(numsToPush[i]);
            }

            for (int i = 0; i < numsToDequeue; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(numToLookFor))
            {
                Console.WriteLine("true");
                return;
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int minNum = int.MaxValue;
                foreach (int item in numbers)
                {
                    if (minNum > item)
                    {
                        minNum = item;
                    }
                }
                Console.WriteLine(minNum);
            }
        }
    }
}
