namespace ChristmasPastryShop.Models.Cocktails.Contracts
{
    public interface ICocktail
    {
        public string Name { get; }

        public string Size { get; }

        public double Price { get; }
    }
}
