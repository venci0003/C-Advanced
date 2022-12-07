using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private List<IAquarium> aquariums;

        private IRepository<IDecoration> decorations;

        public Controller()
        {
            aquariums = new List<IAquarium>();

            decorations = new DecorationRepository();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium;

            if (aquariumType == "FreshwaterAquarium" || aquariumType == "SaltwaterAquarium")
            {
                if (aquariumType == "FreshwaterAquarium")
                {
                    aquarium = new FreshwaterAquarium(aquariumName);

                    aquariums.Add(aquarium);

                    return String.Format(OutputMessages.SuccessfullyAdded, aquariumType);
                }
                else
                {
                    aquarium = new SaltwaterAquarium(aquariumName);

                    aquariums.Add(aquarium);

                    return String.Format(OutputMessages.SuccessfullyAdded, aquariumType);
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration;

            if (decorationType == "Ornament" || decorationType == "Plant")
            {
                if (decorationType == "Ornament")
                {
                    decoration = new Ornament();

                    decorations.Add(decoration);
                }
                else
                {
                    decoration = new Plant();

                    decorations.Add(decoration);
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IAquarium neededAquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            IFish fish;

            if (fishType == "FreshwaterFish" || fishType == "SaltwaterFish")
            {
                if (fishType == "FreshwaterFish")
                {
                    fish = new FreshwaterFish(fishName, fishSpecies, price);

                    if (neededAquarium.GetType().Name == "FreshwaterAquarium")
                    {
                        neededAquarium.AddFish(fish);

                        return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
                    }
                    else
                    {
                        return string.Format(OutputMessages.UnsuitableWater);
                    }
                }
                else
                {
                    fish = new SaltwaterFish(fishName, fishSpecies, price);

                    if (neededAquarium.GetType().Name == "SaltwaterAquarium")
                    {
                        neededAquarium.AddFish(fish);
                        return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
                    }
                    else
                    {
                        return string.Format(OutputMessages.UnsuitableWater);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium validAquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal price = validAquarium.Decorations.Select(d => d.Price).Sum() + validAquarium.Fish.Select(f => f.Price).Sum();

            return string.Format(OutputMessages.AquariumValue, aquariumName, price);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium validAquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            int fishCount = validAquarium.Fish.Count;

            return string.Format(OutputMessages.FishFed, fishCount);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IAquarium validAquarium = aquariums.FirstOrDefault(a => a.Name == aquariumName);

            IDecoration validDecoration = decorations.FindByType(decorationType);

            if (validDecoration == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }
            validAquarium.AddDecoration(validDecoration);

            decorations.Remove(validDecoration);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder info = new StringBuilder();

            foreach (IAquarium aquarium in aquariums)
            {
                info.AppendLine(aquarium.ToString());
            }

            return info.ToString().Trim();
        }
    }
}
