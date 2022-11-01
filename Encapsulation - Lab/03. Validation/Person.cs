using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Validation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public Person(string firsName, string lastName, int age, decimal salary)
        {
            this.FirstName = firsName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get 
            { 
                return firstName; 
            }
            private set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            private set
            {
                if (value < 650)
                {
                    throw new ArgumentException("Salary cannot be less than 650 leva!");
                }
                salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.Salary:f2} leva.";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2;
            }
            this.Salary = salary + (salary * percentage) / 100;
        }
    }
}
