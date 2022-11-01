using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestInformation = new Dictionary<string, string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of contests")
                {
                    break;
                }
                string[] tokens = command.Split(":");
                string contest = tokens[0];
                string passwordForContest = tokens[1];
                if (!contestInformation.ContainsKey(contest))
                {
                    contestInformation[contest] = passwordForContest;
                }
            }
            Dictionary<string, List<UserNameProperties>> usernameInformation = new Dictionary<string, List<UserNameProperties>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of submissions")
                {
                    break;
                }
                string[] tokens = command.Split("=>");
                string currentContest = tokens[0];
                string passwordForContest = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);
                if (contestInformation.ContainsKey(currentContest))
                {
                    if (contestInformation[currentContest] == passwordForContest)
                    {
                        UserNameProperties currentProperties = new UserNameProperties(currentContest, points);
                        if (!usernameInformation.ContainsKey(username))
                        {
                            usernameInformation[username] = new List<UserNameProperties>();
                            usernameInformation[username].Add(currentProperties);
                        }
                        else if (usernameInformation[username].Any(x => x.Contest == currentContest))
                        {
                            UserNameProperties currentUserNameProperties = usernameInformation[username].FirstOrDefault(x => x.Contest == currentContest);
                            if (currentUserNameProperties != null)
                            {
                                if (currentUserNameProperties.Points < points)
                                {
                                    currentUserNameProperties.Points = points;
                                }
                            }
                        }
                        else
                        {
                            usernameInformation[username].Add(currentProperties);
                        }
                    }
                }
            }
            FindBestScore(usernameInformation);
            RankList(usernameInformation);
        }

        static void RankList(Dictionary<string, List<UserNameProperties>> usernameInformation)
        {
            Console.WriteLine("Ranking: ");
            foreach (KeyValuePair<string, List<UserNameProperties>> username in usernameInformation.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{username.Key}");
                foreach (UserNameProperties points in username.Value.OrderByDescending(x => x.Points))
                {
                    Console.WriteLine($"#  {points.Contest} -> {points.Points}");
                }
            }
        }

        static void FindBestScore(Dictionary<string, List<UserNameProperties>> usernameInformation)
        {
            int sum = 0;
            int max = int.MinValue;
            string bestUsername = string.Empty;
            foreach (KeyValuePair<string, List<UserNameProperties>> username in usernameInformation)
            {
                foreach (UserNameProperties points in username.Value)
                {
                    sum += points.Points;
                }
                if (sum > max)
                {
                    max = sum;
                    bestUsername = username.Key;
                }
                sum = 0;
            }
            Console.WriteLine($"Best candidate is {bestUsername} with total {max} points.");
        }
    }
    class UserNameProperties
    {
        public UserNameProperties(string contest, int points)
        {
            this.Contest = contest;
            this.Points = points;
        }

        public string Contest { get; set; }
        public int Points { get; set; }
    }
}
