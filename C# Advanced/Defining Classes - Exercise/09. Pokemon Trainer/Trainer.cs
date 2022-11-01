using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Pokemon_Trainer
{
    public class Trainer
    {
        public Trainer(string name, int numberOfBadges)
        {
            this.Name = name;
            this.NumberOfBadges = numberOfBadges;
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> PokemonCollection { get; set; } = new List<Pokemon>();
        public void AddPokemon(Pokemon pokemon)
        {
            this.PokemonCollection.Add(pokemon);
        }
        public void CheckForPokemonsWithGivenElement(string element, Trainer currentTrainer)
        {
            int countMatchedPokemons = 0;
            for (int i = 0; i < currentTrainer.PokemonCollection.Count; i++)
            {
                Pokemon currentPokemon = this.PokemonCollection[i];
                if (currentPokemon.Element != element)
                {
                    continue;
                }
                else
                {
                    countMatchedPokemons++;
                    currentTrainer.NumberOfBadges += 1;
                    return;
                }
            }
            if (countMatchedPokemons == 0)
            {
                for (int i = 0; i < currentTrainer.PokemonCollection.Count; i++)
                {
                    Pokemon currentPokemon = PokemonCollection[i];
                    currentPokemon.Health -= 10;
                    if (currentPokemon.Health <= 0)
                    {
                        PokemonCollection.Remove(currentPokemon);
                    }
                }
            }
        }
    }
}
