using System;
using System.Linq;
using System.Collections.Generic;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Func<List<int>, List<int>> addFunction = list => list.Select(x => ++x).ToList();
            Func<List<int>, List<int>> subtractFunction = list => list.Select(x => --x).ToList();
            Func<List<int>, List<int>> multiplyFunction = list => list.Select(x => x * 2).ToList();
            Action<int> printFunction = num => Console.Write($"{num} ");

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "add")
                {
                    nums = addFunction(nums);
                }
                else if (input == "subtract")
                {
                    nums = subtractFunction(nums);
                }
                else if (input == "multiply")
                {
                    nums = multiplyFunction(nums);
                }
                else if (input == "print")
                {
                    foreach (var num in nums)
                    {
                        printFunction(num);
                    }
                }
            }
        }
    }
}
