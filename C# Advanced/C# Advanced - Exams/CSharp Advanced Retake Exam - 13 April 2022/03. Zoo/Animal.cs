using System.Text;

namespace Zoo
{
    public class Animal
    {

        public Animal(string species, string diet, double weight, double length)
        {
            this.Species = species;
            this.Weight = weight;
            this.Diet = diet;
            this.Length = length;
        }
        private string species;

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        private string diet;

        public string Diet
        {
            get { return diet; }
            set { diet = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public override string ToString() => $"The {species} is a {diet} and weighs {weight} kg.";
    }
}
