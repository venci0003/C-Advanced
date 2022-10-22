using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {

        public Computer(string model, int capacity)
        {
            this.Multiprocessor = new List<CPU>();
            this.Model = model;
            this.Capacity = capacity;
        }

        public List<CPU> Multiprocessor { get; set; }
        public string Model { get; set; }

        public int Capacity { get; set; }

        public int Count { get => Multiprocessor.Count; }

        public void Add(CPU cpu)
        {
            if (this.Capacity - this.Multiprocessor.Count > 0)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            CPU removeByBrand = this.Multiprocessor.FirstOrDefault(a => a.Brand == brand);

            if (removeByBrand != null)
            {
                Multiprocessor.Remove(removeByBrand);
                return true;
            }

            return false;
        }

        public CPU MostPowerful()
        {
            return this.Multiprocessor.OrderByDescending(m => m.Frequency).First();
        }

        public CPU GetCPU(string brand)
        {
            CPU returnBrand = this.Multiprocessor.FirstOrDefault(a => a.Brand == brand);

            if (returnBrand != null)
            {
                return returnBrand;
            }

            return null;
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine($"CPUs in the Computer {Model}:");
            foreach (CPU item in this.Multiprocessor)
            {
                report.AppendLine(item.ToString());
            }
            return report.ToString().Trim();
        }
    }
}
