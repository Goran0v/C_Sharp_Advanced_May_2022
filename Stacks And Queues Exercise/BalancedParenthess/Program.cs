using System;
using System.Linq;
using System.Collections.Generic;

namespace BalancedParenthess
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            Stack<char> brackets = new Stack<char>(symbols);

            bool isBalanced = false;
            if (symbols.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < symbols.Length / 2; i++)
            {
                char curr = symbols[i];
                if (curr == '{' && brackets.Pop() == '}')
                {
                    isBalanced = true;
                }
                else if (curr == '[' && brackets.Pop() == ']')
                {
                    isBalanced = true;
                }
                else if (curr == '(' && brackets.Pop() == ')')
                {
                    isBalanced = true;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
