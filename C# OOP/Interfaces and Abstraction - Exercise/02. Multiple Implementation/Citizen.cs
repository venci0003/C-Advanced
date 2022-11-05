using _02._Multiple_Implementation.Models.Contracts;

namespace _02._Multiple_Implementation
{
    public class Citizen : IPerson,IIdentifiable,IBirthable
    {
        private string name;
        private int age;
        public Citizen(string name, int age, string Id,string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
            this.Birthdate = birthDate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }
    }
}
