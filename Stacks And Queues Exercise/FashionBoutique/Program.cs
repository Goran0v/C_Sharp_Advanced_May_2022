using System;
using System.Linq;
using System.Collections.Generic;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);

            int rackCounter = 1;
            int currSum = 0;
            while (stack.Count() != 0)
            {
                if ((currSum + stack.Peek()) <= rackCapacity)
                {
                    currSum += stack.Pop();
                }
                else
                {
                    currSum = 0;
                    rackCounter++;
                }
            }

            Console.WriteLine(rackCounter);
        }
    }
}