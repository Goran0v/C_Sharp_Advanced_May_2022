using System;
using System.Linq;
using System.Collections.Generic;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVat = x => x * 1.2m;
            decimal[] prices = Console.ReadLine().Split(", ").Select(decimal.Parse).ToArray();
            prices = prices.Select(addVat).ToArray();
            prices.ToList().ForEach(x => Console.WriteLine(Math.Round(x, 2)));
        }
    }
}