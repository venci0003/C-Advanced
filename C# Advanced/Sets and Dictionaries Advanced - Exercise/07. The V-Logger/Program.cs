using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vlogger> vloggers = new List<Vlogger>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Statistics")
                {
                    break;
                }

                string vloggerName = command[0];
                string action = command[1];
                string vloggerToFollowName  = command[2];

                if (action == "joined")
                {
                    if (!vloggers.Any(v => v.Name == vloggerName))
                    {
                        vloggers.Add(new Vlogger(vloggerName));
                    }
                }
                else
                {
                    if (vloggerName == vloggerToFollowName
                        || !vloggers.Any(v => v.Name == vloggerName)
                        || !vloggers.Any(v => v.Name == vloggerToFollowName))
                    {
                        continue;
                    }

                    Vlogger vlogger = vloggers.Single(v => v.Name == vloggerName);
                    vlogger.Following.Add(vloggerToFollowName);

                    Vlogger vloggerToFollow = vloggers.Single(v => v.Name == vloggerToFollowName);
                    vloggerToFollow.Followers.Add(vloggerName);
                }
            }
            vloggers = vloggers.OrderByDescending(v => v.Followers.Count).ThenBy(v => v.Following.Count).ToList();
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            
            int count = 1;
            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
                if (count == 1)
                {
                    foreach (var follower in vlogger.Followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
    public class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new SortedSet<string>();
            Following = new HashSet<string>();
        }
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
    }
}
