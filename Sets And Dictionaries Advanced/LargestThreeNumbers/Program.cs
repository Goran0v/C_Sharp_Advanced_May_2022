using System;
using System.Linq;
using System.Collections.Generic;

namespace LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToList();
            for (int i = 0; i < 3; i++)
            {
                if (i < arr.Count)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}
