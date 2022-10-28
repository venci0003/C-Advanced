using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<Trainer> trainers = new List<Trainer>();

            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];

                string pokemonNmae = tokens[1];

                string pokemonElement = tokens[2];

                int pokemonHealth = int.Parse(tokens[3]);

                if (!trainers.Any(x => x.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName, 0);

                    trainers.Add(trainer);

                }
                Pokemon pokemon = new Pokemon(pokemonNmae, pokemonElement, pokemonHealth);

                Trainer trainerToFind = trainers.Find(x => x.Name == trainerName);

                trainerToFind.AddPokemon(pokemon);
            }
            string secondCommand;

            while ((secondCommand = Console.ReadLine()) != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    Trainer currentTrainer = trainers[i];

                    currentTrainer.CheckForPokemonsWithGivenElement(secondCommand, currentTrainer);
                }
            }
            PrintResult(trainers);
        }

        static void PrintResult(List<Trainer> trainers)
        {
            foreach (Trainer trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
            }
        }
    }
}
