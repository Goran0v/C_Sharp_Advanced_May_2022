using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Tires
    {
        private int age;
        private double pressure;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public Tires(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}
