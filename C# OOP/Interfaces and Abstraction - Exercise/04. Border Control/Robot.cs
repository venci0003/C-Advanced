using System;
using System.Collections.Generic;
using System.Text;
using _04._Border_Control.Models.Contracts;

namespace _04._Border_Control
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
