namespace ChristmasPastryShop.Models.Booths.Contracts
{
    using ChristmasPastryShop.Models.Cocktails.Contracts;
    using ChristmasPastryShop.Models.Delicacies.Contracts;
    using ChristmasPastryShop.Repositories.Contracts;
    public interface IBooth
    {
        public int BoothId { get; }

        public int Capacity { get; }
        IRepository<IDelicacy> DelicacyMenu { get; }

        IRepository<ICocktail> CocktailMenu { get; }

        public double CurrentBill { get; }

        public double Turnover { get; }

        public bool IsReserved { get; }

        void UpdateCurrentBill(double amount);

        void Charge();

        void ChangeStatus();
    }
}
