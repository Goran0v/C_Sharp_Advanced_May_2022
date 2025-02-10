using System;
using System.Linq;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Sum(arr, 0));
        }

        static long Sum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index] + Sum(arr, index + 1);
        }
    }
}