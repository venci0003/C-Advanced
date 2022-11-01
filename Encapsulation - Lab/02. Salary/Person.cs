

namespace PersonsInfo
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
            get { return firstName; }
            private set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
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
