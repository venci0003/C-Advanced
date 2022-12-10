using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Repositories
{
    public class DelicacyRepository : IRepository<IDelicacy>
    {
        private List<IDelicacy> delicacyInformation;

        public DelicacyRepository()
        {
            delicacyInformation = new List<IDelicacy>();
        }

        public IReadOnlyCollection<IDelicacy> Models => delicacyInformation;

        public void AddModel(IDelicacy model)
        {
            delicacyInformation.Add(model);
        }
    }
}
