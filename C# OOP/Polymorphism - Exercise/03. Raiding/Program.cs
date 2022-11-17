using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroParty = new List<BaseHero>();

            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                string name = Console.ReadLine();

                string classType = Console.ReadLine();

                try
                {
                    if (classType == "Druid")
                    {
                        BaseHero hero = new Druid(name);

                        heroParty.Add(hero);
                    }
                    else if (classType == "Paladin")
                    {
                        BaseHero hero = new Paladin(name);

                        heroParty.Add(hero);
                    }
                    else if (classType == "Rogue")
                    {
                        BaseHero hero = new Rogue(name);

                        heroParty.Add(hero);
                    }
                    else if (classType == "Warrior")
                    {
                        BaseHero hero = new Warrior(name);

                        heroParty.Add(hero);
                    }
                    else
                    {
                        i--;
                        throw new FormatException("Invalid hero!");
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            int partyPower = 0;

            int bossHealth = int.Parse(Console.ReadLine());

            foreach (BaseHero hero in heroParty)
            {
                Console.WriteLine(hero.CastAbility());
                partyPower += hero.Power;
            }

            if (partyPower >= bossHealth)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
