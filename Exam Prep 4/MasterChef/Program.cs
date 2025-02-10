using System;
using System.Linq;
using System.Collections.Generic;

namespace MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Dictionary<string, int> dishes = new Dictionary<string, int>
            {
                { "Dipping sauce", 0 },
                { "Green salad", 0 },
                { "Chocolate cake", 0 },
                { "Lobster", 0 }
            };

            while (true)
            {
                if (ingredients.Count == 0 || freshness.Count == 0)
                {
                    break;
                }
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int sum = ingredients.Peek() * freshness.Peek();
                if (sum == 150)
                {
                    dishes["Dipping sauce"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (sum == 250)
                {
                    dishes["Green salad"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (sum == 300)
                {
                    dishes["Chocolate cake"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (sum == 400)
                {
                    dishes["Lobster"]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    int newIngredient = ingredients.Dequeue() + 5;
                    ingredients.Enqueue(newIngredient);
                }
            }

            bool isDone = false;
            if (dishes["Dipping sauce"] >= 1 && dishes["Green salad"] >= 1 && dishes["Chocolate cake"] >= 1 && dishes["Lobster"] >= 1)
            {
                isDone = true;
            }

            if (!isDone)
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredients.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                foreach (var dish in dishes.OrderBy(d => d.Key))
                {
                    if (dish.Value >= 1)
                    {
                        Console.WriteLine($" # {dish.Key} --> {dish.Value}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                if (ingredients.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
                foreach (var dish in dishes.OrderBy(d => d.Key))
                {
                    Console.WriteLine($" # {dish.Key} --> {dish.Value}");
                }
            }
        }
    }
}
