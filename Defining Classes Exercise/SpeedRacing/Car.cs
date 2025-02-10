using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumpPerKm;
        private double travelledDistance;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }
        public double FuelConsumpPerKm
        {
            get { return fuelConsumpPerKm; }
            set { fuelConsumpPerKm = value; }
        }
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public Car(string model, double fuelAmount, double fuelConsump)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumpPerKm = fuelConsump;
            this.TravelledDistance = 0;
        }

        public void Drive(double km)
        {
            if (this.FuelAmount - (km * this.FuelConsumpPerKm) >= 0)
            {
                this.FuelAmount -= (km * this.FuelConsumpPerKm);
                this.TravelledDistance += km;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
