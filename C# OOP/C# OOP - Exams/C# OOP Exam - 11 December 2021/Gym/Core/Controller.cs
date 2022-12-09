using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipmentInformation;

        private List<IGym> gymInformation;

        public Controller()
        {
            equipmentInformation = new EquipmentRepository();

            gymInformation = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete;

            IGym gymForAthlete = gymInformation.FirstOrDefault(g => g.Name == gymName);

            if (athleteType == "Boxer" || athleteType == "Weightlifter")
            {
                if (athleteType == "Boxer")
                {

                    athlete = new Boxer(athleteName, motivation, numberOfMedals);

                    if (gymForAthlete.GetType().Name == "BoxingGym")
                    {
                        gymForAthlete.AddAthlete(athlete);
                    }
                    else
                    {
                        return string.Format(OutputMessages.InappropriateGym);
                    }
                }
                else if (athleteType == "Weightlifter")
                {
                    athlete = new Weightlifter(athleteName, motivation, numberOfMedals);

                    if (gymForAthlete.GetType().Name == "WeightliftingGym")
                    {
                        gymForAthlete.AddAthlete(athlete);
                    }
                    else
                    {
                        return string.Format(OutputMessages.InappropriateGym);
                    }
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            }

            return string.Format(OutputMessages.EntityAddedToGym, athleteType, gymName);
        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment;

            if (equipmentType == "BoxingGloves" || equipmentType == "Kettlebell")
            {
                if (equipmentType == "BoxingGloves")
                {
                    equipment = new BoxingGloves();

                    equipmentInformation.Add(equipment);
                }
                else if (equipmentType == "Kettlebell")
                {
                    equipment = new Kettlebell();

                    equipmentInformation.Add(equipment);
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }

            return string.Format(OutputMessages.SuccessfullyAdded, equipmentType);
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym;

            if (gymType == "BoxingGym" || gymType == "WeightliftingGym")
            {
                if (gymType == "BoxingGym")
                {
                    gym = new BoxingGym(gymName);

                    gymInformation.Add(gym);
                }
                else if (gymType == "WeightliftingGym")
                {
                    gym = new WeightliftingGym(gymName);

                    gymInformation.Add(gym);
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }

            return string.Format(OutputMessages.SuccessfullyAdded, gymType);
        }

        public string EquipmentWeight(string gymName)
        {
            IGym gymToSumWeights = gymInformation.FirstOrDefault(g => g.Name == gymName);

            return string.Format(OutputMessages.EquipmentTotalWeight, gymName, gymToSumWeights.EquipmentWeight);
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IGym neededGym = gymInformation.FirstOrDefault(g => g.Name == gymName);

            IEquipment neededEquipment = equipmentInformation.FindByType(equipmentType);

            if (neededEquipment == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentEquipment, equipmentType));
            }

            neededGym.AddEquipment(neededEquipment);

            equipmentInformation.Remove(neededEquipment);

            return string.Format(OutputMessages.EntityAddedToGym, equipmentType, gymName);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            foreach (IGym gym in gymInformation)
            {
                report.AppendLine(gym.GymInfo());
            }

            return report.ToString().Trim();
        }

        public string TrainAthletes(string gymName)
        {
            IGym gymToTrainIn = gymInformation.FirstOrDefault(g => g.Name == gymName);

            foreach (IAthlete athlete in gymToTrainIn.Athletes)
            {
                athlete.Exercise();
            }

            return string.Format(OutputMessages.AthleteExercise, gymToTrainIn.Athletes.Count);
        }
    }
}
