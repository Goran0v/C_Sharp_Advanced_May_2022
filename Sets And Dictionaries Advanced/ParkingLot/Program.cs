using System;
using System.Linq;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] arr = input.Split(", ").ToArray();
                string command = arr[0];
                if (command == "IN")
                {
                    set.Add(arr[1]);
                }
                else if (command == "OUT")
                {
                    set.Remove(arr[1]);
                }
            }

            if (set.Count > 0)
            {
                foreach (var plate in set)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
