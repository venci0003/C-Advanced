using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int forLoopsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGradeInformation = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < forLoopsCount; i++)
            {
                string[] information = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string nameOfStudent = information[0];
                decimal gradeOfStudent = decimal.Parse(information[1]);

                if (!studentsGradeInformation.ContainsKey(nameOfStudent))
                {
                    studentsGradeInformation[nameOfStudent] = new List<decimal>();
                    studentsGradeInformation[nameOfStudent].Add(gradeOfStudent);
                }
                else
                {
                    studentsGradeInformation[nameOfStudent].Add(gradeOfStudent);
                }
            }

            foreach (var studentInformation in studentsGradeInformation)
            {
                Console.WriteLine($"{studentInformation.Key} -> {(string.Join(" ",studentInformation.Value.Select(x => $"{x:f2}")))} (avg: {(studentInformation.Value).Average():f2})");
            }
        }
    }
}
