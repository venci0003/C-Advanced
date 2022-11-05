using _01._Define_an_Interface_IPerson.Models.Interfaces;

namespace _01._Define_an_Interface_IPerson
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}
