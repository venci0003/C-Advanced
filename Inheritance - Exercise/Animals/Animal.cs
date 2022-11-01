using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            if (age < 0 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
            {
                throw new Exception("Invalid input");
            }

            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }


        public int Age { get; set; }

        public string Gender { get; set; }


        public virtual string ProduceSound()
        {
            return string.Empty;
        }
    }
}
