using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mealsnInfo = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            Queue<string> meals = new Queue<string>(mealsnInfo);

            var caloriesInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Stack<int> calories = new Stack<int>(caloriesInfo);

            Dictionary<string, int> mealsDict = new Dictionary<string, int>()
            {
                {"salad", 350 },
                {"soup", 490 },
                {"pasta", 680 },
                {"steak", 790 },
            };

            int eatenMeals = 0;

            while (meals.Any() && calories.Any())
            {
                int dailyCals = calories.Pop();

                while (meals.Any() && dailyCals > 0)
                {
                    string currMeal = meals.Dequeue();
                    dailyCals -= mealsDict[currMeal];
                    eatenMeals++;
                }


                if (dailyCals == 0)
                {
                    dailyCals = 0;
                }
                else if (dailyCals < 0)
                {
                    if (calories.Any())
                    {
                        var nextDayCals = calories.Pop() + dailyCals;

                        calories.Push(nextDayCals);
                    }
                }
                if (!meals.Any() && dailyCals > 0)
                {
                    calories.Push(dailyCals);
                }
            }


            PrintOutput(calories, meals, eatenMeals);

        }

        public static void PrintOutput(Stack<int> calories, Queue<string> meals, int eatenMeals)
        {
            if (!meals.Any())
            {
                Console.WriteLine($"John had {eatenMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calories)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {eatenMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
