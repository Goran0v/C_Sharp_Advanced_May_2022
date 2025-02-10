using System;
using System.Linq;
using System.Collections.Generic;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Predicate<string> isCapital = (string x) => x.Length > 0 && char.IsUpper(x[0]);
            //Func<string, bool> func = ch => char.IsUpper(ch[0]);
            string[] words = text.Split(' ').Where(x => isCapital(x)).ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
