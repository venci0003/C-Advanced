namespace AquaShop.Models.Aquariums.Contracts
{
    using System.Collections.Generic;

    using AquaShop.Models.Decorations.Contracts;
    using AquaShop.Models.Fish.Contracts;

    public interface IAquarium
    {
        string Name { get; }

        int Capacity { get; }

        int Comfort { get; }

        ICollection<IDecoration> Decorations { get; }

        ICollection<IFish> Fish { get; }

        void AddFish(IFish fish);

        bool RemoveFish(IFish fish);

        void AddDecoration(IDecoration decoration);

        void Feed();

        string GetInfo();
    }
}
