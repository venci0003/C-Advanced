using System;

namespace FootballTeam
{
    public class FootballPlayer
    {
        private string name;
        private int playerNumber;
        private string position;
        private int scoredGoals;

        public FootballPlayer(string name, int playerNumber, string position)
        {
            Name = name;
            PlayerNumber = playerNumber;
            Position = position;
            this.scoredGoals = 0;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }
                name = value;
            }
        }

        public int PlayerNumber
        {
            get => playerNumber;
            private set
            {
                if (value < 1 || value > 21)
                {
                    throw new ArgumentException("Player number must be in range [1,21]");
                }
                playerNumber = value;
            }
        }

        public string Position
        {
            get => position;
            private set
            {
                if (value != "Goalkeeper" && value != "Midfielder" && value != "Forward")
                {
                    throw new ArgumentException("Invalid Position");
                }
                position = value;
            }
        }

        public int ScoredGoals => scoredGoals;

        public void Score()
        {
            this.scoredGoals++;
        }
    }
}
