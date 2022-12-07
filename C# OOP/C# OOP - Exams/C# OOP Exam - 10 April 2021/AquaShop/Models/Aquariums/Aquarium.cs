using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;

        private int capacity;

        private List<IDecoration> decorations;

        private List<IFish> fishes;

        protected Aquarium(string name, int capacity)
        {
            Name = name;

            Capacity = capacity;

            decorations = new List<IDecoration>();

            fishes = new List<IFish>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAquariumName);
                }
                name = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            private set
            {

                capacity = value;
            }
        }

        public int Comfort => decorations.Select(d => d.Comfort).Sum();


        public ICollection<IDecoration> Decorations => decorations;

        public ICollection<IFish> Fish => fishes;

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (fishes.Count == Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            else
            {
                fishes.Add(fish);
            }
        }

        public void Feed()
        {
            foreach (IFish fish in fishes)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine($"{Name} ({this.GetType().Name}):");

            if (fishes.Count == 0)
            {
                info.AppendLine("none");
            }
            else
            {
                info.AppendLine(string.Join(", ", fishes.Select(f => f.Name)));
            }

            info.AppendLine($"Decorations: {decorations.Count}");

            info.AppendLine($"Comfort: {Comfort}");

            return info.ToString().Trim();
        }

        public bool RemoveFish(IFish fish)
        {
            return fishes.Remove(fish);
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine($"{this.Name} ({this.GetType().Name}):");

            if (Fish.Count > 0)
            {
                info.AppendLine($"Fish: { string.Join(", ", fishes.Select(f => f.Name))}");
            }
            else
            {
                info.AppendLine("Fish: none");
            }

            info.AppendLine($"Decorations: {decorations.Count}");

            info.AppendLine($"Comfort: {this.Comfort}");
            
            return info.ToString().Trim();
        }
    }
}
