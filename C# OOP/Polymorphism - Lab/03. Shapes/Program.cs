using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape shape = null;
            string shapeType = Console.ReadLine();
            if (shapeType == "Circle")
            {
                shape = new Circle(2.5);
                Console.WriteLine($"{shape.CalculateArea():f2}");
                Console.WriteLine($"{shape.CalculatePerimeter():f2}");
                Console.WriteLine(shape.Draw());
            }
            else
            {
                shape = new Rectangle(10.5, 12.7);
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine(shape.Draw());
            }
        }
    }
}
