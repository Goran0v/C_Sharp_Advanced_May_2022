﻿using System;
using System.Linq;

namespace CustomComparator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Func<int, int, int> sortFunction = (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1 : (x % 2 != 0 && y % 2 == 0) ? 1 : x > y ? 1 : x < y ? -1 : 0;
            Array.Sort(arr, (x, y) => sortFunction(x, y));
            Console.WriteLine(string.Join(' ', arr));
        }
    }
}