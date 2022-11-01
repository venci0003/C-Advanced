using System.Text;

namespace Drones
{
    public class Drone
    {
        private string name;
        private string brand;
        private int range;
        private bool available;

        public Drone(string name, string brand, int range)
        {
            this.Name = name;
            this.Brand = brand;
            this.Range = range;
            this.available = true;
        }

        public bool Available
        {
            get { return this.available; }
            set { this.available = value; }
        }
        public int Range
        {
            get { return this.range; }
            set { this.range = value; }
        }


        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Drone: {name}");
            result.AppendLine($"Manufactured by: {brand}");
            result.AppendLine($"Range: {range} kilometers");

            return result.ToString().Trim();
        }
    }
}
