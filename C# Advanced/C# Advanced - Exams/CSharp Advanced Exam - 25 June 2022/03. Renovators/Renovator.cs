using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
		private string name;

		private string type;

		private double rate;

		private int days;

		private bool hired;

		public Renovator(string name,string type,double rate, int days)
		{
			this.Name = name;
			this.Type = type;
			this.Rate = rate;
			this.Days = days;
		}

		public bool Hired
		{
			get { return this.hired; }
			set { this.hired = value; }
		}

		public int Days
		{
			get { return this.days; }
			set { this.days = value; }
		}


		public double Rate
		{
			get { return this.rate; }
			set { this.rate = value; }
		}


		public string Type
		{
			get { return this.type; }
			set { this.type = value; }
		}


		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			
			result.AppendLine($"-Renovator: {name}");
			result.AppendLine($"--Specialty: {type}");
			result.AppendLine($"--Rate per day: {rate} BGN");

			return result.ToString().Trim();
		}
	}
}
