using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command == "Beast!")
                {
                    break;
                }
                string name = tokens[0];
                int age = int.Parse(tokens[1]);   

                if (command == "Cat")
                {
                    try
                    {
                        Cat cat = new Cat(name, age, tokens[2]);
                        Console.WriteLine($"{command}\n{cat.Name} {cat.Age} {cat.Gender}\n{cat.ProduceSound()}");
                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                }
                else if (command == "Kitten")
                {
                    try
                    {
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine($"{command}\n{kitten.Name} {kitten.Age} {kitten.Gender}\n{kitten.ProduceSound()}");
                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                }
                else if (command == "Tomcat")
                {
                    try
                    {
                        Tomcat tomCat = new Tomcat(name, age);
                        Console.WriteLine($"{command}\n{tomCat.Name} {tomCat.Age} {tomCat.Gender}\n{tomCat.ProduceSound()}");
                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                }
                else if (command == "Dog")
                {
                    try
                    {
                        Dog dog = new Dog(name, age, tokens[2]);
                        Console.WriteLine($"{command}\n{dog.Name} {dog.Age} {dog.Gender}\n{dog.ProduceSound()}");
                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                }
                else if (command == "Frog")
                {
                    try
                    {
                        Frog frog = new Frog(name, age, tokens[2]);
                        Console.WriteLine($"{command}\n{frog.Name} {frog.Age} {frog.Gender}\n{frog.ProduceSound()}");
                    }
                    catch (Exception exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                }
            }
        }
    }
}
