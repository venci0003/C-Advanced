using System;
using System.Collections.Generic;
using System.Text;
using _04._Border_Control.Models.Contracts;

namespace _04._Border_Control
{
    public class Citizen : IIdCheckable
    {
        private string name;
        private int age;
        private string id;

        public Citizen(string name, int age, string id)
        {
           this.Name = name;
           this.Age = age;
           this.Id = id;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

      
    }
}
