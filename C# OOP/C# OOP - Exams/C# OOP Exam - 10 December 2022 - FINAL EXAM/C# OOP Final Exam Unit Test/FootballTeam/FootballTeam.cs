using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam
{
    public class FootballTeam
    {
        private List<FootballPlayer> players;
        private string name;
        private int capacity;

        public FootballTeam(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.players = new List<FootballPlayer>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public int Capacity
        {
            get => this.capacity;
            set
            {
                if (value < 15)
                {
                    throw new ArgumentException("Capacity min value = 15");
                }
                this.capacity = value;
            }
        }

        public List<FootballPlayer> Players => this.players;

        public string AddNewPlayer(FootballPlayer player)
        {
            if (this.players.Count >= this.Capacity)
            {
                return "No more positions available!";
            }

            this.players.Add(player);
            return $"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}";
        }

        public FootballPlayer PickPlayer(string name) 
            => this.players.FirstOrDefault(p => p.Name == name);

        public string PlayerScore(int playerNumber)
        {
            FootballPlayer player = this.Players.FirstOrDefault(p => p.PlayerNumber == playerNumber);
            player.Score();

            return $"{player.Name} scored and now has {player.ScoredGoals} for this season!";
        }
    }
}
