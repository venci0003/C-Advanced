namespace _06._Food_Shortage
{
    public class Robot : IIdCheckable
    {
        private string name;
        private string id;

        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; set; }

        public string Id { get; set; }
    }
}
