using System;
using System.Linq;
using System.Collections.Generic;

namespace SetsAndDictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary<double, int> counter = new Dictionary<double, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!counter.ContainsKey(arr[i]))
                {
                    counter.Add(arr[i], 1);
                }
                else
                {
                    counter[arr[i]]++;
                }
            }

            foreach (var num in counter)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
