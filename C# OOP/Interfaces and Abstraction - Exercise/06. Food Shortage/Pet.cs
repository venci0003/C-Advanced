namespace _06._Food_Shortage
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
