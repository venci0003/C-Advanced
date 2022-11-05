using System;
using System.Collections.Generic;
using System.Text;
using Birthday_Celebrations.Models.Contracts;

namespace _05._Birthday_Celebrations
{
    public class Pet : IBirthdatable
    {
        private string name;
        private string birthDate;

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get; set; }
        public string BirthDate { get; set; }
    }
}
