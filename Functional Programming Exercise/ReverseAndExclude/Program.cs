using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            Action<List<int>> reverser = list => list.Reverse();
            reverser(numbers);
            Predicate<int> isExcluding = num => num % n == 0;
            Action<List<int>, int> excluder = (List<int> list, int n) => list.Remove(n);
            Action<int> printer = num => Console.Write(num + " ");

            for (int i = 0; i < numbers.Count; i++)
            {
                if (isExcluding(numbers[i]))
                {
                    excluder(numbers, numbers[i]);
                    i--;
                }
            }

            foreach (var num in numbers)
            {
                printer(num);
            }
        }
    }
}
