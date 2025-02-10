﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            Console.WriteLine($"{string.Join(", ", numbers)}");
        }
    }
}
