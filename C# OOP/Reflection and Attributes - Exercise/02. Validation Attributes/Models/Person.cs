using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private string fullName;
        private int age;

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
        [MyRequired]
        public string FullName
        {
            get => fullName;
            private set => fullName = value;
        }

        [MyRange(10,20)]
        public int Age
        {
            get => age;
            private set => age = value;
        }
    }
}