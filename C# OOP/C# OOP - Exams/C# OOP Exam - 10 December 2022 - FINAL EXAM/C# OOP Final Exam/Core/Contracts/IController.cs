namespace ChristmasPastryShop.Core.Contracts
{
    public interface IController
    {
        string AddBooth(int capacity);

        string AddDelicacy(int boothId, string delicacyTypeName, string delicacyName);

        string AddCocktail(int boothId, string cocktailTypeName, string cocktailName, string size);

        string ReserveBooth(int countOfPeople);

        string TryOrder(int boothId, string order);

        string LeaveBooth(int boothId);

        string BoothReport(int boothId);
    }
}
