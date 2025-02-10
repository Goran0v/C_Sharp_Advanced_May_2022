using System;
using System.Linq;
using System.Collections.Generic;

namespace SumNumbers
{
    class Program
    {
        static int Parse(string str)
        {
            return int.Parse(str);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] nums = input.Split(", ").Select(Parse).ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum());
        }
    }
}
