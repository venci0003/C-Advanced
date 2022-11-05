using System;
using System.Collections.Generic;
using System.Text;
using Birthday_Celebrations.Models.Contracts;

namespace _05._Birthday_Celebrations
{
    public class Citizen : IBirthdatable, IIdCheckable
    {
        private string name;
        private int age;
        private string id;
        private string birthDate;

        public Citizen(string name, int age, string id,string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }
    }
}
