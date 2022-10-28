using System;

namespace _05._Date_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateModifier data = new DateModifier();

            string firstData = Console.ReadLine();

            string secondData = Console.ReadLine();

            var result = data.CalculateDifferenceBetweenTwoData(firstData, secondData);

            int finalResult = int.Parse(result);

            Console.WriteLine(Math.Abs(finalResult));
        }
    }
}
