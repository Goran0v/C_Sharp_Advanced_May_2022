using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            HashSet<string> vipSet = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string plate = input;
                if (plate == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(plate[0]))
                {
                    vipSet.Add(plate);
                }
                else
                    set.Add(plate);
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "END")
            {
                if (set.Contains(cmd))
                {
                    set.Remove(cmd);
                }
                if (vipSet.Contains(cmd))
                {
                    vipSet.Remove(cmd);
                }
            }
            
            Console.WriteLine(set.Count() + vipSet.Count);
            foreach (var plate in vipSet)
            {
                Console.WriteLine(plate);
            }
            foreach (var plate in set)
            {
                Console.WriteLine(plate);
            }
        }
    }
}
