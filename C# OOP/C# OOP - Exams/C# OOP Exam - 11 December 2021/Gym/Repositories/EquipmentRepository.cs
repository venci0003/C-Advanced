using Gym.Models.Equipment.Contracts;
using Gym.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Repositories
{
    public class EquipmentRepository : IRepository<IEquipment>
    {
        private List<IEquipment> equipmentList;

        public EquipmentRepository()
        {
            equipmentList = new List<IEquipment>();
        }

        public IReadOnlyCollection<IEquipment> Models => equipmentList;

        public void Add(IEquipment model)
        {
            equipmentList.Add(model);
        }

        public IEquipment FindByType(string type)
        {
            return equipmentList.FirstOrDefault(e => e.GetType().Name == type);
        }

        public bool Remove(IEquipment model)
        {
            return equipmentList.Remove(model);
        }
    }
}
