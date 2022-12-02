using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters($"Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
