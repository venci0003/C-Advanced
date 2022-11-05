using System;

namespace _03._Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] urlAdresses = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string currentPhoneNumber = phoneNumbers[i];

                if (currentPhoneNumber.Length == 10)
                {
                    Smartphone smartphone = new Smartphone();
                    Console.WriteLine($"{smartphone.Call(currentPhoneNumber)}");
                }
                else if (currentPhoneNumber.Length == 7)
                {
                    StationaryPhone stationaryPhone = new StationaryPhone();
                    Console.WriteLine($"{stationaryPhone.Dial(currentPhoneNumber)}");
                }
            }

            for (int i = 0; i < urlAdresses.Length; i++)
            {
                string currentUrlAdress = urlAdresses[i];
                Smartphone smartphone = new Smartphone();
                Console.WriteLine($"{smartphone.Browse(currentUrlAdress)}");
            }
        }
    }
}
