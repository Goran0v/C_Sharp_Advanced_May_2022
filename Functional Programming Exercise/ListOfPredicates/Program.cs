using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < dividers.Length; j++)
                {
                    Predicate<int> isDivisible = num => num % dividers[j] == 0;
                    if (isDivisible(i))
                    {
                        counter++;
                    }
                }
                if (counter == dividers.Length)
                {
                    Console.Write($"{i} ");
                }
                counter = 0;
            }
        }
    }
}
