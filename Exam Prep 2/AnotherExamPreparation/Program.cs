using System;
using System.Linq;
using System.Collections.Generic;

namespace AnotherExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] steel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] carbon = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queueSteel = new Queue<int>(steel);
            Stack<int> stackCarbon = new Stack<int>(carbon);
            Dictionary<string, int> swordsCount = new Dictionary<string, int>
            {
                {"Gladius", 0},
                {"Shamshir", 0},
                {"Katana", 0},
                {"Sabre", 0},
                {"Broadsword", 0},
            };
            int totalSwords = 0;

            while (true)
            {
                if (queueSteel.Count == 0 || stackCarbon.Count == 0)
                {
                    break;
                }
                int sum = queueSteel.Peek() + stackCarbon.Peek();
                if (sum == 70)
                {
                    swordsCount["Gladius"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    totalSwords++;
                }
                else if (sum == 80)
                {
                    swordsCount["Shamshir"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    totalSwords++;
                }
                else if (sum == 90)
                {
                    swordsCount["Katana"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    totalSwords++;
                }
                else if (sum == 110)
                {
                    swordsCount["Sabre"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    totalSwords++;
                }
                else if (sum == 150)
                {
                    swordsCount["Broadsword"]++;
                    queueSteel.Dequeue();
                    stackCarbon.Pop();
                    totalSwords++;
                }
                else
                {
                    queueSteel.Dequeue();
                    int currentCarbon = stackCarbon.Pop();
                    currentCarbon += 5;
                    stackCarbon.Push(currentCarbon);
                }
            }

            if (totalSwords > 0)
            {
                Console.WriteLine($"You have forged {totalSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (queueSteel.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", queueSteel)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (stackCarbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", stackCarbon)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            if (swordsCount.Count > 0)
            {
                foreach (var sword in swordsCount.OrderBy(x => x.Key))
                {
                    if (sword.Value > 0)
                    {
                        Console.WriteLine($"{sword.Key}: {sword.Value}");
                    }
                }
            }
            
        }
    }
}
