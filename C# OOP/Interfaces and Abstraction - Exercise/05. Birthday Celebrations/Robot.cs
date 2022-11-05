using System;
using System.Collections.Generic;
using System.Text;
using Birthday_Celebrations.Models.Contracts;

namespace _05._Birthday_Celebrations
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
