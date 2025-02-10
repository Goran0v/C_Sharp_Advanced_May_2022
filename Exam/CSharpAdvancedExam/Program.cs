using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpAdvancedExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                { "Sink", 0},
                { "Oven", 0},
                { "Countertop", 0},
                { "Wall", 0},
                { "Floor", 0}
            };

            while (true)
            {
                if (whiteTiles.Count == 0 || greyTiles.Count == 0)
                {
                    break;
                }

                if (whiteTiles.Peek() == greyTiles.Peek())
                {
                    int sum = whiteTiles.Peek() + greyTiles.Peek();
                    if (sum == 40)
                    {
                        locations["Sink"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (sum == 50)
                    {
                        locations["Oven"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (sum == 60)
                    {
                        locations["Countertop"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else if (sum == 70)
                    {
                        locations["Wall"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                    else
                    {
                        locations["Floor"]++;
                        whiteTiles.Pop();
                        greyTiles.Dequeue();
                    }
                }
                else
                {
                    int whiteTile = whiteTiles.Pop() / 2;
                    whiteTiles.Push(whiteTile);
                    int greyTile = greyTiles.Dequeue();
                    greyTiles.Enqueue(greyTile);
                }
            }

            if (whiteTiles.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }

            if (greyTiles.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }

            foreach (var tile in locations.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                if (tile.Value > 0)
                {
                    Console.WriteLine($"{tile.Key}: {tile.Value}");
                }
            }
        }
    }
}
