using System;
using System.Linq;
using System.Collections.Generic;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ').ToList();
            Predicate<int> isHigher = sum => sum >= n;

            int sum = 0;
            foreach (var name in names)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (isHigher(sum))
                {
                    Console.WriteLine(name);
                    break;
                }
                sum = 0;
            }
        }
    }
}
