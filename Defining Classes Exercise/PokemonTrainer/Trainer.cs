using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Trainer
    {
        private string name;
        private int numOfBadges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NumOfBadges
        {
            get { return numOfBadges; }
            set { numOfBadges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public Trainer(string name)
        {
            this.Name = name;
            this.NumOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
    }
}
