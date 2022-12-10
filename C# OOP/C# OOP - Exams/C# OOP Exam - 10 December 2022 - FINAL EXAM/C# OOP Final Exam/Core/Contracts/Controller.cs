namespace ChristmasPastryShop.Core.Contracts
{
    using System.Linq;
    using System.Text;
    using Models.Booths;
    using Models.Booths.Contracts;
    using Models.Cocktails;
    using Models.Delicacies.Contracts;
    using Models.Delicacies;
    using Repositories;
    using Utilities.Messages;
    using Models.Cocktails.Contracts;
    public class Controller : IController
    {
        private BoothRepository boothInformation;

        public Controller()
        {
            boothInformation = new BoothRepository();
        }

        public string AddBooth(int capacity)
        {
            IBooth booth = new Booth(boothInformation.Models.Count + 1, capacity);

            boothInformation.AddModel(booth);

            return string.Format(OutputMessages.NewBoothAdded, boothInformation.Models.Count, capacity);
        }

        public string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size)
        {

            if (size != "Large" && size != "Small" && size != "Middle")
            {
                return string.Format(OutputMessages.InvalidCocktailSize, size);
            }

            if (cocktailTypeName != "Hibernation" && cocktailTypeName != "MulledWine")
            {
                return string.Format(OutputMessages.InvalidCocktailType, cocktailTypeName);
            }

            IBooth validBooth = boothInformation.Models.First(b => b.BoothId == boothId);

            if (validBooth.CocktailMenu.Models.Any(c => c.Name == cocktailTypeName && c.Size == size))
            {
                return string.Format(OutputMessages.CocktailAlreadyAdded, size, cocktailName);
            }

            ICocktail cocktail = CreateCocktail(cocktailTypeName, cocktailName, size, validBooth);

            return string.Format(OutputMessages.NewCocktailAdded, size, cocktailName, cocktail.GetType().Name);
        }



        public string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName)
        {
            if (delicacyTypeName != "Gingerbread" && delicacyTypeName != "Stolen")
            {
                return string.Format(OutputMessages.InvalidDelicacyType, delicacyTypeName);
            }

            IDelicacy delicacy = CreateDelicacy(delicacyTypeName, delicacyName);

            IBooth validBooth = boothInformation.Models.First(b => b.BoothId == boothId);

            if (validBooth.DelicacyMenu.Models.Any(d => d.Name == delicacyName))
            {
                return string.Format(OutputMessages.DelicacyAlreadyAdded, delicacyName);
            }

            validBooth.DelicacyMenu.AddModel(delicacy);

            return string.Format(OutputMessages.NewDelicacyAdded, delicacy.GetType().Name, delicacyName);
        }

        public string BoothReport(int boothId)
        {
            IBooth validBooth = boothInformation.Models.First(b => b.BoothId == boothId);

            StringBuilder report = new StringBuilder();

            report.AppendLine(validBooth.ToString());

            return report.ToString().TrimEnd();
        }

        public string LeaveBooth(int boothId)
        {
            IBooth boothToLeave = boothInformation.Models.First(b => b.BoothId == boothId);

            double currentBill = boothToLeave.CurrentBill;

            boothToLeave.Charge();

            boothToLeave.ChangeStatus();

            StringBuilder result = new StringBuilder();

            result.AppendLine($"Bill {currentBill:f2} lv");

            result.AppendLine($"Booth {boothId} is now available!");

            return result.ToString().Trim();
        }

        public string ReserveBooth(int countOfPeople)
        {
            IBooth validBooth = boothInformation.Models
                .OrderBy(b => b.Capacity)
                .ThenByDescending(b => b.BoothId)
                .Where(b => b.IsReserved == false)
                .FirstOrDefault(b => b.Capacity >= countOfPeople);

            if (validBooth == null)
            {
                return string.Format(OutputMessages.NoAvailableBooth, countOfPeople);
            }

            validBooth.ChangeStatus();

            return string.Format(OutputMessages.BoothReservedSuccessfully, validBooth.BoothId, countOfPeople);
        }

        public string TryOrder(int boothId, string order)
        {
            IBooth validBooth = boothInformation.Models.First(b => b.BoothId == boothId);

            string[] orders = order.Split('/');

            string itemTypeName = orders[0];

            string itemName = orders[1];

            int count = int.Parse(orders[2]);

            if (itemTypeName != "Gingerbread" && itemTypeName != "Stolen" && itemTypeName != "Hibernation" && itemTypeName != "MulledWine")
            {
                return string.Format(OutputMessages.NotRecognizedType, itemTypeName);
            }

            if (itemTypeName == "Gingerbread" || itemTypeName == "Stolen")
            {
                if (!validBooth.DelicacyMenu.Models.Any(d => d.Name == itemName))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, itemTypeName, itemName);
                }

                double priceToBePaid;

                IDelicacy validDelicacy = validBooth.DelicacyMenu.Models.First(d => d.GetType().Name == itemTypeName);

                priceToBePaid = validDelicacy.Price * count;

                validBooth.UpdateCurrentBill(priceToBePaid);

                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, count, itemName);
            }
            else
            {
                string size = orders[3];

                if (!validBooth.CocktailMenu.Models.Any(c => c.Name == itemName && c.Size == size))
                {
                    return string.Format(OutputMessages.NotRecognizedItemName, size, itemName);
                }

                double priceToBePaid = 0;

                ICocktail cocktail = validBooth.CocktailMenu.Models.First(d => d.GetType().Name == itemTypeName);

                priceToBePaid = cocktail.Price * count;

                validBooth.UpdateCurrentBill(priceToBePaid);

                return string.Format(OutputMessages.SuccessfullyOrdered, boothId, count, itemName);
            }
        }
        private static ICocktail CreateCocktail(string cocktailTypeName, string cocktailName, string size, IBooth validBooth)
        {
            ICocktail cocktail;
            if (cocktailTypeName == "MulledWine")
            {
                cocktail = new MulledWine(cocktailName, size);

                validBooth.CocktailMenu.AddModel(cocktail);
            }
            else
            {
                cocktail = new Hibernation(cocktailName, size);

                validBooth.CocktailMenu.AddModel(cocktail);
            }

            return cocktail;
        }

        private static IDelicacy CreateDelicacy(string delicacyTypeName, string delicacyName)
        {
            IDelicacy delicacy;
            if (delicacyTypeName == "Stolen")
            {
                delicacy = new Stolen(delicacyName);
            }
            else
            {
                delicacy = new Gingerbread(delicacyName);
            }

            return delicacy;
        }
    }
}
