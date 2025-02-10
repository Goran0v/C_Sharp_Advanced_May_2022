using System;
using System.Linq;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == '(')
                {
                    stack.Push(i);
                }
                else if (c == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subexpr = expression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subexpr);
                }
            }
        }
    }
}
