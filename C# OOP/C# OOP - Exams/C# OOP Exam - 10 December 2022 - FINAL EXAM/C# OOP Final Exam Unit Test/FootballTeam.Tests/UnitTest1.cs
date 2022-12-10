using NUnit.Framework;
using System;

namespace FootballTeam.Tests
{
    public class Tests
    {
        private FootballPlayer player;

        private FootballTeam team;

        [SetUp]
        public void Setup()
        {
            player = new FootballPlayer("Berbatov", 12, "Forward");

            team = new FootballTeam("Litex", 16);
        }

        [Test]
        public void Test_If_Player_Constructor_Works()
        {
            Assert.AreEqual("Berbatov", player.Name);

            Assert.AreEqual(12, player.PlayerNumber);

            Assert.AreEqual("Forward", player.Position);

            Assert.AreEqual(0, player.ScoredGoals);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_If_Player_Name_Exception_Works(string name)
        {
            Assert.Throws<ArgumentException>(() => 
            
            player = new FootballPlayer(name, 12, "Forward"));
        }

        [TestCase(-1)]
        [TestCase(40)]
        [TestCase(1000)]
        public void Test_If_Player_Number_Exception_Works(int number)
        {
            Assert.Throws<ArgumentException>(() => 
            
            player = new FootballPlayer("Berbatov", number, "Forward"));
        }
        [TestCase("Watcher")]
        [TestCase("Back")]
        [TestCase("Winger")]
        public void Test_If_Player_Position_Exception_Works(string value)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                player = new FootballPlayer("Berbatov", 12, value);
            });
        }
        [Test]
        public void Test_If_Positions_Are_Valid()
        {
            player = new FootballPlayer("Berbatov", 12, "Midfielder");

            Assert.AreEqual("Berbatov", player.Name);

            Assert.AreEqual(12, player.PlayerNumber);

            Assert.AreEqual("Midfielder", player.Position);

            Assert.AreEqual(0, player.ScoredGoals);
        }


        [Test]
        public void Test_If_Player_ScoreGoalsMethod_Works()
        {
            player.Score();

            Assert.AreEqual(1, player.ScoredGoals);
        }

        [Test]
        public void Test_If_Team_Constructor_Works()
        {
            Assert.AreEqual("Litex", team.Name);

            Assert.AreEqual(16, team.Capacity);

            Assert.IsNotNull(team.Players);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_If_Team_Exception_Works_With_Invalid_Name(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            
            team = new FootballTeam(name, 20));
        }


        [Test]
        public void Test_If_Team_AddMethod_Works()
        {
            for (int i = 1; i <= 16; i++)
            {
                string name = string.Format($"Berbatov{i}");

                team.AddNewPlayer(new FootballPlayer(name, 10, "Forward"));
            }

            string expectedMessage = string.Format("No more positions available!");

            Assert.AreEqual(expectedMessage, team.AddNewPlayer(player));
        }

        [TestCase(12)]
        [TestCase(13)]
        [TestCase(-1)]
        public void Test_If_Team_ExceptionsWork(int capacity)
        {
            Assert.Throws<ArgumentException>(() => team = new FootballTeam("Litex", capacity));
        }

        [Test]
        public void Test_If_Team_AddPlayer_Method_Works()
        {
            string expectedMessage = string.Format($"Added player {player.Name} in position {player.Position} with number {player.PlayerNumber}");

            Assert.AreEqual(expectedMessage, team.AddNewPlayer(player));
        }

        [Test]
        public void Test_Team_PlayerScore_Method()
        {
            team.AddNewPlayer(player);

            string expectedMessage =
                string.Format($"{player.Name} scored and now has {player.ScoredGoals + 1} for this season!");

            Assert.AreEqual(expectedMessage, team.PlayerScore(12));
        }

        [Test]
        public void Test_If_Team_PickUpPlayer_Method_Works()
        {
            team.AddNewPlayer(player);

            FootballPlayer expectedPlayer = team.PickPlayer("Berbatov");

            Assert.AreSame(expectedPlayer, player);
        }

        [Test]
        public void Test_If_Team_Exception_Works_With_PickUpPlayer_Null()
        {
            team.AddNewPlayer(player);

            Assert.AreEqual(null, team.PickPlayer("Ceci"));
        }
    }
}