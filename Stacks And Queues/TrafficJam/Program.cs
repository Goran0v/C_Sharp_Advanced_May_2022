using System;
using System.Linq;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int totalPassed = 0;
            int n = int.Parse(Console.ReadLine());
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            var car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            totalPassed++;
                        }
                    }
                }
                else if (cmd == "end")
                {
                    Console.WriteLine($"{totalPassed} cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(cmd);
                }
            }
        }
    }
}
