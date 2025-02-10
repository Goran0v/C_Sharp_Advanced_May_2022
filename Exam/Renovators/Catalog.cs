using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count => this.renovators.Count;

        public Catalog(string name, int neededRenovators, string project)
        {
            this.renovators = new List<Renovator>();
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
        }

        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Name == null || renovator.Name == string.Empty || renovator.Type == null || renovator.Type == string.Empty)
            {
                return "Invalid renovator's information.";
            }
            if (this.renovators.Count + 1 > this.NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }

            this.renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            if (this.renovators.Count > 0)
            {
                foreach (var renovator in this.renovators)
                {
                    if (renovator.Name == name)
                    {
                        return this.renovators.Remove(renovator);
                    }
                }
            }

            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            List<Renovator> renovatorsToRemove = new List<Renovator>();
            if (this.renovators.Count > 0)
            {
                foreach (var renovator in this.renovators)
                {
                    if (renovator.Type == type)
                    {
                        renovatorsToRemove.Add(renovator);
                    }
                }

                if (renovatorsToRemove.Count > 0)
                {
                    foreach (var renovator in renovatorsToRemove)
                    {
                        this.renovators.Remove(renovator);
                    }
                    return renovatorsToRemove.Count;
                }
            }
            
            return 0;
        }

        public Renovator HireRenovator(string name)
        {
            if (this.renovators.Count > 0)
            {
                foreach (var renovator in this.renovators)
                {
                    if (renovator.Name == name)
                    {
                        renovator.Hired = true;
                        return renovator;
                    }
                }
            }

            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            var list = new List<Renovator>();
            if (this.renovators.Count > 0)
            {
                foreach (var renovator in this.renovators)
                {
                    if (renovator.Days >= days)
                    {
                        list.Add(renovator);
                    }
                }
            }

            return list;
        }

        public string Report()
        {
            List<Renovator> availableRenovators = new List<Renovator>();
            foreach (var renovator in this.renovators)
            {
                if (renovator.Hired == false)
                {
                    availableRenovators.Add(renovator);
                }
            }
            if (availableRenovators.Count > 0)
            {
                return $"Renovators available for Project {this.Project}:" + Environment.NewLine + $"{string.Join(Environment.NewLine, availableRenovators)}";
            }

            return null;
        }
    }
}
