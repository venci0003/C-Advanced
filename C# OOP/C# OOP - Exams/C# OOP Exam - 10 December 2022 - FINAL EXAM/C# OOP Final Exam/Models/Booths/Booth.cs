using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Models.Cocktails;
using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth : IBooth
    {
        private int boothId;

        private int capacity;

        private double currentBill;

        private double turnover;

        private bool isReserved;

        private IRepository<IDelicacy> delicacyInformation;

        private IRepository<ICocktail> cocktailInformation;

        public Booth(int boothId, int capacity)
        {
            BoothId = boothId;

            Capacity = capacity;

            CurrentBill = 0;

            Turnover = 0;

            isReserved = false;

            delicacyInformation = new DelicacyRepository();

            cocktailInformation = new CocktailRepository();
        }

        public int BoothId
        {
            get
            {
                return boothId;
            }
            private set
            {
                boothId = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }
                capacity = value;
            }
        }

        public IRepository<IDelicacy> DelicacyMenu => delicacyInformation;

        public IRepository<ICocktail> CocktailMenu => cocktailInformation;

        public double CurrentBill
        {
            get
            {
                return currentBill;
            }
            private set
            {

                currentBill = value;
            }
        }

        public double Turnover
        {
            get
            {
                return turnover;
            }
            private set
            {

                turnover = value;
            }
        }

        public bool IsReserved
        {
            get
            {
                return isReserved;
            }
            private set
            {

                isReserved = value;
            }
        }

        public void ChangeStatus()
        {
            if (IsReserved == true)
            {
                IsReserved = false;
            }
            if (IsReserved == false)
            {
                IsReserved = true;
            }
        }

        public void Charge()
        {
            Turnover += CurrentBill;

            CurrentBill = 0;
        }

        public void UpdateCurrentBill(double amount)
        {
            CurrentBill += amount;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Booth: {BoothId}");

            result.AppendLine($"Capacity: {Capacity}");

            result.AppendLine($"Turnover: {Turnover:f2} lv");

            result.AppendLine($"-Cocktail menu:");

            foreach (ICocktail cocktail in cocktailInformation.Models)
            {
                result.AppendLine($"--{cocktail.ToString()}");
            }

            result.AppendLine("-Delicacy menu:");

            foreach (IDelicacy delicacy in delicacyInformation.Models)
            {
                result.AppendLine($"--{delicacy.ToString()}");
            }

            return result.ToString().Trim();
        }
    }
}
