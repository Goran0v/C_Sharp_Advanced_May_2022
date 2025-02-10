using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamPreparationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SALAD = 350;
            const int SOUP = 490;
            const int PASTA = 680;
            const int STEAK = 790;

            string[] mealsArr = Console.ReadLine().Split(' ').ToArray();
            int[] calorieIntakeArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<string> meals = new List<string>(mealsArr);
            List<int> calorieIntake = new List<int>(calorieIntakeArr);
            int mealsCount = meals.Count;
            int mealsEaten = 0;

            while (true)
            {
                if (meals.Count == 0)
                {
                    break;
                }
                if (calorieIntake.Count == 0)
                {
                    break;
                }
                string currentMeal = meals[0];

                if (currentMeal == "salad")
                {
                    if (calorieIntake[calorieIntake.Count - 1] - SALAD > 0)
                    {
                        calorieIntake[calorieIntake.Count - 1] -= SALAD;
                        meals.RemoveAt(0);
                        mealsEaten++;
                    }
                    else
                    {
                        if (calorieIntake.Count > 1)
                        {
                            calorieIntake[calorieIntake.Count - 2] += calorieIntake[calorieIntake.Count - 1];
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                        }
                        else
                        {
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                            mealsEaten++;
                            meals.RemoveAt(0);
                        }
                    }
                }
                else if (currentMeal == "soup")
                {
                    if (calorieIntake[calorieIntake.Count - 1] - SOUP > 0)
                    {
                        calorieIntake[calorieIntake.Count - 1] -= SOUP;
                        meals.RemoveAt(0);
                        mealsEaten++;
                    }
                    else
                    {
                        if (calorieIntake.Count > 1)
                        {
                            calorieIntake[calorieIntake.Count - 2] += calorieIntake[calorieIntake.Count - 1];
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                        }
                        else
                        {
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                            mealsEaten++;
                            meals.RemoveAt(0);
                        }
                    }
                }
                else if (currentMeal == "pasta")
                {
                    if (calorieIntake[calorieIntake.Count - 1] - PASTA > 0)
                    {
                        calorieIntake[calorieIntake.Count - 1] -= PASTA;
                        meals.RemoveAt(0);
                        mealsEaten++;
                    }
                    else
                    {
                        if (calorieIntake.Count > 1)
                        {
                            calorieIntake[calorieIntake.Count - 2] += calorieIntake[calorieIntake.Count - 1];
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                        }
                        else
                        {
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                            mealsEaten++;
                            meals.RemoveAt(0);
                        }
                    }
                }
                else if (currentMeal == "steak")
                {
                    if (calorieIntake[calorieIntake.Count - 1] - STEAK > 0)
                    {
                        calorieIntake[calorieIntake.Count - 1] -= STEAK;
                        meals.RemoveAt(0);
                        mealsEaten++;
                    }
                    else
                    {
                        if (calorieIntake.Count > 1)
                        {
                            calorieIntake[calorieIntake.Count - 2] += calorieIntake[calorieIntake.Count - 1];
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                        }
                        else
                        {
                            calorieIntake.RemoveAt(calorieIntake.Count - 1);
                            mealsEaten++;
                            meals.RemoveAt(0);
                        }
                    }
                }
            }

            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {mealsCount} meals.");
                if (calorieIntake.Count > 0)
                {
                    calorieIntake.Reverse();
                    Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calorieIntake)} calories.");
                }
                else
                {
                    Console.WriteLine($"For the next few days, he can eat 0 calories.");
                }
            }
            else if (meals.Count > 0)
            {
                Console.WriteLine($"John ate enough, he had {mealsEaten} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
