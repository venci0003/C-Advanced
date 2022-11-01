using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DarkKnight playerClass = new DarkKnight("DustCollector",100);
            Console.WriteLine(playerClass);
        }
    }
}
