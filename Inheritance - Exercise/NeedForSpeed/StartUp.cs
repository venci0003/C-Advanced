using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int horsePower = int.Parse(Console.ReadLine());

            double fuel = double.Parse(Console.ReadLine());

            SportCar nissanSilvia = new SportCar(horsePower, fuel);

            int kilometersToDrive = int.Parse(Console.ReadLine());

            nissanSilvia.Drive(kilometersToDrive);

        }
    }
}
