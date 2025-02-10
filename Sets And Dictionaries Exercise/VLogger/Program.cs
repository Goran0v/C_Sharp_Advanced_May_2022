using System;
using System.Collections.Generic;
using System.Linq;

namespace VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<List<string>, int>> vlogers = new Dictionary<string, Dictionary<List<string>, int>>();
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] arr = input.Split(' ');
                string name = arr[0];
                string action = arr[1];
                if (action == "joined")
                {
                    if (!vlogers.ContainsKey(name))
                    {
                        vlogers.Add(name, new Dictionary<List<string>, int>());
                    }
                }
                else if (action == "followed")
                {
                    string followingName = arr[2];
                    if (vlogers.ContainsKey(name) && vlogers.ContainsKey(followingName) && name != followingName)
                    {
                        List<string> firstFollowing = new List<string>();
                        List<string> secondFollowers = new List<string>();
                        if (!firstFollowing.Contains(followingName) && !secondFollowers.Contains(name))
                        {
                            firstFollowing.Add(followingName);
                            vlogers[name][firstFollowing]++;
                            secondFollowers.Add(name);
                            vlogers[name][secondFollowers]++;
                        }
                    }
                }
            }

            vlogers = (Dictionary<string, Dictionary<List<string>, int>>)vlogers.OrderBy(x => x.Value.OrderBy(y => y.Value));
            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");
            int counter = 1;
            foreach (var vloger in vlogers)
            {
                foreach (var item in vloger.Value)
                {
                    Console.WriteLine($"{counter}. {vloger.Key} : {vloger.Value.Count}, {item.Value} following");
                    foreach (var follower in item.Key)
                    {
                        Console.WriteLine($"* {follower}");
                    }
                    break;
                }
                counter++;
            }
        }
    }
}