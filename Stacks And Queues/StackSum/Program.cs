using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(elements);
            while (true)
            {
                string cmd = Console.ReadLine();
                var items = cmd.Split(' ');
                if (items[0] == "add")
                {
                    int n1 = int.Parse(items[1]);
                    int n2 = int.Parse(items[2]);
                    numbers.Push(n1);
                    numbers.Push(n2);
                }
                else if (items[0] == "remove")
                {
                    int count = int.Parse(items[1]);
                    if (numbers.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                else if (items[0] == "end")
                {
                    var sum = numbers.ToArray().Sum();
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
            }
        }
    }
}
