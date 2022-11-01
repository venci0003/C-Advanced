using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> participantsPoints = new SortedDictionary<string, int>();
            SortedDictionary<string, int> languagesSubmissions = new SortedDictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }
                string[] command = input.Split("-");
                if (command[1] == "banned")
                {
                    participantsPoints.Remove(command[0]);
                    continue;
                }

                string username = command[0];
                string language = command[1];
                int points = int.Parse(command[2]);

                if (!participantsPoints.ContainsKey(username))
                {
                    participantsPoints.Add(username, points);
                }

                if (participantsPoints[username] < points)
                {
                    participantsPoints[username] = points;
                }

                if (!languagesSubmissions.ContainsKey(language))
                {
                    languagesSubmissions.Add(language, 0);
                }

                languagesSubmissions[language]++;
            }
            Console.WriteLine("Results:");
            foreach (KeyValuePair<string, int> userInformation in participantsPoints.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{userInformation.Key} | {userInformation.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (KeyValuePair<string, int> submissionInformation in languagesSubmissions.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{submissionInformation.Key} - {submissionInformation.Value}");
            }
        }
    }
}
