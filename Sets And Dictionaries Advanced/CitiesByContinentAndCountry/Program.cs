using System;
using System.Linq;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentData = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();
                string continent = line[0];
                string country = line[1];
                string city = line[2];
                if (!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent, new Dictionary<string, List<string>>());
                    if (!continentData[continent].ContainsKey(country))
                    {
                        continentData[continent][country] = new List<string>();
                    }
                    continentData[continent][country].Add(city);
                }
                else
                {
                    List<string> cities = new List<string>();
                    cities.Add(city);
                    if (!continentData[continent].ContainsKey(country))
                    {
                        continentData[continent].Add(country, cities);
                    }
                    else
                    {
                        continentData[continent][country].Add(city);
                    }
                }
            }

            foreach (var data in continentData)
            {
                Console.WriteLine($"{data.Key}:");
                foreach (var country in data.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
