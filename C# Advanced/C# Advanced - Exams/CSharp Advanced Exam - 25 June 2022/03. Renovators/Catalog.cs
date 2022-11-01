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
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            this.renovators = new List<Renovator>();
        }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count
        {
            get { return renovators.Count; }
        }
        public string AddRenovator(Renovator renovator)
        {
            string message = string.Empty;
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                message = "Invalid renovator's information.";
            }
            else if (renovator.Rate > 350)
            {
                message = "Invalid renovator's rate.";
            }
            else if (this.NeededRenovators - this.renovators.Count > 0)
            {
                this.renovators.Add(renovator);
                message = $"Successfully added {renovator.Name} to the catalog.";
            }
            else
            {
                message = "Renovators are no more needed.";
            }
            return message;
        }
        public bool RemoveRenovator(string name)
        {
            bool isExist = true;
            Renovator reniovartoToRemove = this.renovators.FirstOrDefault(r => r.Name == name);
            if (reniovartoToRemove == null)
            {
                return false;
            }
            else
            {
                this.renovators.Remove(reniovartoToRemove);
            }
            return isExist;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int countRemovedRenovators = 0;
            for (int i = 0; i < this.renovators.Count; i++)
            {
                Renovator currentRenovator = renovators[i];
                if (currentRenovator.Type == type)
                {
                    countRemovedRenovators++;
                    this.renovators.Remove(currentRenovator);
                    i--;
                }
            }
            return countRemovedRenovators;
        }
        public Renovator HireRenovator(string name)
        {
            Renovator renovatorToFind = this.renovators.FirstOrDefault(r => r.Name == name);
            if (renovatorToFind != null)
            {
                renovatorToFind.Hired = true;
                return renovatorToFind;
            }
            else
            {
                return null;
            }
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovators = this.renovators.Where(r => r.Days >= days).ToList();
            return renovators;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");
            foreach (Renovator renovator in renovators.Where(r => r.Hired != true))
            {
                sb.AppendLine(renovator.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
