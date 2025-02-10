using System;
using System.Linq;
using System.Collections.Generic;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int wastedFood = 0;

            Queue<int> guestQueue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Stack<int> plateStack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            while(true)
            {
                if (guestQueue.Count == 0 || plateStack.Count == 0)
                {
                    break;
                }
                int currGuest = guestQueue.Peek();
                int currentPlate = plateStack.Peek();
                if (guestQueue.Peek() - currentPlate <= 0)
                {
                    wastedFood += currentPlate - guestQueue.Dequeue();
                    plateStack.Pop();
                }
                else
                {
                    currGuest -= plateStack.Pop();
                    while (currGuest > 0)
                    {
                        currGuest -= plateStack.Pop();
                    }
                    wastedFood += Math.Abs(currGuest);
                    guestQueue.Dequeue();
                }
            }

            if (guestQueue.Count == 0)
            {
                Console.WriteLine($"Plates: {string.Join(' ', plateStack.Reverse())}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(' ', guestQueue)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}
