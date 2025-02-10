using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ').ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    elements.Add(arr[j]);
                }
            }

            foreach (var element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
