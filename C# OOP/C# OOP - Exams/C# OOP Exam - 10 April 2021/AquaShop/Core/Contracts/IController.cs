namespace AquaShop.Core.Contracts
{
    public interface IController
    {
        string AddAquarium(string aquariumType, string aquariumName);

        string AddDecoration(string decorationType);

        string InsertDecoration(string aquariumName, string decorationType);

        string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price);

        string FeedFish(string aquariumName);

        string CalculateValue(string aquariumName);

        string Report();
    }
}
