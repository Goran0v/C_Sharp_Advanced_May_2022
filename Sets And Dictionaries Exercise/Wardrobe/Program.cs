using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothing = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" -> ").ToArray();
                string[] clothes = arr[1].Split(',').ToArray();
                string color = arr[0];
                if (!clothing.ContainsKey(color))
                {
                    clothing.Add(color, new Dictionary<string, int>());
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!clothing[color].ContainsKey(clothes[j]))
                        {
                            clothing[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            clothing[color][clothes[j]]++;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!clothing[color].ContainsKey(clothes[j]))
                        {
                            clothing[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            clothing[color][clothes[j]]++;
                        }
                    }
                }
            }

            string[] itemToLookFor = Console.ReadLine().Split(' ');
            foreach (var clothe in clothing)
            {
                Console.WriteLine($"{clothe.Key} clothes:");
                foreach (var cloth in clothe.Value)
                {
                    if (clothe.Key == itemToLookFor[0] && cloth.Key == itemToLookFor[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
