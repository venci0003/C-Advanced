using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        public CPU(string brand, int cores, double frequency)
        {
            this.Brand = brand;
            this.Cores = cores;
            this.Frequency = frequency;
        }

        public string Brand { get; set; }
        public int Cores { get; set; }
        public double Frequency { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Brand} CPU:");

            result.AppendLine($"Cores: {this.Cores}");

            result.AppendLine($"Frequency: {this.Frequency:f1} GHz");

            return result.ToString().Trim();
        }
    }
}
