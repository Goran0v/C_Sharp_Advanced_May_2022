using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public SkiRental(string name, int capacity)
        {
            this.data = new List<Ski>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Ski ski)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (this.data.Count > 0)
            {
                foreach (var ski in this.data)
                {
                    if (ski.Manufacturer == manufacturer && ski.Model == model)
                    {
                        this.data.Remove(ski);
                        return true;
                    }
                }
            }

            return false;
        }

        public Ski GetNewestSki()
        {
            if (this.data.Count > 0)
            {
                Ski newestSki = this.data.OrderByDescending(s => s.Year).First();
                return newestSki;
            }

            return null;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            if (this.data.Count > 0)
            {
                foreach (var ski in this.data)
                {
                    if (ski.Manufacturer == manufacturer && ski.Model == model)
                    {
                        return ski;
                    }
                }
            }

            return null;
        }

        public string GetStatistics()
        {
            return $"The skis stored in {this.Name}:" + Environment.NewLine + $"{string.Join(Environment.NewLine, this.data)}";
        }
    }
}
