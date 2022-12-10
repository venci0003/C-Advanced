using ChristmasPastryShop.Models.Booths.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;

namespace ChristmasPastryShop.Repositories
{
    public class BoothRepository : IRepository<IBooth>
    {
        private List<IBooth> boothInformation;

        public BoothRepository()
        {
           boothInformation = new List<IBooth>();
        }

        public IReadOnlyCollection<IBooth> Models => boothInformation;

        public void AddModel(IBooth model)
        {
            boothInformation.Add(model);
        }
    }
}
