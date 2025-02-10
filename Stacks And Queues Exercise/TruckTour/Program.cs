using System;
using System.Linq;
using System.Collections.Generic;

namespace TruckTour
{
    class Pump
    {
        public int Number;
        public int Petrol;
        public int Distance;
        public Pump(int number, int petrol, int distance)
        {
            this.Number = number;
            this.Petrol = petrol;
            this.Distance = distance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<Pump> queue = new Queue<Pump>();
            for (int i = 0; i <= n - 1; i++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int petrol = arr[0];
                int distance = arr[1];
                Pump newPump = new Pump(i, petrol, distance);
                queue.Enqueue(newPump);
            }

            int totalDistance = queue.Sum(pump => pump.Distance);
            int travelledDistance = 0;

            while (true)
            {
                int fuel = 0;
                foreach (var pump in queue)
                {
                    fuel += pump.Petrol;
                    if (fuel - pump.Distance)
                    {

                    }
                }
            }
        }
    }
}
