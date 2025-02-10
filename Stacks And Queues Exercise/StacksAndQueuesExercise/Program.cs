using System;
using System.Linq;
using System.Collections.Generic;

namespace StacksAndQueuesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nums[0];
            int numsToPop = nums[1];
            int numToLookFor = nums[2];

            int[] numsToPush = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numsToPush.Length; i++)
            {
                numbers.Push(numsToPush[i]);
            }

            for (int i = 0; i < numsToPop; i++)
            {
                numbers.Pop();
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