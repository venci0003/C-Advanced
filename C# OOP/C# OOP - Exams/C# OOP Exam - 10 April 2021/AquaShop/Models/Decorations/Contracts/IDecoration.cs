namespace AquaShop.Models.Decorations.Contracts
{
    using System;

    public interface IDecoration
    {
        int Comfort { get; }

        decimal Price { get; }
    }
}
