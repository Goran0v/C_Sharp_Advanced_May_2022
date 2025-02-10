using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Func<int[], int> minNum = arr => arr.Min();
            Console.WriteLine(minNum(nums));
        }
    }
}
