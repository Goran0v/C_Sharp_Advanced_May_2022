using System;
using System.Collections.Generic;
using System.Linq;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            var box = new Box<int>(list);
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstIndex = arr[0];
            int secondIndex = arr[1];
            box.Swap(list, firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
