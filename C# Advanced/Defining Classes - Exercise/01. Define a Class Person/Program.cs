using System;

namespace _01._Define_a_Class_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person()
            {
                Name = "Peter",
                Age = 20
            };

            Person secondPerson = new Person()
            {
                Name = "Hristo",
                Age = 32
            };

            Person thirdPerson = new Person()
            {
                Name = "Jose",
                Age = 43
            };
        }
    }
}
