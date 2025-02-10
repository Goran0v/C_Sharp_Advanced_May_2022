using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = arr[0];
            int m = arr[1];
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();
            HashSet<int> mixed = new HashSet<int>();

            int[] nums = new int[n + m];
            for (int i = 0; i < n + m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
                if (i + 1 > n)
                {
                    second.Add(num);
                }
                else
                {
                    first.Add(num);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (first.Contains(nums[i]) && second.Contains(nums[i]))
                {
                    mixed.Add(nums[i]);
                }
            }

            foreach (var num in mixed)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
