using System;
using System.Collections.Generic;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Drones = new List<Drone>();
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
        }

        public int Count => this.Drones.Count;

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone";
            }

            if (this.Capacity >= Drones.Count)
            {
                return "Airfield is full.";
            }

            this.Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }
    }
}
