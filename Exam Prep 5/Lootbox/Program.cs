﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            int sum = 0;

            while (true)
            {
                if (firstBox.Count == 0 || secondBox.Count == 0)
                {
                    break;
                }

                if ((firstBox.Peek() + secondBox.Peek()) % 2 == 0)
                {
                    sum += (firstBox.Dequeue() + secondBox.Pop());
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
