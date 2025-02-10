using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = 0;
            this.Efficiency = "none";
        }

        public Engine(string model, int power, int displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = "none";
        }

        public Engine(string model, int power, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = efficiency;
            this.Displacement = 0;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}
