using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Oldest_Family_Member
{
    public class Person
    {
        private string name;

        private int age;

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age) : this()
        {
            Age = age;
        }

        public Person(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }
    }
}
