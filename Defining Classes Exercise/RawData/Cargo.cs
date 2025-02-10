using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Cargo
    {
        private string type;
        private int weight;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }
}
