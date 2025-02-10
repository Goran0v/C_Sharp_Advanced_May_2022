using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> shops = new SortedDictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] arr = input.Split(", ");
                string shop = arr[0];
                string product = arr[1];
                double price = double.Parse(arr[2]);
                if (!shops.ContainsKey(shop))
                {
                    List<string> products = new List<string>();
                    products.Add(product);
                    products.Add(price.ToString());
                    shops.Add(shop, products);
                }
                else
                {
                    shops[shop].Add(product);
                    shops[shop].Add(price.ToString());
                }
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                for (int i = 0; i < shop.Value.Count; i += 2)
                {
                    Console.WriteLine($"Product: {shop.Value[i]}, Price: {double.Parse(shop.Value[i + 1])}");
                }
            }
        }
    }
}
