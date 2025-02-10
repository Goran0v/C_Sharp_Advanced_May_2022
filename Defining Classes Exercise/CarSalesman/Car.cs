using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine @Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "none";
        }
        public Car(string model, Engine engine, int weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = "none";
        }
        public Car(string model, Engine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
            this.Weight = 0;
        }
        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
    }
}
