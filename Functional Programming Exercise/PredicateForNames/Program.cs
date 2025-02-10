using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ').ToArray();
            Predicate<string> isLongEnough = name => name.Length <= n;
            for (int i = 0; i < names.Length; i++)
            {
                if (isLongEnough(names[i]))
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
