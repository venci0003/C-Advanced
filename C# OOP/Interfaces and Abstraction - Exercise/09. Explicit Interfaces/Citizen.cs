namespace Explicit_Interfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public string Country { get; private set; }

        public int Age { get; private set; }

        string IResident.GetName()
        {
            return "Mr/Ms/Mrs";
        }

        string IPerson.GetName()
        {
            return Name;
        }
    }
}
