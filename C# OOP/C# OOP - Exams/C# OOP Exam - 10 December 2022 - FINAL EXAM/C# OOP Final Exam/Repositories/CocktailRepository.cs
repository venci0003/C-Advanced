using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace ChristmasPastryShop.Repositories
{
    public class CocktailRepository : IRepository<ICocktail>
    {
        private List<ICocktail> coctailsInformation;

        public CocktailRepository()
        {
            coctailsInformation = new List<ICocktail>();
        }

        public IReadOnlyCollection<ICocktail> Models => coctailsInformation;

        public void AddModel(ICocktail model)
        {
            coctailsInformation.Add(model);
        }
    }
}
