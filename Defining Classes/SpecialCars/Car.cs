﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;
        private int engineIndex;
        private int tiresIndex;
        private double sumOfTirePressure;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public Engine @Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }
        public int EngineIndex
        {
            get { return engineIndex; }
            set { engineIndex = value; }
        }
        public int TiresIndex
        {
            get { return tiresIndex; }
            set { tiresIndex = value; }
        }
        public double SumOfTirePressure
        {
            get { return sumOfTirePressure; }
            set { sumOfTirePressure = value; }
        }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
        : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires, int engineIndex, int tiresIndex, int sumOfTirePressure)
        : this(make, model, year, fuelQuantity, fuelConsumption, engine, tires)
        {
            this.EngineIndex = engineIndex;
            this.TiresIndex = tiresIndex;
            this.sumOfTirePressure = sumOfTirePressure;
        }

        public void Drive(double distance)
        {
            if (this.FuelQuantity - ((this.FuelConsumption * distance) / 100) >= 0)
            {
                this.FuelQuantity -= ((distance * this.FuelConsumption) / 100);
            }
        }
    }
}
