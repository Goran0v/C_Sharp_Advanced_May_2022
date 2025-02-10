using System;
using System.Linq;
using System.Collections.Generic;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startNum = arr[0];
            int endNum = arr[1];
            string word = Console.ReadLine();
            Predicate<int> isEven = x => x % 2 == 0;
            if (word == "even")
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    if (isEven(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            else if (word == "odd")
            {
                for (int i = startNum; i <= endNum; i++)
                {
                    if (!isEven(i))
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
    }
}
